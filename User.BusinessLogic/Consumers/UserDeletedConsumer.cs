using EventBus;
using MassTransit;
using User.BusinessLogic.Services.Interfaces;

namespace User.BusinessLogic.Consumers;

public class UserDeletedConsumer(IClientService service) : IConsumer<UserDeletedEvent>
{
    public async Task Consume(ConsumeContext<UserDeletedEvent> context)
    {
        var userId = context.Message.Id;

        await service.DeleteAsync(userId, default);
    }
}