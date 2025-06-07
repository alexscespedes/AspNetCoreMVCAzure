using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMVC.Models;
using AspNetCoreMVC.Services;

namespace AspNetCoreMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IGreetingService _greetingService;

    public HomeController(ILogger<HomeController> logger, IGreetingService greetingService)
    {
        _logger = logger;
        _greetingService = greetingService;
    }

    public IActionResult Index()
    {
        ViewBag.Message = _greetingService.GetGreeting();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
