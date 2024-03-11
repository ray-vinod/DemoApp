using MinimalApiEndpoints;
using src.DemoApp.Services;

namespace src.DemoApp.Endpoints;

public partial class Endpoints
{
    public class Home : IEndpoint
    {
        public void Endpoints(IEndpointRouteBuilder app)
        {
            app.MapGet("/home", () => "Hello from Home!");
            app.MapGet("/home/message", (IHomeService homeService) => homeService.Message());
        }
    }
}