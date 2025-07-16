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
            ViewBag.foodTypes=DB.saveFoodTypes();

            return View(accion);
        }else{
            return View("Index");
        }


    }


 [HttpPost]
    public IActionResult agregarComida(string nombre, int idTipoComida, double precio, bool sinGluten){
        if(nombre != null && precio != null){
            DB.addFood(nombre, idTipoComida, precio, sinGluten);
        }
        

        return View("Index");
    }


[HttpPost]
    public IActionResult borrarCliente(int idCliente){
        
        if(idCliente != null){
            DB.deleteClient(idCliente);
        }

        return View("Index");
    }

[HttpPost]
    public IActionResult modificarMozo(string nombre, string apellido, int idMozo){
        
        
        DB.modifyWaiter(idMozo, apellido, nombre);

        return View("Index");
    }
}
