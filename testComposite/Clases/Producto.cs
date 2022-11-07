using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testComposite.Clases
{
    public class Producto : Componente
    {
        private IList<Componente> componenteList;

        public Producto(string nombre) : base(nombre)
        {
            componenteList = new List<Componente>();
        }

        public override void AgregarHijo(Componente c)
        {
            this.componenteList.Add(c); 
        }

        public override float CalcularTotal()
        {
            float total = 0;
            foreach (Componente c in componenteList)
            {
                total += c.CalcularTotal();
            }
            return total;
        }

        public override IList<Componente> Mostrar()
        {
            return componenteList.ToArray();
        }

        public override void QuitarHijo(Componente c)
        {
            this.componenteList.Remove(c);
        }
    }
}
