using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using royaltjänstflytt.Feature;
using royaltjänstflytt.Models;

namespace royaltjänstflytt.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMainService _mainService;

    public HomeController(ILogger<HomeController> logger, IMainService mainService)
    {
        _logger = logger;
        _mainService = mainService;
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
    [HttpPost]
    public async Task<IActionResult> CleaningSubmit(Move move) 
    {
        if (ModelState.IsValid)
        {
            var item =await _mainService.CreateMoveItem(move);
            if (item is Move)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Error");
        }
        return RedirectToAction("Error");
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
