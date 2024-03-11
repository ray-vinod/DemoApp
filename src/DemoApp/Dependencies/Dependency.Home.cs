using RegisterServices;
using src.DemoApp.Services;

namespace src.DemoApp.Dependencies;

public partial class Dependency
{
    public class Home : IService
    {
        public void Services(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IHomeService, HomeService>();
        }
    }
}