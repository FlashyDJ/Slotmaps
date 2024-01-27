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
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueDoubleExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, 1.11D);
        sparseSecondaryMap.Insert(key2, 2.22D);
        sparseSecondaryMap.Insert(key3, 3.33D);

        var result = sparseSecondaryMap.ContainsValue(1.11D);

        Assert.True(result);
    }

    [Fact]
    public void ValueDoubleDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, 1.11D);
        sparseSecondaryMap.Insert(key2, 2.22D);
        sparseSecondaryMap.Insert(key3, 3.33D);

        var result = sparseSecondaryMap.ContainsValue(4.44D);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueDoubleNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.11D);
        sparseSecondaryMap.Insert(key3, 2.22D);

        var result = sparseSecondaryMap.ContainsValue(null);

        Assert.True(result);
    }

    [Fact]
    public void ValueDoubleNullableDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.11D);
        sparseSecondaryMap.Insert(key3, 2.22D);

        var result = sparseSecondaryMap.ContainsValue(3.33D);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueBoolExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, true);
        sparseSecondaryMap.Insert(key2, false);

        var result = sparseSecondaryMap.ContainsValue(true);

        Assert.True(result);
    }

    [Fact]
    public void ValueBoolDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, true);

        var result = sparseSecondaryMap.ContainsValue(false);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueBoolNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, true);

        var result = sparseSecondaryMap.ContainsValue(null);

        Assert.True(result);
    }

    [Fact]
    public void ValueBoolNullableDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);

        var result = sparseSecondaryMap.ContainsValue(true);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueCharExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, 'A');
        sparseSecondaryMap.Insert(key2, 'B');
        sparseSecondaryMap.Insert(key3, 'C');

        var result = sparseSecondaryMap.ContainsValue('A');

        Assert.True(result);
    }

    [Fact]
    public void ValueCharDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, 'A');
        sparseSecondaryMap.Insert(key2, 'B');
        sparseSecondaryMap.Insert(key3, 'C');

        var result = sparseSecondaryMap.ContainsValue('D');

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueCharNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 'A');
        sparseSecondaryMap.Insert(key3, 'B');

        var result = sparseSecondaryMap.ContainsValue(null);

        Assert.True(result);
    }

    [Fact]
    public void ValueCharNullableDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 'A');
        sparseSecondaryMap.Insert(key3, 'B');

        var result = sparseSecondaryMap.ContainsValue('C');

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueLongExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, 1000_000_000_000L);
        sparseSecondaryMap.Insert(key2, 2000_000_000_000L);
        sparseSecondaryMap.Insert(key3, 3000_000_000_000L);

        var result = sparseSecondaryMap.ContainsValue(1000_000_000_000L);

        Assert.True(result);
    }

    [Fact]
    public void ValueLongDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, 1000_000_000_000L);
        sparseSecondaryMap.Insert(key2, 2000_000_000_000L);
        sparseSecondaryMap.Insert(key3, 3000_000_000_000L);

        var result = sparseSecondaryMap.ContainsValue(4000_000_000_000L);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueLongNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1000_000_000_000L);
        sparseSecondaryMap.Insert(key3, 2000_000_000_000L);

        var result = sparseSecondaryMap.ContainsValue(null);

        Assert.True(result);
    }

    [Fact]
    public void ValueLongNullableDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1000_000_000_000L);
        sparseSecondaryMap.Insert(key3, 2000_000_000_000L);

        var result = sparseSecondaryMap.ContainsValue(3000_000_000_000L);

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
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueDecimalExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, 1.111_111_111M);
        sparseSecondaryMap.Insert(key2, 2.222_222_222M);
        sparseSecondaryMap.Insert(key3, 3.333_333_333M);

        var result = sparseSecondaryMap.ContainsValue(1.111_111_111M);

        Assert.True(result);
    }

    [Fact]
    public void ValueDecimalDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, 1.111_111_111M);
        sparseSecondaryMap.Insert(key2, 2.222_222_222M);
        sparseSecondaryMap.Insert(key3, 3.333_333_333M);

        var result = sparseSecondaryMap.ContainsValue(4.444_444_444M);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueDecimalNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.111_111_111M);
        sparseSecondaryMap.Insert(key3, 2.222_222_222M);

        var result = sparseSecondaryMap.ContainsValue(null);

        Assert.True(result);
    }

    [Fact]
    public void ValueDecimalNullableDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.111_111_111M);
        sparseSecondaryMap.Insert(key3, 2.222_222_222M);

        var result = sparseSecondaryMap.ContainsValue(3.333_333_333M);

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
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueTimeSpanExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, new TimeSpan(00,00,00));
        sparseSecondaryMap.Insert(key2, new TimeSpan(01,00,00));
        sparseSecondaryMap.Insert(key3, new TimeSpan(02,00,00));

        var result = sparseSecondaryMap.ContainsValue(new TimeSpan(00,00,00));

        Assert.True(result);
    }

    [Fact]
    public void ValueTimeSpanDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, new TimeSpan(00,00,00));
        sparseSecondaryMap.Insert(key2, new TimeSpan(01,00,00));
        sparseSecondaryMap.Insert(key3, new TimeSpan(02,00,00));

        var result = sparseSecondaryMap.ContainsValue(new TimeSpan(03,00,00));

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void ValueTimeSpanNullableExists_ReturnsTrue()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, new TimeSpan(00,00,00));
        sparseSecondaryMap.Insert(key3, new TimeSpan(01,00,00));

        var result = sparseSecondaryMap.ContainsValue(null);

        Assert.True(result);
    }

    [Fact]
    public void ValueTimeSpanNullableDoesNotExist_ReturnsFalse()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, new TimeSpan(00,00,00));
        sparseSecondaryMap.Insert(key3, new TimeSpan(01,00,00));

        var result = sparseSecondaryMap.ContainsValue(new TimeSpan(02,00,00));

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