Imports System

Module Module1
    Sub Main()
        Console.WriteLine("Ingrese el d�a:")
        Dim dia As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese el mes:")
        Dim mes As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese el a�o:")
        Dim a�o As Integer = Convert.ToInt32(Console.ReadLine())

        MostrarFecha(dia, mes, a�o)

        Console.ReadLine()
    End Sub

    Sub MostrarFecha(dia As Integer, mes As Integer, a�o As Integer)
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
                mesTexto = "Mes inv�lido"
        End Select

        If mesTexto <> "Mes inv�lido" Then
            Console.WriteLine("La fecha es: {0} de {1} de {2}", dia, mesTexto, a�o)
        Else
            Console.WriteLine("Ha ingresado un mes no v�lido.")
        End If
    End Sub
End Module

