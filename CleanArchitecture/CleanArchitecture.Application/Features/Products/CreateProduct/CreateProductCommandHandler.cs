using AutoMapper;
using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.Products.CreateProduct;

public sealed class CreateProductCommandHandler(
    IProductRepository productRepository, 
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateProductCommand>
{
    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        Product product = mapper.Map<Product>(request);
        product.CreatedDate = DateTime.Now;

        await productRepository.CreateAsync(product, cancellationToken).ConfigureAwait(false); ;
        await unitOfWork.SaveChangesAsync().ConfigureAwait(false);
    }
}