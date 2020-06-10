using System;
/* 1.9. Crea un proyecto llamado “ÁreaCirculo” 
 * donde se ingresa el radio del círculo imprime el
área. 𝐴𝑟𝑒𝑎 = 𝜋𝑟2 */
namespace ÁreaCirculoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            float radio, area;
            //Entrada
            Console.Write("Ingrese el radio dé un círculo: ");
            radio = Convert.ToSingle(Console.ReadLine());
            //Proceso
            area = (Single)(Math.PI * Math.Pow(radio, 2));
            //Salida
            Console.WriteLine("area = Pi.r^2 => {0}.{1}^2 = {2}", Math.PI, radio, area);
        }
    }
}
