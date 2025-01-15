namespace SemaphoreUI.NET;

public class SemaphoreUiConfiguration
{
    public const string Version = "1.0.0";

    public SemaphoreUiConfiguration(string baseUrl, string username, string password)
    {
        BaseUrl = baseUrl;
        Username = username;
        Password = password;
    }

    public string BaseUrl { get; set; } = "https://localhost:3000";
    public string Username { get; set; }
    public string Password { get; set; }

    public SemaphoreUiClient CreateClient()
    {
        return new DockerClient(this);
    }
}
