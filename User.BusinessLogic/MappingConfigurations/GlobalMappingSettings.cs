using Mapster;
using System.Reflection;

namespace User.BusinessLogic.MappingConfigurations;

public static class GlobalMappingSettings
{
    public static void SetMapper()
    {
        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
        TypeAdapterConfig.GlobalSettings.Default.MaxDepth(2);
        TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);
        TypeAdapterConfig.GlobalSettings.Default.IgnoreNullValues(true);
    }
}