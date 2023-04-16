using Microsoft.AspNetCore.DataProtection.Repositories;
using webAPI.Repository;
using webAPI.Services;

public static class DependencyInjectionExtensions
{
    public static void AddDependencies(this IServiceCollection services)
    {        
        
        // Add repository classes
        services.AddScoped<ICarsRepository, CarsRepository>();

        // Add services
        services.AddScoped<ICarsService, CarsService>();

    }
}