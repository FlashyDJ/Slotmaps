namespace FlashyDJ.Slotmaps;

public partial class SparseSecondaryMap<TKey, TValue>
{
    /// <summary>
    ///   Represents a collection of values associated with a <see cref="SparseSecondaryMap{TKey, TValue}"/>.
    /// </summary>
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotValueCollection : ICollection<TValue>, IReadOnlyCollection<TValue>
    {
        private readonly SparseSecondaryMap<TKey, TValue> _sparseMap;

        /// <summary>
        ///   Initializes a new instance of the <see cref="SparseSecondaryMap{TKey, TValue}.SlotValueCollection"/> class associated with a <see cref="SparseSecondaryMap{TValue}"/>.
        /// </summary>
        /// <param name="sparseSecondaryMap">
        ///   The <see cref="SparseSecondaryMap{TValue}"/> with which this collection is associated. Must not be null.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///   Thrown if <paramref name="sparseSecondaryMap"/> is null.
        /// </exception>
        public SlotValueCollection(SparseSecondaryMap<TKey, TValue> sparseSecondaryMap)
        {
            ArgumentNullException.ThrowIfNull(sparseSecondaryMap);
            _sparseMap = sparseSecondaryMap;
        }

        bool ICollection<TValue>.IsReadOnly => true;
        void ICollection<TValue>.Add(TValue item) => throw new NotSupportedException();
        void ICollection<TValue>.Clear() => throw new NotSupportedException();
        bool ICollection<TValue>.Remove(TValue item) => throw new NotSupportedException();
        IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator() => new Enumerator(_sparseMap);
        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(_sparseMap);

        /// <summary>
        ///   Gets the number of values in the <see cref="SparseSecondaryMap{TKey, TValue}.SlotValueCollection"/>.
        /// </summary>
        public int Count => _sparseMap.Count;

        /// <summary>
        ///   Determines whether the <see cref="SparseSecondaryMap{TKey, TValue}.SlotValueCollection"/> contains a specific value.
        /// </summary>
        /// <param name="value">The value to locate in the collection.</param>
        /// <returns>
        ///   <see langword="true"/> if the <see cref="SparseSecondaryMap{TKey, TValue}.SlotValueCollection"/> contains the specified value; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Contains(TValue value) => _sparseMap.ContainsValue(value!);

        /// <summary>
        ///   Copies the elements of the <see cref="SparseSecondaryMap{TKey, TValue}.SlotValueCollection"/> to an array, starting at the specified index.
        /// </summary>
        /// <param name="array">
        ///   The one-dimensional array that is the destination of the elements copied from the <see cref="SparseSecondaryMap{TKey, TValue}.SlotValueCollection"/>. Must not be null.
        /// </param>
        /// <param name="index">
        ///   The zero-based index in <paramref name="array"/> at which copying begins.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///   Thrown if <paramref name="array"/> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   Thrown if <paramref name="index"/> is negative, greater than or equal to the length of <paramref name="array"/>, or if there are not enough elements in the <see cref="SparseSecondaryMap{TKey, TValue}.SlotValueCollection"/> to fill the destination array starting at the specified index.
        /// </exception>
        public void CopyTo(TValue[] array, int index)
        {
            ArgumentNullException.ThrowIfNull(array);
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
            ArgumentOutOfRangeException.ThrowIfLessThan(Count, array.Length - index);

            for (int i = 0; i < _sparseMap.Capacity; i++)
            {
                var slot = _sparseMap._slots[i];

                if (slot.Occupied)
                    array[index++] = slot.Value;
            }
        }

        /// <summary>
        ///   Represents an enumerator for the values in the <see cref="SparseSecondaryMap{TKey, TValue}.SlotValueCollection"/>.
        /// </summary>
        public struct Enumerator : IEnumerator<TValue>, IEnumerator
        {
            private readonly SparseSecondaryMap<TKey, TValue> _sparseMap;
            private int _index;
            private TValue _current;

            internal Enumerator(SparseSecondaryMap<TKey, TValue> sparseSecondaryMap)
            {
                _sparseMap = sparseSecondaryMap;
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
                while (_index < _sparseMap.Capacity)
                {
                    while (++_index < _sparseMap.Capacity)
                    {
                        var slot = _sparseMap._slots[_index];

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
