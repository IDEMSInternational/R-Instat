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

Imports instat.Translations
Public Class dlgDuplicateColumns
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDuplicateFunction As RFunction
    Private clsConvertFunction As RFunction
    Public strSelectedDataFrame As String = ""
    Private bUseSelectedColumn As Boolean = False
    Private strSelectedColumn As String = ""

    Private Sub dlgCopySheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
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

        ' For ucrSelector
        ucrSelectorForDuplicateColumn.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForDuplicateColumn.SetParameterIsString()

        ' For ucrReceiver
        ucrReceiverDuplicateColumns.SetParameter(New RParameter("col_data", 1))
        ucrReceiverDuplicateColumns.SetParameterIsRFunction()
        ucrReceiverDuplicateColumns.Selector = ucrSelectorForDuplicateColumn
        ucrReceiverDuplicateColumns.SetMeAsReceiver()
        ucrReceiverDuplicateColumns.bUseFilteredData = False

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

        'ucrChkConvertSpecifyDecimalsToDisplay.SetParameter(New RParameter("set_digits", 4))
        'ucrChkConvertSpecifyDecimalsToDisplay.SetText("Specify Decimals (from Numeric)")
        'ucrChkConvertSpecifyDecimalsToDisplay.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        'ucrChkConvertSpecifyDecimalsToDisplay.SetRDefault("FALSE")
        'ucrChkConvertSpecifyDecimalsToDisplay.AddToLinkedControls(ucrLinked:=ucrNudConvertDisplayDecimals, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrNudConvertDisplayDecimals.SetParameter(New RParameter("set_decimals", 5))
        'ucrNudConvertDisplayDecimals.Minimum = 1
        'ucrNudConvertDisplayDecimals.Increment = 1
        'ucrNudConvertDisplayDecimals.SetRDefault("4")

        ucrChkConvertSpecifyDecimalsToDisplay.SetParameter(New RParameter("set_decimals", 4))
        ucrChkConvertSpecifyDecimalsToDisplay.SetText("Specify Decimals (from Numeric)")
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

        'column position options
        'TODO THIS WILL BE REMOVED AFTER THE ADDITION OF THE COMBOBOX IN UCRSAVE
        ucrPnlDuplicateColPosition.SetParameter(New RParameter("before", 3))
        ucrPnlDuplicateColPosition.AddRadioButton(rdoBefore, "TRUE")
        ucrPnlDuplicateColPosition.AddRadioButton(rdoAfter, "FALSE")
        ucrPnlDuplicateColPosition.AddRadioButton(rdoBeginning, "TRUE")
        ucrPnlDuplicateColPosition.AddRadioButton(rdoEnd, "FALSE")
        ucrPnlDuplicateColPosition.AddParameterPresentCondition(rdoBefore, "adjacent_column", True)
        ucrPnlDuplicateColPosition.AddParameterPresentCondition(rdoAfter, "adjacent_column", True)
        ucrPnlDuplicateColPosition.AddParameterPresentCondition(rdoBeginning, "adjacent_column", False)
        ucrPnlDuplicateColPosition.AddParameterPresentCondition(rdoEnd, "adjacent_column", False)

        ' For ucrSaveColumn
        ucrInputDuplicateColumnName.SetParameter(New RParameter("col_name", 2))
        ucrInputDuplicateColumnName.SetDataFrameSelector(ucrSelectorForDuplicateColumn.ucrAvailableDataFrames)
        ucrInputDuplicateColumnName.SetItemsTypeAsColumns()
        ucrInputDuplicateColumnName.SetDefaultTypeAsColumn()
        ucrInputDuplicateColumnName.SetValidationTypeAsRVariable()
        ucrInputDuplicateColumnName.bAllowNonConditionValues = True
    End Sub

    Private Sub SetDefaults()
        clsDuplicateFunction = New RFunction
        clsConvertFunction = New RFunction
        ucrBase.clsRsyntax.lstAfterCodes.Clear()

        ucrSelectorForDuplicateColumn.Reset()
        ucrInputDuplicateColumnName.Reset()
        ucrInputDuplicateColumnName.SetName("")

        'set up duplicate function
        clsDuplicateFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsDuplicateFunction.AddParameter("before", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicateFunction)

        'set up convert function
        clsConvertFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertFunction.AddParameter("to_type", Chr(34) & "factor" & Chr(34), iPosition:=2)
        clsConvertFunction.AddParameter("data_name", Chr(34) & ucrSelectorForDuplicateColumn.strCurrentDataFrame & Chr(34), iPosition:=0)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)

        ucrSelectorForDuplicateColumn.SetRCode(clsDuplicateFunction, bReset)
        ucrReceiverDuplicateColumns.SetRCode(clsDuplicateFunction, bReset)
        ucrPnlDuplicateColPosition.SetRCode(clsDuplicateFunction, bReset)
        ucrInputDuplicateColumnName.AddAdditionalCodeParameterPair(clsConvertFunction, New RParameter("col_names", 1), iAdditionalPairNo:=1)
        ucrInputDuplicateColumnName.SetRCode(clsDuplicateFunction, bReset)

        ucrPnlConvertTo.SetRCode(clsConvertFunction, bReset)
        ucrPnlConvertFactorToNumericOptions.SetRCode(clsConvertFunction, bReset)
        ucrChkConvertSpecifyDecimalsToDisplay.SetRCode(clsConvertFunction, bReset)
        ucrNudConvertDisplayDecimals.SetRCode(clsConvertFunction, bReset)
        ucrChkConvertKeepAttributes.SetRCode(clsConvertFunction, bReset)
        ucrChkConvertCreateLabels.SetRCode(clsConvertFunction, bReset)

        ucrChkChangeType.SetRSyntax(ucrBase.clsRsyntax, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverDuplicateColumns.IsEmpty AndAlso Not ucrInputDuplicateColumnName.IsEmpty Then
            If ucrChkChangeType.Checked AndAlso (rdoConvertToFactor.Checked OrElse rdoConvertToOrderedFactor.Checked) AndAlso ucrChkConvertSpecifyDecimalsToDisplay.Checked AndAlso ucrNudConvertDisplayDecimals.GetText = "" Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()
        ucrInputDuplicateColumnName.bAllowNonConditionValues = True ' temporary fix
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

    Private Sub PositionOfDuplicatedColumn()
        If rdoAfter.Checked Then
            If Not ucrReceiverDuplicateColumns.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("adjacent_column", ucrReceiverDuplicateColumns.GetVariableNames)
            Else
                ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            End If
            ucrBase.clsRsyntax.AddParameter("before", "FALSE")
        ElseIf rdoBeginning.Checked Then
            ucrBase.clsRsyntax.AddParameter("before", "TRUE")
            ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
        ElseIf rdoBefore.Checked Then
            ucrBase.clsRsyntax.AddParameter("before", "TRUE")
            If Not ucrReceiverDuplicateColumns.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("adjacent_column", ucrReceiverDuplicateColumns.GetVariableNames)
            Else
                ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            End If
        ElseIf rdoEnd.Checked Then
            ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            ucrBase.clsRsyntax.AddParameter("before", "FALSE")
        End If
    End Sub

    Private Sub DefaultNewName()
        If Not ucrInputDuplicateColumnName.bUserTyped AndAlso Not ucrReceiverDuplicateColumns.IsEmpty Then
            ucrInputDuplicateColumnName.SetPrefix(ucrReceiverDuplicateColumns.GetVariableNames(False))
        End If
    End Sub

    Private Sub ucrPnlColPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDuplicateColPosition.ControlValueChanged
        ucrReceiverDuplicateColumns.UpdateControl()
        PositionOfDuplicatedColumn()
    End Sub

    Private Sub ucrReceiverForCopyColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDuplicateColumns.ControlValueChanged
        DefaultNewName()
        PositionOfDuplicatedColumn()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDuplicateColumns.ControlContentsChanged, ucrInputDuplicateColumnName.ControlContentsChanged, ucrPnlConvertTo.ControlContentsChanged, ucrNudConvertDisplayDecimals.ControlContentsChanged, ucrChkConvertSpecifyDecimalsToDisplay.ControlContentsChanged, ucrChkChangeType.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkChangeType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkChangeType.ControlValueChanged
        'Remove the Convert Function if change type is unchecked
        If ucrChkChangeType.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsConvertFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsConvertFunction)
        End If
    End Sub

    Private Sub ucrSelectorForDuplicateColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForDuplicateColumn.ControlValueChanged
        'also change the data_name parameter value of the Convert Function with the new value of the selector
        clsConvertFunction.AddParameter("data_name", Chr(34) & ucrSelectorForDuplicateColumn.strCurrentDataFrame & Chr(34), iPosition:=0)
    End Sub
End Class
