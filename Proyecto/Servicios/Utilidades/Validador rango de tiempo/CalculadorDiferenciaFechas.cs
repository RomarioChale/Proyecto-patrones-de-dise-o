using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Servicios.Utilidades.Validador_rango_de_tiempo
{
    public class CalculadorDiferenciaFechas : ICalculadorDiferenciaFechas
    {
        public double DirerenciaFechaActualYFechaEvento(DateTime fecha, DateTime fechaActual)
        {
            double horas = (fecha - fechaActual).TotalHours;

            return horas;
        }
    }
}
