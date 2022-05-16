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
Public Class dlgTransposeColumns
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResettingDialogue As Boolean = False
    Private clsOverallFunction, clsTransposeFunction, clsGetColumnNamesFunction As New RFunction
    Private lstEditedVariables, lstAllVariables As New List(Of String)
    Private Sub dlgTransposeColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 277
        ucrReceiverColumnsToTranspose.SetParameterIsRFunction()
        ucrReceiverColumnsToTranspose.Selector = ucrSelectorTransposeColumns
        ucrReceiverColumnsToTranspose.SetMeAsReceiver()
        ucrReceiverVariableNames.SetParameter(New RParameter("make.names", 1))
        ucrReceiverVariableNames.SetParameterIsString()
        ucrReceiverVariableNames.Selector = ucrSelectorTransposeColumns
        'The checkbox is not yet implemented in the updated code as it was not implemented in pre-updated code
        ucrChkNameNewColumns.SetText("Name New Columns")
        ucrChkNameNewColumns.Enabled = False ' temporary
        ucrChkDisplayVariableNames.SetText("Include Old Names")
        ucrChkDisplayVariableNames.AddParameterPresentCondition(True, "keep.names")
        ucrChkDisplayVariableNames.AddParameterPresentCondition(False, "keep.names", False)
        ucrInputDisplayVariableNames.SetParameter(New RParameter("keep.names", 2))
        'ucrNewDF
        ucrNewDataframe.SetIsTextBox()
        ucrNewDataframe.SetSaveTypeAsDataFrame()
        ucrNewDataframe.SetDataFrameSelector(ucrSelectorTransposeColumns.ucrAvailableDataFrames)
        ucrNewDataframe.SetLabelText("New Data Frame Name:")
        ucrChkDisplayVariableNames.AddToLinkedControls({ucrInputDisplayVariableNames}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, objNewDefaultState:="old name", bNewLinkedChangeToDefaultState:=True)
    End Sub
    Private Sub SetDefaults()
        clsTransposeFunction = New RFunction
        clsOverallFunction = New RFunction
        clsGetColumnNamesFunction = New RFunction
        ucrSelectorTransposeColumns.Reset()
        ucrNewDataframe.Reset()
        'ucrReceiverColumnsToTranspose.SetMeAsReceiver()
        NewDefaultName()
        clsOverallFunction.SetRCommand("as.data.frame")
        clsOverallFunction.SetAssignTo(ucrNewDataframe.GetText(), strTempDataframe:=ucrNewDataframe.GetText())
        clsOverallFunction.AddParameter("x", clsRFunctionParameter:=clsTransposeFunction)
        clsTransposeFunction.SetPackageName("data.table")
        clsTransposeFunction.SetRCommand("transpose")
        clsTransposeFunction.AddParameter("l", "columns", iPosition:=0)
        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)
    End Sub
    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverVariableNames.SetRCode(clsTransposeFunction, bReset)
        ucrChkDisplayVariableNames.SetRCode(clsTransposeFunction, bReset)
        ucrNewDataframe.SetRCode(clsOverallFunction, bReset)
    End Sub
    Private Sub TestOkEnabled()
        If Not ucrReceiverColumnsToTranspose.IsEmpty AndAlso ucrNewDataframe.IsComplete() Then
            If ucrChkDisplayVariableNames.Checked AndAlso (Not ucrInputDisplayVariableNames.IsEmpty) Then
                ucrBase.OKEnabled(True)
            ElseIf ucrChkDisplayVariableNames.Checked AndAlso ucrInputDisplayVariableNames.IsEmpty Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        bResettingDialogue = True
        SetDefaults()
        SetRCodeforControls(True)
        UpdateSelector()
        TestOkEnabled()
        bResettingDialogue = False
    End Sub
    Private Sub NewDefaultName()
        If (Not ucrNewDataframe.bUserTyped) AndAlso ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataframe.SetName(ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_transposed")
        End If
    End Sub
    Private Sub CoreName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTransposeColumns.ControlValueChanged
        NewDefaultName()
    End Sub
    Private Sub ucrReceiverColumnsToTranspose_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToTranspose.ControlValueChanged
        ucrBase.clsRsyntax.lstBeforeCodes.Clear()
        clsGetColumnNamesFunction = ucrReceiverColumnsToTranspose.GetVariables(True).Clone
        clsGetColumnNamesFunction.SetAssignTo("columns")
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetColumnNamesFunction)
        If ucrReceiverColumnsToTranspose.IsEmpty AndAlso lstEditedVariables.Count > 0 Then
            UpdateSelector()
            ucrReceiverColumnsToTranspose.SetMeAsReceiver()
        End If
        If ucrReceiverColumnsToTranspose.IsEmpty Then
            ucrReceiverVariableNames.Clear()
        End If
    End Sub
    Private Sub UpdateSelector()
        ClearSelector()
        If bResettingDialogue Then
            For i = 0 To lstAllVariables.Count - 1
                ucrSelectorTransposeColumns.lstAvailableVariable.Items.Add(lstAllVariables.Item(i))
                ucrSelectorTransposeColumns.lstAvailableVariable.Items(i).Tag = ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text
            Next
        Else
            For i = 0 To lstEditedVariables.Count - 1
                ucrSelectorTransposeColumns.lstAvailableVariable.Items.Add(lstEditedVariables.Item(i))
                ucrSelectorTransposeColumns.lstAvailableVariable.Items(i).Tag = ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text
            Next
        End If
    End Sub
    Private Sub ClearSelector()
        ucrSelectorTransposeColumns.lstAvailableVariable.Clear()
        ucrSelectorTransposeColumns.lstAvailableVariable.Groups.Clear()
        ucrSelectorTransposeColumns.lstAvailableVariable.Columns.Add("Variables")
    End Sub
    Private Sub ucrReceiverVariableNames_Enter(sender As Object, e As EventArgs) Handles ucrReceiverVariableNames.Enter
        Dim grps As New ListViewGroup
        ClearSelector()
        If Not ucrReceiverColumnsToTranspose.IsEmpty Then
            If ucrReceiverColumnsToTranspose.GetVariableNamesList(False).Count > 1 Then
                grps = New ListViewGroup(key:=ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text,
                                         headerText:=ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                ucrSelectorTransposeColumns.lstAvailableVariable.Groups.Add(grps)
            End If
            For j = 0 To ucrReceiverColumnsToTranspose.GetVariableNamesList(False).Count - 1
                ucrSelectorTransposeColumns.lstAvailableVariable.Items.Add(ucrReceiverColumnsToTranspose.GetVariableNamesList(False)(j))
                ucrSelectorTransposeColumns.lstAvailableVariable.Items(j).Tag = ucrSelectorTransposeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text
                ucrSelectorTransposeColumns.lstAvailableVariable.Items(j).ToolTipText = ucrReceiverColumnsToTranspose.GetVariableNamesList(False)(0)
            Next
        End If
    End Sub
    Private Sub ucrSelectorTransposeColumns_DataFrameChanged() Handles ucrSelectorTransposeColumns.DataFrameChanged
        If Not bResettingDialogue Then
            If ucrSelectorTransposeColumns.lstAvailableVariable.Items.Count > 0 Then
                lstEditedVariables.Clear()
                lstAllVariables.Clear()
                For Each lstv As ListViewItem In ucrSelectorTransposeColumns.lstAvailableVariable.Items
                    lstAllVariables.Add(lstv.Text)
                    lstEditedVariables.Add(lstv.Text)
                Next
            End If
        End If
    End Sub
    Private Sub ucrReceiverColumnsToTranspose_Enter(sender As Object, e As EventArgs) Handles ucrReceiverColumnsToTranspose.Enter
        bResettingDialogue = True
        UpdateSelector()
        bResettingDialogue = False
        'If Not ucrReceiverColumnsToTranspose.IsEmpty AndAlso
        '    ucrSelectorTransposeColumns.lstAvailableVariable.Items.Count > 0 Then
        '    UpdateSelector()
        'End If
    End Sub
    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToTranspose.ControlContentsChanged,
        ucrNewDataframe.ControlContentsChanged, ucrReceiverVariableNames.ControlContentsChanged, ucrChkDisplayVariableNames.ControlContentsChanged,
        ucrInputDisplayVariableNames.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class