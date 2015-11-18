Imports instat.Translations
Public Class ucrButtons
    Public clsRsyntax As New RSyntax

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.ParentForm.Hide()
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        EmptyTxt()
    End Sub

    Public Event ClickOk(sender As Object, e As EventArgs)
    Public Event ClickReset(sender As Object, e As EventArgs)

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If clsRsyntax.iFunctionType = 1 Then
            frmMain.clsRInterface.RunScript(clsRsyntax.writeScript(), clsRsyntax.iCallType)
        ElseIf clsRsyntax.iFunctionType = 2
            frmMain.clsRInterface.RunScript(clsRsyntax.orderScript(), clsRsyntax.iCallType)
        Else
            frmMain.clsRInterface.RunScript(clsRsyntax.GetScript(), clsRsyntax.iCallType)
        End If
        RaiseEvent ClickOk(sender, e)
    End Sub
    Public Sub EmptyTxt()
        Dim Ctrl As Control
        For Each Ctrl In Me.ParentForm.Controls
            If TypeOf Ctrl Is TextBox Then Ctrl.Text = ""
            If TypeOf Ctrl Is GroupBox Then
                Dim Ctrl1 As Control
                For Each Ctrl1 In Ctrl.Controls
                    If TypeOf Ctrl1 Is TextBox Then
                        Ctrl1.Text = ""
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub ucrButtons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        translateEach(Controls)
    End Sub
End Class
