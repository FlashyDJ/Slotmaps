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