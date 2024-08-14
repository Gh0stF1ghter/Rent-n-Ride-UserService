using EventBus.UserEvents;
using MassTransit;
using User.BusinessLogic.Services.Interfaces;

namespace User.BusinessLogic.Consumers;

public class UserDeletedConsumer(IClientService service) : IConsumer<UserDeleted>
{
    public async Task Consume(ConsumeContext<UserDeleted> context)
    {
        var userId = context.Message.Id;

        await service.DeleteAsync(userId, default);
    }
}