namespace FlashyDJ.Slotmaps;

/// <summary>
///   Represents a secondary slot map that associates keys of type <see cref="SlotKey"/> for efficiently
///   storing additional information for primary slot map elements with values of type <typeparamref name="TValue"/>.
/// </summary>
/// <typeparam name="TValue">The type of values stored in the secondary map.</typeparam>
/// <seealso cref="SlotKey"/>
/// <seealso cref="SecondaryMap{TKey,TValue}"/>
[DebuggerDisplay("Count = {Count}")]
public class SecondaryMap<TValue> : SecondaryMap<SlotKey, TValue>
{
    /// <summary>
    ///   Initializes a new instance of the <see cref="SecondaryMap{TValue}"/> class that is empty with no
    ///   initial capacity.
    /// </summary>
    public SecondaryMap() : base() { }

    /// <summary>
    ///   Initializes a new instance of the <see cref="SecondaryMap{TValue}"/> class with the specified capacity.
    /// </summary>
    /// <param name="capacity">The initial capacity of the secondary map. Must be a non-negative integer.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   Thrown if <paramref name="capacity"/> is negative.
    /// </exception>
    public SecondaryMap(int capacity) : base(capacity) { }
}