namespace FlashyDJ.Slotmaps;

public partial class SparseSecondaryMap<TKey, TValue>
{
    [DebuggerDisplay("{ToString()}")]
    private struct Slot(TValue value, uint version)
    {
        public TValue Value = value;

        public uint Version = version;

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

