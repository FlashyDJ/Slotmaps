namespace Slotmaps.Tests;
public class SlotMapTests
{
    public class Add
    {
        [Fact]
        public void NewValidValue_ReturnsKeyIncreasesCountAndContainKeys()
        {
            var slotMap = new SlotMap<int>();

            var key = slotMap.Add(42);

            Assert.Single(slotMap);
            Assert.True(slotMap.ContainsKey(key));
            Assert.Equal(42, slotMap.Get(key));
        }

        [Fact]
        public void AddElementsBeyondCapacity_ResizesCorrectly()
        {
            var slotMap = new SlotMap<string>(2);

            var key1 = slotMap.Add("Value1");
            var key2 = slotMap.Add("Value2");
            var key3 = slotMap.Add("Value3");

            Assert.True(slotMap.ContainsKey(key1));
            Assert.True(slotMap.ContainsKey(key2));
            Assert.True(slotMap.ContainsKey(key3));
            Assert.Equal("Value1", slotMap.Get(key1));
            Assert.Equal("Value2", slotMap.Get(key2));
            Assert.Equal("Value3", slotMap.Get(key3));
            Assert.Equal(4, slotMap.Capacity);
        }

        [Fact]
        public void ValidSlotKey_UpdatesSlotValue()
        {
            var slotMap = new SlotMap<string>();

            var key = slotMap.Add("InitialValue");
            var newKey = slotMap.Insert(key, "UpdatedValue");
            var value = slotMap.Get(newKey);

            Assert.Equal(key.Index, newKey.Index);
            Assert.NotEqual(key, newKey);
            Assert.Equal("UpdatedValue", value);
        }

