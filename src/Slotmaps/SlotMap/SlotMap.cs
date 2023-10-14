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
    public new SlotKey Add(TValue value) => base.Add(value);

    /// <include file='docs.xml' path='docs/ContainsKey/*'/>
    public new bool ContainsKey(SlotKey key) => base.ContainsKey(key);

    /// <include file='docs.xml' path='docs/ContainsValue/*'/>
    public new bool ContainsValue(TValue value) => base.ContainsValue(value);

    /// <include file='docs.xml' path='docs/Clear/*'/>
    public new void Clear() => base.Clear();

    /// <include file='docs.xml' path='docs/Drain/*'/>
    public new IEnumerable<KeyValuePair<SlotKey,TValue>> Drain() => base.Drain();

    /// <include file='docs.xml' path='docs/EnsureCapacity/*'/>
    public new int EnsureCapacity(int capacity) => base.EnsureCapacity(capacity);

    /// <include file='docs.xml' path='docs/Get/*'/>
    public new TValue Get(SlotKey key) => base.Get(key);

    /// <include file='docs.xml' path='docs/Insert/*'/>
    public new SlotKey Insert(SlotKey key, TValue value) => base.Insert(key, value);

    /// <include file='docs.xml' path='docs/Remove/*'/>
    public new TValue Remove(SlotKey key) => Remove(key);

    /// <include file='docs.xml' path='docs/Reserve/*'/>
    public new void Reserve(int additionalSize) => Reserve(additionalSize);

    /// <include file='docs.xml' path='docs/Resize/*'/>
    public new void Resize(int newSize) => base.Resize(newSize);

    /// <include file='docs.xml' path='docs/Retain/*'/>
    public new void Retain(Func<SlotKey,TValue, bool> predicate) => base.Retain(predicate);

    /// <include file='docs.xml' path='docs/TryInsert/*'/>
    public new bool TryInsert(SlotKey key, TValue value, out SlotKey newKey) => base.TryInsert(key, value, out newKey);

    /// <include file='docs.xml' path='docs/TryGet/*'/>
    public new bool TryGet(SlotKey key, [MaybeNullWhen(false)] out TValue value) => base.TryGet(key, out value);

    /// <include file='docs.xml' path='docs/TryRemove/*'/>
    public new bool TryRemove(SlotKey key, [MaybeNullWhen(false)] out TValue value) => base.TryRemove(key, out value);
}