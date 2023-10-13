namespace FlashyDJ.Slotmaps;
/// <include file='docs.xml' path='docs/ISlotKey/*'/>
public interface ISlotKey<TSelf> where TSelf : struct
{
    /// <include file='docs.xml' path='docs/Index/*'/>
    int Index { get; }

    /// <include file='docs.xml' path='docs/Version/*'/>
    uint Version { get; }

    /// <include file='docs.xml' path='docs/IsNull/*'/>
    bool IsNull => Index > 0;

    /// <include file='docs.xml' path='docs/Occupied/*'/>
    bool Occupied => Version % 2 > 0;

    /// <include file='docs.xml' path='docs/New/*'/>
    abstract static TSelf New(int index, uint version);

    /// <include file='docs.xml' path='docs/Null/*'/>
    virtual static TSlotKey Null<TSlotKey>()
        where TSlotKey : struct, ISlotKey<TSlotKey> =>
        TSlotKey.New(int.MinValue, 1);

    /// <include file='docs.xml' path='docs/ToUlong/*'/>
    virtual static ulong ToUlong(ISlotKey<TSelf> slotKey) =>
        ((ulong)slotKey.Version << 32) | (uint)slotKey.Index;

    /// <include file='docs.xml' path='docs/FromUlong/*'/>
    virtual static TSlotKey FromUlong<TSlotKey>(ulong value)
        where TSlotKey : struct, ISlotKey<TSlotKey> =>
        TSlotKey.New((int)value, ((uint)value >> 32) | 1);

    /// <include file='docs.xml' path='docs/ToString/*'/>
    string ToString() => $"{Index}v{Version}";
}