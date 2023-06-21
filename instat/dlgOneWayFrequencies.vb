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
Public Class dlgOneWayFrequencies
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsTableSjMiscFrqRFunction, clsTableAsDataFrameRFunction As New RFunction
    Private clsGraphSjGGFreqPlotRFunction, clsGraphGridRFunction, clsGraphGridAsGGplotRFunction As New RFunction
    Private clsStemLeafCaptureOutputFunction, clsStemLeafPurrMapRFunction, clsStemLeafRFunction As New RFunction
    Private clsStemLeafTildeROperator As New ROperator
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumns() As String = Nothing

    Private Sub dlgOneWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetDefaultColumn()
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 518
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        '----------------------------------
        'all options controls
        ucrPnlFreq.AddRadioButton(rdoFrqTable)
        ucrPnlFreq.AddRadioButton(rdoFrqGraph)
        ucrPnlFreq.AddRadioButton(rdoFrqStemLeaf)

        'setting rdoGraph, rdoTable and rdoStemLeaf
        ucrPnlFreq.AddFunctionNamesCondition(rdoFrqTable, {"frq", "as.data.frame"}, bNewIsPositive:=True)
        ucrPnlFreq.AddFunctionNamesCondition(rdoFrqGraph, {"plot_frq", "as.ggplot"}, bNewIsPositive:=True)
        ucrPnlFreq.AddFunctionNamesCondition(rdoFrqStemLeaf, "capture.output", bNewIsPositive:=True)

        ucrPnlFreq.AddToLinkedControls({ucrPnlTableGraphSort, ucrChkTableGraphWeights, ucrChkTableGraphGroupData}, {rdoFrqTable, rdoFrqGraph}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlFreq.AddToLinkedControls({ucrPnlTableOutput, ucrChkTableMinFrq}, {rdoFrqTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreq.AddToLinkedControls(ucrChkGraphFlipCoordinates, {rdoFrqGraph}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlFreq.AddToLinkedControls({ucrChkStemLeafScale, ucrChkStemLeafWidth}, {rdoFrqStemLeaf}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrReceiverFreq.SetParameter(New RParameter("x", 0))
        ucrReceiverFreq.SetParameterIsRFunction()
        ucrReceiverFreq.bForceAsDataFrame = True
        ucrReceiverFreq.Selector = ucrSelectorFreq
        ucrReceiverFreq.strSelectorHeading = "Variables"
        ucrReceiverFreq.bDropUnusedFilterLevels = True
        ucrReceiverFreq.bRemoveLabels = True  'temp fix to bug in sjPlot

        ucrSaveFreq.SetDataFrameSelector(ucrSelectorFreq.ucrAvailableDataFrames)
        ucrSaveFreq.SetIsComboBox()
        'other save control properties are set based on the dialog options

        '----------------------------------

        '----------------------------------
        'table and graph controls
        ucrChkTableGraphWeights.SetText("Weights")
        ucrChkTableGraphWeights.AddToLinkedControls(ucrReceiverTableGraphWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverTableGraphWeights.SetParameter(New RParameter("weight.by", 1))
        ucrReceiverTableGraphWeights.SetParameterIsRFunction()
        ucrReceiverTableGraphWeights.Selector = ucrSelectorFreq
        ucrReceiverTableGraphWeights.SetDataType("numeric")
        ucrReceiverTableGraphWeights.strSelectorHeading = "Numerics"

        ucrPnlTableGraphSort.SetParameter(New RParameter("sort.frq", 2))
        ucrPnlTableGraphSort.AddRadioButton(rdoNone, Chr(34) & "none" & Chr(34))
        ucrPnlTableGraphSort.AddRadioButton(rdoAscending, Chr(34) & "asc" & Chr(34))
        ucrPnlTableGraphSort.AddRadioButton(rdoDescending, Chr(34) & "desc" & Chr(34))
        ucrPnlTableGraphSort.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrChkTableGraphGroupData.SetText("Group Data")
        ucrChkTableGraphGroupData.AddToLinkedControls(ucrNudTableGraphGroups, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)

        ucrNudTableGraphGroups.SetParameter(New RParameter("auto.grp", 9))
        ucrNudTableGraphGroups.SetMinMax(2, 100)
        ucrNudTableGraphGroups.Increment = 5

        ucrPnlTableGraphSort.SetLinkedDisplayControl(cmdOptions)
        ucrPnlTableGraphSort.SetLinkedDisplayControl(grpTableGraphSort)
        '----------------------------------
        'table controls
        ucrPnlTableOutput.AddRadioButton(rdoTableAsOutput)
        ucrPnlTableOutput.AddRadioButton(rdoTableAsDataFrame)
        ucrPnlTableOutput.SetLinkedDisplayControl(grpTableGraphOutput)

        ucrChkTableMinFrq.SetText("Min Frequency")
        ucrChkTableMinFrq.AddToLinkedControls(ucrNudTableMinFreq, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        ucrNudTableMinFreq.SetParameter(New RParameter("min.frq", 10))
        ucrNudTableMinFreq.SetMinMax(iNewMin:=0)
        'ucrNudTableMinFreq.SetRDefault(0)

        '----------------------------------
        'graph controls
        ucrChkGraphFlipCoordinates.SetParameter(New RParameter("coord.flip", 10))
        ucrChkGraphFlipCoordinates.SetText("Flip Coordinates")
        ucrChkGraphFlipCoordinates.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkGraphFlipCoordinates.SetRDefault("FALSE")

        '----------------------------------
        'stema and leaf controls
        ucrChkStemLeafScale.SetText("Scale")
        ucrChkStemLeafScale.AddToLinkedControls(ucrNudStemLeafScale, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)

        ucrNudStemLeafScale.SetParameter(New RParameter("scale", 1))
        ucrNudStemLeafScale.SetMinMax(0.0)
        ucrNudStemLeafScale.DecimalPlaces = 1
        ucrNudStemLeafScale.Increment = 0.1

        ucrChkStemLeafWidth.SetText("Width")
        ucrChkStemLeafWidth.AddToLinkedControls(ucrNudStemLeafWidth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=80)

        ucrNudStemLeafWidth.SetParameter(New RParameter("width", 2))
        ucrNudStemLeafWidth.SetMinMax(20)
        ucrNudStemLeafWidth.Increment = 1
        '----------------------------------

    End Sub

    Private Sub SetDefaults()
        clsTableSjMiscFrqRFunction = New RFunction
        clsTableAsDataFrameRFunction = New RFunction

        clsGraphSjGGFreqPlotRFunction = New RFunction
        clsGraphGridRFunction = New RFunction
        clsGraphGridAsGGplotRFunction = New RFunction

        clsStemLeafRFunction = New RFunction
        clsStemLeafPurrMapRFunction = New RFunction
        clsStemLeafTildeROperator = New ROperator

        ucrSelectorFreq.Reset()
        ucrReceiverFreq.SetMeAsReceiver()
        ucrSaveFreq.Reset()

        '-------------------------
        'table functions
        clsTableSjMiscFrqRFunction.SetPackageName("sjmisc")
        clsTableSjMiscFrqRFunction.SetRCommand("frq")

        clsTableAsDataFrameRFunction.SetRCommand("as.data.frame")
        clsTableAsDataFrameRFunction.AddParameter("x", clsRFunctionParameter:=clsTableSjMiscFrqRFunction, iPosition:=0)
        '-------------------------

        '-------------------------
        'Graphics functions
        clsGraphSjGGFreqPlotRFunction.SetPackageName("sjPlot")
        clsGraphSjGGFreqPlotRFunction.SetRCommand("plot_frq")
        clsGraphSjGGFreqPlotRFunction.AddParameter("geom.size", 0.5, iPosition:=14)

        'grids multuple sjplots 
        clsGraphGridRFunction.SetPackageName("sjPlot")
        clsGraphGridRFunction.SetRCommand("plot_grid")
        clsGraphGridRFunction.AddParameter("x", clsRFunctionParameter:=clsGraphSjGGFreqPlotRFunction, iPosition:=0)

        'converts the grid to ggplot
        clsGraphGridAsGGplotRFunction.SetPackageName("ggplotify")
        clsGraphGridAsGGplotRFunction.SetRCommand("as.ggplot")
        clsGraphGridAsGGplotRFunction.AddParameter("plot", clsRFunctionParameter:=clsGraphGridRFunction, iPosition:=0)
        clsGraphGridAsGGplotRFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorFreq.strCurrentDataFrame,
                                                  strObjectName:="last_graph")

        '-------------------------

        '-------------------------
        'stem leaf functions
        clsStemLeafCaptureOutputFunction.SetPackageName("utils")
        clsStemLeafCaptureOutputFunction.SetRCommand("capture.output")
        clsStemLeafCaptureOutputFunction.AddParameter("x", clsRFunctionParameter:=clsStemLeafPurrMapRFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsStemLeafCaptureOutputFunction.SetAssignTo("result")

        clsStemLeafPurrMapRFunction.SetPackageName("purrr")
        clsStemLeafPurrMapRFunction.SetRCommand("map")
        clsStemLeafPurrMapRFunction.AddParameter("Tilde", clsROperatorParameter:=clsStemLeafTildeROperator, bIncludeArgumentName:=False, iPosition:=1)

        clsStemLeafTildeROperator.SetOperation("~")
        clsStemLeafTildeROperator.AddParameter("right", clsRFunctionParameter:=clsStemLeafRFunction, bIncludeArgumentName:=False, iPosition:=1)
        clsStemLeafTildeROperator.bForceIncludeOperation = True

        clsStemLeafRFunction.SetRCommand("stem")
        '-------------------------

        ucrBase.clsRsyntax.SetBaseRFunction(clsTableSjMiscFrqRFunction)
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)

        '-------------------------
        'all options controls
        ucrSaveFreq.AddAdditionalRCode(clsTableAsDataFrameRFunction)
        ucrSaveFreq.AddAdditionalRCode(clsGraphGridAsGGplotRFunction)
        ucrSaveFreq.AddAdditionalRCode(clsGraphSjGGFreqPlotRFunction)

        ucrReceiverFreq.AddAdditionalCodeParameterPair(clsGraphSjGGFreqPlotRFunction, New RParameter("data", 0), iAdditionalPairNo:=1)

        ucrPnlFreq.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveFreq.SetRCode(clsGraphGridAsGGplotRFunction, bReset)
        ucrReceiverFreq.SetRCode(clsTableSjMiscFrqRFunction, bReset)
        '-------------------------

        '-------------------------
        'table graph controls

        'reuse the same parameter because we want the same values for table and graph option
        ucrPnlTableGraphSort.AddAdditionalCodeParameterPair(clsGraphSjGGFreqPlotRFunction, ucrPnlTableGraphSort.GetParameter(), iAdditionalPairNo:=1)
        ucrNudTableGraphGroups.AddAdditionalCodeParameterPair(clsGraphSjGGFreqPlotRFunction, ucrNudTableGraphGroups.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverTableGraphWeights.AddAdditionalCodeParameterPair(clsGraphSjGGFreqPlotRFunction, ucrReceiverTableGraphWeights.GetParameter(), iAdditionalPairNo:=1)

        ucrPnlTableGraphSort.SetRCode(clsTableSjMiscFrqRFunction, bReset)
        ucrNudTableGraphGroups.SetRCode(clsTableSjMiscFrqRFunction, bReset)
        ucrReceiverTableGraphWeights.SetRCode(clsTableSjMiscFrqRFunction, bReset)
        '-------------------------

        '-------------------------
        'table controls
        ucrNudTableMinFreq.SetRCode(clsTableSjMiscFrqRFunction, bReset)

        '-------------------------

        '-------------------------
        'graph controls
        ucrChkGraphFlipCoordinates.SetRCode(clsGraphSjGGFreqPlotRFunction, bReset)

        '-------------------------

        '-------------------------
        'stem leaf controls
        ucrNudStemLeafScale.SetRCode(clsStemLeafRFunction, bReset)
        ucrNudStemLeafWidth.SetRCode(clsStemLeafRFunction, bReset)
        '-------------------------

    End Sub

    Private Sub ucrPnlFreq_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFreq.ControlValueChanged
        If rdoFrqTable.Checked OrElse rdoFrqGraph.Checked Then
            ucrChkTableGraphWeights.Checked = clsTableSjMiscFrqRFunction.ContainsParameter("weight.by") OrElse clsGraphSjGGFreqPlotRFunction.ContainsParameter("weight.by")
            ucrChkTableGraphGroupData.Checked = clsTableSjMiscFrqRFunction.ContainsParameter("auto.grp") OrElse clsGraphSjGGFreqPlotRFunction.ContainsParameter("auto.grp")

            If rdoFrqTable.Checked Then
                'the ideal way to determine the checked radio button would be to use AddFunctionNamesCondition()
                'but the panel does not have the feature to do it when using function names that are generated by different RFunctions objects
                'ucrPnlTableOutput.AddFunctionNamesCondition(rdoTableAsOutput, "frq", bNewIsPositive:=True)
                'ucrPnlTableOutput.AddFunctionNamesCondition(rdoTableAsDataFrame, "as.data.frame", bNewIsPositive:=True)
                If clsTableSjMiscFrqRFunction.strRCommand = "as.data.frame" Then
                    rdoTableAsDataFrame.Checked = True
                Else
                    rdoTableAsOutput.Checked = True
                End If
                ucrChkTableMinFrq.Checked = clsTableSjMiscFrqRFunction.ContainsParameter("min.frq")
            End If

        ElseIf rdoFrqStemLeaf.Checked Then
            ucrChkStemLeafWidth.Checked = clsStemLeafRFunction.ContainsParameter("width")
            ucrChkStemLeafScale.Checked = clsStemLeafRFunction.ContainsParameter("scale")
        End If
    End Sub

    Private Sub outPutChangeControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFreq.ControlValueChanged, ucrPnlTableOutput.ControlValueChanged, ucrReceiverFreq.ControlValueChanged
        If rdoFrqTable.Checked Then
            If rdoTableAsOutput.Checked Then
                ucrSaveFreq.SetSaveType(strRObjectType:=RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)
                ucrSaveFreq.SetPrefix("freq_summary")
                ucrSaveFreq.SetCheckBoxText("Save Summary")
                ucrSaveFreq.SetAssignToIfUncheckedValue("last_summary")

                'restore assign to
                clsTableSjMiscFrqRFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                                              strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                                              strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                              strRDataFrameNameToAddObjectTo:=ucrSelectorFreq.strCurrentDataFrame,
                                                              strObjectName:="last_summary")

                ucrBase.clsRsyntax.SetBaseRFunction(clsTableSjMiscFrqRFunction)
            Else
                ucrSaveFreq.SetPrefix("one_way_freq")
                ucrSaveFreq.SetCheckBoxText("Save Data Frame")
                ucrSaveFreq.SetSaveType(strRObjectType:=RObjectTypeLabel.Dataframe)
                ucrSaveFreq.SetAssignToIfUncheckedValue("one_way_freq")

                'remove assign to because clsTableSjMiscFrqRFunction will be wrapped into clsTableAsDataFrameRFunction
                clsTableSjMiscFrqRFunction.RemoveAssignTo()
                ucrBase.clsRsyntax.SetBaseRFunction(clsTableAsDataFrameRFunction)

            End If
        ElseIf rdoFrqGraph.Checked Then
            ucrSaveFreq.SetSaveType(strRObjectType:=RObjectTypeLabel.Graph, strRObjectFormat:=RObjectFormat.Image)
            ucrSaveFreq.SetCheckBoxText("Save Graph")
            ucrSaveFreq.SetPrefix("freq_graph")
            ucrSaveFreq.SetAssignToIfUncheckedValue("last_graph")

            If ucrReceiverFreq.GetVariableNamesAsList().Count > 1 Then
                'remove assign to because clsGraphSjGGFreqPlotRFunction will be wrapped into clsGraphGridAsGGplotRFunction
                clsGraphSjGGFreqPlotRFunction.RemoveAssignTo()
                ucrBase.clsRsyntax.SetBaseRFunction(clsGraphGridAsGGplotRFunction)
            Else
                'restore assign to
                clsGraphSjGGFreqPlotRFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                                              strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                                              strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                                              strRDataFrameNameToAddObjectTo:=ucrSelectorFreq.strCurrentDataFrame,
                                                              strObjectName:="last_graph")
                ucrBase.clsRsyntax.SetBaseRFunction(clsGraphSjGGFreqPlotRFunction)
            End If

        ElseIf rdoFrqStemLeaf.Checked Then
            ucrSaveFreq.SetSaveType(strRObjectType:=RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)
            ucrSaveFreq.SetPrefix("freq_summary")
            ucrSaveFreq.SetCheckBoxText("Save Summary")
            ucrSaveFreq.SetAssignToIfUncheckedValue("last_summary")

            clsStemLeafCaptureOutputFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                                              strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                                              strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                              strRDataFrameNameToAddObjectTo:=ucrSelectorFreq.strCurrentDataFrame,
                                                              strObjectName:="last_summary")
            ucrBase.clsRsyntax.SetBaseRFunction(clsStemLeafCaptureOutputFunction)
        End If
    End Sub

    Private Sub ucrReceiverFreq_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFreq.ControlValueChanged
        Dim strRVector As String = ucrReceiverFreq.GetVariableNames
        clsGraphGridRFunction.AddParameter("tags", strParameterValue:=strRVector, iPosition:=1)
        clsStemLeafPurrMapRFunction.AddParameter(".x", strParameterValue:=strRVector, iPosition:=0)

        'manually construct the data_book$get_data_frame(data_name="data_name")" command from the data frame selector
        Dim clsRFunction As New RFunction
        Dim strtemp As String = ""
        clsRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsRFunction.AddParameter(strParameterName:="data_name", strParameterValue:=Chr(34) & ucrSelectorFreq.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
        clsRFunction.SetAssignTo(ucrSelectorFreq.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        clsRFunction.ToScript(strtemp)

        clsStemLeafRFunction.AddParameter("x", strtemp.Trim() & "[[.x]]", bIncludeArgumentName:=False, iPosition:=0)

    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlFreq.ControlContentsChanged,
        ucrReceiverFreq.ControlContentsChanged, ucrSaveFreq.ControlContentsChanged,
        ucrChkTableGraphWeights.ControlContentsChanged, ucrReceiverTableGraphWeights.ControlContentsChanged,
        ucrChkTableGraphGroupData.ControlContentsChanged, ucrNudTableGraphGroups.ControlContentsChanged,
        ucrChkTableMinFrq.ControlContentsChanged, ucrNudTableMinFreq.ControlContentsChanged,
        ucrPnlTableOutput.ControlContentsChanged,
        ucrChkStemLeafWidth.ControlContentsChanged, ucrNudStemLeafWidth.ControlContentsChanged,
         ucrChkStemLeafScale.ControlContentsChanged, ucrNudStemLeafScale.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTableGraphWeights.ControlValueChanged
        If ucrChkTableGraphWeights.Checked Then
            ucrReceiverTableGraphWeights.SetMeAsReceiver()
        Else
            ucrReceiverFreq.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgOneWayFrequencies.SetRFunction(clsTableSjMiscFrqRFunction, clsGraphSjGGFreqPlotRFunction, clsGraphGridRFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgOneWayFrequencies.ShowDialog()
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnabled As Boolean = True

        If ucrReceiverFreq.IsEmpty() Then
            bOkEnabled = False
        ElseIf rdoFrqTable.Checked OrElse rdoFrqGraph.Checked Then
            If ucrChkTableGraphWeights.Checked AndAlso ucrReceiverTableGraphWeights.IsEmpty Then
                bOkEnabled = False
            ElseIf ucrChkTableGraphGroupData.Checked AndAlso ucrNudTableGraphGroups.IsEmpty Then
                bOkEnabled = False
            ElseIf rdoFrqTable.Checked AndAlso ucrChkTableMinFrq.Checked AndAlso ucrNudTableMinFreq.IsEmpty Then
                bOkEnabled = False
            End If
        ElseIf rdoFrqStemLeaf.Checked Then
            If ucrChkStemLeafWidth.Checked AndAlso ucrNudStemLeafWidth.IsEmpty Then
                bOkEnabled = False
            ElseIf ucrChkStemLeafScale.Checked AndAlso ucrNudStemLeafScale.IsEmpty Then
                bOkEnabled = False
            End If
        End If

        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub SetDefaultColumn()
        If Not String.IsNullOrEmpty(strDefaultDataFrame) Then
            ucrSelectorFreq.SetDataframe(strDefaultDataFrame)
        End If
        If strDefaultColumns IsNot Nothing Then
            For Each strVar As String In strDefaultColumns
                ucrReceiverFreq.Add(strVar, strDefaultDataFrame)
            Next
        End If
        strDefaultDataFrame = ""
        strDefaultColumns = Nothing
    End Sub

End Class
