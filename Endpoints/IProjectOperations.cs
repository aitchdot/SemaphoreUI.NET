using SemaphoreUI.NET.Model;

namespace SemaphoreUI.NET.Endpoints;

public interface IProjectOperations
{
    #region SemaphoreEvent Management

    /// <summary>
    ///     Get events associated with a project
    /// </summary>
    Task<IList<SemaphoreEvent>> GetProjectEventsAsync(int projectId, CancellationToken cancellationToken = default);

    #endregion

    #region Project Management

    /// <summary>
    ///     Fetch a project by its ID
    /// </summary>
    Task<Project> GetProjectAsync(int projectId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Update project details
    /// </summary>
    Task UpdateProjectAsync(int projectId, Project updateRequest, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Delete a project by its ID
    /// </summary>
    Task DeleteProjectAsync(int projectId, CancellationToken cancellationToken = default);

    #endregion

    #region User Management

    /// <summary>
    ///     Get a list of users linked to a project
    /// </summary>
    Task<IList<User>> GetProjectUsersAsync(int projectId, string sort, string order,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Link a user to a project
    /// </summary>
    Task AddUserToProjectAsync(int projectId, LinkUserRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Remove a user from a project
    /// </summary>
    Task RemoveUserFromProjectAsync(int projectId, int userId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Promote a user to admin within the project
    /// </summary>
    Task MakeUserAdminAsync(int projectId, int userId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Revoke admin privileges from a user
    /// </summary>
    Task RevokeUserAdminAsync(int projectId, int userId, CancellationToken cancellationToken = default);

    #endregion

    #region Access Key Management

    /// <summary>
    ///     Get access keys linked to the project
    /// </summary>
    Task<IList<AccessKey>> GetProjectAccessKeysAsync(int projectId, string keyType, string sort, string order,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Add a new access key to the project
    /// </summary>
    Task AddAccessKeyToProjectAsync(int projectId, AccessKeyRequest accessKeyRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Update an existing access key
    /// </summary>
    Task UpdateAccessKeyAsync(int projectId, int keyId, AccessKeyRequest accessKeyRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Remove an access key from the project
    /// </summary>
    Task RemoveAccessKeyAsync(int projectId, int keyId, CancellationToken cancellationToken = default);

    #endregion

    #region Repository Management

    /// <summary>
    ///     Get a list of repositories linked to the project
    /// </summary>
    Task<IList<Repository>> GetProjectRepositoriesAsync(int projectId, string sort, string order,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Add a repository to the project
    /// </summary>
    Task AddRepositoryToProjectAsync(int projectId, AddRepositoryRequest addRepositoryRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Remove a repository from the project
    /// </summary>
    Task RemoveRepositoryFromProjectAsync(int projectId, int repositoryId,
        CancellationToken cancellationToken = default);

    #endregion

    #region Inventory Management

    /// <summary>
    ///     Get the project inventory
    /// </summary>
    Task<IList<InventoryResponse>> GetProjectInventoryAsync(int projectId, string sort, string order,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Create a new inventory item in the project
    /// </summary>
    Task<InventoryResponse> CreateInventoryAsync(int projectId, InventoryRequest inventoryRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Update an existing inventory item in the project
    /// </summary>
    Task UpdateInventoryAsync(int projectId, int inventoryId, InventoryRequest inventoryRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Remove an inventory item from the project
    /// </summary>
    Task RemoveInventoryAsync(int projectId, int inventoryId, CancellationToken cancellationToken = default);

    #endregion

    #region Environment Management

    /// <summary>
    ///     Get the environments associated with the project
    /// </summary>
    Task<IList<SemaphoreUiEnvironment>> GetProjectEnvironmentsAsync(int projectId, string sort, string order,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Add a new environment to the project
    /// </summary>
    Task AddEnvironmentToProjectAsync(int projectId, EnvironmentRequest environmentRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Update an existing environment in the project
    /// </summary>
    Task UpdateEnvironmentAsync(int projectId, int environmentId, EnvironmentRequest environmentRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Remove an environment from the project
    /// </summary>
    Task RemoveEnvironmentAsync(int projectId, int environmentId, CancellationToken cancellationToken = default);

    #endregion

    #region Template Management

    /// <summary>
    ///     Get a list of templates linked to the project
    /// </summary>
    Task<IList<Template>> GetProjectTemplatesAsync(int projectId, string sort, string order,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Add a new template to the project
    /// </summary>
    Task AddTemplateToProjectAsync(int projectId, TemplateRequest templateRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Update an existing template in the project
    /// </summary>
    Task UpdateTemplateAsync(int projectId, int templateId, TemplateRequest templateRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Remove a template from the project
    /// </summary>
    Task RemoveTemplateFromProjectAsync(int projectId, int templateId,
        CancellationToken cancellationToken = default);

    #endregion

    #region Task Management

    /// <summary>
    ///     Get tasks associated with the project
    /// </summary>
    Task<IList<SemaphoreTask>> GetProjectTasksAsync(int projectId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Start a new task/job for the project
    /// </summary>
    Task<SemaphoreTask> StartProjectTaskAsync(int projectId, StartProjectTaskRequest taskRequest,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Get the most recent 200 tasks for the project
    /// </summary>
    Task<IList<SemaphoreTask>>
        GetLast200ProjectTasksAsync(int projectId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Get a specific task details by ID
    /// </summary>
    Task<SemaphoreTask> GetProjectTaskAsync(int projectId, int taskId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Delete a specific task by ID
    /// </summary>
    Task DeleteProjectTaskAsync(int projectId, int taskId, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Get the output of a specific task
    /// </summary>
    Task<SemaphoreTaskOutput> GetProjectTaskOutputAsync(int projectId, int taskId,
        CancellationToken cancellationToken = default);

    #endregion
}