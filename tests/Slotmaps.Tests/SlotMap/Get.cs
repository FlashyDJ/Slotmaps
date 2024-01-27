//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;

public class Get
{
    [Fact]
    public void InvalidKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var invalidKey = new SlotKey(-1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(invalidKey));
    }

    [Fact]
    public void KeyNotFound_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var key = new SlotKey(1, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<int>();
        var key = slotMap.Insert(10);

        var value = slotMap.Get(key);

        Assert.Equal(10, value);
    }

    [Fact]
    public void IntWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void IntWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<int?>();
        var key = slotMap.Insert(null);

        var value = slotMap.Get(key);

        Assert.Null(value);
    }

    [Fact]
    public void IntNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void IntNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<string>();
        var key = slotMap.Insert("Value 1");

        var value = slotMap.Get(key);

        Assert.Equal("Value 1", value);
    }

    [Fact]
    public void StringWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void StringWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<string?>();
        var key = slotMap.Insert(null);

        var value = slotMap.Get(key);

        Assert.Null(value);
    }

    [Fact]
    public void StringNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void StringNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<double>();
        var key = slotMap.Insert(1.11D);

        var value = slotMap.Get(key);

        Assert.Equal(1.11D, value);
    }

    [Fact]
    public void DoubleWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Insert(1.11D);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void DoubleWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Insert(1.11D);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<double?>();
        var key = slotMap.Insert(null);

        var value = slotMap.Get(key);

        Assert.Null(value);
    }

    [Fact]
    public void DoubleNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void DoubleNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<bool>();
        var key = slotMap.Insert(true);

        var value = slotMap.Get(key);

        Assert.Equal(true, value);
    }

    [Fact]
    public void BoolWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Insert(true);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void BoolWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Insert(true);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<bool?>();
        var key = slotMap.Insert(null);

        var value = slotMap.Get(key);

        Assert.Null(value);
    }

    [Fact]
    public void BoolNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void BoolNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<char>();
        var key = slotMap.Insert('A');

        var value = slotMap.Get(key);

        Assert.Equal('A', value);
    }

    [Fact]
    public void CharWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Insert('A');
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void CharWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Insert('A');
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<char?>();
        var key = slotMap.Insert(null);

        var value = slotMap.Get(key);

        Assert.Null(value);
    }

    [Fact]
    public void CharNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void CharNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<long>();
        var key = slotMap.Insert(1000_000_000_000L);

        var value = slotMap.Get(key);

        Assert.Equal(1000_000_000_000L, value);
    }

    [Fact]
    public void LongWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Insert(1000_000_000_000L);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void LongWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Insert(1000_000_000_000L);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<long?>();
        var key = slotMap.Insert(null);

        var value = slotMap.Get(key);

        Assert.Null(value);
    }

    [Fact]
    public void LongNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void LongNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<float>();
        var key = slotMap.Insert(1.1F);

        var value = slotMap.Get(key);

        Assert.Equal(1.1F, value);
    }

    [Fact]
    public void FloatWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void FloatWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<float?>();
        var key = slotMap.Insert(null);

        var value = slotMap.Get(key);

        Assert.Null(value);
    }

    [Fact]
    public void FloatNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void FloatNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<decimal>();
        var key = slotMap.Insert(1.111_111_111M);

        var value = slotMap.Get(key);

        Assert.Equal(1.111_111_111M, value);
    }

    [Fact]
    public void DecimalWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Insert(1.111_111_111M);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void DecimalWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Insert(1.111_111_111M);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = slotMap.Insert(null);

        var value = slotMap.Get(key);

        Assert.Null(value);
    }

    [Fact]
    public void DecimalNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void DecimalNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<DateTime>();
        var key = slotMap.Insert(DateTime.Parse("2023-01-01"));

        var value = slotMap.Get(key);

        Assert.Equal(DateTime.Parse("2023-01-01"), value);
    }

    [Fact]
    public void DateTimeWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void DateTimeWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key = slotMap.Insert(null);

        var value = slotMap.Get(key);

        Assert.Null(value);
    }

    [Fact]
    public void DateTimeNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void DateTimeNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = slotMap.Insert(new TimeSpan(00,00,00));

        var value = slotMap.Get(key);

        Assert.Equal(new TimeSpan(00,00,00), value);
    }

    [Fact]
    public void TimeSpanWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Insert(new TimeSpan(00,00,00));
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void TimeSpanWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Insert(new TimeSpan(00,00,00));
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = slotMap.Insert(null);

        var value = slotMap.Get(key);

        Assert.Null(value);
    }

    [Fact]
    public void TimeSpanNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void TimeSpanNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<Guid>();
        var key = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));

        var value = slotMap.Get(key);

        Assert.Equal(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"), value);
    }

    [Fact]
    public void GuidWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void GuidWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableWithValidKey_ReturnsValue()
    {
        var slotMap = new SlotMap<Guid?>();
        var key = slotMap.Insert(null);

        var value = slotMap.Get(key);

        Assert.Null(value);
    }

    [Fact]
    public void GuidNullableWithOlderVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(0, 0);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

    [Fact]
    public void GuidNullableWithNewerVersionKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = new SlotKey(1, 2);

        Assert.Throws<KeyNotFoundException>(() => slotMap.Get(key2));
    }

}