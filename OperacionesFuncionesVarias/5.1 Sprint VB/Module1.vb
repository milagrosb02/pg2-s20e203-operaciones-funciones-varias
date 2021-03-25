Module Sprint

    Sub Main()

        Dim fecha As Date

        Dim hora As UShort

        Console.WriteLine("Ingresar una fecha: ")
        fecha = Console.ReadLine()

        Console.WriteLine("Ingresar una hora: ")
        hora = Console.ReadLine()


        Console.WriteLine("Resultado: " & fecha.AddDays(hora))

    End Sub

End Module
