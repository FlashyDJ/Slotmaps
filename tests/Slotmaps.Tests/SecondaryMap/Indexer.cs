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
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetDouble_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1.11D);

        var result = secondaryMap[key];

        Assert.Equal(1.11D, result);
    }

    [Fact]
    public void GetDouble_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.11D);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void DoubleWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.11D);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetDouble_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = 1.11D;

        Assert.Equal(1.11D, secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetDoubleNullable_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetDoubleNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void DoubleNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetDoubleNullable_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = null;

        Assert.Null(secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetBool_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, true);

        var result = secondaryMap[key];

        Assert.Equal(true, result);
    }

    [Fact]
    public void GetBool_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, true);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void BoolWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, true);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetBool_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = true;

        Assert.Equal(true, secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetBoolNullable_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetBoolNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void BoolNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetBoolNullable_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = null;

        Assert.Null(secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetChar_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 'A');

        var result = secondaryMap[key];

        Assert.Equal('A', result);
    }

    [Fact]
    public void GetChar_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 'A');

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void CharWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 'A');
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetChar_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = 'A';

        Assert.Equal('A', secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetCharNullable_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetCharNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void CharNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetCharNullable_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = null;

        Assert.Null(secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetLong_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1000_000_000_000L);

        var result = secondaryMap[key];

        Assert.Equal(1000_000_000_000L, result);
    }

    [Fact]
    public void GetLong_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1000_000_000_000L);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void LongWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1000_000_000_000L);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetLong_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = 1000_000_000_000L;

        Assert.Equal(1000_000_000_000L, secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetLongNullable_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetLongNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void LongNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetLongNullable_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<long?>();
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
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetDecimal_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 1.111_111_111M);

        var result = secondaryMap[key];

        Assert.Equal(1.111_111_111M, result);
    }

    [Fact]
    public void GetDecimal_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.111_111_111M);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void DecimalWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, 1.111_111_111M);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetDecimal_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = 1.111_111_111M;

        Assert.Equal(1.111_111_111M, secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetDecimalNullable_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetDecimalNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void DecimalNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetDecimalNullable_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
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
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetTimeSpan_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, new TimeSpan(00,00,00));

        var result = secondaryMap[key];

        Assert.Equal(new TimeSpan(00,00,00), result);
    }

    [Fact]
    public void GetTimeSpan_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void TimeSpanWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetTimeSpan_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);

        secondaryMap[key] = new TimeSpan(00,00,00);

        Assert.Equal(new TimeSpan(00,00,00), secondaryMap[key]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GetTimeSpanNullable_ValidKey_ReturnsValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, null);

        var result = secondaryMap[key];

        Assert.Null(result);
    }

    [Fact]
    public void GetTimeSpanNullable_OlderVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 2);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void TimeSpanNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 0);
        var key2 = new SlotKey(1, 1);
        secondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => secondaryMap[key2]);
    }

    [Fact]
    public void SetTimeSpanNullable_InsertsValue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
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