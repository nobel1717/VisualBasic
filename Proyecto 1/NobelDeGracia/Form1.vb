Public Class Form1
    Dim alturaDep1 As Integer = 0
    Dim alturaDep2 As Integer = 0
    Dim maxAlturaLogica As Integer = 5000
    Dim maxAlturaVisual As Integer = 230
    Dim alturaTuboVisual As Integer = 120
    Dim alturaTuboLogica As Integer = (alturaTuboVisual / maxAlturaVisual) * maxAlturaLogica
    Dim compuertaAbierta As Boolean = False
    Dim velocidadLlenado As Integer = 50
    Dim vaciando As Boolean = False


    Dim paddingInferiorDep1 As Integer = 118
    Dim paddingInferiorDep2 As Integer = 80
    Dim tuboAnchoFijo As Integer

    Private Sub btnIniciarLlenado_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        TimerVaciado.Stop()
        TimerLlenado.Start()
    End Sub

    Private Sub TimerLlenado_Tick(sender As Object, e As EventArgs) Handles TimerLlenado.Tick
        If alturaDep1 < maxAlturaLogica Then
            alturaDep1 += velocidadLlenado
            If alturaDep1 > maxAlturaLogica Then alturaDep1 = maxAlturaLogica

            Dim alturaVisualDep1 As Integer = (alturaDep1 / maxAlturaLogica) * maxAlturaVisual
            panelDep1.Height = alturaVisualDep1
            panelDep1.Top = panelDep1.Parent.Height - panelDep1.Height - paddingInferiorDep1
            txtAlturaDep1.Text = alturaDep1.ToString()

            If alturaDep1 >= alturaTuboLogica AndAlso Not chkCompuertaCerrada.Checked Then
                TimerCompuerta.Start()
            End If
        Else
            TimerLlenado.Stop()
        End If
    End Sub

    Private Sub chkCompuertaCerrada_CheckedChanged(sender As Object, e As EventArgs) Handles chkCompuertaCerrada.CheckedChanged
        If chkCompuertaCerrada.Checked Then
            TimerCompuerta.Stop()
        ElseIf alturaDep1 >= alturaTuboLogica Then
            TimerCompuerta.Start()
        End If
    End Sub

    Private Sub TimerCompuerta_Tick(sender As Object, e As EventArgs) Handles TimerCompuerta.Tick
        If alturaDep1 >= alturaTuboLogica AndAlso alturaDep2 < maxAlturaLogica AndAlso Not chkCompuertaCerrada.Checked Then
            alturaDep1 -= 25
            alturaDep2 += 25
            If alturaDep1 < 0 Then alturaDep1 = 0
            If alturaDep2 > maxAlturaLogica Then alturaDep2 = maxAlturaLogica

            Dim alturaVisualDep1 As Integer = (alturaDep1 / maxAlturaLogica) * maxAlturaVisual
            panelDep1.Height = alturaVisualDep1
            panelDep1.Top = panelDep1.Parent.Height - panelDep1.Height - paddingInferiorDep1

            Dim alturaVisualDep2 As Integer = (alturaDep2 / maxAlturaLogica) * maxAlturaVisual
            panelDep2.Height = alturaVisualDep2
            panelDep2.Top = panelDep2.Parent.Height - panelDep2.Height - paddingInferiorDep2

            PanelTubo.Visible = True
            PanelTubo.Width = 35
            PanelTubo.Height = 10
            txtAlturaDep1.Text = alturaDep1.ToString()
            txtAlturaDep22.Text = alturaDep2.ToString()
        ElseIf alturaDep2 >= maxAlturaLogica Then
            TimerCompuerta.Stop()
        End If
    End Sub

    Private Sub ScrollBarVelocidad_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrollBarVelocidad.Scroll
        Dim invertedValue As Integer = ScrollBarVelocidad.Maximum - ScrollBarVelocidad.Value + ScrollBarVelocidad.Minimum
        velocidadLlenado = invertedValue
        lblVelocidad.Text = "Velocidad: " & velocidadLlenado.ToString()
    End Sub

    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        TimerLlenado.Stop()
        If alturaDep1 > 0 Or alturaDep2 > 0 Then
            vaciando = True
            TimerVaciado.Start()
        End If
    End Sub

    Private Sub TimerVaciado_Tick(sender As Object, e As EventArgs) Handles TimerVaciado.Tick

        If alturaDep1 > 0 Then
            alturaDep1 -= 25
            If alturaDep1 < 0 Then alturaDep1 = 0

            Dim alturaVisualDep1 As Integer = (alturaDep1 / maxAlturaLogica) * maxAlturaVisual
            panelDep1.Height = alturaVisualDep1
            panelDep1.Top = panelDep1.Parent.Height - panelDep1.Height - paddingInferiorDep1
            txtAlturaDep1.Text = alturaDep1.ToString()
        End If

        If alturaDep2 > 0 Then
            alturaDep2 -= 25
            If alturaDep2 < 0 Then alturaDep2 = 0

            Dim alturaVisualDep2 As Integer = (alturaDep2 / maxAlturaLogica) * maxAlturaVisual
            panelDep2.Height = alturaVisualDep2
            panelDep2.Top = panelDep2.Parent.Height - panelDep2.Height - paddingInferiorDep2
            txtAlturaDep22.Text = alturaDep2.ToString()
        End If

        If alturaDep1 <= alturaTuboLogica AndAlso alturaDep2 <= alturaTuboLogica Then
            PanelTubo.Height = 0
        End If

        If alturaDep1 <= 0 AndAlso alturaDep2 <= 0 Then
            TimerVaciado.Stop()
            vaciando = False
        End If
    End Sub

    Private Sub btnTerminarLlenado_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        TimerLlenado.Stop()
        TimerCompuerta.Stop()
        TimerVaciado.Stop()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.ControlBox = False
        PanelTubo.Visible = False
        ScrollBarVelocidad.Minimum = 0
        ScrollBarVelocidad.Maximum = 100
        ScrollBarVelocidad.Value = 85
    End Sub

End Class
