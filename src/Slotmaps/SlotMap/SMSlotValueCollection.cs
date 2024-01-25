namespace FlashyDJ.Slotmaps;
public partial class SlotMap<TKey, TValue>
{
    /// <summary>
    ///   Represents a readonly collection of values in a slot map.
    /// </summary>
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotValueCollection : ICollection<TValue>, IReadOnlyCollection<TValue>
    {
        private readonly SlotMap<TKey, TValue> _slotMap;

        /// <summary>
        ///   Initializes a new instance of the <see cref="SlotValueCollection"/> class with a reference to the
        ///   parent slot map.
        /// </summary>
        /// <param name="slotMap">The slot map to associate with this value collection. Must not be null.</param>
        /// <exception cref="ArgumentNullException">
        ///   Thrown if <paramref name="slotMap"/> is null.
        /// </exception>
        public SlotValueCollection(SlotMap<TKey, TValue> slotMap)
        {
            ArgumentNullException.ThrowIfNull(slotMap);
            _slotMap = slotMap;
        }

        bool ICollection<TValue>.IsReadOnly => true;
        void ICollection<TValue>.Add(TValue item) => throw new NotSupportedException();
        void ICollection<TValue>.Clear() => throw new NotSupportedException();
        bool ICollection<TValue>.Remove(TValue item) => throw new NotSupportedException();
        IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator() => new Enumerator(_slotMap);
        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(_slotMap);

        /// <summary>Gets the number of values in the collection.</summary>
        public int Count => _slotMap.Count;

        /// <summary>
        ///   Determines whether the collection contains a specific value.
        /// </summary>
        /// <param name="value">The value to search for in the collection.</param>
        /// <returns>
        ///  <see langword="true"/> if the slot map contains the specified value; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Contains(TValue value) => _slotMap.ContainsValue(value);

        /// <summary>
        ///   Copies the elements of the value collection to an array, starting at the specified index.
        /// </summary>
        /// <param name="array">The destination array where values will be copied.</param>
        /// <param name="index">The zero-based index in the array at which copying begins.</param>
        /// <exception cref="ArgumentNullException">
        ///   Thrown if <paramref name="array"/> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   Thrown if <paramref name="index"/> is negative, greater than or equal to the length of <paramref name="array"/>,
        ///   or if there are not enough elements in the slot map to fill the destination array starting at the specified index.
        /// </exception>
        public void CopyTo(TValue[] array, int index)
        {
            ArgumentNullException.ThrowIfNull(array);
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
            ArgumentOutOfRangeException.ThrowIfLessThan(Count, array.Length - index);

            for (int i = 0; i < _slotMap.Capacity; i++)
            {
                var slot = _slotMap._slots[i];

                if (slot.Occupied)
                    array[index++] = slot.Value;
            }
        }

        /// <summary>
        ///   Represents an enumerator for the values in the <see cref="SlotValueCollection"/>
        /// </summary>
        public struct Enumerator : IEnumerator<TValue>, IEnumerator
        {
            private readonly SlotMap<TKey, TValue> _slotMap;
            private int _index;
            private TValue _current;

            internal Enumerator(SlotMap<TKey, TValue> slotMap)
            {
                _slotMap = slotMap;
                _index = -1;
                _current = default!;
            }

            object? IEnumerator.Current => Current;

            /// <inheritdoc/>
            public TValue Current => _current;

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

                        _current = slot.Value;
                        return true;
                    }
                }
                return false;
            }

            /// <inheritdoc/>
            public void Reset()
            {
                _index = -1;
                _current = default!;
            }
        }
    }
}

