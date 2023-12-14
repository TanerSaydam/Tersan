using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Infrastructure.Authentication;
using CleanArchitecture.Infrastructure.Context;
using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        string connectionString = "Data Source=DESKTOP-3BJ5GK9\\SQLEXPRESS;Initial Catalog=CleanArchitectureDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
        services.AddScoped<IUnitOfWork>(srv => srv.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<IJwtService, JwtService>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        return services;
    }

}
