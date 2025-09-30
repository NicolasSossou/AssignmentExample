namespace Infrastructure1.Models;

public class Product
{
    public string Id { get; set; } = null!;
    public string? ArticleNumber { get; set; }
    public string ProductTitle { get; set; } = null!; 
    public string? ProductDescription { get; set; }=null!;
 

}
public class Unit
{ 
public int Id { get; set; }
    public string UnitName { get; set; } = null!;
}
public class ProductPrice
{
    public Product Product { get; set; } = null!;
    public Unit Unit { get; set; } = null!;
    public decimal UnitPrice { get; set; }

}
public class ProductSku
{ 
public Product Product { get; set; } = null!;

    public int Quantity { get; set; }
}

public class  ProductCreateRequest
{
    public string? ArticleNumber { get; set; }
    public bool? IsService { get; set; }
    public string ProductTitle { get; set; } = null!;
    public string? ProductDescription { get; set; } = null!;
    public string Unit { get; set; } = null!;
    public decimal UnitPrice { get; set; }
}

public class ProductViewModel
{

}
public class ProductModel
{

}
