using System.Runtime.CompilerServices;
using FlashyDJ.Slotmaps;

namespace RandMeldHeap;

public class RandomizedMeldableHeap<T> where T : IComparable<T>
{
    public readonly record struct HeapKey(int Index, uint Version) : ISlotKey<HeapKey>
    {
        public bool IsNull => Index < 0 || Version == 0;
        public static HeapKey New(int index, uint version) => new(index, version);
        public static HeapKey Null() => new(int.MinValue, 0);
    }

    public readonly record struct NodeHandle(HeapKey Handle)
    {
        public static implicit operator HeapKey(NodeHandle nodeHandle) => nodeHandle.Handle;
    }

    private struct Node(T value, HeapKey children1, HeapKey children2, HeapKey parent)
    {
        public Node(T value) : this(value, HeapKey.Null(), HeapKey.Null(), HeapKey.Null()) { }
        public T Value = value;
        public HeapKey[] Children = [children1, children2];
        public HeapKey Parent = parent;
    }

    private readonly SlotMap<HeapKey, Node> _slots = new();
    private readonly Random _rng = new();
    private HeapKey _root = HeapKey.Null();

    public int Count => _slots.Count;

    public NodeHandle Insert(T value)
    {
        var key = _slots.Insert(new(value));
        _root = Meld(key, _root);
        return new(key);
    }

    public T Pop()
    {
        var root = _slots.Remove(_root);
        _root = Meld(root.Children[0], root.Children[1]);

        if (_slots.ContainsKey(_root))
            _slots[_root].Parent = HeapKey.Null();

        return root.Value;
    }

    public T RemoveKey(NodeHandle node)
    {
        UnlinkNode(node);
        return _slots.Remove(node).Value;
    }

    public void UpdateKey(NodeHandle node, T value)
    {
        UnlinkNode(node);
        _slots[node] = new(value);
        _root = Meld(node, _root);
    }

    private void LinkParentAndChild(HeapKey parent, HeapKey child, int childIndex)
    {
        _slots[parent].Children[childIndex] = child;
        _slots[child].Parent = parent;
    }

    private HeapKey Meld(HeapKey key1, HeapKey key2)
    {
        if (key1.IsNull) return key2;

        if (key2.IsNull) return key1;

        if (ShouldSwapNodes(key1, key2))
            (key1, key2) = (key2, key1);

        var ret = key1;

        var parent = key1;
        var trickle = key2;

        while (true)
        {
            var children = _slots[parent].Children;
            if (children[0].IsNull)
            {
                LinkParentAndChild(parent, trickle, 0);
                break;
            }
            else if (children[1].IsNull)
            {
                LinkParentAndChild(parent, trickle, 1);
                break;
            }

            var index = _rng.Next(1);
            var child = children[index];
            if (ShouldSwapNodes(child, trickle))
            {
                LinkParentAndChild(parent, trickle, index);
                (parent, trickle) = (trickle, child);
            }
            else
                parent = child;
        }

        return ret;
    }

    private bool ShouldSwapNodes(HeapKey firstNode, HeapKey secondNode) =>
        _slots[firstNode].Value.CompareTo(_slots[secondNode].Value) > 0;

    private void UnlinkNode(HeapKey node)
    {
        var children = _slots[node].Children;
        var parentKey = _slots[node].Parent;
        var meldedChildren = Meld(children[0], children[1]);

        if (_slots.ContainsKey(meldedChildren))
            _slots[meldedChildren].Parent = parentKey;

        ref var parent = ref _slots.GetRefOrNullRef(parentKey);
        if (!Unsafe.IsNullRef(ref parent))
        {
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
