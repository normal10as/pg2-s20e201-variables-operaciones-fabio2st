using System;
/* 1.10. Crea un proyecto llamado “CotizaciónDólar” 
 * el cual se ingresa la cantidad de dólares
que se va a comprar y el tipo de cambio en pesos 
(costó de un dólar en pesos) 
Calcular e imprimir la cantidad que se debe 
pagar en pesos por la cantidad de dólares indicada */
namespace CotizaciónDólarCs
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal montoDolar, costoDolar, montoPesos;

            Console.Write("Ingrese monto en dólares: ");
            montoDolar = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Costo dólar: ");
            costoDolar = Convert.ToDecimal(Console.ReadLine());

            montoPesos = montoDolar * costoDolar;

            Console.WriteLine("Pago en pesos: " + montoPesos);
        }
    }
}
