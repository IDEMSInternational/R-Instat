Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports instat.frm_datasheet


Public Class frm_first
    Private Excel03ConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
    Private Excel07ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"

    
    Private Sub frm_first_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets the children forms
        frm_datasheet.MdiParent = Me
        frm_datasheet.Show()
        frm_cmd_window.MdiParent = Me
        'frm_cmd_window.Show()

    End Sub

    Private Sub OpenToolBtn_Click(sender As Object, e As EventArgs) Handles OpenToolBtn.Click
        'OpenFile.ShowDialog()
        'Dim dia As New OpenFileDialog
        OpenFile.Filter = "Instat Worksheets (*.wor)|*.wor|Excel Worksheets (*.xlsx)|*.xlsx|Comma Separated (*.csv)|*.csv|
Minitab (*.mtw)|*.mtw|SPSS/Win (*.sav)|*.sav|Excel 2-5/95/97 (*.xls)|*.xls|All Files (*.*)|*.*"

        If OpenFile.ShowDialog(Me) = DialogResult.OK Then

            Dim reader As New StreamReader(OpenFile.FileName)
            Dim data As String = reader.ReadToEnd

            reader.Close()
            'txtBox.Text = data

        End If


    End Sub

    Private Sub openFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFile.FileOk
        Dim filePath As String = OpenFile.FileName
        Dim extension As String = Path.GetExtension(filePath)
        'Dim header As String = If(rbHeaderYes.Checked, "YES", "NO")
        Dim header As String = ("Yes")
        Dim conStr As String, sheetName As String

        conStr = String.Empty
        Select Case extension

            Case ".xls"
                'Excel 97-03
                conStr = String.Format(Excel03ConString, filePath, header)
                Exit Select

            Case ".xlsx"
                'Excel 07
                conStr = String.Format(Excel07ConString, filePath, header)
                Exit Select
        End Select

        'Get the name of the First Sheet.
        Using con As New OleDbConnection(conStr)
            Using cmd As New OleDbCommand()
                cmd.Connection = con
                con.Open()
                Dim dtExcelSchema As DataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                sheetName = dtExcelSchema.Rows(0)("TABLE_NAME").ToString()
                con.Close()
            End Using
        End Using

        'Read Data from the First Sheet.
        Using con As New OleDbConnection(conStr)
            Using cmd As New OleDbCommand()
                Using oda As New OleDbDataAdapter()
                    Dim dt As New DataTable()
                    cmd.CommandText = (Convert.ToString("SELECT * From [") & sheetName) + "]"
                    cmd.Connection = con
                    con.Open()
                    oda.SelectCommand = cmd
                    oda.Fill(dt)
                    con.Close()




                    'Populate DataGridView.
                    frm_datasheet.dtViewData.DataSource = dt
                    frm_datasheet.grid.Load(filePath)
                    'dataGridView1.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click

    End Sub

    Private Sub Menu_Strip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Menu_Strip.ItemClicked

    End Sub
End Class
