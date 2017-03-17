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

Public Class dlgOpenNetCDF
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRDefaultFunction, clsRCDF, clsRDatanames As New RFunction

    'Private clsBaseNetCDF, clsRCDF As New RFunction
    'Dim bFirstLoad As Boolean
    Dim strFileType As String
    'Dim bCanImport As Boolean
    Dim bComponentsInitialised As Boolean
    Public bStartOpenDialog As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        'clsBaseNetCDF.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_NetCDF")
        'clsBaseNetCDF.AddParameter("nc_data", clsRFunctionParameter:=clsRCDF)
        bFirstLoad = True
        'bCanImport = True
        bComponentsInitialised = True
        bStartOpenDialog = True
        ucrInputDataName.bAutoChangeOnLeave = True
    End Sub

    Private Sub dlgOpenNetCDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        Me.Show()
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bStartOpenDialog Then
            GetFileFromOpenDialog()
            bStartOpenDialog = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()

        'autoTranslate(Me)
        'Me.Show()
        'If bFirstLoad Then
        '    InitialiseDialog()
        '    SetCSVDefault()
        '    bFirstLoad = False
        'End If
        'If bStartOpenDialog Then
        '    GetFileFromOpenDialog()
        '    bStartOpenDialog = False
        'End If
        'TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputDataName.SetRCode(clsRDatanames, bReset)
        ucrInputLocDataName.SetRCode(clsRDatanames, bReset)
        ucrInputFilePath.SetRCode(clsRCDF, bReset)
    End Sub

    Private Sub SetDefaults()
        clsRDefaultFunction = New RFunction
        ucrInputLocDataName.SetName("lat_lon_data")
        ucrInputDataName.SetName("")
        ucrInputFilePath.IsReadOnly = True
        ucrInputFilePath.SetName("")
        clsRDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_NetCDF")
        clsRDefaultFunction.AddParameter("nc_data", clsRFunctionParameter:=clsRCDF)
        clsRDefaultFunction.AddParameter("data_names", clsRFunctionParameter:=clsRDatanames)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRDefaultFunction)
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.iHelpTopicID = 
        ucrInputDataName.SetValidationTypeAsRVariable()
        ucrInputLocDataName.SetValidationTypeAsRVariable()
        'clsSummariesList = New RFunction
        clsRDatanames.SetRCommand("c")
        ucrInputDataName.SetParameter(New RParameter("data_df_name", 0))
        ucrInputDataName.clsParameter.bIncludeArgumentName = False
        ucrInputLocDataName.SetParameter(New RParameter("location_df_name", 1))
        ucrInputLocDataName.clsParameter.bIncludeArgumentName = False
        ucrInputFilePath.SetParameter(New RParameter("filename", 0))
    End Sub

    'Private Sub ucrInputDataName_NameChanged() Handles ucrInputDataName.NameChanged, ucrInputLocDataName.NameChanged
    '    ucrBase.clsRsyntax.AddParameter("data_names", "c(" & Chr(34) & ucrInputDataName.GetText() & Chr(34) & "," & Chr(34) & ucrInputLocDataName.GetText() & Chr(34) & ")")
    'End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If bCanImport Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'Loads the open dialog on load and click
    Public Sub GetFileFromOpenDialog()
        Dim strFilePath As String = ""
        Dim strFileName As String = ""
        Dim strFileExt As String = ""
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "All Data files|*.nc|NetCDF files|*.nc"
            dlgOpen.Title = "Open Data from file"
            If Not ucrInputFilePath.IsEmpty() Then
                dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(ucrInputFilePath.GetText(), "/", "\"))
            Else
                dlgOpen.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If

            If dlgOpen.ShowDialog() = DialogResult.OK Then
                ucrInputDataName.SetName("")
                'ucrInputDataName.Reset()
                'checks if the file name is not blank'
                If dlgOpen.FileName <> "" Then
                    strFileName = Path.GetFileNameWithoutExtension(dlgOpen.FileName)
                    strFilePath = Replace(dlgOpen.FileName, "\", "/")
                    strFileExt = Path.GetExtension(strFilePath)
                    ucrInputFilePath.SetName(strFilePath)
                    ucrInputDataName.Show()
                    lblSSTName.Show()

                    If strFileExt = ".nc" Then
                        'ucrBase.clsRsyntax.SetBaseRFunction(clsBaseNetCDF)
                        clsRCDF.SetRCommand("nc_open")
                        clsRCDF.AddParameter("filename", Chr(34) & strFilePath & Chr(34))
                        strFileType = "nc"
                        ucrInputDataName.SetName(strFileName, bSilent:=True)
                        ucrInputDataName.Focus()
                    End If
                End If
            End If
            'TestOkEnabled()
        End Using
    End Sub

    Private Sub cmdOpenDataSet_Click(sender As Object, e As EventArgs) Handles cmdOpenDataSet.Click
        GetFileFromOpenDialog()
        TestOkEnabled()
    End Sub
End Class