using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace FlashyDJ.Slotmaps;
[Serializable]
[DebuggerDisplay("Count = {Count}")]
public partial class SecondaryMap<TValue> : ICollection<KeyValuePair<SlotKey, TValue>>
{
#pragma warning disable CA1825 // avoid the extra generic instantiation for Array.Empty<T>()
    private static readonly Slot<TValue>[] s_emptyArray = new Slot<TValue>[0];
#pragma warning restore CA1825

    private Slot<TValue>[] _slots;
    private SlotKeyCollection? _keys;
    private SlotValueCollection? _values;

    public SecondaryMap() => _slots = s_emptyArray;

    public SecondaryMap(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);

        if (capacity == 0)
            _slots = s_emptyArray;
        else
            _slots = new Slot<TValue>[capacity];
    }

    bool ICollection<KeyValuePair<SlotKey, TValue>>.IsReadOnly => false;

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

    public bool ContainsKey(SlotKey key)
    {
        if (key.IsInvalid)
            return false;

        return _slots.Length > key.Index && _slots[key.Index].Version == key.Version;
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
        }
    }
    public IEnumerable<KeyValuePair<SlotKey, TValue>> Drain()
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

        return _slots[key.Index].Value!;
    }

    public TValue Insert(SlotKey key, TValue value)
    {
        ArgumentNullException.ThrowIfNull(value);

        if (key.IsInvalid)
            throw new KeyNotFoundException("Invalid SlotKey");

        if (Capacity <= key.Index)
            Array.Resize(ref _slots, key.Index + 1);

        ref var slot = ref _slots[key.Index];
        var returnValue = slot.Value ?? value;

        if (slot.Version == key.Version)
        {
            slot.Value = value;
            return returnValue;
        }

        if (slot.Occupied)
        {
            if (key.Version < slot.Version)
                throw new KeyNotFoundException("Invalid SlotKey");
        }
        else
        {
            Count++;
        }

        slot.Value = value;
        slot.Version = key.Version;
        return returnValue;
    }

    public TValue Remove(SlotKey key)
    {
        if (key.IsInvalid)
            throw new KeyNotFoundException("Invalid SlotKey");

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

        throw new KeyNotFoundException("Invalid SlotKey");
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

    public void Retain(Func<SlotKey, TValue, bool> predicate)
    {
        for (int i = 0; i < _slots.Length; i++)
        {
            ref var slot = ref _slots[i];

            if (slot.Occupied)
            {
                var key = new SlotKey(i, slot.Version);
                var value = slot.Value;

                if (!predicate(key, value!))
                    Remove(key);
            }
        }
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

    public bool TryInsert(SlotKey key, TValue value, out TValue? oldValue)
    {
        ArgumentNullException.ThrowIfNull(value);
        oldValue = default;

        if (key.IsInvalid)
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
        {
            Count++;
        }

        slot.Value = value;
        slot.Version = key.Version;
        return true;
    }

    public bool TryRemove(SlotKey key, [MaybeNullWhen(false)] out TValue value)
    {
        value = default;

        if (key.IsInvalid)
            return false;

        if (Capacity > key.Index)
        {
            ref var slot = ref _slots[key.Index];
            if (slot.Version == key.Version)
            {
                value = slot.Value;
                slot = Slot<TValue>.NewVacant();
                Count--;

                return true;
            }
        }

        return false;
    }

    public struct Enumerator : IEnumerator<KeyValuePair<SlotKey, TValue>>, IEnumerator
    {
        private readonly SecondaryMap<TValue> _secondaryMap;
        private int _index;
        private KeyValuePair<SlotKey, TValue> _current;

        internal Enumerator(SecondaryMap<TValue> slotMap)
        {
            _secondaryMap = slotMap;
            _index = -1;
            _current = default;
        }

        public KeyValuePair<SlotKey, TValue> Current => _current;

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            while (_index < _secondaryMap.Capacity)
            {
                while (++_index < _secondaryMap.Capacity)
                {
                    var slot = _secondaryMap._slots[_index];

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
