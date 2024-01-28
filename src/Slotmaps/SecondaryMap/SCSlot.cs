namespace FlashyDJ.Slotmaps;
public partial class SecondaryMap<TKey, TValue>
{
    [DebuggerDisplay("{ToString()}")]
    internal struct Slot(TValue value, uint version)
    {
        private TValue _value = value;

        public TValue Value
        {
            get => Occupied ? _value : throw new InvalidOperationException("Slot is vacant");
            internal set => _value = value;
        }

        public uint Version { get; internal set; } = version;

        public bool Occupied => Version != 0;

        public void SetVacant()
        {
            Value = default!;
            Version = 0;
        }

        public override string ToString() => $"{Value}v{Version}";
    }
}
