<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnActualizar = New Button()
        btnAgregar = New Button()
        Label7 = New Label()
        txtCedula = New TextBox()
        btnConsultar = New Button()
        Label6 = New Label()
        txtCorreo = New TextBox()
        txtEdad = New TextBox()
        txtApellido = New TextBox()
        txtNombre = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        btnRegresar = New Button()
        btnEliminar = New Button()
        SuspendLayout()
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
        btnActualizar.Location = New Point(400, 279)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(84, 33)
        btnActualizar.TabIndex = 50
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
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
        btnAgregar.Location = New Point(207, 279)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 33)
        btnAgregar.TabIndex = 49
        btnAgregar.Text = "Registrar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(257, 110)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 18)
        Label7.TabIndex = 48
        Label7.Text = "Cédula"
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(257, 128)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(88, 23)
        txtCedula.TabIndex = 47
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
        btnConsultar.Location = New Point(302, 279)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(75, 33)
        btnConsultar.TabIndex = 46
        btnConsultar.Text = "Consultar"
        btnConsultar.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(244, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(310, 30)
        Label6.TabIndex = 45
        Label6.Text = "Formulario de Clientes"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(255, 232)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(299, 23)
        txtCorreo.TabIndex = 44
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(428, 128)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(46, 23)
        txtEdad.TabIndex = 43
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(428, 179)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(126, 23)
        txtApellido.TabIndex = 42
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(255, 179)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(150, 23)
        txtNombre.TabIndex = 41
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(255, 214)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 18)
        Label5.TabIndex = 40
        Label5.Text = "Correo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(428, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 18)
        Label3.TabIndex = 39
        Label3.Text = "Edad"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(428, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 18)
        Label2.TabIndex = 38
        Label2.Text = "Apellido"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(255, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 18)
        Label1.TabIndex = 37
        Label1.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(366, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 21)
        Label4.TabIndex = 52
        Label4.Text = "Form 2"
        ' 
        ' btnRegresar
        ' 
        btnRegresar.BackColor = SystemColors.ButtonHighlight
        btnRegresar.FlatAppearance.BorderColor = Color.DarkGreen
        btnRegresar.FlatAppearance.BorderSize = 3
        btnRegresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnRegresar.FlatAppearance.MouseOverBackColor = Color.Teal
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.Font = New Font("Britannic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegresar.ForeColor = SystemColors.ActiveCaptionText
        btnRegresar.Location = New Point(334, 357)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(150, 33)
        btnRegresar.TabIndex = 53
        btnRegresar.Text = "Ir al otro método"
        btnRegresar.UseVisualStyleBackColor = False
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
        btnEliminar.Location = New Point(502, 279)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(95, 33)
        btnEliminar.TabIndex = 54
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(800, 450)
        Controls.Add(btnEliminar)
        Controls.Add(btnRegresar)
        Controls.Add(Label4)
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
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnEliminar As Button
End Class
