namespace Proyecto.Entitidades
{
    public class Avion : ITransporte
    {
        public Avion() { }

        public double CostoKilometro { get { return 10; } }
        public double VelocidadEntrega { get { return 600; } }
        public string Nombre { get { return "Tren"; } } 


    }
}
