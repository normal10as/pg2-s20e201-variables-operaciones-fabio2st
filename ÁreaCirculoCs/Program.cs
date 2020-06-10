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
            float radio, area;

            Console.Write("Ingrese el radio dé un círculo: ");
            radio = Convert.ToSingle(Console.ReadLine());

            area = (Single)(Math.PI * Math.Pow(radio, 2));

            Console.WriteLine("area = Pi.r^2 => {0}.{1}^2 = {2}",Math.PI, radio, area);
        }
    }
}
