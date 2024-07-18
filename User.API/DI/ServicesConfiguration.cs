﻿using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using System.Reflection;
using User.API.Extensions;
using User.API.Utilities.Authorization;

namespace User.API.DI;

public static class ServicesConfiguration
{
    public static void AddApiDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoValidation();

        services.AddAuth0Authentication(configuration);

        services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();

        services.ConfigureCors(configuration);

        services.ConfigureSwagger();
    }

    private static void AddAutoValidation(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddFluentValidationAutoValidation();
    }

    private static void ConfigureCors(this IServiceCollection services, IConfiguration configuration)
    {
        var rent = configuration.GetConnectionString("RentService");
        var admin = configuration.GetConnectionString("AdminPanelService");
        var gateway = configuration.GetConnectionString("ApiGateway");

        services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
                builder
                .WithOrigins(
                    rent,
                    admin,
                    gateway
                    )
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
        });
    }


    private static void AddAuth0Authentication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(
    options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }).AddJwtBearer(
    options =>
    {
        options.Authority = $"https://{configuration["Auth0:Domain"]}/";
        options.Audience = configuration["Auth0:Audience"];
    });

        services.AddAuthorizationBuilder()
            .AddPolicy("change:catalogue", policy =>
                policy.Requirements.Add(
                    new HasScopeRequirement("change:catalogue", configuration["Auth0:Domain"])
                    ));

    }
}