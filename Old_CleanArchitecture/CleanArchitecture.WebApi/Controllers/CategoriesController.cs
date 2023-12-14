using CleanArchitecture.Application.Features.Categories.AddCategory;
using CleanArchitecture.Application.Features.Categories.GetAllCategory;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.WebApi.Abstractions;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers;
public class CategoriesController : ApiController
{
    public CategoriesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddCategoryCommand request, CancellationToken cancellationToken)
    {
        return await HandleCommandAsync<AddCategoryCommand,string>(request, cancellationToken);
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllCategoryQuery request, CancellationToken cancellationToken)
    {
        return await HandleCommandAsync<GetAllCategoryQuery, List<Category>>(request, cancellationToken);
    }
}

