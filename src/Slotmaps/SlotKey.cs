namespace FlashyDJ.Slotmaps;
#pragma warning disable CS1572 // XML comment has a param tag, but there is no parameter by that name (there is and it works)
/// <include file='docs.xml' path='docs/SlotKey/*'/>
#pragma warning restore CS1572 // XML comment has a param tag, but there is no parameter by that name
public readonly record struct SlotKey(uint Index, uint Version) : ISlotKey<SlotKey>
{
    public static SlotKey New(uint index, uint version) => new(index, version);

    public bool Occupied => Version % 2 > 0;

    /// <include file='docs.xml' path='docs/IsNull/*'/>
    public bool IsNull => Index == uint.MaxValue;

    /// <include file='docs.xml' path='docs/Null/*'/>
    public static SlotKey Null() => new(uint.MinValue, 0);

    public static ulong ToUlong(ISlotKey<SlotKey> slotKey) =>
        ((ulong)slotKey.Version << 32) | slotKey.Index;

    public static SlotKey FromUlong<SlotKey>(ulong value)
        where SlotKey : struct, ISlotKey<SlotKey> =>
        SlotKey.New((uint)value, ((uint)value >> 32) | 1);

    /// <include file='docs.xml' path='docs/SlotKeyToUlong/*'/>
    public static implicit operator ulong(SlotKey slotKey) =>
        ((ulong)slotKey.Version << 32) | slotKey.Index;

    /// <include file='docs.xml' path='docs/UlongToSlotKey/*'/>
    public static implicit operator SlotKey(ulong value) =>
        new((uint)value, ((uint)value >> 32) | 1);

    /// <include file='docs.xml' path='docs/ToString/*'/>
    public override string ToString() => $"{Index}v{Version}";
}
