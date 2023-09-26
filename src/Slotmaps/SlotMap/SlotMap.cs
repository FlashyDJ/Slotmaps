using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace FlashyDJ.Slotmaps;
[Serializable]
[DebuggerDisplay("Count = {Count}")]
public partial class SlotMap<TValue> : ICollection<KeyValuePair<SlotKey, TValue>>
{
    private const int DefaultCapacity = 4;

#pragma warning disable CA1825 // avoid the extra generic instantiation for Array.Empty<T>()
    private static readonly Slot<TValue>[] s_emptyArray = new Slot<TValue>[0];
#pragma warning restore CA1825

    private Slot<TValue>[] _slots;
    private int _freeHead;
    private SlotKeyCollection? _keys;
    private SlotValueCollection? _values;

    public SlotMap() => _slots = s_emptyArray;

    public SlotMap(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);

        if (capacity == 0)
            _slots = s_emptyArray;
        else
            _slots = new Slot<TValue>[capacity];
    }

    void ICollection<KeyValuePair<SlotKey, TValue>>.Add(KeyValuePair<SlotKey, TValue> item) =>
        Insert(item.Key, item.Value);

    bool ICollection<KeyValuePair<SlotKey, TValue>>.Contains(KeyValuePair<SlotKey, TValue> item) =>
        ContainsKey(item.Key) && ContainsValue(item.Value);

    void ICollection<KeyValuePair<SlotKey, TValue>>.CopyTo(KeyValuePair<SlotKey, TValue>[] array, int index)
    {
        ArgumentNullException.ThrowIfNull(array);
        ArgumentOutOfRangeException.ThrowIfNegative(index);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
        ArgumentOutOfRangeException.ThrowIfLessThan(Count, array.Length - index);

        for (int i = 0; i < Capacity; i++)
        {
            var slot = _slots[i];

            if (slot.Occupied)
                array[index++] = new(new(i, slot.Version), slot.Value);
        }
    }

    bool ICollection<KeyValuePair<SlotKey, TValue>>.Remove(KeyValuePair<SlotKey, TValue> item)
    {
        if (ContainsKey(item.Key) && ContainsValue(item.Value))
        {
            Remove(item.Key);
            return true;
        }
            
        return false;
    }

    IEnumerator<KeyValuePair<SlotKey, TValue>> IEnumerable<KeyValuePair<SlotKey, TValue>>.GetEnumerator() =>
        new Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

    bool ICollection<KeyValuePair<SlotKey, TValue>>.IsReadOnly => false;

    public int Capacity => _slots.Length;
    public int Count { get; private set; }
    public bool IsEmpty => Count == 0;
    public SlotKeyCollection Keys => _keys ??= new SlotKeyCollection(this);
    public SlotValueCollection Values => _values ??= new SlotValueCollection(this);

    public TValue this[SlotKey key]
    {
        get
        {
            if (!ContainsKey(key))
                throw new KeyNotFoundException("Invalid SlotKey");

            return _slots[key.Index].Value;
        }
        set => Insert(key, value);
    }

    public SlotKey Add(TValue value)
    {
        ArgumentNullException.ThrowIfNull(value);
        var newCount = Count + 1;

        if (_freeHead <= Capacity - 1)
        {
            ref var slot = ref _slots[_freeHead];

            if (!slot.Occupied)
            {
                var occupiedVersion = slot.Version + 1;
                var updatedkey = new SlotKey(_freeHead, occupiedVersion);

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

        return new(newIndex, newSlot.Version);
    }

    public bool ContainsKey(SlotKey key)
    {
        if (key.Index >= 0 && key.Index < _slots.Length)
        {
            ref var slot = ref _slots[key.Index];
            return slot.Version == key.Version;
        }

        return false;
    }

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

    public void Clear()
    {
        if (Count > 0)
        {
            Array.Clear(_slots);

            Count = 0;
            _freeHead = 0;
        }
    }

    public IEnumerable<KeyValuePair<SlotKey,TValue>> Drain()
    {
        for (int i = 0; i < Capacity; i++)
        {
            if (_slots[i].Occupied)
            {
                var key = new SlotKey(i, _slots[i].Version);
                var value = _slots[i].Value;

                Remove(key);

                yield return new(key, value);
            }
        }
    }

    public int EnsureCapacity(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);

        if (Capacity >= capacity)
            return Capacity;

        Resize(capacity);

        return capacity;
    }

    public TValue Get(SlotKey key)
    {
        if (!ContainsKey(key))
            throw new KeyNotFoundException("Invalid SlotKey");

        return _slots[key.Index].Value;
    }

    public SlotKey Insert(SlotKey key, TValue value)
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

        return new(key.Index, slot.Version);
    }

    public TValue Remove(SlotKey key)
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

    public void Reserve(int additionalSize)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(additionalSize);

        Array.Resize(ref _slots, Capacity + additionalSize);
    }

    public void Resize(int newSize)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(newSize, Capacity);

        if (newSize == Capacity)
            return;

        Array.Resize(ref _slots, newSize);
    }

    public void Retain(Func<SlotKey,TValue, bool> predicate)
    {
        for (int i = 0; i < _slots.Length; i++)
        {
            ref var slot = ref _slots[i];
            
            if (slot.Occupied)
            {
                var key = new SlotKey(i, slot.Version);
                var value = slot.Value;

                if (!predicate(key, value))
                    Remove(key);
            }
        }
    }

    public bool TryAdd(SlotKey key, TValue value, out SlotKey newKey)
    {
        ArgumentNullException.ThrowIfNull(value);

        if (!ContainsKey(key))
        {
            newKey = SlotKey.Null;
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

        newKey = new(key.Index, slot.Version);
        return true;
    }

    public bool TryGet(SlotKey key, [MaybeNullWhen(false)] out TValue value)
    {
        if (!ContainsKey(key))
        {
            value = default;
            return false;
        }

        value = _slots[key.Index].Value!;
        return true;
    }

    public bool TryRemove(SlotKey key, [MaybeNullWhen(false)] out TValue value)
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

    public struct Enumerator : IEnumerator<KeyValuePair<SlotKey, TValue>>, IEnumerator
    {
        private readonly SlotMap<TValue> _slotMap;
        private int _index;
        private KeyValuePair<SlotKey, TValue> _current;

        internal Enumerator(SlotMap<TValue> slotMap)
        {
            _slotMap = slotMap;
            _index = -1;
            _current = default;
        }

        public KeyValuePair<SlotKey, TValue> Current => _current;

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            while (_index < _slotMap.Capacity)
            {
                while (++_index < _slotMap.Capacity)
                {
                    var slot = _slotMap._slots[_index];

                    if (!slot.Occupied)
                        break;

                    _current = new(new(_index, slot.Version), slot.Value);
                    return true;
                }
            }
            return false;
        }

        public void Reset()
        {
            _index = -1;
            _current = default;
        }
    }
}
