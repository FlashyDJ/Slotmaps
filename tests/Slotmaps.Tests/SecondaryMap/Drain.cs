//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SecondaryMap;

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

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, 10);
        secondaryMap.Insert(key2, 20);

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key1, 10), result);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 20), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithInt_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, 10);
        secondaryMap.Insert(key2, 20);
        secondaryMap.Insert(key3, 30);
        secondaryMap.Insert(key4, 40);

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 20), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key3, 30), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithInt_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, 10);
        secondaryMap.Insert(key2, 20);
        secondaryMap.Insert(key3, 30);
        secondaryMap.Insert(key4, 40);
        secondaryMap.Insert(key5, 50);
        secondaryMap.Insert(key6, 60);

        List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, int>(key1, 10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 20), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key3, 30), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key4, 40), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key5, 50), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key6, 60), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithInt_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, 10);
        secondaryMap.Insert(key2, 20);
        secondaryMap.Insert(key3, 30);
        secondaryMap.Insert(key4, 40);
        secondaryMap.Insert(key5, 50);
        secondaryMap.Insert(key6, 60);

        List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, int>(key1, 10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 20), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key3, 30), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key4, 40), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key5, 50), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key6, 60), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 10);

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key2, 10), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithIntNullable_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 10);
        secondaryMap.Insert(key3, 20);
        secondaryMap.Insert(key4, 30);

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, int?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key2, 10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key3, 20), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithIntNullable_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 10);
        secondaryMap.Insert(key3, 20);
        secondaryMap.Insert(key4, 30);
        secondaryMap.Insert(key5, 40);
        secondaryMap.Insert(key6, 50);

        List<KeyValuePair<SlotKey, int?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, int?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key2, 10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key3, 20), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key4, 30), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key5, 40), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key6, 50), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithIntNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 10);
        secondaryMap.Insert(key3, 20);
        secondaryMap.Insert(key4, 30);
        secondaryMap.Insert(key5, 40);
        secondaryMap.Insert(key6, 50);

        List<KeyValuePair<SlotKey, int?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, int?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key2, 10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key3, 20), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key4, 30), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key5, 40), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key6, 50), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, "Value 1");
        secondaryMap.Insert(key2, "Value 2");

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key1, "Value 1"), result);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key2, "Value 2"), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithString_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, "Value 1");
        secondaryMap.Insert(key2, "Value 2");
        secondaryMap.Insert(key3, "Value 3");
        secondaryMap.Insert(key4, "Value 4");

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, string>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key2, "Value 2"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key3, "Value 3"), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithString_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, "Value 1");
        secondaryMap.Insert(key2, "Value 2");
        secondaryMap.Insert(key3, "Value 3");
        secondaryMap.Insert(key4, "Value 4");
        secondaryMap.Insert(key5, "Value 5");
        secondaryMap.Insert(key6, "Value 6");

        List<KeyValuePair<SlotKey, string>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, string>(key1, "Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key2, "Value 2"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key3, "Value 3"), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key4, "Value 4"), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key5, "Value 5"), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key6, "Value 6"), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithString_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, "Value 1");
        secondaryMap.Insert(key2, "Value 2");
        secondaryMap.Insert(key3, "Value 3");
        secondaryMap.Insert(key4, "Value 4");
        secondaryMap.Insert(key5, "Value 5");
        secondaryMap.Insert(key6, "Value 6");

        List<KeyValuePair<SlotKey, string>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, string>(key1, "Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key2, "Value 2"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key3, "Value 3"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key4, "Value 4"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key5, "Value 5"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key6, "Value 6"), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, "Value 1");

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key2, "Value 1"), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithStringNullable_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, "Value 1");
        secondaryMap.Insert(key3, "Value 2");
        secondaryMap.Insert(key4, "Value 3");

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, string?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key2, "Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key3, "Value 2"), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithStringNullable_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, "Value 1");
        secondaryMap.Insert(key3, "Value 2");
        secondaryMap.Insert(key4, "Value 3");
        secondaryMap.Insert(key5, "Value 4");
        secondaryMap.Insert(key6, "Value 5");

        List<KeyValuePair<SlotKey, string?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, string?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key2, "Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key3, "Value 2"), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key4, "Value 3"), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key5, "Value 4"), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key6, "Value 5"), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithStringNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, "Value 1");
        secondaryMap.Insert(key3, "Value 2");
        secondaryMap.Insert(key4, "Value 3");
        secondaryMap.Insert(key5, "Value 4");
        secondaryMap.Insert(key6, "Value 5");

        List<KeyValuePair<SlotKey, string?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, string?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key2, "Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key3, "Value 2"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key4, "Value 3"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key5, "Value 4"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key6, "Value 5"), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, 1.11D);
        secondaryMap.Insert(key2, 2.22D);

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key1, 1.11D), result);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key2, 2.22D), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithDouble_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, 1.11D);
        secondaryMap.Insert(key2, 2.22D);
        secondaryMap.Insert(key3, 3.33D);
        secondaryMap.Insert(key4, 4.44D);

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, double>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key2, 2.22D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key3, 3.33D), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithDouble_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, 1.11D);
        secondaryMap.Insert(key2, 2.22D);
        secondaryMap.Insert(key3, 3.33D);
        secondaryMap.Insert(key4, 4.44D);
        secondaryMap.Insert(key5, 5.55D);
        secondaryMap.Insert(key6, 6.66D);

        List<KeyValuePair<SlotKey, double>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, double>(key1, 1.11D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key2, 2.22D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key3, 3.33D), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key4, 4.44D), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key5, 5.55D), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key6, 6.66D), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithDouble_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, 1.11D);
        secondaryMap.Insert(key2, 2.22D);
        secondaryMap.Insert(key3, 3.33D);
        secondaryMap.Insert(key4, 4.44D);
        secondaryMap.Insert(key5, 5.55D);
        secondaryMap.Insert(key6, 6.66D);

        List<KeyValuePair<SlotKey, double>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, double>(key1, 1.11D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key2, 2.22D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key3, 3.33D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key4, 4.44D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key5, 5.55D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key6, 6.66D), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.11D);

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key2, 1.11D), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithDoubleNullable_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.11D);
        secondaryMap.Insert(key3, 2.22D);
        secondaryMap.Insert(key4, 3.33D);

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, double?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key2, 1.11D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key3, 2.22D), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithDoubleNullable_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.11D);
        secondaryMap.Insert(key3, 2.22D);
        secondaryMap.Insert(key4, 3.33D);
        secondaryMap.Insert(key5, 4.44D);
        secondaryMap.Insert(key6, 5.55D);

        List<KeyValuePair<SlotKey, double?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, double?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key2, 1.11D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key3, 2.22D), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key4, 3.33D), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key5, 4.44D), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key6, 5.55D), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithDoubleNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.11D);
        secondaryMap.Insert(key3, 2.22D);
        secondaryMap.Insert(key4, 3.33D);
        secondaryMap.Insert(key5, 4.44D);
        secondaryMap.Insert(key6, 5.55D);

        List<KeyValuePair<SlotKey, double?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, double?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key2, 1.11D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key3, 2.22D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key4, 3.33D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key5, 4.44D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key6, 5.55D), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, true);
        secondaryMap.Insert(key2, false);

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key1, true), result);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key2, false), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithBool_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, true);
        secondaryMap.Insert(key2, false);
        secondaryMap.Insert(key3, true);
        secondaryMap.Insert(key4, false);

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, bool>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key2, false), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key3, true), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithBool_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, true);
        secondaryMap.Insert(key2, false);
        secondaryMap.Insert(key3, true);
        secondaryMap.Insert(key4, false);
        secondaryMap.Insert(key5, true);
        secondaryMap.Insert(key6, false);

        List<KeyValuePair<SlotKey, bool>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, bool>(key1, true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key2, false), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key3, true), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key4, false), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key5, true), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key6, false), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithBool_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, true);
        secondaryMap.Insert(key2, false);
        secondaryMap.Insert(key3, true);
        secondaryMap.Insert(key4, false);
        secondaryMap.Insert(key5, true);
        secondaryMap.Insert(key6, false);

        List<KeyValuePair<SlotKey, bool>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, bool>(key1, true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key2, false), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key3, true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key4, false), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key5, true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key6, false), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, true);

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key2, true), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithBoolNullable_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, true);
        secondaryMap.Insert(key3, false);
        secondaryMap.Insert(key4, null);

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, bool?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key2, true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key3, false), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithBoolNullable_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, true);
        secondaryMap.Insert(key3, false);
        secondaryMap.Insert(key4, null);
        secondaryMap.Insert(key5, true);
        secondaryMap.Insert(key6, false);

        List<KeyValuePair<SlotKey, bool?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key2, true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key3, false), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key4, null), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key5, true), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key6, false), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithBoolNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, true);
        secondaryMap.Insert(key3, false);
        secondaryMap.Insert(key4, null);
        secondaryMap.Insert(key5, true);
        secondaryMap.Insert(key6, false);

        List<KeyValuePair<SlotKey, bool?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key2, true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key3, false), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key4, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key5, true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key6, false), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, 'A');
        secondaryMap.Insert(key2, 'B');

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key1, 'A'), result);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key2, 'B'), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithChar_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, 'A');
        secondaryMap.Insert(key2, 'B');
        secondaryMap.Insert(key3, 'C');
        secondaryMap.Insert(key4, 'D');

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, char>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key2, 'B'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key3, 'C'), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithChar_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, 'A');
        secondaryMap.Insert(key2, 'B');
        secondaryMap.Insert(key3, 'C');
        secondaryMap.Insert(key4, 'D');
        secondaryMap.Insert(key5, 'E');
        secondaryMap.Insert(key6, 'F');

        List<KeyValuePair<SlotKey, char>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, char>(key1, 'A'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key2, 'B'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key3, 'C'), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key4, 'D'), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key5, 'E'), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key6, 'F'), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithChar_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, 'A');
        secondaryMap.Insert(key2, 'B');
        secondaryMap.Insert(key3, 'C');
        secondaryMap.Insert(key4, 'D');
        secondaryMap.Insert(key5, 'E');
        secondaryMap.Insert(key6, 'F');

        List<KeyValuePair<SlotKey, char>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, char>(key1, 'A'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key2, 'B'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key3, 'C'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key4, 'D'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key5, 'E'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key6, 'F'), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 'A');

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key2, 'A'), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithCharNullable_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 'A');
        secondaryMap.Insert(key3, 'B');
        secondaryMap.Insert(key4, 'C');

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, char?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key2, 'A'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key3, 'B'), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithCharNullable_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 'A');
        secondaryMap.Insert(key3, 'B');
        secondaryMap.Insert(key4, 'C');
        secondaryMap.Insert(key5, 'D');
        secondaryMap.Insert(key6, 'E');

        List<KeyValuePair<SlotKey, char?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, char?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key2, 'A'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key3, 'B'), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key4, 'C'), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key5, 'D'), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key6, 'E'), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithCharNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 'A');
        secondaryMap.Insert(key3, 'B');
        secondaryMap.Insert(key4, 'C');
        secondaryMap.Insert(key5, 'D');
        secondaryMap.Insert(key6, 'E');

        List<KeyValuePair<SlotKey, char?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, char?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key2, 'A'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key3, 'B'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key4, 'C'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key5, 'D'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key6, 'E'), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, 1000_000_000_000L);
        secondaryMap.Insert(key2, 2000_000_000_000L);

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key1, 1000_000_000_000L), result);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key2, 2000_000_000_000L), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithLong_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, 1000_000_000_000L);
        secondaryMap.Insert(key2, 2000_000_000_000L);
        secondaryMap.Insert(key3, 3000_000_000_000L);
        secondaryMap.Insert(key4, 4000_000_000_000L);

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, long>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key2, 2000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key3, 3000_000_000_000L), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithLong_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, 1000_000_000_000L);
        secondaryMap.Insert(key2, 2000_000_000_000L);
        secondaryMap.Insert(key3, 3000_000_000_000L);
        secondaryMap.Insert(key4, 4000_000_000_000L);
        secondaryMap.Insert(key5, 5000_000_000_000L);
        secondaryMap.Insert(key6, 6000_000_000_000L);

        List<KeyValuePair<SlotKey, long>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, long>(key1, 1000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key2, 2000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key3, 3000_000_000_000L), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key4, 4000_000_000_000L), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key5, 5000_000_000_000L), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key6, 6000_000_000_000L), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithLong_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, 1000_000_000_000L);
        secondaryMap.Insert(key2, 2000_000_000_000L);
        secondaryMap.Insert(key3, 3000_000_000_000L);
        secondaryMap.Insert(key4, 4000_000_000_000L);
        secondaryMap.Insert(key5, 5000_000_000_000L);
        secondaryMap.Insert(key6, 6000_000_000_000L);

        List<KeyValuePair<SlotKey, long>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, long>(key1, 1000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key2, 2000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key3, 3000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key4, 4000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key5, 5000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key6, 6000_000_000_000L), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1000_000_000_000L);

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key2, 1000_000_000_000L), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithLongNullable_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1000_000_000_000L);
        secondaryMap.Insert(key3, 2000_000_000_000L);
        secondaryMap.Insert(key4, 3000_000_000_000L);

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, long?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key2, 1000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key3, 2000_000_000_000L), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithLongNullable_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1000_000_000_000L);
        secondaryMap.Insert(key3, 2000_000_000_000L);
        secondaryMap.Insert(key4, 3000_000_000_000L);
        secondaryMap.Insert(key5, 4000_000_000_000L);
        secondaryMap.Insert(key6, 5000_000_000_000L);

        List<KeyValuePair<SlotKey, long?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, long?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key2, 1000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key3, 2000_000_000_000L), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key4, 3000_000_000_000L), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key5, 4000_000_000_000L), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key6, 5000_000_000_000L), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithLongNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1000_000_000_000L);
        secondaryMap.Insert(key3, 2000_000_000_000L);
        secondaryMap.Insert(key4, 3000_000_000_000L);
        secondaryMap.Insert(key5, 4000_000_000_000L);
        secondaryMap.Insert(key6, 5000_000_000_000L);

        List<KeyValuePair<SlotKey, long?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, long?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key2, 1000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key3, 2000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key4, 3000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key5, 4000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key6, 5000_000_000_000L), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, 1.1F);
        secondaryMap.Insert(key2, 2.2F);

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key1, 1.1F), result);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key2, 2.2F), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithFloat_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, 1.1F);
        secondaryMap.Insert(key2, 2.2F);
        secondaryMap.Insert(key3, 3.3F);
        secondaryMap.Insert(key4, 4.4F);

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, float>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key2, 2.2F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key3, 3.3F), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithFloat_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, 1.1F);
        secondaryMap.Insert(key2, 2.2F);
        secondaryMap.Insert(key3, 3.3F);
        secondaryMap.Insert(key4, 4.4F);
        secondaryMap.Insert(key5, 5.5F);
        secondaryMap.Insert(key6, 6.6F);

        List<KeyValuePair<SlotKey, float>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, float>(key1, 1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key2, 2.2F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key3, 3.3F), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key4, 4.4F), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key5, 5.5F), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key6, 6.6F), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithFloat_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, 1.1F);
        secondaryMap.Insert(key2, 2.2F);
        secondaryMap.Insert(key3, 3.3F);
        secondaryMap.Insert(key4, 4.4F);
        secondaryMap.Insert(key5, 5.5F);
        secondaryMap.Insert(key6, 6.6F);

        List<KeyValuePair<SlotKey, float>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, float>(key1, 1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key2, 2.2F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key3, 3.3F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key4, 4.4F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key5, 5.5F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key6, 6.6F), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.1F);

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key2, 1.1F), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithFloatNullable_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.1F);
        secondaryMap.Insert(key3, 2.2F);
        secondaryMap.Insert(key4, 3.3F);

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, float?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key2, 1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key3, 2.2F), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithFloatNullable_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.1F);
        secondaryMap.Insert(key3, 2.2F);
        secondaryMap.Insert(key4, 3.3F);
        secondaryMap.Insert(key5, 4.4F);
        secondaryMap.Insert(key6, 5.5F);

        List<KeyValuePair<SlotKey, float?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, float?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key2, 1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key3, 2.2F), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key4, 3.3F), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key5, 4.4F), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key6, 5.5F), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithFloatNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.1F);
        secondaryMap.Insert(key3, 2.2F);
        secondaryMap.Insert(key4, 3.3F);
        secondaryMap.Insert(key5, 4.4F);
        secondaryMap.Insert(key6, 5.5F);

        List<KeyValuePair<SlotKey, float?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, float?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key2, 1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key3, 2.2F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key4, 3.3F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key5, 4.4F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key6, 5.5F), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, 1.111_111_111M);
        secondaryMap.Insert(key2, 2.222_222_222M);

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key1, 1.111_111_111M), result);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key2, 2.222_222_222M), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithDecimal_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, 1.111_111_111M);
        secondaryMap.Insert(key2, 2.222_222_222M);
        secondaryMap.Insert(key3, 3.333_333_333M);
        secondaryMap.Insert(key4, 4.444_444_444M);

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, decimal>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key2, 2.222_222_222M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key3, 3.333_333_333M), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithDecimal_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, 1.111_111_111M);
        secondaryMap.Insert(key2, 2.222_222_222M);
        secondaryMap.Insert(key3, 3.333_333_333M);
        secondaryMap.Insert(key4, 4.444_444_444M);
        secondaryMap.Insert(key5, 5.555_555_555M);
        secondaryMap.Insert(key6, 6.666_666_666M);

        List<KeyValuePair<SlotKey, decimal>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key1, 1.111_111_111M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key2, 2.222_222_222M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key3, 3.333_333_333M), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key4, 4.444_444_444M), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key5, 5.555_555_555M), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key6, 6.666_666_666M), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithDecimal_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, 1.111_111_111M);
        secondaryMap.Insert(key2, 2.222_222_222M);
        secondaryMap.Insert(key3, 3.333_333_333M);
        secondaryMap.Insert(key4, 4.444_444_444M);
        secondaryMap.Insert(key5, 5.555_555_555M);
        secondaryMap.Insert(key6, 6.666_666_666M);

        List<KeyValuePair<SlotKey, decimal>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key1, 1.111_111_111M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key2, 2.222_222_222M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key3, 3.333_333_333M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key4, 4.444_444_444M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key5, 5.555_555_555M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key6, 6.666_666_666M), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.111_111_111M);

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key2, 1.111_111_111M), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithDecimalNullable_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.111_111_111M);
        secondaryMap.Insert(key3, 2.222_222_222M);
        secondaryMap.Insert(key4, 3.333_333_333M);

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, decimal?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key2, 1.111_111_111M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key3, 2.222_222_222M), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithDecimalNullable_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.111_111_111M);
        secondaryMap.Insert(key3, 2.222_222_222M);
        secondaryMap.Insert(key4, 3.333_333_333M);
        secondaryMap.Insert(key5, 4.444_444_444M);
        secondaryMap.Insert(key6, 5.555_555_555M);

        List<KeyValuePair<SlotKey, decimal?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key2, 1.111_111_111M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key3, 2.222_222_222M), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key4, 3.333_333_333M), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key5, 4.444_444_444M), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key6, 5.555_555_555M), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithDecimalNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.111_111_111M);
        secondaryMap.Insert(key3, 2.222_222_222M);
        secondaryMap.Insert(key4, 3.333_333_333M);
        secondaryMap.Insert(key5, 4.444_444_444M);
        secondaryMap.Insert(key6, 5.555_555_555M);

        List<KeyValuePair<SlotKey, decimal?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key2, 1.111_111_111M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key3, 2.222_222_222M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key4, 3.333_333_333M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key5, 4.444_444_444M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key6, 5.555_555_555M), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        secondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key1, DateTime.Parse("2023-01-01")), result);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key2, DateTime.Parse("2023-02-01")), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithDateTime_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        secondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        secondaryMap.Insert(key3, DateTime.Parse("2023-03-01"));
        secondaryMap.Insert(key4, DateTime.Parse("2023-04-01"));

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, DateTime>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key2, DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key3, DateTime.Parse("2023-03-01")), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithDateTime_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        secondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        secondaryMap.Insert(key3, DateTime.Parse("2023-03-01"));
        secondaryMap.Insert(key4, DateTime.Parse("2023-04-01"));
        secondaryMap.Insert(key5, DateTime.Parse("2023-05-01"));
        secondaryMap.Insert(key6, DateTime.Parse("2023-06-01"));

        List<KeyValuePair<SlotKey, DateTime>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key1, DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key2, DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key3, DateTime.Parse("2023-03-01")), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key4, DateTime.Parse("2023-04-01")), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key5, DateTime.Parse("2023-05-01")), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key6, DateTime.Parse("2023-06-01")), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithDateTime_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        secondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        secondaryMap.Insert(key3, DateTime.Parse("2023-03-01"));
        secondaryMap.Insert(key4, DateTime.Parse("2023-04-01"));
        secondaryMap.Insert(key5, DateTime.Parse("2023-05-01"));
        secondaryMap.Insert(key6, DateTime.Parse("2023-06-01"));

        List<KeyValuePair<SlotKey, DateTime>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key1, DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key2, DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key3, DateTime.Parse("2023-03-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key4, DateTime.Parse("2023-04-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key5, DateTime.Parse("2023-05-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key6, DateTime.Parse("2023-06-01")), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key2, DateTime.Parse("2023-01-01")), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithDateTimeNullable_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        secondaryMap.Insert(key3, DateTime.Parse("2023-02-01"));
        secondaryMap.Insert(key4, DateTime.Parse("2023-03-01"));

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, DateTime?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key2, DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key3, DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithDateTimeNullable_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        secondaryMap.Insert(key3, DateTime.Parse("2023-02-01"));
        secondaryMap.Insert(key4, DateTime.Parse("2023-03-01"));
        secondaryMap.Insert(key5, DateTime.Parse("2023-04-01"));
        secondaryMap.Insert(key6, DateTime.Parse("2023-05-01"));

        List<KeyValuePair<SlotKey, DateTime?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key2, DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key3, DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key4, DateTime.Parse("2023-03-01")), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key5, DateTime.Parse("2023-04-01")), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key6, DateTime.Parse("2023-05-01")), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithDateTimeNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        secondaryMap.Insert(key3, DateTime.Parse("2023-02-01"));
        secondaryMap.Insert(key4, DateTime.Parse("2023-03-01"));
        secondaryMap.Insert(key5, DateTime.Parse("2023-04-01"));
        secondaryMap.Insert(key6, DateTime.Parse("2023-05-01"));

        List<KeyValuePair<SlotKey, DateTime?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key2, DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key3, DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key4, DateTime.Parse("2023-03-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key5, DateTime.Parse("2023-04-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key6, DateTime.Parse("2023-05-01")), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));
        secondaryMap.Insert(key2, new TimeSpan(01,00,00));

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key1, new TimeSpan(00,00,00)), result);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key2, new TimeSpan(01,00,00)), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithTimeSpan_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));
        secondaryMap.Insert(key2, new TimeSpan(01,00,00));
        secondaryMap.Insert(key3, new TimeSpan(02,00,00));
        secondaryMap.Insert(key4, new TimeSpan(03,00,00));

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, TimeSpan>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key2, new TimeSpan(01,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key3, new TimeSpan(02,00,00)), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithTimeSpan_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));
        secondaryMap.Insert(key2, new TimeSpan(01,00,00));
        secondaryMap.Insert(key3, new TimeSpan(02,00,00));
        secondaryMap.Insert(key4, new TimeSpan(03,00,00));
        secondaryMap.Insert(key5, new TimeSpan(04,00,00));
        secondaryMap.Insert(key6, new TimeSpan(05,00,00));

        List<KeyValuePair<SlotKey, TimeSpan>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key1, new TimeSpan(00,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key2, new TimeSpan(01,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key3, new TimeSpan(02,00,00)), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key4, new TimeSpan(03,00,00)), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key5, new TimeSpan(04,00,00)), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key6, new TimeSpan(05,00,00)), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithTimeSpan_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));
        secondaryMap.Insert(key2, new TimeSpan(01,00,00));
        secondaryMap.Insert(key3, new TimeSpan(02,00,00));
        secondaryMap.Insert(key4, new TimeSpan(03,00,00));
        secondaryMap.Insert(key5, new TimeSpan(04,00,00));
        secondaryMap.Insert(key6, new TimeSpan(05,00,00));

        List<KeyValuePair<SlotKey, TimeSpan>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key1, new TimeSpan(00,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key2, new TimeSpan(01,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key3, new TimeSpan(02,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key4, new TimeSpan(03,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key5, new TimeSpan(04,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key6, new TimeSpan(05,00,00)), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, new TimeSpan(00,00,00));

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key2, new TimeSpan(00,00,00)), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithTimeSpanNullable_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, new TimeSpan(00,00,00));
        secondaryMap.Insert(key3, new TimeSpan(01,00,00));
        secondaryMap.Insert(key4, new TimeSpan(02,00,00));

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, TimeSpan?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key2, new TimeSpan(00,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key3, new TimeSpan(01,00,00)), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithTimeSpanNullable_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, new TimeSpan(00,00,00));
        secondaryMap.Insert(key3, new TimeSpan(01,00,00));
        secondaryMap.Insert(key4, new TimeSpan(02,00,00));
        secondaryMap.Insert(key5, new TimeSpan(03,00,00));
        secondaryMap.Insert(key6, new TimeSpan(04,00,00));

        List<KeyValuePair<SlotKey, TimeSpan?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key2, new TimeSpan(00,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key3, new TimeSpan(01,00,00)), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key4, new TimeSpan(02,00,00)), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key5, new TimeSpan(03,00,00)), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key6, new TimeSpan(04,00,00)), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithTimeSpanNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, new TimeSpan(00,00,00));
        secondaryMap.Insert(key3, new TimeSpan(01,00,00));
        secondaryMap.Insert(key4, new TimeSpan(02,00,00));
        secondaryMap.Insert(key5, new TimeSpan(03,00,00));
        secondaryMap.Insert(key6, new TimeSpan(04,00,00));

        List<KeyValuePair<SlotKey, TimeSpan?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key2, new TimeSpan(00,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key3, new TimeSpan(01,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key4, new TimeSpan(02,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key5, new TimeSpan(03,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key6, new TimeSpan(04,00,00)), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        secondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), result);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithGuid_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        secondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        secondaryMap.Insert(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        secondaryMap.Insert(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, Guid>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithGuid_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        secondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        secondaryMap.Insert(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        secondaryMap.Insert(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        secondaryMap.Insert(key5, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));
        secondaryMap.Insert(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

        List<KeyValuePair<SlotKey, Guid>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731")), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key5, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45")), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46")), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithGuid_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        secondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        secondaryMap.Insert(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        secondaryMap.Insert(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        secondaryMap.Insert(key5, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));
        secondaryMap.Insert(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

        List<KeyValuePair<SlotKey, Guid>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key5, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46")), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var result = secondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), result);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void RemovedKeysWithGuidNullable_NotReturnRemovedKeys()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        secondaryMap.Insert(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        secondaryMap.Insert(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        secondaryMap.Remove(key1);
        secondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, Guid?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithGuidNullable_ReturnsItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        secondaryMap.Insert(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        secondaryMap.Insert(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        secondaryMap.Insert(key5, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        secondaryMap.Insert(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        List<KeyValuePair<SlotKey, Guid?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key5, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731")), secondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45")), secondaryMap);
        Assert.Equal(3, secondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithGuidNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        secondaryMap.Insert(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        secondaryMap.Insert(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        secondaryMap.Insert(key5, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        secondaryMap.Insert(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        List<KeyValuePair<SlotKey, Guid?>> drainedItems = new(3);

        foreach (var kvp in secondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key5, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45")), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(secondaryMap);
    }

}