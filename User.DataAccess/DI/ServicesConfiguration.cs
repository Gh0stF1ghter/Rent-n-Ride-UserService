﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using User.DataAccess.Context;
using User.DataAccess.Repositories.Implementations;
using User.DataAccess.Repositories.Interfaces;

namespace User.DataAccess.DI;

public static class ServicesConfiguration
{
    public static void AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<UsersDbContext>(options => options.UseNpgsql($"{configuration.GetConnectionString("DBConnection")} User ID={Environment.GetEnvironmentVariable("POSTGRES_USER")}; Password={Environment.GetEnvironmentVariable("POSTGRES_PASSWORD")}"));

        services.AddTransient<IClientRepository, ClientRepository>();
    }
}