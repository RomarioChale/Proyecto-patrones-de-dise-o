using System.IO;

namespace Proyecto.Servicios.Utilidades
{
    public class LectorArchivo : ILectorArchivo
    {
        private readonly IBuscadorArchivo _buscadorArchivo;
        public LectorArchivo(IBuscadorArchivo buscarArchivo)
        {
            _buscadorArchivo = buscarArchivo;
        }
        public string[] LeerArchivo(string nombreArchivo)
        {
            try
            {
                string ruta = _buscadorArchivo.BuscarArchivo(nombreArchivo);
                string[] lines = File.ReadAllLines(ruta);
                return lines;
            }
            catch (NotFoundException)
            {
                throw new NotFoundException("Ocurrió un error con el archivo");
            }
        }
    }
}
