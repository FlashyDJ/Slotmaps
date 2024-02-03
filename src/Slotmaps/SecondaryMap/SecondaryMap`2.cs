namespace FlashyDJ.Slotmaps;

/// <summary>
///   Represents a secondary slot map that associates keys of type <typeparamref name="TKey"/> for efficiently
///   storing additional information for primary slot map elements.
/// </summary>
/// <typeparam name="TKey">The type of keys that implement <see cref="ISlotKey{TKey}"/>.</typeparam>
/// <typeparam name="TValue">The type of values stored in the secondary map.</typeparam>
/// <seealso cref="ISlotKey{TKey}"/>
/// <seealso cref="SparseSecondaryMap{TKey, TValue}"/>
[DebuggerDisplay("Count = {Count}")]
public partial class SecondaryMap<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
    where TKey : struct, ISlotKey<TKey>
{
    private Slot[] _slots;
    private SlotKeyCollection? _keys;
    private SlotValueCollection? _values;

    /// <summary>
    ///   Initializes a new instance of the <see cref="SecondaryMap{TKey, TValue}"/> class that is empty with no
    ///   initial capacity.
    /// </summary>
    public SecondaryMap() => _slots = [];

    /// <summary>
    ///   Initializes a new instance of the <see cref="SecondaryMap{TKey, TValue}"/> class with the specified capacity.
    /// </summary>
    /// <param name="capacity">The initial capacity of the secondary map. Must be a non-negative integer.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   Thrown if <paramref name="capacity"/> is negative.
    /// </exception>
    /// <seealso cref="Capacity"/>
    public SecondaryMap(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);
        _slots = capacity == 0 ? [] : new Slot[capacity];
    }

    IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

    /// <summary>
    ///   Gets the capacity of the secondary map.
    /// </summary>
    public int Capacity => _slots.Length;

    /// <summary>
    ///   Gets the number of elements currently stored in the secondary map.
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    ///   Indicates whether the secondary map is empty.
    /// </summary>
    public bool IsEmpty => Count == 0;

    /// <summary>
    ///   Gets a read only collection of keys associated with the values in the secondary map.
    /// </summary>
    /// <seealso cref="SlotKeyCollection"/>
    public SlotKeyCollection Keys => _keys ??= new SlotKeyCollection(this);

    /// <summary>
    ///   Gets a read only collection of values stored in the secondary map.
    /// </summary>
    /// <seealso cref="SlotValueCollection"/>
    public SlotValueCollection Values => _values ??= new SlotValueCollection(this);

    /// <summary>
    ///   Gets or sets the value associated with the specified key.
    /// </summary>
    /// <param name="key">The key to retrieve or set the value for.</param>
    /// <value>The value associated with the specified key.</value>
    /// <exception cref="KeyNotFoundException">
    ///   Thrown if the specified <paramref name="key"/> is not found in the secondary map.
    /// </exception>
    public TValue this[TKey key]
    {
        get => Get(key);
        set => Insert(key, value);
    }

    /// <summary>
    ///   Determines whether the slot map contains a key that matches the specified <paramref name="key"/>.
    /// </summary>
    /// <param name="key">The key to search for in the secondary map.</param>
    /// <returns>
    ///   <see langword="true"/> if the secondary map contains the specified key; otherwise, <see langword="false"/>.
    /// </returns>
    /// <seealso cref="TryGet"/>
    public bool ContainsKey(TKey key) =>
        !key.IsNull && key.Index <= _slots.Length - 1
        && _slots[key.Index].Version == key.Version;

    /// <summary>
    ///   Determines whether the secondary map contains a value that matches the specified <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The value to search for in the secondary map.</param>
    /// <returns>
    ///   <see langword="true"/> if the secondary map contains the specified value; otherwise, <see langword="false"/>.
    /// </returns>
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

    /// <summary>
    ///   Removes all values from the secondary map, resetting it to an empty state.
    /// </summary>
    public void Clear()
    {
        if (Count > 0)
        {
            Array.Clear(_slots);
            Count = 0;
        }
    }

    /// <summary>
    ///   Empties the secondary map by returning key-value pairs one by one while leaving the remaining items
    ///   in the map.
    /// </summary>
    /// <returns>
    ///   An enumerable sequence of key-value pairs drained from the secondary map.
    /// </returns>
    /// <seealso cref="Clear"/>
    /// <seealso cref="Retain"/>
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

    /// <summary>
    ///   Ensures that the secondary map can hold at least the specified capacity without resizing.
    /// </summary>
    /// <param name="capacity">The desired capacity. Must be a non-negative integer.</param>
    /// <returns>The actual capacity of the secondary map after ensuring it meets the specified capacity.</returns>
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
    ///   Gets the value associated with the specified key in the secondary map.
    /// </summary>
    /// <param name="key">The key to retrieve the value for.</param>
    /// <returns>The value associated with the specified key.</returns>
    /// <exception cref="KeyNotFoundException">
    ///   Thrown if the specified <paramref name="key"/> is not found in the secondary map.
    /// </exception>
    /// <seealso cref="TryGet"/>
    public TValue Get(TKey key) =>
        ContainsKey(key) ? _slots[key.Index].Value
                         : throw ThrowHelper.GetKeyNotFoundException_MaybeNull(key);

    /// <inheritdoc/>
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => new Enumerator(this);

    /// <summary>
    ///   Inserts or updates a value associated with the specified key in the secondary map.
    /// </summary>
    /// <param name="key">The key to insert or update the value for.</param>
    /// <param name="value">The value to insert or update.</param>
    /// <returns>
    ///   The previous value associated with the specified key if applicable, or the new
    ///   value itself if the slot doesn't contain anything.
    /// </returns>
    /// <exception cref="KeyNotFoundException">
    ///   Thrown if the specified <paramref name="key"/> is not found in the secondary map.
    /// </exception>
    /// <seealso cref="TryInsert"/>
    public TValue Insert(TKey key, TValue value)
    {
        if (key.IsNull)
            ThrowHelper.ThrowKeyNotFoundException_Null(key);

        if (key.Index >= Capacity)
            Array.Resize(ref _slots, key.Index + 1);

        ref var slot = ref _slots[key.Index];

        if (!slot.Occupied)
            Count++;
        else if (IsOlderVersion(key.Version, slot.Version))
            ThrowHelper.ThrowKeyNotFoundException_OlderVersion(key);

        return slot.Update(value, key.Version);
    }

    /// <summary>
    ///   Removes the value associated with the specified key from the secondary map.
    /// </summary>
    /// <param name="key">The key to remove from the secondary map.</param>
    /// <returns>The removed value.</returns>
    /// <exception cref="KeyNotFoundException">
    ///   Thrown if the specified <paramref name="key"/> is not found in the secondary map.
    /// </exception>
    /// <seealso cref="TryRemove"/>
    public TValue Remove(TKey key)
    {
        if (key.IsNull)
            ThrowHelper.ThrowKeyNotFoundException_Null(key);

        if (Capacity > key.Index)
        {
            ref var slot = ref _slots[key.Index];
            if (slot.Version == key.Version)
            {
                Count--;
                return slot.Clear();
            }
        }

        throw ThrowHelper.GetKeyNotFoundException(key);
    }

    /// <summary>
    ///   Ensures that the secondary map has enough additional capacity to accommodate the specified number of elements.
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
        int requiredCapacity = Count + additionalSize;

        if (requiredCapacity > Capacity)
            Array.Resize(ref _slots, requiredCapacity);
    }

    /// <summary>
    ///   Resizes the secondary map to the specified new size.
    /// </summary>
    /// <param name="newSize">
    ///   The new size for the secondary map. Must be greater than or equal to the current capacity.
    /// </param>
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
    ///   Retains elements in the secondary map based on a specified predicate.
    /// </summary>
    /// <param name="predicate">
    ///   A function that defines whether to retain or remove an element based on its key and value.
    /// </param>
    /// <seealso cref="Drain"/>
    /// <seealso cref="Remove"/>
    /// <seealso cref="TryRemove"/>
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

    /// <summary>
    ///   Tries to retrieve the value associated with the specified key from the secondary map.
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
        if (ContainsKey(key))
        {
            value = _slots[key.Index].Value;
            return true;
        }

        value = default;
        return false;
    }

    /// <summary>
    ///   Tries to insert or update a value associated with the specified key in the secondary map.
    /// </summary>
    /// <param name="key">The key to insert or update the value for.</param>
    /// <param name="value">The value to insert or update.</param>
    /// <param name="oldValue">
    ///   When this method returns, contains the old value if insertion or update was successful.
    /// </param>
    /// <returns>
    ///   <see langword="true"/> if insertion or update was successful; otherwise, <see langword="false"/>.
    /// </returns>
    /// <seealso cref="Insert"/>
    public bool TryInsert(TKey key, TValue value, [MaybeNullWhen(false)] out TValue oldValue)
    {
        oldValue = default;

        if (key.IsNull)
            return false;

        if (key.Index >= Capacity)
            Array.Resize(ref _slots, key.Index + 1);

        ref var slot = ref _slots[key.Index];

        if (!slot.Occupied)
            Count++;
        else if (IsOlderVersion(key.Version, slot.Version))
            return false;

        oldValue = slot.Update(value, key.Version);
        return true;
    }

    /// <summary>
    ///   Tries to remove the value associated with the specified key from the secondary map.
    /// </summary>
    /// <param name="key">The key to remove from the secondary map.</param>
    /// <param name="value">
    ///   When this method returns, contains the value associated with the removed key if found; otherwise,
    ///   the default value.
    /// </param>
    /// <returns>
    ///   <see langword="true"/> if the value associated with the specified key was found and removed; otherwise,
    ///   <see langword="false"/>.
    /// </returns>
    /// <seealso cref="Remove"/>
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
                Count--;
                value = slot.Clear();
                return true;
            }
        }

        return false;
    }

    /// <summary>
    ///   Represents an enumerator for the <see cref="SecondaryMap{TKey, TValue}"/> collection.
    /// </summary>
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
