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
    Private clsBaseNetCDF, clsRCDF As New RFunction
    Dim bFirstLoad As Boolean
    Dim strFileType As String
    Dim bCanImport As Boolean
    Dim bComponentsInitialised As Boolean
    Public bStartOpenDialog As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
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
        ucrBase.iHelpTopicID = 102
        ucrInputName.SetValidationTypeAsRVariable()
        ucrInputNameLocation.SetValidationTypeAsRVariable()
        ucrInputNameLocation.SetName("lat_lon_data")
    End Sub

    Private Sub ucrInputDataName_NameChanged() Handles ucrInputName.NameChanged, ucrInputNameLocation.NameChanged
        ucrBase.clsRsyntax.AddParameter("data_names", "c(" & Chr(34) & ucrInputName.GetText() & Chr(34) & "," & Chr(34) & ucrInputNameLocation.GetText() & Chr(34) & ")")
    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetCSVDefault()
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

                    If strFileExt = ".nc" Then
                        ucrBase.clsRsyntax.SetBaseRFunction(clsBaseNetCDF)
                        clsRCDF.SetRCommand("nc_open")
                        clsRCDF.AddParameter("filename", Chr(34) & strFilePath & Chr(34))
                        strFileType = "nc"
                        ucrInputName.SetName(strFileName, bSilent:=True)
                        ucrInputName.Focus()
                    End If
                End If
            End If
            TestOkEnabled()
        End Using
    End Sub

    Private Sub SetCSVDefault()

    End Sub

    Private Sub cmdOpenDataSet_Click(sender As Object, e As EventArgs) Handles cmdOpenDataSet.Click
        GetFileFromOpenDialog()
    End Sub
End Class