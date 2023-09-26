namespace Slotmaps.Tests;
public class SecondarySlotMapTests
{
    [Fact]
    public void Count_InitiallyEmpty()
    {
        var secondaryMap = new SecondaryMap<int>();
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void ShouldClearMap()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(0, 1);
        var key2 = new SlotKey(1, 1);
        var value1 = 42;
        var value2 = 23;

        secondaryMap.Insert(key1, value1);
        secondaryMap.Insert(key2, value2);
        secondaryMap.Clear();

        Assert.False(secondaryMap.ContainsKey(key1));
        Assert.False(secondaryMap.ContainsKey(key2));
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void Insert_ShouldInsertValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(0, 1);
        var value = 42;

        secondaryMap.Insert(key, value);

        Assert.True(secondaryMap.ContainsKey(key));
        Assert.Equal(value, secondaryMap.Get(key));
        Assert.Single(secondaryMap); 
    }

    [Fact]
    public void Insert_SameVersion_ShouldInsertAndReplaceValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(0,1);
        var initialValue = 42;
        var updatedValue = 100;

        secondaryMap.Insert(key, initialValue);
        var result2 = secondaryMap.Insert(key, updatedValue);

        Assert.Equal(initialValue, result2);
        Assert.True(secondaryMap.ContainsKey(key));
        Assert.Equal(updatedValue, secondaryMap.Get(key));
        Assert.Single(secondaryMap);
    }

    [Fact]
    public void Insert_NewVersion_ShouldInsertAndReplaceValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(0, 1);
        var initialValue = 42;
        var updatedValue = 100;

        secondaryMap.Insert(key, initialValue);
        var result2 = secondaryMap.Insert(key with { Version = 3 }, updatedValue);

        Assert.Equal(initialValue, result2);
        Assert.True(secondaryMap.ContainsKey(key with { Version = 3 }));
        Assert.Equal(updatedValue, secondaryMap.Get(key with { Version = 3 }));
        Assert.Single(secondaryMap);
    }

    [Fact]
    public void Insert_ShouldInsertMultipleValues()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(0, 1);
        var key2 = new SlotKey(1, 1);
        var value1 = 42;
        var value2 = 23;

        secondaryMap.Insert(key1, value1);
        secondaryMap.Insert(key2, value2);


        Assert.True(secondaryMap.ContainsKey(key1));
        Assert.True(secondaryMap.ContainsKey(key2));
        Assert.Equal(value1, secondaryMap.Get(key1));
        Assert.Equal(value2, secondaryMap.Get(key2));
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void Remove_ShouldRemoveValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(0,1);
        var value = 42;

        secondaryMap.Insert(key, value);
        secondaryMap.Remove(key);

        Assert.False(secondaryMap.ContainsKey(key));
    }
}

