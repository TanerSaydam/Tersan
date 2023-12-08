using DomainDrivenDesign.Domain.Users;
using DomainDrivenDesign.Infrastructure.Context;
using DomainDrivenDesign.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DomainDrivenDesign.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ApplicationDbContext>();

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
