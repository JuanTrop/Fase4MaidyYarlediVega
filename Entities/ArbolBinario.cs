using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase4MaidyYarlediVega.Entities
{
    public class ArbolBinario
    {
        private Nodo raiz;
        private List<int> recorrido = new List<int>();

        internal Nodo Raiz { get => raiz; set => raiz = value; }
        public List<int> Recorrido { get => recorrido; set => recorrido = value; }

        //Insertar Nodo
        public void InsertarNodo(Nodo nodo) { 

            if(raiz == null)
            {
                raiz = nodo;
            }
            else
            {
                Nodo anterior = null,auxiliar = raiz;
                while(auxiliar != null)
                {
                    if(auxiliar.Valor > nodo.Valor)
                    {
                        anterior = auxiliar;
                        auxiliar = auxiliar.Izquierdo;
                    } else if (auxiliar.Valor < nodo.Valor)
                    {
                        anterior = auxiliar;
                        auxiliar = auxiliar.Derecho;
                    } else
                    {
                        Console.WriteLine("Ya existe en el arbol");
                        break;
                    }
                }
                if(anterior.Valor < nodo.Valor)
                {
                    anterior.Derecho = nodo;
                } else if(anterior.Valor > nodo.Valor)
                {
                    anterior.Izquierdo = nodo;
                } else
                {
                    Console.WriteLine("No se pudo insertar");
                }
            }
        }
        
        //Recorrido PostOrden
        public void PostOrden(Nodo nodo)
        {
            
            if (nodo != null)
            {
                
                PostOrden(nodo.Izquierdo);
                PostOrden(nodo.Derecho);
                recorrido.Add(nodo.Valor);
            }
        }

        //Recorrido Inorden
        public void Inorden(Nodo nodo)
        {
            if (nodo != null)
            {

                Inorden(nodo.Izquierdo);
                recorrido.Add(nodo.Valor);
                Inorden(nodo.Derecho);
                
            }
        }

        //Recorrido PreOrden
        public void PreOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                recorrido.Add(nodo.Valor);
                PreOrden(nodo.Izquierdo);
                PreOrden(nodo.Derecho);

            }
        }

        //Devuelve la información sobre el arbol en formato String
        public string String()
        {
            if (raiz != null)
            {
                return this.raiz.GetString(this.raiz);
            } else
            {
                return "Arbol vacío";
            }
        }

        //Imprime en consola la información del árbol
        public void Imprimir()
        {
            Console.WriteLine(this.String());
        }

        //Limpia la lista de recorridos
        public void LimpiarRecorrido()
        {
            recorrido.Clear();
        }

        public void MostrarRecorrido()
        {
            for(int i = 0; i < recorrido.Count; i++)
            {
                Console.WriteLine(recorrido[i]);
            }
        }

    }


}
