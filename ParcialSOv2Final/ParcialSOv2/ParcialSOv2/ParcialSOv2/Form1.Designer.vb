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
        components = New ComponentModel.Container()
        dgvProcesos = New DataGridView()
        btnCrear = New Button()
        btnListo = New Button()
        btnEjecutar = New Button()
        btnBloquear = New Button()
        btnAutomatizar = New Button()
        cbPrioridad = New ComboBox()
        timerProgreso = New Timer(components)
        timerEliminar = New Timer(components)
        btnStart = New Button()
        btnStop = New Button()
        btnFinalizar = New Button()
        btnKill = New Button()
        btnDesbloquear = New Button()
        CType(dgvProcesos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProcesos
        ' 
        dgvProcesos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProcesos.BackgroundColor = SystemColors.ControlDarkDark
        dgvProcesos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProcesos.Location = New Point(30, 110)
        dgvProcesos.Name = "dgvProcesos"
        dgvProcesos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProcesos.Size = New Size(689, 415)
        dgvProcesos.TabIndex = 0
        ' 
        ' btnCrear
        ' 
        btnCrear.BackColor = SystemColors.HotTrack
        btnCrear.Cursor = Cursors.Hand
        btnCrear.FlatStyle = FlatStyle.Flat
        btnCrear.Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCrear.ForeColor = SystemColors.ControlText
        btnCrear.Location = New Point(194, 26)
        btnCrear.Name = "btnCrear"
        btnCrear.Size = New Size(86, 23)
        btnCrear.TabIndex = 1
        btnCrear.Text = "Crear"
        btnCrear.UseVisualStyleBackColor = False
        ' 
        ' btnListo
        ' 
        btnListo.BackColor = SystemColors.ControlLight
        btnListo.Cursor = Cursors.Hand
        btnListo.Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnListo.Location = New Point(744, 133)
        btnListo.Name = "btnListo"
        btnListo.Size = New Size(149, 23)
        btnListo.TabIndex = 2
        btnListo.Text = "Listo ✅"
        btnListo.UseVisualStyleBackColor = False
        ' 
        ' btnEjecutar
        ' 
        btnEjecutar.BackColor = SystemColors.ControlLight
        btnEjecutar.Cursor = Cursors.Hand
        btnEjecutar.Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEjecutar.Location = New Point(744, 162)
        btnEjecutar.Name = "btnEjecutar"
        btnEjecutar.Size = New Size(149, 23)
        btnEjecutar.TabIndex = 3
        btnEjecutar.Text = "Ejecutar"
        btnEjecutar.UseVisualStyleBackColor = False
        ' 
        ' btnBloquear
        ' 
        btnBloquear.BackColor = SystemColors.ControlLight
        btnBloquear.Cursor = Cursors.Hand
        btnBloquear.Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBloquear.Location = New Point(744, 213)
        btnBloquear.Name = "btnBloquear"
        btnBloquear.Size = New Size(149, 23)
        btnBloquear.TabIndex = 4
        btnBloquear.Text = "Bloquear 🔒"
        btnBloquear.UseVisualStyleBackColor = False
        ' 
        ' btnAutomatizar
        ' 
        btnAutomatizar.BackColor = SystemColors.ControlLight
        btnAutomatizar.Cursor = Cursors.Hand
        btnAutomatizar.FlatStyle = FlatStyle.Flat
        btnAutomatizar.Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAutomatizar.Location = New Point(279, 66)
        btnAutomatizar.Name = "btnAutomatizar"
        btnAutomatizar.Size = New Size(129, 23)
        btnAutomatizar.TabIndex = 6
        btnAutomatizar.Text = "Automatizar"
        btnAutomatizar.UseVisualStyleBackColor = False
        ' 
        ' cbPrioridad
        ' 
        cbPrioridad.FlatStyle = FlatStyle.Popup
        cbPrioridad.Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbPrioridad.FormattingEnabled = True
        cbPrioridad.Location = New Point(30, 26)
        cbPrioridad.Name = "cbPrioridad"
        cbPrioridad.Size = New Size(138, 23)
        cbPrioridad.TabIndex = 8
        ' 
        ' timerProgreso
        ' 
        ' 
        ' timerEliminar
        ' 
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.ForestGreen
        btnStart.Cursor = Cursors.Hand
        btnStart.FlatStyle = FlatStyle.Popup
        btnStart.Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.ForeColor = SystemColors.HighlightText
        btnStart.Location = New Point(30, 66)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(86, 23)
        btnStart.TabIndex = 9
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnStop
        ' 
        btnStop.BackColor = Color.OrangeRed
        btnStop.Cursor = Cursors.Hand
        btnStop.FlatStyle = FlatStyle.Popup
        btnStop.Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStop.ForeColor = SystemColors.HighlightText
        btnStop.Location = New Point(150, 66)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(86, 23)
        btnStop.TabIndex = 10
        btnStop.Text = "Stop"
        btnStop.UseVisualStyleBackColor = False
        ' 
        ' btnFinalizar
        ' 
        btnFinalizar.BackColor = SystemColors.ControlLight
        btnFinalizar.Cursor = Cursors.Hand
        btnFinalizar.Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFinalizar.Location = New Point(744, 301)
        btnFinalizar.Name = "btnFinalizar"
        btnFinalizar.Size = New Size(149, 23)
        btnFinalizar.TabIndex = 11
        btnFinalizar.Text = "Finalizar"
        btnFinalizar.UseVisualStyleBackColor = False
        ' 
        ' btnKill
        ' 
        btnKill.BackColor = SystemColors.ControlLight
        btnKill.Cursor = Cursors.Hand
        btnKill.Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKill.Location = New Point(744, 330)
        btnKill.Name = "btnKill"
        btnKill.Size = New Size(149, 23)
        btnKill.TabIndex = 13
        btnKill.Text = "Kill 💀"
        btnKill.UseVisualStyleBackColor = False
        ' 
        ' btnDesbloquear
        ' 
        btnDesbloquear.BackColor = SystemColors.ControlLight
        btnDesbloquear.Cursor = Cursors.Hand
        btnDesbloquear.Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDesbloquear.Location = New Point(744, 242)
        btnDesbloquear.Name = "btnDesbloquear"
        btnDesbloquear.Size = New Size(149, 23)
        btnDesbloquear.TabIndex = 14
        btnDesbloquear.Text = "Desbloquear 🔓"
        btnDesbloquear.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(914, 550)
        Controls.Add(btnDesbloquear)
        Controls.Add(btnKill)
        Controls.Add(btnFinalizar)
        Controls.Add(btnStop)
        Controls.Add(btnStart)
        Controls.Add(cbPrioridad)
        Controls.Add(btnAutomatizar)
        Controls.Add(btnBloquear)
        Controls.Add(btnEjecutar)
        Controls.Add(btnListo)
        Controls.Add(btnCrear)
        Controls.Add(dgvProcesos)
        Font = New Font("Lucida Sans Typewriter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        Text = "Form1"
        CType(dgvProcesos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvProcesos As DataGridView
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnListo As Button
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents btnBloquear As Button
    Friend WithEvents btnAutomatizar As Button
    Friend WithEvents cbPrioridad As ComboBox
    Friend WithEvents timerProgreso As Timer
    Friend WithEvents timerEliminar As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btnZombie_CheckedChanged As CheckBox
    Friend WithEvents btnKill As Button
    Friend WithEvents btnDesbloquear As Button

End Class
