using MediatR;

namespace CleanArchitecture.Application.Features.Products.CreateProduct;
public sealed record CreateProductCommand(
    string Name,
    decimal Price) : IRequest;
