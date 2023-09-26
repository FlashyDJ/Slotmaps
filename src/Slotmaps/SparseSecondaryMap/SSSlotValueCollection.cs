using System.Collections;
using System.Diagnostics;

namespace FlashyDJ.Slotmaps;

public partial class SparseSecondaryMap<TValue>
{
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotValueCollection : ICollection<TValue>, IReadOnlyCollection<TValue>
    {
        private readonly SparseSecondaryMap<TValue> _sparseMap;

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

        public int Count => _sparseMap.Count;

        public bool Contains(TValue value) => _sparseMap.ContainsValue(value!);
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

            public TValue Current => _current;

            public void Dispose() { }

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

            public void Reset()
            {
                _index = -1;
                _current = default!;
            }
        }
    }
}
