using Bogus;
using User.DataAccess.Entities;

namespace Tests.DataGeneration;

internal static class DataGenerator
{
    public static List<UserEntity> AddClientData(int count)
    {
        var clientFaker = GetClientFaker();

        return clientFaker.Generate(count);
    }

    private static Faker<UserEntity> GetClientFaker() =>
        new Faker<UserEntity>()
            .RuleFor(c => c.Id, _ => Guid.NewGuid())
            .RuleFor(c => c.FirstName, f => f.Name.FirstName())
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.Email, f => f.Internet.Email())
            .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber());
}