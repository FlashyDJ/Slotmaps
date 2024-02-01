namespace FlashyDJ.Slotmaps;

/// <summary>
///   Represents a slot map that associates keys of type <see cref="SlotKey"/>
///   with values of type <typeparamref name="TValue"/>.
/// </summary>
/// <typeparam name="TValue">The type of values stored in the slot map.</typeparam>
/// <seealso cref="SlotKey"/>
/// <seealso cref="SlotMap{TKey, TValue}"/>
[DebuggerDisplay("Count = {Count}")]
public class SlotMap<TValue> : SlotMap<SlotKey, TValue>
{
    /// <summary>
    ///   Initializes a new instance of the <see cref="SlotMap{TValue}"/> class that is empty with no
    ///   initial capacity.
    /// </summary>
    public SlotMap() : base() { }

    /// <summary>
    ///   Initializes a new instance of the <see cref="SlotMap{TValue}"/> class with the specified capacity.
    /// </summary>
    /// <param name="capacity">The initial capacity of the slot map. Must be a non-negative integer.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   Thrown if <paramref name="capacity"/> is negative.
    /// </exception>
    public SlotMap(int capacity) : base(capacity) { }
}