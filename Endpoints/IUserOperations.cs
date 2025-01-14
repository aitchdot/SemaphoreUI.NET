using SemaphoreUI.NET.Model;

namespace SemaphoreUI.NET.Endpoints;

/// <summary>
///     Interface for user-related operations such as fetching user data, managing tokens, and user profiles.
/// </summary>
public interface IUserOperations
{
    /// <summary>
    ///     Fetch the details of the currently logged-in user.
    /// </summary>
    /// <returns>The logged-in user's profile.</returns>
    Task<User> GetCurrentUserAsync(CancellationToken cancellationToken = default);

    /// <summary>
    ///     Fetch all users in the system.
    /// </summary>
    /// <returns>A list of users.</returns>
    Task<IList<User>> GetAllUsersAsync(CancellationToken cancellationToken = default);

    /// <summary>
    ///     Create a new user profile.
    /// </summary>
    /// <param name="createUserRequest">The details of the user to create.</param>
    /// <returns>The created user profile.</returns>
    Task<User> CreateUserAsync(CreateUserRequest createUserRequest, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Fetch a specific user's profile by user ID.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>The user's profile.</returns>
    Task<User> GetUserByIdAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Update the details of an existing user.
    /// </summary>
    /// <param name="userId">The ID of the user to update.</param>
    /// <param name="userUpdateRequest">The updated user details.</param>
    /// <returns>A task representing the update operation.</returns>
    Task UpdateUserAsync(string userId, UpdateUserRequest userUpdateRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Delete a user from the system.
    /// </summary>
    /// <param name="userId">The ID of the user to delete.</param>
    /// <returns>A task representing the deletion operation.</returns>
    Task DeleteUserAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Update the password for a specific user.
    /// </summary>
    /// <param name="userId">The ID of the user whose password will be updated.</param>
    /// <param name="passwordRequest">The new password details.</param>
    /// <param name="cancellationToken"></param>
    /// <returns>A task representing the password update operation.</returns>
    Task UpdateUserPasswordAsync(string userId, UpdatePasswordRequest passwordRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Fetch all API tokens for a specific user.
    /// </summary>
    /// <param name="userId">The ID of the user whose tokens are to be fetched.</param>
    /// <returns>A list of API tokens.</returns>
    Task<IList<ApiToken>> GetApiTokensAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Create a new API token for a specific user.
    /// </summary>
    /// <param name="userId">The ID of the user for whom to create the API token.</param>
    /// <returns>The newly created API token.</returns>
    Task<ApiToken> CreateApiTokenAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Revoke a specific API token for a user.
    /// </summary>
    /// <param name="userId">The ID of the user whose API token will be revoked.</param>
    /// <param name="apiTokenId">The ID of the API token to expire.</param>
    /// <returns>A task representing the revoke operation.</returns>
    Task RevokeApiTokenAsync(string userId, string apiTokenId, CancellationToken cancellationToken = default);
}