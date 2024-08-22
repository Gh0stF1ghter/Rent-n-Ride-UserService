using Microsoft.Extensions.Configuration;
using Moq;

namespace Rent.UnitTests.Mocks;
internal class ConfigurationMock : Mock<IConfiguration>
{
    public void GetDomain() =>
        Setup(c => c.GetSection("Auth0")["Domain"])
        .Returns("Domain");

    public void GetManagementAudience() =>
        Setup(c => c.GetSection("Auth0")["ManagementAudience"])
        .Returns("https://ManagementAudience");

    public void GetClientId() =>
        Setup(c => c.GetSection("Auth0")["ClientId"])
        .Returns("ClientId");

    public void GetClientSecret() =>
        Setup(c => c.GetSection("Auth0")["ClientSecret"])
        .Returns("ClientSecret");
}