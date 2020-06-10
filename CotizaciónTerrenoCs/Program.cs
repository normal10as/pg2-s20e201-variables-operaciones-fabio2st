using System;
/* 1.2 Crear un proyecto llamado “CotizaciónTerreno” 
 * qué calcule e imprima el costo un terreno
cuadrado o rectangular, teniendo como datos el ancho 
y la longitud en metros y el costo del
metro cuadrado. */
namespace CotizaciónTerrenoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración y asignación de variables
            int ancho, longitud;
            decimal costoMetroCuadrado, costoTotal;
            //Entradas
            Console.Write("Ingrese el ancho del terreno: ");
            ancho = Convert.ToInt32( Console.ReadLine());
            Console.Write("Ingrese la longitud del terreno: ");
            longitud = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el precio del metro cuadrado: ");
            costoMetroCuadrado = Convert.ToInt32(Console.ReadLine());
            //Procesos
            costoTotal = ancho * longitud * costoMetroCuadrado;
            //Salidas
            Console.WriteLine("Valor cotización: $" + costoTotal);
        }
    }
}
