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

Public Class dlgOneWayFrequencies
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsSjtFreq As New RFunction
    Private clsSjpFrq As New RFunction
    Private Sub dlgOneWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrReceiverOneWayFreq.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlFreqDisplay.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrChkWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrPnlSort.SetRCode(clsSjtFreq, bReset)
        ucrChkFlip.SetRCode(clsSjpFrq, bReset)
    End Sub

    Private Sub InitialiseDialog()
        'HelpID
        ' ucrBase.iHelpTopicID = 
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrReceiverOneWayFreq.Selector = ucrSelectorOneWayFreq
        ucrReceiverOneWayFreq.SetMeAsReceiver()
        ucrReceiverOneWayFreq.SetParameter(New RParameter("data", 1))
        ucrReceiverOneWayFreq.SetParameterIsRFunction()

        ucrReceiverWeights.Selector = ucrSelectorOneWayFreq
        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 3))
        ucrReceiverWeights.SetParameterIsRFunction()
        ucrReceiverWeights.SetDataType("numeric")

        ucrPnlSort.SetParameter(New RParameter("sort.frq", 2))
        ucrPnlSort.AddRadioButton(rdoNone, Chr(34) & "none" & Chr(34))
        ucrPnlSort.AddRadioButton(rdoAscending, Chr(34) & "asc" & Chr(34))
        ucrPnlSort.AddRadioButton(rdoDescending, Chr(34) & "desc" & Chr(34))
        ucrPnlSort.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrPnlFreqDisplay.AddRadioButton(rdoTable)
        ucrPnlFreqDisplay.AddRadioButton(rdoGraph)

        ucrPnlFreqDisplay.AddFunctionNamesCondition(rdoTable, "sjPlot::sjt.frq")
        ucrPnlFreqDisplay.AddFunctionNamesCondition(rdoGraph, "sjPlot::sjp.frq")

        ucrChkWeights.SetText("Weights")
        ucrChkWeights.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeights.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetParameter(New RParameter("coord.flip"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkFlip.SetRDefault("FALSE")
    End Sub

    Private Sub SetDefaults()
        clsSjtFreq = New RFunction
        clsSjpFrq = New RFunction
        ucrSelectorOneWayFreq.Reset()
        ucrReceiverOneWayFreq.SetParameter(New RParameter("data", 1))
        ucrReceiverOneWayFreq.SetParameterIsRFunction()
        clsSjtFreq.SetRCommand("sjPlot::sjt.frq")
        clsSjtFreq.AddParameter("data", clsRFunctionParameter:=ucrReceiverOneWayFreq.GetVariables)
        clsSjtFreq.AddParameter("sort.frq", Chr(34) & "none" & Chr(34))
        clsSjpFrq.SetRCommand("sjPlot::sjp.frq")
        clsSjpFrq.AddParameter("var.cnt", clsRFunctionParameter:=ucrReceiverOneWayFreq.GetVariables)
        ucrBase.clsRsyntax.SetBaseRFunction(clsSjtFreq)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverOneWayFreq.IsEmpty() Then
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
        If rdoTable.Checked Then
            ucrReceiverOneWayFreq.SetParameter(New RParameter("data", 1))
            ucrReceiverOneWayFreq.SetParameterIsRFunction()
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjtFreq)
        ElseIf rdoGraph.Checked Then
            ucrReceiverOneWayFreq.SetParameter(New RParameter("var.cnt", 1))
            ucrReceiverOneWayFreq.SetParameterIsRFunction()
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpFrq)
        End If
        SetRCodeForControls(False)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFreqDisplay.ControlValueChanged
        ChangeBaseFunction()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneWayFreq.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class