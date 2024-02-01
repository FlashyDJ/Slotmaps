//////////////////////////////////////////|WARNING|///////////////////////////////////////////
//		    			        GENERATED CODE - DO NOT MODIFY      		    	  		//
//    Changes will not be permanent. Update the T4 template files instead. (*.t4) (*.tt)    //
//////////////////////////////////////////////////////////////////////////////////////////////
namespace Slotmaps.Tests.SlotMap;

public class ContainsValue
{
    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int                                          //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<int>();
        slotMap.Insert(10);
        slotMap.Insert(20);
        slotMap.Insert(30);

        var result1 = slotMap.ContainsValue(10);
        var result2 = slotMap.ContainsValue(20);
        var result3 = slotMap.ContainsValue(30);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void IntValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<int>();
        var key1 = slotMap.Insert(10);
        var key2 = slotMap.Insert(20);
        var key3 = slotMap.Insert(30);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(10);
        var result2 = slotMap.ContainsValue(20);
        var result3 = slotMap.ContainsValue(30);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void IntValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<int>();
        slotMap.Insert(10);
        slotMap.Insert(20);
        slotMap.Insert(30);

        var result = slotMap.ContainsValue(40);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         int?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void IntNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<int?>();
        slotMap.Insert(null);
        slotMap.Insert(10);
        slotMap.Insert(20);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(10);
        var result3 = slotMap.ContainsValue(20);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void IntNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<int?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(10);
        var key3 = slotMap.Insert(20);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(10);
        var result3 = slotMap.ContainsValue(20);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void IntNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<int?>();
        slotMap.Insert(null);
        slotMap.Insert(10);
        slotMap.Insert(20);

        var result = slotMap.ContainsValue(30);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        string                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<string>();
        slotMap.Insert("Value 1");
        slotMap.Insert("Value 2");
        slotMap.Insert("Value 3");

        var result1 = slotMap.ContainsValue("Value 1");
        var result2 = slotMap.ContainsValue("Value 2");
        var result3 = slotMap.ContainsValue("Value 3");

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void StringValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<string>();
        var key1 = slotMap.Insert("Value 1");
        var key2 = slotMap.Insert("Value 2");
        var key3 = slotMap.Insert("Value 3");

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue("Value 1");
        var result2 = slotMap.ContainsValue("Value 2");
        var result3 = slotMap.ContainsValue("Value 3");

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void StringValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<string>();
        slotMap.Insert("Value 1");
        slotMap.Insert("Value 2");
        slotMap.Insert("Value 3");

        var result = slotMap.ContainsValue("Value 4");

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       string?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void StringNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<string?>();
        slotMap.Insert(null);
        slotMap.Insert("Value 1");
        slotMap.Insert("Value 2");

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue("Value 1");
        var result3 = slotMap.ContainsValue("Value 2");

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void StringNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<string?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert("Value 1");
        var key3 = slotMap.Insert("Value 2");

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue("Value 1");
        var result3 = slotMap.ContainsValue("Value 2");

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void StringNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<string?>();
        slotMap.Insert(null);
        slotMap.Insert("Value 1");
        slotMap.Insert("Value 2");

        var result = slotMap.ContainsValue("Value 3");

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<float>();
        slotMap.Insert(1.1F);
        slotMap.Insert(2.2F);
        slotMap.Insert(3.3F);

        var result1 = slotMap.ContainsValue(1.1F);
        var result2 = slotMap.ContainsValue(2.2F);
        var result3 = slotMap.ContainsValue(3.3F);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void FloatValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<float>();
        var key1 = slotMap.Insert(1.1F);
        var key2 = slotMap.Insert(2.2F);
        var key3 = slotMap.Insert(3.3F);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(1.1F);
        var result2 = slotMap.ContainsValue(2.2F);
        var result3 = slotMap.ContainsValue(3.3F);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void FloatValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<float>();
        slotMap.Insert(1.1F);
        slotMap.Insert(2.2F);
        slotMap.Insert(3.3F);

        var result = slotMap.ContainsValue(4.4F);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        float?                                        //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void FloatNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<float?>();
        slotMap.Insert(null);
        slotMap.Insert(1.1F);
        slotMap.Insert(2.2F);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(1.1F);
        var result3 = slotMap.ContainsValue(2.2F);

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void FloatNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<float?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(1.1F);
        var key3 = slotMap.Insert(2.2F);

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(1.1F);
        var result3 = slotMap.ContainsValue(2.2F);

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void FloatNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<float?>();
        slotMap.Insert(null);
        slotMap.Insert(1.1F);
        slotMap.Insert(2.2F);

