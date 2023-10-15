namespace FlashyDJ.Slotmaps;
/// <include file='docs.xml' path='docs/SlotMapD/*'/>
public class SlotMap<TValue> : SlotMap<SlotKey, TValue>
{
    /// <include file='docs.xml' path='docs/SlotMapDCtor1/*'/>
    public SlotMap() : base() { }

    /// <include file='docs.xml' path='docs/SlotMapDCtor2/*'/>
    public SlotMap(int capacity) : base(capacity) { }

    /// <include file='docs.xml' path='docs/Capacity/*'/>
    public new int Capacity => base.Capacity;

    /// <include file='docs.xml' path='docs/Count/*'/>
    public new int Count => base.Count;

    /// <include file='docs.xml' path='docs/IsEmpty/*'/>
    public new bool IsEmpty => base.IsEmpty;

    /// <include file='docs.xml' path='docs/Keys/*'/>
    public new SlotKeyCollection Keys => base.Keys;

    /// <include file='docs.xml' path='docs/Values/*'/>
    public new SlotValueCollection Values => base.Values;

    /// <include file='docs.xml' path='docs/Indexer/*'/>
    public new TValue this[SlotKey key]
    {
        get => base[key];
        set => base[key] = value;
    }

    /// <include file='docs.xml' path='docs/Add/*'/>
    /// <include file='codesnippets.xml' path='code/AddD/*'/>
    public new SlotKey Add(TValue value) => base.Add(value);

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
    /// <include file='codesnippets.xml' path='docs/DrainD/*'/>
    public new IEnumerable<KeyValuePair<SlotKey,TValue>> Drain() => base.Drain();

    /// <include file='docs.xml' path='docs/EnsureCapacity/*'/>
    /// <include file='codesnippets.xml' path='docs/EnsureCapacityD/*'/>
    public new int EnsureCapacity(int capacity) => base.EnsureCapacity(capacity);

    /// <include file='docs.xml' path='docs/Get/*'/>
    /// <include file='codesnippets.xml' path='docs/GetD/*'/>
    public new TValue Get(SlotKey key) => base.Get(key);

    /// <include file='docs.xml' path='docs/Insert/*'/>
    /// <include file='codesnippets.xml' path='docs/InsertD/*'/>
    public new SlotKey Insert(SlotKey key, TValue value) => base.Insert(key, value);

    /// <include file='docs.xml' path='docs/Remove/*'/>
    /// <include file='codesnippets.xml' path='docs/RemoveD/*'/>
    public new TValue Remove(SlotKey key) => base.Remove(key);

    /// <include file='docs.xml' path='docs/Reserve/*'/>
    /// <include file='codesnippets.xml' path='docs/ReserveD/*'/>
    public new void Reserve(int additionalSize) => base.Reserve(additionalSize);

    /// <include file='docs.xml' path='docs/Resize/*'/>
    /// <include file='codesnippets.xml' path='docs/ResizeD/*'/>
    public new void Resize(int newSize) => base.Resize(newSize);

    /// <include file='docs.xml' path='docs/Retain/*'/>
    /// <include file='codesnippets.xml' path='docs/RetainD/*'/>
    public new void Retain(Func<SlotKey,TValue, bool> predicate) => base.Retain(predicate);

    /// <include file='docs.xml' path='docs/TryInsert/*'/>
    /// <include file='codesnippets.xml' path='docs/TryInsertD/*'/>
    public new bool TryInsert(SlotKey key, TValue value, out SlotKey newKey) => base.TryInsert(key, value, out newKey);

    /// <include file='docs.xml' path='docs/TryGet/*'/>
    /// <include file='codesnippets.xml' path='docs/TryGetD/*'/>
    public new bool TryGet(SlotKey key, [MaybeNullWhen(false)] out TValue value) => base.TryGet(key, out value);

    /// <include file='docs.xml' path='docs/TryRemove/*'/>
    /// <include file='codesnippets.xml' path='docs/TryRemoveD/*'/>
    public new bool TryRemove(SlotKey key, [MaybeNullWhen(false)] out TValue value) => base.TryRemove(key, out value);
}