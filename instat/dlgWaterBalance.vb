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
    Public clsReplaceNA60, clsWaterBalance60, clsWaterFilter60, clsDifference, clsDifferenceList, clsFirstWaterBalance60, clsFirstWaterBalance60List, clsFirstWaterBalance0List, clsWaterFilter60List, clsWaterFilter0List, clsReplaceNA0, clsWaterBalance60List, clsWaterBalance0List, clsWaterBalance0, clsWaterFilter0, clsFirstWaterBalance0 As New RFunction
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

    Private Sub ucrSelectorForStartofRains_DataFrameChanged() Handles ucrSelectorForWaterBalance.DataFrameChanged
        strCurrDataName = Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        clsAddKey.AddParameter("data_name", strCurrDataName)
        FirstDayofTheYear()
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 201

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

        ' for clarity when it runs
        clsReplaceNA60.SetAssignTo("Replace_NA_60")
        clsReplaceNA0.SetAssignTo("Replace_NA_0")
        clsWaterBalance60.SetAssignTo("Water_Balance_60")
        clsWaterBalance0.SetAssignTo("Water_Balance_0")
        clsWaterFilter60.SetAssignTo("Water_Filter_60")
        clsWaterFilter0.SetAssignTo("Water_Filter_0")
        clsFirstWaterBalance60.SetAssignTo("First_Water_Balance_60")
        clsFirstWaterBalance0.SetAssignTo("First_Water_Balance_0")

        clsWaterBalance60List.SetRCommand("list")
        clsWaterBalance0List.SetRCommand("list")
        clsWaterFilter60List.SetRCommand("list")
        clsWaterFilter0List.SetRCommand("list")
        clsFirstWaterBalance60List.SetRCommand("list")
        clsFirstWaterBalance0List.SetRCommand("list")

        clsDifferenceList.SetRCommand("list")
        clsDifference.SetRCommand("instat_calculation$new")

        ucrReceiverRainfall.Selector = ucrSelectorForWaterBalance
        ucrReceiverYear.Selector = ucrSelectorForWaterBalance
        ucrReceiverDate.Selector = ucrSelectorForWaterBalance
        ucrReceiverDOY.Selector = ucrSelectorForWaterBalance
        ucrReceiverDate.SetMeAsReceiver()

        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverRainfall.bAutoFill = True
        ucrReceiverYear.bAutoFill = True

        'save
        ucrSaveWaterBalance.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)
        ucrSaveWaterBalance.SetLabelText("New Column Name:")
        ucrSaveWaterBalance.SetIsTextBox()
        ucrSaveWaterBalance.SetPrefix("Water_Balance")
        ucrSaveWaterBalance.SetSaveTypeAsColumn()

        nudCapacity.Maximum = Integer.MaxValue
        nudCapacity.Increment = 10
        nudCapacity.DecimalPlaces = 0

        nudWBLessThan.Increment = 10
        nudWBLessThan.Maximum = Integer.MaxValue

        ucrInputEvaporation.SetValidationTypeAsNumeric()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForWaterBalance.Reset()
        ucrSaveWaterBalance.Reset()

        nudFrom.Value = 1
        nudTo.Value = 366
        nudCapacity.Value = 60
        nudWBLessThan.Value = 40
        ucrInputEvaporation.SetName("5")
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso nudCapacity.Text <> "" AndAlso nudFrom.Text <> "" AndAlso nudTo.Text <> "" AndAlso Not ucrInputEvaporation.IsEmpty AndAlso nudWBLessThan.Text <> "" AndAlso ucrSaveWaterBalance.IsComplete Then
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

    Private Sub WaterBalance() ' crashes regardless of this sub
        clsReplaceNA60.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsReplaceNA60.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na( " & ucrReceiverRainfall.GetVariableNames(False) & "), 60)" & Chr(34))
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

        clsReplaceNA0.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsReplaceNA0.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na(" & ucrReceiverRainfall.GetVariableNames(False) & "), 0)" & Chr(34))
        clsReplaceNA0.AddParameter("result_name", Chr(34) & "Replace_NA_0" & Chr(34))
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
        clsWaterFilter0List.AddParameter("sub1", clsRFunctionParameter:=clsWaterBalance0)

        clsFirstWaterBalance0.AddParameter("type", Chr(34) & "summary" & Chr(34))
        clsFirstWaterBalance0.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34))
        clsFirstWaterBalance0.AddParameter("result_name", Chr(34) & "First_Water_Balance_0" & Chr(34))
        clsFirstWaterBalance0.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        clsFirstWaterBalance0.AddParameter("manipulations", clsRFunctionParameter:=clsFirstWaterBalance0List)
        clsFirstWaterBalance0.AddParameter("save", "0")
        clsFirstWaterBalance0List.AddParameter("sub2", clsRFunctionParameter:=clsYearGroup, bIncludeArgumentName:=False)
        clsFirstWaterBalance0List.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
        clsFirstWaterBalance0List.AddParameter("sub1", clsRFunctionParameter:=clsWaterFilter0, bIncludeArgumentName:=False)
    End Sub

    Private Sub FirstWaterBalancePerYear() ' error occurs when clsDifference runs
        clsDifference.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsDifference.AddParameter("function_exp", Chr(34) & "First_Water_Balance_0 - First_Water_Balance_60" & Chr(34))
        clsDifference.AddParameter("result_name", Chr(34) & "Difference" & Chr(34))
        clsDifference.AddParameter("sub_calculations", clsRFunctionParameter:=clsDifferenceList)
        clsDifferenceList.AddParameter("sub1", clsRFunctionParameter:=clsFirstWaterBalance0)
        clsDifferenceList.AddParameter("sub2", clsRFunctionParameter:=clsFirstWaterBalance60)
        clsDifference.AddParameter("save", "0")
        ' try it in the other sub? Or sub on it's own?

        clsWaterBalance.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsWaterBalance.AddParameter("function_exp", Chr(34) & "replace(First_Water_Balance_0, Difference != 0, NA)" & Chr(34))
        clsWaterBalance.AddParameter("result_name", Chr(34) & ucrSaveWaterBalance.GetText() & Chr(34))
        clsWaterBalance.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterBalanceList)
        clsWaterBalanceList.AddParameter("sub1", clsRFunctionParameter:=clsFirstWaterBalance0)
        clsWaterBalanceList.AddParameter("sub2", clsRFunctionParameter:=clsDifference)
        clsWaterBalance.AddParameter("save", "2")
    End Sub

    Private Sub YearGroupDaily()
        clsYearGroup.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsYearGroup.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
    End Sub

    Private Sub FirstDayofTheYear()
        ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsWaterBalance)
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

    Private Sub nudWBLessThan_ValueChanged(sender As Object, e As EventArgs) Handles nudWBLessThan.TextChanged
        WaterBalance()
        TestOKEnabled()
    End Sub

    Private Sub nudCapacity_ValueChanged(sender As Object, e As EventArgs) Handles nudCapacity.TextChanged
        WaterBalance()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputEvaporation_NameChanged() Handles ucrInputEvaporation.NameChanged
        WaterBalance()
        TestOKEnabled()
    End Sub

    Private Sub ucrSaveWaterBalance_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveWaterBalance.ControlValueChanged
        clsWaterBalance.SetAssignTo(ucrSaveWaterBalance.ucrInputTextSave.GetText)
        FirstWaterBalancePerYear()
    End Sub

    Private Sub ucrSaveWaterBalance_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveWaterBalance.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class