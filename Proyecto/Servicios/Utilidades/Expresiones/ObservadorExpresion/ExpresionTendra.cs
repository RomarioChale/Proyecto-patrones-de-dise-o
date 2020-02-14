using Proyecto.Servicios.Utilidades.Expresiones.ObservadorEvento.Interfaces;
using Proyecto.Servicios.Utilidades.Expresiones.ObservadorExpresion.Utilidades;

namespace Proyecto.Servicios.Utilidades.Expresiones.ObservadorExpresion
{
    public class ExpresionTendra : IObservadorExpresion
    {
        public TipoExpresiones AsignarExpresion()
        {
         return TipoExpresiones.Tendrá;

        }
    }
}
