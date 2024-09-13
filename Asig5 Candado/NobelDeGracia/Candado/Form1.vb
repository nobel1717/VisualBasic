Public Class Form1
    Private CombinacionCorrecta As String = "3123"

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles btninte.Click
        Dim intento As String = dig1.Text & dig2.Text & dig3.Text & dig4.Text

        If intento = CombinacionCorrecta Then
            MessageBox.Show("¡Wopaaaaa! Acertaste y has abierto la caja.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Combinación incorrecta, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LimpiarTextBoxes()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btndesis.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de rendirte?", "Desistir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            MessageBox.Show("Has desistido del intento. ¡Te espero la próxima vez!", "Desistir", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
        LimpiarTextBoxes()
        dig1.Focus()
    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles dig1.TextChanged
        If dig1.Text.Length = 1 Then
            dig2.Focus()
        End If
    End Sub

    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles dig2.TextChanged
        If dig2.Text.Length = 1 Then
            dig3.Focus()
        End If
    End Sub

    Private Sub txt3_TextChanged(sender As Object, e As EventArgs) Handles dig3.TextChanged
        If dig3.Text.Length = 1 Then
            dig4.Focus()
        End If
    End Sub

    Private Sub txt4_TextChanged(sender As Object, e As EventArgs) Handles dig4.TextChanged
        If dig4.Text.Length = 1 Then
            btninte.Focus()
        End If
    End Sub

    Private Sub LimpiarTextBoxes()
        dig1.Clear()
        dig2.Clear()
        dig3.Clear()
        dig4.Clear()
        dig1.Focus()
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
