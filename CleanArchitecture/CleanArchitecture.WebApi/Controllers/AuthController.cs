using CleanArchitecture.Application.Features.Auth.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class AuthController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Login(LoginCommand request, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(request, cancellationToken);

        return Ok(new { Token = response });
    }
}
