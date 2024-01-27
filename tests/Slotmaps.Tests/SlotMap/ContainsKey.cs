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
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<double>();
        var key = slotMap.Insert(1.11D);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void DoubleItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<double>();
        var key = slotMap.Insert(1.11D);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void DoubleItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Insert(1.11D);
        var key2 = slotMap.Insert(2.22D);

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DoubleNullableWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<double?>();
        var key = slotMap.Insert(null);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void DoubleNullableItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<double?>();
        var key = slotMap.Insert(null);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void DoubleNullableItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.11D);

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<bool>();
        var key = slotMap.Insert(true);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void BoolItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<bool>();
        var key = slotMap.Insert(true);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void BoolItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Insert(true);
        var key2 = slotMap.Insert(false);

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void BoolNullableWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<bool?>();
        var key = slotMap.Insert(null);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void BoolNullableItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<bool?>();
        var key = slotMap.Insert(null);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void BoolNullableItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(true);

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<char>();
        var key = slotMap.Insert('A');

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void CharItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<char>();
        var key = slotMap.Insert('A');

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void CharItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Insert('A');
        var key2 = slotMap.Insert('B');

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void CharNullableWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<char?>();
        var key = slotMap.Insert(null);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void CharNullableItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<char?>();
        var key = slotMap.Insert(null);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void CharNullableItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert('A');

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<long>();
        var key = slotMap.Insert(1000_000_000_000L);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void LongItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<long>();
        var key = slotMap.Insert(1000_000_000_000L);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void LongItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Insert(1000_000_000_000L);
        var key2 = slotMap.Insert(2000_000_000_000L);

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void LongNullableWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<long?>();
        var key = slotMap.Insert(null);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void LongNullableItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<long?>();
        var key = slotMap.Insert(null);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void LongNullableItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1000_000_000_000L);

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
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<decimal>();
        var key = slotMap.Insert(1.111_111_111M);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void DecimalItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<decimal>();
        var key = slotMap.Insert(1.111_111_111M);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void DecimalItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Insert(1.111_111_111M);
        var key2 = slotMap.Insert(2.222_222_222M);

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DecimalNullableWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = slotMap.Insert(null);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void DecimalNullableItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<decimal?>();
        var key = slotMap.Insert(null);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void DecimalNullableItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.111_111_111M);

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
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = slotMap.Insert(new TimeSpan(00,00,00));

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void TimeSpanItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key = slotMap.Insert(new TimeSpan(00,00,00));

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void TimeSpanItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Insert(new TimeSpan(00,00,00));
        var key2 = slotMap.Insert(new TimeSpan(01,00,00));

        slotMap.Remove(key1);

        Assert.False(slotMap.ContainsKey(key1));
        Assert.True(slotMap.ContainsKey(key2));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void TimeSpanNullableWithValidKeyExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = slotMap.Insert(null);

        var result = slotMap.ContainsKey(key);

        Assert.True(result);
    }

    [Fact]
    public void TimeSpanNullableItemAddedToSlotMap_EmptysSlotMapAndNotContainKey()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key = slotMap.Insert(null);

        slotMap.Remove(key);

        Assert.Empty(slotMap);
        Assert.False(slotMap.ContainsKey(key));
    }

    [Fact]
    public void TimeSpanNullableItemRemovedFromSlotMap_NotContainRemovedKeyAndContainsOtherKey()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(new TimeSpan(00,00,00));

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