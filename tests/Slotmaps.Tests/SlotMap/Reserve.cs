//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;

public class Reserve
{
    [Fact]
    public void ValidAdditionalSize_ResizesMap()
    {
        var slotMap = new SlotMap<int>();
        var initialCapacity = slotMap.Capacity;
        var additionalSize = 10;
   
        slotMap.Reserve(additionalSize);
   
        Assert.Equal(initialCapacity + additionalSize, slotMap.Capacity);
    }
   
    [Fact]
    public void Reserve_NegativeAdditionalSize_ThrowsArgumentOutOfRangeException()
    {
        var slotMap = new SlotMap<int>();
        var negativeSize = -10;
   
        Assert.Throws<ArgumentOutOfRangeException>(() => slotMap.Reserve(negativeSize));
    }
}