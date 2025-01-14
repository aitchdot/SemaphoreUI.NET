using System.Net;

namespace SemaphoreUI.NET;

public class SemaphoreUiApiException(HttpStatusCode statusCode, string responseBody)
    : Exception($"SemaphoreUI API responded with status code={statusCode}, response={responseBody}")
{
    public HttpStatusCode StatusCode { get; private set; } = statusCode;

    public string ResponseBody { get; private set; } = responseBody;
}