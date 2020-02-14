using Proyecto.Entitidades.Paqueteria;
using Proyecto.Servicios.BuilderPedido.Interfaces;

namespace Proyecto.Servicios
{
    public interface IVerificadorPaqueteria
    {
        PedidoBuilder VerificarPaqueteria(string NombrePaqueteria);
    }
}