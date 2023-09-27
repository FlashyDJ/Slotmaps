using ISlotCollection = System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<FlashyDJ.Slotmaps.SlotKey, int>>;

namespace Slotmaps.Tests;
public class SparseSecondaryMapICollectionTests
{
    public class Add
    {
        [Fact]
        public void ValidKeyAndValue_AddsKeyValuePairToMap()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 0);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            (map as ISlotCollection).Add(kvp);

            Assert.Equal(42, map[key]);
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(0, -1);
            var kvp = new KeyValuePair<SlotKey, int>(invalidKey, 42);

            var ex = Assert.Throws<KeyNotFoundException>(() => (map as ISlotCollection).Add(kvp));
            Assert.Equal("Invalid SlotKey", ex.Message);
        }

        [Fact]
        public void OlderVersionKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 2);
            var key2 = new SlotKey(1, 1);
            map.Insert(key1, 42);
            var kvp = new KeyValuePair<SlotKey, int>(key2, 24);

            var ex = Assert.Throws<KeyNotFoundException>(() => (map as ISlotCollection).Add(kvp));
            Assert.Equal("SlotKey is an older version", ex.Message);
        }
    }

    public class Contains
    {
        [Fact]
        public void ExistingKeyValuePair_ReturnsTrue()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            map.Insert(key, 42);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            var result = (map as ISlotCollection).Contains(kvp);

            Assert.True(result);
        }

        [Fact]
        public void NonexistentKeyValuePair_ReturnsFalse()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            var result = (map as ISlotCollection).Contains(kvp);

            Assert.False(result);
        }

        [Fact]
        public void InvalidKey_ReturnsFalse()
        {
            var map = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(0, -1);
            var kvp = new KeyValuePair<SlotKey, int>(invalidKey, 42);

            var result = (map as ISlotCollection).Contains(kvp);

            Assert.False(result);
        }

        [Fact]
        public void KeyWithOlderVersion_ReturnsFalse()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(1, 1);
            map.TryInsert(key1, 42, out _);
            var kvp = new KeyValuePair<SlotKey, int>(key2, 24);

            var result = (map as ISlotCollection).Contains(kvp);

            Assert.False(result);
        }

        [Fact]
        public void ExistingValue_ReturnsTrue()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);

            var result = (map as ISlotCollection).Contains(
                new KeyValuePair<SlotKey, int>(key1, 42));

            Assert.True(result);
        }

        [Fact]
        public void NonexistentValue_ReturnsFalse()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);

            var result = (map as ISlotCollection)
                         .Contains(new KeyValuePair<SlotKey, int>(key1, 99));

            Assert.False(result);
        }
    }

    public class CopyTo
    {
        [Fact]
        public void ValidArguments_CopiesKeyValuePairsToArray()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            var key3 = new SlotKey(3, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);
            map.Insert(key3, 36);
            var array = new KeyValuePair<SlotKey, int>[3];

            (map as ISlotCollection).CopyTo(array, 0);

            Assert.Equal(new KeyValuePair<SlotKey, int>(key1, 42), array[0]);
            Assert.Equal(new KeyValuePair<SlotKey, int>(key2, 24), array[1]);
            Assert.Equal(new KeyValuePair<SlotKey, int>(key3, 36), array[2]);
        }

        [Fact]
        public void InvalidArray_ThrowsArgumentNullException()
        {
            var map = new SparseSecondaryMap<int>();
            var array = (KeyValuePair<SlotKey, int>[])null!;

            Assert.Throws<ArgumentNullException>(
                () => (map as ISlotCollection).CopyTo(array, 0)
            );
        }

        [Fact]
        public void NegativeIndex_ThrowsArgumentOutOfRangeException()
        {
            var map = new SparseSecondaryMap<int>();
            var array = new KeyValuePair<SlotKey, int>[1];

            Assert.Throws<ArgumentOutOfRangeException>(
                () => (map as ISlotCollection).CopyTo(array, -1)
            );
        }

        [Fact]
        public void IndexGreaterThanArrayLength_ThrowsArgumentOutOfRangeException()
        {
            var map = new SparseSecondaryMap<int>();
            var array = new KeyValuePair<SlotKey, int>[1];

            Assert.Throws<ArgumentOutOfRangeException>(
                () => (map as ISlotCollection).CopyTo(array, 2)
            );
        }

        [Fact]
        public void NotEnoughSpaceInArray_ThrowsArgumentOutOfRangeException()
        {
            var map = new SparseSecondaryMap<int>();
            var array = new KeyValuePair<SlotKey, int>[2];

            Assert.Throws<ArgumentOutOfRangeException>(
                () => (map as ISlotCollection).CopyTo(array, 1)
            );
        }
    }

    public class Enumerator
    {
        [Fact]
        public void GetEnumerator_EnumeratesAllKeyValuePairs()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);
            var expectedPairs = new List<KeyValuePair<SlotKey, int>>
            {
                new KeyValuePair<SlotKey, int>(key1, 42),
                new KeyValuePair<SlotKey, int>(key2, 24)
            };

            var enumerator = (map as ISlotCollection).GetEnumerator();
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
            var map = new SparseSecondaryMap<int>();

            var enumerator = (map as ISlotCollection).GetEnumerator();

            Assert.False(enumerator.MoveNext());
        }

        [Fact]
        public void GetEnumerator_AfterRemovingKey_EnumeratesRemainingKeyValuePairs()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);
            var expectedPairs = new List<KeyValuePair<SlotKey, int>>
            {
                new KeyValuePair<SlotKey, int>(key2, 24)
            };
            map.Remove(key1);

            var enumerator = (map as ISlotCollection).GetEnumerator();
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
        public void IEnumerable_ForeachLoop_EnumeratesAllKeyValuePairs()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);
            map.Insert(key1, 42);
            map.Insert(key2, 24);

            var expectedPairs = new List<KeyValuePair<SlotKey, int>>
            {
                new KeyValuePair<SlotKey, int>(key1, 42),
                new KeyValuePair<SlotKey, int>(key2, 24)
            };

            var actualPairs = new List<KeyValuePair<SlotKey, int>>();
            foreach (var kvp in map)
            {
                actualPairs.Add(kvp);
            }

            Assert.Equal(expectedPairs, actualPairs);
        }

        [Fact]
        public void IEnumerable_ForeachLoop_EmptyMap_DoesNotEnterLoop()
        {
            var map = new SparseSecondaryMap<int>();
            bool enteredLoop = false;

            foreach (var kvp in map)
            {
                enteredLoop = true;
            }

            Assert.False(enteredLoop);
        }

        [Fact]
        public void IEnumerable_ForeachLoop_AfterRemovingKey_EnumeratesRemainingKeyValuePairs()
        {
            var map = new SparseSecondaryMap<int>();
            var key1 = new SlotKey(1, 1);
            var key2 = new SlotKey(2, 1);

            map.Insert(key1, 42);
            map.Insert(key2, 24);
            map.Remove(key1);

            var expectedPairs = new List<KeyValuePair<SlotKey, int>>
            {
                new KeyValuePair<SlotKey, int>(key2, 24)
            };

            var actualPairs = new List<KeyValuePair<SlotKey, int>>();
            foreach (var kvp in map)
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
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            map.Insert(key, 42);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            var result = (map as ISlotCollection).Remove(kvp);

            Assert.True(result);
            Assert.Empty(map);
        }

        [Fact]
        public void NonexistentKeyValuePair_ReturnsFalse()
        {
            var map = new SparseSecondaryMap<int>();
            var key = new SlotKey(1, 1);
            var kvp = new KeyValuePair<SlotKey, int>(key, 42);

            var result = (map as ISlotCollection).Remove(kvp);

            Assert.False(result);
        }

        [Fact]
        public void InvalidKey_ThrowsKeyNotFoundException()
        {
            var map = new SparseSecondaryMap<int>();
            var invalidKey = new SlotKey(0, -1);
            var kvp = new KeyValuePair<SlotKey, int>(invalidKey, 42);

            var result = (map as ISlotCollection).Remove(kvp);

            Assert.False(result);
        }
    }
    
}

