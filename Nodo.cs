using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class Nodo
    {
        public int Dato { get; set; }
        public Nodo izq { get; set; }
        public Nodo der { get; set; }

        public void Agregar(int dato)
        {
            if(dato <Dato) 
            {
                if (izq ==null)
                {
                    izq = new() { Dato = dato };
                }
                else
                {
                    izq.Agregar(dato);
                }
            }
            else if(der==null) 
            {
                der= new() { Dato = dato };
            }
            else { der.Agregar(dato);}
        }
        public void inorden()
        {
            if (izq !=null)
            {
                izq.inorden();
            }
            Console.WriteLine(Dato);
            if (der!=null)
            {
                der.inorden();
            }
        }

    }
}
