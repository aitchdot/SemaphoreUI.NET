using Ardalis.GuardClauses;
using SemaphoreUI.NET.Model;

namespace SemaphoreUI.NET.Endpoints;

public class UserOperations : IUserOperations
{
    private readonly SemaphoreUiClient _client;

    internal UserOperations(SemaphoreUiClient client)
    {
        _client = client;
    }

    #region Implementation of IUserOperations

    public async Task<User> GetCurrentUserAsync(CancellationToken cancellationToken = default)
    {
        return await _client.MakeRequestAsync<User>(HttpMethod.Get, "/user", cancellationToken);
    }

    public async Task<IList<User>> GetAllUsersAsync(CancellationToken cancellationToken = default)
    {
        return await _client.MakeRequestAsync<User[]>(HttpMethod.Get, "/users", cancellationToken);
    }

    public async Task<User> CreateUserAsync(CreateUserRequest createUserRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.Null(createUserRequest, nameof(createUserRequest));

        return await _client.MakeRequestAsync<User>(HttpMethod.Post, "/users", cancellationToken, createUserRequest);
    }

    public async Task<User> GetUserByIdAsync(string userId, CancellationToken cancellationToken = default)
    {
        Guard.Against.NullOrEmpty(userId, nameof(userId));

        return await _client.MakeRequestAsync<User>(HttpMethod.Get, $"/users/{userId}", cancellationToken);
    }

    public async Task UpdateUserAsync(string userId, UpdateUserRequest? userUpdateRequest = null,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NullOrEmpty(userId, nameof(userId));
        Guard.Against.Null(userUpdateRequest, nameof(userUpdateRequest));

        await _client.MakeRequestAsync(HttpMethod.Put, $"/users/{userId}", cancellationToken, userUpdateRequest);
    }

    public async Task DeleteUserAsync(string userId, CancellationToken cancellationToken = default)
    {
        Guard.Against.NullOrEmpty(userId, nameof(userId));

        await _client.MakeRequestAsync(HttpMethod.Delete, $"/users/{userId}", cancellationToken);
    }

    public async Task UpdateUserPasswordAsync(string userId, UpdatePasswordRequest passwordRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NullOrEmpty(userId, nameof(userId));
        Guard.Against.Null(passwordRequest, nameof(passwordRequest));

        await _client.MakeRequestAsync(HttpMethod.Put, $"/users/{userId}/password", cancellationToken,
                                       passwordRequest);
    }

    public async Task<IList<ApiToken>> GetApiTokensAsync(string userId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NullOrEmpty(userId, nameof(userId));

        return await _client.MakeRequestAsync<ApiToken[]>(HttpMethod.Get, $"/users/{userId}/api-tokens",
                                                          cancellationToken);
    }

    public async Task<ApiToken> CreateApiTokenAsync(string userId, CancellationToken cancellationToken = default)
    {
        Guard.Against.NullOrEmpty(userId, nameof(userId));

        return await _client.MakeRequestAsync<ApiToken>(HttpMethod.Post, $"/users/{userId}/api-tokens",
                                                        cancellationToken);
    }

    public async Task RevokeApiTokenAsync(string userId, string apiTokenId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NullOrEmpty(userId, nameof(userId));
        Guard.Against.NullOrEmpty(apiTokenId, nameof(apiTokenId));

        await _client.MakeRequestAsync(HttpMethod.Delete, $"/users/{userId}/api-tokens/{apiTokenId}",
                                       cancellationToken);
    }

    #endregion
}