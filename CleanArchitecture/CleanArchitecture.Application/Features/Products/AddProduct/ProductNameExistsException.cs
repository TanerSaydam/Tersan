namespace CleanArchitecture.Application.Features.Products.AddProduct;

public sealed class ProductNameExistsException: Exception
{
    public ProductNameExistsException() : base("Bu ürün adı daha önce kullanılmış")
    {
        
    }
}
