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
        var key1 = slotMap.Add(10);
        var key2 = slotMap.Add(20);

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
        var key1 = slotMap.Add(10);
        var key2 = slotMap.Add(20);
        var key3 = slotMap.Add(30);
        var key4 = slotMap.Add(40);

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
        var key1 = slotMap.Add(10);
        var key2 = slotMap.Add(20);
        var key3 = slotMap.Add(30);
        var key4 = slotMap.Add(40);
        var key5 = slotMap.Add(50);
        var key6 = slotMap.Add(60);

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
        var key1 = slotMap.Add(10);
        var key2 = slotMap.Add(20);
        var key3 = slotMap.Add(30);
        var key4 = slotMap.Add(40);
        var key5 = slotMap.Add(50);
        var key6 = slotMap.Add(60);

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(10);

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(10);
        var key3 = slotMap.Add(20);
        var key4 = slotMap.Add(30);

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(10);
        var key3 = slotMap.Add(20);
        var key4 = slotMap.Add(30);
        var key5 = slotMap.Add(40);
        var key6 = slotMap.Add(50);

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(10);
        var key3 = slotMap.Add(20);
        var key4 = slotMap.Add(30);
        var key5 = slotMap.Add(40);
        var key6 = slotMap.Add(50);

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
        var key1 = slotMap.Add("Value 1");
        var key2 = slotMap.Add("Value 2");

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
        var key1 = slotMap.Add("Value 1");
        var key2 = slotMap.Add("Value 2");
        var key3 = slotMap.Add("Value 3");
        var key4 = slotMap.Add("Value 4");

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
        var key1 = slotMap.Add("Value 1");
        var key2 = slotMap.Add("Value 2");
        var key3 = slotMap.Add("Value 3");
        var key4 = slotMap.Add("Value 4");
        var key5 = slotMap.Add("Value 5");
        var key6 = slotMap.Add("Value 6");

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
        var key1 = slotMap.Add("Value 1");
        var key2 = slotMap.Add("Value 2");
        var key3 = slotMap.Add("Value 3");
        var key4 = slotMap.Add("Value 4");
        var key5 = slotMap.Add("Value 5");
        var key6 = slotMap.Add("Value 6");

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add("Value 1");

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add("Value 1");
        var key3 = slotMap.Add("Value 2");
        var key4 = slotMap.Add("Value 3");

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add("Value 1");
        var key3 = slotMap.Add("Value 2");
        var key4 = slotMap.Add("Value 3");
        var key5 = slotMap.Add("Value 4");
        var key6 = slotMap.Add("Value 5");

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add("Value 1");
        var key3 = slotMap.Add("Value 2");
        var key4 = slotMap.Add("Value 3");
        var key5 = slotMap.Add("Value 4");
        var key6 = slotMap.Add("Value 5");

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
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyDoubleMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<double>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledDoubleMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Add(1.11D);
        var key2 = slotMap.Add(2.22D);

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key1, 1.11D), result);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key2, 2.22D), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DoubleWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Add(1.11D);
        var key2 = slotMap.Add(2.22D);
        var key3 = slotMap.Add(3.33D);
        var key4 = slotMap.Add(4.44D);

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, double>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key2, 2.22D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key3, 3.33D), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DoubleDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Add(1.11D);
        var key2 = slotMap.Add(2.22D);
        var key3 = slotMap.Add(3.33D);
        var key4 = slotMap.Add(4.44D);
        var key5 = slotMap.Add(5.55D);
        var key6 = slotMap.Add(6.66D);

        List<KeyValuePair<SlotKey, double>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, double>(key1,1.11D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key2,2.22D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key3,3.33D), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key4, 4.44D), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key5, 5.55D), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key6, 6.66D), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void DoubleDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Add(1.11D);
        var key2 = slotMap.Add(2.22D);
        var key3 = slotMap.Add(3.33D);
        var key4 = slotMap.Add(4.44D);
        var key5 = slotMap.Add(5.55D);
        var key6 = slotMap.Add(6.66D);

        List<KeyValuePair<SlotKey, double>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, double>(key1,1.11D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key2,2.22D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key3,3.33D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key4,4.44D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key5,5.55D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double>(key6,6.66D), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyDoubleNullableMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<double?>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledDoubleNullableMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.11D);

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key2, 1.11D), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DoubleNullableWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.11D);
        var key3 = slotMap.Add(2.22D);
        var key4 = slotMap.Add(3.33D);

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, double?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key2, 1.11D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key3, 2.22D), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DoubleNullableDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.11D);
        var key3 = slotMap.Add(2.22D);
        var key4 = slotMap.Add(3.33D);
        var key5 = slotMap.Add(4.44D);
        var key6 = slotMap.Add(5.55D);

        List<KeyValuePair<SlotKey, double?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, double?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key2,1.11D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key3,2.22D), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key4, 3.33D), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key5, 4.44D), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key6, 5.55D), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void DoubleNullableDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.11D);
        var key3 = slotMap.Add(2.22D);
        var key4 = slotMap.Add(3.33D);
        var key5 = slotMap.Add(4.44D);
        var key6 = slotMap.Add(5.55D);

        List<KeyValuePair<SlotKey, double?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, double?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key2,1.11D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key3,2.22D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key4,3.33D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key5,4.44D), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, double?>(key6,5.55D), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyBoolMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<bool>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledBoolMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Add(true);
        var key2 = slotMap.Add(false);

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key1, true), result);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key2, false), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void BoolWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Add(true);
        var key2 = slotMap.Add(false);
        var key3 = slotMap.Add(true);
        var key4 = slotMap.Add(false);

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, bool>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key2, false), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key3, true), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void BoolDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Add(true);
        var key2 = slotMap.Add(false);
        var key3 = slotMap.Add(true);
        var key4 = slotMap.Add(false);
        var key5 = slotMap.Add(true);
        var key6 = slotMap.Add(false);

        List<KeyValuePair<SlotKey, bool>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, bool>(key1,true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key2,false), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key3,true), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key4, false), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key5, true), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key6, false), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void BoolDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Add(true);
        var key2 = slotMap.Add(false);
        var key3 = slotMap.Add(true);
        var key4 = slotMap.Add(false);
        var key5 = slotMap.Add(true);
        var key6 = slotMap.Add(false);

        List<KeyValuePair<SlotKey, bool>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, bool>(key1,true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key2,false), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key3,true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key4,false), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key5,true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool>(key6,false), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyBoolNullableMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<bool?>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledBoolNullableMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(true);

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key2, true), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void BoolNullableWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(true);
        var key3 = slotMap.Add(false);
        var key4 = slotMap.Add(null);

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, bool?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key2, true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key3, false), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void BoolNullableDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(true);
        var key3 = slotMap.Add(false);
        var key4 = slotMap.Add(null);
        var key5 = slotMap.Add(true);
        var key6 = slotMap.Add(false);

        List<KeyValuePair<SlotKey, bool?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key2,true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key3,false), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key4, null), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key5, true), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key6, false), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void BoolNullableDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(true);
        var key3 = slotMap.Add(false);
        var key4 = slotMap.Add(null);
        var key5 = slotMap.Add(true);
        var key6 = slotMap.Add(false);

        List<KeyValuePair<SlotKey, bool?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key2,true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key3,false), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key4,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key5,true), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, bool?>(key6,false), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyCharMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<char>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledCharMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Add('A');
        var key2 = slotMap.Add('B');

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key1, 'A'), result);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key2, 'B'), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void CharWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Add('A');
        var key2 = slotMap.Add('B');
        var key3 = slotMap.Add('C');
        var key4 = slotMap.Add('D');

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, char>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key2, 'B'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key3, 'C'), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void CharDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Add('A');
        var key2 = slotMap.Add('B');
        var key3 = slotMap.Add('C');
        var key4 = slotMap.Add('D');
        var key5 = slotMap.Add('E');
        var key6 = slotMap.Add('F');

        List<KeyValuePair<SlotKey, char>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, char>(key1,'A'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key2,'B'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key3,'C'), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key4, 'D'), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key5, 'E'), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key6, 'F'), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void CharDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Add('A');
        var key2 = slotMap.Add('B');
        var key3 = slotMap.Add('C');
        var key4 = slotMap.Add('D');
        var key5 = slotMap.Add('E');
        var key6 = slotMap.Add('F');

        List<KeyValuePair<SlotKey, char>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, char>(key1,'A'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key2,'B'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key3,'C'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key4,'D'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key5,'E'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char>(key6,'F'), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyCharNullableMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<char?>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledCharNullableMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add('A');

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key2, 'A'), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void CharNullableWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add('A');
        var key3 = slotMap.Add('B');
        var key4 = slotMap.Add('C');

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, char?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key2, 'A'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key3, 'B'), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void CharNullableDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add('A');
        var key3 = slotMap.Add('B');
        var key4 = slotMap.Add('C');
        var key5 = slotMap.Add('D');
        var key6 = slotMap.Add('E');

        List<KeyValuePair<SlotKey, char?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, char?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key2,'A'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key3,'B'), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key4, 'C'), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key5, 'D'), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key6, 'E'), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void CharNullableDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add('A');
        var key3 = slotMap.Add('B');
        var key4 = slotMap.Add('C');
        var key5 = slotMap.Add('D');
        var key6 = slotMap.Add('E');

        List<KeyValuePair<SlotKey, char?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, char?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key2,'A'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key3,'B'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key4,'C'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key5,'D'), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, char?>(key6,'E'), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyLongMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<long>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledLongMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Add(1000_000_000_000L);
        var key2 = slotMap.Add(2000_000_000_000L);

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key1, 1000_000_000_000L), result);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key2, 2000_000_000_000L), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void LongWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Add(1000_000_000_000L);
        var key2 = slotMap.Add(2000_000_000_000L);
        var key3 = slotMap.Add(3000_000_000_000L);
        var key4 = slotMap.Add(4000_000_000_000L);

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, long>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key2, 2000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key3, 3000_000_000_000L), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void LongDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Add(1000_000_000_000L);
        var key2 = slotMap.Add(2000_000_000_000L);
        var key3 = slotMap.Add(3000_000_000_000L);
        var key4 = slotMap.Add(4000_000_000_000L);
        var key5 = slotMap.Add(5000_000_000_000L);
        var key6 = slotMap.Add(6000_000_000_000L);

        List<KeyValuePair<SlotKey, long>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, long>(key1,1000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key2,2000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key3,3000_000_000_000L), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key4, 4000_000_000_000L), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key5, 5000_000_000_000L), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key6, 6000_000_000_000L), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void LongDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Add(1000_000_000_000L);
        var key2 = slotMap.Add(2000_000_000_000L);
        var key3 = slotMap.Add(3000_000_000_000L);
        var key4 = slotMap.Add(4000_000_000_000L);
        var key5 = slotMap.Add(5000_000_000_000L);
        var key6 = slotMap.Add(6000_000_000_000L);

        List<KeyValuePair<SlotKey, long>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, long>(key1,1000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key2,2000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key3,3000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key4,4000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key5,5000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long>(key6,6000_000_000_000L), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyLongNullableMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<long?>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledLongNullableMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1000_000_000_000L);

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key2, 1000_000_000_000L), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void LongNullableWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1000_000_000_000L);
        var key3 = slotMap.Add(2000_000_000_000L);
        var key4 = slotMap.Add(3000_000_000_000L);

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, long?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key2, 1000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key3, 2000_000_000_000L), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void LongNullableDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1000_000_000_000L);
        var key3 = slotMap.Add(2000_000_000_000L);
        var key4 = slotMap.Add(3000_000_000_000L);
        var key5 = slotMap.Add(4000_000_000_000L);
        var key6 = slotMap.Add(5000_000_000_000L);

        List<KeyValuePair<SlotKey, long?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, long?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key2,1000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key3,2000_000_000_000L), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key4, 3000_000_000_000L), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key5, 4000_000_000_000L), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key6, 5000_000_000_000L), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void LongNullableDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1000_000_000_000L);
        var key3 = slotMap.Add(2000_000_000_000L);
        var key4 = slotMap.Add(3000_000_000_000L);
        var key5 = slotMap.Add(4000_000_000_000L);
        var key6 = slotMap.Add(5000_000_000_000L);

        List<KeyValuePair<SlotKey, long?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, long?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key2,1000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key3,2000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key4,3000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key5,4000_000_000_000L), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, long?>(key6,5000_000_000_000L), drainedItems);
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
        var key1 = slotMap.Add(1.1F);
        var key2 = slotMap.Add(2.2F);

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
        var key1 = slotMap.Add(1.1F);
        var key2 = slotMap.Add(2.2F);
        var key3 = slotMap.Add(3.3F);
        var key4 = slotMap.Add(4.4F);

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
        var key1 = slotMap.Add(1.1F);
        var key2 = slotMap.Add(2.2F);
        var key3 = slotMap.Add(3.3F);
        var key4 = slotMap.Add(4.4F);
        var key5 = slotMap.Add(5.5F);
        var key6 = slotMap.Add(6.6F);

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
        var key1 = slotMap.Add(1.1F);
        var key2 = slotMap.Add(2.2F);
        var key3 = slotMap.Add(3.3F);
        var key4 = slotMap.Add(4.4F);
        var key5 = slotMap.Add(5.5F);
        var key6 = slotMap.Add(6.6F);

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.1F);

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.1F);
        var key3 = slotMap.Add(2.2F);
        var key4 = slotMap.Add(3.3F);

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.1F);
        var key3 = slotMap.Add(2.2F);
        var key4 = slotMap.Add(3.3F);
        var key5 = slotMap.Add(4.4F);
        var key6 = slotMap.Add(5.5F);

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.1F);
        var key3 = slotMap.Add(2.2F);
        var key4 = slotMap.Add(3.3F);
        var key5 = slotMap.Add(4.4F);
        var key6 = slotMap.Add(5.5F);

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
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyDecimalMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<decimal>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledDecimalMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Add(1.111_111_111M);
        var key2 = slotMap.Add(2.222_222_222M);

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key1, 1.111_111_111M), result);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key2, 2.222_222_222M), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DecimalWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Add(1.111_111_111M);
        var key2 = slotMap.Add(2.222_222_222M);
        var key3 = slotMap.Add(3.333_333_333M);
        var key4 = slotMap.Add(4.444_444_444M);

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, decimal>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key2, 2.222_222_222M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key3, 3.333_333_333M), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DecimalDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Add(1.111_111_111M);
        var key2 = slotMap.Add(2.222_222_222M);
        var key3 = slotMap.Add(3.333_333_333M);
        var key4 = slotMap.Add(4.444_444_444M);
        var key5 = slotMap.Add(5.555_555_555M);
        var key6 = slotMap.Add(6.666_666_666M);

        List<KeyValuePair<SlotKey, decimal>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key1,1.111_111_111M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key2,2.222_222_222M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key3,3.333_333_333M), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key4, 4.444_444_444M), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key5, 5.555_555_555M), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key6, 6.666_666_666M), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void DecimalDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Add(1.111_111_111M);
        var key2 = slotMap.Add(2.222_222_222M);
        var key3 = slotMap.Add(3.333_333_333M);
        var key4 = slotMap.Add(4.444_444_444M);
        var key5 = slotMap.Add(5.555_555_555M);
        var key6 = slotMap.Add(6.666_666_666M);

        List<KeyValuePair<SlotKey, decimal>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key1,1.111_111_111M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key2,2.222_222_222M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key3,3.333_333_333M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key4,4.444_444_444M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key5,5.555_555_555M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal>(key6,6.666_666_666M), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyDecimalNullableMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<decimal?>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledDecimalNullableMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.111_111_111M);

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key2, 1.111_111_111M), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DecimalNullableWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.111_111_111M);
        var key3 = slotMap.Add(2.222_222_222M);
        var key4 = slotMap.Add(3.333_333_333M);

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, decimal?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key2, 1.111_111_111M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key3, 2.222_222_222M), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DecimalNullableDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.111_111_111M);
        var key3 = slotMap.Add(2.222_222_222M);
        var key4 = slotMap.Add(3.333_333_333M);
        var key5 = slotMap.Add(4.444_444_444M);
        var key6 = slotMap.Add(5.555_555_555M);

        List<KeyValuePair<SlotKey, decimal?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key2,1.111_111_111M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key3,2.222_222_222M), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key4, 3.333_333_333M), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key5, 4.444_444_444M), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key6, 5.555_555_555M), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void DecimalNullableDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.111_111_111M);
        var key3 = slotMap.Add(2.222_222_222M);
        var key4 = slotMap.Add(3.333_333_333M);
        var key5 = slotMap.Add(4.444_444_444M);
        var key6 = slotMap.Add(5.555_555_555M);

        List<KeyValuePair<SlotKey, decimal?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key2,1.111_111_111M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key3,2.222_222_222M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key4,3.333_333_333M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key5,4.444_444_444M), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, decimal?>(key6,5.555_555_555M), drainedItems);
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
        var key1 = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Add(DateTime.Parse("2023-02-01"));

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
        var key1 = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Add(DateTime.Parse("2023-02-01"));
        var key3 = slotMap.Add(DateTime.Parse("2023-03-01"));
        var key4 = slotMap.Add(DateTime.Parse("2023-04-01"));

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
        var key1 = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Add(DateTime.Parse("2023-02-01"));
        var key3 = slotMap.Add(DateTime.Parse("2023-03-01"));
        var key4 = slotMap.Add(DateTime.Parse("2023-04-01"));
        var key5 = slotMap.Add(DateTime.Parse("2023-05-01"));
        var key6 = slotMap.Add(DateTime.Parse("2023-06-01"));

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
        var key1 = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Add(DateTime.Parse("2023-02-01"));
        var key3 = slotMap.Add(DateTime.Parse("2023-03-01"));
        var key4 = slotMap.Add(DateTime.Parse("2023-04-01"));
        var key5 = slotMap.Add(DateTime.Parse("2023-05-01"));
        var key6 = slotMap.Add(DateTime.Parse("2023-06-01"));

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(DateTime.Parse("2023-01-01"));

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key3 = slotMap.Add(DateTime.Parse("2023-02-01"));
        var key4 = slotMap.Add(DateTime.Parse("2023-03-01"));

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key3 = slotMap.Add(DateTime.Parse("2023-02-01"));
        var key4 = slotMap.Add(DateTime.Parse("2023-03-01"));
        var key5 = slotMap.Add(DateTime.Parse("2023-04-01"));
        var key6 = slotMap.Add(DateTime.Parse("2023-05-01"));

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key3 = slotMap.Add(DateTime.Parse("2023-02-01"));
        var key4 = slotMap.Add(DateTime.Parse("2023-03-01"));
        var key5 = slotMap.Add(DateTime.Parse("2023-04-01"));
        var key6 = slotMap.Add(DateTime.Parse("2023-05-01"));

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
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyTimeSpanMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<TimeSpan>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledTimeSpanMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Add(new TimeSpan(00,00,00));
        var key2 = slotMap.Add(new TimeSpan(01,00,00));

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key1, new TimeSpan(00,00,00)), result);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key2, new TimeSpan(01,00,00)), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void TimeSpanWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Add(new TimeSpan(00,00,00));
        var key2 = slotMap.Add(new TimeSpan(01,00,00));
        var key3 = slotMap.Add(new TimeSpan(02,00,00));
        var key4 = slotMap.Add(new TimeSpan(03,00,00));

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, TimeSpan>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key2, new TimeSpan(01,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key3, new TimeSpan(02,00,00)), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void TimeSpanDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Add(new TimeSpan(00,00,00));
        var key2 = slotMap.Add(new TimeSpan(01,00,00));
        var key3 = slotMap.Add(new TimeSpan(02,00,00));
        var key4 = slotMap.Add(new TimeSpan(03,00,00));
        var key5 = slotMap.Add(new TimeSpan(04,00,00));
        var key6 = slotMap.Add(new TimeSpan(05,00,00));

        List<KeyValuePair<SlotKey, TimeSpan>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key1,new TimeSpan(00,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key2,new TimeSpan(01,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key3,new TimeSpan(02,00,00)), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key4, new TimeSpan(03,00,00)), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key5, new TimeSpan(04,00,00)), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key6, new TimeSpan(05,00,00)), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void TimeSpanDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Add(new TimeSpan(00,00,00));
        var key2 = slotMap.Add(new TimeSpan(01,00,00));
        var key3 = slotMap.Add(new TimeSpan(02,00,00));
        var key4 = slotMap.Add(new TimeSpan(03,00,00));
        var key5 = slotMap.Add(new TimeSpan(04,00,00));
        var key6 = slotMap.Add(new TimeSpan(05,00,00));

        List<KeyValuePair<SlotKey, TimeSpan>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key1,new TimeSpan(00,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key2,new TimeSpan(01,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key3,new TimeSpan(02,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key4,new TimeSpan(03,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key5,new TimeSpan(04,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan>(key6,new TimeSpan(05,00,00)), drainedItems);
        Assert.Equal(6, drainedItems.Count);
        Assert.Empty(slotMap.Drain());
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void EmptyTimeSpanNullableMap_ReturnsEmptySequence()
    {
        var slotMap = new SlotMap<TimeSpan?>();

        var result = slotMap.Drain().ToArray();

        Assert.Empty(result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FilledTimeSpanNullableMap_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(new TimeSpan(00,00,00));

        var result = slotMap.Drain().ToArray();

        Assert.Equal(2, result.Length);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key1, null), result);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key2, new TimeSpan(00,00,00)), result);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void TimeSpanNullableWithRemovedKeys_NotReturnRemovedKeys()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(new TimeSpan(00,00,00));
        var key3 = slotMap.Add(new TimeSpan(01,00,00));
        var key4 = slotMap.Add(new TimeSpan(02,00,00));

        slotMap.Remove(key1);
        slotMap.Remove(key4);

        List<KeyValuePair<SlotKey, TimeSpan?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Equal(2, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key2, new TimeSpan(00,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key3, new TimeSpan(01,00,00)), drainedItems);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void TimeSpanNullableDrainingUpToMiddle_ReturnsItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(new TimeSpan(00,00,00));
        var key3 = slotMap.Add(new TimeSpan(01,00,00));
        var key4 = slotMap.Add(new TimeSpan(02,00,00));
        var key5 = slotMap.Add(new TimeSpan(03,00,00));
        var key6 = slotMap.Add(new TimeSpan(04,00,00));

        List<KeyValuePair<SlotKey, TimeSpan?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
            if (kvp.Key.Equals(key3))
                break;
        }

        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key2,new TimeSpan(00,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key3,new TimeSpan(01,00,00)), drainedItems);
        Assert.Equal(3, drainedItems.Count);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key4, new TimeSpan(02,00,00)), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key5, new TimeSpan(03,00,00)), slotMap);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key6, new TimeSpan(04,00,00)), slotMap);
        Assert.Equal(3, slotMap.Count);
    }

    [Fact]
    public void TimeSpanNullableDrainingEverything_ReturnsAllItemsAndEmptiesMap()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(new TimeSpan(00,00,00));
        var key3 = slotMap.Add(new TimeSpan(01,00,00));
        var key4 = slotMap.Add(new TimeSpan(02,00,00));
        var key5 = slotMap.Add(new TimeSpan(03,00,00));
        var key6 = slotMap.Add(new TimeSpan(04,00,00));

        List<KeyValuePair<SlotKey, TimeSpan?>> drainedItems = new(3);

        foreach (var kvp in slotMap.Drain())
        {
            drainedItems.Add(kvp);
        }

        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key1,null), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key2,new TimeSpan(00,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key3,new TimeSpan(01,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key4,new TimeSpan(02,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key5,new TimeSpan(03,00,00)), drainedItems);
        Assert.Contains(new KeyValuePair<SlotKey, TimeSpan?>(key6,new TimeSpan(04,00,00)), drainedItems);
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
        var key1 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

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
        var key1 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key3 = slotMap.Add(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key4 = slotMap.Add(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));

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
        var key1 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key3 = slotMap.Add(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key4 = slotMap.Add(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        var key5 = slotMap.Add(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));
        var key6 = slotMap.Add(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

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
        var key1 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key3 = slotMap.Add(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key4 = slotMap.Add(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        var key5 = slotMap.Add(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));
        var key6 = slotMap.Add(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key3 = slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key4 = slotMap.Add(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key3 = slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key4 = slotMap.Add(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key5 = slotMap.Add(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        var key6 = slotMap.Add(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

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
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key3 = slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key4 = slotMap.Add(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key5 = slotMap.Add(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        var key6 = slotMap.Add(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

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