using Proyecto.Entitidades;
using Proyecto.Servicios;
using Proyecto.Servicios.Utilidades;
using Proyecto.Servicios.Utilidades.Calculos;
using System.Collections.Generic;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            BuscadorArchivo buscadorArchivo = new BuscadorArchivo();
            LectorArchivo lectorArchivo = new LectorArchivo(buscadorArchivo);
            VerificadorPaqueteria verificadorPaqueteria = new VerificadorPaqueteria();
            ConvertidorTxtObjeto convertidorTxtObjeto = new ConvertidorTxtObjeto(lectorArchivo, verificadorPaqueteria);
            List<Pedido> pedidos = convertidorTxtObjeto.AsignarDatosDeArchivos("");
            CalculadorCostoEnvio calculadorCostoEnvio = new CalculadorCostoEnvio();
            calculadorCostoEnvio.CalcularCostoEnvio(pedidos);
        }
    }
}
