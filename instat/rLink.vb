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
    Dim fOpen As New OpenFileDialog
    Dim dataset As DataFrame
    Dim headers As CharacterVector
    Dim holder As String


    'Sub open()
    '    'For importing files into the instat'
    '    'start the open file dialog
    '    fOpen.Filter = "Instat Worksheets (*.wor)|*.wor|Excel Worksheets (*.xlsx)|*.xlsx|Comma Separated (*.csv)|*.csv|
    'Minitab (*.mtw)|*.mtw|SPSS/Win (*.sav)|*.sav|Excel 2-5/95/97 (*.xls)|*.xls|All Files (*.*)|*.*"
    '    fOpen.Title = "Import file"
    '    'fOpen.ShowDialog()
    '    If fOpen.ShowDialog() = DialogResult.OK Then
    '        'checks if the file name is not blank'
    '        If fOpen.FileName <> "" Then
    '            frm_main.grid.Load(fOpen.FileName)
    '            frm_main.tstatus.Text = Path.GetFileNameWithoutExtension(fOpen.FileName)
    '        End If
    '    Else
    '        MsgBox("No File was selected!", vbInformation, "Message From Instat")
    '    End If
    'End Sub
    Sub dataframe()
        Dim engine As REngine = REngine.GetInstance()
        engine.Initialize()
        'For importing files into the instat'
        'start the open file dialog
        fOpen.Filter = "Instat Worksheets (*.wor)|*.wor|Excel Worksheets (*.xlsx)|*.xlsx|Comma Separated (*.csv)|*.csv|
Minitab (*.mtw)|*.mtw|SPSS/Win (*.sav)|*.sav|Excel 2-5/95/97 (*.xls)|*.xls|All Files (*.*)|*.*"
        fOpen.Title = "Import"
        If fOpen.ShowDialog() = DialogResult.OK Then
            'checks if the file name is not blank'
            If fOpen.FileName <> "" Then
                Dim extension As String = Path.GetExtension(fOpen.FileName)
                Dim sheet = frm_main.grid.CurrentWorksheet()
                Dim r_count As Double, c_count As Double
                holder = String.Empty
                Select Case extension
                    Case ".csv"
                        holder = Replace(fOpen.FileName, "\", "/")
                        dataset = engine.Evaluate("data<-as.data.frame(read.table('" & holder & "', header = T, sep = ','))").AsDataFrame
                        headers = engine.Evaluate("headers<-colnames(data)").AsCharacter
                        engine.Evaluate("r<-nrow(data)")
                        r_count = engine.GetSymbol("r").AsNumeric().First()
                        engine.Evaluate("c<-ncol(data)")
                        c_count = engine.GetSymbol("c").AsNumeric().First()
                        sheet.Rows = r_count
                        sheet.Name = Path.GetFileNameWithoutExtension(fOpen.FileName)
                        For i As Integer = 0 To r_count - 1
                            For k As Integer = 0 To c_count - 1
                                sheet.ColumnHeaders(k).Text = headers(k)
                                sheet(row:=i, col:=k) = dataset(i, k)
                            Next
                        Next
                        engine.Dispose()
                End Select
            Else
                MsgBox("Must have a file name!", vbCritical, "Message from Instat")
            End If
        Else
            MsgBox("No File was selected!", vbAbort, "Message From Instat")
        End If
        frm_main.tstatus.Text = Path.GetFileNameWithoutExtension(fOpen.FileName)
    End Sub
End Class
