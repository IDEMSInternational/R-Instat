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
Public Class sdgCalculationsSummmary
    Public bFirstLoad As Boolean = True
    Private clsCalculationFunction As New RFunction
    Private clsCalcFromList As New RFunction
    Dim lstType As New List(Of KeyValuePair(Of String, String))

    Private Sub sdgCalculationsSummmary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        ' Set Items in ucrType

        ucrType.SetItems({"calculation", "summary", "by", "filter"}) ' and combine
        ucrReceiverBy.Selector = ucrSelectorBy
        ucrReceiverBy.SetMeAsReceiver()
        ucrReceiverBy.SetDataType("factor")

        clsCalcFromList.SetRCommand("list")
        ' This is the new way of using this control. Not needed yet
        'lstType.Add(New KeyValuePair(Of String, String)("Calculation", Chr(34) & "calculation" & Chr(34)))
        'lstType.Add(New KeyValuePair(Of String, String)("Summary", Chr(34) & "summary" & Chr(34)))
        'lstType.Add(New KeyValuePair(Of String, String)("By", Chr(34) & "by" & Chr(34)))
        'lstType.Add(New KeyValuePair(Of String, String)("Filter", Chr(34) & "filter" & Chr(34)))
        'lstType.Add(New KeyValuePair(Of String, String)("Combine", Chr(34) & "combination" & Chr(34)))
        'ucrType.SetItems(lstType)
        'ucrType.SetParameterName("type")

        clsCalculationFunction.SetAssignTo(ucrCalculationName.ToString())
    End Sub

    Private Sub SetDefaults()
        ucrSelectorBy.Reset()
        ucrSelectorBy.Focus()
        ucrType.SetName("calculation")
        DisplayOptions()
        rdoDoNotSave.Checked = True
    End Sub

    Public Sub SetCalculationFunction(clsNewCalcFunction As RFunction)
        clsCalculationFunction = clsNewCalcFunction
    End Sub

    Private Sub DisplayOptions()
        If ucrType.GetText = "calculation" OrElse ucrType.GetText = "summary" Then
            ucrSelectorBy.Visible = False
            ucrReceiverBy.Visible = False
            lblFactor.Visible = False
            ucrCalcSummary.Visible = True
            lblColumnName.Visible = True
            ucrColumnName.Visible = True
            rdoSaveCalcAndResult.Visible = True
        ElseIf ucrType.GetText = "by" Then
            lblColumnName.Visible = False
            ucrColumnName.Visible = False
            ucrSelectorBy.Visible = True
            ucrReceiverBy.Visible = True
            lblFactor.Visible = True
            rdoSaveCalcAndResult.Visible = False
            ucrCalcSummary.Visible = False
            If rdoSaveCalcAndResult.Checked Then
                rdoDoNotSave.Checked = True
            End If
        ElseIf ucrType.GetText = "filter" Then
            ucrSelectorBy.Visible = False
            ucrReceiverBy.Visible = False
            lblFactor.Visible = False
            lblColumnName.Visible = False
            ucrColumnName.Visible = False
            rdoSaveCalcAndResult.Visible = False
            ucrCalcSummary.Visible = False
            If rdoSaveCalcAndResult.Checked Then
                rdoDoNotSave.Checked = True
            End If
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

    ' Looking at Manipulations Tab
    Private Sub cmdManipAdd_Click(sender As Object, e As EventArgs) Handles cmdManipAdd.Click

    End Sub
    ' We want to have that this opens a dialog which only shows filter and by as options in type

    ' Sub Calculations Tab
    ' We want to have that this opens a dialog which only shows calculations and summary (and combine) as options in type
    Private Sub cmdSubAdd_Click(sender As Object, e As EventArgs) Handles cmdSubAdd.Click

    End Sub

    Private Sub ucrType_NameChanged() Handles ucrType.NameChanged
        DisplayOptions()
        If ucrType.IsEmpty Then
            clsCalculationFunction.RemoveParameterByName("type")
        Else
            clsCalculationFunction.AddParameter("type", Chr(34) & ucrType.GetText() & Chr(34))
        End If
    End Sub

    Private Sub ucrCalcSummary_SelectionChanged() Handles ucrCalcSummary.SelectionChanged
        Dim strCalcFromList As String
        Dim strColumn As String

        If Not ucrCalcSummary.ucrReceiverForCalculation.IsEmpty Then
            clsCalculationFunction.AddParameter("function_exp", ucrCalcSummary.ucrReceiverForCalculation.GetText())
        Else
            clsCalculationFunction.RemoveParameterByName("function_exp")
        End If

        'Need to do this instead of with RFunctions because the calculated_from list can have multiple items with the same label
        If ucrCalcSummary.ucrSelectorForCalculations.lstVariablesInReceivers.Count > 0 Then
            strCalcFromList = "list("
            For i = 0 To ucrCalcSummary.ucrSelectorForCalculations.lstVariablesInReceivers.Count - 1
                strColumn = ucrCalcSummary.ucrSelectorForCalculations.lstVariablesInReceivers(i)
                If i > 0 Then
                    strCalcFromList = ", " & strCalcFromList
                End If
                strCalcFromList = strCalcFromList & ucrCalcSummary.ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.Text & " = " & strColumn
            Next
            strCalcFromList = strCalcFromList & ")"
            clsCalcFromList.AddParameter("calculated_from", strCalcFromList)
        Else
            clsCalcFromList.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub ucrCalculationName_NameChanged() Handles ucrCalculationName.NameChanged
        If ucrCalculationName.IsEmpty Then
            clsCalculationFunction.RemoveParameterByName("name")
        Else
            clsCalculationFunction.AddParameter("name", ucrCalculationName.GetText())
        End If
    End Sub

    Private Sub ucrColumnName_NameChanged() Handles ucrColumnName.NameChanged
        If ucrColumnName.IsEmpty Then
            clsCalculationFunction.RemoveParameterByName("result_name")
        Else
            clsCalculationFunction.AddParameter("result_name", ucrColumnName.GetText())
        End If
    End Sub
End Class