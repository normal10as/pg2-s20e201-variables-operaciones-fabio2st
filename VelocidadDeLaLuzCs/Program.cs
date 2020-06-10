using System;
/* 1.4. Crear un proyecto llamado “VelocidadDeLaLuz”. 
 * Teniendo en cuenta que la velocidad de la
luz 300.000 kilómetros por segundo, 
elaborar un algoritmo que lea un tiempo en segundos
imprima la distancia que recorre la luz en dicho tiempo */
namespace VelocidadDeLaLuzCs
{
    class Program
    {
        static void Main(string[] args)
        {
            short segundos;
            ulong distancia;
            Console.Write("Ingrese número de segundos: ");
            segundos = Convert.ToInt16(Console.ReadLine());
            distancia = (ulong)segundos * 300000;
            Console.WriteLine("En {0} segundos, la luz recorre {1} Kilometros.", segundos, distancia);
        }
    }
}
