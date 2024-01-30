namespace FlashyDJ.Slotmaps;

public partial class SparseSecondaryMap<TKey, TValue>
{
    /// <summary>
    ///   Represents a read only collection of <see cref="ISlotKey{TKey}"/> instances associated with a <see cref="SparseSecondaryMap{TKey, TValue}"/>.
    /// </summary>
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotKeyCollection : ICollection<TKey>, IReadOnlyCollection<TKey>
    {
        private readonly SparseSecondaryMap<TKey, TValue> _sparseMap;

        /// <summary>
        ///   Initializes a new instance of the <see cref="SparseSecondaryMap{TKey, TValue}.SlotKeyCollection"/> class with a reference to the parent <see cref="SparseSecondaryMap{TValue}"/>.
        /// </summary>
        /// <param name="sparseSecondaryMap">
        ///   The <see cref="SparseSecondaryMap{TValue}"/> to which this collection is associated.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///   Thrown if <paramref name="sparseSecondaryMap"/> is null.
        /// </exception>
        public SlotKeyCollection(SparseSecondaryMap<TKey, TValue> sparseSecondaryMap)
        {
            ArgumentNullException.ThrowIfNull(sparseSecondaryMap);
            _sparseMap = sparseSecondaryMap;
        }

        bool ICollection<TKey>.IsReadOnly => true;
        void ICollection<TKey>.Add(TKey item) => throw new NotSupportedException();
        void ICollection<TKey>.Clear() => throw new NotSupportedException();
        bool ICollection<TKey>.Remove(TKey item) => throw new NotSupportedException();
        IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator() => new Enumerator(_sparseMap);
        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(_sparseMap);

        /// <summary>
        ///   Gets the number of elements in the <see cref="SparseSecondaryMap{TKey, TValue}.SlotKeyCollection"/>.
        /// </summary>
        public int Count => _sparseMap.Count;

        /// <summary>
        ///   Determines whether the <see cref="SparseSecondaryMap{TKey, TValue}.SlotKeyCollection"/> contains a specific <see cref="SlotKey"/>.
        /// </summary>
        /// <param name="key">
        ///   The <see cref="SlotKey"/> to locate in the collection.
        /// </param>
        /// <returns>
        ///   <see langword="true"/> if the <see cref="SparseSecondaryMap{TKey, TValue}.SlotKeyCollection"/> contains the specified <paramref name="key"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Contains(TKey key) => _sparseMap.ContainsKey(key);

        /// <summary>
        ///   Copies the elements of the <see cref="SparseSecondaryMap{TKey, TValue}.SlotKeyCollection"/> to an array, starting at the specified index.
        /// </summary>
        /// <param name="array">
        ///   The one-dimensional array that is the destination of the elements copied from the <see cref="SparseSecondaryMap{TKey, TValue}.SlotKeyCollection"/>. Must not be null.
        /// </param>
        /// <param name="index">
        ///   The zero-based index in <paramref name="array"/> at which copying begins.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///   Thrown if <paramref name="array"/> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   Thrown if <paramref name="index"/> is negative, greater than or equal to the length of <paramref name="array"/>, or if there are not enough elements in the <see cref="SparseSecondaryMap{TKey, TValue}.SlotKeyCollection"/> to fill the destination array starting at the specified index.
        /// </exception>
        public void CopyTo(TKey[] array, int index)
        {
            ArgumentNullException.ThrowIfNull(array);
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
            ArgumentOutOfRangeException.ThrowIfLessThan(_sparseMap.Count, array.Length - index);

            for (int i = 0; i < _sparseMap.Capacity; i++)
            {
                var slot = _sparseMap._slots[i];

                array[index++] = TKey.New(i, slot.Version);
            }
        }

        /// <summary>
        ///   Represents an enumerator for the <see cref="SlotKeyCollection"/>.
        /// </summary>
        public struct Enumerator : IEnumerator<TKey>, IEnumerator
        {
            private readonly SparseSecondaryMap<TKey, TValue> _sparseMap;
            private int _index;
            private TKey _current;

            internal Enumerator(SparseSecondaryMap<TKey, TValue> sparseSecondaryMap)
            {
                _sparseMap = sparseSecondaryMap;
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
                while (_index < _sparseMap.Capacity)
                {
                    while (++_index < _sparseMap.Capacity)
                    {
                        var slot = _sparseMap._slots[_index];

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
