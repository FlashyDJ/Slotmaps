using System.Collections;
using System.Diagnostics;

namespace FlashyDJ.Slotmaps;
public partial class SecondaryMap<TValue>
{
    /// <include file='docs.xml' path='docs/SlotKeyCollection/*'/>
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotKeyCollection : ICollection<SlotKey>, IReadOnlyCollection<SlotKey>
    {
        private readonly SecondaryMap<TValue> _secondaryMap;

        /// <include file='docs.xml' path='docs/SKCCtor/*'/>
        public SlotKeyCollection(SecondaryMap<TValue> secondaryMap)
        {
            ArgumentNullException.ThrowIfNull(secondaryMap);
            _secondaryMap = secondaryMap;
        }

        bool ICollection<SlotKey>.IsReadOnly => true;
        void ICollection<SlotKey>.Add(SlotKey item) => throw new NotSupportedException();
        void ICollection<SlotKey>.Clear() => throw new NotSupportedException();
        bool ICollection<SlotKey>.Remove(SlotKey item) => throw new NotSupportedException();
        IEnumerator<SlotKey> IEnumerable<SlotKey>.GetEnumerator() => new Enumerator(_secondaryMap);
        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(_secondaryMap);

        /// <include file='docs.xml' path='docs/SKCCount/*'/>
        public int Count => _secondaryMap.Count;

        /// <include file='docs.xml' path='docs/SKCContains/*'/>
        public bool Contains(SlotKey key) => _secondaryMap.ContainsKey(key);

        /// <include file='docs.xml' path='docs/SKCCopyTo/*'/>
        public void CopyTo(SlotKey[] array, int index)
        {
            ArgumentNullException.ThrowIfNull(array);
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
            ArgumentOutOfRangeException.ThrowIfLessThan(_secondaryMap.Count, array.Length - index);

            for (int i = 0; i < _secondaryMap.Capacity; i++)
            {
                var slot = _secondaryMap._slots[i];

                if (slot.Occupied)
                    array[index++] = new(i, slot.Version);
            }
        }

        /// <include file='docs.xml' path='docs/SKCEnumerator/*'/>
        public struct Enumerator : IEnumerator<SlotKey>, IEnumerator
        {
            private readonly SecondaryMap<TValue> _secondaryMap;
            private int _index;
            private SlotKey _current;

            internal Enumerator(SecondaryMap<TValue> secondaryMap)
            {
                _secondaryMap = secondaryMap;
                _index = -1;
                _current = default;
            }

            object IEnumerator.Current => Current;

            /// <inheritdoc/>
            public SlotKey Current => _current;

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

                        _current = new(_index, slot.Version);
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
