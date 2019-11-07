using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDeDatos.EstructuraDeDatos

    public class TDAPila
    {
        int dato;
        TDAPila frente;
        TDAPila siguiente;
        TDAPila cima;


        //Constructor
        public TDAPila(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }

        //Constructor vacío 
        public TDAPila() { }
        //CrearPila

        public static TDAPila CrearPila(int dato)
        {
            TDAPila miPila = new TDAPila(dato);
            miPila.frente = miPila.cima;
            miPila.cima = miPila;
            return miPila;
        }
        //Apilar

        public static TDAPila ApilarPila(TDAPila miPila,int dato)
        {
            if (miPila == null)
            { Console.WriteLine("No se ha creado ninguna pila.\n"); return miPila; }
            else
            {
                TDAPila nodoNuevo = new TDAPila(dato);
                TDAPila aux = miPila;
                miPila.cima.siguiente = nodoNuevo;
                miPila.cima = miPila.cima.siguiente;
                return miPila;
            }
            
        }
        //Desapilar

        public static TDAPila DesapilarPila(TDAPila miPila)
        {
            //Si la pila está vacía
            if (miPila == null)
            {
                Console.WriteLine("No se ha creado ninguna pila.\n");return miPila;
            }
            else
            {
                //Si la pila solo tiene un nodo

                if (miPila.siguiente == null)
                {
                    
                    return miPila.siguiente;
                }
                //Si la pila tiene más de un nodo

                else
                {
                    TDAPila aux = miPila;
                    for (; aux.siguiente.siguiente != null; aux = aux.siguiente) { }
                    Console.WriteLine("Dato desapilado: " + aux.siguiente.dato+"\n");
                    aux.siguiente = aux.siguiente.siguiente;
                    miPila.cima = aux;
                    return miPila;
                }
            }
            
        }
        //Imprimir la cima

        public static void ImprimirCima(TDAPila miPila)
        {
            if (miPila == null)
            {
                Console.WriteLine("No se ha creado ninguna pila\n");
            }
            else
            {
                Console.WriteLine("Cima: " + miPila.cima.dato + "\n");
            }
        }
        //Imprimir pila

        public static void ImprimirPila(TDAPila miPila)
        {
            for (TDAPila aux = miPila; aux != null; aux = aux.siguiente)
                Console.WriteLine("Dato: " + aux.dato + "\n");
        }
    }
}
