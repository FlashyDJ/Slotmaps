//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SparseSecondaryMap;

public class Retain
{
    [Fact]
    public void PredicateRemovesSomeItems_ItemsThatSatisfyPredicateAreRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, 42);
        sparseSecondaryMap.Insert(key2, 24);
        sparseSecondaryMap.Insert(key3, 36);
        sparseSecondaryMap.Insert(key4, 50);
        sparseSecondaryMap.Insert(key5, 18);

        sparseSecondaryMap.Retain((key, value) => value > 30);

        Assert.Equal(3, sparseSecondaryMap.Count);
        Assert.Equal(42, sparseSecondaryMap[key1]);
        Assert.Equal(36, sparseSecondaryMap[key3]);
        Assert.Equal(50, sparseSecondaryMap[key4]);
        Assert.False(sparseSecondaryMap.ContainsKey(key2));
        Assert.False(sparseSecondaryMap.ContainsKey(key5));
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllIntItems_NoItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, 10);
        sparseSecondaryMap.Insert(key2, 20);
        sparseSecondaryMap.Insert(key3, 30);
        sparseSecondaryMap.Insert(key4, 40);
        sparseSecondaryMap.Insert(key5, 50);

        sparseSecondaryMap.Retain((key, value) => value == 60);

        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllIntItems_ItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, 10);
        sparseSecondaryMap.Insert(key2, 20);
        sparseSecondaryMap.Insert(key3, 30);
        sparseSecondaryMap.Insert(key4, 40);
        sparseSecondaryMap.Insert(key5, 50);

        sparseSecondaryMap.Retain((key, value) => value != 60);

        Assert.Equal(5, sparseSecondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllIntNullableItems_NoItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 10);
        sparseSecondaryMap.Insert(key3, 20);
        sparseSecondaryMap.Insert(key4, 30);
        sparseSecondaryMap.Insert(key5, 40);

        sparseSecondaryMap.Retain((key, value) => value == 50);

        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllIntNullableItems_ItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<int?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 10);
        sparseSecondaryMap.Insert(key3, 20);
        sparseSecondaryMap.Insert(key4, 30);
        sparseSecondaryMap.Insert(key5, 40);

        sparseSecondaryMap.Retain((key, value) => value != 50);

        Assert.Equal(5, sparseSecondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllStringItems_NoItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, "Value 1");
        sparseSecondaryMap.Insert(key2, "Value 2");
        sparseSecondaryMap.Insert(key3, "Value 3");
        sparseSecondaryMap.Insert(key4, "Value 4");
        sparseSecondaryMap.Insert(key5, "Value 5");

        sparseSecondaryMap.Retain((key, value) => value == "Value 6");

        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllStringItems_ItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, "Value 1");
        sparseSecondaryMap.Insert(key2, "Value 2");
        sparseSecondaryMap.Insert(key3, "Value 3");
        sparseSecondaryMap.Insert(key4, "Value 4");
        sparseSecondaryMap.Insert(key5, "Value 5");

        sparseSecondaryMap.Retain((key, value) => value != "Value 6");

        Assert.Equal(5, sparseSecondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllStringNullableItems_NoItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, "Value 1");
        sparseSecondaryMap.Insert(key3, "Value 2");
        sparseSecondaryMap.Insert(key4, "Value 3");
        sparseSecondaryMap.Insert(key5, "Value 4");

        sparseSecondaryMap.Retain((key, value) => value == "Value 5");

        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllStringNullableItems_ItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<string?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, "Value 1");
        sparseSecondaryMap.Insert(key3, "Value 2");
        sparseSecondaryMap.Insert(key4, "Value 3");
        sparseSecondaryMap.Insert(key5, "Value 4");

        sparseSecondaryMap.Retain((key, value) => value != "Value 5");

        Assert.Equal(5, sparseSecondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllFloatItems_NoItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, 1.1F);
        sparseSecondaryMap.Insert(key2, 2.2F);
        sparseSecondaryMap.Insert(key3, 3.3F);
        sparseSecondaryMap.Insert(key4, 4.4F);
        sparseSecondaryMap.Insert(key5, 5.5F);

        sparseSecondaryMap.Retain((key, value) => value == 6.6F);

        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllFloatItems_ItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, 1.1F);
        sparseSecondaryMap.Insert(key2, 2.2F);
        sparseSecondaryMap.Insert(key3, 3.3F);
        sparseSecondaryMap.Insert(key4, 4.4F);
        sparseSecondaryMap.Insert(key5, 5.5F);

        sparseSecondaryMap.Retain((key, value) => value != 6.6F);

        Assert.Equal(5, sparseSecondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllFloatNullableItems_NoItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.1F);
        sparseSecondaryMap.Insert(key3, 2.2F);
        sparseSecondaryMap.Insert(key4, 3.3F);
        sparseSecondaryMap.Insert(key5, 4.4F);

        sparseSecondaryMap.Retain((key, value) => value == 5.5F);

        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllFloatNullableItems_ItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<float?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, 1.1F);
        sparseSecondaryMap.Insert(key3, 2.2F);
        sparseSecondaryMap.Insert(key4, 3.3F);
        sparseSecondaryMap.Insert(key5, 4.4F);

        sparseSecondaryMap.Retain((key, value) => value != 5.5F);

        Assert.Equal(5, sparseSecondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDateTimeItems_NoItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-03-01"));
        sparseSecondaryMap.Insert(key4, DateTime.Parse("2023-04-01"));
        sparseSecondaryMap.Insert(key5, DateTime.Parse("2023-05-01"));

        sparseSecondaryMap.Retain((key, value) => value == DateTime.Parse("2023-06-01"));

        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllDateTimeItems_ItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-02-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-03-01"));
        sparseSecondaryMap.Insert(key4, DateTime.Parse("2023-04-01"));
        sparseSecondaryMap.Insert(key5, DateTime.Parse("2023-05-01"));

        sparseSecondaryMap.Retain((key, value) => value != DateTime.Parse("2023-06-01"));

        Assert.Equal(5, sparseSecondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllDateTimeNullableItems_NoItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-02-01"));
        sparseSecondaryMap.Insert(key4, DateTime.Parse("2023-03-01"));
        sparseSecondaryMap.Insert(key5, DateTime.Parse("2023-04-01"));

        sparseSecondaryMap.Retain((key, value) => value == DateTime.Parse("2023-05-01"));

        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllDateTimeNullableItems_ItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<DateTime?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, DateTime.Parse("2023-01-01"));
        sparseSecondaryMap.Insert(key3, DateTime.Parse("2023-02-01"));
        sparseSecondaryMap.Insert(key4, DateTime.Parse("2023-03-01"));
        sparseSecondaryMap.Insert(key5, DateTime.Parse("2023-04-01"));

        sparseSecondaryMap.Retain((key, value) => value != DateTime.Parse("2023-05-01"));

        Assert.Equal(5, sparseSecondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllGuidItems_NoItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        sparseSecondaryMap.Insert(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        sparseSecondaryMap.Insert(key5, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        sparseSecondaryMap.Retain((key, value) => value == Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllGuidItems_ItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key2, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        sparseSecondaryMap.Insert(key4, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));
        sparseSecondaryMap.Insert(key5, Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        sparseSecondaryMap.Retain((key, value) => value != Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F46"));

        Assert.Equal(5, sparseSecondaryMap.Count);
    }
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void PredicateRemovesAllGuidNullableItems_NoItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        sparseSecondaryMap.Insert(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        sparseSecondaryMap.Insert(key5, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));

        sparseSecondaryMap.Retain((key, value) => value == Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        Assert.Empty(sparseSecondaryMap);
    }

    [Fact]
    public void PredicateKeepsAllGuidNullableItems_ItemsRetained()
    {
        var sparseSecondaryMap = new SparseSecondaryMap<Guid?>();
        var key1 = new SlotKey(1, 1);
        var key2 = new SlotKey(2, 1);
        var key3 = new SlotKey(3, 1);
        var key4 = new SlotKey(4, 1);
        var key5 = new SlotKey(5, 1);
        sparseSecondaryMap.Insert(key1, null);
        sparseSecondaryMap.Insert(key2, Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        sparseSecondaryMap.Insert(key3, Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        sparseSecondaryMap.Insert(key4, Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));
        sparseSecondaryMap.Insert(key5, Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));

        sparseSecondaryMap.Retain((key, value) => value != Guid.Parse("E2E85D84-FAFE-44E9-A14C-78D50C207F45"));

        Assert.Equal(5, sparseSecondaryMap.Count);
    }
}