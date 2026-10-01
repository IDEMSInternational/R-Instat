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
Imports RDotNet
Public Class dlgSelect
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSetCurrentColumnSelection As New RFunction
    Private clsApplyAsSubset As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsCatFunction As New RFunction
    Private clsSelectionView As New RFunction

    Private Sub dlgSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 597
        ucrBase.clsRsyntax.iCallType = 2

        ucrInputSelectPreview.txtInput.ReadOnly = True
        ucrReceiverSelect.SetItemType("column_selection")
        ucrReceiverSelect.strSelectorHeading = "Column selections"
        ucrReceiverSelect.Selector = ucrSelectorForSelectColumns
        ucrReceiverSelect.SetMeAsReceiver()

        ucrSelectorForSelectColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForSelectColumns.SetParameterIsString()
        ucrSelectorForSelectColumns.HideShowAddOrDataOptionsOrListView(bDataOptionsVisible:=False)

        ucrReceiverSelect.SetParameter(New RParameter("name", 1))
        ucrReceiverSelect.SetParameterIsString()

        ucrChkDataframe.SetText("Data Frame")
        ucrChkDataframe.SetParameter(New RParameter("dataframe", 0))
        ucrChkDataframe.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkMetaData.SetText("Meta Data")
        ucrChkMetaData.SetParameter(New RParameter("metadata", 1))
        ucrChkMetaData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkDialogue.SetText("Dialogs")
        ucrChkDialogue.SetParameter(New RParameter("dialogue", 2))
        ucrChkDialogue.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrPnlApplyOptions.AddRadioButton(rdoApplyAsSelect)
        ucrPnlApplyOptions.AddRadioButton(rdoApplyAsSubset)
        ucrPnlApplyOptions.AddRadioButton(rdoApplySave)
        ucrPnlApplyOptions.AddFunctionNamesCondition(rdoApplyAsSelect, frmMain.clsRLink.strInstatDataObject & "$set_current_column_selection")
        ucrPnlApplyOptions.AddFunctionNamesCondition(rdoApplyAsSubset, frmMain.clsRLink.strInstatDataObject & "$copy_data_object")
        ucrPnlApplyOptions.AddFunctionNamesCondition(rdoApplySave, "cat")

        ucrInputNewDataFrameName.SetParameter(New RParameter("new_name", 1))
        ucrInputNewDataFrameName.SetDataFrameSelector(ucrSelectorForSelectColumns.ucrAvailableDataFrames)
        ucrInputNewDataFrameName.bAllowNonConditionValues = True

        ucrPnlApplyOptions.AddToLinkedControls({ucrInputNewDataFrameName}, {rdoApplyAsSubset}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputNewDataFrameName.SetLinkedDisplayControl(lblNewDataFrameName)
    End Sub

    Private Sub SetDefaults()
        clsSetCurrentColumnSelection = New RFunction
        clsApplyAsSubset = New RFunction
        clsDummyFunction = New RFunction
        clsCatFunction = New RFunction
        clsSelectionView = New RFunction

        ucrSelectorForSelectColumns.Reset()

        grpOptions.Visible = False
        ucrChkDialogue.Enabled = False

        clsDummyFunction.AddParameter("dataframe", "TRUE", iPosition:=0)
        clsDummyFunction.AddParameter("dialogue", "TRUE", iPosition:=1)
        clsDummyFunction.AddParameter("metadata", "TRUE", iPosition:=2)

        clsCatFunction.SetRCommand("cat")

        clsSetCurrentColumnSelection.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_current_column_selection")

        clsApplyAsSubset.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$copy_data_object")
        clsApplyAsSubset.AddParameter("data_name", Chr(34) & ucrSelectorForSelectColumns.strCurrentDataFrame & Chr(34), iPosition:=0)

        clsSelectionView.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$column_selection_string")

        ucrBase.clsRsyntax.SetBaseRFunction(clsSetCurrentColumnSelection)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrReceiverSelect.AddAdditionalCodeParameterPair(clsApplyAsSubset, New RParameter("column_selection_name", 2), iAdditionalPairNo:=1)
        ucrSelectorForSelectColumns.SetRCode(clsSetCurrentColumnSelection, bReset)
        ucrReceiverSelect.SetRCode(clsSetCurrentColumnSelection, bReset)
        ucrInputNewDataFrameName.SetRCode(clsApplyAsSubset, bReset)
        ucrPnlApplyOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkDataframe.SetRCode(clsDummyFunction, bReset)
        ucrChkMetaData.SetRCode(clsDummyFunction, bReset)
        ucrChkDialogue.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoApplyAsSubset.Checked Then
            ucrBase.OKEnabled(Not ucrInputNewDataFrameName.IsEmpty AndAlso Not ucrReceiverSelect.IsEmpty)
        Else
            ucrBase.OKEnabled(Not ucrReceiverSelect.IsEmpty AndAlso (ucrChkDataframe.Checked OrElse ucrChkDialogue.Checked OrElse ucrChkMetaData.Checked))
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Public Sub SetDefaultDataFrame(Optional strDefaultDataframe As String = "")
        If strDefaultDataframe <> "" Then
            ucrSelectorForSelectColumns.SetDataframe(strDefaultDataframe)
        End If
    End Sub

    Private Sub cmdDefineNewSelect_Click(sender As Object, e As EventArgs) Handles cmdDefineNewSelect.Click
        If frmMain.IsColumnSelectionApplied Then
            Dim clsRemoveCurrentSelection As New RFunction
            clsRemoveCurrentSelection.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_current_column_selection")
            clsRemoveCurrentSelection.AddParameter("data_name", Chr(34) & ucrSelectorForSelectColumns.strCurrentDataFrame & Chr(34))
            frmMain.clsRLink.RunScript(clsRemoveCurrentSelection.ToScript, strComment:="Remove current selection")
        End If
        dlgSelectColumns.SetDefaultDataFrame(ucrSelectorForSelectColumns.ucrAvailableDataFrames.strCurrDataFrame)
        dlgSelectColumns.ShowDialog()
        ucrSelectorForSelectColumns.LoadList()
    End Sub

    Private Sub ucrPnlApplyOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlApplyOptions.ControlValueChanged
        If rdoApplyAsSelect.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSetCurrentColumnSelection)
            grpOptions.Visible = True
        ElseIf rdoApplyAsSubset.Checked Then
            grpOptions.Visible = False
            ucrBase.clsRsyntax.SetBaseRFunction(clsApplyAsSubset)
        Else
            clsCatFunction.AddParameter("dispay", Chr(34) & "Saved column selection" & Chr(34), bIncludeArgumentName:=False)
            ucrBase.clsRsyntax.SetBaseRFunction(clsCatFunction)
            grpOptions.Visible = False
        End If
        SetSelectionPreview()
    End Sub

    Private Sub ucrSelectorForSelectColumns_DataFrameChanged() Handles ucrSelectorForSelectColumns.DataFrameChanged
        If Not ucrSelectorForSelectColumns.IsEmpty() Then
            clsApplyAsSubset.AddParameter("data_name", Chr(34) & ucrSelectorForSelectColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        Else
            clsApplyAsSubset.RemoveParameterByName("data_name")
        End If
    End Sub

    Private Sub ucrReceiverSelect_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelect.ControlValueChanged
        If Not ucrReceiverSelect.IsEmpty Then
            ucrInputNewDataFrameName.SetName(ucrReceiverSelect.GetVariableNames.Trim(Chr(34)))
        Else
            ucrInputNewDataFrameName.SetName("")
        End If
    End Sub

    Private Sub ucrReceiverSelect_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelect.ControlContentsChanged, ucrInputNewDataFrameName.ControlContentsChanged, ucrPnlApplyOptions.ControlContentsChanged, ucrChkDataframe.ControlContentsChanged, ucrChkDialogue.ControlContentsChanged, ucrChkMetaData.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ApplyColumnSelectionSettings(applyToMetaData As Boolean, applyToDataFrame As Boolean, applyToDialogue As Boolean)
        frmMain.UseColumnSelectionInMetaData(applyToMetaData)
        frmMain.UseColumnSelectionInDataView(applyToDataFrame)
        frmMain.clsRLink.bUseColumnSelection = applyToDialogue
    End Sub

    Private Sub ucrChkDataframe_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkDataframe.ControlContentsChanged, ucrChkDialogue.ControlContentsChanged, ucrChkMetaData.ControlContentsChanged
        ApplyColumnSelectionSettings(ucrChkMetaData.Checked, ucrChkDataframe.Checked, ucrChkDialogue.Checked)
    End Sub

    Private Sub SetSelectionPreview()
        If ucrReceiverSelect.IsEmpty Then
            ucrInputSelectPreview.SetName("( )")
            clsSelectionView.RemoveParameterByName("name")
            clsSelectionView.RemoveParameterByName("data_name")
        Else
            clsSelectionView.AddParameter("name", ucrReceiverSelect.GetVariableNames)
            clsSelectionView.AddParameter("data_name", Chr(34) & ucrSelectorForSelectColumns.strCurrentDataFrame & Chr(34), iPosition:=0)
            Try
                ucrInputSelectPreview.SetName(frmMain.clsRLink.RunInternalScriptGetValue(clsSelectionView.ToScript(), bSilent:=True).AsCharacter(0))
            Catch ex As Exception
                ucrInputSelectPreview.SetName("Preview not available")
            End Try
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverSelect_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSelect.SelectionChanged
        SetSelectionPreview()
    End Sub

End Class