using Moq;
using System.Linq.Expressions;
using User.DataAccess.Entities;
using User.DataAccess.Repositories.Interfaces;

namespace Tests.Mocks;

internal class ClientRepositoryMock : Mock<IClientRepository>
{
    private readonly CancellationToken _anyToken = It.IsAny<CancellationToken>();

    public void GetRange(IEnumerable<UserEntity> clientsToReturn) =>
        Setup(cr => cr.GetRangeAsync(It.IsAny<int>(), It.IsAny<int>(), _anyToken))
            .ReturnsAsync(clientsToReturn);

    public void GetById(UserEntity? clientToReturn) =>
        Setup(cr => cr.GetByIdAsync(It.IsAny<Guid>(), _anyToken))
            .ReturnsAsync(clientToReturn);

    public void IsExists(bool boolToReturn) =>
        Setup(cr => cr.IsExistsAsync(It.IsAny<Expression<Func<UserEntity, bool>>>(), _anyToken))
        .ReturnsAsync(boolToReturn);
}