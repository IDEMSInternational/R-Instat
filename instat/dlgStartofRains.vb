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
    Public clsAddKey, clsDayFromAndTo, clsRainyDays, clsFirstDOYPerYear, clsYearGroupDaily, clsManipulationFirstDOYPerYear, clsCombinedFilter, clsCombinedList As New RFunction
    'Total Rainfall classes
    Private clsTRRollingSum, clsTRWetSpell, clsTRWetSpellList As New RFunction
    'Rainy Day classes
    Private clsSubRDRainDays1, clsRDRollingRainDays As New RFunction
    'Dry Spell classes
    Private clsDSDryPeriodTen, clsDSDrySpell, clsDSDryPeriodTenList, clsSubDSRainDays2 As New RFunction
    'Dry Period classes
    Private clsDPOverallInterval, clsDPOverallIntervalList, clsDPRain, clsDPRainList, clsDPRainInDays As New RFunction
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
        ucrBase.iHelpTopicID = 199
        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.SetAssignTo("Day_From_and_To")
        clsYearGroupDaily.SetRCommand("instat_calculation$new")
        clsYearGroupDaily.SetAssignTo("Year_Group_Daily")
        clsRainyDays.SetRCommand("instat_calculation$new")
        clsTRRollingSum.SetRCommand("instat_calculation$new")
        clsTRRollingSum.SetAssignTo("rolling_sum_day")
        'clsMinimumRainfall.SetRCommand("instat_calculation$new")
        'clsMinimumRainfall.SetAssignTo("Minimum_Rainfall")
        clsRDRollingRainDays.SetRCommand("instat_calculation$new")
        clsRDRollingRainDays.SetAssignTo("Rolling_rain")
        clsFirstDOYPerYear.SetRCommand("instat_calculation$new")
        clsFirstDOYPerYear.SetAssignTo("First_doy_per_year")
        clsDSDryPeriodTen.SetRCommand("instat_calculation$new")
        clsDSDryPeriodTen.SetAssignTo("Dry_Period_10")
        clsDSDrySpell.SetRCommand("instat_calculation$new")
        clsDSDrySpell.SetAssignTo("Dry_Spell")
        'clsWithinThirtyDays.SetRCommand("instat_calculation$new")
        'clsWithinThirtyDays.SetAssignTo("dry_spell_10")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$apply_instat_calculation")
        clsSubRDRainDays1.SetRCommand("list")
        clsSubDSRainDays2.SetRCommand("list")
        clsCombinedList.SetRCommand("list")
        clsManipulationFirstDOYPerYear.SetRCommand("list")
        clsDSDryPeriodTenList.SetRCommand("list")
        clsTRWetSpellList.SetRCommand("list")
        clsTRWetSpell.SetRCommand("instat_calculation$new")
        clsTRWetSpell.SetAssignTo("Wet_Spell")

        clsCombinedFilter.SetRCommand("instat_calculation$new")
        clsCombinedFilter.SetAssignTo("combined_filter")

        ucrReceiverRainfall.Selector = ucrSelectorForStartofRains
        ucrReceiverYear.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.Selector = ucrSelectorForStartofRains
        ucrReceiverDOY.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.SetMeAsReceiver()

        nudTRPercentile.Minimum = 0
        nudTRPercentile.Maximum = 1
        nudTRPercentile.DecimalPlaces = 2
        nudTRPercentile.Increment = 0.1

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

        'save
        ucrSaveStartofRains.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrSaveStartofRains.SetLabelText("New Column Name:")
        ucrSaveStartofRains.SetIsTextBox()
        ucrSaveStartofRains.SetPrefix("Start_of_Rains")
        ucrSaveStartofRains.SetSaveTypeAsColumn()
    End Sub

    Private Sub SetDefaults()
        ucrSaveStartofRains.Reset()

        ucrSelectorForStartofRains.Reset()
        chkConsecutiveRainyDays.Checked = False
        chkDrySpell.Checked = False
        chkTotalRainfall.Checked = False
        chkDryPeriod.Checked = False
        CheckBoxesSetting()
        TestOKEnabled()
        nudTRAmount.Value = 20
        nudTRPercentile.Value = 0.8
        nudRDMinimum.Value = 1
        nudDSMaximumDays.Value = 10
        nudDSLengthofTime.Value = 30
        nudTROverDays.Value = 2
        nudThreshold.Value = 0.85
        rdoTRAmount.Checked = True
        nudDPMaxRain.Value = 40
        nudDPRainPeriod.Value = 30
        nudDPOverallInterval.Value = 45
        nudFrom.Value = 1
        nudTo.Value = 366
        'DefaultNudValue()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveStartofRains.IsComplete AndAlso Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso nudThreshold.Text <> "" AndAlso nudFrom.Text <> "" AndAlso nudTo.Text <> "" AndAlso ((chkConsecutiveRainyDays.Checked AndAlso nudRDMinimum.Text <> "" AndAlso nudRDOutOfDays.Text <> "") OrElse Not chkConsecutiveRainyDays.Checked) AndAlso (((chkTotalRainfall.Checked AndAlso nudTROverDays.Text <> "") AndAlso ((rdoTRAmount.Checked AndAlso nudTRAmount.Text <> "") OrElse (rdoTRPercentile.Checked AndAlso nudTRPercentile.Text <> ""))) OrElse Not chkTotalRainfall.Checked) AndAlso ((chkDrySpell.Checked AndAlso nudDSMaximumDays.Text <> "" AndAlso nudDSLengthofTime.Text <> "") OrElse Not chkDrySpell.Checked) AndAlso ((chkDryPeriod.Checked AndAlso nudDPMaxRain.Text <> "" AndAlso nudDPRainPeriod.Text <> "" AndAlso nudDPOverallInterval.Text <> "") OrElse Not chkDryPeriod.Checked) Then
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
        CombinedFilter()
        TestOKEnabled()
    End Sub

    Private Sub DryPeriod(sender As Object, e As EventArgs) Handles nudDPRainPeriod.TextChanged, nudDPOverallInterval.TextChanged, nudDPMaxRain.TextChanged, chkDryPeriod.CheckedChanged
        CheckBoxesSetting()
        DryPeriod()
        nudValues()
        TestOKEnabled()
    End Sub

    Private Sub TotalRainfall(sender As Object, e As EventArgs) Handles nudTROverDays.TextChanged, chkTotalRainfall.CheckedChanged, rdoTRAmount.CheckedChanged, rdoTRPercentile.CheckedChanged
        CheckBoxesSetting()
        CombinedFilter()
        RollingSumMethod()
        TotalRainPercentileWetSpell()
        nudValues() ' new
        'DefaultNudValue()
        TestOKEnabled()
    End Sub

    Private Sub TotalRainfallNuds(sender As Object, e As EventArgs) Handles nudTRAmount.TextChanged, nudTRPercentile.TextChanged
        CombinedFilter()
        TestOKEnabled()
    End Sub

    Private Sub RainyDays(sender As Object, e As EventArgs) Handles nudRDMinimum.TextChanged, nudRDOutOfDays.TextChanged, chkConsecutiveRainyDays.CheckedChanged
        CheckBoxesSetting()
        RollingOfRainDays()
        nudValues()
        CombinedFilter()
        TestOKEnabled()
    End Sub

    Private Sub DrySpell(sender As Object, e As EventArgs) Handles nudDSLengthofTime.ValueChanged, nudDSMaximumDays.ValueChanged, chkDrySpell.CheckedChanged
        CheckBoxesSetting()
        DrySpell()
        nudValues()
        CombinedFilter()
        TestOKEnabled()
    End Sub


    'Private Sub grpConditionsForStartofRains_Enter(sender As Object, e As EventArgs) Handles nudTRAmount.TextChanged, nudTRPercentile.TextChanged, nudRDMinimum.TextChanged, nudDSMaximumDays.TextChanged, nudDSLengthofTime.TextChanged, nudTROverDays.TextChanged, nudRDOutOfDays.TextChanged
    '    RainyDaysMethod()
    '    DayFromAndToMethod()
    '    CombinedFilter()
    '    RollingOfRainDays()
    '    DrySpell()
    '    RollingSumMethod()
    '    TotalRainPercentileWetSpell()
    '    nudValues()
    '    TestOKEnabled()
    'End Sub

    'Private Sub grpConditionsForStartofRains1_Enter(sender As Object, e As EventArgs) Handles chkConsecutiveRainyDays.CheckedChanged, chkTotalRainfall.CheckedChanged, chkDrySpell.CheckedChanged, chkDryPeriod.CheckedChanged
    '    CheckBoxesSetting()
    '    DrySpell()
    '    RainyDaysMethod()
    '    CombinedFilter()
    '    FirstDOYPerYear()
    '    TestOKEnabled()
    '    nudValues()
    'End Sub

    ' yep
    Private Sub ucrReceiverRainfall_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRainfall.SelectionChanged
        RainyDaysMethod()
        RollingSumMethod()
        DryPeriod()
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
            nudTRAmount.Visible = False
            nudTRPercentile.Visible = False
            If rdoTRAmount.Checked Then
                nudTRAmount.Visible = True
                nudTRPercentile.Visible = False
            ElseIf rdoTRPercentile.Checked Then
                nudTRAmount.Visible = False
                nudTRPercentile.Visible = True
            Else
                nudTRAmount.Visible = False
                nudTRPercentile.Visible = False
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
            nudRDMinimum.Maximum = nudRDOutOfDays.Value - 1
            nudRDOutOfDays.Minimum = nudRDMinimum.Value + 1
        End If
        If chkDrySpell.Checked Then
            nudDSMaximumDays.Maximum = nudDSLengthofTime.Value - 1
            nudDSLengthofTime.Minimum = nudDSMaximumDays.Value + 1
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
        If chkTotalRainfall.Checked AndAlso Not ucrReceiverRainfall.IsEmpty Then
            clsTRRollingSum.AddParameter("function_exp", Chr(34) & " zoo::rollapply(data = " & ucrReceiverRainfall.GetVariableNames(False) & " ,width = " & nudTROverDays.Value & ", FUN = sum, na.rm = FALSE, align='right', fill=NA)" & Chr(34))
            clsTRRollingSum.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsTRRollingSum.AddParameter("result_name", Chr(34) & "roll_sum_Rain" & Chr(34))
            clsTRRollingSum.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")")
            clsTRRollingSum.AddParameter("save", 0)
        Else
            clsTRRollingSum.RemoveParameterByName("function_exp")
            clsTRRollingSum.RemoveParameterByName("type")
            clsTRRollingSum.RemoveParameterByName("result_name")
            clsTRRollingSum.RemoveParameterByName("calculated_from")
            clsTRRollingSum.RemoveParameterByName("save")
        End If
    End Sub

    ' If we have 'Percentile' checked
    Private Sub TotalRainPercentileWetSpell()
        If rdoTRPercentile.Checked Then
            clsTRWetSpell.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsTRWetSpell.AddParameter("function_exp", Chr(34) & "quantile(roll_sum_Rain, c(" & nudTRPercentile.Value & "), na.rm=T)" & Chr(34))
            clsTRWetSpell.AddParameter("result_name", Chr(34) & "wet_spell" & Chr(34))
            clsTRWetSpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsTRWetSpellList)
            clsTRWetSpellList.AddParameter("sub1", clsRFunctionParameter:=clsTRRollingSum, bIncludeArgumentName:=False)
            clsTRWetSpell.AddParameter("save", "0")
        Else
            clsTRWetSpell.RemoveParameterByName("type")
            clsTRWetSpell.RemoveParameterByName("function_exp")
            clsTRWetSpell.RemoveParameterByName("result_name")
            clsTRWetSpell.RemoveParameterByName("sub_calculations")
            clsTRWetSpellList.RemoveParameterByName("sub1")
            clsTRWetSpell.RemoveParameterByName("save")
        End If
    End Sub

    Private Sub RollingOfRainDays()
        '  If rolling of rain days one is checked Then
        clsRDRollingRainDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsRDRollingRainDays.AddParameter("function_exp", Chr(34) & "zoo::rollapply(data=rain_day, width = " & nudRDOutOfDays.Value & ", FUN = sum, na.rm = FALSE, align = 'right', fill=NA)" & Chr(34))
        clsRDRollingRainDays.AddParameter("result_name", Chr(34) & "Rolling_Rain_Days" & Chr(34))
        clsRDRollingRainDays.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubRDRainDays1)
        clsSubRDRainDays1.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
        clsRDRollingRainDays.AddParameter("save", 0)
    End Sub

    Private Sub DrySpell()
        If chkDrySpell.Checked Then
            clsDSDrySpell.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsDSDrySpell.AddParameter("function_exp", Chr(34) & "cumsum(rain_day==0)-cummax((rain_day)*cumsum(rain_day==0))" & Chr(34))
            clsDSDrySpell.AddParameter("result_name", Chr(34) & "Dry_Spell" & Chr(34))
            clsDSDrySpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubDSRainDays2)
            clsSubDSRainDays2.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
            clsDSDrySpell.AddParameter("save", 0)
            clsDSDryPeriodTen.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsDSDryPeriodTen.AddParameter("function_exp", Chr(34) & "zoo::rollapply(data = Dry_Spell, width=" & nudDSLengthofTime.Value & ", FUN=max, na.rm = FALSE, align='left', fill=NA)" & Chr(34))
            clsDSDryPeriodTen.AddParameter("result_name", Chr(34) & "Dry_Spell" & Chr(34))
            clsDSDryPeriodTen.AddParameter("sub_calculations", clsRFunctionParameter:=clsDSDryPeriodTenList)
            clsDSDryPeriodTenList.AddParameter("sub1", clsRFunctionParameter:=clsDSDrySpell, bIncludeArgumentName:=False)
            clsDSDryPeriodTen.AddParameter("save", 2)
        Else
            clsDSDrySpell.RemoveParameterByName("type")
            clsDSDrySpell.RemoveParameterByName("function_exp")
            clsDSDrySpell.RemoveParameterByName("result_name")
            clsDSDrySpell.RemoveParameterByName("sub_calculations")
            clsSubDSRainDays2.RemoveParameterByName("sub1")
            clsDSDrySpell.RemoveParameterByName("save")
            clsDSDryPeriodTen.RemoveParameterByName("type")
            clsDSDryPeriodTen.RemoveParameterByName("function_exp")
            clsDSDryPeriodTen.RemoveParameterByName("sub_calculations")
            clsDSDryPeriodTen.RemoveParameterByName("result_name")
            clsDSDryPeriodTen.RemoveParameterByName("save")
            clsDSDryPeriodTenList.RemoveParameterByName("sub1")
        End If
    End Sub

    Private Sub DryPeriod()
        If chkDryPeriod.Checked Then
            clsDPRainInDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsDPRainInDays.AddParameter("function_exp", Chr(34) & "zoo::rollapply(data = " & ucrReceiverRainfall.GetVariableNames(False) & " ,width = " & nudDPRainPeriod.Value & ", FUN = sum, na.rm = FALSE, align='left', fill=NA)" & Chr(34))
            clsDPRainInDays.AddParameter("result_name", Chr(34) & "Rain_in_Days" & Chr(34))
            clsDPRainInDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")")
            clsDPRainInDays.AddParameter("save", "0")

            clsDPRain.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsDPRain.AddParameter("function_exp", Chr(34) & "match( Rain_in_Days <= " & nudDPMaxRain.Value & ", 1, nomatch = 0)" & Chr(34))
            clsDPRain.AddParameter("result_name", Chr(34) & "Above_Threshold" & Chr(34))
            clsDPRain.AddParameter("sub_calculations", clsRFunctionParameter:=clsDPRainList)
            clsDPRainList.AddParameter("sub1", clsRFunctionParameter:=clsDPRainInDays, bIncludeArgumentName:=False)
            clsDPRain.AddParameter("save", 0)

            clsDPOverallInterval.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsDPOverallInterval.AddParameter("function_exp", Chr(34) & "zoo::rollapply(data = Above_Threshold ,width = (" & nudDPOverallInterval.Value & "-" & nudDPRainPeriod.Value & "+ 1), FUN = sum, na.rm = FALSE, align='left', fill=NA)" & Chr(34))
            clsDPOverallInterval.AddParameter("result_name", Chr(34) & "DP_Overall_Interval_Rain" & Chr(34))
            clsDPOverallInterval.AddParameter("sub_calculations", clsRFunctionParameter:=clsDPOverallIntervalList)
            clsDPOverallIntervalList.AddParameter("sub1", clsRFunctionParameter:=clsDPRain, bIncludeArgumentName:=False)
            clsDPOverallInterval.AddParameter("save", "2")
        Else
            clsDPRainInDays.RemoveParameterByName("type")
            clsDPRainInDays.RemoveParameterByName("function_exp")
            clsDPRainInDays.RemoveParameterByName("result_name")
            clsDPRainInDays.RemoveParameterByName("calculated_from")
            clsDPRainInDays.RemoveParameterByName("save")
            clsDPRain.RemoveParameterByName("type")
            clsDPRain.RemoveParameterByName("function_exp")
            clsDPRain.RemoveParameterByName("result_name")
            clsDPRain.RemoveParameterByName("sub_calculations")
            clsDPRainList.RemoveParameterByName("sub1")
            clsDPRain.RemoveParameterByName("save")
            clsDPOverallInterval.RemoveParameterByName("type")
            clsDPOverallInterval.RemoveParameterByName("function_exp")
            clsDPOverallInterval.RemoveParameterByName("result_name")
            clsDPOverallInterval.RemoveParameterByName("sub_calculations")
            clsDPOverallInterval.RemoveParameterByName("sub1")
            clsDPOverallInterval.RemoveParameterByName("save")
        End If
    End Sub

    Private Sub CombinedFilter()
        Dim strTempFunExpression As String = Chr(34)
        clsCombinedFilter.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsCombinedFilter.AddParameter("sub_calculations", clsRFunctionParameter:=clsCombinedList)

        clsCombinedFilter.RemoveParameterByName("function_exp")

        If chkTotalRainfall.Checked Then
            strTempFunExpression = strTempFunExpression & "roll_sum_Rain > "
            If rdoTRAmount.Checked Then
                strTempFunExpression = strTempFunExpression & nudTRAmount.Value
                clsCombinedList.RemoveParameterByName("sub4")
            ElseIf rdoTRPercentile.Checked Then
                strTempFunExpression = strTempFunExpression & "wet_spell"
                clsCombinedList.AddParameter("sub4", clsRFunctionParameter:=clsTRWetSpell, bIncludeArgumentName:=False)
            End If
            strTempFunExpression = strTempFunExpression & " & "
            clsCombinedList.AddParameter("sub3", clsRFunctionParameter:=clsTRRollingSum, bIncludeArgumentName:=False)
        Else
            clsCombinedList.RemoveParameterByName("sub3")
        End If
        If chkConsecutiveRainyDays.Checked Then
            strTempFunExpression = strTempFunExpression & "Rolling_Rain_Days >= " & nudRDMinimum.Value & " & "
            clsCombinedList.AddParameter("sub2", clsRFunctionParameter:=clsRDRollingRainDays, bIncludeArgumentName:=False)
        Else
            clsCombinedList.RemoveParameterByName("sub2")
        End If
        If chkDrySpell.Checked Then
            strTempFunExpression = strTempFunExpression & "Dry_Spell < " & nudDSMaximumDays.Value & " & "
            clsCombinedList.AddParameter("sub1", clsRFunctionParameter:=clsDSDryPeriodTen, bIncludeArgumentName:=False)
        Else
            clsCombinedList.RemoveParameterByName("sub1")
        End If
        If chkDryPeriod.Checked Then
            strTempFunExpression = strTempFunExpression & "DP_Overall_Interval_Rain == 0 " & " & "
            clsCombinedList.AddParameter("sub5", clsRFunctionParameter:=clsDPOverallInterval, bIncludeArgumentName:=False)
        Else
            clsCombinedList.RemoveParameterByName("sub5")
        End If

        strTempFunExpression = strTempFunExpression & ucrReceiverRainfall.GetVariableNames(False) & ">=" & nudThreshold.Value & Chr(34)

        clsCombinedFilter.AddParameter("function_exp", strTempFunExpression)
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
            clsFirstDOYPerYear.AddParameter("result_name", Chr(34) & ucrSaveStartofRains.GetText() & Chr(34))
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

    Private Sub ucrSaveStartofRains_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveStartofRains.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSaveStartofRains_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveStartofRains.ControlValueChanged
        clsFirstDOYPerYear.SetAssignTo(ucrSaveStartofRains.ucrInputTextSave.GetText)
        FirstDOYPerYear()
    End Sub

    'Private Sub DefaultNudValue()
    '    nudRDOutOfDays.Value = nudTROverDays.Value ' crashes if I go to 100+, can crash upon a reset, also what if I change the nudOverDays then the nudOutofDays - then I lose my nudOverDays value I put in
    'End Sub
End Class