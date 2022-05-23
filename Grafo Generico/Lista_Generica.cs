using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Grafo_Generico
{
    class Lista_Generica
    {
        protected List<Nodo> nodos;

        public Lista_Generica()
        {
            nodos = new List<Nodo>();
        }
        public virtual void AgregaNodo(Nodo _Nodo)
        {
            nodos.Add(_Nodo);
        }
        public virtual List<Nodo> getLista()
        {
            return nodos;
        }

        public virtual void setName() { }

        public virtual void imprime(Graphics g)
        {
            foreach (Nodo n in nodos)
            {
                g.FillEllipse(Brushes.Yellow, n.getPc().X - 15, n.getPc().Y - 15, 30, 30);
                g.DrawEllipse(Pens.Red, n.getPc().X - 15, n.getPc().Y - 15, 30, 30);
                
            }
        }
    }
}
