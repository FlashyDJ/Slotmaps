namespace FlashyDJ.Slotmaps;
/// <include file='docs.xml' path='docs/SlotMapD/*'/>
public class SlotMap<TValue> : SlotMap<SlotKey, TValue>
{
    /// <include file='docs.xml' path='docs/SlotMapDCtor1/*'/>
    public SlotMap() : base() { }

    /// <include file='docs.xml' path='docs/SlotMapDCtor2/*'/>
    public SlotMap(int capacity) : base(capacity) { }

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Capacity"/>
    public new int Capacity => base.Capacity;

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Count"/>
    public new int Count => base.Count;

    /// <inheritdoc cref="SlotMap{TKey, TValue}.IsEmpty"/>
    public new bool IsEmpty => base.IsEmpty;

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Keys"/>
    public new SlotKeyCollection Keys => base.Keys;

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Values"/>
    public new SlotValueCollection Values => base.Values;

    /// <include file='docs.xml' path='docs/Indexer/*'/>
    public new TValue this[SlotKey key]
    {
        get => base[key];
        set => base[key] = value;
    }

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Add"/>
    public new SlotKey Add(TValue value) => base.Add(value);

    /// <inheritdoc cref="SlotMap{TKey, TValue}.ContainsKey"/>
    public new bool ContainsKey(SlotKey key) => base.ContainsKey(key);

    /// <inheritdoc cref="SlotMap{TKey, TValue}.ContainsValue"/>
    public new bool ContainsValue(TValue value) => base.ContainsValue(value);

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Clear"/>
    public new void Clear() => base.Clear();

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Drain"/>
    public new IEnumerable<KeyValuePair<SlotKey,TValue>> Drain() => base.Drain();

    /// <inheritdoc cref="SlotMap{TKey, TValue}.EnsureCapacity"/>
    public new int EnsureCapacity(int capacity) => base.EnsureCapacity(capacity);

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Get"/>
    public new TValue Get(SlotKey key) => base.Get(key);

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Insert"/>
    public new SlotKey Insert(SlotKey key, TValue value) => base.Insert(key, value);

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Remove"/>
    public new TValue Remove(SlotKey key) => Remove(key);

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Reserve"/>
    public new void Reserve(int additionalSize) => Reserve(additionalSize);

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Resize"/>
    public new void Resize(int newSize) => base.Resize(newSize);

    /// <inheritdoc cref="SlotMap{TKey, TValue}.Retain"/>
    public new void Retain(Func<SlotKey,TValue, bool> predicate) => base.Retain(predicate);

    /// <inheritdoc cref="SlotMap{TKey, TValue}.TryInsert"/>
    public new bool TryInsert(SlotKey key, TValue value, out SlotKey newKey) => base.TryInsert(key, value, out newKey);

    /// <inheritdoc cref="SlotMap{TKey, TValue}.TryGet"/>
    public new bool TryGet(SlotKey key, [MaybeNullWhen(false)] out TValue value) => base.TryGet(key, out value);

    /// <inheritdoc cref="SlotMap{TKey, TValue}.TryRemove"/>
    public new bool TryRemove(SlotKey key, [MaybeNullWhen(false)] out TValue value) => base.TryRemove(key, out value);
}