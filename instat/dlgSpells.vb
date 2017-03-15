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

Public Class dlgSpells
    Public clsAddKey, clsDayFromAndTo, clsAdditionalCondition, clsRainyDays, clsMaxValue, clsYearGroupDaily, clsManipulationFirstDOYPerYear, clsCombinedFilter, clsCombinedList As New RFunction
    Private clsMaxValueList, clsDSDrySpell, clsSubDSRainDays1, clsSubDSRainDays2 As New RFunction
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
        clsMaxValue.SetRCommand("instat_calculation$new")
        clsMaxValue.SetAssignTo("First_doy_per_year")
        clsDSDrySpell.SetRCommand("instat_calculation$new")
        clsDSDrySpell.SetAssignTo("Dry_Spell")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$apply_instat_calculation")
        clsSubDSRainDays1.SetRCommand("list")
        clsSubDSRainDays2.SetRCommand("list")
        clsCombinedList.SetRCommand("list")
        clsManipulationFirstDOYPerYear.SetRCommand("list")
        clsAdditionalCondition.SetRCommand("instat_calculation$new")
        clsAdditionalCondition.SetAssignTo("Additional_Condition")

        clsCombinedFilter.SetRCommand("instat_calculation$new")
        clsCombinedFilter.SetAssignTo("combined_filter")

        ucrReceiverRainfall.Selector = ucrSelectorForStartofRains
        ucrReceiverYear.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.Selector = ucrSelectorForStartofRains
        ucrReceiverDayOfYear.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.SetMeAsReceiver()

        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDayOfYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDayOfYear.bAutoFill = True
        ucrReceiverRainfall.bAutoFill = True
        ucrReceiverYear.bAutoFill = True

        nudConditionLeft.DecimalPlaces = 2
        NudConditionRight.DecimalPlaces = 2

        'Dim dctCondition As New Dictionary(Of String, String)
        'dctCondition.Add("Between", "between")
        'dctCondition.Add("Less than", Chr(34) & "<" & Chr(34))
        'dctCondition.Add("Greater than", Chr(34) & ">" & Chr(34))
        'ucrInputCondition.SetItems(dctCondition)

        ucrInputCondition.SetItems({"<=", "Between", ">="})
        nudFrom.Minimum = 1
        nudFrom.Maximum = 366
        nudTo.Minimum = 1
        nudTo.Maximum = 366
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForStartofRains.Reset()
        TestOKEnabled()

        nudFrom.Value = 1
        nudTo.Value = 366
        nudConditionLeft.Value = 0
        NudConditionRight.Value = 0.85
        ucrInputCondition.SetName("Between")
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub DisplayForConditions()
        Select Case ucrInputCondition.GetText
            Case "Between"
                nudConditionLeft.Visible = True
                NudConditionRight.Visible = True
                lblRain.Visible = False
            Case Else
                nudConditionLeft.Visible = True
                NudConditionRight.Visible = False
                lblRain.Visible = True
        End Select
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDayOfYear.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso nudConditionLeft.Text <> "" AndAlso nudFrom.Text <> "" AndAlso nudTo.Text <> "" AndAlso NudConditionRight.Text <> "" Then ' and ucrInput is empty
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    ' nud max and mins.
    Private Sub nudValues()
        '  nudFrom.Maximum = ucrNudTo.Value - 1
        ' ucrNudTo.Minimum = nudFrom.Value + 1
        'nudMaximumDays.Maximum = nudLengthofTime.Value - 1
        'nudLengthofTime.Minimum = nudMaximumDays.Value + 1
    End Sub

    Private Sub DayFromAndToMethod()
        clsDayFromAndTo.AddParameter("function_exp", Chr(34) & ucrReceiverDayOfYear.GetVariableNames(False) & ">=" & nudFrom.Value & " & " & ucrReceiverDayOfYear.GetVariableNames(False) & "<=" & nudTo.Value & Chr(34))
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDayOfYear.GetVariableNames() & ")")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34))
    End Sub

    Private Sub RainyDaysMethod()

        If chkConditionRain.Checked Then
            clsRainyDays.RemoveParameterByName("type")
            clsRainyDays.RemoveParameterByName("function_exp")
            clsRainyDays.RemoveParameterByName("result_name")
            clsRainyDays.RemoveParameterByName("calculated_from")
            clsRainyDays.RemoveParameterByName("save")
            clsDSDrySpell.RemoveParameterByName("function_exp")
            clsDSDrySpell.RemoveParameterByName("sub_calculations")
            clsSubDSRainDays1.RemoveParameterByName("sub1")
            clsAdditionalCondition.AddParameter("type", "calculation")
            clsAdditionalCondition.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", " & (nudConditionLeft.Value - 1) & ", 0)" & Chr(34))
            clsAdditionalCondition.AddParameter("result_name", "rain_day2")
            clsAdditionalCondition.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames(True) & ")")
            clsAdditionalCondition.AddParameter("save", 0)

            clsDSDrySpell.AddParameter("function_exp", Chr(34) & "cumsum(rain_day2==0)-cummax((rain_day2)*cumsum(rain_day2==0))" & Chr(34))
            clsDSDrySpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubDSRainDays2)
            clsSubDSRainDays2.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)

        Else
            clsAdditionalCondition.RemoveParameterByName("type")
            clsAdditionalCondition.RemoveParameterByName("function_exp")
            clsAdditionalCondition.RemoveParameterByName("result_name")
            clsAdditionalCondition.RemoveParameterByName("calculated_from")
            clsAdditionalCondition.RemoveParameterByName("save")
            clsDSDrySpell.RemoveParameterByName("function_exp")
            clsDSDrySpell.RemoveParameterByName("sub_calculations")
            clsSubDSRainDays2.RemoveParameterByName("sub1")

            clsRainyDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            Select Case ucrInputCondition.GetText
                Case "<="
                    clsRainyDays.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverRainfall.GetVariableNames(False) & "<=" & nudConditionLeft.Value & "," & "1, nomatch = 0" & ")" & Chr(34))
                Case "Between"
                    clsRainyDays.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverRainfall.GetVariableNames(False) & "<=" & nudConditionLeft.Value & "&" & ucrReceiverRainfall.GetVariableNames(False) & ">=" & NudConditionRight.Value & "," & "1, nomatch = 0" & ")" & Chr(34))
                Case Else
                    clsRainyDays.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverRainfall.GetVariableNames(False) & ">=" & nudConditionLeft.Value & "," & "1, nomatch = 0" & ")" & Chr(34))
            End Select
            clsRainyDays.AddParameter("result_name", Chr(34) & "rain_day" & Chr(34))
            clsRainyDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames(True) & ")")
            clsRainyDays.AddParameter("save", 0)
            clsDSDrySpell.AddParameter("function_exp", Chr(34) & "cumsum(rain_day==0)-cummax((rain_day)*cumsum(rain_day==0))" & Chr(34))
            clsDSDrySpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubDSRainDays1)
            clsSubDSRainDays1.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
        End If
        clsDSDrySpell.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsDSDrySpell.AddParameter("result_name", Chr(34) & "Dry_Spell" & Chr(34))
        clsDSDrySpell.AddParameter("save", 0)
    End Sub

    Private Sub ucrInputCondition_NameChanged() Handles ucrInputCondition.NameChanged
        DisplayForConditions()
        RainyDaysMethod()
    End Sub

    Private Sub MaxValue()
        ' run these when things are checked
        clsManipulationFirstDOYPerYear.AddParameter("sub2", clsRFunctionParameter:=clsYearGroupDaily, bIncludeArgumentName:=False)
        clsManipulationFirstDOYPerYear.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)

        clsMaxValue.AddParameter("type", Chr(34) & "summary" & Chr(34))
        clsMaxValue.AddParameter("function_exp", Chr(34) & "max(Dry_Spell)" & Chr(34))
        clsMaxValue.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDayOfYear.GetVariableNames() & ")")
        clsMaxValue.AddParameter("manipulations", clsRFunctionParameter:=clsManipulationFirstDOYPerYear)
        clsMaxValue.AddParameter("sub_calculations", clsRFunctionParameter:=clsMaxValueList)
        clsMaxValueList.AddParameter("sub1", clsRFunctionParameter:=clsDSDrySpell, bIncludeArgumentName:=False)
        clsMaxValue.AddParameter("result_name", Chr(34) & "Max_Length" & Chr(34))
        clsMaxValue.AddParameter("save", 2)
    End Sub

    Private Sub firstDayofTheYear()
        ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsMaxValue)
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        frmMain.clsRLink.RunScript(clsAddKey.ToScript, strComment:="Start of Rains: Defining Date column as key")

        DayFromAndToMethod()
        RainyDaysMethod()
        MaxValue()
    End Sub

    Private Sub nudToAndFrom_ControlValueChanged(sender As Object, e As EventArgs) Handles nudTo.ValueChanged, nudFrom.ValueChanged
        nudValues()
        DayFromAndToMethod()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverDOY(sender As Object, e As EventArgs) Handles ucrReceiverDayOfYear.SelectionChanged
        DayFromAndToMethod()
        MaxValue()
        firstDayofTheYear()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverRainfall_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRainfall.SelectionChanged
        RainyDaysMethod()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverYear_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverYear.SelectionChanged
        clsYearGroupDaily.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsYearGroupDaily.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDate.SelectionChanged
        If Not ucrReceiverDate.IsEmpty Then
            clsAddKey.AddParameter("col_name", ucrReceiverDate.GetVariableNames)
        Else
            clsAddKey.RemoveParameterByName("col_name")
        End If
        TestOKEnabled()
    End Sub

    Private Sub conditionnuds_valuechanged(sender As Object, e As EventArgs) Handles NudConditionRight.ValueChanged, nudConditionLeft.ValueChanged
        RainyDaysMethod()
        TestOKEnabled()
    End Sub
End Class