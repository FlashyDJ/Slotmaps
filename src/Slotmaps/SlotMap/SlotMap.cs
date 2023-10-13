namespace FlashyDJ.Slotmaps;
/// <include file='docs.xml' path='docs/SlotMapSlotKey/*'/>
public partial class SlotMap<TValue> : SlotMap<SlotKey, TValue>
{
    /// <include file='docs.xml' path='docs/SlotMapSlotKeyCtor1/*'/>
    public SlotMap() : base() { }

    /// <include file='docs.xml' path='docs/SlotMapSlotKeyCtor2/*'/>
    public SlotMap(int capacity) : base(capacity) { }
}

