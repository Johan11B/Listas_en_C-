using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class Nodo
    {
        public int Valor;
        public Nodo Siguiente;
        public Nodo Anterior;

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
            Anterior = null;
        }
    }

   
    class ListaDobleEnlazada
    {
        public Nodo Cabeza;
        public Nodo Cola;

        public void AgregarAlFinal(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (Cabeza == null)
            {
                Cabeza = Cola = nuevo;
            }
            else
            {
                Cola.Siguiente = nuevo;
                nuevo.Anterior = Cola;
                Cola = nuevo;
            }
        }

        public void ImprimirAdelante()
        {
            Nodo actual = Cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }

        public void ImprimirAtras()
        {
            Nodo actual = Cola;
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Anterior;
            }
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ListaDobleEnlazada lista = new ListaDobleEnlazada();
            lista.AgregarAlFinal(10);
            lista.AgregarAlFinal(20);
            lista.AgregarAlFinal(30);

            Console.WriteLine("Recorrido hacia adelante:");
            lista.ImprimirAdelante();

            Console.WriteLine("Recorrido hacia atrás:");
            lista.ImprimirAtras();

            Console.ReadLine();
        }
    }
}
