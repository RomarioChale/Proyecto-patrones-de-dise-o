﻿using Proyecto.Entitidades;
using Proyecto.Entitidades.Empresa;
using Proyecto.Entitidades.Paqueteria;
using Proyecto.Servicios.BuilderPedido.Interfaces;
using System;

namespace Proyecto.Servicios.BuilderPedido
{
    public class PedidoFedex : PedidoBuilder
    {
        private readonly IPaqueteria paqueteria = new Fedex();

        public override IPaqueteria GetPaqueteria()
        {
            return paqueteria;
        }

        public override void AddDestino(string destino)
        {
            _pedido.Destino = destino;
        }

        public override void AddDistancia(double distancia)
        {
            _pedido.Distancia = distancia;

        }

        public override void AddFechaPedido(DateTime fechaPedido)
        {
            _pedido.FechaPedido = fechaPedido;

        }

        public override void AddOrigen(string origen)
        {
            _pedido.Origen = origen;

        }

        public override bool AddTransporte(ITransporte transporte)
        {
            bool respuesta = true;
            if (!(transporte is Barco))
            {
                respuesta = false;
            }

            return respuesta;
        }
    }
}
