//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SlotMap;
public class ContainsValue
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<int>();
        slotMap.Add(10);
        slotMap.Add(20);
        slotMap.Add(30);

        var result1 = slotMap.ContainsValue(10);
        var result2 = slotMap.ContainsValue(20);
        var result3 = slotMap.ContainsValue(30);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void IntValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Add(10);
        var key2 = slotMap.Add(20);
        var key3 = slotMap.Add(30);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(10);
        var result2 = slotMap.ContainsValue(20);
        var result3 = slotMap.ContainsValue(30);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void IntValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<int>();
        slotMap.Add(10);
        slotMap.Add(20);
        slotMap.Add(30);

        var result = slotMap.ContainsValue(40);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<int?>();
        slotMap.Add(null);
        slotMap.Add(10);
        slotMap.Add(20);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(10);
        var result3 = slotMap.ContainsValue(20);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void IntNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(10);
        var key3 = slotMap.Add(20);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(10);
        var result3 = slotMap.ContainsValue(20);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void IntNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<int?>();
        slotMap.Add(null);
        slotMap.Add(10);
        slotMap.Add(20);

        var result = slotMap.ContainsValue(30);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<string>();
        slotMap.Add("Value 1");
        slotMap.Add("Value 2");
        slotMap.Add("Value 3");

        var result1 = slotMap.ContainsValue("Value 1");
        var result2 = slotMap.ContainsValue("Value 2");
        var result3 = slotMap.ContainsValue("Value 3");

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void StringValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Add("Value 1");
        var key2 = slotMap.Add("Value 2");
        var key3 = slotMap.Add("Value 3");

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue("Value 1");
        var result2 = slotMap.ContainsValue("Value 2");
        var result3 = slotMap.ContainsValue("Value 3");

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void StringValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<string>();
        slotMap.Add("Value 1");
        slotMap.Add("Value 2");
        slotMap.Add("Value 3");

        var result = slotMap.ContainsValue("Value 4");

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<string?>();
        slotMap.Add(null);
        slotMap.Add("Value 1");
        slotMap.Add("Value 2");

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue("Value 1");
        var result3 = slotMap.ContainsValue("Value 2");

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void StringNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add("Value 1");
        var key3 = slotMap.Add("Value 2");

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue("Value 1");
        var result3 = slotMap.ContainsValue("Value 2");

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void StringNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<string?>();
        slotMap.Add(null);
        slotMap.Add("Value 1");
        slotMap.Add("Value 2");

        var result = slotMap.ContainsValue("Value 3");

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<double>();
        slotMap.Add(1.11D);
        slotMap.Add(2.22D);
        slotMap.Add(3.33D);

        var result1 = slotMap.ContainsValue(1.11D);
        var result2 = slotMap.ContainsValue(2.22D);
        var result3 = slotMap.ContainsValue(3.33D);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void DoubleValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Add(1.11D);
        var key2 = slotMap.Add(2.22D);
        var key3 = slotMap.Add(3.33D);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(1.11D);
        var result2 = slotMap.ContainsValue(2.22D);
        var result3 = slotMap.ContainsValue(3.33D);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void DoubleValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<double>();
        slotMap.Add(1.11D);
        slotMap.Add(2.22D);
        slotMap.Add(3.33D);

        var result = slotMap.ContainsValue(4.44D);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<double?>();
        slotMap.Add(null);
        slotMap.Add(1.11D);
        slotMap.Add(2.22D);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(1.11D);
        var result3 = slotMap.ContainsValue(2.22D);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void DoubleNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.11D);
        var key3 = slotMap.Add(2.22D);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(1.11D);
        var result3 = slotMap.ContainsValue(2.22D);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void DoubleNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<double?>();
        slotMap.Add(null);
        slotMap.Add(1.11D);
        slotMap.Add(2.22D);

        var result = slotMap.ContainsValue(3.33D);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<bool>();
        slotMap.Add(true);
        slotMap.Add(false);

        var result1 = slotMap.ContainsValue(true);
        var result2 = slotMap.ContainsValue(false);

        Assert.True(result1);
        Assert.True(result2);
    }

    [Fact]
    public void BoolValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Add(true);
        var key2 = slotMap.Add(false);
        var key3 = slotMap.Add(true);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(true);
        var result2 = slotMap.ContainsValue(false);
        var result3 = slotMap.ContainsValue(true);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void BoolValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<bool>();
        slotMap.Add(true);
        slotMap.Add(true);

        var result = slotMap.ContainsValue(false);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<bool?>();
        slotMap.Add(null);
        slotMap.Add(true);
        slotMap.Add(false);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(true);
        var result3 = slotMap.ContainsValue(false);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void BoolNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(true);
        var key3 = slotMap.Add(false);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(true);
        var result3 = slotMap.ContainsValue(false);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void BoolNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<bool?>();
        slotMap.Add(null);
        slotMap.Add(true);

        var result = slotMap.ContainsValue(false);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<char>();
        slotMap.Add('A');
        slotMap.Add('B');
        slotMap.Add('C');

        var result1 = slotMap.ContainsValue('A');
        var result2 = slotMap.ContainsValue('B');
        var result3 = slotMap.ContainsValue('C');

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void CharValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Add('A');
        var key2 = slotMap.Add('B');
        var key3 = slotMap.Add('C');

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue('A');
        var result2 = slotMap.ContainsValue('B');
        var result3 = slotMap.ContainsValue('C');

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void CharValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<char>();
        slotMap.Add('A');
        slotMap.Add('B');
        slotMap.Add('C');

        var result = slotMap.ContainsValue('D');

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<char?>();
        slotMap.Add(null);
        slotMap.Add('A');
        slotMap.Add('B');

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue('A');
        var result3 = slotMap.ContainsValue('B');

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void CharNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add('A');
        var key3 = slotMap.Add('B');

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue('A');
        var result3 = slotMap.ContainsValue('B');

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void CharNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<char?>();
        slotMap.Add(null);
        slotMap.Add('A');
        slotMap.Add('B');

        var result = slotMap.ContainsValue('C');

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<long>();
        slotMap.Add(1000_000_000_000L);
        slotMap.Add(2000_000_000_000L);
        slotMap.Add(3000_000_000_000L);

        var result1 = slotMap.ContainsValue(1000_000_000_000L);
        var result2 = slotMap.ContainsValue(2000_000_000_000L);
        var result3 = slotMap.ContainsValue(3000_000_000_000L);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void LongValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Add(1000_000_000_000L);
        var key2 = slotMap.Add(2000_000_000_000L);
        var key3 = slotMap.Add(3000_000_000_000L);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(1000_000_000_000L);
        var result2 = slotMap.ContainsValue(2000_000_000_000L);
        var result3 = slotMap.ContainsValue(3000_000_000_000L);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void LongValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<long>();
        slotMap.Add(1000_000_000_000L);
        slotMap.Add(2000_000_000_000L);
        slotMap.Add(3000_000_000_000L);

        var result = slotMap.ContainsValue(4000_000_000_000L);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<long?>();
        slotMap.Add(null);
        slotMap.Add(1000_000_000_000L);
        slotMap.Add(2000_000_000_000L);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(1000_000_000_000L);
        var result3 = slotMap.ContainsValue(2000_000_000_000L);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void LongNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1000_000_000_000L);
        var key3 = slotMap.Add(2000_000_000_000L);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(1000_000_000_000L);
        var result3 = slotMap.ContainsValue(2000_000_000_000L);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void LongNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<long?>();
        slotMap.Add(null);
        slotMap.Add(1000_000_000_000L);
        slotMap.Add(2000_000_000_000L);

        var result = slotMap.ContainsValue(3000_000_000_000L);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<float>();
        slotMap.Add(1.1F);
        slotMap.Add(2.2F);
        slotMap.Add(3.3F);

        var result1 = slotMap.ContainsValue(1.1F);
        var result2 = slotMap.ContainsValue(2.2F);
        var result3 = slotMap.ContainsValue(3.3F);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void FloatValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Add(1.1F);
        var key2 = slotMap.Add(2.2F);
        var key3 = slotMap.Add(3.3F);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(1.1F);
        var result2 = slotMap.ContainsValue(2.2F);
        var result3 = slotMap.ContainsValue(3.3F);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void FloatValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<float>();
        slotMap.Add(1.1F);
        slotMap.Add(2.2F);
        slotMap.Add(3.3F);

        var result = slotMap.ContainsValue(4.4F);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<float?>();
        slotMap.Add(null);
        slotMap.Add(1.1F);
        slotMap.Add(2.2F);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(1.1F);
        var result3 = slotMap.ContainsValue(2.2F);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void FloatNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.1F);
        var key3 = slotMap.Add(2.2F);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(1.1F);
        var result3 = slotMap.ContainsValue(2.2F);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void FloatNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<float?>();
        slotMap.Add(null);
        slotMap.Add(1.1F);
        slotMap.Add(2.2F);

        var result = slotMap.ContainsValue(3.3F);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<decimal>();
        slotMap.Add(1.111_111_111M);
        slotMap.Add(2.222_222_222M);
        slotMap.Add(3.333_333_333M);

        var result1 = slotMap.ContainsValue(1.111_111_111M);
        var result2 = slotMap.ContainsValue(2.222_222_222M);
        var result3 = slotMap.ContainsValue(3.333_333_333M);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void DecimalValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Add(1.111_111_111M);
        var key2 = slotMap.Add(2.222_222_222M);
        var key3 = slotMap.Add(3.333_333_333M);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(1.111_111_111M);
        var result2 = slotMap.ContainsValue(2.222_222_222M);
        var result3 = slotMap.ContainsValue(3.333_333_333M);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void DecimalValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<decimal>();
        slotMap.Add(1.111_111_111M);
        slotMap.Add(2.222_222_222M);
        slotMap.Add(3.333_333_333M);

        var result = slotMap.ContainsValue(4.444_444_444M);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<decimal?>();
        slotMap.Add(null);
        slotMap.Add(1.111_111_111M);
        slotMap.Add(2.222_222_222M);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(1.111_111_111M);
        var result3 = slotMap.ContainsValue(2.222_222_222M);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void DecimalNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(1.111_111_111M);
        var key3 = slotMap.Add(2.222_222_222M);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(1.111_111_111M);
        var result3 = slotMap.ContainsValue(2.222_222_222M);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void DecimalNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<decimal?>();
        slotMap.Add(null);
        slotMap.Add(1.111_111_111M);
        slotMap.Add(2.222_222_222M);

        var result = slotMap.ContainsValue(3.333_333_333M);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<DateTime>();
        slotMap.Add(DateTime.Parse("2023-01-01"));
        slotMap.Add(DateTime.Parse("2023-02-01"));
        slotMap.Add(DateTime.Parse("2023-03-01"));

        var result1 = slotMap.ContainsValue(DateTime.Parse("2023-01-01"));
        var result2 = slotMap.ContainsValue(DateTime.Parse("2023-02-01"));
        var result3 = slotMap.ContainsValue(DateTime.Parse("2023-03-01"));

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void DateTimeValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Add(DateTime.Parse("2023-02-01"));
        var key3 = slotMap.Add(DateTime.Parse("2023-03-01"));

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(DateTime.Parse("2023-01-01"));
        var result2 = slotMap.ContainsValue(DateTime.Parse("2023-02-01"));
        var result3 = slotMap.ContainsValue(DateTime.Parse("2023-03-01"));

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void DateTimeValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<DateTime>();
        slotMap.Add(DateTime.Parse("2023-01-01"));
        slotMap.Add(DateTime.Parse("2023-02-01"));
        slotMap.Add(DateTime.Parse("2023-03-01"));

        var result = slotMap.ContainsValue(DateTime.Parse("2023-04-01"));

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<DateTime?>();
        slotMap.Add(null);
        slotMap.Add(DateTime.Parse("2023-01-01"));
        slotMap.Add(DateTime.Parse("2023-02-01"));

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(DateTime.Parse("2023-01-01"));
        var result3 = slotMap.ContainsValue(DateTime.Parse("2023-02-01"));

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void DateTimeNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(DateTime.Parse("2023-01-01"));
        var key3 = slotMap.Add(DateTime.Parse("2023-02-01"));

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(DateTime.Parse("2023-01-01"));
        var result3 = slotMap.ContainsValue(DateTime.Parse("2023-02-01"));

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void DateTimeNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<DateTime?>();
        slotMap.Add(null);
        slotMap.Add(DateTime.Parse("2023-01-01"));
        slotMap.Add(DateTime.Parse("2023-02-01"));

        var result = slotMap.ContainsValue(DateTime.Parse("2023-03-01"));

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<TimeSpan>();
        slotMap.Add(new TimeSpan(00,00,00));
        slotMap.Add(new TimeSpan(01,00,00));
        slotMap.Add(new TimeSpan(02,00,00));

        var result1 = slotMap.ContainsValue(new TimeSpan(00,00,00));
        var result2 = slotMap.ContainsValue(new TimeSpan(01,00,00));
        var result3 = slotMap.ContainsValue(new TimeSpan(02,00,00));

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void TimeSpanValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Add(new TimeSpan(00,00,00));
        var key2 = slotMap.Add(new TimeSpan(01,00,00));
        var key3 = slotMap.Add(new TimeSpan(02,00,00));

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(new TimeSpan(00,00,00));
        var result2 = slotMap.ContainsValue(new TimeSpan(01,00,00));
        var result3 = slotMap.ContainsValue(new TimeSpan(02,00,00));

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void TimeSpanValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<TimeSpan>();
        slotMap.Add(new TimeSpan(00,00,00));
        slotMap.Add(new TimeSpan(01,00,00));
        slotMap.Add(new TimeSpan(02,00,00));

        var result = slotMap.ContainsValue(new TimeSpan(03,00,00));

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        slotMap.Add(null);
        slotMap.Add(new TimeSpan(00,00,00));
        slotMap.Add(new TimeSpan(01,00,00));

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(new TimeSpan(00,00,00));
        var result3 = slotMap.ContainsValue(new TimeSpan(01,00,00));

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void TimeSpanNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(new TimeSpan(00,00,00));
        var key3 = slotMap.Add(new TimeSpan(01,00,00));

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(new TimeSpan(00,00,00));
        var result3 = slotMap.ContainsValue(new TimeSpan(01,00,00));

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void TimeSpanNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        slotMap.Add(null);
        slotMap.Add(new TimeSpan(00,00,00));
        slotMap.Add(new TimeSpan(01,00,00));

        var result = slotMap.ContainsValue(new TimeSpan(02,00,00));

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<Guid>();
        slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        slotMap.Add(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        var result1 = slotMap.ContainsValue(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var result2 = slotMap.ContainsValue(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var result3 = slotMap.ContainsValue(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void GuidValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key3 = slotMap.Add(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var result2 = slotMap.ContainsValue(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var result3 = slotMap.ContainsValue(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void GuidValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<Guid>();
        slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        slotMap.Add(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        var result = slotMap.ContainsValue(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<Guid?>();
        slotMap.Add(null);
        slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var result3 = slotMap.ContainsValue(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void GuidNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Add(null);
        var key2 = slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key3 = slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var result3 = slotMap.ContainsValue(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void GuidNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<Guid?>();
        slotMap.Add(null);
        slotMap.Add(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        slotMap.Add(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        var result = slotMap.ContainsValue(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        Assert.False(result);
    }

}