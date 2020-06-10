using System;
/* 1.5. Crear un proyecto y un módulo llamado “Cuadratica” 
 * que resuelva la siguiente ecuación 𝑥 = 𝑏2−4𝑎𝑐 / 2𝑎
donde a = 1, b = 5 y c=2. Mostrar el resultado obtenido. */
namespace CuadraticaCs
{
    class Program
    {
        static void Main(string[] args)
        {
        ushort a = 1, b = 5, c = 2;
        double x;
        x = (b*2-4*a*c) / (2*a);
        Console.WriteLine("x = b2−4ac / 2a donde a = 1, b = 5 y c = 2 entonces x = " + x);
        }
    }
}
