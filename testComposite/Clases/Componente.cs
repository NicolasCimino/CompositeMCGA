using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testComposite.Clases
{
    public abstract class Componente
    {
        private string nombre;

        public Componente(string n) { this.nombre = n; }
        public string Nombre { get { return nombre; } }

        public abstract void AgregarHijo(Componente c);
        public abstract void QuitarHijo(Componente c);
        public abstract IList<Componente> Mostrar();
        public abstract float CalcularTotal();

    }
}
