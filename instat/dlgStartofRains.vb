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
    Public clsAddKey, clsDayFromAndTo, clsRainyDays, clsRollingSum, clsMinimumRainfall, clsRollingRainDays, clsXdaysRain, clsFirstDOYPerYear, clsFirstInstance, clsNoRain, clsCumulativeRain, clsDryPeriodTen, clsWithinThirtyDays As New RFunction
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
        DayFromAndToMethod()
    End Sub

    Private Sub ucrSelectorForStartofRains_DataFrameChanged() Handles ucrSelectorForStartofRains.DataFrameChanged
        clsAddKey.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub InitialiseDialog()
        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsRainyDays.SetRCommand("instat_calculation$new")
        clsRollingSum.SetRCommand("instat_calculation$new")
        clsMinimumRainfall.SetRCommand("instat_calculation$new")
        clsRollingRainDays.SetRCommand("instat_calculation$new")
        clsXdaysRain.SetRCommand("instat_calculation$new")
        clsFirstDOYPerYear.SetRCommand("instat_calculation$new")
        clsFirstInstance.SetRCommand("instat_calculation$new")
        clsNoRain.SetRCommand("instat_calculation$new")
        clsCumulativeRain.SetRCommand("instat_calculation$new")
        clsDryPeriodTen.SetRCommand("instat_calculation$new")
        clsWithinThirtyDays.SetRCommand("instat_calculation$new")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$apply_instat_calculation")
        ucrReceiverRainfall.Selector = ucrSelectorForStartofRains
        ucrReceiverRainfall.SetMeAsReceiver()
        ucrReceiverDate.SetMeAsReceiver()
        ucrReceiverDOY.SetMeAsReceiver()
    End Sub

    Private Sub SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub grpRainParameters_Enter(sender As Object, e As EventArgs) Handles nudFrom.TextChanged, nudTo.TextChanged, nudThreshold.TextChanged, nudOverDays.TextChanged
        TestOKEnabled()
    End Sub

    Private Sub grpConditionsForSatrtofRains_Enter(sender As Object, e As EventArgs) Handles chkConsecutiveRainyDays.CheckedChanged, chkTotalRainfall.CheckedChanged, chkTotalRainfall.CheckedChanged, nudValue.TextChanged, nudMinimum.TextChanged, nudMaximumDays.TextChanged, nudLengthofTime.TextChanged
        DayFromAndToMethod()
        RainyDaysMethod()
        MinimumRainfallMethod()
        XDaysRainMethod()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverRainfall_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRainfall.SelectionChanged
        RainyDaysMethod()
        RollingSumMethod()
    End Sub

    Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDate.SelectionChanged
        AddKeyMethod()
    End Sub
    Private Sub AddKeyMethod()
        If Not ucrReceiverDate.IsEmpty Then
            clsAddKey.AddParameter("col_name", ucrReceiverDate.GetVariableNames)
        Else
            clsAddKey.RemoveParameterByName("col_name")
        End If
        frmMain.clsRLink.RunInternalScript(clsAddKey.ToScript)
    End Sub

    Private Sub DayFromAndToMethod()
        If nudFrom.Text <> "" AndAlso nudTo.TextAlign <> "" AndAlso Not ucrReceiverDOY.IsEmpty Then
            clsDayFromAndTo.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & ">" & nudFrom.Value & ucrReceiverDOY.GetVariableNames(False) & "<" & nudTo.Value & Chr(34))
            clsDayFromAndTo.AddParameter("calculated_from", Chr(34) & "list(Daily =" & ucrReceiverDOY.GetVariableNames(False) & ")" & Chr(34))
        Else
            clsDayFromAndTo.RemoveParameterByName("function_exp")
            clsDayFromAndTo.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub RainyDaysMethod()
        If Not ucrReceiverRainfall.IsEmpty AndAlso nudThreshold.Text <> "" Then
            clsRainyDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsRainyDays.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverRainfall.GetVariableNames(False) & ">=" & nudThreshold.Value & "," & "1, nomatch = 0" & Chr(34))
            clsRainyDays.AddParameter("result_name", Chr(34) & "rain_day" & Chr(34))
            clsRainyDays.AddParameter("calculated_from", "list(Daily = " & ucrReceiverRainfall.GetVariableNames & ")")
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
            clsRollingSum.AddParameter("function_exp", Chr(34) & " rollapply(" & ucrReceiverRainfall.GetVariableNames(False) & " ,2,sum,align='right',fill=NA)" & Chr(34))
            clsRollingSum.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            clsRollingSum.AddParameter("result_name", Chr(34) & "roll_sum_Rain" & Chr(34))
            clsRollingSum.AddParameter("calculated_from", "list(Daily = " & ucrReceiverRainfall.GetVariableNames & ")")
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
        If chkConsecutiveRainyDays.Checked Then
            lblMinimum.Enabled = True
            nudMinimum.Enabled = True
            If nudMinimum.Text <> "" Then
                clsMinimumRainfall.AddParameter("function_exp", Chr(34) & "roll_sum_Rain >" & nudMinimum.Value)
                clsMinimumRainfall.AddParameter("type", Chr(34) & "filter" & Chr(34))
                clsMinimumRainfall.AddParameter("sub_calculations", "list(" & clsRollingSum.ToScript & ")")
            Else
                clsMinimumRainfall.RemoveParameterByName("function_exp")
                clsMinimumRainfall.RemoveParameterByName("type")
                clsMinimumRainfall.RemoveParameterByName("sub_calculations")
            End If
        Else
            lblMinimum.Enabled = False
            nudMinimum.Enabled = False
        End If
        RollingOfRainDays()
    End Sub

    Private Sub RollingOfRainDays()
        clsRollingRainDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsRollingRainDays.AddParameter("function_exp", Chr(34) & "rollapply(data=rain_day, width=5, FUN=sum, align = 'right', fill=NA)" & Chr(34))
        clsRollingRainDays.AddParameter("result_name", Chr(34) & "Rolling_Rain_Days" & Chr(34))
        clsRollingRainDays.AddParameter("calculated_from", "list(Daily =" & Chr(34) & " rain_day" & Chr(34) & ")")
        clsRollingRainDays.AddParameter("save", 1)
    End Sub
    Private Sub XDaysRainMethod()
        If nudMinimum.Text <> "" Then
            clsXdaysRain.AddParameter("type", Chr(34) & "filter" & Chr(34))
            clsXdaysRain.AddParameter("function_exp", "Rolling_Rain_Days >=" & nudMinimum.Value)
            clsXdaysRain.AddParameter("sub_calculations", "list(Rolling_Of_rain_days)")
        Else
            clsXdaysRain.RemoveParameterByName("type")
            clsXdaysRain.RemoveParameterByName("function_exp")
            clsXdaysRain.RemoveParameterByName("sub_calculations")
        End If
    End Sub
End Class