using AutoMapper;
using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Features.Products.UpdateProduct;

public sealed class UpdateProductCommandHandler(
    IProductRepository productRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<UpdateProductCommand>
{
    public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        Product? product = await productRepository.GetAll().FirstOrDefaultAsync(p=> p.Id == request.Id, cancellationToken); 

        if(product is not null)
        {
            mapper.Map(request, product);

            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
