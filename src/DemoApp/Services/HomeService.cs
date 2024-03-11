namespace src.DemoApp.Services;

public interface IHomeService
{
    string Message();
}


public class HomeService : IHomeService
{
    public string Message()
    {
        return "Hello from Home service!";
    }
}