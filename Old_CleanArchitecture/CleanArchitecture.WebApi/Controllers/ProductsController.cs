using CleanArchitecture.Application.Features.Products.AddProduct;
using CleanArchitecture.Application.Features.Products.GetAllProduct;
using CleanArchitecture.WebApi.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers;

public class ProductsController : ApiController
{
    public ProductsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddProductCommand request, CancellationToken cancellationToken)
    {
        Guid id = await _mediator.Send(request, cancellationToken);
        return Ok(new { Id = id });
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
