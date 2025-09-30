namespace Infrastructure1.Models;

public class Product
{
    public string Id { get; set; } = null!;
    public string? ArticleNumber { get; set; }
    public string ProductTitle { get; set; } = null!; 
    public string? ProductDescription { get; set; }=null!;
    public string Unit {  get; set; } = null!;
    public decimal UnitPrice { get; set; }

}

public class  ProductCreateRequest
{
    
}

public class ProductViewModel
{

}
public class ProductModel
{

}