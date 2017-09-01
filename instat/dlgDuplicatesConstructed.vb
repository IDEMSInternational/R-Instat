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

Imports RDotNet
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

        ucrPnlOptions.AddRadioButton(rdoDataFrame)
        ucrPnlOptions.AddRadioButton(rdoSelectedVariables)
        ucrPnlOptions.AddRadioButton(rdoSuccessiveValues)

        ucrPnlDuplicates.AddRadioButton(rdoAllDuplicateCases)
        ucrPnlDuplicates.AddRadioButton(rdoDuplicatesOnly)
        ucrPnlDuplicates.AddRadioButton(rdoIndexNumberOfDuplicates)

        ucrPnlOptions.AddFunctionNamesCondition(rdoDataFrame, "duplicated2")
        ucrPnlOptions.AddFunctionNamesCondition(rdoSelectedVariables, "duplicated")
        ucrPnlOptions.AddFunctionNamesCondition(rdoSuccessiveValues, frmMain.clsRLink.strInstatDataObject & "$duplicated_cases")

        ucrPnlOptions.AddToLinkedControls(ucrReceiverForSelectedVariables, {rdoSelectedVariables}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrPnlDuplicates, {rdoSelectedVariables, rdoDataFrame}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoAllDuplicateCases)
        ucrPnlOptions.AddToLinkedControls({ucrChkOmitValues, ucrChkTolerance, ucrReceiverForSuccessiveValues}, {rdoSuccessiveValues}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkOmitValues.SetText("Omit Value(s)")

        ucrReceiverForSelectedVariables.SetLinkedDisplayControl(lblVariablesToDuplicate)
        ucrChkOmitValues.AddParameterValuesCondition(False, "ignore", "NULL", True)
        ucrChkOmitValues.AddParameterValuesCondition(True, "ignore", "NULL", False)

        ucrChkOmitValues.AddToLinkedControls(ucrNudOmit, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkOmitValues.AddToLinkedControls(ucrInputConditions, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="==")
        ucrChkOmitValues.SetLinkedDisplayControl(grpOptions)

        ucrInputTolerance.SetParameter(New RParameter("tolerance", 0))
        ucrInputTolerance.AddQuotesIfUnrecognised = False

        ucrChkTolerance.SetParameter(ucrInputTolerance.GetParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkTolerance.SetText("Tolerance")
        ucrChkTolerance.AddParameterPresentCondition(True, "tolerance")
        ucrChkTolerance.AddParameterPresentCondition(False, "tolerance", False)

        ucrChkTolerance.AddToLinkedControls(ucrInputTolerance, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.01)
        ucrInputTolerance.SetValidationTypeAsNumeric()

        ucrSelectorDuplicateswithVariables.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDuplicateswithVariables.SetParameterIsString()

        ucrReceiverForSelectedVariables.SetParameter(New RParameter("x", 0))
        ucrReceiverForSelectedVariables.SetParameterIsRFunction()
        ucrReceiverForSelectedVariables.Selector = ucrSelectorDuplicateswithVariables

        ' for rdoSuccessiveVariables only
        ucrReceiverForSuccessiveValues.SetParameter(New RParameter("col_name", 1))
        ucrReceiverForSuccessiveValues.SetParameterIsString()
        ucrReceiverForSuccessiveValues.Selector = ucrSelectorDuplicateswithVariables
        ucrReceiverForSuccessiveValues.SetLinkedDisplayControl(lblSelectedVariable)

        ucrInputConditions.SetParameter(New RParameter("y"))
        dctConditions.Add("==", "==")
        dctConditions.Add("<", "<")
        dctConditions.Add("<=", "<=")
        dctConditions.Add(">", ">")
        dctConditions.Add(">=", ">=")
        ucrInputConditions.SetItems(dctConditions)
        ucrInputConditions.SetDropDownStyleAsNonEditable()

        ucrPnlDuplicates.AddFunctionNamesCondition(rdoAllDuplicateCases, "duplicated2")
        ucrPnlDuplicates.AddFunctionNamesCondition(rdoDuplicatesOnly, "duplicated")
        rdoIndexNumberOfDuplicates.Enabled = False 'for now until it's working properly

        ttDuplicates.SetToolTip(rdoAllDuplicateCases, "All cases are given as being duplicate rows")
        ttDuplicates.SetToolTip(rdoDuplicatesOnly, "The first occurrence is not indicated, but further instances are considered duplicates")
        ttDuplicates.SetToolTip(rdoIndexNumberOfDuplicates, "Any duplicates are given their index number")

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
        ucrReceiverForSelectedVariables.SetMeAsReceiver()
        ucrReceiverForSuccessiveValues.SetMeAsReceiver()

        ucrBase.clsRsyntax.iCallType = 2
        clsDuplicated.SetRCommand("duplicated")
        clsDuplicated.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsStreakFunction.AddParameter("ignore", "NULL")
        clsDuplicated2.SetPackageName("questionr")
        clsDuplicated2.SetRCommand("duplicated2")

        clsStreakFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$duplicated_cases")
        clsSubsetCol.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicated2)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverForSelectedVariables.AddAdditionalCodeParameterPair(clsDuplicated2, New RParameter("x", 1), iAdditionalPairNo:=1)
        'ucrReceiverForSuccessiveValues.AddAdditionalCodeParameterPair(clsSubsetCol, New RParameter("col_name", 1), iAdditionalPairNo:=3)
        ucrSelectorDuplicateswithVariables.AddAdditionalCodeParameterPair(clsDuplicated2, New RParameter("x", 0), iAdditionalPairNo:=1)
        '  ucrSelectorDuplicateswithVariables.AddAdditionalCodeParameterPair(clsSubsetCol, ucrSelectorDuplicateswithVariables.GetParameter, iAdditionalPairNo:=2)
        ucrSelectorDuplicateswithVariables.AddAdditionalCodeParameterPair(clsDuplicated, New RParameter("x", 0), iAdditionalPairNo:=2)

        ucrNewColumnName.AddAdditionalRCode(clsDuplicated2, 1)
        ucrNewColumnName.AddAdditionalRCode(clsStreakFunction, 2)

        ucrReceiverForSuccessiveValues.SetRCode(clsStreakFunction, bReset)
        ucrChkOmitValues.SetRCode(clsStreakFunction, bReset)
        ucrNudOmit.SetRCode(clsStreakFunction, bReset)
        ucrChkTolerance.SetRCode(clsStreakFunction, bReset)
        ucrInputTolerance.SetRCode(clsStreakFunction, bReset)
        ucrSelectorDuplicateswithVariables.SetRCode(clsStreakFunction, bReset)
        ucrReceiverForSelectedVariables.SetRCode(clsDuplicated, bReset)
        ucrNewColumnName.SetRCode(clsDuplicated, bReset)
        ucrPnlDuplicates.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        If bReset Then
            ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        End If
    End Sub

    Private Sub TestOKEnabled()
        If ucrNewColumnName.IsComplete Then
            If (rdoDataFrame.Checked AndAlso ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") OrElse (rdoSelectedVariables.Checked AndAlso Not ucrReceiverForSelectedVariables.IsEmpty) OrElse (rdoSuccessiveValues.Checked AndAlso Not ucrReceiverForSuccessiveValues.IsEmpty AndAlso ((ucrChkOmitValues.Checked AndAlso ucrNudOmit.GetText <> "") OrElse Not ucrChkOmitValues.Checked) AndAlso ((ucrChkTolerance.Checked AndAlso Not ucrInputTolerance.IsEmpty) OrElse Not ucrChkTolerance.Checked)) Then
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
            If Not ucrReceiverForSuccessiveValues.IsEmpty Then
                clsSubsetCol.AddParameter("col_name", ucrReceiverForSuccessiveValues.GetVariableNames())
                clsSubsetCol.AddParameter("data_name", Chr(34) & ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
                frmMain.clsRLink.RunInternalScriptGetValue(clsSubsetCol.ToScript)
                clsStreakFunction.AddParameter("ignore", clsSubsetCol.ToScript & "[" & clsSubsetCol.ToScript & ucrInputConditions.GetText & ucrNudOmit.GetText & "]", iPosition:=2)
            Else
                clsStreakFunction.AddParameter("ignore", "NULL")
            End If
        Else
                clsSubsetCol.RemoveParameterByName("col_name")
            clsSubsetCol.RemoveParameterByName("data_name")
            clsStreakFunction.AddParameter("ignore", "NULL", iPosition:=2)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        SetDataFrameOrColumns()
    End Sub

    Private Sub SetDataFrameOrColumns()
        If rdoDataFrame.Checked Then
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(False)
            ucrSelectorDuplicateswithVariables.SetParameterIsrfunction()
            clsDuplicated.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
            clsDuplicated2.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        ElseIf rdoSelectedVariables.Checked Then
            ucrReceiverForSelectedVariables.SetMeAsReceiver()
            ucrSelectorDuplicateswithVariables.SetParameterIsrfunction()
            ucrReceiverForSelectedVariables.SetParameterIsRFunction()
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(True)
        ElseIf rdoSuccessiveValues.Checked Then
            ucrReceiverForSuccessiveValues.SetMeAsReceiver()
            ucrSelectorDuplicateswithVariables.SetParameterIsString()
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(True)
        End If
    End Sub

    Private Sub SetBaseFunction()
        If rdoDataFrame.Checked OrElse rdoSelectedVariables.Checked Then
            If rdoAllDuplicateCases.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicated2)
            ElseIf rdoDuplicatesOnly.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicated)
            End If
        ElseIf rdoSuccessiveValues.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsStreakFunction)
        End If
    End Sub

    Private Sub ucrPnlDuplicates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDuplicates.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub ucrSelectorDuplicateswithVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDuplicateswithVariables.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        SetDataFrameOrColumns()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlContentsChanged, ucrSelectorDuplicateswithVariables.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrReceiverForSelectedVariables.ControlContentsChanged, ucrReceiverForSuccessiveValues.ControlContentsChanged, ucrChkOmitValues.ControlContentsChanged, ucrChkTolerance.ControlContentsChanged, ucrNudOmit.ControlContentsChanged, ucrInputTolerance.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkOmitValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitValues.ControlValueChanged, ucrReceiverForSuccessiveValues.ControlValueChanged, ucrNudOmit.ControlValueChanged, ucrInputConditions.ControlValueChanged
        SetIgnoreVals()
    End Sub
End Class