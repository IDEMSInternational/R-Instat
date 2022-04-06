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
Public Class dlgDescribeTwoVariable
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Public strFirstVariablesType, strSecondVariableType As String
    Public clsGetDataType, clsGetSecondDataType, clsRCorrelation, clsRCustomSummary,
           clsCombineFunction, clsRAnova, clsFrequencyTables, clsSkimrFunction, clsSummariesList,
           clsGroupByFunction, clsDummyFunction, clsMmtableFunction, clsHeaderTopLeftSummaryVariableFunction,
           clsHeaderLeftFunction, clsHeaderTopFunction, clsHeaderLeftTopFuncion, clsCombineFrequencyParameters,
           clsSummaryMapFunction, clsFactorVectorFunction, clsMmtableMapFunction As New RFunction
    Private clsGroupByPipeOperator, clsMmtablePlusOperator, clsMapFrequencyPipeOperator,
             clsMmtableTildeOperator, clsDataSummaryTildeOperator As New ROperator
    Private lstFrequencyParameters As New List(Of String)({"percentage_type", "margin_name",
                                                          "perc_total_factors", "perc_decimal",
                                                          "signif_fig", "include_margins"})
    Private iUcrBaseXLocation, iDialogueXsize As Integer

    Private Sub dlgDescribeTwoVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 414
        ucrBase.clsRsyntax.iCallType = 2

        iUcrBaseXLocation = ucrBase.Location.X
        iDialogueXsize = Me.Size.Width

        ucrSelectorDescribeTwoVar.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDescribeTwoVar.SetParameterIsString()

        ucrReceiverFirstVars.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverFirstVars.SetParameterIsString()
        ucrReceiverFirstVars.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverFirstVars.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)

        ucrReceiverSecondVar.SetParameter(New RParameter("factors", 2))
        ucrReceiverSecondVar.SetParameterIsString()
        ucrReceiverSecondVar.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverSecondVar.SetLinkedDisplayControl(lbSecondVariable)

        ucrReceiverSecondOpt.SetParameter(New RParameter("factors", 2, bNewIncludeArgumentName:=False))
        ucrReceiverSecondOpt.bWithQuotes = False
        ucrReceiverSecondOpt.SetParameterIsString()
        ucrReceiverSecondOpt.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverSecondOpt.SetLinkedDisplayControl(lbSecondOpt)
        ucrReceiverSecondOpt.SetDataType("factor")

        ucrReceiverSecondFactor.SetParameter(New RParameter("second_factor", 3, bNewIncludeArgumentName:=False))
        ucrReceiverSecondFactor.bWithQuotes = False
        ucrReceiverSecondFactor.SetParameterIsString()
        ucrReceiverSecondFactor.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverSecondFactor.SetLinkedDisplayControl(lblSecondFactor)
        ucrReceiverSecondFactor.SetDataType("factor")

        ucrReceiverNumericVariable.SetParameter(New RParameter("columns_to_summarise", 4))
        ucrReceiverNumericVariable.SetDataType("numeric")
        ucrReceiverNumericVariable.SetParameterIsString()
        ucrReceiverNumericVariable.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverNumericVariable.SetLinkedDisplayControl(lblNumericVariable)

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 6))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.bUpdateRCodeFromControl = True

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 5))
        ucrChkDisplayMargins.SetText("Display Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")

        ucrInputMarginName.SetLinkedDisplayControl(lblMarginName)

        ucrPnlDescribe.AddRadioButton(rdoCustomize)
        ucrPnlDescribe.AddRadioButton(rdoSkim)
        ucrPnlDescribe.AddParameterValuesCondition(rdoCustomize, "checked", "customize")
        ucrPnlDescribe.AddParameterValuesCondition(rdoSkim, "checked", "skim")

        ucrChkDisplayAsPercentage.SetParameter(New RParameter("percentage_type", 1))
        ucrChkDisplayAsPercentage.SetText("As Percentages")
        ucrChkDisplayAsPercentage.SetValuesCheckedAndUnchecked(Chr(34) & "factors" & Chr(34), Chr(34) & "none" & Chr(34))
        ucrChkDisplayAsPercentage.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrReceiverPercentages, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrChkPercentageProportion, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverPercentages.SetParameter(New RParameter("perc_total_factors", 2))
        ucrReceiverPercentages.SetParameterIsString()
        ucrReceiverPercentages.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverPercentages.SetDataType("factor")
        ucrReceiverPercentages.SetLinkedDisplayControl(lblFactorsAsPercentage)

        ucrChkPercentageProportion.SetParameter(New RParameter("perc_decimal", 3))
        ucrChkPercentageProportion.SetText("Display as Decimal")
        ucrChkPercentageProportion.SetRDefault("FALSE")

        ucrNudSigFigs.SetParameter(New RParameter("signif_fig", 6))
        ucrNudSigFigs.SetMinMax(0, 22)
        ucrNudSigFigs.SetRDefault(2)

        ucrNudColumnFactors.SetMinMax(1, 2)

        ucrPnlDescribe.AddToLinkedControls({ucrReceiverSecondOpt, ucrReceiverSecondFactor}, {rdoSkim}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        clsGetDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetDataType.AddParameter("property", "data_type_label")

        clsGetSecondDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetSecondDataType.AddParameter("property", "data_type_label")
    End Sub

    Private Sub SetDefaults()
        clsFrequencyTables = New RFunction
        clsRAnova = New RFunction
        clsRCorrelation = New RFunction
        clsSummariesList = New RFunction
        clsRCustomSummary = New RFunction
        clsCombineFunction = New RFunction
        clsSkimrFunction = New RFunction
        clsGroupByPipeOperator = New ROperator
        clsGroupByFunction = New RFunction
        clsMmtableFunction = New RFunction
        clsHeaderLeftFunction = New RFunction
        clsHeaderTopFunction = New RFunction
        clsHeaderTopLeftSummaryVariableFunction = New RFunction
        clsHeaderLeftTopFuncion = New RFunction
        clsDummyFunction = New RFunction
        clsCombineFrequencyParameters = New RFunction
        clsSummaryMapFunction = New RFunction
        clsFactorVectorFunction = New RFunction
        clsMmtableMapFunction = New RFunction
        clsDataSummaryTildeOperator = New ROperator
        clsMmtableTildeOperator = New ROperator
        clsMapFrequencyPipeOperator = New ROperator
        clsMmtablePlusOperator = New ROperator


        ucrSelectorDescribeTwoVar.Reset()
        ucrReceiverFirstVars.SetMeAsReceiver()
        ucrInputMarginName.SetText("All")
        ucrNudColumnFactors.SetText("2")
        ucrInputMarginName.Visible = False

        clsCombineFrequencyParameters.SetRCommand("c")

        clsDataSummaryTildeOperator.SetOperation("~")
        clsDataSummaryTildeOperator.AddParameter("summary_table", clsRFunctionParameter:=clsFrequencyTables, iPosition:=1)

        clsMmtableTildeOperator.SetOperation("~")
        clsMmtableTildeOperator.AddParameter("mmtable", clsRFunctionParameter:=clsMmtableFunction, iPosition:=1)

        clsFactorVectorFunction.SetRCommand("c")
        clsFactorVectorFunction.SetAssignTo("multiple_receiver_cols")

        clsSummaryMapFunction.SetPackageName("purrr")
        clsSummaryMapFunction.SetRCommand("map")
        clsSummaryMapFunction.AddParameter(".x", clsRFunctionParameter:=clsFactorVectorFunction, iPosition:=0)
        clsSummaryMapFunction.AddParameter(".f", clsROperatorParameter:=clsDataSummaryTildeOperator, iPosition:=1)

        clsMmtableMapFunction.SetPackageName("purrr")
        clsMmtableMapFunction.SetRCommand("map")
        clsMmtableMapFunction.AddParameter(".x", ".", iPosition:=0)
        clsMmtableMapFunction.AddParameter(".f", clsROperatorParameter:=clsMmtablePlusOperator, iPosition:=1)


        clsMapFrequencyPipeOperator.SetOperation("%>%")
        clsMapFrequencyPipeOperator.AddParameter("map_summary_table", clsRFunctionParameter:=clsSummaryMapFunction, iPosition:=1)
        clsMapFrequencyPipeOperator.AddParameter("map_mmtable", clsRFunctionParameter:=clsMmtableMapFunction, iPosition:=2)

        clsHeaderLeftFunction.SetPackageName("mmtable2")
        clsHeaderLeftFunction.SetRCommand("header_top_left")

        clsHeaderTopFunction.SetPackageName("mmtable2")
        clsHeaderTopFunction.SetRCommand("header_left_top")

        clsHeaderTopLeftSummaryVariableFunction.SetPackageName("mmtable2")
        clsHeaderTopLeftSummaryVariableFunction.SetRCommand("header_top_left")
        clsHeaderTopLeftSummaryVariableFunction.AddParameter("variable", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)

        clsMmtableFunction.SetPackageName("mmtable2")
        clsMmtableFunction.SetRCommand("mmtable")
        clsMmtableFunction.AddParameter("data", ".x", iPosition:=0)
        clsMmtableFunction.AddParameter("cells", "value", iPosition:=1)

        clsDummyFunction.AddParameter("checked", "skim", iPosition:=0)

        clsMmtablePlusOperator.SetOperation("+")
        clsMmtablePlusOperator.AddParameter("mmtable2", clsRFunctionParameter:=clsMmtableFunction, iPosition:=0)
        clsMmtablePlusOperator.AddParameter("header_left", clsRFunctionParameter:=clsHeaderLeftFunction, iPosition:=2)
        clsMmtablePlusOperator.AddParameter("header_top", clsRFunctionParameter:=clsHeaderTopFunction, iPosition:=3)

        clsGroupByPipeOperator.SetOperation("%>%")
        clsGroupByPipeOperator.AddParameter("skim", clsRFunctionParameter:=clsSkimrFunction, iPosition:=2, bIncludeArgumentName:=False)

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsSkimrFunction.SetPackageName("skimr")
        clsSkimrFunction.SetRCommand("skim_without_charts")

        clsCombineFunction.SetRCommand("c")

        clsFrequencyTables.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsFrequencyTables.AddParameter("store_results", "FALSE", iPosition:=0)
        clsFrequencyTables.AddParameter("treat_columns_as_factor", "FALSE", iPosition:=1)
        clsFrequencyTables.AddParameter("summaries", "count_label", iPosition:=2)
        clsFrequencyTables.AddParameter("columns_to_summarise", ".x", iPosition:=3)
        clsFrequencyTables.SetAssignTo("frequency_table")

        clsRAnova.AddParameter("signif.stars", "FALSE", iPosition:=2)
        clsRAnova.AddParameter("sign_level", "FALSE", iPosition:=3)
        clsRAnova.AddParameter("means", "FALSE", iPosition:=4)

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_missing", Chr(34) & "summary_count_missing" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsSummariesList.AddParameter("summary_min", Chr(34) & "summary_min" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
        clsSummariesList.AddParameter("p25", Chr(34) & "p25" & Chr(34), bIncludeArgumentName:=False, iPosition:=2)
        clsSummariesList.AddParameter("summary_median", Chr(34) & "summary_median" & Chr(34), bIncludeArgumentName:=False, iPosition:=3)
        clsSummariesList.AddParameter("summary_mean", Chr(34) & "summary_mean" & Chr(34), bIncludeArgumentName:=False, iPosition:=4)
        clsSummariesList.AddParameter("p75", Chr(34) & "p75" & Chr(34), bIncludeArgumentName:=False, iPosition:=5)
        clsSummariesList.AddParameter("summary_max", Chr(34) & "summary_max" & Chr(34), bIncludeArgumentName:=False, iPosition:=6)

        clsRCustomSummary.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary")
        clsRCustomSummary.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList)

        clsRCustomSummary.AddParameter("store_results", "FALSE", iPosition:=4)
        clsRCustomSummary.AddParameter("drop", "TRUE", iPosition:=5)
        clsRCustomSummary.AddParameter("na.rm", "FALSE", iPosition:=6)
        clsRCustomSummary.AddParameter("return_output", "TRUE", iPosition:=7)

        clsRCorrelation.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$cor")

        clsRAnova.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables")

        ucrBase.clsRsyntax.SetBaseROperator(clsGroupByPipeOperator)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRAnova, New RParameter("y_col_name", 2), iAdditionalPairNo:=1)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsFrequencyTables, New RParameter("factors", 2), iAdditionalPairNo:=2)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRCorrelation, New RParameter("y_col_name", 2), iAdditionalPairNo:=3)

        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsRAnova, New RParameter("x_col_names", 1), iAdditionalPairNo:=1)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsRCorrelation, New RParameter("x_col_names", 1), iAdditionalPairNo:=2)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsSkimrFunction, New RParameter("col_names", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)

        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRAnova, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=1)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRCustomSummary, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=2)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsFrequencyTables, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=3)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsMapFrequencyPipeOperator, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=4)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsGroupByPipeOperator, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=5)

        ucrChkOmitMissing.SetRCode(clsRCustomSummary, bReset)
        ucrReceiverFirstVars.SetRCode(clsRCustomSummary, bReset)
        ucrReceiverSecondVar.SetRCode(clsRCustomSummary, bReset)
        ucrSelectorDescribeTwoVar.SetRCode(clsRCorrelation, bReset)
        ucrReceiverSecondOpt.SetRCode(clsGroupByFunction, bReset)
        ucrReceiverSecondFactor.SetRCode(clsGroupByFunction, bReset)
        ucrReceiverNumericVariable.SetRCode(clsFrequencyTables, bReset)
        ucrChkDisplayMargins.SetRCode(clsCombineFrequencyParameters, bReset)
        ucrChkDisplayAsPercentage.SetRCode(clsCombineFrequencyParameters, bReset)
        ucrReceiverPercentages.SetRCode(clsCombineFrequencyParameters, bReset)
        ucrChkPercentageProportion.SetRCode(clsCombineFrequencyParameters, bReset)
        ucrPnlDescribe.SetRCode(clsDummyFunction, bReset)
        ucrNudSigFigs.SetRCode(clsCombineFrequencyParameters, bReset)
        Results()
    End Sub

    Public Sub TestOKEnabled()
        If rdoCustomize.Checked Then
            If ((Not ucrReceiverSecondVar.IsEmpty()) AndAlso (Not ucrReceiverFirstVars.IsEmpty())) Then
                If ((strFirstVariablesType = "numeric" OrElse strFirstVariablesType = "integer") AndAlso (strSecondVariableType = "factor")) AndAlso clsSummariesList.clsParameters.Count = 0 Then
                    ucrBase.OKEnabled(False)
                Else
                    ucrBase.OKEnabled(True)
                End If
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If ucrReceiverFirstVars.IsEmpty Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If

        End If
    End Sub

    Private Sub ucrBaseDescribeTwoVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.SetRFunction(clsSummariesList, clsRCustomSummary, clsCombineFunction, ucrSelectorDescribeTwoVar, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs)
        sdgDescribeDisplay.SetRFunction(clsFrequencyTables, clsRAnova, bResetSubdialog)
        bResetSubdialog = False
        sdgDescribeDisplay.ShowDialog()
        TestOKEnabled()
    End Sub

    Public Sub Results()
        Dim lstFirstItemTypes As List(Of String)
        If rdoCustomize.Checked Then
            grpSummaries.Visible = True
            If Not ucrReceiverFirstVars.IsEmpty() Then
                lstFirstItemTypes = ucrReceiverFirstVars.GetCurrentItemTypes(True, bIsCategoricalNumeric:=True)
                If lstFirstItemTypes.Count = 1 AndAlso lstFirstItemTypes.Contains("logical") Then
                    lstFirstItemTypes(0) = "categorical"
                Else
                    lstFirstItemTypes.RemoveAll(Function(x) x.Contains("logical"))
                End If
                If (lstFirstItemTypes.Count > 0) Then
                    strFirstVariablesType = lstFirstItemTypes(0)
                Else
                    strFirstVariablesType = ""
                    lblFirstType.Text = "________"
                    lblFirstType.ForeColor = SystemColors.ControlText
                End If
                lblFirstType.Text = strFirstVariablesType
                lblFirstType.ForeColor = SystemColors.Highlight
            Else
                strFirstVariablesType = ""
                lblFirstType.Text = "________"
                lblFirstType.ForeColor = SystemColors.ControlText
            End If
            If Not ucrReceiverSecondVar.IsEmpty() Then
                strSecondVariableType = ucrReceiverSecondVar.strCurrDataType
                If strSecondVariableType.Contains("factor") OrElse strSecondVariableType.Contains("character") OrElse strSecondVariableType.Contains("logical") Then
                    strSecondVariableType = "categorical"
                Else
                    strSecondVariableType = "numeric"
                End If
                lblSecondType.Text = strSecondVariableType
                lblSecondType.ForeColor = SystemColors.Highlight
            Else
                strSecondVariableType = ""
                lblSecondType.Text = "________"
                lblSecondType.ForeColor = SystemColors.ControlText
            End If

            If strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric" Then
                grpOptions.Visible = True
                cmdSummaries.Visible = False
                ucrChkOmitMissing.Visible = True
                ucrBase.clsRsyntax.SetBaseRFunction(clsRCorrelation)
                lblSummaryName.Text = "Correlations"
                lblSummaryName.ForeColor = SystemColors.Highlight
            ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" Then
                grpOptions.Visible = False
                ucrBase.clsRsyntax.SetBaseRFunction(clsRAnova)
                lblSummaryName.Text = "ANOVA tables"
                lblSummaryName.ForeColor = SystemColors.Highlight
            ElseIf strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                grpOptions.Visible = True
                cmdSummaries.Visible = True
                ucrChkOmitMissing.Visible = True
                ucrBase.clsRsyntax.SetBaseRFunction(clsRCustomSummary)
                ucrReceiverFirstVars.SetParameterIsString()
                lblSummaryName.Text = "Numerical summaries"
                lblSummaryName.ForeColor = SystemColors.Highlight
            ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" Then
                grpOptions.Visible = False
                ucrBase.clsRsyntax.SetBaseROperator(clsMmtablePlusOperator)
                lblSummaryName.Text = "Frequency tables"
                lblSummaryName.ForeColor = SystemColors.Highlight
            Else
                grpOptions.Visible = False
                lblSummaryName.Text = "__________"
                lblSummaryName.ForeColor = SystemColors.ControlText
            End If
        Else
            grpOptions.Visible = False
            grpSummaries.Visible = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstVars.ControlContentsChanged, ucrReceiverSecondVar.ControlContentsChanged, ucrPnlDescribe.ControlContentsChanged
        If Not ucrReceiverFirstVars.IsEmpty AndAlso ucrChangedControl Is ucrReceiverFirstVars Then
            Dim iPosition As Integer = 0
            clsFactorVectorFunction.ClearParameters()
            For Each strColumn In ucrReceiverFirstVars.GetVariableNamesList()
                clsFactorVectorFunction.AddParameter(strColumn, strColumn, bIncludeArgumentName:=False, iPosition:=iPosition)
            Next
        End If

        If rdoCustomize.Checked AndAlso ucrChangedControl Is ucrReceiverSecondVar Then
            If strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" Then
                ucrReceiverNumericVariable.SetMeAsReceiver()
            End If
        End If

        SwapMmtableHeaderFunctions()
        ChangeLocations()
        Results()
        TestOKEnabled()
        EnableDisableFrequencyControls()
        AddRemoveFrequencyParameters()
    End Sub

    Private Sub ucrChkOmitMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMissing.ControlValueChanged
        If ucrChkOmitMissing.Checked Then
            clsRCorrelation.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34), iPosition:=2)
        Else
            clsRCorrelation.RemoveParameterByName("use")
        End If
    End Sub

    Private Sub ucrPnlDescribe_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDescribe.ControlValueChanged
        ucrReceiverFirstVars.Clear()
        ucrReceiverFirstVars.SetMeAsReceiver()
        If rdoSkim.Checked Then
            clsDummyFunction.AddParameter("checked", "skim", iPosition:=0)
            ucrReceiverFirstVars.SetSingleTypeStatus(False)
            ucrBase.clsRsyntax.SetBaseROperator(clsGroupByPipeOperator)
        Else
            clsDummyFunction.AddParameter("checked", "customize", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsRCustomSummary)
            ucrReceiverFirstVars.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)
        End If
        ChangeLocations()
    End Sub

    Private Sub ChangeLocations()
        If rdoSkim.Checked Then
            ucrBase.Location = New Point(iUcrBaseXLocation, 328)
            Me.Size = New System.Drawing.Point(iDialogueXsize, 425)
        Else
            If strFirstVariablesType = "categorical" AndAlso
                strSecondVariableType = "categorical" AndAlso
                ucrReceiverNumericVariable.IsEmpty Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 435)
                Me.Size = New System.Drawing.Point(iDialogueXsize, 530)
            Else
                ucrBase.Location = New Point(iUcrBaseXLocation, 328)
                Me.Size = New System.Drawing.Point(iDialogueXsize, 425)
            End If
        End If
    End Sub

    Private Sub ucrReceiverSecondOpt_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondOpt.ControlValueChanged
        If ucrReceiverSecondOpt.IsEmpty Then
            clsGroupByPipeOperator.RemoveParameterByName("group")
        Else
            clsGroupByPipeOperator.AddParameter("group", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub EnableDisableFrequencyControls()
        If rdoCustomize.Checked Then
            If strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" Then
                ucrReceiverNumericVariable.Visible = True
                If ucrReceiverNumericVariable.IsEmpty Then
                    grpDisplay.Visible = True
                    grpFrequency.Visible = True
                    ucrChkDisplayMargins.Visible = True
                    If ucrChkDisplayMargins.Checked Then
                        ucrInputMarginName.Visible = True
                    Else
                        ucrInputMarginName.Visible = False
                    End If
                Else
                    DisableFrequencyControls()
                End If
            Else
                ucrReceiverFirstVars.SetMeAsReceiver()
                ucrReceiverNumericVariable.Visible = False
                DisableFrequencyControls()
            End If
        Else
            ucrReceiverNumericVariable.Visible = False
            DisableFrequencyControls()
        End If
    End Sub

    Private Sub DisableFrequencyControls()
        grpDisplay.Visible = False
        grpFrequency.Visible = False
        ucrChkDisplayMargins.Visible = False
        ucrInputMarginName.Visible = False
    End Sub

    Private Sub SwapMmtableHeaderFunctions()
        If Not ucrReceiverFirstVars.IsEmpty Then
            If ucrNudColumnFactors.GetText = 1 Then
                clsHeaderLeftFunction.AddParameter("variable", ucrReceiverFirstVars.GetVariableNamesList()(0), iPosition:=0)
                clsHeaderTopFunction.AddParameter("variable", ucrReceiverSecondVar.GetVariableNames(False), iPosition:=0)
            ElseIf ucrNudColumnFactors.GetText = 2 Then
                clsHeaderLeftFunction.AddParameter("variable", ucrReceiverSecondVar.GetVariableNames(False), iPosition:=0)
                clsHeaderTopFunction.AddParameter("variable", ucrReceiverFirstVars.GetVariableNamesList()(0), iPosition:=0)
            End If
        End If
    End Sub

    Private Sub AddRemoveFrequencyParameters()
        If strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" Then
            For Each strParameter In lstFrequencyParameters
                clsFrequencyTables.RemoveParameterByName(strParameter)
            Next
            If ucrReceiverNumericVariable.IsEmpty Then
                For Each clsParameter In clsCombineFrequencyParameters.clsParameters
                    clsFrequencyTables.AddParameter(clsParameter)
                Next
            End If
        End If
    End Sub

    Private Sub ucrReceiverNumericVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverNumericVariable.ControlValueChanged
        If Not ucrReceiverNumericVariable.IsEmpty Then
            clsMmtablePlusOperator.AddParameter("summary_variable", clsRFunctionParameter:=clsHeaderTopLeftSummaryVariableFunction, iPosition:=1)
        Else
            clsMmtablePlusOperator.RemoveParameterByName("summary_variable")
        End If
        EnableDisableFrequencyControls()
        ChangeLocations()
        AddRemoveFrequencyParameters()
    End Sub

    Private Sub Frequencies_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPercentageProportion.ControlValueChanged,
        ucrChkDisplayAsPercentage.ControlValueChanged, ucrNudSigFigs.ControlValueChanged, ucrChkDisplayMargins.ControlValueChanged,
        ucrReceiverPercentages.ControlValueChanged, ucrInputMarginName.ControlValueChanged
        If ucrChkDisplayAsPercentage.Checked Then
            ucrReceiverPercentages.SetMeAsReceiver()
        Else
            ucrReceiverFirstVars.SetMeAsReceiver()
        End If
        If ucrChkDisplayMargins.Checked Then
            ucrInputMarginName.Visible = True
            clsCombineFrequencyParameters.AddParameter("margin_name", Chr(34) & ucrInputMarginName.GetText & Chr(34), iPosition:=6)
        Else
            ucrInputMarginName.Visible = False
            clsCombineFrequencyParameters.RemoveParameterByName("margin_name")
        End If
        AddRemoveFrequencyParameters()
    End Sub

    Private Sub ucrNudColumnFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudColumnFactors.ControlValueChanged
        SwapMmtableHeaderFunctions()
    End Sub
End Class