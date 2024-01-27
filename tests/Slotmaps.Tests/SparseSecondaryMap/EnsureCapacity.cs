//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SparseSecondaryMap;

public class EnsureCapacity
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void IntWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void IntNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void StringWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void StringNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DoubleWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DoubleNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void BoolWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void BoolNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void CharWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void CharNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void LongWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void LongNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void FloatWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void FloatNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DecimalWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DecimalNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DateTimeWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void DateTimeNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void TimeSpanWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void TimeSpanNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void GuidWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithPositiveValue_ReturnsCapacity()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var capacity = 100;

        int result = sparseSecondaryMap.EnsureCapacity(capacity);

        Assert.True(result >= capacity);
        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void GuidNullableWithNegativeValue_ThrowsArgumentOutOfRangeException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();

        Assert.Throws<ArgumentOutOfRangeException>(() => sparseSecondaryMap.EnsureCapacity(-10));
    }

}