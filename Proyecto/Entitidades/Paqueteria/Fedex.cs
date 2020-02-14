using Proyecto.Entitidades.Paqueteria;

namespace Proyecto.Entitidades.Empresa
{
    public class Fedex :IPaqueteria
    {
        //public ITransporte Transporte { get; set; }
        //public const double Utilidad = 50;

        public ITransporte Transporte { get { return new Barco(); }}

        public double Utilidad { get { return 50; } }

        public string Nombre { get; set; }
    }
}
