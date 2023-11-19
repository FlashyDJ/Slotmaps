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
        var key = slotMap.Add(10);

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
        var key1 = slotMap.Add(10);
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
        var key1 = slotMap.Add(10);
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
        var key = slotMap.Add(null);

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
        var key1 = slotMap.Add(null);
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
        var key1 = slotMap.Add(null);
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
        var key = slotMap.Add("Value 1");

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
        var key1 = slotMap.Add("Value 1");
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
        var key1 = slotMap.Add("Value 1");
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
        var key = slotMap.Add(null);

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
        var key1 = slotMap.Add(null);
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
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, "Value 1", out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<double>();
        var key = slotMap.Add(1.11D);

        bool result = slotMap.TryInsert(key, 2.22D, out var newKey);

        Assert.True(result);
        Assert.Equal(2.22D, slotMap[newKey]);
    }

    [Fact]
    public void DoubleWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<double>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, 1.11D, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void DoubleWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Add(1.11D);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, 2.22D, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(1.11D, slotMap[key1]);
    }

    [Fact]
    public void DoubleWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Add(1.11D);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 2.22D, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(1.11D, slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<double?>();
        var key = slotMap.Add(null);

        bool result = slotMap.TryInsert(key, 1.11D, out var newKey);

        Assert.True(result);
        Assert.Equal(1.11D, slotMap[newKey]);
    }

    [Fact]
    public void DoubleNullableWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<double?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, null, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void DoubleNullableWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, 1.11D, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    [Fact]
    public void DoubleNullableWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 1.11D, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<bool>();
        var key = slotMap.Add(true);

        bool result = slotMap.TryInsert(key, false, out var newKey);

        Assert.True(result);
        Assert.Equal(false, slotMap[newKey]);
    }

    [Fact]
    public void BoolWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<bool>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, true, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void BoolWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Add(true);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, false, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(true, slotMap[key1]);
    }

    [Fact]
    public void BoolWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Add(true);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, false, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(true, slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<bool?>();
        var key = slotMap.Add(null);

        bool result = slotMap.TryInsert(key, true, out var newKey);

        Assert.True(result);
        Assert.Equal(true, slotMap[newKey]);
    }

    [Fact]
    public void BoolNullableWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<bool?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, null, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void BoolNullableWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, true, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    [Fact]
    public void BoolNullableWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, true, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<char>();
        var key = slotMap.Add('A');

        bool result = slotMap.TryInsert(key, 'B', out var newKey);

        Assert.True(result);
        Assert.Equal('B', slotMap[newKey]);
    }

    [Fact]
    public void CharWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<char>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, 'A', out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void CharWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Add('A');
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, 'B', out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal('A', slotMap[key1]);
    }

    [Fact]
    public void CharWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Add('A');
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 'B', out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal('A', slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<char?>();
        var key = slotMap.Add(null);

        bool result = slotMap.TryInsert(key, 'A', out var newKey);

        Assert.True(result);
        Assert.Equal('A', slotMap[newKey]);
    }

    [Fact]
    public void CharNullableWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<char?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, null, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void CharNullableWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, 'A', out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    [Fact]
    public void CharNullableWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 'A', out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<long>();
        var key = slotMap.Add(1000_000_000_000L);

        bool result = slotMap.TryInsert(key, 2000_000_000_000L, out var newKey);

        Assert.True(result);
        Assert.Equal(2000_000_000_000L, slotMap[newKey]);
    }

    [Fact]
    public void LongWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<long>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, 1000_000_000_000L, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void LongWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Add(1000_000_000_000L);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, 2000_000_000_000L, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(1000_000_000_000L, slotMap[key1]);
    }

    [Fact]
    public void LongWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Add(1000_000_000_000L);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 2000_000_000_000L, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(1000_000_000_000L, slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<long?>();
        var key = slotMap.Add(null);

        bool result = slotMap.TryInsert(key, 1000_000_000_000L, out var newKey);

        Assert.True(result);
        Assert.Equal(1000_000_000_000L, slotMap[newKey]);
    }

    [Fact]
    public void LongNullableWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<long?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, null, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void LongNullableWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, 1000_000_000_000L, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    [Fact]
    public void LongNullableWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 1000_000_000_000L, out var newKey);

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
        var key = slotMap.Add(1.1F);

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
        var key1 = slotMap.Add(1.1F);
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
        var key1 = slotMap.Add(1.1F);
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
        var key = slotMap.Add(null);

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
        var key1 = slotMap.Add(null);
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
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 1.1F, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<decimal>();
        var key = slotMap.Add(1.111_111_111M);

        bool result = slotMap.TryInsert(key, 2.222_222_222M, out var newKey);

        Assert.True(result);
        Assert.Equal(2.222_222_222M, slotMap[newKey]);
    }

    [Fact]
    public void DecimalWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<decimal>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, 1.111_111_111M, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void DecimalWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Add(1.111_111_111M);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, 2.222_222_222M, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(1.111_111_111M, slotMap[key1]);
    }

    [Fact]
    public void DecimalWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Add(1.111_111_111M);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 2.222_222_222M, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(1.111_111_111M, slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = slotMap.Add(null);

        bool result = slotMap.TryInsert(key, 1.111_111_111M, out var newKey);

        Assert.True(result);
        Assert.Equal(1.111_111_111M, slotMap[newKey]);
    }

    [Fact]
    public void DecimalNullableWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<decimal?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, null, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void DecimalNullableWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, 1.111_111_111M, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    [Fact]
    public void DecimalNullableWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, 1.111_111_111M, out var newKey);

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
        var key = slotMap.Add(DateTime.Parse("2023-01-01"));

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
        var key1 = slotMap.Add(DateTime.Parse("2023-01-01"));
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
        var key1 = slotMap.Add(DateTime.Parse("2023-01-01"));
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
        var key = slotMap.Add(null);

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
        var key1 = slotMap.Add(null);
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
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, DateTime.Parse("2023-01-01"), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = slotMap.Add(new TimeSpan(00,00,00));

        bool result = slotMap.TryInsert(key, new TimeSpan(01,00,00), out var newKey);

        Assert.True(result);
        Assert.Equal(new TimeSpan(01,00,00), slotMap[newKey]);
    }

    [Fact]
    public void TimeSpanWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, new TimeSpan(00,00,00), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void TimeSpanWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Add(new TimeSpan(00,00,00));
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, new TimeSpan(01,00,00), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(new TimeSpan(00,00,00), slotMap[key1]);
    }

    [Fact]
    public void TimeSpanWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Add(new TimeSpan(00,00,00));
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, new TimeSpan(01,00,00), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Equal(new TimeSpan(00,00,00), slotMap[key1]);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithValidKey_ReturnsTrueAndNewKey()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = slotMap.Add(null);

        bool result = slotMap.TryInsert(key, new TimeSpan(00,00,00), out var newKey);

        Assert.True(result);
        Assert.Equal(new TimeSpan(00,00,00), slotMap[newKey]);
    }

    [Fact]
    public void TimeSpanNullableWithInvalidKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryInsert(invalidKey, null, out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
    }

    [Fact]
    public void TimeSpanNullableWithOlderVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryInsert(key2, new TimeSpan(00,00,00), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

    [Fact]
    public void TimeSpanNullableWithNewerVersionKey_ReturnsFalseAndNullKey()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, new TimeSpan(00,00,00), out var newKey);

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
        var key = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

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
        var key1 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
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
        var key1 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
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
        var key = slotMap.Add(null);

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
        var key1 = slotMap.Add(null);
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
        var key1 = slotMap.Add(null);
        var key2 = key1 with { Version = 2 };

        bool result = slotMap.TryInsert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), out var newKey);

        Assert.False(result);
        Assert.True(newKey.IsNull);
        Assert.Null(slotMap[key1]);
    }

}