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
Public Class sdgSummaries
    Public clsListFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Public strSummariesParameter As String
    Private lstCheckboxes As New List(Of ucrCheck)

    Private Sub sdgDescribe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrChkNonMissing.SetParameter(New RParameter("summary_count_non_missing", 1), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkNonMissing.SetText("N Non Missing")

        ucrChkNMissing.SetParameter(New RParameter("summary_count_missing", 2), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkNMissing.SetText("N Missing")

        ucrChkNTotal.SetParameter(New RParameter("summary_count", 3), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkNTotal.SetText("N Total")

        ucrChkMean.SetParameter(New RParameter("summary_mean", 4), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkMean.SetText("Mean")

        ucrChkMinimum.SetParameter(New RParameter("summary_min", 5), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkMinimum.SetText("Minimum")

        ucrChkMode.SetParameter(New RParameter("summary_mode", 6), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkMode.SetText("Mode")

        ucrChkMaximum.SetParameter(New RParameter("summary_max", 7), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkMaximum.SetText("Maximum")

        ucrChkMedian.SetParameter(New RParameter("summary_median", 8), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkMedian.SetText("Median")

        ucrChkStdDev.SetParameter(New RParameter("summary_sd", 9), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkStdDev.SetText("Standard Deviation")

        ucrChkRange.SetParameter(New RParameter("summary_range", 10), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkRange.SetText("Range")

        ucrChkSum.SetParameter(New RParameter("summary_sum", 11), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkSum.SetText("Sum")

        ucrChkVariance.SetParameter(New RParameter("summary_var", 12), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkVariance.SetText("Variance")

        ucrChkQuartiles.SetParameter(New RParameter("summary_quartiles", 13), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkQuartiles.Enabled = False 'To be enabled once quartiles summary function has is implemented in Instat object
        ucrChkQuartiles.SetText("Quartiles")

        lstCheckboxes = New List(Of ucrCheck)
        lstCheckboxes.AddRange({ucrChkNTotal, ucrChkNonMissing, ucrChkNMissing, ucrChkMean, ucrChkMinimum, ucrChkMode, ucrChkMaximum, ucrChkMedian, ucrChkStdDev, ucrChkVariance, ucrChkRange, ucrChkSum, ucrChkQuartiles})
        For Each ctrTemp As ucrCheck In lstCheckboxes
            ctrTemp.SetParameterValue(Chr(34) & ctrTemp.GetParameter().strArgumentName & Chr(34))
            ctrTemp.SetParameterIncludeArgumentName(False)
        Next
        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsListFunction = clsNewRFunction
        SetRCode(Me, clsListFunction, bReset)
    End Sub

    Public ReadOnly Property SummaryCount As Integer
        Get
            Dim iCount As Integer = 0
            For Each ucrTemp As ucrCheck In lstCheckboxes
                If ucrTemp.Checked Then
                    iCount = iCount + 1
                End If
            Next
            Return iCount
        End Get
    End Property

    Private Sub ucrButtonsSummaries_ClickReturn(sender As Object, e As EventArgs) Handles ucrButtonsSummaries.ClickReturn
        'Temp solution to telling user why OK not enabled. Should be something on the main dialog to show this instead.
        'Maybe, number of summaries selected.
        If SummaryCount = 0 Then
            MsgBox("No summaries selected. Ok will not be enabled on the main dialog.", Title:="No summaries selected", Buttons:=MsgBoxStyle.Information)
        End If
    End Sub
End Class