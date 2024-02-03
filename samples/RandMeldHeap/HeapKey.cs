using FlashyDJ.Slotmaps;

namespace RandMeldHeap;

public readonly record struct HeapKey(int Index, uint Version) : ISlotKey<HeapKey>
{
    public bool IsNull => Index < 0 || Version == 0;

    public static HeapKey New(int index, uint version) => new(index, version);

    public static HeapKey Null() => new(int.MinValue, 0);
}

