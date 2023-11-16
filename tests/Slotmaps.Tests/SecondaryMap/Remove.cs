//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SecondaryMap;
public class Remove
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 10);

        var result = secondaryMap.Remove(key);

        Assert.Equal(10, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void IntWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void IntWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void IntWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 10);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void IntWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, 10);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Remove(key);

        Assert.Equal(null, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void IntNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void IntNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, "Value 1");

        var result = secondaryMap.Remove(key);

        Assert.Equal("Value 1", result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void StringWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void StringWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void StringWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, "Value 1");

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void StringWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, "Value 1");

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Remove(key);

        Assert.Equal(null, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void StringNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void StringNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1.11D);

        var result = secondaryMap.Remove(key);

        Assert.Equal(1.11D, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void DoubleWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void DoubleWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void DoubleWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.11D);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void DoubleWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, 1.11D);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Remove(key);

        Assert.Equal(null, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void DoubleNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void DoubleNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void DoubleNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void DoubleNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, true);

        var result = secondaryMap.Remove(key);

        Assert.Equal(true, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void BoolWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void BoolWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void BoolWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, true);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void BoolWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, true);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Remove(key);

        Assert.Equal(null, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void BoolNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void BoolNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void BoolNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void BoolNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 'A');

        var result = secondaryMap.Remove(key);

        Assert.Equal('A', result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void CharWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void CharWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void CharWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 'A');

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void CharWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, 'A');

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Remove(key);

        Assert.Equal(null, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void CharNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void CharNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void CharNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void CharNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1000_000_000_000L);

        var result = secondaryMap.Remove(key);

        Assert.Equal(1000_000_000_000L, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void LongWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void LongWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void LongWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1000_000_000_000L);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void LongWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, 1000_000_000_000L);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Remove(key);

        Assert.Equal(null, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void LongNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void LongNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void LongNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void LongNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1.1F);

        var result = secondaryMap.Remove(key);

        Assert.Equal(1.1F, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void FloatWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void FloatWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void FloatWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.1F);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void FloatWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, 1.1F);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Remove(key);

        Assert.Equal(null, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void FloatNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void FloatNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1.111_111_111M);

        var result = secondaryMap.Remove(key);

        Assert.Equal(1.111_111_111M, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void DecimalWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void DecimalWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void DecimalWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.111_111_111M);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void DecimalWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, 1.111_111_111M);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Remove(key);

        Assert.Equal(null, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void DecimalNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void DecimalNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void DecimalNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void DecimalNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        var result = secondaryMap.Remove(key);

        Assert.Equal(DateTime.Parse("2023-01-01"), result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void DateTimeWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void DateTimeWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Remove(key);

        Assert.Equal(null, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void DateTimeNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void DateTimeNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, new TimeSpan(00,00,00));

        var result = secondaryMap.Remove(key);

        Assert.Equal(new TimeSpan(00,00,00), result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void TimeSpanWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void TimeSpanWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void TimeSpanWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void TimeSpanWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Remove(key);

        Assert.Equal(null, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void TimeSpanNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void TimeSpanNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void TimeSpanNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void TimeSpanNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var result = secondaryMap.Remove(key);

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void GuidWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void GuidWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void GuidWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void GuidWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithValidKey_RemovesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap.Remove(key);

        Assert.Equal(null, result);
        Assert.False(secondaryMap.TryGet(key, out _));
    }

    [Fact]
    public void GuidNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(invalidKey));
    }

    [Fact]
    public void GuidNullableWithKeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key));
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap.Remove(key2));
    }

}