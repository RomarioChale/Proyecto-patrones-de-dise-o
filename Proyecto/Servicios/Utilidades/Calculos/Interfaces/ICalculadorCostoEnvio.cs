using Proyecto.Entitidades;
using Proyecto.Entitidades.Paqueteria;

namespace Proyecto.Servicios.Utilidades.Calculos
{
    public interface ICalculadorCostoEnvio
    {
        double CalcularCostoEnvio(ITransporte transporte, double distancia, IPaqueteria paqueteria);
    }
}