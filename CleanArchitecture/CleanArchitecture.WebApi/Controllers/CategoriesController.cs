using CleanArchitecture.Application.Features.Categories.AddCategory;
using CleanArchitecture.Application.Features.Categories.GetAllCategory;
using CleanArchitecture.WebApi.Abstractions;
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
        await _mediator.Send(request, cancellationToken);

        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllCategoryQuery request, CancellationToken cancellationToken)
    {
       var response = await _mediator.Send(request, cancellationToken);

        return Ok(response);
    }
}
