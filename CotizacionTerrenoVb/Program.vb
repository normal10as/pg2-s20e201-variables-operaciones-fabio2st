Imports System

' 1.2 Crear un proyecto llamado “CotizaciónTerreno” 
'  qué calcule e imprima el costo un terreno
' cuadrado o rectangular, teniendo como datos el ancho 
' y la longitud en metros y el costo del
' metro cuadrado. 
Module Program
    Sub Main(args As String())
        ' Declaración y asignación de variables
        Dim ancho, longitud As Integer
        Dim costoMetroCuadrado, costoTotal As Decimal
        'Entradas
        Console.Write("Ingrese el ancho del terreno: ")
        ancho = Console.ReadLine()
        Console.Write("Ingrese la longitud del terreno: ")
        longitud = Console.ReadLine()
        Console.Write("Ingrese el precio del metro cuadrado: ")
        costoMetroCuadrado = Console.ReadLine()
        'Procesos
        costoTotal = ancho * longitud * costoMetroCuadrado
        'Salidas
        Console.WriteLine("Valor cotización: $" & costoTotal)
    End Sub
End Module