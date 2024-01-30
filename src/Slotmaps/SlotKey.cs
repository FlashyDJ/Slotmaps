namespace FlashyDJ.Slotmaps;

/// <summary>
///   Represents a key used in various map structures to uniquely identify elements.
/// </summary>
/// <param name="Index">The index of the slot.</param>
/// <param name = "Version" > The version of the slot.</param>
/// <seealso cref="ISlotKey{T}"/>
public readonly record struct SlotKey(int Index, uint Version) : ISlotKey<SlotKey>
{
    /// <inheritdoc/>
    public bool IsNull => Index < 0 || Version == 0;

    /// <inheritdoc/>
    public bool Occupied => Version % 2 > 0;

    /// <inheritdoc/>
    public static SlotKey New(int index, uint version) => new(index, version);

    /// <inheritdoc/>
    public static SlotKey Null() => new(int.MinValue, 0);

    /// <inheritdoc/>
    public static ulong ToUlong(ISlotKey<SlotKey> slotKey) =>
        ((ulong)slotKey.Version << 32) | (uint)slotKey.Index;

    /// <inheritdoc/>
    public static SlotKey FromUlong<SlotKey>(ulong value)
        where SlotKey : struct, ISlotKey<SlotKey> =>
        SlotKey.New((int)value, ((uint)value >> 32) | 1);

    /// <summary>
    ///   Implicitly converts a slot key to an unsigned 64-bit integer representation.
    /// </summary>
    /// <param name="slotKey">The slot key to convert.</param>
    public static implicit operator ulong(SlotKey slotKey) =>
        ((ulong)slotKey.Version << 32) | (uint)slotKey.Index;

    /// <ImplicitFromUlong>
    ///   <summary>
    ///     Implicitly converts an unsigned 64-bit integer representation to a slot key.
    ///   </summary>
    ///   <param name="value">The unsigned 64-bit integer representation to convert.</param>
    /// </ImplicitFromUlong>
    public static implicit operator SlotKey(ulong value) =>
        new((int)value, ((uint)value >> 32) | 1);

    /// <inheritdoc cref="ISlotKey{TSelf}.ToString"/>
    public override string ToString() => $"{Index}v{Version}";
}
