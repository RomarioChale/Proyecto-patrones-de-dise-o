using Proyecto.Servicios.Utilidades.Expresiones.ObservadorExpresion.Utilidades;
using Proyecto.Servicios.Utilidades.Validador_rango_de_tiempo.Utilerias;

namespace Proyecto.Entitidades
{
    public class EstadoPedido
    {
        public double TiempoViaje { get; set; }
        public UnidadTiempo UnidadTiempo { get; set; }
        public TipoExpresiones TipoExpresiones { get; set; }
    }
}
