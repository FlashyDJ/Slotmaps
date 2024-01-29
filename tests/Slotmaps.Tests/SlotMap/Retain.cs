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