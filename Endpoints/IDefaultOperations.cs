using SemaphoreUI.NET.Model;

namespace SemaphoreUI.NET.Endpoints;

/// <summary>
///     Interface defining the default operations.
/// </summary>
public interface IDefaultOperations
{
    /// <summary>
    ///     Ping the server.
    /// </summary>
    Task<string> PingAsync(CancellationToken cancellationToken = default);

    /// <summary>
    ///     Handle the WebSocket connection.
    /// </summary>
    Task WebSocketHandler(CancellationToken cancellationToken = default);

    /// <summary>
    ///     Get information about the system.
    /// </summary>
    Task<InfoType> GetInfoAsync(CancellationToken cancellationToken = default);

    /// <summary>
    ///     Check for updates.
    /// </summary>
    Task<InfoType> CheckForUpdateAsync(CancellationToken cancellationToken = default);

    /// <summary>
    ///     Trigger the update process.
    /// </summary>
    Task UpdateAsync(CancellationToken cancellationToken = default);

    /// <summary>
    ///     Get events from the server.
    /// </summary>
    Task<IList<SemaphoreEvent>> GetEventsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    ///     Get the last events from the server.
    /// </summary>
    Task<IList<SemaphoreEvent>> GetLastEventsAsync(CancellationToken cancellationToken = default);
}