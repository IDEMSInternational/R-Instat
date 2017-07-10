' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Imports System.IO

Public Class dlgOpenSST
    'Private intLines As Integer
    Private clsReadFile As RFunction
    Private clsRBaseCPT, clsBaseNetCDF, clsRCDF As New RFunction
    Private strTempWorkbookName As String
    Dim bFirstLoad As Boolean
    Dim strFileType As String
    Dim bCanImport As Boolean
    Dim bComponentsInitialised As Boolean
    Public bStartOpenDialog As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'intLines = 10
        clsReadFile = New RFunction
        clsRBaseCPT.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_SST")
        clsRBaseCPT.AddParameter("dataset", clsRFunctionParameter:=clsReadFile)
        clsBaseNetCDF.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_NetCDF")
        clsBaseNetCDF.AddParameter("nc_data", clsRFunctionParameter:=clsRCDF)

        bFirstLoad = True
        bCanImport = True
        bComponentsInitialised = True
        bStartOpenDialog = True
        ucrInputName.bAutoChangeOnLeave = True
    End Sub

    Private Sub dlgImportDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        Me.Show()
        If bFirstLoad Then
            InitialiseDialog()
            SetCSVDefault()
            bFirstLoad = False
        End If
        If bStartOpenDialog Then
            GetFileFromOpenDialog()
            bStartOpenDialog = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseOpenSST.iHelpTopicID = 102
        ucrInputName.SetValidationTypeAsRVariable()
        ucrInputNameLocation.SetValidationTypeAsRVariable()
        ucrInputNameLocation.SetName("lat_lon_data")
        'temp disabled until can easily switch between fread and read.csv
        'disabled until issue is resolved: http://stackoverflow.com/questions/37635541/rio-r-package-can-i-import-a-csv-file-with-non-comma-separator
        ucrInputSeparator.Enabled = False
        ucrInputFilePath.IsReadOnly = True
        'csv options settings
        clsReadFile.AddParameter("check.names", "TRUE")
        clsReadFile.AddParameter("header", "FALSE")
        ucrInputEncoding.SetItems({"unknown"})
        ucrInputSeparator.SetItems({"Automatic", ",", "Whitespace", ":", ";", "|", "^"})
        ucrInputDecimal.SetItems({"Automatic", ".", ","})
        nudSkip.Maximum = Integer.MaxValue
    End Sub

#Region "Shared options"
    Private Sub ucrInputDataName_NameChanged() Handles ucrInputName.NameChanged, ucrInputNameLocation.NameChanged
        ucrBaseOpenSST.clsRsyntax.AddParameter("data_names", "c(" & Chr(34) & ucrInputName.GetText() & Chr(34) & "," & Chr(34) & ucrInputNameLocation.GetText() & Chr(34) & ")")
    End Sub

#End Region

#Region "Dialog options"
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseOpenSST.ClickReset
        SetCSVDefault()
    End Sub

    Private Sub TestOkEnabled()
        If bCanImport Then
            ucrBaseOpenSST.OKEnabled(True)
        Else
            ucrBaseOpenSST.OKEnabled(False)
        End If
    End Sub
#End Region

