namespace Proyecto.Entitidades
{
    public interface ITransporte
    {
        double CostoKilometro { get;}
        double VelocidadEntrega { get;}
        string Nombre { get; }
    }
}
