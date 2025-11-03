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
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License

' along with this program. If not, see <http://www.gnu.org/licenses/>.


Imports instat.Translations
Imports System.IO
Imports RDotNet

Public Class dlgImportFromEPicsa
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDummyFunction, clsGcsFileFunction, clsListDefinitionsFunction, clsGetDefinitionsData, clsStationMetadataFunction As New RFunction

    Private Sub dlgImportFromEPicsa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctCountry As New Dictionary(Of String, String)

        ucrPnlImportFromEPicsa.AddRadioButton(rdoDefinitions)
        ucrPnlImportFromEPicsa.AddRadioButton(rdoStation)
        ucrPnlImportFromEPicsa.AddRadioButton(rdoData)
        ucrPnlImportFromEPicsa.AddParameterValuesCondition(rdoDefinitions, "checked", "definitions")
        ucrPnlImportFromEPicsa.AddParameterValuesCondition(rdoStation, "checked", "station")
        ucrPnlImportFromEPicsa.AddParameterValuesCondition(rdoData, "checked", "data")

        ucrPnlImportFromEPicsa.AddToLinkedControls({ucrInputComboCountry}, {rdoDefinitions, rdoStation}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlImportFromEPicsa.AddToLinkedControls({ucrInputDefinitionsID, ucrInputComboFindFiles}, {rdoDefinitions}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ' This tab is disabled for now. Will be implemented later
        rdoData.Enabled = False


        ucrInputTokenPath.SetParameter(New RParameter("filename", 0))
        ucrInputTokenPath.SetLinkedDisplayControl(lblToken)

        ucrInputComboCountry.SetParameter(New RParameter("country", 1))
        dctCountry.Add("mw", Chr(34) & "mw" & Chr(34))
        dctCountry.Add("zm", Chr(34) & "zm" & Chr(34))
        dctCountry.Add("zm_workshops", Chr(34) & "zm_workshops" & Chr(34))
        dctCountry.Add("mw_workshops", Chr(34) & "mw_workshops" & Chr(34))
        ucrInputComboCountry.SetItems(dctCountry)
        ucrInputComboCountry.SetText("mw")
        ucrInputComboCountry.SetLinkedDisplayControl(lblCountry)

        ucrInputDefinitionsID.SetParameter(New RParameter("definitions_id", 2))
        ucrInputDefinitionsID.SetLinkedDisplayControl(lblDefinitionsID)

        ucrInputComboFindFiles.SetParameter(New RParameter("file", 3))
        ucrInputComboFindFiles.SetDropDownStyleAsNonEditable()
        ucrInputComboFindFiles.bAllowNonConditionValues = True

        ucrSaveDefinitions.SetIsTextBox()
        ucrSaveDefinitions.ucrInputTextSave.bAutoChangeOnLeave = True
    End Sub

    Private Sub SetDefaults()
        clsDummyFunction = New RFunction
        clsListDefinitionsFunction = New RFunction
        clsGetDefinitionsData = New RFunction
        clsGcsFileFunction = New RFunction
        clsStationMetadataFunction = New RFunction

        rdoData.Enabled = False
        ucrInputComboCountry.SetText("mw")
        ucrInputComboFindFiles.cboInput.Items.Clear()

        clsDummyFunction.AddParameter("checked", "definitions", iPosition:=0)

        clsGcsFileFunction.SetPackageName("epicsawrap")
        clsGcsFileFunction.SetRCommand("gcs_auth_file")

        clsListDefinitionsFunction.SetPackageName("epicsawrap")
        clsListDefinitionsFunction.SetRCommand("list_definition_versions")
        clsListDefinitionsFunction.AddParameter("country", ucrInputComboCountry.GetText(), iPosition:=0)
        clsListDefinitionsFunction.AddParameter("definition_id", ucrInputDefinitionsID.GetText(), iPosition:=0)

        clsGetDefinitionsData.SetPackageName("epicsawrap")
        clsGetDefinitionsData.SetRCommand("get_definitions_data")

        clsStationMetadataFunction.SetPackageName("epicsawrap")
        clsStationMetadataFunction.SetRCommand("station_metadata")
        clsStationMetadataFunction.AddParameter("include_definitions", "FALSE", iPosition:=2)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGcsFileFunction, iPosition:=1)
        changeBaseFunctions()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputDefinitionsID.AddAdditionalCodeParameterPair(clsListDefinitionsFunction, New RParameter("definition_id", 2))
        ucrInputComboCountry.AddAdditionalCodeParameterPair(clsListDefinitionsFunction, New RParameter("country", 0), 1)
        ucrInputComboCountry.AddAdditionalCodeParameterPair(clsStationMetadataFunction, New RParameter("country", 0), 2)
        ucrInputComboCountry.AddAdditionalCodeParameterPair(clsGetDefinitionsData, New RParameter("country", 0), 3)

        ucrSaveDefinitions.AddAdditionalRCode(clsStationMetadataFunction)

        ucrPnlImportFromEPicsa.SetRCode(clsDummyFunction)
        ucrInputTokenPath.SetRCode(clsGcsFileFunction, bReset)
        ucrInputDefinitionsID.SetRCode(clsGetDefinitionsData, bReset)
        ucrInputComboFindFiles.SetRCode(clsGetDefinitionsData, bReset)
        ucrSaveDefinitions.SetRCode(clsGetDefinitionsData, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoDefinitions.Checked Then
            If Not ucrInputTokenPath.IsEmpty AndAlso Not ucrInputDefinitionsID.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoStation.Checked Then
            If Not ucrInputTokenPath.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub AllControls_ControlContentChanged(ucrChangedControl As ucrCore) Handles ucrPnlImportFromEPicsa.ControlContentsChanged, ucrInputTokenPath.ControlContentsChanged,
        ucrInputComboCountry.ControlContentsChanged, ucrInputDefinitionsID.ControlContentsChanged, ucrInputComboFindFiles.ControlContentsChanged
        changeBaseFunctions()
        TestOkEnabled()
    End Sub

    Private Function CleanFileNames(strNamesArray As String())
        Dim newStrNamesArray As New List(Of String)
        For Each filePath As String In strNamesArray
            newStrNamesArray.Add(Path.GetFileNameWithoutExtension(filePath))
        Next
        Return newStrNamesArray.ToArray()
    End Function

    Private Sub cmdFindFiles_Click(sender As Object, e As EventArgs) Handles cmdFindFiles.Click
        Dim strFormNames() As String
        Dim cleanedFileNames() As String
        Dim expTemp As SymbolicExpression
        Dim expTemp2 As SymbolicExpression


        Cursor = Cursors.WaitCursor
        ' Running the gcs_auth_file function internally first
        expTemp2 = frmMain.clsRLink.RunInternalScriptGetValue(clsGcsFileFunction.ToScript(), bSeparateThread:=False, bShowWaitDialogOverride:=False)
        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsListDefinitionsFunction.ToScript(), bSeparateThread:=False, bShowWaitDialogOverride:=False)
        Cursor = Cursors.Default
        If expTemp IsNot Nothing Then
            strFormNames = expTemp.AsCharacter().ToArray()
            cleanedFileNames = CleanFileNames(strFormNames)
            If cleanedFileNames.Length > 0 Then
                ucrInputComboFindFiles.SetItems(cleanedFileNames)
                ucrInputComboFindFiles.SetName(ucrInputComboFindFiles.cboInput.Items(0))
            Else
                ucrInputComboFindFiles.cboInput.Items.Clear()
            End If
        Else
            ucrInputComboFindFiles.cboInput.Items.Clear()
        End If
    End Sub

    Private Sub ucrPnlImportFromEPicsa_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlImportFromEPicsa.ControlValueChanged, ucrInputTokenPath.ControlValueChanged
        If rdoStation.Checked Then
            cmdFindFiles.Visible = False
            clsDummyFunction.AddParameter("checked", "station", iPosition:=0)
        ElseIf rdoDefinitions.Checked Then
            cmdFindFiles.Visible = True
            clsDummyFunction.AddParameter("checked", "definitions", iPosition:=0)
        End If
        ChangeSaveType()
        changeBaseFunctions()
        TestOkEnabled()
    End Sub

    Private Sub cmdChooseFile_Click(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "JSON Files|*.json"
            dlgOpen.Title = "Import JSON File"

            dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(ucrInputTokenPath.GetText(), "/", "\"))

            If dlgOpen.ShowDialog() = DialogResult.OK AndAlso dlgOpen.FileName <> "" Then
                ucrInputTokenPath.SetName(Replace(dlgOpen.FileName, "\", "/"))
            End If
        End Using
    End Sub

    Private Sub ChangeSaveType()
        If rdoDefinitions.Checked Then
            ucrSaveDefinitions.SetSaveType(strRObjectType:=RObjectTypeLabel.StructureLabel, strRObjectFormat:=RObjectFormat.Text)
            ucrSaveDefinitions.SetName("last_definition")
            ucrSaveDefinitions.SetLabelText("Definition Name:")
            ucrSaveDefinitions.SetDataFrameSelector(ucrDataframeSelector)
        ElseIf rdoStation.Checked Then
            ucrSaveDefinitions.SetSaveTypeAsDataFrame()
            ucrSaveDefinitions.SetName("last_dataframe")
            ucrSaveDefinitions.SetLabelText("Dataframe Name:")
        End If
    End Sub

    Private Sub changeBaseFunctions()
        If rdoDefinitions.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsGetDefinitionsData)
        ElseIf rdoStation.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsStationMetadataFunction)
        End If
    End Sub

End Class