Module Module1

    Sub Main()

        Dim verbo, yo, tu, el, nos, ellos, ud As String

        Console.WriteLine("Ingresar el infinitivo del verbo: ")
        verbo = Console.ReadLine()

        yo = verbo.Replace("ar", "o").Replace("er", "o").Replace("ir", "o")

        tu = verbo.Replace("ar", "as").Replace("er", "es").Replace("ir", "es")

        el = verbo.Replace("ar", "a").Replace("er", "e").Replace("ir", "e")

        nos = verbo.Replace("ar", "amos").Replace("er", "emos").Replace("ir", "imos")

        ud = verbo.Replace("ar", "an").Replace("er", "en").Replace("ir", "en")

        ellos = verbo.Replace("ar", "an").Replace("er", "en").Replace("ir", "en")


        Console.WriteLine("Yo: " & yo)
        Console.WriteLine("Tu: " & tu)
        Console.WriteLine("El: " & el)
        Console.WriteLine("Nosotros: " & nos)
        Console.WriteLine("Ellos: " & ellos)
        Console.WriteLine("Ustedes: " & ud)

    End Sub

End Module
