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
    Public clsRType, clsRFilter, clsRCalculation As New RSyntax
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
    End Sub

    Private Sub SetDefaults()
        ucrSelectorBy.Reset()
        ucrSelectorBy.Focus()
        ucrType.SetName("calculation")
        DisplayOptions()
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
            rdoDoNotSave.Checked = True
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

        ElseIf ucrType.GetText = "by" Then
            TypeBy()
        ElseIf ucrType.GetText = "filter" Then
            TypeFilter()
        Else
            ' combine options
        End If
    End Sub

    Private Sub TypeBy()
        clsRType.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsRType.AddParameter("calculated_from", "list(" & ucrSelectorBy.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "=" & ucrReceiverBy.GetVariableNames() & ")")
        ' I believe that the variable names automatically have chr(34) around them

        ' not sure about calculation name - this is what is displayed in the item box in the dlg.

        If rdoSaveCalculation.Checked Then
            clsRType.AddParameter("save", "1")
        Else
            clsRType.AddParameter("save", "0")
        End If

    End Sub

    Private Sub TypeFilter()
        clsRFilter.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsRFilter.AddParameter("calculated_from", )

        If rdoSaveCalculation.Checked Then
            clsRFilter.AddParameter("save", "1")
        Else
            clsRFilter.AddParameter("save", "0")
        End If
    End Sub

    Private Sub TypeCalculate()
        clsRCalculation.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsRCalculation.AddParameter("result_name", Chr(34) & ucrCalculationName.ToString & Chr(34))

        If rdoSaveCalculation.Checked Then
            clsRCalculation.AddParameter("save", "1")
        ElseIf rdoSaveCalcAndResult.Checked Then
            clsRCalculation.AddParameter("save", "2")
        Else
            clsRCalculation.AddParameter("save", "0")
        End If
    End Sub

    Private Sub rdoSaveOptions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDoNotSave.CheckedChanged, rdoSaveCalculation.CheckedChanged, rdoSaveCalcAndResult.CheckedChanged
        RunType()
    End Sub
End Class