        var result = slotMap.ContainsValue(3.3F);

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                       DateTime                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<DateTime>();
        slotMap.Insert(DateTime.Parse("2023-01-01"));
        slotMap.Insert(DateTime.Parse("2023-02-01"));
        slotMap.Insert(DateTime.Parse("2023-03-01"));

        var result1 = slotMap.ContainsValue(DateTime.Parse("2023-01-01"));
        var result2 = slotMap.ContainsValue(DateTime.Parse("2023-02-01"));
        var result3 = slotMap.ContainsValue(DateTime.Parse("2023-03-01"));

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void DateTimeValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<DateTime>();
        var key1 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key2 = slotMap.Insert(DateTime.Parse("2023-02-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-03-01"));

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(DateTime.Parse("2023-01-01"));
        var result2 = slotMap.ContainsValue(DateTime.Parse("2023-02-01"));
        var result3 = slotMap.ContainsValue(DateTime.Parse("2023-03-01"));

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void DateTimeValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<DateTime>();
        slotMap.Insert(DateTime.Parse("2023-01-01"));
        slotMap.Insert(DateTime.Parse("2023-02-01"));
        slotMap.Insert(DateTime.Parse("2023-03-01"));

        var result = slotMap.ContainsValue(DateTime.Parse("2023-04-01"));

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                      DateTime?                                       //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void DateTimeNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<DateTime?>();
        slotMap.Insert(null);
        slotMap.Insert(DateTime.Parse("2023-01-01"));
        slotMap.Insert(DateTime.Parse("2023-02-01"));

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(DateTime.Parse("2023-01-01"));
        var result3 = slotMap.ContainsValue(DateTime.Parse("2023-02-01"));

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void DateTimeNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<DateTime?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(DateTime.Parse("2023-01-01"));
        var key3 = slotMap.Insert(DateTime.Parse("2023-02-01"));

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(DateTime.Parse("2023-01-01"));
        var result3 = slotMap.ContainsValue(DateTime.Parse("2023-02-01"));

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void DateTimeNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<DateTime?>();
        slotMap.Insert(null);
        slotMap.Insert(DateTime.Parse("2023-01-01"));
        slotMap.Insert(DateTime.Parse("2023-02-01"));

        var result = slotMap.ContainsValue(DateTime.Parse("2023-03-01"));

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                         Guid                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<Guid>();
        slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        var result1 = slotMap.ContainsValue(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var result2 = slotMap.ContainsValue(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var result3 = slotMap.ContainsValue(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void GuidValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<Guid>();
        var key1 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key2 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var key3 = slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var result2 = slotMap.ContainsValue(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        var result3 = slotMap.ContainsValue(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void GuidValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<Guid>();
        slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));
        slotMap.Insert(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        var result = slotMap.ContainsValue(Guid.Parse("D31CCB20-ECBE-4349-BEAA-BC56A0E0B731"));

        Assert.False(result);
    }

    //////////////////////////////////////////////////////////////////////////////////////////
    //                                        Guid?                                         //
    //////////////////////////////////////////////////////////////////////////////////////////

    [Fact]
    public void GuidNullableValueExists_ReturnsTrue()
    {
        var slotMap = new SlotMap<Guid?>();
        slotMap.Insert(null);
        slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var result3 = slotMap.ContainsValue(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        Assert.True(result1);
        Assert.True(result2);
        Assert.True(result3);
    }

    [Fact]
    public void GuidNullableValueRemoved_ReturnsFalse()
    {
        var slotMap = new SlotMap<Guid?>();
        var key1 = slotMap.Insert(null);
        var key2 = slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var key3 = slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        slotMap.Remove(key1);
        slotMap.Remove(key2);
        slotMap.Remove(key3);

        var result1 = slotMap.ContainsValue(null);
        var result2 = slotMap.ContainsValue(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        var result3 = slotMap.ContainsValue(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        Assert.False(result1);
        Assert.False(result2);
        Assert.False(result3);
    }

    [Fact]
    public void GuidNullableValueDoesNotExist_ReturnsFalse()
    {
        var slotMap = new SlotMap<Guid?>();
        slotMap.Insert(null);
        slotMap.Insert(Guid.Parse("A7CDEB8A-62A7-4AC6-90F6-8344309736DE"));
        slotMap.Insert(Guid.Parse("B9EAA78E-3CE3-4F19-85BF-C9F8F8D6C407"));

        var result = slotMap.ContainsValue(Guid.Parse("C5E20F5C-BB26-4F71-AD26-5A7B6E785FFE"));

        Assert.False(result);
    }

}