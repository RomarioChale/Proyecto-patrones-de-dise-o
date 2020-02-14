using Proyecto.Entitidades;
using Proyecto.Servicios.BuilderPedido.Interfaces;

namespace Proyecto.Servicios.BuilderPedido
{
    public class PedidoAssemble
    {
        private readonly PedidoBuilder _pedidoBuilder;

        public PedidoAssemble(PedidoBuilder pedidoBuilder)
        {
            _pedidoBuilder = pedidoBuilder;
        }

        public void Assemble(Pedido pedido)
        {
            _pedidoBuilder.AddOrigen(pedido.Origen);
            _pedidoBuilder.AddDestino(pedido.Destino);
            _pedidoBuilder.AddDistancia(pedido.Distancia);
            _pedidoBuilder.AddFechaPedido(pedido.FechaPedido);
            _pedidoBuilder.AddTransporte(pedido.Paqueteria.Transporte);
        }

        public Pedido GetPedido()
        {
            return _pedidoBuilder.Pedido;
        }
    }
}
