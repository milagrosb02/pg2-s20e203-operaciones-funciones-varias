Module PalabraMasLongitud

    Sub Main()

        Dim palabra1, palabra2, palabra3 As String

        Dim longitud1, longitud2, longitud3 As UShort

        Console.WriteLine("Ingresar una palabra: ")
        palabra1 = Console.ReadLine()

        Console.WriteLine("Ingresar una palabra: ")
        palabra2 = Console.ReadLine()

        Console.WriteLine("Ingresar una palabra: ")
        palabra3 = Console.ReadLine()

        longitud1 = palabra1.Length

        longitud2 = palabra2.Length

        longitud3 = palabra3.Length



        Console.WriteLine("La palabra de mayor longitud es: " & Math.Max(longitud1, Math.Max(longitud2, longitud3)))

    End Sub

End Module
