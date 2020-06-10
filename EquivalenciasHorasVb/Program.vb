Imports System

' 1.3. Crea un proyecto llamado “EquivalenciasHoras” 
'  que lea una cantidad de horas e imprima su
' equivalente en minutos, segundos y días 
Module Program
    Sub Main(ByVal args As String())
        'Declaración de variables
        Dim horas As UShort
        Dim minutos As UInteger
        Dim segundos As UInteger
        Dim dias As UShort
        'Entrada
        Console.Write("Ingrese cantidad horas: ")
        horas = Console.ReadLine()
        'Proceso
        minutos = horas * 60
        segundos = minutos * 60
        dias = horas / 24
        'Salida
        Console.WriteLine("Equivale a {0} segundos", segundos)
        Console.WriteLine("Equivale a {0} minutos", minutos)
        Console.WriteLine("Equivale a {0} dias", dias)
    End Sub
End Module

