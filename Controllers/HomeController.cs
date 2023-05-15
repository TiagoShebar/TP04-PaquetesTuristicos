using Microsoft.AspNetCore.Mvc;

namespace TP04PaquetesTurísticos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {   
        ViewBag.paquetes = ORTWorld.Paquetes;
        return View();
    }

    public IActionResult SelectPaquete(){
        CargarListas();
        return View();
    }

    public IActionResult GuardarPaquete(int destino, int hotel, int aereo, int excursion){
        if(destino == 0 || hotel == 0 || aereo == 0 || excursion == 0){
            ViewBag.MensajeError = "ERROR. Datos Faltantes";
            CargarListas();
            return View("SelectPaquete");
        }
        else{
            ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[destino-1], new Paquete(ORTWorld.ListaHoteles[hotel-1], ORTWorld.ListaAereos[aereo-1], ORTWorld.ListaExcursiones[excursion-1]));
            ViewBag.paquetes = ORTWorld.Paquetes;
            return View("Index");
        }
        
    }

    public void CargarListas(){
        ViewBag.destinos = ORTWorld.ListaDestinos;
        ViewBag.hoteles = ORTWorld.ListaHoteles;
        ViewBag.aereos = ORTWorld.ListaAereos;
        ViewBag.excursiones = ORTWorld.ListaExcursiones;
    }
}
