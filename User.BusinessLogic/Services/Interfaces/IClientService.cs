using User.BusinessLogic.Models;

namespace User.BusinessLogic.Services.Interfaces;

public interface IClientService
{
    Task<IEnumerable<ClientModel>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<ClientModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<ClientModel> AddAsync(ClientModel clientModel, CancellationToken cancellationToken);

    Task<ClientModel> UpdateAsync(ClientModel newClientModel, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}