Imports instat

Public Class ucrRadio
    Public Overrides Sub UpdateControl(Optional bReset As Boolean = False)
        MyBase.UpdateControl(bReset)
    End Sub

    Public Overrides Sub UpdateRCode()
        MyBase.UpdateRCode()
    End Sub

    Private Sub rdoRadio_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRadio.CheckedChanged
        OnControlContentsChanged()
        OnControlValueChanged()
    End Sub
End Class
