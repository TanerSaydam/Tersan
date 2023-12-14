using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Infrastructure.Authorization;
public sealed class RoleFilterAttribute : TypeFilterAttribute
{
    public RoleFilterAttribute(string role,string code) : base(typeof(RoleAttribute))
    {
        Arguments = new object[] { role, code };
    }
}
