using Microsoft.AspNetCore.Mvc;
using TemizKodunOnemi.AdvancedOrnek.WebApi.Context;
using TemizKodunOnemi.AdvancedOrnek.WebApi.DTOs;
using TemizKodunOnemi.AdvancedOrnek.WebApi.Exceptions;
using TemizKodunOnemi.AdvancedOrnek.WebApi.Models;

namespace TemizKodunOnemi.AdvancedOrnek.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ItemsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public ItemsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var items = _context.Items().Select(s => new ItemListDto(s.Id, s.Name));
        return Ok(items);
    }


    [HttpPost]
    public IActionResult Create(CreateItemDto request)
    {
        var isNameExist = _context.Any(request.Name);
        if (isNameExist)
        {
            throw new ItemNameAlreadyExistException();
        }

        Item item = new()
        {
            Id = 5,
            Name = request.Name,
        };

        _context.Add(item);
        _context.SaveChanges();
        return Ok(new { Id = item.Id });
    }
}
