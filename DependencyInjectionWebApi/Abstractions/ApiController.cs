using DependencyInjectionWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionWebApi.Abstractions;
[Route("api/[controller]/[action]")]
[ApiController]
//[Authorize]
public abstract class ApiController : ControllerBase
{

}
