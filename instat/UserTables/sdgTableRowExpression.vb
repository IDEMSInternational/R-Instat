Public Class sdgTableRowExpression
    Private bFirstload As Boolean = True

    Private Sub sdgTableRowExpression_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Setup(strDataFrameName As String)
        If bFirstload Then
            'InitialiseControl()
            'bFirstload = False
        End If



        ' Set up the selector
        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)



    End Sub

    ' TODO. In future this can be refactored to return an RFUnction
    Public Function GetRowExpression() As String
        Return ""
    End Function
End Class