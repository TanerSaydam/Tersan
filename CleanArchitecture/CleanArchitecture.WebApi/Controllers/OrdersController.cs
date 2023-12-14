using CleanArchitecture.Application.Features.Orders.CreateOrder;
using CleanArchitecture.Application.Features.Orders.GetAllOrder;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace CleanArchitecture.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class OrdersController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        await mediator.Send(request, cancellationToken);

        return NoContent();
    }

    [HttpPost]
    [EnableQuery]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        GetAllOrderQuery request = new();
        var response = await mediator.Send(request, cancellationToken);

        return Ok(response);
    }
}
