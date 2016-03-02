Public Class ucrInputTextBox
    Public Overrides Sub SetName(strName As String)
        If IsValid(strName) Then
            txtInput.Text = strName
            OnNameChanged()
        Else
            MsgBox(strName & "is not a valid for this textbox", vbOKOnly)
        End If
    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        bUserTyped = True
    End Sub

    Private Sub txtInput_Leave(sender As Object, e As EventArgs) Handles txtInput.Leave
        ValidateText(txtInput.Text, txtInput)
    End Sub


End Class
