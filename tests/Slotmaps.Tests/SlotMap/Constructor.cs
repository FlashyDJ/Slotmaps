//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;

public class Constructor
{
    [Fact]
    public void WithCapacityParameter_SetsCapacityAndBeEmpty()
    {
        int capacity = 10;

        var slotMap = new SlotMap<int>(capacity);

        Assert.Equal(capacity, slotMap.Capacity);
        Assert.Empty(slotMap);
        Assert.True(slotMap.IsEmpty);
    }
}