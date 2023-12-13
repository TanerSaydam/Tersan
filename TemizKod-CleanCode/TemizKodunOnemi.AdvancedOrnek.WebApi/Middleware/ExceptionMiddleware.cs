
using System.Diagnostics;

namespace TemizKodunOnemi.AdvancedOrnek.WebApi.Middleware;

public sealed class ExceptionMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
		try
		{			
			await next(context);
			//DB'ye Bunu Kayıt edebilirsiniz
			
		}
		catch (Exception ex)
		{
			context.Response.StatusCode = 500;
			context.Response.ContentType = "application/json";
			await context.Response.WriteAsync(new ErrorResult(ex.Message).ToString(), CancellationToken.None);
		}
    }
}

public sealed record ErrorResult(string Message);
