namespace FlashyDJ.Slotmaps;
/// <include file='docs.xml' path="docs/SlotMap/*"/>
[Serializable]
[DebuggerDisplay("Count = {Count}")]
public partial class SlotMap<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>
    where TKey : struct, ISlotKey<TKey>
{
    private const int DefaultCapacity = 4;

#pragma warning disable CA1825 // avoid the extra generic instantiation for Array.Empty<T>()
    private static readonly Slot[] s_emptyArray = new Slot[0];
#pragma warning restore CA1825

    private Slot[] _slots;
    private int _freeHead;
    private SlotKeyCollection? _keys;
    private SlotValueCollection? _values;

    /// <include file='docs.xml' path="docs/Ctor1/*"/>
    public SlotMap() => _slots = s_emptyArray;

    /// <include file='docs.xml' path="docs/Ctor2/*"/>
    public SlotMap(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);

        if (capacity == 0)
            _slots = s_emptyArray;
        else
            _slots = new Slot[capacity];
    }

    void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item) =>
        Insert(item.Key, item.Value);

    bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item) =>
        ContainsKey(item.Key) && ContainsValue(item.Value);

    void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
    {
        ArgumentNullException.ThrowIfNull(array);
        ArgumentOutOfRangeException.ThrowIfNegative(index);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
        ArgumentOutOfRangeException.ThrowIfLessThan(Count, array.Length - index);

        for (int i = 0; i < Capacity; i++)
        {
            var slot = _slots[i];

            if (slot.Occupied)
                array[index++] = new(TKey.New(i, slot.Version), slot.Value);
        }
    }

    bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
    {
        if (ContainsKey(item.Key) && ContainsValue(item.Value))
        {
            Remove(item.Key);
            return true;
        }
            
        return false;
    }

    IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() =>
        new Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

    bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

    /// <include file='docs.xml' path="docs/Capacity/*"/>
    public int Capacity => _slots.Length;

    /// <include file='docs.xml' path="docs/Count/*"/>
    public int Count { get; private set; }

    /// <include file='docs.xml' path="docs/IsEmpty/*"/>
    public bool IsEmpty => Count == 0;

    /// <include file='docs.xml' path="docs/Keys/*"/>
    public SlotKeyCollection Keys => _keys ??= new SlotKeyCollection(this);

    /// <include file='docs.xml' path="docs/Values/*"/>
    public SlotValueCollection Values => _values ??= new SlotValueCollection(this);

    /// <include file='docs.xml' path="docs/Indexer/*"/>
    public TValue this[TKey key]
    {
        get
        {
            if (!ContainsKey(key))
                throw new KeyNotFoundException("Invalid SlotKey");

            return _slots[key.Index].Value;
        }
        set => Insert(key, value);
    }

    /// <include file='docs.xml' path="docs/Add/*"/>
    public TKey Add(TValue value)
    {
        ArgumentNullException.ThrowIfNull(value);
        var newCount = Count + 1;

        if (_freeHead <= Capacity - 1)
        {
            ref var slot = ref _slots[_freeHead];

            if (!slot.Occupied)
            {
                var occupiedVersion = slot.Version + 1;
                var updatedkey = TKey.New(_freeHead, occupiedVersion);

                _freeHead = slot.NextFree;
                slot.Value = value;
                slot.Version = occupiedVersion;

                Count = newCount;
                return updatedkey;
            }
        }

        if (newCount > Capacity)
            Reserve(Capacity == 0 ? DefaultCapacity : Capacity);

        int newIndex = newCount - 1;

        ref var newSlot = ref _slots[newIndex];
        newSlot.Value = value;
        newSlot.Version++;

        _freeHead = newCount;
        Count++;

        return TKey.New(newIndex, newSlot.Version);
    }

    /// <include file='docs.xml' path="docs/ContainsKey/*"/>
    public bool ContainsKey(TKey key)
    {
        if (key.Index >= 0 && key.Index < _slots.Length)
        {
            ref var slot = ref _slots[key.Index];
            return slot.Version == key.Version;
        }

        return false;
    }

    /// <include file='docs.xml' path="docs/ContainsValue/*"/>
    public bool ContainsValue(TValue value)
    {
        if (value is null)
            return false;

        for (int i = 0; i < _slots.Length; i++)
        {
            ref var slot = ref _slots[i];
            if (slot.Occupied && EqualityComparer<TValue>.Default.Equals(slot.Value, value))
                return true;
        }

        return false;
    }

    /// <include file='docs.xml' path="docs/Clear/*"/>
    public void Clear()
    {
        if (Count > 0)
        {
            Array.Clear(_slots);

            Count = 0;
            _freeHead = 0;
        }
    }

    /// <include file='docs.xml' path="docs/Drain/*"/>
    public IEnumerable<KeyValuePair<TKey,TValue>> Drain()
    {
        for (int i = 0; i < Capacity; i++)
        {
            if (_slots[i].Occupied)
            {
                var key = TKey.New(i, _slots[i].Version);
                var value = _slots[i].Value;

                Remove(key);

                yield return new(key, value);
            }
        }
    }

    /// <include file='docs.xml' path="docs/EnsureCapacity/*"/>
    public int EnsureCapacity(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);

        if (Capacity >= capacity)
            return Capacity;

        Resize(capacity);

        return capacity;
    }

    /// <include file='docs.xml' path="docs/Get/*"/>
    public TValue Get(TKey key)
    {
        if (!ContainsKey(key))
            throw new KeyNotFoundException("Invalid SlotKey");

        return _slots[key.Index].Value;
    }

    /// <include file='docs.xml' path="docs/Insert/*"/>
    public TKey Insert(TKey key, TValue value)
    {
        ArgumentNullException.ThrowIfNull(value);

        if (!ContainsKey(key))
            throw new KeyNotFoundException("Invalid SlotKey");

        ref var slot = ref _slots[key.Index];
        slot.Value = value;

        if (!slot.Occupied)
        {
            Count++;
            slot.Version++;
        }
        else
        {
            slot.Version += 2;
        }

        return TKey.New(key.Index, slot.Version);
    }

    /// <include file='docs.xml' path="docs/Remove/*"/>
    public TValue Remove(TKey key)
    {
        if (!ContainsKey(key))
            throw new KeyNotFoundException("Invalid SlotKey");

        ref var slot = ref _slots[key.Index];

        var returnValue = slot.Value;
        slot.Value = default;
        slot.NextFree = _freeHead;
        slot.Version++;

        _freeHead = key.Index;
        Count--;

        return returnValue;
    }

    // TODO: Take account of Count
    /// <include file='docs.xml' path="docs/Reserve/*"/>
    public void Reserve(int additionalSize)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(additionalSize);

        Array.Resize(ref _slots, Capacity + additionalSize);
    }

    /// <include file='docs.xml' path="docs/Resize/*"/>
    public void Resize(int newSize)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(newSize, Capacity);

        if (newSize == Capacity)
            return;

        Array.Resize(ref _slots, newSize);
    }

    /// <include file='docs.xml' path="docs/Retain/*"/>
    public void Retain(Func<TKey,TValue, bool> predicate)
    {
        for (int i = 0; i < _slots.Length; i++)
        {
            ref var slot = ref _slots[i];
            
            if (slot.Occupied)
            {
                var key = TKey.New(i, slot.Version);
                var value = slot.Value;

                if (!predicate(key, value))
                    Remove(key);
            }
        }
    }

    /// <include file='docs.xml' path="docs/TryInsert/*"/>
    public bool TryInsert(TKey key, TValue value, out TKey newKey)
    {
        ArgumentNullException.ThrowIfNull(value);

        if (!ContainsKey(key))
        {
            newKey = TKey.Null<TKey>();
            return false;
        }

        ref var slot = ref _slots[key.Index];
        slot.Value = value;

        if (!slot.Occupied)
        {
            slot.Version++;
            Count++;
        }
        else
        {
            slot.Version += 2;
        }

        newKey = TKey.New(key.Index, slot.Version);
        return true;
    }

    /// <include file='docs.xml' path="docs/TryGet/*"/>
    public bool TryGet(TKey key, [MaybeNullWhen(false)] out TValue value)
    {
        if (!ContainsKey(key))
        {
            value = default;
            return false;
        }

        value = _slots[key.Index].Value!;
        return true;
    }

    /// <include file='docs.xml' path="docs/TryRemove/*"/>
    public bool TryRemove(TKey key, [MaybeNullWhen(false)] out TValue value)
    {
        if (!ContainsKey(key))
        {
            value = default;
            return false;
        }

        ref var slot = ref _slots[key.Index];
        value = slot.Value!;

        slot.Value = default;
        slot.NextFree = _freeHead;
        slot.Version++;

        _freeHead = key.Index;
        Count--;

        return true;
    }

    /// <include file='docs.xml' path="docs/Enumerator/*"/>
    public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator
    {
        private readonly SlotMap<TKey, TValue> _slotMap;
        private int _index;
        private KeyValuePair<TKey, TValue> _current;

        internal Enumerator(SlotMap<TKey, TValue> slotMap)
        {
            _slotMap = slotMap;
            _index = -1;
            _current = default;
        }

        /// <inheritdoc/>
        public KeyValuePair<TKey, TValue> Current => _current;

        object IEnumerator.Current => Current;

        /// <inheritdoc/>
        public void Dispose() { }

        /// <inheritdoc/>
        public bool MoveNext()
        {
            while (_index < _slotMap.Capacity)
            {
                while (++_index < _slotMap.Capacity)
                {
                    var slot = _slotMap._slots[_index];

                    if (!slot.Occupied)
                        break;

                    _current = new(TKey.New(_index, slot.Version), slot.Value);
                    return true;
                }
            }
            return false;
        }

        /// <inheritdoc/>
        public void Reset()
        {
            _index = -1;
            _current = default;
        }
    }
}
