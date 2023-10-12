namespace FlashyDJ.Slotmaps;
/// <include file='docs.xml' path='docs/SlotKey/*'/>
/// <param name="Index">The index of the slot.</param>
/// <param name = "Version" > The version of the slot.</param>
public readonly record struct SlotKey(int Index, uint Version) : ISlotKey<SlotKey>
{
    /// <inheritdoc/>
    public bool IsNull => Index < 0;

    /// <inheritdoc/>
    public bool Occupied => Version % 2 > 0;

    /// <inheritdoc/>
    public static SlotKey New(int index, uint version) => new(index, version);

    /// <inheritdoc/> <include file='docs.xml' path='docs/Null/*'/>
    public static SlotKey Null() => new(int.MinValue, 0);

    /// <inheritdoc/>
    public static ulong ToUlong(ISlotKey<SlotKey> slotKey) =>
        ((ulong)slotKey.Version << 32) | (uint)slotKey.Index;

    /// <inheritdoc/>
    public static SlotKey FromUlong<SlotKey>(ulong value)
        where SlotKey : struct, ISlotKey<SlotKey> =>
        SlotKey.New((int)value, ((uint)value >> 32) | 1);

    /// <include file='docs.xml' path='docs/ImplicitToUlong/*'/>
    public static implicit operator ulong(SlotKey slotKey) =>
        ((ulong)slotKey.Version << 32) | (uint)slotKey.Index;

    /// <include file='docs.xml' path='docs/ImplicitFromUlong/*'/>
    public static implicit operator SlotKey(ulong value) =>
        new((int)value, ((uint)value >> 32) | 1);

    /// <inheritdoc cref="ISlotKey{TSelf}.ToString"/>
    public override string ToString() => $"{Index}v{Version}";
}
