using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.Products.GetAllProduct;
public sealed record GetAllProductQuery(): IRequest<List<Product>>;
