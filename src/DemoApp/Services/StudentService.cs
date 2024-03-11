namespace src.DemoApp.Services;

public interface IStudentService
{
    Task<List<string>> Students();
}


public class StudentService : IStudentService
{
    public async Task<List<string>> Students()
    {
        List<string> students = ["John", "Jane", "July"];

        return await Task.FromResult(students);
    }
}