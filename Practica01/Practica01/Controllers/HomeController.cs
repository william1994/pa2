using Microsoft.AspNetCore.Mvc;
using Practica01.Bussines;
using Practica01.Models;
using System.Diagnostics;

namespace Practica01.Controllers
{
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        Operaciones op = new Operaciones();
        public IActionResult Suma(Acciones acciones)
        {
            // Objeto de negocio
            
            Double resultado = op.Suma(acciones);

            ViewBag.VariableAEnviar = resultado;

            return View();
        }

        public IActionResult NoMayores(String dato1) {
        return View();
        }

        [HttpGet]
        public IActionResult PeticionTypeGet()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SecondPage() {

            return View();
        }

    }
}