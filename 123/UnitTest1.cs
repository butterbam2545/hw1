namespace UnitTest1;

public class UnitTest1
{
    [Fact]
    public void NameTest(){
        var shop = new shop("bam", 100,"shop",10000);
        Assert.Equal("bam", shop.Name);
    }
    [Fact]
    public void NumberTest(){
        var shop = new shop("bam", 100,"shop",10000);
        shop.Number += 100;
        Assert.Equal("200", shop.Number);
    }
    [Fact]
    public void OwnerNameTest(){
        var shop = new shop("bam", 100,"shop",10000);
        Assert.Equal("shop", shop.Name);
    }
    [Fact]
    public void RegisteredValueTest(){
        var shop = new shop("bam", 100,"shop",10000);
        Assert.Equal("200000", shop.RegisteredValue);
    }
}
