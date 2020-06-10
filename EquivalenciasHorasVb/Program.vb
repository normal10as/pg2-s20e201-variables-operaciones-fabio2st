Imports System

' 1.3. Crea un proyecto llamado “EquivalenciasHoras” 
'  que lea una cantidad de horas e imprima su
' equivalente en minutos, segundos y días 
Module Program
    Sub Main(ByVal args As String())
        Dim horas As UShort
        Dim minutos As UInteger
        Dim segundos As UInteger
        Dim dias As UShort
        Console.Write("Ingrese cantidad horas: ")
        horas = Convert.ToUInt16(Console.ReadLine())
        minutos = CUInt(horas) * 60
        segundos = minutos * 60
        dias = CUShort(horas / 24)
        Console.WriteLine("Equivale a {0} segundos", segundos)
        Console.WriteLine("Equivale a {0} minutos", minutos)
        Console.WriteLine("Equivale a {0} dias", dias)
    End Sub
End Module

