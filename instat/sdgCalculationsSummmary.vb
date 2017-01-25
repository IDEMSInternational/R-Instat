﻿' Instat-R
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
Public Class sdgCalculationsSummmary
    Public bFirstLoad As Boolean = True
    Private clsCalculationFunction As New RFunction
    Dim lstType As New List(Of KeyValuePair(Of String, String))
    Private lstSubCalcFunctions As New List(Of KeyValuePair(Of String, RFunction))
    Private lstManipulationFunctions As New List(Of KeyValuePair(Of String, RFunction))
    Dim clsSubCalcsList As New RFunction
    Dim clsManipulationsList As New RFunction
    Dim iSubCalcCount As Integer = 1
    Dim iManipCount As Integer = 1
    Dim bIsSubCalc As Boolean = False
    Dim bIsManipulation As Boolean = False

    Private Sub sdgCalculationsSummmary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            'temporary solution to subdialog linking issues
            SetDefaults()
        End If
    End Sub

    Private Sub InitialiseDialog()
        ' Set Items in ucrType
        ucrBaseSummmaryCalcSubdialog.iHelpTopicID = 514
        ucrReceiverByOrSort.Selector = ucrSelectorBy
        ucrReceiverByOrSort.SetMeAsReceiver()

        ' This is the new way of using this control. Not needed yet
        'lstType.Add(New KeyValuePair(Of String, String)("Calculation", Chr(34) & "calculation" & Chr(34)))
        'lstType.Add(New KeyValuePair(Of String, String)("Summary", Chr(34) & "summary" & Chr(34)))
        'lstType.Add(New KeyValuePair(Of String, String)("By", Chr(34) & "by" & Chr(34)))
        'lstType.Add(New KeyValuePair(Of String, String)("Filter", Chr(34) & "filter" & Chr(34)))
        'lstType.Add(New KeyValuePair(Of String, String)("Combine", Chr(34) & "combination" & Chr(34)))
        'ucrType.SetItems(lstType)
        'ucrType.SetParameterName("type")

        ucrCalcSummary.ucrReceiverForCalculation.SetMeAsReceiver()
        ucrCalcSummary.chkSaveResultInto.Visible = False
        ucrCalcSummary.ucrSaveResultInto.Visible = False
        ucrResultName.SetValidationTypeAsRVariable()
        ucrCalculationName.SetValidationTypeAsRVariable()

        clsSubCalcsList.SetRCommand("list")
        clsManipulationsList.SetRCommand("list")

        ucrManipulations.lstAvailableData.View = View.List
    End Sub

    Private Sub SetDefaults()
        ucrSelectorBy.Reset()
        ucrSelectorBy.Focus()

        If bIsSubCalc Then
            Text = "Add Sub Calculation"
            ucrType.SetItems({"calculation", "summary"})
            ucrType.SetName("calculation")
        ElseIf bIsManipulation Then
            Text = "Add Manipulation"
            ucrType.SetItems({"by", "filter", "sort"})
            ucrType.SetName("by")
        Else
            ucrType.SetName("calculation")
            Text = "Add Calculation"
            ucrType.SetItems({"calculation", "summary", "by", "filter", "sort"}) ' and combine
            ucrType.SetName("calculation")
        End If
        SetType()

        rdoDoNotSave.Checked = True
        SetSaveOption()

        ucrCalcSummary.ucrSelectorForCalculations.Reset()
        ucrCalculationName.SetName("")
        ucrResultName.SetName("")

        lstSubCalcs.Items.Clear()
        lstSubCalcFunctions.Clear()
        ucrManipulations.Reset()
        lstManipulationFunctions.Clear()

        'temp until working
        cmdManipEdit.Enabled = False
        cmdManipDuplicate.Enabled = False
        cmdSubCalcEdit.Enabled = False
        cmdSubCalcDuplicate.Enabled = False
    End Sub

    Public Sub SetCalculationFunction(clsNewCalcFunction As RFunction)
        clsCalculationFunction = clsNewCalcFunction
    End Sub

    Public Sub SetAsSubCalculation()
        bIsSubCalc = True
        bIsManipulation = False
    End Sub

    Public Sub SetAsManipulation()
        bIsManipulation = True
        bIsSubCalc = False
    End Sub

    Public Sub SetAsCalculation()
        bIsManipulation = False
        bIsSubCalc = False
    End Sub

    Private Sub DisplayOptions()
        If ucrType.GetText = "calculation" OrElse ucrType.GetText = "summary" Then
            ucrSelectorBy.Visible = False
            ucrReceiverByOrSort.Visible = False
            lblReceiverLabel.Visible = False
            ucrCalcSummary.Visible = True
            If ucrType.GetText = "calculation" Then
                ucrCalcSummary.ucrInputCalOptions.SetName("Basic")
            Else
                ucrCalcSummary.ucrInputCalOptions.SetName("Statistics")
            End If
            ucrDefineFilter.Visible = False
            rdoSaveCalcAndResult.Enabled = True
            ucrResultName.Enabled = True
        ElseIf ucrType.GetText = "by" Then
            ucrSelectorBy.Visible = True
            ucrReceiverByOrSort.Visible = True
            ucrReceiverByOrSort.SetDataType("factor")
            lblReceiverLabel.Text = "By Factors:"
            lblReceiverLabel.Visible = True
            ucrCalcSummary.Visible = False
            clsCalculationFunction.RemoveParameterByName("function_exp")
            ucrDefineFilter.Visible = False
            If rdoSaveCalcAndResult.Checked Then
                rdoSaveCalculation.Checked = True
            End If
            rdoSaveCalcAndResult.Enabled = False
            ucrResultName.Enabled = False
        ElseIf ucrType.GetText = "filter" Then
            ucrSelectorBy.Visible = False
            ucrReceiverByOrSort.Visible = False
            lblReceiverLabel.Visible = False
            ucrCalcSummary.Visible = False
            ucrDefineFilter.Visible = True
            If rdoSaveCalcAndResult.Checked Then
                rdoSaveCalculation.Checked = True
            End If
            rdoSaveCalcAndResult.Enabled = False
            ucrResultName.Enabled = False
        ElseIf ucrType.GetText = "sort" Then
            ucrSelectorBy.Visible = True
            ucrReceiverByOrSort.Visible = True
            ucrReceiverByOrSort.RemoveIncludedMetadataProperty("class")
            lblReceiverLabel.Text = "Sort by:"
            lblReceiverLabel.Visible = True
            ucrCalcSummary.Visible = False
            clsCalculationFunction.RemoveParameterByName("function_exp")
            ucrDefineFilter.Visible = False
            If rdoSaveCalcAndResult.Checked Then
                rdoSaveCalculation.Checked = True
            End If
            rdoSaveCalcAndResult.Enabled = False
            ucrResultName.Enabled = False
        Else
            ' combine options
        End If
    End Sub

    Private Sub rdoSaveOptions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDoNotSave.CheckedChanged, rdoSaveCalculation.CheckedChanged, rdoSaveCalcAndResult.CheckedChanged
        If rdoSaveCalculation.Checked Then
            clsCalculationFunction.AddParameter("save", "1")
        ElseIf rdoSaveCalcAndResult.Checked Then
            clsCalculationFunction.AddParameter("save", "2")
        Else
            clsCalculationFunction.AddParameter("save", "0")
        End If
    End Sub

    Private Sub SetSaveOption()
        If rdoSaveCalculation.Checked Then
            clsCalculationFunction.AddParameter("save", "1")
        ElseIf rdoSaveCalcAndResult.Checked Then
            clsCalculationFunction.AddParameter("save", "2")
        Else
            clsCalculationFunction.AddParameter("save", "0")
        End If
    End Sub

    ' Sub Calculations Tab
    ' We want to have that this opens a dialog which only shows calculations and summary (and combine) as options in type
    Private Sub cmdSubCalcAdd_Click(sender As Object, e As EventArgs) Handles cmdSubCalcAdd.Click
        Dim clsSubCalcFunction As New RFunction
        Dim sdgSubCalc As New sdgCalculationsSummmary

        clsSubCalcFunction.SetRCommand("instat_calculation$new")
        sdgSubCalc.SetAsSubCalculation()
        sdgSubCalc.SetCalculationFunction(clsSubCalcFunction)
        sdgSubCalc.ShowDialog()
        If clsSubCalcFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "name") = -1 Then
            clsSubCalcFunction.AddParameter("name", Chr(34) & "sub_calc" & iSubCalcCount & Chr(34))
            clsSubCalcFunction.SetAssignTo("sub_calc" & iSubCalcCount)
            iSubCalcCount = iSubCalcCount + 1
        End If
        lstSubCalcs.Items.Add(clsSubCalcFunction.clsParameters.Find(Function(x) x.strArgumentName = "name").strArgumentValue.Trim(Chr(34)))
        lstSubCalcFunctions.Add(New KeyValuePair(Of String, RFunction)(lstSubCalcs.Items(lstSubCalcs.Items.Count - 1).Text, clsSubCalcFunction.Clone()))
        UpdateSubCalcs()
    End Sub

    ' We want to have that this opens a dialog which only shows filter and by as options in type
    Private Sub cmdManipAdd_Click(sender As Object, e As EventArgs) Handles cmdManipAdd.Click
        Dim clsManipFunction As New RFunction
        Dim sdgManip As New sdgCalculationsSummmary

        clsManipFunction.SetRCommand("instat_calculation$new")
        sdgManip.SetAsManipulation()
        sdgManip.SetCalculationFunction(clsManipFunction)
        sdgManip.ShowDialog()
        If clsManipFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "name") = -1 Then
            clsManipFunction.AddParameter("name", Chr(34) & "manipulation" & iManipCount & Chr(34))
            clsManipFunction.SetAssignTo("manipulation" & iManipCount)
            iManipCount = iManipCount + 1
        End If
        ucrManipulations.lstAvailableData.Items.Add(clsManipFunction.clsParameters.Find(Function(x) x.strArgumentName = "name").strArgumentValue.Trim(Chr(34)))
        lstManipulationFunctions.Add(New KeyValuePair(Of String, RFunction)(ucrManipulations.lstAvailableData.Items(ucrManipulations.lstAvailableData.Items.Count - 1).Text, clsManipFunction.Clone()))
        UpdateManipulations()
    End Sub

    Private Sub ucrType_NameChanged() Handles ucrType.NameChanged
        SetType()
    End Sub

    Private Sub SetType()
        DisplayOptions()
        If ucrType.IsEmpty Then
            clsCalculationFunction.RemoveParameterByName("type")
        Else
            clsCalculationFunction.AddParameter("type", Chr(34) & ucrType.GetText() & Chr(34))
        End If
    End Sub

    Private Sub ucrCalcSummary_SelectionChanged() Handles ucrCalcSummary.SelectionChanged
        If {"calculation", "summary"}.Contains(ucrType.GetText()) Then
            If Not ucrCalcSummary.ucrReceiverForCalculation.IsEmpty Then
                clsCalculationFunction.AddParameter("function_exp", Chr(34) & ucrCalcSummary.ucrReceiverForCalculation.GetText() & Chr(34))
            Else
                clsCalculationFunction.RemoveParameterByName("function_exp")
            End If

            If ucrCalcSummary.ucrSelectorForCalculations.lstVariablesInReceivers.Count > 0 Then
                clsCalculationFunction.AddParameter("calculated_from", CreateCalcFromList(ucrCalcSummary.ucrSelectorForCalculations.lstVariablesInReceivers, ucrCalcSummary.ucrSelectorForCalculations))
            Else
                clsCalculationFunction.RemoveParameterByName("calculated_from")
            End If
        End If
    End Sub

    Private Sub ucrCalculationName_NameChanged() Handles ucrCalculationName.NameChanged
        If ucrCalculationName.IsEmpty Then
            clsCalculationFunction.RemoveParameterByName("name")
            clsCalculationFunction.RemoveAssignTo()
        Else
            clsCalculationFunction.AddParameter("name", Chr(34) & ucrCalculationName.GetText() & Chr(34))
            clsCalculationFunction.SetAssignTo(ucrCalculationName.GetText())
        End If
    End Sub

    Private Sub ucrColumnName_NameChanged() Handles ucrResultName.NameChanged
        If ucrResultName.IsEmpty Then
            clsCalculationFunction.RemoveParameterByName("result_name")
        Else
            clsCalculationFunction.AddParameter("result_name", Chr(34) & ucrResultName.GetText() & Chr(34))
        End If
    End Sub

    Private Sub ucrReceiverBy_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverByOrSort.SelectionChanged
        If {"by", "sort"}.Contains(ucrType.GetText()) Then
            If ucrReceiverByOrSort.IsEmpty Then
                clsCalculationFunction.RemoveParameterByName("calculated_from")
            Else
                clsCalculationFunction.AddParameter("calculated_from", CreateCalcFromList(ucrReceiverByOrSort.GetVariableNamesAsList(), ucrSelectorBy))
            End If
        End If
    End Sub

    'Need to do this instead of with RFunctions because the calculated_from list can have multiple items with the same label
    Private Function CreateCalcFromList(lstVariables As List(Of String), ucrCurrentSelector As ucrSelectorByDataFrame) As String
        Dim strCalcFromList As String
        Dim strColumn As String

        strCalcFromList = "list("
        For i = 0 To lstVariables.Count - 1
            strColumn = lstVariables(i)
            If i > 0 Then
                strCalcFromList = strCalcFromList & ","
            End If
            strCalcFromList = strCalcFromList & ucrCurrentSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text & " = " & Chr(34) & strColumn & Chr(34)
        Next
        strCalcFromList = strCalcFromList & ")"
        Return strCalcFromList
    End Function

    Private Sub ucrDefineFilter_FilterChanged() Handles ucrDefineFilter.FilterChanged
        If ucrType.GetText() = "filter" Then
            If ucrDefineFilter.ucrFilterPreview.IsEmpty Then
                clsCalculationFunction.RemoveParameterByName("function_exp")
                clsCalculationFunction.RemoveParameterByName("calculated_from")
            Else
                clsCalculationFunction.AddParameter("function_exp", Chr(34) & ucrDefineFilter.ucrFilterPreview.GetText() & Chr(34))
                clsCalculationFunction.AddParameter("calculated_from", CreateCalcFromList(ucrDefineFilter.GetFilteredVariables(False), ucrDefineFilter.ucrSelectorForFitler))
            End If
        End If
    End Sub

    Private Sub UpdateSubCalcs()
        clsSubCalcsList.ClearParameters()
        For i As Integer = 0 To lstSubCalcFunctions.Count - 1
            clsSubCalcsList.AddParameter(i, clsRFunctionParameter:=lstSubCalcFunctions(i).Value.Clone(), bIncludeArgumentName:=False)
        Next
        If lstSubCalcFunctions.Count > 0 Then
            clsCalculationFunction.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcsList, bIncludeArgumentName:=False)
        Else
            clsCalculationFunction.RemoveParameterByName("sub_calculations")
        End If
    End Sub

    Private Sub UpdateManipulations()
        clsManipulationsList.ClearParameters()
        For i As Integer = 0 To lstManipulationFunctions.Count - 1
            clsManipulationsList.AddParameter(i, clsRFunctionParameter:=lstManipulationFunctions(i).Value.Clone(), bIncludeArgumentName:=False)
        Next

        If lstManipulationFunctions.Count > 0 Then
            clsCalculationFunction.AddParameter("manipulations", clsRFunctionParameter:=clsManipulationsList)
        Else
            clsCalculationFunction.RemoveParameterByName("manipulations")
        End If
    End Sub

    Private Sub cmdManipDelete_Click(sender As Object, e As EventArgs) Handles cmdManipDelete.Click
        Dim iIndex As Integer

        For Each lviTemp As ListViewItem In ucrManipulations.lstAvailableData.SelectedItems
            iIndex = ucrManipulations.lstAvailableData.Items.IndexOf(lviTemp)
            ucrManipulations.lstAvailableData.Items.Remove(lviTemp)
            lstManipulationFunctions.RemoveAt(iIndex)
        Next
    End Sub

    Private Sub cmdSubCalcDelete_Click(sender As Object, e As EventArgs) Handles cmdSubCalcDelete.Click
        Dim iIndex As Integer

        For Each lviTemp As ListViewItem In lstSubCalcs.SelectedItems
            iIndex = lstSubCalcs.Items.IndexOf(lviTemp)
            lstSubCalcs.Items.Remove(lviTemp)
            lstSubCalcFunctions.RemoveAt(iIndex)
        Next
    End Sub
End Class