public interface ISlotKey<TSelf> where TSelf : struct
{
    uint Index { get; }
    uint Version { get; }
    bool Occupied => Version % 2 > 0;
    bool IsNull => Index == uint.MaxValue;

    abstract static TSelf New(uint index, uint version);

    virtual static TSlotKey Null<TSlotKey>()
        where TSlotKey : struct, ISlotKey<TSlotKey> =>
        TSlotKey.New(uint.MaxValue, 1);

    virtual static ulong ToUlong(ISlotKey<TSelf> slotKey) =>
        ((ulong)slotKey.Version << 32) | slotKey.Index;

    virtual static TSlotKey FromUlong<TSlotKey>(ulong value)
        where TSlotKey : struct, ISlotKey<TSlotKey> =>
        TSlotKey.New((uint)value, ((uint)value >> 32) | 1);
}