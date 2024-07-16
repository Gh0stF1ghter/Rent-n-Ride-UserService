using EventBus;
using EventBus.UserEvents;
using Mapster;
using MassTransit;
using User.BusinessLogic.Models;
using User.BusinessLogic.Services.Interfaces;

namespace User.BusinessLogic.Consumers;

public class UserUpdatedConsumer(IClientService service) : IConsumer<UserUpdated>
{
    public async Task Consume(ConsumeContext<UserUpdated> context)
    {
        var userFromEvent = context.Message;

        var userModel = userFromEvent.Adapt<ClientModel>();

        await service.UpdateAsync(userModel, default);
    }
}
