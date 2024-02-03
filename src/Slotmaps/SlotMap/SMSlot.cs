namespace FlashyDJ.Slotmaps;
public partial class SlotMap<TKey, TValue>
{
    [DebuggerDisplay("{ToString()}")]
    private struct Slot(TValue value, uint version)
    {
        public TValue Value = value;

        public uint Version = version;

        public int NextFree;

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