Imports instat

Public Class ucrRadio
    Public Overrides Sub UpdateControl(clsRCodeObject As RCodeStructure)
        MyBase.UpdateControl(clsRCodeObject)
    End Sub

    Public Overrides Sub UpdateRCode(Optional clsRFunction As RFunction = Nothing, Optional clsROperator As ROperator = Nothing)
        MyBase.UpdateRCode(clsRFunction, clsROperator)
    End Sub

    Private Sub rdoRadio_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRadio.CheckedChanged
        OnControlContentsChanged()
        OnControlValueChanged()
    End Sub
End Class
