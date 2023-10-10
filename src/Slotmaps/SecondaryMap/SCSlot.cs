namespace FlashyDJ.Slotmaps;
public partial class SecondaryMap<TValue>
{
    internal struct Slot(TValue value, int version)
    {
        public static Slot NewVacant() => new(default!, -1);

        private TValue? _value = value;

        public bool Occupied => Version > 0;

        public TValue Value
        {
            get => _value ?? throw new NullReferenceException();
            internal set => _value = value;
        }

        public int Version { get; internal set; } = version;

        public void SetVacant()
        {
            _value = default;
            Version = -1;
        }

        public override string ToString() => $"{Value}v{Version}";
    }
}
