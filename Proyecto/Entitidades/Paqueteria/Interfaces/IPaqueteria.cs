namespace Proyecto.Entitidades.Paqueteria
{
    public interface IPaqueteria
    { 
      ITransporte Transporte { get;}
      double Utilidad { get; }

      string Nombre { get; set; }

    }
}
