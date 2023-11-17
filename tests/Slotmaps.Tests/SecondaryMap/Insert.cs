//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SecondaryMap;
public class Insert
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, 10);

        Assert.Equal(10, result);
    }

    [Fact]
    public void IntWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, 10));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void IntWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, 10);
        var result2 = secondaryMap.Insert(key2, 20);

        Assert.Equal(10, result1);
        Assert.Equal(10, result2);
        Assert.Equal(20, secondaryMap[key2]);
    }

    [Fact]
    public void IntWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, 10);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, 20));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void IntWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, 10);
        var secondInsert = secondaryMap.Insert(key, 20);

        Assert.Equal(10, firstInsert);
        Assert.Equal(10, secondInsert);
        Assert.Equal(20, secondaryMap.Get(key));
    }

    [Fact]
    public void ValidIntValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, 10);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, 20);
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertInt_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, 10);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, 20);
        Assert.Equal(20, secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void IntNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, 10);

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(10, secondaryMap[key2]);
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, 10));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void IntNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, 10);

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(10, secondaryMap.Get(key));
    }

    [Fact]
    public void ValidIntNullableValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, null);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, 10);
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertIntNullable_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, null);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, 10);
        Assert.Equal(10, secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, "Value 1");

        Assert.Equal("Value 1", result);
    }

    [Fact]
    public void StringWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, "Value 1"));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void StringWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, "Value 1");
        var result2 = secondaryMap.Insert(key2, "Value 2");

        Assert.Equal("Value 1", result1);
        Assert.Equal("Value 1", result2);
        Assert.Equal("Value 2", secondaryMap[key2]);
    }

    [Fact]
    public void StringWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, "Value 1");

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, "Value 2"));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void StringWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, "Value 1");
        var secondInsert = secondaryMap.Insert(key, "Value 2");

        Assert.Equal("Value 1", firstInsert);
        Assert.Equal("Value 1", secondInsert);
        Assert.Equal("Value 2", secondaryMap.Get(key));
    }

    [Fact]
    public void ValidStringValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, "Value 1");
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, "Value 2");
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertString_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, "Value 1");

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, "Value 2");
        Assert.Equal("Value 2", secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void StringNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, "Value 1");

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal("Value 1", secondaryMap[key2]);
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, "Value 1"));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void StringNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, "Value 1");

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal("Value 1", secondaryMap.Get(key));
    }

    [Fact]
    public void ValidStringNullableValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, null);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, "Value 1");
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertStringNullable_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, null);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, "Value 1");
        Assert.Equal("Value 1", secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, 1.11D);

        Assert.Equal(1.11D, result);
    }

    [Fact]
    public void DoubleWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, 1.11D));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void DoubleWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, 1.11D);
        var result2 = secondaryMap.Insert(key2, 2.22D);

        Assert.Equal(1.11D, result1);
        Assert.Equal(1.11D, result2);
        Assert.Equal(2.22D, secondaryMap[key2]);
    }

    [Fact]
    public void DoubleWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, 1.11D);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, 2.22D));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void DoubleWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, 1.11D);
        var secondInsert = secondaryMap.Insert(key, 2.22D);

        Assert.Equal(1.11D, firstInsert);
        Assert.Equal(1.11D, secondInsert);
        Assert.Equal(2.22D, secondaryMap.Get(key));
    }

    [Fact]
    public void ValidDoubleValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, 1.11D);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, 2.22D);
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertDouble_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, 1.11D);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, 2.22D);
        Assert.Equal(2.22D, secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void DoubleNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void DoubleNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, 1.11D);

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(1.11D, secondaryMap[key2]);
    }

    [Fact]
    public void DoubleNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, 1.11D));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void DoubleNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, 1.11D);

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(1.11D, secondaryMap.Get(key));
    }

    [Fact]
    public void ValidDoubleNullableValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, null);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, 1.11D);
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertDoubleNullable_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, null);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, 1.11D);
        Assert.Equal(1.11D, secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, true);

        Assert.Equal(true, result);
    }

    [Fact]
    public void BoolWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, true));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void BoolWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, true);
        var result2 = secondaryMap.Insert(key2, false);

        Assert.Equal(true, result1);
        Assert.Equal(true, result2);
        Assert.Equal(false, secondaryMap[key2]);
    }

    [Fact]
    public void BoolWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, true);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, false));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void BoolWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, true);
        var secondInsert = secondaryMap.Insert(key, false);

        Assert.Equal(true, firstInsert);
        Assert.Equal(true, secondInsert);
        Assert.Equal(false, secondaryMap.Get(key));
    }

    [Fact]
    public void ValidBoolValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, true);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, false);
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertBool_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, true);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, false);
        Assert.Equal(false, secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void BoolNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void BoolNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, true);

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(true, secondaryMap[key2]);
    }

    [Fact]
    public void BoolNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, true));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void BoolNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, true);

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(true, secondaryMap.Get(key));
    }

    [Fact]
    public void ValidBoolNullableValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, null);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, true);
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertBoolNullable_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, null);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, true);
        Assert.Equal(true, secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, 'A');

        Assert.Equal('A', result);
    }

    [Fact]
    public void CharWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, 'A'));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void CharWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, 'A');
        var result2 = secondaryMap.Insert(key2, 'B');

        Assert.Equal('A', result1);
        Assert.Equal('A', result2);
        Assert.Equal('B', secondaryMap[key2]);
    }

    [Fact]
    public void CharWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, 'A');

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, 'B'));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void CharWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, 'A');
        var secondInsert = secondaryMap.Insert(key, 'B');

        Assert.Equal('A', firstInsert);
        Assert.Equal('A', secondInsert);
        Assert.Equal('B', secondaryMap.Get(key));
    }

    [Fact]
    public void ValidCharValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, 'A');
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, 'B');
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertChar_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, 'A');

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, 'B');
        Assert.Equal('B', secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void CharNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void CharNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, 'A');

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal('A', secondaryMap[key2]);
    }

    [Fact]
    public void CharNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, 'A'));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void CharNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, 'A');

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal('A', secondaryMap.Get(key));
    }

    [Fact]
    public void ValidCharNullableValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, null);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, 'A');
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertCharNullable_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, null);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, 'A');
        Assert.Equal('A', secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, 1000_000_000_000L);

        Assert.Equal(1000_000_000_000L, result);
    }

    [Fact]
    public void LongWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, 1000_000_000_000L));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void LongWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, 1000_000_000_000L);
        var result2 = secondaryMap.Insert(key2, 2000_000_000_000L);

        Assert.Equal(1000_000_000_000L, result1);
        Assert.Equal(1000_000_000_000L, result2);
        Assert.Equal(2000_000_000_000L, secondaryMap[key2]);
    }

    [Fact]
    public void LongWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, 1000_000_000_000L);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, 2000_000_000_000L));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void LongWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, 1000_000_000_000L);
        var secondInsert = secondaryMap.Insert(key, 2000_000_000_000L);

        Assert.Equal(1000_000_000_000L, firstInsert);
        Assert.Equal(1000_000_000_000L, secondInsert);
        Assert.Equal(2000_000_000_000L, secondaryMap.Get(key));
    }

    [Fact]
    public void ValidLongValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, 1000_000_000_000L);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, 2000_000_000_000L);
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertLong_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, 1000_000_000_000L);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, 2000_000_000_000L);
        Assert.Equal(2000_000_000_000L, secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void LongNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void LongNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, 1000_000_000_000L);

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(1000_000_000_000L, secondaryMap[key2]);
    }

    [Fact]
    public void LongNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, 1000_000_000_000L));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void LongNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, 1000_000_000_000L);

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(1000_000_000_000L, secondaryMap.Get(key));
    }

    [Fact]
    public void ValidLongNullableValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, null);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, 1000_000_000_000L);
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertLongNullable_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, null);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, 1000_000_000_000L);
        Assert.Equal(1000_000_000_000L, secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, 1.1F);

        Assert.Equal(1.1F, result);
    }

    [Fact]
    public void FloatWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, 1.1F));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void FloatWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, 1.1F);
        var result2 = secondaryMap.Insert(key2, 2.2F);

        Assert.Equal(1.1F, result1);
        Assert.Equal(1.1F, result2);
        Assert.Equal(2.2F, secondaryMap[key2]);
    }

    [Fact]
    public void FloatWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, 1.1F);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, 2.2F));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void FloatWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, 1.1F);
        var secondInsert = secondaryMap.Insert(key, 2.2F);

        Assert.Equal(1.1F, firstInsert);
        Assert.Equal(1.1F, secondInsert);
        Assert.Equal(2.2F, secondaryMap.Get(key));
    }

    [Fact]
    public void ValidFloatValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, 1.1F);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, 2.2F);
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertFloat_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, 1.1F);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, 2.2F);
        Assert.Equal(2.2F, secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void FloatNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, 1.1F);

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(1.1F, secondaryMap[key2]);
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, 1.1F));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void FloatNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, 1.1F);

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(1.1F, secondaryMap.Get(key));
    }

    [Fact]
    public void ValidFloatNullableValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, null);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, 1.1F);
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertFloatNullable_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, null);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, 1.1F);
        Assert.Equal(1.1F, secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, 1.111_111_111M);

        Assert.Equal(1.111_111_111M, result);
    }

    [Fact]
    public void DecimalWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, 1.111_111_111M));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void DecimalWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, 1.111_111_111M);
        var result2 = secondaryMap.Insert(key2, 2.222_222_222M);

        Assert.Equal(1.111_111_111M, result1);
        Assert.Equal(1.111_111_111M, result2);
        Assert.Equal(2.222_222_222M, secondaryMap[key2]);
    }

    [Fact]
    public void DecimalWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, 1.111_111_111M);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, 2.222_222_222M));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void DecimalWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, 1.111_111_111M);
        var secondInsert = secondaryMap.Insert(key, 2.222_222_222M);

        Assert.Equal(1.111_111_111M, firstInsert);
        Assert.Equal(1.111_111_111M, secondInsert);
        Assert.Equal(2.222_222_222M, secondaryMap.Get(key));
    }

    [Fact]
    public void ValidDecimalValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, 1.111_111_111M);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, 2.222_222_222M);
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertDecimal_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, 1.111_111_111M);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, 2.222_222_222M);
        Assert.Equal(2.222_222_222M, secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void DecimalNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void DecimalNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, 1.111_111_111M);

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(1.111_111_111M, secondaryMap[key2]);
    }

    [Fact]
    public void DecimalNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, 1.111_111_111M));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void DecimalNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, 1.111_111_111M);

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(1.111_111_111M, secondaryMap.Get(key));
    }

    [Fact]
    public void ValidDecimalNullableValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, null);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, 1.111_111_111M);
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertDecimalNullable_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, null);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, 1.111_111_111M);
        Assert.Equal(1.111_111_111M, secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        Assert.Equal(DateTime.Parse("2023-01-01"), result);
    }

    [Fact]
    public void DateTimeWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, DateTime.Parse("2023-01-01")));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        var result2 = secondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));

        Assert.Equal(DateTime.Parse("2023-01-01"), result1);
        Assert.Equal(DateTime.Parse("2023-01-01"), result2);
        Assert.Equal(DateTime.Parse("2023-02-01"), secondaryMap[key2]);
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, DateTime.Parse("2023-02-01")));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void DateTimeWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, DateTime.Parse("2023-01-01"));
        var secondInsert = secondaryMap.Insert(key, DateTime.Parse("2023-02-01"));

        Assert.Equal(DateTime.Parse("2023-01-01"), firstInsert);
        Assert.Equal(DateTime.Parse("2023-01-01"), secondInsert);
        Assert.Equal(DateTime.Parse("2023-02-01"), secondaryMap.Get(key));
    }

    [Fact]
    public void ValidDateTimeValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertDateTime_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, DateTime.Parse("2023-02-01"));
        Assert.Equal(DateTime.Parse("2023-02-01"), secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void DateTimeNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(DateTime.Parse("2023-01-01"), secondaryMap[key2]);
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, DateTime.Parse("2023-01-01")));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void DateTimeNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(DateTime.Parse("2023-01-01"), secondaryMap.Get(key));
    }

    [Fact]
    public void ValidDateTimeNullableValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, null);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertDateTimeNullable_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, null);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, DateTime.Parse("2023-01-01"));
        Assert.Equal(DateTime.Parse("2023-01-01"), secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, new TimeSpan(00,00,00));

        Assert.Equal(new TimeSpan(00,00,00), result);
    }

    [Fact]
    public void TimeSpanWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, new TimeSpan(00,00,00)));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void TimeSpanWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, new TimeSpan(00,00,00));
        var result2 = secondaryMap.Insert(key2, new TimeSpan(01,00,00));

        Assert.Equal(new TimeSpan(00,00,00), result1);
        Assert.Equal(new TimeSpan(00,00,00), result2);
        Assert.Equal(new TimeSpan(01,00,00), secondaryMap[key2]);
    }

    [Fact]
    public void TimeSpanWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, new TimeSpan(00,00,00));

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, new TimeSpan(01,00,00)));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void TimeSpanWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, new TimeSpan(00,00,00));
        var secondInsert = secondaryMap.Insert(key, new TimeSpan(01,00,00));

        Assert.Equal(new TimeSpan(00,00,00), firstInsert);
        Assert.Equal(new TimeSpan(00,00,00), secondInsert);
        Assert.Equal(new TimeSpan(01,00,00), secondaryMap.Get(key));
    }

    [Fact]
    public void ValidTimeSpanValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, new TimeSpan(00,00,00));
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, new TimeSpan(01,00,00));
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertTimeSpan_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, new TimeSpan(00,00,00));

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, new TimeSpan(01,00,00));
        Assert.Equal(new TimeSpan(01,00,00), secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void TimeSpanNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void TimeSpanNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, new TimeSpan(00,00,00));

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(new TimeSpan(00,00,00), secondaryMap[key2]);
    }

    [Fact]
    public void TimeSpanNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, new TimeSpan(00,00,00)));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void TimeSpanNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, new TimeSpan(00,00,00));

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(new TimeSpan(00,00,00), secondaryMap.Get(key));
    }

    [Fact]
    public void ValidTimeSpanNullableValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, null);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, new TimeSpan(00,00,00));
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertTimeSpanNullable_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, null);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, new TimeSpan(00,00,00));
        Assert.Equal(new TimeSpan(00,00,00), secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result);
    }

    [Fact]
    public void GuidWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void GuidWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var result2 = secondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result1);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result2);
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), secondaryMap[key2]);
    }

    [Fact]
    public void GuidWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void GuidWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var secondInsert = secondaryMap.Insert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), firstInsert);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), secondInsert);
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), secondaryMap.Get(key));
    }

    [Fact]
    public void ValidGuidValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertGuid_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithValidKey_ReturnsInsertedValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);

        var result = secondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void GuidNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), secondaryMap[key2]);
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        secondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void GuidNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), secondaryMap.Get(key));
    }

    [Fact]
    public void ValidGuidNullableValues_CountIncrementsOnInsertion()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        secondaryMap.Insert(key1, null);
        Assert.Single(secondaryMap);

        secondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        Assert.Equal(2, secondaryMap.Count);
    }

    [Fact]
    public void ReInsertGuidNullable_ReturnsDefaultValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1,1);
        secondaryMap.Insert(key, null);

        var capacity = secondaryMap.Capacity;

        secondaryMap.Remove(key);
        Assert.Empty(secondaryMap);

        secondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), secondaryMap[key]);

        Assert.Equal(capacity, secondaryMap.Capacity);
        Assert.Single(secondaryMap);
    }
}