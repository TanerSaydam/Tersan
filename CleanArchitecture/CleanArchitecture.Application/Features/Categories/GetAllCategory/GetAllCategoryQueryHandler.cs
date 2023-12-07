using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using ErrorOr;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Features.Categories.GetAllCategory;

public sealed class GetAllCategoryQueryHandler(ICategoryRepository categoryRepository) : IRequestHandler<GetAllCategoryQuery, ErrorOr<List<Category>>>
{
    public async Task<ErrorOr<List<Category>>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
    {
        return await categoryRepository.GetAll().ToListAsync(cancellationToken);
    }
}
