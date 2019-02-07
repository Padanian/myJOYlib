
Public Class myJOYlib

    Private m_value As Decimal
    Private m_HeatCoolAction As Integer
    Private m_FanAction As Integer
    Public Property nodeAddress As Integer
    Public Property locationRecognition As Integer
    Shadows Event MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
    Shadows Event MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
    Private ClickNo As Integer

    Public Property Value As Decimal
        Get
            Return m_value
        End Get
        Set(Value As Decimal)
            If Value > 0 And Value <= 99.9 Then
                lblTemp.Text = Format(Value, "0#.0#°C")
                m_value = Value
            ElseIf Value = 0 Then
                lblTemp.Text = "OFF"
                m_value = Value
            End If
        End Set
    End Property
    Public Property HeatCoolAction As Integer
        Get
            Return m_HeatCoolAction
        End Get
        Set(HeatCoolAction As Integer)
            If HeatCoolAction >= 0 And HeatCoolAction <= 2 Then
                m_HeatCoolAction = HeatCoolAction
                If m_HeatCoolAction = 0 Then
                    pbHeatCoolAction.Image = Nothing
                ElseIf m_HeatCoolAction = 1 Then
                    pbHeatCoolAction.Image = My.Resources.thermoplus
                ElseIf m_HeatCoolAction = 2 Then
                    pbHeatCoolAction.Image = My.Resources.thermominus
                Else
                    pbHeatCoolAction.Image = Nothing
                End If
            End If
        End Set
    End Property
    Public Property FanAction As Integer
        Get
            Return m_FanAction
        End Get
        Set(FanAction As Integer)
            If FanAction >= 0 And FanAction <= 256 Then
                m_FanAction = FanAction
                If m_FanAction = 0 Then
                    pbFanAction.Image = Nothing
                    lblFanAction.Text = ""
                ElseIf m_FanAction = 1 Then
                    pbFanAction.Image = My.Resources.fan
                    lblFanAction.Text = "     1"
                ElseIf m_FanAction = 2 Then
                    pbFanAction.Image = My.Resources.fan
                    lblFanAction.Text = "     2"
                ElseIf m_FanAction = 3 Then
                    pbFanAction.Image = My.Resources.fan
                    lblFanAction.Text = "     3"
                ElseIf m_FanAction = 256 Then
                    pbFanAction.Image = Nothing
                    lblFanAction.Text = ""
                ElseIf m_FanAction = 255 Then
                    pbFanAction.Image = My.Resources.fan
                    lblFanAction.Text = "AUTO 1"
                ElseIf m_FanAction = 254 Then
                    pbFanAction.Image = My.Resources.fan
                    lblFanAction.Text = "AUTO 2"
                ElseIf m_FanAction = 253 Then
                    pbFanAction.Image = My.Resources.fan
                    lblFanAction.Text = "AUTO 3"
                Else
                    pbFanAction.Image = Nothing
                    lblFanAction.Text = ""
                End If
            End If
        End Set
    End Property




    Public Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Value = 21.0
        HeatCoolAction = 0
        FanAction = 0
        nodeAddress = 32
        locationRecognition = 0

        pbFanAction.Visible = False
        pbHeatCoolAction.Visible = False
        Me.Size = New Size(31, 56)

        lblTemp.Font = New Font("Tahoma", 5, FontStyle.Regular)
        lblTemp.Location = New Point(5, 7)
        lblFanAction.Visible = False


    End Sub
    Public Sub Me_MouseMove(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox1.MouseHover

        If ClientRectangle.Contains(PointToClient(Control.MousePosition)) And Me.Size.Width <> 94 Then
            pbFanAction.Visible = True
            pbHeatCoolAction.Visible = True
            Me.Size = New Size(94, 168)

            lblTemp.Font = New Font("Tahoma", 12, FontStyle.Bold)
            lblTemp.Location = New Point(17, 22)
            lblFanAction.Visible = True
        Else
            pbFanAction.Visible = False
            pbHeatCoolAction.Visible = False
            Me.Size = New Size(31, 56)

            lblTemp.Font = New Font("Tahoma", 5, FontStyle.Bold)
            lblTemp.Location = New Point(5, 7)
            lblFanAction.Visible = False
        End If

    End Sub



End Class
