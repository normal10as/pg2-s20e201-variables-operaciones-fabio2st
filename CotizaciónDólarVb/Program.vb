Imports System
' 1.10. Crea un proyecto llamado �Cotizaci�nD�lar� 
'  el cual se ingresa la cantidad de d�lares
' que se va a comprar y el tipo de cambio en pesos 
' (cost� de un d�lar en pesos) 
' Calcular e imprimir la cantidad que se debe 
' pagar en pesos por la cantidad de d�lares indicada 
Module Program
    Sub Main(args As String())
        Dim montoDolar, costoDolar, montoPesos As Decimal
        Console.Write("Ingrese monto en d�lares: ")
        montoDolar = Console.ReadLine()
        Console.Write("Costo d�lar: ")
        costoDolar = Console.ReadLine()
        montoPesos = montoDolar * costoDolar
        Console.WriteLine("Pago en pesos: " & montoPesos)
    End Sub
End Module
