namespace Slotmaps.Tests;
public class SparseSecondaryMapTests
{
    public class ContainsKey
    {
        [Fact]
        public void ValidKeyExists_ReturnsTrue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            sparseMap.Insert(key, 42);

            var result = sparseMap.ContainsKey(key);

            Assert.True(result);
        }

        [Fact]
        public void ValidKeyDoesNotExist_ReturnsFalse()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            var result = sparseMap.ContainsKey(key);

            Assert.False(result);
        }

        [Fact]
        public void InvalidKeyWithVersionLessThan1_ReturnsFalse()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(1, 0);

            var result = sparseMap.ContainsKey(invalidKey);

            Assert.False(result);
        }

        [Fact]
        public void InvalidKeyWithVersionGreaterOrEqualTo1_ReturnsFalse()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(-1, 1);

            var result = sparseMap.ContainsKey(invalidKey);

            Assert.False(result);
        }
    }

    public class ContainsValue
    {
        [Fact]
        public void ValueExists_ReturnsTrue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            sparseMap.Insert(key3, 36);

            var result = sparseMap.ContainsValue(24);

            Assert.True(result);
        }

        [Fact]
        public void ValueDoesNotExist_ReturnsFalse()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            sparseMap.Insert(key3, 36);

            var result = sparseMap.ContainsValue(100);

            Assert.False(result);
        }

        [Fact]
        public void NullValue_ReturnsFalse()
        {
            var sparseMap = new SparseSecondaryMap<string>();
            var key1 = new SlotKey(1, 0);
            sparseMap.Insert(key1, "value");

            var result = sparseMap.ContainsValue(null!);

            Assert.False(result);
        }
    }

    public class Clear
    {
        [Fact]
        public void WithItems_ClearsMapAndSetsCountToZero()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            var capacity = sparseMap.Capacity;

            sparseMap.Clear();

            Assert.Equal(capacity, sparseMap.Capacity);
            Assert.Empty(sparseMap);
        }

        [Fact]
        public void EmptyMap_DoesNothing()
        {
            var sparseMap = new SparseSecondaryMap<int>();

            sparseMap.Clear();

            Assert.Empty(sparseMap);
        }
    }

    public class Drain
    {
        [Fact]
        public void EmptyMap_ReturnsEmptySequence()
        {
            var sparseMap = new SparseSecondaryMap<int>();

            var result = sparseMap.Drain().ToArray();

            Assert.Empty(result);
            Assert.Empty(sparseMap);
        }

        [Fact]
        public void FilledMap_ReturnsAllItemsAndEmptiesMap()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);

            var result = sparseMap.Drain().ToArray();

            Assert.Equal(2, result.Length);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key1, 42), result);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 24), result);
            Assert.Empty(sparseMap);
        }

        [Fact]
        public void RemovedKeys_NotReturnRemovedKeys()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            var key4 = new SlotKey(4, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            sparseMap.Insert(key3, 420);
            sparseMap.Insert(key4, 240);

            sparseMap.Remove(key1);
            sparseMap.Remove(key4);

            List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

            foreach (var kvp in sparseMap.Drain())
            {
                drainedItems.Add(kvp);
            }

            Assert.Equal(2, drainedItems.Count);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 24), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key3, 420), drainedItems);
            Assert.Empty(sparseMap);
        }

        [Fact]
        public void DrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            var key4 = new SlotKey(4, 1);
            var key5 = new SlotKey(5, 1);
            var key6 = new SlotKey(6, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            sparseMap.Insert(key3, 420);
            sparseMap.Insert(key4, 240);
            sparseMap.Insert(key5, 4200);
            sparseMap.Insert(key6, 2400);

            List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

            foreach (var kvp in sparseMap.Drain())
            {
                drainedItems.Add(kvp);
                if (kvp.Key.Equals(key3))
                    break;
            }

            Assert.Contains(new KeyValuePair<SlotKey, int>(key1,42), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key2,24), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key3,420), drainedItems);
            Assert.Equal(3, drainedItems.Count);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key4, 240), sparseMap);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key5, 4200), sparseMap);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key6, 2400), sparseMap);
            Assert.Equal(3, sparseMap.Count);
        }

        [Fact]
        public void DrainingEverything_ReturnsAllItemsAndEmptiesMap()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            var key4 = new SlotKey(4, 1);
            var key5 = new SlotKey(5, 1);
            var key6 = new SlotKey(6, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            sparseMap.Insert(key3, 420);
            sparseMap.Insert(key4, 240);
            sparseMap.Insert(key5, 4200);
            sparseMap.Insert(key6, 2400);

            List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

            foreach (var kvp in sparseMap.Drain())
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
            Assert.Empty(sparseMap);
        }

    }

    public class EnsureCapacity
    {
        [Fact]
        public void PositiveValue_ReturnsCapacity()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var capacity = 100;

            int result = sparseMap.EnsureCapacity(capacity);

            Assert.True(result >= capacity);
        }

        [Fact]
        public void NegativeValue_ThrowsArgumentOutOfRangeException()
        {
            var sparseMap = new SparseSecondaryMap<int>();

            Assert.Throws<ArgumentOutOfRangeException>(() => sparseMap.EnsureCapacity(-10));
        }
    }

    public class Get
    {
        [Fact]
        public void ValidKey_ReturnsValue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            sparseMap.Insert(key, 42);

            var result = sparseMap.Get(key);

            Assert.Equal(42, result);
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(-1, 0);

            Assert.Throws<KeyNotFoundException>(() => sparseMap.Get(invalidKey));
        }

        [Fact]
        public void KeyNotFound_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 0);

            Assert.Throws<KeyNotFoundException>(() => sparseMap.Get(key));
        }

        [Fact]
        public void OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(1, 0);
            sparseMap.Insert(key1, 42);

            Assert.Throws<KeyNotFoundException>(() => sparseMap.Get(key2));
        }

        [Fact]
        public void NewerVersionKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 0);
            var key2 = new SlotKey(1, 1);
            sparseMap.Insert(key1, 42);
            
            Assert.Throws<KeyNotFoundException>(() => sparseMap.Get(key2));
        }
    }

    public class Indexer
    {
        [Fact]
        public void Get_ValidKey_ReturnsValue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            sparseMap.Insert(key, 42);

            var result = sparseMap[key];

            Assert.Equal(42, result);
        }

        [Fact]
        public void Get_InvalidKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(-1, 0);

            Assert.Throws<KeyNotFoundException>(() => sparseMap[invalidKey]);
        }

        [Fact]
        public void Get_KeyNotFound_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 0);

            Assert.Throws<KeyNotFoundException>(() => sparseMap[key]);
        }

        [Fact]
        public void Get_OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);
            sparseMap.Insert(key1, 42);

            Assert.Throws<KeyNotFoundException>(() => sparseMap[key2]);
        }

        [Fact]
        public void Set_InsertsValue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            sparseMap[key] = 42;

            Assert.Equal(42, sparseMap[key]);
        }
    }

    public class Insert
    {
        [Fact]
        public void ValidKey_ReturnsInsertedValue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            var result = sparseMap.Insert(key, 42);

            Assert.Equal(42, result);
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(-1, 0);

            var ex = Assert.Throws<KeyNotFoundException>(() => sparseMap.Insert(invalidKey, 42));
            Assert.Equal("Invalid SlotKey", ex.Message);
        }

        [Fact]
        public void NewerVersionKey_ReturnsOldValueAndUpdatesValue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(1, 2);

            var result1 = sparseMap.Insert(key1, 42);
            var result2 = sparseMap.Insert(key2, 24);

            Assert.Equal(42, result1);
            Assert.Equal(42, result2);
            Assert.Equal(24, sparseMap[key2]);
        }

        [Fact]
        public void OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);

            sparseMap.Insert(key1, 42);

            var ex = Assert.Throws<KeyNotFoundException>(() => sparseMap.Insert(key2, 24));
            Assert.Equal("SlotKey is an older version", ex.Message);
        }

        [Fact]
        public void SameKey_ReplacesAndReturnsPreviousValue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            var firstInsert = sparseMap.Insert(key, 42);
            var secondInsert = sparseMap.Insert(key, 24);

            Assert.Equal(42, firstInsert);
            Assert.Equal(42, secondInsert);
        }

        [Fact]
        public void ValidValues_CountIncrementsOnInsertion()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);

            sparseMap.Insert(key1, 42);
            Assert.Single(sparseMap);

            sparseMap.Insert(key2, 24);
            Assert.Equal(2, sparseMap.Count);
        }
        
    }

    public class Remove
    {
        [Fact]
        public void ValidKey_RemovesAndReturnsPreviousValue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            sparseMap.Insert(key, 42);

            var result = sparseMap.Remove(key);

            Assert.Equal(42, result);
            Assert.False(sparseMap.TryGet(key, out _));
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(-1, 0);

            Assert.Throws<KeyNotFoundException>(() => sparseMap.Remove(invalidKey));
        }

        [Fact]
        public void KeyNotFound_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            Assert.Throws<KeyNotFoundException>(() => sparseMap.Remove(key));
        }

        [Fact]
        public void OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);
            sparseMap.Insert(key1, 42);

            Assert.Throws<KeyNotFoundException>(() => sparseMap.Remove(key2));
        }

        [Fact]
        public void NewerVersionKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(1, 2);
            sparseMap.Insert(key1, 42);

            Assert.Throws<KeyNotFoundException>(() => sparseMap.Remove(key2));
        }
    }

    public class Retain
    {
        [Fact]
        public void PredicateRemovesSomeItems_ItemsThatSatisfyPredicateAreRetained()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            var key4 = new SlotKey(4, 1);
            var key5 = new SlotKey(5, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            sparseMap.Insert(key3, 36);
            sparseMap.Insert(key4, 50);
            sparseMap.Insert(key5, 18);

            sparseMap.Retain((key, value) => value > 30);

            Assert.Equal(3, sparseMap.Count);
            Assert.Equal(42, sparseMap[key1]);
            Assert.Equal(36, sparseMap[key3]);
            Assert.Equal(50, sparseMap[key4]);
            Assert.False(sparseMap.ContainsKey(key2));
            Assert.False(sparseMap.ContainsKey(key5));
        }

        [Fact]
        public void PredicateRemovesAllItems_NoItemsRetained()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            var key4 = new SlotKey(4, 1);
            var key5 = new SlotKey(5, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            sparseMap.Insert(key3, 36);
            sparseMap.Insert(key4, 50);
            sparseMap.Insert(key5, 18);

            sparseMap.Retain((key, value) => value > 100);

            Assert.Empty(sparseMap);
        }

        [Fact]
        public void PredicateKeepsAllItems_NoItemsRemoved()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            var key4 = new SlotKey(4, 1);
            var key5 = new SlotKey(5, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            sparseMap.Insert(key3, 36);
            sparseMap.Insert(key4, 50);
            sparseMap.Insert(key5, 18);

            sparseMap.Retain((key, value) => value > 10);

            Assert.Equal(5, sparseMap.Count);
        }
    }

    public class TryGet
    {
        [Fact]
        public void ValidKey_ReturnsTrueAndValue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            sparseMap.Insert(key, 42);

            bool result = sparseMap.TryGet(key, out var value);

            Assert.True(result);
            Assert.Equal(42, value);
        }

        [Fact]
        public void InvalidKey_ReturnsFalseAndDefault()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(-1, 0);

            bool result = sparseMap.TryGet(invalidKey, out var value);

            Assert.False(result);
            Assert.Equal(default, value);
        }

        [Fact]
        public void KeyNotFound_ReturnsFalseAndDefault()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            bool result = sparseMap.TryGet(key, out var value);

            Assert.False(result);
            Assert.Equal(default, value);
        }

        [Fact]
        public void OlderVersionKey_ReturnsFalseAndDefault()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);
            sparseMap.Insert(key1, 42);

            bool result = sparseMap.TryGet(key2, out var value);

            Assert.False(result);
            Assert.Equal(default, value);
        }

        [Fact]
        public void NewerVersionKey_ReturnsFalseAndDefault()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(1, 2);
            sparseMap.Insert(key1, 42);

            bool result = sparseMap.TryGet(key2, out var value);

            Assert.False(result);
            Assert.Equal(default, value);
        }
    }

    public class TryRemove
    {
        [Fact]
        public void ValidKey_RemovesAndReturnsTrueAndPreviousValue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            sparseMap.Insert(key, 42);

            bool result = sparseMap.TryRemove(key, out var previousValue);

            Assert.True(result);
            Assert.Equal(42, previousValue);
            Assert.False(sparseMap.TryGet(key, out _));
        }

        [Fact]
        public void InvalidKey_ReturnsFalseAndDefault()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(-1, 0);

            bool result = sparseMap.TryRemove(invalidKey, out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }

        [Fact]
        public void KeyNotFound_ReturnsFalseAndDefault()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);

            bool result = sparseMap.TryRemove(key, out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }

        [Fact]
        public void OlderVersionKey_ReturnsFalseAndDefault()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);
            sparseMap.Insert(key1, 42);

            bool result = sparseMap.TryRemove(key2, out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }

        [Fact]
        public void NewerVersionKey_ReturnsFalseAndDefault()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(1, 2);
            sparseMap.Insert(key1, 42);

            bool result = sparseMap.TryRemove(key2, out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }
    }

    public class TryInsert
    {
        [Fact]
        public void ValidKey_ReturnsTrueAndInsertedValue()
        {
            var sparseMap = new SparseSecondaryMap<string>();
            var key = new SlotKey(1, 1);

            bool result = sparseMap.TryInsert(key, "Value1", out var previousValue);

            Assert.True(result);
            Assert.Equal("Value1", previousValue);
        }

        [Fact]
        public void InvalidKey_ReturnsFalseAndDefaultPreviousValue()
        {
            var sparseMap = new SparseSecondaryMap<string>();
            var invalidKey = new SlotKey(-1, 0);

            bool result = sparseMap.TryInsert(invalidKey, "Value1", out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }

        [Fact]
        public void OlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
        {
            var sparseMap = new SparseSecondaryMap<string>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);

            sparseMap.TryInsert(key1, "Value1", out var _);

            bool result = sparseMap.TryInsert(key2, "Value2", out var previousValue);
            Assert.False(result);
            Assert.Equal(default, previousValue);
        }

        [Fact]
        public void SameKey_ReturnsTrueAndPreviousValue()
        {
            var sparseMap = new SparseSecondaryMap<string>();
            var key = new SlotKey(1, 1);

            sparseMap.TryInsert(key, "Value1", out var previousValue1);
            bool result = sparseMap.TryInsert(key, "Value2", out var previousValue2);

            Assert.True(result);
            Assert.Equal("Value1", previousValue1);
            Assert.Equal("Value1", previousValue2);
        }

        [Fact]
        public void ValidValues_CountIncrementsOnInsertion()
        {
            var sparseMap = new SparseSecondaryMap<string>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);

            sparseMap.TryInsert(key1, "Value1", out _);

            Assert.Single(sparseMap);

            sparseMap.TryInsert(key2, "Value2", out _);

            Assert.Equal(2, sparseMap.Count);
        }
    }

    [Fact]
    public void SetKeyAsVacant_ReturnsDefaultValue()
    {
        var sparseMap = new SparseSecondaryMap<int>();
        var key = new SlotKey(1,1);
        sparseMap.Insert(key, 42);

        var capacity = sparseMap.Capacity;

        sparseMap.Remove(key);
        Assert.Empty(sparseMap);

        sparseMap.Insert(key, 10);
        Assert.Equal(10, sparseMap[key]);

        Assert.Equal(capacity, sparseMap.Capacity);
        Assert.Single(sparseMap);
    }
}

