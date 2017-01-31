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
Imports instat
Imports instat.Translations
Public Class sdgSummaries
    Public clsRSummaries As New RFunction
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    'Public clsGraphOneVariable As New RFunction
    Public strSummariesParameter
    Private Sub sdgDescribe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub SetDefaults()

    End Sub

    Public Sub InitialiseControls()
        ucrChkNonMissing.SetText("N Non Missing")
        ucrChkNMissing.SetText("N Missing")
        ucrChkNTotal.SetText("N Total")
        ucrChkNTotal.Tag = "summary_count"
        ucrChkNonMissing.Tag = "summary_count_non_missing"
        ucrChkNMissing.Tag = "summary_count_missing"
        ucrChkMean.SetText("Mean")
        ucrChkMean.Tag = "summary_mean"
        ucrChkMinimum.SetText("Minimum")
        ucrChkMinimum.Tag = "summary_min"
        ucrChkMode.SetText("Mode")
        ucrChkMode.Tag = "summary_mode"
        ucrChkMaximum.SetText("Maximum")
        ucrChkMaximum.Tag = "summary_max"
        ucrChkMedian.SetText("Median")
        ucrChkMedian.Tag = "summary_median"
        ucrChkStdDev.SetText("Standard Deviation")
        ucrChkStdDev.Tag = "summary_sd"
        ucrChkRange.SetText("Range")
        ucrChkRange.Tag = "summary_range"
        ucrChkSum.SetText("Sum")
        ucrChkSum.Tag = "summary_sum"
        ucrChkVariance.SetText("Variance")
        ucrChkQuartiles.SetText("Quartiles")

        ucrChkNonMissing.Checked = True
        ucrChkNTotal.Checked = True
        ucrChkSum.Checked = True

        'To add quartiles, variance etc
        'ucrChkMean.Checked = False
        'chkStdDev.Checked = False
        'chkMode.Checked = False
        'chkMinimum.Checked = False
        'chkMaximum.Checked = False
        'chkNMissing.Checked = False
        'chkNonMissing.Checked = True
        'chkNTotal.Checked = True
        'chkMedian.Checked = False
        'chkRange.Checked = False
        'chkSum.Checked = True
        'ucrChkFreeScaleAxisforFacets.SetText("Free Scale Axis for Facets")
        'clsGraphOneVariable.AddParameter(SetParameter(New RParameter("free_scale_axis"))
        'ucrChkFreeScaleAxisforFacets.SetDefault("FALSE")

        bControlsInitialised = True
        SummariesParameters()
    End Sub

    Public Sub SummariesParameters()
        Dim lstCheckboxes As New List(Of ucrCheck)
        Dim chkSummary As ucrCheck
        Dim i As Integer = 0
        If lstCheckboxes.Count = 0 Then
            lstCheckboxes.AddRange({ucrChkNTotal, ucrChkNonMissing, ucrChkNMissing, ucrChkMean, ucrChkMinimum, ucrChkMode, ucrChkMaximum, ucrChkMedian, ucrChkStdDev, ucrChkRange, ucrChkSum, ucrChkQuartiles})
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

            clsRSummaries.AddParameter("summaries", strSummariesParameter)
        Else
            clsRSummaries.RemoveParameterByName("summaries")
        End If
    End Sub

    Public Sub SetMyRFunction(clsRNewSummaries As RFunction)
        'this sub should be removed once new implementation has been done on all dialogs linking to this subdialog
        'clsRSummaries = clsRNewSummaries
    End Sub

    'Private Sub grpsummaries_CheckedChanged(sender As Object, e As EventArgs)
    '    SummariesParameters()
    'End Sub

    Public Sub TestSummaries()
        SummariesParameters()
        If strSummariesParameter = "c()" Then
            MsgBox("OK will be disabled until you check at least one summary.")
        End If
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRSummaries = clsNewRFunction
        SetRCode(Me, clsRSummaries, bReset)
    End Sub

    Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNonMissing.ControlValueChanged, ucrChkNMissing.ControlValueChanged, ucrChkNTotal.ControlValueChanged, ucrChkNonMissing.ControlValueChanged, ucrChkMaximum.ControlValueChanged, ucrChkMean.ControlValueChanged, ucrChkMinimum.ControlValueChanged, ucrChkMode.ControlValueChanged, ucrChkMedian.ControlValueChanged, ucrChkStdDev.ControlValueChanged, ucrChkRange.ControlValueChanged, ucrChkVariance.ControlValueChanged, ucrChkQuartiles.ControlValueChanged
        TestSummaries()
    End Sub
End Class