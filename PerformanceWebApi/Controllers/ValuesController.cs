using Microsoft.AspNetCore.Mvc;

namespace PerformanceWebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get1()
    {
        await Task.Delay(2000);

        return NoContent();
    }

    [HttpGet]
    public async Task<IActionResult> Get2()
    {
        await Task.Delay(3000);

        return NoContent();
    }
}
