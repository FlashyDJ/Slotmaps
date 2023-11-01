using System.Diagnostics;

namespace FlashyDJ.Slotmaps;
public partial class SparseSecondaryMap<TKey, TValue>
{
    [DebuggerDisplay("{ToString()}")]
    internal struct Slot(TValue value, uint version)
    {
        private TValue? _value = value;

        public TValue Value
        {
            get => _value ?? throw new InvalidOperationException("Slot is empty");
            internal set => _value = value!;
        }

        public uint Version { get; internal set; } = version;

        public bool Occupied => Version != 0;

        public void SetVacant()
        {
            _value = default;
            Version = 0;
        }

        public override string ToString() => $"{Value}v{Version}";
    }
}

