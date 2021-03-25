Module Refrase

    Sub Main()
        Dim frase As String = "Aunque la cadena sea de oro, sirve para lo mismo."

        Dim palabra1, palabra2, fraseFinal As String

        Console.WriteLine("Ingresar una palabra que exista en la cadena: ")
        palabra1 = Console.ReadLine()

        Console.WriteLine("Ingresar una palabra para reemplazar: ")
        palabra2 = Console.ReadLine()


        Console.WriteLine(frase)

        fraseFinal = Replace(frase, palabra1, palabra2)

        Console.WriteLine(fraseFinal)

    End Sub

End Module
