using System;

class Nodo
{
    public int Dato;          // Valor que guarda el nodo
    public Nodo Siguiente;    // Referencia al siguiente nodo

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaCircular
{
    private Nodo ultimo;  // Referencia al último nodo de la lista

    public ListaCircular()
    {
        ultimo = null;
    }

    // Método para agregar un nodo a la lista
    public void Agregar(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato);

        if (ultimo == null)
        {
            // Si la lista está vacía
            ultimo = nuevoNodo;
            ultimo.Siguiente = ultimo; // Apunta a sí mismo
        }
        else
        {
            // Si ya hay nodos
            nuevoNodo.Siguiente = ultimo.Siguiente; // El nuevo apunta al primero
            ultimo.Siguiente = nuevoNodo;           // El último apunta al nuevo
            ultimo = nuevoNodo;                     // Actualizamos el último
        }
    }

    // Método para mostrar los elementos de la lista
    public void Mostrar()
    {
        if (ultimo == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo actual = ultimo.Siguiente;  // Empezamos desde el primero

        do
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        while (actual != ultimo.Siguiente); // Cuando vuelve al inicio, paramos

        Console.WriteLine("(vuelve al inicio)");
    }
}

class Program
{
    static void Main()
    {
        ListaCircular lista = new ListaCircular();

        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);

        lista.Mostrar();

        Console.ReadLine();  // Para mantener la ventana abierta
    }
}