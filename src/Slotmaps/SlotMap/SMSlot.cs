namespace FlashyDJ.Slotmaps;
public partial class SlotMap<TKey, TValue>
{
    internal struct Slot(TValue value, uint version)
    {
        private TValue _value = value;

        public TValue Value
        {
            get => Occupied ? _value : throw new InvalidOperationException();
            internal set => _value = value!;
        }

        public int NextFree { get; internal set; }

        public uint Version { get; internal set; } = version;

        public bool Occupied => Version % 2 > 0;

        public override string ToString() => $"{Value}v{Version}";
    }
}