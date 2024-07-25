Public Class sdgTableRowExpression
    Private bFirstload As Boolean = True

    Private Sub InitialiseControl()
        ucrReceiverExpression.Selector = ucrSelectorCols
    End Sub

    Public Sub Setup(strDataFrameName As String)
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If


        ' Set up the selector
        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)
        ucrReceiverExpression.SetMeAsReceiver()
        ucrReceiverExpression.ResetText()

    End Sub

    ' TODO. In future this can be refactored to return an RFUnction
    Public Function GetRowExpression() As String
        Return ucrReceiverExpression.GetText()
    End Function

    Private Sub btnAddCondition_Click(sender As Object, e As EventArgs) Handles btnAddCondition.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition(cboCondition.Text)
    End Sub
End Class