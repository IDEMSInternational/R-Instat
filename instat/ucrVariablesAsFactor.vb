Public Class ucrVariablesAsFactor
    Public bSingleVariable As Boolean = True
    Public ucrFactorReceiver As ucrReceiverSingle

    Public Sub SetFactorReceiver(ucrReceiverToSet As ucrReceiverSingle)
        ucrFactorReceiver = ucrReceiverToSet
    End Sub

    Public Sub SetSelector(ucrSelectorToSet As ucrSelector)
        ucrSingleVariable.Selector = ucrSelectorToSet
        ucrMultipleVariables.Selector = ucrSelectorToSet
    End Sub

    Private Sub cmdVariables_Click(sender As Object, e As EventArgs) Handles cmdVariables.Click
        If bSingleVariable Then
            'need to translate correctly
            cmdVariables.Text = "Multiple Variables"
            cmdVariables.FlatStyle = FlatStyle.Popup
            bSingleVariable = False
            ucrSingleVariable.Visible = False
            ucrMultipleVariables.Visible = True
        Else
            ucrSingleVariable.Visible = True
            ucrMultipleVariables.Visible = False
            'need to translate correctly
            cmdVariables.Text = "Single Variables"
            cmdVariables.FlatStyle = FlatStyle.Flat
            bSingleVariable = True
        End If
    End Sub
End Class
