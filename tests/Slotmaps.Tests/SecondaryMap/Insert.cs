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

        Assert.Null(result);
    }

    [Fact]
    public void IntNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, 10);

        Assert.Null(result1);
        Assert.Null(result2);
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
    }

    [Fact]
    public void IntNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, 10);

        Assert.Null(firstInsert);
        Assert.Null(secondInsert);
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

        Assert.Null(result);
    }

    [Fact]
    public void StringNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, "Value 1");

        Assert.Null(result1);
        Assert.Null(result2);
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
    }

    [Fact]
    public void StringNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, "Value 1");

        Assert.Null(firstInsert);
        Assert.Null(secondInsert);
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

        Assert.Null(result);
    }

    [Fact]
    public void FloatNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, 1.1F);

        Assert.Null(result1);
        Assert.Null(result2);
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
    }

    [Fact]
    public void FloatNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, 1.1F);

        Assert.Null(firstInsert);
        Assert.Null(secondInsert);
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

        Assert.Null(result);
    }

    [Fact]
    public void DateTimeNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));

        Assert.Null(result1);
        Assert.Null(result2);
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
    }

    [Fact]
    public void DateTimeNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        Assert.Null(firstInsert);
        Assert.Null(secondInsert);
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

        Assert.Null(result);
    }

    [Fact]
    public void GuidNullableWithInvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var invalidKey = new SlotKey(-1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => secondaryMap.Insert(invalidKey, null));
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ReturnsOldValueAndUpdatesValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);

        var result1 = secondaryMap.Insert(key1, null);
        var result2 = secondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Null(result1);
        Assert.Null(result2);
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
    }

    [Fact]
    public void GuidNullableWithSameKey_ReplacesAndReturnsPreviousValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);

        var firstInsert = secondaryMap.Insert(key, null);
        var secondInsert = secondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Null(firstInsert);
        Assert.Null(secondInsert);
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