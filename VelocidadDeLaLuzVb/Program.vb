Imports System

Module Program
    Sub Main(args As String())
        Dim segundos As Short
        Dim distancia As ULong
        Console.Write("Ingrese n�mero de segundos: ")
        segundos = Console.ReadLine()
        distancia = segundos * 300000
        Console.WriteLine("En {0} segundos, la luz recorre {1} Kilometros.", segundos, distancia)
    End Sub
End Module
