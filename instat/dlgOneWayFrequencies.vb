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
        ucrChkGraph.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkTable.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrChkWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlSort.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkFlip.SetRCode(clsSjpFrq, bReset)

        ucrNudGroups.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkGroupData.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

    End Sub

    Private Sub InitialiseDialog()
        'HelpID
        ' ucrBase.iHelpTopicID = 

        cmdOptions.Enabled = True
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
        ucrChkTable.AddFunctionNamesCondition(True, "sjt.frq")
        'ucrChkGraph.AddFunctionNamesCondition(True, "sjp.frq")
        ucrChkGraph.AddToLinkedControls(ucrChkFlip, {True}, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrChkGroupData.SetText("Group Data")
        ucrNudGroups.SetMinMax(2, 100)
        ucrNudGroups.Increment = 5

        ucrNudGroups.SetParameter(New RParameter("auto.group"))
        ucrChkGroupData.SetParameter(ucrNudGroups.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkGroupData.AddToLinkedControls(ucrNudGroups, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)

        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetParameter(New RParameter("coord.flip", 1))
        ucrChkFlip.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlip.SetRDefault("FALSE")
    End Sub

    Private Sub SetDefaults()
        clsSjtFreq = New RFunction
        clsSjpFrq = New RFunction
        ucrSelectorOneWayFreq.Reset()
        sdgOneWayFrequencies.ucrSaveGraph.Reset()
        sdgOneWayFrequencies.ucrInputGraphTitle.SetName("")
        sdgOneWayFrequencies.ucrInputHorizontalLabels.Reset()
        sdgOneWayFrequencies.ucrInputVerticalLabels.Reset()
        ucrReceiverOneWayFreq.SetParameter(New RParameter("data", 1))
        ucrReceiverOneWayFreq.SetParameterIsRFunction()
        clsSjtFreq.SetRCommand("sjt.frq")
        clsSjtFreq.AddParameter("sort.frq", Chr(34) & "none" & Chr(34))
        'parameter added to have the default to False (R default is TRUE)
        clsSjtFreq.AddParameter("show.summary", "FALSE")
        clsSjtFreq.AddParameter("skip.zero", "FALSE")
        'defining the digit default value
        clsSjtFreq.AddParameter("digits", 0)

        clsSjpFrq.SetRCommand("sjp.frq")
        clsSjpFrq.AddParameter("sort.frq", Chr(34) & "none" & Chr(34))
        clsSjpFrq.AddParameter("type", Chr(34) & "bar" & Chr(34))
        clsSjpFrq.AddParameter("vjust", Chr(34) & "bottom" & Chr(34))
        clsSjpFrq.AddParameter("hjust", Chr(34) & "center" & Chr(34))
        'parameter added to have the check box checked on default
        clsSjpFrq.AddParameter("show.prc", "TRUE")
        'parameter added to have the default to False (R default is TRUE)
        clsSjpFrq.AddParameter("show.n", "FALSE")
        clsSjpFrq.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorOneWayFreq.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsSjtFreq)
        bResetSubdialog = True

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
        End If
        If ucrChkGraph.Checked Then
            ' ucrBase.clsRsyntax.bHTMLOutput = False
            ucrBase.clsRsyntax.iCallType = 3
        End If
        If Not (ucrChkGraph.Checked AndAlso ucrChkTable.Checked) Then 'temporary fix to ensure graphs are displayed in the output window before a wrapper for displaying both tables and graphs at the same time on the output window is implemented
            ucrBase.clsRsyntax.iCallType = 3
        End If
    End Sub

    Private Sub ChangeBaseFunction()
        If ucrChkTable.Checked Then
            ucrReceiverOneWayFreq.SetParameter(New RParameter("data", 1))
            ucrReceiverOneWayFreq.SetParameterIsRFunction()
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjtFreq)
        End If
        If ucrChkGraph.Checked Then
            ucrReceiverOneWayFreq.SetParameter(New RParameter("var.cnt", 1))
            ucrReceiverOneWayFreq.SetParameterIsRFunction()
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpFrq)
        End If

        If ucrChkGraph.Checked = False AndAlso ucrChkTable.Checked = False Then
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

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        ' Link the base function to the sub dialog
        sdgOneWayFrequencies.SetRFunction(clsSjtFreq, clsSjpFrq, bResetSubdialog)
        bResetSubdialog = False
        sdgOneWayFrequencies.ShowDialog()
        TestOkEnabled()
    End Sub
End Class