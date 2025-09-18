
namespace Infrastructure.Models;

public class ProductResult
{
  public bool Success { get; set; }
    public string? Error { get; set; }
    public Product? Content { get; set; }

}

public class ProductResult<T> : ProductResult
{
    public new T? Content { get; set; }

}