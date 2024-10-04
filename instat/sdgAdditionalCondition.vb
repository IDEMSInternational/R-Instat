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
Public Class sdgAdditionalCondition
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Private clsCombinedList, clsCalcDrySpellRollMax, clsIsNaFirstDryPeriod, clsIsNaFirstDrySpell, clsIsNaDryPeriod, clsIsNaDrySpell, clsRainDayRollingSumFunction, clsIsNaRollSumRainDay, clsIsNaFirstRollSumRainDay, clsDrySpellPeriodRollMaxFunction, clsRollingSumRainDryPeriodFunction, clsCalcRainDayRollingSum, clsCalcRollSumNumberDryPeriod As RFunction
    Private clsConditionsAndOperator, clsIsNaOperatorStartDOY, clsConditionsOrOverallOperator, clsRollingSumRainDayOperator, clsDSCombineOperator, clsSumRainDryPeriodIntervalMinusOperator, clsSumRainDryPeriodOperator, clsDPCombineOperator, clsSumRainDryPeriodIntervalPlusOperator As ROperator

    Private Sub sdgAdditionalCondition_Load(sender As Object, e As EventArgs) Handles ucrSdgButtons.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        'Number of Rainy days
        ucrChkNumberOfRainyDays.SetParameter(New RParameter("rd_sub", clsCalcRainDayRollingSum, 2, False), False)
        'ucrChkNumberOfRainyDays.AddAdditionalCodeParameterPair(clsConditionsAndOperator, New RParameter("rain_days", clsRollingSumRainDayOperator, 2, False), iAdditionalPairNo:=1)
        ucrChkNumberOfRainyDays.SetText("Number of Rainy Days")

        ucrNudRDMinimumDays.SetParameter(New RParameter("1", 1))
        ucrNudRDMinimumDays.SetLinkedDisplayControl(lblRDMinimum)
        ucrNudRDMinimumDays.SetMinMax(1, 366)

        ucrNudRDOutOfDays.SetParameter(New RParameter("n", 1))
        ucrNudRDOutOfDays.SetLinkedDisplayControl(lblRDWidth)
        ucrNudRDOutOfDays.SetMinMax(1, 366)

        ucrChkNumberOfRainyDays.AddToLinkedControls(ucrNudRDMinimumDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkNumberOfRainyDays.AddToLinkedControls(ucrNudRDOutOfDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        'Dry Spell
        ucrChkDrySpell.SetText("Dry Spell")
        ucrChkDrySpell.SetParameter(New RParameter("ds_sub", clsCalcDrySpellRollMax, 3, False), False)
        ucrChkDrySpell.AddAdditionalCodeParameterPair(clsConditionsAndOperator, New RParameter("dry_spell", clsDSCombineOperator, 3, False), iAdditionalPairNo:=1)
        ucrChkDrySpell.AddToLinkedControls(ucrNudDSLengthOfTime, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=21)
        ucrChkDrySpell.AddToLinkedControls(ucrNudDSMaximumDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=9)
        ucrNudDSLengthOfTime.SetLinkedDisplayControl(lblDSLengthofTime)
        ucrNudDSMaximumDays.SetLinkedDisplayControl(lblDSMaximumDays)

        ucrNudDSLengthOfTime.SetParameter(New RParameter("n", 1))
        ucrNudDSLengthOfTime.SetMinMax(1, 366)

        ucrNudDSMaximumDays.SetParameter(New RParameter("ds_max", 1))
        ucrNudDSMaximumDays.SetMinMax(1, 366)

        ' Dry Period
        ucrChkDryPeriod.SetText("Dry Period")
        ucrChkDryPeriod.SetParameter(New RParameter("dp_sub", 3, False))
        'ucrChkDryPeriod.AddAdditionalCodeParameterPair(clsConditionsAndOperator, New RParameter("dry_period", clsDPCombineOperator, 4, False), iAdditionalPairNo:=1)

        ucrNudDPRainPeriod.SetParameter(New RParameter("n", 0))
        ucrNudDPRainPeriod.SetLinkedDisplayControl(lblDPLength)
        ucrNudDPRainPeriod.SetMinMax(1, 366)

        ucrNudDPMaxRain.SetParameter(New RParameter("right", 1))
        ucrNudDPMaxRain.SetLinkedDisplayControl(lblDPMaxRain)
        ucrNudDPMaxRain.SetMinMax(1, Integer.MaxValue)

        ucrNudDPOverallInterval.SetParameter(New RParameter("0", 0))
        ucrNudDPOverallInterval.SetLinkedDisplayControl(lblDPOverallInterval)
        ucrNudDPOverallInterval.SetMinMax(1, 366)

        ucrChkDryPeriod.AddToLinkedControls(ucrNudDPMaxRain, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=40)
        ucrChkDryPeriod.AddToLinkedControls(ucrNudDPOverallInterval, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=45)
        ucrChkDryPeriod.AddToLinkedControls(ucrNudDPRainPeriod, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=30)
    End Sub

    Public Sub SetRFunction(clsNewCombinedList As RFunction, clsNewCalcDrySpellRollMax As RFunction, clsNewIsNaFirstDryPeriod As RFunction, clsNewIsNaFirstDrySpell As RFunction, clsNewIsNaDryPeriod As RFunction, clsNewIsNaDrySpell As RFunction, clsNewRainDayRollingSumFunction As RFunction, clsNewIsNaRollSumRainDay As RFunction, clsNewIsNaFirstRollSumRainDay As RFunction, clsNewDrySpellPeriodRollMaxFunction As RFunction, clsNewRollingSumRainDryPeriodFunction As RFunction, clsNewCalcRainDayRollingSum As RFunction, clsNewCalcRollSumNumberDryPeriod As RFunction, clsNewConditionsAndOperator As ROperator, clsNewIsNaOperatorStartDOY As ROperator, clsNewConditionsOrOverallOperator As ROperator, clsNewRollingSumRainDayOperator As ROperator, clsNewDSCombineOperator As ROperator, clsNewSumRainDryPeriodIntervalMinusOperator As ROperator, clsNewSumRainDryPeriodOperator As ROperator, clsNewDPCombineOperator As ROperator, clsNewSumRainDryPeriodIntervalPlusOperator As ROperator, Optional bReset As Boolean = False)
        clsCombinedList = clsNewCombinedList
        clsCalcDrySpellRollMax = clsNewCalcDrySpellRollMax
        clsIsNaFirstDryPeriod = clsNewIsNaFirstDryPeriod
        clsIsNaFirstDrySpell = clsNewIsNaFirstDrySpell
        clsIsNaDryPeriod = clsNewIsNaDryPeriod
        clsIsNaDrySpell = clsNewIsNaDrySpell
        clsRainDayRollingSumFunction = clsNewRainDayRollingSumFunction
        clsIsNaRollSumRainDay = clsNewIsNaRollSumRainDay
        clsIsNaFirstRollSumRainDay = clsNewIsNaFirstRollSumRainDay
        clsDrySpellPeriodRollMaxFunction = clsNewDrySpellPeriodRollMaxFunction
        clsRollingSumRainDryPeriodFunction = clsNewRollingSumRainDryPeriodFunction
        clsCalcRainDayRollingSum = clsNewCalcRainDayRollingSum
        clsCalcRollSumNumberDryPeriod = clsNewCalcRollSumNumberDryPeriod
        clsConditionsAndOperator = clsNewConditionsAndOperator
        clsIsNaOperatorStartDOY = clsNewIsNaOperatorStartDOY
        clsConditionsOrOverallOperator = clsNewConditionsOrOverallOperator
        clsRollingSumRainDayOperator = clsNewRollingSumRainDayOperator
        clsDSCombineOperator = clsNewDSCombineOperator
        clsSumRainDryPeriodIntervalMinusOperator = clsNewSumRainDryPeriodIntervalMinusOperator
        clsSumRainDryPeriodOperator = clsNewSumRainDryPeriodOperator
        clsDPCombineOperator = clsNewDPCombineOperator
        clsSumRainDryPeriodIntervalPlusOperator = clsNewSumRainDryPeriodIntervalPlusOperator

        ucrNudDPRainPeriod.AddAdditionalCodeParameterPair(clsSumRainDryPeriodIntervalPlusOperator, ucrNudDPRainPeriod.GetParameter(), iAdditionalPairNo:=1)
        ucrChkNumberOfRainyDays.AddAdditionalCodeParameterPair(clsConditionsAndOperator, New RParameter("rain_days", clsRollingSumRainDayOperator, 2, False), iAdditionalPairNo:=1)
        ucrChkDryPeriod.AddAdditionalCodeParameterPair(clsConditionsAndOperator, New RParameter("dry_period", clsDPCombineOperator, 4, False), iAdditionalPairNo:=1)

        ucrChkNumberOfRainyDays.SetRCode(clsCombinedList, bReset, bCloneIfNeeded:=True)
        ucrNudRDOutOfDays.SetRCode(clsRainDayRollingSumFunction, bReset, bCloneIfNeeded:=True)

        ucrNudRDMinimumDays.SetRCode(clsRollingSumRainDayOperator, bReset, bCloneIfNeeded:=True)
        ucrNudDSMaximumDays.SetRCode(clsDSCombineOperator, bReset, bCloneIfNeeded:=True)

        ucrChkDryPeriod.SetRCode(clsCombinedList, bReset, bCloneIfNeeded:=True)
        ucrNudDPRainPeriod.SetRCode(clsRollingSumRainDryPeriodFunction, bReset, bCloneIfNeeded:=True)
        ucrNudDPMaxRain.SetRCode(clsSumRainDryPeriodOperator, bReset, bCloneIfNeeded:=True)
        ucrNudDPOverallInterval.SetRCode(clsSumRainDryPeriodIntervalMinusOperator, bReset, bCloneIfNeeded:=True)

        ucrChkDrySpell.SetRCode(clsCombinedList, bReset, bCloneIfNeeded:=True)
        ucrNudDSLengthOfTime.SetRCode(clsDrySpellPeriodRollMaxFunction, bReset, bCloneIfNeeded:=True)

    End Sub

    Private Sub ucrChkNumberOfRainyDays_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNumberOfRainyDays.ControlValueChanged
        If ucrChkNumberOfRainyDays.Checked Then
            clsIsNaOperatorStartDOY.AddParameter("2", clsRFunctionParameter:=clsIsNaFirstRollSumRainDay, iPosition:=2)
            clsConditionsOrOverallOperator.AddParameter("is.na_roll_sum_rain_day", clsRFunctionParameter:=clsIsNaRollSumRainDay, iPosition:=3)
        Else
            clsIsNaOperatorStartDOY.RemoveParameterByName("2")
            clsConditionsOrOverallOperator.RemoveParameterByName("is.na_roll_sum_rain_day")
        End If
    End Sub

    Private Sub ucrChkDrySpell_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDrySpell.ControlValueChanged
        If ucrChkDrySpell.Checked Then
            clsIsNaOperatorStartDOY.AddParameter("3", clsRFunctionParameter:=clsIsNaFirstDrySpell, iPosition:=3)
            clsConditionsOrOverallOperator.AddParameter("is.na_dry_spell", clsRFunctionParameter:=clsIsNaDrySpell, iPosition:=4)
        Else
            clsIsNaOperatorStartDOY.RemoveParameterByName("3")
            clsConditionsOrOverallOperator.RemoveParameterByName("is.na_dry_spell")
        End If
    End Sub

    Private Sub ucrChkDryPeriod_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDryPeriod.ControlValueChanged
        If ucrChkDryPeriod.Checked Then
            clsIsNaOperatorStartDOY.AddParameter("4", clsRFunctionParameter:=clsIsNaFirstDryPeriod, iPosition:=4)
            clsConditionsOrOverallOperator.AddParameter("is.na_dry_period", clsRFunctionParameter:=clsIsNaDryPeriod, iPosition:=5)
        Else
            clsIsNaOperatorStartDOY.RemoveParameterByName("4")
            clsConditionsOrOverallOperator.RemoveParameterByName("is.na_dry_period")
        End If
    End Sub

    Private Sub MaximumValuesControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkDryPeriod.ControlContentsChanged, ucrNudDPRainPeriod.ControlContentsChanged, ucrNudDPOverallInterval.ControlContentsChanged
        If ucrChkDryPeriod.Checked Then
            ucrNudDPRainPeriod.Maximum = ucrNudDPOverallInterval.Value
            ucrNudDPOverallInterval.Minimum = ucrNudDPRainPeriod.Value
        End If
    End Sub
End Class