using EventBus;
using EventBus.UserEvents;
using Mapster;
using MassTransit;
using User.BusinessLogic.Models;
using User.BusinessLogic.Services.Interfaces;

namespace User.BusinessLogic.Consumers;

public class UserCreatedConsumer(IClientService service) : IConsumer<UserCreated>
{
    public async Task Consume(ConsumeContext<UserCreated> context)
    {
        var userFromEvent = context.Message;

        await Console.Out.WriteLineAsync($"user {userFromEvent.Email} consumed");

        var user = userFromEvent.Adapt<ClientModel>();

        await service.AddAsync(user, default);
    }
}