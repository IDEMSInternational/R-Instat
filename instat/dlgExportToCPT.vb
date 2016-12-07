' Instat-R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports System.IO
Imports instat.Translations
Public Class dlgExportToCPT
    Public bFirstLoad As Boolean = True
    Private clsWriteTXT, clsOutPut, clsWriteCSV, clsWriteXLSX, clsWriteOthers As New RFunction
    Private Sub dlgExportToCPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        txtExportFile.Text = ""
        chkLong.Checked = True
        ucrReceiverYears.SetMeAsReceiver()
        ucrSSTDataframe.Reset()
        ucrLocationDataFrame.Reset()
    End Sub

    Private Sub InitialiseDialog()
        clsOutPut.SetRCommand("output_for_CPT")
        ucrReceiverMultipleDataColumns.Selector = ucrSSTDataframe
        ucrReceiverDataColumn.Selector = ucrSSTDataframe
        ucrReceiverYears.Selector = ucrSSTDataframe
        ucrReceiverStations.Selector = ucrSSTDataframe
        ucrLocationDataFrame.lblDataFrame.Text = "Location:"
    End Sub

    Private Sub TestOkEnabled()
        If (txtExportFile.Text <> "" AndAlso (Not ucrReceiverYears.IsEmpty) AndAlso ((chkLong.Checked AndAlso (Not ucrReceiverStations.IsEmpty) AndAlso (Not ucrReceiverDataColumn.IsEmpty)) OrElse ((Not chkLong.Checked) AndAlso (Not ucrReceiverMultipleDataColumns.IsEmpty)))) Then
            ucrBaseExportToCPT.OKEnabled(True)
        Else
            ucrBaseExportToCPT.OKEnabled(False)
        End If
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim dlgSave As New SaveFileDialog
        dlgSave.Title = "Export file dialog"
        dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
        'dlgSave.Filter = "Comma separated file (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|TAB-separated data (*.tsv)|*.tsv|Pipe-separated data (*.psv)|*.psv|Feather r / Python interchange format (*.feather)|*.feather|Fixed-Width format data (*.fwf)|*.fwf|Serialized r objects (*.rds)|*.rds|Saved r objects (*.RData)|*.RData|JSON(*.json)|*.json|YAML(*.yml)|*.yml|Stata(*.dta)|*.dta|SPSS(*.sav)|*.sav|XBASE database files (*.dbf)|*.dbf| Weka Attribute - Relation File Format (*.arff)|*.arff|r syntax object (*.R)|*.R|Xml(*.xml)|*.xml|HTML(*.html)|*.html"
        dlgSave.Filter = "Text separated file (*.txt)|*.txt"
        If dlgSave.ShowDialog = DialogResult.OK Then
            If dlgSave.FileName <> "" Then
                txtExportFile.Text = Path.GetFileName(dlgSave.FileName)
                SaveFileType(dlgSave.FileName.Replace("\", "/"))
            End If
        End If
    End Sub

    Private Sub txtExportFile_Click(sender As Object, e As EventArgs) Handles txtExportFile.Click
        cmdBrowse_Click(sender, e)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseExportToCPT.ClickReset
        SetDefaults()
    End Sub

    Private Sub chkLong_CheckedChanged(sender As Object, e As EventArgs) Handles chkLong.CheckedChanged
        ucrReceiverYears.Focus()
        If chkLong.Checked Then
            clsOutPut.AddParameter("long", "TRUE")
            lblStations.Visible = True
            ucrReceiverStations.Visible = True
            lblDataColumn.Visible = True
            ucrReceiverDataColumn.Visible = True
            lblDataColumns.Visible = False
            ucrReceiverMultipleDataColumns.Visible = False
        Else
            clsOutPut.AddParameter("long", "FALSE ")
            lblDataColumns.Visible = True
            ucrReceiverMultipleDataColumns.Visible = True
            lblStations.Visible = False
            ucrReceiverStations.Visible = False
            lblDataColumn.Visible = False
            ucrReceiverDataColumn.Visible = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSSTDataframe_DataFrameChanged() Handles ucrSSTDataframe.DataFrameChanged
        clsOutPut.AddParameter("data_name", clsRFunctionParameter:=ucrSSTDataframe.ucrAvailableDataFrames.clsCurrDataFrame)
        TestOkEnabled()
    End Sub

    Private Sub txtExportFile_TextChanged(sender As Object, e As EventArgs) Handles txtExportFile.TextChanged
        TestOkEnabled()
    End Sub

    Private Sub SaveFileType(strFilePath As String)
        Select Case Path.GetExtension(strFilePath)
            Case ".txt"
                clsWriteTXT.SetRCommand("rio::export")
                clsWriteTXT.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteTXT.AddParameter("x", clsRFunctionParameter:=clsOutPut)
                clsWriteTXT.AddParameter("sep", Chr(34) & "\t" & Chr(34))
                clsWriteTXT.AddParameter("quote", "FALSE")
                clsWriteTXT.AddParameter("row.names", "FALSE")
                clsWriteTXT.AddParameter("col.names", "TRUE")
                ucrBaseExportToCPT.clsRsyntax.SetBaseRFunction(clsWriteTXT)
                'Case ".csv"
                '    clsWriteCSV.SetRCommand("rio::export")
                '    'chkOptions.Enabled = False
                '    'grpOptions.Enabled = False
                '    clsWriteCSV.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                '    clsWriteCSV.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.ucrAvailableDataFrames.clsCurrDataFrame)
                '    ucrBase.clsRsyntax.SetBaseRFunction(clsWriteCSV)
                'Case ".xlsx"
                '    clsWriteXLSX.SetRCommand("rio::export")
                '    'temp disabled
                '    'chkOptions.Enabled = True
                '    clsWriteXLSX.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                '    clsWriteXLSX.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                '    ucrBase.clsRsyntax.SetBaseRFunction(clsWriteXLSX)
                'TAB-separated data (.tsv), using write.table with row.names = FALSE.

                'Case ".tsv", ".psv", ".feather", ".fwf", ".rds", ".RData", ".json", ".yml", ".dta", ".sav", ".dbf", ".arff", ".R", ".xml", ".html"
                '    clsWriteOthers.SetRCommand("rio::export")
                '    'temp disabled
                '    'chkOptions.Enabled = True
                '    clsWriteOthers.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                '    clsWriteOthers.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                '    ucrBase.clsRsyntax.SetBaseRFunction(clsWriteOthers)
        End Select
    End Sub

    Private Sub ucrLocationDataFrame_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrLocationDataFrame.DataFrameChanged
        clsOutPut.AddParameter("lat_lon_data", clsRFunctionParameter:=ucrLocationDataFrame.clsCurrDataFrame)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverDataColumn_Load(sender As Object, e As EventArgs) Handles ucrReceiverDataColumn.Load

    End Sub

    Private Sub ucrReceiverYears_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverYears.SelectionChanged
        clsOutPut.AddParameter("year_col", ucrReceiverYears.GetVariableNames(bWithQuotes:=True))
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverStations_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverStations.SelectionChanged
        If chkLong.Checked Then
            clsOutPut.AddParameter("station_col", ucrReceiverStations.GetVariableNames(bWithQuotes:=True))
        Else
            clsOutPut.RemoveParameterByName("station_col")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverMultipleDataColumns_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverMultipleDataColumns.SelectionChanged
        clsOutPut.AddParameter("sst_cols", ucrReceiverMultipleDataColumns.GetVariableNames(bWithQuotes:=True))
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverDataColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDataColumn.SelectionChanged
        clsOutPut.AddParameter("sst_cols", ucrReceiverDataColumn.GetVariableNames(bWithQuotes:=True))
        TestOkEnabled()
    End Sub
End Class