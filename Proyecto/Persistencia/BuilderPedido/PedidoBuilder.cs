using Proyecto.Entitidades;
using Proyecto.Entitidades.Paqueteria;
using System;

namespace Proyecto.Servicios.BuilderPedido.Interfaces
{
    public abstract class PedidoBuilder
    {
        protected Pedido _pedido = new Pedido();
        public Pedido Pedido { get { return _pedido; } }

       public abstract IPaqueteria GetPaqueteria();
       public abstract void AddOrigen(string origen);
       public abstract void AddDestino(string destino);
       public abstract void AddDistancia(double distancia);
       public abstract bool AddTransporte(ITransporte transporte);
       public abstract void AddFechaPedido(DateTime fechaPedido);

        //void AddEstadoPedido();
    }
}
