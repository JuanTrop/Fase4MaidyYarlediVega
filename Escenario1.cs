using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fase4MaidyYarlediVega.Entities;

namespace Fase4MaidyYarlediVega
{
    public partial class Escenario1 : Form
    {
       protected ArbolBinario arbol = new ArbolBinario();

        public Escenario1()
        {
            InitializeComponent();
            //Inicializamos el arbol
            CargarArbol();
        }
        protected virtual void CargarArbol()
        {
            Nodo nodo1 = new Nodo(50);
            Nodo nodo2 = new Nodo(40);
            Nodo nodo3 = new Nodo(30);
            Nodo nodo4 = new Nodo(25);
            Nodo nodo5 = new Nodo(35);
            Nodo nodo6 = new Nodo(45);
            Nodo nodo7 = new Nodo(42);
            Nodo nodo8 = new Nodo(60);
            Nodo nodo9 = new Nodo(55);
            Nodo nodo10 = new Nodo(65);
            Nodo nodo11 = new Nodo(75);
            Nodo nodo12 = new Nodo(70);
            arbol.InsertarNodo(nodo1);
            arbol.InsertarNodo(nodo2);
            arbol.InsertarNodo(nodo3);
            arbol.InsertarNodo(nodo4);
            arbol.InsertarNodo(nodo5);
            arbol.InsertarNodo(nodo6);
            arbol.InsertarNodo(nodo7);
            arbol.InsertarNodo(nodo8);
            arbol.InsertarNodo(nodo9);
            arbol.InsertarNodo(nodo10);
            arbol.InsertarNodo(nodo11);
            arbol.InsertarNodo(nodo12);
        }

        protected void DibujarNodo(Graphics nodo, Pen myNodoRaiz, string value, int x, int y)
        {
            nodo.FillEllipse(Brushes.Cyan, x, y, 35, 35);
            nodo.DrawString(value, Font, Brushes.Purple, x + 10, y + 10);
            nodo.DrawEllipse(myNodoRaiz, x, y, 35, 35);

        }

        protected void DibujarLinea(Graphics nodo, Pen linea, int x1, int y1, int x2, int y2, Boolean izquierda)
        {
            if (izquierda)
            {
                nodo.DrawLine(linea, x1 + 35, y1 + 10, x2, y2 + 25);
            } else
            {
                nodo.DrawLine(linea, x1, y1 + 15 , x2 + 155, y2 - 30);
            }
        }

        protected virtual void gráficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Escenario1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void Escenario1_Load(object sender, EventArgs e)
        {

        }

        protected virtual void inordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void preordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        protected virtual void postordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        protected virtual void gráficaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Instancia elipses, lineas y relleno
            Graphics nodo;
            nodo = CreateGraphics();
            Pen myNodoRaiz = new Pen(Color.Orange, 3);
            Pen linea = new Pen(Color.Orange, 2);

            //dibujar arbol a través de DibujarNodo Y DibujarLinea
            DibujarNodo(nodo, myNodoRaiz, "50", 440, 80);
            DibujarNodo(nodo, myNodoRaiz, "40", 320, 130);
            DibujarLinea(nodo, linea, 320, 130, 440, 80, true);
            DibujarNodo(nodo, myNodoRaiz, "55", 480, 200);
            DibujarLinea(nodo, linea, 480, 200, 560, 130, true);
            DibujarNodo(nodo, myNodoRaiz, "65", 580, 250);
            DibujarLinea(nodo, linea, 580, 250, 680, 180, true);
            DibujarNodo(nodo, myNodoRaiz, "60", 560, 130);
            DibujarLinea(nodo, linea, 560, 130, 320, 130, false);
            DibujarNodo(nodo, myNodoRaiz, "70", 680, 180);
            DibujarLinea(nodo, linea, 680, 180, 440, 180, false);
            DibujarNodo(nodo, myNodoRaiz, "75", 800, 230);
            DibujarLinea(nodo, linea, 800, 230, 560, 230, false);
            DibujarNodo(nodo, myNodoRaiz, "45", 440, 180);
            DibujarLinea(nodo, linea, 440, 180, 200, 180, false);
            DibujarNodo(nodo, myNodoRaiz, "42", 350, 260);
            DibujarLinea(nodo, linea, 350, 260, 445, 185, true);
            DibujarNodo(nodo, myNodoRaiz, "30", 200, 180);
            DibujarLinea(nodo, linea, 200, 180, 320, 130, true);
            DibujarNodo(nodo, myNodoRaiz, "25", 80, 230);
            DibujarLinea(nodo, linea, 80, 230, 200, 180, true);
            DibujarNodo(nodo, myNodoRaiz, "35", 320, 230);
            DibujarLinea(nodo, linea, 320, 230, 80, 230, false);
        }

        private void inordenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Cargamos el recorrido en la lista
            lblRecorrido.Visible = true;
            lblRecorrido.Text = "Recorrido Inorden: ";
            arbol.Inorden(arbol.Raiz);
            Graphics nodo;
            nodo = CreateGraphics();
            Pen myNodoRaiz = new Pen(Color.Orange, 3);
            Pen linea = new Pen(Color.Orange, 2);

            int space = 0; //Para cargar el espaciado en X con cada iteracion

            for (int i = 0; i < arbol.Recorrido.Count; i++)
            {
                DibujarNodo(nodo, myNodoRaiz, arbol.Recorrido[i].ToString(), 120 + space, 350);
                space += 40;
            }

            arbol.LimpiarRecorrido(); //Limpiamos la lista de recorrido
        }

        private void preordenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Cargamos el recorrido en la lista
            lblRecorrido.Visible = true;
            lblRecorrido.Text = "Recorrido Preorden: ";
            arbol.PreOrden(arbol.Raiz);
            Graphics nodo;
            nodo = CreateGraphics();
            Pen myNodoRaiz = new Pen(Color.Orange, 3);
            Pen linea = new Pen(Color.Orange, 2);

            int space = 0; //Para cargar el espaciado en X con cada iteracion

            for (int i = 0; i < arbol.Recorrido.Count; i++)
            {
                DibujarNodo(nodo, myNodoRaiz, arbol.Recorrido[i].ToString(), 120 + space, 350);
                space += 40;
            }

            arbol.LimpiarRecorrido(); //Limpiamos la lista de recorrido
        }

        private void postordenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Cargamos el recorrido en la lista
            lblRecorrido.Visible = true;
            lblRecorrido.Text = "Recorrido PostOrden: ";
            arbol.PostOrden(arbol.Raiz);
            Graphics nodo;
            nodo = CreateGraphics();
            Pen myNodoRaiz = new Pen(Color.Orange, 3);
            Pen linea = new Pen(Color.Orange, 2);

            int space = 0; //Para cargar el espaciado en X con cada iteracion

            for (int i = 0; i < arbol.Recorrido.Count; i++)
            {
                DibujarNodo(nodo, myNodoRaiz, arbol.Recorrido[i].ToString(), 120 + space, 350);
                space += 40;
            }

            arbol.LimpiarRecorrido(); //Limpiamos la lista de recorrido
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
