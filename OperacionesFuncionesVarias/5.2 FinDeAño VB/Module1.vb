Module Module1

    Sub Main()

        Dim fechaActual As Date = Date.Today

        Dim anio As Long

        Dim fechaFinal As Date

        Dim mes As Byte = 12

        Dim meses, semanas, horas As Integer

        Console.WriteLine("Ingresar año: ")

        anio = Console.ReadLine()

        fechaFinal = DateSerial(anio, mes + 1, 0)


        meses = DateDiff("m", fechaActual, fechaFinal)

        semanas = DateDiff("ww", fechaActual, fechaFinal)

        horas = DateDiff("h", fechaActual, fechaFinal)

        Console.WriteLine("Faltan: " & meses & " " & "meses")
        Console.WriteLine("Faltan: " & semanas & " " & "semanas")
        Console.WriteLine("Faltan: " & horas & " " & "horas")



    End Sub

End Module
