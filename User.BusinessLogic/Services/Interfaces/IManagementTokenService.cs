using User.BusinessLogic.Models.Auth0Token;

namespace User.BusinessLogic.Services.Interfaces;

public interface IManagementTokenService
{
    Task<TokenResponse> GetTokenAsync(CancellationToken cancellationToken);
}