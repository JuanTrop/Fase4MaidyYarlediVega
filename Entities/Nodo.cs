using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase4MaidyYarlediVega.Entities
{
    class Nodo
    {
        private Nodo izquierdo;
        private Nodo derecho;
        private int valor;

        public int Valor { get => valor; set => valor = value; }
        internal Nodo Izquierdo { get => izquierdo; set => izquierdo = value; }
        internal Nodo Derecho { get => derecho; set => derecho = value; }

       public string GetString(Nodo nodo)
        {
            if(nodo != null)
            {
                string text = " Nodo: \n";
                text += "Valor: " + nodo.Valor + "\n";
                text += "Izquierdo: " + GetString(nodo.Izquierdo);
                text += "Derecho: "+ GetString(nodo.Derecho);

                return text;
            } else
            {
                return "Nodo vacío \n";
            }
        }

    }
}
