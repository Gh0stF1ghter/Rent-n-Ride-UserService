using User.API.DI;
using User.API.Extensions;
using User.BusinessLogic.DI;
using User.BusinessLogic.MappingConfigurations;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddApplicationDependencies(builder.Configuration);
services.AddApiDependencies();

GlobalMappingSettings.SetMapper();

services.AddControllers();

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();