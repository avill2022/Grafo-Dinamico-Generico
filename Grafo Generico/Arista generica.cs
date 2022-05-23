using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Grafo_Generico
{
    class Arista_generica
    {
        Pen pluma;
        float CatOx1, CatAy1;
        float CatOx2, CatAy2;


        private Nodo Nodo_Origen;
        public Nodo _Nodo_Origen { get { return Nodo_Origen; } set { Nodo_Origen = value; } } 
        private Nodo Nodo_Destino;
        public Nodo _Nodo_Destino { get { return Nodo_Destino; } set { Nodo_Destino = value;} }
        public int peso;
        public Point PuntoMedio;

        public Arista_generica() 
        {
            pluma = new Pen(Color.Red);
            AdjustableArrowCap acc = new AdjustableArrowCap(5, 5, true);
            pluma.CustomEndCap = acc;
        }
        public void calculaPuntoMedio()
        {
            PuntoMedio = new Point((Nodo_Origen.pc.X + Nodo_Destino.pc.X) / 2, (Nodo_Origen.pc.Y + Nodo_Destino.pc.Y) / 2);
        }
        public void calculaPeso()
        {
            if (Nodo_Origen == Nodo_Destino)
            {
                peso = 0;
            }
            else
            {
                peso = (int)Math.Sqrt(Math.Pow(Nodo_Destino.pc.X - Nodo_Origen.pc.X, 2) + Math.Pow(Nodo_Destino.pc.Y - Nodo_Origen.pc.Y, 2));
            }
        }


        public void Calcula_Flecha()
        {
            double teta1 = Math.Atan2(Nodo_Destino.pc.Y - Nodo_Origen.pc.Y, Nodo_Destino.pc.X - Nodo_Origen.pc.X);
            CatOx1 = Nodo_Origen.pc.X + (float)((Math.Cos(teta1)) * (30 / 2));
            CatAy1 = Nodo_Origen.pc.Y + (float)((Math.Sin(teta1)) * (30 / 2));

            double teta2 = Math.Atan2(Nodo_Origen.pc.Y - Nodo_Destino.pc.Y, Nodo_Origen.pc.X - Nodo_Destino.pc.X);
            CatOx2 =Nodo_Destino.pc.X + (float)((Math.Cos(teta2)) * (30 / 2));
            CatAy2 = Nodo_Destino.pc.Y + (float)((Math.Sin(teta2)) * (30 / 2));
        }
        public  void imprimeArista(Graphics g)
        {
            Calcula_Flecha();
            calculaPuntoMedio();
            calculaPeso();


            if (Nodo_Destino == Nodo_Origen)
            {
                g.DrawBezier(pluma, CatOx1-10, CatAy1-15, CatOx1 + 25, CatAy1 - 60, CatOx1 - 50, CatAy1 - 50, CatOx2-25, CatAy2-10);
                //DrawCurvePoint(g, this.Vertice_Origen.pc.X, this.Vertice_Destino.pc.Y);
                g.DrawString(this.peso.ToString(), new Font("Arial", 10), new SolidBrush(Color.Red), this.Nodo_Destino.pc.X - 7, this.Nodo_Destino.pc.Y - 50);
            }
            else
            {
                g.DrawLine(pluma, CatOx1, CatAy1, CatOx2, CatAy2);
                g.DrawString(this.peso.ToString(), new Font("Arial", 10), new SolidBrush(Color.Red), this.PuntoMedio);
            }
        }
        private void DrawCurvePoint(Graphics g, int x, int y)
        {
            // Create points that define curve.
            Point point1 = new Point(x - 10, y - 10);
            Point point2 = new Point(x - 15, y - 23);
            Point point3 = new Point(x, y - 40);
            Point point4 = new Point(x + 15, y - 23);
            Point point5 = new Point(x + 10, y - 10);


            Point[] curvePoints = { point1, point2, point3, point4, point5 };

            // Draw lines between original points to screen.
            //g.DrawLines(redPen, curvePoints);

            // Draw curve to screen.
            g.DrawCurve(pluma, curvePoints);
        }

    }
}
