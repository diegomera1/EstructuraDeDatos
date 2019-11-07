using System;
using System.Collections.Generic;
using System.Text;

namespace EstructuraDeDatos.EstructuraDeDatos
{
    public class TDACola
    {
        int dato;
        TDACola cima;
        TDACola frente;
        TDACola siguiente;

        //Constructor

        public TDACola(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
        //Constructor vacio

        public TDACola() { }
        //Crear cola

        public static TDACola CrearCola(int dato)
        {
            TDACola miCola = new TDACola(dato);
            miCola.frente = miCola.cima = miCola;
            return miCola;
        }
        //Método para encolar

        public static TDACola EncolarCola(TDACola miCola, int dato)
        {
            if (miCola == null)
            {
                Console.WriteLine("La cola no ha sido creada\n"); return miCola;
            }
            else
            {
                TDACola nuevoNodo = new TDACola(dato);
                miCola.cima.siguiente = nuevoNodo;
                miCola.cima = miCola.cima.siguiente;
                return miCola;
            }

        }

        //Desencolar

        public static TDACola DesencolarCola(TDACola miCola)
        {
            if (miCola == null)
            {
                Console.WriteLine("La cola no ha sido creada,\n"); return miCola;
            }
            else
            {
                Console.WriteLine("Dato desencolado: " + miCola.dato + "\n");
                TDACola aux = miCola;
                for (; aux.siguiente.siguiente != null; aux = aux.siguiente) { }
                miCola = miCola.siguiente;
                miCola.cima = aux.siguiente;
                miCola.frente = miCola;
                return miCola;
            }

        }

        //Imprimir cima

        public static void ImprimirCima(TDACola miCola)
        {
            if (miCola == null)
            {
                Console.WriteLine("La cola no ha sido creada, cree una con la opción 1\n");
            }
            else
            {
                Console.WriteLine("Cima: " + miCola.cima.dato + "\n");
            }
        }

        //Imprimir cabecera

        public static void ImprimirCabecera(TDACola miCola)
        {
            if (miCola == null)
            {
                Console.WriteLine("La cola no ha sido creada, cree una con la opción 1\n");
            }
            else
            {
                Console.WriteLine("Cabecera: " + miCola.frente.dato + "\n");
            }
        }
        //Imprimir cola

    public static void ImprimirCola(TDACola miCola)
        {
            if (miCola == null)
            {
                Console.WriteLine("La cola no ha sido creada.\n");
            }
            else
            {
                TDACola aux = miCola;
                for (; aux != null; aux = aux.siguiente)
                    Console.WriteLine("Dato: " + aux.dato + "\n");
            }
        }
    }
}