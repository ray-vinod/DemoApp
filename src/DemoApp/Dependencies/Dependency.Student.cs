using Microsoft.EntityFrameworkCore;
using RegisterServices;
using src.DemoApp.Data;
using src.DemoApp.Services;

namespace src.DemoApp.Dependencies;

public partial class Dependency
{
    public class Student : IService
    {
        public void Services(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IStudentService, StudentService>();

            // Register Database
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}