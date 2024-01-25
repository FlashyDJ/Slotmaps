//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////

namespace Slotmaps.Tests.SecondaryMap;
public class Retain
{
    [Fact]
    public void PredicateRemovesSomeItems_ItemsThatSatisfyPredicateAreRetained()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 42);
        secondaryMap.Insert(key2, 24);
        secondaryMap.Insert(key3, 36);
        secondaryMap.Insert(key4, 50);
        secondaryMap.Insert(key5, 18);

        secondaryMap.Retain((key, value) => value > 30);

        Assert.Equal(3, secondaryMap.Count);
        Assert.Equal(42, secondaryMap[key1]);
        Assert.Equal(36, secondaryMap[key3]);
        Assert.Equal(50, secondaryMap[key4]);
        Assert.False(secondaryMap.ContainsKey(key2));
        Assert.False(secondaryMap.ContainsKey(key5));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllIntItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 10);
        secondaryMap.Insert(key2, 20);
        secondaryMap.Insert(key3, 30);
        secondaryMap.Insert(key4, 40);
        secondaryMap.Insert(key5, 50);

        secondaryMap.Retain((key, value) => value == 60);

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllIntItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 10);
        secondaryMap.Insert(key2, 20);
        secondaryMap.Insert(key3, 30);
        secondaryMap.Insert(key4, 40);
        secondaryMap.Insert(key5, 50);

        secondaryMap.Retain((key, value) => value != 60);

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllIntNullableItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 10);
        secondaryMap.Insert(key3, 20);
        secondaryMap.Insert(key4, 30);
        secondaryMap.Insert(key5, 40);

        secondaryMap.Retain((key, value) => value == 50);

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllIntNullableItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 10);
        secondaryMap.Insert(key3, 20);
        secondaryMap.Insert(key4, 30);
        secondaryMap.Insert(key5, 40);

        secondaryMap.Retain((key, value) => value != 50);

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllStringItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, "Value 1");
        secondaryMap.Insert(key2, "Value 2");
        secondaryMap.Insert(key3, "Value 3");
        secondaryMap.Insert(key4, "Value 4");
        secondaryMap.Insert(key5, "Value 5");

        secondaryMap.Retain((key, value) => value == "Value 6");

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllStringItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, "Value 1");
        secondaryMap.Insert(key2, "Value 2");
        secondaryMap.Insert(key3, "Value 3");
        secondaryMap.Insert(key4, "Value 4");
        secondaryMap.Insert(key5, "Value 5");

        secondaryMap.Retain((key, value) => value != "Value 6");

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllStringNullableItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, "Value 1");
        secondaryMap.Insert(key3, "Value 2");
        secondaryMap.Insert(key4, "Value 3");
        secondaryMap.Insert(key5, "Value 4");

        secondaryMap.Retain((key, value) => value == "Value 5");

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllStringNullableItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, "Value 1");
        secondaryMap.Insert(key3, "Value 2");
        secondaryMap.Insert(key4, "Value 3");
        secondaryMap.Insert(key5, "Value 4");

        secondaryMap.Retain((key, value) => value != "Value 5");

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        double                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDoubleItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 1.11D);
        secondaryMap.Insert(key2, 2.22D);
        secondaryMap.Insert(key3, 3.33D);
        secondaryMap.Insert(key4, 4.44D);
        secondaryMap.Insert(key5, 5.55D);

        secondaryMap.Retain((key, value) => value == 6.66D);

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllDoubleItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<double>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 1.11D);
        secondaryMap.Insert(key2, 2.22D);
        secondaryMap.Insert(key3, 3.33D);
        secondaryMap.Insert(key4, 4.44D);
        secondaryMap.Insert(key5, 5.55D);

        secondaryMap.Retain((key, value) => value != 6.66D);

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       double?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDoubleNullableItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.11D);
        secondaryMap.Insert(key3, 2.22D);
        secondaryMap.Insert(key4, 3.33D);
        secondaryMap.Insert(key5, 4.44D);

        secondaryMap.Retain((key, value) => value == 5.55D);

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllDoubleNullableItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<double?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.11D);
        secondaryMap.Insert(key3, 2.22D);
        secondaryMap.Insert(key4, 3.33D);
        secondaryMap.Insert(key5, 4.44D);

        secondaryMap.Retain((key, value) => value != 5.55D);

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         bool                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllBoolItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, true);
        secondaryMap.Insert(key2, false);
        secondaryMap.Insert(key3, true);
        secondaryMap.Insert(key4, false);
        secondaryMap.Insert(key5, true);

