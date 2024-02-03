using FlashyDJ.Slotmaps;

namespace RandMeldHeap;

public class RandMeldHeap<T> where T : IComparable<T>
{
    public readonly record struct NodeHandle(HeapKey Handle)
    {
        public static implicit operator HeapKey(NodeHandle nodeHandle) => nodeHandle.Handle;
    }

    private struct Node(T value, HeapKey children1, HeapKey children2, HeapKey parent)
    {
        public T Value { get; set; } = value;
        public HeapKey[] Children { get; set; } = [children1, children2];
        public HeapKey Parent { get; set; } = parent;

        public Node(T value) : this(value, HeapKey.Null(), HeapKey.Null(), HeapKey.Null()) { }
    }

    private readonly SlotMap<HeapKey, Node> _slots = new();
    private uint _rng = 0xdead_beef;
    private HeapKey _root = HeapKey.Null();

    public int Count => _slots.Count;

    public NodeHandle Insert(T value)
    {
        var key = _slots.Insert(new(value));

        var root = _root;


        return new(key);
    }

    public T Pop()
    {
        if (_slots.TryRemove(_root, out var root))
        {
            _root = Meld(root.Children[0], root.Children[1]);
            if (_slots.TryGet(_root, out var newRoot))
            {
                newRoot.Parent = HeapKey.Null();
            }
            return root.Value;
        }
        else
        {
            throw new InvalidOperationException("Heap is empty");
        }
    }

    public T RemoveKey(NodeHandle node)
    {
        UnlinkNode(node);
        return _slots.TryRemove(node, out var nodeValue) ? nodeValue.Value 
                                                         : throw new KeyNotFoundException("Invalid key");
    }

    public void UpdateKey(NodeHandle node, T value)
    {
        UnlinkNode(node);

        _slots[node] = new(value);

        var root = _root;
        _root = Meld(node, root);
    }

    private bool CoinFlip()
    {
        _rng += (_rng << 8) + 1;
        return (_rng >> 31) > 0;
    }

    private HeapKey Meld(HeapKey key1, HeapKey key2)
    {
        if (key1.IsNull) return key2;

        if (key2.IsNull) return key1;

        if (_slots[key1].Value.CompareTo(_slots[key2].Value) > 0)
            (key1, key2) = (key2, key1);

        var ret = key1;

        var parent = key1;
        var trickle = key2;

        while (true)
        {
            var children = _slots[parent].Children;

            if (children[0].IsNull)
            {
                _slots[parent].Children[0] = trickle;

                // Should be _slots[trickle].Parent = parent;
                var trk = _slots[trickle];
                trk.Parent = parent;
                _slots[trickle] = trk;
                break;
            }
            else if (children[1].IsNull)
            {
                _slots[parent].Children[1] = trickle;
                var trk = _slots[trickle];
                trk.Parent = parent;
                _slots[trickle] = trk;
            }

            var coin = CoinFlip() ? 0 : 1;
            var child = children[coin];
            if (_slots[child].Value.CompareTo(_slots[trickle].Value) > 0)
            {
                _slots[parent].Children[coin] = trickle;

                var trk = _slots[trickle];
                trk.Parent = parent;
                _slots[trickle] = trk;

                parent = trickle;
                trickle = child;
            }
            else
                parent = child;
        }

        return ret;
    }

    private void UnlinkNode(HeapKey node)
    {
        var children = _slots[node].Children;
        var parentKey = _slots[node].Parent;

        var meldedChildren = Meld(children[0], children[1]);

        if (_slots.TryGet(meldedChildren, out var mc))
        {
            // Should be reference
            mc.Parent = parentKey;
            _slots[meldedChildren] = mc;
        }

        if (_slots.TryGet(parentKey, out var parent))
        {
            // Should be reference
            if (parent.Children[0] == node)
                parent.Children[0] = meldedChildren;
            else
                parent.Children[1] = meldedChildren;

            _slots[parentKey] = parent;
        }
        else
            _root = meldedChildren;
    }
}
