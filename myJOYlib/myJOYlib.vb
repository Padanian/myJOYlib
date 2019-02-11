
Public Class myJOYlib

    Private m_value As Decimal
    Private m_HeatCoolAction As Integer
    Private m_FanAction As Integer
    Public Property nodeAddress As Integer
    Public Property locationRecognition As Integer
    Shadows Event MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
    Shadows Event MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
    Private ClickNo As Integer
    Private MouseIsDown As Boolean = False
    Private currentX, currentY As Integer

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
        lblTemp.Location = New Point(3, 7)
        lblFanAction.Visible = False

        AddHandler PictureBox1.MouseHover, AddressOf Me_MouseHover
        AddHandler pbFanAction.MouseHover, AddressOf Me_MouseHover
        AddHandler pbHeatCoolAction.MouseHover, AddressOf Me_MouseHover
        AddHandler lblTemp.MouseHover, AddressOf Me_MouseHover
        AddHandler lblFanAction.MouseHover, AddressOf Me_MouseHover
        AddHandler Timer1.Tick, AddressOf Me_MouseHover

        AddHandler PictureBox1.MouseMove, AddressOf image_MouseMove
        AddHandler pbFanAction.MouseMove, AddressOf image_MouseMove
        AddHandler pbHeatCoolAction.MouseMove, AddressOf image_MouseMove
        AddHandler lblTemp.MouseMove, AddressOf image_MouseMove
        AddHandler lblFanAction.MouseMove, AddressOf image_MouseMove

        AddHandler PictureBox1.MouseDown, AddressOf image_MouseDown
        AddHandler pbFanAction.MouseDown, AddressOf image_MouseDown
        AddHandler pbHeatCoolAction.MouseDown, AddressOf image_MouseDown
        AddHandler lblTemp.MouseDown, AddressOf image_MouseDown
        AddHandler lblFanAction.MouseDown, AddressOf image_MouseDown

        AddHandler PictureBox1.MouseUp, AddressOf image_MouseUp
        AddHandler pbFanAction.MouseUp, AddressOf image_MouseUp
        AddHandler pbHeatCoolAction.MouseUp, AddressOf image_MouseUp
        AddHandler lblTemp.MouseUp, AddressOf image_MouseUp
        AddHandler lblFanAction.MouseUp, AddressOf image_MouseUp


    End Sub
    Public Sub Me_MouseHover(ByVal sender As Object, ByVal e As EventArgs)

        Dim mouseLocation As Point = PointToClient(Control.MousePosition)
        Dim r As Rectangle = New Rectangle(PictureBox1.Location.X, PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)

        If mouseLocation.X > r.Location.X And mouseLocation.Y > r.Location.Y And
            mouseLocation.X < r.Width And mouseLocation.Y < r.Height Then

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
            lblTemp.Location = New Point(3, 7)
            lblFanAction.Visible = False
        End If

    End Sub
    Private Sub image_MouseMove(sender As Object, e As MouseEventArgs)
        If MouseIsDown Then
            sender.Parent.Top = sender.Parent.Top + (e.Y - currentY)
            sender.Parent.Left = sender.Parent.Left + (e.X - currentX)
        End If
    End Sub
    Private Sub image_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        MouseIsDown = True
        currentX = e.X
        currentY = e.Y
    End Sub
    Private Sub image_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        MouseIsDown = False
    End Sub
    Private Function MouseIsOverControl(ByVal [Control] As Control) As Boolean
        Dim r = [Control].ClientRectangle
        r.Inflate(15, 15)
        Return r.Contains([Control].PointToClient(MousePosition))
    End Function
End Class
