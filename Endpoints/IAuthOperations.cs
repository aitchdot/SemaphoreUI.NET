using SemaphoreUI.NET.Model;

namespace SemaphoreUI.NET.Endpoints;

internal interface IAuthOperations
{
    /// <summary>
    ///     Logs the user into the system using the provided login credentials.
    /// </summary>
    Task<bool> LoginAsync(Login body, CancellationToken cancellationToken);

    /// <summary>
    ///     Logs the user out of the system.
    /// </summary>
    Task LogoutAsync(CancellationToken cancellationToken);

    /// <summary>
    ///     Expires a specific API token by its ID.
    /// </summary>
    Task ExpireApiTokenAsync(string tokenId, CancellationToken cancellationToken);

    /// <summary>
    ///     Retrieves a list of API tokens associated with the current user.
    /// </summary>
    Task<List<ApiToken>> GetTokensByUserAsync(CancellationToken cancellationToken);

    /// <summary>
    ///     Creates a new API token for the current user.
    /// </summary>
    Task<ApiToken> CreateTokenAsync(CancellationToken cancellationToken);
}