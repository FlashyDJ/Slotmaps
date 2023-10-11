public interface ISlotKey<TSelf> where TSelf : struct
{
    int Index { get; }
    uint Version { get; }
    bool IsNull => Index > 0;
    bool Occupied => Version % 2 > 0;

    abstract static TSelf New(int index, uint version);

    virtual static TSlotKey Null<TSlotKey>()
        where TSlotKey : struct, ISlotKey<TSlotKey> =>
        TSlotKey.New(int.MinValue, 1);

    virtual static ulong ToUlong(ISlotKey<TSelf> slotKey) =>
        ((ulong)slotKey.Version << 32) | (uint)slotKey.Index;

    virtual static TSlotKey FromUlong<TSlotKey>(ulong value)
        where TSlotKey : struct, ISlotKey<TSlotKey> =>
        TSlotKey.New((int)value, ((uint)value >> 32) | 1);

    string ToString() => $"{Index}v{Version}";
}