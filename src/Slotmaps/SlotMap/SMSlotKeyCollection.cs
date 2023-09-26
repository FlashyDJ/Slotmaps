using System.Collections;
using System.Diagnostics;

namespace FlashyDJ.Slotmaps;
public partial class SlotMap<TValue>
{
    [DebuggerDisplay("Count = {Count}")]
    public sealed class SlotKeyCollection : ICollection<SlotKey>, IReadOnlyCollection<SlotKey>
    {
        private readonly SlotMap<TValue> _slotMap;

        public SlotKeyCollection(SlotMap<TValue> slotMap)
        {
            ArgumentNullException.ThrowIfNull(slotMap);
            _slotMap = slotMap;
        }

        bool ICollection<SlotKey>.IsReadOnly => true;
        void ICollection<SlotKey>.Add(SlotKey item) => throw new NotSupportedException();
        void ICollection<SlotKey>.Clear() => throw new NotSupportedException();
        bool ICollection<SlotKey>.Remove(SlotKey item) => throw new NotSupportedException();
        IEnumerator<SlotKey> IEnumerable<SlotKey>.GetEnumerator() => new Enumerator(_slotMap);
        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(_slotMap);

        public int Count => _slotMap.Count;

        public bool Contains(SlotKey key) => _slotMap.ContainsKey(key);
        public void CopyTo(SlotKey[] array, int index)
        {
            ArgumentNullException.ThrowIfNull(array);
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(index, array.Length);
            ArgumentOutOfRangeException.ThrowIfLessThan(_slotMap.Count, array.Length - index);

            for (int i = 0; i < _slotMap.Capacity; i++)
            {
                var slot = _slotMap._slots[i];

                if (slot.Occupied)
                    array[index++] = new(i, slot.Version);
            }
        }

        public struct Enumerator : IEnumerator<SlotKey>, IEnumerator
        {
            private readonly SlotMap<TValue> _slotMap;
            private int _index;
            private SlotKey _current;

            internal Enumerator(SlotMap<TValue> slotMap)
            {
                _slotMap = slotMap;
                _index = -1;
                _current = default;
            }

            object IEnumerator.Current => Current;

            public SlotKey Current => _current;

            public readonly void Dispose() { }

            public bool MoveNext()
            {
                while (_index < _slotMap.Capacity)
                {
                    while (++_index < _slotMap.Capacity)
                    {
                        var slot = _slotMap._slots[_index];

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

