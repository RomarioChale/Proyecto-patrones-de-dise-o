using Proyecto.Entitidades;
using Proyecto.Entitidades.Paqueteria;
using Proyecto.Servicios.Utilidades.Calculos;
using System;
using System.Collections.Generic;

namespace Proyecto.Servicios
{
    public class PedidoService : IPedidoService
    {
        private readonly ICalculadorCostoEnvio _calculadorCostoEnvio;
        private readonly ICalculadorFechaEntrega _calculadorFechaEntrega;
        private readonly ICalculadorTiempoTraslado _calculadorTiempoTraslado;

        public PedidoService(ICalculadorCostoEnvio calculadorCostoEnvio, ICalculadorFechaEntrega calculadorFechaEntrega, ICalculadorTiempoTraslado caculadorTiempoTraslado)
        {
            _calculadorCostoEnvio = calculadorCostoEnvio;
            _calculadorFechaEntrega = calculadorFechaEntrega;
            _calculadorTiempoTraslado = caculadorTiempoTraslado;
        }



        public List<Pedido> ObtenerDatosLogisticaPedido(List<Pedido> pedidos)
        {
            List<Pedido> Costosedidos = new List<Pedido>();
            foreach (Pedido pedido in pedidos)
            {
                pedido.CostoEnvio = ObtenerCostoEnvio(pedido.Distancia, pedido.Paqueteria);
                pedido.TiempoTraslado = ObtenerTiempoTraslado(pedido.Distancia, pedido.Paqueteria.Transporte.VelocidadEntrega);
                pedido.FechaEntrega = ObtenerFechaEntrega(pedido.FechaPedido, pedido.TiempoTraslado);

                Costosedidos.Add(pedido);
            }

            return Costosedidos;
        }

        private double ObtenerCostoEnvio(double distancia, IPaqueteria paqueteria)
        {
            return _calculadorCostoEnvio.CalcularCostoEnvio(paqueteria.Transporte, distancia, paqueteria);
        }

        private DateTime ObtenerFechaEntrega(DateTime fechaPedido, double tiempoTraslado)
        {
            return _calculadorFechaEntrega.CalcularFechaEntrega(fechaPedido, tiempoTraslado);
        }


        private double ObtenerTiempoTraslado(double distancia, double velocidad)
        {
            return _calculadorTiempoTraslado.CalcularTiempoTraslado(distancia, velocidad);
        }
    }
}
