using CleanArchitecture.Application.Behaviors;
using CleanArchitecture.Domain.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArchitecture.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly(), typeof(Product).Assembly);
            configuration.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });        

        services.AddFluentValidationAutoValidation();
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}
