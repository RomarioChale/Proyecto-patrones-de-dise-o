using Proyecto.Entitidades;
using Proyecto.Servicios.Utilidades.Expresiones;
using Proyecto.Servicios.Utilidades.Expresiones.ObservadorEvento.Interfaces;
using Proyecto.Servicios.Utilidades.Expresiones.ObservadorExpresion;
using Proyecto.Servicios.Utilidades.Expresiones.ObservadorExpresion.Utilidades;
using System;
using System.Collections.Generic;

namespace Proyecto.Servicios
{
    public class ExpresionesService
    {
        private IPedidoService _pedidoService;

        private DateTime _fechaActual = DateTime.Now;
        public ExpresionesService(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        public void AsignarTiempoExpresion(List<Pedido> pedidos)
        {
            foreach (Pedido pedido in pedidos)
            {
                pedido.Expresiones = ValidarTiempoExpresion(pedido);
            }
        }

        private List<IObservadorExpresion> ValidarTiempoExpresion(Pedido pedido)
        {
            List<IObservadorExpresion> expresiones = new List<IObservadorExpresion>();

            if (pedido.FechaEntrega < _fechaActual)
            {
                expresiones.Add(new ExpresionSalio());
                expresiones.Add(new ExpresionLLego());
                expresiones.Add(new ExpresionHace());
                expresiones.Add(new ExpresionTuvo());
            }
            else
            {
                expresiones.Add(new ExpresionHaSalido());
                expresiones.Add(new ExpresionLlegara());
                expresiones.Add(new ExpresionDentroDe());
                expresiones.Add(new ExpresionTendra());
            }

            return expresiones;
        }


    }
}
