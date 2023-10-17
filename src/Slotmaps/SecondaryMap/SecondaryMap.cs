namespace FlashyDJ.Slotmaps;
/// <include file='docs.xml' path='docs/SecondaryMapD/*'/>
/// <include file='codesnippets.xml' path='code/SecondaryMapD/*'/>
[DebuggerDisplay("Count = {Count}")]
public class SecondaryMap<TValue> : SecondaryMap<SlotKey, TValue>
{
    /// <include file='docs.xml' path='docs/Ctor1D/*'/>
    public SecondaryMap() : base() {}

    /// <include file='docs.xml' path='docs/Ctor2D/*'/>
    public SecondaryMap(int capacity) : base(capacity) {}

    /// <include file='docs.xml' path='docs/Capacity/*'/>
    /// <include file='codesnippets.xml' path='code/CapacityD/*'/>
    public new int Capacity => base.Capacity;

    /// <include file='docs.xml' path='docs/Count/*'/>
    /// <include file='codesnippets.xml' path='code/CountD/*'/>
    public new int Count => base.Count;

    /// <include file='docs.xml' path='docs/IsEmpty/*'/>
    /// <include file='codesnippets.xml' path='code/IsEmptyD/*'/>
    public new bool IsEmpty => base.IsEmpty;

    /// <include file='docs.xml' path='docs/Keys/*'/>
    /// <include file='codesnippets.xml' path='code/KeysD/*'/>
    public new SlotKeyCollection Keys => base.Keys;

    /// <include file='docs.xml' path='docs/Values/*'/>
    /// <include file='codesnippets.xml' path='code/ValuesD/*'/>
    public new SlotValueCollection Values => base.Values;

    /// <include file='docs.xml' path='docs/Indexer/*'/>
    /// <include file='codesnippets.xml' path='code/IndexerD/*'/>
    public new TValue this[SlotKey key]
    {
        get => base[key];
        set => base[key] = value;
    }

    /// <include file='docs.xml' path='docs/ContainsKey/*'/>
    /// <include file='codesnippets.xml' path='code/ContainsKeyD/*'/>
    public new bool ContainsKey(SlotKey key) => base.ContainsKey(key);

    /// <include file='docs.xml' path='docs/ContainsValue/*'/>
    /// <include file='codesnippets.xml' path='code/ContainsValueD/*'/>
    public new bool ContainsValue(TValue value) => base.ContainsValue(value);

    /// <include file='docs.xml' path='docs/Clear/*'/>
    /// <include file='codesnippets.xml' path='code/ClearD/*'/>
    public new void Clear() => base.Clear();

    /// <include file='docs.xml' path='docs/Drain/*'/>
    /// <include file='codesnippets.xml' path='code/DrainD/*'/>
    public new IEnumerable<KeyValuePair<SlotKey,TValue>> Drain() => base.Drain();

    /// <include file='docs.xml' path='docs/EnsureCapacity/*'/>
    /// <include file='codesnippets.xml' path='code/EnsureCapacityD/*'/>
    public new int EnsureCapacity(int capacity) => base.EnsureCapacity(capacity);

    /// <include file='docs.xml' path='docs/Get/*'/>
    /// <include file='codesnippets.xml' path='code/GetD/*'/>
    public new TValue Get(SlotKey key) => base.Get(key);

    /// <include file='docs.xml' path='docs/Insert/*'/>
    /// <include file='codesnippets.xml' path='code/InsertD/*'/>
    public new TValue Insert(SlotKey key, TValue value) => base.Insert(key, value);

    /// <include file='docs.xml' path='docs/Remove/*'/>
    /// <include file='codesnippets.xml' path='code/RemoveD/*'/>
    public new TValue Remove(SlotKey key) => base.Remove(key);

    /// <include file='docs.xml' path='docs/Reserve/*'/>
    /// <include file='codesnippets.xml' path='code/ReserveD/*'/>
    public new void Reserve(int additionalSize) => base.Reserve(additionalSize);

    /// <include file='docs.xml' path='docs/Resize/*'/>
    /// <include file='codesnippets.xml' path='code/ResizeD/*'/>
    public new void Resize(int newSize) => base.Resize(newSize);

    /// <include file='docs.xml' path='docs/Retain/*'/>
    /// <include file='codesnippets.xml' path='code/RetainD/*'/>
    public new void Retain(Func<SlotKey,TValue, bool> predicate) => base.Retain(predicate);

    /// <include file='docs.xml' path='docs/TryInsert/*'/>
    /// <include file='codesnippets.xml' path='code/TryInsertD/*'/>
    public new bool TryInsert(SlotKey key, TValue value, out TValue? oldValue) => base.TryInsert(key, value, out oldValue);

    /// <include file='docs.xml' path='docs/TryGet/*'/>
    /// <include file='codesnippets.xml' path='code/TryGetD/*'/>
    public new bool TryGet(SlotKey key, [MaybeNullWhen(false)] out TValue value) => base.TryGet(key, out value);

    /// <include file='docs.xml' path='docs/TryRemove/*'/>
    /// <include file='codesnippets.xml' path='code/TryRemoveD/*'/>
    public new bool TryRemove(SlotKey key, [MaybeNullWhen(false)] out TValue value) => base.TryRemove(key, out value);
}