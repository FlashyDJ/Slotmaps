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

        Assert.Null(result);
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

        Assert.Null(result1);
        Assert.Null(result2);
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

        Assert.Null(firstInsert);
        Assert.Null(secondInsert);
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

        Assert.Null(result);
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

        Assert.Null(result1);
        Assert.Null(result2);
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

        Assert.Null(firstInsert);
        Assert.Null(secondInsert);
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

        Assert.Null(result);
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

        Assert.Null(result1);
        Assert.Null(result2);
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

        Assert.Null(firstInsert);
        Assert.Null(secondInsert);
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

        Assert.Null(result);
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

        Assert.Null(result1);
        Assert.Null(result2);
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

        Assert.Null(firstInsert);
        Assert.Null(secondInsert);
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

        Assert.Null(result);
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

        Assert.Null(result1);
        Assert.Null(result2);
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

        Assert.Null(firstInsert);
        Assert.Null(secondInsert);
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