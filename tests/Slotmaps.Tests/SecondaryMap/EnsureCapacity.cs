//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SecondaryMap;
public class EnsureCapacity
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<int>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void IntWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<int>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void IntNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<int?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<string>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void StringWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<string>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void StringNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<string?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<double>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DoubleWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<double>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DoubleNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<double?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void BoolWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<bool>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void BoolNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<bool?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<char>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void CharWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<char>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void CharNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<char?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<long>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void LongWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<long>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void LongNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<long?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<float>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void FloatWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<float>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void FloatNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<float?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DecimalWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<decimal>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DecimalNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<decimal?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DateTimeWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<DateTime>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void DateTimeNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void TimeSpanWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void TimeSpanNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void GuidWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<Guid>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithPositiveValue_ReturnsCapacity()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var capacity = 100;

        int result = secondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void GuidNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var secondaryMap = new SecondaryMap<Guid?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => secondaryMap.EnsureCapacity(-10));
    }

}