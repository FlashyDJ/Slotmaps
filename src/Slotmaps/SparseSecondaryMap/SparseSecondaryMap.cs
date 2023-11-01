namespace FlashyDJ.Slotmaps;
public class SparseSecondaryMap<TValue> : SparseSecondaryMap<SlotKey, TValue>
{
    public SparseSecondaryMap() : base() { }

    public SparseSecondaryMap(int capacity) : base(capacity) { }
}
