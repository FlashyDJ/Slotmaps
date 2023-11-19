//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SlotMap;
public class EnsureCapacity
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<int>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void IntWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<int>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<int?>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void IntNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<int?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<string>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void StringWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<string>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<string?>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void StringNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<string?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<double>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DoubleWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<double>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<double?>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DoubleNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<double?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<bool>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void BoolWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<bool>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<bool?>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void BoolNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<bool?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<char>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void CharWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<char>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<char?>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void CharNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<char?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<long>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void LongWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<long>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<long?>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void LongNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<long?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<float>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FloatWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<float>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<float?>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void FloatNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<float?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<decimal>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DecimalWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<decimal>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<decimal?>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DecimalNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<decimal?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<DateTime>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DateTimeWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<DateTime>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<DateTime?>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void DateTimeNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<DateTime?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void TimeSpanWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<TimeSpan>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void TimeSpanNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<TimeSpan?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<Guid>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void GuidWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<Guid>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithPositiveValue_ReturnsCapacity()
    {
        var slotMap = new SlotMap<Guid?>();
        var capacity = 100;

        int result = slotMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(slotMap);
    }

    [Fact]
    public void GuidNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<Guid?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.EnsureCapacity(-10));
    }

}