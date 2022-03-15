using Practica01.Models;

namespace Practica01.Service
{
    public interface IOperaciones
    {

        Double Suma(Acciones acciones);
        Double Resta(Acciones acciones);
        Double Multiplicacion(Acciones acciones);
        Double Div(Acciones acciones);
    }
}
