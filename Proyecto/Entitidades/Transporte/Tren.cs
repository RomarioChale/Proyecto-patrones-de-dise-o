namespace Proyecto.Entitidades
{
    public class Tren : ITransporte
    {
        public Tren() { }

        public double CostoKilometro { get { return 5; } }

        public double VelocidadEntrega { get { return 80; } }

        public string Nombre { get { return "Tren"; } }
 
    }
}
