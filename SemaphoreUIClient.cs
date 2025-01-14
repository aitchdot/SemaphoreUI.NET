using System.Net;
using System.Text;
using Newtonsoft.Json;
using SemaphoreUI.NET.Endpoints;
using SemaphoreUI.NET.Model;

namespace SemaphoreUI.NET;

public class SemaphoreUiClient : ISemaphoreUiClient
{
    private readonly IAuthOperations _auth;
    private readonly string _baseUrl;
    private CookieContainer _cookieContainer;
    private readonly HttpClient _httpClient;

    public SemaphoreUiConfiguration Configuration { get; }
    public TimeSpan DefaultTimeout { get; set; }
    public IProjectOperations Project { get; }
    public IUserOperations Users { get; }
    public IProjectsOperations Projects { get; }
    public IDefaultOperations Default { get; }

    public SemaphoreUiClient(SemaphoreUiConfiguration configuration)
    {
        _baseUrl = configuration.BaseUrl;
        Project = new ProjectOperations(this);
        Projects = new ProjectsOperations(this);
        Users = new UserOperations(this);
        Default = new DefaultOperations(this);
        _auth = new AuthOperations(this);

        _cookieContainer = new CookieContainer();
        var handler = new HttpClientHandler
        {
            CookieContainer = _cookieContainer,
            UseCookies = true,
            AllowAutoRedirect = true
        };

        _httpClient = new HttpClient(handler);
    }

    public async ValueTask DisposeAsync()
    {
        await LogoutAsync(default);
        _httpClient?.Dispose();
    }

    private async Task<bool> EnsureAuthenticatedAsync()
    {
        try
        {
            Users.GetCurrentUserAsync();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    private async Task LogoutAsync(CancellationToken cancellationToken)
    {
        await _auth.LogoutAsync(cancellationToken);
        _cookieContainer = new CookieContainer();
    }

    internal async Task<T> MakeRequestAsync<T>(HttpMethod method, string path, CancellationToken cancellationToken,
        object? body = null)
    {
        var response = await PrivateMakeRequestAsync(method, path, cancellationToken, body);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            return JsonConvert.DeserializeObject<T>(content);
        }

        throw new Exception($"Error making request to {path}: {response.StatusCode}");
    }

    internal async Task MakeRequestAsync(HttpMethod method, string path, CancellationToken cancellationToken,
        object? body = null)
    {
        var response = await PrivateMakeRequestAsync(method, path, cancellationToken, body);
        if (!response.IsSuccessStatusCode)
            throw new Exception($"Error making request to {path}: {response.StatusCode}");
    }

    private async Task<HttpResponseMessage> PrivateMakeRequestAsync(HttpMethod method, string path,
        CancellationToken cancellationToken, object? body = null)
    {
        if (!await EnsureAuthenticatedAsync())
            if (!await _auth.LoginAsync(new Login(Configuration.Username, Configuration.Password), cancellationToken))
                throw new UnauthorizedAccessException("Unable to authenticate.");

        HttpContent? content = null;
        if (body != null)
            content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

        var requestMessage = new HttpRequestMessage(method, $"{_baseUrl}{path}") { Content = content };
        return await _httpClient.SendAsync(requestMessage, cancellationToken);
    }
}