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
Public Class sdgDescribe
    Public clsRDescribe As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub sdgDescribe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Public Sub SetDefaults()
        chkNTotal.Tag = "summary_count"
        chkNonMissing.Tag = "summary_count_non_missing"
        chkNMissing.Tag = "summary_count_missing"
        chkMean.Tag = "summary_mean"
        chkMinimum.Tag = "summary_min"
        chkMode.Tag = "summary_mode"
        chkMaximum.Tag = "summary_max"
        chkMedian.Tag = "summary_median"
        chkStdDev.Tag = "summary_sd"
        chkRange.Tag = "summary_range"
        chkSum.Tag = "summary_sum"
        chkMean.Checked = True
        chkStdDev.Checked = True
        chkMode.Checked = True
        chkMinimum.Checked = True
        chkMaximum.Checked = True
        chkNMissing.Checked = True
        chkNonMissing.Checked = True
        chkNTotal.Checked = True
        chkMedian.Checked = True
        chkRange.Checked = True
        chkSum.Checked = True
        SummariesParameters()
    End Sub

    Public Sub SummariesParameters()
        Dim lstCheckboxes As New List(Of CheckBox)
        Dim chkSummary As CheckBox
        Dim strSummariesParameter As String = ""
        Dim i As Integer = 0
        If lstCheckboxes.Count = 0 Then
            lstCheckboxes.AddRange({chkMean, chkMode, chkMinimum, chkMaximum, chkRange, chkStdDev, chkNTotal, chkMedian, chkQuartiles, chkNonMissing, chkNMissing, chkSum})
        End If

        strSummariesParameter = "c("
        For Each chkSummary In lstCheckboxes
            If chkSummary.Checked Then
                If i > 0 Then
                    strSummariesParameter = strSummariesParameter & ","
                End If
                strSummariesParameter = strSummariesParameter & Chr(34) & chkSummary.Tag & Chr(34)
                i = i + 1
            End If
        Next
        strSummariesParameter = strSummariesParameter & ")"
        If i > 0 Then
            clsRDescribe.AddParameter("summaries", strSummariesParameter)
        Else
            clsRDescribe.RemoveParameterByName("summaries")
        End If
    End Sub


    Public Sub SetUcrDescribe(clsRNewDescribe As RFunction)
        clsRDescribe = clsRNewDescribe
    End Sub

    Private Sub grpsummaries_CheckedChanged(sender As Object, e As EventArgs) Handles chkNTotal.CheckedChanged, chkNonMissing.CheckedChanged, chkNMissing.CheckedChanged, chkMode.CheckedChanged, chkMinimum.CheckedChanged, chkMaximum.CheckedChanged, chkSum.CheckedChanged, chkMean.CheckedChanged, chkRange.CheckedChanged, chkStdDev.CheckedChanged, chkMedian.CheckedChanged, chkQuartiles.CheckedChanged, chkVariance.CheckedChanged
        SummariesParameters()
    End Sub
End Class