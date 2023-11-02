//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SecondaryMap;
public class ContainsKey
{
    [Fact]
    public void ValidKeyDoesNotExist_ReturnsFalse()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);
    
        var result = secondaryMap.ContainsKey(key);
    
        Assert.False(result);
    }
    
    [Fact]
    public void InvalidKeyWithVersionLessThan1_ReturnsFalse()
    {
        var secondaryMap = new SecondaryMap<int>();
        var invalidKey = new SlotKey(1, 0);
    
        var result = secondaryMap.ContainsKey(invalidKey);
    
        Assert.False(result);
    }
    
    [Fact]
    public void InvalidKeyWithVersionGreaterOrEqualTo1_ReturnsFalse()
    {
        var secondaryMap = new SecondaryMap<int>();
        var invalidKey = new SlotKey(-1, 1);
    
        var result = secondaryMap.ContainsKey(invalidKey);
    
        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithIntExists_ReturnsTrue()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 20);

        var result = secondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithStringExists_ReturnsTrue()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, "Value 2");

        var result = secondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithDoubleExists_ReturnsTrue()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 2.22D);

        var result = secondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithBoolExists_ReturnsTrue()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, false);

        var result = secondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithCharExists_ReturnsTrue()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 'B');

        var result = secondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithLongExists_ReturnsTrue()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 2000_000_000_000L);

        var result = secondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithFloatExists_ReturnsTrue()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 2.2F);

        var result = secondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithDecimalExists_ReturnsTrue()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, 2.222_222_222M);

        var result = secondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithDateTimeExists_ReturnsTrue()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, DateTime.Parse("2023-02-01"));

        var result = secondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithTimeSpanExists_ReturnsTrue()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, new(01,00,00));

        var result = secondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithGuidExists_ReturnsTrue()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key = new SlotKey(1, 1);
        secondaryMap.Insert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        var result = secondaryMap.ContainsKey(key);

        Assert.True(result);
    }

}