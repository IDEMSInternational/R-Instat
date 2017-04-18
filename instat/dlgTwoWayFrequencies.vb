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
    Private clsVariablesList As New RFunction
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

        ucrReceiverRowFactor.SetParameter(New RParameter("x", 0))
        ucrReceiverRowFactor.SetParameterIsRFunction()
        ucrReceiverColumnFactor.SetParameter(New RParameter("grp", 1))
        ucrReceiverColumnFactor.SetParameterIsRFunction()

        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 2))
        ucrReceiverWeights.SetParameterIsRFunction()

        ucrPnlFreqType.SetParameter(New RParameter("fun", 3))
        ucrPnlFreqType.AddRadioButton(rdoCount, Chr(34) & "grpfrq" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoRow, Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoColumn, Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoCell, Chr(34) & "xtab" & Chr(34))
        'ucrPnlFreqType.bAllowNonConditionValues = False

        ucrPnlFreqType.AddParameterPresentCondition(rdoCount, "grpfrq")
        ucrPnlFreqType.AddParameterPresentCondition(rdoCell, "fun")
        ucrPnlFreqType.AddParameterPresentCondition(rdoCell, "margin")
        ucrPnlFreqType.AddParameterPresentCondition(rdoColumn, "fun")
        ucrPnlFreqType.AddParameterPresentCondition(rdoColumn, "margin")
        ucrPnlFreqType.AddParameterPresentCondition(rdoRow, "fun")
        ucrPnlFreqType.AddParameterPresentCondition(rdoRow, "margin")


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
        ucrChkCell.SetLinkedDisplayControl(grpFrequencies)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrPnlFreqType, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqType.SetLinkedDisplayControl(grpFreqType)
    End Sub

    Private Sub SetDefaults()
        clsSjTab = New RFunction
        clsSjPlot = New RFunction
        clsVariablesList = New RFunction

        ucrSelectorTwoWayFrequencies.SetParameter(New RParameter("data"))
        ucrSelectorTwoWayFrequencies.SetParameterIsString()

        clsVariablesList.SetRCommand("c")
        clsVariablesList.AddParameter(ucrReceiverRowFactor.GetVariableNames, bIncludeArgumentName:=False)
        clsVariablesList.AddParameter(ucrReceiverRowFactor.GetVariableNames, bIncludeArgumentName:=False)
        clsSjPlot.AddParameter(clsRFunctionParameter:=clsVariablesList)
        clsSjTab.AddParameter(clsRFunctionParameter:=clsVariablesList)
        'temp
        clsSjTab.AddParameter("fun", Chr(34) & "xtab" & Chr(34))
        ucrSelectorTwoWayFrequencies.Reset()
        ucrReceiverRowFactor.SetMeAsReceiver()

        ucrSelectorTwoWayFrequencies.SetParameter(New RParameter("data"))
        ucrSelectorTwoWayFrequencies.SetParameterIsrfunction()

        clsSjTab.SetRCommand("sjtab")

        clsSjTab.AddParameter("show.obs", "TRUE")
        clsSjTab.AddParameter("show.summary", "FALSE")
        clsSjTab.AddParameter("digits", 0)
        clsSjPlot.SetRCommand("sjplot")
        clsSjPlot.AddParameter("margin", Chr(34) & "row" & Chr(34))

        clsSjPlot.AddParameter("show.prc", "TRUE")
        clsSjPlot.AddParameter("show.n", "TRUE")
        clsSjPlot.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoWayFrequencies.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsSjTab)
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        'ucrReceiverRowFactor.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("x", 0), iAdditionalPairNo:=1)
        'ucrReceiverColumnFactor.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("grp", 1), iAdditionalPairNo:=1)
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("weight.by", 1), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjPlot, ucrChkWeights.GetParameter(), iAdditionalPairNo:=1)
        'ucrSelectorTwoWayFrequencies.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("data"), iAdditionalPairNo:=1)
        ucrReceiverRowFactor.SetRCode(clsVariablesList, bReset)
        ucrReceiverColumnFactor.SetRCode(clsVariablesList, bReset)
        ucrReceiverWeights.SetRCode(clsSjTab, bReset)
        ucrChkWeights.SetRCode(clsSjTab, bReset)
        ucrChkFlip.SetRCode(clsSjPlot, bReset)

        ucrPnlFreqType.SetRCode(clsSjPlot, bReset)
        ucrPnlFreqDisplay.SetRCode(clsSjTab, bReset)

        ucrSelectorTwoWayFrequencies.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
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
        If rdoTable.Checked AndAlso ucrChkFlip.Checked Then
            ucrReceiverRowFactor.ChangeParameterName("var.col", 1)
            ucrReceiverColumnFactor.ChangeParameterName("var.row", 0)
        ElseIf rdoTable.Checked AndAlso Not ucrChkFlip.Checked Then
            ucrReceiverRowFactor.ChangeParameterName("var.row", 0)
            ucrReceiverColumnFactor.ChangeParameterName("var.col", 1)
        End If
    End Sub

    Private Sub ucrPnlFreqType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFreqType.ControlValueChanged
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