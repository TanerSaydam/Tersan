using DependencyInjectionWebApi.Utilities;

namespace DependencyInjectionWebApi.Services;

public static class StaticService
{
    public static void SmsGonder()
    {
        ApplicationDbContext context2 = new();
        var context = ServiceTool.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        context.Connection();
    }
}
