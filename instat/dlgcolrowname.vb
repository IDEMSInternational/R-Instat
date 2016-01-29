Public Class dlgcolrowname
    Private Sub btnClickCancel_Click(sender As Object, e As EventArgs) Handles btnClickCancel.Click
        Me.Hide()
    End Sub

    Private Sub cmdClickOk_Click(sender As Object, e As EventArgs) Handles cmdClickOk.Click
        Dim strk As String
        If txtcolrowname IsNot Nothing Then
            strk = frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data(data_name = " & Chr(34) & frmEditor.grdData.CurrentWorksheet.Name & Chr(34) & ", column_name = " &
        Chr(34) & frmEditor.grdData.CurrentWorksheet.GetColumnHeader(frmEditor.grdData.CurrentWorksheet.SelectionRange.Col).Text & Chr(34) & ", new_val = " & Chr(34) & txtcolrowname.Text & Chr(34) & ")"
            frmMain.clsRLink.RunScript(strk)
            Me.Hide()
        Else
            MessageBox.Show("Name cannot be empty")
            txtcolrowname.Focus()
        End If

    End Sub
End Class