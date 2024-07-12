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

        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());

        services.AddScoped<IClientService, ClientService>();
    }

    public static void AddMessageBroker(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMassTransit(cfg =>
        {
            var assembly = Assembly.GetExecutingAssembly();

            cfg.AddConsumers(assembly);

            cfg.UsingRabbitMq((context, factoryCfg) =>
            {
                factoryCfg.Host(configuration.GetConnectionString("RabbitMQ"), "/", host =>
                {
                    var username = Environment.GetEnvironmentVariable("RABBITMQ_DEFAULT_USER") ?? "user";
                    var password = Environment.GetEnvironmentVariable("RABBITMQ_DEFAULT_PASSWORD") ?? "password";

                    host.Username(username);
                    host.Password(password);
                });

                factoryCfg.ConfigureEndpoints(context);
            });
        });
    }
}