namespace AspNetCoreMVC.Services;

public interface IGreetingService
{
    string GetGreeting();
}

public class GreetingService : IGreetingService
{
    public string GetGreeting()
    {
        return "Hello world from ASP.NET CORE MVC";
    }
}