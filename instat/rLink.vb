Imports RDotNet
Imports System.IO
Imports System
Imports System.Data
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports RDotNet.DataFrame
Imports instat.frm_main
Public Class rLink
    ' The link between vb.Net and R'
    Dim climateObjectPath As String = "C:/ClimateObject" 'Location of the Climate object'
    Dim engine As REngine
    Dim fOpen As New OpenFileDialog
    Dim holder As String


    Sub open()
        'For importing files into the instat'
        'start the open file dialog
        fOpen.Filter = "Instat Worksheets (*.wor)|*.wor|Excel Worksheets (*.xlsx)|*.xlsx|Comma Separated (*.csv)|*.csv|
Minitab (*.mtw)|*.mtw|SPSS/Win (*.sav)|*.sav|Excel 2-5/95/97 (*.xls)|*.xls|All Files (*.*)|*.*"
        fOpen.Title = "Import file"
        'fOpen.ShowDialog()
        If fOpen.ShowDialog() = DialogResult.OK Then
            'checks if the file name is not blank'
            If fOpen.FileName <> "" Then
                frm_main.grid.Load(fOpen.FileName)
                frm_main.tstatus.Text = Path.GetFileNameWithoutExtension(fOpen.FileName)
            End If
        Else
            MsgBox("No File was selected!", , "Message From Instat")
        End If
    End Sub
End Class
