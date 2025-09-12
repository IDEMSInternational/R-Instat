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
Public Class dlgThreeVariableFrequencies
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsSjTabFunction, clsSelectFunction, clsSjPlotFunction,
            clsGroupByFunction, clsGridArrangeFunction, clsArrangeFunction As New RFunction
    Private clsTableBaseOperator, clsGraphBaseOperator As New ROperator
    Private clsCurrBaseCode As New RCodeStructure
    Private iMaxGraphGroupX As Integer

    Private Sub dlgThreeVariableFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            iMaxGraphGroupX = grpFreqTypeGraph.Location.X
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        ReopenDialog()
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub ReopenDialog()
        ChangeLocation()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 415
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrChkWeights.Enabled = False ' temporary because of bug in R functions being used

        ucrSelectorThreeVariableFrequencies.SetParameter(New RParameter("data", 0))
        ucrSelectorThreeVariableFrequencies.SetParameterIsrfunction()
        ucrSelectorThreeVariableFrequencies.bDropUnusedFilterLevels = True

        ucrReceiverRowFactor.SetParameter(New RParameter("var.row", 1))
        ucrReceiverRowFactor.Selector = ucrSelectorThreeVariableFrequencies
        ucrReceiverRowFactor.SetParameterIsString()
        ucrReceiverRowFactor.bWithQuotes = False
        ucrReceiverRowFactor.SetParameterIncludeArgumentName(False)
        ucrReceiverRowFactor.bExcludeFromSelector = True

        ucrReceiverColumnFactor.SetParameter(New RParameter("var.col", 2))
        ucrReceiverColumnFactor.Selector = ucrSelectorThreeVariableFrequencies
        ucrReceiverColumnFactor.SetDataType("factor")
        ucrReceiverColumnFactor.strSelectorHeading = "Factors"
        ucrReceiverColumnFactor.SetParameterIsString()
        ucrReceiverColumnFactor.bWithQuotes = False
        ucrReceiverColumnFactor.SetParameterIncludeArgumentName(False)
        ucrReceiverColumnFactor.bExcludeFromSelector = True

        ucrReceiverGroupsBy1st.SetParameter(New RParameter("x", 0))
        ucrReceiverGroupsBy1st.Selector = ucrSelectorThreeVariableFrequencies
        ucrReceiverGroupsBy1st.strSelectorHeading = "Factors"
        ucrReceiverGroupsBy1st.SetParameterIsString()
        ucrReceiverGroupsBy1st.bWithQuotes = False
        ucrReceiverGroupsBy1st.SetParameterIncludeArgumentName(False)
        ucrReceiverGroupsBy1st.bExcludeFromSelector = True

        ucrReceiverGroupBy2nd.SetParameter(New RParameter("y", 0))
        ucrReceiverGroupBy2nd.Selector = ucrSelectorThreeVariableFrequencies
        ucrReceiverGroupBy2nd.SetDataType("factor")
        ucrReceiverGroupBy2nd.strSelectorHeading = "Factors"
        ucrReceiverGroupBy2nd.SetParameterIsString()
        ucrReceiverGroupBy2nd.bWithQuotes = False
        ucrReceiverGroupBy2nd.SetParameterIncludeArgumentName(False)
        ucrReceiverGroupBy2nd.bExcludeFromSelector = True

        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 3))
        ucrReceiverWeights.SetParameterIsRFunction()
        ucrReceiverWeights.Selector = ucrSelectorThreeVariableFrequencies
        ucrReceiverWeights.SetDataType("numeric")

        ucrChkFlip.SetParameter(New RParameter("coord.flip", 4), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetRDefault("FALSE")

        ucrChkRow.SetParameter(New RParameter("show.row.prc", 5), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkRow.SetText("Row (%)")
        ucrChkRow.SetRDefault("FALSE")

        ucrChkCount.SetParameter(New RParameter("show.obs", 6), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkCount.SetText("Count")
        ucrChkCount.SetRDefault("TRUE")

        ucrChkColumn.SetParameter(New RParameter("show.col.prc", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkColumn.SetText("Column (%)")
        ucrChkColumn.SetRDefault("FALSE")

        ucrChkCell.SetParameter(New RParameter("show.cell.prc", 8), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkCell.SetText("Cell (%)")
        ucrChkCell.SetRDefault("FALSE")

        ucrChkWeights.SetText("Weights")
        ucrChkWeights.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeights.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlFrequencyDisplay.AddRadioButton(rdoTable)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoGraph)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoBoth)

        ucrPnlFrequencyDisplay.AddParameterPresentCondition(rdoTable, "sjtab")
        ucrPnlFrequencyDisplay.AddParameterPresentCondition(rdoGraph, "sjplot")
        'TODO have conditions on multiple functions for both option
        'and also requires multiple output support. So for now diesable
        rdoBoth.Enabled = False

        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrChkCount, {rdoTable, rdoBoth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrChkRow, {rdoTable, rdoBoth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrChkCell, {rdoTable, rdoBoth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrChkColumn, {rdoTable, rdoBoth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrPnlFreqType, {rdoGraph, rdoBoth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqType.SetLinkedDisplayControl(grpFreqTypeGraph)

        ucrPnlFreqType.SetParameter(New RParameter("fun", 4))
        ucrPnlFreqType.AddRadioButton(rdoCount, Chr(34) & "grpfrq" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoRow, Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoColumn, Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoCell, Chr(34) & "xtab" & Chr(34))

        ucrPnlFreqType.AddParameterPresentCondition(rdoCount, "margin", False)
        ucrPnlFreqType.AddParameterValuesCondition(rdoRow, "margin", Chr(34) & "row" & Chr(34))
        ucrPnlFreqType.AddParameterValuesCondition(rdoCell, "margin", Chr(34) & "cell" & Chr(34))
        ucrPnlFreqType.AddParameterValuesCondition(rdoColumn, "margin", Chr(34) & "col" & Chr(34))

        ' ucrSaveGraph.Enabled = False 'temporary for now
        ucrSaveGraph.SetPrefix("three_way_freq")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorThreeVariableFrequencies.ucrAvailableDataFrames)
        ucrSaveGraph.SetIsComboBox()

        ucrChkColumn.SetLinkedDisplayControl(grpFreqTypeTable)
    End Sub

    Private Sub SetDefaults()
        clsSelectFunction = New RFunction
        clsSjPlotFunction = New RFunction
        clsGroupByFunction = New RFunction
        clsSjTabFunction = New RFunction
        clsArrangeFunction = New RFunction
        clsGridArrangeFunction = New RFunction
        clsTableBaseOperator = New ROperator
        clsGraphBaseOperator = New ROperator

        ucrSelectorThreeVariableFrequencies.Reset()
        ucrReceiverRowFactor.SetMeAsReceiver()
        ucrSaveGraph.Reset()

        clsTableBaseOperator.SetOperation("%>%")
        clsTableBaseOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
        clsTableBaseOperator.AddParameter("select", clsRFunctionParameter:=clsSelectFunction, iPosition:=2)
        clsTableBaseOperator.AddParameter("arrange", clsRFunctionParameter:=clsArrangeFunction, iPosition:=3)
        clsTableBaseOperator.AddParameter("sjtab", clsRFunctionParameter:=clsSjTabFunction, iPosition:=4)
        clsTableBaseOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                                     strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                                     strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                     strRDataFrameNameToAddObjectTo:=ucrSelectorThreeVariableFrequencies.strCurrentDataFrame,
                                                     strObjectName:="last_summary")

        clsGraphBaseOperator.SetOperation("%>%")
        'iPosition should follow in the folowing order for this operator
        clsGraphBaseOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
        clsGraphBaseOperator.AddParameter("select", clsRFunctionParameter:=clsSelectFunction, iPosition:=2)
        clsGraphBaseOperator.AddParameter("arrange", clsRFunctionParameter:=clsArrangeFunction, iPosition:=3)
        clsGraphBaseOperator.AddParameter("sjplot", clsRFunctionParameter:=clsSjPlotFunction, iPosition:=4)

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")
        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")
        clsArrangeFunction.SetPackageName("dplyr")
        clsArrangeFunction.SetRCommand("arrange")

        clsSjTabFunction.SetPackageName("sjPlot")
        clsSjTabFunction.SetRCommand("sjtab")
        clsSjTabFunction.AddParameter("show.summary", "FALSE")
        clsSjTabFunction.AddParameter("digits", 0)
        clsSjTabFunction.AddParameter("fun", Chr(34) & "xtab" & Chr(34))
        clsSjTabFunction.AddParameter("string.total", Chr(34) & "Total" & Chr(34))

        clsSjPlotFunction.SetPackageName("sjPlot")
        clsSjPlotFunction.SetRCommand("sjplot")
        clsSjPlotFunction.AddParameter("fun", Chr(34) & "grpfrq" & Chr(34))
        clsSjPlotFunction.AddParameter("show.prc", "TRUE")
        clsSjPlotFunction.AddParameter("show.n", "TRUE")

        clsGridArrangeFunction.SetPackageName("gridExtra")
        'use arrangeGrob() instead of grid.arrange() because arrangeGrob() returns a grob without drawing on the current device.
        'read package ocumentation for more information
        'clsGridArrangeFunction.SetRCommand("grid.arrange") 'left here for future reference only
        clsGridArrangeFunction.SetRCommand("arrangeGrob")
        clsGridArrangeFunction.AddParameter("grobs", clsROperatorParameter:=clsGraphBaseOperator)
        clsGridArrangeFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                                       strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                                       strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                                       strRDataFrameNameToAddObjectTo:=ucrSelectorThreeVariableFrequencies.strCurrentDataFrame,
                                                       strObjectName:="last_graph")

        ucrBase.clsRsyntax.SetBaseROperator(clsTableBaseOperator)
        clsCurrBaseCode = clsTableBaseOperator
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        Dim clsTempParamX As RParameter
        Dim clsTempParamY As RParameter

        ucrSaveGraph.AddAdditionalRCode(clsTableBaseOperator, iAdditionalPairNo:=1)
        ucrSaveGraph.AddAdditionalRCode(clsGridArrangeFunction, iAdditionalPairNo:=2)

        clsTempParamX = New RParameter("x", 3)
        ucrReceiverGroupsBy1st.AddAdditionalCodeParameterPair(clsSelectFunction, clsTempParamX, iAdditionalPairNo:=1)
        clsTempParamX.bIncludeArgumentName = False
        clsTempParamY = New RParameter("y", 4)
        ucrReceiverGroupBy2nd.AddAdditionalCodeParameterPair(clsSelectFunction, clsTempParamY, iAdditionalPairNo:=1)
        clsTempParamY.bIncludeArgumentName = False

        ucrReceiverGroupsBy1st.AddAdditionalCodeParameterPair(clsArrangeFunction, New RParameter("col", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverGroupBy2nd.AddAdditionalCodeParameterPair(clsArrangeFunction, New RParameter("col", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)

        ucrSelectorThreeVariableFrequencies.AddAdditionalCodeParameterPair(clsGraphBaseOperator, ucrSelectorThreeVariableFrequencies.GetParameter, iAdditionalPairNo:=1)

        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjPlotFunction, New RParameter("weight.by", 1), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjPlotFunction, ucrChkWeights.GetParameter(), iAdditionalPairNo:=1)

        ucrReceiverRowFactor.SetRCode(clsSelectFunction, bReset)
        ucrReceiverColumnFactor.SetRCode(clsSelectFunction, bReset)
        ucrReceiverGroupsBy1st.SetRCode(clsGroupByFunction, bReset)
        ucrReceiverGroupBy2nd.SetRCode(clsGroupByFunction, bReset)
        ucrReceiverWeights.SetRCode(clsSjTabFunction, bReset)
        ucrChkWeights.SetRCode(clsSjTabFunction, bReset)
        ucrChkFlip.SetRCode(clsSjPlotFunction, bReset)
        ucrPnlFreqType.SetRCode(clsSjPlotFunction, bReset)
        If bReset OrElse Not rdoBoth.Checked Then
            ucrPnlFrequencyDisplay.SetRCode(clsCurrBaseCode, bReset)
        End If

        ucrSelectorThreeVariableFrequencies.SetRCode(clsTableBaseOperator, bReset)
        ucrChkCell.SetRCode(clsSjTabFunction, bReset)
        ucrChkColumn.SetRCode(clsSjTabFunction, bReset)
        ucrChkRow.SetRCode(clsSjTabFunction, bReset)
        ucrChkCount.SetRCode(clsSjTabFunction, bReset)
        ucrSaveGraph.SetRCode(clsGridArrangeFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverGroupsBy1st.IsEmpty() OrElse Not ucrSaveGraph.IsComplete OrElse Not ucrReceiverGroupBy2nd.IsEmpty) AndAlso Not ucrReceiverRowFactor.IsEmpty() AndAlso Not ucrReceiverColumnFactor.IsEmpty AndAlso ucrSaveGraph.IsComplete Then
            If Not ucrChkWeights.Checked Then
                ucrBase.OKEnabled(True)
            Else
                If ucrReceiverWeights.IsEmpty Then
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
        TestOkEnabled()
    End Sub

    Private Sub SetBaseFunction()
        If rdoTable.Checked OrElse rdoBoth.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsTableBaseOperator)
            ucrSaveGraph.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
            ucrSaveGraph.SetAssignToIfUncheckedValue("last_summary")
            ucrSaveGraph.SetCheckBoxText("Store Summary")
        ElseIf rdoGraph.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsGridArrangeFunction)
            ucrSaveGraph.SetSaveType(RObjectTypeLabel.Graph, strRObjectFormat:=RObjectFormat.Image)
            ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
            ucrSaveGraph.SetCheckBoxText("Store Graph")
        End If
    End Sub

    'todo. Both option disabled
    'Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
    '    Dim strGraph As String
    '    Dim strTempScript As String = ""


    '    If rdoBoth.Checked Then
    '        strGraph = clsGridArrangeFunction.ToScript(strTempScript)
    '        frmMain.clsRLink.RunRScript(strTempScript & strGraph, iCallType:=3)
    '    End If
    'End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgTwoWayFrequencies.SetRCode(clsSjTabFunction, clsSjPlotFunction, clsGraphBaseOperator, bResetSubdialog, bNewUseTitle:=False)
        bResetSubdialog = False
        sdgTwoWayFrequencies.ShowDialog()
        TestOkEnabled()
    End Sub

    Private Sub ChangeLocation()
        If rdoBoth.Checked Then
            grpFreqTypeGraph.Location = New Point(iMaxGraphGroupX, grpFreqTypeGraph.Location.Y)
        Else
            grpFreqTypeGraph.Location = New Point(grpFreqTypeTable.Location.X, grpFreqTypeTable.Location.Y)
        End If
    End Sub

    Private Sub ucrPnlFrequencyDisplay_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFlip.ControlValueChanged, ucrPnlFrequencyDisplay.ControlValueChanged
        Dim clsRowParam As RParameter
        Dim clsColumnParam As RParameter

        clsRowParam = ucrReceiverRowFactor.GetParameter()
        clsColumnParam = ucrReceiverColumnFactor.GetParameter()
        If rdoTable.Checked OrElse rdoBoth.Checked Then
            If ucrChkFlip.Checked Then
                clsColumnParam.Position = 1
                clsRowParam.Position = 2
            Else
                clsRowParam.Position = 1
                clsColumnParam.Position = 2
            End If
            ucrReceiverRowFactor.SetParameter(clsRowParam)
            ucrReceiverColumnFactor.SetParameter(clsColumnParam)
        End If
        ChangeLocation()
        SetBaseFunction()
    End Sub

    Private Sub ucrPnlFreqType_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlFreqType.ControlContentsChanged
        If rdoCell.Checked Then
            clsSjPlotFunction.AddParameter("margin", Chr(34) & "cell" & Chr(34))
        ElseIf rdoColumn.Checked Then
            clsSjPlotFunction.AddParameter("margin", Chr(34) & "col" & Chr(34))
        ElseIf rdoRow.Checked Then
            clsSjPlotFunction.AddParameter("margin", Chr(34) & "row" & Chr(34))
        Else
            clsSjPlotFunction.RemoveParameterByName("margin")
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnFactor.ControlContentsChanged, ucrReceiverRowFactor.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrChkWeights.ControlContentsChanged, ucrReceiverGroupBy2nd.ControlContentsChanged, ucrReceiverGroupsBy1st.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class