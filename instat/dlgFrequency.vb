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
Public Class dlgFrequency
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private clsMmtableFunction As New RFunction
    Private clsHeaderTopLeftFunction As New RFunction
    Private clsFrequencyOperator As New ROperator
    Private clsMmtableOperator As New ROperator
    Private clsSummariesHeaderLeftTopFunction, clsSummariesHeaderTopLeftFunction,
            clsVariableHeaderLeftTopFunction, clsVariableHeaderTopLeftFunction,
            clsummaryVariableHeaderLeftTopFunction, clsSummaryVariableHeaderTopLeftFunction As New RFunction
    Private Sub dlgFrequency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 425

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        cmdOptions.Enabled = False ' Temporarily disabled

        'Temporary disable the weight controls
        ucrChkWeight.Enabled = False
        grpMargin.Enabled = False
        ucrChkWeight.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorFrequency.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFrequency.SetParameterIsString()

        ucrReceiverFactors.SetParameter(New RParameter("factors", 1))
        ucrReceiverFactors.SetParameterIsString()
        ucrReceiverFactors.Selector = ucrSelectorFrequency
        ucrReceiverFactors.SetDataType("factor")
        ucrReceiverFactors.SetMeAsReceiver()

        ucrChkStoreResults.SetParameter(New RParameter("store_results", 2))
        ucrChkStoreResults.SetText("Store Results")
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("FALSE")

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 3))
        ucrChkDisplayMargins.SetText("Display Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")

        'ucrPnlMargin.SetParameter(New RParameter("margins", iNewPosition:=4))
        'ucrPnlMargin.AddRadioButton(rdoOuter, Chr(34) & "outer" & Chr(34))
        'ucrPnlMargin.AddRadioButton(rdoSummary, Chr(34) & "summary" & Chr(34))
        'ucrPnlMargin.AddRadioButton(rdoBoth, "c(""outer"",""summary"")")
        'ucrPnlMargin.SetLinkedDisplayControl(grpMargin)

        ucrInputMarginName.SetParameter(New RParameter("margin_name", iNewPosition:=5))
        ucrInputMarginName.SetLinkedDisplayControl(lblMarginName)

        ucrNudSigFigs.SetParameter(New RParameter("signif_fig", 6))
        ucrNudSigFigs.SetMinMax(0, 22)
        ucrNudSigFigs.SetRDefault(2)

        ucrChkDisplayAsPercentage.SetParameter(New RParameter("percentage_type", 7))
        ucrChkDisplayAsPercentage.SetText("As Percentages")
        ucrChkDisplayAsPercentage.SetValuesCheckedAndUnchecked(Chr(34) & "factors" & Chr(34), Chr(34) & "none" & Chr(34))
        ucrChkDisplayAsPercentage.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrReceiverMultiplePercentages.SetParameter(New RParameter("perc_total_factors", 8))
        ucrReceiverMultiplePercentages.SetParameterIsString()
        ucrReceiverMultiplePercentages.Selector = ucrSelectorFrequency
        ucrReceiverMultiplePercentages.SetDataType("factor") ' TODO data this accepts must be in the other receiver too
        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrReceiverMultiplePercentages, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverMultiplePercentages.SetLinkedDisplayControl(lblFactorsAsPercentage)

        ucrChkPercentageProportion.SetParameter(New RParameter("perc_decimal", 9))
        ucrChkPercentageProportion.SetText("Display as Decimal")
        ucrChkPercentageProportion.SetRDefault("FALSE")

        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrChkPercentageProportion, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrChkDisplayMargins.AddToLinkedControls({ucrPnlMargin}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoOuter)
        ucrChkDisplayMargins.AddToLinkedControls(ucrInputMarginName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="All")
        ucrChkTreatColumnAsFactor.AddToLinkedControls({ucrChkDisplaySummariesAsRow, ucrChkDisplayVariablesAsRows}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTreatColumnAsFactor.AddToLinkedControls(ucrChkDisplaySummaryVariablesAsRow, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkTreatColumnAsFactor.SetParameter(New RParameter("treat_columns_as_factor", 10))
        ucrChkTreatColumnAsFactor.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkTreatColumnAsFactor.SetText("Treat Summaries as a Further Factor")

        ucrChkDisplaySummariesAsRow.SetText("Display Summaries As Rows")
        ucrChkDisplaySummariesAsRow.AddParameterPresentCondition(True, "summariesLeftTop")
        ucrChkDisplaySummariesAsRow.AddParameterPresentCondition(False, "summariesLeftTop", False)

        ucrChkDisplaySummaryVariablesAsRow.SetText("Display Summary_Variables As Rows")
        ucrChkDisplaySummaryVariablesAsRow.AddParameterPresentCondition(True, "summariesVariableLeftTop")
        ucrChkDisplaySummaryVariablesAsRow.AddParameterPresentCondition(False, "summariesVariableLeftTop", False)

        ucrChkDisplayVariablesAsRows.SetText("Display Variables As Rows")
        ucrChkDisplayVariablesAsRows.AddParameterPresentCondition(True, "variablesLeftTop")
        ucrChkDisplayVariablesAsRows.AddParameterPresentCondition(False, "variablesLeftTop", False)

        ucrSaveTable.SetPrefix("frequency_table")
        ucrSaveTable.SetSaveTypeAsTable()
        ucrSaveTable.SetDataFrameSelector(ucrSelectorFrequency.ucrAvailableDataFrames)
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetCheckBoxText("Save Table")
        ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsMmtableFunction = New RFunction
        clsHeaderTopLeftFunction = New RFunction
        clsFrequencyOperator = New ROperator
        clsMmtableOperator = New ROperator
        clsSummariesHeaderTopLeftFunction = New RFunction
        clsSummariesHeaderLeftTopFunction = New RFunction
        clsVariableHeaderTopLeftFunction = New RFunction
        clsVariableHeaderLeftTopFunction = New RFunction
        clsummaryVariableHeaderLeftTopFunction = New RFunction
        clsSummaryVariableHeaderTopLeftFunction = New RFunction

        ucrReceiverFactors.SetMeAsReceiver()
        ucrSelectorFrequency.Reset()
        ucrSaveTable.Reset()
        ucrBase.clsRsyntax.lstBeforeCodes.Clear()

        clsSummariesHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsSummariesHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsSummariesHeaderLeftTopFunction.AddParameter("variable", "summary", iPosition:=0)

        clsSummariesHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsSummariesHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsSummariesHeaderTopLeftFunction.AddParameter("variable", "summary", iPosition:=0)

        clsVariableHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsVariableHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsVariableHeaderTopLeftFunction.AddParameter("variable", "variable", iPosition:=0)

        clsVariableHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsVariableHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsVariableHeaderLeftTopFunction.AddParameter("variable", "variable", iPosition:=0)

        clsummaryVariableHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsummaryVariableHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsummaryVariableHeaderLeftTopFunction.AddParameter("variable", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)

        clsSummaryVariableHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsSummaryVariableHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsSummaryVariableHeaderTopLeftFunction.AddParameter("variable", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)

        clsMmtableOperator.SetOperation("+")

        clsFrequencyOperator.SetOperation("+")
        clsFrequencyOperator.AddParameter("mmtable2", clsRFunctionParameter:=clsMmtableFunction, iPosition:=0)

        clsHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsHeaderTopLeftFunction.SetRCommand("header_top_left")

        clsMmtableFunction.SetPackageName("mmtable2")
        clsMmtableFunction.SetRCommand("mmtable")
        clsMmtableFunction.AddParameter("data", "frequency_table", iPosition:=0)
        clsMmtableFunction.AddParameter("cells", "value", iPosition:=1)

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsDefaultFunction.AddParameter("store_results", "FALSE", iPosition:=2)
        clsDefaultFunction.AddParameter("treat_columns_as_factor", "FALSE", iPosition:=10)
        clsDefaultFunction.AddParameter("summaries", "count_label", iPosition:=11)
        clsDefaultFunction.SetAssignTo("frequency_table")

        ucrBase.clsRsyntax.AddToBeforeCodes(clsDefaultFunction, 0)
        ucrBase.clsRsyntax.SetBaseROperator(clsFrequencyOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputMarginName.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverFactors.SetRCode(clsDefaultFunction, bReset)
        ucrChkDisplayMargins.SetRCode(clsDefaultFunction, bReset)
        ucrChkStoreResults.SetRCode(clsDefaultFunction, bReset)
        ucrSelectorFrequency.SetRCode(clsDefaultFunction, bReset)
        ucrNudSigFigs.SetRCode(clsDefaultFunction, bReset)
        'ucrPnlMargin.SetRCode(clsDefaultFunction, bReset)
        ucrChkTreatColumnAsFactor.SetRCode(clsDefaultFunction, bReset)
        ucrChkDisplaySummariesAsRow.SetRCode(clsFrequencyOperator, bReset)
        ucrChkDisplaySummaryVariablesAsRow.SetRCode(clsFrequencyOperator, bReset)
        ucrChkDisplayVariablesAsRows.SetRCode(clsFrequencyOperator, bReset)
        ucrSaveTable.SetRCode(clsFrequencyOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactors.IsEmpty AndAlso ucrSaveTable.IsComplete AndAlso ucrNudSigFigs.GetText <> "" AndAlso Not ucrReceiverFactors.IsEmpty Then 'AndAlso Not clsSummaryCount.clsParameters.Count = 0 Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SettingReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayAsPercentage.ControlValueChanged
        If ucrChkDisplayAsPercentage.Checked Then
            ucrReceiverMultiplePercentages.SetMeAsReceiver()
        Else
            ucrReceiverFactors.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrReceiverFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlValueChanged
        clsFrequencyOperator.RemoveParameterByName("tops")
        clsMmtableOperator.ClearParameters()
        If ucrReceiverFactors.GetCount() > 0 Then
            clsHeaderTopLeftFunction.AddParameter("variable", ucrReceiverFactors.GetVariableNamesAsList().Item(0), iPosition:=0)
            clsMmtableOperator.AddParameter("leftTop", clsRFunctionParameter:=clsHeaderTopLeftFunction, iPosition:=0)
            If ucrReceiverFactors.GetCount() > 1 Then
                Dim iCount As Integer = 0
                For Each StrVariableName As String In ucrReceiverFactors.GetVariableNamesAsList()
                    Dim clsHeaderLeftTopFunction As New RFunction
                    clsHeaderLeftTopFunction.SetPackageName("mmtable2")
                    clsHeaderLeftTopFunction.SetRCommand("header_left_top")
                    If iCount >= 1 Then
                        clsHeaderLeftTopFunction.AddParameter("variable", ucrReceiverFactors.GetVariableNamesAsList().Item(iCount), iPosition:=iCount - 1)
                        clsMmtableOperator.AddParameter("icount", clsRFunctionParameter:=clsHeaderLeftTopFunction, iPosition:=iCount)
                    End If
                    iCount += 1
                Next
            End If
            clsFrequencyOperator.AddParameter("tops", clsROperatorParameter:=clsMmtableOperator, iPosition:=1)
        End If
    End Sub

    Private Sub Display_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplaySummariesAsRow.ControlValueChanged, ucrChkDisplayVariablesAsRows.ControlValueChanged, ucrChkDisplaySummaryVariablesAsRow.ControlValueChanged, ucrChkTreatColumnAsFactor.ControlValueChanged
        clsFrequencyOperator.RemoveParameterByName("summariesTopLeft")
        clsFrequencyOperator.RemoveParameterByName("summariesLeftTop")
        clsFrequencyOperator.RemoveParameterByName("variablesTopLeft")
        clsFrequencyOperator.RemoveParameterByName("variablesLeftTop")
        clsFrequencyOperator.RemoveParameterByName("summariesVariableTopLeft")
        clsFrequencyOperator.RemoveParameterByName("summariesVariableLeftTop")

        If ucrChkTreatColumnAsFactor.Checked Then
            If ucrChkDisplaySummariesAsRow.Checked Then
                clsFrequencyOperator.AddParameter("summariesLeftTop", clsRFunctionParameter:=clsSummariesHeaderLeftTopFunction, iPosition:=1)
            Else
                clsFrequencyOperator.AddParameter("summariesTopLeft", clsRFunctionParameter:=clsSummariesHeaderTopLeftFunction, iPosition:=1)
            End If

            If ucrChkDisplayVariablesAsRows.Checked Then
                clsFrequencyOperator.AddParameter("variablesLeftTop", clsRFunctionParameter:=clsVariableHeaderLeftTopFunction, iPosition:=1)
            Else
                clsFrequencyOperator.AddParameter("variablesTopLeft", clsRFunctionParameter:=clsVariableHeaderTopLeftFunction, iPosition:=1)
            End If
        Else
            If ucrChkDisplaySummaryVariablesAsRow.Checked Then
                clsFrequencyOperator.AddParameter("summariesVariableLeftTop", clsRFunctionParameter:=clsummaryVariableHeaderLeftTopFunction, iPosition:=1)
            Else
                clsFrequencyOperator.AddParameter("summariesVariableTopLeft", clsRFunctionParameter:=clsSummaryVariableHeaderTopLeftFunction, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlContentsChanged, ucrSaveTable.ControlContentsChanged, ucrNudSigFigs.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class