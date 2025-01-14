using Ardalis.GuardClauses;
using SemaphoreUI.NET.Model;

namespace SemaphoreUI.NET.Endpoints;

public class ProjectOperations : IProjectOperations
{
    private readonly SemaphoreUiClient _client;

    internal ProjectOperations(SemaphoreUiClient client)
    {
        _client = client;
    }

    #region Implementation of IProjectOperations

    public async Task<Project> GetProjectAsync(int projectId, CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        return await _client.MakeRequestAsync<Project>(HttpMethod.Get, $"/projects/{projectId}", cancellationToken)
                   .ConfigureAwait(false);
    }

    public async Task UpdateProjectAsync(int projectId, Project updateRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.Null(updateRequest, nameof(updateRequest));

        await _client.MakeRequestAsync(HttpMethod.Put, $"/projects/{projectId}", cancellationToken, updateRequest);
    }

    public async Task DeleteProjectAsync(int projectId, CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));

        await _client.MakeRequestAsync(HttpMethod.Delete, $"/projects/{projectId}", cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<IList<SemaphoreEvent>> GetProjectEventsAsync(int projectId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));

        return await _client
                   .MakeRequestAsync<SemaphoreEvent[]>(HttpMethod.Get, $"/projects/{projectId}/events",
                                                       cancellationToken).ConfigureAwait(false);
    }

    public async Task<IList<User>> GetProjectUsersAsync(int projectId, string sort, string order,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NullOrEmpty(sort, nameof(sort));
        Guard.Against.NullOrEmpty(order, nameof(order));

        return await _client
                   .MakeRequestAsync<User[]>(HttpMethod.Get,
                                             $"/projects/{projectId}/users?sort={sort}&order={order}",
                                             cancellationToken).ConfigureAwait(false);
    }

    public async Task AddUserToProjectAsync(int projectId, LinkUserRequest request,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.Null(request, nameof(request));

        await _client.MakeRequestAsync(HttpMethod.Post, $"/projects/{projectId}/users", cancellationToken, request)
            .ConfigureAwait(false);
    }

    public async Task RemoveUserFromProjectAsync(int projectId, int userId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(userId, nameof(userId));

        await _client
            .MakeRequestAsync(HttpMethod.Delete, $"/projects/{projectId}/users/{userId}", cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task MakeUserAdminAsync(int projectId, int userId, CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(userId, nameof(userId));

        await _client
            .MakeRequestAsync(HttpMethod.Post, $"/projects/{projectId}/users/{userId}/admin", cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task RevokeUserAdminAsync(int projectId, int userId, CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(userId, nameof(userId));

        await _client
            .MakeRequestAsync(HttpMethod.Delete, $"/projects/{projectId}/users/{userId}/admin", cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<IList<AccessKey>> GetProjectAccessKeysAsync(int projectId, string keyType, string sort,
        string order, CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NullOrEmpty(keyType, nameof(keyType));
        Guard.Against.NullOrEmpty(sort, nameof(sort));
        Guard.Against.NullOrEmpty(order, nameof(order));

        return await _client
                   .MakeRequestAsync<AccessKey[]>(HttpMethod.Get,
                                                  $"/projects/{projectId}/access-keys?keyType={keyType}&sort={sort}&order={order}",
                                                  cancellationToken).ConfigureAwait(false);
    }

    public async Task AddAccessKeyToProjectAsync(int projectId, AccessKeyRequest accessKeyRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.Null(accessKeyRequest, nameof(accessKeyRequest));

        await _client.MakeRequestAsync(HttpMethod.Post, $"/projects/{projectId}/access-keys", cancellationToken,
                                       accessKeyRequest).ConfigureAwait(false);
    }

    public async Task UpdateAccessKeyAsync(int projectId, int keyId, AccessKeyRequest accessKeyRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(keyId, nameof(keyId));
        Guard.Against.Null(accessKeyRequest, nameof(accessKeyRequest));

        await _client.MakeRequestAsync(HttpMethod.Put, $"/projects/{projectId}/access-keys/{keyId}",
                                       cancellationToken, accessKeyRequest).ConfigureAwait(false);
    }

    public async Task RemoveAccessKeyAsync(int projectId, int keyId, CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(keyId, nameof(keyId));

        await _client
            .MakeRequestAsync(HttpMethod.Delete, $"/projects/{projectId}/access-keys/{keyId}", cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<IList<Repository>> GetProjectRepositoriesAsync(int projectId, string sort, string order,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NullOrEmpty(sort, nameof(sort));
        Guard.Against.NullOrEmpty(order, nameof(order));

        return await _client
                   .MakeRequestAsync<Repository[]>(HttpMethod.Get,
                                                   $"/projects/{projectId}/repositories?sort={sort}&order={order}",
                                                   cancellationToken).ConfigureAwait(false);
    }

    public async Task AddRepositoryToProjectAsync(int projectId, AddRepositoryRequest addRepositoryRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.Null(addRepositoryRequest, nameof(addRepositoryRequest));

        await _client.MakeRequestAsync(HttpMethod.Post, $"/projects/{projectId}/repositories", cancellationToken,
                                       addRepositoryRequest).ConfigureAwait(false);
    }

    public async Task RemoveRepositoryFromProjectAsync(int projectId, int repositoryId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(repositoryId, nameof(repositoryId));

        await _client.MakeRequestAsync(HttpMethod.Delete, $"/projects/{projectId}/repositories/{repositoryId}",
                                       cancellationToken).ConfigureAwait(false);
    }

    public async Task<IList<InventoryResponse>> GetProjectInventoryAsync(int projectId, string sort, string order,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NullOrEmpty(sort, nameof(sort));
        Guard.Against.NullOrEmpty(order, nameof(order));

        return await _client
                   .MakeRequestAsync<InventoryResponse[]>(HttpMethod.Get,
                                                  $"/projects/{projectId}/inventory?sort={sort}&order={order}",
                                                  cancellationToken).ConfigureAwait(false);
    }

    public async Task<InventoryResponse> CreateInventoryAsync(int projectId, InventoryRequest inventoryRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.Null(inventoryRequest, nameof(inventoryRequest));

        return await _client
                   .MakeRequestAsync<InventoryResponse>(HttpMethod.Post, $"/projects/{projectId}/inventory",
                                                cancellationToken, inventoryRequest).ConfigureAwait(false);
    }

    public async Task UpdateInventoryAsync(int projectId, int inventoryId, InventoryRequest inventoryRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(inventoryId, nameof(inventoryId));
        Guard.Against.Null(inventoryRequest, nameof(inventoryRequest));

        await _client.MakeRequestAsync(HttpMethod.Put, $"/projects/{projectId}/inventory/{inventoryId}",
                                       cancellationToken, inventoryRequest).ConfigureAwait(false);
    }

    public async Task RemoveInventoryAsync(int projectId, int inventoryId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(inventoryId, nameof(inventoryId));

        await _client
            .MakeRequestAsync(HttpMethod.Delete, $"/projects/{projectId}/inventory/{inventoryId}",
                              cancellationToken).ConfigureAwait(false);
    }

    public async Task<IList<SemaphoreUiEnvironment>> GetProjectEnvironmentsAsync(int projectId, string sort,
        string order, CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NullOrEmpty(sort, nameof(sort));
        Guard.Against.NullOrEmpty(order, nameof(order));

        return await _client
                   .MakeRequestAsync<SemaphoreUiEnvironment[]>(HttpMethod.Get,
                                                               $"/projects/{projectId}/environments?sort={sort}&order={order}",
                                                               cancellationToken).ConfigureAwait(false);
    }

    public async Task AddEnvironmentToProjectAsync(int projectId, EnvironmentRequest environmentRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.Null(environmentRequest, nameof(environmentRequest));

        await _client.MakeRequestAsync(HttpMethod.Post, $"/projects/{projectId}/environments", cancellationToken,
                                       environmentRequest).ConfigureAwait(false);
    }

    public async Task UpdateEnvironmentAsync(int projectId, int environmentId,
        EnvironmentRequest environmentRequest, CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(environmentId, nameof(environmentId));
        Guard.Against.Null(environmentRequest, nameof(environmentRequest));

        await _client.MakeRequestAsync(HttpMethod.Put, $"/projects/{projectId}/environments/{environmentId}",
                                       cancellationToken, environmentRequest).ConfigureAwait(false);
    }

    public async Task RemoveEnvironmentAsync(int projectId, int environmentId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(environmentId, nameof(environmentId));

        await _client.MakeRequestAsync(HttpMethod.Delete, $"/projects/{projectId}/environments/{environmentId}",
                                       cancellationToken).ConfigureAwait(false);
    }

    public async Task<IList<Template>> GetProjectTemplatesAsync(int projectId, string sort, string order,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NullOrEmpty(sort, nameof(sort));
        Guard.Against.NullOrEmpty(order, nameof(order));

        return await _client
                   .MakeRequestAsync<Template[]>(HttpMethod.Get,
                                                 $"/projects/{projectId}/templates?sort={sort}&order={order}",
                                                 cancellationToken).ConfigureAwait(false);
    }

    public async Task AddTemplateToProjectAsync(int projectId, TemplateRequest templateRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.Null(templateRequest, nameof(templateRequest));

        await _client
            .MakeRequestAsync(HttpMethod.Post, $"/projects/{projectId}/templates", cancellationToken,
                              templateRequest).ConfigureAwait(false);
    }

    public async Task UpdateTemplateAsync(int projectId, int templateId, TemplateRequest templateRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(templateId, nameof(templateId));
        Guard.Against.Null(templateRequest, nameof(templateRequest));

        await _client.MakeRequestAsync(HttpMethod.Put, $"/projects/{projectId}/templates/{templateId}",
                                       cancellationToken, templateRequest).ConfigureAwait(false);
    }

    public async Task RemoveTemplateFromProjectAsync(int projectId, int templateId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(templateId, nameof(templateId));

        await _client
            .MakeRequestAsync(HttpMethod.Delete, $"/projects/{projectId}/templates/{templateId}", cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<IList<SemaphoreTask>> GetProjectTasksAsync(int projectId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));

        return await _client
                   .MakeRequestAsync<SemaphoreTask[]>(HttpMethod.Get, $"/projects/{projectId}/tasks", cancellationToken)
                   .ConfigureAwait(false);
    }

    public async Task<SemaphoreTask> StartProjectTaskAsync(int projectId, StartProjectTaskRequest taskRequest,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.Null(taskRequest, nameof(taskRequest));

        return await _client
                   .MakeRequestAsync<SemaphoreTask>(HttpMethod.Post, $"/projects/{projectId}/tasks", cancellationToken,
                                                    taskRequest).ConfigureAwait(false);
    }

    public async Task<IList<SemaphoreTask>> GetLast200ProjectTasksAsync(int projectId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));

        return await _client
                   .MakeRequestAsync<SemaphoreTask[]>(HttpMethod.Get, $"/projects/{projectId}/tasks/last",
                                                      cancellationToken)
                   .ConfigureAwait(false);
    }

    public async Task<SemaphoreTask> GetProjectTaskAsync(int projectId, int taskId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(taskId, nameof(taskId));

        return await _client
                   .MakeRequestAsync<SemaphoreTask>(HttpMethod.Get, $"/projects/{projectId}/tasks/{taskId}",
                                                    cancellationToken).ConfigureAwait(false);
    }

    public async Task DeleteProjectTaskAsync(int projectId, int taskId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(taskId, nameof(taskId));

        await _client
            .MakeRequestAsync(HttpMethod.Delete, $"/projects/{projectId}/tasks/{taskId}", cancellationToken)
            .ConfigureAwait(false);
    }

    public async Task<SemaphoreTaskOutput> GetProjectTaskOutputAsync(int projectId, int taskId,
        CancellationToken cancellationToken = default)
    {
        Guard.Against.NegativeOrZero(projectId, nameof(projectId));
        Guard.Against.NegativeOrZero(taskId, nameof(taskId));

        return await _client
                   .MakeRequestAsync<SemaphoreTaskOutput>(HttpMethod.Get,
                                                          $"/projects/{projectId}/tasks/{taskId}/output",
                                                          cancellationToken).ConfigureAwait(false);
    }

    #endregion
}