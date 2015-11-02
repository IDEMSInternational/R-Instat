Imports RDotNet
Imports System.IO
Public Class frmMain
    Public clsRInterface As New RInterface
    Public clsRSyntax As New RSyntax
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmEditor.MdiParent = Me
        frmCommand.MdiParent = Me
        'frmGraphics.MdiParent = Me
        frmLog.MdiParent = Me
        frmScript.MdiParent = Me
        frmLog.MdiParent = Me
        Me.LayoutMdi(MdiLayout.ArrangeIcons)

        'frmCommand.Dock = DockStyle.Fill
        frmEditor.Dock = DockStyle.Left
        frmEditor.Dock = DockStyle.Fill
        frmCommand.Dock = DockStyle.Right
        frmLog.Dock = DockStyle.Right
        frmLog.Dock = DockStyle.Bottom

        frmCommand.Show()
        frmEditor.Show()
        frmLog.Show()
        clsRInterface.SetLog(frmLog.txtLog)
        clsRInterface.SetOutput(frmCommand.txtCommand)

    End Sub

    Private Sub ImportASCIIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFIleIEASCII.Click

        Dim dlgOpen As New OpenFileDialog
        Dim strExtension As String
        Dim strHolder As String
        Dim dataset As DataFrame

        'For importing files into the instat'
        'start the open file dialog
        dlgOpen.Filter = "Comma Separated (*.csv)|*.csv|Excel 2-5/95/97 (*.xls)|*.xls|All Files (*.*)|*.*"
        dlgOpen.Title = "Import"
        If dlgOpen.ShowDialog() = DialogResult.OK Then
            'checks if the file name is not blank'
            If dlgOpen.FileName <> "" Then
                strExtension = Path.GetExtension(dlgOpen.FileName)
                strHolder = Replace(dlgOpen.FileName, "\", "/")
                clsRInterface.LoadData(strExtension, strHolder)
            Else
                MsgBox("Must have a file name!", vbInformation, "Message from Instat")
            End If
        Else
            MsgBox("No File was selected!", vbInformation, "Message From Instat")
        End If

        dataset = clsRInterface.GetData("data")
        frmEditor.UpdateSheet()
    End Sub



    Private Sub DescribeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescribeToolStripMenuItem.Click
        'dlgDescriptiveStatistics.Show()
    End Sub

    Private Sub mnuFileOpenWorksheet_Click(sender As Object, e As EventArgs) Handles mnuFileOpenWorksheet.Click

    End Sub

    Private Sub CutCtrlXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click

    End Sub

    Private Sub mnuBar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuBar.ItemClicked

    End Sub

    Private Sub mnuManageRegular_Click(sender As Object, e As EventArgs) Handles mnuManageRegular.Click
        dlgRegularSequence.Show()
    End Sub
End Class