using System;
using System.Collections.Generic;
using EstructuraDeDatos.EstructuraDeDatos;

namespace EstructuraDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pila
            Console.WriteLine("//////////////////////////////////////////");
            Console.WriteLine("Ejemplo de pila\n");
            TDAPila miPila = null;
            miPila = TDAPila.CrearPila(50);
            miPila = TDAPila.ApilarPila(miPila,45);
            miPila = TDAPila.ApilarPila(miPila,80);
            TDAPila.ImprimirCima(miPila);
            miPila = TDAPila.DesapilarPila(miPila);
            TDAPila.ImprimirCima(miPila);
            TDAPila.ImprimirPila(miPila);


            //Cola
            Console.WriteLine("////////////////////////////////");
            Console.WriteLine("Ejemplo de cola\n");
            TDACola miCola = null;
            miCola = TDACola.CrearCola(78);
            miCola = TDACola.EncolarCola(miCola,98);
            miCola = TDACola.EncolarCola(miCola,878);
            TDACola.ImprimirCima(miCola);
            TDACola.ImprimirCabecera(miCola);
            miCola = TDACola.DesencolarCola(miCola);
            TDACola.ImprimirCabecera(miCola);
            TDACola.ImprimirCima(miCola);
            TDACola.ImprimirCola(miCola);
            Console.ReadKey();
        }
    }
}
