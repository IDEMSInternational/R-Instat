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
    Public clsListFunction, clsDefaultFunction, clsConcFunction As New RFunction
    Public bControlsInitialised As Boolean = False
    Private lstCheckboxes As New List(Of ucrCheck)
    Private lstVerifCheckboxes As New List(Of ucrCheck)
    Private ucrBaseSelector As ucrSelector
    Public strDataFrame As String
    Private strWeightLabel As String
    Public bEnable2VariableTab As Boolean = True
    Public bOkEnabled As Boolean = True

    Private Sub sdgDescribe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        tbTwoVariables.Enabled = bEnable2VariableTab
    End Sub

    Public Sub InitialiseControls()

        ucrButtonsSummaries.iHelpTopicID = 183

        lstCheckboxes = New List(Of ucrCheck)

        ucrChkNonMissing.SetParameter(New RParameter("summary_count_non_missing", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_count_non_missing" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkNonMissing.SetText("N Non Missing")

        ucrChkNMissing.SetParameter(New RParameter("summary_count_missing", 2), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_count_missing" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkNMissing.SetText("N Missing")

        ucrChkNTotal.SetParameter(New RParameter("summary_count", 3), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_count" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkNTotal.SetText("N Total")

        ucrChkMean.SetParameter(New RParameter("summary_mean", 4), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_mean" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        ucrChkMinimum.SetParameter(New RParameter("summary_min", 5), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_min" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMinimum.SetText("Minimum")

        ucrChkMode.SetParameter(New RParameter("summary_mode", 6), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_mode" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMode.SetText("Mode")

        ucrChkMaximum.SetParameter(New RParameter("summary_max", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_max" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMaximum.SetText("Maximum")

        ucrChkMedian.SetParameter(New RParameter("summary_median", 8), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_median" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        ucrChkStdDev.SetParameter(New RParameter("summary_sd", 9), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_sd" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        ucrChkRange.SetParameter(New RParameter("summary_range", 10), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_range" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRange.SetText("Range")

        ucrChkSum.SetParameter(New RParameter("summary_sum", 11), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_sum" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        ucrChkVariance.SetParameter(New RParameter("summary_var", 12), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_var" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        ucrChkKurtosis.SetParameter(New RParameter("summary_kurtosis", 13), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_kurtosis" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        ucrChkSkewness.SetParameter(New RParameter("summary_skewness", 14), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_skewness" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        ucrChkMc.SetParameter(New RParameter("summary_skewness_mc", 15), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_skewness_mc" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMc.SetText("mc")

        ucrChkCoefficientOfVariation.SetParameter(New RParameter("summary_coef_var", 16), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_coef_var" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        ucrChkMedianAbsoluteDeviation.SetParameter(New RParameter("summary_median_absolute_deviation", 17), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_median_absolute_deviation" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        ucrChkQn.SetParameter(New RParameter("summary_Qn", 18), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_Qn" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkQn.SetText("Qn")

        ucrChkSn.SetParameter(New RParameter("summary_Sn", 19), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_Sn" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSn.SetText("Sn")

        ucrChkCorrelations.SetParameter(New RParameter("summary_cor", 20), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_cor" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        ucrChkCovariance.SetParameter(New RParameter("summary_cov", 21), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_cov" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        'circular
        ucrChkCircMean.SetParameter(New RParameter("summary_mean_circular", 22), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_mean_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCircMean.SetText("Mean")

        ucrChkCircMedian.SetParameter(New RParameter("summary_median_circular", 23), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_median_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCircMedian.SetText("Median")

        ucrChkMin.SetParameter(New RParameter("summary_min_circular", 24), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_min_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMin.SetText("Min")

        ucrChkMedianH.SetParameter(New RParameter("summary_medianHL_circular", 25), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_medianHL_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMedianH.SetText("MedianHL")

        ucrChkMax.SetParameter(New RParameter("summary_max_circular", 26), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_max_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMax.SetText("Max")

        ucrChkQ1.SetParameter(New RParameter("summary_Q1_circular", 27), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_Q1_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkQ1.SetText("Q1")

        ucrChkQ3.SetParameter(New RParameter("summary_Q3_circular", 28), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_Q3_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkQ3.SetText("Q3")

        ucrChkQuantile.SetParameter(New RParameter("summary_quantile", 29), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_quantile" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        ucrChkSd.SetParameter(New RParameter("summary_sd_circular", 30), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_sd_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSd.SetText("Sd")

        ucrChkVar.SetParameter(New RParameter("summary_var_circular", 31), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_var_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkVar.SetText("Var")

        ucrChkAngVar.SetParameter(New RParameter("summary_ang_var_circular", 32), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_ang_var_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkAngVar.SetText("Ang_var")

        ucrChkAngDev.SetParameter(New RParameter("summary_ang_dev_circular", 33), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_ang_dev_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkAngDev.SetText("Ang_dev")

        ucrChkrho.SetParameter(New RParameter("summary_rho_circular", 34), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_rho_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkrho.SetText("Rho")

        ucrChkCircRange.SetParameter(New RParameter("summary_range_circular", 35), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_range_circular" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCircRange.SetText("Range")

        ucrInputQuantile.SetParameter(New RParameter("probs", 1))
        ucrInputQuantile.SetValidationTypeAsNumeric(dcmMin:=0, dcmMax:=1)
        ucrInputQuantile.AddQuotesIfUnrecognised = False

        ucrReceiverSecondVariable.Selector = ucrSelectorSecondVariable
        ucrReceiverSecondVariable.SetMeAsReceiver()
        ucrReceiverSecondVariable.SetIncludedDataTypes({"numeric"})

        ucrReceiverOrderBy.Selector = ucrSelectorOrderBy
        ucrReceiverOrderBy.SetMeAsReceiver()

        ucrChkFirst.SetParameter(New RParameter("summary_first", 36), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_first" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkFirst.SetText("First")

        ucrChkLast.SetParameter(New RParameter("summary_last", 37), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_last" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkLast.SetText("Last")

        ucrChknth.SetParameter(New RParameter("summary_nth", 38), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_nth" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChknth.SetText("nth")

        ucrChkOrderBy.SetText("Order by another variable")

        ucrChkn_distinct.SetParameter(New RParameter("summary_n_distinct", 39), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_n_distinct" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkn_distinct.SetText("n_distinct")

        ucrChkPercentile.SetParameter(New RParameter("summary_quantile", 40), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_quantile" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkPercentile.SetText("Percentile")

        ucrInputPercentile.SetParameter(New RParameter("probs", 2))
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
        ucrChkQuantile.AddToLinkedControls(ucrInputQuantile, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkSample.AddToLinkedControls(ucrChkSetseed, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSetseed.AddToLinkedControls(ucrNudSeed, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)

        ucrInputN.SetLinkedDisplayControl(lblInputN)
        ucrNudFraction.SetLinkedDisplayControl(lblFractionTrimmed)

        ucrChkTrimmedMean.SetParameter(New RParameter("summary_trimmed_mean", 41), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_trimmed_mean" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkTrimmedMean.SetText("Trimmed Mean")

        ucrNudFraction.SetParameter(New RParameter("trimmed", 3))
        ucrNudFraction.Maximum = 0.5
        ucrNudFraction.DecimalPlaces = 2
        ucrNudFraction.Increment = 0.01
        ucrNudFraction.SetRDefault(0)

        ucrInputN.SetParameter(New RParameter("nth_value", 4))
        ucrInputN.AddQuotesIfUnrecognised = False
        ucrInputN.SetValidationTypeAsNumeric()

        ucrInputComboPropTest.SetParameter(New RParameter("prop_test", 5))
        Dim dctProportionTest As New Dictionary(Of String, String)
        dctProportionTest.Add("<", Chr(34) & "'<'" & Chr(34))
        dctProportionTest.Add("<=", Chr(34) & "'<='" & Chr(34))
        dctProportionTest.Add(">", Chr(34) & "'>'" & Chr(34))
        dctProportionTest.Add(">=", Chr(34) & "'>='" & Chr(34))
        dctProportionTest.Add("==", Chr(34) & "'=='" & Chr(34))
        ucrInputComboPropTest.SetItems(dctProportionTest)
        ucrInputComboPropTest.SetDropDownStyleAsNonEditable()

        ucrInputPropValue.SetParameter(New RParameter("prop_value", 6))
        ucrInputPropValue.SetValidationTypeAsNumeric()
        ucrInputPropValue.AddQuotesIfUnrecognised = False

        ucrInputComboCountTest.SetParameter(New RParameter("count_test", 7))
        Dim dctCountTest As New Dictionary(Of String, String)
        dctCountTest.Add("<", Chr(34) & "'<'" & Chr(34))
        dctCountTest.Add("<=", Chr(34) & "'<='" & Chr(34))
        dctCountTest.Add(">", Chr(34) & "'>'" & Chr(34))
        dctCountTest.Add(">=", Chr(34) & "'>='" & Chr(34))
        dctCountTest.Add("==", Chr(34) & "'=='" & Chr(34))
        ucrInputComboCountTest.SetItems(dctCountTest)
        ucrInputComboCountTest.SetDropDownStyleAsNonEditable()

        ucrInputCountValue.SetParameter(New RParameter("count_value", 8))
        ucrInputCountValue.SetValidationTypeAsNumeric()
        ucrInputCountValue.AddQuotesIfUnrecognised = False

        ucrChkProportion.SetParameter(New RParameter("proportion_calc", 42), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "proportion_calc" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkProportion.SetText("Proportion")

        ucrChkPercentage.SetParameter(New RParameter("As_percentage", 9))
        ucrChkPercentage.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPercentage.SetRDefault("FALSE")
        ucrChkPercentage.SetText("As Percentage")

        ucrChkCount.SetParameter(New RParameter("count_calc", 43), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "count_calc" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCount.SetText("Count")

        ucrChkStandardErrorOfMean.SetParameter(New RParameter("standard_error_mean", 44), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "standard_error_mean" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkStandardErrorOfMean.SetText("Standard Error of the Mean")

        'Verification::HydroGOF Options
        ucrChkMeanError.SetParameter(New RParameter("me", 45), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "me" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMeanError.SetText("me")
        ttVerificationSummaries.SetToolTip(ucrChkMeanError.chkCheck, "Mean error")

        ucrChkMeanAbsoluteError.SetParameter(New RParameter("mae", 46), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "mae" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMeanAbsoluteError.SetText("mae")
        ttVerificationSummaries.SetToolTip(ucrChkMeanAbsoluteError.chkCheck, "Mean absolute error")

        ucrChkRootMeanSquaredError.SetParameter(New RParameter("rmse", 47), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rmse" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRootMeanSquaredError.SetText("rmse")
        ttVerificationSummaries.SetToolTip(ucrChkRootMeanSquaredError.chkCheck, "Root mean squared error")

        ucrChkNormRootMeanSquaredError.SetParameter(New RParameter("nrmse", 48), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "nrmse" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkNormRootMeanSquaredError.SetText("nrmse")
        ttVerificationSummaries.SetToolTip(ucrChkNormRootMeanSquaredError.chkCheck, "Normalized root mean squared error")

        ucrChkPercentBias.SetParameter(New RParameter("PBIAS", 49), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "PBIAS" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkPercentBias.SetText("PBIAS")
        ttVerificationSummaries.SetToolTip(ucrChkPercentBias.chkCheck, "Percent bias")

        ucrChkRatioOfRootMeanSquaredError.SetParameter(New RParameter("rsr", 50), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rsr" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRatioOfRootMeanSquaredError.SetText("rsr")
        ttVerificationSummaries.SetToolTip(ucrChkRatioOfRootMeanSquaredError.chkCheck, "Ratio of root mean square error")

        ucrChkRatioOfStandardDeviation.SetParameter(New RParameter("rSD", 51), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rSD" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRatioOfStandardDeviation.SetText("rSD")
        ttVerificationSummaries.SetToolTip(ucrChkRatioOfStandardDeviation.chkCheck, "Ratio of standard deviations")

        ucrChkNashSutcliffeEfficiency.SetParameter(New RParameter("NSE", 52), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "NSE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkNashSutcliffeEfficiency.SetText("NSE")
        ttVerificationSummaries.SetToolTip(ucrChkNashSutcliffeEfficiency.chkCheck, "Nash-Sutcliffe efficiency")

        ucrChkModNashSutcliffeEff.SetParameter(New RParameter("mNSE", 53), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "mNSE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkModNashSutcliffeEff.SetText("mNSE")
        ttVerificationSummaries.SetToolTip(ucrChkModNashSutcliffeEff.chkCheck, "Modified Nash-Sutcliffe effieciency")

        ucrChkRelativeNashSutcliffeEff.SetParameter(New RParameter("rNSE", 54), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rNSE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRelativeNashSutcliffeEff.SetText("rNSE")
        ttVerificationSummaries.SetToolTip(ucrChkRelativeNashSutcliffeEff.chkCheck, "Relative Nash-Sutcliffe efficiency")

        ucrChkModifiedIndexOfAgreement.SetParameter(New RParameter("md", 55), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "md" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkModifiedIndexOfAgreement.SetText("md")
        ttVerificationSummaries.SetToolTip(ucrChkModifiedIndexOfAgreement.chkCheck, "Modified index of agreement")

        ucrChkIndexOfAgreement.SetParameter(New RParameter("d", 56), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "d" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkIndexOfAgreement.SetText("d")
        ttVerificationSummaries.SetToolTip(ucrChkIndexOfAgreement.chkCheck, "Index of agreement")

        ucrChkRelativeIndexOfAgreement.SetParameter(New RParameter("rd", 57), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rd" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRelativeIndexOfAgreement.SetText("rd")
        ttVerificationSummaries.SetToolTip(ucrChkRelativeIndexOfAgreement.chkCheck, "Relative index of agreement")

        ucrChkCoefPersistence.SetParameter(New RParameter("cp", 58), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "cp" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCoefPersistence.SetText("cp")
        ttVerificationSummaries.SetToolTip(ucrChkCoefPersistence.chkCheck, "Coefficient of persistence")

        ucrChkCoefDetermination.SetParameter(New RParameter("R2", 59), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "R2" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCoefDetermination.SetText("R^2")
        ttVerificationSummaries.SetToolTip(ucrChkCoefDetermination.chkCheck, "Coefficient of determination")

        ucrChkKlingGuptaEfficiency.SetParameter(New RParameter("KGE", 60), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "KGE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkKlingGuptaEfficiency.SetText("KGE")
        ttVerificationSummaries.SetToolTip(ucrChkKlingGuptaEfficiency.chkCheck, "Kling-Gupta efficiency")

        ucrChkVolumetricEfficiency.SetParameter(New RParameter("VE", 61), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "VE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkVolumetricEfficiency.SetText("VE")
        ttVerificationSummaries.SetToolTip(ucrChkVolumetricEfficiency.chkCheck, "Volumetric efficiency")

        ucrChkMeanSquaredError.SetParameter(New RParameter("mse", 62), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "mse" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMeanSquaredError.SetText("mse")
        ttVerificationSummaries.SetToolTip(ucrChkMeanSquaredError.chkCheck, "Mean squared error")

        ucrChkSumOfSquaredResiduals.SetParameter(New RParameter("ssq", 63), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "ssq" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSumOfSquaredResiduals.SetText("ssq")
        ttVerificationSummaries.SetToolTip(ucrChkSumOfSquaredResiduals.chkCheck, "Sum of squared residuals")

        ttVerificationSummaries.SetToolTip(ucrInputJmia.txtInput, "numeric value, with the exponent to be used in the computation of the modified index of agreement. The default value is j=1")

        ucrInputJmia.SetParameter(New RParameter("j", 10))
        ucrInputJmia.SetValidationTypeAsNumeric()
        ucrInputJmia.AddQuotesIfUnrecognised = False
        ucrInputJmia.SetRDefault(1)

        ucrChkSelectAll.SetText("Select all")

        ucrChkSample.SetParameter(New RParameter("summary_sample", 64), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_sample" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSample.SetText("Sample")

        ucrChkSetseed.SetText("Set seed")
        ucrChkSetseed.AddParameterPresentCondition(True, "seed")
        ucrChkSetseed.AddParameterPresentCondition(False, "seed", False)

        ucrNudSeed.SetParameter(New RParameter("seed", 11))

        lstVerifCheckboxes.AddRange({ucrChkCorrelations, ucrChkCoefDetermination, ucrChkCoefPersistence, ucrChkIndexOfAgreement, ucrChkKlingGuptaEfficiency, ucrChkMeanAbsoluteError, ucrChkModifiedIndexOfAgreement, ucrChkMeanError, ucrChkModNashSutcliffeEff, ucrChkMeanSquaredError, ucrChkNormRootMeanSquaredError, ucrChkNashSutcliffeEfficiency, ucrChkPercentBias, ucrChkRelativeIndexOfAgreement, ucrChkRootMeanSquaredError, ucrChkRelativeNashSutcliffeEff, ucrChkRatioOfStandardDeviation, ucrChkRatioOfRootMeanSquaredError, ucrChkSumOfSquaredResiduals, ucrChkVolumetricEfficiency})

        ucrChkP10.SetParameter(New RParameter("p10", 64), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "p10" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkP20.SetParameter(New RParameter("p20", 65), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "p20" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkP25.SetParameter(New RParameter("p25", 66), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "p25" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkP30.SetParameter(New RParameter("p30", 67), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "p30" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkP33.SetParameter(New RParameter("p33", 68), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "p33" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkP40.SetParameter(New RParameter("p40", 69), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "p40" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkP60.SetParameter(New RParameter("p60", 70), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "p60" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkP67.SetParameter(New RParameter("p67", 71), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "p67" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkP70.SetParameter(New RParameter("p70", 72), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "p70" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkP75.SetParameter(New RParameter("p75", 73), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "p75" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkP80.SetParameter(New RParameter("p80", 74), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "p80" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkP90.SetParameter(New RParameter("p90", 75), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "p90" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))

        lstCheckboxes.AddRange({ucrChkNTotal, ucrChkNonMissing, ucrChkNMissing, ucrChkMean, ucrChkMinimum, ucrChkMode, ucrChkMaximum, ucrChkMedian, ucrChkStdDev, ucrChkVariance, ucrChkRange, ucrChkSum, ucrChkP10, ucrChkP20, ucrChkP25, ucrChkP30, ucrChkP33, ucrChkP40, ucrChkP60, ucrChkP67, ucrChkP70, ucrChkP75, ucrChkP80, ucrChkP90, ucrChkMedianAbsoluteDeviation, ucrChkKurtosis, ucrChkCoefficientOfVariation, ucrChkSkewness, ucrChkMc, ucrChkQn, ucrChkSn, ucrChkCorrelations, ucrChkCovariance, ucrChkFirst, ucrChkLast, ucrChknth, ucrChkn_distinct, ucrChkTrimmedMean, ucrChkPercentile, ucrChkProportion, ucrChkCount, ucrChkStandardErrorOfMean, ucrChkCircMean, ucrChkCircMedian, ucrChkMin, ucrChkMedianH, ucrChkMax, ucrChkQ1, ucrChkQ3, ucrChkQuantile, ucrChkSd, ucrChkVar, ucrChkAngVar, ucrChkAngDev, ucrChkrho, ucrChkCircRange, ucrChkCoefDetermination, ucrChkCoefPersistence, ucrChkIndexOfAgreement, ucrChkKlingGuptaEfficiency, ucrChkMeanAbsoluteError, ucrChkModifiedIndexOfAgreement, ucrChkMeanError, ucrChkModNashSutcliffeEff, ucrChkMeanSquaredError, ucrChkNormRootMeanSquaredError, ucrChkNashSutcliffeEfficiency, ucrChkPercentBias, ucrChkRelativeIndexOfAgreement, ucrChkRootMeanSquaredError, ucrChkRelativeNashSutcliffeEff, ucrChkRatioOfStandardDeviation, ucrChkRatioOfRootMeanSquaredError, ucrChkSumOfSquaredResiduals, ucrChkVolumetricEfficiency, ucrChkSample})
        For Each ctrTemp As ucrCheck In lstCheckboxes
            ctrTemp.SetParameterIncludeArgumentName(False)
            ctrTemp.SetRDefault(Chr(34) & Chr(34))
        Next
        bControlsInitialised = True
        TwoVariablesControls()
        PositionOptions()
        OrderByCheckEnabled()
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, clsNewDefaultFunction As RFunction, clsNewConcFunction As RFunction, Optional ucrNewBaseSelector As ucrSelector = Nothing, Optional bReset As Boolean = False, Optional strNewWeightLabel As String = Nothing, Optional strDefaultTab As String = "")
        Dim bTabFound As Boolean = False

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsListFunction = clsNewRFunction
        clsDefaultFunction = clsNewDefaultFunction
        clsConcFunction = clsNewConcFunction

        strWeightLabel = strNewWeightLabel

        'updating labels of weighted summaries
        ucrChkSum.SetText("Sum" & strWeightLabel)
        ucrChkMean.SetText("Mean" & strWeightLabel)
        ucrChkStdDev.SetText("Sd" & strWeightLabel)
        ucrChkVariance.SetText("Var" & strWeightLabel)
        ucrChkMedian.SetText("Median" & strWeightLabel)
        ucrChkQuantile.SetText("Quantile" & strWeightLabel)
        ucrChkP10.SetText("P10" & strWeightLabel)
        ucrChkP20.SetText("P20" & strWeightLabel)
        ucrChkP25.SetText("P25" & strWeightLabel)
        ucrChkP30.SetText("P30" & strWeightLabel)
        ucrChkP33.SetText("P33" & strWeightLabel)
        ucrChkP40.SetText("P40" & strWeightLabel)
        ucrChkP60.SetText("P60" & strWeightLabel)
        ucrChkP67.SetText("P67" & strWeightLabel)
        ucrChkP70.SetText("P70" & strWeightLabel)
        ucrChkP75.SetText("P75" & strWeightLabel)
        ucrChkP80.SetText("P80" & strWeightLabel)
        ucrChkP90.SetText("P90" & strWeightLabel)
        ucrChkKurtosis.SetText("Kurtosis" & strWeightLabel)
        ucrChkSkewness.SetText("Skewness (3rd Moment)" & strWeightLabel)
        ucrChkCoefficientOfVariation.SetText("Coefficient Of Variation" & strWeightLabel)
        ucrChkMedianAbsoluteDeviation.SetText("Median Absolute Deviation (MAD)" & strWeightLabel)
        ucrChkCorrelations.SetText("Correlations" & strWeightLabel)
        ucrChkCovariance.SetText("Covariance" & strWeightLabel)

        'This is meant to force selector select the current dataframe as selected in the main dialog
        ucrBaseSelector = ucrNewBaseSelector
        If ucrBaseSelector IsNot Nothing AndAlso ucrBaseSelector.strCurrentDataFrame <> "" Then
            strDataFrame = ucrBaseSelector.strCurrentDataFrame
            ucrSelectorSecondVariable.SetDataframe(strDataFrame, False)
            ucrSelectorOrderBy.SetDataframe(strDataFrame, False)
        End If

        ucrChkPercentage.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputPropValue.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputComboPropTest.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputCountValue.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputComboCountTest.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputPercentile.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrNudFraction.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputN.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputQuantile.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrInputJmia.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrNudSeed.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrChkSetseed.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)

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
        ucrChkP10.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkP20.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkP25.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkP30.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkP33.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkP40.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkP60.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkP67.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkP70.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkP75.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkP80.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkP90.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
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
        ucrChkCircMean.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkCircMedian.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMin.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMedianH.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMax.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkQ1.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkQ3.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkQuantile.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkSd.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkVar.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkAngVar.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkAngDev.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkrho.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkCircRange.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkCoefDetermination.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkCoefPersistence.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkIndexOfAgreement.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkKlingGuptaEfficiency.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMeanAbsoluteError.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkModifiedIndexOfAgreement.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMeanError.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkModNashSutcliffeEff.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMeanSquaredError.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkNormRootMeanSquaredError.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkNashSutcliffeEfficiency.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkPercentBias.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkRelativeIndexOfAgreement.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkRootMeanSquaredError.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkRelativeNashSutcliffeEff.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkRatioOfStandardDeviation.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkRatioOfRootMeanSquaredError.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkSumOfSquaredResiduals.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkVolumetricEfficiency.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkSample.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)

        If bReset Then
            ucrSelectorSecondVariable.Reset()
            ucrSelectorOrderBy.Reset()
            If strDefaultTab <> "" Then
                For i As Integer = 0 To tbSummaries.TabPages.Count - 1
                    If tbSummaries.TabPages(i).Text = strDefaultTab Then
                        tbSummaries.SelectedIndex = i
                        bTabFound = True
                        Exit For
                    End If
                Next
                If Not bTabFound Then
                    MsgBox("Developer error: there is no Summary tab called" & Chr(34) & strDefaultTab & Chr(34) & vbNewLine & "Default tab will be selected.")
                    tbSummaries.SelectedIndex = 0
                End If
            Else
                tbSummaries.SelectedIndex = 0
            End If
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
        If (ucrChkCorrelations.Checked OrElse ucrChkCovariance.Checked OrElse ucrChkCoefDetermination.Checked OrElse ucrChkCoefPersistence.Checked OrElse ucrChkIndexOfAgreement.Checked OrElse ucrChkKlingGuptaEfficiency.Checked OrElse ucrChkMeanAbsoluteError.Checked OrElse ucrChkModifiedIndexOfAgreement.Checked OrElse ucrChkMeanError.Checked OrElse ucrChkModNashSutcliffeEff.Checked OrElse ucrChkMeanSquaredError.Checked OrElse ucrChkNormRootMeanSquaredError.Checked OrElse ucrChkNashSutcliffeEfficiency.Checked OrElse ucrChkPercentBias.Checked OrElse ucrChkRelativeIndexOfAgreement.Checked OrElse ucrChkRootMeanSquaredError.Checked OrElse ucrChkRelativeNashSutcliffeEff.Checked OrElse ucrChkRatioOfStandardDeviation.Checked OrElse ucrChkRatioOfRootMeanSquaredError.Checked OrElse ucrChkSumOfSquaredResiduals.Checked OrElse ucrChkVolumetricEfficiency.Checked) AndAlso ucrReceiverSecondVariable.IsEmpty Then
            MsgBox("Second Variable receiver in Two-Variables tab is empty. Ok will Not be enabled on the main dialog.", Title:="Second Variable Receiver", Buttons:=MsgBoxStyle.Information)
            bOkEnabled = False
        Else
            bOkEnabled = True
        End If
    End Sub

    Private Sub TwoVariablesControls()
        If ucrChkCorrelations.Checked OrElse ucrChkCovariance.Checked OrElse ucrChkCoefDetermination.Checked OrElse ucrChkCoefPersistence.Checked OrElse ucrChkIndexOfAgreement.Checked OrElse ucrChkKlingGuptaEfficiency.Checked OrElse ucrChkMeanAbsoluteError.Checked OrElse ucrChkModifiedIndexOfAgreement.Checked OrElse ucrChkMeanError.Checked OrElse ucrChkModNashSutcliffeEff.Checked OrElse ucrChkMeanSquaredError.Checked OrElse ucrChkNormRootMeanSquaredError.Checked OrElse ucrChkNashSutcliffeEfficiency.Checked OrElse ucrChkPercentBias.Checked OrElse ucrChkRelativeIndexOfAgreement.Checked OrElse ucrChkRootMeanSquaredError.Checked OrElse ucrChkRelativeNashSutcliffeEff.Checked OrElse ucrChkRatioOfStandardDeviation.Checked OrElse ucrChkRatioOfRootMeanSquaredError.Checked OrElse ucrChkSumOfSquaredResiduals.Checked OrElse ucrChkVolumetricEfficiency.Checked Then
            ucrSelectorSecondVariable.Visible = True
            ucrReceiverSecondVariable.Visible = True
            lblSecondVariable.Visible = True
        Else
            ucrSelectorSecondVariable.Visible = False
            ucrReceiverSecondVariable.Visible = False
            lblSecondVariable.Visible = False
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

    Private Sub ucrChkCorrelations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCorrelations.ControlValueChanged, ucrChkCovariance.ControlValueChanged, ucrReceiverSecondVariable.ControlValueChanged, ucrChkCoefDetermination.ControlValueChanged, ucrChkCoefPersistence.ControlValueChanged, ucrChkIndexOfAgreement.ControlContentsChanged, ucrChkKlingGuptaEfficiency.ControlContentsChanged, ucrChkMeanAbsoluteError.ControlContentsChanged, ucrChkModifiedIndexOfAgreement.ControlContentsChanged, ucrChkMeanError.ControlContentsChanged, ucrChkModNashSutcliffeEff.ControlContentsChanged, ucrChkMeanSquaredError.ControlContentsChanged, ucrChkNormRootMeanSquaredError.ControlContentsChanged, ucrChkNashSutcliffeEfficiency.ControlContentsChanged, ucrChkPercentBias.ControlContentsChanged, ucrChkRelativeIndexOfAgreement.ControlContentsChanged, ucrChkRootMeanSquaredError.ControlContentsChanged, ucrChkRelativeNashSutcliffeEff.ControlContentsChanged, ucrChkRatioOfStandardDeviation.ControlContentsChanged, ucrChkRatioOfRootMeanSquaredError.ControlContentsChanged, ucrChkSumOfSquaredResiduals.ControlContentsChanged, ucrChkVolumetricEfficiency.ControlContentsChanged
        TwoVariablesControls()
        If ucrChkCorrelations.Checked OrElse ucrChkCovariance.Checked OrElse ucrChkCoefDetermination.Checked OrElse ucrChkCoefPersistence.Checked OrElse ucrChkIndexOfAgreement.Checked OrElse ucrChkKlingGuptaEfficiency.Checked OrElse ucrChkMeanAbsoluteError.Checked OrElse ucrChkModifiedIndexOfAgreement.Checked OrElse ucrChkMeanError.Checked OrElse ucrChkModNashSutcliffeEff.Checked OrElse ucrChkMeanSquaredError.Checked OrElse ucrChkNormRootMeanSquaredError.Checked OrElse ucrChkNashSutcliffeEfficiency.Checked OrElse ucrChkPercentBias.Checked OrElse ucrChkRelativeIndexOfAgreement.Checked OrElse ucrChkRootMeanSquaredError.Checked OrElse ucrChkRelativeNashSutcliffeEff.Checked OrElse ucrChkRatioOfStandardDeviation.Checked OrElse ucrChkRatioOfRootMeanSquaredError.Checked OrElse ucrChkSumOfSquaredResiduals.Checked OrElse ucrChkVolumetricEfficiency.Checked Then
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

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Dim clsHelp As New RFunction
        Dim strPackageName As String

        strPackageName = "hydroGOF"
        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("package", Chr(34) & strPackageName & Chr(34))
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:="Opening help page for" & " " & strPackageName & " " & "Package. Generated from dialog Modelling", iCallType:=2, bSeparateThread:=False, bUpdateGrids:=False)
    End Sub

    Private Sub ucrChkOrderBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOrderBy.ControlValueChanged
        PositionOptions()
        OrderByCheckEnabled()
    End Sub

    Private Sub ucrChkSelectAll_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectAll.ControlValueChanged
        If ucrChkSelectAll.Checked Then
            For Each ctrTemp As ucrCheck In lstVerifCheckboxes
                ctrTemp.Checked = True
            Next
            ucrChkSelectAll.SetText("Unselect all")
        Else
            For Each ctrTemp As ucrCheck In lstVerifCheckboxes
                ctrTemp.Checked = False
            Next
            ucrChkSelectAll.SetText("Select all")
        End If
    End Sub
End Class