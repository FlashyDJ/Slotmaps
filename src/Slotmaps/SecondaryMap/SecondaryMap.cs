namespace FlashyDJ.Slotmaps;
/// <include file='docs.xml' path='docs/SecondaryMapD/*'/>
[DebuggerDisplay("Count = {Count}")]
public class SecondaryMap<TValue> : SecondaryMap<SlotKey, TValue>
{
    /// <include file='docs.xml' path='docs/Ctor1D/*'/>
    public SecondaryMap() : base() {}

/// <include file='docs.xml' path='docs/Ctor2D/*'/>
    public SecondaryMap(int capacity) : base(capacity) {}
}