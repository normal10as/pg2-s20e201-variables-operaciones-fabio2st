Imports System

Module Program
    Sub Main(args As String())
        ' Declaraci�n y asignaci�n de variables
        Dim descripcion As String
        Dim costoUnitario As Decimal
        Dim unidadesProducidas As UInteger
        Dim factorCostos As Decimal = 3.5
        Dim costoFijo As Decimal = 10700
        ' Entradas
        Console.Write("Ingrese la descripci�n del art�culo: ")
        descripcion = Console.ReadLine()
        Console.Write("Ingrese el n�mero de unidades producidas: ")
        unidadesProducidas = Console.ReadLine()
        ' Procesos
        costoUnitario = (unidadesProducidas * factorCostos + costoFijo) / unidadesProducidas
        'Salidas
        Console.WriteLine("Art�culo: " & descripcion)
        Console.WriteLine("N�mero de unidades: " & unidadesProducidas)
        Console.WriteLine("Costo de producci�n: $" & costoUnitario)
    End Sub
End Module
