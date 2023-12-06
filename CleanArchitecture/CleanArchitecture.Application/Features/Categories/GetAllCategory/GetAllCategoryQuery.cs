using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Categories.GetAllCategory;
public sealed record GetAllCategoryQuery(): IRequest<List<Category>>;

public sealed class GetAllCategoryQueryHandler(ICategoryRepository categoryRepository) : IRequestHandler<GetAllCategoryQuery, List<Category>>
{
    public async Task<List<Category>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
    {
        return await categoryRepository.GetAll().ToListAsync(cancellationToken);
    }
}
