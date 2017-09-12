' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
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
        lstCheckboxes = New List(Of ucrCheck)

        ucrChkNonMissing.SetParameter(New RParameter("summary_count_non_missing", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_count_non_missing" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkNonMissing.SetText("N Non Missing")

        ucrChkNMissing.SetParameter(New RParameter("summary_count_missing", 2), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_count_missing" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkNMissing.SetText("N Missing")

        ucrChkNTotal.SetParameter(New RParameter("summary_count", 3), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_count" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkNTotal.SetText("N Total")

        ucrChkMean.SetParameter(New RParameter("summary_mean", 4), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_mean" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMean.SetText("Mean")

        ucrChkMinimum.SetParameter(New RParameter("summary_min", 5), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_min" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMinimum.SetText("Minimum")

        ucrChkMode.SetParameter(New RParameter("summary_mode", 6), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_mode" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMode.SetText("Mode")

        ucrChkMaximum.SetParameter(New RParameter("summary_max", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_max" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMaximum.SetText("Maximum")

        ucrChkMedian.SetParameter(New RParameter("summary_median", 8), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_median" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMedian.SetText("Median")

        ucrChkStdDev.SetParameter(New RParameter("summary_sd", 9), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_sd" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkStdDev.SetText("Standard Deviation")

        ucrChkRange.SetParameter(New RParameter("summary_range", 10), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_range" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRange.SetText("Range")

        ucrChkSum.SetParameter(New RParameter("summary_sum", 11), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_sum" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSum.SetText("Sum")

        ucrChkVariance.SetParameter(New RParameter("summary_var", 12), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_var" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkVariance.SetText("Variance")

        ucrChkUpperQuartile.SetParameter(New RParameter("upper_quartile", 13), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "upper_quartile" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkUpperQuartile.SetText("Upper Quartile")

        ucrChkLowerQuartile.SetParameter(New RParameter("lower_quartile", 14), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "lower_quartile" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkLowerQuartile.SetText("Lower Quartile")

        ucrChkKurtosis.SetParameter(New RParameter("summary_kurtosis", 15), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_kurtosis" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkKurtosis.SetText("Kurtosis")

        ucrChkSkewness.SetParameter(New RParameter("summary_skewness", 16), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_skewness" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSkewness.SetText("Skewness")

        ucrChkCoefficientOfVariation.SetParameter(New RParameter("summary_coef_var", 17), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_coef_var" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCoefficientOfVariation.SetText("Coefficient Of Variation")

        ucrChkMedianAbsoluteDeviation.SetParameter(New RParameter("summary_median_absolute_deviation", 18), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_median_absolute_deviation" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMedianAbsoluteDeviation.SetText("Median Absolute Deviation (MAD)")

        ucrChkQn.SetParameter(New RParameter("summary_Qn", 19), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_Qn" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkQn.SetText("Qn")

        ucrChkSn.SetParameter(New RParameter("summary_Sn", 20), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_Sn" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSn.SetText("Sn")

        'ucrPnlMissingOptions.AddRadioButton(rdoNumber)
        'ucrPnlMissingOptions.AddRadioButton(rdoPercentage)

        'ucrPnlMissingOptions.AddToLinkedControls({ucrNudNumber}, {rdoNumber}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlMissingOptions.AddToLinkedControls({ucrNudPercentage}, {rdoPercentage}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudPercentage.SetLinkedDisplayControl(lblPercentage)
        ucrNudNumber.SetLinkedDisplayControl(lblNumber)

        lstCheckboxes.AddRange({ucrChkNTotal, ucrChkNonMissing, ucrChkNMissing, ucrChkMean, ucrChkMinimum, ucrChkMode, ucrChkMaximum, ucrChkMedian, ucrChkStdDev, ucrChkVariance, ucrChkRange, ucrChkSum, ucrChkUpperQuartile, ucrChkLowerQuartile, ucrChkMedianAbsoluteDeviation, ucrChkKurtosis, ucrChkCoefficientOfVariation, ucrChkSkewness, ucrChkQn, ucrChkSn})
        'TODO: This needs modifying summaries functions to allow this options to be implemented.
        tbMissingOptions.Enabled = False
        For Each ctrTemp As ucrCheck In lstCheckboxes
            ctrTemp.SetParameterIncludeArgumentName(False)
            ctrTemp.SetRDefault(Chr(34) & Chr(34))
        Next
        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsListFunction = clsNewRFunction
        SetRCode(Me, clsListFunction, bReset)

        If bReset Then
            tbSummaries.SelectedIndex = 0
        End If
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