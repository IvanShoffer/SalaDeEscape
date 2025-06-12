using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SaladeEscape.Models;

namespace SaladeEscape.Controllers;

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
    public IActionResult comoJugar()
    {
        return View("comoJugar");
    }
     public IActionResult participantes()
    {
        return View("participantes");
    }
     public IActionResult final()
    {
        return View("final");
    }
    public IActionResult InicializarAcertijo()
    {
       Acertijo acertijo = new Acertijo();
       HttpContext.Session.SetString("juego", Objeto.ObjectToString(acertijo));

        return View("Sala1");
    }
    
    public IActionResult Sala1234(string respuesta)
    {
     Acertijo acertijo = Objeto.StringToObject<Acertijo>(HttpContext.Session.GetString("Juego"));
     if(acertijo !=null)
     {
 if (!acertijo.ValidarRespuesta(respuesta))
        {
        
            ViewBag.Mensaje = "Respuesta incorrecta. Intentá de nuevo.";
        }

        if(acertijo.SalaActual >= acertijo.RespuestasCorrectas.Count()){
            return View("final");
        }

  
    
        
     }
      HttpContext.Session.SetString("juego", Objeto.ObjectToString(acertijo));
      return View("Sala"+acertijo.SalaActual);
   
    }
}
  
 