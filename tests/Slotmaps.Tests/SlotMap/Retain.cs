//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;

public class Retain
{
    [Fact]
    public void PredicateRemovesSomeItems_ItemsThatSatisfyPredicateAreRetained()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(42);
        var key2 = slotMap.Insert(24);
        var key3 = slotMap.Insert(36);
        var key4 = slotMap.Insert(50);
        var key5 = slotMap.Insert(18);

        slotMap.Retain((key, value) => value > 30);

        Assert.Equal(3, slotMap.Count);
        Assert.Equal(42, slotMap[key1]);
        Assert.Equal(36, slotMap[key3]);
        Assert.Equal(50, slotMap[key4]);
        Assert.False(slotMap.ContainsKey(key2));
        Assert.False(slotMap.ContainsKey(key5));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllIntItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = slotMap.Insert(20);
        var key3 = slotMap.Insert(30);
        var key4 = slotMap.Insert(40);
        var key5 = slotMap.Insert(50);
        

        slotMap.Retain((key, value) => value == 60);

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllIntItems_ItemsRetained()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = slotMap.Insert(20);
        var key3 = slotMap.Insert(30);
        var key4 = slotMap.Insert(40);
        var key5 = slotMap.Insert(50);

        slotMap.Retain((key, value) => value != 60);

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllIntNullableItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(10);
        var key3 = slotMap.Insert(20);
        var key4 = slotMap.Insert(30);
        var key5 = slotMap.Insert(40);
        

        slotMap.Retain((key, value) => value == 50);

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllIntNullableItems_ItemsRetained()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(10);
        var key3 = slotMap.Insert(20);
        var key4 = slotMap.Insert(30);
        var key5 = slotMap.Insert(40);

        slotMap.Retain((key, value) => value != 50);

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllStringItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = slotMap.Insert("Value 2");
        var key3 = slotMap.Insert("Value 3");
        var key4 = slotMap.Insert("Value 4");
        var key5 = slotMap.Insert("Value 5");
        

        slotMap.Retain((key, value) => value == "Value 6");

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllStringItems_ItemsRetained()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = slotMap.Insert("Value 2");
        var key3 = slotMap.Insert("Value 3");
        var key4 = slotMap.Insert("Value 4");
        var key5 = slotMap.Insert("Value 5");

        slotMap.Retain((key, value) => value != "Value 6");

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllStringNullableItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert("Value 1");
        var key3 = slotMap.Insert("Value 2");
        var key4 = slotMap.Insert("Value 3");
        var key5 = slotMap.Insert("Value 4");
        

        slotMap.Retain((key, value) => value == "Value 5");

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllStringNullableItems_ItemsRetained()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert("Value 1");
        var key3 = slotMap.Insert("Value 2");
        var key4 = slotMap.Insert("Value 3");
        var key5 = slotMap.Insert("Value 4");

        slotMap.Retain((key, value) => value != "Value 5");

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDoubleItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Insert(1.11D);
        var key2 = slotMap.Insert(2.22D);
        var key3 = slotMap.Insert(3.33D);
        var key4 = slotMap.Insert(4.44D);
        var key5 = slotMap.Insert(5.55D);
        

        slotMap.Retain((key, value) => value == 6.66D);

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllDoubleItems_ItemsRetained()
    {
        var slotMap = new SlotMap<double>();
        var key1 = slotMap.Insert(1.11D);
        var key2 = slotMap.Insert(2.22D);
        var key3 = slotMap.Insert(3.33D);
        var key4 = slotMap.Insert(4.44D);
        var key5 = slotMap.Insert(5.55D);

        slotMap.Retain((key, value) => value != 6.66D);

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDoubleNullableItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.11D);
        var key3 = slotMap.Insert(2.22D);
        var key4 = slotMap.Insert(3.33D);
        var key5 = slotMap.Insert(4.44D);
        

