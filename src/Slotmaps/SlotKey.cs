namespace FlashyDJ.Slotmaps;
#pragma warning disable CS1572 // XML comment has a param tag, but there is no parameter by that name (there is and it works)
/// <include file='docs.xml' path='docs/SlotKey/*'/>
#pragma warning restore CS1572 // XML comment has a param tag, but there is no parameter by that name
public readonly record struct SlotKey(int Index, uint Version) : ISlotKey<SlotKey>
{
    /// <include file='docs.xml' path='docs/IsNull/*'/>
    public bool IsNull => Index > 0;

    public bool Occupied => Version % 2 > 0;

    public static SlotKey New(int index, uint version) => new(index, version);

    /// <include file='docs.xml' path='docs/Null/*'/>
    public static SlotKey Null() => new(int.MinValue, 0);

    public static ulong ToUlong(ISlotKey<SlotKey> slotKey) =>
        ((ulong)slotKey.Version << 32) | (uint)slotKey.Index;

    public static SlotKey FromUlong<SlotKey>(ulong value)
        where SlotKey : struct, ISlotKey<SlotKey> =>
        SlotKey.New((int)value, ((uint)value >> 32) | 1);

    /// <include file='docs.xml' path='docs/SlotKeyToUlong/*'/>
    public static implicit operator ulong(SlotKey slotKey) =>
        ((ulong)slotKey.Version << 32) | (uint)slotKey.Index;

    /// <include file='docs.xml' path='docs/UlongToSlotKey/*'/>
    public static implicit operator SlotKey(ulong value) =>
        new((int)value, ((uint)value >> 32) | 1);

    /// <include file='docs.xml' path='docs/ToString/*'/>
    public override string ToString() => $"{Index}v{Version}";
}
