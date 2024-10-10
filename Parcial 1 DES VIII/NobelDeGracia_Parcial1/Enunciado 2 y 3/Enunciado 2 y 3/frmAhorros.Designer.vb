<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAhorros
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
        lstMeses = New ListBox()
        txtAhorroTotal = New TextBox()
        btnCalcular = New Button()
        SuspendLayout()
        ' 
        ' lstMeses
        ' 
        lstMeses.FormattingEnabled = True
        lstMeses.ItemHeight = 15
        lstMeses.Location = New Point(90, 47)
        lstMeses.Name = "lstMeses"
        lstMeses.Size = New Size(172, 304)
        lstMeses.TabIndex = 0
        ' 
        ' txtAhorroTotal
        ' 
        txtAhorroTotal.Location = New Point(303, 105)
        txtAhorroTotal.Name = "txtAhorroTotal"
        txtAhorroTotal.Size = New Size(209, 23)
        txtAhorroTotal.TabIndex = 1
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(320, 175)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(75, 23)
        btnCalcular.TabIndex = 2
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' frmAhorros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalcular)
        Controls.Add(txtAhorroTotal)
        Controls.Add(lstMeses)
        Name = "frmAhorros"
        Text = "frmAhorros"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstMeses As ListBox
    Friend WithEvents txtAhorroTotal As TextBox
    Friend WithEvents btnCalcular As Button
End Class
