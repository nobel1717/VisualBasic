<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalificaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        txtApellido = New TextBox()
        txtNombre = New TextBox()
        txtCedula = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        GroupBox2 = New GroupBox()
        btnRegistrar = New Button()
        Label7 = New Label()
        txtExFinal = New TextBox()
        txtParcial3 = New TextBox()
        txtParcial2 = New TextBox()
        txtParcial1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnNuevo = New Button()
        dgvEstudiantes = New DataGridView()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvEstudiantes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtApellido)
        GroupBox1.Controls.Add(txtNombre)
        GroupBox1.Controls.Add(txtCedula)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(102, 64)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(203, 131)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos Generales"
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(85, 91)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(100, 23)
        txtApellido.TabIndex = 5
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(85, 56)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 4
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(85, 19)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(100, 23)
        txtCedula.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 99)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 15)
        Label6.TabIndex = 2
        Label6.Text = "APELLIDO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 15)
        Label5.TabIndex = 1
        Label5.Text = "NOMBRE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 0
        Label4.Text = "CÉDULA"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnRegistrar)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(txtExFinal)
        GroupBox2.Controls.Add(txtParcial3)
        GroupBox2.Controls.Add(txtParcial2)
        GroupBox2.Controls.Add(txtParcial1)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(375, 64)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(281, 131)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Notas de Exámenes"
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(155, 63)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(86, 43)
        btnRegistrar.TabIndex = 10
        btnRegistrar.Text = "Registrar en Grid"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(148, 22)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 15)
        Label7.TabIndex = 9
        Label7.Text = "Ex. Final"
        ' 
        ' txtExFinal
        ' 
        txtExFinal.Location = New Point(204, 19)
        txtExFinal.Name = "txtExFinal"
        txtExFinal.Size = New Size(37, 23)
        txtExFinal.TabIndex = 8
        ' 
        ' txtParcial3
        ' 
        txtParcial3.Location = New Point(60, 88)
        txtParcial3.Name = "txtParcial3"
        txtParcial3.Size = New Size(37, 23)
        txtParcial3.TabIndex = 7
        ' 
        ' txtParcial2
        ' 
        txtParcial2.Location = New Point(60, 56)
        txtParcial2.Name = "txtParcial2"
        txtParcial2.Size = New Size(37, 23)
        txtParcial2.TabIndex = 6
        ' 
        ' txtParcial1
        ' 
        txtParcial1.Location = New Point(60, 19)
        txtParcial1.Name = "txtParcial1"
        txtParcial1.Size = New Size(37, 23)
        txtParcial1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 2
        Label3.Text = "Parcial 3"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "Parcial 2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 0
        Label1.Text = "Parcial 1"
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(684, 107)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(79, 47)
        btnNuevo.TabIndex = 2
        btnNuevo.Text = "Nuevo Estudiante"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' dgvEstudiantes
        ' 
        dgvEstudiantes.AllowUserToAddRows = False
        dgvEstudiantes.AllowUserToDeleteRows = False
        dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEstudiantes.Location = New Point(12, 201)
        dgvEstudiantes.Name = "dgvEstudiantes"
        dgvEstudiantes.ReadOnly = True
        dgvEstudiantes.Size = New Size(913, 216)
        dgvEstudiantes.TabIndex = 3
        ' 
        ' frmCalificaciones
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(937, 450)
        Controls.Add(dgvEstudiantes)
        Controls.Add(btnNuevo)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frmCalificaciones"
        Text = "frmCalificaciones"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvEstudiantes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtExFinal As TextBox
    Friend WithEvents txtParcial3 As TextBox
    Friend WithEvents txtParcial2 As TextBox
    Friend WithEvents txtParcial1 As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgvEstudiantes As DataGridView
End Class
