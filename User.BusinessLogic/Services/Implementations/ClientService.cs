using Auth0.ManagementApi;
using Auth0.ManagementApi.Models;
using Mapster;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using User.BusinessLogic.Extensions;
using User.BusinessLogic.Models;
using User.BusinessLogic.Services.Interfaces;
using User.DataAccess.Entities;
using User.DataAccess.Repositories.Interfaces;

namespace User.BusinessLogic.Services.Implementations;

public class ClientService(
    IClientRepository clientRepository,
    IDistributedCache distributedCache,
    IManagementTokenService tokenService,
    IConfiguration configuration) : IClientService
{
    public async Task<IEnumerable<ClientModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken)
    {
        var clients = await clientRepository.GetRangeAsync(page, pageSize, cancellationToken);

        var clientModels = clients.Adapt<IEnumerable<ClientModel>>();

        return clientModels;
    }

    public async Task<ClientModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var key = nameof(ClientModel) + id;

        var cache = await distributedCache.GetDataFromCacheAsync<ClientModel>(key, cancellationToken);

        if (cache is not null)
            return cache;

        var client = await clientRepository.GetByIdAsync(id, cancellationToken);

        var clientModel = client.Adapt<ClientModel>();

        await distributedCache.CacheData(cache, key, cancellationToken);

        return clientModel;
    }

    public async Task<ClientModel> AddAsync(ClientModel clientModel, CancellationToken cancellationToken)
    {
        var token = await tokenService.GetTokenAsync(cancellationToken);
        var domain = configuration["Auth0:Domain"];

        var managementClient = new ManagementApiClient(token.AccessToken, new Uri(configuration["Auth0:ManagementAudience"]));

        var newClient = clientModel.Adapt<UserEntity>();

        var newAuth0Client = clientModel.Adapt<UserCreateRequest>();

        newAuth0Client.Connection = "Username-Password-Authentication";

        var createdClient = await managementClient.Users.CreateAsync(newAuth0Client, cancellationToken);

        newClient.UserId = createdClient.UserId;

        await clientRepository.AddAsync(newClient, cancellationToken);

        var newClientModel = newClient.Adapt<ClientModel>();

        return newClientModel;
    }

    public async Task<ClientModel> UpdateAsync(ClientModel newClientModel, CancellationToken cancellationToken)
    {
        var clientToUpdate = await clientRepository.GetByIdAsync(newClientModel.Id, cancellationToken);

        var token = await tokenService.GetTokenAsync(cancellationToken);
        var domain = configuration["Auth0:Domain"];

        var userID = clientToUpdate.UserId;

        var managementClient = new ManagementApiClient(token.AccessToken, domain);

        newClientModel.Adapt(clientToUpdate);

        var clientUpdateRequest = clientToUpdate.Adapt<UserUpdateRequest>();

        clientToUpdate.UserId = userID;

        var response = await managementClient.Users.UpdateAsync(clientToUpdate.UserId, clientUpdateRequest, cancellationToken);

        await clientRepository.UpdateAsync(clientToUpdate, cancellationToken);

        var clientToReturn = clientToUpdate.Adapt<ClientModel>();

        var key = nameof(ClientModel) + clientToReturn.Id;
        await distributedCache.CacheData(clientToReturn, key, cancellationToken);

        return clientToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var token = await tokenService.GetTokenAsync(cancellationToken);
        var domain = configuration["Auth0:Domain"];

        var managementClient = new ManagementApiClient(token.AccessToken, domain);

        var clientToDelete  =await clientRepository.GetByIdAsync(id, cancellationToken);

        await clientRepository.RemoveByIdAsync(id, cancellationToken);

        var key = nameof(ClientModel) + id;
        await distributedCache.RemoveAsync(key, cancellationToken);

        await managementClient.Users.DeleteAsync(clientToDelete.UserId);
    }
}