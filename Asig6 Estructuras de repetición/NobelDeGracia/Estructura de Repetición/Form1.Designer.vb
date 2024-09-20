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
        en1 = New Button()
        en2 = New Button()
        BindingSource1 = New BindingSource(components)
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' en1
        ' 
        en1.BackColor = SystemColors.GradientActiveCaption
        en1.Location = New Point(129, 269)
        en1.Name = "en1"
        en1.Size = New Size(95, 23)
        en1.TabIndex = 0
        en1.Text = "Enunciado 1"
        en1.UseVisualStyleBackColor = False
        ' 
        ' en2
        ' 
        en2.BackColor = SystemColors.GradientActiveCaption
        en2.Location = New Point(444, 269)
        en2.Name = "en2"
        en2.Size = New Size(95, 23)
        en2.TabIndex = 1
        en2.Text = "Enunciado 2"
        en2.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Menu
        TextBox1.Location = New Point(129, 319)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(142, 23)
        TextBox1.TabIndex = 2
        TextBox1.Text = "Cadena de texto"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(287, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 46)
        Label1.TabIndex = 3
        Label1.Text = "Asignación 6"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(325, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 24)
        Label2.TabIndex = 4
        Label2.Text = "Nobel De Gracia"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(79, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 22)
        Label3.TabIndex = 5
        Label3.Text = "Reglas de la aplicación:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 9.75F)
        Label4.Location = New Point(79, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(600, 18)
        Label4.TabIndex = 6
        Label4.Text = "Enunciado 1:  ingresa todas las letras posible, una a una en cada intento, esto se repetirá hasta que "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 9.75F)
        Label5.Location = New Point(79, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(529, 18)
        Label5.TabIndex = 7
        Label5.Text = "ingreses una vocal, luego se mostrará en una caja texto las letras formando una cadena."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Trebuchet MS", 9.75F)
        Label6.Location = New Point(79, 207)
        Label6.Name = "Label6"
        Label6.Size = New Size(336, 18)
        Label6.TabIndex = 9
        Label6.Text = "vocales y cuántas consonantes existen en dicha cadena."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Trebuchet MS", 9.75F)
        Label7.Location = New Point(79, 192)
        Label7.Name = "Label7"
        Label7.Size = New Size(557, 18)
        Label7.TabIndex = 8
        Label7.Text = "Enunciado 2: Elabora una cadena entre letras vocales y consonantes, se mostrará cuántas son"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(en2)
        Controls.Add(en1)
        Name = "Form1"
        Text = "Form1"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents en1 As Button
    Friend WithEvents en2 As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
