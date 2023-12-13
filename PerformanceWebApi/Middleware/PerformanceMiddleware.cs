
using System.Diagnostics;

namespace PerformanceWebApi.Middleware;

public sealed class PerformanceMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var stopWatch = Stopwatch.StartNew();
        DateTime startTime = DateTime.Now;
        await next(context);
        stopWatch.Stop();
        DateTime endTime = DateTime.Now;
        string? methodName = context.Request.Path.Value;

        if (stopWatch.ElapsedMilliseconds > 2000 && stopWatch.ElapsedMilliseconds <= 3000)
        {
            Console.WriteLine($"{methodName} API isteği 2sn'den fazla sürdü. Başlangıç zamanı: {startTime} Bitiş Zamanı: {endTime}");
        }

        if (stopWatch.ElapsedMilliseconds > 3000)
        {
            Console.WriteLine($"{methodName} API isteği 3sn'den fazla sürdü. Başlangıç zamanı: {startTime} Bitiş Zamanı: {endTime}");
        }
    }
}
