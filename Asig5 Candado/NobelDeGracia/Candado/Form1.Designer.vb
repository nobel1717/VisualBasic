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
        dig1 = New TextBox()
        dig2 = New TextBox()
        dig3 = New TextBox()
        dig4 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btninte = New Button()
        btndesis = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' dig1
        ' 
        dig1.Location = New Point(327, 156)
        dig1.Name = "dig1"
        dig1.Size = New Size(21, 23)
        dig1.TabIndex = 0
        ' 
        ' dig2
        ' 
        dig2.Location = New Point(354, 156)
        dig2.Name = "dig2"
        dig2.Size = New Size(21, 23)
        dig2.TabIndex = 1
        ' 
        ' dig3
        ' 
        dig3.Location = New Point(381, 156)
        dig3.Name = "dig3"
        dig3.Size = New Size(21, 23)
        dig3.TabIndex = 2
        ' 
        ' dig4
        ' 
        dig4.Location = New Point(408, 156)
        dig4.Name = "dig4"
        dig4.Size = New Size(21, 23)
        dig4.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(325, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 21)
        Label1.TabIndex = 4
        Label1.Text = "Ingrese 4 dígitos "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(280, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(226, 15)
        Label2.TabIndex = 5
        Label2.Text = "Solo use los siguientes número: 1, 2 o 3 "
        ' 
        ' btninte
        ' 
        btninte.BackColor = SystemColors.HighlightText
        btninte.ForeColor = SystemColors.ControlText
        btninte.Location = New Point(289, 207)
        btninte.Name = "btninte"
        btninte.Size = New Size(75, 23)
        btninte.TabIndex = 6
        btninte.Text = "Intentar"
        btninte.UseVisualStyleBackColor = False
        ' 
        ' btndesis
        ' 
        btndesis.BackColor = SystemColors.ButtonHighlight
        btndesis.Location = New Point(397, 207)
        btndesis.Name = "btndesis"
        btndesis.Size = New Size(75, 23)
        btndesis.TabIndex = 7
        btndesis.Text = "Desistir"
        btndesis.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Palatino Linotype", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(194, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(395, 87)
        Label3.TabIndex = 8
        Label3.Text = "CANDADO"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(btndesis)
        Controls.Add(btninte)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dig4)
        Controls.Add(dig3)
        Controls.Add(dig2)
        Controls.Add(dig1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dig1 As TextBox
    Friend WithEvents dig2 As TextBox
    Friend WithEvents dig3 As TextBox
    Friend WithEvents dig4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btninte As Button
    Friend WithEvents btndesis As Button
    Friend WithEvents Label3 As Label

End Class
