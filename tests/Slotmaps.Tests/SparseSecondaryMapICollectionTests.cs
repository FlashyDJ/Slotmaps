using ISlotCollection = System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<FlashyDJ.Slotmaps.SlotKey, int>>;

namespace Slotmaps.Tests;
public class SparseSecondaryMapICollectionTests
{
    public class Add
    {
        [Fact]
        public void ValidKeyAndValue_AddsKeyValuePairToMap()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 0);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            (sparseMap as ISlotCollection).Add(kvp);

            Assert.Equal(42, sparseMap[key]);
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(-1, 0);
            var kvp = new KeyValuePair<SlotKey, int>(invalidKey, 42);

            var ex = Assert.Throws<KeyNotFoundException>(() => (sparseMap as ISlotCollection).Add(kvp));
            Assert.Equal("Invalid SlotKey", ex.Message);
        }

        [Fact]
        public void OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);
            sparseMap.Insert(key1, 42);
            var kvp = new KeyValuePair<SlotKey, int>(key2, 24);

            var ex = Assert.Throws<KeyNotFoundException>(() => (sparseMap as ISlotCollection).Add(kvp));
            Assert.Equal("SlotKey is an older version", ex.Message);
        }
    }

    public class Contains
    {
        [Fact]
        public void ExistingKeyValuePair_ReturnsTrue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            sparseMap.Insert(key, 42);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            var result = (sparseMap as ISlotCollection).Contains(kvp);

            Assert.True(result);
        }

        [Fact]
        public void NonexistentKeyValuePair_ReturnsFalse()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            var result = (sparseMap as ISlotCollection).Contains(kvp);

            Assert.False(result);
        }

        [Fact]
        public void InvalidKey_ReturnsFalse()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(-1, 0);
            var kvp = new KeyValuePair<SlotKey, int>(invalidKey, 42);

            var result = (sparseMap as ISlotCollection).Contains(kvp);

            Assert.False(result);
        }

        [Fact]
        public void KeyWithOlderVersion_ReturnsFalse()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(1, 1);
            sparseMap.TryInsert(key1, 42, out _);
            var kvp = new KeyValuePair<SlotKey, int>(key2, 24);

            var result = (sparseMap as ISlotCollection).Contains(kvp);

            Assert.False(result);
        }

        [Fact]
        public void ExistingValue_ReturnsTrue()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);

            var result = (sparseMap as ISlotCollection).Contains(
                new KeyValuePair<SlotKey, int>(key1, 42));

            Assert.True(result);
        }

        [Fact]
        public void NonexistentValue_ReturnsFalse()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);

            var result = (sparseMap as ISlotCollection)
                         .Contains(new KeyValuePair<SlotKey, int>(key1, 99));

            Assert.False(result);
        }
    }

    public class CopyTo
    {
        [Fact]
        public void ValidArguments_CopiesKeyValuePairsToArray()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            sparseMap.Insert(key3, 36);
            var array = new KeyValuePair<SlotKey, int>[3];

            (sparseMap as ISlotCollection).CopyTo(array, 0);

            Assert.Equal(new KeyValuePair<SlotKey, int>(key1, 42), array[0]);
            Assert.Equal(new KeyValuePair<SlotKey, int>(key2, 24), array[1]);
            Assert.Equal(new KeyValuePair<SlotKey, int>(key3, 36), array[2]);
        }

        [Fact]
        public void InvalidArray_ThrowsArgumentNullException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var array = (KeyValuePair<SlotKey, int>[])null!;

            Assert.Throws<ArgumentNullException>(
                () => (sparseMap as ISlotCollection).CopyTo(array, 0)
            );
        }

        [Fact]
        public void NegativeIndex_ThrowsArgumentOutOfRangeException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var array = new KeyValuePair<SlotKey, int>[1];

            Assert.Throws<ArgumentOutOfRangeException>(
                () => (sparseMap as ISlotCollection).CopyTo(array, -1)
            );
        }

        [Fact]
        public void IndexGreaterThanArrayLength_ThrowsArgumentOutOfRangeException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var array = new KeyValuePair<SlotKey, int>[1];

            Assert.Throws<ArgumentOutOfRangeException>(
                () => (sparseMap as ISlotCollection).CopyTo(array, 2)
            );
        }

        [Fact]
        public void NotEnoughSpaceInArray_ThrowsArgumentOutOfRangeException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var array = new KeyValuePair<SlotKey, int>[2];

            Assert.Throws<ArgumentOutOfRangeException>(
                () => (sparseMap as ISlotCollection).CopyTo(array, 1)
            );
        }
    }

    public class Enumerator
    {
        [Fact]
        public void GetEnumerator_EnumeratesAllKeyValuePairs()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            var expectedPairs = new List<KeyValuePair<SlotKey, int>>
            {
                new KeyValuePair<SlotKey, int>(key1, 42),
                new KeyValuePair<SlotKey, int>(key2, 24)
            };

            var enumerator = (sparseMap as ISlotCollection).GetEnumerator();
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
            var sparseMap = new SparseSecondaryMap<int>();

            var enumerator = (sparseMap as ISlotCollection).GetEnumerator();

            Assert.False(enumerator.MoveNext());
        }

        [Fact]
        public void GetEnumerator_AfterRemovingKey_EnumeratesRemainingKeyValuePairs()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            var expectedPairs = new List<KeyValuePair<SlotKey, int>>
            {
                new KeyValuePair<SlotKey, int>(key2, 24)
            };
            sparseMap.Remove(key1);

            var enumerator = (sparseMap as ISlotCollection).GetEnumerator();
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
            var slotMap = new SparseSecondaryMap<int>(3);
            ISlotCollection iSlotMap = slotMap;

            slotMap.Insert(new(0, 1), 10);
            slotMap.Insert(new(1, 1), 20);
            slotMap.Insert(new(2, 1), 30);

            var enumerator = iSlotMap.GetEnumerator();
            var enumeratedItems = new List<KeyValuePair<SlotKey, int>>();

            while (enumerator.MoveNext())
            {
                enumeratedItems.Add(enumerator.Current);
            }

            Assert.Equal(3, enumeratedItems.Count);

            Assert.Contains(new KeyValuePair<SlotKey, int>(
                new SlotKey(0, 1), 10), enumeratedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(
                new SlotKey(1, 1), 20), enumeratedItems);
            Assert.Contains(new KeyValuePair<SlotKey, int>(
                new SlotKey(2, 1), 30), enumeratedItems);
        }
    }

    public class ForEachLoop
    {
        [Fact]
        public void EnumeratesAllKeyValuePairs()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);

            var expectedPairs = new List<KeyValuePair<SlotKey, int>>
            {
                new KeyValuePair<SlotKey, int>(key1, 42),
                new KeyValuePair<SlotKey, int>(key2, 24)
            };

            var actualPairs = new List<KeyValuePair<SlotKey, int>>();
            foreach (var kvp in sparseMap)
            {
                actualPairs.Add(kvp);
            }

            Assert.Equal(expectedPairs, actualPairs);
        }

        [Fact]
        public void EmptyMap_DoesNotEnterLoop()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            bool enteredLoop = false;

            foreach (var kvp in sparseMap)
            {
                enteredLoop = true;
            }

            Assert.False(enteredLoop);
        }

        [Fact]
        public void AfterRemovingKey_EnumeratesRemainingKeyValuePairs()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);

            sparseMap.Insert(key1, 42);
            sparseMap.Insert(key2, 24);
            sparseMap.Remove(key1);

            var expectedPairs = new List<KeyValuePair<SlotKey, int>>
            {
                new KeyValuePair<SlotKey, int>(key2, 24)
            };

            var actualPairs = new List<KeyValuePair<SlotKey, int>>();
            foreach (var kvp in sparseMap)
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
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            sparseMap.Insert(key, 42);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            var result = (sparseMap as ISlotCollection).Remove(kvp);

            Assert.True(result);
            Assert.Empty(sparseMap);
        }

        [Fact]
        public void NonexistentKeyValuePair_ReturnsFalse()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            var result = (sparseMap as ISlotCollection).Remove(kvp);

            Assert.False(result);
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var sparseMap = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(-1, 0);
            var kvp = new KeyValuePair<SlotKey, int>(invalidKey, 42);

            var result = (sparseMap as ISlotCollection).Remove(kvp);

            Assert.False(result);
        }
    }
    
}

