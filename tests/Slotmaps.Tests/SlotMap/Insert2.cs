//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;
public class Insert2
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, 10));
    }

    [Fact]
    public void IntWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Insert(10);

        var newKey = slotMap.Insert(key, 20);

        Assert.Equal(20, slotMap[newKey]);
    }

    [Fact]
    public void ReplaceIntValue_SameCount()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Insert(10);

        Assert.Single(slotMap);
        Assert.Equal(10, slotMap.Get(key));

        var key2 = slotMap.Insert(key, 20);
        Assert.Single(slotMap);
        Assert.Equal(20, slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int?>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, null));
    }

    [Fact]
    public void IntNullableWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Insert(null);

        var newKey = slotMap.Insert(key, 10);

        Assert.Equal(10, slotMap[newKey]);
    }

    [Fact]
    public void ReplaceIntNullableValue_SameCount()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.Null(slotMap.Get(key));

        var key2 = slotMap.Insert(key, 10);
        Assert.Single(slotMap);
        Assert.Equal(10, slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, "Value 1"));
    }

    [Fact]
    public void StringWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Insert("Value 1");

        var newKey = slotMap.Insert(key, "Value 2");

        Assert.Equal("Value 2", slotMap[newKey]);
    }

    [Fact]
    public void ReplaceStringValue_SameCount()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Insert("Value 1");

        Assert.Single(slotMap);
        Assert.Equal("Value 1", slotMap.Get(key));

        var key2 = slotMap.Insert(key, "Value 2");
        Assert.Single(slotMap);
        Assert.Equal("Value 2", slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string?>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, null));
    }

    [Fact]
    public void StringNullableWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Insert(null);

        var newKey = slotMap.Insert(key, "Value 1");

        Assert.Equal("Value 1", slotMap[newKey]);
    }

    [Fact]
    public void ReplaceStringNullableValue_SameCount()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.Null(slotMap.Get(key));

        var key2 = slotMap.Insert(key, "Value 1");
        Assert.Single(slotMap);
        Assert.Equal("Value 1", slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, 1.1F));
    }

    [Fact]
    public void FloatWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Insert(1.1F);

        var newKey = slotMap.Insert(key, 2.2F);

        Assert.Equal(2.2F, slotMap[newKey]);
    }

    [Fact]
    public void ReplaceFloatValue_SameCount()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Insert(1.1F);

        Assert.Single(slotMap);
        Assert.Equal(1.1F, slotMap.Get(key));

        var key2 = slotMap.Insert(key, 2.2F);
        Assert.Single(slotMap);
        Assert.Equal(2.2F, slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float?>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, null));
    }

    [Fact]
    public void FloatNullableWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Insert(null);

        var newKey = slotMap.Insert(key, 1.1F);

        Assert.Equal(1.1F, slotMap[newKey]);
    }

    [Fact]
    public void ReplaceFloatNullableValue_SameCount()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.Null(slotMap.Get(key));

        var key2 = slotMap.Insert(key, 1.1F);
        Assert.Single(slotMap);
        Assert.Equal(1.1F, slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, DateTime.Parse("2023-01-01")));
    }

    [Fact]
    public void DateTimeWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));

        var newKey = slotMap.Insert(key, DateTime.Parse("2023-02-01"));

        Assert.Equal(DateTime.Parse("2023-02-01"), slotMap[newKey]);
    }

    [Fact]
    public void ReplaceDateTimeValue_SameCount()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));

        Assert.Single(slotMap);
        Assert.Equal(DateTime.Parse("2023-01-01"), slotMap.Get(key));

        var key2 = slotMap.Insert(key, DateTime.Parse("2023-02-01"));
        Assert.Single(slotMap);
        Assert.Equal(DateTime.Parse("2023-02-01"), slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, null));
    }

    [Fact]
    public void DateTimeNullableWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Insert(null);

        var newKey = slotMap.Insert(key, DateTime.Parse("2023-01-01"));

        Assert.Equal(DateTime.Parse("2023-01-01"), slotMap[newKey]);
    }

    [Fact]
    public void ReplaceDateTimeNullableValue_SameCount()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.Null(slotMap.Get(key));

        var key2 = slotMap.Insert(key, DateTime.Parse("2023-01-01"));
        Assert.Single(slotMap);
        Assert.Equal(DateTime.Parse("2023-01-01"), slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE")));
    }

    [Fact]
    public void GuidWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var newKey = slotMap.Insert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), slotMap[newKey]);
    }

    [Fact]
    public void ReplaceGuidValue_SameCount()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Single(slotMap);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), slotMap.Get(key));

        var key2 = slotMap.Insert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        Assert.Single(slotMap);
        Assert.Equal(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"), slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, null));
    }

    [Fact]
    public void GuidNullableWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Insert(null);

        var newKey = slotMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), slotMap[newKey]);
    }

    [Fact]
    public void ReplaceGuidNullableValue_SameCount()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.Null(slotMap.Get(key));

        var key2 = slotMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        Assert.Single(slotMap);
        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), slotMap.Get(key2));
    }

}