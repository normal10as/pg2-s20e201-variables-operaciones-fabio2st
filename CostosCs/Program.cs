using System;

namespace CostosCs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración y asignación de variables
            string descripcion;
            decimal costoUnitario;
            int unidadesProducidas;
            decimal factorCostos = 3.5M;
            decimal costoFijo = 10700;
            //Entradas
            Console.Write("Ingrese la descripción del artículo: ");
            descripcion = Console.ReadLine();
            Console.Write("Ingrese el número de unidades producidas: ");
            unidadesProducidas = Convert.ToInt32(Console.ReadLine());
            //Procesos
            costoUnitario = (unidadesProducidas * factorCostos + costoFijo) / unidadesProducidas;
            //Salidas
            Console.WriteLine("Artículo: " + descripcion);
            Console.WriteLine("Número de unidades: " + unidadesProducidas);
            Console.WriteLine("Costo de producción: $" + costoUnitario);
        }
    }
}