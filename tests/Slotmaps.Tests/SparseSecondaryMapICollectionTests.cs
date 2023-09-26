using ISlotCollection = System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<FlashyDJ.Slotmaps.SlotKey, string>>;

namespace Slotmaps.Tests;
public class SparseSecondaryMapICollectionTests
{
    [Fact]
    public void Enumerator_ShouldEnumerateCorrectly()
    {
        var slotMap = new SparseSecondaryMap<string>(3);
        ISlotCollection iSlotMap = slotMap;

        slotMap.Insert(new(0,1),"10");
        slotMap.Insert(new(1, 1),"20");
        slotMap.Insert(new(2, 1),"30");

        var enumerator = iSlotMap.GetEnumerator();
        var enumeratedItems = new List<KeyValuePair<SlotKey, string>>();

        while (enumerator.MoveNext())
        {
            enumeratedItems.Add(enumerator.Current);
        }

        Assert.Equal(3, enumeratedItems.Count);

        Assert.Contains(new KeyValuePair<SlotKey, string>(new SlotKey(0, 1), "10"), enumeratedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(new SlotKey(1, 1), "20"), enumeratedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(new SlotKey(2, 1), "30"), enumeratedItems);
    }
}

