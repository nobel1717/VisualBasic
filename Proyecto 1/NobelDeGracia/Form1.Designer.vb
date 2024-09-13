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
        pictureBoxDep1 = New PictureBox()
        pictureBoxDep2 = New PictureBox()
        hScrollBarVelocidad = New HScrollBar()
        HScrollBar2 = New HScrollBar()
        btnIniciar = New Button()
        btnTerminar = New Button()
        btnSalir = New Button()
        Timer = New Timer(components)
        Label1 = New Label()
        txtAlturaDep1 = New Label()
        txtAlturaDep22 = New Label()
        CType(pictureBoxDep1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureBoxDep2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBoxDep1
        ' 
        pictureBoxDep1.Location = New Point(242, 73)
        pictureBoxDep1.Name = "pictureBoxDep1"
        pictureBoxDep1.Size = New Size(100, 217)
        pictureBoxDep1.TabIndex = 0
        pictureBoxDep1.TabStop = False
        ' 
        ' pictureBoxDep2
        ' 
        pictureBoxDep2.Location = New Point(399, 102)
        pictureBoxDep2.Name = "pictureBoxDep2"
        pictureBoxDep2.Size = New Size(100, 216)
        pictureBoxDep2.TabIndex = 1
        pictureBoxDep2.TabStop = False
        ' 
        ' hScrollBarVelocidad
        ' 
        hScrollBarVelocidad.Location = New Point(74, 87)
        hScrollBarVelocidad.Name = "hScrollBarVelocidad"
        hScrollBarVelocidad.Size = New Size(113, 155)
        hScrollBarVelocidad.TabIndex = 2
        ' 
        ' HScrollBar2
        ' 
        HScrollBar2.Location = New Point(610, 102)
        HScrollBar2.Name = "HScrollBar2"
        HScrollBar2.Size = New Size(113, 155)
        HScrollBar2.TabIndex = 3
        ' 
        ' btnIniciar
        ' 
        btnIniciar.Location = New Point(458, 371)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(75, 23)
        btnIniciar.TabIndex = 4
        btnIniciar.Text = "Iniciar"
        btnIniciar.UseVisualStyleBackColor = True
        ' 
        ' btnTerminar
        ' 
        btnTerminar.Location = New Point(559, 371)
        btnTerminar.Name = "btnTerminar"
        btnTerminar.Size = New Size(75, 23)
        btnTerminar.TabIndex = 5
        btnTerminar.Text = "Terminar"
        btnTerminar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(658, 371)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 23)
        btnSalir.TabIndex = 6
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(359, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 9
        Label1.Text = "Altura"
        ' 
        ' txtAlturaDep1
        ' 
        txtAlturaDep1.AutoSize = True
        txtAlturaDep1.Location = New Point(282, 55)
        txtAlturaDep1.Name = "txtAlturaDep1"
        txtAlturaDep1.Size = New Size(13, 15)
        txtAlturaDep1.TabIndex = 10
        txtAlturaDep1.Text = "0"
        ' 
        ' txtAlturaDep22
        ' 
        txtAlturaDep22.AutoSize = True
        txtAlturaDep22.Location = New Point(421, 73)
        txtAlturaDep22.Name = "txtAlturaDep22"
        txtAlturaDep22.Size = New Size(13, 15)
        txtAlturaDep22.TabIndex = 11
        txtAlturaDep22.Text = "0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtAlturaDep22)
        Controls.Add(txtAlturaDep1)
        Controls.Add(Label1)
        Controls.Add(btnSalir)
        Controls.Add(btnTerminar)
        Controls.Add(btnIniciar)
        Controls.Add(HScrollBar2)
        Controls.Add(hScrollBarVelocidad)
        Controls.Add(pictureBoxDep2)
        Controls.Add(pictureBoxDep1)
        Name = "Form1"
        Text = "Form1"
        CType(pictureBoxDep1, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureBoxDep2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pictureBoxDep1 As PictureBox
    Friend WithEvents pictureBoxDep2 As PictureBox
    Friend WithEvents hScrollBarVelocidad As HScrollBar
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnTerminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents txtAlturaDep2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAlturaDep1 As Label
    Friend WithEvents txtAlturaDep22 As Label

End Class
