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
            float celsius, fahrenheit;
            Console.Write("Ingrese temperatura en Celsius: ");
            celsius = Convert.ToSingle(Console.ReadLine());
            fahrenheit = (float)(celsius * 1.8 + 32);
            Console.WriteLine("Temperatura en fahrenheit: " + fahrenheit);
        }
    }
}
