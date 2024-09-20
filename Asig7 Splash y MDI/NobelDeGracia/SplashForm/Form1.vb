Public Class Form1
    Private Sub SplashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga.Start()
    End Sub

    Private Sub Carga_Tick(sender As Object, e As EventArgs) Handles Carga.Tick
        panelCarga.Width += 18

        If panelCarga.Width >= 599 Then
            Carga.Stop()
            Dim mainForm As New Principal()
            mainForm.Show()
            Me.Hide()

        End If
    End Sub


End Class
