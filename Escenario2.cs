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
    public partial class Escenario2 : Escenario1
    {
        public Escenario2()
        {
            InitializeComponent();
            
        }

        protected override void CargarArbol()
        {
            Nodo nodo1 = new Nodo(26);
            Nodo nodo2 = new Nodo(20);
            Nodo nodo3 = new Nodo(17);
            Nodo nodo4 = new Nodo(25);
            Nodo nodo5 = new Nodo(24);
            Nodo nodo6 = new Nodo(31);
            Nodo nodo7 = new Nodo(28);
            Nodo nodo8 = new Nodo(55);
            Nodo nodo9 = new Nodo(37);
            arbol.InsertarNodo(nodo1);
            arbol.InsertarNodo(nodo2);
            arbol.InsertarNodo(nodo3);
            arbol.InsertarNodo(nodo4);
            arbol.InsertarNodo(nodo5);
            arbol.InsertarNodo(nodo6);
            arbol.InsertarNodo(nodo7);
            arbol.InsertarNodo(nodo8);
            arbol.InsertarNodo(nodo9);
        }

        protected override void gráficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        protected override void postordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cargamos el recorrido en la lista
            lblRecorrido.Visible = true;
            arbol.PostOrden(arbol.Raiz);
            Graphics nodo;
            nodo = CreateGraphics();
            Pen myNodoRaiz = new Pen(Color.DarkCyan, 3);
            Pen linea = new Pen(Color.Orange, 2);

            int space = 0; //Para cargar el espaciado en X con cada iteracion

            for (int i = 0; i < arbol.Recorrido.Count  ; i++)
            {
                DibujarNodo(nodo, myNodoRaiz, arbol.Recorrido[i].ToString(), 120 + space, 350);
                space += 40;
            }

            arbol.LimpiarRecorrido(); //Limpiamos la lista de recorrido
        }

        protected override void preordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cargamos el recorrido en la lista
            lblRecorrido.Visible = true;
            arbol.PreOrden(arbol.Raiz);
            Graphics nodo;
            nodo = CreateGraphics();
            Pen myNodoRaiz = new Pen(Color.DarkCyan, 3);
            Pen linea = new Pen(Color.Orange, 2);

            int space = 0; //Para cargar el espaciado en X con cada iteracion

            for (int i = 0; i < arbol.Recorrido.Count ; i++)
            {
                DibujarNodo(nodo, myNodoRaiz, arbol.Recorrido[i].ToString(), 120 + space, 350);
                space += 40;
            }

            arbol.LimpiarRecorrido(); //Limpiamos la lista de recorrido
        }

        protected override void inordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cargamos el recorrido en la lista
            lblRecorrido.Visible = true;
            arbol.Inorden(arbol.Raiz);
            Graphics nodo;
            nodo = CreateGraphics();
            Pen myNodoRaiz = new Pen(Color.DarkCyan, 3);
            Pen linea = new Pen(Color.Orange, 2);

            int space = 0; //Para cargar el espaciado en X con cada iteracion

            for (int i = 0; i < arbol.Recorrido.Count ; i++)
            {
                DibujarNodo(nodo, myNodoRaiz, arbol.Recorrido[i].ToString(), 120 + space, 350);
                space += 40;
            }

            arbol.LimpiarRecorrido(); //Limpiamos la lista de recorrido
        }

        protected override void gráficaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Graphics nodo;
            nodo = CreateGraphics();
            Pen myNodoRaiz = new Pen(Color.DarkCyan, 3);
            Pen linea = new Pen(Color.Orange, 2);

            //dibujar arbol a través de DibujarNodo Y DibujarLinea
            DibujarNodo(nodo, myNodoRaiz, "26", 440, 80);
            DibujarNodo(nodo, myNodoRaiz, "20", 320, 130);
            DibujarLinea(nodo, linea, 320, 130, 440, 80, true);
            DibujarNodo(nodo, myNodoRaiz, "28", 480, 200);
            DibujarLinea(nodo, linea, 480, 200, 560, 130, true);
            DibujarNodo(nodo, myNodoRaiz, "37", 580, 250);
            DibujarLinea(nodo, linea, 580, 250, 680, 180, true);
            DibujarNodo(nodo, myNodoRaiz, "31", 560, 130);
            DibujarLinea(nodo, linea, 560, 130, 320, 130, false);
            DibujarNodo(nodo, myNodoRaiz, "55", 680, 180);
            DibujarLinea(nodo, linea, 680, 180, 440, 180, false);
            DibujarNodo(nodo, myNodoRaiz, "25", 440, 180);
            DibujarLinea(nodo, linea, 440, 180, 200, 180, false);
            DibujarNodo(nodo, myNodoRaiz, "24", 350, 260);
            DibujarLinea(nodo, linea, 350, 260, 445, 185, true);
            DibujarNodo(nodo, myNodoRaiz, "17", 200, 180);
            DibujarLinea(nodo, linea, 200, 180, 320, 130, true);
        }
        }
}
