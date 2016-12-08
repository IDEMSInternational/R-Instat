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
    Public clsAddKey, clsDayFromAndTo, clsRainyDays, clsRollingSum, clsMinimumRainfall, clsRollingRainDays, clsXdaysRain, clsFirstDOYPerYear, clsDryPeriodTen, clsWithinThirtyDays, clsDrySpell, clsYearGroupDaily, clsSubCalcMinSum, clsSubCalcXDaysRain, clsSubCalcNoTenInThirty, clsManipulationFirstDOYPerYear, clsApplyRainDays As New RFunction
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
        clsRainyDays.SetRCommand("instat_calculation$new")
        'clsRainyDays.SetAssignTo("Rainy_Days")
        clsRollingSum.SetRCommand("instat_calculation$new")
        clsRollingSum.SetAssignTo("rolling_sum")
        clsMinimumRainfall.SetRCommand("instat_calculation$new")
        clsMinimumRainfall.SetAssignTo("Minimum_Rainfall")
        clsRollingRainDays.SetRCommand("instat_calculation$new")
        clsRollingRainDays.SetAssignTo("Rolling_Of_rain_days")
        clsXdaysRain.SetRCommand("instat_calculation$new")
        clsXdaysRain.SetAssignTo("x_Days_Rain")
        clsFirstDOYPerYear.SetRCommand("instat_calculation$new")
        clsFirstDOYPerYear.SetAssignTo("First_doy_per_year")
        clsDryPeriodTen.SetRCommand("instat_calculation$new")
        clsDryPeriodTen.SetAssignTo("Dry_Period_10")
        clsDrySpell.SetRCommand("instat_calculation$new")
        clsDrySpell.SetAssignTo("Dry_Spell")
        clsWithinThirtyDays.SetRCommand("instat_calculation$new")
        clsWithinThirtyDays.SetAssignTo("dry_spell_no_10_in_30")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$apply_instat_calculation")
        clsApplyRainDays.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$apply_instat_calculation")
        clsApplyRainDays.AddParameter("calc", clsRFunctionParameter:=clsRainyDays)
        clsSubCalcMinSum.SetRCommand("list")
        clsSubCalcXDaysRain.SetRCommand("list")
        clsSubCalcNoTenInThirty.SetRCommand("list")
        clsManipulationFirstDOYPerYear.SetRCommand("list")
        ucrReceiverRainfall.Selector = ucrSelectorForStartofRains
        ucrReceiverRainfall.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.Selector = ucrSelectorForStartofRains
        ucrReceiverDOY.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.SetMeAsReceiver()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorForStartofRains.Reset()
        chkConsecutiveRainyDays.Checked = False
        chkDrySpell.Checked = False
        chkTotalRainfall.Checked = False
        CheckBoxesSetting()
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If Not (ucrReceiverRainfall.IsEmpty AndAlso ucrReceiverDate.IsEmpty AndAlso ucrReceiverDOY.IsEmpty) Then
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
        TestOKEnabled()
    End Sub

    Private Sub grpConditionsForSatrtofRains_Enter(sender As Object, e As EventArgs) Handles nudValue.TextChanged, nudMinimum.TextChanged, nudMaximumDays.TextChanged, nudLengthofTime.TextChanged, nudOverDays.TextChanged
        RainyDaysMethod()
        MinimumRainfallMethod()
        XDaysRainMethod()
        PeriodWithinThirtyDays()
        TestOKEnabled()
    End Sub

    Private Sub grpConditionsForSatrtofRains1_Enter(sender As Object, e As EventArgs) Handles chkConsecutiveRainyDays.CheckedChanged, chkTotalRainfall.CheckedChanged, chkDrySpell.CheckedChanged
        CheckBoxesSetting()
        MinimumRainfallMethod()
    End Sub
    Private Sub ucrReceiverRainfall_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRainfall.SelectionChanged
        RainyDaysMethod()
        RollingSumMethod()
    End Sub

    Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs)
        YearGroupDaily()
        AddKeyMethod()
    End Sub

    Private Sub CheckBoxesSetting()
        If chkTotalRainfall.Checked Then
            nudValue.Visible = True
            nudOverDays.Visible = True
            lblVal.Visible = True
            lblOverDays.Visible = True
        Else
            nudValue.Visible = False
            nudOverDays.Visible = False
            lblVal.Visible = False
            lblOverDays.Visible = False
        End If
        If chkDrySpell.Checked Then
            nudMaximumDays.Visible = True
            nudLengthofTime.Visible = True
            lblLengthofTime.Visible = True
            lblMaximumDays.Visible = True
        Else
            nudMaximumDays.Visible = False
            nudLengthofTime.Visible = False
            lblLengthofTime.Visible = False
            lblMaximumDays.Visible = False
        End If
        If chkConsecutiveRainyDays.Checked Then

            nudMinimum.Visible = True
            nudOutOfDays.Visible = True
            lblMinimum.Visible = True
            lblWidth.Visible = True
        Else
            nudMinimum.Visible = False
            nudOutOfDays.Visible = False
            lblMinimum.Visible = False
            lblWidth.Visible = False
        End If
    End Sub


    Private Sub AddKeyMethod()
        If Not ucrReceiverDate.IsEmpty Then
            clsAddKey.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
            clsAddKey.AddParameter("col_name", ucrReceiverDate.GetVariableNames)
        Else
            clsAddKey.RemoveParameterByName("col_name")
            clsAddKey.RemoveParameterByName("data_name")
        End If
    End Sub

    Private Sub DayFromAndToMethod()
        If nudFrom.Text <> "" AndAlso nudTo.Text <> "" AndAlso (Not ucrReceiverDOY.IsEmpty) Then
            clsDayFromAndTo.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & ">" & nudFrom.Value & " & " & ucrReceiverDOY.GetVariableNames(False) & "<" & nudTo.Value & Chr(34))
            clsDayFromAndTo.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
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
            clsRainyDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & Chr(34) & "Rain" & Chr(34) & ")")
            clsRainyDays.AddParameter("save", 2)
        Else
            clsRainyDays.RemoveParameterByName("type")
            clsRainyDays.RemoveParameterByName("function_exp")
            clsRainyDays.RemoveParameterByName("result_name")
            clsRainyDays.RemoveParameterByName("calculated_from")
            clsRainyDays.RemoveParameterByName("save")
        End If
    End Sub

    Private Sub RollingSumMethod()
        If Not ucrReceiverRainfall.IsEmpty Then
            clsRollingSum.AddParameter("function_exp", Chr(34) & " rollapply(data = " & ucrReceiverRainfall.GetVariableNames(False) & " ,width = " & nudOutOfDays.Value & ", FUN = sum, align='right', fill=NA)" & Chr(34))
            clsRollingSum.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsRollingSum.AddParameter("result_name", Chr(34) & "roll_sum_Rain" & Chr(34))
            clsRollingSum.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")")
            clsRollingSum.AddParameter("save", 1)
        Else
            clsRollingSum.RemoveParameterByName("function_exp")
            clsRollingSum.RemoveParameterByName("type")
            clsRollingSum.RemoveParameterByName("result_name")
            clsRollingSum.RemoveParameterByName("calculated_from")
            clsRollingSum.RemoveParameterByName("save")
        End If
    End Sub

    Private Sub MinimumRainfallMethod()
        If nudValue.Text <> "" Then
            clsMinimumRainfall.AddParameter("function_exp", Chr(34) & "roll_sum_Rain >" & nudValue.Value & Chr(34))
            clsMinimumRainfall.AddParameter("type", Chr(34) & "filter" & Chr(34))
            clsSubCalcMinSum.AddParameter("sub1", clsRFunctionParameter:=clsRollingSum, bIncludeArgumentName:=False)
            clsMinimumRainfall.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcMinSum)
        Else
            clsMinimumRainfall.RemoveParameterByName("function_exp")
            clsMinimumRainfall.RemoveParameterByName("type")
            clsMinimumRainfall.RemoveParameterByName("sub_calculations")
            clsSubCalcMinSum.RemoveParameterByName("sub1")
        End If
        RollingOfRainDays()
    End Sub

    Private Sub RollingOfRainDays()

        clsRollingRainDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsRollingRainDays.AddParameter("function_exp", Chr(34) & "rollapply(data=rain_day, width= " & nudOutOfDays.Value & ", FUN=sum, align = 'right', fill=NA)" & Chr(34))
        clsRollingRainDays.AddParameter("result_name", Chr(34) & "Rolling_Rain_Days" & Chr(34))
        clsRollingRainDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & Chr(34) & "rain_day" & Chr(34) & ")")
        clsRollingRainDays.AddParameter("save", 1)
    End Sub
    Private Sub XDaysRainMethod()
        If nudMinimum.Text <> "" Then
            clsXdaysRain.AddParameter("type", Chr(34) & "filter" & Chr(34))
            clsXdaysRain.AddParameter("function_exp", Chr(34) & "Rolling_Rain_Days >=" & nudMinimum.Value & Chr(34))
            clsSubCalcXDaysRain.AddParameter("sub1", clsRFunctionParameter:=clsRollingRainDays, bIncludeArgumentName:=False)
            clsXdaysRain.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcXDaysRain)
        Else
            clsXdaysRain.RemoveParameterByName("type")
            clsXdaysRain.RemoveParameterByName("function_exp")
            clsXdaysRain.RemoveParameterByName("sub_calculations")
            clsSubCalcXDaysRain.RemoveParameterByName("sub1")
        End If
        DrySpell()
    End Sub

    Private Sub DrySpell()
        clsDrySpell.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsDrySpell.AddParameter("function_exp", Chr(34) & "cumsum(rain_day==0)-cummax((rain_day)*cumsum(rain_day==0))" & Chr(34))
        clsDrySpell.AddParameter("result_name", Chr(34) & "Dry_Spell" & Chr(34))
        clsDrySpell.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & Chr(34) & "rain_day" & Chr(34) & ")")
        clsDrySpell.AddParameter("save", 1)
        NoTenInThirty()
    End Sub

    Private Sub NoTenInThirty()
        clsSubCalcNoTenInThirty.AddParameter("sub1", clsRFunctionParameter:=clsDrySpell, bIncludeArgumentName:=False)
        clsDryPeriodTen.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsDryPeriodTen.AddParameter("function_exp", Chr(34) & "rollapply(data = Dry_Spell, width=" & nudMaximumDays.Value & ", FUN=max, align='right', fill=NA)" & Chr(34))
        clsDryPeriodTen.AddParameter("result_name", Chr(34) & "Dry_Period" & Chr(34))
        clsDryPeriodTen.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcNoTenInThirty)
        clsDryPeriodTen.AddParameter("save", 2)
        PeriodWithinThirtyDays()
    End Sub

    Private Sub PeriodWithinThirtyDays()
        clsWithinThirtyDays.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsWithinThirtyDays.AddParameter("function_exp", Chr(34) & "Dry_Period <" & nudLengthofTime.Value & Chr(34))
        clsWithinThirtyDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & Chr(34) & "Dry_period" & ")" & Chr(34))
    End Sub

    Private Sub FirstDOYPerYear()
        If Not ucrReceiverDOY.IsEmpty Then
            clsManipulationFirstDOYPerYear.AddParameter("sub1", clsRFunctionParameter:=clsXdaysRain, bIncludeArgumentName:=False)
            clsManipulationFirstDOYPerYear.AddParameter("sub2", clsRFunctionParameter:=clsDryPeriodTen, bIncludeArgumentName:=False)
            clsManipulationFirstDOYPerYear.AddParameter("sub3", clsRFunctionParameter:=clsYearGroupDaily, bIncludeArgumentName:=False)
            clsManipulationFirstDOYPerYear.AddParameter("sub4", clsRFunctionParameter:=clsMinimumRainfall, bIncludeArgumentName:=False)
            clsManipulationFirstDOYPerYear.AddParameter("sub5", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
            clsFirstDOYPerYear.AddParameter("type", Chr(34) & "summary" & Chr(34))
            clsFirstDOYPerYear.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34))
            clsFirstDOYPerYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
            clsFirstDOYPerYear.AddParameter("manipulations", clsRFunctionParameter:=clsManipulationFirstDOYPerYear)
            clsFirstDOYPerYear.AddParameter("result_name", Chr(34) & "Start_of_Rains" & Chr(34))
        Else
            clsManipulationFirstDOYPerYear.RemoveParameterByName("sub1")
            clsManipulationFirstDOYPerYear.RemoveParameterByName("sub2")
            clsManipulationFirstDOYPerYear.RemoveParameterByName("sub3")
            clsManipulationFirstDOYPerYear.RemoveParameterByName("sub4")
            clsManipulationFirstDOYPerYear.RemoveParameterByName("sub5")
            clsFirstDOYPerYear.RemoveParameterByName("type")
            clsFirstDOYPerYear.RemoveParameterByName("function_exp")
            clsFirstDOYPerYear.RemoveParameterByName("calculated_from")
            clsFirstDOYPerYear.RemoveParameterByName("manipulations")
        End If
    End Sub
    Private Sub YearGroupDaily()
        clsYearGroupDaily.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsYearGroupDaily.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDate.GetVariableNames & ")")
    End Sub
    Private Sub firstDayofTheYear()
        ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsFirstDOYPerYear)
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        frmMain.clsRLink.RunScript(clsAddKey.ToScript, strComment:="Start of Rains: Defining Date column as key")
        frmMain.clsRLink.RunScript(clsApplyRainDays.ToScript, strComment:="Start of Rains: Creating rain_day column")
    End Sub
End Class