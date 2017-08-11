﻿' R- Instat
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

Imports instat
Imports instat.Translations
Public Class dlgClimaticSummary
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsDefaultFunction, clsSummariesList, clsDefaultFactors As New RFunction
    Private clsKeyFunction, clsAddKeyColName, clsDayFromAndTo As New RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator As New ROperator
    Private strCurrDataName As String = ""
    'Dim strGroupByCalcFrom As String = ""
    Private strTempFuc As String = ""
    Private Sub dlgClimaticSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    ' if within-year is checked, add within-year receiver
    ' if annual-variable is checked, add from.to receiver (or display!)
    ' if annual is checked, display from/to nuds

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 510
        rdoAnnualVariable.Enabled = False
        ucrChkDropUnusedLevels.Enabled = False ' removed this functionality so this is disabled

        ucrSelectorVariable.SetParameter(New RParameter("data_name", 0))
        ucrSelectorVariable.SetParameterIsString()

        'panel setting
        ucrPnlAnnual.AddRadioButton(rdoAnnual)
        ucrPnlAnnual.AddRadioButton(rdoAnnualVariable)
        ucrPnlAnnual.AddRadioButton(rdoWithinYear)

        ucrPnlAnnual.AddParameterPresentCondition(rdoWithinYear, "within_variable", True)
        ucrPnlAnnual.AddParameterPresentCondition(rdoAnnual, "within_variable", False)
        ucrPnlAnnual.AddParameterPresentCondition(rdoAnnualVariable, "within_variable", False)

        'receivers:
        ' by receivers
        ucrReceiverStation.SetParameter(New RParameter("station", 0, False))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorVariable
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverYear.SetParameter(New RParameter("year", 1, False))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorVariable
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverWithinYear.SetParameter(New RParameter("within_variable", 2, False))
        ucrReceiverWithinYear.SetParameterIsString()
        ucrReceiverWithinYear.strSelectorHeading = "Variables"
        ucrReceiverWithinYear.Selector = ucrSelectorVariable
        ucrReceiverWithinYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "month" & Chr(34)}) ' TODO: fix this and allow others, e.g., dekad, weekly, day, doy, etc.
        ucrReceiverWithinYear.bAutoFill = True

        ' summary
        ucrReceiverElement.SetParameter(New RParameter("columns_to_summarise", 0))
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.strSelectorHeading = "Variables"
        ucrReceiverElement.Selector = ucrSelectorVariable
        ucrReceiverElement.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)}) ' TODO: fix this and allow others, e.g., temps
        ucrReceiverElement.bAutoFill = True

        ' others
        ucrReceiverDate.SetParameter(New RParameter("date", 1))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorVariable
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsRFunction()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorVariable
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverDOY.strSelectorHeading = "Day Variables"

        'setting up Nuds
        ucrNudFrom.SetParameter(New RParameter("from", 1))
        ucrNudFrom.SetMinMax(1, 365)

        ucrNudTo.SetParameter(New RParameter("to", 1))
        ucrNudTo.SetMinMax(2, 366)

        'TODO: set up this receiver for annual-variable
        ucrReceiverFrom.Selector = ucrSelectorVariable
        ucrReceiverTo.Selector = ucrSelectorVariable

        ' Other checkbox options
        ucrChkStoreResults.SetParameter(New RParameter("store_results", 3))
        ucrChkStoreResults.SetText("Store Results in Data Frame")
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("TRUE")

        ucrChkPrintOutput.SetParameter(New RParameter("return_output", 4))
        ucrChkPrintOutput.SetText("Print Results to Output Window")
        ucrChkPrintOutput.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPrintOutput.SetRDefault("FALSE")

        ucrChkDropUnusedLevels.SetParameter(New RParameter("drop", 5))
        ucrChkDropUnusedLevels.SetText("Drop Unused Levels")
        ucrChkDropUnusedLevels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDropUnusedLevels.SetRDefault("FALSE")

        'linking controls
        ucrPnlAnnual.AddToLinkedControls(ucrNudFrom, {rdoAnnual}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnual.AddToLinkedControls(ucrNudTo, {rdoAnnual}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=366)
        ucrPnlAnnual.AddToLinkedControls({ucrReceiverFrom, ucrReceiverTo}, {rdoAnnualVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnual.AddToLinkedControls({ucrReceiverWithinYear}, {rdoWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudFrom.SetLinkedDisplayControl(lblFrom)
        ucrNudTo.SetLinkedDisplayControl(lblTo)
        ucrReceiverFrom.SetLinkedDisplayControl(lblReceiverFrom)
        ucrReceiverTo.SetLinkedDisplayControl(lblReceiverTo)
        ucrReceiverWithinYear.SetLinkedDisplayControl(lblWithinYear)
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsSummariesList = New RFunction
        clsDefaultFactors = New RFunction

        clsDayFromAndToOperator = New ROperator
        clsDayFromAndTo = New RFunction
        clsDayFromOperator = New ROperator
        clsDayToOperator = New ROperator
        clsKeyFunction = New RFunction
        clsAddKeyColName = New RFunction

        bResetSubdialog = True
        ucrSelectorVariable.Reset()
        ucrReceiverStation.SetMeAsReceiver()

        clsKeyFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsKeyFunction.AddParameter("col_name", clsRFunctionParameter:=clsAddKeyColName)
        clsAddKeyColName.SetRCommand("c")

        'TODO: this changes to from >= receiver and to <= receiver if annual-variable is checekd.
        clsDayFromAndToOperator.bToScriptAsRString = True
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsDayFromAndTo.AddParameter("function_exp", clsROperatorParameter:=clsDayFromAndToOperator, iPosition:=1)
        clsDayFromAndToOperator.SetOperation("&")
        clsDayFromAndToOperator.AddParameter("from", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDayFromOperator.SetOperation(">=") ' doy = DOY_receiver in position 0. This is always the case
        clsDayFromOperator.AddParameter("from", 1, iPosition:=1)
        clsDayFromAndToOperator.AddParameter("to", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDayToOperator.SetOperation("<=") ' doy = DOY_receiver in position 0. This is always the case
        clsDayToOperator.AddParameter("to", 366, iPosition:=1)
        clsDayFromAndTo.SetAssignTo("day_from_and_to")

        'TODO: what defaults do we want?
        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsDefaultFunction.AddParameter("factors", clsRFunctionParameter:=clsDefaultFactors, iPosition:=1)
        clsDefaultFunction.AddParameter("additional_filter", clsRFunctionParameter:=clsDayFromAndTo, iPosition:=5)
        clsDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList)
        clsDefaultFunction.AddParameter("silent", "TRUE") 'Prevents an error if user chooses non count summaries with no columns to summarise

        clsDefaultFactors.SetRCommand("c")

        ucrBase.clsRsyntax.AddToAfterCodes(clsKeyFunction, iPosition:=0)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrSelectorVariable.AddAdditionalCodeParameterPair(clsKeyFunction, ucrSelectorVariable.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsAddKeyColName, ucrReceiverStation.GetParameter, iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)
        ucrNudTo.SetRCode(clsDayToOperator, bReset)
        ucrNudFrom.SetRCode(clsDayFromOperator, bReset)

        ucrSelectorVariable.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverElement.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverDate.SetRCode(clsAddKeyColName, bReset)

        ucrPnlAnnual.SetRCode(clsDefaultFactors, bReset)
        ucrReceiverStation.SetRCode(clsDefaultFactors, bReset)
        ucrReceiverYear.SetRCode(clsDefaultFactors, bReset)
        ucrReceiverWithinYear.SetRCode(clsDefaultFactors, bReset)
    End Sub

    'TODO: run these things at the correct times
    Public Sub TestOKEnabled()
        If Not clsSummariesList.clsParameters.Count = 0 AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty Then
            If rdoAnnual.Checked Then
                If ucrNudFrom.GetText <> "" AndAlso ucrNudTo.GetText <> "" AndAlso Not ucrReceiverDOY.IsEmpty AndAlso (Not ucrReceiverYear.IsEmpty OrElse Not ucrReceiverStation.IsEmpty) Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoAnnualVariable.Checked Then
                If Not ucrReceiverFrom.IsEmpty AndAlso Not ucrReceiverTo.IsEmpty AndAlso (Not ucrReceiverYear.IsEmpty OrElse Not ucrReceiverStation.IsEmpty) Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoWithinYear.Checked Then
                If ucrNudFrom.GetText <> "" AndAlso ucrNudTo.GetText <> "" AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverWithinYear.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummary_Click(sender As Object, e As EventArgs) Handles cmdSummary.Click
        sdgSummaries.SetRFunction(clsSummariesList, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub DayBoundaries()
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged, ucrSelectorVariable.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        DayBoundaries()
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverWithinYear.ControlContentsChanged, ucrPnlAnnual.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class