---
uid: FlashyDJ.Slotmaps.SlotMap`2.ContainsKey(`0)
remarks: *content
---

Use this method to check if a specific <code class="paramref">key</code> exists in the slot map. A <code class="paramref">key</code> is considered to exist if its <see cref="SlotKey.Index"/> is within the valid range of slots (0 to the capacity of the map) and the corresponding slot has the same version as the provided <code class="paramref">key</code>.