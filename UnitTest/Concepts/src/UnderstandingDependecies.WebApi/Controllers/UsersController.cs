using Microsoft.AspNetCore.Mvc;
using UnderstandingDependecies.WebApi.Services;

namespace UnderstandingDependecies.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class UsersController(IUserService userService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var users = await userService.GetAllAsync(cancellationToken);
        return Ok(users);
    }
}
