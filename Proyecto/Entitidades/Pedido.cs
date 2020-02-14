using Proyecto.Entitidades.Paqueteria;
using Proyecto.Servicios.Utilidades.Expresiones.ObservadorEvento.Interfaces;
using System;
using System.Collections.Generic;

namespace Proyecto.Entitidades
{
    public class Pedido
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public double Distancia { get; set; }
        public double CostoEnvio { get; set; }
        public double TiempoTraslado { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaTraslado { get; set; }
        public IPaqueteria Paqueteria { get; set;}
        public List<IObservadorExpresion> Expresiones { get; set; }

        public Pedido() { }
        public Pedido(string origen, string destino, double distancia, DateTime fechaPedido, IPaqueteria paqueteria)
        {
            Origen = origen;
            Destino = destino;
            Distancia = distancia;
            FechaPedido = fechaPedido;
            Paqueteria = paqueteria;
        }
    }
}
