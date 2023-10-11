using ISlotCollection = System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<FlashyDJ.Slotmaps.SlotKey, int>>;

namespace Slotmaps.Tests;
public class SlotMapICollectionTests
{
    public class Add
    {
        [Fact]
        public void ValidKeyAndValue_AddsKeyValuePairToMap()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(24);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            (slotMap as ISlotCollection).Add(kvp);

            Assert.Equal(42, slotMap[key with { Version = 3 }]);
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<int>();
            var invalidKey = new SlotKey(-1, 0);
            var kvp = new KeyValuePair<SlotKey, int>(invalidKey, 42);

            var ex = Assert.Throws<KeyNotFoundException>(() => (slotMap as ISlotCollection).Add(kvp));
            Assert.Equal("Invalid SlotKey", ex.Message);
        }

        [Fact]
        public void OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = key1 with { Version = 0 };
            var kvp = new KeyValuePair<SlotKey, int>(key2, 24);

            var ex = Assert.Throws<KeyNotFoundException>(() => (slotMap as ISlotCollection).Add(kvp));
            Assert.Equal("Invalid SlotKey", ex.Message);
        }
    }
    
    public class Clear
    {
        [Fact]
        public void WithItems_ClearsMapAndSetsCountToZero()
        {
            var slotMap = new SlotMap<int>(2);
            slotMap.Add(42);
            slotMap.Add(24);

            (slotMap as ISlotCollection).Clear();

            Assert.Equal(0, (slotMap as ISlotCollection).Count);
            Assert.Empty((slotMap as ISlotCollection));
        }
    }
    
    public class Contains
    {
        [Fact]
        public void ExistingKeyValuePair_ReturnsTrue()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            bool containsKey = (slotMap as ISlotCollection).Contains(kvp);

            Assert.True(containsKey);
        }

        [Fact]
        public void NonexistentKeyValuePair_ReturnsFalse()
        {
            var slotMap = new SlotMap<int>();
            var key = new SlotKey(1, 1);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            bool containsKey = (slotMap as ISlotCollection).Contains(kvp);

            Assert.False(containsKey);
        }

        [Fact]
        public void InvalidKey_ReturnsFalse()
        {
            var slotMap = new SlotMap<int>();
            var invalidKey = new SlotKey(-1, 0);
            var kvp = new KeyValuePair<SlotKey, int>(invalidKey, 42);

            var result = (slotMap as ISlotCollection).Contains(kvp);

            Assert.False(result);
        }

        [Fact]
        public void KeyWithOlderVersion_ReturnsFalse()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = key1 with { Version = 0 };
            var kvp = new KeyValuePair<SlotKey, int>(key2, 24);

            var result = (slotMap as ISlotCollection).Contains(kvp);

            Assert.False(result);
        }
    }
    
    public class CopyTo
    {
        [Fact]
        public void ValidArguments_CopiesKeyValuePairsToArray()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = slotMap.Add(24);
            var key3 = slotMap.Add(36);

            var array = new KeyValuePair<SlotKey, int>[3];

            (slotMap as ISlotCollection).CopyTo(array, 0);

            Assert.Equal(new KeyValuePair<SlotKey, int>(key1, 42), array[0]);
            Assert.Equal(new KeyValuePair<SlotKey, int>(key2, 24), array[1]);
            Assert.Equal(new KeyValuePair<SlotKey, int>(key3, 36), array[2]);
        }

        [Fact]
        public void InvalidArray_ThrowsArgumentNullException()
        {
            var slotMap = new SlotMap<int>();
            var array = (KeyValuePair<SlotKey, int>[])null!;

            Assert.Throws<ArgumentNullException>(
                () => (slotMap as ISlotCollection).CopyTo(array, 0)
            );
        }

        [Fact]
        public void NegativeIndex_ThrowsArgumentOutOfRangeException()
        {
            var slotMap = new SlotMap<int>();
            var array = new KeyValuePair<SlotKey, int>[1];

            Assert.Throws<ArgumentOutOfRangeException>(
                () => (slotMap as ISlotCollection).CopyTo(array, -1)
            );
        }

        [Fact]
        public void IndexGreaterThanArrayLength_ThrowsArgumentOutOfRangeException()
        {
            var slotMap = new SlotMap<int>();
            var array = new KeyValuePair<SlotKey, int>[1];

            Assert.Throws<ArgumentOutOfRangeException>(
                () => (slotMap as ISlotCollection).CopyTo(array, 2)
            );
        }

        [Fact]
        public void NotEnoughSpaceInArray_ThrowsArgumentOutOfRangeException()
        {
            var slotMap = new SlotMap<int>();
            var array = new KeyValuePair<SlotKey, int>[2];

            Assert.Throws<ArgumentOutOfRangeException>(
                () => (slotMap as ISlotCollection).CopyTo(array, 1)
            );
        }
    }
    
    public class Enumerator
    {
        [Fact]
        public void GetEnumerator_EnumeratesAllKeyValuePairs()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = slotMap.Add(24);

            var expectedPairs = new List<KeyValuePair<SlotKey, int>>
            {
                new KeyValuePair<SlotKey, int>(key1, 42),
                new KeyValuePair<SlotKey, int>(key2, 24)
            };

            var enumerator = (slotMap as ISlotCollection).GetEnumerator();
            var actualPairs = new List<KeyValuePair<SlotKey, int>>();
            while (enumerator.MoveNext())
            {
                actualPairs.Add(enumerator.Current);
            }

            Assert.Equal(expectedPairs, actualPairs);
        }

        [Fact]
        public void GetEnumerator_EmptyMap_ReturnsEmptyEnumerator()
        {
            var slotMap = new SlotMap<int>();

            var enumerator = (slotMap as ISlotCollection).GetEnumerator();

            Assert.False(enumerator.MoveNext());
        }

        [Fact]
        public void GetEnumerator_AfterRemovingKey_EnumeratesRemainingKeyValuePairs()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = slotMap.Add(24);

            var expectedPairs = new List<KeyValuePair<SlotKey, int>>
            {
                new KeyValuePair<SlotKey, int>(key2, 24)
            };

            slotMap.Remove(key1);

            var enumerator = (slotMap as ISlotCollection).GetEnumerator();
            var actualPairs = new List<KeyValuePair<SlotKey, int>>();
            while (enumerator.MoveNext())
            {
                actualPairs.Add(enumerator.Current);
            }

            Assert.Equal(expectedPairs, actualPairs);
        }

        [Fact]
        public void Enumerator_ShouldEnumerateCorrectly()
        {
            var slotMap = new SlotMap<int>(3);

            var key1 = slotMap.Add(10);
            var key2 = slotMap.Add(20);
            var key3 = slotMap.Add(30);

            var enumerator = (slotMap as ISlotCollection).GetEnumerator();
            var enumeratedItems = new List<KeyValuePair<SlotKey, int>>();

            while (enumerator.MoveNext())
            {
                enumeratedItems.Add(enumerator.Current);
            }

            Assert.Equal(3, enumeratedItems.Count);

            Assert.Contains(new KeyValuePair<SlotKey, int>(key1, 10), enumeratedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 20), enumeratedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(key3, 30), enumeratedItems);
        }
    }

    public class ForEachLoop
    {
        [Fact]
        public void EnumeratesAllKeyValuePairs()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = slotMap.Add(24);

            var expectedPairs = new List<KeyValuePair<SlotKey, int>>
            {
                new KeyValuePair<SlotKey, int>(key1, 42),
                new KeyValuePair<SlotKey, int>(key2, 24)
            };

            var actualPairs = new List<KeyValuePair<SlotKey, int>>();
            foreach (var kvp in slotMap)
            {
                actualPairs.Add(kvp);
            }

            Assert.Equal(expectedPairs, actualPairs);
        }

        [Fact]
        public void EmptyMap_DoesNotEnterLoop()
        {
            var slotMap = new SlotMap<int>();
            bool enteredLoop = false;

            foreach (var kvp in slotMap)
            {
                enteredLoop = true;
            }

            Assert.False(enteredLoop);
        }

        [Fact]
        public void AfterRemovingKey_EnumeratesRemainingKeyValuePairs()
        {
            var slotMap = new SlotMap<int>();
            var key1 = slotMap.Add(42);
            var key2 = slotMap.Add(24);

            slotMap.Remove(key1);

            var expectedPairs = new List<KeyValuePair<SlotKey, int>>
            {
                new KeyValuePair<SlotKey, int>(key2, 24)
            };

            var actualPairs = new List<KeyValuePair<SlotKey, int>>();
            foreach (var kvp in slotMap)
            {
                actualPairs.Add(kvp);
            }

            Assert.Equal(expectedPairs, actualPairs);
        }
    }

    public class Remove
    {
        [Fact]
        public void ExistingKeyValuePair_RemovesKeyValuePairAndReturnsTrue()
        {
            var slotMap = new SlotMap<int>();
            var key = slotMap.Add(42);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            var result = (slotMap as ISlotCollection).Remove(kvp);

            Assert.True(result);
            Assert.Empty(slotMap);
        }

        [Fact]
        public void NonexistentKeyValuePair_ReturnsFalse()
        {
            var slotMap = new SlotMap<int>();
            var key = new SlotKey(1, 1);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            var result = (slotMap as ISlotCollection).Remove(kvp);

            Assert.False(result);
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var slotMap = new SlotMap<int>();
            var invalidKey = new SlotKey(-1, 0);
            var kvp = new KeyValuePair<SlotKey, int>(invalidKey, 42);

            var result = (slotMap as ISlotCollection).Remove(kvp);

            Assert.False(result);
        }
    }
}

