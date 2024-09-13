Public Class Form1

    ' Variables globales
    Dim procesos As New List(Of Proceso)
    Dim maxNucleos As Integer = 8
    Dim enEjecucion As Integer = 0
    Dim maxProcesos As Integer = 25
    Dim enPausa As Boolean = False
    Dim rnd As New Random()
    Dim tiempoFinalizado As Integer = 2000 ' Tiempo de 2 segundos para finalización

    ' Tiempos de procesamiento por prioridad
    Dim tiempoProceso As New Dictionary(Of String, Integer) From {
        {"Muy Alta", 250},
        {"Alta", 600},
        {"Media", 1200},
        {"Baja", 2500}
    }

    ' Estructura del Proceso
    Public Class Proceso
        Public Property Nombre As String
        Public Property Prioridad As String
        Public Property Estado As String
        Public Property Subprocesos As Integer
        Public Property SubprocesoActual As Integer
        Public Property TiempoFinalizado As DateTime ' Para controlar el tiempo de eliminación
        Public Property ProgresoActual As Integer

        Public Sub New(nombre As String, prioridad As String, rnd As Random)
            Me.Nombre = nombre
            Me.Prioridad = prioridad
            Me.Estado = "Nuevo"
            Me.Subprocesos = rnd.Next(1, 31) ' Subprocesos aleatorios entre 1 y 30
            Me.SubprocesoActual = 0
            Me.TiempoFinalizado = DateTime.MinValue ' Inicializa a un valor mínimo
        End Sub
    End Class

    ' Cargar Formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPrioridad.Items.Add("Muy Alta")
        cbPrioridad.Items.Add("Alta")
        cbPrioridad.Items.Add("Media")
        cbPrioridad.Items.Add("Baja")

        dgvProcesos.Columns.Clear()
        dgvProcesos.Columns.Add("Nombre", "Nombre del Proceso")
        dgvProcesos.Columns.Add("Prioridad", "Prioridad")
        dgvProcesos.Columns.Add("Estado", "Estado")
        dgvProcesos.Columns.Add("Progreso", "Progreso")

        timerProgreso.Interval = 500 ' Intervalo de 0.5 segundos
        timerProgreso.Enabled = False

        ' Temporizador para eliminar procesos finalizados
        timerEliminar.Interval = 1000 ' 1 segundo
        timerEliminar.Enabled = False
    End Sub

    ' Método para actualizar la vista de procesos
    Private Sub ActualizarVistaProcesos()
        dgvProcesos.Rows.Clear()

        ' Ordenar los procesos por estado
        Dim procesosOrdenados = procesos.OrderBy(Function(p) ObtenerOrdenEstado(p.Estado)).ToList()

        ' Añadir procesos al DataGridView
        For Each proceso In procesosOrdenados
            Dim progresoTexto As String = $"{proceso.ProgresoActual} / {proceso.Subprocesos}"
            Dim rowIndex As Integer = dgvProcesos.Rows.Add(proceso.Nombre, proceso.Prioridad, proceso.Estado, progresoTexto)
            dgvProcesos.Rows(rowIndex).DefaultCellStyle.BackColor = ObtenerColorPorEstado(proceso.Estado)
        Next

        ' Refrescar la interfaz
        dgvProcesos.Refresh()
    End Sub

    Private Function ObtenerOrdenEstado(estado As String) As Integer
        Select Case estado
            Case "Ejecución"
                Return 1
            Case "Espera"
                Return 2
            Case "Listo"
                Return 3
            Case "Bloqueado en Espera"
                Return 4
            Case Else
                Return 5 ' Para los demás estados
        End Select
    End Function

    ' Colores según el estado del proceso
    Private Function ObtenerColorPorEstado(estado As String) As Color
        Select Case estado
            Case "Nuevo"
                Return Color.LightGray
            Case "Listo"
                Return Color.LightBlue
            Case "Ejecución"
                Return Color.LightGreen
            Case "Espera"
                Return Color.Yellow
            Case "Finalizado"
                Return Color.LightCoral
            Case "Zombi"
                Return Color.Red
            Case "Bloqueado en Espera"
                Return Color.Orange
            Case Else
                Return Color.White
        End Select
    End Function

    ' Botón "Crear Proceso"
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        ' Verificar si el número máximo de procesos ha sido alcanzado
        If procesos.Count >= maxProcesos Then
            MessageBox.Show("No se pueden crear más de 25 procesos.")
            Return
        End If

        ' Verificar si se ha seleccionado una prioridad
        If cbPrioridad.SelectedItem Is Nothing Then
            MessageBox.Show("Debe seleccionar una prioridad antes de crear un proceso.")
            Return
        End If

        ' Generar proceso de manera única y segura
        Dim nombre As String = "Proceso " & (procesos.Count + 1).ToString()
        Dim prioridad As String = cbPrioridad.SelectedItem.ToString()

        Dim nuevoProceso As New Proceso(nombre, prioridad, rnd)
        procesos.Add(nuevoProceso)

        ' Actualizar la vista después de añadir el proceso
        ActualizarVistaProcesos()
    End Sub

    ' Botón "Start" para iniciar el temporizador
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        enPausa = False
        timerProgreso.Start() ' Inicia el temporizador
    End Sub

    ' Botón "Stop" para detener el temporizador
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        enPausa = True
        timerProgreso.Stop() ' Detiene el temporizador
    End Sub

    ' Botón "Automatizar" - ejecuta todos los procesos en estado "Listo"
    Private Sub btnAutomatizar_Click(sender As Object, e As EventArgs) Handles btnAutomatizar.Click
        Dim procesosListos = procesos.Where(Function(p) p.Estado = "Listo").OrderBy(Function(p) ObtenerPrioridadNumerica(p.Prioridad)).ToList()

        ' Ejecutar procesos hasta que se ocupen todos los núcleos
        For Each proc In procesosListos
            If enEjecucion < maxNucleos Then
                proc.Estado = "Ejecución"
                enEjecucion += 1
            Else
                proc.Estado = "Espera"
            End If
        Next

        ActualizarVistaProcesos()
        timerProgreso.Start() ' Iniciar el temporizador para la ejecución de procesos
    End Sub

    Private Sub timerProgreso_Tick(sender As Object, e As EventArgs) Handles timerProgreso.Tick
        If enPausa Then Return

        ' Procesar cada proceso en ejecución
        For Each proc In procesos.Where(Function(p) p.Estado = "Ejecución").ToList()
            ' Incrementar el progreso del proceso basado en su prioridad
            Dim incrementoProgreso As Integer = 1 ' Ajuste del incremento básico
            proc.ProgresoActual += incrementoProgreso

            ' Verificar si el proceso ha completado su ejecución
            If proc.ProgresoActual >= proc.Subprocesos Then
                ' Determinar si el proceso se convierte en zombi o finalizado
                If rnd.NextDouble() <= 0.08 Then
                    proc.Estado = "Zombi"
                Else
                    proc.Estado = "Finalizado"
                    proc.TiempoFinalizado = DateTime.Now ' Marca el tiempo de finalización
                End If
                enEjecucion -= 1
            End If
        Next

        ' Actualizar la vista de los procesos
        ActualizarVistaProcesos()

        ' Gestionar procesos en espera si hay núcleos disponibles
        GestionarProcesosEnEspera()

        ' Verificar si el temporizador de eliminación debe iniciarse
        If Not timerEliminar.Enabled Then
            timerEliminar.Start()
        End If
    End Sub

    Private Sub GestionarProcesosEnEspera()
        Dim procesosEnEspera = procesos.Where(Function(p) p.Estado = "Espera").ToList()

        For Each proc In procesosEnEspera
            If enEjecucion < maxNucleos Then
                proc.Estado = "Ejecución"
                enEjecucion += 1
            Else
                Exit For
            End If
        Next
        ActualizarVistaProcesos()
    End Sub

    ' Botón "Listo"
    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        For Each filaSeleccionada As DataGridViewRow In dgvProcesos.SelectedRows
            Dim nombreProceso As String = filaSeleccionada.Cells(0).Value.ToString()
            Dim proc = procesos.FirstOrDefault(Function(p) p.Nombre = nombreProceso)
            If proc IsNot Nothing AndAlso proc.Estado = "Nuevo" Then
                proc.Estado = "Listo"
            End If
        Next
        ActualizarVistaProcesos()
    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        ' Ejecuta solo los procesos seleccionados
        For Each filaSeleccionada As DataGridViewRow In dgvProcesos.SelectedRows
            Dim nombreProceso As String = filaSeleccionada.Cells(0).Value.ToString()
            Dim proc = procesos.FirstOrDefault(Function(p) p.Nombre = nombreProceso)
            If proc IsNot Nothing AndAlso proc.Estado = "Listo" Then
                If enEjecucion < maxNucleos Then
                    proc.Estado = "Ejecución"
                    enEjecucion += 1
                Else
                    proc.Estado = "Espera"
                End If
            End If
        Next
        ActualizarVistaProcesos()
        timerProgreso.Start() ' Inicia el temporizador para la ejecución de procesos
    End Sub

    ' Botón "Finalizar"
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        For Each filaSeleccionada As DataGridViewRow In dgvProcesos.SelectedRows
            Dim nombreProceso As String = filaSeleccionada.Cells(0).Value.ToString()
            Dim proc = procesos.FirstOrDefault(Function(p) p.Nombre = nombreProceso)
            If proc IsNot Nothing AndAlso proc.Estado = "Ejecución" Then
                proc.Estado = "Finalizado"
                proc.TiempoFinalizado = DateTime.Now
                enEjecucion -= 1
            End If
        Next
        ActualizarVistaProcesos()
    End Sub

    ' Temporizador para eliminar procesos finalizados
    Private Sub timerEliminar_Tick(sender As Object, e As EventArgs) Handles timerEliminar.Tick
        ' Eliminar procesos finalizados después de 2 segundos
        Dim ahora As DateTime = DateTime.Now
        For Each proc In procesos.Where(Function(p) p.Estado = "Finalizado" AndAlso ahora.Subtract(p.TiempoFinalizado).TotalMilliseconds >= tiempoFinalizado).ToList()
            procesos.Remove(proc)
        Next
        ActualizarVistaProcesos()

        ' Detener el temporizador si no hay procesos finalizados pendientes
        If Not procesos.Any(Function(p) p.Estado = "Finalizado") Then
            timerEliminar.Stop()
        End If
    End Sub

    ' Obtener el valor numérico de la prioridad
    Private Function ObtenerPrioridadNumerica(prioridad As String) As Integer
        Select Case prioridad
            Case "Muy Alta"
                Return 1
            Case "Alta"
                Return 2
            Case "Media"
                Return 3
            Case "Baja"
                Return 4
            Case Else
                Return 5
        End Select
    End Function

    ' Botón "Desbloquear"
    Private Sub btnDesbloquear_Click(sender As Object, e As EventArgs) Handles btnDesbloquear.Click
        For Each filaSeleccionada As DataGridViewRow In dgvProcesos.SelectedRows
            Dim nombreProceso As String = filaSeleccionada.Cells(0).Value.ToString()
            Dim proc = procesos.FirstOrDefault(Function(p) p.Nombre = nombreProceso)
            If proc IsNot Nothing AndAlso proc.Estado = "Bloqueado en Espera" Then
                proc.Estado = "Listo"
            End If
        Next
        ActualizarVistaProcesos()
    End Sub

    ' Botón "Kill"
    Private Sub btnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
        For Each filaSeleccionada As DataGridViewRow In dgvProcesos.SelectedRows
            Dim nombreProceso As String = filaSeleccionada.Cells(0).Value.ToString()
            Dim proc = procesos.FirstOrDefault(Function(p) p.Nombre = nombreProceso)
            If proc IsNot Nothing Then
                procesos.Remove(proc)
            End If
        Next
        ActualizarVistaProcesos()
    End Sub

    ' Botón "Bloquear"
    Private Sub btnBloquear_Click(sender As Object, e As EventArgs) Handles btnBloquear.Click
        For Each filaSeleccionada As DataGridViewRow In dgvProcesos.SelectedRows
            Dim nombreProceso = filaSeleccionada.Cells(0).Value.ToString
            Dim proc = procesos.FirstOrDefault(Function(p) p.Nombre = nombreProceso)
            If proc IsNot Nothing AndAlso proc.Estado = "Ejecución" Then
                proc.Estado = "Bloqueado en Espera"
                enEjecucion -= 1
            End If
        Next
        ActualizarVistaProcesos()
    End Sub
End Class