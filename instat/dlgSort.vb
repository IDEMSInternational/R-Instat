
Imports RDotNet
Public Class dlgSort
    Private Sub UcrButtons1_clickOk(sender As Object, e As EventArgs) Handles UcrButtons1.ClickOk
        Dim strScript As String
        Dim temp
        Dim bFirst As Boolean
        Dim newdata As DataFrame


        bFirst = True
        If UcrDataSelection1.lstSelectedVariables.Items.Count > 0 Then
            strScript = "data<-data[order(data["
            For Each temp In UcrDataSelection1.lstSelectedVariables.Items
                If bFirst Then
                    bFirst = False
                Else
                    strScript = strScript & "],data["
                End If
                strScript = strScript & Chr(34) & temp.ToString & Chr(34)
            Next
            strScript = strScript & "]),]"
            frmMain.clsRInterface.RunScript(strScript, False)
        End If
        newdata = frmMain.clsRInterface.GetData("data")
        frmEditor.UpdateSheet(newdata)
        Me.Close()
    End Sub
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles UcrButtons1.ClickOk

    End Sub

    Private Sub dlgSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class