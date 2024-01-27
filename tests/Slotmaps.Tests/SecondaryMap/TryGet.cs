//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SecondaryMap;

public class TryGet
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 10);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(10, value);
    }

    [Fact]
    public void IntWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void IntWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void IntWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 10);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void IntWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, 10);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void IntNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void IntNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, "Value 1");

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal("Value 1", value);
    }

    [Fact]
    public void StringWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<string>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void StringWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void StringWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, "Value 1");

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void StringWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, "Value 1");

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void StringNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void StringNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1.11D);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(1.11D, value);
    }

    [Fact]
    public void DoubleWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<double>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DoubleWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DoubleWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.11D);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DoubleWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, 1.11D);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void DoubleNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DoubleNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DoubleNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DoubleNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, true);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(true, value);
    }

    [Fact]
    public void BoolWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void BoolWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void BoolWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, true);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void BoolWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, true);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void BoolNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void BoolNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void BoolNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void BoolNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 'A');

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal('A', value);
    }

    [Fact]
    public void CharWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<char>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void CharWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void CharWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 'A');

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void CharWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, 'A');

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void CharNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void CharNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void CharNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void CharNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1000_000_000_000L);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(1000_000_000_000L, value);
    }

    [Fact]
    public void LongWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<long>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void LongWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void LongWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1000_000_000_000L);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void LongWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, 1000_000_000_000L);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void LongNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void LongNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void LongNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void LongNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1.1F);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(1.1F, value);
    }

    [Fact]
    public void FloatWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<float>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void FloatWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void FloatWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.1F);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void FloatWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, 1.1F);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void FloatNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void FloatNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1.111_111_111M);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(1.111_111_111M, value);
    }

    [Fact]
    public void DecimalWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DecimalWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DecimalWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.111_111_111M);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DecimalWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, 1.111_111_111M);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void DecimalNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DecimalNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DecimalNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DecimalNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(DateTime.Parse("2023-01-01"), value);
    }

    [Fact]
    public void DateTimeWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DateTimeWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void DateTimeNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DateTimeNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, new TimeSpan(00,00,00));

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(new TimeSpan(00,00,00), value);
    }

    [Fact]
    public void TimeSpanWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void TimeSpanWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void TimeSpanWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void TimeSpanWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void TimeSpanNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void TimeSpanNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void TimeSpanNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void TimeSpanNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), value);
    }

    [Fact]
    public void GuidWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void GuidWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void GuidWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void GuidWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithValidKey_ReturnsTrueAndValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void GuidNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void GuidNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        secondaryMap.Insert(key1, null);

        bool result = secondaryMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

}