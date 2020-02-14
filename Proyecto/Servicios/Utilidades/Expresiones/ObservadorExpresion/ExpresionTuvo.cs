using Proyecto.Servicios.Utilidades.Expresiones.ObservadorEvento.Interfaces;
using System;

namespace Proyecto.Servicios.Utilidades.Expresiones.ObservadorExpresion.Utilidades
{
    public class ExpresionTuvo : IObservadorExpresion
    {
        public TipoExpresiones AsignarExpresion()
        {
         return TipoExpresiones.Tuvó;
        }
    }
}
