namespace CQRS.Products.CreateProduct;

public sealed record CreateProductCommandResponse(int Id, string Name, decimal Price);