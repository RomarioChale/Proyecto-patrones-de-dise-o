using System.Collections.Generic;
using Proyecto.Entitidades;

namespace Proyecto.Servicios
{
    public interface IPedidoService
    {
        List<Pedido> ObtenerDatosLogisticaPedido(List<Pedido> pedidos);
    }
}