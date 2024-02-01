---
uid: FlashyDJ.Slotmaps.SlotMap`1
remarks: *content
---

The [SlotMap<TValue>](xref:FlashyDJ.Slotmaps.SlotMap`1) class is a versatile data structure designed for efficient association of keys with values. It is particularly useful when you need to manage a large number of items with a stable key-value relationship with the default key type of [SlotKey](xref:FlashyDJ.Slotmaps.SlotKey). 

The slot map optimizes memory usage by storing values in an array of slots and associating each value with a key. It also manages slot reuse and reallocation to ensure efficient storage.

If you require a custom key type, consider using the more generic [SlotMap<TKey, TValue>](xref:FlashyDJ.Slotmaps.SlotMap`2) class where you can specify your own key type implementing [ISlotKey<TKey>](xref:FlashyDJ.Slotmaps.ISlotKey`1).