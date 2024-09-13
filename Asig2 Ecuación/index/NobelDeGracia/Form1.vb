Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            ' Recoger los valores de las cajas de texto
            Dim y As Double = Convert.ToDouble(txtY.Text)
            Dim q As Double = Convert.ToDouble(txtQ.Text)
            Dim g As Double = 9.81

            Dim resultado As Double = y + (q ^ 2) / (2 * g * y ^ 2)

            txtResultado.Text = "Resultado: " + resultado.ToString("F2")
        Catch ex As Exception
            MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error de entrada")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles txtResultado.Click

    End Sub
End Class
