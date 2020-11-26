using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4MaidyYarlediVega
{
    public partial class Escenario1 : Form
    {
        public Escenario1()
        {
            InitializeComponent();
        }
        private void dibujarNodo(Graphics nodo, Pen myNodoRaiz, string value, int x, int y)
        {
            nodo.FillEllipse(Brushes.Cyan, x, y, 35, 35);
            nodo.DrawString(value, Font, Brushes.Purple, x + 10, y + 10);
            nodo.DrawEllipse(myNodoRaiz, x, y, 35, 35);

        }

        private void dibujarLinea(Graphics nodo, Pen linea, int x1, int y1, int x2, int y2, Boolean izquierda)
        {
            if (izquierda)
            {
                nodo.DrawLine(linea, x1 + 35, y1 + 10, x2, y2 + 25);
            } else
            {
                nodo.DrawLine(linea, x1 - 35, y1 - 10, x2, y2 - 25);
            }
        }

        private void gráficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instancia elipses, lineas y relleno
            Graphics nodo;
            nodo = CreateGraphics();
            Pen myNodoRaiz = new Pen(Color.Orange, 3);
            Pen linea = new Pen(Color.Orange, 2);

            //dibujar arbol a través de dibujarNodo
            //dibujando nodos izquierdos
            dibujarNodo(nodo, myNodoRaiz, "50", 320, 30);
            dibujarNodo(nodo, myNodoRaiz, "40",200, 80);
            dibujarLinea(nodo, linea, 200, 80, 320, 30, true);
            dibujarNodo(nodo, myNodoRaiz, "30", 80, 130);
            dibujarLinea(nodo, linea, 80, 130, 200, 80, true);
        }
    }
}
