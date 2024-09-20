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
        BindingSource1 = New BindingSource(components)
        panelCarga = New Panel()
        Panel2 = New Panel()
        Label1 = New Label()
        Carga = New Timer(components)
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelCarga
        ' 
        panelCarga.BackColor = Color.MediumAquamarine
        panelCarga.Location = New Point(0, 0)
        panelCarga.Name = "panelCarga"
        panelCarga.Size = New Size(90, 27)
        panelCarga.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(panelCarga)
        Panel2.Location = New Point(0, 318)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(599, 27)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(214, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 32)
        Label1.TabIndex = 0
        Label1.Text = "Ingresando..."
        ' 
        ' Carga
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(599, 345)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Cursor = Cursors.WaitCursor
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        TopMost = True
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents panelCarga As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Carga As Timer

End Class
