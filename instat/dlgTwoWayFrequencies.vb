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
    Private clsSjPlot As New RFunction
    Private clsSjTab As New RFunction

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
        ' ucrBase.iHelpTopicID = 

        ucrReceiverColumnFactor.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverRowFactor.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverWeights.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverRowFactor.SetDataType("factor")
        ucrReceiverColumnFactor.SetDataType("factor")
        ucrReceiverWeights.SetDataType("numeric")

        ucrReceiverRowFactor.SetParameter(New RParameter("var.row", 0))
        ucrReceiverRowFactor.SetParameterIsString()
        ucrReceiverRowFactor.SetParameterIncludeArgumentName(False)

        ucrReceiverColumnFactor.SetParameter(New RParameter("var.col", 1))
        ucrReceiverColumnFactor.SetParameterIsString()
        ucrReceiverColumnFactor.SetParameterIncludeArgumentName(False)

        ucrSelectorTwoWayFrequencies.SetParameter(New RParameter("data"))
        ucrSelectorTwoWayFrequencies.SetParameterIsrfunction()
        ucrSelectorTwoWayFrequencies.SetParameterIncludeArgumentName(False)

        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 2))
        ucrReceiverWeights.SetParameterIsRFunction()

        ucrPnlFreqType.SetParameter(New RParameter("fun", 3))
        ucrPnlFreqType.AddRadioButton(rdoCount, Chr(34) & "grpfrq" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoRow, Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoColumn, Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoCell, Chr(34) & "xtab" & Chr(34))

        'ucrPnlFreqType.AddParameterPresentCondition(rdoCount, "fun")
        'ucrPnlFreqType.AddParameterPresentCondition(rdoCell, "fun")
        'ucrPnlFreqType.AddParameterPresentCondition(rdoCell, "margin")
        'ucrPnlFreqType.AddParameterPresentCondition(rdoColumn, "fun")
        'ucrPnlFreqType.AddParameterPresentCondition(rdoColumn, "margin")
        'ucrPnlFreqType.AddParameterPresentCondition(rdoRow, "fun")
        'ucrPnlFreqType.AddParameterPresentCondition(rdoRow, "margin")

        ' ucrPnlFreqDisplay.AddParameterPresentCondition(rdoGraph, "fun")

        ucrChkRow.SetParameter(New RParameter("show.row.prc", 4), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkRow.SetText("Row (%)")
        ucrChkRow.SetRDefault("FALSE")

        ucrChkCount.SetParameter(New RParameter("show.obs", 5), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkCount.SetText("Count")
        ucrChkCount.SetRDefault("TRUE")

        ucrChkColumn.SetParameter(New RParameter("show.col.prc", 6), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkColumn.SetText("Column (%)")
        ucrChkColumn.SetRDefault("FALSE")

        ucrChkCell.SetParameter(New RParameter("show.cell.prc", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkCell.SetText("Cell (%)")
        ucrChkCell.SetRDefault("FALSE")

        ucrChkWeights.SetText("Weights")
        ucrChkWeights.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeights.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkFlip.SetParameter(New RParameter("coord.flip", 3), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetRDefault("FALSE")

        ucrPnlFreqDisplay.AddRadioButton(rdoTable)
        ucrPnlFreqDisplay.AddRadioButton(rdoGraph)

        ucrPnlFreqDisplay.AddFunctionNamesCondition(rdoTable, "sjtab")
        ucrPnlFreqDisplay.AddFunctionNamesCondition(rdoGraph, "sjplot")

        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkCount, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkRow, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkCell, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkColumn, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrPnlFreqType, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoCount)

    End Sub

    Private Sub SetDefaults()
        clsSjTab = New RFunction
        clsSjPlot = New RFunction

        clsSjTab.AddParameter("fun", Chr(34) & "xtab" & Chr(34))

        ucrSelectorTwoWayFrequencies.Reset()
        ucrReceiverRowFactor.SetMeAsReceiver()

        clsSjTab.SetRCommand("sjtab")
        clsSjTab.AddParameter("show.obs", "TRUE")
        clsSjTab.AddParameter("show.summary", "FALSE")
        clsSjTab.AddParameter("digits", 0)
        clsSjPlot.SetRCommand("sjplot")

        clsSjPlot.AddParameter("show.prc", "TRUE")
        clsSjPlot.AddParameter("show.n", "TRUE")
        clsSjPlot.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoWayFrequencies.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsSjTab)
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        Dim clsTempParamOne As RParameter
        Dim clsTempParamTwo As RParameter
        Dim clsTempParamData As RParameter

        clsTempParamOne = New RParameter("x", 0)
        ucrReceiverRowFactor.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("clsTempParamOne", 0), iAdditionalPairNo:=1)
        clsTempParamOne.bIncludeArgumentName = False

        clsTempParamTwo = New RParameter("grp", 0)
        ucrReceiverColumnFactor.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("clsTempParamTwo", 1), iAdditionalPairNo:=1)
        clsTempParamTwo.bIncludeArgumentName = False

        clsTempParamData = New RParameter("data", 0)
        ucrSelectorTwoWayFrequencies.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("clsTempParamData", 1), iAdditionalPairNo:=1)
        clsTempParamTwo.bIncludeArgumentName = False

        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("weight.by", 1), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjPlot, ucrChkWeights.GetParameter(), iAdditionalPairNo:=1)

        ucrReceiverRowFactor.SetRCode(clsSjTab, bReset)
        ucrReceiverColumnFactor.SetRCode(clsSjTab, bReset)

        ucrReceiverWeights.SetRCode(clsSjTab, bReset)
        ucrChkWeights.SetRCode(clsSjTab, bReset)
        ucrChkFlip.SetRCode(clsSjPlot, bReset)
        ucrPnlFreqType.SetRCode(clsSjPlot, bReset)
        ucrPnlFreqDisplay.SetRCode(clsSjTab, bReset)
        ucrSelectorTwoWayFrequencies.SetRCode(clsSjTab, bReset)
        ucrChkCell.SetRCode(clsSjTab, bReset)
        ucrChkColumn.SetRCode(clsSjTab, bReset)
        ucrChkRow.SetRCode(clsSjTab, bReset)
        ucrChkCount.SetRCode(clsSjTab, bReset)
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If rdoTable.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjTab)
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

        If rdoTable.Checked AndAlso rdoGraph.Checked Then
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

    Private Sub ucrChkFlip_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFlip.ControlValueChanged
        'If rdoTable.Checked AndAlso ucrChkFlip.Checked Then
        '    ucrReceiverRowFactor.ChangeParameterName("var.col", 1)
        '    ucrReceiverRowFactor.SetParameterIncludeArgumentName(False)
        '    ucrReceiverColumnFactor.ChangeParameterName("var.row", 0)
        '    ucrReceiverColumnFactor.SetParameterIncludeArgumentName(False)
        'ElseIf rdoTable.Checked AndAlso Not ucrChkFlip.Checked Then
        '    ucrReceiverRowFactor.ChangeParameterName("var.row", 0)
        '    ucrReceiverRowFactor.SetParameterIncludeArgumentName(False)
        '    ucrReceiverColumnFactor.ChangeParameterName("var.col", 1)
        '    ucrReceiverColumnFactor.SetParameterIncludeArgumentName(False)
        'End If
    End Sub

    Private Sub ucrPnlFreqType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFreqType.ControlValueChanged, ucrPnlFreqDisplay.ControlValueChanged
        If rdoCell.Checked Then
            ucrBase.clsRsyntax.AddParameter("margin", Chr(34) & "cell" & Chr(34))
        ElseIf rdoColumn.Checked Then
            ucrBase.clsRsyntax.AddParameter("margin", Chr(34) & "col" & Chr(34))
        ElseIf rdoRow.Checked Then
            ucrBase.clsRsyntax.AddParameter("margin", Chr(34) & "row" & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("margin")
        End If
    End Sub
End Class