using MediatR;

namespace CleanArchitecture.Application.Features.Products.AddProduct;
public sealed record AddProductCommand(
    string Name,
    decimal Price,
    Guid CategoryId) : IRequest<Guid>;
