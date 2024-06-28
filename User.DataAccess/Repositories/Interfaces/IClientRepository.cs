using User.DataAccess.Entities;

namespace User.DataAccess.Repositories.Interfaces;

public interface IClientRepository : IRepositoryBase<UserEntity>
{
    Task<IEnumerable<UserEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken);

    Task<UserEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}