Public Class ucrInputTextBox
    Public Overloads Sub SetName(strName As String)
        If IsValid(strName) Then
            txtInput.Text = strName
        Else
            MsgBox(strName & "is not a valid for this textbox", vbOKOnly)
        End If


    End Sub

    Private Sub txtInput_Leave(sender As Object, e As EventArgs) Handles txtInput.Leave
        ValidateText(txtInput.Text, txtInput)
    End Sub
End Class
