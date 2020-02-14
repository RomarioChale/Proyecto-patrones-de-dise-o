using Proyecto.Servicios.Utilidades.Expresiones.ObservadorEvento.Interfaces;
using Proyecto.Servicios.Utilidades.Expresiones.ObservadorExpresion.Utilidades;
using System.Collections.Generic;

namespace Proyecto.Servicios.Utilidades.Expresiones.ObservadorEvento
{
    public class ExpresionesObservador
    {
        private readonly List<IObservadorExpresion> _observadores = new List<IObservadorExpresion>();
        private readonly List<TipoExpresiones> _expresiones = new List<TipoExpresiones>();

        public void AgregarObservador(IObservadorExpresion observador)
        {
            _observadores.Add(observador);
            NotificarObservadores();
        }

        public List<TipoExpresiones> GetExpresiones()
        {
            return _expresiones;
        }

        public void EliminarObservador(IObservadorExpresion observador)
        {
            _observadores.Remove(observador);

        }
        public void NotificarObservadores()
        {
            foreach (IObservadorExpresion obj in _observadores)
            {
                TipoExpresiones expresion = obj.AsignarExpresion();
                _expresiones.Add(expresion);
            }
        }
    }
}
