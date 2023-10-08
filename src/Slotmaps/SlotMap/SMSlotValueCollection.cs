namespace FlashyDJ.Slotmaps;
public partial class SlotMap<TValue>
{
    /// <include file='docs.xml' path='docs/SlotValueCollection/*'/>
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotValueCollection : ICollection<TValue>, IReadOnlyCollection<TValue>
    {
        private readonly SlotMap<TValue> _slotMap;

        /// <include file='docs.xml' path='docs/SVCCtor/*'/>
        public SlotValueCollection(SlotMap<TValue> slotMap)
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

        /// <include file='docs.xml' path='docs/SVCCount/*'/>
        public int Count => _slotMap.Count;

        /// <include file='docs.xml' path='docs/SVCContains/*'/>
        public bool Contains(TValue value) => _slotMap.ContainsValue(value!);

        /// <include file='docs.xml' path='docs/SVCCopyTo/*'/>
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

        /// <include file='docs.xml' path='docs/SVCEnumerator/*'/>
        public struct Enumerator : IEnumerator<TValue>, IEnumerator
        {
            private readonly SlotMap<TValue> _slotMap;
            private int _index;
            private TValue _current;

            internal Enumerator(SlotMap<TValue> slotMap)
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

