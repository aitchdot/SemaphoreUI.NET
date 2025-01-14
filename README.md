# .NET Client for Semaphore UI API

This library allows you to interact with the Semaphore UI API endpoints in your .NET applications.

## Installation

You can add this library to your project using [NuGet](https://www.nuget.org/).

### Using the Package Manager Console

Run the following command in the **Package Manager Console**:

```powershell
Install-Package SemaphoreUI.NET
```

### Using .NET CLI
Run the following command in your terminal:

```bash
dotnet add package SemaphoreUI.NET
```

## Usage

### Initializing the Client

```csharp
using Semaphore.UI.Client;

SemaphoreApiClient client = new(new SemaphoreUiConfiguration(
    new Uri("https://semaphore.domain.tld:3000"), "User", "Password")
     .CreateClient();
```

### Examples

#### TODO:

### Exceptions

- **`SemaphoreApiException`**: Thrown when the Semaphore API responds with an error status code. Contains the response details.
- **`TaskCanceledException`**: Thrown when a request times out.
- **`ArgumentNullException`**: Thrown when a required parameter is missing.
