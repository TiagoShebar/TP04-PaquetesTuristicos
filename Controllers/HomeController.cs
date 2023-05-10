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
        ViewBag.destinos = ORTWorld.ListaDestinos;
        ViewBag.hoteles = ORTWorld.ListaHoteles;
        ViewBag.aereos = ORTWorld.ListaAereos;
        ViewBag.excursiones = ORTWorld.ListaExcursiones;
        return View();
    }

    public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion){
        if(Destino == 0 || Hotel == 0 || Aereo == 0 || Excursion == 0){
            ViewBag.MensajeError = "ERROR. Datos Faltantes";
            return View("SelectPaquete");
        }
        else{
            ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino-1], new Paquete(ORTWorld.ListaHoteles[Hotel-1], ORTWorld.ListaAereos[Aereo-1], ORTWorld.ListaExcursiones[Excursion-1]));
        }
        ViewBag.paquetes = ORTWorld.Paquetes;
        return View("Index");
    }
}
