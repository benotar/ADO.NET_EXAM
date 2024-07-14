using exam2.Data;
using Microsoft.EntityFrameworkCore;

namespace exam2;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .SetBasePath(Directory.GetCurrentDirectory())
            .Build();
        
        var connectionString = config.GetConnectionString("SQLiteConnection");

        services.AddDbContext<RailwayDbContext>(options =>
        {
            options.UseSqlite(connectionString);
        });

        services.AddScoped<IRailwayDbContext>(provider =>
            provider.GetService<RailwayDbContext>());


        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(Program).Assembly);
        });
        
        return services;
    }
}