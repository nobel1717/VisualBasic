Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles en1.Click
        Dim cadena As String = ""
        Dim letra As String = ""
        Dim vocales As String = "AEIOUaeiou"

        Do
            letra = InputBox("Ingrese una letra:")
            If letra.Length = 1 AndAlso Char.IsLetter(letra) Then
                cadena &= letra
            Else
                MsgBox("Por favor ingrese una letra válida.")
            End If
        Loop While Not vocales.Contains(letra)
        TextBox1.Text = cadena
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles en2.Click
        Dim cadena As String = InputBox("Ingrese una cadena:")
        Dim vocales As String = "AEIOUaeiou"
        Dim contadorVocales As Integer = 0
        Dim contadorConsonantes As Integer = 0

        If cadena.Any(Function(c) Char.IsDigit(c)) Then
            MsgBox("La cadena no puede contener números.")
            Exit Sub
        End If
        For Each letra As Char In cadena
            If Char.IsLetter(letra) Then
                If vocales.Contains(letra) Then
                    contadorVocales += 1
                Else
                    contadorConsonantes += 1
                End If
            End If
        Next

        MsgBox("Vocales: " & contadorVocales & vbCrLf & "Consonantes: " & contadorConsonantes)
    End Sub
End Class
