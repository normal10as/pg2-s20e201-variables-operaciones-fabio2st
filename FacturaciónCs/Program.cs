using System;
/* 1.8. Crea un proyecto llamado “Facturación” en el cual 
 * se ingresa el nombre de un artículo y su costo. 
 * La utilidad es del 150 por ciento 
y el impuesto es el 21 por ciento. 
Calcular e imprimir artículo, utilidad, 
impuesto y precio de venta. */
namespace FacturaciónCs
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreArticulo;
            decimal costo, precio, utilidad, impuesto;
            decimal utilidadPorcentaje = 150;
            decimal impuestoPorcentaje = 21;

            Console.Write("Nombre artículo: ");
            nombreArticulo = Console.ReadLine();
            Console.Write("Costo: ");
            costo = Convert.ToDecimal(Console.ReadLine());

            utilidad = costo * utilidadPorcentaje / 100;
            precio = costo + utilidad;
            impuesto = precio * impuestoPorcentaje / 100;
            precio += impuesto;

            Console.WriteLine("Articulo: " + nombreArticulo);
            Console.WriteLine("Costo:    " + costo);  // no estaba en el requerimiento
            Console.WriteLine("Utilidad: " + utilidad);
            Console.WriteLine("Impuesto: " + impuesto);
            Console.WriteLine("Precio:   " + precio);
        }
    }
}
