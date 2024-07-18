using ClientGrpcService;
using Grpc.Core;
using Mapster;
using User.BusinessLogic.Services.Interfaces;

namespace User.BusinessLogic.GrpcServices;

public class ClientGrpcServiceController(IClientService service) : ClientService.ClientServiceBase
{
    public override async Task<GetClientsInRangeResponse> GetClients(GetClientsInRangeRequest request, ServerCallContext context)
    {
        var dataList = await service.GetRangeAsync(request.PageNumber, request.PageSize, context.CancellationToken);

        var responseData = dataList.Adapt<IEnumerable<ProtoClientModel>>();

        var response = new GetClientsInRangeResponse();

        response.Clients.AddRange(responseData);

        return response;
    }

    public override async Task<GetClientResponse> GetClient(GetClientRequest request, ServerCallContext context)
    {
        var idIsValid = Guid.TryParse(request.Id, out var id);

        if (!idIsValid)
            throw new InvalidOperationException("Provided id is not GUID");

        var data = await service.GetByIdAsync(id, context.CancellationToken);

        var responseData = data.Adapt<ProtoClientModel>();

        var response = new GetClientResponse
        {
            Client = responseData
        };

        return response;
    }
}