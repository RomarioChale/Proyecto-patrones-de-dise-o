using Proyecto.Persistencia.BuilderPedido;
using Proyecto.Servicios.BuilderPedido;
using Proyecto.Servicios.BuilderPedido.Interfaces;

namespace Proyecto.Servicios
{
    public class VerificadorPaqueteria : IVerificadorPaqueteria
    {
        public PedidoBuilder VerificarPaqueteria(string NombrePaqueteria)
        {
            PedidoBuilder paqueteria;
            switch (NombrePaqueteria)
            {
                case "Fedex":
                    paqueteria = new PedidoFedex();
                    break;

                case "Estafeta":
                    paqueteria = new PedidoEstafeta();
                    break;

                case "DHL":
                    paqueteria = new PedidoDHL();
                    break;

                default:
                    paqueteria = new PedidoFedex();
                    break;
            }

            return paqueteria;
        }
    }
}
