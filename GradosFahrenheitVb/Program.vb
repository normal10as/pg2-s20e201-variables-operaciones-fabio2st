Imports System
' 1.6. Crea un proyecto llamado �GradosFahrenheit� 
'  donde se ingresa la temperatura en Celsius y
' se muestra su equivalente en fahrenheit. 
' Investigar la f�rmula necesaria para realizar el
' c�lculo. 
Module Program
    Sub Main(args As String())
        'Declaraci�n de variables
        Dim celsius, fahrenheit As Single
        'Entrada
        Console.Write("Ingrese temperatura en Celsius: ")
        celsius = Console.ReadLine()
        'Proceso
        fahrenheit = celsius * 1.8 + 32
        'Salida
        Console.WriteLine("Temperatura en fahrenheit: " & fahrenheit)
    End Sub
End Module
