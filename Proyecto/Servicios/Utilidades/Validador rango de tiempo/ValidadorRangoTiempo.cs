using Proyecto.Entitidades;
using Proyecto.Servicios.Utilidades.Validador_rango_de_tiempo.Utilerias;
using System;
using System.Collections.Generic;

namespace Proyecto.Servicios.Utilidades.Validador_rango_de_tiempo
{
    public class ValidadorRangoTiempo
    {
        private readonly DateTime _fechaActual = DateTime.Now;

        private readonly ICalculadorDiferenciaFechas _calcularDiferenciaDeFechas;
        public ValidadorRangoTiempo(ICalculadorDiferenciaFechas calcularDiferenciaDeFechas)
        {
            _calcularDiferenciaDeFechas = calcularDiferenciaDeFechas;
        }


        public List<object> EvaluarTiempoPorHoras(List<Pedido> pedidos)
        {
            double minutos;
            double cantidad;

            List<object> pedidossFechas = new List<object>();

            foreach (Pedido pedido in pedidos)
            {
                double horas = Math.Abs(_calcularDiferenciaDeFechas.DirerenciaFechaActualYFechaEvento(pedido.FechaPedido, _fechaActual));

                minutos = horas * 60;


                double tiempoViaje = Math.Round(minutos);
                UnidadTiempo unidadTiempo = UnidadTiempo.Minutos;
               // pedido.EstadoPedido.TipoExpresiones = evento.Fecha > _fechaActual ? Estatus.Ocurrirá : Estatus.Ocurrió;

                if (horas > 1 && horas < 24)
                {
                    tiempoViaje = Math.Round(horas);
                    unidadTiempo = UnidadTiempo.Horas;
                }
                if (horas > 24 && horas < 730)
                {
                    cantidad = horas / 24;
                    tiempoViaje = Math.Round(cantidad);
                    unidadTiempo = UnidadTiempo.Dias;
                }
                if (horas > 730)
                {
                    cantidad = horas / 730;

                    tiempoViaje = (Math.Round(cantidad) + 1);
                    unidadTiempo = UnidadTiempo.Meses;
                }

                pedidossFechas.Add(tiempoViaje);
                pedidossFechas.Add(unidadTiempo);
            }

            return pedidossFechas;
        }
    }
}
