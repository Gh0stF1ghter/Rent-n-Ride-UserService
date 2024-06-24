using Bogus;
using User.DataAccess.Entities;

namespace User.DataAccess.Context;

internal static class DataGenerator
{
    private const int CountOfGeneratedUnits = 5;

    public static readonly List<UserEntity> Clients = [];

    public static void Init()
    {
        AddClientData();
    }

    private static void AddClientData()
    {
        var clientFaker = GetClientFaker();

        var generatedClient = clientFaker.Generate(CountOfGeneratedUnits);

        Clients.AddRange(generatedClient);
    }

    private static Faker<UserEntity> GetClientFaker() =>
        new Faker<UserEntity>()
            .RuleFor(c => c.Id, _ => Guid.NewGuid())
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.Email, f => f.Internet.Email())
            .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber());
}