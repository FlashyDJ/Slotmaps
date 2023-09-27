using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FlashyDJ.Slotmaps;
[Serializable]
[DebuggerDisplay("Count = {Count}")]
public partial class SparseSecondaryMap<TValue> : ICollection<KeyValuePair<SlotKey, TValue>>
{
    private readonly Dictionary<int, Slot<TValue>> _slots;
    private SlotKeyCollection? _keys;
    private SlotValueCollection? _values;

    public SparseSecondaryMap() => _slots = new(0);

    public SparseSecondaryMap(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);
        _slots = new(capacity);
    }

    bool ICollection<KeyValuePair<SlotKey, TValue>>.IsReadOnly => false;

    void ICollection<KeyValuePair<SlotKey, TValue>>.Add(KeyValuePair<SlotKey, TValue> item) =>
        Insert(item.Key, item.Value);

    bool ICollection<KeyValuePair<SlotKey, TValue>>.Contains(KeyValuePair<SlotKey, TValue> item) =>
        ContainsKey(item.Key) && (EqualityComparer<TValue>.Default.Equals(Get(item.Key), item.Value));

    void ICollection<KeyValuePair<SlotKey, TValue>>.CopyTo(KeyValuePair<SlotKey, TValue>[] array, int index)
    {
        ArgumentNullException.ThrowIfNull(array);
        ArgumentOutOfRangeException.ThrowIfNegative(index);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
        ArgumentOutOfRangeException.ThrowIfLessThan(Count, array.Length - index);

        foreach (var key in _slots.Keys)
        {
            ref var slot = ref CollectionsMarshal.GetValueRefOrAddDefault(_slots, key, out var _);

            if (slot.Occupied)
                array[index++] = new(new(key, slot.Version), slot.Value);
        }
    }

    bool ICollection<KeyValuePair<SlotKey, TValue>>.Remove(KeyValuePair<SlotKey, TValue> item) =>
        ContainsKey(item.Key)
        && (EqualityComparer<TValue>.Default.Equals(Get(item.Key), item.Value)
        && TryRemove(item.Key, out var _));

    IEnumerator<KeyValuePair<SlotKey, TValue>> IEnumerable<KeyValuePair<SlotKey, TValue>>.GetEnumerator() =>
        new Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

    public int Capacity => _slots.EnsureCapacity(0);
    public int Count { get; private set; }
    public bool IsEmpty => Count == 0;
    public SlotKeyCollection Keys => _keys ??= new SlotKeyCollection(this);
    public SlotValueCollection Values => _values ??= new SlotValueCollection(this);

    public TValue this[SlotKey key]
    {
        get
        {
            if (key.IsInvalid && key.Version < 1)
                throw new KeyNotFoundException("Invalid SlotKey");

            var exists = _slots.TryGetValue(key.Index, out var slot);

            if (!exists || slot.Version != key.Version)
                throw new KeyNotFoundException("Invalid SlotKey");

            return slot.Value;
        }
        set => Insert(key, value);
    }

    public bool ContainsKey(SlotKey key)
    {
        if (key.IsInvalid && key.Version < 1)
            return false;

        ref var slot = ref CollectionsMarshal.GetValueRefOrAddDefault(_slots, key.Index, out var exists);

        return exists && slot.Occupied && slot.Version == key.Version;
    }

    public bool ContainsValue(TValue value) =>
        value is not null
        && _slots.Where(x => EqualityComparer<TValue>.Default.Equals(x.Value.Value, value)).Any();

    public void Clear()
    {
        if (Count > 0)
        {
            _slots.Clear();
            Count = 0;
        }
    }

    public IEnumerable<KeyValuePair<SlotKey, TValue>> Drain()
    {
        foreach (var slot in _slots)
        {
            if (slot.Value.Occupied)
            {
                var key = new SlotKey(slot.Key, slot.Value.Version);
                var value = slot.Value.Value;

                Remove(key);

                yield return new(key, value);
            }
        }
    }

    public int EnsureCapacity(int capacity) => _slots.EnsureCapacity(capacity);

    public TValue Get(SlotKey key)
    {
        if (key.IsInvalid && key.Version < 1)
            throw new KeyNotFoundException("Invalid SlotKey");

        var exists = _slots.TryGetValue(key.Index, out var slot);

        if (!exists || slot.Version != key.Version || !slot.Occupied)
            throw new KeyNotFoundException("Invalid SlotKey");

        return slot.Value;
    }

    public TValue Insert(SlotKey key, TValue value)
    {
        ArgumentNullException.ThrowIfNull(value);

        if (key.IsInvalid && key.Version < 1)
            throw new KeyNotFoundException("Invalid SlotKey");

        ref var slot = ref CollectionsMarshal.GetValueRefOrAddDefault(_slots, key.Index, out var exists);

        if (exists)
        {
            if (key.Version < slot.Version)
                throw new KeyNotFoundException("SlotKey is an older version");

            var replacedValue = slot.Value;

            slot.Value = value;
            slot.Version = key.Version;
            return replacedValue;
        }
        else
        {
            Count++;
        }

        slot.Value = value;
        slot.Version = key.Version;
        return value;
    }

    public TValue Remove(SlotKey key)
    {
        if (key.IsInvalid && key.Version < 1)
            throw new KeyNotFoundException("Invalid SlotKey");

        ref var slot = ref CollectionsMarshal.GetValueRefOrNullRef(_slots, key.Index);
        
        if (!Unsafe.IsNullRef(ref slot))
        {
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

    public void Retain(Func<SlotKey, TValue, bool> predicate)
    {
        foreach(var key in _slots.Keys)
        {
            ref var slot = ref CollectionsMarshal.GetValueRefOrAddDefault(_slots, key, out var _);

            if (slot.Occupied)
            {
                var slotKey = new SlotKey(key, slot.Version);
                var value = slot.Value;

                if (!predicate(slotKey, value!))
                    Remove(slotKey);
            }
        }
    }

    public bool TryGet(SlotKey key, [MaybeNullWhen(false)] out TValue value)
    {
        value = default;

        if (key.IsInvalid && key.Version < 1)
            return false;

        var exists = _slots.TryGetValue(key.Index, out var slot);

        if (!exists || slot.Version != key.Version || !slot.Occupied)
            return false;

        value = slot.Value;
        return true;
    }

    public bool TryInsert(SlotKey key, TValue value, [MaybeNullWhen(false)] out TValue previousValue)
    {
        ArgumentNullException.ThrowIfNull(value);
        previousValue = default;

        if (key.IsInvalid && key.Version < 1)
            return false;

        ref var slot = ref CollectionsMarshal.GetValueRefOrAddDefault(_slots, key.Index, out var exists);

        if (exists)
        {
            if (key.Version < slot.Version)
                return false;

            previousValue = slot.Value;

            slot.Value = value;
            slot.Version = key.Version;
            return true;
        }
        else
        {
            Count++;
        }

        slot.Value = value;
        slot.Version = key.Version;
        previousValue = value;
        return true;
    }

    public bool TryRemove(SlotKey key, [MaybeNullWhen(false)] out TValue value)
    {
        value = default;

        if (key.IsInvalid && key.Version < 1)
            return false;

        ref var slot = ref CollectionsMarshal.GetValueRefOrNullRef(_slots, key.Index);
        
        if (!Unsafe.IsNullRef(ref slot))
        {
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

    public struct Enumerator : IEnumerator<KeyValuePair<SlotKey, TValue>>, IEnumerator
    {
        private readonly SparseSecondaryMap<TValue> _sparseMap;
        private readonly IEnumerator<KeyValuePair<int, Slot<TValue>>> _dictEnumerator;

        internal Enumerator(SparseSecondaryMap<TValue> sparseMap)
        {
            _sparseMap = sparseMap;
            _dictEnumerator = _sparseMap._slots.GetEnumerator();
            Current = default;
        }

        public KeyValuePair<SlotKey, TValue> Current { get; private set; }

        object IEnumerator.Current => Current;

        public readonly void Dispose() { }

        public bool MoveNext()
        {
            while (_dictEnumerator.MoveNext())
            {
                var kvp = _dictEnumerator.Current;

                if (!kvp.Value.Occupied)
                    continue;

                Current = new(new(kvp.Key, kvp.Value.Version), kvp.Value.Value);
                return true;
            }
            return false;
        }

        public void Reset()
        {
            Current = default;
        }
    }
}

