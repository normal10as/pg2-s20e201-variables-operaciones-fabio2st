Imports System
' 1.9. Crea un proyecto llamado “ÁreaCirculo” 
'  donde se ingresa el radio del círculo imprime el
' área. 𝐴𝑟𝑒𝑎 = 𝜋𝑟2 
Module Program
    Sub Main(args As String())
        'Declaración de variables
        Dim radio, area As Single
        'Entrada
        Console.Write("Ingrese el radio dé un círculo: ")
        radio = Console.ReadLine()
        'Proceso
        area = Math.PI * radio ^ 2
        'Salida
        Console.WriteLine("area = Pi.r^2 => {0}.{1}^2 = {2}", Math.PI, radio, area)
    End Sub
End Module
