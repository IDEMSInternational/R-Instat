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
Public Class dlgFrequency
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private Sub dlgFrequency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub SetDefaults()
        ucrReceiverFactors.SetMeAsReceiver()
        ucrFactorsSelector.Reset()
        TestOkEnabled()
        ucrchkCounts.Checked = True
        ucrchkCheckDisplayMargins.Checked = True
        ' cmdOptions.Enabled = False
        ucrNudColumnFactors.Value = 1
        ucrNudDecimals.Value = 0
    End Sub

    Private Sub InitialiseDialog()
        ucrSingleReceiver.Selector = ucrFactorsSelector
        ucrReceiverFactors.Selector = ucrFactorsSelector
        ucrReceiverSingle.Selector = ucrFactorsSelector
        ucrReceiverFactors.SetDataType("factor")
        ucrReceiverSingle.SetDataType("numeric")
        ucrSingleReceiver.SetDataType("factor")
        ucrchkWeights.SetText("Weights")
        ucrchkCheckDisplayMargins.SetText("Display Margins")
        ucrchkCounts.SetText("Counts")
        ucrchkOverallPercentages.SetText("Overall Percentages")
        ucrchkPercentagesOf.SetText("Percentages of")

        ucrchkWeights.AddToLinkedControls(ucrReceiverSingle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrchkPercentagesOf.AddToLinkedControls(ucrSingleReceiver, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrNudColumnFactors.SetMinMax(0, frmMain.clsRLink.GetDataFrameLength(ucrFactorsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text))
        ucrNudDecimals.SetMinMax(0, 5)

    End Sub
    Private Sub UpdateReceiver()
        If ucrchkWeights.Checked Then
            ucrReceiverSingle.SetMeAsReceiver()
        ElseIf ucrchkPercentagesOf.Checked Then
            ucrSingleReceiver.SetMeAsReceiver()
        Else
            ucrReceiverFactors.SetMeAsReceiver()
        End If
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverFactors.IsEmpty AndAlso (Not ucrchkWeights.Checked OrElse (ucrchkWeights.Checked AndAlso Not ucrSingleReceiver.IsEmpty)) AndAlso (ucrchkCounts.Checked OrElse ucrchkOverallPercentages.Checked OrElse (ucrchkPercentagesOf.Checked AndAlso Not ucrSingleReceiver.IsEmpty)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub ucrchkWeights_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSingle.ControlContentsChanged, ucrReceiverFactors.ControlContentsChanged, ucrSingleReceiver.ControlContentsChanged, ucrchkWeights.ControlContentsChanged, ucrchkPercentagesOf.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgFrequency.ShowDialog()
    End Sub

    Private Sub ucrchkOverallPercentages_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrchkWeights.ControlValueChanged, ucrchkPercentagesOf.ControlValueChanged
        UpdateReceiver()
    End Sub

End Class