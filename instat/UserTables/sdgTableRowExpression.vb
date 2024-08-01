Public Class sdgTableRowExpression
    Private bFirstload As Boolean = True
    Public bUserClickedReturn As Boolean = False

    Private Sub sdgTableRowExpression_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If

        bUserClickedReturn = False
    End Sub

    Private Sub InitialiseControl()
        ucrReceiverExpression.Selector = ucrSelectorCols
        ucrReceiverExpression.SetMeAsReceiver()
    End Sub

    Public Sub Setup(strDataFrameName As String)
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If


        ' Set up the selector
        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)
        ucrReceiverExpression.Clear()

    End Sub

    ' TODO. In future this can be refactored to return an RFunction
    Public Function GetUserInputRowExpression() As String
        Return ucrReceiverExpression.GetText()
    End Function

    Private Sub btnAddCondition_Click(sender As Object, e As EventArgs) Handles btnAddCondition.Click
        ucrReceiverExpression.AddToReceiverAtCursorPosition(cboCondition.Text)
    End Sub

    Private Sub ucrSdgBaseButtons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgBaseButtons.ClickReturn
        bUserClickedReturn = True
    End Sub
End Class