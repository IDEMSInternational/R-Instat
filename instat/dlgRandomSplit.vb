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
    Private clsInitialTimeSplit As New RFunction
    Private clsInitialSplit As New RFunction
    Private clsTraining As New RFunction
    Private clsTesting As New RFunction

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
        ucrReceiverRanSplit.SetParameterIsString()

        ucrSelectorRandomSplit.SetParameter(New RParameter("data", 0))
        ucrSelectorRandomSplit.SetParameterIsrfunction()

        ucrNudPool.SetLinkedDisplayControl(lblPool)
        ucrNudPool.SetParameter(New RParameter("pool", 5))
        ucrNudPool.DecimalPlaces = 2
        ucrNudPool.SetMinMax(0.01, 1.0)
        ucrNudPool.Increment = 0.01

        ucrChkStratifyingFactor.SetText("Stratifying Variable")
        ucrChkStratifyingFactor.AddToLinkedControls(ucrNudBreaks, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=4)
        ucrChkStratifyingFactor.SetParameter(ucrNudPool.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkStratifyingFactor.AddToLinkedControls({ucrNudPool, ucrReceiverRanSplit}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.1)

        ucrNudLag.SetParameter(New RParameter("lag", 3))
        ucrNudLag.SetMinMax(0, 100)
        ucrNudLag.Increment = 0.5
        ucrNudLag.DecimalPlaces = 2
        ucrChkLag.SetText("Lag:")
        ucrChkLag.SetParameter(ucrNudLag.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkLag.AddToLinkedControls(ucrNudLag, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        ucrChkTest.SetText("Save Test Data:")
        ucrChkTest.AddToLinkedControls(ucrSaveTestingData, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveTrainingData.SetLabelText("Save Train to:")
        ucrSaveTrainingData.SetSaveTypeAsDataFrame()
        ucrSaveTrainingData.SetDataFrameSelector(ucrSelectorRandomSplit.ucrAvailableDataFrames)
        ucrSaveTrainingData.SetPrefix("training_data")
        ucrSaveTrainingData.SetIsComboBox()

        ucrSaveTestingData.SetLabelText("Save Test to:")
        ucrSaveTestingData.SetSaveTypeAsDataFrame()
        ucrSaveTestingData.SetDataFrameSelector(ucrSelectorRandomSplit.ucrAvailableDataFrames)
        ucrSaveTestingData.SetPrefix("testing_data")
        ucrSaveTestingData.SetIsComboBox()

        ucrNudBreaks.SetLinkedDisplayControl(lblBreaks)
        ucrNudBreaks.SetParameter(New RParameter("breaks", 4))
        ucrNudFraction.SetMinMax(0.1, 10.0)
        ucrNudFraction.DecimalPlaces = 2
        ucrNudFraction.Increment = 0.1

        ucrNudFraction.SetLinkedDisplayControl(lblFraction)
        ucrNudFraction.SetParameter(New RParameter("prop", 1))
        ucrNudFraction.SetMinMax(0.01, 0.99)
        ucrNudFraction.DecimalPlaces = 2
        ucrNudFraction.Increment = 0.01

        ucrPnlRandomSplit.AddRadioButton(rdoSample)
        ucrPnlRandomSplit.AddRadioButton(rdoTimeSeries)
        ucrPnlRandomSplit.AddFunctionNamesCondition(rdoSample, {"initial_split", "training", "testing"})
        ucrPnlRandomSplit.AddFunctionNamesCondition(rdoTimeSeries, {"initial_time_split", "training", "testing"})
        ucrPnlRandomSplit.AddToLinkedControls({ucrChkLag}, {rdoTimeSeries}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlRandomSplit.AddToLinkedControls({ucrChkStratifyingFactor}, {rdoSample}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        clsInitialTimeSplit = New RFunction
        clsInitialSplit = New RFunction
        clsTesting = New RFunction
        clsTraining = New RFunction

        ucrSelectorRandomSplit.Reset()
        ucrSelectorRandomSplit.Focus()
        ucrSaveTrainingData.Reset()
        ucrSaveTestingData.Reset()

        clsInitialTimeSplit.SetPackageName("rsample")
        clsInitialTimeSplit.SetRCommand("initial_time_split")
        clsInitialTimeSplit.AddParameter("prop", "0.75", iPosition:=1)
        clsInitialTimeSplit.AddParameter("lag", "0", iPosition:=2)
        clsInitialTimeSplit.SetAssignTo("rsample")

        clsInitialSplit.SetPackageName("rsample")
        clsInitialSplit.SetRCommand("initial_split")
        clsInitialSplit.AddParameter("prop", "0.75", iPosition:=1)
        clsInitialSplit.AddParameter("strata", "NULL", iPosition:=2)
        clsInitialSplit.AddParameter("breaks", "4", iPosition:=4)
        clsInitialSplit.SetAssignTo("rsample")

        clsTraining.SetPackageName("rsample")
        clsTraining.SetRCommand("training")
        clsTraining.SetAssignTo("training_data", strTempDataframe:=ucrSelectorRandomSplit.strCurrentDataFrame, strDataFrameNames:="last_training")

        clsTesting.SetPackageName("rsample")
        clsTesting.SetRCommand("testing")
        clsTesting.SetAssignTo("testing_data", strTempDataframe:=ucrSelectorRandomSplit.strCurrentDataFrame, strDataFrameNames:="last_testing")
        ucrBase.clsRsyntax.SetBaseRFunction(clsInitialSplit)
        ucrBase.clsRsyntax.AddToAfterCodes(clsTesting, 0)
        ucrBase.clsRsyntax.AddToAfterCodes(clsTraining, 1)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlRandomSplit.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrSelectorRandomSplit.AddAdditionalCodeParameterPair(clsInitialTimeSplit, New RParameter("data", ucrSelectorRandomSplit.ucrAvailableDataFrames.clsCurrDataFrame, 0), iAdditionalPairNo:=1)
        ucrNudFraction.AddAdditionalCodeParameterPair(clsInitialTimeSplit, New RParameter("prop", 1), iAdditionalPairNo:=1)

        ucrSelectorRandomSplit.SetRCode(clsInitialSplit, bReset)
        ucrNudBreaks.SetRCode(clsInitialSplit, bReset)
        ucrNudFraction.SetRCode(clsInitialSplit, bReset)
        ucrNudPool.SetRCode(clsInitialSplit, bReset)
        ucrSaveTrainingData.SetRCode(clsTraining, bReset)
        ucrSaveTestingData.SetRCode(clsTesting, bReset)
        ucrNudLag.SetRCode(clsInitialTimeSplit, bReset)
        ucrReceiverRanSplit.SetRCode(clsInitialSplit, bReset)
        ucrChkStratifyingFactor.SetRCode(clsInitialSplit, bReset)

        If bReset Then
            ucrChkTest.SetRCode(clsInitialSplit, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        If ucrSaveTestingData.IsComplete Or ucrSaveTrainingData.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetBaseFunction()
        ucrBase.clsRsyntax.ClearCodes()
        If rdoSample.Checked Then
            If ucrSaveTestingData.IsComplete Then
                clsTesting.AddParameter("x", clsRFunctionParameter:=clsInitialSplit)
            End If
            If ucrSaveTrainingData.IsComplete Then
                clsTraining.AddParameter("x", clsRFunctionParameter:=clsInitialSplit)
            End If
            ucrBase.clsRsyntax.SetBaseRFunction(clsInitialSplit)
        Else
            If ucrSaveTestingData.IsComplete Then
                clsTesting.AddParameter("x", clsRFunctionParameter:=clsInitialTimeSplit)
            End If
            If ucrSaveTrainingData.IsComplete Then
                clsTraining.AddParameter("x", clsRFunctionParameter:=clsInitialTimeSplit)
            End If
            ucrBase.clsRsyntax.SetBaseRFunction(clsInitialTimeSplit)
        End If
        ucrBase.clsRsyntax.AddToAfterCodes(clsTesting, 0)
        ucrBase.clsRsyntax.AddToAfterCodes(clsTraining, 1)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrCore_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudFraction.ControlContentsChanged, ucrNudLag.ControlContentsChanged, ucrNudPool.ControlContentsChanged, ucrPnlRandomSplit.ControlContentsChanged, ucrChkLag.ControlContentsChanged, ucrChkStratifyingFactor.ControlContentsChanged, ucrNudBreaks.ControlContentsChanged, ucrSaveTrainingData.ControlContentsChanged, ucrSaveTestingData.ControlContentsChanged, ucrChkTest.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlRandomSplit_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlRandomSplit.ControlValueChanged, ucrChkStratifyingFactor.ControlValueChanged, ucrReceiverRanSplit.ControlValueChanged, ucrChkLag.ControlValueChanged, ucrNudBreaks.ControlValueChanged, ucrNudFraction.ControlValueChanged, ucrNudPool.ControlValueChanged, ucrChkTest.ControlValueChanged
        SetBaseFunction()
    End Sub

End Class