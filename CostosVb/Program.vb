Imports System

Module Program
    Sub Main(args As String())
        ' Declaración y asignación de variables
        Dim descripcion As String
        Dim costoUnitario As Decimal
        Dim unidadesProducidas As UInteger
        Dim factorCostos As Decimal = 3.5
        Dim costoFijo As Decimal = 10700
        ' Entradas
        Console.Write("Ingrese la descripción del artículo: ")
        descripcion = Console.ReadLine()
        Console.Write("Ingrese el número de unidades producidas: ")
        unidadesProducidas = Console.ReadLine()
        ' Procesos
        costoUnitario = (unidadesProducidas * factorCostos + costoFijo) / unidadesProducidas
        'Salidas
        Console.WriteLine("Artículo: " & descripcion)
        Console.WriteLine("Número de unidades: " & unidadesProducidas)
        Console.WriteLine("Costo de producción: $" & costoUnitario)
    End Sub
End Module
