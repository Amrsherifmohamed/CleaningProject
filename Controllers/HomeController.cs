using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using royaltjänstflytt.Models;

namespace royaltjänstflytt.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
        
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }



    public IActionResult Cleaning()
    {
        return View();
    }

    public IActionResult Moving()
    {
        return View();
    }

    public IActionResult Storage()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
