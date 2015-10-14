Public Class frmLineTest
    Private Sub frmLineTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Protected Sub btnFirst_Click(ByVal sender As Object,
 ByVal e As System.EventArgs) Handles btnFirst.Click
        Dim oLine As LineDelim = New LineDelim()

        oLine.Line = txtLine.Text
        txtFirstWord.Text = oLine.GetWord()
    End Sub

End Class