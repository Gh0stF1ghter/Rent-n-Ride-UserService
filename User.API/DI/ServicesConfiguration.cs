using FluentValidation;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using System.Reflection;

namespace User.API.DI;

public static class ServicesConfiguration
{
    public static void AddApiDependencies(this IServiceCollection services)
    {
        services.AddAutoValidation();
    }

    private static void AddAutoValidation(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddFluentValidationAutoValidation();
    }
}
