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
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, 1.11D));
    }

    [Fact]
    public void DoubleWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<double>();
        var key = slotMap.Insert(1.11D);

        var newKey = slotMap.Insert(key, 2.22D);

        Assert.Equal(2.22D, slotMap[newKey]);
    }

    [Fact]
    public void ReplaceDoubleValue_SameCount()
    {
        var slotMap = new SlotMap<double>();
        var key = slotMap.Insert(1.11D);

        Assert.Single(slotMap);
        Assert.Equal(1.11D, slotMap.Get(key));

        var key2 = slotMap.Insert(key, 2.22D);
        Assert.Single(slotMap);
        Assert.Equal(2.22D, slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<double?>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, null));
    }

    [Fact]
    public void DoubleNullableWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<double?>();
        var key = slotMap.Insert(null);

        var newKey = slotMap.Insert(key, 1.11D);

        Assert.Equal(1.11D, slotMap[newKey]);
    }

    [Fact]
    public void ReplaceDoubleNullableValue_SameCount()
    {
        var slotMap = new SlotMap<double?>();
        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.Null(slotMap.Get(key));

        var key2 = slotMap.Insert(key, 1.11D);
        Assert.Single(slotMap);
        Assert.Equal(1.11D, slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, true));
    }

    [Fact]
    public void BoolWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<bool>();
        var key = slotMap.Insert(true);

        var newKey = slotMap.Insert(key, false);

        Assert.Equal(false, slotMap[newKey]);
    }

    [Fact]
    public void ReplaceBoolValue_SameCount()
    {
        var slotMap = new SlotMap<bool>();
        var key = slotMap.Insert(true);

        Assert.Single(slotMap);
        Assert.Equal(true, slotMap.Get(key));

        var key2 = slotMap.Insert(key, false);
        Assert.Single(slotMap);
        Assert.Equal(false, slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<bool?>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, null));
    }

    [Fact]
    public void BoolNullableWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<bool?>();
        var key = slotMap.Insert(null);

        var newKey = slotMap.Insert(key, true);

        Assert.Equal(true, slotMap[newKey]);
    }

    [Fact]
    public void ReplaceBoolNullableValue_SameCount()
    {
        var slotMap = new SlotMap<bool?>();
        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.Null(slotMap.Get(key));

        var key2 = slotMap.Insert(key, true);
        Assert.Single(slotMap);
        Assert.Equal(true, slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, 'A'));
    }

    [Fact]
    public void CharWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<char>();
        var key = slotMap.Insert('A');

        var newKey = slotMap.Insert(key, 'B');

        Assert.Equal('B', slotMap[newKey]);
    }

    [Fact]
    public void ReplaceCharValue_SameCount()
    {
        var slotMap = new SlotMap<char>();
        var key = slotMap.Insert('A');

        Assert.Single(slotMap);
        Assert.Equal('A', slotMap.Get(key));

        var key2 = slotMap.Insert(key, 'B');
        Assert.Single(slotMap);
        Assert.Equal('B', slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<char?>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, null));
    }

    [Fact]
    public void CharNullableWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<char?>();
        var key = slotMap.Insert(null);

        var newKey = slotMap.Insert(key, 'A');

        Assert.Equal('A', slotMap[newKey]);
    }

    [Fact]
    public void ReplaceCharNullableValue_SameCount()
    {
        var slotMap = new SlotMap<char?>();
        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.Null(slotMap.Get(key));

        var key2 = slotMap.Insert(key, 'A');
        Assert.Single(slotMap);
        Assert.Equal('A', slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, 1000_000_000_000L));
    }

    [Fact]
    public void LongWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<long>();
        var key = slotMap.Insert(1000_000_000_000L);

        var newKey = slotMap.Insert(key, 2000_000_000_000L);

        Assert.Equal(2000_000_000_000L, slotMap[newKey]);
    }

    [Fact]
    public void ReplaceLongValue_SameCount()
    {
        var slotMap = new SlotMap<long>();
        var key = slotMap.Insert(1000_000_000_000L);

        Assert.Single(slotMap);
        Assert.Equal(1000_000_000_000L, slotMap.Get(key));

        var key2 = slotMap.Insert(key, 2000_000_000_000L);
        Assert.Single(slotMap);
        Assert.Equal(2000_000_000_000L, slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<long?>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, null));
    }

    [Fact]
    public void LongNullableWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<long?>();
        var key = slotMap.Insert(null);

        var newKey = slotMap.Insert(key, 1000_000_000_000L);

        Assert.Equal(1000_000_000_000L, slotMap[newKey]);
    }

    [Fact]
    public void ReplaceLongNullableValue_SameCount()
    {
        var slotMap = new SlotMap<long?>();
        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.Null(slotMap.Get(key));

        var key2 = slotMap.Insert(key, 1000_000_000_000L);
        Assert.Single(slotMap);
        Assert.Equal(1000_000_000_000L, slotMap.Get(key2));
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
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, 1.111_111_111M));
    }

    [Fact]
    public void DecimalWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<decimal>();
        var key = slotMap.Insert(1.111_111_111M);

        var newKey = slotMap.Insert(key, 2.222_222_222M);

        Assert.Equal(2.222_222_222M, slotMap[newKey]);
    }

    [Fact]
    public void ReplaceDecimalValue_SameCount()
    {
        var slotMap = new SlotMap<decimal>();
        var key = slotMap.Insert(1.111_111_111M);

        Assert.Single(slotMap);
        Assert.Equal(1.111_111_111M, slotMap.Get(key));

        var key2 = slotMap.Insert(key, 2.222_222_222M);
        Assert.Single(slotMap);
        Assert.Equal(2.222_222_222M, slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, null));
    }

    [Fact]
    public void DecimalNullableWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = slotMap.Insert(null);

        var newKey = slotMap.Insert(key, 1.111_111_111M);

        Assert.Equal(1.111_111_111M, slotMap[newKey]);
    }

    [Fact]
    public void ReplaceDecimalNullableValue_SameCount()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.Null(slotMap.Get(key));

        var key2 = slotMap.Insert(key, 1.111_111_111M);
        Assert.Single(slotMap);
        Assert.Equal(1.111_111_111M, slotMap.Get(key2));
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
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, new TimeSpan(00,00,00)));
    }

    [Fact]
    public void TimeSpanWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = slotMap.Insert(new TimeSpan(00,00,00));

        var newKey = slotMap.Insert(key, new TimeSpan(01,00,00));

        Assert.Equal(new TimeSpan(01,00,00), slotMap[newKey]);
    }

    [Fact]
    public void ReplaceTimeSpanValue_SameCount()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = slotMap.Insert(new TimeSpan(00,00,00));

        Assert.Single(slotMap);
        Assert.Equal(new TimeSpan(00,00,00), slotMap.Get(key));

        var key2 = slotMap.Insert(key, new TimeSpan(01,00,00));
        Assert.Single(slotMap);
        Assert.Equal(new TimeSpan(01,00,00), slotMap.Get(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithNonexistentKey_ThrowsKeyNotFoundException()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = new SlotKey(1, 0);

        var ex = Assert.Throws<KeyNotFoundException>(() => slotMap.Insert(key, null));
    }

    [Fact]
    public void TimeSpanNullableWithExistingKey_UpdatesValueAndReturnsNewKey()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = slotMap.Insert(null);

        var newKey = slotMap.Insert(key, new TimeSpan(00,00,00));

        Assert.Equal(new TimeSpan(00,00,00), slotMap[newKey]);
    }

    [Fact]
    public void ReplaceTimeSpanNullableValue_SameCount()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = slotMap.Insert(null);

        Assert.Single(slotMap);
        Assert.Null(slotMap.Get(key));

        var key2 = slotMap.Insert(key, new TimeSpan(00,00,00));
        Assert.Single(slotMap);
        Assert.Equal(new TimeSpan(00,00,00), slotMap.Get(key2));
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