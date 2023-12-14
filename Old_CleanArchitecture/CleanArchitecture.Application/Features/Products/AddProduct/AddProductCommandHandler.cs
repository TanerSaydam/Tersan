using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.Products.AddProduct;

public sealed class AddProductCommandHandler(IProductRepository productRepository) : IRequestHandler<AddProductCommand, Guid>
{
    public async Task<Guid> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        bool isNameExists = await productRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);
        if (isNameExists)
        {
            throw new ProductNameExistsException();
        }

        Product product = new()
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Price = request.Price,
            CategoryId = request.CategoryId
        };

        await productRepository.AddSaveAsync(product, cancellationToken);

        return product.Id;
    }
}
