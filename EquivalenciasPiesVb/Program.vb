Imports System
' 1.7. Crear un proyecto llamado “EquivalenciasPies”. 
'  Se debe ingresar una distancia medidas en pies y 
'  calcular su equivalente en pulgadas, yarda, cms y metros. 
' Utilizar únicamente las equivalencias conocidas: 
' 1 pie = 12 pulgadas, 1 yarda = 3 pies, 
' 1 pulgada = 2.54 cm, 1 metro = 100 cm. 
Module Program
    Sub Main(args As String())
        'Declaración de variables
        Dim piePulgadas As Byte = 12
        Dim yardaPies As Byte = 3
        Dim pulgadaCms As Decimal = 2.54
        Dim metroCms As Byte = 100
        Dim pies As UInteger
        Dim pulgadas, yardas, cms, metros As Decimal
        'Entrada
        Console.Write("Ingrese medida en pies: ")
        pies = Console.ReadLine()
        'Proceso
        pulgadas = pies * piePulgadas
        yardas = pies / yardaPies
        cms = pulgadas * pulgadaCms
        metros = cms / metroCms
        'Salida
        Console.WriteLine("Equivale a {0} pulgadas", pulgadas)
        Console.WriteLine("Equivale a {0} yardas", yardas)
        Console.WriteLine("Equivale a {0} centimetros", cms)
        Console.WriteLine("Equivale a {0} metros", metros)
    End Sub
End Module
