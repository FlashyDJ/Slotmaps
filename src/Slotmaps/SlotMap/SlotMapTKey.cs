﻿namespace FlashyDJ.Slotmaps;

/// <summary>
///   Represents a slot map data structure that associates keys of type <typeparamref name="TKey"/>
///   with values of type <typeparamref name="TValue"/>.
/// </summary>
/// <typeparam name="TKey">The struct type of keys that implement. <see cref="ISlotKey{TKey}"/>.</typeparam>
/// <typeparam name="TValue">The type of values stored in the slot map.</typeparam>
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

    /// <summary>
    ///   Initializes a new instance of the <see cref="SlotMap{TKey, TValue}"/> class that is empty with no
    ///   initial capacity.
    /// </summary>
    public SlotMap() => _slots = s_emptyArray;

    /// <summary>
    ///   Initializes a new instance of the <see cref="SlotMap{TKey, TValue}"/> class with the specified capacity.
    /// </summary>
    /// <param name="capacity">The initial capacity of the slot map. Must be a non-negative integer.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   Thrown if <paramref name="capacity"/> is negative.
    /// </exception>
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

    /// <summary> Gets the capacity of the slot map. </summary>
    public int Capacity => _slots.Length;

    /// <summary> Gets the number of elements currently stored in the slot map. </summary>
    public int Count { get; private set; }

    /// <summary> Indicates whether the slot map is empty. </summary>
    public bool IsEmpty => Count == 0;

    /// <summary> Gets a read only collection of latest keys associated with the values in the slot map. </summary>
    public SlotKeyCollection Keys => _keys ??= new SlotKeyCollection(this);

    /// <summary> Gets a read only collection of values stored in the slot map. </summary>
    public SlotValueCollection Values => _values ??= new SlotValueCollection(this);

    /// <summary> Gets or sets the value associated with the specified key. </summary>
    /// <param name="key">The key to retrieve or set the value for.</param>
    /// <returns>The value associated with the specified key.</returns>
    /// <exception cref="KeyNotFoundException">
    ///   Thrown if the specified <paramref name="key"/> is not found in the slot map.
    /// </exception>
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

    /// <summary>
    ///   Adds a value to the slot map and returns a key associated with the added value. It assigns the value
    ///   to an available slot if one is available; otherwise, it expands the internal storage to accommodate
    ///   the new value.
    /// </summary>
    /// <param name="value">The value to be added to the slot map.</param>
    /// <returns>The key associated with the added value.</returns>
    /// <exception cref="ArgumentNullException">
    ///   Thrown if <paramref name="value"/> is null.
    /// </exception>
    public TKey Add(TValue value)
    {
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

    /// <summary>
    ///   Determines whether the slot map contains a key that matches the specified <paramref name="key"/>.
    /// </summary>
    /// <param name="key">The key to search for in the slot map.</param>
    /// <returns>
    ///   <see langword="true"/> if the slot map contains the specified key; otherwise, <see langword="false"/>.
    /// </returns>
    /// <seealso cref="TryGet"/>
    public bool ContainsKey(TKey key)
    {
        if (key.Index >= 0 && key.Index < _slots.Length)
        {
            ref var slot = ref _slots[key.Index];
            return slot.Version == key.Version;
        }

        return false;
    }

    /// <summary>
    ///   Determines whether the slot map contains a value that matches the specified <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The value to search for in the slot map.</param>
    /// <returns>
    ///   <see langword="true"/> if the slot map contains the specified value; otherwise, <see langword="false"/>.
    /// </returns>
    /// <seealso cref="TryGet"/>
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

    /// <summary> Removes all values from the slot map, resetting it to an empty state. </summary>
    public void Clear()
    {
        if (Count > 0)
        {
            Array.Clear(_slots);

            Count = 0;
            _freeHead = 0;
        }
    }

    /// <summary>
    ///   Empties the slot map by returning key-value pairs one by one while leaving the remaining items in the map.
    /// </summary>
    /// <returns>An enumerable sequence of key-value pairs drained from the slot map.</returns>
    /// <seealso cref="Clear"/>
    /// <seealso cref="Retain"/>
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

    /// <summary>
    ///   Ensures that the slot map can hold at least the specified capacity without resizing.
    /// </summary>
    /// <param name="capacity">The desired capacity. Must be a non-negative integer.</param>
    /// <returns>The actual capacity of the slot map after ensuring it meets the specified capacity.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   Thrown if <paramref name="capacity"/> is negative.
    /// </exception>
    /// <seealso cref="Capacity"/>
    /// <seealso cref="Reserve"/>
    /// <seealso cref="Resize"/>
    public int EnsureCapacity(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);

        if (Capacity >= capacity)
            return Capacity;

        Resize(capacity);

        return capacity;
    }

    /// <summary>
    ///   Gets the value associated with the specified key in the slot map.
    /// </summary>
    /// <param name="key">The key to retrieve the value for.</param>
    /// <returns>The value associated with the specified key.</returns>
    /// <exception cref="KeyNotFoundException">
    ///   Thrown if the specified <paramref name="key"/> is not found in the slot map.
    /// </exception>
    public TValue Get(TKey key)
    {
        if (!ContainsKey(key))
            throw new KeyNotFoundException("Invalid SlotKey");

        return _slots[key.Index].Value;
    }

    /// <summary>
    ///   Inserts or updates a value associated with the specified key in the slot map.
    /// </summary>
    /// <param name="key">The key to insert or update the value for.</param>
    /// <param name="value">The value to insert or update.</param>
    /// <returns>The updated key after the insertion or update with an incremented version number.</returns>
    /// <exception cref="KeyNotFoundException">
    ///   Thrown if the specified <paramref name="key"/> is not found in the slot map.
    /// </exception>
    /// <seealso cref="TryInsert"/>
    public TKey Insert(TKey key, TValue value)
    {
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

    /// <summary>
    ///   Removes the value associated with the specified key from the slot map.
    /// </summary>
    /// <param name="key">The key to remove from the slot map.</param>
    /// <returns>The removed value.</returns>
    /// <exception cref="KeyNotFoundException">
    ///   Thrown if the specified <paramref name="key"/> is not found in the slot map.
    /// </exception>
    /// <seealso cref="TryRemove"/>
    public TValue Remove(TKey key)
    {
        if (!ContainsKey(key))
            throw new KeyNotFoundException("Invalid SlotKey");

        ref var slot = ref _slots[key.Index];

        var returnValue = slot.Value;
        slot.Value = default!;
        slot.NextFree = _freeHead;
        slot.Version++;

        _freeHead = key.Index;
        Count--;

        return returnValue;
    }

    // TODO: Take account of Count
    /// <summary>
    /// Ensures that the slot map has enough additional capacity to accommodate the specified number of elements.
    /// </summary>
    /// <param name="additionalSize">The additional capacity to reserve. Must be a positive integer.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   Thrown if <paramref name="additionalSize"/> is negative or zero.
    /// </exception>
    /// <seealso cref="Capacity"/>
    /// <seealso cref="EnsureCapacity"/>
    /// <seealso cref="Resize"/>
    public void Reserve(int additionalSize)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(additionalSize);

        Array.Resize(ref _slots, Capacity + additionalSize);
    }

    /// <summary>
    ///   Resizes the slot map to the specified new size.
    /// </summary>
    /// <param name="newSize">The new size for the slot map. Must be greater than or equal to the current capacity.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   Thrown if <paramref name="newSize"/> is less than the current capacity.
    /// </exception>
    /// <seealso cref="EnsureCapacity"/>
    /// <seealso cref="Reserve"/>
    public void Resize(int newSize)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(newSize, Capacity);

        if (newSize == Capacity)
            return;

        Array.Resize(ref _slots, newSize);
    }

    /// <summary>
    ///   Retains elements in the slot map based on a specified predicate.
    /// </summary>
    /// <param name="predicate">A function that defines whether to retain or remove an element based on its key and value.</param>
    /// <seealso cref="Drain"/>
    /// <seealso cref="Remove"/>
    /// <seealso cref="TryRemove"/>
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

    /// <summary>
    ///   Tries to insert or update a value associated with the specified key in the slot map.
    /// </summary>
    /// <param name="key">The key to insert or update the value for.</param>
    /// <param name="value">The value to insert or update.</param>
    /// <param name="newKey">
    ///   When this method returns, contains the updated key if insertion or update was successful.
    /// </param>
    /// <returns>
    ///   <see langword="true"/> if insertion or update was successful; otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    ///   Thrown if <paramref name="value"/> is <c>null</c>.
    /// </exception>
    /// <seealso cref="Insert"/>
    public bool TryInsert(TKey key, TValue value, out TKey newKey)
    {
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

    /// <summary>
    ///   Tries to retrieve the value associated with the specified key from the slot map.
    /// </summary>
    /// <param name="key">The key to retrieve the value for.</param>
    /// <param name="value">
    ///   When this method returns, contains the value associated with the specified key if found; otherwise,
    ///   the default value.
    /// </param>
    /// <returns>
    ///   <see langword="true"/> if the value associated with the specified key was found; otherwise, <see langword="false"/>.
    /// </returns>
    /// <seealso cref="Get"/>
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

    /// <summary>
    ///   Tries to remove the value associated with the specified key from the slot map.
    /// </summary>
    /// <param name="key">The key to remove from the slot map.</param>
    /// <param name="value">
    ///   When this method returns, contains the value associated with the removed key if found; otherwise,
    ///   the default value.
    /// </param>
    /// <returns>
    ///   <see langword="true"/> if the value associated with the specified key was found and removed; otherwise, <see langword="false"/>.
    /// </returns>
    /// <seealso cref="Remove"/>
    public bool TryRemove(TKey key, [MaybeNullWhen(false)] out TValue value)
    {
        if (!ContainsKey(key))
        {
            value = default;
            return false;
        }

        ref var slot = ref _slots[key.Index];
        value = slot.Value;

        slot.Value = default!;
        slot.NextFree = _freeHead;
        slot.Version++;

        _freeHead = key.Index;
        Count--;

        return true;
    }

    /// <summary>Represents an enumerator for key-value pairs in a slot map.</summary>
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
