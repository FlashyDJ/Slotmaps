---
uid: FlashyDJ.Slotmaps.SlotMap`2
remarks: *content
---

The [SlotMap<TKey, TValue>](xref:FlashyDJ.Slotmaps.SlotMap`2) class is a versatile data structure designed for efficient association of keys with values. It is particularly useful when you need to manage a large number of items with a stable key-value relationship and when keys must adhere to the [ISlotKey<TKey>](xref:FlashyDJ.Slotmaps.ISlotKey`1) interface.

The slot map optimizes memory usage by storing values in an array of slots and associating each value with a key. It also manages slot reuse and reallocation to ensure efficient storage.

To use this class effectively, ensure that your key type <code class="typeparamref">TValue</code> implements the [ISlotKey<TKey>](xref:FlashyDJ.Slotmaps.ISlotKey`1) interface, providing the necessary methods for slot-based management.

If you don't require a custom key type, you can use [SlotMap<TValue>](xref:FlashyDJ.Slotmaps.SlotMap`1). This class automatically sets the key type to [SlotKey](xref:FlashyDJ.Slotmaps.SlotKey), simplifying slot-based key management and allowing you to focus on value association and efficient data management.