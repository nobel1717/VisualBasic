Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    ' Opción del menú para abrir el formulario del DataGridView
    Private Sub OpenDataGridViewFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirElFormularioToolStripMenuItem.Click
        Dim dgvForm As New DataGridViewForm
        dgvForm.MdiParent = Me
        dgvForm.Show()
    End Sub

    ' Opción del menú para salir
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub


End Class