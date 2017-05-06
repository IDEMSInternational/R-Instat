'' Instat-R
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
Imports instat
Imports instat.Translations
Public Class dlgTransformClimatic
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True

    Private clsSumFunction, clsCountFunction, clsSpellFunction, clsWaterBalanceFunction As New RFunction
    Private Sub dlgTransformClimatic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
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
        Dim dctInputSumPairs As New Dictionary(Of String, String)
        ucrReceiverStation.Selector = ucrSelectorTransform
        ucrReceiverYear.Selector = ucrSelectorTransform
        ucrReceiverDate.Selector = ucrSelectorTransform
        ucrReceiverDOY.Selector = ucrSelectorTransform
        ucrReceiverData.Selector = ucrSelectorTransform
        ucrReceiverDate.SetMeAsReceiver()
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        'this is not right
        ucrReceiverData.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverData.bAutoFill = True
        ucrReceiverYear.bAutoFill = True

        ucrPnlTransform.AddRadioButton(rdoSum)
        ucrPnlTransform.AddRadioButton(rdoCount)
        ucrPnlTransform.AddRadioButton(rdoSpell)
        ucrPnlTransform.AddRadioButton(rdoWaterBalance)

        ucrPnlTransform.AddFunctionNamesCondition(rdoSum, "")
        ucrPnlTransform.AddFunctionNamesCondition(rdoCount, "")
        ucrPnlTransform.AddFunctionNamesCondition(rdoSpell, "")
        ucrPnlTransform.AddFunctionNamesCondition(rdoWaterBalance, "")

        ucrNudThreshold.SetParameter(New RParameter("threshold"))
        ucrNudThreshold.SetMinMax(0, 100)
        ucrNudThreshold.Increment = 0.01
        ucrNudThreshold.DecimalPlaces = 2
        ucrNudThreshold.SetRDefault("0.85")

        ucrInputSum.SetParameter(New RParameter("summary"))
        dctInputSumPairs.Add("Sum", Chr(34) & "sum" & Chr(34))
        dctInputSumPairs.Add("Max", Chr(34) & "max" & Chr(34))
        dctInputSumPairs.Add("Min", Chr(34) & "min" & Chr(34))
        dctInputSumPairs.Add("Mean", Chr(34) & "mean" & Chr(34))
        ucrInputSum.SetItems(dctInputSumPairs)
        ucrInputSum.SetLinkedDisplayControl(lblSumOver)

        ucrNudSumOver.SetParameter(New RParameter("sum_over"))
        ucrNudSumOver.SetMinMax(1, 366)
        ucrNudSumOver.Increment = 1
        ucrNudSumOver.SetLinkedDisplayControl(lblSumRows)
        'ucrNudSumOver.SetRDefault("3")

        ucrNudCountOver.SetParameter(New RParameter("count_over"))
        ucrNudCountOver.SetMinMax(1, 366)
        ucrNudCountOver.Increment = 1
        ucrNudCountOver.SetLinkedDisplayControl(lblCountOver)
        ucrNudCountOver.SetLinkedDisplayControl(lblCountRows)
        'ucrNudCountOver.SetRDefault("3")

        ucrInputSpellLower.SetValidationTypeAsNumeric()
        ucrInputSpellLower.SetParameter(New RParameter("spell_lower"))

        ucrInputSpellUpper.SetValidationTypeAsNumeric()
        ucrInputSpellUpper.SetParameter(New RParameter("spell_upper"))

        ucrNudWBCapacity.SetParameter(New RParameter("capacity"))
        ucrNudWBCapacity.SetMinMax(1, 366)
        ucrNudWBCapacity.Increment = 1
        'ucrNudWBCapacity.SetRDefault("60")
        ucrInputEvaporation.SetValidationTypeAsNumeric()
        ucrInputEvaporation.SetParameter(New RParameter("evaporation"))

        ucrSaveTransform.SetDataFrameSelector(ucrSelectorTransform.ucrAvailableDataFrames)
        ucrSaveTransform.SetLabelText("New Column Name:")
        ucrSaveTransform.SetIsTextBox()
        ucrSaveTransform.SetPrefix("Sum")
        ucrSaveTransform.SetSaveTypeAsColumn()

        ucrPnlTransform.AddToLinkedControls({ucrInputSum, ucrNudSumOver}, {rdoSum}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrNudCountOver}, {rdoCount}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrInputSum, ucrNudSumOver}, {rdoSpell}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrInputSum, ucrNudSumOver}, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        'ucrChkLong.AddToLinkedControls(ucrReceiverDataColumn, {True}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        'ucrChkLong.AddToLinkedControls(ucrReceiverStations, {True}, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        clsSumFunction = New RFunction
        clsCountFunction = New RFunction
        clsSpellFunction = New RFunction
        clsWaterBalanceFunction = New RFunction
        ucrSaveTransform.Reset()
        ucrSelectorTransform.Reset()

    End Sub

    Private Sub ucrPnlTransform_Load(sender As Object, e As EventArgs) Handles ucrPnlTransform.Load

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

    Private Sub ucrPnlTransform_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlTransform.ControlContentsChanged
        If rdoSum.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSumFunction)
            ucrSaveTransform.SetPrefix("Sum")
        ElseIf rdoCount.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCountFunction)
            ucrSaveTransform.SetPrefix("Count")
        ElseIf rdoSpell.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSpellFunction)
            ucrSaveTransform.SetPrefix("Spell")
        ElseIf rdoWaterBalance.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsWaterBalanceFunction)
            ucrSaveTransform.SetPrefix("Water_balance")
        End If
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged ' add more teskok controls
        TestOkEnabled()
    End Sub
End Class