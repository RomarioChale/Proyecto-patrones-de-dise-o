using Proyecto.Entitidades.Paqueteria;

namespace Proyecto.Entitidades.Empresa
{
    public class DHL : IPaqueteria
    {
        //public ITransporte Transporte { get;}
        //public const double Utilidad = 40;
        //public ITransporte Transporte { get; }

        public double Utilidad { get { return 40; } }

        public ITransporte Transporte { get; set; }
        public string Nombre { get; set; }
    }
}
