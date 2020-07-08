Imports System
' 1.8. Crea un proyecto llamado “Facturación” en el cual 
'  se ingresa el nombre de un artículo y su costo. 
'  La utilidad es del 150 por ciento 
' y el impuesto es el 21 por ciento. 
' Calcular e imprimir artículo, utilidad, 
' impuesto y precio de venta. 
Module Program
    Sub Main(args As String())
        'Declaración de variables
        Dim nombreArticulo As String
        Dim costo, precio, utilidad, impuesto As Decimal
        Dim utilidadPorcentaje As Decimal = 150
        Dim impuestoPorcentaje As Decimal = 21
        'Entrada
        Console.Write("Nombre artículo: ")
        nombreArticulo = Console.ReadLine()
        Console.Write("Costo: ")
        costo = Console.ReadLine()
        'Proceso
        utilidad = costo * utilidadPorcentaje / 100
        precio = costo + utilidad
        impuesto = precio * impuestoPorcentaje / 100
        precio += impuesto
        'Salida
        Console.WriteLine("Articulo: " & nombreArticulo)
        Console.WriteLine("Costo:    " & costo)  ' no estaba en el requerimiento
        Console.WriteLine("Utilidad: " & utilidad)
        Console.WriteLine("Impuesto: " & impuesto)
        Console.WriteLine("Precio:   " & precio)
    End Sub
End Module
