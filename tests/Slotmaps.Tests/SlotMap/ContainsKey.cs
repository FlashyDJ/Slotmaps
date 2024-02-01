//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;

public class ContainsKey
{
    [Fact]
    public void ValidKeyDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<string>();
        var key = new SlotKey(1, 1);

        var result = slotMap.ContainsKey(key);

        Assert.False(result);
    }

    [Fact]
    public void InvalidKeyWithVersionLessThan1_ReturnsFalse()
    {
        var slotMap = new SlotMap<string>();
        var invalidKey = new SlotKey(1, 0);

        var result = slotMap.ContainsKey(invalidKey);

        Assert.False(result);
    }

    [Fact]
    public void InvalidKeyWithVersionGreaterOrEqualTo1_ReturnsFalse()
    {
        var slotMap = new SlotMap<string>();
        var invalidKey = new SlotKey(-1, 1);

        var result = slotMap.ContainsKey(invalidKey);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Insert(10);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void IntItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Insert(10);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void IntItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = slotMap.Insert(20);

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Insert(null);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void IntNullableItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Insert(null);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void IntNullableItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(10);

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Insert("Value 1");

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void StringItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Insert("Value 1");

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void StringItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = slotMap.Insert("Value 2");

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Insert(null);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void StringNullableItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Insert(null);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void StringNullableItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert("Value 1");

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Insert(1.1F);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void FloatItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Insert(1.1F);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void FloatItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = slotMap.Insert(2.2F);

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Insert(null);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void FloatNullableItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Insert(null);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void FloatNullableItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.1F);

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void DateTimeItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void DateTimeItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Insert(DateTime.Parse("2023-02-01"));

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Insert(null);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void DateTimeNullableItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Insert(null);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void DateTimeNullableItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(DateTime.Parse("2023-01-01"));

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void GuidItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void GuidItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Insert(null);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void GuidNullableItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Insert(null);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void GuidNullableItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

}