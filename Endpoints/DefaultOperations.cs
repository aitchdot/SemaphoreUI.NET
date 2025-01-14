using SemaphoreUI.NET.Model;

namespace SemaphoreUI.NET.Endpoints;

internal class DefaultOperations : IDefaultOperations
{
    private readonly SemaphoreUiClient _client;

    internal DefaultOperations(SemaphoreUiClient client)
    {
        _client = client;
    }

    public async Task<string> PingAsync(CancellationToken cancellationToken = default)
    {
        return await _client.MakeRequestAsync<string>(HttpMethod.Get, "ping", cancellationToken)
                   .ConfigureAwait(false);
    }

    public async Task WebSocketHandler(CancellationToken cancellationToken = default)
    {
        await _client.MakeRequestAsync(HttpMethod.Get, "websocket", cancellationToken).ConfigureAwait(false);
    }

    public async Task<InfoType> GetInfoAsync(CancellationToken cancellationToken = default)
    {
        return await _client.MakeRequestAsync<InfoType>(HttpMethod.Get, "info", cancellationToken)
                   .ConfigureAwait(false);
    }

    public async Task<InfoType> CheckForUpdateAsync(CancellationToken cancellationToken = default)
    {
        return await _client.MakeRequestAsync<InfoType>(HttpMethod.Get, "update", cancellationToken)
                   .ConfigureAwait(false);
    }

    public async Task UpdateAsync(CancellationToken cancellationToken = default)
    {
        await _client.MakeRequestAsync(HttpMethod.Post, "update", cancellationToken).ConfigureAwait(false);
    }

    public async Task<IList<SemaphoreEvent>> GetEventsAsync(CancellationToken cancellationToken = default)
    {
        return await _client.MakeRequestAsync<SemaphoreEvent[]>(HttpMethod.Get, "events", cancellationToken)
                   .ConfigureAwait(false);
    }

    public async Task<IList<SemaphoreEvent>> GetLastEventsAsync(CancellationToken cancellationToken = default)
    {
        return await _client.MakeRequestAsync<SemaphoreEvent[]>(HttpMethod.Get, "events/last", cancellationToken)
                   .ConfigureAwait(false);
    }
}