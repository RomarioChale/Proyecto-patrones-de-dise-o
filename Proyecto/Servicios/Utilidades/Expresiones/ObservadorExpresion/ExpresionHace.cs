using Proyecto.Servicios.Utilidades.Expresiones.ObservadorEvento.Interfaces;
using Proyecto.Servicios.Utilidades.Expresiones.ObservadorExpresion.Utilidades;
using System;

namespace Proyecto.Servicios.Utilidades.Expresiones.ObservadorExpresion
{
    public class ExpresionHace : IObservadorExpresion
    {
        public TipoExpresiones AsignarExpresion()
        {
           return TipoExpresiones.Hace;
        }
    }
}
