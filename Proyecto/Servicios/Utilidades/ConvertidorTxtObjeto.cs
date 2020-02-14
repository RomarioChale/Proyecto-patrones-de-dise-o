using Proyecto.Entitidades;
using Proyecto.Servicios.BuilderPedido;
using Proyecto.Servicios.BuilderPedido.Interfaces;
using Proyecto.Servicios.Utilidades;
using System;
using System.Collections.Generic;

namespace Proyecto.Servicios
{
    public class ConvertidorTxtObjeto
    {
        readonly ILectorArchivo _lectorArchivo;
        readonly IVerificadorPaqueteria _verificadorPaqueteria;
        public ConvertidorTxtObjeto(ILectorArchivo lectorArchivos, IVerificadorPaqueteria verificadorPaqueteria)
        {
            _verificadorPaqueteria = verificadorPaqueteria;
            _lectorArchivo = lectorArchivos;
        }

        public List<Pedido> AsignarDatosDeArchivos(string nombreArchivo)
        {
            string[] lines = _lectorArchivo.LeerArchivo(nombreArchivo);
            string[] datos;
            char[] charSeparators = new char[] { ',' };
            try
            {
                List<Pedido> pedidos = new List<Pedido>();

                foreach (string line in lines)
                {

                    datos = line.Split(charSeparators);

                    Pedido pedido = EnsablarPedido(datos);

                    pedidos.Add(pedido);
                }
                return pedidos;
            }
            catch (Exception ex)
            {
                Exception exception = new Exception(ex.Message);
                throw exception;
            }


        }

        private Pedido EnsablarPedido(string[] datos)
        {
            PedidoBuilder constructorPaqueteria = _verificadorPaqueteria.VerificarPaqueteria(datos[3]);
            Pedido pedido = new Pedido()
            {
                Origen = datos[0],
                Destino = datos[1],
                Distancia = Convert.ToDouble(datos[2]),
                Paqueteria = constructorPaqueteria.GetPaqueteria(),
                FechaPedido = Convert.ToDateTime(datos[5])
            };

            PedidoAssemble pedidoAssemble = new PedidoAssemble(constructorPaqueteria);
            pedidoAssemble.Assemble(pedido);
            return pedido;
        }

       
    }
}
