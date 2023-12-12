using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using TemizKodunOnemi.AdvancedOrnek.WebApi.Context;
using TemizKodunOnemi.AdvancedOrnek.WebApi.DTOs;
using TemizKodunOnemi.AdvancedOrnek.WebApi.Exceptions;
using TemizKodunOnemi.AdvancedOrnek.WebApi.Models;
using TemizKodunOnemi.AdvancedOrnek.WebApi.Validators;

namespace TemizKodunOnemi.AdvancedOrnek.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ItemsController : ControllerBase
{
    private ApplicationDbContext _context;
    public ItemsController(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException();
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
