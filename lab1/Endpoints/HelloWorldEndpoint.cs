using FastEndpoints;

namespace lab1.Endpoints;

public class HelloWorldEndpoint : EndpointWithoutRequest
{
    public override void Configure()
    {
        Get("/api/hello-world");
        AllowAnonymous();
    }
    
    public override async Task HandleAsync(CancellationToken ct)
    {
        // new { message = "Hello, World!" }
        await SendAsync("Hello, World!", cancellation: ct);
    }
}