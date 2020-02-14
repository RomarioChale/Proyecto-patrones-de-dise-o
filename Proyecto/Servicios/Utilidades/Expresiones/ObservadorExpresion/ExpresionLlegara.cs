using Proyecto.Servicios.Utilidades.Expresiones.ObservadorEvento.Interfaces;
using Proyecto.Servicios.Utilidades.Expresiones.ObservadorExpresion.Utilidades;
using System;

namespace Proyecto.Servicios.Utilidades.Expresiones
{
    public class ExpresionLlegara : IObservadorExpresion
    {
        public TipoExpresiones AsignarExpresion()
        {
            return TipoExpresiones.Llegará;
        }
    }
}
