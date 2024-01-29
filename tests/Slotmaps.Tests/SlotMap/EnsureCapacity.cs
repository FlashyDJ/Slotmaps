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