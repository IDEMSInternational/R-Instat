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
Public Class dlgTwoWayFrequencies
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsSjTab, clsSelect, clsSjPlot As New RFunction
    Private clsTableBaseOperator, clsGraphBaseOperator As New ROperator

    Private Sub dlgTwoWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'HelpID
        'ucrBase.iHelpTopicID = 
        Me.Size = New Size(426, 411)
        ucrReceiverColumnFactor.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverRowFactor.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverWeights.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverRowFactor.SetDataType("factor")
        ucrReceiverColumnFactor.SetDataType("factor")
        ucrReceiverWeights.SetDataType("numeric")

        'setting receivers parameters
        ucrReceiverRowFactor.SetParameter(New RParameter("var.row", 1))
        ucrReceiverRowFactor.SetParameterIsString()
        ucrReceiverRowFactor.bWithQuotes = False
        ucrReceiverRowFactor.SetParameterIncludeArgumentName(False)
        ucrReceiverColumnFactor.SetParameter(New RParameter("var.col", 2))
        ucrReceiverColumnFactor.SetParameterIsString()
        ucrReceiverColumnFactor.bWithQuotes = False
        ucrReceiverColumnFactor.SetParameterIncludeArgumentName(False)

        'setting selector
        ucrSelectorTwoWayFrequencies.SetParameter(New RParameter("data", 0))
        ucrSelectorTwoWayFrequencies.SetParameterIsrfunction()

        'ucrReceiverWeights
        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 3))
        ucrReceiverWeights.SetParameterIsRFunction()

        'setting ucrPnlFreqType
        ucrPnlFreqType.SetParameter(New RParameter("fun", 4))
        ucrPnlFreqType.AddRadioButton(rdoCount, Chr(34) & "grpfrq" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoRow, Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoColumn, Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoCell, Chr(34) & "xtab" & Chr(34))

        'Adding ucrPnlFreqType conditions
        ucrPnlFreqType.AddParameterValuesCondition(rdoCount, "fun", "grpfrq")
        ucrPnlFreqType.AddParameterValuesCondition(rdoCount, "margin", False)
        ucrPnlFreqType.AddParameterValuesCondition(rdoRow, "fun", "xtab")
        ucrPnlFreqType.AddParameterValuesCondition(rdoRow, "margin", "row")
        ucrPnlFreqType.AddParameterValuesCondition(rdoCell, "fun", "xtab")
        ucrPnlFreqType.AddParameterValuesCondition(rdoCell, "margin", "cell")
        ucrPnlFreqType.AddParameterValuesCondition(rdoColumn, "fun", "xtab")
        ucrPnlFreqType.AddParameterValuesCondition(rdoColumn, "margin", "col")
        ucrPnlFreqType.bAllowNonConditionValues = True
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

        ucrChkFlip.SetParameter(New RParameter("coord.flip", 4), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetRDefault("FALSE")
        'Setting ucrPnlFreqDisplay
        ucrPnlFreqDisplay.AddRadioButton(rdoTable)
        ucrPnlFreqDisplay.AddRadioButton(rdoGraph)
        ucrPnlFreqDisplay.AddRadioButton(rdoBoth)

        ucrPnlFreqDisplay.AddFunctionNamesCondition(rdoTable, "sjtab")
        ucrPnlFreqDisplay.AddFunctionNamesCondition(rdoGraph, "sjplot")
        ucrPnlFreqDisplay.AddFunctionNamesCondition(rdoBoth, "sjtab")
        ucrPnlFreqDisplay.AddFunctionNamesCondition(rdoBoth, "sjplot")
        'Setting Display of the group boxes in the dialogue
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkCount, {rdoTable, rdoBoth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkRow, {rdoTable, rdoBoth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkCell, {rdoTable, rdoBoth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkColumn, {rdoTable, rdoBoth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColumn.SetLinkedDisplayControl(grpFreqTypeTable)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrPnlFreqType, {rdoGraph, rdoBoth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoCount)
        ucrPnlFreqType.SetLinkedDisplayControl(grpFreqTypeGraph)

    End Sub

    Private Sub SetDefaults()
        clsSjTab = New RFunction
        clsSjPlot = New RFunction
        clsTableBaseOperator = New ROperator
        clsSelect = New RFunction

        clsTableBaseOperator.SetOperation("%>%")
        clsTableBaseOperator.AddParameter("select", clsRFunctionParameter:=clsSelect, iPosition:=1)
        clsTableBaseOperator.AddParameter("sjtab", clsRFunctionParameter:=clsSjTab, iPosition:=2)

        clsSelect.SetPackageName("dplyr")
        clsSelect.SetRCommand("select")

        'Reset
        ucrSelectorTwoWayFrequencies.Reset()
        ucrReceiverRowFactor.SetMeAsReceiver()
        sdgTwoWayFrequencies.ucrInputTableTitle.SetName("")
        sdgTwoWayFrequencies.ucrInputGraphTitle.SetName("")


        'Defining Table functions and default functions
        clsSjTab.SetPackageName("sjPlot")
        clsSjTab.SetRCommand("sjtab")
        clsSjTab.AddParameter("show.obs", "TRUE")
        clsSjTab.AddParameter("show.summary", "FALSE")
        clsSjTab.AddParameter("digits", 0)
        clsSjTab.AddParameter("fun", Chr(34) & "xtab" & Chr(34))

        'Defining Plot functions and default functions
        clsSjPlot.SetRCommand("sjplot")
        clsSjPlot.AddParameter("show.prc", "TRUE")
        clsSjPlot.AddParameter("show.n", "TRUE")
        clsSjPlot.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoWayFrequencies.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsTableBaseOperator)
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        Dim clsTempParamOne As RParameter
        Dim clsTempParamTwo As RParameter

        'Adding additional pair of fuction and parameters in various controls and setting up Rcode
        clsTempParamOne = New RParameter("x", 1)
        ucrReceiverRowFactor.AddAdditionalCodeParameterPair(clsSjPlot, clsTempParamOne, iAdditionalPairNo:=1)
        clsTempParamOne.bIncludeArgumentName = False

        clsTempParamTwo = New RParameter("grp", 2)
        ucrReceiverColumnFactor.AddAdditionalCodeParameterPair(clsSjPlot, clsTempParamTwo, iAdditionalPairNo:=1)
        clsTempParamTwo.bIncludeArgumentName = False
        ucrSelectorTwoWayFrequencies.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("data", 0), iAdditionalPairNo:=1)
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("weight.by", 1), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjPlot, ucrChkWeights.GetParameter(), iAdditionalPairNo:=1)

        ucrReceiverRowFactor.SetRCode(clsSelect, bReset)
        ucrReceiverColumnFactor.SetRCode(clsSelect, bReset)
        ucrReceiverWeights.SetRCode(clsSjTab, bReset)
        ucrChkWeights.SetRCode(clsSjTab, bReset)
        ucrChkFlip.SetRCode(clsSjPlot, bReset)
        ucrPnlFreqType.SetRCode(clsSjPlot, bReset)
        ucrPnlFreqDisplay.SetRCode(clsSjTab, bReset)
        ucrSelectorTwoWayFrequencies.SetRCode(clsTableBaseOperator, bReset)
        ucrSelectorTwoWayFrequencies.SetRCode(clsSjPlot, bReset)
        ucrChkCell.SetRCode(clsSjTab, bReset)
        ucrChkColumn.SetRCode(clsSjTab, bReset)
        ucrChkRow.SetRCode(clsSjTab, bReset)
        ucrChkCount.SetRCode(clsSjTab, bReset)

    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If rdoTable.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsTableBaseOperator)
            'ucrBase.clsRsyntax.bHTMLOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        ElseIf rdoGraph.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjPlot)
            ' ucrBase.clsRsyntax.bHTMLOutput = False
            ucrBase.clsRsyntax.iCallType = 3
        End If
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverColumnFactor.IsEmpty() AndAlso Not ucrReceiverRowFactor.IsEmpty() Then
            If Not ucrChkWeights.Checked Then
                ucrBase.OKEnabled(True)
            Else
                If Not ucrReceiverWeights.IsEmpty Then
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnFactor.ControlContentsChanged, ucrReceiverRowFactor.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrChkWeights.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeights.ControlValueChanged
        If ucrChkWeights.Checked Then
            ucrReceiverWeights.SetMeAsReceiver()
        Else
            ucrReceiverRowFactor.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strGraph As String
        Dim strTempScript As String = ""

        If rdoBoth.Checked Then
            strGraph = clsSjPlot.ToScript(strTempScript)
            frmMain.clsRLink.RunScript(strTempScript & strGraph, iCallType:=3)
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgTwoWayFrequencies.SetRFunction(clsSjTab, clsSjPlot, bResetSubdialog)
        bResetSubdialog = False
        sdgTwoWayFrequencies.ShowDialog()
        ShowValueParameter()
        TestOkEnabled()
    End Sub

    Public Sub ShowValueParameter()
        If (sdgTwoWayFrequencies.ucrChkShowPercentage.Checked = False AndAlso sdgTwoWayFrequencies.ucrChkShowCount.Checked = False) Then
            ucrBase.clsRsyntax.AddParameter("show.values", "FALSE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("show.values")
        End If
    End Sub

    Private Sub ucrChkFlip_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFlip.ControlValueChanged, ucrPnlFreqDisplay.ControlValueChanged
        'Not functional- Meant to help on flipping the tables produced
        'If rdoTable.Checked AndAlso ucrChkFlip.Checked Then
        '    ucrReceiverRowFactor.ChangeParameterName("var.col")
        '    ucrReceiverRowFactor.SetParameterIsString()
        '    ucrReceiverRowFactor.bWithQuotes = False
        '    ucrReceiverRowFactor.SetParameterIncludeArgumentName(False)
        '    ucrReceiverColumnFactor.ChangeParameterName("var.row")
        '    ucrReceiverColumnFactor.SetParameterIsString()
        '    ucrReceiverColumnFactor.bWithQuotes = False
        '    ucrReceiverColumnFactor.SetParameterIncludeArgumentName(False)
        'ElseIf rdoTable.Checked AndAlso Not ucrChkFlip.Checked Then
        '    ucrReceiverRowFactor.ChangeParameterName("var.row")
        '    ucrReceiverRowFactor.SetParameterIsString()
        '    ucrReceiverRowFactor.bWithQuotes = False
        '    ucrReceiverRowFactor.SetParameterIncludeArgumentName(False)
        '    ucrReceiverColumnFactor.ChangeParameterName("var.col")
        '    ucrReceiverColumnFactor.SetParameterIsString()
        '    ucrReceiverColumnFactor.bWithQuotes = False
        '    ucrReceiverColumnFactor.SetParameterIncludeArgumentName(False)
        'Else

        'End If
    End Sub

    Private Sub ucrPnlFreqType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFreqDisplay.ControlValueChanged
        If rdoCell.Checked Then
            ucrBase.clsRsyntax.AddParameter("margin", Chr(34) & "cell" & Chr(34))
        ElseIf rdoColumn.Checked Then
            ucrBase.clsRsyntax.AddParameter("margin", Chr(34) & "col" & Chr(34))
        ElseIf rdoRow.Checked Then
            ucrBase.clsRsyntax.AddParameter("margin", Chr(34) & "row" & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("margin")
        End If
        changelocation()
    End Sub
    Private Sub changelocation()
        If rdoBoth.Checked Then
            grpFreqTypeTable.Location = New Point(240, 166)
            grpFreqTypeGraph.Location = New Point(358, 166)
            Me.Size = New Size(498, 411)
        Else
            grpFreqTypeTable.Location = New Point(263, 166)
            grpFreqTypeGraph.Location = New Point(263, 166)
            Me.Size = New Size(426, 411)
        End If
    End Sub
End Class