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
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithDoubleItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, 1.11D);
        secondaryMap.Insert(key2, 2.22D);
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyDoubleMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<double>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithDoubleNullableItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.11D);
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyDoubleNullableMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<double?>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithBoolItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, true);
        secondaryMap.Insert(key2, false);
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyBoolMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<bool>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithBoolNullableItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, true);
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyBoolNullableMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<bool?>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithCharItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, 'A');
        secondaryMap.Insert(key2, 'B');
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyCharMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<char>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithCharNullableItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 'A');
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyCharNullableMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<char?>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithLongItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, 1000_000_000_000L);
        secondaryMap.Insert(key2, 2000_000_000_000L);
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyLongMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<long>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithLongNullableItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1000_000_000_000L);
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyLongNullableMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<long?>();

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
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithDecimalItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, 1.111_111_111M);
        secondaryMap.Insert(key2, 2.222_222_222M);
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyDecimalMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<decimal>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithDecimalNullableItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.111_111_111M);
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyDecimalNullableMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<decimal?>();

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
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithTimeSpanItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));
        secondaryMap.Insert(key2, new TimeSpan(01,00,00));
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyTimeSpanMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(0, secondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithTimeSpanNullableItems_ClearsMapAndSetsCountToZero()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, new TimeSpan(00,00,00));
        var capacity = secondaryMap.Capacity;

        secondaryMap.Clear();

        Assert.Empty(secondaryMap);
        Assert.Equal(capacity, secondaryMap.Capacity);
    }

    [Fact]
    public void EmptyTimeSpanNullableMap_DoesNothing()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();

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