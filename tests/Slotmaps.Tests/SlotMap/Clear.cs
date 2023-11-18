//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SlotMap;
public class Clear
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithIntItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<int>();
        slotMap.Add(10);
        slotMap.Add(20);
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyIntMap_DoesNothing()
    {
        var slotMap = new SlotMap<int>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithIntNullableItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<int?>();
        slotMap.Add(null);
        slotMap.Add(10);
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyIntNullableMap_DoesNothing()
    {
        var slotMap = new SlotMap<int?>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithStringItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<string>();
        slotMap.Add("Value 1");
        slotMap.Add("Value 2");
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyStringMap_DoesNothing()
    {
        var slotMap = new SlotMap<string>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithStringNullableItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<string?>();
        slotMap.Add(null);
        slotMap.Add("Value 1");
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyStringNullableMap_DoesNothing()
    {
        var slotMap = new SlotMap<string?>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithDoubleItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<double>();
        slotMap.Add(1.11D);
        slotMap.Add(2.22D);
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyDoubleMap_DoesNothing()
    {
        var slotMap = new SlotMap<double>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithDoubleNullableItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<double?>();
        slotMap.Add(null);
        slotMap.Add(1.11D);
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyDoubleNullableMap_DoesNothing()
    {
        var slotMap = new SlotMap<double?>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithBoolItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<bool>();
        slotMap.Add(true);
        slotMap.Add(false);
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyBoolMap_DoesNothing()
    {
        var slotMap = new SlotMap<bool>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithBoolNullableItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<bool?>();
        slotMap.Add(null);
        slotMap.Add(true);
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyBoolNullableMap_DoesNothing()
    {
        var slotMap = new SlotMap<bool?>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithCharItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<char>();
        slotMap.Add('A');
        slotMap.Add('B');
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyCharMap_DoesNothing()
    {
        var slotMap = new SlotMap<char>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithCharNullableItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<char?>();
        slotMap.Add(null);
        slotMap.Add('A');
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyCharNullableMap_DoesNothing()
    {
        var slotMap = new SlotMap<char?>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithLongItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<long>();
        slotMap.Add(1000_000_000_000L);
        slotMap.Add(2000_000_000_000L);
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyLongMap_DoesNothing()
    {
        var slotMap = new SlotMap<long>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithLongNullableItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<long?>();
        slotMap.Add(null);
        slotMap.Add(1000_000_000_000L);
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyLongNullableMap_DoesNothing()
    {
        var slotMap = new SlotMap<long?>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithFloatItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<float>();
        slotMap.Add(1.1F);
        slotMap.Add(2.2F);
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyFloatMap_DoesNothing()
    {
        var slotMap = new SlotMap<float>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithFloatNullableItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<float?>();
        slotMap.Add(null);
        slotMap.Add(1.1F);
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyFloatNullableMap_DoesNothing()
    {
        var slotMap = new SlotMap<float?>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithDecimalItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<decimal>();
        slotMap.Add(1.111_111_111M);
        slotMap.Add(2.222_222_222M);
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyDecimalMap_DoesNothing()
    {
        var slotMap = new SlotMap<decimal>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithDecimalNullableItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<decimal?>();
        slotMap.Add(null);
        slotMap.Add(1.111_111_111M);
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyDecimalNullableMap_DoesNothing()
    {
        var slotMap = new SlotMap<decimal?>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithDateTimeItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<DateTime>();
        slotMap.Add(DateTime.Parse("2023-01-01"));
        slotMap.Add(DateTime.Parse("2023-02-01"));
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyDateTimeMap_DoesNothing()
    {
        var slotMap = new SlotMap<DateTime>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithDateTimeNullableItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<DateTime?>();
        slotMap.Add(null);
        slotMap.Add(DateTime.Parse("2023-01-01"));
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyDateTimeNullableMap_DoesNothing()
    {
        var slotMap = new SlotMap<DateTime?>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithTimeSpanItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<TimeSpan>();
        slotMap.Add(new TimeSpan(00,00,00));
        slotMap.Add(new TimeSpan(01,00,00));
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyTimeSpanMap_DoesNothing()
    {
        var slotMap = new SlotMap<TimeSpan>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithTimeSpanNullableItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        slotMap.Add(null);
        slotMap.Add(new TimeSpan(00,00,00));
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyTimeSpanNullableMap_DoesNothing()
    {
        var slotMap = new SlotMap<TimeSpan?>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithGuidItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<Guid>();
        slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyGuidMap_DoesNothing()
    {
        var slotMap = new SlotMap<Guid>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void WithGuidNullableItems_ClearsMapAndSetsCountToZero()
    {
        var slotMap = new SlotMap<Guid?>();
        slotMap.Add(null);
        slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var capacity = slotMap.Capacity;
    
        slotMap.Clear();
    
        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void EmptyGuidNullableMap_DoesNothing()
    {
        var slotMap = new SlotMap<Guid?>();
    
        slotMap.Clear();
    
        Assert.Empty(slotMap);
    }

}