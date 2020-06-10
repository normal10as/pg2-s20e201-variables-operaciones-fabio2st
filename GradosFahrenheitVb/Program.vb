Imports System
' 1.6. Crea un proyecto llamado “GradosFahrenheit” 
'  donde se ingresa la temperatura en Celsius y
' se muestra su equivalente en fahrenheit. 
' Investigar la fórmula necesaria para realizar el
' cálculo. 
Module Program
    Sub Main(args As String())
        Dim celsius, fahrenheit As Single
        Console.Write("Ingrese temperatura en Celsius: ")
        celsius = Console.ReadLine()
        fahrenheit = celsius * 1.8 + 32
        Console.WriteLine("Temperatura en fahrenheit: " & fahrenheit)
    End Sub
End Module
