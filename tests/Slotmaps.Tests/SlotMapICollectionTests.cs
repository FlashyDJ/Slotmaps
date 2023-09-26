using ISlotCollection = System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<FlashyDJ.Slotmaps.SlotKey, string>>;

namespace Slotmaps.Tests;
public class SlotMapICollectionTests
{
    public class Add
    {
        [Fact]
        public void AddsKeyValuePairToSlotMap_ShouldContainAddedKeyAndValue()
        {
            ISlotCollection iSlotMap = new SlotMap<string>(1);
            var key0 = new SlotKey(0, 0);

            iSlotMap.Add(new(key0, "TestValue"));

            Assert.True(iSlotMap.Contains(new(key0 with { Version = 1}, "TestValue")));
        }
    }
    
    public class Clear
    {
        [Fact]
        public void WithElementsAdded_ShouldRemoveAllElementsFromSlotMap()
        {
            ISlotCollection iSlotMap = new SlotMap<string>(1);
            iSlotMap.Add(new(new(0,0), "TestValue"));

            iSlotMap.Clear();

            Assert.Equal(0, iSlotMap.Count);
        }
    }
    
    public class Contains
    {
        [Fact]
        public void ExistingKeyValuePair_ShouldReturnTrue()
        {
            SlotMap<string> slotMap = new SlotMap<string>();
            SlotKey key = slotMap.Add("TestValue");

            ISlotCollection iSlotMap = slotMap;
            bool containsKey = iSlotMap.Contains(new(key, "TestValue"));

            Assert.True(containsKey);
            Assert.True(slotMap.ContainsKey(key));
        }

        [Fact]
        public void KeyValuePairNotPresent_ShouldReturnFalse()
        {
            SlotMap<string> slotMap = new SlotMap<string>();
            ISlotCollection iSlotMap = slotMap;

            bool containsKey = iSlotMap.Contains(new(SlotKey.Null, ""));

            Assert.False(containsKey);
        }
    }
    
    public class CopyTo
    {
        [Fact]
        public void ElementsAddedToSlotMap_CopyToArray()
        {
            SlotMap<string> slotMap = new SlotMap<string>(3);
            slotMap.Add( "One");
            slotMap.Add( "Two");
            slotMap.Add( "Three");

            KeyValuePair<SlotKey, string>[] array = new KeyValuePair<SlotKey, string>[3];
            ISlotCollection iSlotMap = slotMap;

            iSlotMap.CopyTo(array, 0);

            Assert.Equal(new KeyValuePair<SlotKey, string>(new SlotKey(0,1), "One"), array[0]);
            Assert.Equal(new KeyValuePair<SlotKey, string>(new SlotKey(1,1), "Two"), array[1]);
            Assert.Equal(new KeyValuePair<SlotKey, string>(new SlotKey(2,1), "Three"), array[2]);
        }
    }
    
    public class Enumerator
    {
        [Fact]
        public void EnumeratingItemsInSlotMap_ShouldEnumerateCorrectly()
        {
            SlotMap<string> slotMap = new SlotMap<string>(3);
            ISlotCollection iSlotMap = slotMap;

            slotMap.Add("10");
            slotMap.Add("20");
            slotMap.Add("30");

            var enumerator = iSlotMap.GetEnumerator();
            var enumeratedItems = new List<KeyValuePair<SlotKey, string>>();
            foreach (var item in iSlotMap)
            {
                enumeratedItems.Add(item);
            }
            // while (enumerator.MoveNext())
            // {
            //     enumeratedItems.Add(enumerator.Current);
            // }

            Assert.Equal(3, enumeratedItems.Count);

            Assert.Contains(new KeyValuePair<SlotKey, string>(new SlotKey(0,1), "10"), enumeratedItems);
            Assert.Contains(new KeyValuePair<SlotKey, string>(new SlotKey(1,1), "20"), enumeratedItems);
            Assert.Contains(new KeyValuePair<SlotKey, string>(new SlotKey(2,1), "30"), enumeratedItems);
        }
    }
    
    public class Remove
    {
        [Fact]
        public void RemoveKeyValuePairFromSlotMap_ShouldSucceed()
        {
            ISlotCollection iSlotMap = new SlotMap<string>(1);
            var key0 = new SlotKey(0, 0);

            iSlotMap.Add(new(key0, "TestValue"));

            bool removed = iSlotMap.Remove(new(key0 with { Version = 1 }, "TestValue"));

            Assert.True(removed);
            Assert.False(iSlotMap.Contains(new(key0 with { Version = 1 }, "TestValue")));
        }

    }
}

