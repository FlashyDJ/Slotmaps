namespace FlashyDJ.Slotmaps;
public partial class SecondaryMap<TKey, TValue>
{
    internal struct Slot(TValue value, uint version)
    {
        public static Slot NewVacant() => new(default!, 0);

        private TValue? _value = value;

        public bool Occupied => Version != 0;

        public TValue Value
        {
            get => _value ?? throw new NullReferenceException();
            internal set => _value = value;
        }

        public uint Version { get; internal set; } = version;

        public void SetVacant()
        {
            _value = default;
            Version = 0;
        }

        public override string ToString() => $"{Value}v{Version}";
    }
}
