using MediatR;

namespace CQRS.Products.CreateProduct;
public sealed record CreateProductCommand(string Name, decimal Price): IRequest<List<CreateProductCommandResponse>>;
