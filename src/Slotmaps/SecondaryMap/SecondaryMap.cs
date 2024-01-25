namespace FlashyDJ.Slotmaps;
/// <summary>
///   Represents a secondary slot map that associates keys of type <see cref="SlotKey"/> for efficiently
///   storing additional information for primary slot map elements.
/// </summary>
/// <typeparam name="TValue">The type of values stored in the secondary map.</typeparam>
/// <seealso cref="SlotKey"/>
/// <seealso cref="SecondaryMap{TKey,TValue}"/>
/// <seealso cref="SparseSecondaryMap{TValue}"/>
[DebuggerDisplay("Count = {Count}")]
public class SecondaryMap<TValue> : SecondaryMap<SlotKey, TValue>
{
    /// <summary>
    ///   Initializes a new instance of the <see cref="SecondaryMap{TValue}"/> class that is empty with no
    ///   initial capacity.
    /// </summary>
    public SecondaryMap() : base() {}

    /// <summary>
    ///   Initializes a new instance of the <see cref="SecondaryMap{TValue}"/> class with the specified capacity.
    /// </summary>
    /// <param name="capacity">The initial capacity of the secondary map. Must be a non-negative integer.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   Thrown if <paramref name="capacity"/> is negative.
    /// </exception>
    /// <seealso cref="Capacity"/>
    public SecondaryMap(int capacity) : base(capacity) {}

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.Capacity"/>
    public new int Capacity => base.Capacity;

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.Count"/>
    public new int Count => base.Count;

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.IsEmpty"/>
    public new bool IsEmpty => base.IsEmpty;

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.Keys"/>
    public new SlotKeyCollection Keys => base.Keys;

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.Values"/>
    public new SlotValueCollection Values => base.Values;

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.this"/>
    public new TValue this[SlotKey key]
    {
        get => base[key];
        set => base[key] = value;
    }

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.ContainsKey"/>
    public new bool ContainsKey(SlotKey key) => base.ContainsKey(key);

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.ContainsValue"/>
    public new bool ContainsValue(TValue value) => base.ContainsValue(value);

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.Clear"/>
    public new void Clear() => base.Clear();

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.Drain"/>
    public new IEnumerable<KeyValuePair<SlotKey,TValue>> Drain() => base.Drain();

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.EnsureCapacity"/>
    public new int EnsureCapacity(int capacity) => base.EnsureCapacity(capacity);

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.Get"/>
    public new TValue Get(SlotKey key) => base.Get(key);

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.Insert"/>
    public new TValue Insert(SlotKey key, TValue value) => base.Insert(key, value);

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.Remove"/>
    public new TValue Remove(SlotKey key) => base.Remove(key);

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.Reserve"/>
    public new void Reserve(int additionalSize) => base.Reserve(additionalSize);

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.Resize"/>
    public new void Resize(int newSize) => base.Resize(newSize);

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.Retain"/>
    public new void Retain(Func<SlotKey,TValue, bool> predicate) => base.Retain(predicate);

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.TryInsert"/>
    public new bool TryInsert(SlotKey key, TValue value, out TValue? oldValue) => base.TryInsert(key, value, out oldValue);

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.TryGet"/>
    public new bool TryGet(SlotKey key, [MaybeNullWhen(false)] out TValue value) => base.TryGet(key, out value);

    /// <inheritdoc cref="SecondaryMap{TKey, TValue}.TryRemove"/>
    public new bool TryRemove(SlotKey key, [MaybeNullWhen(false)] out TValue value) => base.TryRemove(key, out value);
}