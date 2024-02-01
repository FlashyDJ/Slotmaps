//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SparseSecondaryMap;

public class ContainsValue
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueIntExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, 10);
        sparseSecondaryMap.Insert(key2, 20);
        sparseSecondaryMap.Insert(key3, 30);

        var result = sparseSecondaryMap.ContainsValue(10);

        Assert.True(result);
    }

    [Fact]
    public void ValueIntDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, 10);
        sparseSecondaryMap.Insert(key2, 20);
        sparseSecondaryMap.Insert(key3, 30);

        var result = sparseSecondaryMap.ContainsValue(40);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueIntNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 10);
        sparseSecondaryMap.Insert(key3, 20);

        var result = sparseSecondaryMap.ContainsValue(null);

        Assert.True(result);
    }

    [Fact]
    public void ValueIntNullableDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 10);
        sparseSecondaryMap.Insert(key3, 20);

        var result = sparseSecondaryMap.ContainsValue(30);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueStringExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, "Value 1");
        sparseSecondaryMap.Insert(key2, "Value 2");
        sparseSecondaryMap.Insert(key3, "Value 3");

        var result = sparseSecondaryMap.ContainsValue("Value 1");

        Assert.True(result);
    }

    [Fact]
    public void ValueStringDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, "Value 1");
        sparseSecondaryMap.Insert(key2, "Value 2");
        sparseSecondaryMap.Insert(key3, "Value 3");

        var result = sparseSecondaryMap.ContainsValue("Value 4");

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueStringNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, "Value 1");
        sparseSecondaryMap.Insert(key3, "Value 2");

        var result = sparseSecondaryMap.ContainsValue(null);

        Assert.True(result);
    }

    [Fact]
    public void ValueStringNullableDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, "Value 1");
        sparseSecondaryMap.Insert(key3, "Value 2");

        var result = sparseSecondaryMap.ContainsValue("Value 3");

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueFloatExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, 1.1F);
        sparseSecondaryMap.Insert(key2, 2.2F);
        sparseSecondaryMap.Insert(key3, 3.3F);

        var result = sparseSecondaryMap.ContainsValue(1.1F);

        Assert.True(result);
    }

    [Fact]
    public void ValueFloatDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, 1.1F);
        sparseSecondaryMap.Insert(key2, 2.2F);
        sparseSecondaryMap.Insert(key3, 3.3F);

        var result = sparseSecondaryMap.ContainsValue(4.4F);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueFloatNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.1F);
        sparseSecondaryMap.Insert(key3, 2.2F);

        var result = sparseSecondaryMap.ContainsValue(null);

        Assert.True(result);
    }

    [Fact]
    public void ValueFloatNullableDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.1F);
        sparseSecondaryMap.Insert(key3, 2.2F);

        var result = sparseSecondaryMap.ContainsValue(3.3F);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueDateTimeExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-03-01"));

        var result = sparseSecondaryMap.ContainsValue(DateTime.Parse("2023-01-01"));

        Assert.True(result);
    }

    [Fact]
    public void ValueDateTimeDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-03-01"));

        var result = sparseSecondaryMap.ContainsValue(DateTime.Parse("2023-04-01"));

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueDateTimeNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-02-01"));

        var result = sparseSecondaryMap.ContainsValue(null);

        Assert.True(result);
    }

    [Fact]
    public void ValueDateTimeNullableDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-02-01"));

        var result = sparseSecondaryMap.ContainsValue(DateTime.Parse("2023-03-01"));

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueGuidExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        var result = sparseSecondaryMap.ContainsValue(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        Assert.True(result);
    }

    [Fact]
    public void ValueGuidDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        var result = sparseSecondaryMap.ContainsValue(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueGuidNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        var result = sparseSecondaryMap.ContainsValue(null);

        Assert.True(result);
    }

    [Fact]
    public void ValueGuidNullableDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        var result = sparseSecondaryMap.ContainsValue(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        Assert.False(result);
    }

}