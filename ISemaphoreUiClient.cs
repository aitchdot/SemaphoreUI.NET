using SemaphoreUI.NET.Endpoints;

namespace SemaphoreUI.NET;

public interface ISemaphoreUiClient : IAsyncDisposable
{
    SemaphoreUiConfiguration Configuration { get; }

    TimeSpan DefaultTimeout { get; set; }

    IProjectOperations Project { get; }

    IUserOperations Users { get; }

    IProjectsOperations Projects { get; }
    IDefaultOperations Default { get; }
}