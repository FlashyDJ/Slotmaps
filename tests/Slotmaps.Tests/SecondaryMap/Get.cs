//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SecondaryMap;
public class Get
{
    [Fact]
    public void InvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(invalidKey));
    }

    [Fact]
    public void KeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsIntValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 10);

        var result = secondaryMap.Get(key);

        Assert.Equal(10, result);
    }

    [Fact]
    public void IntWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, 10);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void IntWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 10);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsIntNullableValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsStringValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, "Value 1");

        var result = secondaryMap.Get(key);

        Assert.Equal("Value 1", result);
    }

    [Fact]
    public void StringWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, "Value 1");

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void StringWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, "Value 1");
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsStringNullableValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDoubleValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1.11D);

        var result = secondaryMap.Get(key);

        Assert.Equal(1.11D, result);
    }

    [Fact]
    public void DoubleWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, 1.11D);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void DoubleWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.11D);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDoubleNullableValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void DoubleNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void DoubleNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsBoolValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, true);

        var result = secondaryMap.Get(key);

        Assert.Equal(true, result);
    }

    [Fact]
    public void BoolWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, true);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void BoolWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, true);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsBoolNullableValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void BoolNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void BoolNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsCharValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 'A');

        var result = secondaryMap.Get(key);

        Assert.Equal('A', result);
    }

    [Fact]
    public void CharWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, 'A');

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void CharWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 'A');
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsCharNullableValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void CharNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void CharNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsLongValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1000_000_000_000L);

        var result = secondaryMap.Get(key);

        Assert.Equal(1000_000_000_000L, result);
    }

    [Fact]
    public void LongWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, 1000_000_000_000L);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void LongWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1000_000_000_000L);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsLongNullableValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void LongNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void LongNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsFloatValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1.1F);

        var result = secondaryMap.Get(key);

        Assert.Equal(1.1F, result);
    }

    [Fact]
    public void FloatWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, 1.1F);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void FloatWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.1F);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsFloatNullableValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDecimalValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1.111_111_111M);

        var result = secondaryMap.Get(key);

        Assert.Equal(1.111_111_111M, result);
    }

    [Fact]
    public void DecimalWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, 1.111_111_111M);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void DecimalWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.111_111_111M);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDecimalNullableValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void DecimalNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void DecimalNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDateTimeValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        var result = secondaryMap.Get(key);

        Assert.Equal(DateTime.Parse("2023-01-01"), result);
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDateTimeNullableValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsTimeSpanValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, new(00,00,00));

        var result = secondaryMap.Get(key);

        Assert.Equal(new(00,00,00), result);
    }

    [Fact]
    public void TimeSpanWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, new(00,00,00));

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void TimeSpanWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, new(00,00,00));
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsTimeSpanNullableValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void TimeSpanNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void TimeSpanNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsGuidValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var result = secondaryMap.Get(key);

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result);
    }

    [Fact]
    public void GuidWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void GuidWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsGuidNullableValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Get(key2));
    }

}