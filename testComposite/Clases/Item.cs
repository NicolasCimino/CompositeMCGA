using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testComposite.Clases
{
    public class Item : Componente
    {
        private float precio;
        public float Precio { get{ return precio; } }
        public Item(string n, float p) : base(n)
        {
            this.precio = p;
        }

        public override void AgregarHijo(Componente c)
        {
      
        }



        public override void QuitarHijo(Componente c)
        {
           
        }

        public override IList<Componente> Mostrar()
        {
            return null;
        }

        public override float CalcularTotal()
        {
            return Precio;
        }
    }
}