        slotMap.Retain((key, value) => value == 5.55D);

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllDoubleNullableItems_ItemsRetained()
    {
        var slotMap = new SlotMap<double?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.11D);
        var key3 = slotMap.Insert(2.22D);
        var key4 = slotMap.Insert(3.33D);
        var key5 = slotMap.Insert(4.44D);

        slotMap.Retain((key, value) => value != 5.55D);

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllBoolItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Insert(true);
        var key2 = slotMap.Insert(false);
        var key3 = slotMap.Insert(true);
        var key4 = slotMap.Insert(false);
        var key5 = slotMap.Insert(true);
        

#pragma warning disable CS0184 // 'is' expression's given expression is never of the provided type
        slotMap.Retain((key, value) => value is int);
#pragma warning restore CS0184 // 'is' expression's given expression is never of the provided type

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllBoolItems_ItemsRetained()
    {
        var slotMap = new SlotMap<bool>();
        var key1 = slotMap.Insert(true);
        var key2 = slotMap.Insert(false);
        var key3 = slotMap.Insert(true);
        var key4 = slotMap.Insert(false);
        var key5 = slotMap.Insert(true);

#pragma warning disable CS0183 // 'is' expression's given expression is always of the provided type
        slotMap.Retain((key, value) => value is bool);
#pragma warning restore CS0183 // 'is' expression's given expression is always of the provided type

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllBoolNullableItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(true);
        var key3 = slotMap.Insert(false);
        var key4 = slotMap.Insert(null);
        var key5 = slotMap.Insert(true);
        

#pragma warning disable CS0184 // 'is' expression's given expression is never of the provided type
        slotMap.Retain((key, value) => value is int);
#pragma warning restore CS0184 // 'is' expression's given expression is never of the provided type

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllBoolNullableItems_ItemsRetained()
    {
        var slotMap = new SlotMap<bool?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(true);
        var key3 = slotMap.Insert(false);
        var key4 = slotMap.Insert(null);
        var key5 = slotMap.Insert(true);

#pragma warning disable CS8794 // The input always matches the provided pattern.
        slotMap.Retain((key, value) => value is bool or null);
#pragma warning restore CS8794 // The input always matches the provided pattern.

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllCharItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Insert('A');
        var key2 = slotMap.Insert('B');
        var key3 = slotMap.Insert('C');
        var key4 = slotMap.Insert('D');
        var key5 = slotMap.Insert('E');
        

        slotMap.Retain((key, value) => value == 'F');

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllCharItems_ItemsRetained()
    {
        var slotMap = new SlotMap<char>();
        var key1 = slotMap.Insert('A');
        var key2 = slotMap.Insert('B');
        var key3 = slotMap.Insert('C');
        var key4 = slotMap.Insert('D');
        var key5 = slotMap.Insert('E');

        slotMap.Retain((key, value) => value != 'F');

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllCharNullableItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert('A');
        var key3 = slotMap.Insert('B');
        var key4 = slotMap.Insert('C');
        var key5 = slotMap.Insert('D');
        

        slotMap.Retain((key, value) => value == 'E');

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllCharNullableItems_ItemsRetained()
    {
        var slotMap = new SlotMap<char?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert('A');
        var key3 = slotMap.Insert('B');
        var key4 = slotMap.Insert('C');
        var key5 = slotMap.Insert('D');

        slotMap.Retain((key, value) => value != 'E');

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllLongItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Insert(1000_000_000_000L);
        var key2 = slotMap.Insert(2000_000_000_000L);
        var key3 = slotMap.Insert(3000_000_000_000L);
        var key4 = slotMap.Insert(4000_000_000_000L);
        var key5 = slotMap.Insert(5000_000_000_000L);
        

        slotMap.Retain((key, value) => value == 6000_000_000_000L);

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllLongItems_ItemsRetained()
    {
        var slotMap = new SlotMap<long>();
        var key1 = slotMap.Insert(1000_000_000_000L);
        var key2 = slotMap.Insert(2000_000_000_000L);
        var key3 = slotMap.Insert(3000_000_000_000L);
        var key4 = slotMap.Insert(4000_000_000_000L);
        var key5 = slotMap.Insert(5000_000_000_000L);

        slotMap.Retain((key, value) => value != 6000_000_000_000L);

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllLongNullableItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1000_000_000_000L);
        var key3 = slotMap.Insert(2000_000_000_000L);
        var key4 = slotMap.Insert(3000_000_000_000L);
        var key5 = slotMap.Insert(4000_000_000_000L);
        

        slotMap.Retain((key, value) => value == 5000_000_000_000L);

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllLongNullableItems_ItemsRetained()
    {
        var slotMap = new SlotMap<long?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1000_000_000_000L);
        var key3 = slotMap.Insert(2000_000_000_000L);
        var key4 = slotMap.Insert(3000_000_000_000L);
        var key5 = slotMap.Insert(4000_000_000_000L);

        slotMap.Retain((key, value) => value != 5000_000_000_000L);

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllFloatItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = slotMap.Insert(2.2F);
        var key3 = slotMap.Insert(3.3F);
        var key4 = slotMap.Insert(4.4F);
        var key5 = slotMap.Insert(5.5F);
        

        slotMap.Retain((key, value) => value == 6.6F);

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllFloatItems_ItemsRetained()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = slotMap.Insert(2.2F);
        var key3 = slotMap.Insert(3.3F);
        var key4 = slotMap.Insert(4.4F);
        var key5 = slotMap.Insert(5.5F);

        slotMap.Retain((key, value) => value != 6.6F);

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllFloatNullableItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.1F);
        var key3 = slotMap.Insert(2.2F);
        var key4 = slotMap.Insert(3.3F);
        var key5 = slotMap.Insert(4.4F);
        

        slotMap.Retain((key, value) => value == 5.5F);

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllFloatNullableItems_ItemsRetained()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.1F);
        var key3 = slotMap.Insert(2.2F);
        var key4 = slotMap.Insert(3.3F);
        var key5 = slotMap.Insert(4.4F);

        slotMap.Retain((key, value) => value != 5.5F);

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDecimalItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Insert(1.111_111_111M);
        var key2 = slotMap.Insert(2.222_222_222M);
        var key3 = slotMap.Insert(3.333_333_333M);
        var key4 = slotMap.Insert(4.444_444_444M);
        var key5 = slotMap.Insert(5.555_555_555M);
        

        slotMap.Retain((key, value) => value == 6.666_666_666M);

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllDecimalItems_ItemsRetained()
    {
        var slotMap = new SlotMap<decimal>();
        var key1 = slotMap.Insert(1.111_111_111M);
        var key2 = slotMap.Insert(2.222_222_222M);
        var key3 = slotMap.Insert(3.333_333_333M);
        var key4 = slotMap.Insert(4.444_444_444M);
        var key5 = slotMap.Insert(5.555_555_555M);

        slotMap.Retain((key, value) => value != 6.666_666_666M);

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDecimalNullableItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.111_111_111M);
        var key3 = slotMap.Insert(2.222_222_222M);
        var key4 = slotMap.Insert(3.333_333_333M);
        var key5 = slotMap.Insert(4.444_444_444M);
        

        slotMap.Retain((key, value) => value == 5.555_555_555M);

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllDecimalNullableItems_ItemsRetained()
    {
        var slotMap = new SlotMap<decimal?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.111_111_111M);
        var key3 = slotMap.Insert(2.222_222_222M);
        var key4 = slotMap.Insert(3.333_333_333M);
        var key5 = slotMap.Insert(4.444_444_444M);

        slotMap.Retain((key, value) => value != 5.555_555_555M);

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDateTimeItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Insert(DateTime.Parse("2023-02-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-03-01"));
        var key4 = slotMap.Insert(DateTime.Parse("2023-04-01"));
        var key5 = slotMap.Insert(DateTime.Parse("2023-05-01"));
        

        slotMap.Retain((key, value) => value == DateTime.Parse("2023-06-01"));

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllDateTimeItems_ItemsRetained()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Insert(DateTime.Parse("2023-02-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-03-01"));
        var key4 = slotMap.Insert(DateTime.Parse("2023-04-01"));
        var key5 = slotMap.Insert(DateTime.Parse("2023-05-01"));

        slotMap.Retain((key, value) => value != DateTime.Parse("2023-06-01"));

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDateTimeNullableItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-02-01"));
        var key4 = slotMap.Insert(DateTime.Parse("2023-03-01"));
        var key5 = slotMap.Insert(DateTime.Parse("2023-04-01"));
        

        slotMap.Retain((key, value) => value == DateTime.Parse("2023-05-01"));

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllDateTimeNullableItems_ItemsRetained()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-02-01"));
        var key4 = slotMap.Insert(DateTime.Parse("2023-03-01"));
        var key5 = slotMap.Insert(DateTime.Parse("2023-04-01"));

        slotMap.Retain((key, value) => value != DateTime.Parse("2023-05-01"));

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllTimeSpanItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Insert(new TimeSpan(00,00,00));
        var key2 = slotMap.Insert(new TimeSpan(01,00,00));
        var key3 = slotMap.Insert(new TimeSpan(02,00,00));
        var key4 = slotMap.Insert(new TimeSpan(03,00,00));
        var key5 = slotMap.Insert(new TimeSpan(04,00,00));
        

        slotMap.Retain((key, value) => value == new TimeSpan(05,00,00));

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllTimeSpanItems_ItemsRetained()
    {
        var slotMap = new SlotMap<TimeSpan>();
        var key1 = slotMap.Insert(new TimeSpan(00,00,00));
        var key2 = slotMap.Insert(new TimeSpan(01,00,00));
        var key3 = slotMap.Insert(new TimeSpan(02,00,00));
        var key4 = slotMap.Insert(new TimeSpan(03,00,00));
        var key5 = slotMap.Insert(new TimeSpan(04,00,00));

        slotMap.Retain((key, value) => value != new TimeSpan(05,00,00));

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllTimeSpanNullableItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(new TimeSpan(00,00,00));
        var key3 = slotMap.Insert(new TimeSpan(01,00,00));
        var key4 = slotMap.Insert(new TimeSpan(02,00,00));
        var key5 = slotMap.Insert(new TimeSpan(03,00,00));
        

        slotMap.Retain((key, value) => value == new TimeSpan(04,00,00));

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllTimeSpanNullableItems_ItemsRetained()
    {
        var slotMap = new SlotMap<TimeSpan?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(new TimeSpan(00,00,00));
        var key3 = slotMap.Insert(new TimeSpan(01,00,00));
        var key4 = slotMap.Insert(new TimeSpan(02,00,00));
        var key5 = slotMap.Insert(new TimeSpan(03,00,00));

        slotMap.Retain((key, value) => value != new TimeSpan(04,00,00));

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllGuidItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key3 = slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key4 = slotMap.Insert(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        var key5 = slotMap.Insert(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));
        

        slotMap.Retain((key, value) => value == Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllGuidItems_ItemsRetained()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key3 = slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key4 = slotMap.Insert(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        var key5 = slotMap.Insert(Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        slotMap.Retain((key, value) => value != Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

        Assert.Equal(5, slotMap.Count);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllGuidNullableItems_NoItemsRetained()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key3 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key4 = slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key5 = slotMap.Insert(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        

        slotMap.Retain((key, value) => value == Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        Assert.Empty(slotMap);
    }

    [Fact]
    public void PredicateKeepsAllGuidNullableItems_ItemsRetained()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key3 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key4 = slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        var key5 = slotMap.Insert(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));

        slotMap.Retain((key, value) => value != Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        Assert.Equal(5, slotMap.Count);
    }

}