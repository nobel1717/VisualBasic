<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvProcesos = New DataGridView()
        btnCrearProceso = New Button()
        btnAsignarListo = New Button()
        btnAsignarEjecucion = New Button()
        btnAsignarBloqueado = New Button()
        btnAsignarFinalizado = New Button()
        btnAutomatizar = New Button()
        CType(dgvProcesos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProcesos
        ' 
        dgvProcesos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProcesos.Location = New Point(182, 26)
        dgvProcesos.Name = "dgvProcesos"
        dgvProcesos.Size = New Size(436, 199)
        dgvProcesos.TabIndex = 0
        ' 
        ' btnCrearProceso
        ' 
        btnCrearProceso.Location = New Point(224, 264)
        btnCrearProceso.Name = "btnCrearProceso"
        btnCrearProceso.Size = New Size(75, 23)
        btnCrearProceso.TabIndex = 1
        btnCrearProceso.Text = "Crear Proceso"
        btnCrearProceso.UseVisualStyleBackColor = True
        ' 
        ' btnAsignarListo
        ' 
        btnAsignarListo.Location = New Point(380, 264)
        btnAsignarListo.Name = "btnAsignarListo"
        btnAsignarListo.Size = New Size(118, 23)
        btnAsignarListo.TabIndex = 2
        btnAsignarListo.Text = "Asignar Listo"
        btnAsignarListo.UseVisualStyleBackColor = True
        ' 
        ' btnAsignarEjecucion
        ' 
        btnAsignarEjecucion.Location = New Point(380, 293)
        btnAsignarEjecucion.Name = "btnAsignarEjecucion"
        btnAsignarEjecucion.Size = New Size(118, 23)
        btnAsignarEjecucion.TabIndex = 3
        btnAsignarEjecucion.Text = "Asignar Ejecución"
        btnAsignarEjecucion.UseVisualStyleBackColor = True
        ' 
        ' btnAsignarBloqueado
        ' 
        btnAsignarBloqueado.Location = New Point(380, 322)
        btnAsignarBloqueado.Name = "btnAsignarBloqueado"
        btnAsignarBloqueado.Size = New Size(118, 23)
        btnAsignarBloqueado.TabIndex = 4
        btnAsignarBloqueado.Text = "Asignar Bloqueado"
        btnAsignarBloqueado.UseVisualStyleBackColor = True
        ' 
        ' btnAsignarFinalizado
        ' 
        btnAsignarFinalizado.Location = New Point(380, 351)
        btnAsignarFinalizado.Name = "btnAsignarFinalizado"
        btnAsignarFinalizado.Size = New Size(118, 23)
        btnAsignarFinalizado.TabIndex = 5
        btnAsignarFinalizado.Text = "Asignar Finalizado"
        btnAsignarFinalizado.UseVisualStyleBackColor = True
        ' 
        ' btnAutomatizar
        ' 
        btnAutomatizar.Location = New Point(224, 351)
        btnAutomatizar.Name = "btnAutomatizar"
        btnAutomatizar.Size = New Size(101, 23)
        btnAutomatizar.TabIndex = 6
        btnAutomatizar.Text = "Automatizar"
        btnAutomatizar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAutomatizar)
        Controls.Add(btnAsignarFinalizado)
        Controls.Add(btnAsignarBloqueado)
        Controls.Add(btnAsignarEjecucion)
        Controls.Add(btnAsignarListo)
        Controls.Add(btnCrearProceso)
        Controls.Add(dgvProcesos)
        Name = "Form1"
        Text = "Parcial1"
        CType(dgvProcesos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvProcesos As DataGridView
    Friend WithEvents btnCrearProceso As Button
    Friend WithEvents btnAsignarListo As Button
    Friend WithEvents btnAsignarEjecucion As Button
    Friend WithEvents btnAsignarBloqueado As Button
    Friend WithEvents btnAsignarFinalizado As Button
    Friend WithEvents btnAutomatizar As Button

End Class
