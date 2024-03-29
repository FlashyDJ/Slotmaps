﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FlashyDJ.Slotmaps;

/// <summary>
///   Represents a secondary map that associates keys of type <see cref="ISlotKey{TKey}"/> with values of type <typeparamref name="TValue"/>.
/// </summary>
/// <typeparam name="TKey">The struct type of keys that implement. <see cref="ISlotKey{TKey}"/>.</typeparam>
/// <typeparam name="TValue">The type of values stored in the secondary map.</typeparam>
[DebuggerDisplay("Count = {Count}")]
public partial class SparseSecondaryMap<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
    where TKey : struct, ISlotKey<TKey>
{
    private readonly Dictionary<int, Slot> _slots;
    private SlotKeyCollection? _keys;
    private SlotValueCollection? _values;

    /// <summary>
    ///   Initializes a new instance of the <see cref="SparseSecondaryMap{TKey, TValue}"/> class with an empty collection.
    /// </summary>
    public SparseSecondaryMap() => _slots = [];

    /// <summary>
    ///   Initializes a new instance of the <see cref="SparseSecondaryMap{TKey, TValue}"/> class with the specified capacity.
    /// </summary>
    /// <param name="capacity">
    ///   The initial capacity of the <see cref="SparseSecondaryMap{TKey, TValue}"/>. Must be a non-negative integer.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   Thrown if <paramref name="capacity"/> is negative.
    /// </exception>
    public SparseSecondaryMap(int capacity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);
        _slots = new(capacity);
    }

    IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

    /// <summary>
    ///   Gets the capacity of the sparse secondary map.
    /// </summary>
    public int Capacity => _slots.EnsureCapacity(0);

    /// <summary>
    ///   Gets the number of elements currently stored in the sparse secondary map.
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    ///   Gets a value indicating whether the sparse secondary map is empty.
    /// </summary>
    public bool IsEmpty => Count == 0;

    /// <summary>
    ///   Gets a read only collection containing the keys in the sparse secondary map.
    /// </summary>
    /// <returns>
    ///   A <see cref="SlotKeyCollection"/> containing the keys in the sparse secondary map.
    /// </returns>
    public SlotKeyCollection Keys => _keys ??= new SlotKeyCollection(this);

    /// <summary>
    ///   Gets a read only collection containing the values in the sparse secondary map.
    /// </summary>
    /// <returns>
    ///   A <see cref="SlotValueCollection"/> containing the values in the sparse secondary map.
    /// </returns>
    public SlotValueCollection Values => _values ??= new SlotValueCollection(this);

    /// <summary>
    ///   Gets or sets the value associated with the specified slot key.
    /// </summary>
    /// <param name="key">
    ///   The slot key whose associated value is to be retrieved or set.
    /// </param>
    /// <value>
    ///   The value associated with the specified <paramref name="key"/>.
    /// </value>
    /// <exception cref="KeyNotFoundException">
    ///   Thrown if the specified <paramref name="key"/> is not found in the slot map.
    /// </exception>
    public TValue this[TKey key]
    {
        get => Get(key);
        set => Insert(key, value);
    }

    /// <summary>
    ///   Determines whether the secondary map contains the specified slot key.
    /// </summary>
    /// <param name="key">
    ///   The slot key to locate in the sparse secondary map.
    /// </param>
    /// <returns>
    ///   <see langword="true"/> if the sparse secondary map contains an entry with the specified slot key that matches both the index and version;
    ///   otherwise, <see langword="false"/>.
    /// </returns>
    public bool ContainsKey(TKey key)
    {
        if (key.IsNull) return false;
        ref var slot = ref CollectionsMarshal.GetValueRefOrNullRef(_slots, key.Index);
        return !Unsafe.IsNullRef(ref slot) && slot.Version == key.Version;
    }

    /// <summary>
    ///   Determines whether the sparse secondary map contains an entry with the specified value.
    /// </summary>
    /// <param name="value">
    ///   The value to locate in the sparse secondary map.
    /// </param>
    /// <returns>
    ///   <see langword="true"/> if the sparse secondary map contains an entry with the specified value; otherwise, <see langword="false"/>.
    /// </returns>
    public bool ContainsValue(TValue value) =>
        _slots.Where(x => EqualityComparer<TValue>.Default.Equals(x.Value.Value, value)).Any();

    /// <summary>
    ///   Removes all elements from the sparse secondary map.
    /// </summary>
    public void Clear()
    {
        if (Count > 0)
        {
            _slots.Clear();
            Count = 0;
        }
    }

    /// <summary>
    ///   Removes and returns elements from the sparse secondary map one at a time as an enumerable collection of key-value pairs.
    /// </summary>
    /// <returns>
    ///   An <see cref="IEnumerable{T}"/> of <see cref="KeyValuePair{SlotKey, TValue}"/> containing the entries retrieved from the sparse secondary map.
    /// </returns>
    public IEnumerable<KeyValuePair<TKey, TValue>> Drain()
    {
        foreach (var slot in _slots)
        {
            var key = TKey.New(slot.Key, slot.Value.Version);
            var value = slot.Value.Value;

            Remove(key);
            yield return new(key, value);
        }
    }

    /// <summary>
    ///   Ensures that the sparse secondary map can hold at least the specified capacity without resizing.
    /// </summary>
    /// <param name="capacity">
    ///   The desired capacity of the sparse secondary map. Must be a non-negative integer.
    /// </param>
    /// <returns>
    ///   The capacity of the sparse secondary map after ensuring it can accommodate the specified capacity.
    ///   If the current capacity is already greater than or equal to the specified capacity, the current capacity is returned.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   Thrown if <paramref name="capacity"/> is negative.
    /// </exception>
    public int EnsureCapacity(int capacity) => _slots.EnsureCapacity(capacity);

    /// <summary>
    ///   Gets the value associated with the specified slot key.
    /// </summary>
    /// <param name="key">
    ///   The slot key to look up in the sparse secondary map.
    /// </param>
    /// <returns>
    ///   The value associated with the specified slot key.
    /// </returns>
    /// <exception cref="KeyNotFoundException">
    ///   Thrown if the specified <paramref name="key"/> is not found in the slot map.
    /// </exception>
    public ref TValue Get(TKey key)
    {
        if (!ContainsKey(key))
            ThrowHelper.ThrowKeyNotFoundException_MaybeNull(key);

        return ref CollectionsMarshal.GetValueRefOrNullRef(_slots, key.Index).Value;
    }

    /// <summary>
    ///   Gets a reference to the value associated with the specified key in the secondary map.
    ///   If the key is not found, returns a null reference of type <typeparamref name="TValue"/>.
    /// </summary>
    /// <param name="key">The key to retrieve the value for.</param>
    /// <returns>A reference to the value associated with the specified key or a null reference.</returns>
    /// <remarks>
    ///   The returned reference may be null, and its nullness can be detected using
    ///   <see cref="Unsafe.IsNullRef{T}(ref readonly T)"/>.
    /// </remarks>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ref TValue GetRefOrNullRef(TKey key) =>
        ref ContainsKey(key) ? ref CollectionsMarshal.GetValueRefOrNullRef(_slots, key.Index).Value
                             : ref Unsafe.NullRef<TValue>();

    /// <inheritdoc/>
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => new Enumerator(this);

    /// <summary>
    ///   Inserts a value into the sparse secondary map associated with the specified slot key.
    /// </summary>
    /// <param name="key">
    ///   The slot key with which to associate the value.
    /// </param>
    /// <param name="value">
    ///   The value to insert into the sparse secondary map.
    /// </param>
    /// <returns>
    ///   The previous value associated with the specified slot key if it existed; otherwise,
    ///   the provided <paramref name="value"/>.
    /// </returns>
    /// <exception cref="KeyNotFoundException">
    ///   Thrown if the specified <paramref name="key"/> is not found or if the
    ///   provided slot key is an older version than an existing entry.
    /// </exception>
    public TValue Insert(TKey key, TValue value)
    {
        if (key.IsNull)
            ThrowHelper.ThrowKeyNotFoundException_Null(key);

        ref var slot = ref CollectionsMarshal.GetValueRefOrAddDefault(_slots, key.Index, out var exists);

        if (!exists)
            Count++;
        else if (IsOlderVersion(key.Version, slot.Version))
            ThrowHelper.ThrowKeyNotFoundException_OlderVersion(key);
        
        return slot.Update(value, key.Version);
    }

    /// <summary>
    ///   Removes the value with the specified slot key from the sparse secondary map.
    /// </summary>
    /// <param name="key">
    ///   The slot key of the entry to remove.
    /// </param>
    /// <returns>
    ///   The value associated with the removed slot key if the entry is found and removed successfully.
    /// </returns>
    /// <exception cref="KeyNotFoundException">
    ///   Thrown if the provided slot key is invalid, has a version less than 1,
    ///   or does not exist in the sparse secondary map.
    /// </exception>
    public TValue Remove(TKey key) =>
        ContainsKey(key) ? RemoveSlot(key)
                         : throw ThrowHelper.GetKeyNotFoundException_MaybeNull(key);

    /// <summary>
    ///   Retains entries in the sparse secondary map based on a specified condition defined by a predicate function.
    /// </summary>
    /// <param name="predicate">
    ///   A delegate that defines the condition for retaining elements. The delegate is called for each entry with its slot key and associated value as arguments.
    /// </param>
    public void Retain(Func<TKey, TValue, bool> predicate)
    {
        foreach(var key in _slots.Keys)
        {
            ref var slot = ref CollectionsMarshal.GetValueRefOrNullRef(_slots, key);

            if (!Unsafe.IsNullRef(ref slot))
            {
                var slotKey = TKey.New(key, slot.Version);
                var value = slot.Value;

                if (!predicate(slotKey, value!))
                    Remove(slotKey);
            }
        }
    }

    /// <summary>
    ///   Tries to get the value associated with the specified slot key from the sparse secondary map.
    /// </summary>
    /// <param name="key">
    ///   The slot key to locate in the <see cref="SparseSecondaryMap{TKey, TValue}"/>.
    /// </param>
    /// <param name="value">
    ///   When this method returns, contains the value associated with the specified slot key, if found; otherwise, the default value for <typeparamref name="TValue"/>.
    /// </param>
    /// <returns>
    ///   <see langword="true"/> if the <paramref name="key"/> is found in the <see cref="SparseSecondaryMap{TKey, TValue}"/>; otherwise, <see langword="false"/>.
    /// </returns>
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
    ///   Tries to insert a value associated with the specified slot key into the sparse secondary map.
    /// </summary>
    /// <param name="key">
    ///   The slot key to associate with the value.
    /// </param>
    /// <param name="value">
    ///   The value to insert into the sparse secondary map.
    /// </param>
    /// <param name="previousValue">
    ///   When this method returns, contains the previous value associated with the specified slot key, if it exists;
    ///   otherwise, the default value for <typeparamref name="TValue"/>.
    /// </param>
    /// <returns>
    ///   <see langword="true"/> if the value was successfully inserted or updated; otherwise, <see langword="false"/>.
    /// </returns>
    public bool TryInsert(TKey key, TValue value, [MaybeNullWhen(false)] out TValue previousValue)
    {
        previousValue = default;
        if (key.IsNull)
            return false;

        ref var slot = ref CollectionsMarshal.GetValueRefOrAddDefault(_slots, key.Index, out var exists);
        
        if (!exists)
            Count++;
        else if (IsOlderVersion(key.Version, slot.Version))
            return false;

        previousValue = slot.Update(value, key.Version);
        return true;
    }

    /// <summary>
    ///   Attempts to remove the entry with the specified slot key from the sparse secondary map.
    /// </summary>
    /// <param name="key">
    ///   The slot key of the entry to remove.
    /// </param>
    /// <param name="value">
    ///   When this method returns, contains the value associated with the specified <paramref name="key"/>, if found; otherwise, the default value for <typeparamref name="TValue"/>.
    /// </param>
    /// <returns>
    ///   <see langword="true"/> if an entry with the specified slot key was found and removed successfully;
    ///   otherwise, <see langword="false"/>.
    /// </returns>
    public bool TryRemove(TKey key, [MaybeNullWhen(false)] out TValue value)
    {
        if (ContainsKey(key))
        {
            value = RemoveSlot(key);
            return true;
        }

        value = default;
        return false;
    }

    private TValue RemoveSlot(TKey key)
    {
        _slots.Remove(key.Index, out var slot);
        Count--;
        return slot.Value;
    }

    /// <summary>
    ///   Represents an enumerator for the <see cref="SparseSecondaryMap{TKey, TValue}"/> collection.
    /// </summary>
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

