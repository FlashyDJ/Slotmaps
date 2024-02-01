//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SecondaryMap;

public class Clear
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithIntItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, 10);
        secondaryMap.Insert(key2, 20);
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyIntMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<int>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithIntNullableItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 10);
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyIntNullableMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<int?>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithStringItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, "Value 1");
        secondaryMap.Insert(key2, "Value 2");
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyStringMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<string>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithStringNullableItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, "Value 1");
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyStringNullableMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<string?>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithFloatItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, 1.1F);
        secondaryMap.Insert(key2, 2.2F);
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyFloatMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<float>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithFloatNullableItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.1F);
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyFloatNullableMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<float?>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithDateTimeItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        secondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyDateTimeMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<DateTime>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithDateTimeNullableItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyDateTimeNullableMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithGuidItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        secondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyGuidMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<Guid>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithGuidNullableItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyGuidNullableMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<Guid?>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

}