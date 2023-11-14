namespace FlashyDJ.Slotmaps;
public partial class SparseSecondaryMap<TKey, TValue>
{
    [DebuggerDisplay("{ToString()}")]
    internal struct Slot(TValue value, uint version)
    {
        private TValue _value = value;
        private bool vacant;

        public TValue Value
        {
            get => Occupied ? _value : throw new InvalidOperationException("Slot is vacant");
            internal set => _value = value;
        }

        public uint Version { get; internal set; } = version;

        public bool Vacant
        {
            get => vacant;
            set
            {
                if (value)
                    Value = default!;

                vacant = value;
            }
        }

        public bool Occupied => !vacant;

        public override string ToString() => $"{Value}v{Version}";
    }
}

