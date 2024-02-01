namespace FlashyDJ.Slotmaps;

public partial class SparseSecondaryMap<TKey, TValue>
{
    /// <summary>
    ///   Represents a read only collection of <see cref="ISlotKey{TKey}"/> instances associated with
    ///   a <see cref="SparseSecondaryMap{TKey, TValue}"/>.
    /// </summary>
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotKeyCollection : ICollection<TKey>, IReadOnlyCollection<TKey>
    {
        private readonly SparseSecondaryMap<TKey, TValue> _sparseMap;

        /// <summary>
        ///   Initializes a new instance of the <see cref="SlotKeyCollection"/> class with a reference
        ///   to the parent <see cref="SparseSecondaryMap{TValue}"/>.
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
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        ///   Gets the number of elements in the <see cref="SlotKeyCollection"/>.
        /// </summary>
        public int Count => _sparseMap.Count;

        /// <summary>
        ///   Determines whether the <see cref="SlotKeyCollection"/> contains a specific <see cref="SlotKey"/>.
        /// </summary>
        /// <param name="key">
        ///   The <see cref="SlotKey"/> to locate in the collection.
        /// </param>
        /// <returns>
        ///   <see langword="true"/> if the <see cref="SlotKeyCollection"/> contains the specified
        ///   <paramref name="key"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Contains(TKey key) => _sparseMap.ContainsKey(key);

        /// <summary>
        ///   Copies the elements of the <see cref="SlotKeyCollection"/> to an array, starting at the
        ///   specified index.
        /// </summary>
        /// <param name="array">
        ///   The one-dimensional array that is the destination of the elements copied from the
        ///   <see cref="SlotKeyCollection"/>. Must not be null.
        /// </param>
        /// <param name="index">
        ///   The zero-based index in <paramref name="array"/> at which copying begins.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///   Thrown if <paramref name="array"/> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///   Thrown if <paramref name="index"/> is negative, greater than or equal to the length of
        ///   <paramref name="array"/>, or if there are not enough elements in the
        ///   <see cref="SlotKeyCollection"/> to fill the destination array
        ///   starting at the specified index.
        /// </exception>
        public void CopyTo(TKey[] array, int index)
        {
            ArgumentNullException.ThrowIfNull(array);
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
            ArgumentOutOfRangeException.ThrowIfLessThan(_sparseMap.Count, array.Length - index);

            foreach (var (key, slot) in _sparseMap._slots)
                array[index++] = TKey.New(key, slot.Version);
        }

        /// <inheritdoc/>
        public IEnumerator<TKey> GetEnumerator()
        {
            foreach (var (key, slot) in _sparseMap._slots)
                yield return TKey.New(key, slot.Version);
        }
    }
}
