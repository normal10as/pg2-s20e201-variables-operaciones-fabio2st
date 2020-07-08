using System;
/* 1.1. Crear un proyecto llamado “Costos” qué calcula 
 * imprima el costo de producción de un artículo, 
 * teniendo como datos la descripción y el número de unidades producidas.
 * El costo se calcula multiplicando el número de unidades producidas 
 * por un factor de costo de materiales de 3.5 
 * y sumándole el producto un costo fijo de 10.700. 
 * Informar todos los datos ingresados junto a los resultados calculados. */
namespace CostosCs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración y asignación de variables
            string descripcion;
            decimal costoUnitario;
            uint unidadesProducidas;
            decimal factorCostos = 3.5M;
            decimal costoFijo = 10700;
            //Entradas
            Console.Write("Ingrese la descripción del artículo: ");
            descripcion = Console.ReadLine();
            Console.Write("Ingrese el número de unidades producidas: ");
            unidadesProducidas = Convert.ToUInt32(Console.ReadLine());
            //Procesos
            costoUnitario = (unidadesProducidas * factorCostos + costoFijo) / unidadesProducidas;
            //Salidas
            Console.WriteLine("Artículo: " + descripcion);
            Console.WriteLine("Número de unidades: " + unidadesProducidas);
            Console.WriteLine("Costo de producción: $" + costoUnitario);
        }
    }
}