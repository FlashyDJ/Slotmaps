//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SparseSecondaryMap;
public class Insert
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, 10);

        Assert.Equal(10, result);
    }

    [Fact]
    public void IntWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, 10));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void IntWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, 10);
        var result2 = sparseSecondaryMap.Insert(key2, 20);

        Assert.Equal(10, result1);
        Assert.Equal(10, result2);
        Assert.Equal(20, sparseSecondaryMap[key2]);
    }

    [Fact]
    public void IntWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, 10);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, 20));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void IntWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, 10);
        var secondInsert = sparseSecondaryMap.Insert(key, 20);

        Assert.Equal(10, firstInsert);
        Assert.Equal(10, secondInsert);
        Assert.Equal(20, sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidIntValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, 10);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, 20);
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertInt_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, 10);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, 20);
        Assert.Equal(20, sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void IntNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, null);
        var result2 = sparseSecondaryMap.Insert(key2, 10);

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(10, sparseSecondaryMap[key2]);
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, 10));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void IntNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, null);
        var secondInsert = sparseSecondaryMap.Insert(key, 10);

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(10, sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidIntNullableValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, null);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, 10);
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertIntNullable_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, null);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, 10);
        Assert.Equal(10, sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, "Value 1");

        Assert.Equal("Value 1", result);
    }

    [Fact]
    public void StringWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, "Value 1"));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void StringWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, "Value 1");
        var result2 = sparseSecondaryMap.Insert(key2, "Value 2");

        Assert.Equal("Value 1", result1);
        Assert.Equal("Value 1", result2);
        Assert.Equal("Value 2", sparseSecondaryMap[key2]);
    }

    [Fact]
    public void StringWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, "Value 1");

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, "Value 2"));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void StringWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, "Value 1");
        var secondInsert = sparseSecondaryMap.Insert(key, "Value 2");

        Assert.Equal("Value 1", firstInsert);
        Assert.Equal("Value 1", secondInsert);
        Assert.Equal("Value 2", sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidStringValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, "Value 1");
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, "Value 2");
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertString_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, "Value 1");

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, "Value 2");
        Assert.Equal("Value 2", sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void StringNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, null);
        var result2 = sparseSecondaryMap.Insert(key2, "Value 1");

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal("Value 1", sparseSecondaryMap[key2]);
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, "Value 1"));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void StringNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, null);
        var secondInsert = sparseSecondaryMap.Insert(key, "Value 1");

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal("Value 1", sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidStringNullableValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, null);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, "Value 1");
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertStringNullable_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, null);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, "Value 1");
        Assert.Equal("Value 1", sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, 1.11D);

        Assert.Equal(1.11D, result);
    }

    [Fact]
    public void DoubleWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, 1.11D));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void DoubleWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, 1.11D);
        var result2 = sparseSecondaryMap.Insert(key2, 2.22D);

        Assert.Equal(1.11D, result1);
        Assert.Equal(1.11D, result2);
        Assert.Equal(2.22D, sparseSecondaryMap[key2]);
    }

    [Fact]
    public void DoubleWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, 1.11D);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, 2.22D));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void DoubleWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, 1.11D);
        var secondInsert = sparseSecondaryMap.Insert(key, 2.22D);

        Assert.Equal(1.11D, firstInsert);
        Assert.Equal(1.11D, secondInsert);
        Assert.Equal(2.22D, sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidDoubleValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, 1.11D);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, 2.22D);
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertDouble_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, 1.11D);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, 2.22D);
        Assert.Equal(2.22D, sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void DoubleNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void DoubleNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, null);
        var result2 = sparseSecondaryMap.Insert(key2, 1.11D);

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(1.11D, sparseSecondaryMap[key2]);
    }

    [Fact]
    public void DoubleNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, 1.11D));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void DoubleNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, null);
        var secondInsert = sparseSecondaryMap.Insert(key, 1.11D);

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(1.11D, sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidDoubleNullableValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, null);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, 1.11D);
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertDoubleNullable_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, null);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, 1.11D);
        Assert.Equal(1.11D, sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, true);

        Assert.Equal(true, result);
    }

    [Fact]
    public void BoolWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, true));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void BoolWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, true);
        var result2 = sparseSecondaryMap.Insert(key2, false);

        Assert.Equal(true, result1);
        Assert.Equal(true, result2);
        Assert.Equal(false, sparseSecondaryMap[key2]);
    }

    [Fact]
    public void BoolWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, true);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, false));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void BoolWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, true);
        var secondInsert = sparseSecondaryMap.Insert(key, false);

        Assert.Equal(true, firstInsert);
        Assert.Equal(true, secondInsert);
        Assert.Equal(false, sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidBoolValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, true);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, false);
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertBool_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, true);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, false);
        Assert.Equal(false, sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void BoolNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void BoolNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, null);
        var result2 = sparseSecondaryMap.Insert(key2, true);

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(true, sparseSecondaryMap[key2]);
    }

    [Fact]
    public void BoolNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, true));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void BoolNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, null);
        var secondInsert = sparseSecondaryMap.Insert(key, true);

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(true, sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidBoolNullableValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, null);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, true);
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertBoolNullable_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, null);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, true);
        Assert.Equal(true, sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, 'A');

        Assert.Equal('A', result);
    }

    [Fact]
    public void CharWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, 'A'));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void CharWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, 'A');
        var result2 = sparseSecondaryMap.Insert(key2, 'B');

        Assert.Equal('A', result1);
        Assert.Equal('A', result2);
        Assert.Equal('B', sparseSecondaryMap[key2]);
    }

    [Fact]
    public void CharWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, 'A');

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, 'B'));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void CharWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, 'A');
        var secondInsert = sparseSecondaryMap.Insert(key, 'B');

        Assert.Equal('A', firstInsert);
        Assert.Equal('A', secondInsert);
        Assert.Equal('B', sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidCharValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, 'A');
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, 'B');
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertChar_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, 'A');

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, 'B');
        Assert.Equal('B', sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void CharNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void CharNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, null);
        var result2 = sparseSecondaryMap.Insert(key2, 'A');

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal('A', sparseSecondaryMap[key2]);
    }

    [Fact]
    public void CharNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, 'A'));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void CharNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, null);
        var secondInsert = sparseSecondaryMap.Insert(key, 'A');

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal('A', sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidCharNullableValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, null);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, 'A');
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertCharNullable_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, null);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, 'A');
        Assert.Equal('A', sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, 1000_000_000_000L);

        Assert.Equal(1000_000_000_000L, result);
    }

    [Fact]
    public void LongWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, 1000_000_000_000L));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void LongWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, 1000_000_000_000L);
        var result2 = sparseSecondaryMap.Insert(key2, 2000_000_000_000L);

        Assert.Equal(1000_000_000_000L, result1);
        Assert.Equal(1000_000_000_000L, result2);
        Assert.Equal(2000_000_000_000L, sparseSecondaryMap[key2]);
    }

    [Fact]
    public void LongWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, 1000_000_000_000L);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, 2000_000_000_000L));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void LongWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, 1000_000_000_000L);
        var secondInsert = sparseSecondaryMap.Insert(key, 2000_000_000_000L);

        Assert.Equal(1000_000_000_000L, firstInsert);
        Assert.Equal(1000_000_000_000L, secondInsert);
        Assert.Equal(2000_000_000_000L, sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidLongValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, 1000_000_000_000L);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, 2000_000_000_000L);
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertLong_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, 1000_000_000_000L);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, 2000_000_000_000L);
        Assert.Equal(2000_000_000_000L, sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void LongNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void LongNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, null);
        var result2 = sparseSecondaryMap.Insert(key2, 1000_000_000_000L);

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(1000_000_000_000L, sparseSecondaryMap[key2]);
    }

    [Fact]
    public void LongNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, 1000_000_000_000L));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void LongNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, null);
        var secondInsert = sparseSecondaryMap.Insert(key, 1000_000_000_000L);

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(1000_000_000_000L, sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidLongNullableValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, null);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, 1000_000_000_000L);
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertLongNullable_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, null);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, 1000_000_000_000L);
        Assert.Equal(1000_000_000_000L, sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, 1.1F);

        Assert.Equal(1.1F, result);
    }

    [Fact]
    public void FloatWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, 1.1F));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void FloatWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, 1.1F);
        var result2 = sparseSecondaryMap.Insert(key2, 2.2F);

        Assert.Equal(1.1F, result1);
        Assert.Equal(1.1F, result2);
        Assert.Equal(2.2F, sparseSecondaryMap[key2]);
    }

    [Fact]
    public void FloatWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, 1.1F);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, 2.2F));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void FloatWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, 1.1F);
        var secondInsert = sparseSecondaryMap.Insert(key, 2.2F);

        Assert.Equal(1.1F, firstInsert);
        Assert.Equal(1.1F, secondInsert);
        Assert.Equal(2.2F, sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidFloatValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, 1.1F);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, 2.2F);
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertFloat_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, 1.1F);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, 2.2F);
        Assert.Equal(2.2F, sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void FloatNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, null);
        var result2 = sparseSecondaryMap.Insert(key2, 1.1F);

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(1.1F, sparseSecondaryMap[key2]);
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, 1.1F));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void FloatNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, null);
        var secondInsert = sparseSecondaryMap.Insert(key, 1.1F);

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(1.1F, sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidFloatNullableValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, null);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, 1.1F);
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertFloatNullable_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, null);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, 1.1F);
        Assert.Equal(1.1F, sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, 1.111_111_111M);

        Assert.Equal(1.111_111_111M, result);
    }

    [Fact]
    public void DecimalWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, 1.111_111_111M));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void DecimalWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, 1.111_111_111M);
        var result2 = sparseSecondaryMap.Insert(key2, 2.222_222_222M);

        Assert.Equal(1.111_111_111M, result1);
        Assert.Equal(1.111_111_111M, result2);
        Assert.Equal(2.222_222_222M, sparseSecondaryMap[key2]);
    }

    [Fact]
    public void DecimalWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, 1.111_111_111M);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, 2.222_222_222M));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void DecimalWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, 1.111_111_111M);
        var secondInsert = sparseSecondaryMap.Insert(key, 2.222_222_222M);

        Assert.Equal(1.111_111_111M, firstInsert);
        Assert.Equal(1.111_111_111M, secondInsert);
        Assert.Equal(2.222_222_222M, sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidDecimalValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, 1.111_111_111M);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, 2.222_222_222M);
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertDecimal_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, 1.111_111_111M);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, 2.222_222_222M);
        Assert.Equal(2.222_222_222M, sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void DecimalNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void DecimalNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, null);
        var result2 = sparseSecondaryMap.Insert(key2, 1.111_111_111M);

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(1.111_111_111M, sparseSecondaryMap[key2]);
    }

    [Fact]
    public void DecimalNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, 1.111_111_111M));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void DecimalNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, null);
        var secondInsert = sparseSecondaryMap.Insert(key, 1.111_111_111M);

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(1.111_111_111M, sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidDecimalNullableValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, null);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, 1.111_111_111M);
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertDecimalNullable_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, null);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, 1.111_111_111M);
        Assert.Equal(1.111_111_111M, sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        Assert.Equal(DateTime.Parse("2023-01-01"), result);
    }

    [Fact]
    public void DateTimeWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, DateTime.Parse("2023-01-01")));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        var result2 = sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));

        Assert.Equal(DateTime.Parse("2023-01-01"), result1);
        Assert.Equal(DateTime.Parse("2023-01-01"), result2);
        Assert.Equal(DateTime.Parse("2023-02-01"), sparseSecondaryMap[key2]);
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-02-01")));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void DateTimeWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, DateTime.Parse("2023-01-01"));
        var secondInsert = sparseSecondaryMap.Insert(key, DateTime.Parse("2023-02-01"));

        Assert.Equal(DateTime.Parse("2023-01-01"), firstInsert);
        Assert.Equal(DateTime.Parse("2023-01-01"), secondInsert);
        Assert.Equal(DateTime.Parse("2023-02-01"), sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidDateTimeValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertDateTime_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, DateTime.Parse("2023-02-01"));
        Assert.Equal(DateTime.Parse("2023-02-01"), sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void DateTimeNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, null);
        var result2 = sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(DateTime.Parse("2023-01-01"), sparseSecondaryMap[key2]);
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-01-01")));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void DateTimeNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, null);
        var secondInsert = sparseSecondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(DateTime.Parse("2023-01-01"), sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidDateTimeNullableValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, null);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertDateTimeNullable_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, null);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, DateTime.Parse("2023-01-01"));
        Assert.Equal(DateTime.Parse("2023-01-01"), sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, new TimeSpan(00,00,00));

        Assert.Equal(new TimeSpan(00,00,00), result);
    }

    [Fact]
    public void TimeSpanWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, new TimeSpan(00,00,00)));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void TimeSpanWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, new TimeSpan(00,00,00));
        var result2 = sparseSecondaryMap.Insert(key2, new TimeSpan(01,00,00));

        Assert.Equal(new TimeSpan(00,00,00), result1);
        Assert.Equal(new TimeSpan(00,00,00), result2);
        Assert.Equal(new TimeSpan(01,00,00), sparseSecondaryMap[key2]);
    }

    [Fact]
    public void TimeSpanWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, new TimeSpan(00,00,00));

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, new TimeSpan(01,00,00)));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void TimeSpanWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, new TimeSpan(00,00,00));
        var secondInsert = sparseSecondaryMap.Insert(key, new TimeSpan(01,00,00));

        Assert.Equal(new TimeSpan(00,00,00), firstInsert);
        Assert.Equal(new TimeSpan(00,00,00), secondInsert);
        Assert.Equal(new TimeSpan(01,00,00), sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidTimeSpanValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, new TimeSpan(00,00,00));
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, new TimeSpan(01,00,00));
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertTimeSpan_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, new TimeSpan(00,00,00));

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, new TimeSpan(01,00,00));
        Assert.Equal(new TimeSpan(01,00,00), sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void TimeSpanNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void TimeSpanNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, null);
        var result2 = sparseSecondaryMap.Insert(key2, new TimeSpan(00,00,00));

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(new TimeSpan(00,00,00), sparseSecondaryMap[key2]);
    }

    [Fact]
    public void TimeSpanNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, new TimeSpan(00,00,00)));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void TimeSpanNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, null);
        var secondInsert = sparseSecondaryMap.Insert(key, new TimeSpan(00,00,00));

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(new TimeSpan(00,00,00), sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidTimeSpanNullableValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, null);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, new TimeSpan(00,00,00));
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertTimeSpanNullable_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, null);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, new TimeSpan(00,00,00));
        Assert.Equal(new TimeSpan(00,00,00), sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result);
    }

    [Fact]
    public void GuidWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void GuidWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var result2 = sparseSecondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result1);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result2);
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), sparseSecondaryMap[key2]);
    }

    [Fact]
    public void GuidWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407")));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void GuidWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var secondInsert = sparseSecondaryMap.Insert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), firstInsert);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), secondInsert);
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidGuidValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertGuid_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithValidKey_ReturnsInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);

        var result = sparseSecondaryMap.Insert(key, null);

        Assert.Equal(null, result);
    }

    [Fact]
    public void GuidNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(invalidKey, null));
        Assert.Equal("Invalid TKey", ex.Message);
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = sparseSecondaryMap.Insert(key1, null);
        var result2 = sparseSecondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Equal(null, result1);
        Assert.Equal(null, result2);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), sparseSecondaryMap[key2]);
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.Insert(key1, null);

        var ex = Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")));
        Assert.Equal("TKey is an older version", ex.Message);
    }

    [Fact]
    public void GuidNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);

        var firstInsert = sparseSecondaryMap.Insert(key, null);
        var secondInsert = sparseSecondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Equal(null, firstInsert);
        Assert.Equal(null, secondInsert);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), sparseSecondaryMap.Get(key));
    }

    [Fact]
    public void ValidGuidNullableValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.Insert(key1, null);
        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        Assert.Equal(2, sparseSecondaryMap.Count);
    }

    [Fact]
    public void ReInsertGuidNullable_ReturnsDefaultValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key = new SlotKey(1,1);
        sparseSecondaryMap.Insert(key, null);

        var capacity = sparseSecondaryMap.Capacity;

        sparseSecondaryMap.Remove(key);
        Assert.Empty(sparseSecondaryMap);

        sparseSecondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), sparseSecondaryMap[key]);

        Assert.Equal(capacity, sparseSecondaryMap.Capacity);
        Assert.Single(sparseSecondaryMap);
    }
}