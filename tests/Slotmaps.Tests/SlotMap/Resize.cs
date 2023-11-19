//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SlotMap;
public class Resize
{
    [Fact]
    public void NewSizeLessThanCapacity_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<int>();
        slotMap.Add(42);
        var newSize = slotMap.Capacity - 1;

        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.Resize(newSize));
    }

    [Fact]
    public void NewSizeEqualToCapacity_DoesNotChangeCapacity()
    {
        var slotMap = new SlotMap<int>();
        slotMap.Add(42);
        var initialCapacity = slotMap.Capacity;
        var newSize = initialCapacity;

        slotMap.Resize(newSize);

        Assert.Equal(initialCapacity, slotMap.Capacity);
    }

    [Fact]
    public void Resize_NewSizeGreaterThanCapacity_ResizesArrayToNewSize()
    {
        var slotMap = new SlotMap<int>();
        slotMap.Add(42);
        var initialCapacity = slotMap.Capacity;
        var newSize = initialCapacity * 2;

        slotMap.Resize(newSize);

        Assert.Equal(newSize, slotMap.Capacity);
    }
}