namespace FlashyDJ.Slotmaps;
public partial class SlotMap<TValue> : SlotMap<SlotKey, TValue>
{
    public SlotMap() : base() { }

    public SlotMap(int capacity) : base(capacity) { }
}

