//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SparseSecondaryMap;

public class TryInsert
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key = new SlotKey(1, 1);

        bool result = sparseSecondaryMap.TryInsert(key, 10, out var previousValue);

        Assert.True(result);
        Assert.Equal(10, previousValue);
    }

    [Fact]
    public void IntWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = sparseSecondaryMap.TryInsert(invalidKey, 10, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key1, 10, out var _);

        bool result = sparseSecondaryMap.TryInsert(key2, 20, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key, 10, out var previousValue1);
        bool result = sparseSecondaryMap.TryInsert(key, 20, out var previousValue2);

        Assert.True(result);
        Assert.Equal(10, previousValue1);
        Assert.Equal(10, previousValue2);
    }

    [Fact]
    public void IntWithValidValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.TryInsert(key1, 10, out _);

        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.TryInsert(key2, 20, out _);

        Assert.Equal(2, sparseSecondaryMap.Count);
        Assert.Equal(10, sparseSecondaryMap[key1]);
        Assert.Equal(20, sparseSecondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key = new SlotKey(1, 1);

        bool result = sparseSecondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Null(previousValue);
    }

    [Fact]
    public void IntNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = sparseSecondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key1, null, out var _);

        bool result = sparseSecondaryMap.TryInsert(key2, 10, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = sparseSecondaryMap.TryInsert(key, 10, out var previousValue2);

        Assert.True(result);
        Assert.Null(previousValue1);
        Assert.Null(previousValue2);
    }

    [Fact]
    public void IntNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.TryInsert(key1, null, out _);

        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.TryInsert(key2, 10, out _);

        Assert.Equal(2, sparseSecondaryMap.Count);
        Assert.Null(sparseSecondaryMap[key1]);
        Assert.Equal(10, sparseSecondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key = new SlotKey(1, 1);

        bool result = sparseSecondaryMap.TryInsert(key, "Value 1", out var previousValue);

        Assert.True(result);
        Assert.Equal("Value 1", previousValue);
    }

    [Fact]
    public void StringWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = sparseSecondaryMap.TryInsert(invalidKey, "Value 1", out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key1, "Value 1", out var _);

        bool result = sparseSecondaryMap.TryInsert(key2, "Value 2", out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key, "Value 1", out var previousValue1);
        bool result = sparseSecondaryMap.TryInsert(key, "Value 2", out var previousValue2);

        Assert.True(result);
        Assert.Equal("Value 1", previousValue1);
        Assert.Equal("Value 1", previousValue2);
    }

    [Fact]
    public void StringWithValidValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.TryInsert(key1, "Value 1", out _);

        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.TryInsert(key2, "Value 2", out _);

        Assert.Equal(2, sparseSecondaryMap.Count);
        Assert.Equal("Value 1", sparseSecondaryMap[key1]);
        Assert.Equal("Value 2", sparseSecondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key = new SlotKey(1, 1);

        bool result = sparseSecondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Null(previousValue);
    }

    [Fact]
    public void StringNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = sparseSecondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key1, null, out var _);

        bool result = sparseSecondaryMap.TryInsert(key2, "Value 1", out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = sparseSecondaryMap.TryInsert(key, "Value 1", out var previousValue2);

        Assert.True(result);
        Assert.Null(previousValue1);
        Assert.Null(previousValue2);
    }

    [Fact]
    public void StringNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.TryInsert(key1, null, out _);

        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.TryInsert(key2, "Value 1", out _);

        Assert.Equal(2, sparseSecondaryMap.Count);
        Assert.Null(sparseSecondaryMap[key1]);
        Assert.Equal("Value 1", sparseSecondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key = new SlotKey(1, 1);

        bool result = sparseSecondaryMap.TryInsert(key, 1.1F, out var previousValue);

        Assert.True(result);
        Assert.Equal(1.1F, previousValue);
    }

    [Fact]
    public void FloatWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = sparseSecondaryMap.TryInsert(invalidKey, 1.1F, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key1, 1.1F, out var _);

        bool result = sparseSecondaryMap.TryInsert(key2, 2.2F, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key, 1.1F, out var previousValue1);
        bool result = sparseSecondaryMap.TryInsert(key, 2.2F, out var previousValue2);

        Assert.True(result);
        Assert.Equal(1.1F, previousValue1);
        Assert.Equal(1.1F, previousValue2);
    }

    [Fact]
    public void FloatWithValidValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.TryInsert(key1, 1.1F, out _);

        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.TryInsert(key2, 2.2F, out _);

        Assert.Equal(2, sparseSecondaryMap.Count);
        Assert.Equal(1.1F, sparseSecondaryMap[key1]);
        Assert.Equal(2.2F, sparseSecondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key = new SlotKey(1, 1);

        bool result = sparseSecondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Null(previousValue);
    }

    [Fact]
    public void FloatNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = sparseSecondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key1, null, out var _);

        bool result = sparseSecondaryMap.TryInsert(key2, 1.1F, out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = sparseSecondaryMap.TryInsert(key, 1.1F, out var previousValue2);

        Assert.True(result);
        Assert.Null(previousValue1);
        Assert.Null(previousValue2);
    }

    [Fact]
    public void FloatNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.TryInsert(key1, null, out _);

        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.TryInsert(key2, 1.1F, out _);

        Assert.Equal(2, sparseSecondaryMap.Count);
        Assert.Null(sparseSecondaryMap[key1]);
        Assert.Equal(1.1F, sparseSecondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);

        bool result = sparseSecondaryMap.TryInsert(key, DateTime.Parse("2023-01-01"), out var previousValue);

        Assert.True(result);
        Assert.Equal(DateTime.Parse("2023-01-01"), previousValue);
    }

    [Fact]
    public void DateTimeWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = sparseSecondaryMap.TryInsert(invalidKey, DateTime.Parse("2023-01-01"), out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key1, DateTime.Parse("2023-01-01"), out var _);

        bool result = sparseSecondaryMap.TryInsert(key2, DateTime.Parse("2023-02-01"), out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key, DateTime.Parse("2023-01-01"), out var previousValue1);
        bool result = sparseSecondaryMap.TryInsert(key, DateTime.Parse("2023-02-01"), out var previousValue2);

        Assert.True(result);
        Assert.Equal(DateTime.Parse("2023-01-01"), previousValue1);
        Assert.Equal(DateTime.Parse("2023-01-01"), previousValue2);
    }

    [Fact]
    public void DateTimeWithValidValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.TryInsert(key1, DateTime.Parse("2023-01-01"), out _);

        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.TryInsert(key2, DateTime.Parse("2023-02-01"), out _);

        Assert.Equal(2, sparseSecondaryMap.Count);
        Assert.Equal(DateTime.Parse("2023-01-01"), sparseSecondaryMap[key1]);
        Assert.Equal(DateTime.Parse("2023-02-01"), sparseSecondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);

        bool result = sparseSecondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Null(previousValue);
    }

    [Fact]
    public void DateTimeNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = sparseSecondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key1, null, out var _);

        bool result = sparseSecondaryMap.TryInsert(key2, DateTime.Parse("2023-01-01"), out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = sparseSecondaryMap.TryInsert(key, DateTime.Parse("2023-01-01"), out var previousValue2);

        Assert.True(result);
        Assert.Null(previousValue1);
        Assert.Null(previousValue2);
    }

    [Fact]
    public void DateTimeNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.TryInsert(key1, null, out _);

        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.TryInsert(key2, DateTime.Parse("2023-01-01"), out _);

        Assert.Equal(2, sparseSecondaryMap.Count);
        Assert.Null(sparseSecondaryMap[key1]);
        Assert.Equal(DateTime.Parse("2023-01-01"), sparseSecondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key = new SlotKey(1, 1);

        bool result = sparseSecondaryMap.TryInsert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var previousValue);

        Assert.True(result);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), previousValue);
    }

    [Fact]
    public void GuidWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = sparseSecondaryMap.TryInsert(invalidKey, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var _);

        bool result = sparseSecondaryMap.TryInsert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var previousValue1);
        bool result = sparseSecondaryMap.TryInsert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), out var previousValue2);

        Assert.True(result);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), previousValue1);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), previousValue2);
    }

    [Fact]
    public void GuidWithValidValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.TryInsert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out _);

        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.TryInsert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), out _);

        Assert.Equal(2, sparseSecondaryMap.Count);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), sparseSecondaryMap[key1]);
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), sparseSecondaryMap[key2]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithValidKey_ReturnsTrueAndInsertedValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);

        bool result = sparseSecondaryMap.TryInsert(key, null, out var previousValue);

        Assert.True(result);
        Assert.Null(previousValue);
    }

    [Fact]
    public void GuidNullableWithInvalidKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = sparseSecondaryMap.TryInsert(invalidKey, null, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ReturnsFalseAndDefaultPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key1, null, out var _);

        bool result = sparseSecondaryMap.TryInsert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var previousValue);
        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidNullableWithSameKey_ReturnsTrueAndPreviousValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);

        sparseSecondaryMap.TryInsert(key, null, out var previousValue1);
        bool result = sparseSecondaryMap.TryInsert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var previousValue2);

        Assert.True(result);
        Assert.Null(previousValue1);
        Assert.Null(previousValue2);
    }

    [Fact]
    public void GuidNullableWithValidValues_CountIncrementsOnInsertion()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);

        sparseSecondaryMap.TryInsert(key1, null, out _);

        Assert.Single(sparseSecondaryMap);

        sparseSecondaryMap.TryInsert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out _);

        Assert.Equal(2, sparseSecondaryMap.Count);
        Assert.Null(sparseSecondaryMap[key1]);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), sparseSecondaryMap[key2]);
    }

}