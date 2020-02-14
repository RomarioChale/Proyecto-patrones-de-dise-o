using System.IO;

namespace Proyecto.Servicios.Utilidades
{
    public class BuscadorArchivo : IBuscadorArchivo
    {
        public string BuscarArchivo(string nombreArchivo)
        {
            string archivo;

            if (string.IsNullOrWhiteSpace(nombreArchivo))
            {
                archivo = Path.GetFullPath("Pedidos" + ".txt");
            }
            else
            {
                archivo = Path.GetFullPath(nombreArchivo + ".txt");
            }

            return archivo;
        }
    }
}
