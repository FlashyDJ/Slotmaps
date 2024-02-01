//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;

public class Drain
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyIntMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<int>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledIntMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = slotMap.Insert(20);

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key1, 10), result);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 20), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void IntWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = slotMap.Insert(20);
        var key3 = slotMap.Insert(30);
        var key4 = slotMap.Insert(40);

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key2, 20), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key3, 30), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void IntDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = slotMap.Insert(20);
        var key3 = slotMap.Insert(30);
        var key4 = slotMap.Insert(40);
        var key5 = slotMap.Insert(50);
        var key6 = slotMap.Insert(60);

        List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, int>(key1,10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key2,20), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key3,30), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key4, 40), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key5, 50), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key6, 60), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void IntDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = slotMap.Insert(20);
        var key3 = slotMap.Insert(30);
        var key4 = slotMap.Insert(40);
        var key5 = slotMap.Insert(50);
        var key6 = slotMap.Insert(60);

        List<KeyValuePair<SlotKey, int>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, int>(key1,10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key2,20), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key3,30), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key4,40), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key5,50), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int>(key6,60), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyIntNullableMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<int?>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledIntNullableMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(10);

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key2, 10), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void IntNullableWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(10);
        var key3 = slotMap.Insert(20);
        var key4 = slotMap.Insert(30);

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, int?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key2, 10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key3, 20), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void IntNullableDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(10);
        var key3 = slotMap.Insert(20);
        var key4 = slotMap.Insert(30);
        var key5 = slotMap.Insert(40);
        var key6 = slotMap.Insert(50);

        List<KeyValuePair<SlotKey, int?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, int?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key2,10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key3,20), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key4, 30), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key5, 40), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key6, 50), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void IntNullableDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(10);
        var key3 = slotMap.Insert(20);
        var key4 = slotMap.Insert(30);
        var key5 = slotMap.Insert(40);
        var key6 = slotMap.Insert(50);

        List<KeyValuePair<SlotKey, int?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, int?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key2,10), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key3,20), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key4,30), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key5,40), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, int?>(key6,50), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyStringMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<string>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledStringMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = slotMap.Insert("Value 2");

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key1, "Value 1"), result);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key2, "Value 2"), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void StringWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = slotMap.Insert("Value 2");
        var key3 = slotMap.Insert("Value 3");
        var key4 = slotMap.Insert("Value 4");

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, string>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key2, "Value 2"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key3, "Value 3"), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void StringDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = slotMap.Insert("Value 2");
        var key3 = slotMap.Insert("Value 3");
        var key4 = slotMap.Insert("Value 4");
        var key5 = slotMap.Insert("Value 5");
        var key6 = slotMap.Insert("Value 6");

        List<KeyValuePair<SlotKey, string>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, string>(key1,"Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key2,"Value 2"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key3,"Value 3"), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key4, "Value 4"), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key5, "Value 5"), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key6, "Value 6"), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void StringDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = slotMap.Insert("Value 2");
        var key3 = slotMap.Insert("Value 3");
        var key4 = slotMap.Insert("Value 4");
        var key5 = slotMap.Insert("Value 5");
        var key6 = slotMap.Insert("Value 6");

        List<KeyValuePair<SlotKey, string>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, string>(key1,"Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key2,"Value 2"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key3,"Value 3"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key4,"Value 4"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key5,"Value 5"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string>(key6,"Value 6"), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyStringNullableMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<string?>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledStringNullableMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert("Value 1");

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key2, "Value 1"), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void StringNullableWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert("Value 1");
        var key3 = slotMap.Insert("Value 2");
        var key4 = slotMap.Insert("Value 3");

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, string?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key2, "Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key3, "Value 2"), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void StringNullableDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert("Value 1");
        var key3 = slotMap.Insert("Value 2");
        var key4 = slotMap.Insert("Value 3");
        var key5 = slotMap.Insert("Value 4");
        var key6 = slotMap.Insert("Value 5");

        List<KeyValuePair<SlotKey, string?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, string?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key2,"Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key3,"Value 2"), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key4, "Value 3"), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key5, "Value 4"), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key6, "Value 5"), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void StringNullableDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert("Value 1");
        var key3 = slotMap.Insert("Value 2");
        var key4 = slotMap.Insert("Value 3");
        var key5 = slotMap.Insert("Value 4");
        var key6 = slotMap.Insert("Value 5");

        List<KeyValuePair<SlotKey, string?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, string?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key2,"Value 1"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key3,"Value 2"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key4,"Value 3"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key5,"Value 4"), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, string?>(key6,"Value 5"), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyFloatMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<float>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledFloatMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = slotMap.Insert(2.2F);

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key1, 1.1F), result);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key2, 2.2F), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FloatWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = slotMap.Insert(2.2F);
        var key3 = slotMap.Insert(3.3F);
        var key4 = slotMap.Insert(4.4F);

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, float>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key2, 2.2F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key3, 3.3F), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FloatDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = slotMap.Insert(2.2F);
        var key3 = slotMap.Insert(3.3F);
        var key4 = slotMap.Insert(4.4F);
        var key5 = slotMap.Insert(5.5F);
        var key6 = slotMap.Insert(6.6F);

        List<KeyValuePair<SlotKey, float>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, float>(key1,1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key2,2.2F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key3,3.3F), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key4, 4.4F), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key5, 5.5F), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key6, 6.6F), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void FloatDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = slotMap.Insert(2.2F);
        var key3 = slotMap.Insert(3.3F);
        var key4 = slotMap.Insert(4.4F);
        var key5 = slotMap.Insert(5.5F);
        var key6 = slotMap.Insert(6.6F);

        List<KeyValuePair<SlotKey, float>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, float>(key1,1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key2,2.2F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key3,3.3F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key4,4.4F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key5,5.5F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float>(key6,6.6F), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyFloatNullableMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<float?>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledFloatNullableMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.1F);

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key2, 1.1F), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FloatNullableWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.1F);
        var key3 = slotMap.Insert(2.2F);
        var key4 = slotMap.Insert(3.3F);

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, float?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key2, 1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key3, 2.2F), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FloatNullableDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.1F);
        var key3 = slotMap.Insert(2.2F);
        var key4 = slotMap.Insert(3.3F);
        var key5 = slotMap.Insert(4.4F);
        var key6 = slotMap.Insert(5.5F);

        List<KeyValuePair<SlotKey, float?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, float?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key2,1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key3,2.2F), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key4, 3.3F), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key5, 4.4F), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key6, 5.5F), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void FloatNullableDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.1F);
        var key3 = slotMap.Insert(2.2F);
        var key4 = slotMap.Insert(3.3F);
        var key5 = slotMap.Insert(4.4F);
        var key6 = slotMap.Insert(5.5F);

        List<KeyValuePair<SlotKey, float?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, float?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key2,1.1F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key3,2.2F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key4,3.3F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key5,4.4F), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, float?>(key6,5.5F), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyDateTimeMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<DateTime>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledDateTimeMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Insert(DateTime.Parse("2023-02-01"));

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key1, DateTime.Parse("2023-01-01")), result);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key2, DateTime.Parse("2023-02-01")), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DateTimeWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Insert(DateTime.Parse("2023-02-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-03-01"));
        var key4 = slotMap.Insert(DateTime.Parse("2023-04-01"));

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, DateTime>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key2, DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key3, DateTime.Parse("2023-03-01")), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DateTimeDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Insert(DateTime.Parse("2023-02-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-03-01"));
        var key4 = slotMap.Insert(DateTime.Parse("2023-04-01"));
        var key5 = slotMap.Insert(DateTime.Parse("2023-05-01"));
        var key6 = slotMap.Insert(DateTime.Parse("2023-06-01"));

        List<KeyValuePair<SlotKey, DateTime>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key1,DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key2,DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key3,DateTime.Parse("2023-03-01")), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key4, DateTime.Parse("2023-04-01")), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key5, DateTime.Parse("2023-05-01")), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key6, DateTime.Parse("2023-06-01")), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void DateTimeDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Insert(DateTime.Parse("2023-02-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-03-01"));
        var key4 = slotMap.Insert(DateTime.Parse("2023-04-01"));
        var key5 = slotMap.Insert(DateTime.Parse("2023-05-01"));
        var key6 = slotMap.Insert(DateTime.Parse("2023-06-01"));

        List<KeyValuePair<SlotKey, DateTime>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key1,DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key2,DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key3,DateTime.Parse("2023-03-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key4,DateTime.Parse("2023-04-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key5,DateTime.Parse("2023-05-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime>(key6,DateTime.Parse("2023-06-01")), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyDateTimeNullableMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<DateTime?>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledDateTimeNullableMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(DateTime.Parse("2023-01-01"));

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key2, DateTime.Parse("2023-01-01")), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DateTimeNullableWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-02-01"));
        var key4 = slotMap.Insert(DateTime.Parse("2023-03-01"));

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, DateTime?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key2, DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key3, DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DateTimeNullableDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-02-01"));
        var key4 = slotMap.Insert(DateTime.Parse("2023-03-01"));
        var key5 = slotMap.Insert(DateTime.Parse("2023-04-01"));
        var key6 = slotMap.Insert(DateTime.Parse("2023-05-01"));

        List<KeyValuePair<SlotKey, DateTime?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key2,DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key3,DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key4, DateTime.Parse("2023-03-01")), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key5, DateTime.Parse("2023-04-01")), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key6, DateTime.Parse("2023-05-01")), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void DateTimeNullableDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-02-01"));
        var key4 = slotMap.Insert(DateTime.Parse("2023-03-01"));
        var key5 = slotMap.Insert(DateTime.Parse("2023-04-01"));
        var key6 = slotMap.Insert(DateTime.Parse("2023-05-01"));

        List<KeyValuePair<SlotKey, DateTime?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key2,DateTime.Parse("2023-01-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key3,DateTime.Parse("2023-02-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key4,DateTime.Parse("2023-03-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key5,DateTime.Parse("2023-04-01")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, DateTime?>(key6,DateTime.Parse("2023-05-01")), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyGuidMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<Guid>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledGuidMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), result);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void GuidWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key3 = slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key4 = slotMap.Insert(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, Guid>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void GuidDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key3 = slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key4 = slotMap.Insert(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        var key5 = slotMap.Insert(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));
        var key6 = slotMap.Insert(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

        List<KeyValuePair<SlotKey, Guid>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key1,Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key2,Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key3,Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731")), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key5, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45")), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46")), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void GuidDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key3 = slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key4 = slotMap.Insert(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        var key5 = slotMap.Insert(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));
        var key6 = slotMap.Insert(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

        List<KeyValuePair<SlotKey, Guid>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key1,Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key2,Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key3,Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key4,Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key5,Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid>(key6,Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46")), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyGuidNullableMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<Guid?>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledGuidNullableMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void GuidNullableWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key3 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key4 = slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, Guid?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void GuidNullableDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key3 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key4 = slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key5 = slotMap.Insert(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        var key6 = slotMap.Insert(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        List<KeyValuePair<SlotKey, Guid?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key2,Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key3,Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key5, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731")), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key6, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45")), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void GuidNullableDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key3 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key4 = slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key5 = slotMap.Insert(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        var key6 = slotMap.Insert(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        List<KeyValuePair<SlotKey, Guid?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key2,Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key3,Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key4,Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key5,Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731")), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, Guid?>(key6,Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45")), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

}