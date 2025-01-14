using SemaphoreUI.NET.Model;

namespace SemaphoreUI.NET.Endpoints;

/// <summary>
///     Interface defining the operations related to projects.
/// </summary>
public interface IProjectsOperations
{
    /// <summary>
    ///     Fetches all the projects.
    /// </summary>
    /// <returns>A list of projects.</returns>
    Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    ///     Creates a new project.
    /// </summary>
    /// <param name="CreateProjectRequest">The project details to create the new project.</param>
    /// <returns>The newly created project.</returns>
    Task<Project> CreateProjectAsync(CreateProjectRequest projectRequest,
        CancellationToken cancellationToken = default);
}