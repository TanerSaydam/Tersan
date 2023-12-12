using Microsoft.AspNetCore.Diagnostics;
using TemizKodunOnemi.AdvancedOrnek.WebApi.Exceptions;

namespace TemizKodunOnemi.AdvancedOrnek.WebApi.Middleware;

public sealed class GlobalExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext, 
        Exception exception, 
        CancellationToken cancellationToken)
    {
        httpContext.Response.StatusCode = 500;

        if(exception.GetType() == typeof(ItemNameAlreadyExistException))
        {
            httpContext.Response.StatusCode = 429;
        }

        httpContext.Response.ContentType = "application/json";
        await httpContext.Response.WriteAsync(new ErrorResult(exception.Message).ToString());

        return true;
    }
}
