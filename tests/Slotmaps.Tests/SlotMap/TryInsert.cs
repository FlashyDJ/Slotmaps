//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;

public class TryInsert
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Insert(10);

        bool result = slotMap.TryInsert(key, 20, out var newKey);

        Assert.True(result);
        Assert.Equal(20, slotMap[newKey]);
    }

    [Fact]
    public void IntWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, 10, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void IntWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, 20, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(10, slotMap[key1]);
    }

    [Fact]
    public void IntWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 20, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(10, slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryInsert(key, 10, out var newKey);

        Assert.True(result);
        Assert.Equal(10, slotMap[newKey]);
    }

    [Fact]
    public void IntNullableWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<int?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, null, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, 10, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 10, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Insert("Value 1");

        bool result = slotMap.TryInsert(key, "Value 2", out var newKey);

        Assert.True(result);
        Assert.Equal("Value 2", slotMap[newKey]);
    }

    [Fact]
    public void StringWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<string>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, "Value 1", out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void StringWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, "Value 2", out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal("Value 1", slotMap[key1]);
    }

    [Fact]
    public void StringWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, "Value 2", out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal("Value 1", slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryInsert(key, "Value 1", out var newKey);

        Assert.True(result);
        Assert.Equal("Value 1", slotMap[newKey]);
    }

    [Fact]
    public void StringNullableWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<string?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, null, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, "Value 1", out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, "Value 1", out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Insert(1.1F);

        bool result = slotMap.TryInsert(key, 2.2F, out var newKey);

        Assert.True(result);
        Assert.Equal(2.2F, slotMap[newKey]);
    }

    [Fact]
    public void FloatWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<float>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, 1.1F, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void FloatWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, 2.2F, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(1.1F, slotMap[key1]);
    }

    [Fact]
    public void FloatWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 2.2F, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(1.1F, slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryInsert(key, 1.1F, out var newKey);

        Assert.True(result);
        Assert.Equal(1.1F, slotMap[newKey]);
    }

    [Fact]
    public void FloatNullableWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<float?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, null, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, 1.1F, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 1.1F, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));

        bool result = slotMap.TryInsert(key, DateTime.Parse("2023-02-01"), out var newKey);

        Assert.True(result);
        Assert.Equal(DateTime.Parse("2023-02-01"), slotMap[newKey]);
    }

    [Fact]
    public void DateTimeWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<DateTime>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, DateTime.Parse("2023-01-01"), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, DateTime.Parse("2023-02-01"), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(DateTime.Parse("2023-01-01"), slotMap[key1]);
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, DateTime.Parse("2023-02-01"), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(DateTime.Parse("2023-01-01"), slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryInsert(key, DateTime.Parse("2023-01-01"), out var newKey);

        Assert.True(result);
        Assert.Equal(DateTime.Parse("2023-01-01"), slotMap[newKey]);
    }

    [Fact]
    public void DateTimeNullableWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<DateTime?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, null, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, DateTime.Parse("2023-01-01"), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, DateTime.Parse("2023-01-01"), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        bool result = slotMap.TryInsert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), out var newKey);

        Assert.True(result);
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), slotMap[newKey]);
    }

    [Fact]
    public void GuidWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<Guid>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void GuidWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), slotMap[key1]);
    }

    [Fact]
    public void GuidWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryInsert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var newKey);

        Assert.True(result);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), slotMap[newKey]);
    }

    [Fact]
    public void GuidNullableWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<Guid?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, null, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

}