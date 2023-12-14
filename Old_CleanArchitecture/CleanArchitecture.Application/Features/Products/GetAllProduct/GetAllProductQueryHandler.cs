using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Features.Products.GetAllProduct;

public sealed class GetAllProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetAllProductQuery, List<Product>>
{
    public async Task<List<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        return await productRepository.GetAll().ToListAsync(cancellationToken);
    }
}
