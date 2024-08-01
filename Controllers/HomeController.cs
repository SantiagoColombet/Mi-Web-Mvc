using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mi_Web_Mvc.Models;

namespace Mi_Web_Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }




    public IActionResult Index()
    {
        return View("index");
    }

    public IActionResult Actividades()
    {
        return View("actividades");
    }
        public IActionResult Ciudades()
    {
        return View("ciudades");
    }
        public IActionResult Contactanos()
    {
        return View("contactanos");
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
