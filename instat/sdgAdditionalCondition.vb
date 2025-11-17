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
    Private clsCombinedList, clsCalcDrySpellRollMax, clsCalcRainDayRollingSum, clsCalcRollSumNumberDryPeriod As RFunction
    Private clsConditionsAndOperator, clsRollingSumRainDayOperator, clsDSCombineOperator, clsDPCombineOperator, clsSumRainDryPeriodIntervalPlusOperator As ROperator

    Private Sub sdgAdditionalCondition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not bControlsInitialised Then
            InitialiseControls()
            bControlsInitialised = True
        End If

        UpdateTranslations()

        ' Subscribe to language-changed event from the shared buttons control
        AddHandler ucrSdgButtons.LanguageChanged, AddressOf ucrSdgButtons_LanguageChanged

    End Sub

    Public Sub InitialiseControls()
        ucrChkNumberOfRainyDays.SetText("Number of Rainy Days")
        ucrChkNumberOfRainyDays.SetParameter(New RParameter("rd_sub", clsCalcRainDayRollingSum, 2, False), False)
        ucrChkNumberOfRainyDays.AddAdditionalCodeParameterPair(clsConditionsAndOperator, New RParameter("rain_days", clsRollingSumRainDayOperator, 2, False), iAdditionalPairNo:=1)

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

        ucrNudDSMaximumDays.SetParameter(New RParameter("right", 1))
        ucrNudDSMaximumDays.SetMinMax(1, 366)
        ucrNudDSMaximumDays.Increment = 1

        ' Dry Period
        ucrChkDryPeriod.SetText("Dry Period")
        ucrChkDryPeriod.SetParameter(New RParameter("dp_sub", clsCalcRollSumNumberDryPeriod, 3, False), False)
        ucrChkDryPeriod.AddAdditionalCodeParameterPair(clsConditionsAndOperator, New RParameter("dry_period", clsDPCombineOperator, 4, False), iAdditionalPairNo:=1)

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

    Public Sub SetRCode(clsNewCombinedList As RFunction, clsNewCalcDrySpellRollMax As RFunction, clsNewCalcRainDayRollingSum As RFunction, clsNewCalcRollSumNumberDryPeriod As RFunction, clsNewConditionsAndOperator As ROperator, clsNewRollingSumRainDayOperator As ROperator, clsNewDSCombineOperator As ROperator, clsNewDPCombineOperator As ROperator, clsNewSumRainDryPeriodIntervalPlusOperator As ROperator, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsCombinedList = clsNewCombinedList
        clsCalcDrySpellRollMax = clsNewCalcDrySpellRollMax
        clsCalcRainDayRollingSum = clsNewCalcRainDayRollingSum
        clsCalcRollSumNumberDryPeriod = clsNewCalcRollSumNumberDryPeriod
        clsConditionsAndOperator = clsNewConditionsAndOperator
        clsRollingSumRainDayOperator = clsNewRollingSumRainDayOperator
        clsDSCombineOperator = clsNewDSCombineOperator
        clsDPCombineOperator = clsNewDPCombineOperator
        clsSumRainDryPeriodIntervalPlusOperator = clsNewSumRainDryPeriodIntervalPlusOperator

        ucrNudDPRainPeriod.AddAdditionalCodeParameterPair(clsSumRainDryPeriodIntervalPlusOperator, ucrNudDPRainPeriod.GetParameter(), iAdditionalPairNo:=1)

        ucrChkNumberOfRainyDays.SetRCode(clsCombinedList, bReset, bCloneIfNeeded:=True)
        ucrChkDryPeriod.SetRCode(clsCombinedList, bReset, bCloneIfNeeded:=True)
        ucrChkDrySpell.SetRCode(clsCombinedList, bReset, bCloneIfNeeded:=True)
    End Sub

    Private Sub MaximumValuesControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkDryPeriod.ControlContentsChanged, ucrNudDPRainPeriod.ControlContentsChanged, ucrNudDPOverallInterval.ControlContentsChanged
        If ucrChkDryPeriod.Checked Then
            ucrNudDPRainPeriod.Maximum = ucrNudDPOverallInterval.Value
            ucrNudDPOverallInterval.Minimum = ucrNudDPRainPeriod.Value
        End If
    End Sub

    Private Sub UpdateTranslations()
        ' Translate designer/localizable texts
        Translations.autoTranslate(Me)

        ' Update texts you previously set programmatically
        ucrChkNumberOfRainyDays.SetText(Translations.GetTranslation("Number of Rainy Days"))
        ucrChkDryPeriod.SetText(Translations.GetTranslation("Dry Period"))
        ucrChkDrySpell.SetText(Translations.GetTranslation("Dry Spell"))
        lblRDMinimum.Text = Translations.GetTranslation("Minimum")
        lblDSMaximumDays.Text = Translations.GetTranslation("Maximum Dry Days:")
        lblDPMaxRain.Text = Translations.GetTranslation("Maximum Rain:")
        lblDPOverallInterval.Text = Translations.GetTranslation("Overall Interval Length:")
        lblRDWidth.Text = Translations.GetTranslation("Out of Days:")
        lblDSLengthofTime.Text = Translations.GetTranslation("Overall Interval Length:")
        lblDPLength.Text = Translations.GetTranslation("Maximum Dry Days:")
    End Sub

    ' Remove the handler when dialog closes to avoid leaks
    Private Sub sdgAdditionalCondition_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RemoveHandler ucrSdgButtons.LanguageChanged, AddressOf ucrSdgButtons_LanguageChanged
    End Sub

    ' Handler to refresh texts only
    Private Sub ucrSdgButtons_LanguageChanged(ByVal newCulture As String)
        Me.SuspendLayout()
        Try
            UpdateTranslations()
        Finally
            Me.ResumeLayout()
            Me.PerformLayout()
            Me.Refresh()
        End Try
    End Sub
End Class