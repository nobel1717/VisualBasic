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
        btnIngresarCliente = New Button()
        btnRealizarTransaccion = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        txtNumeroCuenta = New TextBox()
        txtNombreCliente = New TextBox()
        txtMontoInicial = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnIngresarCliente
        ' 
        btnIngresarCliente.Location = New Point(541, 222)
        btnIngresarCliente.Name = "btnIngresarCliente"
        btnIngresarCliente.Size = New Size(124, 23)
        btnIngresarCliente.TabIndex = 0
        btnIngresarCliente.Text = "Ingresar Cliente"
        btnIngresarCliente.UseVisualStyleBackColor = True
        ' 
        ' btnRealizarTransaccion
        ' 
        btnRealizarTransaccion.Location = New Point(518, 344)
        btnRealizarTransaccion.Name = "btnRealizarTransaccion"
        btnRealizarTransaccion.Size = New Size(164, 23)
        btnRealizarTransaccion.TabIndex = 1
        btnRealizarTransaccion.Text = "RealizarTransacción"
        btnRealizarTransaccion.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Info
        PictureBox1.Image = My.Resources.Resources.banco_fondo
        PictureBox1.Location = New Point(-46, -13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(486, 515)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(463, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 15)
        Label1.TabIndex = 3
        Label1.Text = "Ingrese número de cuenta"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(463, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 15)
        Label2.TabIndex = 4
        Label2.Text = "Nombre del CIiente"
        ' 
        ' txtNumeroCuenta
        ' 
        txtNumeroCuenta.Location = New Point(616, 91)
        txtNumeroCuenta.Name = "txtNumeroCuenta"
        txtNumeroCuenta.PlaceholderText = "0000"
        txtNumeroCuenta.Size = New Size(124, 23)
        txtNumeroCuenta.TabIndex = 6
        ' 
        ' txtNombreCliente
        ' 
        txtNombreCliente.Location = New Point(616, 129)
        txtNombreCliente.Name = "txtNombreCliente"
        txtNombreCliente.PlaceholderText = "Nombre y Apellido"
        txtNombreCliente.Size = New Size(124, 23)
        txtNombreCliente.TabIndex = 7
        ' 
        ' txtMontoInicial
        ' 
        txtMontoInicial.Location = New Point(616, 173)
        txtMontoInicial.Name = "txtMontoInicial"
        txtMontoInicial.PlaceholderText = "0.00"
        txtMontoInicial.Size = New Size(122, 23)
        txtMontoInicial.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(463, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 9
        Label3.Text = "Saldo inicial"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Highlight
        Label4.Font = New Font("Showcard Gothic", 27.75F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(86, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 46)
        Label4.TabIndex = 10
        Label4.Text = "Banco UTP"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(530, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(194, 27)
        Label5.TabIndex = 11
        Label5.Text = "Ingresar Cliente"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtMontoInicial)
        Controls.Add(txtNombreCliente)
        Controls.Add(txtNumeroCuenta)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnRealizarTransaccion)
        Controls.Add(btnIngresarCliente)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnIngresarCliente As Button
    Friend WithEvents btnRealizarTransaccion As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumeroCuenta As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtMontoInicial As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
