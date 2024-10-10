Public Class frmAhorros
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lstMeses.Items.Clear()
        txtAhorroTotal.Clear()

        Dim ahorroMensual As Double = 3
        Dim ahorroTotal As Double = 0

        For mes As Integer = 1 To 12
            lstMeses.Items.Add("Mes " & mes & ": $" & ahorroMensual.ToString("F2"))
            ahorroTotal += ahorroMensual
            ahorroMensual *= 3
        Next
        txtAhorroTotal.Text = "Total Ahorro: $" & ahorroTotal.ToString("F2")
    End Sub
End Class
