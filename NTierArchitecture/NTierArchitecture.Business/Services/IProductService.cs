using NTierArchitecture.Entities.Dtos;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Services;
public interface IProductService
{
    Task AddAsync(ProductAddDto request, CancellationToken cancellationToken = default);
    Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default);
}
