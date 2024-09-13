Public Class Form1
    Dim procesoID As Integer = 0
    Dim maxProcesos As Integer = 20
    Dim maxProcesosEjecucion As Integer = 8
    Dim WithEvents timerAutomatizacion As New Timer
    Dim WithEvents timerEliminar As New Timer
    Dim prioridad As String() = {"Alta", "Media", "Baja"}
    Dim random As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvProcesos.ColumnCount = 3
        dgvProcesos.Columns(0).Name = "ID"
        dgvProcesos.Columns(1).Name = "Estado"
        dgvProcesos.Columns(2).Name = "Prioridad"
        dgvProcesos.Columns(0).Width = 100
        dgvProcesos.Columns(1).Width = 150
        dgvProcesos.Columns(2).Width = 100

        timerAutomatizacion.Interval = 1000
        timerEliminar.Interval = 1000
    End Sub

    ' Crear un nuevo proceso
    Private Sub btnCrearProceso_Click(sender As Object, e As EventArgs) Handles btnCrearProceso.Click
        If dgvProcesos.Rows.Count < maxProcesos Then
            procesoID += 1
            Dim fila As String() = New String() {procesoID.ToString(), "Nuevo", prioridad(procesoID Mod 3)}
            dgvProcesos.Rows.Add(fila)
            ActualizarColores()
        Else
            MessageBox.Show("Has alcanzado el máximo de 20 procesos.", "Límite de Procesos")
        End If
    End Sub

    ' Estado "Listo"
    Private Sub btnAsignarListo_Click(sender As Object, e As EventArgs) Handles btnAsignarListo.Click
        CambiarEstado("Nuevo", "Listo")
    End Sub

    ' Estado "Ejecución"
    Private Sub btnAsignarEjecucion_Click(sender As Object, e As EventArgs) Handles btnAsignarEjecucion.Click
        If ContarProcesosEnEjecucion() < maxProcesosEjecucion Then
            CambiarEstado("Listo", "Ejecución")
        Else
            MessageBox.Show("Ya hay 8 procesos en ejecución.", "Límite de Procesos en Ejecución")
        End If
    End Sub

    ' Estado "Bloqueado"
    Private Sub btnAsignarBloqueado_Click(sender As Object, e As EventArgs) Handles btnAsignarBloqueado.Click
        CambiarEstado("Ejecución", "Bloqueado")
    End Sub

    ' Estado "Finalizado"
    Private Sub btnAsignarFinalizado_Click(sender As Object, e As EventArgs) Handles btnAsignarFinalizado.Click
        If dgvProcesos.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = dgvProcesos.SelectedRows(0)
            Dim probabilidad As Integer = random.Next(0, 100)

            If probabilidad < 20 Then ' 20% de probabilidad de cambiar a "Zombi"
                filaSeleccionada.Cells(1).Value = "Zombi"
            Else
                filaSeleccionada.Cells(1).Value = "Finalizado"
                timerEliminar.Start() ' Inicia el temporizador para eliminar la fila después de 1 segundo
            End If
            ActualizarColores()
        Else
            MessageBox.Show("Selecciona un proceso.", "Advertencia")
        End If
    End Sub

    ' Cambiar el estado del proceso seleccionado
    Private Sub CambiarEstado(estadoActual As String, nuevoEstado As String)
        If dgvProcesos.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = dgvProcesos.SelectedRows(0)
            If filaSeleccionada.Cells(1).Value = estadoActual Then
                filaSeleccionada.Cells(1).Value = nuevoEstado
                ActualizarColores()
            Else
                MessageBox.Show($"El proceso no está en estado '{estadoActual}'.", "Error")
            End If
        Else
            MessageBox.Show("Selecciona un proceso.", "Advertencia")
        End If
    End Sub

    ' Temporizador para eliminar el proceso finalizado
    Private Sub timerEliminar_Tick(sender As Object, e As EventArgs) Handles timerEliminar.Tick
        For Each fila As DataGridViewRow In dgvProcesos.Rows
            If fila.Cells(1).Value = "Finalizado" Then
                dgvProcesos.Rows.Remove(fila)
                Exit For
            End If
        Next
        timerEliminar.Stop() ' Detiene el temporizador después de eliminar la fila
    End Sub

    ' Actualizar los colores según el estado
    Private Sub ActualizarColores()
        For Each fila As DataGridViewRow In dgvProcesos.Rows
            Select Case fila.Cells(1).Value
                Case "Nuevo"
                    fila.DefaultCellStyle.BackColor = Color.LightBlue
                Case "Listo"
                    fila.DefaultCellStyle.BackColor = Color.LightGreen
                Case "Ejecución"
                    fila.DefaultCellStyle.BackColor = Color.LightYellow
                Case "Bloqueado"
                    fila.DefaultCellStyle.BackColor = Color.Orange
                Case "Finalizado"
                    fila.DefaultCellStyle.BackColor = Color.LightGray
                Case "Zombi"
                    fila.DefaultCellStyle.BackColor = Color.Red
            End Select
        Next
    End Sub

    ' Automatización del ciclo completo de los procesos
    Private Sub btnAutomatizar_Click(sender As Object, e As EventArgs) Handles btnAutomatizar.Click
        If dgvProcesos.Rows.Count > 0 Then
            timerAutomatizacion.Start()
        Else
            MessageBox.Show("No hay procesos para automatizar.", "Error")
        End If
    End Sub

    Private Sub timerAutomatizacion_Tick(sender As Object, e As EventArgs) Handles timerAutomatizacion.Tick
        For Each fila As DataGridViewRow In dgvProcesos.Rows
            Select Case fila.Cells(1).Value
                Case "Nuevo"
                    fila.Cells(1).Value = "Listo"
                    timerAutomatizacion.Interval = random.Next(1000, 3000) ' Generar un tiempo aleatorio entre 1s y 3s
                Case "Listo"
                    If ContarProcesosEnEjecucion() < maxProcesosEjecucion Then
                        fila.Cells(1).Value = "Ejecución"
                        timerAutomatizacion.Interval = random.Next(1000, 3000) ' Generar un tiempo aleatorio entre 1s y 3s
                    End If
                Case "Ejecución"
                    Dim probabilidad As Integer = random.Next(0, 100)
                    If probabilidad < 20 Then ' 20% de probabilidad de cambiar a "Zombi"
                        fila.Cells(1).Value = "Zombi"
                    Else
                        fila.Cells(1).Value = "Finalizado"
                        timerEliminar.Start() ' Inicia el temporizador para eliminar la fila después de 1 segundo
                    End If
                    timerAutomatizacion.Interval = 1000 ' El estado "Finalizado" siempre dura 1 segundo
            End Select
        Next
        ActualizarColores()
    End Sub

    ' Función para contar los procesos en estado "Ejecución"
    Private Function ContarProcesosEnEjecucion() As Integer
        Dim count As Integer = 0
        For Each fila As DataGridViewRow In dgvProcesos.Rows
            If fila.Cells(1).Value = "Ejecución" Then
                count += 1
            End If
        Next
        Return count
    End Function
End Class