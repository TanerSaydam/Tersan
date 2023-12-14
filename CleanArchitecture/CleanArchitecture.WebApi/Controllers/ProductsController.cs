using CleanArchitecture.Application.Features.Products.CreateProduct;
using CleanArchitecture.Application.Features.Products.GetAllProduct;
using CleanArchitecture.Application.Features.Products.UpdateProduct;
using CleanArchitecture.Infrastructure.Authorization;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public sealed class ProductsController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateProductCommand request, CancellationToken cancellationToken)
    {
        await mediator.Send(request, cancellationToken);

        return NoContent();
    }


    [HttpPost]
    public async Task<IActionResult> Update(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        await mediator.Send(request, cancellationToken);

        return NoContent();
    }

    [HttpGet]
    [RoleFilter("Products.GetAll")]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        GetAllProductQuery request = new();
        var response = await mediator.Send(request, cancellationToken);

        return Ok(response);
    }
}
