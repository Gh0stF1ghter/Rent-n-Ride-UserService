using FluentAssertions;
using Mapster;
using Newtonsoft.Json;
using System.Text;
using Tests.DataGeneration;
using Tests.Mocks;
using User.BusinessLogic.Models;
using User.BusinessLogic.Services.Implementations;
using User.DataAccess.Entities;

namespace Tests.ServicesTests;

public class ClientServiceTests
{
    private readonly ClientRepositoryMock _repositoryMock = new();
    private readonly DistributedCacheMock _distributedCacheMock = new();

    private readonly List<UserEntity> _clients = DataGenerator.AddClientData(5);

    public ClientServiceTests()
    {
        _repositoryMock.GetRange(_clients);
        _repositoryMock.GetById(_clients[0]);
        _repositoryMock.IsExists(true);
    }

    [Fact]
    public async Task GetRangeAsync__ReturnsClientModelList()
    {
        //Arrange
        var correctClientModels = _clients.Adapt<IEnumerable<ClientModel>>();

        var service = new ClientService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.GetRangeAsync(1, 1, default);

        //Assert
        response.Should().BeEquivalentTo(correctClientModels);
    }

    [Fact]
    public async Task GetByIdAsync__ReturnsClientModel()
    {
        //Arrange
        var correctClientModel = _clients[0].Adapt<ClientModel>();

        var serializedModel = JsonConvert.SerializeObject(correctClientModel);
        var cachedModel = Encoding.UTF8.GetBytes(serializedModel);
        _distributedCacheMock.GetDataFromCache(cachedModel);

        var service = new ClientService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.GetByIdAsync(Guid.NewGuid(), default);

        //Assert
        response.Should().BeEquivalentTo(correctClientModel);
    }

    [Fact]
    public async Task GetByIdAsync_InvalidId_ThrowsInvalidOperationException()
    {
        //Arrange
        _repositoryMock.GetByIdThrowsException();

        var service = new ClientService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = async () => await service.GetByIdAsync(Guid.NewGuid(), default);

        //Assert
        await response.Should().ThrowAsync<InvalidOperationException>();
    }

    [Fact]
    public async Task GetByIdAsync_EmptyCache_ReturnsClientModel()
    {
        //Arrange
        var correctClientModel = _clients[0].Adapt<ClientModel>();

        var serializedModel = JsonConvert.SerializeObject(null);
        var cachedModel = Encoding.UTF8.GetBytes(serializedModel);
        _distributedCacheMock.GetDataFromCache(cachedModel);

        var service = new ClientService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.GetByIdAsync(Guid.NewGuid(), default);

        //Assert
        response.Should().BeEquivalentTo(correctClientModel);
    }

    [Fact]
    public async Task AddAsync_ClientModel_ReturnsClientModel()
    {
        //Arrange
        var correctClientModel = _clients[0].Adapt<ClientModel>();
        var service = new ClientService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.AddAsync(correctClientModel, default);

        //Assert
        response.Should().BeEquivalentTo(correctClientModel);
    }

    [Fact]
    public async Task UpdateAsync_ClientModel_ReturnsClientModel()
    {
        //Arrange
        var correctClientModel = _clients[1].Adapt<ClientModel>();
        var service = new ClientService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = await service.UpdateAsync(correctClientModel, default);

        //Assert
        response.Should().BeEquivalentTo(correctClientModel);
    }

    [Fact]
    public async Task UpdateAsync_InvalidId_ThrowsInvalidOperationException()
    {
        //Arrange
        _repositoryMock.GetByIdThrowsException();

        var correctClientModel = _clients[1].Adapt<ClientModel>();
        var service = new ClientService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = async () => await service.UpdateAsync(correctClientModel, default);

        //Assert
        await response.Should().ThrowAsync<InvalidOperationException>();
    }

    [Fact]
    public async Task DeleteAsync_ClientId_()
    {
        //Arrange
        var service = new ClientService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = async () => await service.DeleteAsync(Guid.NewGuid(), default);

        //Assert
        await response.Should().NotThrowAsync();
    }

    [Fact]
    public async Task DeleteAsync_InvalidId_ThrowsInvalidOperationException()
    {
        //Arrange
        _repositoryMock.RemoveByIdThrowsException();

        var service = new ClientService(_repositoryMock.Object, _distributedCacheMock.Object);

        //Act
        var response = async () => await service.DeleteAsync(Guid.NewGuid(), default);

        //Assert
        await response.Should().ThrowAsync<InvalidOperationException>();
    }
}