#Region "Import options"
    'Loads the open dialog on load and click
    Public Sub GetFileFromOpenDialog()
        Dim strFilePath As String = ""
        Dim strFileName As String = ""
        Dim strFileExt As String = ""
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "All Data files|*.csv;*.tsv;*.txt;*.nc|Comma separated files|*.csv|Tab separated files|*.tsv|Text Separated files|*.txt|NetCDF files|*.nc"
            dlgOpen.Title = "Open Data from file"
            If Not ucrInputFilePath.IsEmpty() Then
                dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(ucrInputFilePath.GetText(), "/", "\"))
            Else
                dlgOpen.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If

            If dlgOpen.ShowDialog() = DialogResult.OK Then
                ucrInputName.SetName("")
                ucrInputName.Reset()
                'checks if the file name is not blank'
                If dlgOpen.FileName <> "" Then
                    strFileName = Path.GetFileNameWithoutExtension(dlgOpen.FileName)
                    strFilePath = Replace(dlgOpen.FileName, "\", "/")
                    strFileExt = Path.GetExtension(strFilePath)
                    ucrInputFilePath.SetName(strFilePath)
                    ucrInputName.Show()
                    lblSSTName.Show()
                    If strFileExt = ".csv" OrElse strFileExt = ".tsv" OrElse strFileExt = ".txt" Then
                        ucrBaseOpenSST.clsRsyntax.SetBaseRFunction(clsRBaseCPT)
                    ElseIf strFileExt = ".nc"
                        ucrBaseOpenSST.clsRsyntax.SetBaseRFunction(clsBaseNetCDF)
                    End If
                    If strFileExt = ".csv" Then
                        clsReadFile.SetRCommand("rio::import")
                        clsReadFile.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                        grpCSV.Show()
                        strFileType = "csv"
                        ucrInputName.SetName(strFileName, bSilent:=True)
                        ucrInputName.Focus()
                        clsReadFile.RemoveParameterByName("fread")
                        clsReadFile.RemoveParameterByName("fill")
                    End If

                    If strFileExt = ".tsv" Then
                        clsReadFile.SetRCommand("rio::import")
                        clsReadFile.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                        grpCSV.Show()
                        strFileType = "tsv"
                        ucrInputName.SetName(strFileName, bSilent:=True)
                        ucrInputName.Focus()
                        clsReadFile.AddParameter("fread", "FALSE")
                        clsReadFile.AddParameter("fill", "TRUE")
                    End If
                    If strFileExt = ".txt" Then
                        clsReadFile.SetRCommand("rio::import")
                        clsReadFile.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                        grpCSV.Show()
                        strFileType = "txt"
                        ucrInputName.SetName(strFileName, bSilent:=True)
                        ucrInputName.Focus()
                        clsReadFile.AddParameter("fread", "FALSE")
                        clsReadFile.AddParameter("fill", "TRUE")
                    End If

                    If strFileExt = ".nc" Then
                        clsRCDF.SetRCommand("nc_open")
                        clsRCDF.AddParameter("filename", Chr(34) & strFilePath & Chr(34))
                        grpCSV.Show()
                        strFileType = "nc"
                        ucrInputName.SetName(strFileName, bSilent:=True)
                        ucrInputName.Focus()
                    End If
                End If
            Else
                If ucrInputFilePath.GetText() = "" Then
                    grpCSV.Hide()
                End If
            End If
            TestOkEnabled()
        End Using
    End Sub

#End Region

#Region "CSV options"
    Private Sub SetCSVDefault()
        ucrInputEncoding.SetName("unknown")
        ucrInputSeparator.SetName("Automatic")
        ucrInputDecimal.SetName("Automatic")
        ucrInputNAStrings.SetName("NA")
        nudSkip.Value = 0
        chkStringsAsFactors.Checked = True
    End Sub

    Private Sub ucrInputEncoding_NameChanged() Handles ucrInputEncoding.NameChanged

        If ucrInputEncoding.GetText() <> "" AndAlso (ucrInputEncoding.GetText() <> "unknown" OrElse frmMain.clsInstatOptions.bIncludeRDefaultParameters) Then
            clsReadFile.AddParameter("encoding", ucrInputEncoding.GetText)
        Else
            clsReadFile.RemoveParameterByName("encoding")
        End If

    End Sub

    Private Sub ucrInputDecimal_NameChanged() Handles ucrInputDecimal.NameChanged
        Select Case ucrInputDecimal.GetText
            Case "Automatic"
                clsReadFile.RemoveParameterByName("dec")
            Case Else
                clsReadFile.AddParameter("dec", Chr(34) & ucrInputDecimal.GetText() & Chr(34))
        End Select
    End Sub

    Private Sub ucrInputSeparator_NameChanged() Handles ucrInputSeparator.NameChanged
        Select Case ucrInputSeparator.GetText
            Case "Automatic"
                If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    clsReadFile.AddParameter("sep", Chr(34) & "auto" & Chr(34))
                Else
                    clsReadFile.RemoveParameterByName("sep")
                End If
                clsReadFile.RemoveParameterByName("sep")
            Case "Whitespace"
                clsReadFile.AddParameter("sep", Chr(34) & "" & Chr(34))
            Case ""
                clsReadFile.RemoveParameterByName("sep")
            Case Else
                clsReadFile.AddParameter("sep", Chr(34) & ucrInputSeparator.GetText() & Chr(34))
        End Select
    End Sub

    Private Sub ucrInputDecimal_TextChanged(sender As Object, e As EventArgs) Handles ucrInputDecimal.TextChanged
        Select Case ucrInputDecimal.GetText
            Case "Period"
                clsReadFile.AddParameter("dec", Chr(34) & "." & Chr(34))
            Case "Comma"
                clsReadFile.AddParameter("dec", Chr(34) & "," & Chr(34))
        End Select
    End Sub

    Private Sub nudDataFrom_ValueChanged(sender As Object, e As EventArgs) Handles nudDataFrom.ValueChanged
        If nudDataFrom.Value = 5 Then
            clsRBaseCPT.RemoveParameterByName("data_from")
        Else
            clsRBaseCPT.AddParameter("data_from", nudDataFrom.Value)
        End If
    End Sub

    Private Sub ucrInputNAStrings_NameChanged() Handles ucrInputNAStrings.NameChanged
        If ucrInputNAStrings.GetText() <> "" AndAlso (ucrInputNAStrings.GetText() <> "NA" OrElse frmMain.clsInstatOptions.bIncludeRDefaultParameters) Then
            clsReadFile.AddParameter("na.strings", Chr(34) & ucrInputNAStrings.GetText() & Chr(34))
        Else
            clsReadFile.RemoveParameterByName("na.strings")
        End If
    End Sub

    Private Sub nudSkips_TextChanged(sender As Object, e As EventArgs) Handles nudSkip.TextChanged
        If bComponentsInitialised Then
            If nudSkip.Value = 0 Then
                clsReadFile.RemoveParameterByName("skip")
            Else
                clsReadFile.AddParameter("skip", nudSkip.Value)
            End If
        End If
    End Sub

    Private Sub cmdOpenDataSet_Click(sender As Object, e As EventArgs) Handles cmdOpenDataSet.Click
        GetFileFromOpenDialog()
    End Sub

#End Region
End Class