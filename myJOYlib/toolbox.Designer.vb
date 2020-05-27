<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class toolbox
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnWiden = New System.Windows.Forms.Button()
        Me.lblTBNode = New System.Windows.Forms.Label()
        Me.lblTBTipo = New System.Windows.Forms.Label()
        Me.lblTBFirmware = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nodo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo"
        '
        'btnWiden
        '
        Me.btnWiden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnWiden.Location = New System.Drawing.Point(1, 80)
        Me.btnWiden.Name = "btnWiden"
        Me.btnWiden.Size = New System.Drawing.Size(20, 20)
        Me.btnWiden.TabIndex = 5
        Me.btnWiden.Text = "<"
        Me.btnWiden.UseVisualStyleBackColor = True
        '
        'lblTBNode
        '
        Me.lblTBNode.AutoSize = True
        Me.lblTBNode.Location = New System.Drawing.Point(44, 11)
        Me.lblTBNode.Name = "lblTBNode"
        Me.lblTBNode.Size = New System.Drawing.Size(13, 13)
        Me.lblTBNode.TabIndex = 1
        Me.lblTBNode.Text = "0"
        '
        'lblTBTipo
        '
        Me.lblTBTipo.AutoSize = True
        Me.lblTBTipo.Location = New System.Drawing.Point(44, 36)
        Me.lblTBTipo.Name = "lblTBTipo"
        Me.lblTBTipo.Size = New System.Drawing.Size(13, 13)
        Me.lblTBTipo.TabIndex = 1
        Me.lblTBTipo.Text = "0"
        '
        'lblTBFirmware
        '
        Me.lblTBFirmware.AutoSize = True
        Me.lblTBFirmware.Location = New System.Drawing.Point(44, 61)
        Me.lblTBFirmware.Name = "lblTBFirmware"
        Me.lblTBFirmware.Size = New System.Drawing.Size(13, 13)
        Me.lblTBFirmware.TabIndex = 6
        Me.lblTBFirmware.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "FW v."
        '
        'toolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(150, 101)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTBFirmware)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnWiden)
        Me.Controls.Add(Me.lblTBTipo)
        Me.Controls.Add(Me.lblTBNode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "toolbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnWiden As Button
    Friend WithEvents lblTBNode As Label
    Friend WithEvents lblTBTipo As Label
    Friend WithEvents lblTBFirmware As Label
    Friend WithEvents Label6 As Label
End Class
