Public Class toolbox
    Private Sub btnWiden_Click(sender As Object, e As EventArgs) Handles btnWiden.Click
        Me.Close()
    End Sub
    'Private Sub nupNodeAddress_ValueChanged(sender As Object, e As EventArgs) Handles nupNodeAddress.ValueChanged
    '    myJOYlib.nodeAddress = nupNodeAddress.Value
    'End Sub

    'Private Sub nupLocationRecognition_ValueChanged(sender As Object, e As EventArgs) Handles nupLocationRecognition.ValueChanged
    '    myJOYlib.locationRecognition = nupLocationRecognition.Value
    'End Sub

    'Private Sub toolbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    nupLocationRecognition.Value = myJOYlib.locationRecognition
    '    nupNodeAddress.Value = myJOYlib.nodeAddress
    'End Sub
End Class