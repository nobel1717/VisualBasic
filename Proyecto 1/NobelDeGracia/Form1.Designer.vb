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
        btnIniciar = New Button()
        btnTerminar = New Button()
        btnSalir = New Button()
        TimerLlenado = New Timer(components)
        Label1 = New Label()
        txtAlturaDep1 = New Label()
        txtAlturaDep22 = New Label()
        panelDep1 = New Panel()
        PictureBox1 = New PictureBox()
        panelDep2 = New Panel()
        btnVaciar = New Button()
        TimerCompuerta = New Timer(components)
        chkCompuertaCerrada = New CheckBox()
        PanelTubo = New Panel()
        PictureBox4 = New PictureBox()
        TimerVaciado = New Timer(components)
        lblVelocidad = New Label()
        ScrollBarVelocidad = New VScrollBar()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox5 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnIniciar
        ' 
        btnIniciar.Location = New Point(522, 285)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(75, 23)
        btnIniciar.TabIndex = 4
        btnIniciar.Text = "Iniciar"
        btnIniciar.UseVisualStyleBackColor = True
        ' 
        ' btnTerminar
        ' 
        btnTerminar.Location = New Point(603, 285)
        btnTerminar.Name = "btnTerminar"
        btnTerminar.Size = New Size(75, 23)
        btnTerminar.TabIndex = 5
        btnTerminar.Text = "Parar"
        btnTerminar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(686, 314)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(67, 23)
        btnSalir.TabIndex = 6
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' TimerLlenado
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(342, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 9
        Label1.Text = "Altura"
        ' 
        ' txtAlturaDep1
        ' 
        txtAlturaDep1.AutoSize = True
        txtAlturaDep1.Location = New Point(267, 115)
        txtAlturaDep1.Name = "txtAlturaDep1"
        txtAlturaDep1.Size = New Size(13, 15)
        txtAlturaDep1.TabIndex = 10
        txtAlturaDep1.Text = "0"
        ' 
        ' txtAlturaDep22
        ' 
        txtAlturaDep22.AutoSize = True
        txtAlturaDep22.Location = New Point(417, 115)
        txtAlturaDep22.Name = "txtAlturaDep22"
        txtAlturaDep22.Size = New Size(13, 15)
        txtAlturaDep22.TabIndex = 11
        txtAlturaDep22.Text = "0"
        ' 
        ' panelDep1
        ' 
        panelDep1.BackColor = Color.Red
        panelDep1.Location = New Point(207, 427)
        panelDep1.Name = "panelDep1"
        panelDep1.Size = New Size(122, 11)
        panelDep1.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.Location = New Point(192, 417)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(290, 35)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' panelDep2
        ' 
        panelDep2.BackColor = Color.Red
        panelDep2.Location = New Point(359, 428)
        panelDep2.Name = "panelDep2"
        panelDep2.Size = New Size(123, 10)
        panelDep2.TabIndex = 13
        ' 
        ' btnVaciar
        ' 
        btnVaciar.Location = New Point(686, 285)
        btnVaciar.Name = "btnVaciar"
        btnVaciar.Size = New Size(67, 23)
        btnVaciar.TabIndex = 16
        btnVaciar.Text = "Vaciar"
        btnVaciar.UseVisualStyleBackColor = True
        ' 
        ' TimerCompuerta
        ' 
        ' 
        ' chkCompuertaCerrada
        ' 
        chkCompuertaCerrada.AutoSize = True
        chkCompuertaCerrada.Location = New Point(522, 249)
        chkCompuertaCerrada.Name = "chkCompuertaCerrada"
        chkCompuertaCerrada.Size = New Size(128, 19)
        chkCompuertaCerrada.TabIndex = 18
        chkCompuertaCerrada.Text = "Compuerta cerrada"
        chkCompuertaCerrada.UseVisualStyleBackColor = True
        ' 
        ' PanelTubo
        ' 
        PanelTubo.BackColor = Color.Red
        PanelTubo.Location = New Point(329, 256)
        PanelTubo.Name = "PanelTubo"
        PanelTubo.RightToLeft = RightToLeft.Yes
        PanelTubo.Size = New Size(52, 10)
        PanelTubo.TabIndex = 2
        PanelTubo.UseWaitCursor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Yellow
        PictureBox4.BackgroundImageLayout = ImageLayout.None
        PictureBox4.BorderStyle = BorderStyle.FixedSingle
        PictureBox4.Location = New Point(317, 249)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(48, 10)
        PictureBox4.TabIndex = 29
        PictureBox4.TabStop = False
        PictureBox4.UseWaitCursor = True
        ' 
        ' TimerVaciado
        ' 
        ' 
        ' lblVelocidad
        ' 
        lblVelocidad.AutoSize = True
        lblVelocidad.Location = New Point(83, 115)
        lblVelocidad.Name = "lblVelocidad"
        lblVelocidad.Size = New Size(13, 15)
        lblVelocidad.TabIndex = 20
        lblVelocidad.Text = "0"
        ' 
        ' ScrollBarVelocidad
        ' 
        ScrollBarVelocidad.Location = New Point(69, 149)
        ScrollBarVelocidad.Name = "ScrollBarVelocidad"
        ScrollBarVelocidad.Size = New Size(44, 262)
        ScrollBarVelocidad.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 417)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 15)
        Label2.TabIndex = 22
        Label2.Text = "Control de Velocidad"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(206, 149)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(123, 229)
        PictureBox2.TabIndex = 27
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Location = New Point(359, 188)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(123, 223)
        PictureBox3.TabIndex = 28
        PictureBox3.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Yellow
        PictureBox5.BackgroundImageLayout = ImageLayout.None
        PictureBox5.BorderStyle = BorderStyle.FixedSingle
        PictureBox5.Location = New Point(317, 265)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(49, 10)
        PictureBox5.TabIndex = 30
        PictureBox5.TabStop = False
        PictureBox5.UseWaitCursor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(795, 456)
        Controls.Add(Label2)
        Controls.Add(ScrollBarVelocidad)
        Controls.Add(lblVelocidad)
        Controls.Add(chkCompuertaCerrada)
        Controls.Add(PictureBox1)
        Controls.Add(btnVaciar)
        Controls.Add(panelDep2)
        Controls.Add(panelDep1)
        Controls.Add(txtAlturaDep22)
        Controls.Add(txtAlturaDep1)
        Controls.Add(Label1)
        Controls.Add(btnSalir)
        Controls.Add(btnTerminar)
        Controls.Add(btnIniciar)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Controls.Add(PanelTubo)
        Controls.Add(PictureBox5)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnTerminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents TimerLlenado As Timer
    Friend WithEvents txtAlturaDep2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAlturaDep1 As Label
    Friend WithEvents txtAlturaDep22 As Label
    Friend WithEvents panelDep1 As Panel
    Friend WithEvents panelDep2 As Panel
    Friend WithEvents btnVaciar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimerCompuerta As Timer
    Friend WithEvents chkCompuertaCerrada As CheckBox
    Friend WithEvents PanelTubo As Panel
    Friend WithEvents TimerVaciado As Timer
    Friend WithEvents lblVelocidad As Label
    Friend WithEvents ScrollBarVelocidad As VScrollBar
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox

End Class
