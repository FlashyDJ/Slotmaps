namespace FlashyDJ.Slotmaps;
public partial class SecondaryMap<TKey, TValue>
{
    [DebuggerDisplay("{ToString()}")]
    private struct Slot(TValue value, uint version)
    {
        public TValue Value = value;

        public uint Version = version;

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
