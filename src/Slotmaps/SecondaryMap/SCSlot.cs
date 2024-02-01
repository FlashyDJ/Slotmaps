namespace FlashyDJ.Slotmaps;
public partial class SecondaryMap<TKey, TValue>
{
    [DebuggerDisplay("{ToString()}")]
    internal struct Slot(TValue value, uint version)
    {
        private TValue _value = value;

        public TValue Value
        {
            get => Occupied ? _value : throw new InvalidOperationException("Slot is empty");
            private set => _value = value;
        }

        public uint Version { get; private set; } = version;

        public readonly bool Occupied => Version != 0;

        public TValue Clear()
        {
            var returnValue = Value;
            Value = default!;
            Version = 0;
            return returnValue;
        }

        public TValue Update(TValue value, uint version)
        {
            var returnValue = Occupied ? Value : value;
            Value = value;
            Version = version;
            return returnValue;
        }

        public override string ToString() => $"{Value}v{Version}";
    }
}
