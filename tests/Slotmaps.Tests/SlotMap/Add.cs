//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SlotMap;
public class Add
{
    [Fact]
    public void InvalidSlotKey_ThrowsArgumentException()
    {
        var slotMap = new SlotMap<string>();
        var key = SlotKey.Null();

        Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, "Value"));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidIntValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<int>();

        var key = slotMap.Add(10);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(10, slotMap.Get(key));
    }

    [Fact]
    public void AddIntElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<int>(2);

        var key1 = slotMap.Add(10);
        var key2 = slotMap.Add(20);
        var key3 = slotMap.Add(30);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(10, slotMap.Get(key1));
        Assert.Equal(20, slotMap.Get(key2));
        Assert.Equal(30, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void IntWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<int>();

        var key = slotMap.Add(10);
        var newKey = slotMap.Insert(key, 20);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(20, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidIntNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<int?>();

        var key = slotMap.Add(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void AddIntNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<int?>(2);

        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(10);
        var key3 = slotMap.Add(20);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(10, slotMap.Get(key2));
        Assert.Equal(20, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void IntNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<int?>();

        var key = slotMap.Add(null);
        var newKey = slotMap.Insert(key, 10);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(10, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidStringValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<string>();

        var key = slotMap.Add("Value 1");

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal("Value 1", slotMap.Get(key));
    }

    [Fact]
    public void AddStringElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<string>(2);

        var key1 = slotMap.Add("Value 1");
        var key2 = slotMap.Add("Value 2");
        var key3 = slotMap.Add("Value 3");

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal("Value 1", slotMap.Get(key1));
        Assert.Equal("Value 2", slotMap.Get(key2));
        Assert.Equal("Value 3", slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void StringWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<string>();

        var key = slotMap.Add("Value 1");
        var newKey = slotMap.Insert(key, "Value 2");
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal("Value 2", value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidStringNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<string?>();

        var key = slotMap.Add(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void AddStringNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<string?>(2);

        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add("Value 1");
        var key3 = slotMap.Add("Value 2");

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal("Value 1", slotMap.Get(key2));
        Assert.Equal("Value 2", slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void StringNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<string?>();

        var key = slotMap.Add(null);
        var newKey = slotMap.Insert(key, "Value 1");
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal("Value 1", value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidDoubleValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<double>();

        var key = slotMap.Add(1.11D);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(1.11D, slotMap.Get(key));
    }

    [Fact]
    public void AddDoubleElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<double>(2);

        var key1 = slotMap.Add(1.11D);
        var key2 = slotMap.Add(2.22D);
        var key3 = slotMap.Add(3.33D);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(1.11D, slotMap.Get(key1));
        Assert.Equal(2.22D, slotMap.Get(key2));
        Assert.Equal(3.33D, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void DoubleWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<double>();

        var key = slotMap.Add(1.11D);
        var newKey = slotMap.Insert(key, 2.22D);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(2.22D, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidDoubleNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<double?>();

        var key = slotMap.Add(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void AddDoubleNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<double?>(2);

        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.11D);
        var key3 = slotMap.Add(2.22D);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(1.11D, slotMap.Get(key2));
        Assert.Equal(2.22D, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void DoubleNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<double?>();

        var key = slotMap.Add(null);
        var newKey = slotMap.Insert(key, 1.11D);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(1.11D, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidBoolValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<bool>();

        var key = slotMap.Add(true);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(true, slotMap.Get(key));
    }

    [Fact]
    public void AddBoolElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<bool>(2);

        var key1 = slotMap.Add(true);
        var key2 = slotMap.Add(false);
        var key3 = slotMap.Add(true);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(true, slotMap.Get(key1));
        Assert.Equal(false, slotMap.Get(key2));
        Assert.Equal(true, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void BoolWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<bool>();

        var key = slotMap.Add(true);
        var newKey = slotMap.Insert(key, false);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(false, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidBoolNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<bool?>();

        var key = slotMap.Add(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void AddBoolNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<bool?>(2);

        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(true);
        var key3 = slotMap.Add(false);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(true, slotMap.Get(key2));
        Assert.Equal(false, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void BoolNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<bool?>();

        var key = slotMap.Add(null);
        var newKey = slotMap.Insert(key, true);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(true, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidCharValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<char>();

        var key = slotMap.Add('A');

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal('A', slotMap.Get(key));
    }

    [Fact]
    public void AddCharElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<char>(2);

        var key1 = slotMap.Add('A');
        var key2 = slotMap.Add('B');
        var key3 = slotMap.Add('C');

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal('A', slotMap.Get(key1));
        Assert.Equal('B', slotMap.Get(key2));
        Assert.Equal('C', slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void CharWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<char>();

        var key = slotMap.Add('A');
        var newKey = slotMap.Insert(key, 'B');
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal('B', value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidCharNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<char?>();

        var key = slotMap.Add(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void AddCharNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<char?>(2);

        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add('A');
        var key3 = slotMap.Add('B');

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal('A', slotMap.Get(key2));
        Assert.Equal('B', slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void CharNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<char?>();

        var key = slotMap.Add(null);
        var newKey = slotMap.Insert(key, 'A');
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal('A', value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidLongValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<long>();

        var key = slotMap.Add(1000_000_000_000L);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(1000_000_000_000L, slotMap.Get(key));
    }

    [Fact]
    public void AddLongElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<long>(2);

        var key1 = slotMap.Add(1000_000_000_000L);
        var key2 = slotMap.Add(2000_000_000_000L);
        var key3 = slotMap.Add(3000_000_000_000L);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(1000_000_000_000L, slotMap.Get(key1));
        Assert.Equal(2000_000_000_000L, slotMap.Get(key2));
        Assert.Equal(3000_000_000_000L, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void LongWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<long>();

        var key = slotMap.Add(1000_000_000_000L);
        var newKey = slotMap.Insert(key, 2000_000_000_000L);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(2000_000_000_000L, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidLongNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<long?>();

        var key = slotMap.Add(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void AddLongNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<long?>(2);

        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1000_000_000_000L);
        var key3 = slotMap.Add(2000_000_000_000L);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(1000_000_000_000L, slotMap.Get(key2));
        Assert.Equal(2000_000_000_000L, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void LongNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<long?>();

        var key = slotMap.Add(null);
        var newKey = slotMap.Insert(key, 1000_000_000_000L);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(1000_000_000_000L, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidFloatValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<float>();

        var key = slotMap.Add(1.1F);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(1.1F, slotMap.Get(key));
    }

    [Fact]
    public void AddFloatElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<float>(2);

        var key1 = slotMap.Add(1.1F);
        var key2 = slotMap.Add(2.2F);
        var key3 = slotMap.Add(3.3F);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(1.1F, slotMap.Get(key1));
        Assert.Equal(2.2F, slotMap.Get(key2));
        Assert.Equal(3.3F, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void FloatWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<float>();

        var key = slotMap.Add(1.1F);
        var newKey = slotMap.Insert(key, 2.2F);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(2.2F, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidFloatNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<float?>();

        var key = slotMap.Add(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void AddFloatNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<float?>(2);

        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.1F);
        var key3 = slotMap.Add(2.2F);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(1.1F, slotMap.Get(key2));
        Assert.Equal(2.2F, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void FloatNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<float?>();

        var key = slotMap.Add(null);
        var newKey = slotMap.Insert(key, 1.1F);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(1.1F, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidDecimalValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<decimal>();

        var key = slotMap.Add(1.111_111_111M);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(1.111_111_111M, slotMap.Get(key));
    }

    [Fact]
    public void AddDecimalElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<decimal>(2);

        var key1 = slotMap.Add(1.111_111_111M);
        var key2 = slotMap.Add(2.222_222_222M);
        var key3 = slotMap.Add(3.333_333_333M);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(1.111_111_111M, slotMap.Get(key1));
        Assert.Equal(2.222_222_222M, slotMap.Get(key2));
        Assert.Equal(3.333_333_333M, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void DecimalWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<decimal>();

        var key = slotMap.Add(1.111_111_111M);
        var newKey = slotMap.Insert(key, 2.222_222_222M);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(2.222_222_222M, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidDecimalNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<decimal?>();

        var key = slotMap.Add(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void AddDecimalNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<decimal?>(2);

        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.111_111_111M);
        var key3 = slotMap.Add(2.222_222_222M);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(1.111_111_111M, slotMap.Get(key2));
        Assert.Equal(2.222_222_222M, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void DecimalNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<decimal?>();

        var key = slotMap.Add(null);
        var newKey = slotMap.Insert(key, 1.111_111_111M);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(1.111_111_111M, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidDateTimeValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<DateTime>();

        var key = slotMap.Add(DateTime.Parse("2023-01-01"));

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(DateTime.Parse("2023-01-01"), slotMap.Get(key));
    }

    [Fact]
    public void AddDateTimeElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<DateTime>(2);

        var key1 = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Add(DateTime.Parse("2023-02-01"));
        var key3 = slotMap.Add(DateTime.Parse("2023-03-01"));

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(DateTime.Parse("2023-01-01"), slotMap.Get(key1));
        Assert.Equal(DateTime.Parse("2023-02-01"), slotMap.Get(key2));
        Assert.Equal(DateTime.Parse("2023-03-01"), slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void DateTimeWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<DateTime>();

        var key = slotMap.Add(DateTime.Parse("2023-01-01"));
        var newKey = slotMap.Insert(key, DateTime.Parse("2023-02-01"));
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(DateTime.Parse("2023-02-01"), value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidDateTimeNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<DateTime?>();

        var key = slotMap.Add(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void AddDateTimeNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<DateTime?>(2);

        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key3 = slotMap.Add(DateTime.Parse("2023-02-01"));

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(DateTime.Parse("2023-01-01"), slotMap.Get(key2));
        Assert.Equal(DateTime.Parse("2023-02-01"), slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void DateTimeNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<DateTime?>();

        var key = slotMap.Add(null);
        var newKey = slotMap.Insert(key, DateTime.Parse("2023-01-01"));
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(DateTime.Parse("2023-01-01"), value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidTimeSpanValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<TimeSpan>();

        var key = slotMap.Add(new TimeSpan(00,00,00));

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(new TimeSpan(00,00,00), slotMap.Get(key));
    }

    [Fact]
    public void AddTimeSpanElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<TimeSpan>(2);

        var key1 = slotMap.Add(new TimeSpan(00,00,00));
        var key2 = slotMap.Add(new TimeSpan(01,00,00));
        var key3 = slotMap.Add(new TimeSpan(02,00,00));

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(new TimeSpan(00,00,00), slotMap.Get(key1));
        Assert.Equal(new TimeSpan(01,00,00), slotMap.Get(key2));
        Assert.Equal(new TimeSpan(02,00,00), slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void TimeSpanWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<TimeSpan>();

        var key = slotMap.Add(new TimeSpan(00,00,00));
        var newKey = slotMap.Insert(key, new TimeSpan(01,00,00));
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(new TimeSpan(01,00,00), value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidTimeSpanNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<TimeSpan?>();

        var key = slotMap.Add(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void AddTimeSpanNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<TimeSpan?>(2);

        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(new TimeSpan(00,00,00));
        var key3 = slotMap.Add(new TimeSpan(01,00,00));

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(new TimeSpan(00,00,00), slotMap.Get(key2));
        Assert.Equal(new TimeSpan(01,00,00), slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void TimeSpanNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<TimeSpan?>();

        var key = slotMap.Add(null);
        var newKey = slotMap.Insert(key, new TimeSpan(00,00,00));
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(new TimeSpan(00,00,00), value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidGuidValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<Guid>();

        var key = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), slotMap.Get(key));
    }

    [Fact]
    public void AddGuidElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<Guid>(2);

        var key1 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key3 = slotMap.Add(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), slotMap.Get(key1));
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), slotMap.Get(key2));
        Assert.Equal(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"), slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void GuidWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<Guid>();

        var key = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var newKey = slotMap.Insert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidGuidNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<Guid?>();

        var key = slotMap.Add(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void AddGuidNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<Guid?>(2);

        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key3 = slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), slotMap.Get(key2));
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void GuidNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<Guid?>();

        var key = slotMap.Add(null);
        var newKey = slotMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), value);
    }

}