//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SparseSecondaryMap;

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
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, 10);
        sparseSecondaryMap.Insert(key2, 20);

        var result = sparseSecondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key1, 10), result);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 20), result);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void RemovedKeysWithInt_NotReturnRemovedKeys()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        sparseSecondaryMap.Insert(key1, 10);
        sparseSecondaryMap.Insert(key2, 20);
        sparseSecondaryMap.Insert(key3, 30);
        sparseSecondaryMap.Insert(key4, 40);

        sparseSecondaryMap.Remove(key1);
        sparseSecondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 20), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key3, 30), drainedItems);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithInt_ReturnsItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, 10);
        sparseSecondaryMap.Insert(key2, 20);
        sparseSecondaryMap.Insert(key3, 30);
        sparseSecondaryMap.Insert(key4, 40);
        sparseSecondaryMap.Insert(key5, 50);
        sparseSecondaryMap.Insert(key6, 60);

        List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, int>(key1, 10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 20), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key3, 30), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key4, 40), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key5, 50), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key6, 60), sparseSecondaryMap);
        Assert.Equal(3, sparseSecondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithInt_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, 10);
        sparseSecondaryMap.Insert(key2, 20);
        sparseSecondaryMap.Insert(key3, 30);
        sparseSecondaryMap.Insert(key4, 40);
        sparseSecondaryMap.Insert(key5, 50);
        sparseSecondaryMap.Insert(key6, 60);

        List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
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
        Assert.Empty(sparseSecondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 10);

        var result = sparseSecondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key2, 10), result);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void RemovedKeysWithIntNullable_NotReturnRemovedKeys()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 10);
        sparseSecondaryMap.Insert(key3, 20);
        sparseSecondaryMap.Insert(key4, 30);

        sparseSecondaryMap.Remove(key1);
        sparseSecondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, int?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key2, 10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key3, 20), drainedItems);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithIntNullable_ReturnsItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 10);
        sparseSecondaryMap.Insert(key3, 20);
        sparseSecondaryMap.Insert(key4, 30);
        sparseSecondaryMap.Insert(key5, 40);
        sparseSecondaryMap.Insert(key6, 50);

        List<KeyValuePair<SlotKey, int?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, int?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key2, 10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key3, 20), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key4, 30), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key5, 40), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key6, 50), sparseSecondaryMap);
        Assert.Equal(3, sparseSecondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithIntNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 10);
        sparseSecondaryMap.Insert(key3, 20);
        sparseSecondaryMap.Insert(key4, 30);
        sparseSecondaryMap.Insert(key5, 40);
        sparseSecondaryMap.Insert(key6, 50);

        List<KeyValuePair<SlotKey, int?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
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
        Assert.Empty(sparseSecondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, "Value 1");
        sparseSecondaryMap.Insert(key2, "Value 2");

        var result = sparseSecondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key1, "Value 1"), result);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key2, "Value 2"), result);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void RemovedKeysWithString_NotReturnRemovedKeys()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        sparseSecondaryMap.Insert(key1, "Value 1");
        sparseSecondaryMap.Insert(key2, "Value 2");
        sparseSecondaryMap.Insert(key3, "Value 3");
        sparseSecondaryMap.Insert(key4, "Value 4");

        sparseSecondaryMap.Remove(key1);
        sparseSecondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, string>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key2, "Value 2"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key3, "Value 3"), drainedItems);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithString_ReturnsItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, "Value 1");
        sparseSecondaryMap.Insert(key2, "Value 2");
        sparseSecondaryMap.Insert(key3, "Value 3");
        sparseSecondaryMap.Insert(key4, "Value 4");
        sparseSecondaryMap.Insert(key5, "Value 5");
        sparseSecondaryMap.Insert(key6, "Value 6");

        List<KeyValuePair<SlotKey, string>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, string>(key1, "Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key2, "Value 2"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key3, "Value 3"), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key4, "Value 4"), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key5, "Value 5"), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key6, "Value 6"), sparseSecondaryMap);
        Assert.Equal(3, sparseSecondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithString_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, "Value 1");
        sparseSecondaryMap.Insert(key2, "Value 2");
        sparseSecondaryMap.Insert(key3, "Value 3");
        sparseSecondaryMap.Insert(key4, "Value 4");
        sparseSecondaryMap.Insert(key5, "Value 5");
        sparseSecondaryMap.Insert(key6, "Value 6");

        List<KeyValuePair<SlotKey, string>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
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
        Assert.Empty(sparseSecondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, "Value 1");

        var result = sparseSecondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key2, "Value 1"), result);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void RemovedKeysWithStringNullable_NotReturnRemovedKeys()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, "Value 1");
        sparseSecondaryMap.Insert(key3, "Value 2");
        sparseSecondaryMap.Insert(key4, "Value 3");

        sparseSecondaryMap.Remove(key1);
        sparseSecondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, string?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key2, "Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key3, "Value 2"), drainedItems);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithStringNullable_ReturnsItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, "Value 1");
        sparseSecondaryMap.Insert(key3, "Value 2");
        sparseSecondaryMap.Insert(key4, "Value 3");
        sparseSecondaryMap.Insert(key5, "Value 4");
        sparseSecondaryMap.Insert(key6, "Value 5");

        List<KeyValuePair<SlotKey, string?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, string?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key2, "Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key3, "Value 2"), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key4, "Value 3"), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key5, "Value 4"), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key6, "Value 5"), sparseSecondaryMap);
        Assert.Equal(3, sparseSecondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithStringNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, "Value 1");
        sparseSecondaryMap.Insert(key3, "Value 2");
        sparseSecondaryMap.Insert(key4, "Value 3");
        sparseSecondaryMap.Insert(key5, "Value 4");
        sparseSecondaryMap.Insert(key6, "Value 5");

        List<KeyValuePair<SlotKey, string?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
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
        Assert.Empty(sparseSecondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, 1.1F);
        sparseSecondaryMap.Insert(key2, 2.2F);

        var result = sparseSecondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key1, 1.1F), result);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key2, 2.2F), result);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void RemovedKeysWithFloat_NotReturnRemovedKeys()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        sparseSecondaryMap.Insert(key1, 1.1F);
        sparseSecondaryMap.Insert(key2, 2.2F);
        sparseSecondaryMap.Insert(key3, 3.3F);
        sparseSecondaryMap.Insert(key4, 4.4F);

        sparseSecondaryMap.Remove(key1);
        sparseSecondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, float>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key2, 2.2F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key3, 3.3F), drainedItems);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithFloat_ReturnsItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, 1.1F);
        sparseSecondaryMap.Insert(key2, 2.2F);
        sparseSecondaryMap.Insert(key3, 3.3F);
        sparseSecondaryMap.Insert(key4, 4.4F);
        sparseSecondaryMap.Insert(key5, 5.5F);
        sparseSecondaryMap.Insert(key6, 6.6F);

        List<KeyValuePair<SlotKey, float>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, float>(key1, 1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key2, 2.2F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key3, 3.3F), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key4, 4.4F), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key5, 5.5F), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key6, 6.6F), sparseSecondaryMap);
        Assert.Equal(3, sparseSecondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithFloat_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, 1.1F);
        sparseSecondaryMap.Insert(key2, 2.2F);
        sparseSecondaryMap.Insert(key3, 3.3F);
        sparseSecondaryMap.Insert(key4, 4.4F);
        sparseSecondaryMap.Insert(key5, 5.5F);
        sparseSecondaryMap.Insert(key6, 6.6F);

        List<KeyValuePair<SlotKey, float>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
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
        Assert.Empty(sparseSecondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.1F);

        var result = sparseSecondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key2, 1.1F), result);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void RemovedKeysWithFloatNullable_NotReturnRemovedKeys()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.1F);
        sparseSecondaryMap.Insert(key3, 2.2F);
        sparseSecondaryMap.Insert(key4, 3.3F);

        sparseSecondaryMap.Remove(key1);
        sparseSecondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, float?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key2, 1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key3, 2.2F), drainedItems);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithFloatNullable_ReturnsItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.1F);
        sparseSecondaryMap.Insert(key3, 2.2F);
        sparseSecondaryMap.Insert(key4, 3.3F);
        sparseSecondaryMap.Insert(key5, 4.4F);
        sparseSecondaryMap.Insert(key6, 5.5F);

        List<KeyValuePair<SlotKey, float?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, float?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key2, 1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key3, 2.2F), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key4, 3.3F), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key5, 4.4F), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key6, 5.5F), sparseSecondaryMap);
        Assert.Equal(3, sparseSecondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithFloatNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.1F);
        sparseSecondaryMap.Insert(key3, 2.2F);
        sparseSecondaryMap.Insert(key4, 3.3F);
        sparseSecondaryMap.Insert(key5, 4.4F);
        sparseSecondaryMap.Insert(key6, 5.5F);

        List<KeyValuePair<SlotKey, float?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
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
        Assert.Empty(sparseSecondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));

        var result = sparseSecondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key1, DateTime.Parse("2023-01-01")), result);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key2, DateTime.Parse("2023-02-01")), result);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void RemovedKeysWithDateTime_NotReturnRemovedKeys()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-03-01"));
        sparseSecondaryMap.Insert(key4, DateTime.Parse("2023-04-01"));

        sparseSecondaryMap.Remove(key1);
        sparseSecondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, DateTime>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key2, DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key3, DateTime.Parse("2023-03-01")), drainedItems);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithDateTime_ReturnsItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-03-01"));
        sparseSecondaryMap.Insert(key4, DateTime.Parse("2023-04-01"));
        sparseSecondaryMap.Insert(key5, DateTime.Parse("2023-05-01"));
        sparseSecondaryMap.Insert(key6, DateTime.Parse("2023-06-01"));

        List<KeyValuePair<SlotKey, DateTime>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key1, DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key2, DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key3, DateTime.Parse("2023-03-01")), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key4, DateTime.Parse("2023-04-01")), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key5, DateTime.Parse("2023-05-01")), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key6, DateTime.Parse("2023-06-01")), sparseSecondaryMap);
        Assert.Equal(3, sparseSecondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithDateTime_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-03-01"));
        sparseSecondaryMap.Insert(key4, DateTime.Parse("2023-04-01"));
        sparseSecondaryMap.Insert(key5, DateTime.Parse("2023-05-01"));
        sparseSecondaryMap.Insert(key6, DateTime.Parse("2023-06-01"));

        List<KeyValuePair<SlotKey, DateTime>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
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
        Assert.Empty(sparseSecondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));

        var result = sparseSecondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key2, DateTime.Parse("2023-01-01")), result);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void RemovedKeysWithDateTimeNullable_NotReturnRemovedKeys()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-02-01"));
        sparseSecondaryMap.Insert(key4, DateTime.Parse("2023-03-01"));

        sparseSecondaryMap.Remove(key1);
        sparseSecondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, DateTime?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key2, DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key3, DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithDateTimeNullable_ReturnsItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-02-01"));
        sparseSecondaryMap.Insert(key4, DateTime.Parse("2023-03-01"));
        sparseSecondaryMap.Insert(key5, DateTime.Parse("2023-04-01"));
        sparseSecondaryMap.Insert(key6, DateTime.Parse("2023-05-01"));

        List<KeyValuePair<SlotKey, DateTime?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key2, DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key3, DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key4, DateTime.Parse("2023-03-01")), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key5, DateTime.Parse("2023-04-01")), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key6, DateTime.Parse("2023-05-01")), sparseSecondaryMap);
        Assert.Equal(3, sparseSecondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithDateTimeNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-02-01"));
        sparseSecondaryMap.Insert(key4, DateTime.Parse("2023-03-01"));
        sparseSecondaryMap.Insert(key5, DateTime.Parse("2023-04-01"));
        sparseSecondaryMap.Insert(key6, DateTime.Parse("2023-05-01"));

        List<KeyValuePair<SlotKey, DateTime?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
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
        Assert.Empty(sparseSecondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        var result = sparseSecondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), result);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), result);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void RemovedKeysWithGuid_NotReturnRemovedKeys()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        sparseSecondaryMap.Insert(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));

        sparseSecondaryMap.Remove(key1);
        sparseSecondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, Guid>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), drainedItems);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithGuid_ReturnsItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        sparseSecondaryMap.Insert(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        sparseSecondaryMap.Insert(key5, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));
        sparseSecondaryMap.Insert(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

        List<KeyValuePair<SlotKey, Guid>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731")), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key5, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45")), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46")), sparseSecondaryMap);
        Assert.Equal(3, sparseSecondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithGuid_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        sparseSecondaryMap.Insert(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        sparseSecondaryMap.Insert(key5, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));
        sparseSecondaryMap.Insert(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

        List<KeyValuePair<SlotKey, Guid>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
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
        Assert.Empty(sparseSecondaryMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableFilledMap_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var result = sparseSecondaryMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), result);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void RemovedKeysWithGuidNullable_NotReturnRemovedKeys()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        sparseSecondaryMap.Insert(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        sparseSecondaryMap.Remove(key1);
        sparseSecondaryMap.Remove(key4);

        List<KeyValuePair<SlotKey, Guid?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DrainingUpToMiddleWithGuidNullable_ReturnsItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        sparseSecondaryMap.Insert(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        sparseSecondaryMap.Insert(key5, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        sparseSecondaryMap.Insert(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        List<KeyValuePair<SlotKey, Guid?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key1, null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key5, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731")), sparseSecondaryMap);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45")), sparseSecondaryMap);
        Assert.Equal(3, sparseSecondaryMap.Count);
    }

    [Fact]
    public void DrainingEverythingWithGuidNullable_ReturnsAllItemsAndEmptiesMap()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        var key6 = new SlotKey(6, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        sparseSecondaryMap.Insert(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        sparseSecondaryMap.Insert(key5, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        sparseSecondaryMap.Insert(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        List<KeyValuePair<SlotKey, Guid?>> drainedItems = new(3);

        foreach (var kvp in sparseSecondaryMap.Drain())
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
        Assert.Empty(sparseSecondaryMap);
    }

}