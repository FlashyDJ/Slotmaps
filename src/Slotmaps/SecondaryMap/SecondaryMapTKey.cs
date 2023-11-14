namespace FlashyDJ.Slotmaps;
/// <include file='docs.xml' path='docs/SecondaryMap/*'/>
/// <include file='codesnippets.xml' path="code/SecondaryMap/*"/>
[Serializable]
[DebuggerDisplay("Count = {Count}")]
public partial class SecondaryMap<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>
    where TKey : struct, ISlotKey<TKey>
{
#pragma warning disable CA1825 // avoid the extra generic instantiation for Array.Empty<T>()
    private static readonly Slot[] s_emptyArray = new Slot[0];
#pragma warning restore CA1825

    private Slot[] _slots;
    private SlotKeyCollection? _keys;
    private SlotValueCollection? _values;

    /// <include file='docs.xml' path='docs/Ctor1/*'/>
    /// <include file='codesnippets.xml' path='code/Ctor1/*'/>
    public SecondaryMap() => _slots = s_emptyArray;

    /// <include file='docs.xml' path='docs/Ctor2/*'/>
    /// <include file='codesnippets.xml' path='code/Ctor2/*'/>
    public SecondaryMap(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);

        if (capacity == 0)
            _slots = s_emptyArray;
        else
            _slots = new Slot[capacity];
    }

    bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

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

    /// <include file='docs.xml' path='docs/Capacity/*'/>
    /// <include file='codesnippets.xml' path="code/Capacity/*"/>
    public int Capacity => _slots.Length;

    /// <include file='docs.xml' path='docs/Count/*'/>
    /// <include file='codesnippets.xml' path="code/Count/*"/>
    public int Count { get; private set; }

    /// <include file='docs.xml' path='docs/IsEmpty/*'/>
    /// <include file='codesnippets.xml' path="code/IsEmpty/*"/>
    public bool IsEmpty => Count == 0;

    /// <include file='docs.xml' path='docs/Keys/*'/>
    /// <include file='codesnippets.xml' path="code/Keys/*"/>
    public SlotKeyCollection Keys => _keys ??= new SlotKeyCollection(this);

    /// <include file='docs.xml' path='docs/Values/*'/>
    /// <include file='codesnippets.xml' path="code/Values/*"/>
    public SlotValueCollection Values => _values ??= new SlotValueCollection(this);

    /// <include file='docs.xml' path='docs/Indexer/*'/>
    /// <include file='codesnippets.xml' path="code/Indexer/*"/>
    public TValue this[TKey key]
    {
        get
        {
            if (!ContainsKey(key))
                throw new KeyNotFoundException("Invalid TKey");

            return _slots[key.Index].Value;
        }
        set => Insert(key, value);
    }

    /// <include file='docs.xml' path='docs/ContainsKey/*'/>
    /// <include file='codesnippets.xml' path="code/ContainsKey/*"/>
    public bool ContainsKey(TKey key)
    {
        if (key.IsNull)
            return false;

        return _slots.Length > key.Index && _slots[key.Index].Version == key.Version;
    }

    /// <include file='docs.xml' path='docs/ContainsValues/*'/>
    /// <include file='codesnippets.xml' path="code/ContainsValues/*"/>
    public bool ContainsValue(TValue value)
    {
        for (int i = 0; i < _slots.Length; i++)
        {
            ref var slot = ref _slots[i];
            if (slot.Occupied && EqualityComparer<TValue>.Default.Equals(slot.Value, value))
                return true;
        }

        return false;
    }

    /// <include file='docs.xml' path='docs/Clear/*'/>
    /// <include file='codesnippets.xml' path="code/Clear/*"/>
    public void Clear()
    {
        if (Count > 0)
        {
            Array.Clear(_slots);
            Count = 0;
        }
    }

    /// <include file='docs.xml' path='docs/Drain/*'/>
    /// <include file='codesnippets.xml' path="code/Drain/*"/>
    public IEnumerable<KeyValuePair<TKey, TValue>> Drain()
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

    /// <include file='docs.xml' path='docs/EnsureCapacity/*'/>
    /// <include file='codesnippets.xml' path="code/EnsureCapacity/*"/>
    public int EnsureCapacity(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);

        if (Capacity >= capacity)
            return Capacity;

        Resize(capacity);

        return capacity;
    }

    /// <include file='docs.xml' path='docs/Get/*'/>
    /// <include file='codesnippets.xml' path="code/Get/*"/>
    public TValue Get(TKey key)
    {
        if (!ContainsKey(key))
            throw new KeyNotFoundException("Invalid TKey");

        return _slots[key.Index].Value!;
    }

    /// <include file='docs.xml' path='docs/Insert/*'/>
    /// <include file='codesnippets.xml' path="code/Insert/*"/>
    public TValue Insert(TKey key, TValue value)
    {
        if (key.IsNull)
            throw new KeyNotFoundException("Invalid TKey");

        if (Capacity <= key.Index)
            Array.Resize(ref _slots, key.Index + 1);

        ref var slot = ref _slots[key.Index];
        var returnValue = slot.Occupied ? slot.Value : value;

        if (slot.Version == key.Version)
        {
            slot.Value = value;
            return returnValue;
        }

        if (slot.Occupied)
        {
            if (key.Version < slot.Version)
                throw new KeyNotFoundException("Invalid TKey");
        }
        else
            Count++;

        slot.Value = value;
        slot.Version = key.Version;
        return returnValue;
    }

    /// <include file='docs.xml' path='docs/Remove/*'/>
    /// <include file='codesnippets.xml' path="code/Remove/*"/>
    public TValue Remove(TKey key)
    {
        if (key.IsNull)
            throw new KeyNotFoundException("Invalid TKey");

        if (Capacity > key.Index)
        {
            ref var slot = ref _slots[key.Index];
            if (slot.Version == key.Version)
            {
                var value = slot.Value;
                slot.SetVacant();
                Count--;

                return value;
            }
        }

        throw new KeyNotFoundException("Invalid TKey");
    }

    /// <include file='docs.xml' path='docs/Reserve/*'/>
    /// <include file='codesnippets.xml' path="code/Reserve/*"/>
    public void Reserve(int additionalSize)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(additionalSize);
        Array.Resize(ref _slots, Capacity + additionalSize);
    }

    /// <include file='docs.xml' path='docs/Resize/*'/>
    /// <include file='codesnippets.xml' path="code/Resize/*"/>
    public void Resize(int newSize)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(newSize, Capacity);

        if (newSize == Capacity)
            return;

        Array.Resize(ref _slots, newSize);
    }

    /// <include file='docs.xml' path='docs/Retain/*'/>
    /// <include file='codesnippets.xml' path="code/Retain/*"/>
    public void Retain(Func<TKey, TValue, bool> predicate)
    {
        for (int i = 0; i < _slots.Length; i++)
        {
            ref var slot = ref _slots[i];

            if (slot.Occupied)
            {
                var key = TKey.New(i, slot.Version);
                var value = slot.Value;

                if (!predicate(key, value!))
                    Remove(key);
            }
        }
    }

    /// <include file='docs.xml' path='docs/TryGet/*'/>
    /// <include file='codesnippets.xml' path="code/TryGet/*"/>
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

    /// <include file='docs.xml' path='docs/TryInsert/*'/>
    /// <include file='codesnippets.xml' path="code/TryInsert/*"/>
    public bool TryInsert(TKey key, TValue value, [MaybeNullWhen(false)] out TValue oldValue)
    {
        oldValue = default;

        if (key.IsNull)
            return false;

        if (Capacity <= key.Index)
            Array.Resize(ref _slots, key.Index + 1);

        ref var slot = ref _slots[key.Index];

        if (slot.Version == key.Version)
        {
            oldValue = slot.Value;
            slot.Value = value;
            return true;
        }

        if (slot.Occupied)
        {
            if (key.Version < slot.Version)
                return false;
        }
        else
            Count++;

        oldValue = value;
        slot.Value = value;
        slot.Version = key.Version;
        return true;
    }

    /// <include file='docs.xml' path='docs/TryRemove/*'/>
    /// <include file='codesnippets.xml' path="code/TryRemove/*"/>
    public bool TryRemove(TKey key, [MaybeNullWhen(false)] out TValue value)
    {
        value = default;

        if (key.IsNull)
            return false;

        if (Capacity > key.Index)
        {
            ref var slot = ref _slots[key.Index];
            if (slot.Version == key.Version)
            {
                value = slot.Value;
                slot.SetVacant();
                Count--;

                return true;
            }
        }

        return false;
    }

    /// <include file='docs.xml' path='docs/Enumerator/*'/>
    public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator
    {
        private readonly SecondaryMap<TKey, TValue> _secondaryMap;
        private int _index;
        private KeyValuePair<TKey, TValue> _current;

        internal Enumerator(SecondaryMap<TKey, TValue> slotMap)
        {
            _secondaryMap = slotMap;
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
            while (_index < _secondaryMap.Capacity)
            {
                while (++_index < _secondaryMap.Capacity)
                {
                    var slot = _secondaryMap._slots[_index];

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
