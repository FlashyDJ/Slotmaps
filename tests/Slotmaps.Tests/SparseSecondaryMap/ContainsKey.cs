//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SparseSecondaryMap;
public class ContainsKey
{
    [Fact]
    public void ValidKeyDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key = new SlotKey(1, 1);
    
        var result = sparseSecondaryMap.ContainsKey(key);
    
        Assert.False(result);
    }
    
    [Fact]
    public void InvalidKeyWithVersionLessThan1_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var invalidKey = new SlotKey(1, 0);
    
        var result = sparseSecondaryMap.ContainsKey(invalidKey);
    
        Assert.False(result);
    }
    
    [Fact]
    public void InvalidKeyWithVersionGreaterOrEqualTo1_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var invalidKey = new SlotKey(-1, 1);
    
        var result = sparseSecondaryMap.ContainsKey(invalidKey);
    
        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithIntExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 20);

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithIntNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 10);

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithStringExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, "Value 2");

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithStringNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, "Value 1");

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithDoubleExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 2.22D);

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithDoubleNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 1.11D);

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithBoolExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, false);

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithBoolNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, true);

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithCharExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 'B');

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithCharNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 'A');

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithLongExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 2000_000_000_000L);

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithLongNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 1000_000_000_000L);

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithFloatExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 2.2F);

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithFloatNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 1.1F);

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithDecimalExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 2.222_222_222M);

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithDecimalNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, 1.111_111_111M);

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithDateTimeExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, DateTime.Parse("2023-02-01"));

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithDateTimeNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, DateTime.Parse("2023-01-01"));

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithTimeSpanExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, new(01,00,00));

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithTimeSpanNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, new(00,00,00));

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithGuidExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValidKeyWithGuidNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key = new SlotKey(1, 1);
        sparseSecondaryMap.Insert(key, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var result = sparseSecondaryMap.ContainsKey(key);

        Assert.True(result);
    }

}