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
Public Class dlgDuplicateRows
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private clsDuplicated2, clsDuplicated, clsStreakFunction, clsSubsetCol, clsDupCountIndex, clsSummaryFunction, clsGetColumnsFunction As New RFunction

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
        ucrBase.iHelpTopicID = 547
        Dim dctConditions As New Dictionary(Of String, String)
        Dim dctType As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 0

        ucrPnlOptions.AddRadioButton(rdoDataFrame)
        ucrPnlOptions.AddRadioButton(rdoSelectedVariables)
        ucrPnlOptions.AddRadioButton(rdoSuccessiveValues)

        ucrPnlOptions.AddFunctionNamesCondition(rdoDataFrame, "duplicated2")
        ucrPnlOptions.AddFunctionNamesCondition(rdoSelectedVariables, "duplicated")
        ucrPnlOptions.AddFunctionNamesCondition(rdoSuccessiveValues, "duplicated_cases")

        ucrPnlOptions.AddToLinkedControls(ucrReceiverForSelectedVariables, {rdoSelectedVariables}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrPnlDuplicates, {rdoDataFrame, rdoSelectedVariables}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoAllDuplicateCases)
        ucrPnlOptions.AddToLinkedControls({ucrChkOmitValues, ucrChkTolerance, ucrReceiverForSuccessiveValues}, {rdoSuccessiveValues}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlDuplicates.AddRadioButton(rdoAllDuplicateCases)
        ucrPnlDuplicates.AddRadioButton(rdoDuplicatesOnly)
        ucrPnlDuplicates.AddRadioButton(rdoIndexNumberOfDuplicates)

        ucrPnlDuplicates.AddToLinkedControls(ucrInputComboType, {rdoIndexNumberOfDuplicates}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboType.SetLinkedDisplayControl(lblType)

        ucrPnlDuplicates.AddFunctionNamesCondition(rdoAllDuplicateCases, "duplicated2")
        ucrPnlDuplicates.AddFunctionNamesCondition(rdoDuplicatesOnly, "duplicated")


        ' for rdoSuccessiveVariables this is ran as a string, it isn't run for rdoSelectedVariables.For rdodataframe this is ran as an r-function so we are doing this manually but passing the parameter in the additional code pair
        ucrSelectorDuplicateswithVariables.SetParameter(New RParameter("x", 0))
        ucrSelectorDuplicateswithVariables.SetParameterIsString()
        ucrSelectorDuplicateswithVariables.bUseCurrentFilter = False

        ucrReceiverForSelectedVariables.SetParameter(New RParameter("x", 0))
        ucrReceiverForSelectedVariables.SetParameterIsRFunction()
        ucrReceiverForSelectedVariables.Selector = ucrSelectorDuplicateswithVariables
        ucrReceiverForSelectedVariables.SetLinkedDisplayControl(lblVariablesToDuplicate)
        ucrReceiverForSelectedVariables.bUseFilteredData = False

        ttDuplicates.SetToolTip(rdoAllDuplicateCases, "All cases are given as being duplicate rows")
        ttDuplicates.SetToolTip(rdoDuplicatesOnly, "The first occurrence is not indicated, but further instances are considered duplicates")
        ttDuplicates.SetToolTip(rdoIndexNumberOfDuplicates, "Any duplicates are given their index number")

        ' For rdoSuccessiveVariables we have the following controls
        ucrReceiverForSuccessiveValues.SetParameter(New RParameter("col_name", 1))
        ucrReceiverForSuccessiveValues.SetParameterIsRFunction()
        ucrReceiverForSuccessiveValues.Selector = ucrSelectorDuplicateswithVariables
        ucrReceiverForSuccessiveValues.SetLinkedDisplayControl(lblSelectedVariable)
        ucrReceiverForSuccessiveValues.bUseFilteredData = False

        ucrChkOmitValues.SetText("Omit Value(s)")
        ucrChkOmitValues.AddParameterValuesCondition(False, "ignore", "NULL", True)
        ucrChkOmitValues.AddParameterValuesCondition(True, "ignore", "NULL", False)
        ucrChkOmitValues.AddToLinkedControls(ucrInputOmitValues, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkOmitValues.AddToLinkedControls(ucrInputConditions, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="==")
        ucrChkOmitValues.SetLinkedDisplayControl(grpOptions)

        ucrInputTolerance.SetParameter(New RParameter("tolerance", 0))
        ucrInputTolerance.AddQuotesIfUnrecognised = False
        ucrInputTolerance.SetValidationTypeAsNumeric()

        ucrChkTolerance.SetParameter(ucrInputTolerance.GetParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkTolerance.SetText("Tolerance")
        ucrChkTolerance.AddParameterPresentCondition(True, "tolerance")
        ucrChkTolerance.AddParameterPresentCondition(False, "tolerance", False)
        ucrChkTolerance.AddToLinkedControls(ucrInputTolerance, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.01)

        ucrInputConditions.SetParameter(New RParameter("y"))
        dctConditions.Add("==", "==")
        dctConditions.Add("<", "<")
        dctConditions.Add("<=", "<=")
        dctConditions.Add(">", ">")
        dctConditions.Add(">=", ">=")
        ucrInputConditions.SetItems(dctConditions)
        ucrInputConditions.SetDropDownStyleAsNonEditable()

        ucrInputComboType.SetParameter(New RParameter("type"))
        dctType.Add("Index", Chr(34) & "index" & Chr(34))
        dctType.Add("Count", Chr(34) & "count" & Chr(34))
        ucrInputComboType.SetDropDownStyleAsNonEditable()
        ucrInputComboType.SetItems(dctType)

        ucrChkIncludeSummary.SetText("Display Summary")
        ucrChkIncludeSummary.AddRSyntaxContainsFunctionNamesCondition(True, {"summary"})
        ucrChkIncludeSummary.AddRSyntaxContainsFunctionNamesCondition(False, {"summary"}, False)

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
        clsDupCountIndex = New RFunction
        clsGetColumnsFunction = New RFunction
        clsSummaryFunction = New RFunction

        SetDataFrameOrColumns()
        ucrNewColumnName.Reset()
        ucrSelectorDuplicateswithVariables.Reset()

        ' For the first two radio buttons, we run either clsDuplicated or clsDuplicated2
        clsDuplicated.SetRCommand("duplicated")
        clsDuplicated.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsDuplicated2.SetPackageName("questionr")
        clsDuplicated2.SetRCommand("duplicated2")

        ' For the third rdo we run clsStreakFunction
        clsStreakFunction.SetRCommand("duplicated_cases")
        clsStreakFunction.AddParameter("ignore", "NULL")

        clsDupCountIndex.SetRCommand("duplicated_count_index")
        clsDupCountIndex.AddParameter("type", Chr(34) & "index" & Chr(34))

        clsGetColumnsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsGetColumnsFunction)
        clsSummaryFunction.iCallType = 2

        clsSubsetCol.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicated)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverForSelectedVariables.AddAdditionalCodeParameterPair(clsDuplicated2, New RParameter("x", 1), iAdditionalPairNo:=1)
        ucrReceiverForSelectedVariables.AddAdditionalCodeParameterPair(clsDupCountIndex, New RParameter("x", 1), iAdditionalPairNo:=2)
        ucrSelectorDuplicateswithVariables.AddAdditionalCodeParameterPair(clsDuplicated2, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrSelectorDuplicateswithVariables.AddAdditionalCodeParameterPair(clsDupCountIndex, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrNewColumnName.AddAdditionalRCode(clsDuplicated2, iAdditionalPairNo:=1)
        ucrNewColumnName.AddAdditionalRCode(clsStreakFunction, iAdditionalPairNo:=2)
        ucrNewColumnName.AddAdditionalRCode(clsDupCountIndex, iAdditionalPairNo:=3)
        ucrNewColumnName.AddAdditionalRCode(clsGetColumnsFunction, iAdditionalPairNo:=4)

        ucrInputComboType.SetRCode(clsDupCountIndex, bReset)
        ucrReceiverForSuccessiveValues.SetRCode(clsStreakFunction, bReset)
        ucrChkOmitValues.SetRCode(clsStreakFunction, bReset)
        ucrInputOmitValues.SetRCode(clsStreakFunction, bReset)
        ucrChkTolerance.SetRCode(clsStreakFunction, bReset)
        ucrInputTolerance.SetRCode(clsStreakFunction, bReset)
        ucrSelectorDuplicateswithVariables.SetRCode(clsDuplicated, bReset)
        ucrReceiverForSelectedVariables.SetRCode(clsDuplicated, bReset)
        ucrNewColumnName.SetRCode(clsDuplicated, bReset)
        ucrPnlDuplicates.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkIncludeSummary.SetRSyntax(ucrBase.clsRsyntax, bReset)

        If bReset Then
            ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        End If
        AddDataFrameForGetColumnsFunction()
    End Sub

    Private Sub TestOKEnabled()
        If ucrNewColumnName.IsComplete Then
            If (rdoDataFrame.Checked AndAlso ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") OrElse (rdoSelectedVariables.Checked AndAlso Not ucrReceiverForSelectedVariables.IsEmpty) OrElse (rdoSuccessiveValues.Checked AndAlso Not ucrReceiverForSuccessiveValues.IsEmpty AndAlso ((ucrChkOmitValues.Checked AndAlso ucrInputOmitValues.GetText <> "") OrElse Not ucrChkOmitValues.Checked) AndAlso ((ucrChkTolerance.Checked AndAlso Not ucrInputTolerance.IsEmpty) OrElse Not ucrChkTolerance.Checked)) Then
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
                clsStreakFunction.AddParameter("ignore", clsSubsetCol.ToScript & "[" & clsSubsetCol.ToScript & ucrInputConditions.GetText & Chr(34) & ucrInputOmitValues.GetText & Chr(34) & "]", iPosition:=2)
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
        If rdoSelectedVariables.Checked Then
            ucrNewColumnName.setLinkedReceiver(ucrReceiverForSelectedVariables)
        ElseIf rdoSuccessiveValues.Checked Then
            ucrNewColumnName.setLinkedReceiver(ucrReceiverForSuccessiveValues)
        End If
    End Sub

    Private Sub ucrChkIncludeSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeSummary.ControlValueChanged
        If ucrChkIncludeSummary.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
        End If
    End Sub

    Private Sub SetDataFrameOrColumns()
        If rdoSelectedVariables.Checked Then
            ucrReceiverForSelectedVariables.SetMeAsReceiver()
            ucrReceiverForSelectedVariables.SetParameterIsRFunction()
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(True)
        ElseIf rdoDataFrame.Checked Then
            ' note that we have to run this here because the parameter x is used for both functions and all four radio buttons
            clsDuplicated.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
            clsDuplicated2.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
            clsDupCountIndex.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
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
            ElseIf rdoIndexNumberOfDuplicates.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsDupCountIndex)
            End If
        ElseIf rdoSuccessiveValues.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsStreakFunction)
        End If
    End Sub

    Private Sub ucrPnlDuplicates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDuplicates.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub rdoSelectedVariables_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSelectedVariables.CheckedChanged

    End Sub

    Private Sub AddDataFrameForGetColumnsFunction()
        clsGetColumnsFunction.AddParameter(strParameterName:="data_name", strParameterValue:=Chr(34) & ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34), iPosition:=0)
    End Sub

    Private Sub ucrSelectorDuplicateswithVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDuplicateswithVariables.ControlValueChanged
        SetDataFrameOrColumns()
        AddDataFrameForGetColumnsFunction()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        SetDataFrameOrColumns()
    End Sub

    Private Sub ucrNewColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlValueChanged
        'change the parameter values
        clsGetColumnsFunction.AddParameter(strParameterName:="col_names", strParameterValue:=Chr(34) & ucrNewColumnName.GetText & Chr(34), iPosition:=1)
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlContentsChanged, ucrSelectorDuplicateswithVariables.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrReceiverForSelectedVariables.ControlContentsChanged, ucrReceiverForSuccessiveValues.ControlContentsChanged, ucrChkOmitValues.ControlContentsChanged, ucrChkTolerance.ControlContentsChanged, ucrInputTolerance.ControlContentsChanged, ucrInputOmitValues.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrCoreControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitValues.ControlValueChanged, ucrReceiverForSuccessiveValues.ControlValueChanged, ucrInputConditions.ControlValueChanged, ucrInputOmitValues.ControlValueChanged
        SetIgnoreVals()
    End Sub
End Class