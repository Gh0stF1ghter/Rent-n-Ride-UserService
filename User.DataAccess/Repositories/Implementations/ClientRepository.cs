using Microsoft.EntityFrameworkCore;
using User.DataAccess.Context;
using User.DataAccess.Entities;
using User.DataAccess.Repositories.Interfaces;

namespace User.DataAccess.Repositories.Implementations;

public class ClientRepository(UsersDbContext context) : RepositoryBase<UserEntity>(context), IClientRepository
{
    public async Task<IEnumerable<UserEntity>> GetRangeAsync(int page, int pageSize, CancellationToken cancellationToken) =>
        await GetRange(page, pageSize)
            .ToListAsync(cancellationToken);

    public async Task<UserEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByCondition(c => c.Id == id)
            .FirstAsync(cancellationToken);
}