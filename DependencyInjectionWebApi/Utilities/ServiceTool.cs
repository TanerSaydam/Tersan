namespace DependencyInjectionWebApi.Utilities;

public static class ServiceTool
{
    public static IServiceProvider ServiceProvider { get; private set; }
    public static IServiceCollection Create(this IServiceCollection services)
    {
        ServiceProvider = services.BuildServiceProvider();
        return services;
    }

    public static string Deneme(this string s)
    {
        return s;
    }

    //public static IQueryable OrderByTaner(this IOrderedQueryable query)
    //{
    //    return query.OrderBy(propa => propa.Name).AsQueryable();
    //}
}