#pragma warning disable CS0184 // 'is' expression's given expression is never of the provided type
        secondaryMap.Retain((key, value) => value is int);
#pragma warning restore CS0184 // 'is' expression's given expression is never of the provided type

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllBoolItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<bool>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, true);
        secondaryMap.Insert(key2, false);
        secondaryMap.Insert(key3, true);
        secondaryMap.Insert(key4, false);
        secondaryMap.Insert(key5, true);

#pragma warning disable CS0183 // 'is' expression's given expression is always of the provided type
        secondaryMap.Retain((key, value) => value is bool);
#pragma warning restore CS0183 // 'is' expression's given expression is always of the provided type

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        bool?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllBoolNullableItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, true);
        secondaryMap.Insert(key3, false);
        secondaryMap.Insert(key4, null);
        secondaryMap.Insert(key5, true);

#pragma warning disable CS0184 // 'is' expression's given expression is never of the provided type
        secondaryMap.Retain((key, value) => value is int);
#pragma warning restore CS0184 // 'is' expression's given expression is never of the provided type

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllBoolNullableItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<bool?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, true);
        secondaryMap.Insert(key3, false);
        secondaryMap.Insert(key4, null);
        secondaryMap.Insert(key5, true);

#pragma warning disable CS8794 // The input always matches the provided pattern.
        secondaryMap.Retain((key, value) => value is bool or null);
