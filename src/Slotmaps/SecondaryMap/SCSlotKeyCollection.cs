namespace FlashyDJ.Slotmaps;
public partial class SecondaryMap<TKey, TValue>
{
    /// <include file='docs.xml' path='docs/SlotKeyCollection/*'/>
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotKeyCollection : ICollection<TKey>, IReadOnlyCollection<TKey>
    {
        private readonly SecondaryMap<TKey, TValue> _secondaryMap;

        /// <include file='docs.xml' path='docs/SKCCtor/*'/>
        public SlotKeyCollection(SecondaryMap<TKey, TValue> secondaryMap)
        {
            ArgumentNullException.ThrowIfNull(secondaryMap);
            _secondaryMap = secondaryMap;
        }

        bool ICollection<TKey>.IsReadOnly => true;
        void ICollection<TKey>.Add(TKey item) => throw new NotSupportedException();
        void ICollection<TKey>.Clear() => throw new NotSupportedException();
        bool ICollection<TKey>.Remove(TKey item) => throw new NotSupportedException();
        IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator() => new Enumerator(_secondaryMap);
        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(_secondaryMap);

        /// <include file='docs.xml' path='docs/SKCCount/*'/>
        public int Count => _secondaryMap.Count;

        /// <include file='docs.xml' path='docs/SKCContains/*'/>
        public bool Contains(TKey key) => _secondaryMap.ContainsKey(key);

        /// <include file='docs.xml' path='docs/SKCCopyTo/*'/>
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

        /// <include file='docs.xml' path='docs/SKCEnumerator/*'/>
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
