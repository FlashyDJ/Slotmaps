namespace FlashyDJ.Slotmaps;
#pragma warning disable CS1572 // XML comment has a param tag, but there is no parameter by that name (there is and it works)
/// <include file='docs.xml' path='docs/SlotKey/*'/>
#pragma warning restore CS1572 // XML comment has a param tag, but there is no parameter by that name
public readonly record struct SlotKey(int Index, int Version)
{
    /// <include file='docs.xml' path='docs/Null/*'/>
    public static SlotKey Null => new(int.MinValue, 0);

    /// <include file='docs.xml' path='docs/IsNull/*'/>
    public bool IsNull => Index == int.MinValue;

    /// <include file='docs.xml' path='docs/IsInvalid/*'/>
    public bool IsInvalid => Index < 0 || Version < 0 || IsNull;

    /// <include file='docs.xml' path='docs/SlotKeyToUlong/*'/>
    public static implicit operator ulong(SlotKey slotKey) =>
        ((ulong)slotKey.Version << 32) | (ulong)slotKey.Index;

    /// <include file='docs.xml' path='docs/UlongToSlotKey/*'/>
    public static implicit operator SlotKey(ulong value) =>
        new((int)value, ((int)value >> 32) | 1);

    /// <include file='docs.xml' path='docs/ToString/*'/>
    public override string ToString() => $"{Index}v{Version}";
}
