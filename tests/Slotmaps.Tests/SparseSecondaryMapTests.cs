namespace Slotmaps.Tests;
public class SparseSecondaryMapTests
{
    public class Drain
    {
        [Fact]
        public void EmptyMap_ReturnsEmptySequence()
        {
            var map = new SparseSecondaryMap<int>();

            var result = map.Drain().ToArray();

            Assert.Empty(result);
            Assert.Empty(map);
        }

        [Fact]
        public void FilledMap_ReturnsAllItemsAndEmptiesMap()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);

            var result = map.Drain().ToArray();

            Assert.Equal(2, result.Length);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key1, 42), result);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 24), result);
            Assert.Empty(map);
        }

        [Fact]
        public void RemovedKeys_NotReturnRemovedKeys()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            var key4 = new SlotKey(4, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);
            map.Insert(key3, 420);
            map.Insert(key4, 240);

            map.Remove(key1);
            map.Remove(key4);

            List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

            foreach (var kvp in map.Drain())
            {
                drainedItems.Add(kvp);
            }

            Assert.Equal(2, drainedItems.Count);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 24), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key3, 420), drainedItems);
            Assert.Empty(map);
        }

        [Fact]
        public void DrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            var key4 = new SlotKey(4, 1);
            var key5 = new SlotKey(5, 1);
            var key6 = new SlotKey(6, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);
            map.Insert(key3, 420);
            map.Insert(key4, 240);
            map.Insert(key5, 4200);
            map.Insert(key6, 2400);

            List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

            foreach (var kvp in map.Drain())
            {
                drainedItems.Add(kvp);
                if (kvp.Key.Equals(key3))
                    break;
            }

            Assert.Contains(new KeyValuePair<SlotKey, int>(key1,42), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key2,24), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key3,420), drainedItems);
            Assert.Equal(3, drainedItems.Count);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key4, 240), map);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key5, 4200), map);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key6, 2400), map);
            Assert.Equal(3, map.Count);
        }

        [Fact]
        public void DrainingEverything_ReturnsAllItemsAndEmptiesMap()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            var key4 = new SlotKey(4, 1);
            var key5 = new SlotKey(5, 1);
            var key6 = new SlotKey(6, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);
            map.Insert(key3, 420);
            map.Insert(key4, 240);
            map.Insert(key5, 4200);
            map.Insert(key6, 2400);

            List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

            foreach (var kvp in map.Drain())
            {
                drainedItems.Add(kvp);
            }

            Assert.Contains(new KeyValuePair<SlotKey, int>(key1,42), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key2,24), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key3,420), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key4,240), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key5,4200), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key6,2400), drainedItems);
            Assert.Equal(6, drainedItems.Count);
            Assert.Empty(map);
        }

    }
    public class Get
    {
        [Fact]
        public void ValidKey_ReturnsValue()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            map.Insert(key, 42);

            var result = map.Get(key);

            Assert.Equal(42, result);
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(0, -1);

            Assert.Throws<KeyNotFoundException>(() => map.Get(invalidKey));
        }

        [Fact]
        public void KeyNotFound_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 0);

            Assert.Throws<KeyNotFoundException>(() => map.Get(key));
        }

        [Fact]
        public void OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(1, 0);
            map.Insert(key1, 42);

            Assert.Throws<KeyNotFoundException>(() => map.Get(key2));
        }

        [Fact]
        public void NewerVersionKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 0);
            var key2 = new SlotKey(1, 1);
            map.Insert(key1, 42);
            
            Assert.Throws<KeyNotFoundException>(() => map.Get(key2));
        }
    }

    public class Indexer
    {
        [Fact]
        public void Get_ValidKey_ReturnsValue()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            map.Insert(key, 42);

            var result = map[key];

            Assert.Equal(42, result);
        }

        [Fact]
        public void Get_InvalidKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(0, -1);

            Assert.Throws<KeyNotFoundException>(() => map[invalidKey]);
        }

        [Fact]
        public void Get_KeyNotFound_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 0);

            Assert.Throws<KeyNotFoundException>(() => map[key]);
        }

        [Fact]
        public void Get_OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);
            map.Insert(key1, 42);

            Assert.Throws<KeyNotFoundException>(() => map[key2]);
        }

        [Fact]
        public void Set_InsertsValue()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            map[key] = 42;

            Assert.Equal(42, map[key]);
        }
    }

    public class Insert
    {
        [Fact]
        public void ValidKey_ReturnsInsertedValue()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            var result = map.Insert(key, 42);

            Assert.Equal(42, result);
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(0, -1);

            Assert.Throws<KeyNotFoundException>(() => map.Insert(invalidKey, 42));
        }

        [Fact]
        public void NewerVersionKey_ReturnsOldValueAndUpdatesValue()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(1, 2);

            var result1 = map.Insert(key1, 42);
            var result2 = map.Insert(key2, 24);

            Assert.Equal(42, result1);
            Assert.Equal(42, result2);
            Assert.Equal(24, map[key2]);
        }

        [Fact]
        public void OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);

            map.Insert(key1, 42);

            Assert.Throws<KeyNotFoundException>(() => map.Insert(key2, 24));
        }

        [Fact]
        public void SameKey_ReplacesAndReturnsPreviousValue()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            var firstInsert = map.Insert(key, 42);
            var secondInsert = map.Insert(key, 24);

            Assert.Equal(42, firstInsert);
            Assert.Equal(42, secondInsert);
        }

        [Fact]
        public void ValidValues_CountIncrementsOnInsertion()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);

            map.Insert(key1, 42);
            Assert.Single(map);

            map.Insert(key2, 24);
            Assert.Equal(2, map.Count);
        }
        
    }

    public class Remove
    {
        [Fact]
        public void ValidKey_RemovesAndReturnsPreviousValue()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            map.Insert(key, 42);

            var result = map.Remove(key);

            Assert.Equal(42, result);
            Assert.False(map.TryGet(key, out _));
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(0, -1);

            Assert.Throws<KeyNotFoundException>(() => map.Remove(invalidKey));
        }

        [Fact]
        public void KeyNotFound_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            Assert.Throws<KeyNotFoundException>(() => map.Remove(key));
        }

        [Fact]
        public void OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);
            map.Insert(key1, 42);

            Assert.Throws<KeyNotFoundException>(() => map.Remove(key2));
        }

        [Fact]
        public void NewerVersionKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(1, 2);
            map.Insert(key1, 42);

            Assert.Throws<KeyNotFoundException>(() => map.Remove(key2));
        }
    }

    public class Retain
    {
        [Fact]
        public void PredicateRemovesSomeItems_ItemsThatSatisfyPredicateAreRetained()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            var key4 = new SlotKey(4, 1);
            var key5 = new SlotKey(5, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);
            map.Insert(key3, 36);
            map.Insert(key4, 50);
            map.Insert(key5, 18);

            map.Retain((key, value) => value > 30);

            Assert.Equal(3, map.Count);
            Assert.Equal(42, map[key1]);
            Assert.Equal(36, map[key3]);
            Assert.Equal(50, map[key4]);
            Assert.False(map.ContainsKey(key2));
            Assert.False(map.ContainsKey(key5));
        }

        [Fact]
        public void PredicateRemovesAllItems_NoItemsRetained()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            var key4 = new SlotKey(4, 1);
            var key5 = new SlotKey(5, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);
            map.Insert(key3, 36);
            map.Insert(key4, 50);
            map.Insert(key5, 18);

            map.Retain((key, value) => value > 100);

            Assert.Empty(map.Drain());
        }

        [Fact]
        public void PredicateKeepsAllItems_NoItemsRemoved()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            var key4 = new SlotKey(4, 1);
            var key5 = new SlotKey(5, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);
            map.Insert(key3, 36);
            map.Insert(key4, 50);
            map.Insert(key5, 18);

            map.Retain((key, value) => value > 10);

            Assert.Equal(5, map.Count);
        }
    }

    public class TryGet
    {
        [Fact]
        public void ValidKey_ReturnsTrueAndValue()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            map.Insert(key, 42);

            bool result = map.TryGet(key, out var value);

            Assert.True(result);
            Assert.Equal(42, value);
        }

        [Fact]
        public void InvalidKey_ReturnsFalseAndDefault()
        {
            var map = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(0, -1);

            bool result = map.TryGet(invalidKey, out var value);

            Assert.False(result);
            Assert.Equal(default, value);
        }

        [Fact]
        public void KeyNotFound_ReturnsFalseAndDefault()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            bool result = map.TryGet(key, out var value);

            Assert.False(result);
            Assert.Equal(default, value);
        }

        [Fact]
        public void OlderVersionKey_ReturnsFalseAndDefault()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);
            map.Insert(key1, 42);

            bool result = map.TryGet(key2, out var value);

            Assert.False(result);
            Assert.Equal(default, value);
        }

        [Fact]
        public void NewerVersionKey_ReturnsFalseAndDefault()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(1, 2);
            map.Insert(key1, 42);

            bool result = map.TryGet(key2, out var value);

            Assert.False(result);
            Assert.Equal(default, value);
        }
    }

    public class TryRemove
    {
        [Fact]
        public void ValidKey_RemovesAndReturnsTrueAndPreviousValue()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            map.Insert(key, 42);

            bool result = map.TryRemove(key, out var previousValue);

            Assert.True(result);
            Assert.Equal(42, previousValue);
            Assert.False(map.TryGet(key, out _));
        }

        [Fact]
        public void InvalidKey_ReturnsFalseAndDefault()
        {
            var map = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(0, -1);

            bool result = map.TryRemove(invalidKey, out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }

        [Fact]
        public void KeyNotFound_ReturnsFalseAndDefault()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            bool result = map.TryRemove(key, out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }

        [Fact]
        public void OlderVersionKey_ReturnsFalseAndDefault()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);
            map.Insert(key1, 42);

            bool result = map.TryRemove(key2, out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }

        [Fact]
        public void NewerVersionKey_ReturnsFalseAndDefault()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(1, 2);
            map.Insert(key1, 42);

            bool result = map.TryRemove(key2, out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }
    }

    public class TryInsert
    {
        [Fact]
        public void ValidKey_ReturnsTrueAndInsertedValue()
        {
            var map = new SparseSecondaryMap<string>();
            var key = new SlotKey(1, 1);

            bool result = map.TryInsert(key, "Value1", out var previousValue);

            Assert.True(result);
            Assert.Equal("Value1", previousValue);
        }

        [Fact]
        public void InvalidKey_ReturnsFalseAndDefaultPreviousValue()
        {
            var map = new SparseSecondaryMap<string>();
            var invalidKey = new SlotKey(0, -1);

            bool result = map.TryInsert(invalidKey, "Value1", out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }

        [Fact]
        public void OlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
        {
            var map = new SparseSecondaryMap<string>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);

            map.TryInsert(key1, "Value1", out var previousValue);

            bool result = map.TryInsert(key2, "Value2", out var previousValue2);
            Assert.False(result);
            Assert.Equal(default, previousValue2);
        }

        [Fact]
        public void SameKey_ReturnsTrueAndPreviousValue()
        {
            var map = new SparseSecondaryMap<string>();
            var key = new SlotKey(1, 1);

            map.TryInsert(key, "Value1", out var previousValue1);
            bool result = map.TryInsert(key, "Value2", out var previousValue2);

            Assert.True(result);
            Assert.Equal("Value1", previousValue1);
            Assert.Equal("Value1", previousValue2);
        }

        [Fact]
        public void ValidValues_CountIncrementsOnInsertion()
        {
            var map = new SparseSecondaryMap<string>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);

            map.TryInsert(key1, "Value1", out _);

            Assert.Single(map);

            map.TryInsert(key2, "Value2", out _);

            Assert.Equal(2, map.Count);
        }
    }

    [Fact]
    public void SetKeyAsVacant_ReturnsDefaultValue()
    {
        var map = new SparseSecondaryMap<int>();
        var key = new SlotKey(1,1);
        map.Insert(key, 42);

        var capacity = map.Capacity;

        map.Remove(key);
        Assert.Empty(map);

        map.Insert(key, 10);
        Assert.Equal(10, map[key]);

        Assert.Equal(capacity, map.Capacity);
        Assert.Single(map);
    }
}

