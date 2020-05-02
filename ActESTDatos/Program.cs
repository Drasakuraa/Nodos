using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActESTDatos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

      namespace LSE
         {
       
        public class Nodo
        {
            public Object dato; 
            public Nodo siguiente; 
            public Nodo comienzo; 

            public void InsertarComienzo(Object dato)
            {
                Nodo Añadir = new Nodo();

                Añadir.dato = dato;
                Añadir.siguiente = comienzo;
                comienzo = Añadir;
            }

            public void InsertarFinal(Object dato)
            {
                if (comienzo == null)
                {
                    comienzo = new Nodo();

                    comienzo.dato = dato;
                    comienzo.siguiente = null;
                }
                else
                {
                    Nodo añadir = new Nodo();
                    añadir.dato = dato;

                    Nodo actual = comienzo;
                    while (actual.siguiente != null)
                    {
                        actual = actual.siguiente;
                    }

                    actual.siguiente = añadir;
                }
            }

        }
        
        public class ListaEnlazada
        {
            private Nodo comienzo;

            public void imprimeTodosLosNodos()
            {
                Nodo actual = comienzo;
                while (actual != null)
                {
                    Console.WriteLine(actual.dato);
                    actual = actual.siguiente;
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Añade al inicio:");
                ListaEnlazada miLista1 = new ListaEnlazada();
                Nodo miNodo1 = new Nodo();


                miNodo1.InsertarComienzo("Hola");
                miNodo1.InsertarComienzo("Mundo");
                miNodo1.InsertarComienzo("Dato3");
                miLista1.imprimeTodosLosNodos();

                Console.WriteLine();

                Console.WriteLine("Añade al final:");
                ListaEnlazada miLista2 = new ListaEnlazada();
                Nodo miNodo2 = new Nodo();

                miNodo2.InsertarFinal("Hola");
                miNodo2.InsertarFinal("Mundo");
                miNodo2.InsertarFinal("Dato3");
                miLista1.imprimeTodosLosNodos();

                Console.ReadLine();

            }
        }
    }
}
