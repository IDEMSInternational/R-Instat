Public Class dlgDescriptiveStatistics

    Private Sub UcrButtons1_clickOk(sender As Object, e As EventArgs) Handles UcrButtons1.ClickOk
        Dim strScript As String
        Dim temp
        Dim bFirst As Boolean

        bFirst = True
        If UcrDataSelection1.lstSelectedVariables.Items.Count > 0 Then
            strScript = "summary(data[c("
            For Each temp In UcrDataSelection1.lstSelectedVariables.Items
                If bFirst Then
                    bFirst = False
                Else
                    strScript = strScript & ","
                End If
                strScript = strScript & Chr(34) & temp.ToString & Chr(34)
            Next
            strScript = strScript & ")])"
            frmMain.clsRInterface.RunScript(strScript)
        End If

    End Sub

    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles UcrButtons1.Load


    End Sub

    Private Sub dlgDescriptiveStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpgraphics.Visible = False
    End Sub

    Private Sub chkGraphics_CheckedChanged(sender As Object, e As EventArgs) Handles chkGraphics.CheckedChanged
        If chkGraphics.Checked = True Then
            grpgraphics.Visible = True
        End If
        If chkGraphics.Checked = False Then
            grpgraphics.Visible = False
        End If
    End Sub

    Private Sub UcrDataSelection1_Load(sender As Object, e As EventArgs) Handles UcrDataSelection1.Load

    End Sub
End Class