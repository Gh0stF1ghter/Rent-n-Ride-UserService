using Mapster;
using Microsoft.Extensions.Caching.Distributed;
using User.BusinessLogic.Exceptions;
using User.BusinessLogic.Exceptions.ExceptionMessages;
using User.BusinessLogic.Extensions;
using User.BusinessLogic.Models;
using User.BusinessLogic.Services.Interfaces;
using User.DataAccess.Entities;
using User.DataAccess.Repositories.Interfaces;

namespace User.BusinessLogic.Services.Implementations;

public class ClientService(IClientRepository clientRepository, IDistributedCache distributedCache) : IClientService
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

        var cacheLifetime = TimeSpan.FromMinutes(10);
        await distributedCache.CacheData(cache, cacheLifetime, key, cancellationToken);

        return clientModel;
    }

    public async Task<ClientModel> AddAsync(ClientModel clientModel, CancellationToken cancellationToken)
    {
        var newClient = clientModel.Adapt<UserEntity>();

        await clientRepository.AddAsync(newClient, cancellationToken);

        var newClientModel = newClient.Adapt<ClientModel>();

        return newClientModel;
    }

    public async Task<ClientModel> UpdateAsync(ClientModel newClientModel, CancellationToken cancellationToken)
    {
        var clientToUpdate = await clientRepository.GetByIdAsync(newClientModel.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.NotFound(nameof(UserEntity), newClientModel.Id));

        newClientModel.Adapt(clientToUpdate);

        await clientRepository.UpdateAsync(clientToUpdate, cancellationToken);

        var clientToReturn = clientToUpdate.Adapt<ClientModel>();

        var key = nameof(ClientModel) + clientToReturn.Id;
        var cacheLifetime = TimeSpan.FromMinutes(10);
        await distributedCache.CacheData(clientToReturn, cacheLifetime, key, cancellationToken);

        return clientToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var clientToDelete = await clientRepository.GetByIdAsync(id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.NotFound(nameof(UserEntity), id));

        await clientRepository.RemoveAsync(clientToDelete, cancellationToken);

        var key = nameof(ClientModel) + id;
        await distributedCache.RemoveAsync(key, cancellationToken);
    }
}