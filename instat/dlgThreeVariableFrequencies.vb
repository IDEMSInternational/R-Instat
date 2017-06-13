' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgThreeVariableFrequencies
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsSjTab, clsSelect, clsSjPlot, clsGroupBy, clsGridArrange As New RFunction
    Private clsTableBaseOperator, clsGraphBaseOperator As New ROperator
    Private clsCurrBaseCode As RCodeStructure

    Private Sub dlgThreeVariableFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 523
        ucrChkWeights.Enabled = False ' temporary because of bug in R functions being used

        ucrSelectorThreeVariableFrequencies.SetParameter(New RParameter("data", 0))
        ucrSelectorThreeVariableFrequencies.SetParameterIsrfunction()

        ucrReceiverRowFactor.SetParameter(New RParameter("var.row", 1))
        ucrReceiverRowFactor.Selector = ucrSelectorThreeVariableFrequencies
        ucrReceiverRowFactor.SetParameterIsString()
        ucrReceiverRowFactor.bWithQuotes = False
        ucrReceiverRowFactor.SetParameterIncludeArgumentName(False)
        ucrReceiverRowFactor.bExcludeFromSelector = True

        ucrReceiverColumnFactor.SetParameter(New RParameter("var.col", 2))
        ucrReceiverColumnFactor.Selector = ucrSelectorThreeVariableFrequencies
        ucrReceiverColumnFactor.SetDataType("factor")
        ucrReceiverColumnFactor.SetParameterIsString()
        ucrReceiverColumnFactor.bWithQuotes = False
        ucrReceiverColumnFactor.SetParameterIncludeArgumentName(False)
        ucrReceiverColumnFactor.bExcludeFromSelector = True

        ucrReceiverGroupsBy1st.SetParameter(New RParameter("x", 0))
        ucrReceiverGroupsBy1st.Selector = ucrSelectorThreeVariableFrequencies
        ucrReceiverGroupsBy1st.SetDataType("factor")
        ucrReceiverGroupsBy1st.SetParameterIsString()
        ucrReceiverGroupsBy1st.bWithQuotes = False
        ucrReceiverGroupsBy1st.SetParameterIncludeArgumentName(False)
        ucrReceiverGroupsBy1st.bExcludeFromSelector = True

        ucrReceiverGroupBy2nd.SetParameter(New RParameter("y", 0))
        ucrReceiverGroupBy2nd.Selector = ucrSelectorThreeVariableFrequencies
        ucrReceiverGroupBy2nd.SetDataType("factor")
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

        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrChkCount, {rdoTable, rdoBoth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrSaveGraph, {rdoGraph, rdoBoth}, bNewLinkedHideIfParameterMissing:=True)
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
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorThreeVariableFrequencies.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("save graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrChkColumn.SetLinkedDisplayControl(grpFreqTypeTable)
    End Sub

    Private Sub SetDefaults()
        clsSelect = New RFunction
        clsSjPlot = New RFunction
        clsGroupBy = New RFunction
        clsSjTab = New RFunction
        clsGridArrange = New RFunction
        clsTableBaseOperator = New ROperator
        clsGraphBaseOperator = New ROperator

        ucrSelectorThreeVariableFrequencies.Reset()
        ucrReceiverRowFactor.SetMeAsReceiver()
        ucrSaveGraph.Reset()

        clsTableBaseOperator.SetOperation("%>%")
        clsTableBaseOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupBy, iPosition:=1)
        clsTableBaseOperator.AddParameter("select", clsRFunctionParameter:=clsSelect, iPosition:=2)
        clsTableBaseOperator.AddParameter("sjtab", clsRFunctionParameter:=clsSjTab, iPosition:=3)

        clsGraphBaseOperator.SetOperation("%>%")
        clsGraphBaseOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupBy, iPosition:=1)
        clsGraphBaseOperator.AddParameter("select", clsRFunctionParameter:=clsSelect, iPosition:=2)
        clsGraphBaseOperator.AddParameter("sjplot", clsRFunctionParameter:=clsSjPlot, iPosition:=3)

        clsGroupBy.SetPackageName("dplyr")
        clsGroupBy.SetRCommand("group_by")
        clsSelect.SetPackageName("dplyr")
        clsSelect.SetRCommand("select")

        clsSjTab.SetPackageName("sjPlot")
        clsSjTab.SetRCommand("sjtab")
        clsSjTab.AddParameter("show.summary", "FALSE")
        clsSjTab.AddParameter("digits", 0)
        clsSjTab.AddParameter("fun", Chr(34) & "xtab" & Chr(34))
        clsSjTab.AddParameter("string.total", Chr(34) & "Total" & Chr(34))

        clsSjPlot.SetPackageName("sjPlot")
        clsSjPlot.SetRCommand("sjplot")
        clsSjPlot.AddParameter("fun", Chr(34) & "grpfrq" & Chr(34))
        clsSjPlot.AddParameter("show.prc", "TRUE")
        clsSjPlot.AddParameter("show.n", "TRUE")

        clsGridArrange.SetPackageName("gridExtra")
        clsGridArrange.SetRCommand("grid.arrange")
        clsGridArrange.AddParameter("grobs", clsROperatorParameter:=clsGraphBaseOperator)

        clsGridArrange.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorThreeVariableFrequencies.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsTableBaseOperator)
        clsCurrBaseCode = clsTableBaseOperator
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        Dim clsTempParamX As RParameter
        Dim clsTempParamY As RParameter

        clsTempParamX = New RParameter("x", 3)
        ucrReceiverGroupsBy1st.AddAdditionalCodeParameterPair(clsSelect, clsTempParamX, iAdditionalPairNo:=1)
        clsTempParamX.bIncludeArgumentName = False
        clsTempParamY = New RParameter("y", 4)
        ucrReceiverGroupBy2nd.AddAdditionalCodeParameterPair(clsSelect, clsTempParamY, iAdditionalPairNo:=1)
        clsTempParamY.bIncludeArgumentName = False

        ucrSelectorThreeVariableFrequencies.AddAdditionalCodeParameterPair(clsGraphBaseOperator, ucrSelectorThreeVariableFrequencies.GetParameter, iAdditionalPairNo:=1)

        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("weight.by", 1), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjPlot, ucrChkWeights.GetParameter(), iAdditionalPairNo:=1)

        ucrReceiverRowFactor.SetRCode(clsSelect, bReset)
        ucrReceiverColumnFactor.SetRCode(clsSelect, bReset)
        ucrReceiverGroupsBy1st.SetRCode(clsGroupBy, bReset)
        ucrReceiverGroupBy2nd.SetRCode(clsGroupBy, bReset)
        ucrReceiverWeights.SetRCode(clsSjTab, bReset)
        ucrChkWeights.SetRCode(clsSjTab, bReset)
        ucrChkFlip.SetRCode(clsSjPlot, bReset)
        ucrPnlFreqType.SetRCode(clsSjPlot, bReset)
        ucrPnlFrequencyDisplay.SetRCode(clsCurrBaseCode, bReset)
        ucrSelectorThreeVariableFrequencies.SetRCode(clsTableBaseOperator, bReset)
        ucrChkCell.SetRCode(clsSjTab, bReset)
        ucrChkColumn.SetRCode(clsSjTab, bReset)
        ucrChkRow.SetRCode(clsSjTab, bReset)
        ucrChkCount.SetRCode(clsSjTab, bReset)
        ucrSaveGraph.SetRCode(clsGridArrange, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverGroupsBy1st.IsEmpty() OrElse Not ucrReceiverGroupBy2nd.IsEmpty) AndAlso Not ucrReceiverRowFactor.IsEmpty() AndAlso Not ucrReceiverColumnFactor.IsEmpty AndAlso ucrSaveGraph.IsComplete Then
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
            clsCurrBaseCode = clsTableBaseOperator
            ucrBase.clsRsyntax.iCallType = 0
        ElseIf rdoGraph.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsGridArrange)
            clsCurrBaseCode = clsGraphBaseOperator
            ucrBase.clsRsyntax.iCallType = 3
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strGraph As String
        Dim strTempScript As String = ""
        Dim bIsAssigned As Boolean
        Dim bToBeAssigned As Boolean
        Dim strAssignTo As String

        If rdoBoth.Checked Then
            bIsAssigned = clsGridArrange.bIsAssigned
            bToBeAssigned = clsGridArrange.bToBeAssigned
            strAssignTo = clsGridArrange.strAssignTo

            strGraph = clsGridArrange.ToScript(strTempScript)
            frmMain.clsRLink.RunScript(strTempScript & strGraph, iCallType:=3)

            clsGridArrange.bIsAssigned = bIsAssigned
            clsGridArrange.bToBeAssigned = bToBeAssigned
            clsGridArrange.strAssignTo = strAssignTo
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgTwoWayFrequencies.SetRCode(clsSjTab, clsSjPlot, clsGraphBaseOperator, bResetSubdialog, bNewUseTitle:=False)
        bResetSubdialog = False
        sdgTwoWayFrequencies.ShowDialog()
        TestOkEnabled()
    End Sub

    Private Sub ChangeLocation()
        If rdoBoth.Checked Then
            grpFreqTypeTable.Location = New Point(260, 261)
            grpFreqTypeGraph.Location = New Point(384, 261)
            Me.Size = New Size(525, 492)
        Else
            grpFreqTypeTable.Location = New Point(260, 261)
            grpFreqTypeGraph.Location = New Point(260, 261)
            Me.Size = New Size(431, 492)
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
            clsSjPlot.AddParameter("margin", Chr(34) & "cell" & Chr(34))
        ElseIf rdoColumn.Checked Then
            clsSjPlot.AddParameter("margin", Chr(34) & "col" & Chr(34))
        ElseIf rdoRow.Checked Then
            clsSjPlot.AddParameter("margin", Chr(34) & "row" & Chr(34))
        Else
            clsSjPlot.RemoveParameterByName("margin")
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnFactor.ControlContentsChanged, ucrReceiverRowFactor.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrChkWeights.ControlContentsChanged, ucrReceiverGroupBy2nd.ControlContentsChanged, ucrReceiverGroupsBy1st.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class