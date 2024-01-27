//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SparseSecondaryMap;

public class Clear
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithIntItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, 10);
        sparseSecondaryMap.Insert(key2, 20);
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyIntMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithIntNullableItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 10);
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyIntNullableMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithStringItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, "Value 1");
        sparseSecondaryMap.Insert(key2, "Value 2");
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyStringMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithStringNullableItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, "Value 1");
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyStringNullableMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithDoubleItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, 1.11D);
        sparseSecondaryMap.Insert(key2, 2.22D);
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyDoubleMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithDoubleNullableItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.11D);
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyDoubleNullableMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithBoolItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, true);
        sparseSecondaryMap.Insert(key2, false);
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyBoolMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithBoolNullableItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, true);
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyBoolNullableMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithCharItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, 'A');
        sparseSecondaryMap.Insert(key2, 'B');
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyCharMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithCharNullableItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 'A');
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyCharNullableMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithLongItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, 1000_000_000_000L);
        sparseSecondaryMap.Insert(key2, 2000_000_000_000L);
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyLongMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithLongNullableItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1000_000_000_000L);
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyLongNullableMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithFloatItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, 1.1F);
        sparseSecondaryMap.Insert(key2, 2.2F);
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyFloatMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithFloatNullableItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.1F);
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyFloatNullableMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithDecimalItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, 1.111_111_111M);
        sparseSecondaryMap.Insert(key2, 2.222_222_222M);
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyDecimalMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithDecimalNullableItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.111_111_111M);
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyDecimalNullableMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithDateTimeItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyDateTimeMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithDateTimeNullableItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyDateTimeNullableMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithTimeSpanItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, new TimeSpan(00,00,00));
        sparseSecondaryMap.Insert(key2, new TimeSpan(01,00,00));
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyTimeSpanMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithTimeSpanNullableItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, new TimeSpan(00,00,00));
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyTimeSpanNullableMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithGuidItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyGuidMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////
    [Fact]
    public void WithGuidNullableItems_ClearsMapAndSetsCountToZero()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
    }

    [Fact]
    public void EmptyGuidNullableMap_DoesNothing()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();

        sparseSecondaryMap.Clear();

        Assert.Empty(sparseSecondaryMap);
        Assert.Equal(0, sparseSecondaryMap.Capacity);
    }

}