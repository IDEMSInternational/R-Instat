Public Class ucrRowExpression

    Private strDataFrameName As String
    Private bFirstload As Boolean = True


    Private Sub UcrInputRowExpression_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If bFirstload Then
        '    initialiseControl()
        '    bFirstload = False
        'End If
    End Sub

    'Private Sub initialiseControl()
    '    ucrInputExpression.SetParameter(New RParameter("rows", 0,))
    'End Sub


    Public Sub setup(strDataFrameName As String)
        Me.strDataFrameName = strDataFrameName
    End Sub

    'Public Sub SetRCode(clsNewCodeStructure As RCodeStructure, Optional bReset As Boolean = False, Optional bUpdate As Boolean = True, Optional bCloneIfNeeded As Boolean = False)
    '    ucrInputExpression.SetRCode(clsNewCodeStructure, bReset:=bReset, bUpdate:=bUpdate, bCloneIfNeeded:=bCloneIfNeeded)
    'End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        sdgTableRowExpression.Setup(strDataFrameName)
        sdgTableRowExpression.ShowDialog(Me.ParentForm)
        ucrInputExpression.SetName(sdgTableRowExpression.GetRowExpression())
    End Sub

    'Public Sub SetValue(strValue As String)
    '    ucrInputExpression.SetName(strValue)
    'End Sub


    Public Function IsEmpty() As Boolean
        Return ucrInputExpression.IsEmpty()
    End Function

    Public Function GetValue() As String
        Return ucrInputExpression.GetText()
    End Function


End Class
