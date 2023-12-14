using MediatR;

namespace CleanArchitecture.Application.Features.Products.UpdateProduct;
public sealed record UpdateProductCommand(
    Guid Id,
    string Name,
    decimal Price): IRequest;
