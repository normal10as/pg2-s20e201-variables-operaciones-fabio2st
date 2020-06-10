using System;
/* 1.6. Crea un proyecto llamado “GradosFahrenheit” 
 * donde se ingresa la temperatura en Celsius y
se muestra su equivalente en fahrenheit. 
Investigar la fórmula necesaria para realizar el
cálculo. */
namespace GradosFahrenheitCs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            float celsius, fahrenheit;
            //Entrada
            Console.Write("Ingrese temperatura en Celsius: ");
            celsius = Convert.ToSingle(Console.ReadLine());
            //Proceso
            fahrenheit = (float)(celsius * 1.8 + 32);
            //Salida
            Console.WriteLine("Temperatura en fahrenheit: " + fahrenheit);
        }
    }
}
