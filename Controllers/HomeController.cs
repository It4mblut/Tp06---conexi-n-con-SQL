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
        


        return View();
    }

    public IActionResult elegirAccion(string accion){

        if(accion=="Listar clientes" || accion=="Eliminar clientes" || accion=="Modificar datos de mozos" || accion=="Agregar comidas" || accion=="Listar registros"){
            
            ViewBag.clients = DB.saveClients();
            ViewBag.tableRegister=DB.saveTableRegisters();
            ViewBag.waiters=DB.saveWaiters();
            ViewBag.tables=DB.saveTables();

            return View(accion);
        }else{
            return View("Index");
        }


    }


}
