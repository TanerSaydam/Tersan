using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Abstractions;

[Route("api/[controller]/[action]")]
[ApiController]
public abstract class ApiController : ControllerBase
{
    public readonly IMediator _mediator;

    protected ApiController(IMediator mediator)
    {
        _mediator = mediator;
    }

    protected async Task<IActionResult> HandleCommandAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken)
        where TRequest : IRequest<ErrorOr<TResponse>>
    {
        var response = await _mediator.Send(request, cancellationToken);

        if (response.IsError)
        {
            return StatusCode(500,response.FirstError);
        }

        if(typeof(TResponse) == typeof(string))
        {
            return Ok(new { Message = response.Value });
        }

        return Ok(response.Value);
    }
}
