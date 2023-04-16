using Microsoft.AspNetCore.DataProtection.Repositories;
using MongoDB.Driver;
using webAPI.Repository;
using webAPI.Services;

public static class DependencyInjectionExtensions
{
    public static void AddDependencies(this IServiceCollection services, IConfiguration config)
    {
        var mongo_uri = !String.IsNullOrEmpty(Environment.GetEnvironmentVariable("MONGO_URI")) ? Environment.GetEnvironmentVariable("MONGO_URI") : config.GetValue<string>("MongoDb:ConnectionString");

        // Add MongoDB client
        var connectionString = mongo_uri;

        var mongoClient = new MongoClient(connectionString);

        services.AddSingleton(mongoClient);

        // Add repository classes
        services.AddScoped<ICarsRepository, CarsRepository>();

        // Add services
        services.AddScoped<ICarsService, CarsService>();

    }
}