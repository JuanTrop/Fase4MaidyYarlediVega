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
                nodo.DrawLine(linea, x1, y1 + 15 , x2 + 155, y2 - 30);
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
            dibujarNodo(nodo, myNodoRaiz, "50", 440, 80);
            dibujarNodo(nodo, myNodoRaiz, "40",320, 130);
            dibujarLinea(nodo, linea, 320, 130, 440, 80, true);
            dibujarNodo(nodo, myNodoRaiz, "55", 480, 200);
            dibujarLinea(nodo, linea, 480, 200, 560, 130, true);
            dibujarNodo(nodo, myNodoRaiz, "65", 580, 250);
            dibujarLinea(nodo, linea, 580, 250, 680, 180, true);
            //derechos
            dibujarNodo(nodo, myNodoRaiz, "60", 560, 130);
            dibujarLinea(nodo, linea, 560, 130, 320, 130, false);
            dibujarNodo(nodo, myNodoRaiz, "70", 680, 180);
            dibujarLinea(nodo, linea, 680, 180, 440, 180, false);
            dibujarNodo(nodo, myNodoRaiz, "75", 800, 230);
            dibujarLinea(nodo, linea, 800, 230, 560, 230, false);
            dibujarNodo(nodo, myNodoRaiz, "45", 440, 180);
            dibujarLinea(nodo, linea, 440, 180, 200, 180, false);

            dibujarNodo(nodo, myNodoRaiz, "42", 350, 260);
            dibujarLinea(nodo, linea, 350, 260, 445, 185, true);

            dibujarNodo(nodo, myNodoRaiz, "30", 200, 180);
            dibujarLinea(nodo, linea, 200, 180, 320, 130, true);

            dibujarNodo(nodo, myNodoRaiz, "25", 80, 230);
            dibujarLinea(nodo, linea, 80, 230, 200, 180, true);

            dibujarNodo(nodo, myNodoRaiz, "35", 320, 230);
            dibujarLinea(nodo, linea, 320, 230, 80, 230, false);
        }

        private void Escenario1_MouseClick(object sender, MouseEventArgs e)
        {
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
        }
    }
}
