using Microsoft.AspNetCore.Mvc;
using Practica01.Models;
using Practica01.Service;

namespace Practica01.Controllers
{
    public class StudentsController : Controller
    {

        private IEstudiante Estudiante;

        public StudentsController(IEstudiante estudiante)
        {
            Estudiante = estudiante;
        }

        public IActionResult Index()
        {
            //Estudiantes  es = new Estudiantes();
            //es.Id = 3;
            //es.Name = "Marlon";
            //es.LastName = "Martinez";
            ////Estudiante.UpdateStudents(es);//
            //Estudiante.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Insertardata(Estudiantes es)  { 

        return RedirectToAction("Index");
       // return View("Index");
        
        }
    }
}
