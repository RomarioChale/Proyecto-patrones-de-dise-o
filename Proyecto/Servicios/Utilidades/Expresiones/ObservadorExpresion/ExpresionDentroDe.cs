using Proyecto.Servicios.Utilidades.Expresiones.ObservadorEvento.Interfaces;
using Proyecto.Servicios.Utilidades.Expresiones.ObservadorExpresion.Utilidades;

namespace Proyecto.Servicios.Utilidades.Expresiones
{
    public class ExpresionDentroDe : IObservadorExpresion
    {
        public TipoExpresiones AsignarExpresion()
        {
            return TipoExpresiones.DentroDe;
        }
    }
}
