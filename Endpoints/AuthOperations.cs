using Ardalis.GuardClauses;
using SemaphoreUI.NET.Model;

namespace SemaphoreUI.NET.Endpoints;

internal class AuthOperations(SemaphoreUiClient client) : IAuthOperations
{
    private readonly SemaphoreUiClient _client = client ?? throw new ArgumentNullException(nameof(client));

    public async Task<bool> LoginAsync(Login body, CancellationToken cancellationToken)
    {
        try
        {
            await _client.MakeRequestAsync<object>(HttpMethod.Post, "/auth/login", cancellationToken, body);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task LogoutAsync(CancellationToken cancellationToken = default)
    {
        await _client.MakeRequestAsync(HttpMethod.Post, "/auth/logout", cancellationToken);
    }


    public async Task<List<ApiToken>> GetTokensByUserAsync(CancellationToken cancellationToken = default)
    {
        var result =
            await _client.MakeRequestAsync<List<ApiToken>>(HttpMethod.Get, "/auth/tokens",
                                                           cancellationToken);
        return result;
    }

    public async Task<ApiToken> CreateTokenAsync(CancellationToken cancellationToken = default)
    {
        var result =
            await _client.MakeRequestAsync<ApiToken>(HttpMethod.Post, "/auth/tokens",
                                                     cancellationToken);
        return result;
    }

    public async Task ExpireApiTokenAsync(string tokenId, CancellationToken cancellationToken = default)
    {
        Guard.Against.NullOrWhiteSpace(tokenId, nameof(tokenId));
        await _client.MakeRequestAsync(HttpMethod.Delete, $"/auth/expire-token/{tokenId}",
                                       cancellationToken);
    }
}