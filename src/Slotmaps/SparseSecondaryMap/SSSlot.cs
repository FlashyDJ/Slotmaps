namespace FlashyDJ.Slotmaps;

public partial class SparseSecondaryMap<TKey, TValue>
{
    [DebuggerDisplay("{ToString()}")]
    internal struct Slot(TValue value, uint version)
    {
        public TValue Value { get; private set; } = value;

        public uint Version { get; private set; } = version;

        public TValue Update(TValue value, uint version)
        {
            var returnValue = Version != 0 ? Value : value;
            Value = value;
            Version = version;
            return returnValue;
        }

        public override string ToString() => $"{Value}v{Version}";
    }
}

