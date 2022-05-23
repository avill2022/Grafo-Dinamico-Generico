using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Grafo_Generico
{
    class Lista_No_Dirigida : Lista_Generica
    {
        int num;
        Font font;

        public Lista_No_Dirigida(Lista_Generica lGen)
        { 
            num = 1;
            font = new Font("Arial",10);
            nodos = new List<Nodo>();

            foreach (Nodo n in lGen.getLista())
            {
                nodos.Add(new Nodo(n.getPc(),n._listaAristas));
            }

        }
        public override void AgregaNodo(Nodo _Nodo)
        {
            this.nodos.Add(_Nodo);
        }
        public override void setName()
        {
            foreach (Nodo n in nodos)
            {
                n.NAMEINT = num.ToString();
                num++;
            }
        }
        public override void imprime(Graphics g)
        {
            
            foreach (Nodo n in nodos)
            {
                g.FillEllipse(Brushes.Yellow, n.getPc().X - 15, n.getPc().Y - 15, 30, 30);
                g.DrawEllipse(Pens.Red, n.getPc().X - 15, n.getPc().Y - 15, 30, 30);
                g.DrawString(n.NAMEINT.ToString(), font, Brushes.Red, n.getPc().X - 5, n.getPc().Y - 5);
               
                foreach (Arista_generica a in n._listaAristas)
                {
                    n.ImprimeAristas(g);
                }
            }
        }

    }
}
