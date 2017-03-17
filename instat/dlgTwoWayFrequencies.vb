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
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverRowFactor.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverColumnFactor.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkWeights.SetRCode(clsSjpXtab, bReset)
        ucrChkWeights.SetRCode(clsSjtXtab, bReset)
        ucrPnlFrequencies.SetRCode(clsSjpXtab, bReset)

        ucrChkTable.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkGraph.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrChkFlip.SetRCode(clsSjpXtab, bReset)

        ucrChkCell.SetRCode(clsSjtXtab, bReset)
        ucrChkColumn.SetRCode(clsSjtXtab, bReset)
        ucrChkCount.SetRCode(clsSjtXtab, bReset)
        ucrChkRow.SetRCode(clsSjtXtab, bReset)

    End Sub

    Private Sub InitialiseDialog()
        'HelpID
        ' ucrBase.iHelpTopicID = 
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrReceiverColumnFactor.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverRowFactor.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverWeights.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverRowFactor.SetDataType("factor")
        ucrReceiverColumnFactor.SetDataType("factor")
        ucrReceiverWeights.SetDataType("numeric")
        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 2))
        ucrReceiverWeights.SetParameterIsRFunction()

        ucrChkGraph.SetText("Graph")
        ucrPnlFrequencies.SetParameter(New RParameter("margin", 3))
        ucrPnlFrequencies.AddRadioButton(rdoRow, Chr(34) & "row" & Chr(34))
        ucrPnlFrequencies.AddRadioButton(rdoColumn, Chr(34) & "col" & Chr(34))
        ucrPnlFrequencies.AddRadioButton(rdoCell, Chr(34) & "cell" & Chr(34))

        ucrChkTable.SetText("Table")
        ucrChkCount.SetText("Count")
        ucrChkCount.SetParameter(New RParameter("show.obs"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkCount.SetRDefault("FALSE")

        ucrChkRow.SetText("Row (%)")
        ucrChkRow.SetParameter(New RParameter("show.row.prc"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkRow.SetRDefault("FALSE")

        ucrChkColumn.SetText("Column (%)")
        ucrChkColumn.SetParameter(New RParameter("show.col.prc"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkColumn.SetRDefault("FALSE")

        ucrChkCell.SetText("Cell (%)")
        ucrChkCell.SetParameter(New RParameter("show.cell.prc"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkCell.SetRDefault("FALSE")

        ucrChkWeights.SetText("Weights")
        ucrChkWeights.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeights.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetParameter(New RParameter("coord.flip", 3), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkFlip.SetRDefault("FALSE")

        ucrChkTable.AddFunctionNamesCondition(True, "sjPlot::sjt.xtab")
        ucrChkTable.AddToLinkedControls(ucrChkCount, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        ucrChkTable.AddToLinkedControls(ucrChkRow, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTable.AddToLinkedControls(ucrChkCell, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTable.AddToLinkedControls(ucrChkColumn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkRow.SetLinkedDisplayControl(grpFreq)
        ucrChkGraph.AddToLinkedControls(ucrPnlFrequencies, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencies.SetLinkedDisplayControl(grpFrequencies)
    End Sub

    Private Sub SetDefaults()
        clsSjtXtab = New RFunction
        clsSjpXtab = New RFunction
        ucrSelectorTwoWayFrequencies.Reset()
        ucrReceiverRowFactor.SetParameter(New RParameter("var.row", 0))
        ucrReceiverRowFactor.SetParameterIsRFunction()
        ucrReceiverRowFactor.SetMeAsReceiver()
        ucrReceiverColumnFactor.SetParameter(New RParameter("var.col", 1))
        ucrReceiverColumnFactor.SetParameterIsRFunction()
        clsSjtXtab.SetRCommand("sjPlot::sjt.xtab")
        clsSjtXtab.AddParameter("var.row", clsRFunctionParameter:=ucrReceiverRowFactor.GetVariables)
        clsSjtXtab.AddParameter("var.col", clsRFunctionParameter:=ucrReceiverColumnFactor.GetVariables)
        clsSjtXtab.AddParameter("show.obs", "TRUE")
        clsSjpXtab.SetRCommand("sjPlot::sjp.xtab")
        clsSjpXtab.AddParameter("x", clsRFunctionParameter:=ucrReceiverRowFactor.GetVariables)
        clsSjpXtab.AddParameter("grp", clsRFunctionParameter:=ucrReceiverColumnFactor.GetVariables)
        clsSjpXtab.AddParameter("margin", Chr(34) & "row" & Chr(34))
        ucrBase.clsRsyntax.SetBaseRFunction(clsSjtXtab)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverRowFactor.IsEmpty() AndAlso Not ucrReceiverColumnFactor.IsEmpty Then
            If ucrChkWeights.Checked Then
                If Not ucrReceiverWeights.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ChangeBaseFunction()
        If ucrChkTable.Checked Then
            ucrReceiverRowFactor.SetParameter(New RParameter("var.row", 0))
            ucrReceiverRowFactor.SetParameterIsRFunction()
            ucrReceiverColumnFactor.SetParameter(New RParameter("var.col", 1))
            ucrReceiverColumnFactor.SetParameterIsRFunction()
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjtXtab)
        ElseIf ucrChkGraph.Checked Then
            ucrReceiverRowFactor.SetParameter(New RParameter("x", 0))
            ucrReceiverRowFactor.SetParameterIsRFunction()
            ucrReceiverColumnFactor.SetParameter(New RParameter("grp", 1))
            ucrReceiverColumnFactor.SetParameterIsRFunction()
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpXtab)
        End If
        SetRCodeForControls(False)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    'Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
    '    If ucrChkTable.Checked Then
    '        frmMain.clsRLink.RunScript(clsSjtFreq.ToScript(), iCallType:=2)
    '    End If
    'End Sub

    Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTable.ControlValueChanged, ucrChkGraph.ControlValueChanged
        ChangeBaseFunction()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnFactor.ControlContentsChanged, ucrReceiverRowFactor.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrChkWeights.ControlContentsChanged, ucrChkTable.ControlContentsChanged, ucrChkGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class
