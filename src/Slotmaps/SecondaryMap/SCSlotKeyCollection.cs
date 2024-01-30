namespace FlashyDJ.Slotmaps;
public partial class SecondaryMap<TKey, TValue>
{
    /// <summary>
    ///   Represents a read only collection of <see cref="ISlotKey{TKey}"/> instances associated with a <see cref="SecondaryMap{TKey, TValue}"/>.
    /// </summary>
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotKeyCollection : ICollection<TKey>, IReadOnlyCollection<TKey>
    {
        private readonly SecondaryMap<TKey, TValue> _secondaryMap;

        /// <summary>
        ///   Initializes a new instance of the <see cref="SecondaryMap{TKey, TValue}.SlotKeyCollection"/> class with a reference to the parent <see cref="SecondaryMap{TKey, TValue}"/>.
        /// </summary>
        /// <param name="secondaryMap">
        ///   The <see cref="SecondaryMap{TKey, TValue}"/> to which this collection is associated.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///   Thrown if <paramref name="secondaryMap"/> is null.
        /// </exception>
        public SlotKeyCollection(SecondaryMap<TKey, TValue> secondaryMap)
        {
            ArgumentNullException.ThrowIfNull(secondaryMap);
            _secondaryMap = secondaryMap;
        }

        bool ICollection<TKey>.IsReadOnly => true;
        void ICollection<TKey>.Add(TKey item) => throw new NotSupportedException();
        void ICollection<TKey>.Clear() => throw new NotSupportedException();
        bool ICollection<TKey>.Remove(TKey item) => throw new NotSupportedException();
        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(_secondaryMap);

        /// <summary>
        ///   Gets the number of elements in the <see cref="SecondaryMap{TKey, TValue}.SlotKeyCollection"/>.
        /// </summary>
        public int Count => _secondaryMap.Count;

        /// <summary>
        ///   Determines whether the <see cref="SecondaryMap{TKey, TValue}.SlotKeyCollection"/> contains a specific <see cref="SlotKey"/>.
        /// </summary>
        /// <param name="key">
        ///   The <see cref="SlotKey"/> to locate in the collection.
        /// </param>
        /// <returns>
        ///   <see langword="true"/> if the <see cref="SecondaryMap{TKey, TValue}.SlotKeyCollection"/> contains the specified <paramref name="key"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Contains(TKey key) => _secondaryMap.ContainsKey(key);

        /// <summary>
        ///   Copies the elements of the <see cref="SecondaryMap{TKey, TValue}.SlotKeyCollection"/> to an array, starting at the specified index.
        /// </summary>
        /// <param name="array">
        ///   The one-dimensional array that is the destination of the elements copied from the <see cref="SecondaryMap{TKey, TValue}.SlotKeyCollection"/>. Must not be null.
        /// </param>
        /// <param name="index">
        ///   The zero-based index in <paramref name="array"/> at which copying begins.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///   Thrown if <paramref name="array"/> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   Thrown if <paramref name="index"/> is negative, greater than or equal to the length of <paramref name="array"/>, or if there are not enough elements in the <see cref="SecondaryMap{TKey, TValue}.SlotKeyCollection"/> to fill the destination array starting at the specified index.
        /// </exception>
        public void CopyTo(TKey[] array, int index)
        {
            ArgumentNullException.ThrowIfNull(array);
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
            ArgumentOutOfRangeException.ThrowIfLessThan(_secondaryMap.Count, array.Length - index);

            for (int i = 0; i < _secondaryMap.Capacity; i++)
            {
                var slot = _secondaryMap._slots[i];

                if (slot.Occupied)
                    array[index++] = TKey.New(i, slot.Version);
            }
        }

        /// <inheritdoc/>
        public IEnumerator<TKey> GetEnumerator() => new Enumerator(_secondaryMap);

        /// <summary>
        ///   Represents an enumerator for the <see cref="SlotKeyCollection"/>.
        /// </summary>
        public struct Enumerator : IEnumerator<TKey>, IEnumerator
        {
            private readonly SecondaryMap<TKey, TValue> _secondaryMap;
            private int _index;
            private TKey _current;

            internal Enumerator(SecondaryMap<TKey, TValue> secondaryMap)
            {
                _secondaryMap = secondaryMap;
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
                while (_index < _secondaryMap.Capacity)
                {
                    while (++_index < _secondaryMap.Capacity)
                    {
                        var slot = _secondaryMap._slots[_index];

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
