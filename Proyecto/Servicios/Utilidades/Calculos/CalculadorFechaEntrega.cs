using System;

namespace Proyecto.Servicios.Utilidades.Calculos
{
    public class CalculadorFechaEntrega : ICalculadorFechaEntrega
    {
        public DateTime CalcularFechaEntrega(DateTime fechaPedido, double tiempoTraslado)
        {
            DateTime fechaEntrega = fechaPedido.AddHours(tiempoTraslado);

            return fechaEntrega;
        }
    }
}
