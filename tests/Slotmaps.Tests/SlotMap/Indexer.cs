//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;

public class Indexer
{
    [Fact]
    public void Get_InvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap[invalidKey]);
    }

    [Fact]
    public void Get_KeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var key = new SlotKey(1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetInt_ValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Insert(10);

        var result = slotMap[key];

        Assert.Equal(10, result);
    }

    [Fact]
    public void GetInt_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = slotMap.Insert(key1, 10);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key1]);
    }

    [Fact]
    public void IntWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        
        Assert.Throws<KeyNotFoundException>(() => slotMap[key1 with { Version = 3 }]);
    }

    [Fact]
    public void SetInt_InvalidSlotKey_ThrowsArgumentException()
    {
        var slotMap = new SlotMap<int>();
        var key = new SlotKey(0, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key] = 10);
    }

    [Fact]
    public void SetAndGetInt_UpdateValue_ReturnsUpdatedValue()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Insert(10);

        slotMap[key] = 20;
        var value = slotMap[key with { Version = 3 }];

        Assert.Equal(20, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetIntNullable_ValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Insert(null);

        var result = slotMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetIntNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key1]);
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        
        Assert.Throws<KeyNotFoundException>(() => slotMap[key1 with { Version = 3 }]);
    }

    [Fact]
    public void SetIntNullable_InvalidSlotKey_ThrowsArgumentException()
    {
        var slotMap = new SlotMap<int?>();
        var key = new SlotKey(0, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key] = null);
    }

    [Fact]
    public void SetAndGetIntNullable_UpdateValue_ReturnsUpdatedValue()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Insert(null);

        slotMap[key] = 10;
        var value = slotMap[key with { Version = 3 }];

        Assert.Equal(10, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetString_ValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Insert("Value 1");

        var result = slotMap[key];

        Assert.Equal("Value 1", result);
    }

    [Fact]
    public void GetString_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = slotMap.Insert(key1, "Value 1");

        Assert.Throws<KeyNotFoundException>(() => slotMap[key1]);
    }

    [Fact]
    public void StringWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        
        Assert.Throws<KeyNotFoundException>(() => slotMap[key1 with { Version = 3 }]);
    }

    [Fact]
    public void SetString_InvalidSlotKey_ThrowsArgumentException()
    {
        var slotMap = new SlotMap<string>();
        var key = new SlotKey(0, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key] = "Value 1");
    }

    [Fact]
    public void SetAndGetString_UpdateValue_ReturnsUpdatedValue()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Insert("Value 1");

        slotMap[key] = "Value 2";
        var value = slotMap[key with { Version = 3 }];

        Assert.Equal("Value 2", value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetStringNullable_ValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Insert(null);

        var result = slotMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetStringNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key1]);
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        
        Assert.Throws<KeyNotFoundException>(() => slotMap[key1 with { Version = 3 }]);
    }

    [Fact]
    public void SetStringNullable_InvalidSlotKey_ThrowsArgumentException()
    {
        var slotMap = new SlotMap<string?>();
        var key = new SlotKey(0, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key] = null);
    }

    [Fact]
    public void SetAndGetStringNullable_UpdateValue_ReturnsUpdatedValue()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Insert(null);

        slotMap[key] = "Value 1";
        var value = slotMap[key with { Version = 3 }];

        Assert.Equal("Value 1", value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetFloat_ValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Insert(1.1F);

        var result = slotMap[key];

        Assert.Equal(1.1F, result);
    }

    [Fact]
    public void GetFloat_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = slotMap.Insert(key1, 1.1F);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key1]);
    }

    [Fact]
    public void FloatWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        
        Assert.Throws<KeyNotFoundException>(() => slotMap[key1 with { Version = 3 }]);
    }

    [Fact]
    public void SetFloat_InvalidSlotKey_ThrowsArgumentException()
    {
        var slotMap = new SlotMap<float>();
        var key = new SlotKey(0, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key] = 1.1F);
    }

    [Fact]
    public void SetAndGetFloat_UpdateValue_ReturnsUpdatedValue()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Insert(1.1F);

        slotMap[key] = 2.2F;
        var value = slotMap[key with { Version = 3 }];

        Assert.Equal(2.2F, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetFloatNullable_ValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Insert(null);

        var result = slotMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetFloatNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key1]);
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        
        Assert.Throws<KeyNotFoundException>(() => slotMap[key1 with { Version = 3 }]);
    }

    [Fact]
    public void SetFloatNullable_InvalidSlotKey_ThrowsArgumentException()
    {
        var slotMap = new SlotMap<float?>();
        var key = new SlotKey(0, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key] = null);
    }

    [Fact]
    public void SetAndGetFloatNullable_UpdateValue_ReturnsUpdatedValue()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Insert(null);

        slotMap[key] = 1.1F;
        var value = slotMap[key with { Version = 3 }];

        Assert.Equal(1.1F, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetDateTime_ValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));

        var result = slotMap[key];

        Assert.Equal(DateTime.Parse("2023-01-01"), result);
    }

    [Fact]
    public void GetDateTime_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Insert(key1, DateTime.Parse("2023-01-01"));

        Assert.Throws<KeyNotFoundException>(() => slotMap[key1]);
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        
        Assert.Throws<KeyNotFoundException>(() => slotMap[key1 with { Version = 3 }]);
    }

    [Fact]
    public void SetDateTime_InvalidSlotKey_ThrowsArgumentException()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = new SlotKey(0, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key] = DateTime.Parse("2023-01-01"));
    }

    [Fact]
    public void SetAndGetDateTime_UpdateValue_ReturnsUpdatedValue()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));

        slotMap[key] = DateTime.Parse("2023-02-01");
        var value = slotMap[key with { Version = 3 }];

        Assert.Equal(DateTime.Parse("2023-02-01"), value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetDateTimeNullable_ValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Insert(null);

        var result = slotMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetDateTimeNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key1]);
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        
        Assert.Throws<KeyNotFoundException>(() => slotMap[key1 with { Version = 3 }]);
    }

    [Fact]
    public void SetDateTimeNullable_InvalidSlotKey_ThrowsArgumentException()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = new SlotKey(0, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key] = null);
    }

    [Fact]
    public void SetAndGetDateTimeNullable_UpdateValue_ReturnsUpdatedValue()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Insert(null);

        slotMap[key] = DateTime.Parse("2023-01-01");
        var value = slotMap[key with { Version = 3 }];

        Assert.Equal(DateTime.Parse("2023-01-01"), value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetGuid_ValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var result = slotMap[key];

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result);
    }

    [Fact]
    public void GetGuid_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Throws<KeyNotFoundException>(() => slotMap[key1]);
    }

    [Fact]
    public void GuidWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        
        Assert.Throws<KeyNotFoundException>(() => slotMap[key1 with { Version = 3 }]);
    }

    [Fact]
    public void SetGuid_InvalidSlotKey_ThrowsArgumentException()
    {
        var slotMap = new SlotMap<Guid>();
        var key = new SlotKey(0, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key] = Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
    }

    [Fact]
    public void SetAndGetGuid_UpdateValue_ReturnsUpdatedValue()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        slotMap[key] = Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407");
        var value = slotMap[key with { Version = 3 }];

        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetGuidNullable_ValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Insert(null);

        var result = slotMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetGuidNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key1]);
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        
        Assert.Throws<KeyNotFoundException>(() => slotMap[key1 with { Version = 3 }]);
    }

    [Fact]
    public void SetGuidNullable_InvalidSlotKey_ThrowsArgumentException()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = new SlotKey(0, 1);

        Assert.Throws<KeyNotFoundException>(() => slotMap[key] = null);
    }

    [Fact]
    public void SetAndGetGuidNullable_UpdateValue_ReturnsUpdatedValue()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Insert(null);

        slotMap[key] = Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE");
        var value = slotMap[key with { Version = 3 }];

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), value);
    }

}