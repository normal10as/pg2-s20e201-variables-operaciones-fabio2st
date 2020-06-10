using System;
/* 1.3. Crea un proyecto llamado “EquivalenciasHoras” 
 * que lea una cantidad de horas e imprima su
equivalente en minutos, segundos y días */
namespace EquivalenciasHorasCs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            ushort horas;
            uint minutos;
            uint segundos;
            ushort dias;
            //Entrada
            Console.Write("Ingrese cantidad horas: ");
            horas = Convert.ToUInt16(Console.ReadLine());
            //Proceso
            minutos = (uint)horas * 60;
            segundos = minutos * 60;
            dias = (ushort)(horas / 24);
            //Salida
            Console.WriteLine("Equivale a {0} segundos" , segundos);
            Console.WriteLine("Equivale a {0} minutos" , minutos);
            Console.WriteLine("Equivale a {0} dias" , dias);
        }
    }
}
