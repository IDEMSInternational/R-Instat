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

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations
Public Class dlgDuplicateColumns
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDuplicateFunction As RFunction
    Private clsConvertFunction As RFunction
    Public strSelectedDataFrame As String = ""
    Private bUseSelectedColumn As Boolean = False
    Private strSelectedColumn As String = ""

    Private Sub dlgDuplicateColumns_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 512

        'For ucrSelector
        ucrSelectorForDuplicateColumn.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForDuplicateColumn.SetParameterIsString()

        'For ucrReceiver
        ucrReceiverDuplicateColumns.SetParameter(New RParameter("col_names", 1))
        ucrReceiverDuplicateColumns.SetParameterIsString()
        ucrReceiverDuplicateColumns.Selector = ucrSelectorForDuplicateColumn
        ucrReceiverDuplicateColumns.SetMeAsReceiver()

        'For change type check box 
        ucrChkChangeType.SetText("Change type")
        ucrChkChangeType.AddRSyntaxContainsFunctionNamesCondition(True, {frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type"}, bNewIsPositive:=True)
        ucrChkChangeType.AddRSyntaxContainsFunctionNamesCondition(False, {frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type"}, bNewIsPositive:=False)
        ucrChkChangeType.AddToLinkedControls(ucrPnlConvertTo, {True}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrChkChangeType.AddToLinkedControls(ucrChkConvertKeepAttributes, {True}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)

        'For convert to column type options
        ucrPnlConvertTo.SetLinkedDisplayControl(grpConvertTo)
        ucrPnlConvertTo.SetParameter(New RParameter("to_type", 2))
        ucrPnlConvertTo.AddRadioButton(rdoConvertToFactor, Chr(34) & "factor" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoConvertToOrderedFactor, Chr(34) & "ordered_factor" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoConvertToNumeric, Chr(34) & "numeric" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoConvertToCharacter, Chr(34) & "character" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoConvertToInteger, Chr(34) & "integer" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoConvertToLogical, Chr(34) & "logical" & Chr(34))
        ucrPnlConvertTo.AddToLinkedControls(ucrChkConvertSpecifyDecimalsToDisplay, {rdoConvertToFactor, rdoConvertToOrderedFactor}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConvertTo.AddToLinkedControls(ucrPnlConvertFactorToNumericOptions, {rdoConvertToNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoConvertDefault)

        ucrPnlConvertFactorToNumericOptions.SetParameter(New RParameter("factor_values", 3))
        ucrPnlConvertFactorToNumericOptions.AddRadioButton(rdoConvertDefault, "NULL")
        ucrPnlConvertFactorToNumericOptions.AddRadioButton(rdoConvertLevels, Chr(34) & "force_values" & Chr(34))
        ucrPnlConvertFactorToNumericOptions.AddRadioButton(rdoConvertOrdinals, Chr(34) & "force_ordinals" & Chr(34))
        ucrPnlConvertFactorToNumericOptions.SetRDefault("NULL")
        ucrPnlConvertFactorToNumericOptions.SetLinkedDisplayControl(grpFactorToNumericOptions)

        ucrChkConvertSpecifyDecimalsToDisplay.SetParameter(New RParameter("set_decimals", 4))
        ucrChkConvertSpecifyDecimalsToDisplay.SetText("Specify Decimals (if Numeric)")
        ucrChkConvertSpecifyDecimalsToDisplay.SetRDefault("FALSE")
        ucrChkConvertSpecifyDecimalsToDisplay.AddToLinkedControls(ucrNudConvertDisplayDecimals, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudConvertDisplayDecimals.SetParameter(New RParameter("set_digits", 5))
        ucrNudConvertDisplayDecimals.Minimum = 0
        ucrNudConvertDisplayDecimals.Increment = 1
        ucrNudConvertDisplayDecimals.SetRDefault("0")

        ucrChkConvertKeepAttributes.SetParameter(New RParameter("keep_attr", 6))
        ucrChkConvertKeepAttributes.SetText("Keep Attributes")
        ucrChkConvertKeepAttributes.SetRDefault("TRUE")

        ucrPnlConvertTo.AddToLinkedControls(ucrChkConvertCreateLabels, {rdoConvertToNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkConvertCreateLabels.SetParameter(New RParameter("keep.labels", 7))
        ucrChkConvertCreateLabels.SetText("Create Labels")
        ucrChkConvertCreateLabels.SetRDefault("TRUE")

        'For ucrSave
        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorForDuplicateColumn.ucrAvailableDataFrames)
        ucrSaveColumn.SetLabelText("New Column Name:")
        ucrSaveColumn.SetIsComboBox()
        ucrSaveColumn.setLinkedReceiver(ucrReceiverDuplicateColumns) 'added

    End Sub

    Private Sub SetDefaults()
        clsDuplicateFunction = New RFunction
        clsConvertFunction = New RFunction
        ucrBase.clsRsyntax.lstAfterCodes.Clear()

        ucrSelectorForDuplicateColumn.Reset()
        ucrSaveColumn.Reset()


        'set up convert function
        clsConvertFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertFunction.AddParameter("data_name", Chr(34) & ucrSelectorForDuplicateColumn.strCurrentDataFrame & Chr(34), iPosition:=0)
        clsConvertFunction.AddParameter("to_type", Chr(34) & "factor" & Chr(34), iPosition:=2)

        'set up duplicate function
        clsDuplicateFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsDuplicateFunction.AddParameter("use_current_filter", "FALSE", iPosition:=2)

        'set the duplicate function as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicateFunction)

    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)

        ucrSelectorForDuplicateColumn.SetRCode(clsDuplicateFunction, bReset)
        ucrReceiverDuplicateColumns.SetRCode(clsDuplicateFunction, bReset)

        ucrSaveColumn.SetRCode(clsDuplicateFunction, bReset)

        ucrPnlConvertTo.SetRCode(clsConvertFunction, bReset)
        ucrPnlConvertFactorToNumericOptions.SetRCode(clsConvertFunction, bReset)
        ucrChkConvertSpecifyDecimalsToDisplay.SetRCode(clsConvertFunction, bReset)
        ucrNudConvertDisplayDecimals.SetRCode(clsConvertFunction, bReset)
        ucrChkConvertKeepAttributes.SetRCode(clsConvertFunction, bReset)
        ucrChkConvertCreateLabels.SetRCode(clsConvertFunction, bReset)

        ucrChkChangeType.SetRSyntax(ucrBase.clsRsyntax, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverDuplicateColumns.IsEmpty AndAlso ucrSaveColumn.IsComplete Then
            If ucrChkChangeType.Checked AndAlso (rdoConvertToFactor.Checked OrElse rdoConvertToOrderedFactor.Checked) AndAlso ucrChkConvertSpecifyDecimalsToDisplay.Checked AndAlso ucrNudConvertDisplayDecimals.GetText = "" Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectorForDuplicateColumn.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverDuplicateColumns.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub ucrChkChangeType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkChangeType.ControlValueChanged
        'Remove the Convert Function if change type is unchecked
        If ucrChkChangeType.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsConvertFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsConvertFunction)
        End If
    End Sub

    Private Sub ucrReceiverForCopyColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDuplicateColumns.ControlValueChanged
        If Not ucrSaveColumn.bUserTyped AndAlso Not ucrReceiverDuplicateColumns.IsEmpty Then
            ucrSaveColumn.SetPrefix(ucrReceiverDuplicateColumns.GetVariableNames(False))
        End If
    End Sub

    Private Sub ucrSelectorForDuplicateColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForDuplicateColumn.ControlValueChanged
        'change the data_name parameter value of the Convert Function with the new value of the selector
        clsConvertFunction.AddParameter("data_name", Chr(34) & ucrSelectorForDuplicateColumn.strCurrentDataFrame & Chr(34), iPosition:=0)
    End Sub
    Private Sub ucrSaveColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveColumn.ControlValueChanged
        clsConvertFunction.AddParameter("col_names", Chr(34) & ucrSaveColumn.GetText & Chr(34), iPosition:=1)
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDuplicateColumns.ControlContentsChanged, ucrPnlConvertTo.ControlContentsChanged, ucrNudConvertDisplayDecimals.ControlContentsChanged, ucrChkConvertSpecifyDecimalsToDisplay.ControlContentsChanged, ucrChkChangeType.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkConvertSpecifyDecimalsToDisplay_Load(sender As Object, e As EventArgs) Handles ucrChkConvertSpecifyDecimalsToDisplay.Load

    End Sub
End Class
