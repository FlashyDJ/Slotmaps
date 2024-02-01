//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SparseSecondaryMap;

public class Get
{
    [Fact]
    public void InvalidKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(invalidKey));
    }

    [Fact]
    public void KeyNotFound_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key = new SlotKey(1, 0);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsIntValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 10);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(10, result);
    }

    [Fact]
    public void IntWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, 10);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void IntWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        sparseSecondaryMap.Insert(key1, 10);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsIntNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Null(result);
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsStringValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, "Value 1");

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal("Value 1", result);
    }

    [Fact]
    public void StringWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, "Value 1");

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void StringWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        sparseSecondaryMap.Insert(key1, "Value 1");
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsStringNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Null(result);
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsFloatValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 1.1F);

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(1.1F, result);
    }

    [Fact]
    public void FloatWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, 1.1F);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void FloatWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        sparseSecondaryMap.Insert(key1, 1.1F);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsFloatNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Null(result);
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDateTimeValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(DateTime.Parse("2023-01-01"), result);
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsDateTimeNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Null(result);
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsGuidValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var result = sparseSecondaryMap.Get(key);

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), result);
    }

    [Fact]
    public void GuidWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void GuidWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKey_ReturnsGuidNullableValue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, null);

        var result = sparseSecondaryMap.Get(key);

        Assert.Null(result);
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 0);
        sparseSecondaryMap.Insert(key1, null);

        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(1, 2);
        sparseSecondaryMap.Insert(key1, null);
        
        Assert.Throws<KeyNotFoundException>(() => sparseSecondaryMap.Get(key2));
    }

}