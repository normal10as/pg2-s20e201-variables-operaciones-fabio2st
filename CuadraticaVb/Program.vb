Imports System
' 1.5. Crear un proyecto y un módulo llamado “Cuadratica” 
'  que resuelva la siguiente ecuación 𝑥 = 𝑏2−4𝑎𝑐 / 2𝑎
' donde a = 1, b = 5 y c=2. Mostrar el resultado obtenido. 
Module Program
    Sub Main(args As String())
        Dim a As UShort = 1, b As UShort = 5, c As UShort = 2
        Dim x As Double
        x = (b * 2 - 4 * a * c) / (2 * a)
        Console.WriteLine("x = b2−4ac / 2a donde a = 1, b = 5 y c = 2 entonces x = " & x)
    End Sub
End Module
