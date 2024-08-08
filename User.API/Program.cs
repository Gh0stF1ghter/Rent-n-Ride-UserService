using User.API.DI;
using User.API.Extensions;
using User.API.GrpcServices;
using User.BusinessLogic.DI;
using User.BusinessLogic.MappingConfigurations;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddApplicationDependencies(builder.Configuration);
services.AddApiDependencies(builder.Configuration);

GlobalMappingSettings.SetMapper();

services.AddControllers();

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.UseHttpsRedirection();

app.MapControllers();
app.MapGrpcService<ClientGrpcServiceController>();

await app.RunAsync();