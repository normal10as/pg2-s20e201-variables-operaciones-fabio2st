Imports System
' 1.10. Crea un proyecto llamado “CotizaciónDólar” 
'  el cual se ingresa la cantidad de dólares
' que se va a comprar y el tipo de cambio en pesos 
' (costó de un dólar en pesos) 
' Calcular e imprimir la cantidad que se debe 
' pagar en pesos por la cantidad de dólares indicada 
Module Program
    Sub Main(args As String())
        Dim montoDolar, costoDolar, montoPesos As Decimal
        Console.Write("Ingrese monto en dólares: ")
        montoDolar = Console.ReadLine()
        Console.Write("Costo dólar: ")
        costoDolar = Console.ReadLine()
        montoPesos = montoDolar * costoDolar
        Console.WriteLine("Pago en pesos: " & montoPesos)
    End Sub
End Module
