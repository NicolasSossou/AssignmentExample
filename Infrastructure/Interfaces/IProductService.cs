using Infrastructure.Models;

namespace Infrastructure.Interfaces;

public interface IProductService
{

    ProductResult AddProductToList(Product product);
   ProductResult<IEnumerable<Product>> GetAllProducts(); // Så att den returnerar en lista av produkter se till att vänja dig med detta//
    
}
