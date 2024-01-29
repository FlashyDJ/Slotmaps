//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SecondaryMap;

public class Indexer
{
    [Fact]
    public void Get_InvalidKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[invalidKey]);
    }

    [Fact]
    public void Get_KeyNotFound_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 0);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetInt_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 10);

        var result = secondaryMap[key];

        Assert.Equal(10, result);
    }

    [Fact]
    public void GetInt_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 10);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void IntWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 10);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetInt_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = 10;

        Assert.Equal(10, secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetIntNullable_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetIntNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetIntNullable_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = null;

        Assert.Null(secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetString_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, "Value 1");

        var result = secondaryMap[key];

        Assert.Equal("Value 1", result);
    }

    [Fact]
    public void GetString_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, "Value 1");

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void StringWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, "Value 1");
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetString_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = "Value 1";

        Assert.Equal("Value 1", secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetStringNullable_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetStringNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetStringNullable_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = null;

        Assert.Null(secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetFloat_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1.1F);

        var result = secondaryMap[key];

        Assert.Equal(1.1F, result);
    }

    [Fact]
    public void GetFloat_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.1F);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void FloatWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.1F);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetFloat_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = 1.1F;

        Assert.Equal(1.1F, secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetFloatNullable_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetFloatNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetFloatNullable_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = null;

        Assert.Null(secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetDateTime_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        var result = secondaryMap[key];

        Assert.Equal(DateTime.Parse("2023-01-01"), result);
    }

    [Fact]
    public void GetDateTime_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetDateTime_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = DateTime.Parse("2023-01-01");

        Assert.Equal(DateTime.Parse("2023-01-01"), secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetDateTimeNullable_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetDateTimeNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetDateTimeNullable_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = null;

        Assert.Null(secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetGuid_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var result = secondaryMap[key];

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result);
    }

    [Fact]
    public void GetGuid_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void GuidWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetGuid_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE");

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetGuidNullable_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetGuidNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetGuidNullable_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = null;

        Assert.Null(secondaryMap[key]);
    }

}