using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private static List<string> Products = new() { "Ürün1", "Ürün2", "Ürün3" };

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Products);
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Products.FirstOrDefault());
    }
}


