Public Class frmConvertToNumeric
    Private iNNonNumeric As Integer = 0
    Private strColumnName As String
    Private bFirstLoad As Boolean = True

    Private Sub frmConvertToNumeric_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
        End If
    End Sub

    Private Sub InitialiseDialog()
        cmdNormalConvert.DialogResult = DialogResult.Yes
        cmdLabelledConvert.DialogResult = DialogResult.No
        cmdCancel.DialogResult = DialogResult.Cancel
    End Sub

    Public Sub SetNonNumeric(iNumber As Integer)
        iNNonNumeric = iNumber
        lblN.Text = iNNonNumeric
    End Sub

    Public Sub SetColumnName(strName As String)
        strColumnName = strName
        lblColumnName.Text = strColumnName
    End Sub

    Private Sub frmConvertToNumeric_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub ConvertButtons_Click(sender As Object, e As EventArgs) Handles cmdNormalConvert.Click, cmdLabelledConvert.Click
        Me.Hide()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Hide()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TableOfContents)
        'Replace with specific page once written
        'Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, iHelpTopicID.ToString())
    End Sub

    Private Sub cmdNonNumeric_Click(sender As Object, e As EventArgs) Handles cmdNonNumeric.Click
        Me.Hide()
        dlgFindNonnumericValues.ShowDialog()
    End Sub
End Class