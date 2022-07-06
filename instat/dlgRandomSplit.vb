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
    Private clsInitialTimeSplit As RFunction
    Private clsInitialSplit As New RFunction
    Private clsTraining As RFunction
    Private clsDummyFunction As RFunction
    Private clsTesting As RFunction

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
        ucrReceiverRanSplit.SetParameter(New RParameter("strata", 2))
        ucrReceiverRanSplit.Selector = ucrSelectorRandomSplit
        ucrReceiverRanSplit.SetMeAsReceiver()
        ucrReceiverRanSplit.SetDataType("factor")
        ucrReceiverRanSplit.SetLinkedDisplayControl(lblReceiverRandomSplit)
        ucrReceiverRanSplit.SetParameterIsString()

        ucrSelectorRandomSplit.SetParameter(New RParameter("data", 0))
        ucrSelectorRandomSplit.SetParameterIsrfunction()

        ucrChkStratifyingFactor.SetText("Stratifying Factor")
        ucrChkStratifyingFactor.SetParameter(New RParameter("check"))
        ucrChkStratifyingFactor.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStratifyingFactor.AddToLinkedControls(ucrNudPool, {True}, bNewLinkedHideIfParameterMissing:=True)
        'ucrChkStratifyingFactor.AddToLinkedControls(ucrReceiverRanSplit, {True}, bNewLinkedHideIfParameterMissing:=True)


        ucrChkLag.SetText("Lag")
        ucrNudLag.SetParameter(New RParameter("lag", 3))
        ucrNudLag.SetMinMax(-100, 100)
        ucrChkLag.AddToLinkedControls(ucrNudLag, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        ucrChkTestingData.SetText("Save Testing Data")
        ucrChkTestingData.SetParameter(New RParameter("testing", 0))
        ucrChkTestingData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkTrainingData.SetText("Save Training Data")
        ucrChkTrainingData.SetParameter(New RParameter("training", 0))
        ucrChkTrainingData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrSaveRandomSplit.SetLabelText("Save sample to:")
        ucrSaveRandomSplit.SetSaveTypeAsDataFrame()
        ucrSaveRandomSplit.SetDataFrameSelector(ucrSelectorRandomSplit.ucrAvailableDataFrames)
        ucrSaveRandomSplit.SetPrefix("training")
        ucrSaveRandomSplit.SetIsComboBox()

        ucrNudBreaks.SetLinkedDisplayControl(lblBreaks)
        ucrNudBreaks.SetParameter(New RParameter("breaks", 4))

        ucrNudFraction.SetLinkedDisplayControl(lblFraction)
        ucrNudFraction.SetParameter(New RParameter("prop", 1))
        ucrNudFraction.SetMinMax(0.01, 0.99)
        ucrNudFraction.DecimalPlaces = 2
        ucrNudFraction.Increment = 0.01

        ucrNudPool.SetLinkedDisplayControl(lblPool)
        ucrNudPool.SetParameter(New RParameter("pool", 5))
        ucrNudPool.DecimalPlaces = 2
        ucrNudPool.SetMinMax(0.00, 0.15)
        ucrNudPool.Increment = 0.01

        ucrPnlRandomSplit.AddRadioButton(rdoSample)
        ucrPnlRandomSplit.AddRadioButton(rdoTimeSeries)
        ucrPnlRandomSplit.AddFunctionNamesCondition(rdoSample, {"initial_split", "training", "testing"})
        ucrPnlRandomSplit.AddFunctionNamesCondition(rdoTimeSeries, {"initial_time_split", "training", "testing"})
        ucrPnlRandomSplit.AddToLinkedControls(ucrChkStratifyingFactor, {rdoSample}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlRandomSplit.AddToLinkedControls({ucrChkStratifyingFactor, ucrNudBreaks}, {rdoSample}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlRandomSplit.AddToLinkedControls({ucrChkLag}, {rdoTimeSeries}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        clsInitialTimeSplit = New RFunction
        clsInitialSplit = New RFunction
        clsTesting = New RFunction
        clsTraining = New RFunction
        clsDummyFunction = New RFunction

        ucrSelectorRandomSplit.Reset()
        ucrSelectorRandomSplit.Focus()
        ucrSaveRandomSplit.Reset()

        clsInitialTimeSplit.SetPackageName("rsample")
        clsInitialTimeSplit.SetRCommand("initial_time_split")
        clsInitialTimeSplit.AddParameter("prop", "0.75", iPosition:=1)
        clsInitialTimeSplit.AddParameter("lag", "0", iPosition:=2)

        clsInitialSplit.SetPackageName("rsample")
        clsInitialSplit.SetRCommand("initial_split")
        clsInitialSplit.AddParameter("prop", "0.75", iPosition:=1)
        clsInitialSplit.AddParameter("strata", "NULL", iPosition:=2)
        clsInitialSplit.AddParameter("lag", "0", iPosition:=3)
        clsInitialSplit.AddParameter("breaks", "4", iPosition:=4)
        clsInitialSplit.AddParameter("pool", "0.1", iPosition:=5)

        clsTraining.SetPackageName("rsample")
        clsTraining.SetRCommand("training")
        clsTraining.SetAssignTo("last_training", strTempDataframe:=ucrSelectorRandomSplit.strCurrentDataFrame, strDataFrameNames:="last_training")

        clsTesting.SetPackageName("rsample")
        clsTesting.SetRCommand("testing")
        clsTesting.SetAssignTo("last_testing", strTempDataframe:=ucrSelectorRandomSplit.strCurrentDataFrame, strDataFrameNames:="last_testing")
        ucrBase.clsRsyntax.SetBaseRFunction(clsInitialSplit)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorRandomSplit.AddAdditionalCodeParameterPair(clsInitialTimeSplit, New RParameter("data", ucrSelectorRandomSplit.ucrAvailableDataFrames.clsCurrDataFrame, 0), iAdditionalPairNo:=1)
        ucrNudFraction.AddAdditionalCodeParameterPair(clsInitialTimeSplit, New RParameter("prop", 1), iAdditionalPairNo:=1)
        ucrNudLag.AddAdditionalCodeParameterPair(clsInitialTimeSplit, New RParameter("lag", 3), iAdditionalPairNo:=1)
        ucrSaveRandomSplit.AddAdditionalRCode(clsTesting, iAdditionalPairNo:=1)

        ucrSelectorRandomSplit.SetRCode(clsInitialSplit, bReset)
        ucrChkTestingData.SetRCode(clsDummyFunction, bReset)
        ucrChkTrainingData.SetRCode(clsDummyFunction, bReset)
        ucrChkStratifyingFactor.SetRCode(clsDummyFunction, bReset)
        ucrNudBreaks.SetRCode(clsInitialSplit, bReset)
        ucrNudFraction.SetRCode(clsInitialSplit, bReset)
        ucrNudPool.SetRCode(clsInitialSplit, bReset)
        ucrSaveRandomSplit.SetRCode(clsTraining, bReset)
        ucrNudLag.SetRCode(clsInitialSplit, bReset)
        ucrReceiverRanSplit.SetRCode(clsInitialSplit, bReset)
        If bReset Then
            ucrPnlRandomSplit.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()

    End Sub
    Private Sub SetBaseFunction()
        If rdoSample.Checked Then
            If ucrChkTestingData.Checked Then
                clsTesting.AddParameter("x", clsRFunctionParameter:=clsInitialSplit)
                ucrBase.clsRsyntax.SetBaseRFunction(clsTesting)
                ucrBase.clsRsyntax.iCallType = 0
                ucrChkTrainingData.Checked = False
            ElseIf ucrChkTrainingData.Checked Then
                clsTraining.AddParameter("x", clsRFunctionParameter:=clsInitialSplit)
                ucrBase.clsRsyntax.SetBaseRFunction(clsTraining)
                ucrChkTestingData.Checked = False
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsInitialSplit)
                ucrBase.clsRsyntax.iCallType = 2
                ucrChkTestingData.Checked = False
                ucrChkTrainingData.Checked = False
            End If
        ElseIf rdoTimeSeries.Checked Then
            If ucrChkTestingData.Checked Then
                clsTesting.AddParameter("x", clsRFunctionParameter:=clsInitialTimeSplit)
                ucrBase.clsRsyntax.SetBaseRFunction(clsTesting)
            ElseIf ucrChkTrainingData.Checked Then
                clsTraining.AddParameter("x", clsRFunctionParameter:=clsInitialTimeSplit)
                ucrBase.clsRsyntax.SetBaseRFunction(clsTraining)
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsInitialTimeSplit)
                ucrBase.clsRsyntax.iCallType = 2
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrCore_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudFraction.ControlContentsChanged, ucrNudLag.ControlContentsChanged, ucrNudPool.ControlContentsChanged, ucrPnlRandomSplit.ControlContentsChanged, ucrChkLag.ControlContentsChanged, ucrChkStratifyingFactor.ControlContentsChanged,
        ucrChkTestingData.ControlContentsChanged, ucrChkTrainingData.ControlContentsChanged, ucrNudBreaks.ControlContentsChanged, ucrSaveRandomSplit.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlRandomSplit_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlRandomSplit.ControlValueChanged '', ucrChkTestingData.ControlValueChanged, ucrChkTrainingData.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub SetDataFramePrefix()
        If ucrChkTestingData.Checked Then
            ucrSaveRandomSplit.SetPrefix("testing")
        ElseIf ucrChkTrainingData.Checked Then
            ucrSaveRandomSplit.SetPrefix("training")
        End If
    End Sub

    Private Sub ucrChkTestingData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTestingData.ControlValueChanged, ucrChkTrainingData.ControlValueChanged
        SetDataFramePrefix()
        SetBaseFunction()
    End Sub
End Class