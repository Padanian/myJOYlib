<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myJOYlib
    Inherits System.Windows.Forms.UserControl

    'UserControl1 esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblFanAction = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbFanAction = New System.Windows.Forms.PictureBox()
        Me.pbHeatCoolAction = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbFanAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHeatCoolAction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblTemp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.Location = New System.Drawing.Point(17, 22)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(63, 19)
        Me.lblTemp.TabIndex = 1
        Me.lblTemp.Text = "99.9°C"
        '
        'lblFanAction
        '
        Me.lblFanAction.AutoSize = True
        Me.lblFanAction.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblFanAction.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanAction.Location = New System.Drawing.Point(41, 75)
        Me.lblFanAction.Name = "lblFanAction"
        Me.lblFanAction.Size = New System.Drawing.Size(49, 14)
        Me.lblFanAction.TabIndex = 3
        Me.lblFanAction.Text = "AUTO 0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250
        '
        'pbFanAction
        '
        Me.pbFanAction.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pbFanAction.Image = Global.myJOYlib.My.Resources.Resources.fan
        Me.pbFanAction.Location = New System.Drawing.Point(48, 46)
        Me.pbFanAction.Name = "pbFanAction"
        Me.pbFanAction.Size = New System.Drawing.Size(32, 32)
        Me.pbFanAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFanAction.TabIndex = 2
        Me.pbFanAction.TabStop = False
        '
        'pbHeatCoolAction
        '
        Me.pbHeatCoolAction.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pbHeatCoolAction.Image = Global.myJOYlib.My.Resources.Resources.thermominus
        Me.pbHeatCoolAction.Location = New System.Drawing.Point(13, 46)
        Me.pbHeatCoolAction.Name = "pbHeatCoolAction"
        Me.pbHeatCoolAction.Size = New System.Drawing.Size(32, 32)
        Me.pbHeatCoolAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbHeatCoolAction.TabIndex = 2
        Me.pbHeatCoolAction.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.myJOYlib.My.Resources.Resources.joy2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'myJOYlib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblFanAction)
        Me.Controls.Add(Me.pbFanAction)
        Me.Controls.Add(Me.pbHeatCoolAction)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "myJOYlib"
        Me.Size = New System.Drawing.Size(94, 168)
        CType(Me.pbFanAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHeatCoolAction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTemp As Label
    Friend WithEvents pbHeatCoolAction As PictureBox
    Friend WithEvents pbFanAction As PictureBox
    Friend WithEvents lblFanAction As Label
    Friend WithEvents Timer1 As Timer
End Class
