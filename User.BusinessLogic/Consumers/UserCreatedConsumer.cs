using EventBus;
using Mapster;
using MassTransit;
using User.BusinessLogic.Models;
using User.BusinessLogic.Services.Interfaces;

namespace User.BusinessLogic.Consumers;

public class UserCreatedConsumer(IClientService service) : IConsumer<UserCreatedEvent>
{
    public async Task Consume(ConsumeContext<UserCreatedEvent> context)
    {
        var userFromEvent = context.Message;

        var user = userFromEvent.Adapt<ClientModel>();

        await service.AddAsync(user, default);
    }
}