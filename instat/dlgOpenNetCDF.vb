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
Imports RDotNet
Imports System.ComponentModel

Public Class dlgOpenNetCDF
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsImportNetcdfFunction, clsNcOpenFunction, clsNcCloseFunction, clsRFileDetails As New RFunction
    Private clsBoundaryListFunction, clsYLimitsFunction, clsXLimtsFunction, clsZLimtsFunction, clsSLimtsFunction, clsTLimitsFunction As New RFunction
    Dim strFileType As String
    Dim bComponentsInitialised As Boolean
    Public bStartOpenDialog As Boolean
    Private bResetSubdialog As Boolean = False
    Private bShowDetails As Boolean
    Private strFilePath As String = ""
    Private strShort As String
    Private strMedium As String
    Private strLong As String
    Private bCloseFile As Boolean = False
    Private strFileAssignName As String = "nc"

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
        SetRCodeForControls(bReset)
        If bStartOpenDialog Then
            GetFileFromOpenDialog()
            bStartOpenDialog = False
        Else
            OpenFile()
        End If
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub OpenFile()
        Dim strTemp As String = ""
        Dim strScript As String = ""

        If Not ucrInputFilePath.IsEmpty AndAlso File.Exists(strFilePath) Then
            strScript = clsNcOpenFunction.ToScript(strTemp)
            frmMain.clsRLink.RunScript(strTemp, strComment:="Opening Net CDF file", bUpdateGrids:=False, bSilent:=True)
            bCloseFile = True
        End If
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.iHelpTopicID = 

        ucrInputFilePath.IsReadOnly = True

        ucrInputFileDetails.txtInput.ScrollBars = ScrollBars.Vertical

        ucrInputDataName.SetParameter(New RParameter("name", 1))
        ucrInputDataName.SetValidationTypeAsRVariable()
        ucrInputDataName.bAutoChangeOnLeave = True
    End Sub

    Private Sub SetDefaults()
        clsImportNetcdfFunction = New RFunction
        clsNcOpenFunction = New RFunction
        clsNcCloseFunction = New RFunction
        clsRFileDetails = New RFunction

        Me.Size = New Size(434, 256)
        cmdDetails.Text = "Show Details >>"
        bShowDetails = True
        strShort = ""
        strMedium = ""
        strLong = ""
        rdoShort.Checked = True

        clsImportNetcdfFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_NetCDF")
        clsImportNetcdfFunction.AddParameter("nc", clsRFunctionParameter:=clsNcOpenFunction, iPosition:=0)

        clsNcOpenFunction.SetPackageName("ncdf4")
        clsNcOpenFunction.SetRCommand("nc_open")
        clsNcOpenFunction.SetAssignTo(strFileAssignName)

        clsBoundaryListFunction.SetRCommand("list")
        clsXLimtsFunction.SetRCommand("c")
        clsYLimitsFunction.SetRCommand("c")
        clsZLimtsFunction.SetRCommand("c")
        clsTLimitsFunction.SetRCommand("c")

        clsNcCloseFunction.SetPackageName("ncdf4")
        clsNcCloseFunction.SetRCommand("nc_close")
        clsNcCloseFunction.AddParameter("nc", clsRFunctionParameter:=clsNcOpenFunction, iPosition:=0)

        clsRFileDetails.SetPackageName("cmsaf")
        clsRFileDetails.SetRCommand("ncinfo")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsImportNetcdfFunction)
        ucrBase.clsRsyntax.AddToAfterCodes(clsNcCloseFunction, iPosition:=0)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputDataName.SetRCode(clsImportNetcdfFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrInputDataName.Text <> "" AndAlso ucrInputFilePath.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    'Loads the open dialog on load and click
    Public Sub GetFileFromOpenDialog()
        Dim strFileName As String = ""
        Dim strFileExt As String = ""
        Dim strTemp As String = ""

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
                    strFilePath = dlgOpen.FileName
                    strFileExt = Path.GetExtension(strFilePath)
                    ucrInputFilePath.SetName(Replace(strFilePath, "\", "/"))
                    If strFileExt = ".nc" Then
                        CheckCloseFile()
                        bCloseFile = True
                        ucrInputDataName.SetName(frmMain.clsRLink.MakeValidText(strFileName))
                        clsNcOpenFunction.AddParameter("filename", Chr(34) & Replace(strFilePath, "\", "/") & Chr(34))
                        clsNcOpenFunction.ToScript(strTemp)
                        frmMain.clsRLink.RunScript(strTemp, strComment:="Opening netCDF file", bUpdateGrids:=False)
                        strFileType = "nc"
                        clsRFileDetails.AddParameter("infile", Chr(34) & Replace(strFilePath, "\", "/") & Chr(34), iPosition:=1)
                        FileDetails()
                        clsImportNetcdfFunction.RemoveParameterByName("boundary")
                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgOpenNetCDF.SetRFunction(clsNewImportNetcdfFunction:=clsImportNetcdfFunction, clsNewNcOpenFunction:=clsNcOpenFunction, strNewFilePath:=strFilePath, clsNewBoundaryListFunction:=clsBoundaryListFunction, clsNewXLimitsFunction:=clsXLimtsFunction, clsNewYLimitsFunction:=clsYLimitsFunction, clsNewZLimitsFunction:=clsZLimtsFunction, clsNewSLimitsFunction:=clsSLimtsFunction, clsNewTLimitsFunction:=clsTLimitsFunction, strNewShortDescription:=strShort, bReset:=bResetSubdialog)
        bResetSubdialog = False
        sdgOpenNetCDF.ShowDialog()
        TestOkEnabled()
    End Sub

    Private Sub cmdOpenDataSet_Click(sender As Object, e As EventArgs) Handles cmdOpenDataSet.Click
        GetFileFromOpenDialog()
    End Sub

    Private Sub cmdDetails_Click(sender As Object, e As EventArgs) Handles cmdDetails.Click
        bShowDetails = Not bShowDetails
        If Not bShowDetails Then
            Me.Size = New Size(777, 256)
            cmdDetails.Text = "Hide Details <<"
        Else
            Me.Size = New Size(434, 256)
            cmdDetails.Text = "Show Details >>"
        End If
    End Sub

    Public Sub FileDetails()
        Dim strScript As String
        Dim vecDetails As CharacterVector

        clsRFileDetails.AddParameter("info", Chr(34) & "s" & Chr(34), iPosition:=0)
        strScript = clsRFileDetails.ToScript
        vecDetails = frmMain.clsRLink.RunInternalScriptGetOutput(strScript, bSilent:=True)
        If vecDetails IsNot Nothing AndAlso vecDetails.Length > 0 Then
            strShort = String.Join(Environment.NewLine, vecDetails)
        Else
            strShort = "Short details not available"
        End If

        clsRFileDetails.AddParameter("info", Chr(34) & "m" & Chr(34), iPosition:=0)
        strScript = clsRFileDetails.ToScript
        vecDetails = frmMain.clsRLink.RunInternalScriptGetOutput(strScript, bSilent:=True)
        If vecDetails IsNot Nothing AndAlso vecDetails.Length > 0 Then
            strMedium = String.Join(Environment.NewLine, vecDetails)
        Else
            strMedium = "Medium details not available"
        End If

        clsRFileDetails.AddParameter("info", Chr(34) & "l" & Chr(34), iPosition:=0)
        strScript = clsRFileDetails.ToScript
        vecDetails = frmMain.clsRLink.RunInternalScriptGetOutput(strScript, bSilent:=True)
        If vecDetails IsNot Nothing AndAlso vecDetails.Length > 0 Then
            strLong = String.Join(Environment.NewLine, vecDetails)
        Else
            strLong = "Long details not available"
        End If
        InputDetails()
    End Sub

    Private Sub InputDetails()
        If rdoShort.Checked Then
            ucrInputFileDetails.Text = strShort
        ElseIf rdoMedium.Checked Then
            ucrInputFileDetails.Text = strMedium
        ElseIf rdoLong.Checked Then
            ucrInputFileDetails.Text = strLong
        Else
        End If
    End Sub

    Private Sub DescriptionButtons_CheckedChanged(sender As Object, e As EventArgs) Handles rdoShort.CheckedChanged, rdoMedium.CheckedChanged, rdoLong.CheckedChanged
        InputDetails()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputFilePath.ControlContentsChanged, ucrInputDataName.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub dlgOpenNetCDF_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CheckCloseFile()
    End Sub

    Private Sub ucrBase_ClickClose(sender As Object, e As EventArgs) Handles ucrBase.ClickClose
        CheckCloseFile()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        bCloseFile = False
        clsNcOpenFunction.SetAssignTo(strFileAssignName)
    End Sub

    Private Sub CheckCloseFile()
        If bCloseFile Then
            frmMain.clsRLink.RunScript(clsNcCloseFunction.ToScript(), strComment:="Closing Net CDF file", bUpdateGrids:=False)
            bCloseFile = False
            clsNcOpenFunction.SetAssignTo(strFileAssignName)
        End If
    End Sub
End Class