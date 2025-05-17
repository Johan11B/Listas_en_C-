using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_simple_enlazada
{
    // Clase que representa un nodo de la lista enlazada
    class Nodo
    {
        public string Nombre;      
        public Nodo siguiente = null; // Referencia al siguiente nodo en la lista; null indica que es el último nodo
    }
    // Clase que representa la lista enlazada simple y contiene métodos para manipularla
    class Lista   
    {
        public Nodo cabeza = null; // Nodo inicial de la lista (primer nodo)
        private int longitud = 0; // Contador privado que guarda la cantidad de nodos en la lista

        //-------Metodo para agregar al principio--------

        public void AgregarInicio (String nombre)
        {
            Nodo nuevoNodo = new Nodo();       
            nuevoNodo.Nombre = nombre;         
            nuevoNodo.siguiente = cabeza;      // Apuntar el nuevo nodo al nodo que antes era cabeza 
            cabeza = nuevoNodo;                
            longitud++;                        
        }
        //-------Metodo para agregar al Final--------
        public void AgregarFinal(String nombre)
        {
      
            Nodo nuevoNodo = new Nodo(); // Crear un nuevo nodo
            nuevoNodo.Nombre = nombre; // Asignar el nombre al nodo
            Nodo puntero = cabeza; // Puntero temporal para recorrer la lista

            if (cabeza == null) //Si cabeza es igual a null entonces cabeza es igual a nuevoNodo
            {
                cabeza = nuevoNodo;
            }else
            {
                //Recorrer la lista hasta llegar al último nodo
                while (puntero.siguiente != null) //puntero avanza hasta que puntero.siguiente sea igual a null que seria el final de la lista
                {
                    puntero = puntero.siguiente;

                }
                puntero.siguiente = nuevoNodo; //Enlazar el nuevo nodo al final de la lista 
            }
            longitud++; //Incrementar la longitud de la lista
        }
        //-------Metodo para insertar después de la posición especificada--------
        public void InsertarDespues(int num, String nombre)
        { 
            Nodo nuevoNodo = new Nodo(); // Crear un nuevo nodo
            nuevoNodo.Nombre = nombre; // Asignar el nombre
            if (cabeza == null)
            {
                cabeza = nuevoNodo;// Si la lista está vacía, el nuevo nodo será la cabeza
                longitud++;
            }
            else if (num <= 0)
            {
                // Si la posición es 0 o negativa, insertar al inicio
                nuevoNodo.siguiente = cabeza;
                cabeza = nuevoNodo;
                longitud++;
            }
            else
            {
                Nodo puntero = cabeza;  // Puntero para recorrer la lista
                int contador = 0;
                // Recorrer la lista hasta la posición anterior a la deseada o hasta el final
                while (contador < num - 1  && puntero.siguiente != null) // Se repite hasta que contador sea menor que num
                {
                    puntero = puntero.siguiente;
                    contador++;

                }
                // Insertar el nuevo nodo después del nodo actual
                nuevoNodo.siguiente = puntero.siguiente;
                puntero.siguiente = nuevoNodo;
                longitud++; // Incrementar la longitud de la lista
            }
        }
        //-------Metodo para obtener un nombre en especifico--------
        public String Obtener (int num)
        {
            if (cabeza == null)
            {
                return null;
            }
            else
            {
                Nodo puntero = cabeza;
                int contador = 0;
                // Buscar el nombre deseado
                while (contador < num && puntero.siguiente != null) // Recorrer la lista hasta la posición deseada o hasta el final
                {
                    puntero = puntero.siguiente;
                    contador++;
                }
                return puntero.Nombre;
                
            }

        }
        //----------Metodo para eliminar elementos al inicio de la lista----------

        public void EliminarInicio()
        {
            if (cabeza != null) // Si la lista no está vacía
            {
                cabeza = cabeza.siguiente; // Mover la cabeza al siguiente nodo
                longitud--; // Decrementar la longitud de la lista
            }
        }
        //----------Metodo para eliminar elementos al inicio de la lista----------

        public void EliminarFinal()
        {
            if (cabeza == null) // Si la lista está vacía
            {
                return;
            }
            if (cabeza.siguiente == null) // Si solo hay un nodo
            {
                cabeza = null; // Hacer que la cabeza sea nula
                longitud--; // Decrementar la longitud de la lista
                return;
            }
            else
            {
                Nodo puntero = cabeza;
                while (puntero.siguiente.siguiente != null) // Recorrer hasta el penúltimo nodo
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = null; // Eliminar el último nodo
            }
            longitud--; // Decrementar la longitud de la lista
        }
        //----------Metodo para eliminar elementos en una posición en particular de la lista----------

        public void EliminarEnPosicionParticular(int num)
        {
            if (cabeza == null) // Si la lista está vacía
            {
                return;
            }
            if (num == 0) // Si se quiere eliminar el primer nodo
            {
                cabeza = cabeza.siguiente; // Mover la cabeza al siguiente nodo
                longitud--; // Decrementar la longitud de la lista
            }
            else
            {
                Nodo puntero = cabeza;
                int contador = 0;
                // Buscar el nodo anterior al que se quiere eliminar
                while (contador < num - 1 && puntero.siguiente != null) // Se repite hasta que contador sea menor que n 
                {
                    puntero = puntero.siguiente;
                    contador++;
                }
                if (puntero.siguiente != null) // Si el nodo a eliminar existe
                {
                    puntero.siguiente = puntero.siguiente.siguiente; // Saltar el nodo a eliminar
                }
            }
            longitud--; // Decrementar la longitud de la lista
        }

        //----------Metodo para contar cuantos elementos tiene la lista----------
        public int LongitudDeLista()
        {
            return longitud; // Retorna la longitud de la lista
        }

    }

}
