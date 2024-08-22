using Mapster;
using Microsoft.AspNetCore.Mvc;
using User.API.ViewModels;
using User.API.ViewModels.ShortViewModels;
using User.BusinessLogic.Models;
using User.BusinessLogic.Services.Interfaces;

namespace User.API.Controllers;

[ApiController]
[Route("api/client")]
public class ClientController(IClientService service) : ControllerBase
{
    [HttpGet]
    [ActionName("GetAllClientsInRange")]
    public async Task<IEnumerable<ClientViewModel>> GetAll([FromQuery] int page, [FromQuery] int pageSize, CancellationToken cancellationToken)
    {
        var clients = await service.GetRangeAsync(page, pageSize, cancellationToken);

        var clientsVMs = clients.Adapt<IEnumerable<ClientViewModel>>();

        return clientsVMs;
    }

    [HttpGet("{id}")]
    [ActionName("GetClientById")]
    public async Task<ClientViewModel> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var client = await service.GetByIdAsync(id, cancellationToken);

        var clientVM = client.Adapt<ClientViewModel>();

        return clientVM;
    }

    [HttpPost]
    [ActionName("CreateClient")]
    public async Task<ClientViewModel> Create([FromBody] ShortClientViewModel createClientViewModel, CancellationToken cancellationToken)
    {
        var createClientModel = createClientViewModel.Adapt<ClientModel>();

        var newClient = await service.AddAsync(createClientModel, cancellationToken);

        var clientVM = newClient.Adapt<ClientViewModel>();

        return clientVM;
    }

    [HttpPut("{id}")]
    [ActionName("UpdateClientById")]
    public async Task<ClientViewModel> Update([FromRoute] Guid id, [FromBody] ShortClientViewModel updateClientViewModel, CancellationToken cancellationToken)
    {
        var clientModel = updateClientViewModel.Adapt<ClientModel>();

        clientModel.Id = id;

        var newClient = await service.UpdateAsync(clientModel, cancellationToken);

        var clientVM = newClient.Adapt<ClientViewModel>();

        return clientVM;
    }

    [HttpDelete("{id}")]
    [ActionName("DeleteClientById")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        await service.DeleteAsync(id, cancellationToken);
    }
}