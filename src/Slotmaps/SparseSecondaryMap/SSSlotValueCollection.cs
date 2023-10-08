namespace FlashyDJ.Slotmaps;
public partial class SparseSecondaryMap<TValue>
{
    /// <include file='docs.xml' path='docs/SlotValueCollection/*'/>
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotValueCollection : ICollection<TValue>, IReadOnlyCollection<TValue>
    {
        private readonly SparseSecondaryMap<TValue> _sparseMap;

        /// <include file='docs.xml' path='docs/SVCCtor/*'/>
        public SlotValueCollection(SparseSecondaryMap<TValue> sparseSecondaryMap)
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

        /// <include file='docs.xml' path='docs/SVCCount/*'/>
        public int Count => _sparseMap.Count;

        /// <include file='docs.xml' path='docs/SVCContains/*'/>
        public bool Contains(TValue value) => _sparseMap.ContainsValue(value!);

        /// <include file='docs.xml' path='docs/SVCCopyTo/*'/>
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

        /// <include file='docs.xml' path='docs/SVCEnumerator/*'/>
        public struct Enumerator : IEnumerator<TValue>, IEnumerator
        {
            private readonly SparseSecondaryMap<TValue> _sparseMap;
            private int _index;
            private TValue _current;

            internal Enumerator(SparseSecondaryMap<TValue> sparseSecondaryMap)
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
