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

        Assert.Null(result);
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

        Assert.Null(result);
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

        Assert.Null(result);
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

        Assert.Null(result);
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

        Assert.Null(result);
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