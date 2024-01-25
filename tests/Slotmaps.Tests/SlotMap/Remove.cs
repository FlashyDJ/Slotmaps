//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SlotMap;
public class Remove
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Add(10);

        var result = slotMap.Remove(key);

        Assert.Equal(10, result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void IntWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void IntWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void IntWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Add(10);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void IntWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Add(10);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Add(null);

        var result = slotMap.Remove(key);

        Assert.Null(result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void IntNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void IntNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Add("Value 1");

        var result = slotMap.Remove(key);

        Assert.Equal("Value 1", result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void StringWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void StringWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void StringWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Add("Value 1");
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void StringWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Add("Value 1");
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Add(null);

        var result = slotMap.Remove(key);

        Assert.Null(result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void StringNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void StringNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<double>();
        var key = slotMap.Add(1.11D);

        var result = slotMap.Remove(key);

        Assert.Equal(1.11D, result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void DoubleWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void DoubleWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void DoubleWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double>();
        var key = slotMap.Add(1.11D);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void DoubleWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double>();
        var key = slotMap.Add(1.11D);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<double?>();
        var key = slotMap.Add(null);

        var result = slotMap.Remove(key);

        Assert.Null(result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void DoubleNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void DoubleNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void DoubleNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void DoubleNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<bool>();
        var key = slotMap.Add(true);

        var result = slotMap.Remove(key);

        Assert.Equal(true, result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void BoolWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void BoolWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void BoolWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool>();
        var key = slotMap.Add(true);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void BoolWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool>();
        var key = slotMap.Add(true);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<bool?>();
        var key = slotMap.Add(null);

        var result = slotMap.Remove(key);

        Assert.Null(result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void BoolNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void BoolNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void BoolNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void BoolNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<char>();
        var key = slotMap.Add('A');

        var result = slotMap.Remove(key);

        Assert.Equal('A', result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void CharWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void CharWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void CharWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char>();
        var key = slotMap.Add('A');
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void CharWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char>();
        var key = slotMap.Add('A');
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<char?>();
        var key = slotMap.Add(null);

        var result = slotMap.Remove(key);

        Assert.Null(result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void CharNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void CharNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void CharNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void CharNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<long>();
        var key = slotMap.Add(1000_000_000_000L);

        var result = slotMap.Remove(key);

        Assert.Equal(1000_000_000_000L, result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void LongWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void LongWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void LongWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long>();
        var key = slotMap.Add(1000_000_000_000L);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void LongWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long>();
        var key = slotMap.Add(1000_000_000_000L);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<long?>();
        var key = slotMap.Add(null);

        var result = slotMap.Remove(key);

        Assert.Null(result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void LongNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void LongNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void LongNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void LongNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Add(1.1F);

        var result = slotMap.Remove(key);

        Assert.Equal(1.1F, result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void FloatWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void FloatWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void FloatWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Add(1.1F);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void FloatWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Add(1.1F);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Add(null);

        var result = slotMap.Remove(key);

        Assert.Null(result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void FloatNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void FloatNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<decimal>();
        var key = slotMap.Add(1.111_111_111M);

        var result = slotMap.Remove(key);

        Assert.Equal(1.111_111_111M, result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void DecimalWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void DecimalWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void DecimalWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal>();
        var key = slotMap.Add(1.111_111_111M);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void DecimalWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal>();
        var key = slotMap.Add(1.111_111_111M);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = slotMap.Add(null);

        var result = slotMap.Remove(key);

        Assert.Null(result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void DecimalNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void DecimalNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void DecimalNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void DecimalNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Add(DateTime.Parse("2023-01-01"));

        var result = slotMap.Remove(key);

        Assert.Equal(DateTime.Parse("2023-01-01"), result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void DateTimeWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void DateTimeWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Add(null);

        var result = slotMap.Remove(key);

        Assert.Null(result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void DateTimeNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void DateTimeNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = slotMap.Add(new TimeSpan(00,00,00));

        var result = slotMap.Remove(key);

        Assert.Equal(new TimeSpan(00,00,00), result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void TimeSpanWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void TimeSpanWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void TimeSpanWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = slotMap.Add(new TimeSpan(00,00,00));
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void TimeSpanWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = slotMap.Add(new TimeSpan(00,00,00));
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = slotMap.Add(null);

        var result = slotMap.Remove(key);

        Assert.Null(result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void TimeSpanNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void TimeSpanNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void TimeSpanNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void TimeSpanNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var result = slotMap.Remove(key);

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void GuidWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void GuidWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void GuidWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void GuidWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Add(null);

        var result = slotMap.Remove(key);

        Assert.Null(result);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void GuidNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(invalidKey));
    }

    [Fact]
    public void GuidNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key));
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Add(null);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

}