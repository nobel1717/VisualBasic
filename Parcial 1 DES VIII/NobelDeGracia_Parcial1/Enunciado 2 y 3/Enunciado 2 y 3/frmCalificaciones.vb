Public Class frmCalificaciones
    Private estudianteNumero As Integer = 1

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtCedula.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtParcial1.Text = "" Or txtParcial2.Text = "" Or txtParcial3.Text = "" Or txtExFinal.Text = "" Then
            MessageBox.Show("Por favor, rellene todos los campos.")
            Exit Sub
        End If

        Dim parcial1, parcial2, parcial3, examenFinal As Double
        If Not Double.TryParse(txtParcial1.Text, parcial1) Or parcial1 < 0 Or parcial1 > 100 Then
            MessageBox.Show("Ingrese un valor válido para Parcial 1 (0 - 100).")
            Exit Sub
        End If
        If Not Double.TryParse(txtParcial2.Text, parcial2) Or parcial2 < 0 Or parcial2 > 100 Then
            MessageBox.Show("Ingrese un valor válido para Parcial 2 (0 - 100).")
            Exit Sub
        End If
        If Not Double.TryParse(txtParcial3.Text, parcial3) Or parcial3 < 0 Or parcial3 > 100 Then
            MessageBox.Show("Ingrese un valor válido para Parcial 3 (0 - 100).")
            Exit Sub
        End If
        If Not Double.TryParse(txtExFinal.Text, examenFinal) Or examenFinal < 0 Or examenFinal > 100 Then
            MessageBox.Show("Ingrese un valor válido para Examen Final (0 - 100).")
            Exit Sub
        End If

        Dim promedioParciales As Double = (parcial1 + parcial2 + parcial3) / 3
        Dim calificacionFinal As Double = (promedioParciales * 0.6) + (examenFinal * 0.4)

        Dim calificacionLetra As String = ""
        Select Case calificacionFinal
            Case >= 90.6
                calificacionLetra = "A"
            Case >= 80.6
                calificacionLetra = "B"
            Case >= 70.6
                calificacionLetra = "C"
            Case >= 60.6
                calificacionLetra = "D"
            Case Else
                calificacionLetra = "F"
        End Select

        dgvEstudiantes.Rows.Add(estudianteNumero, txtCedula.Text, txtApellido.Text, txtNombre.Text, parcial1, parcial2, parcial3, promedioParciales.ToString("F2"), examenFinal, calificacionLetra)

        estudianteNumero += 1

        LimpiarCampos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtCedula.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtParcial1.Clear()
        txtParcial2.Clear()
        txtParcial3.Clear()
        txtExFinal.Clear()
    End Sub

    Private Sub frmCalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEstudiantes.Columns.Clear()

        dgvEstudiantes.Columns.Add("No", "No.")
        dgvEstudiantes.Columns.Add("Cedula", "Cédula")
        dgvEstudiantes.Columns.Add("Apellido", "Apellido")
        dgvEstudiantes.Columns.Add("Nombre", "Nombre")
        dgvEstudiantes.Columns.Add("Parcial1", "Parcial 1")
        dgvEstudiantes.Columns.Add("Parcial2", "Parcial 2")
        dgvEstudiantes.Columns.Add("Parcial3", "Parcial 3")
        dgvEstudiantes.Columns.Add("PromParciales", "Prom. Parciales")
        dgvEstudiantes.Columns.Add("ExamenFinal", "Ex. Final")
        dgvEstudiantes.Columns.Add("CalFinal", "Cal. Final")

        dgvEstudiantes.Columns("No").Width = 50
        dgvEstudiantes.Columns("Cedula").Width = 100
        dgvEstudiantes.Columns("Apellido").Width = 120
        dgvEstudiantes.Columns("Nombre").Width = 120
        dgvEstudiantes.Columns("Parcial1").Width = 70
        dgvEstudiantes.Columns("Parcial2").Width = 70
        dgvEstudiantes.Columns("Parcial3").Width = 70
        dgvEstudiantes.Columns("PromParciales").Width = 100
        dgvEstudiantes.Columns("ExamenFinal").Width = 70
        dgvEstudiantes.Columns("CalFinal").Width = 70
    End Sub


End Class