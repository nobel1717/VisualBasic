Public Class Form1
    ' Variables para los niveles de líquido en los depósitos
    Dim alturaDep1 As Integer = 0
    Dim alturaDep2 As Integer = 0
    ' Velocidad de llenado
    Dim velocidadLlenado As Integer = 1
    ' Timer para controlar el llenado y vaciado
    Dim WithEvents timerLlenado As New Timer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar valores del Timer
        timerLlenado.Interval = 100
        hScrollBarVelocidad.Minimum = 1
        hScrollBarVelocidad.Maximum = 100
        txtAlturaDep1.Text = alturaDep1.ToString()
        txtAlturaDep22.Text = alturaDep2.ToString()
    End Sub

    ' Controlar el llenado
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        timerLlenado.Start()
    End Sub

    ' Detener el llenado
    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        timerLlenado.Stop()
    End Sub

    ' Salir de la aplicación
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    ' Controlar la velocidad de llenado
    Private Sub hScrollBarVelocidad_Scroll(sender As Object, e As ScrollEventArgs) Handles hScrollBarVelocidad.Scroll
        velocidadLlenado = hScrollBarVelocidad.Value
    End Sub

    ' Evento del Timer para simular el llenado
    Private Sub timerLlenado_Tick(sender As Object, e As EventArgs) Handles timerLlenado.Tick
        ' Llenado del primer depósito
        If alturaDep1 < 5000 Then
            alturaDep1 += velocidadLlenado
            txtAlturaDep1.Text = alturaDep1.ToString()
            pictureBoxDep1.Height += velocidadLlenado
        End If

        ' Simulación de transferencia de líquido entre depósitos cuando la altura alcanza la tubería
        If alturaDep1 >= 3000 Then ' Altura de la tubería
            If alturaDep1 > 0 Then
                alturaDep1 -= velocidadLlenado
                alturaDep2 += velocidadLlenado
                txtAlturaDep1.Text = alturaDep1.ToString()
                txtAlturaDep22.Text = alturaDep2.ToString()
                pictureBoxDep1.Height -= velocidadLlenado
                pictureBoxDep2.Height += velocidadLlenado
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
