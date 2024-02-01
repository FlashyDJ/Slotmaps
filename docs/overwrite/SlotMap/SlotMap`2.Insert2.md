---
uid: FlashyDJ.Slotmaps.SlotMap`2.Insert(`0,`1)
remarks: *content
---

Use the <code class="method">Insert</code> method to associate a new value with an existing <code class="paramref">key</code> in the slot map. If the <code class="paramref">key</code> does not exist in the map, a [KeyNotFoundException](xref:System.Collections.Generic.KeyNotFoundException) is thrown. If the <code class="paramref">key</code> exists, the associated value is updated, and the key's version number is incremented. If the <code class="paramref">key</code> is not associated with a value, its version number is incremented, and the <code class="property">Count</code> property is increased by one.