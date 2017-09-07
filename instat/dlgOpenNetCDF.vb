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

Public Class dlgOpenNetCDF
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsImportNetcdfFunction, clsNcOpenFunction, clsRClose, clsRFileDetails As New RFunction
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
        End If
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.iHelpTopicID = 

        ucrInputFilePath.SetParameter(New RParameter("filename", 0))
        ucrInputFilePath.IsReadOnly = True

        ucrInputDataName.SetParameter(New RParameter("name", 1))
        ucrInputDataName.SetValidationTypeAsRVariable()

        ' For File Detail options
        ucrPnlFileDetails.SetParameter(New RParameter("info", 0))
        ucrPnlFileDetails.AddRadioButton(rdoShort, Chr(34) & "s" & Chr(34))
        ucrPnlFileDetails.AddRadioButton(rdoMedium, Chr(34) & "m" & Chr(34))
        ucrPnlFileDetails.AddRadioButton(rdoLong, Chr(34) & "l" & Chr(34))
        ucrPnlFileDetails.SetRDefault(Chr(34) & "s" & Chr(34))

        ucrInputFileDetails.txtInput.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub SetDefaults()
        clsImportNetcdfFunction = New RFunction
        clsNcOpenFunction = New RFunction
        clsRClose = New RFunction
        clsRFileDetails = New RFunction

        Me.Size = New Size(434, 256)
        cmdDetails.Text = "Show Details"
        bShowDetails = True
        strShort = ""
        strMedium = ""
        strLong = ""

        ucrInputFilePath.SetName("")
        'ucrInputDataName.SetName("") ' technically this clears anyway as it updates to what is in the ucrInputFilePath, which is nothing.

        clsImportNetcdfFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_NetCDF")
        clsImportNetcdfFunction.AddParameter("nc", clsRFunctionParameter:=clsNcOpenFunction, iPosition:=0)

        clsNcOpenFunction.SetPackageName("ncdf4")
        clsNcOpenFunction.SetRCommand("nc_open")
        'clsNcOpenFunction.SetAssignTo("nc")

        clsBoundaryListFunction.SetRCommand("list")
        clsXLimtsFunction.SetRCommand("c")
        clsYLimitsFunction.SetRCommand("c")
        clsZLimtsFunction.SetRCommand("c")
        clsTLimitsFunction.SetRCommand("c")

        clsRClose.SetPackageName("ncdf4")
        clsRClose.SetRCommand("nc_close")
        clsRClose.AddParameter("nc", clsRFunctionParameter:=clsNcOpenFunction, iPosition:=0)

        clsRFileDetails.SetPackageName("cmsaf")
        clsRFileDetails.SetRCommand("ncinfo")

        ucrBase.clsRsyntax.AddToAfterCodes(clsRClose, iPosition:=0)
        ucrBase.clsRsyntax.SetBaseRFunction(clsImportNetcdfFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputDataName.SetRCode(clsImportNetcdfFunction, bReset)
        ucrInputFilePath.SetRCode(clsNcOpenFunction, bReset)
        ucrPnlFileDetails.SetRCode(clsRFileDetails, bReset)
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
                        clsNcOpenFunction.AddParameter("filename", Chr(34) & strFilePath & Chr(34))
                        strFileType = "nc"
                        ucrInputDataName.SetName(strFileName, bSilent:=True)
                        ucrInputDataName.Focus()
                        clsRFileDetails.AddParameter("infile", Chr(34) & strFilePath & Chr(34), iPosition:=1)
                        FileDetails()
                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgOpenNetCDF.SetRFunction(clsNewImportNetcdfFunction:=clsImportNetcdfFunction, clsNewNcOpenFunction:=clsNcOpenFunction, clsNewXLimitsFunction:=clsXLimtsFunction, clsNewYLimitsFunction:=clsYLimitsFunction, clsNewZLimitsFunction:=clsZLimtsFunction, clsNewSLimitsFunction:=clsSLimtsFunction, clsNewTLimitsFunction:=clsTLimitsFunction, strNewShortDescription:=strShort, bReset:=bResetSubdialog)
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
            cmdDetails.Text = "Hide Details"
        Else
            Me.Size = New Size(434, 256)
            cmdDetails.Text = "Show Details"
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

    Private Sub ucrPnlFileDetails_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFileDetails.ControlValueChanged
        InputDetails()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputFilePath.ControlContentsChanged, ucrInputDataName.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class