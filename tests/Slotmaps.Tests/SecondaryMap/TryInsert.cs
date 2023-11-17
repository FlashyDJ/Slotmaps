//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SecondaryMap;
public class TryInsert
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, 10, out var previousValue);

        Assert.True(result);
        Assert.Equal(10, previousValue);
    }

    [Fact]
    public void IntWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, 10, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, 10, out var _);

        bool result = secondaryMap.TryInsert(key2, 20, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, 10, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, 20, out var previousValue2);

        Assert.True(result);
        Assert.Equal(10, previousValue1);
        Assert.Equal(10, previousValue2);
    }

    [Fact]
    public void IntWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, 10, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, 20, out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(10, secondaryMap[key1]);
        Assert.Equal(20, secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
    }

    [Fact]
    public void IntNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, null, out var _);

        bool result = secondaryMap.TryInsert(key2, 10, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, 10, out var previousValue2);

        Assert.True(result);
        Assert.Equal(null, previousValue1);
        Assert.Equal(null, previousValue2);
    }

    [Fact]
    public void IntNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, null, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, 10, out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(null, secondaryMap[key1]);
        Assert.Equal(10, secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, "Value 1", out var previousValue);

        Assert.True(result);
        Assert.Equal("Value 1", previousValue);
    }

    [Fact]
    public void StringWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, "Value 1", out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, "Value 1", out var _);

        bool result = secondaryMap.TryInsert(key2, "Value 2", out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, "Value 1", out var previousValue1);
        bool result = secondaryMap.TryInsert(key, "Value 2", out var previousValue2);

        Assert.True(result);
        Assert.Equal("Value 1", previousValue1);
        Assert.Equal("Value 1", previousValue2);
    }

    [Fact]
    public void StringWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, "Value 1", out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, "Value 2", out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal("Value 1", secondaryMap[key1]);
        Assert.Equal("Value 2", secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
    }

    [Fact]
    public void StringNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, null, out var _);

        bool result = secondaryMap.TryInsert(key2, "Value 1", out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, "Value 1", out var previousValue2);

        Assert.True(result);
        Assert.Equal(null, previousValue1);
        Assert.Equal(null, previousValue2);
    }

    [Fact]
    public void StringNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, null, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, "Value 1", out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(null, secondaryMap[key1]);
        Assert.Equal("Value 1", secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, 1.11D, out var previousValue);

        Assert.True(result);
        Assert.Equal(1.11D, previousValue);
    }

    [Fact]
    public void DoubleWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, 1.11D, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DoubleWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, 1.11D, out var _);

        bool result = secondaryMap.TryInsert(key2, 2.22D, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DoubleWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, 1.11D, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, 2.22D, out var previousValue2);

        Assert.True(result);
        Assert.Equal(1.11D, previousValue1);
        Assert.Equal(1.11D, previousValue2);
    }

    [Fact]
    public void DoubleWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, 1.11D, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, 2.22D, out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(1.11D, secondaryMap[key1]);
        Assert.Equal(2.22D, secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
    }

    [Fact]
    public void DoubleNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DoubleNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, null, out var _);

        bool result = secondaryMap.TryInsert(key2, 1.11D, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DoubleNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, 1.11D, out var previousValue2);

        Assert.True(result);
        Assert.Equal(null, previousValue1);
        Assert.Equal(null, previousValue2);
    }

    [Fact]
    public void DoubleNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, null, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, 1.11D, out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(null, secondaryMap[key1]);
        Assert.Equal(1.11D, secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, true, out var previousValue);

        Assert.True(result);
        Assert.Equal(true, previousValue);
    }

    [Fact]
    public void BoolWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, true, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void BoolWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, true, out var _);

        bool result = secondaryMap.TryInsert(key2, false, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void BoolWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, true, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, false, out var previousValue2);

        Assert.True(result);
        Assert.Equal(true, previousValue1);
        Assert.Equal(true, previousValue2);
    }

    [Fact]
    public void BoolWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, true, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, false, out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(true, secondaryMap[key1]);
        Assert.Equal(false, secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
    }

    [Fact]
    public void BoolNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void BoolNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, null, out var _);

        bool result = secondaryMap.TryInsert(key2, true, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void BoolNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, true, out var previousValue2);

        Assert.True(result);
        Assert.Equal(null, previousValue1);
        Assert.Equal(null, previousValue2);
    }

    [Fact]
    public void BoolNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, null, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, true, out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(null, secondaryMap[key1]);
        Assert.Equal(true, secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, 'A', out var previousValue);

        Assert.True(result);
        Assert.Equal('A', previousValue);
    }

    [Fact]
    public void CharWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, 'A', out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void CharWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, 'A', out var _);

        bool result = secondaryMap.TryInsert(key2, 'B', out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void CharWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, 'A', out var previousValue1);
        bool result = secondaryMap.TryInsert(key, 'B', out var previousValue2);

        Assert.True(result);
        Assert.Equal('A', previousValue1);
        Assert.Equal('A', previousValue2);
    }

    [Fact]
    public void CharWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, 'A', out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, 'B', out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal('A', secondaryMap[key1]);
        Assert.Equal('B', secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
    }

    [Fact]
    public void CharNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void CharNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, null, out var _);

        bool result = secondaryMap.TryInsert(key2, 'A', out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void CharNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, 'A', out var previousValue2);

        Assert.True(result);
        Assert.Equal(null, previousValue1);
        Assert.Equal(null, previousValue2);
    }

    [Fact]
    public void CharNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, null, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, 'A', out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(null, secondaryMap[key1]);
        Assert.Equal('A', secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, 1000_000_000_000L, out var previousValue);

        Assert.True(result);
        Assert.Equal(1000_000_000_000L, previousValue);
    }

    [Fact]
    public void LongWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, 1000_000_000_000L, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void LongWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, 1000_000_000_000L, out var _);

        bool result = secondaryMap.TryInsert(key2, 2000_000_000_000L, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void LongWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, 1000_000_000_000L, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, 2000_000_000_000L, out var previousValue2);

        Assert.True(result);
        Assert.Equal(1000_000_000_000L, previousValue1);
        Assert.Equal(1000_000_000_000L, previousValue2);
    }

    [Fact]
    public void LongWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, 1000_000_000_000L, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, 2000_000_000_000L, out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(1000_000_000_000L, secondaryMap[key1]);
        Assert.Equal(2000_000_000_000L, secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
    }

    [Fact]
    public void LongNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void LongNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, null, out var _);

        bool result = secondaryMap.TryInsert(key2, 1000_000_000_000L, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void LongNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, 1000_000_000_000L, out var previousValue2);

        Assert.True(result);
        Assert.Equal(null, previousValue1);
        Assert.Equal(null, previousValue2);
    }

    [Fact]
    public void LongNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, null, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, 1000_000_000_000L, out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(null, secondaryMap[key1]);
        Assert.Equal(1000_000_000_000L, secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, 1.1F, out var previousValue);

        Assert.True(result);
        Assert.Equal(1.1F, previousValue);
    }

    [Fact]
    public void FloatWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, 1.1F, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, 1.1F, out var _);

        bool result = secondaryMap.TryInsert(key2, 2.2F, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, 1.1F, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, 2.2F, out var previousValue2);

        Assert.True(result);
        Assert.Equal(1.1F, previousValue1);
        Assert.Equal(1.1F, previousValue2);
    }

    [Fact]
    public void FloatWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, 1.1F, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, 2.2F, out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(1.1F, secondaryMap[key1]);
        Assert.Equal(2.2F, secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
    }

    [Fact]
    public void FloatNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, null, out var _);

        bool result = secondaryMap.TryInsert(key2, 1.1F, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, 1.1F, out var previousValue2);

        Assert.True(result);
        Assert.Equal(null, previousValue1);
        Assert.Equal(null, previousValue2);
    }

    [Fact]
    public void FloatNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, null, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, 1.1F, out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(null, secondaryMap[key1]);
        Assert.Equal(1.1F, secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, 1.111_111_111M, out var previousValue);

        Assert.True(result);
        Assert.Equal(1.111_111_111M, previousValue);
    }

    [Fact]
    public void DecimalWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, 1.111_111_111M, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DecimalWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, 1.111_111_111M, out var _);

        bool result = secondaryMap.TryInsert(key2, 2.222_222_222M, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DecimalWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, 1.111_111_111M, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, 2.222_222_222M, out var previousValue2);

        Assert.True(result);
        Assert.Equal(1.111_111_111M, previousValue1);
        Assert.Equal(1.111_111_111M, previousValue2);
    }

    [Fact]
    public void DecimalWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, 1.111_111_111M, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, 2.222_222_222M, out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(1.111_111_111M, secondaryMap[key1]);
        Assert.Equal(2.222_222_222M, secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
    }

    [Fact]
    public void DecimalNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DecimalNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, null, out var _);

        bool result = secondaryMap.TryInsert(key2, 1.111_111_111M, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DecimalNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, 1.111_111_111M, out var previousValue2);

        Assert.True(result);
        Assert.Equal(null, previousValue1);
        Assert.Equal(null, previousValue2);
    }

    [Fact]
    public void DecimalNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, null, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, 1.111_111_111M, out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(null, secondaryMap[key1]);
        Assert.Equal(1.111_111_111M, secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, DateTime.Parse("2023-01-01"), out var previousValue);

        Assert.True(result);
        Assert.Equal(DateTime.Parse("2023-01-01"), previousValue);
    }

    [Fact]
    public void DateTimeWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, DateTime.Parse("2023-01-01"), out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, DateTime.Parse("2023-01-01"), out var _);

        bool result = secondaryMap.TryInsert(key2, DateTime.Parse("2023-02-01"), out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, DateTime.Parse("2023-01-01"), out var previousValue1);
        bool result = secondaryMap.TryInsert(key, DateTime.Parse("2023-02-01"), out var previousValue2);

        Assert.True(result);
        Assert.Equal(DateTime.Parse("2023-01-01"), previousValue1);
        Assert.Equal(DateTime.Parse("2023-01-01"), previousValue2);
    }

    [Fact]
    public void DateTimeWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, DateTime.Parse("2023-01-01"), out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, DateTime.Parse("2023-02-01"), out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(DateTime.Parse("2023-01-01"), secondaryMap[key1]);
        Assert.Equal(DateTime.Parse("2023-02-01"), secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
    }

    [Fact]
    public void DateTimeNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, null, out var _);

        bool result = secondaryMap.TryInsert(key2, DateTime.Parse("2023-01-01"), out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, DateTime.Parse("2023-01-01"), out var previousValue2);

        Assert.True(result);
        Assert.Equal(null, previousValue1);
        Assert.Equal(null, previousValue2);
    }

    [Fact]
    public void DateTimeNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, null, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, DateTime.Parse("2023-01-01"), out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(null, secondaryMap[key1]);
        Assert.Equal(DateTime.Parse("2023-01-01"), secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, new TimeSpan(00,00,00), out var previousValue);

        Assert.True(result);
        Assert.Equal(new TimeSpan(00,00,00), previousValue);
    }

    [Fact]
    public void TimeSpanWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, new TimeSpan(00,00,00), out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void TimeSpanWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, new TimeSpan(00,00,00), out var _);

        bool result = secondaryMap.TryInsert(key2, new TimeSpan(01,00,00), out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void TimeSpanWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, new TimeSpan(00,00,00), out var previousValue1);
        bool result = secondaryMap.TryInsert(key, new TimeSpan(01,00,00), out var previousValue2);

        Assert.True(result);
        Assert.Equal(new TimeSpan(00,00,00), previousValue1);
        Assert.Equal(new TimeSpan(00,00,00), previousValue2);
    }

    [Fact]
    public void TimeSpanWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, new TimeSpan(00,00,00), out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, new TimeSpan(01,00,00), out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(new TimeSpan(00,00,00), secondaryMap[key1]);
        Assert.Equal(new TimeSpan(01,00,00), secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
    }

    [Fact]
    public void TimeSpanNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void TimeSpanNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, null, out var _);

        bool result = secondaryMap.TryInsert(key2, new TimeSpan(00,00,00), out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void TimeSpanNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, new TimeSpan(00,00,00), out var previousValue2);

        Assert.True(result);
        Assert.Equal(null, previousValue1);
        Assert.Equal(null, previousValue2);
    }

    [Fact]
    public void TimeSpanNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, null, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, new TimeSpan(00,00,00), out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(null, secondaryMap[key1]);
        Assert.Equal(new TimeSpan(00,00,00), secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var previousValue);

        Assert.True(result);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), previousValue);
    }

    [Fact]
    public void GuidWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var _);

        bool result = secondaryMap.TryInsert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var previousValue1);
        bool result = secondaryMap.TryInsert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), out var previousValue2);

        Assert.True(result);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), previousValue1);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), previousValue2);
    }

    [Fact]
    public void GuidWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), secondaryMap[key1]);
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), secondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);

        bool result = secondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
    }

    [Fact]
    public void GuidNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = secondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.TryInsert(key1, null, out var _);

        bool result = secondaryMap.TryInsert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);

        secondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = secondaryMap.TryInsert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var previousValue2);

        Assert.True(result);
        Assert.Equal(null, previousValue1);
        Assert.Equal(null, previousValue2);
    }

    [Fact]
    public void GuidNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.TryInsert(key1, null, out _);

        Assert.Single(secondaryMap);

        secondaryMap.TryInsert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out _);

        Assert.Equal(2, secondaryMap.Count);
        Assert.Equal(null, secondaryMap[key1]);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), secondaryMap[key2]);
    }

}