#pragma warning restore CS8794 // The input always matches the provided pattern.

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         char                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllCharItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 'A');
        secondaryMap.Insert(key2, 'B');
        secondaryMap.Insert(key3, 'C');
        secondaryMap.Insert(key4, 'D');
        secondaryMap.Insert(key5, 'E');

        secondaryMap.Retain((key, value) => value == 'F');

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllCharItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<char>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 'A');
        secondaryMap.Insert(key2, 'B');
        secondaryMap.Insert(key3, 'C');
        secondaryMap.Insert(key4, 'D');
        secondaryMap.Insert(key5, 'E');

        secondaryMap.Retain((key, value) => value != 'F');

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        char?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllCharNullableItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 'A');
        secondaryMap.Insert(key3, 'B');
        secondaryMap.Insert(key4, 'C');
        secondaryMap.Insert(key5, 'D');

        secondaryMap.Retain((key, value) => value == 'E');

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllCharNullableItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<char?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 'A');
        secondaryMap.Insert(key3, 'B');
        secondaryMap.Insert(key4, 'C');
        secondaryMap.Insert(key5, 'D');

        secondaryMap.Retain((key, value) => value != 'E');

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         long                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllLongItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 1000_000_000_000L);
        secondaryMap.Insert(key2, 2000_000_000_000L);
        secondaryMap.Insert(key3, 3000_000_000_000L);
        secondaryMap.Insert(key4, 4000_000_000_000L);
        secondaryMap.Insert(key5, 5000_000_000_000L);

        secondaryMap.Retain((key, value) => value == 6000_000_000_000L);

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllLongItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<long>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 1000_000_000_000L);
        secondaryMap.Insert(key2, 2000_000_000_000L);
        secondaryMap.Insert(key3, 3000_000_000_000L);
        secondaryMap.Insert(key4, 4000_000_000_000L);
        secondaryMap.Insert(key5, 5000_000_000_000L);

        secondaryMap.Retain((key, value) => value != 6000_000_000_000L);

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        long?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllLongNullableItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1000_000_000_000L);
        secondaryMap.Insert(key3, 2000_000_000_000L);
        secondaryMap.Insert(key4, 3000_000_000_000L);
        secondaryMap.Insert(key5, 4000_000_000_000L);

        secondaryMap.Retain((key, value) => value == 5000_000_000_000L);

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllLongNullableItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<long?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1000_000_000_000L);
        secondaryMap.Insert(key3, 2000_000_000_000L);
        secondaryMap.Insert(key4, 3000_000_000_000L);
        secondaryMap.Insert(key5, 4000_000_000_000L);

        secondaryMap.Retain((key, value) => value != 5000_000_000_000L);

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllFloatItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 1.1F);
        secondaryMap.Insert(key2, 2.2F);
        secondaryMap.Insert(key3, 3.3F);
        secondaryMap.Insert(key4, 4.4F);
        secondaryMap.Insert(key5, 5.5F);

        secondaryMap.Retain((key, value) => value == 6.6F);

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllFloatItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 1.1F);
        secondaryMap.Insert(key2, 2.2F);
        secondaryMap.Insert(key3, 3.3F);
        secondaryMap.Insert(key4, 4.4F);
        secondaryMap.Insert(key5, 5.5F);

        secondaryMap.Retain((key, value) => value != 6.6F);

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllFloatNullableItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.1F);
        secondaryMap.Insert(key3, 2.2F);
        secondaryMap.Insert(key4, 3.3F);
        secondaryMap.Insert(key5, 4.4F);

        secondaryMap.Retain((key, value) => value == 5.5F);

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllFloatNullableItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.1F);
        secondaryMap.Insert(key3, 2.2F);
        secondaryMap.Insert(key4, 3.3F);
        secondaryMap.Insert(key5, 4.4F);

        secondaryMap.Retain((key, value) => value != 5.5F);

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDecimalItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 1.111_111_111M);
        secondaryMap.Insert(key2, 2.222_222_222M);
        secondaryMap.Insert(key3, 3.333_333_333M);
        secondaryMap.Insert(key4, 4.444_444_444M);
        secondaryMap.Insert(key5, 5.555_555_555M);

        secondaryMap.Retain((key, value) => value == 6.666_666_666M);

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllDecimalItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<decimal>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, 1.111_111_111M);
        secondaryMap.Insert(key2, 2.222_222_222M);
        secondaryMap.Insert(key3, 3.333_333_333M);
        secondaryMap.Insert(key4, 4.444_444_444M);
        secondaryMap.Insert(key5, 5.555_555_555M);

        secondaryMap.Retain((key, value) => value != 6.666_666_666M);

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       decimal?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDecimalNullableItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.111_111_111M);
        secondaryMap.Insert(key3, 2.222_222_222M);
        secondaryMap.Insert(key4, 3.333_333_333M);
        secondaryMap.Insert(key5, 4.444_444_444M);

        secondaryMap.Retain((key, value) => value == 5.555_555_555M);

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllDecimalNullableItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<decimal?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, 1.111_111_111M);
        secondaryMap.Insert(key3, 2.222_222_222M);
        secondaryMap.Insert(key4, 3.333_333_333M);
        secondaryMap.Insert(key5, 4.444_444_444M);

        secondaryMap.Retain((key, value) => value != 5.555_555_555M);

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDateTimeItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        secondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        secondaryMap.Insert(key3, DateTime.Parse("2023-03-01"));
        secondaryMap.Insert(key4, DateTime.Parse("2023-04-01"));
        secondaryMap.Insert(key5, DateTime.Parse("2023-05-01"));

        secondaryMap.Retain((key, value) => value == DateTime.Parse("2023-06-01"));

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllDateTimeItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        secondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        secondaryMap.Insert(key3, DateTime.Parse("2023-03-01"));
        secondaryMap.Insert(key4, DateTime.Parse("2023-04-01"));
        secondaryMap.Insert(key5, DateTime.Parse("2023-05-01"));

        secondaryMap.Retain((key, value) => value != DateTime.Parse("2023-06-01"));

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDateTimeNullableItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        secondaryMap.Insert(key3, DateTime.Parse("2023-02-01"));
        secondaryMap.Insert(key4, DateTime.Parse("2023-03-01"));
        secondaryMap.Insert(key5, DateTime.Parse("2023-04-01"));

        secondaryMap.Retain((key, value) => value == DateTime.Parse("2023-05-01"));

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllDateTimeNullableItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        secondaryMap.Insert(key3, DateTime.Parse("2023-02-01"));
        secondaryMap.Insert(key4, DateTime.Parse("2023-03-01"));
        secondaryMap.Insert(key5, DateTime.Parse("2023-04-01"));

        secondaryMap.Retain((key, value) => value != DateTime.Parse("2023-05-01"));

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       TimeSpan                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllTimeSpanItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));
        secondaryMap.Insert(key2, new TimeSpan(01,00,00));
        secondaryMap.Insert(key3, new TimeSpan(02,00,00));
        secondaryMap.Insert(key4, new TimeSpan(03,00,00));
        secondaryMap.Insert(key5, new TimeSpan(04,00,00));

        secondaryMap.Retain((key, value) => value == new TimeSpan(05,00,00));

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllTimeSpanItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<TimeSpan>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, new TimeSpan(00,00,00));
        secondaryMap.Insert(key2, new TimeSpan(01,00,00));
        secondaryMap.Insert(key3, new TimeSpan(02,00,00));
        secondaryMap.Insert(key4, new TimeSpan(03,00,00));
        secondaryMap.Insert(key5, new TimeSpan(04,00,00));

        secondaryMap.Retain((key, value) => value != new TimeSpan(05,00,00));

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      TimeSpan?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllTimeSpanNullableItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, new TimeSpan(00,00,00));
        secondaryMap.Insert(key3, new TimeSpan(01,00,00));
        secondaryMap.Insert(key4, new TimeSpan(02,00,00));
        secondaryMap.Insert(key5, new TimeSpan(03,00,00));

        secondaryMap.Retain((key, value) => value == new TimeSpan(04,00,00));

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllTimeSpanNullableItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<TimeSpan?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, new TimeSpan(00,00,00));
        secondaryMap.Insert(key3, new TimeSpan(01,00,00));
        secondaryMap.Insert(key4, new TimeSpan(02,00,00));
        secondaryMap.Insert(key5, new TimeSpan(03,00,00));

        secondaryMap.Retain((key, value) => value != new TimeSpan(04,00,00));

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllGuidItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        secondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        secondaryMap.Insert(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        secondaryMap.Insert(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        secondaryMap.Insert(key5, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        secondaryMap.Retain((key, value) => value == Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllGuidItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        secondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        secondaryMap.Insert(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        secondaryMap.Insert(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        secondaryMap.Insert(key5, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        secondaryMap.Retain((key, value) => value != Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

        Assert.Equal(5, secondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllGuidNullableItems_NoItemsRetained()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        secondaryMap.Insert(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        secondaryMap.Insert(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        secondaryMap.Insert(key5, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));

        secondaryMap.Retain((key, value) => value == Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        Assert.Empty(secondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllGuidNullableItems_ItemsRetained()
    {
        var secondaryMap = new SecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        secondaryMap.Insert(key1, null);
        secondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        secondaryMap.Insert(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        secondaryMap.Insert(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        secondaryMap.Insert(key5, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));

        secondaryMap.Retain((key, value) => value != Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        Assert.Equal(5, secondaryMap.Count);
    }
}