using Microsoft.AspNetCore.Mvc;
using UnderstandingDependecies.WebApi.DTOs;
using UnderstandingDependecies.WebApi.Services;

namespace UnderstandingDependecies.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class UsersController(IUserService userService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateUserDto request, CancellationToken cancellationToken = default)
    {
        await userService.CreateAsync(request,cancellationToken);

        return NoContent();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var users = await userService.GetAllAsync(cancellationToken);
        return Ok(users);
    }
}
