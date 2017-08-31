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
Public Class dlgDuplicatesConstructed
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private clsDuplicated2, clsDuplicated, clsStreakFunction, clsSubsetCol As New RFunction

    Private Sub dlgDuplicatesConstructed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctConditions As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.iCallType = 2

        ucrPnlOptions.AddRadioButton(rdoDataFrame)
        ucrPnlOptions.AddRadioButton(rdoSelectedVariables)
        ucrPnlOptions.AddRadioButton(rdoSuccessiveValues)

        ucrPnlOptions.AddFunctionNamesCondition(rdoDataFrame, "duplicated2")
        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoSelectedVariables, "x", frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        ucrPnlOptions.AddFunctionNamesCondition(rdoSuccessiveValues, frmMain.clsRLink.strInstatDataObject & "$duplicated_cases")

        ucrPnlOptions.AddToLinkedControls(ucrReceiverForDuplicates, {rdoSelectedVariables, rdoSuccessiveValues}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrPnlDuplicates, {rdoSelectedVariables, rdoDataFrame}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoAllDuplicateCases)
        ucrPnlOptions.AddToLinkedControls({ucrChkOmitValues, ucrChkTolerance}, {rdoSuccessiveValues}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ' Selector
        ' for rdoDataFrame this is ran as a r-function, it isn't run for rdoSelectedVariables. For rdoSuccessiveVariables this is a string so we are doing this manually
        ucrSelectorDuplicateswithVariables.SetParameter(New RParameter("x", 0))
        ucrSelectorDuplicateswithVariables.SetParameterIsrfunction()

        ' Receiver
        ' for rdoDataFrame this not run, this is ran as a r-function for rdoSelectedVariables. For rdoSuccessiveVariables this is a string so we are doing this manually
        ucrReceiverForDuplicates.SetParameter(New RParameter("x", 0))
        ucrReceiverForDuplicates.SetParameterIsRFunction()
        ucrReceiverForDuplicates.Selector = ucrSelectorDuplicateswithVariables
        ucrReceiverForDuplicates.SetMeAsReceiver()
        ucrReceiverForDuplicates.SetLinkedDisplayControl(lblSelectedVariable)

        ' For the first two rdos we have the following control
        ucrPnlDuplicates.AddRadioButton(rdoAllDuplicateCases)
        ucrPnlDuplicates.AddRadioButton(rdoDuplicatesOnly)
        ucrPnlDuplicates.AddRadioButton(rdoIndexNumberOfDuplicates)

        ucrPnlDuplicates.AddFunctionNamesCondition(rdoAllDuplicateCases, "duplicated2")
        ucrPnlDuplicates.AddFunctionNamesCondition(rdoDuplicatesOnly, "duplicated")
        rdoIndexNumberOfDuplicates.Enabled = False 'for now until it's working properly

        ttDuplicates.SetToolTip(rdoAllDuplicateCases, "All cases are given as being duplicate rows")
        ttDuplicates.SetToolTip(rdoDuplicatesOnly, "The first occurrence is not indicated, but further instances are considered duplicates")
        ttDuplicates.SetToolTip(rdoIndexNumberOfDuplicates, "Any duplicates are given their index number")

        ' For rdoSuccessiveVariables we have the following controls
        ucrChkOmitValues.SetText("Omit Value(s)")
        ucrChkOmitValues.AddParameterValuesCondition(False, "ignore", "NULL", True)
        ucrChkOmitValues.AddParameterValuesCondition(True, "ignore", "NULL", False)

        ucrChkOmitValues.AddToLinkedControls(ucrNudOmit, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkOmitValues.AddToLinkedControls(ucrInputConditions, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="==")
        ucrChkOmitValues.SetLinkedDisplayControl(grpOptions)

        ucrChkTolerance.SetText("Tolerance")
        ucrChkTolerance.AddParameterPresentCondition(True, "tolerance")
        ucrChkTolerance.AddParameterPresentCondition(False, "tolerance", False)
        ucrChkTolerance.AddToLinkedControls(ucrInputTolerance, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.01)

        ucrInputTolerance.SetParameter(New RParameter("tolerance", 0))
        ucrInputTolerance.AddQuotesIfUnrecognised = False
        ucrInputTolerance.SetValidationTypeAsNumeric()

        ucrChkTolerance.SetParameter(ucrInputTolerance.GetParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrInputConditions.SetParameter(New RParameter("y"))
        dctConditions.Add("==", "==")
        dctConditions.Add("<", "<")
        dctConditions.Add("<=", "<=")
        dctConditions.Add(">", ">")
        dctConditions.Add(">=", ">=")
        ucrInputConditions.SetItems(dctConditions)
        ucrInputConditions.SetDropDownStyleAsNonEditable()

        ucrNewColumnName.SetPrefix("dup")
        ucrNewColumnName.SetDataFrameSelector(ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames)
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetLabelText("New Column Name:")
    End Sub

    Private Sub SetDefaults()
        clsDuplicated = New RFunction
        clsDuplicated2 = New RFunction
        clsStreakFunction = New RFunction
        clsSubsetCol = New RFunction

        SetDataFrameOrColumns()
        ucrNewColumnName.Reset()
        ucrSelectorDuplicateswithVariables.Reset()

        ' For the first two radio buttons, we run either clsDuplicated or clsDuplicated2
        clsDuplicated.SetRCommand("duplicated")
        clsDuplicated.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsDuplicated2.SetPackageName("questionr")
        clsDuplicated2.SetRCommand("duplicated2")
        'clsDuplicated2.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        'clsDuplicated2.AddParameter("x", frmMain.clsRLink.strInstatDataObject & "$get_data_frame", iPosition:=0)

        ' For the third rdo we run clsStreakFunction
        clsSubsetCol.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsSubsetCol.AddParameter("data_name", Chr(34) & ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsSubsetCol.AddParameter("col_names", ucrReceiverForDuplicates.GetVariableNames(), iPosition:=1)
        clsSubsetCol.SetAssignTo(ucrReceiverForDuplicates.GetVariableNames(False))

        clsStreakFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$duplicated_cases")
        clsStreakFunction.AddParameter("data_name", Chr(34) & ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsStreakFunction.AddParameter("col_name", ucrReceiverForDuplicates.GetVariableNames(), iPosition:=1)
        clsStreakFunction.AddParameter("ignore", "NULL")

        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicated2)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverForDuplicates.AddAdditionalCodeParameterPair(clsDuplicated2, ucrReceiverForDuplicates.GetParameter, iAdditionalPairNo:=1)
        ucrSelectorDuplicateswithVariables.AddAdditionalCodeParameterPair(clsDuplicated, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrNewColumnName.AddAdditionalRCode(clsDuplicated2, 1)
        ucrNewColumnName.AddAdditionalRCode(clsStreakFunction, 2)

        ucrChkOmitValues.SetRCode(clsStreakFunction, bReset)
        ucrNudOmit.SetRCode(clsStreakFunction, bReset)
        ucrChkTolerance.SetRCode(clsStreakFunction, bReset)
        ucrInputTolerance.SetRCode(clsStreakFunction, bReset)
        ucrSelectorDuplicateswithVariables.SetRCode(clsDuplicated2, bReset)

        ucrReceiverForDuplicates.SetRCode(clsDuplicated, bReset)
        ucrNewColumnName.SetRCode(clsDuplicated, bReset)
        ucrPnlDuplicates.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        If bReset Then
            ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        End If
    End Sub

    Private Sub TestOKEnabled()
        If ucrNewColumnName.IsComplete Then
            If (rdoDataFrame.Checked AndAlso ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") OrElse (rdoSelectedVariables.Checked AndAlso Not ucrReceiverForDuplicates.IsEmpty) OrElse (rdoSuccessiveValues.Checked AndAlso Not ucrReceiverForDuplicates.IsEmpty) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetIgnoreVals()
        If ucrChkOmitValues.Checked Then
            clsStreakFunction.AddParameter("ignore", ucrReceiverForDuplicates.GetVariableNames(False) & "[" & ucrReceiverForDuplicates.GetVariableNames(False) & ucrInputConditions.GetText & ucrNudOmit.GetText & "]", iPosition:=2)
        Else
            clsStreakFunction.AddParameter("ignore", "NULL")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetDataFrameOrColumns()
        If rdoDataFrame.Checked Then
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(False)
            ' note that we have to run this here because the parameter x is used for both functions and all four radio buttons
            clsDuplicated.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
            clsDuplicated2.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        ElseIf rdoSelectedVariables.Checked Then
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(True)
            ' note that we have to run this here because the parameter x is used for both functions and all four radio buttons
            clsDuplicated.AddParameter("x", clsRFunctionParameter:=ucrReceiverForDuplicates.GetVariables, iPosition:=0)
            clsDuplicated2.AddParameter("x", clsRFunctionParameter:=ucrReceiverForDuplicates.GetVariables, iPosition:=0)
        ElseIf rdoSuccessiveValues.Checked Then
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(True)
        End If
    End Sub

    Private Sub SetBaseFunction()
        If rdoDataFrame.Checked OrElse rdoSelectedVariables.Checked Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSubsetCol)
            If rdoAllDuplicateCases.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicated2)
            ElseIf rdoDuplicatesOnly.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicated)
            End If
        ElseIf rdoSuccessiveValues.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsStreakFunction)
            If ucrChkOmitValues.Checked Then
                ucrBase.clsRsyntax.AddToBeforeCodes(clsSubsetCol, iPosition:=1)
            Else
                ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSubsetCol)
            End If
        End If
    End Sub

    Private Sub ucrPnlDuplicates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDuplicates.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub ucrSelectorDuplicateswithVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDuplicateswithVariables.ControlValueChanged
        ' These are run as strings, not automatically in the new system so we need to update these when the selector changes.
        clsStreakFunction.AddParameter("data_name", Chr(34) & ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsSubsetCol.AddParameter("data_name", Chr(34) & ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        'SetDataFrameOrColumns() ' TODO: check we don't need this
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        SetDataFrameOrColumns()
    End Sub

    Private Sub ucrReceiverForDuplicates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForDuplicates.ControlValueChanged
        ' These are not run automatically in the new system so we need to update these when the selector changes.
        clsStreakFunction.AddParameter("col_name", ucrReceiverForDuplicates.GetVariableNames(), iPosition:=1)
        clsSubsetCol.AddParameter("col_names", ucrReceiverForDuplicates.GetVariableNames(), iPosition:=1)
        clsSubsetCol.SetAssignTo(ucrReceiverForDuplicates.GetVariableNames(False))
        SetIgnoreVals()
    End Sub

    Private Sub ucrChkOmitValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitValues.ControlValueChanged, ucrNudOmit.ControlValueChanged, ucrInputConditions.ControlValueChanged
        SetBaseFunction()
        SetIgnoreVals()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlContentsChanged, ucrSelectorDuplicateswithVariables.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrReceiverForDuplicates.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class