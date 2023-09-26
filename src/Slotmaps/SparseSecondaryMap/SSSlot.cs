using System.Diagnostics;

namespace FlashyDJ.Slotmaps;
public partial class SparseSecondaryMap<TValue>
{
    [DebuggerDisplay("{ToString()}")]
    internal struct Slot<TValue>(TValue value, int version)
    {
        private TValue? _value = value;

        public TValue Value
        {
            get => _value ?? throw new InvalidOperationException("Slot is empty");
            internal set => _value = value!;
        }

        public int Version { get; internal set; } = version;

        public bool Occupied => Version > 0;

        public void SetVacant()
        {
            _value = default;
            Version = -1;
        }

        public override string ToString() => $"{Value}v{Version}";
    }
}

