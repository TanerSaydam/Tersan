using CleanArchitecture.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CleanArchitecture.Infrastructure.Authorization;
public sealed class RoleAttribute : Attribute, IAuthorizationFilter
{
    private readonly string _role;
    private readonly string _code;
    private readonly ApplicationDbContext _context;

    public RoleAttribute(string role, string code, ApplicationDbContext context)
    {
        _role = role;
        _context = context;
        _code = code;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var response = _context.Products.ToList();
        //database de role arayabiliyorum

       throw new UnauthorizedAccessException("Yetkiniz yok!");
    }
}
