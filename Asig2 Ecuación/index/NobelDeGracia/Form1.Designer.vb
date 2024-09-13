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
        txtY = New TextBox()
        txtQ = New TextBox()
        btnCalcular = New Button()
        Label2 = New Label()
        Label3 = New Label()
        txtResultado = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(108, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 25)
        Label1.TabIndex = 0
        Label1.Text = "Ingrese los valores"
        ' 
        ' txtY
        ' 
        txtY.Location = New Point(118, 182)
        txtY.Name = "txtY"
        txtY.Size = New Size(50, 23)
        txtY.TabIndex = 2
        ' 
        ' txtQ
        ' 
        txtQ.Location = New Point(205, 182)
        txtQ.Name = "txtQ"
        txtQ.Size = New Size(52, 23)
        txtQ.TabIndex = 3
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(108, 276)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(90, 30)
        btnCalcular.TabIndex = 4
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(118, 208)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 18)
        Label2.TabIndex = 5
        Label2.Text = "valor y"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(205, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 18)
        Label3.TabIndex = 7
        Label3.Text = "valor q"
        ' 
        ' txtResultado
        ' 
        txtResultado.AutoSize = True
        txtResultado.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtResultado.Location = New Point(237, 280)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(167, 19)
        txtResultado.TabIndex = 8
        txtResultado.Text = "Resultado:  ______"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(258, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(250, 35)
        Label5.TabIndex = 9
        Label5.Text = "Asignación No.2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(323, 65)
        Label6.Name = "Label6"
        Label6.Size = New Size(123, 19)
        Label6.TabIndex = 10
        Label6.Text = "Nobel De Gracia"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.ecuacion
        PictureBox2.Location = New Point(323, 129)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(229, 113)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.WindowFrame
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtResultado)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnCalcular)
        Controls.Add(txtQ)
        Controls.Add(txtY)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Asignación No.2"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtY As TextBox
    Friend WithEvents txtQ As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResultado As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox

End Class
