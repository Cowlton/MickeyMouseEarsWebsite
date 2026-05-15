namespace MickeyEarsShopWebsite.Models;

public class Product
{

    public Product()
    {
    }
    
    public int ProductId { get; set; }
    public string Name { get; set; }
    public bool Available  { get; set; }
    public int PrimaryImageId { get; set; }
    public int SecondaryImageId { get; set; }
    public bool InStock { get; set; }
    
}