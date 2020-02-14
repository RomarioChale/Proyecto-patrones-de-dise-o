namespace Proyecto.Entitidades
{
    public class Barco : ITransporte
    {
        public Barco() { }

        public double CostoKilometro { get { return 1; } }

        public double VelocidadEntrega { get { return 40; } }

        public string Nombre { get { return "Barco"; } }


    }
}
