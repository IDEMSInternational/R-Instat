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

Public Class dlgOpenNetCDF
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRDefaultFunction, clsRCDF As New RFunction
    Dim strFileType As String
    Dim bComponentsInitialised As Boolean
    Public bStartOpenDialog As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        bFirstLoad = True
        bComponentsInitialised = True
        bStartOpenDialog = True
        ucrInputDataName.bAutoChangeOnLeave = True
    End Sub

    Private Sub dlgOpenNetCDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        If bStartOpenDialog Then
            GetFileFromOpenDialog()
            bStartOpenDialog = False
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputDataName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrInputLocDataName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrInputFilePath.SetRCode(clsRCDF, bReset)
        ucrInputLatColName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrInputLonColName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub SetDefaults()
        clsRDefaultFunction = New RFunction
        ucrInputLocDataName.SetName("lat_lon_data")
        ucrInputDataName.SetName("")
        ucrInputLatColName.SetName("")
        ucrInputLonColName.SetName("")
        ucrInputFilePath.IsReadOnly = True
        ucrInputFilePath.SetName("")
        clsRDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_NetCDF")
        clsRDefaultFunction.AddParameter("nc_data", clsRFunctionParameter:=clsRCDF)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRDefaultFunction)
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.iHelpTopicID = 
        ucrInputLocDataName.SetDefaultTypeAsDataFrame()
        ucrInputDataName.SetValidationTypeAsRVariable()
        ucrInputLocDataName.SetValidationTypeAsRVariable()
        ucrInputFilePath.SetParameter(New RParameter("filename", 0))
        ucrInputDataName.SetParameter(New RParameter("main_data_name", 1))
        ucrInputLocDataName.SetParameter(New RParameter("loc_data_name", 2))
        ucrInputLatColName.SetParameter(New RParameter("latitude_col_name", 3))
        ucrInputLatColName.SetLinkedDisplayControl(lblLatColName)
        ucrInputLonColName.SetParameter(New RParameter("longitude_col_name", 4))
        ucrInputLonColName.SetLinkedDisplayControl(lblLonColName)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If (ucrInputDataName.Text <> "" AndAlso ucrInputLocDataName.Text <> "" AndAlso ucrInputFilePath.Text <> "" AndAlso (Not ucrInputDataName.Text = ucrInputLocDataName.Text)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrInputFilePath_Load(sender As Object, e As EventArgs) Handles ucrInputFilePath.Load

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
                'checks if the file name is not blank'
                If dlgOpen.FileName <> "" Then
                    strFileName = Path.GetFileNameWithoutExtension(dlgOpen.FileName)
                    strFilePath = Replace(dlgOpen.FileName, "\", "/")
                    strFileExt = Path.GetExtension(strFilePath)
                    ucrInputFilePath.SetName(strFilePath)
                    ucrInputDataName.Show()
                    lblMainDataName.Show()

                    If strFileExt = ".nc" Then
                        clsRCDF.SetRCommand("nc_open")
                        clsRCDF.AddParameter("filename", Chr(34) & strFilePath & Chr(34))
                        strFileType = "nc"
                        ucrInputDataName.SetName(strFileName, bSilent:=True)
                        ucrInputDataName.Focus()
                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub cmdOpenDataSet_Click(sender As Object, e As EventArgs) Handles cmdOpenDataSet.Click
        GetFileFromOpenDialog()
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputFilePath.ControlContentsChanged, ucrInputDataName.ControlContentsChanged, ucrInputLocDataName.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class