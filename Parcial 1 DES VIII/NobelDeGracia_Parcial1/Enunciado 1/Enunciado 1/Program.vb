Imports System

Module Module1
    Sub Main()
        Console.WriteLine("Ingrese el día:")
        Dim dia As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese el mes:")
        Dim mes As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese el año:")
        Dim año As Integer = Convert.ToInt32(Console.ReadLine())

        MostrarFecha(dia, mes, año)

        Console.ReadLine()
    End Sub

    Sub MostrarFecha(dia As Integer, mes As Integer, año As Integer)
        Dim mesTexto As String

        Select Case mes
            Case 1
                mesTexto = "enero"
            Case 2
                mesTexto = "febrero"
            Case 3
                mesTexto = "marzo"
            Case 4
                mesTexto = "abril"
            Case 5
                mesTexto = "mayo"
            Case 6
                mesTexto = "junio"
            Case 7
                mesTexto = "julio"
            Case 8
                mesTexto = "agosto"
            Case 9
                mesTexto = "septiembre"
            Case 10
                mesTexto = "octubre"
            Case 11
                mesTexto = "noviembre"
            Case 12
                mesTexto = "diciembre"
            Case Else
                mesTexto = "Mes inválido"
        End Select

        If mesTexto <> "Mes inválido" Then
            Console.WriteLine("La fecha es: {0} de {1} de {2}", dia, mesTexto, año)
        Else
            Console.WriteLine("Ha ingresado un mes no válido.")
        End If
    End Sub
End Module

