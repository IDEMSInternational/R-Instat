Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports instat.frm_datasheet


Public Class frm_first

    Private Sub frm_first_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets the children forms
        frm_datasheet.MdiParent = Me
        frm_datasheet.Show()
        frm_cmd_window.MdiParent = Me
        'frm_cmd_window.Show()

    End Sub

    Private Sub OpenToolBtn_Click(sender As Object, e As EventArgs) Handles OpenToolBtn.Click
        OpenFile.Filter = "Instat Worksheets (*.wor)|*.wor|Excel Worksheets (*.xlsx)|*.xlsx|Comma Separated (*.csv)|*.csv|
Minitab (*.mtw)|*.mtw|SPSS/Win (*.sav)|*.sav|Excel 2-5/95/97 (*.xls)|*.xls|All Files (*.*)|*.*"

        If OpenFile.ShowDialog(Me) = DialogResult.OK Then


        End If


    End Sub

    Private Sub openFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFile.FileOk
        Dim filePath As String = OpenFile.FileName
        Dim extension As String = Path.GetExtension(filePath)
        'Populate Grid
        frm_datasheet.grid.Load(filePath)
        'dataGridView1.DataSource = dt
    End Sub

End Class
