using System.Runtime.CompilerServices;

namespace FlashyDJ.Slotmaps;
public readonly record struct SlotKey(int Index, int Version)
{
    public static SlotKey Null => new(int.MinValue, 0);

    public bool IsNull => Index == int.MinValue;

    public bool IsInvalid => Index < 0 || Version < 0 || IsNull;

    public static implicit operator ulong(SlotKey slotKey) =>
        ((ulong)slotKey.Version << 32) | (ulong)slotKey.Index;

    public static implicit operator SlotKey(ulong value) =>
        new((int)value, ((int)value >> 32) | 1);

    public override string ToString() => $"{Index}v{Version}";
}
