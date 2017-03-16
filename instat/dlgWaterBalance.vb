' Instat-R
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
Public Class dlgWaterBalance
    Public clsAddKey, clsYearGroup, clsDayFromAndTo, clsFirstWaterBalanceYear, clsFirstWaterBalanceManipulation60, clsWaterBalanceList, clsWaterBalanceCalc, clsWaterBalance As New RFunction
    Public clsReplaceNA60, clsWaterBalance60, clsWaterFilter60, clsFirstWaterBalance60, clsFirstWaterBalance60List, clsFirstWaterBalance0List, clsWaterFilter60List, clsWaterFilter0List, clsReplaceNA0, clsWaterBalance60List, clsWaterBalance0List, clsWaterBalance0, clsWaterFilter0, clsFirstWaterBalance0 As New RFunction
    Private strCurrDataName As String = ""
    Public bFirstLoad As Boolean = True

    Private Sub dlgWaterBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub ucrSelectorForStartofRains_DataFrameChanged() Handles ucrSelectorForStartofRains.DataFrameChanged
        strCurrDataName = Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        clsAddKey.AddParameter("data_name", strCurrDataName)
        FirstDayofTheYear()
    End Sub

    Private Sub InitialiseDialog()
        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.SetAssignTo("Day_From_and_To")
        clsYearGroup.SetRCommand("instat_calculation$new")
        clsYearGroup.SetAssignTo("Year_Group_Daily")
        clsWaterBalance.SetRCommand("instat_calculation$new")
        clsWaterBalance.SetAssignTo("Water_Balance")
        clsWaterBalanceCalc.SetRCommand("instat_calculation$new")
        clsWaterBalanceCalc.SetAssignTo("Water_Balance_Calc")
        clsFirstWaterBalanceYear.SetRCommand("instat_calculation$new")
        clsFirstWaterBalanceYear.SetAssignTo("First_Water_Balance")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$apply_instat_calculation")
        clsFirstWaterBalanceManipulation60.SetRCommand("list")
        clsWaterBalanceList.SetRCommand("list")
        clsReplaceNA60.SetRCommand("instat_calculation$new")
        clsReplaceNA0.SetRCommand("instat_calculation$new")
        clsWaterBalance60.SetRCommand("instat_calculation$new")
        clsWaterBalance0.SetRCommand("instat_calculation$new")
        clsWaterFilter60.SetRCommand("instat_calculation$new")
        clsWaterFilter0.SetRCommand("instat_calculation$new")
        clsFirstWaterBalance60.SetRCommand("instat_calculation$new")
        clsFirstWaterBalance0.SetRCommand("instat_calculation$new")
        clsWaterBalance60List.SetRCommand("list")
        clsWaterBalance0List.SetRCommand("list")
        clsWaterFilter60List.SetRCommand("list")
        clsWaterFilter0List.SetRCommand("list")
        clsFirstWaterBalance60List.SetRCommand("list")
        clsFirstWaterBalance0List.SetRCommand("list")

        ucrReceiverRainfall.Selector = ucrSelectorForStartofRains
        ucrReceiverYear.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.Selector = ucrSelectorForStartofRains
        ucrReceiverDOY.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.SetMeAsReceiver()

        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverRainfall.bAutoFill = True
        ucrReceiverYear.bAutoFill = True
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForStartofRains.Reset()
        nudFrom.Value = 1
        nudTo.Value = 366
        nudCapacity.Value = 60
        nudWBLessThan.Value = 0.5
        ucrInputEvaporation.SetName("5")
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso nudCapacity.Text <> "" AndAlso nudFrom.Text <> "" AndAlso nudTo.Text <> "" AndAlso Not ucrInputEvaporation.IsEmpty AndAlso nudWBLessThan.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub nudValues()
        '    '  nudFrom.Maximum = nudTo.Value - 1
        '    ' nudTo.Minimum = nudFrom.Value + 
    End Sub

    Private Sub AddKeyMethod()
        If Not ucrReceiverDate.IsEmpty Then
            clsAddKey.AddParameter("col_name", ucrReceiverDate.GetVariableNames)
        Else
            clsAddKey.RemoveParameterByName("col_name")
        End If
    End Sub

    Private Sub DayFromAndToMethod()
        clsDayFromAndTo.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & ">=" & nudFrom.Value & " & " & ucrReceiverDOY.GetVariableNames(False) & "<=" & nudTo.Value & Chr(34))
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34))
    End Sub

    Private Sub WaterBalance()
        ' if the evaporation column is empty then:

        ' Replace_NA_60
        '
        '        clsReplaceNA60
        '        clsWaterBalance60
        '        clsWaterFilter60
        '        clsFirstWaterBalance60

        '        clsWaterBalanceCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        '        clsWaterBalanceCalc.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & nudCapacity.Value & "), " & ucrReceiverRainfall.GetVariableNames(False) & ", accumulate=TRUE)" & Chr(34))
        '        clsWaterBalanceCalc.AddParameter("result_name", Chr(34) & "Water_Balance_0" & Chr(34))
        '        clsWaterBalanceCalc.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")")
        '        clsWaterBalanceCalc.AddParameter("save", "0")

        '        'else
        '        'remove parameters by name
        '        'end if


        '    End Sub


        clsReplaceNA60.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsReplaceNA60.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na(" & ucrReceiverRainfall.GetVariableNames(False) & ", 60)" & Chr(34))
        clsReplaceNA60.AddParameter("result_name", Chr(34) & "Replace_NA_60" & Chr(34))
        clsReplaceNA60.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")")
        clsReplaceNA60.AddParameter("save", "0") ' has save = 2on rcode

        clsWaterBalance60.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsWaterBalance60.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & nudCapacity.Value & "), Replace_NA_60, accumulate=TRUE)" & Chr(34))
        clsWaterBalance60.AddParameter("result_name", Chr(34) & "Water_Balance_60" & Chr(34))
        clsWaterBalance60.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterBalance60List)
        clsWaterBalance60List.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA60)
        clsWaterBalance60.AddParameter("save", "0")

        clsWaterFilter60.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsWaterFilter60.AddParameter("function_exp", Chr(34) & "Water_Balance_60 <= " & nudWBLessThan.Value & Chr(34))
        clsWaterFilter60.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterFilter60List)
        clsWaterFilter60List.AddParameter("sub1", clsRFunctionParameter:=clsWaterBalance60)

        clsFirstWaterBalance60.AddParameter("type", Chr(34) & "summary" & Chr(34))
        clsFirstWaterBalance60.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34))
        clsFirstWaterBalance60.AddParameter("result_name", Chr(34) & "First_Water_Balance_60" & Chr(34))
        clsFirstWaterBalance60.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        clsFirstWaterBalance60.AddParameter("manipulations", clsRFunctionParameter:=clsFirstWaterBalanceManipulation60)
        clsFirstWaterBalance60.AddParameter("save", "0")
        clsFirstWaterBalanceManipulation60.AddParameter("sub2", clsRFunctionParameter:=clsYearGroup, bIncludeArgumentName:=False)
        clsFirstWaterBalanceManipulation60.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
        clsFirstWaterBalanceManipulation60.AddParameter("sub1", clsRFunctionParameter:=clsWaterFilter60, bIncludeArgumentName:=False)


        '### First Instance of Each Year
        'First_Water_Balance_60 <- instat_calculation$new(type = "summary", function_exp = "doy_366[1]", calculated_from = list(Damango = "doy_366"),
        '                                              manipulations = list(Water_Filter_60, Year_group_for_Damango, Day_From_and_To),


        clsReplaceNA0.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsReplaceNA0.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na(" & ucrReceiverRainfall.GetVariableNames(False) & ", 0)" & Chr(34))
        clsReplaceNA0.AddParameter("result_name", Chr(34) & "clsReplaceNA0" & Chr(34))
        clsReplaceNA0.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")")
        clsReplaceNA0.AddParameter("save", "0")

        clsWaterBalance0.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsWaterBalance0.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & nudCapacity.Value & "), Replace_NA_0, accumulate=TRUE)" & Chr(34))
        clsWaterBalance0.AddParameter("result_name", Chr(34) & "Water_Balance_0" & Chr(34))
        clsWaterBalance0.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterBalance0List)
        clsWaterBalance0List.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA0)
        clsWaterBalance0.AddParameter("save", "0")

        clsWaterFilter0.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsWaterFilter0.AddParameter("function_exp", Chr(34) & "Water_Balance_0 <= " & nudWBLessThan.Value & Chr(34))
        clsWaterFilter0.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterFilter0List)
        clsWaterFilter0List.AddParameter("sub1", clsRFunctionParameter:=clsWaterFilter0)

        clsFirstWaterBalance0.AddParameter("type", Chr(34) & "summary" & Chr(34))
        clsFirstWaterBalance0.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34))
        clsFirstWaterBalance0.AddParameter("result_name", Chr(34) & "First_Water_Balance_0" & Chr(34))
        clsFirstWaterBalance0.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        clsFirstWaterBalance0.AddParameter("manipulations", clsRFunctionParameter:=clsFirstWaterBalance0List)
        clsFirstWaterBalance0.AddParameter("save", "2")
        clsFirstWaterBalance0List.AddParameter("sub2", clsRFunctionParameter:=clsYearGroup, bIncludeArgumentName:=False)
        clsFirstWaterBalance0List.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
        clsFirstWaterBalance0List.AddParameter("sub1", clsRFunctionParameter:=clsFirstWaterBalance0, bIncludeArgumentName:=False)



        '## Are they the same value?

        'Na1_minus_2 <- instat_calculation$new(type = "calculation",
        '                                      function_exp = "First_Water_Balance_0 - First_Water_Balance_60",
        '                                      result_name = "Difference", sub_calculations = list(First_Water_Balance_0, First_Water_Balance_60), save = 0)


        '## Where Difference =/= 0, replace First_Water_Balance_0 with NA
        '## replace(First_Water_Balance_0, Difference == 0, NA)

        'Replace_Final <- instat_calculation$new(type = "calculation",
        '                                      function_exp = "replace(First_Water_Balance_0, Difference != 0, NA)",
        '                                      result_name = "Final_water", sub_calculations = list(First_Water_Balance_0, Na1_minus_2), save = 2)
        'InstatDataObject$apply_instat_calculation(Replace_Final)

    End Sub


    Private Sub FirstWaterBalancePerYear()


    End Sub

    Private Sub YearGroupDaily()
        clsYearGroup.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsYearGroup.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
    End Sub

    Private Sub FirstDayofTheYear()
        ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsFirstWaterBalanceYear)
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        frmMain.clsRLink.RunScript(clsAddKey.ToScript, strComment:="Water Balance: Defining Date column as key")

        FirstDayofTheYear()
        DayFromAndToMethod()
        WaterBalance()
        FirstWaterBalancePerYear()
    End Sub

    Private Sub ucrReceiverYear_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverYear.SelectionChanged
        YearGroupDaily()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverRainfall_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRainfall.SelectionChanged
        WaterBalance()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverDOY_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDOY.SelectionChanged
        DayFromAndToMethod()
        FirstWaterBalancePerYear()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDate.SelectionChanged
        AddKeyMethod()
        TestOKEnabled()
    End Sub

    Private Sub DayFromAndTo(sender As Object, e As EventArgs) Handles nudFrom.TextChanged, nudTo.TextChanged
        DayFromAndToMethod()
        nudValues()
        TestOKEnabled()
    End Sub

    Private Sub nudWBLessThan_ValueChanged(sender As Object, e As EventArgs) Handles nudWBLessThan.ValueChanged
        WaterBalance()
        TestOKEnabled()
    End Sub

    Private Sub nudCapacity_ValueChanged(sender As Object, e As EventArgs) Handles nudCapacity.ValueChanged
        WaterBalance()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputEvaporation_NameChanged() Handles ucrInputEvaporation.NameChanged
        WaterBalance()
        TestOKEnabled()
    End Sub
End Class