namespace DDD.Products;
public interface IProductRepository
{
    void Add(Product product);
    List<Product> GetAll(); 
}
