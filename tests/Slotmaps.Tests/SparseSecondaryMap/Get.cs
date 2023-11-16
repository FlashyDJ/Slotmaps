//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SparseSecondaryMap;
public class Get
{
    [Fact]
    public void InvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(invalidKey));
    }

    [Fact]
    public void KeyNotFound_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key = new SlotKey(1, 0);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsIntValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 10);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(10, result);
    }

    [Fact]
    public void IntWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, 10);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void IntWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, 10);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsIntNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsStringValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, "Value 1");

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal("Value 1", result);
    }

    [Fact]
    public void StringWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, "Value 1");

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void StringWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, "Value 1");
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsStringNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDoubleValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 1.11D);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(1.11D, result);
    }

    [Fact]
    public void DoubleWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, 1.11D);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void DoubleWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, 1.11D);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDoubleNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void DoubleNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void DoubleNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsBoolValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, true);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(true, result);
    }

    [Fact]
    public void BoolWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, true);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void BoolWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, true);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsBoolNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void BoolNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void BoolNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsCharValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 'A');

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal('A', result);
    }

    [Fact]
    public void CharWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, 'A');

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void CharWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, 'A');
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsCharNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void CharNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void CharNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsLongValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 1000_000_000_000L);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(1000_000_000_000L, result);
    }

    [Fact]
    public void LongWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, 1000_000_000_000L);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void LongWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, 1000_000_000_000L);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsLongNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void LongNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void LongNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsFloatValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 1.1F);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(1.1F, result);
    }

    [Fact]
    public void FloatWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, 1.1F);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void FloatWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, 1.1F);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsFloatNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDecimalValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 1.111_111_111M);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(1.111_111_111M, result);
    }

    [Fact]
    public void DecimalWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, 1.111_111_111M);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void DecimalWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, 1.111_111_111M);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDecimalNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void DecimalNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void DecimalNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDateTimeValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(DateTime.Parse("2023-01-01"), result);
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDateTimeNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsTimeSpanValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, new(00,00,00));

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(new(00,00,00), result);
    }

    [Fact]
    public void TimeSpanWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, new(00,00,00));

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void TimeSpanWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, new(00,00,00));
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsTimeSpanNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void TimeSpanNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void TimeSpanNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsGuidValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result);
    }

    [Fact]
    public void GuidWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void GuidWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsGuidNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(null, result);
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

}