using System.Diagnostics.CodeAnalysis;

namespace FlashyDJ.Slotmaps;
public interface ISlotMap<TValue> : ICollection<KeyValuePair<SlotKey, TValue>>
{
    int Capacity { get; }

    bool IsEmpty { get; }

    ICollection<SlotKey> Keys { get; }

    ICollection<TValue> Values { get;  }

    TValue this[SlotKey key] { get; set; }

    SlotKey Add(TValue value);

    SlotKey Insert(SlotKey key, TValue value);

    bool ContainsKey(SlotKey key);

    TValue Get(SlotKey key);

    TValue Remove(SlotKey key);

    bool TryAdd(SlotKey key, TValue value, out SlotKey updatedKey);

    bool TryGet(SlotKey key, [MaybeNullWhen(false)] out TValue value);

    bool TryRemove(SlotKey key, [MaybeNullWhen(false)] out TValue value);
}

