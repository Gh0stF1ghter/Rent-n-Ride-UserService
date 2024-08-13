using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;
using User.BusinessLogic.Exceptions;
using User.BusinessLogic.Exceptions.ExceptionMessages;
using User.BusinessLogic.Models.Auth0Token;
using User.BusinessLogic.Services.Interfaces;

namespace User.BusinessLogic.Services.Implementations;

public class ManagementTokenService(IConfiguration configuration, IHttpClientFactory httpClientFactory) : IManagementTokenService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient();
    private const string grantType = "client_credentials";

    public async Task<TokenResponse> GetTokenAsync(CancellationToken cancellationToken)
    {
        var domain = configuration["Auth0:Domain"];
        var clientId = configuration["Auth0:ClientId"];
        var clientSecret = configuration["Auth0:ClientSecret"];
        var audience = configuration["Auth0:ManagementAudience"];

        var tokenRequestBody = new
        {
            client_id = clientId,
            client_secret = clientSecret,
            audience,
            grant_type = grantType
        };

        var response = await _httpClient.PostAsJsonAsync($"https://{domain}/oauth/token", tokenRequestBody, cancellationToken);

        response.EnsureSuccessStatusCode();

        var tokenResponse = await response.Content.ReadFromJsonAsync<TokenResponse>(cancellationToken);

        if (tokenResponse is null)
            throw new MissedTokenException(ExceptionMessages.TokenMissing);

        return tokenResponse;
    }
}
