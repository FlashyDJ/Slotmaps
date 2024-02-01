namespace FlashyDJ.Slotmaps;
public partial class SlotMap<TKey, TValue>
{
    /// <summary>
    /// Represents a read only collection of keys associated with a value in the slot map.
    /// </summary>
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotKeyCollection : ICollection<TKey>, IReadOnlyCollection<TKey>
    {
        private readonly SlotMap<TKey, TValue> _slotMap;

        /// <summary>
        /// Initializes a new instance of the <see cref="SlotKeyCollection"/> class with a reference
        /// to the parent slot map.
        /// </summary>
        /// <param name="slotMap">The slot map to associate with this key collection. Must not be null.</param>
        /// <exception cref="ArgumentNullException">
        ///   Thrown if <paramref name="slotMap"/> is null.
        /// </exception>
        public SlotKeyCollection(SlotMap<TKey, TValue> slotMap)
        {
            ArgumentNullException.ThrowIfNull(slotMap);
            _slotMap = slotMap;
        }

        bool ICollection<TKey>.IsReadOnly => true;
        void ICollection<TKey>.Add(TKey item) => throw new NotSupportedException();
        void ICollection<TKey>.Clear() => throw new NotSupportedException();
        bool ICollection<TKey>.Remove(TKey item) => throw new NotSupportedException();
        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(_slotMap);

        /// <summary>Gets the number of keys in the collection.</summary>
        public int Count => _slotMap.Count;

        /// <summary>
        ///   Determines whether the collection contains a specific key.
        /// </summary>
        /// <param name="key">The key to search for in the collection.</param>
        /// <returns>
        ///   <see langword="true"/> if the slot map contains the specified key; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Contains(TKey key) => _slotMap.ContainsKey(key);

        /// <summary>
        ///   Copies the elements of the key collection to an array, starting at the specified index.
        /// </summary>
        /// <param name="array">The destination array where keys will be copied.</param>
        /// <param name="index">The zero-based index in the array at which copying begins.</param>
        /// <exception cref="ArgumentNullException">
        ///   Thrown if <paramref name="array"/> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   Thrown if <paramref name="index"/> is negative, greater than or equal to the length of
        ///   <paramref name="array"/>, or if there are not enough elements in the slot map to fill the
        ///   destination array starting at the specified index.
        /// </exception>
        public void CopyTo(TKey[] array, int index)
        {
            ArgumentNullException.ThrowIfNull(array);
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
            ArgumentOutOfRangeException.ThrowIfLessThan(_slotMap.Count, array.Length - index);

            for (int i = 0; i < _slotMap.Capacity; i++)
            {
                var slot = _slotMap._slots[i];

                if (slot.Occupied)
                    array[index++] = TKey.New(i, slot.Version);
            }
        }

        /// <inheritdoc/>
        public IEnumerator<TKey> GetEnumerator() => new Enumerator(_slotMap);

        /// <summary>
        ///   Represents an enumerator for the keys in the <see cref="SlotKeyCollection"/>.
        /// </summary>
        public struct Enumerator : IEnumerator<TKey>, IEnumerator
        {
            private readonly SlotMap<TKey, TValue> _slotMap;
            private int _index;
            private TKey _current;

            internal Enumerator(SlotMap<TKey, TValue> slotMap)
            {
                _slotMap = slotMap;
                _index = -1;
                _current = default;
            }

            object IEnumerator.Current => Current;

            /// <inheritdoc/>
            public TKey Current => _current;

            /// <inheritdoc/>
            public readonly void Dispose() { }

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

                        _current = TKey.New(_index, slot.Version);
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
}

