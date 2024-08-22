using System.Text.Json.Serialization;

namespace User.BusinessLogic.Models.Auth0Token;

public record TokenResponse
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; init; } = string.Empty;

    [JsonPropertyName("token_type")]
    public string TokenType { get; init; } = string.Empty;
}
