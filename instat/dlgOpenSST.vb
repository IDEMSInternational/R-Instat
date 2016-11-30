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
Imports instat.Translations
Imports System.IO

Public Class dlgOpenSST
    'Private intLines As Integer
    Private clsReadCSV, clsReadLatLon, clsRList, clsReadLatLon0 As RFunction
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
        clsReadCSV = New RFunction
        clsReadLatLon = New RFunction
        clsRList = New RFunction
        clsReadLatLon0 = New RFunction
        ucrBaseOpenSST.clsRsyntax.SetFunction("import_CPT")
        ucrBaseOpenSST.clsRsyntax.AddParameter("dataset", clsRFunctionParameter:=clsReadCSV)
        clsReadLatLon.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")
        clsRList.SetRCommand("list")
        clsReadLatLon.AddParameter("data_tables", clsRFunctionParameter:=clsRList)
        clsReadLatLon0.SetRCommand("lat_lon_dataframe")
        clsReadLatLon0.AddParameter("dataset", clsRFunctionParameter:=clsReadCSV)
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
        'temp disabled until can easily switch between fread and read.csv
        'disabled until issue is resolved: http://stackoverflow.com/questions/37635541/rio-r-package-can-i-import-a-csv-file-with-non-comma-separator
        ucrInputSeparator.Enabled = False
        ucrInputFilePath.IsReadOnly = True
        'csv options settings
        clsReadCSV.AddParameter("check.names", "TRUE")
        clsReadCSV.AddParameter("header", "FALSE")
        ucrInputEncoding.SetItems({"unknown"})
        ucrInputSeparator.SetItems({"Automatic", ",", "Whitespace", ":", ";", "|", "^"})
        ucrInputDecimal.SetItems({"Automatic", ".", ","})
        nudSkip.Maximum = Integer.MaxValue
    End Sub

#Region "Shared options"
    Private Sub ucrInputName_NameChanged() Handles ucrInputName.NameChanged
        If Not ucrInputName.IsEmpty Then
            ucrBaseOpenSST.clsRsyntax.SetAssignTo(ucrInputName.GetText(), strTempDataframe:=ucrInputName.GetText())
            clsRList.AddParameter("lat_lon_data", clsRFunctionParameter:=clsReadLatLon0)
        Else
            ucrBaseOpenSST.clsRsyntax.RemoveAssignTo()
        End If
        TestOkEnabled()
    End Sub
#End Region

#Region "Dialog options"
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseOpenSST.ClickReset
        SetCSVDefault()
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrInputName.IsEmpty) AndAlso bCanImport Then
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
            dlgOpen.Filter = "All Data files|*.csv;*.tsv;*.txt|Comma separated files|*.csv|Tab separated files|*.tsv|Text Separated files|*.txt"
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
                    lblName.Show()
                    If strFileExt = ".csv" Then
                        clsReadCSV.SetRCommand("rio::import")
                        clsReadCSV.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                        grpCSV.Show()
                        strFileType = "csv"
                        ucrInputName.SetName(strFileName, bSilent:=True)
                        ucrInputName.Focus()
                        clsReadCSV.RemoveParameterByName("fread")
                        clsReadCSV.RemoveParameterByName("fill")
                    End If

                    If strFileExt = ".tsv" Then
                        clsReadCSV.SetRCommand("rio::import")
                        clsReadCSV.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                        grpCSV.Show()
                        strFileType = "tsv"
                        ucrInputName.SetName(strFileName, bSilent:=True)
                        ucrInputName.Focus()
                        clsReadCSV.AddParameter("fread", "FALSE")
                        clsReadCSV.AddParameter("fill", "TRUE")
                    End If
                    If strFileExt = ".txt" Then
                        clsReadCSV.SetRCommand("rio::import")
                        clsReadCSV.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                        grpCSV.Show()
                        strFileType = "txt"
                        ucrInputName.SetName(strFileName, bSilent:=True)
                        ucrInputName.Focus()
                        clsReadCSV.AddParameter("fread", "FALSE")
                        clsReadCSV.AddParameter("fill", "TRUE")
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
            clsReadCSV.AddParameter("encoding", ucrInputEncoding.GetText)
        Else
            clsReadCSV.RemoveParameterByName("encoding")
        End If

    End Sub

    Private Sub ucrInputDecimal_NameChanged() Handles ucrInputDecimal.NameChanged
        Select Case ucrInputDecimal.GetText
            Case "Automatic"
                clsReadCSV.RemoveParameterByName("dec")
            Case Else
                clsReadCSV.AddParameter("dec", Chr(34) & ucrInputDecimal.GetText() & Chr(34))
        End Select
    End Sub

    Private Sub ucrInputSeparator_NameChanged() Handles ucrInputSeparator.NameChanged
        Select Case ucrInputSeparator.GetText
            Case "Automatic"
                If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    clsReadCSV.AddParameter("sep", Chr(34) & "auto" & Chr(34))
                Else
                    clsReadCSV.RemoveParameterByName("sep")
                End If
                clsReadCSV.RemoveParameterByName("sep")
            Case "Whitespace"
                clsReadCSV.AddParameter("sep", Chr(34) & "" & Chr(34))
            Case ""
                clsReadCSV.RemoveParameterByName("sep")
            Case Else
                clsReadCSV.AddParameter("sep", Chr(34) & ucrInputSeparator.GetText() & Chr(34))
        End Select
    End Sub

    Private Sub ucrInputDecimal_TextChanged(sender As Object, e As EventArgs) Handles ucrInputDecimal.TextChanged
        Select Case ucrInputDecimal.GetText
            Case "Period"
                clsReadCSV.AddParameter("dec", Chr(34) & "." & Chr(34))
            Case "Comma"
                clsReadCSV.AddParameter("dec", Chr(34) & "," & Chr(34))
        End Select
    End Sub

    Private Sub nudDataFrom_ValueChanged(sender As Object, e As EventArgs) Handles nudDataFrom.ValueChanged
        If nudDataFrom.Value = 5 Then
            ucrBaseOpenSST.clsRsyntax.RemoveParameter("data_from")
        Else
            ucrBaseOpenSST.clsRsyntax.AddParameter("data_from", nudDataFrom.Value)
        End If
    End Sub

    Private Sub ucrInputNAStrings_NameChanged() Handles ucrInputNAStrings.NameChanged
        If ucrInputNAStrings.GetText() <> "" AndAlso (ucrInputNAStrings.GetText() <> "NA" OrElse frmMain.clsInstatOptions.bIncludeRDefaultParameters) Then
            clsReadCSV.AddParameter("na.strings", Chr(34) & ucrInputNAStrings.GetText() & Chr(34))
        Else
            clsReadCSV.RemoveParameterByName("na.strings")
        End If
    End Sub

    Private Sub ucrInputName_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub nudSkips_TextChanged(sender As Object, e As EventArgs) Handles nudSkip.TextChanged
        If bComponentsInitialised Then
            If nudSkip.Value = 0 Then
                clsReadCSV.RemoveParameterByName("skip")
            Else
                clsReadCSV.AddParameter("skip", nudSkip.Value)
            End If
        End If
    End Sub

    Private Sub cmdOpenDataSet_Click(sender As Object, e As EventArgs) Handles cmdOpenDataSet.Click
        GetFileFromOpenDialog()
    End Sub
#End Region

    Private Sub ucrBaseOpenSST_clickok(sender As Object, e As EventArgs) Handles ucrBaseOpenSST.ClickOk
        frmMain.clsRLink.RunScript(clsReadLatLon.ToScript(), 0)
    End Sub
End Class