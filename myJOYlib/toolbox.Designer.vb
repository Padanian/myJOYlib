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
        nupNodeAddress = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        nupLocationRecognition = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnWiden = New System.Windows.Forms.Button()
        CType(nupNodeAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(nupLocationRecognition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nupNodeAddress
        '
        nupNodeAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        nupNodeAddress.Location = New System.Drawing.Point(55, 9)
        nupNodeAddress.Name = "nupNodeAddress"
        nupNodeAddress.Size = New System.Drawing.Size(44, 22)
        nupNodeAddress.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nodo"
        '
        'nupLocationRecognition
        '
        nupLocationRecognition.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        nupLocationRecognition.Location = New System.Drawing.Point(55, 34)
        nupLocationRecognition.Name = "nupLocationRecognition"
        nupLocationRecognition.Size = New System.Drawing.Size(44, 22)
        nupLocationRecognition.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Location"
        '
        'btnWiden
        '
        Me.btnWiden.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnWiden.Location = New System.Drawing.Point(1, 57)
        Me.btnWiden.Name = "btnWiden"
        Me.btnWiden.Size = New System.Drawing.Size(20, 20)
        Me.btnWiden.TabIndex = 5
        Me.btnWiden.Text = "<"
        Me.btnWiden.UseVisualStyleBackColor = True
        '
        'toolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(120, 78)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnWiden)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(nupLocationRecognition)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(nupNodeAddress)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "toolbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(nupNodeAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(nupLocationRecognition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Shared WithEvents nupNodeAddress As NumericUpDown
    Friend WithEvents Label1 As Label
    Public Shared WithEvents nupLocationRecognition As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btnWiden As Button
End Class
