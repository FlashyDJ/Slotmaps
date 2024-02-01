//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;

public class TryGet
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithValidKey_ReturnsTrueAndValue()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Insert(10);

        bool result = slotMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(10, value);
    }

    [Fact]
    public void IntWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void IntWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void IntWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void IntWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithValidKey_ReturnsTrueAndValue()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void IntNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void IntNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithValidKey_ReturnsTrueAndValue()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Insert("Value 1");

        bool result = slotMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal("Value 1", value);
    }

    [Fact]
    public void StringWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void StringWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void StringWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void StringWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithValidKey_ReturnsTrueAndValue()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void StringNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void StringNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithValidKey_ReturnsTrueAndValue()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Insert(1.1F);

        bool result = slotMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(1.1F, value);
    }

    [Fact]
    public void FloatWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void FloatWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void FloatWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void FloatWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithValidKey_ReturnsTrueAndValue()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void FloatNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void FloatNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithValidKey_ReturnsTrueAndValue()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));

        bool result = slotMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(DateTime.Parse("2023-01-01"), value);
    }

    [Fact]
    public void DateTimeWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DateTimeWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithValidKey_ReturnsTrueAndValue()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void DateTimeNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DateTimeNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithValidKey_ReturnsTrueAndValue()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        bool result = slotMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), value);
    }

    [Fact]
    public void GuidWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void GuidWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void GuidWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void GuidWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithValidKey_ReturnsTrueAndValue()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryGet(key, out var value);

        Assert.True(result);
        Assert.Null(value);
    }

    [Fact]
    public void GuidNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryGet(invalidKey, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void GuidNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryGet(key, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryGet(key2, out var value);

        Assert.False(result);
        Assert.Equal(default, value);
    }

}