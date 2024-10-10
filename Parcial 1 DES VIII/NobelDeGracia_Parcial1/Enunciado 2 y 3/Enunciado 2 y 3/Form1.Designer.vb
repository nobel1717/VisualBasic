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
        btnCalificaciones = New Button()
        btnAhorros = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(361, 142)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 15)
        Label1.TabIndex = 0
        Label1.Text = "Elige el enunciado"
        ' 
        ' btnCalificaciones
        ' 
        btnCalificaciones.Location = New Point(446, 213)
        btnCalificaciones.Name = "btnCalificaciones"
        btnCalificaciones.Size = New Size(109, 23)
        btnCalificaciones.TabIndex = 1
        btnCalificaciones.Text = "Enunciado 3"
        btnCalificaciones.UseVisualStyleBackColor = True
        ' 
        ' btnAhorros
        ' 
        btnAhorros.Location = New Point(271, 213)
        btnAhorros.Name = "btnAhorros"
        btnAhorros.Size = New Size(105, 23)
        btnAhorros.TabIndex = 2
        btnAhorros.Text = "Enunciado 2"
        btnAhorros.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAhorros)
        Controls.Add(btnCalificaciones)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalificaciones As Button
    Friend WithEvents btnAhorros As Button

End Class
