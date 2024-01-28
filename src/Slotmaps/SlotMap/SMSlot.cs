namespace FlashyDJ.Slotmaps;
public partial class SlotMap<TKey, TValue>
{
    internal struct Slot(TValue value, uint version)
    {
        private TValue _value = value;

        public TValue Value
        {
            get => Occupied ? _value : throw new InvalidOperationException("Slot is empty");
            set => _value = value;
        }

        public uint Version { get; private set; } = version;

        public int NextFree { get; private set; }

        public readonly bool Occupied => Version % 2 > 0;

        public TValue Clear(int nextFree)
        {
            var value = Value;
            Value = default!;
            NextFree = nextFree;
            Version++;
            return value;
        }

        public uint Update(TValue value)
        {
            Value = value;
            return Version += Occupied ? 2u : 1u;
        }

        public override string ToString() => $"{Value}v{Version}";
    }
}