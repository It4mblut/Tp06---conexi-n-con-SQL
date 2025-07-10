using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PruebaDeDapperYSql.Models;

namespace PruebaDeDapperYSql.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.clients = DB.saveClients();

        
        return View();
    }
}
