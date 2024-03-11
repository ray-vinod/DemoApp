using MinimalApiEndpoints;
using src.DemoApp.Services;

namespace src.DemoApp.Endpoints;

public partial class Endpoint
{
    public class Student : IEndpoint
    {
        public void Endpoints(IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/student");

            group.MapGet("", Students);

        }

        public async Task<IResult> Students(IStudentService studentService)
        {
            var students = await studentService.Students();

            return Results.Ok(new { Students = students });
        }
    }
}