Imports RDotNet
Public Class dlgPlot
    Private Sub UcrButtons1_clickOk(sender As Object, e As EventArgs) Handles UcrButtons1.ClickOk
        Dim strScript As String

        strScript = "plot( data$" & txtY.Text & "  , data$" & txtX.Text & ", main = '" & txtTitle.Text & " ' ) "
        frmMain.clsRInterface.RunScript(strScript, False)
    End Sub
    Private Sub dlgPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset As DataFrame
        Dim i As Integer

        dataset = frmMain.clsRInterface.GetData("data")
        For i = 0 To dataset.ColumnCount - 1
            lstBoxAvailable.Items.Add(dataset.ColumnNames(i))
        Next
    End Sub
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If txtY.Text <> "" Then
            txtY.Text = txtY.Text & "," & lstBoxAvailable.SelectedItem.ToString
        ElseIf (txtY.Text = "") Then
            txtY.Text = lstBoxAvailable.SelectedItem.ToString
        Else
            MsgBox("No item was selected", vbInformation, "Selection message")
        End If


        'If (lstBoxAvailable.SelectedItem <> "") Then
        '    txtY.Text = lstBoxAvailable.SelectedItem.ToString
        'Else
        '    MsgBox("No item was selected", vbInformation, "Selection message")
        'End If

        'If (lstBoxAvailable.SelectedItem <> "") And txtY.Text <> "" Then
        '    txtY.Text = lstBoxAvailable.SelectedItem.ToString & ", " & txtY.Text = lstBoxAvailable.SelectedItem.ToString
        'Else
        '    MsgBox("No item was selected", vbInformation, "Selection message")
        'End If

    End Sub

    Private Sub cmdRemove_Click(sender As Object, e As EventArgs) Handles cmdRemove.Click
        If (lstBoxAvailable.SelectedItem <> "") Then
            txtX.Text = lstBoxAvailable.SelectedItem.ToString
        Else
            MsgBox("No item was selected", vbInformation, "Selection message")
        End If
    End Sub
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles UcrButtons1.Load

    End Sub
    Private Sub txtY_TextChanged(sender As Object, e As EventArgs) Handles txtY.TextChanged

    End Sub
End Class