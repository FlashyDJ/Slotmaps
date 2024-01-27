//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;

public class TryRemove
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Insert(10);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(10, previousValue);
        Assert.Equal(10, previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void IntWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
        Assert.Null(previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void IntNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Insert("Value 1");

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal("Value 1", previousValue);
        Assert.Equal("Value 1", previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void StringWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
        Assert.Null(previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void StringNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<double>();
        var key = slotMap.Insert(1.11D);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(1.11D, previousValue);
        Assert.Equal(1.11D, previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void DoubleWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<double>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DoubleWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<double>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DoubleWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Insert(1.11D);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DoubleWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Insert(1.11D);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<double?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
        Assert.Null(previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void DoubleNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<double?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DoubleNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<double?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DoubleNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DoubleNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<bool>();
        var key = slotMap.Insert(true);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(true, previousValue);
        Assert.Equal(true, previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void BoolWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<bool>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void BoolWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<bool>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void BoolWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Insert(true);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void BoolWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Insert(true);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<bool?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
        Assert.Null(previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void BoolNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<bool?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void BoolNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<bool?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void BoolNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void BoolNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<char>();
        var key = slotMap.Insert('A');

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal('A', previousValue);
        Assert.Equal('A', previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void CharWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<char>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void CharWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<char>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void CharWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Insert('A');
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void CharWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Insert('A');
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<char?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
        Assert.Null(previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void CharNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<char?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void CharNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<char?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void CharNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void CharNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<long>();
        var key = slotMap.Insert(1000_000_000_000L);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(1000_000_000_000L, previousValue);
        Assert.Equal(1000_000_000_000L, previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void LongWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<long>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void LongWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<long>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void LongWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Insert(1000_000_000_000L);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void LongWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Insert(1000_000_000_000L);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<long?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
        Assert.Null(previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void LongNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<long?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void LongNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<long?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void LongNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void LongNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Insert(1.1F);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(1.1F, previousValue);
        Assert.Equal(1.1F, previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void FloatWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
        Assert.Null(previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void FloatNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<decimal>();
        var key = slotMap.Insert(1.111_111_111M);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(1.111_111_111M, previousValue);
        Assert.Equal(1.111_111_111M, previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void DecimalWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<decimal>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DecimalWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<decimal>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DecimalWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Insert(1.111_111_111M);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DecimalWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Insert(1.111_111_111M);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
        Assert.Null(previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void DecimalNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<decimal?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DecimalNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DecimalNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DecimalNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(DateTime.Parse("2023-01-01"), previousValue);
        Assert.Equal(DateTime.Parse("2023-01-01"), previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void DateTimeWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
        Assert.Null(previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void DateTimeNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = slotMap.Insert(new TimeSpan(00,00,00));

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(new TimeSpan(00,00,00), previousValue);
        Assert.Equal(new TimeSpan(00,00,00), previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void TimeSpanWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void TimeSpanWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void TimeSpanWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Insert(new TimeSpan(00,00,00));
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void TimeSpanWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Insert(new TimeSpan(00,00,00));
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
        Assert.Null(previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void TimeSpanNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void TimeSpanNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void TimeSpanNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void TimeSpanNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), previousValue);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void GuidWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithValidKey_RemovesAndReturnsTrueAndPreviousValue()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Insert(null);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.True(result);
        Assert.Equal(null, previousValue);
        Assert.Null(previousValue);
        Assert.False(slotMap.TryGet(key, out _));
    }

    [Fact]
    public void GuidNullableWithInvalidKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid?>();
        var invalidKey = new SlotKey(-1, 0);

        bool result = slotMap.TryRemove(invalidKey, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidNullableWithKeyNotFound_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = new SlotKey(1, 1);

        bool result = slotMap.TryRemove(key, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 0 };

        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ReturnsFalseAndDefault()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = key1 with { Version = 2 };
        
        bool result = slotMap.TryRemove(key2, out var previousValue);

        Assert.False(result);
        Assert.Equal(default, previousValue);
    }

}