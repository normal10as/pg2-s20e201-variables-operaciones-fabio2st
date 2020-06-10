Imports System
' 1.9. Crea un proyecto llamado “ÁreaCirculo” 
'  donde se ingresa el radio del círculo imprime el
' área. 𝐴𝑟𝑒𝑎 = 𝜋𝑟2 
Module Program
    Sub Main(args As String())
        Dim radio, area As Single

        Console.Write("Ingrese el radio dé un círculo: ")

        radio = Convert.ToSingle(Console.ReadLine())

        area = CSng(Math.PI * Math.Pow(radio, 2))

        Console.WriteLine("area = Pi.r^2 => {0}.{1}^2 = {2}", Math.PI, radio, area)
    End Sub
End Module
