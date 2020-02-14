using Proyecto.Entitidades.Paqueteria;

namespace Proyecto.Entitidades.Empresa
{
    public class Estafeta : IPaqueteria
    {
        //public ITransporte Transporte { get; set; }
        //public const double Utilidad = 20;
        public ITransporte Transporte { get; set; }

        public double Utilidad { get { return 20; } }

        public string Nombre { get; set; }
    }
}
