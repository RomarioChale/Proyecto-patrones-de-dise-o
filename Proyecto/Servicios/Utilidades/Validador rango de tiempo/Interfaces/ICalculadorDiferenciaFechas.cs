using System;

namespace Proyecto.Servicios.Utilidades.Validador_rango_de_tiempo
{
    public interface ICalculadorDiferenciaFechas
    {
        double DirerenciaFechaActualYFechaEvento(DateTime fecha, DateTime fechaActual);
    }
}