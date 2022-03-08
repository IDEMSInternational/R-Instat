' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgRandomSplit
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True


    Private Sub dlgRandomSplit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrPnlRandomSplit.AddRadioButton(rdoSample)
        ucrPnlRandomSplit.AddRadioButton(rdoTimeSeries)
        ucrPnlRandomSplit.AddFunctionNamesCondition(rdoSample, {"scale", "na.omit"})
        ucrPnlRandomSplit.AddFunctionNamesCondition(rdoTimeSeries, {"dist", "as.matrix"})

        ucrReceiverRandomSplit.SetParameterIsRFunction()
        'ucrReceiverRandomSplit.Selector = ucrSelectorRandomSplit
        ucrReceiverRandomSplit.SetMeAsReceiver()
        ucrReceiverRandomSplit.SetDataType("numeric")

        ucrSelectorRandomSplit.SetParameterIsRFunction()

        ucrChkStratifyingFactor.SetText("Set Seed")

        ucrChkLog.SetText("Log")
        ucrChkLog.AddToLinkedControls(ucrNudLog, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Default")

        ucrChkTestingData.SetText("Save Testing Data")

        ucrChkTrainingData.SetText("Save Training Data")

        ucrNudFraction.SetLinkedDisplayControl(lblFraction)

        ucrNudPool.SetLinkedDisplayControl(lblPool)
    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub
End Class