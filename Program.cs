using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fase4MaidyYarlediVega.Entities;

namespace Fase4MaidyYarlediVega
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Prueba de operaciones con arboles
            ArbolBinario arbolPrueba = new ArbolBinario();
            Nodo nodo1 = new Nodo();
            nodo1.Valor = 26;
            Nodo nodo2 = new Nodo();
            nodo2.Valor = 20;
            Nodo nodo3 = new Nodo();
            nodo3.Valor = 17;
            Nodo nodo4 = new Nodo();
            nodo4.Valor = 25;
            Nodo nodo5 = new Nodo();
            nodo5.Valor = 24;
            Nodo nodo6 = new Nodo();
            nodo6.Valor = 31;
            Nodo nodo7 = new Nodo();
            nodo7.Valor = 28;
            Nodo nodo8 = new Nodo();
            nodo8.Valor = 55;
            Nodo nodo9 = new Nodo();
            nodo9.Valor = 37;
            Nodo nodo10 = new Nodo();
            nodo10.Valor = 70;
            Nodo nodo11 = new Nodo();
            nodo11.Valor = 65;
            Nodo nodo12 = new Nodo();
            nodo12.Valor = 75;

            arbolPrueba.InsertarNodo(nodo1);
            arbolPrueba.InsertarNodo(nodo2);
            arbolPrueba.InsertarNodo(nodo3);
            arbolPrueba.InsertarNodo(nodo4);
            arbolPrueba.InsertarNodo(nodo5);
            arbolPrueba.InsertarNodo(nodo6);
            arbolPrueba.InsertarNodo(nodo7);
            arbolPrueba.InsertarNodo(nodo8);
            arbolPrueba.InsertarNodo(nodo9);
            //arbolPrueba.InsertarNodo(nodo10);
            //arbolPrueba.InsertarNodo(nodo11);
            //arbolPrueba.InsertarNodo(nodo12);


            arbolPrueba.Imprimir();


            //PostOrden
            arbolPrueba.PostOrden(arbolPrueba.Raiz);
            arbolPrueba.MostrarRecorrido();
            arbolPrueba.LimpiarRecorrido();

            Console.WriteLine(" ");

            //Inorden
            arbolPrueba.Inorden(arbolPrueba.Raiz);
            arbolPrueba.MostrarRecorrido();
            arbolPrueba.LimpiarRecorrido();

            Console.WriteLine(" ");

            //PreOrden
            arbolPrueba.PreOrden(arbolPrueba.Raiz);
            arbolPrueba.MostrarRecorrido();
            arbolPrueba.LimpiarRecorrido();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InicioUI());
        }
    }
}
