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
    Public bEnable2VariableTab As Boolean = True
    Public bOkEnabled As Boolean = True

    Private Sub sdgDescribe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        tbTwoVariables.Enabled = bEnable2VariableTab
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

        ucrChkCorrelations.SetParameter(New RParameter("summary_cor", 21), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_cor" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCorrelations.SetText("Correlations")

        ucrChkCovariance.SetParameter(New RParameter("summary_cov", 22), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_cov" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCovariance.SetText("Covariance")

        ucrReceiverSecondVariable.Selector = ucrSelectorSecondVariable
        ucrReceiverSecondVariable.SetMeAsReceiver()
        ucrReceiverSecondVariable.SetIncludedDataTypes({"numeric"})

        ucrReceiverOrderBy.Selector = ucrSelectorOrderBy
        ucrReceiverOrderBy.SetMeAsReceiver()

        ucrChkFirst.SetParameter(New RParameter("summary_first", 23), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_first" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkFirst.SetText("First")

        ucrChkLast.SetParameter(New RParameter("summary_last", 24), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_last" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkLast.SetText("Last")

        ucrChknth.SetParameter(New RParameter("summary_nth", 25), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_nth" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChknth.SetText("nth")

        ucrChkOrderBy.SetText("Order by another variable")

        ucrChkn_distinct.SetParameter(New RParameter("summary_n_distinct", 26), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_n_distinct" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkn_distinct.SetText("n_distinct")

        ucrChkPercentile.SetParameter(New RParameter("summary_quantile", 27), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_quantile" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkPercentile.SetText("Percentile")

        ucrInputPercentile.SetParameter(New RParameter("probs", 12))
        ucrInputPercentile.SetValidationTypeAsNumeric(dcmMin:=0, dcmMax:=1)
        ucrInputPercentile.AddQuotesIfUnrecognised = False

        'linking controls
        ucrChkPercentile.AddToLinkedControls(ucrInputPercentile, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.25)
        ucrChkTrimmedMean.AddToLinkedControls(ucrNudFraction, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChknth.AddToLinkedControls(ucrInputN, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        ucrChkProportion.AddToLinkedControls(ucrInputComboPropTest, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="==")
        ucrChkProportion.AddToLinkedControls(ucrInputPropValue, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkProportion.AddToLinkedControls(ucrChkPercentage, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCount.AddToLinkedControls(ucrInputComboCountTest, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="==")
        ucrChkCount.AddToLinkedControls(ucrInputCountValue, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkIncludeMissingOpt.AddToLinkedControls(ucrPnlMissingOptions, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoNumber)
        ucrPnlMissingOptions.AddToLinkedControls({ucrNudNumber}, {rdoNumber}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrPnlMissingOptions.AddToLinkedControls({ucrNudPercentage}, {rdoPercentage}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrPnlMissingOptions.AddToLinkedControls({ucrNudNumberNotMissing}, {rdoNumberNotMissing}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=340)

        ucrInputN.SetLinkedDisplayControl(lblInputN)
        ucrNudFraction.SetLinkedDisplayControl(lblFractionTrimmed)
        ucrNudNumber.SetLinkedDisplayControl(lblNumber)
        ucrNudPercentage.SetLinkedDisplayControl(lblPercentage)
        ucrNudNumberNotMissing.SetLinkedDisplayControl(lblNumberNotMissing)

        ucrPnlMissingOptions.SetParameter(New RParameter("na_type", 9))
        ucrPnlMissingOptions.AddRadioButton(rdoNumber, Chr(34) & "'n'" & Chr(34))
        ucrPnlMissingOptions.AddRadioButton(rdoPercentage, Chr(34) & "'prop'" & Chr(34))
        ucrPnlMissingOptions.AddRadioButton(rdoNumberNotMissing, Chr(34) & "'n_non_miss'" & Chr(34))

        ucrChkTrimmedMean.SetParameter(New RParameter("summary_trimmed_mean", 27), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_trimmed_mean" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkTrimmedMean.SetText("Trimmed Mean")

        ucrNudFraction.SetParameter(New RParameter("trimmed", 13))
        ucrNudFraction.Maximum = 0.5
        ucrNudFraction.DecimalPlaces = 2
        ucrNudFraction.Increment = 0.01
        ucrNudFraction.SetRDefault(0)

        ucrInputN.SetParameter(New RParameter("nth_value", 14))
        ucrInputN.AddQuotesIfUnrecognised = False
        ucrInputN.SetValidationTypeAsNumeric()

        ucrInputComboPropTest.SetParameter(New RParameter("prop_test", 9))
        Dim dctProportionTest As New Dictionary(Of String, String)
        dctProportionTest.Add("<", Chr(34) & "'<'" & Chr(34))
        dctProportionTest.Add("<=", Chr(34) & "'<='" & Chr(34))
        dctProportionTest.Add(">", Chr(34) & "'>'" & Chr(34))
        dctProportionTest.Add(">=", Chr(34) & "'>='" & Chr(34))
        dctProportionTest.Add("==", Chr(34) & "'=='" & Chr(34))
        ucrInputComboPropTest.SetItems(dctProportionTest)
        ucrInputComboPropTest.SetDropDownStyleAsNonEditable()

        ucrInputPropValue.SetParameter(New RParameter("prop_value", 8))
        ucrInputPropValue.SetValidationTypeAsNumeric()
        ucrInputPropValue.AddQuotesIfUnrecognised = False

        ucrInputComboCountTest.SetParameter(New RParameter("count_test", 11))
        Dim dctCountTest As New Dictionary(Of String, String)
        dctCountTest.Add("<", Chr(34) & "'<'" & Chr(34))
        dctCountTest.Add("<=", Chr(34) & "'<='" & Chr(34))
        dctCountTest.Add(">", Chr(34) & "'>'" & Chr(34))
        dctCountTest.Add(">=", Chr(34) & "'>='" & Chr(34))
        dctCountTest.Add("==", Chr(34) & "'=='" & Chr(34))
        ucrInputComboCountTest.SetItems(dctCountTest)
        ucrInputComboCountTest.SetDropDownStyleAsNonEditable()

        ucrInputCountValue.SetParameter(New RParameter("count_value", 10))
        ucrInputCountValue.SetValidationTypeAsNumeric()
        ucrInputCountValue.AddQuotesIfUnrecognised = False

        ucrChkProportion.SetParameter(New RParameter("proportion_calc", 28), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "proportion_calc" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkProportion.SetText("Proportion")

        ucrChkPercentage.SetParameter(New RParameter("As_percentage", 7))
        ucrChkPercentage.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPercentage.SetRDefault("FALSE")
        ucrChkPercentage.SetText("As Percentage")

        ucrChkCount.SetParameter(New RParameter("count_calc", 29), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "count_calc" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCount.SetText("Count")

        ucrChkIncludeMissingOpt.SetText("Inlcude Missing Options")
        ucrChkIncludeMissingOpt.AddParameterPresentCondition(True, "na_type")
        ucrChkIncludeMissingOpt.AddParameterPresentCondition(False, "na_type", False)

        ucrNudPercentage.SetParameter(New RParameter("na_max_prop", 10))

        ucrNudNumber.SetParameter(New RParameter("na_max_n", 11))

        ucrNudNumberNotMissing.SetParameter(New RParameter("na_min_n", 12))
        ucrNudNumberNotMissing.SetMinMax(0, iNewMax:=Integer.MaxValue)

        ucrChkStandardErrorOfMean.SetParameter(New RParameter("standard_error_mean", 30), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "standard_error_mean" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkStandardErrorOfMean.SetText("Standard Error of the Mean")

        lstCheckboxes.AddRange({ucrChkNTotal, ucrChkNonMissing, ucrChkNMissing, ucrChkMean, ucrChkMinimum, ucrChkMode, ucrChkMaximum, ucrChkMedian, ucrChkStdDev, ucrChkVariance, ucrChkRange, ucrChkSum, ucrChkUpperQuartile, ucrChkLowerQuartile, ucrChkMedianAbsoluteDeviation, ucrChkKurtosis, ucrChkCoefficientOfVariation, ucrChkSkewness, ucrChkMc, ucrChkQn, ucrChkSn, ucrChkCorrelations, ucrChkCovariance, ucrChkFirst, ucrChkLast, ucrChknth, ucrChkn_distinct, ucrChkTrimmedMean, ucrChkPercentile, ucrChkProportion, ucrChkCount, ucrChkStandardErrorOfMean})

        For Each ctrTemp As ucrCheck In lstCheckboxes
            ctrTemp.SetParameterIncludeArgumentName(False)
            ctrTemp.SetRDefault(Chr(34) & Chr(34))
        Next
        bControlsInitialised = True
        MissingOptionsVisibilty()
        PositionOptions()
        OrderByCheckEnabled()
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
            ucrSelectorOrderBy.SetDataframe(strDataFrame, False)
        End If

        ucrNudPercentage.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrNudNumber.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrNudNumberNotMissing.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrChkIncludeMissingOpt.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrPnlMissingOptions.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)

        ucrChkPercentage.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputPropValue.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputComboPropTest.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputCountValue.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputComboCountTest.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputPercentile.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrNudFraction.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputN.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)

        ucrChkCount.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkProportion.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
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
        ucrChkStandardErrorOfMean.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)

        If bReset Then
            tbSummaries.SelectedIndex = 0
            ucrSelectorSecondVariable.Reset()
            ucrSelectorOrderBy.Reset()
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
            MsgBox("No summaries selected. Ok will Not be enabled on the main dialog.", Title:="No summaries selected", Buttons:=MsgBoxStyle.Information)
        End If
        If (ucrChkCorrelations.Checked OrElse ucrChkCovariance.Checked) AndAlso ucrReceiverSecondVariable.IsEmpty Then
            MsgBox("Second Variable receiver in Two-Variables tab is empty. Ok will Not be enabled on the main dialog.", Title:="Second Variable Receiver", Buttons:=MsgBoxStyle.Information)
            bOkEnabled = False
        Else
            bOkEnabled = True
        End If
    End Sub

    Private Sub MissingOptionsVisibilty()
        If ucrChkCorrelations.Checked OrElse ucrChkCovariance.Checked Then
            ucrSelectorSecondVariable.Show()
            ucrReceiverSecondVariable.Show()
            lblSecondVariable.Show()
        Else
            ucrSelectorSecondVariable.Hide()
            ucrReceiverSecondVariable.Hide()
            lblSecondVariable.Hide()
        End If
    End Sub

    Private Sub PositionOptions()
        If ucrChkOrderBy.Checked Then
            ucrSelectorOrderBy.Show()
            ucrReceiverOrderBy.Show()
            lblOrderBy.Show()
        Else
            ucrSelectorOrderBy.Hide()
            ucrReceiverOrderBy.Hide()
            lblOrderBy.Hide()
        End If
    End Sub

    Private Sub OrderByCheckEnabled()
        If ucrChkFirst.Checked OrElse ucrChkLast.Checked OrElse ucrChknth.Checked Then
            ucrChkOrderBy.Enabled = True
        ElseIf Not ucrChkFirst.Checked AndAlso Not ucrChkLast.Checked AndAlso Not ucrChknth.Checked Then
            ucrChkOrderBy.Checked = False
            ucrChkOrderBy.Enabled = False
        End If
    End Sub

    Private Sub ucrChkCorrelations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCorrelations.ControlValueChanged, ucrChkCovariance.ControlValueChanged, ucrReceiverSecondVariable.ControlValueChanged
        MissingOptionsVisibilty()
        If ucrChkCorrelations.Checked OrElse ucrChkCovariance.Checked Then
            clsDefaultFunction.AddParameter("y", ucrReceiverSecondVariable.GetVariableNames, iPosition:=3)
        Else
            clsDefaultFunction.RemoveParameterByName("y")
        End If
    End Sub

    Private Sub ucrReceiverOrderBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOrderBy.ControlValueChanged
        PositionOptions()
        If Not ucrReceiverOrderBy.IsEmpty Then
            clsDefaultFunction.AddParameter("order_by", ucrReceiverOrderBy.GetVariableNames, iPosition:=4)
        Else
            clsDefaultFunction.RemoveParameterByName("order_by")
        End If
    End Sub

    Private Sub ucrChkFirst_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFirst.ControlValueChanged, ucrChkLast.ControlValueChanged, ucrChknth.ControlValueChanged
        OrderByCheckEnabled()
    End Sub

    Private Sub ucrChkOrderBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOrderBy.ControlValueChanged
        PositionOptions()
        OrderByCheckEnabled()
    End Sub
End Class