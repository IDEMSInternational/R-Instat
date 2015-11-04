Public Class dlgBoxPlot
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub UcrButtons1_ClickOk(sender As Object, e As EventArgs) Handles UcrButtons1.ClickOk
        Dim strScript As String
        Dim temp
        Dim bFirst As Boolean

        bFirst = True
        If UcrDataSelection1.lstSelectedVariables.Items.Count > 0 Then
            strScript = "boxplot(data[c("
            For Each temp In UcrDataSelection1.lstSelectedVariables.Items
                If bFirst Then
                    bFirst = False
                Else
                    strScript = strScript & ","
                End If
                strScript = strScript & "'" & temp.ToString & "'"
            Next
            strScript = strScript & ")])"
            frmMain.clsRInterface.RunScript(strScript)
            Me.Hide()
        End If

    End Sub

    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles UcrButtons1.Load


    End Sub

    Private Sub UcrDataSelection1_Load(sender As Object, e As EventArgs) Handles UcrDataSelection1.Load

    End Sub
End Class

