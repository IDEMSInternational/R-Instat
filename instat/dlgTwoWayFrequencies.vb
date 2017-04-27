﻿' Instat-R
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
    Private clsSjtXtab As New RFunction
    Private clsSjpXtab As New RFunction
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
        rdoCount.Enabled = False

        ucrReceiverColumnFactor.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverRowFactor.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverWeights.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverRowFactor.SetDataType("factor")
        ucrReceiverColumnFactor.SetDataType("factor")
        ucrReceiverWeights.SetDataType("numeric")

        ucrReceiverRowFactor.SetParameter(New RParameter("var.row", 0))
        ucrReceiverRowFactor.SetParameterIsRFunction()
        ucrReceiverColumnFactor.SetParameter(New RParameter("var.col", 1))
        ucrReceiverColumnFactor.SetParameterIsRFunction()

        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 2))
        ucrReceiverWeights.SetParameterIsRFunction()

        ucrPnlFreqType.SetParameter(New RParameter("margin", 3))
        ucrPnlFreqType.AddRadioButton(rdoRow, Chr(34) & "row" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoColumn, Chr(34) & "col" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoCell, Chr(34) & "cell" & Chr(34))
        ucrPnlFreqType.bAllowNonConditionValues = False

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

        ucrPnlFreqDisplay.AddFunctionNamesCondition(rdoTable, "sjt.xtab")
        ucrPnlFreqDisplay.AddFunctionNamesCondition(rdoGraph, "sjp.xtab")

        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkCount, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkRow, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkCell, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkColumn, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCell.SetLinkedDisplayControl(grpFrequencies)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrPnlFreqType, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqType.SetLinkedDisplayControl(grpFreqType)
    End Sub

    Private Sub SetDefaults()
        clsSjtXtab = New RFunction
        clsSjpXtab = New RFunction
        ucrSelectorTwoWayFrequencies.Reset()
        ucrReceiverRowFactor.SetMeAsReceiver()

        clsSjtXtab.SetRCommand("sjt.xtab")

        clsSjtXtab.AddParameter("show.obs", "TRUE")
        clsSjtXtab.AddParameter("show.summary", "FALSE")
        clsSjtXtab.AddParameter("digits", 0)
        clsSjpXtab.SetRCommand("sjp.xtab")
        clsSjpXtab.AddParameter("margin", Chr(34) & "row" & Chr(34))

        clsSjpXtab.AddParameter("show.prc", "TRUE")
        clsSjpXtab.AddParameter("show.n", "TRUE")
        clsSjpXtab.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoWayFrequencies.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsSjtXtab)
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverRowFactor.AddAdditionalCodeParameterPair(clsSjpXtab, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverColumnFactor.AddAdditionalCodeParameterPair(clsSjpXtab, New RParameter("grp", 1), iAdditionalPairNo:=1)
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjpXtab, New RParameter("weight.by", 1), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjpXtab, ucrChkWeights.GetParameter(), iAdditionalPairNo:=1)

        ucrReceiverRowFactor.SetRCode(clsSjtXtab, bReset)
        ucrReceiverColumnFactor.SetRCode(clsSjtXtab, bReset)
        ucrReceiverWeights.SetRCode(clsSjtXtab, bReset)
        ucrChkWeights.SetRCode(clsSjtXtab, bReset)
        ucrChkFlip.SetRCode(clsSjpXtab, bReset)

        ucrPnlFreqType.SetRCode(clsSjpXtab, bReset)
        ucrPnlFreqDisplay.SetRCode(clsSjtXtab, bReset)

        ucrChkCell.SetRCode(clsSjtXtab, bReset)
        ucrChkColumn.SetRCode(clsSjtXtab, bReset)
        ucrChkRow.SetRCode(clsSjtXtab, bReset)
        ucrChkCount.SetRCode(clsSjtXtab, bReset)
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If rdoTable.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjtXtab)
            'ucrBase.clsRsyntax.bHTMLOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        ElseIf rdoGraph.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpXtab)
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
            strGraph = clsSjpXtab.ToScript(strTempScript)
            frmMain.clsRLink.RunScript(strTempScript & strGraph, iCallType:=3)
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgTwoWayFrequencies.SetRFunction(clsSjtXtab, clsSjpXtab, bResetSubdialog)
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
End Class