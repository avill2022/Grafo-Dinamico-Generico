using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Grafo_Generico
{
    class Nodo
    {
        private Point Pc;
        public Point pc { get { return Pc; } set { Pc = value; } }
        private string namecar;
        public string NAMECAR { get { return namecar; } set { namecar = value; } }
        private string nameint;
        public string NAMEINT { get { return nameint; } set { nameint = value; } }
        private List<Arista_generica> listaAristas;
        public List<Arista_generica> _listaAristas { get { return listaAristas; } set { listaAristas = value; } }

        public Nodo(int x,int y)
        {
            Pc = new Point(x, y);
            listaAristas = new List<Arista_generica>();
        }
        public Nodo(Point pos, List<Arista_generica> aristas)
        {
            listaAristas = aristas;
            Pc = pos;
        }
        public Point getPc()
        {
            return Pc;
        }
        public void ImprimeAristas(Graphics g)
        { 
            foreach(Arista_generica ari in this.listaAristas)
            {
                ari.imprimeArista(g);
            }
        }
    }
}