        [Fact]
        public void InvalidSlotKey_ThrowsArgumentException()
        {
            var slotMap = new SlotMap<string>();
            var key = SlotKey.Null;

            Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, "Value"));
        }
    }

    public class Constructor
    {
        [Fact]
        public void WithCapacityParameter_SetsCapacityAndBeEmpty()
        {
            int capacity = 10;

            var slotMap = new SlotMap<int>(capacity);

            Assert.Equal(capacity, slotMap.Capacity);
            Assert.Empty(slotMap);
            Assert.True(slotMap.IsEmpty);
        }
    }
    
    public class ContainsKey
    {
        [Fact]
        public void ValidKeyExists_ReturnsTrue()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);

            var result = slotMap.ContainsKey(key);

            Assert.True(result);
        }

        [Fact]
        public void ValidKeyDoesNotExist_ReturnsFalse()
        {
            var slotMap = new SlotMap<string>();
            var key = new SlotKey(1, 1);

            var result = slotMap.ContainsKey(key);

            Assert.False(result);
        }

        [Fact]
        public void InvalidKeyWithVersionLessThan1_ReturnsFalse()
        {
            var slotMap = new SlotMap<int>();
            var invalidKey = new SlotKey(1, 0);

            var result = slotMap.ContainsKey(invalidKey);

            Assert.False(result);
        }

        [Fact]
        public void InvalidKeyWithVersionGreaterOrEqualTo1_ReturnsFalse()
        {
            var slotMap = new SlotMap<int>();
            var invalidKey = new SlotKey(-1, 1);

            var result = slotMap.ContainsKey(invalidKey);

            Assert.False(result);
        }

        [Fact]
        public void ItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);

            slotMap.Remove(key);

            Assert.Empty(slotMap);
            Assert.False(slotMap.ContainsKey(key));
        }

        [Fact]
        public void ItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
        {
            var slotMap = new SlotMap<string>();
            var key1 = slotMap.Add("Value1");
            var key2 = slotMap.Add("Value2");

            slotMap.Remove(key1);

            Assert.False(slotMap.ContainsKey(key1));
            Assert.True(slotMap.ContainsKey(key2));
        }

    }

    public class ContainsValue
    {
        [Fact]
        public void ValueExists_ReturnsTrue()
        {
            var slotMap = new SlotMap<int>();
            slotMap.Add(42);
            slotMap.Add(24);
            slotMap.Add(36);

            var result = slotMap.ContainsValue(24);

            Assert.True(result);
        }

        [Fact]
        public void ValueDoesNotExist_ReturnsFalse()
        {
            var slotMap = new SlotMap<int>();
            slotMap.Add(42);
            slotMap.Add(24);
            slotMap.Add(36);

            var result = slotMap.ContainsValue(100);

            Assert.False(result);
        }

        [Fact]
        public void NullValue_ReturnsFalse()
        {
            var slotMap = new SlotMap<string>();
            slotMap.Add("value");

            var result = slotMap.ContainsValue(null!);

            Assert.False(result);
        }
    }

    public class Clear
    {
        [Fact]
        public void WithItems_ClearsMapAndSetsCountToZero()
        {
            var slotMap = new SlotMap<int>();
            slotMap.Add(42);
            slotMap.Add(24);
            var capacity = slotMap.Capacity;

            slotMap.Clear();

            Assert.Equal(capacity, slotMap.Capacity);
            Assert.Empty(slotMap);
        }

        [Fact]
        public void EmptyMap_DoesNothing()
        {
            var slotMap = new SlotMap<int>();

            slotMap.Clear();

            Assert.Empty(slotMap);
        }
    }
    
    public class Drain
    {
        [Fact]
        public void EmptyMap_ReturnsEmptySequence()
        {
            var slotMap = new SlotMap<int>();

            var result = slotMap.Drain().ToArray();

            Assert.Empty(result);
            Assert.Empty(slotMap);
        }

        [Fact]
        public void FilledMap_ReturnsAllItemsAndEmptiesMap()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = slotMap.Add(24);

            var result = slotMap.Drain().ToArray();

            Assert.Equal(2, result.Length);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key1, 42), result);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 24), result);
            Assert.Empty(slotMap);
        }

        [Fact]
        public void RemovedKeys_NotReturnRemovedKeys()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = slotMap.Add(24);
            var key3 = slotMap.Add(420);
            var key4 = slotMap.Add(240);

            slotMap.Remove(key1);
            slotMap.Remove(key4);

            List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

            foreach (var kvp in slotMap.Drain())
            {
                drainedItems.Add(kvp);
            }

            Assert.Equal(2, drainedItems.Count);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 24), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key3, 420), drainedItems);
            Assert.Empty(slotMap);
        }

        [Fact]
        public void DrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = slotMap.Add(24);
            var key3 = slotMap.Add(420);
            var key4 = slotMap.Add(240);
            var key5 = slotMap.Add(4200);
            var key6 = slotMap.Add(2400);

            List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

            foreach (var kvp in slotMap.Drain())
            {
                drainedItems.Add(kvp);
                if (kvp.Key.Equals(key3))
                    break;
            }

            Assert.Contains(new KeyValuePair<SlotKey, int>(key1,42), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key2,24), drainedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key3,420), drainedItems);
            Assert.Equal(3, drainedItems.Count);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key4, 240), slotMap);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key5, 4200), slotMap);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key6, 2400), slotMap);
            Assert.Equal(3, slotMap.Count);
        }

        [Fact]
        public void DrainingEverything_ReturnsAllItemsAndEmptiesMap()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = slotMap.Add(24);
            var key3 = slotMap.Add(420);
            var key4 = slotMap.Add(240);
            var key5 = slotMap.Add(4200);
            var key6 = slotMap.Add(2400);

            List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

            foreach (var kvp in slotMap.Drain())
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
            Assert.Empty(slotMap.Drain());
        }
        
    }

    public class EnsureCapacity
    {
        [Fact]
        public void PositiveValue_ReturnsCapacity()
        {
            var slotMap = new SlotMap<int>();
            var capacity = 100;

            int result = slotMap.EnsureCapacity(capacity);

            Assert.Equal(capacity, result);
        }

        [Fact]
        public void NegativeValue_ThrowsArgumentOutOfRangeException()
        {
            var slotMap = new SlotMap<int>();

            Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
        }
    }

    public class Get
    {
        [Fact]
        public void ValidKey_ReturnsValue()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);

            var value = slotMap.Get(key);

            Assert.Equal(42, value);
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<int>();
            var invalidKey = new SlotKey(0, -1);

            Assert.Throws<KeyNotFoundException>(() => slotMap.Get(invalidKey));
        }

        [Fact]
        public void KeyNotFound_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<int>();
            var key = new SlotKey(1, 0);

            Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key));
        }

        [Fact]
        public void OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = new SlotKey(0, 0);

            Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
        }

        [Fact]
        public void NewerVersionKey_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = new SlotKey(1, 2);

            Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
        }
    }

    public class Indexer
    {
        [Fact]
        public void Get_ValidKey_ReturnsValue()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);

            var result = slotMap[key];

            Assert.Equal(42, result);
        }

        [Fact]
        public void Get_InvalidKey_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<string>();
            var key = new SlotKey(0, -1);

            Assert.Throws<KeyNotFoundException>(() => slotMap[key]);
        }

        [Fact]
        public void Get_KeyNotFound_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<int>();
            var key = new SlotKey(1, 0);

            Assert.Throws<KeyNotFoundException>(() => slotMap[key]);
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
        public void Set_InvalidSlotKey_ThrowsArgumentException()
        {
            var slotMap = new SlotMap<string>();
            var key = new SlotKey(0, 1);

            Assert.Throws<KeyNotFoundException>(() => slotMap[key] = "Value");
        }

        [Fact]
        public void SetAndGet_UpdateValue_ReturnsUpdatedValue()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);

            slotMap[key] = 24;
            var value = slotMap[key with { Version = 3 }];

            Assert.Equal(24, value);
        }
    }

    public class Insert
    {
        [Fact]
        public void Insert_NonexistentKey_ThrowsKeyNotFoundException()
        {
            var map = new SlotMap<int>();
            var key = new SlotKey(1, 0);
            var value = 42;

            var ex = Assert.Throws<KeyNotFoundException>(() => map.Insert(key, value));
        }

        [Fact]
        public void ExistingKey_UpdatesValueAndReturnsNewKey()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);
            var newValue = 24;

            var newKey = slotMap.Insert(key, newValue);

            Assert.Equal(newValue, slotMap[newKey]);
        }
    }

    public class Remove
    {
        [Fact]
        public void ValidKey_RemovesAndReturnsPreviousValue()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);

            var result = slotMap.Remove(key);

            Assert.Equal(42, result);
            Assert.False(slotMap.ContainsKey(key));
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<int>();
            var invalidKey = new SlotKey(0, -1);

            Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
        }

        [Fact]
        public void KeyNotFound_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<int>();
            var key = new SlotKey(1, 1);

            Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
        }

        [Fact]
        public void OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);
            var key2 = key with { Version = 0 };

            Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
        }

        [Fact]
        public void NewerVersionKey_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);
            var key2 = key with { Version = 2 };

            Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
        }
    }

    public class Reserve
    {
        [Fact]
        public void ValidAdditionalSize_ResizesArray()
        {
            var slotMap = new SlotMap<int>();
            var initialCapacity = slotMap.Capacity;
            var additionalSize = 10;

            slotMap.Reserve(additionalSize);

            Assert.Equal(initialCapacity + additionalSize, slotMap.Capacity);
        }

        [Fact]
        public void Reserve_NegativeAdditionalSize_ThrowsArgumentOutOfRangeException()
        {
            var slotMap = new SlotMap<int>();
            var negativeSize = -10;

            Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.Reserve(negativeSize));
        }
    }

    public class Resize
    {
        [Fact]
        public void NewSizeLessThanCapacity_ThrowsArgumentOutOfRangeException()
        {
            var slotMap = new SlotMap<int>();
            slotMap.Add(42);
            var newSize = slotMap.Capacity - 1;

            Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.Resize(newSize));
        }

        [Fact]
        public void NewSizeEqualToCapacity_DoesNotChangeCapacity()
        {
            var slotMap = new SlotMap<int>();
            slotMap.Add(42);
            var initialCapacity = slotMap.Capacity;
            var newSize = initialCapacity;

            slotMap.Resize(newSize);

            Assert.Equal(initialCapacity, slotMap.Capacity);
        }

        [Fact]
        public void Resize_NewSizeGreaterThanCapacity_ResizesArrayToNewSize()
        {
            var slotMap = new SlotMap<int>();
            slotMap.Add(42);
            var initialCapacity = slotMap.Capacity;
            var newSize = initialCapacity * 2;

            slotMap.Resize(newSize);

            Assert.Equal(newSize, slotMap.Capacity);
        }
    }

    public class Retain
    {
        [Fact]
        public void PredicateRemovesSomeItems_ItemsThatSatisfyPredicateAreRetained()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = slotMap.Add(24);
            var key3 = slotMap.Add(36);
            var key4 = slotMap.Add(50);
            var key5 = slotMap.Add(18);

            slotMap.Retain((key, value) => value > 30);

            Assert.Equal(3, slotMap.Count);
            Assert.Equal(42, slotMap[key1]);
            Assert.Equal(36, slotMap[key3]);
            Assert.Equal(50, slotMap[key4]);
            Assert.False(slotMap.ContainsKey(key2));
            Assert.False(slotMap.ContainsKey(key5));
        }

        [Fact]
        public void PredicateRemovesAllItems_NoItemsRetained()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = slotMap.Add(24);
            var key3 = slotMap.Add(36);
            var key4 = slotMap.Add(50);
            var key5 = slotMap.Add(18);

            slotMap.Retain((key, value) => value > 100);

            Assert.Empty(slotMap);
        }

        [Fact]
        public void PredicateKeepsAllItems_NoItemsRemoved()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = slotMap.Add(24);
            var key3 = slotMap.Add(36);
            var key4 = slotMap.Add(50);
            var key5 = slotMap.Add(18);

            slotMap.Retain((key, value) => value > 10);

            Assert.Equal(5, slotMap.Count);
        }
    }

    public class TryAdd
    {
        [Fact]
        public void ValidKey_ReturnsTrueAndNewKey()
        {
            var slotMap = new SlotMap<string>();
            var key = slotMap.Add("Value1");

            bool result = slotMap.TryInsert(key, "Value2", out var newKey);

            Assert.True(result);
            Assert.Equal("Value2", slotMap[newKey]);
        }

        [Fact]
        public void InvalidKey_ReturnsFalseAndNullKey()
        {
            var slotMap = new SlotMap<string>();
            var invalidKey = new SlotKey(0, -1);

            bool result = slotMap.TryInsert(invalidKey, "Value1", out var newKey);

            Assert.False(result);
            Assert.True(newKey.IsNull);
        }

        [Fact]
        public void OlderVersionKey_ReturnsFalseAndNullKey()
        {
            var slotMap = new SlotMap<string>();
            var key1 = slotMap.Add("Value1");
            var key2 = key1 with { Version = 0 };

            bool result = slotMap.TryInsert(key2, "Value2", out var newKey);

            Assert.False(result);
            Assert.True(newKey.IsNull);
            Assert.Equal("Value1", slotMap[key1]);
        }

        [Fact]
        public void NewerVersionKey_ReturnsFalseAndNullKey()
        {
            var slotMap = new SlotMap<string>();
            var key1 = slotMap.Add("Value1");
            var key2 = key1 with { Version = 2 };

            bool result = slotMap.TryInsert(key2, "Value2", out var newKey);

            Assert.False(result);
            Assert.True(newKey.IsNull);
            Assert.Equal("Value1", slotMap[key1]);
        }
    }

    public class TryGet
    {
        [Fact]
        public void ValidKey_ReturnsTrueAndValue()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);

            bool result = slotMap.TryGet(key, out var value);

            Assert.True(result);
            Assert.Equal(42, value);
        }

        [Fact]
        public void InvalidKey_ReturnsFalseAndDefault()
        {
            var slotMap = new SlotMap<int>();
            var invalidKey = new SlotKey(0, -1);

            bool result = slotMap.TryGet(invalidKey, out var value);

            Assert.False(result);
            Assert.Equal(default, value);
        }

        [Fact]
        public void KeyNotFound_ReturnsFalseAndDefault()
        {
            var slotMap = new SlotMap<int>();
            var key = new SlotKey(1, 1);

            bool result = slotMap.TryGet(key, out var value);

            Assert.False(result);
            Assert.Equal(default, value);
        }

        [Fact]
        public void OlderVersionKey_ReturnsFalseAndDefault()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = key1 with { Version = 0 };

            bool result = slotMap.TryGet(key2, out var value);

            Assert.False(result);
            Assert.Equal(default, value);
        }

        [Fact]
        public void NewerVersionKey_ReturnsFalseAndDefault()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = key1 with { Version = 2 };

            bool result = slotMap.TryGet(key2, out var value);

            Assert.False(result);
            Assert.Equal(default, value);
        }
    }

    public class TryRemove
    {
        [Fact]
        public void ValidKey_RemovesAndReturnsTrueAndPreviousValue()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);

            bool result = slotMap.TryRemove(key, out var previousValue);

            Assert.True(result);
            Assert.Equal(42, previousValue);
            Assert.False(slotMap.TryGet(key, out _));
        }

        [Fact]
        public void InvalidKey_ReturnsFalseAndDefault()
        {
            var slotMap = new SlotMap<int>();
            var invalidKey = new SlotKey(0, -1);

            bool result = slotMap.TryRemove(invalidKey, out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }

        [Fact]
        public void KeyNotFound_ReturnsFalseAndDefault()
        {
            var slotMap = new SlotMap<int>();
            var key = new SlotKey(1, 1);

            bool result = slotMap.TryRemove(key, out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }

        [Fact]
        public void OlderVersionKey_ReturnsFalseAndDefault()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add( 42);
            var key2 = key1 with { Version = 0 };

            bool result = slotMap.TryRemove(key2, out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }

        [Fact]
        public void NewerVersionKey_ReturnsFalseAndDefault()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = key1 with { Version = 2 };
            

            bool result = slotMap.TryRemove(key2, out var previousValue);

            Assert.False(result);
            Assert.Equal(default, previousValue);
        }
    }

    [Fact]
    public void RemoveAndAdd_WithMultipleKeys_ProperlyRemovesAndAddValuesAndKeys()
    {
        var slotMap = new SlotMap<string>(10);

        var key1 = slotMap.Add("Value1");
        var key2 = slotMap.Add("Value2");
        var key3 = slotMap.Add("Value3");
        var key4 = slotMap.Add("Value4");
        var key5 = slotMap.Add("Value5");
        var key6 = slotMap.Add("Value6");
        var key7 = slotMap.Add("Value7");
        var key8 = slotMap.Add("Value8");
        var key9 = slotMap.Add("Value9");
        var key10 = slotMap.Add("Value10");

        var result1 = slotMap.Remove(key1);
        var result2 = slotMap.Remove(key2);
        var result3 = slotMap.Remove(key3);
        var result8 = slotMap.Remove(key8);
        var result9 = slotMap.Remove(key9);

        var newKey1 = slotMap.Add("NewValue1");
        var newKey2 = slotMap.Add("NewValue2");
        var newKey3 = slotMap.Add("NewValue3");
        var newKey8 = slotMap.Add("NewValue8");
        var newKey9 = slotMap.Add("NewValue9");

        // Verify if successfully removed
        Assert.Equal("Value1", result1);
        Assert.Equal("Value2", result2);
        Assert.Equal("Value3", result3);
        Assert.Equal("Value8", result8);
        Assert.Equal("Value9", result9);

        // Old keys should be invalidated
        Assert.False(slotMap.ContainsKey(key1));
        Assert.False(slotMap.ContainsKey(key2));
        Assert.False(slotMap.ContainsKey(key3));
        Assert.False(slotMap.ContainsKey(key8));
        Assert.False(slotMap.ContainsKey(key9));

        // New keys should exist
        Assert.True(slotMap.ContainsKey(newKey1));
        Assert.True(slotMap.ContainsKey(newKey2));
        Assert.True(slotMap.ContainsKey(newKey3));
        Assert.True(slotMap.ContainsKey(newKey8));
        Assert.True(slotMap.ContainsKey(newKey9));

        // Unremoved keys should still exist
        Assert.True(slotMap.ContainsKey(key4));
        Assert.True(slotMap.ContainsKey(key5));
        Assert.True(slotMap.ContainsKey(key6));
        Assert.True(slotMap.ContainsKey(key7));
        Assert.True(slotMap.ContainsKey(key10));

        // New values should match
        Assert.Equal("NewValue1", slotMap.Get(newKey1));
        Assert.Equal("NewValue2", slotMap.Get(newKey2));
        Assert.Equal("NewValue3", slotMap.Get(newKey3));
        Assert.Equal("NewValue8", slotMap.Get(newKey8));
        Assert.Equal("NewValue9", slotMap.Get(newKey9));

        // Unremoved values should match
        Assert.Equal("Value4", slotMap.Get(key4));
        Assert.Equal("Value5", slotMap.Get(key5));
        Assert.Equal("Value6", slotMap.Get(key6));
        Assert.Equal("Value7", slotMap.Get(key7));
        Assert.Equal("Value10", slotMap.Get(key10));

        Assert.Equal(10, slotMap.Capacity);
    }
}
