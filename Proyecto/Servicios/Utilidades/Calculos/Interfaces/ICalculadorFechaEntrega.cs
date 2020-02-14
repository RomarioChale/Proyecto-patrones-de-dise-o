using System;

namespace Proyecto.Servicios.Utilidades.Calculos
{
    public interface ICalculadorFechaEntrega
    {
        DateTime CalcularFechaEntrega(DateTime fechaPedido, double tiempoTraslado);
    }
}