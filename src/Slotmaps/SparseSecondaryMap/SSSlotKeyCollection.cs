using System.Collections;
using System.Diagnostics;

namespace FlashyDJ.Slotmaps;

public partial class SparseSecondaryMap<TValue>
{
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotKeyCollection : ICollection<SlotKey>, IReadOnlyCollection<SlotKey>
    {
        private readonly SparseSecondaryMap<TValue> _sparseMap;

        public SlotKeyCollection(SparseSecondaryMap<TValue> sparseSecondaryMap)
        {
            ArgumentNullException.ThrowIfNull(sparseSecondaryMap);
            _sparseMap = sparseSecondaryMap;
        }

        bool ICollection<SlotKey>.IsReadOnly => true;
        void ICollection<SlotKey>.Add(SlotKey item) => throw new NotSupportedException();
        void ICollection<SlotKey>.Clear() => throw new NotSupportedException();
        bool ICollection<SlotKey>.Remove(SlotKey item) => throw new NotSupportedException();
        IEnumerator<SlotKey> IEnumerable<SlotKey>.GetEnumerator() => new Enumerator(_sparseMap);
        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(_sparseMap);

        public int Count => _sparseMap.Count;

        public bool Contains(SlotKey key) => _sparseMap.ContainsKey(key);
        public void CopyTo(SlotKey[] array, int index)
        {
            ArgumentNullException.ThrowIfNull(array);
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
            ArgumentOutOfRangeException.ThrowIfLessThan(_sparseMap.Count, array.Length - index);

            for (int i = 0; i < _sparseMap.Capacity; i++)
            {
                var slot = _sparseMap._slots[i];

                if (slot.Occupied)
                    array[index++] = new(i, slot.Version);
            }
        }

        public struct Enumerator : IEnumerator<SlotKey>, IEnumerator
        {
            private readonly SparseSecondaryMap<TValue> _sparseMap;
            private int _index;
            private SlotKey _current;

            internal Enumerator(SparseSecondaryMap<TValue> sparseSecondaryMap)
            {
                _sparseMap = sparseSecondaryMap;
                _index = -1;
                _current = default;
            }

            object IEnumerator.Current => Current;

            public SlotKey Current => _current;

            public readonly void Dispose() { }

            public bool MoveNext()
            {
                while (_index < _sparseMap.Capacity)
                {
                    while (++_index < _sparseMap.Capacity)
                    {
                        var slot = _sparseMap._slots[_index];

                        if (!slot.Occupied)
                            break;

                        _current = new(_index, slot.Version);
                        return true;
                    }
                }
                return false;
            }

            public void Reset()
            {
                _index = -1;
                _current = default;
            }
        }
    }
}
