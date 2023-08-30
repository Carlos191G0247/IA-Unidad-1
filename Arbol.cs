using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class Arbol
    {
        public Nodo Raiz { get; private set; } = null;

        public void Agregar(int dato)
        {
            if (Raiz==null)
            {
                Raiz = new() { Dato = dato };
            }
            else
            {
                Raiz.Agregar(dato);
            }
        }
    }
}
