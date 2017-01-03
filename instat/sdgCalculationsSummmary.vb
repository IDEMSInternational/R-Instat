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
    Public clsRFunction As New RFunction
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

        lstType.Add(New KeyValuePair(Of String, String)("Calculation", Chr(34) & "calculation" & Chr(34)))
        lstType.Add(New KeyValuePair(Of String, String)("Summary", Chr(34) & "summary" & Chr(34)))
        lstType.Add(New KeyValuePair(Of String, String)("By", Chr(34) & "by" & Chr(34)))
        lstType.Add(New KeyValuePair(Of String, String)("Filter", Chr(34) & "filter" & Chr(34)))
        '        lstType.Add(New KeyValuePair(Of String, String)("Combine", Chr(34) & "combination" & Chr(34)))
        ucrType.SetItems(lstType)
        ucrType.SetParameterName("type")

        clsRFunction.SetAssignTo(ucrCalculationName.ToString())
    End Sub

    Private Sub SetDefaults()
        ucrSelectorBy.Reset()
        ucrSelectorBy.Focus()
        ucrType.SetName("calculation")
        DisplayOptions()
        rdoDoNotSave.Checked = True
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

    Private Sub ucrType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ucrType.TextChanged
        DisplayOptions()
    End Sub

    Private Sub RunType()
        If ucrType.GetText = "calculation" Then
            TypeCalculate()
        ElseIf ucrType.GetText = "summary" Then
            TypeSummary()
        ElseIf ucrType.GetText = "by" Then
            TypeBy()
        ElseIf ucrType.GetText = "filter" Then
            TypeFilter()
        Else
            ' combine options
        End If
    End Sub

    Private Sub TypeBy()
        '        clsRType.AddParameter("calculated_from", "list(" & ucrSelectorBy.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "=" & ucrReceiverBy.GetVariableNames() & ")")
        ' I believe that the variable names automatically have chr(34) around them
        ' not sure about calculation name - this is what is displayed in the item box in the dlg.
    End Sub

    Private Sub TypeFilter()
    End Sub

    Private Sub TypeCalculate()
        '        clsRCalculation.AddParameter("result_name", Chr(34) & ucrCalculationName.ToString & Chr(34))
        '        clsRCalculation.AddParameter("calculated_from", "list(" & ucrCalcSummary.ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "=" & ucrCalcSummary.ucrReceiverForCalculation.GetVariableNames() & ")")
        '        clsRCalculation.AddParameter("function_exp", Chr(34) & ucrCalcSummary.ucrReceiverForCalculation.ToString() & Chr(34))
    End Sub

    Private Sub TypeSummary()
        '        clsRSummary.AddParameter("result_name", Chr(34) & ucrCalculationName.ToString & Chr(34))
        '        clsRSummary.AddParameter("calculated_from", "list(" & ucrCalcSummary.ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "=" & ucrCalcSummary.ucrReceiverForCalculation.GetVariableNames() & ")")
        '        clsRSummary.AddParameter("function_exp", Chr(34) & ucrCalcSummary.ucrReceiverForCalculation.ToString() & Chr(34))
    End Sub

    Private Sub rdoSaveOptions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDoNotSave.CheckedChanged, rdoSaveCalculation.CheckedChanged, rdoSaveCalcAndResult.CheckedChanged
        If rdoSaveCalculation.Checked Then
            clsRFunction.AddParameter("save", "1")
        ElseIf rdoSaveCalcAndResult.Checked Then
            clsRFunction.AddParameter("save", "2")
        Else
            clsRFunction.AddParameter("save", "0")
        End If
    End Sub

    ' Looking at Manipulations Tab
    Private Sub cmdManipAdd_Click(sender As Object, e As EventArgs) Handles cmdManipAdd.Click

    End Sub
    ' We want to have that this opens a dialog which only shows filter and by as options in type

    ' Sub Calculations Tab
    Private Sub cmdSubAdd_Click(sender As Object, e As EventArgs) Handles cmdSubAdd.Click

    End Sub
    ' We want to have that this opens a dialog which only shows calculations and summary (and combine) as options in type

End Class