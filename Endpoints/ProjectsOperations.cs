using Ardalis.GuardClauses;
using SemaphoreUI.NET.Model;

namespace SemaphoreUI.NET.Endpoints;

internal class ProjectsOperations : IProjectsOperations
{
    private readonly SemaphoreUiClient _client;

    internal ProjectsOperations(SemaphoreUiClient client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken cancellationToken = default)
    {
        return await _client.MakeRequestAsync<IEnumerable<Project>>(HttpMethod.Get, "/projects", cancellationToken);
    }

    public async Task<Project> CreateProjectAsync(CreateProjectRequest projectRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.Null(projectRequest, nameof(projectRequest));
        return await _client.MakeRequestAsync<Project>(HttpMethod.Post, "/projects", cancellationToken, projectRequest);
    }
}