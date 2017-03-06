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

Public Class dlgStartofRains
    Public clsAddKey, clsDayFromAndTo, clsRainyDays, clsRollingSum, clsMinimumRainfall, clsRollingRainDays, clsFirstDOYPerYear, clsDryPeriodTen, clsWithinThirtyDays, clsDrySpell, clsYearGroupDaily, clsManipulationFirstDOYPerYear As New RFunction
    Public clsDryPeriodTenList, clsSubRainDays1, clsSubRainDays2, clsCombinedFilter, clsCombinedList, clsWetSpell, clsWetSpellList, clsDPOverallInterval, clsDPOverallIntervalList, clsDPRain, clsDPRainList, clsDPRainInDays As New RFunction
    Private strCurrDataName As String = ""
    Public bFirstLoad As Boolean = True
    Private Sub dlgStartofRains_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverDOY_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDOY.SelectionChanged
        firstDayofTheYear()
        DayFromAndToMethod()
        FirstDOYPerYear()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForStartofRains_DataFrameChanged() Handles ucrSelectorForStartofRains.DataFrameChanged
        strCurrDataName = Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        clsAddKey.AddParameter("data_name", strCurrDataName)
        firstDayofTheYear()
    End Sub

    Private Sub InitialiseDialog()
        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.SetAssignTo("Day_From_and_To")
        clsYearGroupDaily.SetRCommand("instat_calculation$new")
        clsYearGroupDaily.SetAssignTo("Year_Group_Daily")
        clsRainyDays.SetRCommand("instat_calculation$new")
        clsRollingSum.SetRCommand("instat_calculation$new")
        clsRollingSum.SetAssignTo("rolling_sum_day")
        clsMinimumRainfall.SetRCommand("instat_calculation$new")
        clsMinimumRainfall.SetAssignTo("Minimum_Rainfall")
        clsRollingRainDays.SetRCommand("instat_calculation$new")
        clsRollingRainDays.SetAssignTo("Rolling_rain")
        clsFirstDOYPerYear.SetRCommand("instat_calculation$new")
        clsFirstDOYPerYear.SetAssignTo("First_doy_per_year")
        clsDryPeriodTen.SetRCommand("instat_calculation$new")
        clsDryPeriodTen.SetAssignTo("Dry_Period_10")
        clsDrySpell.SetRCommand("instat_calculation$new")
        clsDrySpell.SetAssignTo("Dry_Spell")
        clsWithinThirtyDays.SetRCommand("instat_calculation$new")
        clsWithinThirtyDays.SetAssignTo("dry_spell_10")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$apply_instat_calculation")
        clsSubRainDays1.SetRCommand("list")
        clsSubRainDays2.SetRCommand("list")
        clsCombinedList.SetRCommand("list")
        clsManipulationFirstDOYPerYear.SetRCommand("list")
        clsDryPeriodTenList.SetRCommand("list")
        clsWetSpellList.SetRCommand("list")
        clsWetSpell.SetRCommand("instat_calculation$new")
        clsWetSpell.SetAssignTo("Wet_Spell")


        clsCombinedFilter.SetRCommand("instat_calculation$new")
        clsCombinedFilter.SetAssignTo("combined_filter")

        ucrReceiverRainfall.Selector = ucrSelectorForStartofRains
        ucrReceiverYear.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.Selector = ucrSelectorForStartofRains
        ucrReceiverDOY.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.SetMeAsReceiver()

        nudPercentile.Minimum = 0
        nudPercentile.Maximum = 1
        nudPercentile.DecimalPlaces = 2
        nudPercentile.Increment = 0.1

        clsDPOverallInterval.SetRCommand("instat_calculation$new")
        clsDPOverallInterval.SetAssignTo("Overall_Interval")
        clsDPRain.SetRCommand("instat_calculation$new")
        clsDPRain.SetAssignTo("Above_Threshold")
        clsDPRainInDays.SetRCommand("instat_calculation$new")
        clsDPRainInDays.SetAssignTo("Rain_Period_Length")

        clsDPOverallIntervalList.SetRCommand("list")
        clsDPRainList.SetRCommand("list")

        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverRainfall.bAutoFill = True
        ucrReceiverYear.bAutoFill = True

        chkDryPeriod.Enabled = False
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForStartofRains.Reset()
        chkConsecutiveRainyDays.Checked = False
        chkDrySpell.Checked = False
        chkTotalRainfall.Checked = False
        chkDryPeriod.Checked = False
        CheckBoxesSetting()
        TestOKEnabled()
        nudAmount.Value = 20
        nudPercentile.Value = 0.8
        nudMinimum.Value = 1
        nudMaximumDays.Value = 10
        nudLengthofTime.Value = 30
        nudOverDays.Value = 2
        nudOutOfDays.Value = 2
        nudThreshold.Value = 0.85
        rdoAmount.Checked = True
        nudDPMaxRain.Value = "40"
        nudDPRainPeriod.Value = "30"
        nudDPOverallInterval.Value = "45"
        nudFrom.Value = 1
        nudTo.Value = 366
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso nudThreshold.Text <> "" AndAlso nudFrom.Text <> "" AndAlso nudTo.Text <> "" AndAlso ((chkConsecutiveRainyDays.Checked AndAlso nudMinimum.Text <> "" AndAlso nudOutOfDays.Text <> "") OrElse Not chkConsecutiveRainyDays.Checked) AndAlso (((chkTotalRainfall.Checked AndAlso nudOverDays.Text <> "") AndAlso ((rdoAmount.Checked AndAlso nudAmount.Text <> "") OrElse (rdoPercentile.Checked AndAlso nudPercentile.Text <> ""))) OrElse Not chkTotalRainfall.Checked) AndAlso ((chkDrySpell.Checked AndAlso nudMaximumDays.Text <> "" AndAlso nudLengthofTime.Text <> "") OrElse Not chkDrySpell.Checked) AndAlso ((chkDryPeriod.Checked AndAlso nudDPMaxRain.Text <> "" AndAlso nudDPRainPeriod.Text <> "" AndAlso nudDPOverallInterval.Text <> "") OrElse Not chkDryPeriod.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub grpRainParameters_Enter(sender As Object, e As EventArgs) Handles nudFrom.TextChanged, nudTo.TextChanged, nudThreshold.TextChanged
        DayFromAndToMethod()
        RainyDaysMethod()
        nudValues()
        TestOKEnabled()
    End Sub

    Private Sub DryPeriod(sender As Object, e As EventArgs) Handles nudDPRainPeriod.TextChanged, nudDPOverallInterval.TextChanged, nudDPMaxRain.TextChanged
        DryPeriodRainPeriod()
        DryPeriodAboveThreshold()
        DryPeriodOverallInterval()
        nudValues()
        TestOKEnabled()
    End Sub

    Private Sub grpConditionsForStartofRains_Enter(sender As Object, e As EventArgs) Handles nudAmount.TextChanged, nudPercentile.TextChanged, nudMinimum.TextChanged, nudMaximumDays.TextChanged, nudLengthofTime.TextChanged, nudOverDays.TextChanged, nudOutOfDays.TextChanged
        RainyDaysMethod()
        DayFromAndToMethod()
        CombinedFilter()
        RollingOfRainDays()
        DrySpell()
        RollingSumMethod()
        WetSpell()
        nudValues()
        TestOKEnabled()
    End Sub

    Private Sub rdoTotalRainfall_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAmount.CheckedChanged, rdoPercentile.CheckedChanged
        CheckBoxesSetting()
        CombinedFilter()
        RollingSumMethod()
        WetSpell()
        TestOKEnabled()
    End Sub

    Private Sub grpConditionsForStartofRains1_Enter(sender As Object, e As EventArgs) Handles chkConsecutiveRainyDays.CheckedChanged, chkTotalRainfall.CheckedChanged, chkDrySpell.CheckedChanged, chkDryPeriod.CheckedChanged
        CheckBoxesSetting()
        DrySpell()
        RainyDaysMethod()
        CombinedFilter()
        FirstDOYPerYear()
        TestOKEnabled()
        nudValues()
    End Sub

    Private Sub ucrReceiverRainfall_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRainfall.SelectionChanged
        RainyDaysMethod()
        RollingSumMethod()
        DryPeriodRainPeriod()
        DryPeriodAboveThreshold()
        DryPeriodOverallInterval()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverYear_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverYear.SelectionChanged
        YearGroupDaily()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDate.SelectionChanged
        AddKeyMethod()
        TestOKEnabled()
    End Sub

    Private Sub CheckBoxesSetting()
        If chkTotalRainfall.Checked Then
            pnlTotalRainfall.Visible = True
            nudAmount.Visible = False
            nudPercentile.Visible = False
            If rdoAmount.Checked Then
                nudAmount.Visible = True
                nudPercentile.Visible = False
            ElseIf rdoPercentile.Checked Then
                nudAmount.Visible = False
                nudPercentile.Visible = True
            Else
                nudAmount.Visible = False
                nudPercentile.Visible = False
            End If
        Else
            pnlTotalRainfall.Visible = False
        End If
        If chkDrySpell.Checked Then
            pnlDrySpell.Visible = True
        Else
            pnlDrySpell.Visible = False
        End If
        If chkConsecutiveRainyDays.Checked Then
            pnlConsecutiveRainyDays.Visible = True
        Else
            pnlConsecutiveRainyDays.Visible = False
        End If
        If chkDryPeriod.Checked Then
            pnlDryPeriod.Visible = True
        Else
            pnlDryPeriod.Visible = False
        End If

    End Sub

    ' nud max and mins.
    Private Sub nudValues()
        '  nudFrom.Maximum = nudTo.Value - 1
        ' nudTo.Minimum = nudFrom.Value + 1
        If chkConsecutiveRainyDays.Checked Then
            nudMinimum.Maximum = nudOutOfDays.Value - 1
            nudOutOfDays.Minimum = nudMinimum.Value + 1
        End If
        If chkDrySpell.Checked Then
            nudMaximumDays.Maximum = nudLengthofTime.Value - 1
            nudLengthofTime.Minimum = nudMaximumDays.Value + 1
        End If
        If chkDryPeriod.Checked Then
            nudDPRainPeriod.Maximum = nudDPOverallInterval.Value - 1
            nudDPOverallInterval.Minimum = nudDPRainPeriod.Value + 1
        End If
    End Sub

    Private Sub AddKeyMethod()
        If Not ucrReceiverDate.IsEmpty Then
            clsAddKey.AddParameter("col_name", ucrReceiverDate.GetVariableNames)
        Else
            clsAddKey.RemoveParameterByName("col_name")
        End If
    End Sub

    Private Sub DayFromAndToMethod()
        If nudFrom.Text <> "" AndAlso nudTo.Text <> "" AndAlso (Not ucrReceiverDOY.IsEmpty) Then
            clsDayFromAndTo.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & ">=" & nudFrom.Value & " & " & ucrReceiverDOY.GetVariableNames(False) & "<=" & nudTo.Value & Chr(34))
            clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
            clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34))
        Else
            clsDayFromAndTo.RemoveParameterByName("function_exp")
            clsDayFromAndTo.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub RainyDaysMethod()
        If ((Not ucrReceiverRainfall.IsEmpty) AndAlso (nudThreshold.Text <> "")) Then
            clsRainyDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsRainyDays.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverRainfall.GetVariableNames(False) & ">=" & nudThreshold.Value & "," & "1, nomatch = 0" & ")" & Chr(34))
            clsRainyDays.AddParameter("result_name", Chr(34) & "rain_day" & Chr(34))
            clsRainyDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames(True) & ")")
            clsRainyDays.AddParameter("save", 0)
            '            clsSubRainDays.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
        Else
            clsRainyDays.RemoveParameterByName("type")
            clsRainyDays.RemoveParameterByName("function_exp")
            clsRainyDays.RemoveParameterByName("result_name")
            clsRainyDays.RemoveParameterByName("calculated_from")
            clsRainyDays.RemoveParameterByName("save")
        End If
    End Sub

    Private Sub RollingSumMethod()
        ' chk total rainfall
        If Not ucrReceiverRainfall.IsEmpty Then
            clsRollingSum.AddParameter("function_exp", Chr(34) & " rollapply(data = " & ucrReceiverRainfall.GetVariableNames(False) & " ,width = " & nudOverDays.Value & ", FUN = sum, na.rm = FALSE, align='right', fill=NA)" & Chr(34))
            clsRollingSum.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsRollingSum.AddParameter("result_name", Chr(34) & "roll_sum_Rain" & Chr(34))
            clsRollingSum.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")")
            clsRollingSum.AddParameter("save", 0)
        Else
            clsRollingSum.RemoveParameterByName("function_exp")
            clsRollingSum.RemoveParameterByName("type")
            clsRollingSum.RemoveParameterByName("result_name")
            clsRollingSum.RemoveParameterByName("calculated_from")
            clsRollingSum.RemoveParameterByName("save")
        End If
    End Sub

    ' If we have 'Percentile' checked
    Private Sub WetSpell()
        If rdoPercentile.Checked Then
            clsWetSpell.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsWetSpell.AddParameter("function_exp", Chr(34) & "quantile(roll_sum_Rain, c(" & nudPercentile.Value & "), na.rm=T)" & Chr(34))
            clsWetSpell.AddParameter("result_name", Chr(34) & "wet_spell" & Chr(34))
            clsWetSpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsWetSpellList)
            clsWetSpellList.AddParameter("sub1", clsRFunctionParameter:=clsRollingSum, bIncludeArgumentName:=False)
            clsWetSpell.AddParameter("save", "0")
        Else
            clsWetSpell.RemoveParameterByName("type")
            clsWetSpell.RemoveParameterByName("function_exp")
            clsWetSpell.RemoveParameterByName("result_name")
            clsWetSpell.RemoveParameterByName("sub_calculations")
            clsWetSpellList.RemoveParameterByName("sub1")
            clsWetSpell.RemoveParameterByName("save")
        End If
    End Sub

    Private Sub RollingOfRainDays()
        '  If rolling of rain days one is checked Then
        clsRollingRainDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsRollingRainDays.AddParameter("function_exp", Chr(34) & "rollapply(data=rain_day, width = " & nudOutOfDays.Value & ", FUN = sum, na.rm = FALSE, align = 'right', fill=NA)" & Chr(34))
        clsRollingRainDays.AddParameter("result_name", Chr(34) & "Rolling_Rain_Days" & Chr(34))
        clsRollingRainDays.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubRainDays1)
        clsSubRainDays1.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
        clsRollingRainDays.AddParameter("save", 0)
    End Sub

    Private Sub DrySpell()
        If chkDrySpell.Checked Then
            clsDrySpell.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsDrySpell.AddParameter("function_exp", Chr(34) & "cumsum(rain_day==0)-cummax((rain_day)*cumsum(rain_day==0))" & Chr(34))
            clsDrySpell.AddParameter("result_name", Chr(34) & "Dry_Spell" & Chr(34))
            clsDrySpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubRainDays2)
            clsSubRainDays2.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
            clsDrySpell.AddParameter("save", 0)
            clsDryPeriodTen.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsDryPeriodTen.AddParameter("function_exp", Chr(34) & "rollapply(data = Dry_Spell, width=" & nudLengthofTime.Value & ", FUN=max, na.rm = FALSE, align='left', fill=NA)" & Chr(34))
            clsDryPeriodTen.AddParameter("result_name", Chr(34) & "Dry_Spell" & Chr(34))
            clsDryPeriodTen.AddParameter("sub_calculations", clsRFunctionParameter:=clsDryPeriodTenList)
            clsDryPeriodTenList.AddParameter("sub1", clsRFunctionParameter:=clsDrySpell, bIncludeArgumentName:=False)
            clsDryPeriodTen.AddParameter("save", 2)
        Else
            clsDrySpell.RemoveParameterByName("type")
            clsDrySpell.RemoveParameterByName("function_exp")
            clsDrySpell.RemoveParameterByName("result_name")
            clsDrySpell.RemoveParameterByName("sub_calculations")
            clsSubRainDays2.RemoveParameterByName("sub1")
            clsDrySpell.RemoveParameterByName("save")
            clsDryPeriodTen.RemoveParameterByName("type")
            clsDryPeriodTen.RemoveParameterByName("function_exp")
            clsDryPeriodTen.RemoveParameterByName("sub_calculations")
            clsDryPeriodTen.RemoveParameterByName("result_name")
            clsDryPeriodTen.RemoveParameterByName("save")
            clsDryPeriodTenList.RemoveParameterByName("sub1")
        End If
    End Sub

    Private Sub DryPeriodRainPeriod()
        If Not ucrReceiverRainfall.IsEmpty Then
            clsDPRainInDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsDPRainInDays.AddParameter("function_exp", Chr(34) & "rollapply(data = " & ucrReceiverRainfall.GetVariableNames(False) & " ,width = " & nudDPRainPeriod.Value & ", FUN = sum, na.rm = FALSE, align='left', fill=NA)" & Chr(34))
            clsDPRainInDays.AddParameter("result_name", Chr(34) & "Rain_in_Days" & Chr(34))
            clsDPRainInDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")")
            clsDPRainInDays.AddParameter("save", "0")
        Else
            clsDPRainInDays.RemoveParameterByName("type")
            clsDPRainInDays.RemoveParameterByName("function_exp")
            clsDPRainInDays.RemoveParameterByName("result_name")
            clsDPRainInDays.RemoveParameterByName("calculated_from")
            clsDPRainInDays.RemoveParameterByName("save")
        End If
    End Sub

    Private Sub DryPeriodAboveThreshold()
        ' If this value is above 40mm, then give it a 0. Otherwise, give it a 1. (i.e., if there is a 20 day period of under 40mm of rain, it is "1")
        If chkDryPeriod.Checked Then
            clsDPRain.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsDPRain.AddParameter("function_exp", Chr(34) & "match( Rain_in_Days <=" & nudDPMaxRain.Value & ", 1, nomatch = 0)" & Chr(34))
            clsDPRain.AddParameter("result_name", Chr(34) & "Above_Threshold" & Chr(34))
            clsDPRain.AddParameter("sub_calculations", clsRFunctionParameter:=clsDPRainList)
            clsDPRainList.AddParameter("sub1", clsRFunctionParameter:=clsDPRainInDays, bIncludeArgumentName:=False)
            clsDPRain.AddParameter("save", 0)
            '            clsSubRainDays.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
        Else
            clsDPRain.RemoveParameterByName("type")
            clsDPRain.RemoveParameterByName("function_exp")
            clsDPRain.RemoveParameterByName("result_name")
            clsDPRain.RemoveParameterByName("sub_calculations")
            clsDPRainList.RemoveParameterByName("sub1")
            clsDPRain.RemoveParameterByName("save")
        End If
    End Sub

    Private Sub DryPeriodOverallInterval()
        ' # Rolling sum of that ^ of a 45 day period (i.e., for the next 45 days, how many times does rainfall over 20 days not reach 40mm?)
        If Not ucrReceiverRainfall.IsEmpty Then
            clsDPOverallInterval.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsDPOverallInterval.AddParameter("function_exp", Chr(34) & "rollapply(data = Above_Threshold ,width = (" & nudDPOverallInterval.Value & "-" & nudDPRainPeriod.Value & "+ 1), FUN = sum, na.rm = FALSE, align='left', fill=NA)" & Chr(34))
            clsDPOverallInterval.AddParameter("result_name", Chr(34) & "DP_Overall_Interval_Rain" & Chr(34))
            clsDPOverallInterval.AddParameter("sub_calculations", clsRFunctionParameter:=clsDPOverallIntervalList)
            clsDPOverallIntervalList.AddParameter("sub1", clsRFunctionParameter:=clsDPRain, bIncludeArgumentName:=False)
            clsDPOverallInterval.AddParameter("save", "2")
        Else
            clsDPOverallInterval.RemoveParameterByName("type")
            clsDPOverallInterval.RemoveParameterByName("function_exp")
            clsDPOverallInterval.RemoveParameterByName("result_name")
            clsDPOverallInterval.RemoveParameterByName("sub_calculations")
            clsDPOverallInterval.RemoveParameterByName("sub1")
            clsDPOverallInterval.RemoveParameterByName("save")
        End If
    End Sub

    Private Sub CombinedFilter()
        clsCombinedFilter.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsCombinedFilter.AddParameter("sub_calculations", clsRFunctionParameter:=clsCombinedList)

        ' Run with all first, then sort out to separate bits.
        ' do six if statements for now

        If chkConsecutiveRainyDays.Checked AndAlso chkTotalRainfall.Checked AndAlso chkDrySpell.Checked Then
            clsCombinedFilter.RemoveParameterByName("function_exp")
            If rdoAmount.Checked Then
                clsCombinedFilter.AddParameter("function_exp", Chr(34) & "Dry_Spell < " & nudMaximumDays.Value & "& Rolling_Rain_Days >=" & nudMinimum.Value & "& roll_sum_Rain >20 & " & ucrReceiverRainfall.GetVariableNames(False) & ">0.85" & Chr(34))
                clsCombinedList.RemoveParameterByName("sub4")
            ElseIf rdoPercentile.Checked Then
                clsCombinedFilter.AddParameter("function_exp", Chr(34) & "Dry_Spell <" & nudMaximumDays.Value & "& Rolling_Rain_Days >=" & nudMinimum.Value & "& roll_sum_Rain > wet_spell & " & ucrReceiverRainfall.GetVariableNames(False) & ">0.85" & Chr(34))
                clsCombinedList.AddParameter("sub4", clsRFunctionParameter:=clsWetSpell, bIncludeArgumentName:=False)
            End If
            clsCombinedList.AddParameter("sub1", clsRFunctionParameter:=clsDryPeriodTen, bIncludeArgumentName:=False)
            clsCombinedList.AddParameter("sub3", clsRFunctionParameter:=clsRollingSum, bIncludeArgumentName:=False)
            clsCombinedList.AddParameter("sub2", clsRFunctionParameter:=clsRollingRainDays, bIncludeArgumentName:=False)


        ElseIf chkTotalRainfall.Checked AndAlso chkDrySpell.Checked Then
            clsCombinedFilter.RemoveParameterByName("function_exp")

            If rdoAmount.Checked Then
                clsCombinedFilter.AddParameter("function_exp", Chr(34) & "Dry_Spell <" & nudMaximumDays.Value & " & roll_sum_Rain >20 & " & ucrReceiverRainfall.GetVariableNames(False) & ">0.85" & Chr(34))
                clsCombinedList.RemoveParameterByName("sub4")
            ElseIf rdoPercentile.Checked Then
                clsCombinedFilter.AddParameter("function_exp", Chr(34) & "Dry_Spell <" & nudMaximumDays.Value & " & roll_sum_Rain >wet_spell & " & ucrReceiverRainfall.GetVariableNames(False) & ">0.85" & Chr(34))
                clsCombinedList.AddParameter(“sub4”, clsRFunctionParameter:=clsWetSpell, bIncludeArgumentName:=False)
                clsCombinedList.AddParameter("sub4", clsRFunctionParameter:=clsWetSpell, bIncludeArgumentName:=False)
            End If
            clsCombinedList.AddParameter("sub1", clsRFunctionParameter:=clsDryPeriodTen, bIncludeArgumentName:=False)
            clsCombinedList.AddParameter("sub3", clsRFunctionParameter:=clsRollingSum, bIncludeArgumentName:=False)
            clsCombinedList.RemoveParameterByName("sub2")



        ElseIf chkConsecutiveRainyDays.Checked AndAlso chkDrySpell.Checked Then
            clsCombinedFilter.RemoveParameterByName("function_exp")
            clsCombinedFilter.AddParameter("function_exp", Chr(34) & "Dry_Spell <" & nudMaximumDays.Value & " & Rolling_Rain_Days >= " & Chr(34) & nudMinimum.Value & Chr(34) & "&" & ucrReceiverRainfall.GetVariableNames(False) & ">0.85" & Chr(34))
            clsCombinedList.AddParameter("sub1", clsRFunctionParameter:=clsDryPeriodTen, bIncludeArgumentName:=False)
            clsCombinedList.RemoveParameterByName("sub3")
            clsCombinedList.AddParameter("sub2", clsRFunctionParameter:=clsRollingRainDays, bIncludeArgumentName:=False)


        ElseIf chkConsecutiveRainyDays.Checked AndAlso chkTotalRainfall.Checked Then
            clsCombinedFilter.RemoveParameterByName("function_exp")
            If rdoAmount.Checked Then
                clsCombinedFilter.AddParameter("function_exp", Chr(34) & "Rolling_Rain_Days >= " & nudMinimum.Value & " & roll_sum_Rain >20 & " & ucrReceiverRainfall.GetVariableNames(False) & ">0.85" & Chr(34))
                clsCombinedList.RemoveParameterByName("sub4")
            ElseIf rdoPercentile.Checked Then
                clsCombinedFilter.AddParameter("function_exp", Chr(34) & "Rolling_Rain_Days >= " & nudMinimum.Value & " & roll_sum_Rain > wet_spell & " & ucrReceiverRainfall.GetVariableNames(False) & ">0.85" & Chr(34))
                clsCombinedList.AddParameter("sub4", clsRFunctionParameter:=clsWetSpell, bIncludeArgumentName:=False)
            End If
            clsCombinedList.RemoveParameterByName("sub1")
            clsCombinedList.AddParameter("sub3", clsRFunctionParameter:=clsRollingSum, bIncludeArgumentName:=False)
            clsCombinedList.AddParameter("sub2", clsRFunctionParameter:=clsRollingRainDays, bIncludeArgumentName:=False)

        ElseIf chkConsecutiveRainyDays.Checked Then
            clsCombinedFilter.RemoveParameterByName("function_exp")
            clsCombinedFilter.AddParameter("function_exp", Chr(34) & "Rolling_Rain_Days >= " & nudMinimum.Value & "&" & ucrReceiverRainfall.GetVariableNames(False) & ">0.85" & Chr(34))
            clsCombinedList.RemoveParameterByName("sub1")
            clsCombinedList.RemoveParameterByName("sub3")
            clsCombinedList.AddParameter("sub2", clsRFunctionParameter:=clsRollingRainDays, bIncludeArgumentName:=False)

        ElseIf chkTotalRainfall.Checked Then
            clsCombinedFilter.RemoveParameterByName("function_exp")
            If rdoAmount.Checked Then
                clsCombinedFilter.AddParameter("function_exp", Chr(34) & "roll_sum_Rain >20 &" & ucrReceiverRainfall.GetVariableNames(False) & ">0.85" & Chr(34))
                clsCombinedList.RemoveParameterByName("sub4")
            ElseIf rdoPercentile.Checked Then
                clsCombinedFilter.AddParameter("function_exp", Chr(34) & "roll_sum_Rain > wet_spell & " & ucrReceiverRainfall.GetVariableNames(False) & ">0.85" & Chr(34))
                clsCombinedList.AddParameter("sub4", clsRFunctionParameter:=clsWetSpell, bIncludeArgumentName:=False)
            End If

            clsCombinedList.RemoveParameterByName("sub1")
            clsCombinedList.AddParameter("sub3", clsRFunctionParameter:=clsRollingSum, bIncludeArgumentName:=False)
            clsCombinedList.RemoveParameterByName("sub2")

        ElseIf chkDrySpell.Checked Then
            clsCombinedFilter.RemoveParameterByName("function_exp")
            clsCombinedFilter.AddParameter("function_exp", Chr(34) & "Dry_Spell <" & nudMaximumDays.Value & "&" & ucrReceiverRainfall.GetVariableNames(False) & ">0.85" & Chr(34))
            clsCombinedList.AddParameter("sub1", clsRFunctionParameter:=clsDryPeriodTen, bIncludeArgumentName:=False)
            clsCombinedList.RemoveParameterByName("sub3")
            clsCombinedList.RemoveParameterByName("sub2")
        Else
            clsCombinedFilter.RemoveParameterByName("function_exp")
            clsCombinedFilter.RemoveParameterByName("type")
            clsCombinedFilter.RemoveParameterByName("sub_calculations")
            clsCombinedList.RemoveParameterByName("sub1")
            clsCombinedList.RemoveParameterByName("sub2")
            clsCombinedList.RemoveParameterByName("sub3")
            clsCombinedList.RemoveParameterByName("sub4")
        End If

        '        If chkDryPeriod.Checked Then
        '            clsCombinedFilter.RemoveParameterByName("function_exp")
        '        clsCombinedFilter.AddParameter("function_exp", Chr(34) & "DP_Overall_Interval_Rain == 0 & ucrReceiverRainfall.GetVariableNames(False)>0.85" & Chr(34))
    End Sub

    Private Sub FirstDOYPerYear()
        ' run these when things are checked
        If Not ucrReceiverDOY.IsEmpty Then

            clsManipulationFirstDOYPerYear.AddParameter("sub1", clsRFunctionParameter:=clsCombinedFilter, bIncludeArgumentName:=False)
            clsManipulationFirstDOYPerYear.AddParameter("sub2", clsRFunctionParameter:=clsYearGroupDaily, bIncludeArgumentName:=False)
            clsManipulationFirstDOYPerYear.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)

            clsFirstDOYPerYear.AddParameter("type", Chr(34) & "summary" & Chr(34))
            clsFirstDOYPerYear.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34))
            clsFirstDOYPerYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
            clsFirstDOYPerYear.AddParameter("manipulations", clsRFunctionParameter:=clsManipulationFirstDOYPerYear)
            clsFirstDOYPerYear.AddParameter("result_name", Chr(34) & "First_Possible_Onset_wet_season" & Chr(34))
            clsFirstDOYPerYear.AddParameter("save", 2)

        Else
            clsManipulationFirstDOYPerYear.RemoveParameterByName("sub1")
            clsManipulationFirstDOYPerYear.RemoveParameterByName("sub2")
            clsManipulationFirstDOYPerYear.RemoveParameterByName("sub3")
            clsFirstDOYPerYear.RemoveParameterByName("type")
            clsFirstDOYPerYear.RemoveParameterByName("function_exp")
            clsFirstDOYPerYear.RemoveParameterByName("calculated_from")
            clsFirstDOYPerYear.RemoveParameterByName("manipulations")
        End If
    End Sub

    Private Sub YearGroupDaily()
        clsYearGroupDaily.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsYearGroupDaily.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
    End Sub

    Private Sub firstDayofTheYear()
        ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsFirstDOYPerYear)
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        frmMain.clsRLink.RunScript(clsAddKey.ToScript, strComment:="Start of Rains: Defining Date column as key")
    End Sub
End Class