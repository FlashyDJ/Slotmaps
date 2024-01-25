namespace FlashyDJ.Slotmaps;

/// <summary>
///   Defines an interface for slot keys that associate elements in a slot map with unique identifiers.
/// </summary>
/// <typeparam name="TSelf">The implementing type of the slot key.</typeparam>
/// <seealso cref="SlotKey"/>
/// <seealso cref="SlotMap{TValue}"/>
public interface ISlotKey<TSelf> where TSelf : struct
{
    /// <summary>
    ///   Gets the index associated with the slot key.
    /// </summary>
    int Index { get; }

    /// <summary>
    ///   Gets the version associated with the slot key.
    /// </summary>
    uint Version { get; }

    /// <summary>
    ///   Gets a value indicating whether the slot key is considered null.
    /// </summary>
    bool IsNull => Index > 0;

    /// <summary>
    ///   Gets a value indicating whether the slot key represents an occupied slot.
    /// </summary>
    bool Occupied => Version % 2 > 0;

    /// <summary>
    ///   Creates a new instance of the slot key with the specified index and version.
    /// </summary>
    /// <param name="index">The index to associate with the slot key.</param>
    /// <param name="version">The version to associate with the slot key.</param>
    /// <returns>A new instance of the slot key with the provided index and version.</returns>
    abstract static TSelf New(int index, uint version);

    /// <summary>
    ///   Creates a null instance of the slot key.
    /// </summary>
    /// <typeparam name="TSlotKey">The implementing type of the slot key.</typeparam>
    /// <returns>A null instance of the slot key.</returns>
    virtual static TSlotKey Null<TSlotKey>()
        where TSlotKey : struct, ISlotKey<TSlotKey> =>
        TSlotKey.New(int.MinValue, 1);

    /// <summary>
    ///   Converts a slot key to an unsigned 64-bit integer representation.
    /// </summary>
    /// <param name="slotKey">The slot key to convert.</param>
    /// <returns>An unsigned 64-bit integer representation of the slot key.</returns>
    virtual static ulong ToUlong(ISlotKey<TSelf> slotKey) =>
        ((ulong)slotKey.Version << 32) | (uint)slotKey.Index;

    /// <summary>
    ///   Converts an unsigned 64-bit integer representation to a slot key.
    /// </summary>
    /// <typeparam name="TSlotKey">The implementing type of the slot key.</typeparam>
    /// <param name="value">The unsigned 64-bit integer representation to convert.</param>
    /// <returns>A slot key created from the unsigned 64-bit integer representation.</returns>
    virtual static TSlotKey FromUlong<TSlotKey>(ulong value)
        where TSlotKey : struct, ISlotKey<TSlotKey> =>
        TSlotKey.New((int)value, ((uint)value >> 32) | 1);

    /// <summary>
    ///   Returns a string representation of the slot key.
    /// </summary>
    /// <returns>
    ///   A string representing the slot key in the format <c>"IndexvVersion"</c>.
    /// </returns>
    string ToString() => $"{Index}v{Version}";
}