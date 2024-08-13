using Mapster;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using User.BusinessLogic.Services.Implementations;
using User.BusinessLogic.Services.Interfaces;
using User.DataAccess.DI;

namespace User.BusinessLogic.DI;

public static class ServicesConfiguration
{
    public static void AddApplicationDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDataAccessDependencies(configuration);

        services.AddStackExchangeRedisCache(options =>
            options.Configuration = configuration.GetConnectionString("Redis"));

        services.AddMessageBroker(configuration);

        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());

        services.AddHttpClient();

        services.AddScoped<IClientService, ClientService>();
        services.AddScoped<IManagementTokenService, ManagementTokenService>();
    }

    public static void AddMessageBroker(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMassTransit(cfg =>
        {
            var assembly = Assembly.GetExecutingAssembly();

            cfg.AddConsumers(assembly);

            cfg.UsingRabbitMq((context, factoryCfg) =>
            {
                factoryCfg.Host(configuration.GetConnectionString("RabbitMQ"), "/");

                factoryCfg.ConfigureEndpoints(context);
            });
        });
    }
}