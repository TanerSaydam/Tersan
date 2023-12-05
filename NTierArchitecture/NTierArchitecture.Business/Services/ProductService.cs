using ValidationResult = FluentValidation.Results.ValidationResult;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Dtos;
using NTierArchitecture.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace NTierArchitecture.Business.Services;
public sealed class ProductService : IProductService
{
    private readonly ProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;
    public ProductService(ProductRepository productRepository, IUnitOfWork unitOfWork)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task AddAsync(ProductAddDto request, CancellationToken cancellationToken = default)
    {
        ProductValidator validator = new();
        ValidationResult result = validator.Validate(request);

        if (!result.IsValid)
        {
            string errorMessages = string.Join("\n", result.Errors.Select(s => s.ErrorMessage));
            throw new ArgumentException(errorMessages);
        }

        if(await _productRepository.IsNameExistsAsync(request.Name, cancellationToken))
        {
            throw new ArgumentException("Bu ürün adı daha önce kullanılmış");

        }
        
        Product product = new()
        {
            Price = request.Price,
            Name = request.Name,
        };

        await _productRepository.AddAsync(product, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var response = await _productRepository.GetAll().OrderBy(p => p.Name).ToListAsync(cancellationToken);
        return response;
    }
}
