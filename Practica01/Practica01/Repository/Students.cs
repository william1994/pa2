using Practica01.Data;
using Practica01.Models;
using Practica01.Service;

namespace Practica01.Repository
{
    public class Students : IEstudiante
    {
        //Especificar la conexion con la basede datos solamente una vez
        //(AplicationdbContext Se encargara por nosotros para trabajar con las entidades
        //("Entidades son las tablas de la bd "))
        private ApplicationDBContext app;
        
        public Students(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddStudents(Estudiantes es)
        {

            //App pertenece a dbcontex
            //en dbcontext 
            //exite un dbset el cual tiene como nombre estudiante
            //que su vez es una representacion de la tabla de la bd
            app.Estudiantes.Add(es);
            app.SaveChanges();
           // throw new NotImplementedException();
        }

        public void DeleteStudents(Estudiantes es)
        {
            app.Estudiantes.Remove(es);
            app.SaveChanges();
           // throw new NotImplementedException();
        }

        public List<Estudiantes> GetAll()
        {
            
            return app.Estudiantes.ToList();
            //    throw new NotImplementedException();
        }

        public Estudiantes LoadInformation(Estudiantes es)
        {
            var listarestudiante = app.Estudiantes.Where(x=> x.Id==es.Id).FirstOrDefault();
            return listarestudiante;

        }

        public void UpdateStudents(Estudiantes es)
        {
            app.Estudiantes.Update(es);
            app.SaveChanges();
           // throw new NotImplementedException();
        }
    }
}
