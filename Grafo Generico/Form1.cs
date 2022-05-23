using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Grafo_Generico
{
    public partial class Form1 : Form
    {
        Lista_Generica l_Nodos;
        Arista_generica arista;
        Graphics g;
        Point p1,p2;
        Bitmap bmp1;

        int herramienta;
        int numeroNodo;
        int inodo;

        private Bitmap bmp; //Para poner una imagen de fondo y paginar
        private Graphics pagina; //Para dibujar cualquier grafico en pantalla

        public Form1()
        {
            InitializeComponent();
            l_Nodos = new Lista_Generica();
            herramienta = 0;
            numeroNodo = 0;


            bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            pagina = Graphics.FromImage(bmp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            l_Nodos.imprime(g);
            p1 = new Point();
            p2 = new Point();
            bmp1 = new Bitmap(ClientSize.Width, ClientSize.Height);
            inodo = 0;  
        }

        private void Lista_Dirigida_Click(object sender, EventArgs e)
        {
            l_Nodos = new Lista_Dirigida(l_Nodos);
            ListaNoDirigida.Enabled = false;
            l_Nodos.setName();
            Form1_Paint(null, null);
        }

        private void ListaNoDirigida_Click(object sender, EventArgs e)
        {
            l_Nodos = new Lista_No_Dirigida(l_Nodos);
            ListaDirigida.Enabled = false;
            l_Nodos.setName();
            Form1_Paint(null, null);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pagina.SmoothingMode = SmoothingMode.AntiAlias;
            pagina.Clear(this.BackColor);
            l_Nodos.imprime(pagina);
            g.DrawImage(bmp, 0, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (herramienta)
            { 
                case 1:
                    
                  inodo = 1; l_Nodos.AgregaNodo(new Nodo(e.X, e.Y));                   
                    
                break;
                case 2:
                    foreach (Nodo n in l_Nodos.getLista())
                    {

                        if (e.X < n.getPc().X + 10 && e.X > n.getPc().X - 10 && e.Y < n.getPc().Y + 10 && e.Y > n.getPc().Y - 10)
                        {
                            herramienta = 11;
                        }

                        if (herramienta == 2) { numeroNodo++; }
                        
                    }
                break;
                case 3:
                break;
                case 4:
                    foreach (Nodo n in l_Nodos.getLista())
                    {
                        if (e.X < n.getPc().X + 10 && e.X > n.getPc().X - 10 && e.Y < n.getPc().Y + 10 && e.Y > n.getPc().Y - 10)
                        {
                            herramienta = 10;
                        }
                        if (herramienta == 4) { numeroNodo++;}
                    }
                break;
            } 
            p1 = e.Location;
            Form1_Paint(null, null);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //p2 = e.Location;
            if (herramienta == 10) { herramienta = 4; }
            

            switch (herramienta)
            {
                case 11:
                    foreach (Nodo n in l_Nodos.getLista())
                    {
                        if (e.X < n.getPc().X + 10 && e.X > n.getPc().X - 10 && e.Y < n.getPc().Y + 10 && e.Y > n.getPc().Y - 10)
                        {
                            //if (n != l_Nodos.getLista()[numeroNodo])
                            //{
                                arista = new Arista_generica();
                                arista._Nodo_Origen = l_Nodos.getLista()[numeroNodo];
                                arista._Nodo_Destino = n;
                                n._listaAristas.Add(arista);
                           // }
                           
                        }
                        //herramienta = 0;
                        Form1_Paint(null, null);
                    }
                    break;
            }
             numeroNodo = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                p2 = e.Location;
                if (herramienta == 10)
                {
                    l_Nodos.getLista()[numeroNodo].pc=e.Location;
                }
                Form1_Paint(null, null);
            }
        }

        private void Nodo_Click(object sender, EventArgs e)
        {
            herramienta = 1;
        }

        private void Arista_Generica_Click(object sender, EventArgs e)
        {
            herramienta = 2;  
        }

        private void Mueve_Nodo_Click(object sender, EventArgs e)
        {
            herramienta = 4;
        }
    }
}
