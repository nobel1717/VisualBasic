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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtEdad = New TextBox()
        txtCorreo = New TextBox()
        Label6 = New Label()
        btnConsultar = New Button()
        txtCedula = New TextBox()
        Label7 = New Label()
        btnAgregar = New Button()
        btnActualizar = New Button()
        btnEliminar = New Button()
        Label4 = New Label()
        btnIrForm2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(243, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 18)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(416, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 18)
        Label2.TabIndex = 1
        Label2.Text = "Apellido"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(416, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 18)
        Label3.TabIndex = 2
        Label3.Text = "Edad"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(243, 197)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 18)
        Label5.TabIndex = 4
        Label5.Text = "Correo"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(243, 162)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(150, 23)
        txtNombre.TabIndex = 5
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(416, 162)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(126, 23)
        txtApellido.TabIndex = 6
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(416, 111)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(46, 23)
        txtEdad.TabIndex = 7
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(243, 215)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(299, 23)
        txtCorreo.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(243, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(310, 30)
        Label6.TabIndex = 10
        Label6.Text = "Formulario de Clientes"
        ' 
        ' btnConsultar
        ' 
        btnConsultar.BackColor = SystemColors.ButtonHighlight
        btnConsultar.FlatAppearance.BorderColor = Color.DarkGreen
        btnConsultar.FlatAppearance.BorderSize = 3
        btnConsultar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnConsultar.FlatAppearance.MouseOverBackColor = Color.Teal
        btnConsultar.FlatStyle = FlatStyle.Flat
        btnConsultar.Font = New Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConsultar.ForeColor = SystemColors.ActiveCaptionText
        btnConsultar.Location = New Point(290, 262)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(75, 33)
        btnConsultar.TabIndex = 12
        btnConsultar.Text = "Consultar"
        btnConsultar.UseVisualStyleBackColor = False
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(245, 111)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(88, 23)
        txtCedula.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(245, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 18)
        Label7.TabIndex = 16
        Label7.Text = "Cédula"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = SystemColors.ButtonHighlight
        btnAgregar.FlatAppearance.BorderColor = Color.DarkGreen
        btnAgregar.FlatAppearance.BorderSize = 3
        btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnAgregar.FlatAppearance.MouseOverBackColor = Color.Teal
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.Font = New Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAgregar.ForeColor = SystemColors.ActiveCaptionText
        btnAgregar.Location = New Point(194, 262)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 33)
        btnAgregar.TabIndex = 34
        btnAgregar.Text = "Registrar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = SystemColors.ButtonHighlight
        btnActualizar.FlatAppearance.BorderColor = Color.DarkGreen
        btnActualizar.FlatAppearance.BorderSize = 3
        btnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnActualizar.FlatAppearance.MouseOverBackColor = Color.Teal
        btnActualizar.FlatStyle = FlatStyle.Flat
        btnActualizar.Font = New Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnActualizar.ForeColor = SystemColors.ActiveCaptionText
        btnActualizar.Location = New Point(388, 262)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(84, 33)
        btnActualizar.TabIndex = 35
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = SystemColors.ButtonHighlight
        btnEliminar.FlatAppearance.BorderColor = Color.DarkGreen
        btnEliminar.FlatAppearance.BorderSize = 3
        btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnEliminar.FlatAppearance.MouseOverBackColor = Color.Teal
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEliminar.ForeColor = SystemColors.ActiveCaptionText
        btnEliminar.Location = New Point(491, 262)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(95, 33)
        btnEliminar.TabIndex = 36
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(361, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 21)
        Label4.TabIndex = 53
        Label4.Text = "Form 1"
        ' 
        ' btnIrForm2
        ' 
        btnIrForm2.BackColor = SystemColors.ButtonHighlight
        btnIrForm2.FlatAppearance.BorderColor = Color.DarkGreen
        btnIrForm2.FlatAppearance.BorderSize = 3
        btnIrForm2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnIrForm2.FlatAppearance.MouseOverBackColor = Color.Teal
        btnIrForm2.FlatStyle = FlatStyle.Flat
        btnIrForm2.Font = New Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnIrForm2.ForeColor = SystemColors.ActiveCaptionText
        btnIrForm2.Location = New Point(322, 353)
        btnIrForm2.Name = "btnIrForm2"
        btnIrForm2.Size = New Size(150, 33)
        btnIrForm2.TabIndex = 54
        btnIrForm2.Text = "Ir al otro método"
        btnIrForm2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(800, 450)
        Controls.Add(btnIrForm2)
        Controls.Add(Label4)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnAgregar)
        Controls.Add(Label7)
        Controls.Add(txtCedula)
        Controls.Add(btnConsultar)
        Controls.Add(Label6)
        Controls.Add(txtCorreo)
        Controls.Add(txtEdad)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnIrForm2 As Button

End Class
