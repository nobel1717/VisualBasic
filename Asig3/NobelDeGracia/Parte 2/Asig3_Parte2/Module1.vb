Module Module1

    Sub Main()
        Console.WriteLine("Ingrese su nombre:")
        Dim nombre As String = Console.ReadLine()

        Console.WriteLine("Ingrese su apellido:")
        Dim apellido As String = Console.ReadLine()

        Dim nombreCompleto As String = ConcatenarNombreApellido(nombre, apellido)
        Console.WriteLine("El nombre completo es: " & nombreCompleto)

        Console.WriteLine("Presione cualquier tecla para salir :D")
        Console.ReadKey()
    End Sub

    Function ConcatenarNombreApellido(nombre As String, apellido As String) As String
        Return nombre & " " & apellido
    End Function

End Module
