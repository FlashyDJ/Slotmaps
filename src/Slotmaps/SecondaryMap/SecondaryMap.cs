namespace FlashyDJ.Slotmaps;
[DebuggerDisplay("Count = {Count}")]
public class SecondaryMap<TValue> : SecondaryMap<SlotKey, TValue>
{
    public SecondaryMap() : base() {}

    public SecondaryMap(int capacity) : base(capacity) {}
}