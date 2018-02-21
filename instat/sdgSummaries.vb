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
    Public clsListFunction, clsDefaultFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Private lstCheckboxes As New List(Of ucrCheck)
    Private ucrBaseSelector As ucrSelector
    Public strDataFrame As String

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
        ucrChkSkewness.SetText("Skewness(3rd Moment)")

        ucrChkMc.SetParameter(New RParameter("summary_skewness_mc", 20), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_skewness_mc" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMc.SetText("mc")

        ucrChkCoefficientOfVariation.SetParameter(New RParameter("summary_coef_var", 17), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_coef_var" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCoefficientOfVariation.SetText("Coefficient Of Variation")

        ucrChkMedianAbsoluteDeviation.SetParameter(New RParameter("summary_median_absolute_deviation", 18), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_median_absolute_deviation" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMedianAbsoluteDeviation.SetText("Median Absolute Deviation (MAD)")

        ucrChkQn.SetParameter(New RParameter("summary_Qn", 19), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_Qn" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkQn.SetText("Qn")

        ucrChkSn.SetParameter(New RParameter("summary_Sn", 20), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_Sn" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSn.SetText("Sn")

        ucrChkProportion.SetText("Proportion")

        ucrChkCount.SetText("Count")

        ucrChkPercentage.SetText("Percentage")

        ucrChkCorrelations.SetParameter(New RParameter("summary_cor", 21), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_cor" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCorrelations.SetText("Correlations")

        ucrChkCovariance.SetParameter(New RParameter("summary_cov", 22), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_cov" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCovariance.SetText("Covariance")

        ucrReceiverSecondVariable.Selector = ucrSelectorSecondVariable
        ucrReceiverSecondVariable.SetMeAsReceiver()

        ucrChkFirst.SetParameter(New RParameter("summary_first", 23), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_first" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkFirst.SetText("First")

        ucrChkLast.SetParameter(New RParameter("summary_last", 24), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_last" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkLast.SetText("Last")

        ucrChknth.SetParameter(New RParameter("summary_nth", 25), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_nth" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChknth.SetText("nth")

        ucrChkn_distinct.SetParameter(New RParameter("summary_n_distinct", 26), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_n_distinct" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkn_distinct.SetText("n_distinct")

        ucrChkPercentile.SetParameter(New RParameter("summary_quantile", 27), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_quantile" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkPercentile.SetText("Percentile")

        ucrInputPercentile.SetParameter(New RParameter("probs", 7))
        ucrInputPercentile.SetValidationTypeAsNumeric()

        'linking controls
        ucrChkPercentile.AddToLinkedControls(ucrInputPercentile, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.25)
        ucrChkProportion.AddToLinkedControls({ucrInputComboProp, ucrChkPercentage, ucrInputProp}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCount.AddToLinkedControls({ucrInputComboCount, ucrInputCount}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTrimmedMean.AddToLinkedControls(ucrNudFraction, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudFraction.SetLinkedDisplayControl(lblFractionTrimmed)
        ucrChknth.AddToLinkedControls(urInputN, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        urInputN.SetLinkedDisplayControl(lblInputN)

        ucrChkTrimmedMean.SetParameter(New RParameter("summary_mean", 27), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_mean" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkTrimmedMean.SetText("Trimmed Mean")

        ucrNudFraction.SetParameter(New RParameter("trim", 5))
        ucrNudFraction.Maximum = 0.5
        ucrNudFraction.DecimalPlaces = 1
        ucrNudFraction.Increment = 0.1
        ucrNudFraction.SetRDefault(0)

        urInputN.SetParameter(New RParameter("n", 6))
        urInputN.SetValidationTypeAsNumeric()

        ucrInputComboProp.SetParameter(New RParameter("inequality"))
        Dim dctProportion As New Dictionary(Of String, String)
        dctProportion.Add("<", "<")
        dctProportion.Add("<=", "<=")
        dctProportion.Add(">", ">")
        dctProportion.Add(">=", ">=")
        dctProportion.Add("==", "==")
        ucrInputComboProp.SetItems(dctProportion)
        ucrInputComboProp.SetDropDownStyleAsNonEditable()
        ucrInputComboProp.SetRDefault(">")

        ucrInputComboCount.SetParameter(New RParameter("inequality"))
        Dim dctCount As New Dictionary(Of String, String)
        dctCount.Add("<", "<")
        dctCount.Add("<=", "<=")
        dctCount.Add(">", ">")
        dctCount.Add(">=", ">=")
        dctCount.Add("==", "==")
        ucrInputComboCount.SetItems(dctProportion)
        ucrInputComboCount.SetDropDownStyleAsNonEditable()
        ucrInputComboCount.SetRDefault(">")

        'ucrPnlMissingOptions.AddRadioButton(rdoNumber)
        'ucrPnlMissingOptions.AddRadioButton(rdoPercentage)

        'ucrPnlMissingOptions.AddToLinkedControls({ucrNudNumber}, {rdoNumber}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlMissingOptions.AddToLinkedControls({ucrNudPercentage}, {rdoPercentage}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudPercentage.SetLinkedDisplayControl(lblPercentage)
        ucrNudNumber.SetLinkedDisplayControl(lblNumber)

        lstCheckboxes.AddRange({ucrChkNTotal, ucrChkNonMissing, ucrChkNMissing, ucrChkMean, ucrChkMinimum, ucrChkMode, ucrChkMaximum, ucrChkMedian, ucrChkStdDev, ucrChkVariance, ucrChkRange, ucrChkSum, ucrChkUpperQuartile, ucrChkLowerQuartile, ucrChkMedianAbsoluteDeviation, ucrChkKurtosis, ucrChkCoefficientOfVariation, ucrChkSkewness, ucrChkMc, ucrChkQn, ucrChkSn, ucrChkCorrelations, ucrChkCovariance, ucrChkFirst, ucrChkLast, ucrChknth, ucrChkn_distinct, ucrChkTrimmedMean, ucrChkPercentile})
        'TODO: This needs modifying summaries functions to allow this options to be implemented.
        tbMissingOptions.Enabled = False
        For Each ctrTemp As ucrCheck In lstCheckboxes
            ctrTemp.SetParameterIncludeArgumentName(False)
            ctrTemp.SetRDefault(Chr(34) & Chr(34))
        Next
        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, clsNewDefaultFunction As RFunction, Optional ucrNewBaseSelector As ucrSelector = Nothing, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsListFunction = clsNewRFunction
        clsDefaultFunction = clsNewDefaultFunction

        'This is meant to force selector select the current dataframe as selected in the main dialog
        ucrBaseSelector = ucrNewBaseSelector
        If ucrBaseSelector IsNot Nothing AndAlso ucrBaseSelector.strCurrentDataFrame <> "" Then
            strDataFrame = ucrBaseSelector.strCurrentDataFrame
            ucrSelectorSecondVariable.SetDataframe(strDataFrame, False)
        End If

        'ucrInputComboCount.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        'ucrInputComboProp.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputPercentile.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrNudFraction.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        urInputN.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrChkPercentile.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkTrimmedMean.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkNTotal.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkNonMissing.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkNMissing.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMean.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMinimum.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMode.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMaximum.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMedian.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkStdDev.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkVariance.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkRange.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkSum.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkUpperQuartile.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkLowerQuartile.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMedianAbsoluteDeviation.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkKurtosis.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkCoefficientOfVariation.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkSkewness.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMc.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkQn.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkSn.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkCorrelations.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkCovariance.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkFirst.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkLast.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChknth.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkn_distinct.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)

        If bReset Then
            tbSummaries.SelectedIndex = 0
            ucrSelectorSecondVariable.Reset()
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

    Private Sub ucrChkCorrelations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCorrelations.ControlValueChanged, ucrChkCovariance.ControlValueChanged, ucrChkFirst.ControlValueChanged, ucrChkLast.ControlValueChanged, ucrChknth.ControlValueChanged, ucrChkn_distinct.ControlValueChanged, ucrReceiverSecondVariable.ControlValueChanged
        If ucrChkCorrelations.Checked OrElse ucrChkCovariance.Checked Then
            clsDefaultFunction.AddParameter("y", ucrReceiverSecondVariable.GetVariableNames, iPosition:=3)
        Else
            clsDefaultFunction.RemoveParameterByName("y")
        End If
        If ucrChkFirst.Checked OrElse ucrChkLast.Checked OrElse ucrChknth.Checked Then
            clsDefaultFunction.AddParameter("order_by", ucrReceiverSecondVariable.GetVariableNames, iPosition:=4)
        Else
            clsDefaultFunction.RemoveParameterByName("order_by")
        End If
    End Sub
End Class