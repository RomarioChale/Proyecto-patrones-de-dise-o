namespace Proyecto.Servicios.Utilidades.Calculos
{
    public class CalculadorTiempoTraslado : ICalculadorTiempoTraslado
    {
        public double CalcularTiempoTraslado(double distancia, double velocidad)
        {
            double TiempoTraslado = distancia / velocidad;

            return TiempoTraslado;
        }
    }
}

