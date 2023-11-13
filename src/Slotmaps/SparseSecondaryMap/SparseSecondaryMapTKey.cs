using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FlashyDJ.Slotmaps;
/// <include file='docs.xml' path='docs/SparseSecondaryMap/*'/>
[Serializable]
[DebuggerDisplay("Count = {Count}")]
public partial class SparseSecondaryMap<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>
    where TKey : struct, ISlotKey<TKey>
{
    private readonly Dictionary<int, Slot> _slots;
    private SlotKeyCollection? _keys;
    private SlotValueCollection? _values;

    /// <include file='docs.xml' path='docs/Ctor1/*'/>
    public SparseSecondaryMap() => _slots = new(0);

    /// <include file='docs.xml' path='docs/Ctor2/*'/>
    public SparseSecondaryMap(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);
        _slots = new(capacity);
    }

    bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

    void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item) =>
        Insert(item.Key, item.Value);

    bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item) =>
        ContainsKey(item.Key) && (EqualityComparer<TValue>.Default.Equals(Get(item.Key), item.Value));

    void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
    {
        ArgumentNullException.ThrowIfNull(array);
        ArgumentOutOfRangeException.ThrowIfNegative(index);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
        ArgumentOutOfRangeException.ThrowIfLessThan(Count, array.Length - index);

        foreach (var key in _slots.Keys)
        {
            ref var slot = ref CollectionsMarshal.GetValueRefOrAddDefault(_slots, key, out var _);
            if (slot.Occupied)
                array[index++] = new(TKey.New(key, slot.Version), slot.Value);
        }
    }

    bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item) =>
        ContainsKey(item.Key)
        && (EqualityComparer<TValue>.Default.Equals(Get(item.Key), item.Value)
        && TryRemove(item.Key, out var _));

    IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() =>
        new Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

    /// <include file='docs.xml' path='docs/Capacity/*'/>
    public int Capacity => _slots.EnsureCapacity(0);

    /// <include file='docs.xml' path='docs/Count/*'/>
    public int Count { get; private set; }

    /// <include file='docs.xml' path='docs/IsEmpty/*'/>
    public bool IsEmpty => Count == 0;

    /// <include file='docs.xml' path='docs/Keys/*'/>
    public SlotKeyCollection Keys => _keys ??= new SlotKeyCollection(this);

    /// <include file='docs.xml' path='docs/Values/*'/>
    public SlotValueCollection Values => _values ??= new SlotValueCollection(this);

    /// <include file='docs.xml' path='docs/Indexer/*'/>
    public TValue this[TKey key]
    {
        get
        {
            if (key.IsNull) throw new KeyNotFoundException("Invalid SlotKey");

            var exists = _slots.TryGetValue(key.Index, out var slot);
            if (!exists || slot.Version != key.Version)
                throw new KeyNotFoundException("Invalid SlotKey");

            return slot.Value;
        }
        set => Insert(key, value);
    }

    /// <include file='docs.xml' path='docs/ContainsKey/*'/>
    public bool ContainsKey(TKey key)
    {
        if (key.IsNull && key.Version < 1)
            return false;

        ref var slot = ref CollectionsMarshal.GetValueRefOrAddDefault(_slots, key.Index, out var exists);
        return exists && slot.Occupied && slot.Version == key.Version;
    }

    /// <include file='docs.xml' path='docs/ContainsValue/*'/>
    public bool ContainsValue(TValue value) =>
        _slots.Where(x => EqualityComparer<TValue>.Default.Equals(x.Value.Value, value)).Any();

    /// <include file='docs.xml' path='docs/Clear/*'/>
    public void Clear()
    {
        if (Count > 0)
        {
            _slots.Clear();
            Count = 0;
        }
    }

    /// <include file='docs.xml' path='docs/Drain/*'/>
    public IEnumerable<KeyValuePair<TKey, TValue>> Drain()
    {
        foreach (var slot in _slots)
        {
            if (slot.Value.Occupied)
            {
                var key = TKey.New(slot.Key, slot.Value.Version);
                var value = slot.Value.Value;

                Remove(key);
                yield return new(key, value);
            }
        }
    }

    /// <include file='docs.xml' path='docs/EnsureCapacity/*'/>
    public int EnsureCapacity(int capacity) => _slots.EnsureCapacity(capacity);

    /// <include file='docs.xml' path='docs/Get/*'/>
    public TValue Get(TKey key)
    {
        if (key.IsNull && key.Version == 0)
            throw new KeyNotFoundException("Invalid SlotKey");

        var exists = _slots.TryGetValue(key.Index, out var slot);

        if (!exists || slot.Version != key.Version || !slot.Occupied)
            throw new KeyNotFoundException("Invalid SlotKey");

        return slot.Value;
    }

    /// <include file='docs.xml' path='docs/Insert/*'/>
    public TValue Insert(TKey key, TValue value)
    {
        if (key.IsNull && key.Version == 0)
            throw new KeyNotFoundException("Invalid SlotKey");

        ref var slot = ref CollectionsMarshal.GetValueRefOrAddDefault(_slots, key.Index, out var exists);

        if (exists && slot.Occupied)
        {
            if (key.Version < slot.Version)
                throw new KeyNotFoundException("SlotKey is an older version");

            var replacedValue = slot.Value;

            slot.Value = value;
            slot.Version = key.Version;
            return replacedValue;
        }
        else
            Count++;

        slot.Value = value;
        slot.Version = key.Version;
        slot.Vacant = false;
        return value;
    }

    /// <include file='docs.xml' path='docs/Remove/*'/>
    public TValue Remove(TKey key)
    {
        if (key.IsNull && key.Version == 0)
            throw new KeyNotFoundException("Invalid SlotKey");

        ref var slot = ref CollectionsMarshal.GetValueRefOrNullRef(_slots, key.Index);
        
        if (!Unsafe.IsNullRef(ref slot))
        {
            if (slot.Version == key.Version)
            {
                var value = slot.Value;
                slot.Vacant = true;
                Count--;
                return value;
            }
        }

        throw new KeyNotFoundException("Invalid SlotKey");
    }

    /// <include file='docs.xml' path='docs/Retain/*'/>
    public void Retain(Func<TKey, TValue, bool> predicate)
    {
        foreach(var key in _slots.Keys)
        {
            ref var slot = ref CollectionsMarshal.GetValueRefOrNullRef(_slots, key);

            if (!Unsafe.IsNullRef(ref slot) && slot.Occupied)
            {
                var slotKey = TKey.New(key, slot.Version);
                var value = slot.Value;

                if (!predicate(slotKey, value!))
                    Remove(slotKey);
            }
        }
    }

    /// <include file='docs.xml' path='docs/TryGet/*'/>
    public bool TryGet(TKey key, [MaybeNullWhen(false)] out TValue value)
    {
        value = default;

        if (key.IsNull && key.Version == 0)
            return false;

        var exists = _slots.TryGetValue(key.Index, out var slot);
        if (!exists || slot.Version != key.Version || !slot.Occupied)
            return false;

        value = slot.Value;
        return true;
    }

    /// <include file='docs.xml' path='docs/TryInsert/*'/>
    public bool TryInsert(TKey key, TValue value, [MaybeNullWhen(false)] out TValue previousValue)
    {
        previousValue = default;

        if (key.IsNull && key.Version == 0)
            return false;

        ref var slot = ref CollectionsMarshal.GetValueRefOrAddDefault(_slots, key.Index, out var exists);

        if (exists && slot.Occupied)
        {
            if (key.Version < slot.Version)
                return false;

            previousValue = slot.Value;

            slot.Value = value;
            slot.Version = key.Version;
            return true;
        }
        else
            Count++;

        slot.Value = value;
        slot.Version = key.Version;
        slot.Vacant = false;
        previousValue = value;
        return true;
    }

    /// <include file='docs.xml' path='docs/TryRemove/*'/>
    public bool TryRemove(TKey key, [MaybeNullWhen(false)] out TValue value)
    {
        value = default;

        if (key.IsNull && key.Version == 0)
            return false;

        ref var slot = ref CollectionsMarshal.GetValueRefOrNullRef(_slots, key.Index);
        
        if (!Unsafe.IsNullRef(ref slot))
        {
            if (slot.Version == key.Version)
            {
                value = slot.Value;
                slot.Vacant = true;
                Count--;
                return true;
            }
        }

        return false;
    }

    /// <include file='docs.xml' path='docs/Enumerator/*'/>
    public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator
    {
        private readonly SparseSecondaryMap<TKey, TValue> _sparseMap;
        private readonly IEnumerator<KeyValuePair<int, Slot>> _dictEnumerator;

        internal Enumerator(SparseSecondaryMap<TKey, TValue> sparseMap)
        {
            _sparseMap = sparseMap;
            _dictEnumerator = _sparseMap._slots.GetEnumerator();
            Current = default;
        }

        /// <inheritdoc/>
        public KeyValuePair<TKey, TValue> Current { get; private set; }

        object IEnumerator.Current => Current;

        /// <inheritdoc/>
        public readonly void Dispose() { }

        /// <inheritdoc/>
        public bool MoveNext()
        {
            while (_dictEnumerator.MoveNext())
            {
                var kvp = _dictEnumerator.Current;

                if (!kvp.Value.Occupied)
                    continue;

                Current = new(TKey.New(kvp.Key, kvp.Value.Version), kvp.Value.Value);
                return true;
            }
            return false;
        }

        /// <inheritdoc/>
        public void Reset()
        {
            Current = default;
        }
    }
}

