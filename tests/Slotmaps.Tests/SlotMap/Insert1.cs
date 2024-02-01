//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;

public class Insert1
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidIntValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<int>();

        var key = slotMap.Insert(10);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(10, slotMap.Get(key));
    }

    [Fact]
    public void InsertIntElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<int>(2);

        var key1 = slotMap.Insert(10);
        var key2 = slotMap.Insert(20);
        var key3 = slotMap.Insert(30);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(10, slotMap.Get(key1));
        Assert.Equal(20, slotMap.Get(key2));
        Assert.Equal(30, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void IntWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<int>();

        var key = slotMap.Insert(10);
        var newKey = slotMap.Insert(key, 20);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(20, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidIntNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<int?>();

        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void InsertIntNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<int?>(2);

        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(10);
        var key3 = slotMap.Insert(20);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(10, slotMap.Get(key2));
        Assert.Equal(20, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void IntNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<int?>();

        var key = slotMap.Insert(null);
        var newKey = slotMap.Insert(key, 10);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(10, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidStringValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<string>();

        var key = slotMap.Insert("Value 1");

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal("Value 1", slotMap.Get(key));
    }

    [Fact]
    public void InsertStringElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<string>(2);

        var key1 = slotMap.Insert("Value 1");
        var key2 = slotMap.Insert("Value 2");
        var key3 = slotMap.Insert("Value 3");

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal("Value 1", slotMap.Get(key1));
        Assert.Equal("Value 2", slotMap.Get(key2));
        Assert.Equal("Value 3", slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void StringWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<string>();

        var key = slotMap.Insert("Value 1");
        var newKey = slotMap.Insert(key, "Value 2");
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal("Value 2", value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidStringNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<string?>();

        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void InsertStringNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<string?>(2);

        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert("Value 1");
        var key3 = slotMap.Insert("Value 2");

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal("Value 1", slotMap.Get(key2));
        Assert.Equal("Value 2", slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void StringNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<string?>();

        var key = slotMap.Insert(null);
        var newKey = slotMap.Insert(key, "Value 1");
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal("Value 1", value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidFloatValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<float>();

        var key = slotMap.Insert(1.1F);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(1.1F, slotMap.Get(key));
    }

    [Fact]
    public void InsertFloatElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<float>(2);

        var key1 = slotMap.Insert(1.1F);
        var key2 = slotMap.Insert(2.2F);
        var key3 = slotMap.Insert(3.3F);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(1.1F, slotMap.Get(key1));
        Assert.Equal(2.2F, slotMap.Get(key2));
        Assert.Equal(3.3F, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void FloatWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<float>();

        var key = slotMap.Insert(1.1F);
        var newKey = slotMap.Insert(key, 2.2F);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(2.2F, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidFloatNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<float?>();

        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void InsertFloatNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<float?>(2);

        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.1F);
        var key3 = slotMap.Insert(2.2F);

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(1.1F, slotMap.Get(key2));
        Assert.Equal(2.2F, slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void FloatNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<float?>();

        var key = slotMap.Insert(null);
        var newKey = slotMap.Insert(key, 1.1F);
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(1.1F, value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidDateTimeValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<DateTime>();

        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(DateTime.Parse("2023-01-01"), slotMap.Get(key));
    }

    [Fact]
    public void InsertDateTimeElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<DateTime>(2);

        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Insert(DateTime.Parse("2023-02-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-03-01"));

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(DateTime.Parse("2023-01-01"), slotMap.Get(key1));
        Assert.Equal(DateTime.Parse("2023-02-01"), slotMap.Get(key2));
        Assert.Equal(DateTime.Parse("2023-03-01"), slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void DateTimeWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<DateTime>();

        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var newKey = slotMap.Insert(key, DateTime.Parse("2023-02-01"));
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(DateTime.Parse("2023-02-01"), value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidDateTimeNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<DateTime?>();

        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void InsertDateTimeNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<DateTime?>(2);

        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-02-01"));

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(DateTime.Parse("2023-01-01"), slotMap.Get(key2));
        Assert.Equal(DateTime.Parse("2023-02-01"), slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void DateTimeNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<DateTime?>();

        var key = slotMap.Insert(null);
        var newKey = slotMap.Insert(key, DateTime.Parse("2023-01-01"));
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(DateTime.Parse("2023-01-01"), value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidGuidValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<Guid>();

        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), slotMap.Get(key));
    }

    [Fact]
    public void InsertGuidElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<Guid>(2);

        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key3 = slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), slotMap.Get(key1));
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), slotMap.Get(key2));
        Assert.Equal(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"), slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void GuidWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<Guid>();

        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var newKey = slotMap.Insert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), value);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void NewValidGuidNullableValue_ReturnsKeyIncreasesCountAndContainKeys()
    {
        var slotMap = new SlotMap<Guid?>();

        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.True(slotMap.ContainsKey(key));
        Assert.Null(slotMap.Get(key));
    }

    [Fact]
    public void InsertGuidNullableElementsBeyondCapacity_ResizesCorrectly()
    {
        var slotMap = new SlotMap<Guid?>(2);

        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key3 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        Assert.True(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
        Assert.True(slotMap.ContainsKey(key3));
        Assert.Null(slotMap.Get(key1));
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), slotMap.Get(key2));
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), slotMap.Get(key3));
        Assert.Equal(4, slotMap.Capacity);
    }

    [Fact]
    public void GuidNullableWithValidSlotKey_UpdatesSlotValue()
    {
        var slotMap = new SlotMap<Guid?>();

        var key = slotMap.Insert(null);
        var newKey = slotMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var value = slotMap.Get(newKey);

        Assert.Equal(key.Index, newKey.Index);
        Assert.NotEqual(key, newKey);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), value);
    }

}