Imports System
'1.4. Crear un proyecto llamado “VelocidadDeLaLuz”. 
'Teniendo en cuenta que la velocidad de la
'luz 300.000 kilómetros por segundo, 
'elaborar un algoritmo que lea un tiempo en segundos
'imprima la distancia que recorre la luz en dicho tiempo 
Module Program
    Sub Main(args As String())
        'Declaración de variables
        Dim segundos As UShort
        Dim distancia As ULong
        'Entrada
        Console.Write("Ingrese número de segundos: ")
        segundos = Console.ReadLine()
        'Proceso
        distancia = segundos * 300000
        'Salida
        Console.WriteLine("En {0} segundos, la luz recorre {1} Kilometros.", segundos, distancia)
    End Sub
End Module
