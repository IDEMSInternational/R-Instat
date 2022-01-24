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

Imports System.Runtime.InteropServices
Imports instat.Translations
Imports System.IO
Imports RDotNet
Imports System.ComponentModel

Public Class dlgOpenNetCDF
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsImportNetcdfFunction, clsNcOpenFunction, clsNcCloseFunction, clsRFileDetails As New RFunction
    Private clsBoundaryListFunction, clsYLimitsFunction, clsXLimtsFunction, clsZLimtsFunction, clsSLimtsFunction, clsTLimitsFunction As New RFunction
    Public bStartOpenDialog As Boolean
    Private bResetSubdialog As Boolean = False
    Private bShowDetails As Boolean
    Private strFilePath As String = ""
    Private strShort As String
    Private strMedium As String
    Private strLong As String
    Private bCloseFile As Boolean = False
    Private strFileAssignName As String = "nc"
    Private iExpandedWidth As Integer
    Private strLibraryPath As String = frmMain.strStaticPath & "\" & "Library" & "\" & "Climatic" & "\" & "_Satellite" & "\"
    Private bFromLibrary As Boolean = False
    Private bSubDialogOKEnabled As Boolean = True
    Private bMultiImport As Boolean = False
    Private strFiles() As String = {}

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        bFirstLoad = True
        bStartOpenDialog = False
        ucrInputDataName.bAutoChangeOnLeave = True
        iExpandedWidth = Me.Width
        NFilesLabelVisible(False)
    End Sub

    Private Sub dlgOpenNetCDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
    End Sub

    Private Sub OpenFile()
        Dim strTemp As String = ""
        Dim strScript As String = ""

        If Not ucrInputPath.IsEmpty AndAlso File.Exists(strFilePath) Then
            strScript = clsNcOpenFunction.ToScript(strTemp)
            frmMain.clsRLink.RunScript(strTemp, strComment:="Opening connection to NetCDF file", bUpdateGrids:=False, bSilent:=True)
            bCloseFile = True
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 393

        ucrInputPath.IsReadOnly = True

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

        strShort = ""
        strMedium = ""
        strLong = ""
        rdoShort.Checked = True
        bMultiImport = False

        ucrInputPath.SetName("")
        ucrInputFileDetails.SetName("")
        NFilesLabelVisible(False)

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

        clsRFileDetails.SetPackageName("cmsafops")
        clsRFileDetails.SetRCommand("ncinfo")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsImportNetcdfFunction)
        ucrBase.clsRsyntax.AddToAfterCodes(clsNcCloseFunction, iPosition:=0)
        bResetSubdialog = True
        bSubDialogOKEnabled = True

        bShowDetails = False
        SetDialogSize()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputDataName.SetRCode(clsImportNetcdfFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (Not bMultiImport OrElse (bMultiImport AndAlso strFiles.Count > 0)) AndAlso ucrInputDataName.Text <> "" AndAlso ucrInputPath.Text <> "" AndAlso bSubDialogOKEnabled Then
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

        NFilesLabelVisible(False)
        bMultiImport = False
        cmdDetails.Visible = True
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "All Data files|*.nc|NetCDF files|*.nc"
            dlgOpen.Title = "Open Data from file"
            If bFromLibrary Then
                ' TODO There should be a way of using Path.GetDirectoryName to avoid needing the If but couldn't get this to work
                If RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
                    dlgOpen.InitialDirectory = Replace(strLibraryPath, "\", "/")
                Else
                    dlgOpen.InitialDirectory = Path.GetDirectoryName(strLibraryPath)
                End If
            ElseIf Not ucrInputPath.IsEmpty() Then
                If RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
                    dlgOpen.InitialDirectory = Replace(Path.GetDirectoryName(ucrInputPath.GetText()), "\", "/")
                Else
                    dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(ucrInputPath.GetText(), "/", "\"))
                End If
            Else
                If RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
                    dlgOpen.InitialDirectory = Replace(frmMain.clsInstatOptions.strWorkingDirectory, "\", "/")
                Else
                    dlgOpen.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
                End If
            End If

            If dlgOpen.ShowDialog() = DialogResult.OK Then
                clsImportNetcdfFunction.RemoveParameterByName("path")
                ucrInputDataName.SetName("")
                'checks if the file name is not blank'
                If dlgOpen.FileName <> "" Then
                    strFileName = Path.GetFileNameWithoutExtension(dlgOpen.FileName)
                    strFilePath = dlgOpen.FileName
                    strFileExt = Path.GetExtension(strFilePath).ToLower()
                    ucrInputPath.SetName(Replace(strFilePath, "\", "/"))
                    If strFileExt = ".nc" Then
                        CheckCloseFile()
                        bCloseFile = True
                        ucrInputDataName.SetName(frmMain.clsRLink.MakeValidText(strFileName))
                        clsNcOpenFunction.AddParameter("filename", Chr(34) & Replace(strFilePath, "\", "/") & Chr(34))
                        clsNcOpenFunction.ToScript(strTemp)
                        frmMain.clsRLink.RunScript(strTemp, strComment:="Opening connection to NetCDF file", bUpdateGrids:=False)
                        clsRFileDetails.AddParameter("infile", Chr(34) & Replace(strFilePath, "\", "/") & Chr(34), iPosition:=1)
                        FileDetails()
                        clsImportNetcdfFunction.RemoveParameterByName("boundary")
                        clsBoundaryListFunction.ClearParameters()
                    End If
                Else
                    MsgBox("File type: '" & strFileExt & "' not recognised as a NetCDF file (.nc).", vbOKOnly)
                    strShort = ""
                    strMedium = ""
                    strLong = ""
                End If
            End If
        End Using
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgOpenNetCDF.SetRFunction(clsNewImportNetcdfFunction:=clsImportNetcdfFunction, clsNewNcOpenFunction:=clsNcOpenFunction, clsNewBoundaryListFunction:=clsBoundaryListFunction, clsNewXLimitsFunction:=clsXLimtsFunction, clsNewYLimitsFunction:=clsYLimitsFunction, clsNewZLimitsFunction:=clsZLimtsFunction, clsNewSLimitsFunction:=clsSLimtsFunction, clsNewTLimitsFunction:=clsTLimitsFunction, strNewShortDescription:=strShort, bNewMultiImport:=bMultiImport, bReset:=bResetSubdialog)
        bResetSubdialog = False
        sdgOpenNetCDF.ShowDialog()
        bSubDialogOKEnabled = sdgOpenNetCDF.bOKEnabled
        TestOkEnabled()
    End Sub

    Private Sub cmdBrowseFile_Click(sender As Object, e As EventArgs) Handles cmdBrowseFile.Click
        GetFileFromOpenDialog()
    End Sub

    Private Sub cmdBrowseFolder_Click(sender As Object, e As EventArgs) Handles cmdBrowseFolder.Click
        Dim strPath As String
        Dim strTemp As String = ""

        Using dlgFolder As New FolderBrowserDialog
            bMultiImport = True
            dlgFolder.Description = "Choose Folder"
            If dlgFolder.ShowDialog() = DialogResult.OK Then
                cmdDetails.Visible = False
                bShowDetails = False
                SetDialogSize()
                ucrInputDataName.SetName("")
                strPath = dlgFolder.SelectedPath
                ucrInputPath.SetName(Replace(strPath, "\", "/"))
                SetNFilesInFolder(strPath)
                If strFiles.Count > 0 Then
                    CheckCloseFile()
                    clsNcOpenFunction.AddParameter("filename", Chr(34) & Replace(strFiles(0), "\", "/") & Chr(34))
                    clsNcOpenFunction.bToBeAssigned = True
                    clsNcOpenFunction.ToScript(strTemp)
                    frmMain.clsRLink.RunScript(strTemp, strComment:="Opening connection to first NetCDF file", bUpdateGrids:=False)
                    bCloseFile = True
                    clsRFileDetails.AddParameter("infile", Chr(34) & Replace(strFiles(0), "\", "/") & Chr(34), iPosition:=1)
                    clsImportNetcdfFunction.AddParameter("path", Chr(34) & Replace(strPath, "\", "/") & Chr(34))
                    ucrInputDataName.SetName(frmMain.clsRLink.MakeValidText(Path.GetFileName(strPath.TrimEnd(Path.DirectorySeparatorChar))))
                    FileDetails()
                    clsImportNetcdfFunction.RemoveParameterByName("boundary")
                    clsBoundaryListFunction.ClearParameters()
                Else
                    clsNcOpenFunction.RemoveParameterByName("filename")
                    strShort = ""
                    strMedium = ""
                    strLong = ""
                End If
            End If
        End Using
        autoTranslate(Me)
    End Sub

    Private Sub SetNFilesInFolder(strPath As String)
        strFiles = Directory.GetFiles(strPath, "*.nc")
        lblNFiles.Text = If(strFiles.Count = 0, "No", strFiles.Count)
        NFilesLabelVisible(True)
    End Sub

    Private Sub NFilesLabelVisible(bVisible As Boolean)
        lblFilesFound.Visible = bVisible
        lblNFiles.Visible = bVisible
    End Sub

    Private Sub cmdFromLibrary_Click(sender As Object, e As EventArgs) Handles cmdFromLibrary.Click
        bFromLibrary = True
        GetFileFromOpenDialog()
        bFromLibrary = False
    End Sub

    Private Sub cmdDetails_Click(sender As Object, e As EventArgs) Handles cmdDetails.Click
        SetDialogSize()
    End Sub

    Private Sub SetDialogSize()
        bShowDetails = Not bShowDetails
        If Not bShowDetails Then
            Me.Size = New Size(iExpandedWidth, Me.Height)
            cmdDetails.Text = "Hide Details <<"
        Else
            Me.Size = New Size(iExpandedWidth / 1.7, Me.Height)
            cmdDetails.Text = "Show Details >>"
        End If
        autoTranslate(Me)
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
        autoTranslate(Me)
    End Sub

    Private Sub DescriptionButtons_CheckedChanged(sender As Object, e As EventArgs) Handles rdoShort.CheckedChanged, rdoMedium.CheckedChanged, rdoLong.CheckedChanged
        InputDetails()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputPath.ControlContentsChanged, ucrInputDataName.ControlContentsChanged
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