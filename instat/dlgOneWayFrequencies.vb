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
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverOneWayFreq.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkGraph.SetRCode(clsSjpFrq, bReset)
        ucrChkTable.SetRCode(clsSjtFreq, bReset)

        ucrChkWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlSort.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkFlip.SetRCode(clsSjpFrq, bReset)
    End Sub

    Private Sub InitialiseDialog()
        'HelpID
        ' ucrBase.iHelpTopicID = 

        cmdOptions.Enabled = False
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

        ucrChkWeights.SetText("Weights")
        ucrChkWeights.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeights.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkGraph.SetText("Graph")
        ucrChkTable.SetText("Table")
        ucrChkTable.AddFunctionNamesCondition(True, "sjPlot::sjt.frq")
        'ucrChkGraph.AddFunctionNamesCondition(True, "sjPlot::sjp.frq")
        ucrChkGraph.AddToLinkedControls(ucrChkFlip, {True}, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetParameter(New RParameter("coord.flip", 1))
        ucrChkFlip.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlip.SetRDefault("FALSE")

        ucrSaveGraph.SetPrefix("one_way_freq")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorOneWayFreq.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()

    End Sub

    Private Sub SetDefaults()
        clsSjtFreq = New RFunction
        clsSjpFrq = New RFunction
        ucrSelectorOneWayFreq.Reset()
        ucrReceiverOneWayFreq.SetParameter(New RParameter("data", 1))
        ucrReceiverOneWayFreq.SetParameterIsRFunction()
        clsSjtFreq.SetRCommand("sjPlot::sjt.frq")
        clsSjtFreq.AddParameter("sort.frq", Chr(34) & "none" & Chr(34))
        clsSjpFrq.SetRCommand("sjPlot::sjp.frq")
        ' clsSjpFrq.AddParameter("coord.flip", "FALSE")
        clsSjpFrq.AddParameter("sort.frq", Chr(34) & "none" & Chr(34))
        clsSjpFrq.SetAssignTo("onevar_graph", strTempDataframe:=ucrSelectorOneWayFreq.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="onevar_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsSjtFreq)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverOneWayFreq.IsEmpty() Then
            If (Not ucrChkWeights.Checked) Then
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

    Public Sub ICallType()
        If ucrChkTable.Checked Then
            ' ucrBase.clsRsyntax.bHTMLOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        ElseIf ucrChkGraph.Checked
            ' ucrBase.clsRsyntax.bHTMLOutput = False
            ucrBase.clsRsyntax.iCallType = 3
        Else 'temporary fix to ensure graphs are displayed in the output window before a wrapper for displaying both tables and graphs at the same time on the output window is implemented
            ucrBase.clsRsyntax.iCallType = 3
        End If
    End Sub

    Private Sub ChangeBaseFunction()
        If ucrChkTable.Checked Then
            ucrReceiverOneWayFreq.SetParameter(New RParameter("data", 1))
            ucrReceiverOneWayFreq.SetParameterIsRFunction()
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjtFreq)
        ElseIf ucrChkGraph.Checked Then
            ucrReceiverOneWayFreq.SetParameter(New RParameter("var.cnt", 1))
            ucrReceiverOneWayFreq.SetParameterIsRFunction()
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpFrq)
            ucrSaveGraph.SetAssignToIfUncheckedValue("onevar_graph")
        Else
            ucrReceiverOneWayFreq.SetParameter(New RParameter("var.cnt", 1))
            ucrReceiverOneWayFreq.SetParameterIsRFunction()
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpFrq)
            ucrSaveGraph.SetAssignToIfUncheckedValue("onevar_graph")
        End If
        SetRCodeForControls(False)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeights.ControlValueChanged
        If ucrChkWeights.Checked Then
            ucrReceiverWeights.SetMeAsReceiver()
        Else
            ucrReceiverOneWayFreq.SetMeAsReceiver()
        End If
    End Sub

    Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTable.ControlValueChanged, ucrChkGraph.ControlValueChanged
        ChangeBaseFunction()
        ICallType()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneWayFreq.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrChkWeights.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class