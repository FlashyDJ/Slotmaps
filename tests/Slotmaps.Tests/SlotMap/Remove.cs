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
        var key = slotMap.Insert(10);

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
        var key = slotMap.Insert(10);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void IntWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Insert(10);
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
        var key = slotMap.Insert(null);

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
        var key = slotMap.Insert(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Insert(null);
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
        var key = slotMap.Insert("Value 1");

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
        var key = slotMap.Insert("Value 1");
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void StringWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Insert("Value 1");
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
        var key = slotMap.Insert(null);

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
        var key = slotMap.Insert(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Insert(null);
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
        var key = slotMap.Insert(1.1F);

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
        var key = slotMap.Insert(1.1F);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void FloatWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Insert(1.1F);
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
        var key = slotMap.Insert(null);

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
        var key = slotMap.Insert(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Insert(null);
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
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));

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
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));
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
        var key = slotMap.Insert(null);

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
        var key = slotMap.Insert(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Insert(null);
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
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

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
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void GuidWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
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
        var key = slotMap.Insert(null);

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
        var key = slotMap.Insert(null);
        var key2 = key with { Version = 0 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Insert(null);
        var key2 = key with { Version = 2 };

        Assert.Throws<KeyNotFoundException>(() => slotMap.Remove(key2));
    }

}