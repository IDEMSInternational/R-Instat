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
Public Class dlgSummaryTables
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsSummariesList As New RFunction
    Private bResetSubdialog As Boolean = False
    Private bResetFormatSubdialog As Boolean = False
    Private clsSummaryDefaultFunction, clsArrangeFunction, clsFrequencyDefaultFunction As New RFunction
    Private bRCodeSet As Boolean = True
    Private clsPivotWiderFunction As New RFunction
    Private ClsTabSpannerDelimFunction As New RFunction
    Private iUcrBaseXLocation, iDialogueXsize As Integer

    Private clsDummyFunction As New RFunction

    Private clsSummaryOperator, clsFrequencyOperator, clsJoiningPipeOperator, clsSpannerOperator As New ROperator

    Private Sub dlgNewSummaryTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        DialogueSize()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 426
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        iUcrBaseXLocation = ucrBase.Location.X
        iDialogueXsize = Me.Height

        'summary_name = NA - 8
        ucrSelectorSummaryTables.SetParameter(New RParameter("data_name", 0))
        ucrSelectorSummaryTables.SetParameterIsString()

        ucrReceiverSummaryCols.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverSummaryCols.Selector = ucrSelectorSummaryTables
        ucrReceiverSummaryCols.SetDataType("numeric")
        ucrReceiverSummaryCols.SetParameterIsString()
        ucrReceiverSummaryCols.SetLinkedDisplayControl(lblVariables)

        ucrReceiverFactors.SetParameter(New RParameter("factors", 2))
        ucrReceiverFactors.SetParameterIsString()
        ucrReceiverFactors.Selector = ucrSelectorSummaryTables
        ucrReceiverFactors.SetDataType("factor")

        ucrReceiverWeights.SetParameter(New RParameter("weights", 3))
        ucrReceiverWeights.SetParameterIsString()
        ucrReceiverWeights.Selector = ucrSelectorSummaryTables
        ucrReceiverWeights.SetDataType("numeric")

        ucrReceiverPercentages.SetParameter(New RParameter("perc_total_factors", 1))
        ucrReceiverPercentages.SetParameterIsString()
        ucrReceiverPercentages.Selector = ucrSelectorSummaryTables
        ucrReceiverPercentages.SetDataType("factor") ' TODO data this accepts must be in the other receiver too
        ucrReceiverPercentages.SetLinkedDisplayControl(lblFactorsAsPercentage)

        ucrChkStoreResults.SetText("Store Summaries")
        ucrChkStoreResults.SetParameter(New RParameter("store_table", 4))
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("FALSE")

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 5))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")
        ucrChkOmitMissing.SetLinkedDisplayControl(cmdMissingOptions)

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 6))
        ucrChkDisplayMargins.SetText("Display Outer Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")
        ucrChkDisplayMargins.AddToLinkedControls({ucrInputMarginName}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True,
                                                 bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="All")
        ucrChkDisplayMargins.AddToLinkedControls({ucrPnlMargin}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True,
                                                 bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoOuter)

        ucrChkFrequencyDisplayMargins.SetParameter(New RParameter("include_margins", 3))
        ucrChkFrequencyDisplayMargins.SetText("Display Margins")
        ucrChkFrequencyDisplayMargins.SetRDefault("FALSE")
        ucrChkFrequencyDisplayMargins.AddToLinkedControls(ucrInputFrequencyMarginName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True,
                                                  bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="All", bNewLinkedUpdateFunction:=True)

        ucrInputFrequencyMarginName.SetParameter(New RParameter("margin_name", iNewPosition:=5))
        ucrInputFrequencyMarginName.SetLinkedDisplayControl(lblFrequencyMarginName)

        ucrPnlMargin.SetParameter(New RParameter("margins", iNewPosition:=7))
        ucrPnlMargin.AddRadioButton(rdoOuter, Chr(34) & "outer" & Chr(34))
        ucrPnlMargin.AddRadioButton(rdoSummary, Chr(34) & "summary" & Chr(34))
        ucrPnlMargin.AddRadioButton(rdoBoth, "c(""outer"",""summary"")")
        ucrPnlMargin.SetLinkedDisplayControl(grpMargin)

        ucrInputMarginName.SetParameter(New RParameter("margin_name", iNewPosition:=5))
        ucrInputMarginName.SetLinkedDisplayControl(lblMarginName)

        ucrChkDropLevels.SetParameter(New RParameter("drop", 9))
        ucrChkDropLevels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDropLevels.SetText("Drop Unused Levels")

        ucrNudSigFigs.SetParameter(New RParameter("signif_fig", 9))
        ucrNudSigFigs.SetMinMax(0, 22)
        ucrNudSigFigs.SetRDefault(2)

        ucrNudColFactors.SetLinkedDisplayControl(lblColumnFactors)
        ucrNudPositionSum.SetLinkedDisplayControl(lblPositionSum)
        ucrNudPositionVar.SetLinkedDisplayControl(lblPositionVar)
        UcrNudColumnSumFactors.SetLinkedDisplayControl(lblColumnSummariesFactors)

        ucrChkWeight.SetText("Weights")
        ucrChkWeight.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeight.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'Not yet implemented
        ucrChkWeight.Visible = False

        ucrPnlSummaryFrequencyTables.AddRadioButton(rdoSummaryTable)
        ucrPnlSummaryFrequencyTables.AddRadioButton(rdoFrequencyTable)
        ucrPnlSummaryFrequencyTables.AddRadioButton(rdoMultipleResponse)
        ucrPnlSummaryFrequencyTables.AddParameterValuesCondition(rdoSummaryTable, "rdo_checked", "rdoSummary")
        ucrPnlSummaryFrequencyTables.AddParameterValuesCondition(rdoFrequencyTable, "rdo_checked", "rdoFrequency")
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrReceiverSummaryCols}, {rdoSummaryTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrReorderSummary}, {rdoSummaryTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrChkDisplayAsPercentage}, {rdoFrequencyTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrChkDisplayMargins}, {rdoSummaryTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrChkFrequencyDisplayMargins, ucrNudColFactors}, {rdoFrequencyTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrChkOmitMissing}, {rdoSummaryTable}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkDisplayAsPercentage.SetParameter(New RParameter("percentage_type", 2))
        ucrChkDisplayAsPercentage.SetText("As Percentages")
        ucrChkDisplayAsPercentage.SetValuesCheckedAndUnchecked(Chr(34) & "factors" & Chr(34), Chr(34) & "none" & Chr(34))
        ucrChkDisplayAsPercentage.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrReceiverPercentages, {True}, bNewLinkedHideIfParameterMissing:=True,
                                                      bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True)
        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrChkPercentageProportion, {True}, bNewLinkedAddRemoveParameter:=True,
                                                      bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True)
        ucrChkDisplayAsPercentage.SetLinkedDisplayControl(grpPercentages)

        ucrChkPercentageProportion.SetParameter(New RParameter("perc_decimal", 3))
        ucrChkPercentageProportion.SetText("Display as Decimal")
        ucrChkPercentageProportion.SetRDefault("FALSE")

        ucrSaveTable.SetPrefix("summary_table")
        ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
        ucrSaveTable.SetDataFrameSelector(ucrSelectorSummaryTables.ucrAvailableDataFrames)
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetCheckBoxText("Store Table")
        ucrSaveTable.SetAssignToIfUncheckedValue("last_table")

        ucrReorderSummary.bDataIsSummaries = True
        DialogueSize()
    End Sub

    Private Sub SetDefaults()
        clsSummaryDefaultFunction = New RFunction
        clsFrequencyDefaultFunction = New RFunction
        clsSummariesList = New RFunction
        clsDummyFunction = New RFunction
        clsPivotWiderFunction = New RFunction
        ClsTabSpannerDelimFunction = New RFunction
        clsArrangeFunction = New RFunction

        clsJoiningPipeOperator = New ROperator
        clsSummaryOperator = New ROperator
        clsFrequencyOperator = New ROperator
        clsSpannerOperator = New ROperator

        ucrReceiverFactors.SetMeAsReceiver()
        ucrSelectorSummaryTables.Reset()
        ucrSaveTable.Reset()

        ucrBase.clsRsyntax.GetBeforeCodes().Clear()

        clsDummyFunction.AddParameter("theme", "select", iPosition:=11)
        clsDummyFunction.AddParameter("rdo_checked", "rdoFrequency", iPosition:=1)
        clsDummyFunction.AddParameter("factor_cols", "FactorVar", iPosition:=2)

        clsPivotWiderFunction.SetRCommand("pivot_wider")
        clsPivotWiderFunction.AddParameter("values_from", "value", iPosition:=1)
        clsPivotWiderFunction.AddParameter("names_sort", "TRUE", iPosition:=2)

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_mean", Chr(34) & "summary_mean" & Chr(34), bIncludeArgumentName:=False) ' TODO decide which default(s) to use?

        clsSummaryDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsSummaryDefaultFunction.AddParameter("treat_columns_as_factor", "TRUE", iPosition:=8)
        clsSummaryDefaultFunction.AddParameter("drop", "TRUE", iPosition:=9)
        clsSummaryDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList, iPosition:=12)
        clsSummaryDefaultFunction.SetAssignToObject("summary_table")

        clsFrequencyDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsFrequencyDefaultFunction.AddParameter("store_results", "FALSE", iPosition:=8)
        clsFrequencyDefaultFunction.AddParameter("treat_columns_as_factor", "FALSE", iPosition:=10)
        clsFrequencyDefaultFunction.AddParameter("drop", "TRUE", iPosition:=9)
        clsFrequencyDefaultFunction.AddParameter("summaries", "count_label", iPosition:=11)
        clsFrequencyDefaultFunction.SetAssignToObject("frequency_table")

        ' Gt function
        Dim clsGtFunction As New RFunction
        clsGtFunction.SetPackageName("gt")
        clsGtFunction.SetRCommand("gt")

        ClsTabSpannerDelimFunction.SetPackageName("gt")
        ClsTabSpannerDelimFunction.SetRCommand("tab_spanner_delim")
        ClsTabSpannerDelimFunction.AddParameter("delim", Chr(34) & "_" & Chr(34))

        clsArrangeFunction.SetRCommand("arrange")

        clsSummaryOperator.SetOperation("%>%")
        clsSummaryOperator.bBrackets = False
        clsSummaryOperator.AddParameter("tableFun", clsRFunctionParameter:=clsSummaryDefaultFunction, iPosition:=0)
        clsSummaryOperator.AddParameter("right", clsROperatorParameter:=clsSpannerOperator, iPosition:=3)

        clsSpannerOperator.SetOperation("%>%")
        clsSpannerOperator.AddParameter("gt", clsRFunctionParameter:=clsGtFunction.Clone, iPosition:=0)
        clsSpannerOperator.AddParameter("tableFun", clsRFunctionParameter:=ClsTabSpannerDelimFunction, iPosition:=2)

        clsFrequencyOperator.SetOperation("%>%")
        clsFrequencyOperator.bBrackets = False
        clsFrequencyOperator.AddParameter("tableFun", clsRFunctionParameter:=clsFrequencyDefaultFunction, iPosition:=0)
        clsFrequencyOperator.AddParameter("right", clsROperatorParameter:=clsSpannerOperator, iPosition:=3)

        clsJoiningPipeOperator.SetOperation("%>%")
        clsJoiningPipeOperator.AddParameter("mutable", clsROperatorParameter:=clsSummaryOperator, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)

        clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorSummaryTables.strCurrentDataFrame,
                                                  strObjectName:="last_table")

        bResetSubdialog = True
        bResetFormatSubdialog = True
        TestOKEnabled()
        SetDefaultValues()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        ucrSelectorSummaryTables.AddAdditionalCodeParameterPair(clsFrequencyDefaultFunction, ucrSelectorSummaryTables.GetParameter, iAdditionalPairNo:=1)
        ucrChkStoreResults.AddAdditionalCodeParameterPair(clsFrequencyDefaultFunction, ucrChkStoreResults.GetParameter, iAdditionalPairNo:=1)
        ucrNudSigFigs.AddAdditionalCodeParameterPair(clsFrequencyDefaultFunction, ucrNudSigFigs.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverFactors.AddAdditionalCodeParameterPair(clsFrequencyDefaultFunction, ucrReceiverFactors.GetParameter, iAdditionalPairNo:=1)
        ucrChkDropLevels.AddAdditionalCodeParameterPair(clsFrequencyDefaultFunction, ucrChkDropLevels.GetParameter, iAdditionalPairNo:=1)

        ucrSelectorSummaryTables.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkDisplayMargins.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkFrequencyDisplayMargins.SetRCode(clsFrequencyDefaultFunction, bReset)
        ucrNudSigFigs.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrReceiverWeights.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkDropLevels.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkWeight.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkStoreResults.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkDisplayAsPercentage.SetRCode(clsFrequencyDefaultFunction, bReset)
        ucrSaveTable.SetRCode(clsJoiningPipeOperator, bReset)
        If bReset Then
            ucrReceiverSummaryCols.SetRCode(clsSummaryDefaultFunction, bReset)
            ucrReceiverFactors.SetRCode(clsSummaryDefaultFunction, bReset)
            ucrNudColFactors.SetRCode(clsFrequencyDefaultFunction, bReset)
            ucrPnlSummaryFrequencyTables.SetRCode(clsDummyFunction, bReset)
            UcrNudColumnSumFactors.SetRCode(clsSummaryDefaultFunction, bReset)
            ucrNudPositionSum.SetRCode(clsSummaryDefaultFunction, bReset)
            ucrNudPositionVar.SetRCode(clsSummaryDefaultFunction, bReset)
        End If
        bRCodeSet = True
        FillListView()
        SetDefaultValues()
        SetColFactorDefaults()
    End Sub

    Private Sub TestOKEnabled()
        If rdoSummaryTable.Checked Then
            If ucrSaveTable.IsComplete AndAlso ucrNudSigFigs.GetText <> "" AndAlso (Not ucrChkWeight.Checked OrElse
                (ucrChkWeight.Checked AndAlso Not ucrReceiverWeights.IsEmpty)) AndAlso
                Not ucrReceiverSummaryCols.IsEmpty AndAlso Not clsSummariesList.clsParameters.Count = 0 Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If Not ucrReceiverFactors.IsEmpty AndAlso ucrSaveTable.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If

    End Sub
    Private Sub btnMoreOptions_Click(sender As Object, e As EventArgs) Handles btnMoreOptions.Click
        sdgTableOptions.Setup(ucrSelectorSummaryTables.strCurrentDataFrame, clsJoiningPipeOperator)
        sdgTableOptions.ShowDialog(Me)

    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        Dim clsConcFunction As New RFunction
        clsConcFunction.SetRCommand("c")
        sdgSummaries.SetRFunction(clsSummariesList, clsSummaryDefaultFunction, clsConcFunction, ucrSelectorSummaryTables, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.bEnable2VariableTab = False
        sdgSummaries.ShowDialog()
        sdgSummaries.bEnable2VariableTab = True
        FillListView()
        SetSummariesDefaults()
        SetVariableDefaults()
        TestOKEnabled()
    End Sub

    Private Sub cmdFormatTable_Click(sender As Object, e As EventArgs) Handles cmdFormatTable.Click

        Dim clsROperator As ROperator
        If rdoFrequencyTable.Checked Then
            clsROperator = clsFrequencyOperator
        ElseIf rdoSummaryTable.Checked Then
            clsROperator = clsSummaryOperator
        Else
            Exit Sub
        End If

        'sdgTableOptions.Setup(clsROperator)
        sdgTableOptions.ShowDialog(Me)

    End Sub

    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeight.ControlValueChanged
        If ucrChkWeight.Checked Then
            ucrReceiverWeights.SetMeAsReceiver()
        Else
            If ucrReceiverFactors.IsEmpty Then
                ucrReceiverFactors.SetMeAsReceiver()
            ElseIf ucrReceiverSummaryCols.IsEmpty Then
                ucrReceiverSummaryCols.SetMeAsReceiver()
            Else
                ucrReceiverFactors.SetMeAsReceiver()
            End If
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlContentsChanged, ucrSaveTable.ControlContentsChanged,
        ucrChkWeight.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrReceiverSummaryCols.ControlContentsChanged,
        ucrPnlSummaryFrequencyTables.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub Display_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudColFactors.ControlValueChanged, UcrNudColumnSumFactors.ControlValueChanged,
        ucrReceiverFactors.ControlValueChanged, ucrNudPositionSum.ControlValueChanged, ucrNudPositionVar.ControlValueChanged, ucrReceiverSummaryCols.ControlValueChanged

        SetDefaultValues()
        SetColFactorDefaults()
        SettingParameters()
        AddPivotWiderVariables()
    End Sub

    Private Sub ucrPnlSummaryFrequencyTables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSummaryFrequencyTables.ControlValueChanged
        cmdSummaries.Visible = rdoSummaryTable.Checked
        cmdFormatTable.Location = New Point(286, If(rdoSummaryTable.Checked, 464, 273))

        DialogueSize()
        SettingParameters()
        SetDefaultValues()
        SetVariableDefaults()
        SetSummariesDefaults()
        SetColFactorDefaults()
        AddPivotWiderVariables()
    End Sub

    Private Sub SettingParameters()
        If rdoFrequencyTable.Checked Then
            grpDisplay.Visible = False
            clsJoiningPipeOperator.AddParameter("mutable", clsROperatorParameter:=clsFrequencyOperator, iPosition:=0)
            ucrSaveTable.SetPrefix("frequency_table")
        Else
            grpDisplay.Visible = True
            clsJoiningPipeOperator.AddParameter("mutable", clsROperatorParameter:=clsSummaryOperator, iPosition:=0)
            ucrSaveTable.SetPrefix("summary_table")

        End If
        If bRCodeSet Then
            If rdoFrequencyTable.Checked Then
                If ucrNudColFactors.Value = 0 Then
                    clsFrequencyOperator.RemoveParameterByName("col_factor")
                Else
                    clsFrequencyOperator.AddParameter("col_factor", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
                End If
            Else
                If UcrNudColumnSumFactors.Value = 0 Then
                    clsSummaryOperator.RemoveParameterByName("col_factor")
                Else
                    clsSummaryOperator.AddParameter("col_factor", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
                End If
            End If
        End If
        AddPivotWiderVariables()
    End Sub

    Private Sub FillListView()
        If clsSummariesList.clsParameters.Count > 0 Then
            ucrReorderSummary.lstAvailableData.Clear()
            ucrReorderSummary.lstAvailableData.Columns.Add("Summaries")
            ucrReorderSummary.lstAvailableData.Columns(0).Width = -2
            For i = 0 To clsSummariesList.clsParameters.Count - 1
                clsSummariesList.clsParameters(i).Position = i
                ucrReorderSummary.lstAvailableData.Items.Add(clsSummariesList.clsParameters(i).strArgumentName)
            Next
        Else
            ucrReorderSummary.lstAvailableData.Items.Clear()
        End If
    End Sub

    Private Sub ucrReorderSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReorderSummary.ControlValueChanged
        Dim lstOrderedSummaries As New List(Of RParameter)
        Dim iPosition As Integer = 0
        For i = 0 To ucrReorderSummary.lstAvailableData.Items.Count - 1
            lstOrderedSummaries.Add(clsSummariesList.GetParameter(ucrReorderSummary.lstAvailableData.Items(i).Text))
        Next

        clsSummariesList.ClearParameters()
        'Changing the parameter positions
        For Each clsParameter In lstOrderedSummaries
            clsParameter.Position = iPosition
            clsSummariesList.AddParameter(clsParameter)
            iPosition += 1
        Next
        SetSummariesDefaults()
        SetColFactorDefaults()
        SetVariableDefaults()
    End Sub

    Private Sub ucrChkDisplayAsPercentage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayAsPercentage.ControlValueChanged
        If ucrChkDisplayAsPercentage.Checked Then
            ucrReceiverPercentages.SetMeAsReceiver()
        Else
            ucrReceiverFactors.SetMeAsReceiver()
        End If
        DialogueSize()
    End Sub

    Private Sub DialogueSize()
        If rdoFrequencyTable.Checked Then
            Me.Size = New Size(505, iDialogueXsize * 0.6)
            Me.ucrNudSigFigs.Location = New Point(119, 309)
            Me.lblSigFigs.Location = New Point(7, 312)
            Me.ucrSaveTable.Location = New Point(10, 360)
            Me.ucrBase.Location = New Point(iUcrBaseXLocation, 390)
        Else
            Me.Size = New Size(505, iDialogueXsize)
            Me.ucrNudSigFigs.Location = New Point(119, 376)
            Me.lblSigFigs.Location = New Point(7, 379)
            Me.ucrSaveTable.Location = New Point(10, 520)
            Me.ucrBase.Location = New Point(iUcrBaseXLocation, 544)
        End If
    End Sub

    Private Sub AddPivotWiderVariables()
        If rdoFrequencyTable.Checked Then
            ' Get the number of variables to use from ucrNudColFactors
            Dim numVars As Integer = ucrNudColFactors.Value

            ' Get the list of selected variable names from ucrReceiverFactors
            Dim varNames As List(Of String) = ucrReceiverFactors.GetVariableNamesAsList()

            ' Create a new list to store the selected variables for names_from
            Dim selectedVars As New List(Of String)

            ' Loop through the ucrReceiverFactors and get only the first numVars items
            For i As Integer = varNames.Count - 1 To Math.Max(varNames.Count - numVars, 0) Step -1
                selectedVars.Add(varNames(i))  ' Add the variable name to selectedVars
            Next

            ' Create a comma-separated string from the selected variables for names_from
            Dim varsString As String = "c(" & String.Join(",", selectedVars) & ")"

            ' Pass the selected variables to the clsPivotWiderFunction's names_from parameter
            clsPivotWiderFunction.AddParameter("names_from", varsString, iPosition:=0)

            ' Check if all variables are added to names_from
            If selectedVars.Count = varNames.Count Then
                ' If all variables are added to names_from, remove the arrange parameter
                clsFrequencyOperator.RemoveParameterByName("arrange")
            Else
                clsFrequencyOperator.AddParameter("arrange", clsRFunctionParameter:=clsArrangeFunction, iPosition:=2)
            End If

            ' Get the remaining variables that were not added to names_from
            Dim remainingVars As New List(Of String)

            For i As Integer = 0 To varNames.Count - numVars - 1
                remainingVars.Add(varNames(i))  ' Add the remaining variables to arrange
            Next

            ' Create a comma-separated string for the remaining variables
            Dim arrangeString As String = String.Join(",", remainingVars)

            ' Pass the remaining variables to the arrange parameter in clsArrangeFunction
            clsArrangeFunction.AddParameter("arrange", arrangeString, iPosition:=0, bIncludeArgumentName:=False)


        Else
            ' Step 1: Define the number of items to add based on UcrNudColumnSumFactors
            Dim numSumm As Integer = UcrNudColumnSumFactors.Value

            ' Step 2: Get the list of variables in ucrReceiverFactors
            Dim varNames As List(Of String) = ucrReceiverFactors.GetVariableNamesAsList()

            ' Step 3: Set up local variables to represent the adjusted positions without changing control values
            Dim positionVar As Integer = ucrNudPositionVar.Value
            Dim positionSum As Integer = ucrNudPositionSum.Value

            ' Step 4: Adjust positions if ucrNudPositionVar equals ucrNudPositionSum
            If positionVar = positionSum Then
                ' If both are at their maximum values, position "variable" one step lower than positionVar
                If positionVar = ucrNudPositionVar.Maximum Then
                    positionVar = Math.Max(1, positionVar - 1)
                Else
                    ' If not at maximum, position "summary" one step higher than positionSum
                    positionSum = Math.Min(ucrNudPositionSum.Maximum, positionSum + 1)
                End If
            End If

            ' Step 5: Add "variable" if condition is met and place it at adjusted positionVar
            If ucrReceiverSummaryCols.Count > 1 AndAlso numSumm > 0 Then
                Dim variableIndex As Integer = Math.Max(0, Math.Min(positionVar - 1, varNames.Count))
                If variableIndex < varNames.Count Then
                    varNames.Insert(variableIndex, "variable")
                Else
                    varNames.Add("variable")
                End If
            End If

            ' Step 6: Add "summary" if condition is met and place it at adjusted positionSum
            If ucrReorderSummary.Count > 1 AndAlso numSumm >= 1 Then
                Dim summaryIndex As Integer = Math.Max(0, Math.Min(positionSum - 1, varNames.Count))
                If summaryIndex < varNames.Count Then
                    varNames.Insert(summaryIndex, "summary")
                Else
                    varNames.Add("summary")
                End If
            End If

            ' Step 7: Trim the list to include only the highest-positioned items, up to numSumm
            Dim namesFromList As New List(Of String)
            For i As Integer = varNames.Count - 1 To Math.Max(varNames.Count - numSumm, 0) Step -1
                namesFromList.Add(varNames(i))
            Next

            ' Convert namesFromList to a comma-separated string for names_from parameter
            Dim varsSummary As String = "c(" & String.Join(",", namesFromList) & ")"
            clsPivotWiderFunction.AddParameter("names_from", varsSummary, iPosition:=0)

            ' Step 8: Identify remaining variables that were not added to names_from
            Dim remainingVars As List(Of String) = varNames.Except(namesFromList).ToList()

            ' Check if all variables are added to names_from
            If remainingVars.Count = 0 Then
                ' If all variables are added to names_from, remove the arrange parameter
                clsSummaryOperator.RemoveParameterByName("arrange")
            Else
                ' Convert remaining variables to a comma-separated string for arrange parameter
                Dim arrangeVars As String = String.Join(",", remainingVars)
                clsArrangeFunction.AddParameter("arrange", arrangeVars, iPosition:=0)
                clsSummaryOperator.AddParameter("arrange", clsRFunctionParameter:=clsArrangeFunction, iPosition:=2)
            End If

        End If
    End Sub

    Private Sub ucrReceiverFactors_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFactors.SelectionChanged, ucrReceiverSummaryCols.SelectionChanged, ucrReorderSummary.SelectedIndexChanged
        SetDefaultValues()
        SetSummariesDefaults()
        SetVariableDefaults()
        SetColFactorDefaults()
    End Sub

    Private Sub SetDefaultValues()
        Dim selectedVariables As List(Of String) = ucrReceiverFactors.GetVariableNamesAsList ' Example, adjust based on your control
        Dim selectedCount As Integer = selectedVariables.Count
        ' Ensure ucrNudColFactors.Maximum does not exceed the number of selected variables
        If selectedCount > 0 Then
            ucrNudColFactors.Maximum = selectedCount

            If ucrNudColFactors.Value > selectedCount Then
                ucrNudColFactors.Value = selectedCount
            End If

            ucrNudColFactors.Minimum = 0

        Else
            ucrNudColFactors.Minimum = 0
        End If

    End Sub

    Private Sub SetVariableDefaults()
        Dim selectedColumns As List(Of String) = ucrReceiverFactors.GetVariableNamesAsList() ' Example, adjust based on your control
        Dim defaultVariables As Integer = selectedColumns.Count

        If ucrReceiverSummaryCols.Count > 1 AndAlso ucrReorderSummary.Count = 1 Then
            ucrNudPositionVar.Maximum = defaultVariables + 1
            ucrNudPositionVar.Minimum = 1
            ucrNudPositionVar.Value = defaultVariables + 1
            ucrNudPositionVar.Enabled = True
        ElseIf ucrReceiverSummaryCols.Count > 1 AndAlso ucrReorderSummary.Count > 1 Then
            ucrNudPositionVar.Maximum = defaultVariables + 2
            ucrNudPositionVar.Minimum = 1
            ucrNudPositionVar.Value = defaultVariables + 1
            ucrNudPositionVar.Enabled = True
        Else
            ucrNudPositionVar.Value = 1
            ucrNudPositionVar.Enabled = False
        End If

    End Sub

    Private Sub SetSummariesDefaults()
        Dim selectedSummaries As List(Of String) = ucrReceiverFactors.GetVariableNamesAsList ' Example, adjust based on your control
        Dim defaultSummaries As Integer = selectedSummaries.Count

        If ucrReceiverSummaryCols.Count > 1 AndAlso ucrReorderSummary.Count > 1 Then
            ucrNudPositionSum.Maximum = defaultSummaries + 2
            ucrNudPositionSum.Minimum = 1
            ucrNudPositionSum.Value = defaultSummaries + 2
            ucrNudPositionSum.Enabled = True
        ElseIf ucrReceiverSummaryCols.Count = 1 AndAlso ucrReorderSummary.Count > 1 Then
            ucrNudPositionSum.Maximum = defaultSummaries + 1
            ucrNudPositionSum.Minimum = 1
            ucrNudPositionSum.Value = defaultSummaries + 1
            ucrNudPositionSum.Enabled = True
        Else
            ucrNudPositionSum.Maximum = 1
            ucrNudPositionSum.Minimum = 1
            ucrNudPositionSum.Value = 1
            ucrNudPositionSum.Enabled = False
        End If

    End Sub

    Private Sub SetColFactorDefaults()
        Dim selectedColFactors As List(Of String) = ucrReceiverFactors.GetVariableNamesAsList()
        Dim defaultColFactors As Integer = selectedColFactors.Count

        If ucrReceiverSummaryCols.Count > 1 AndAlso ucrReorderSummary.Count > 1 Then
            UcrNudColumnSumFactors.Maximum = defaultColFactors + 2
        ElseIf ucrReceiverSummaryCols.Count > 1 OrElse ucrReorderSummary.Count > 1 Then
            UcrNudColumnSumFactors.Maximum = defaultColFactors + 1
        Else
            UcrNudColumnSumFactors.Maximum = defaultColFactors
        End If
        UcrNudColumnSumFactors.Minimum = 0
    End Sub

End Class
