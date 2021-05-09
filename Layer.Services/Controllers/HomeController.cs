using Layer.Services.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Layer.Services.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILoggerManager _logger;

        public HomeController(ILoggerManager logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            //Traza personzalido Mensaje Tipo Informativo
            _logger.LogInformation("Metodo Informativo");

            //Traza personzalido Mensaje Tipo Advertencia
            _logger.LogAdvertencia("Metodo Warning");

            //Traza personzalido Mensaje Tipo Error
            _logger.LogError("Metodo Error");

            //Traza con el Nombre del Metodo, Mensaje de Excepcion y Mensaje Tipo Informativo
            _logger.LogInformation(System.Reflection.MethodBase.GetCurrentMethod().Name, new Exception("Mensaje Excepcion Info"));

            //Traza con el Nombre del Metodo, Mensaje de Excepcion y Mensaje Tipo Advertencia
            _logger.LogAdvertencia(System.Reflection.MethodBase.GetCurrentMethod().Name, new Exception("Mensaje Excepcion Advertencia"));

            //Traza con el Nombre del Metodo, Mensaje de Excepcion y Mensaje Tipo Error
            _logger.LogError(System.Reflection.MethodBase.GetCurrentMethod().Name, new Exception("Mensaje Excepcion Error"));


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
}
