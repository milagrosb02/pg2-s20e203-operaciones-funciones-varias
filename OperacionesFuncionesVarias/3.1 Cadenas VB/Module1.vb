Module Module1

    Sub Main()

        Dim cadena, ultimaPalabra, segundaPalabra, nueva_cadena As String
        Dim primer_espacio_blanco, segundo_espacio_blanco As Byte

        Console.WriteLine("Ingresar cadena de al menos 3 palabras: ")

        cadena = Console.ReadLine()

        ultimaPalabra = cadena.Substring(cadena.LastIndexOf(" ") + 1)

        primer_espacio_blanco = cadena.IndexOf(" ")

        segundo_espacio_blanco = cadena.IndexOf(" ", primer_espacio_blanco + 1)

        segundaPalabra = cadena.Substring(primer_espacio_blanco + 1, segundo_espacio_blanco - primer_espacio_blanco)


        Console.WriteLine("Segunda palabra: " & segundaPalabra)

        Console.WriteLine("Ultima palabra: " & ultimaPalabra)

        Console.WriteLine("Cadena final: " & cadena.Replace(ultimaPalabra, segundaPalabra))



    End Sub

End Module
