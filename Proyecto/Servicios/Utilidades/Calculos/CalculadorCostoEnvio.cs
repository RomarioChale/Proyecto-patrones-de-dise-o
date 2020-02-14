using Proyecto.Entitidades;
using Proyecto.Entitidades.Paqueteria;
using System.Collections.Generic;

namespace Proyecto.Servicios.Utilidades.Calculos
{
    public class CalculadorCostoEnvio : ICalculadorCostoEnvio
    {
        public double CalcularCostoEnvio(ITransporte transporte, double distancia, IPaqueteria paqueteria)
        {
            double costoEnvio;

            costoEnvio = CalcularCostoPorTrasnporte(transporte, distancia) * CalcularMargenUtilidad(paqueteria);

            return costoEnvio;
        }

        private double CalcularCostoPorTrasnporte(ITransporte transporte, double distancia)
        {
            double costoTrasporte;

            costoTrasporte = transporte.CostoKilometro * distancia;

            return costoTrasporte;
        }

        private double CalcularMargenUtilidad(IPaqueteria paqueteria)
        {
            double margenUtilidad;

            margenUtilidad = (paqueteria.Utilidad + 1) / 100;

            return margenUtilidad;
        }
    }
}
