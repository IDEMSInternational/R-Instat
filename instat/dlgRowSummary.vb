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
Public Class dlgRowSummary
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDummyFunction As New RFunction
    Private clsGetColumnsFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private clsRowWisePipeOperator As New ROperator
    Private clsRowWiseFunction, clsMutateFunction As New RFunction
    Private clsMeanFunction, clsSumFunction, clsStandardDeviationFunction, clsMinimumFunction, clsMaximumFunction,
    clsMedianFunction, clsCountFunction, clsNumberMissingFunction, clsIsNaFunction, clsIsNotNaFunction, clsAnyDuplicatedFunction,
    clsAnyNaFuction, clsCvFunction, clsGmeanFunction, clsHmeanFunction, clsIQRFunction, clsKurtosisFunction, clsMadFunction, clsMcFunction,
    clsTrimmedMeanFunction, clsMfvFunction, clsMfv1Function, clsQuantileFunction, clsSkewnessFunction, clsRowRanksFunction, clsRowRangesFunction,
    clsRowQuantilesFunction, clsAsMatrixFunction As New RFunction
    Private clsBaseFunction, clsListFunction As New RFunction

    Private Sub dlgRowSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 45

        Dim dctTiesValues As New Dictionary(Of String, String)
        Dim dctProbabilityValues As New Dictionary(Of String, String)
        Dim dctRangeValues As New Dictionary(Of String, String)
        Dim dctTypeValues As New Dictionary(Of String, String)

        ucrReceiverForRowSummaries.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrReceiverForRowSummaries.Selector = ucrSelectorForRowSummaries
        ucrReceiverForRowSummaries.SetMeAsReceiver()
        ucrReceiverForRowSummaries.strSelectorHeading = "Numerics"
        ucrReceiverForRowSummaries.SetIncludedDataTypes({"numeric"})
        ucrReceiverForRowSummaries.bUseFilteredData = False
        ucrReceiverForRowSummaries.bForceAsDataFrame = False
        ucrReceiverForRowSummaries.SetParameterIsString()
        ucrReceiverForRowSummaries.bWithQuotes = False

        ucrReceiverForMultipleRowSummaries.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrReceiverForMultipleRowSummaries.Selector = ucrSelectorForRowSummaries
        ucrReceiverForMultipleRowSummaries.SetMeAsReceiver()
        ucrReceiverForMultipleRowSummaries.bUseFilteredData = False
        ucrReceiverForMultipleRowSummaries.bForceAsDataFrame = True
        ucrReceiverForMultipleRowSummaries.SetParameterIsRFunction()
        ucrReceiverForMultipleRowSummaries.SetIncludedDataTypes({"numeric"})
        ucrReceiverForMultipleRowSummaries.strSelectorHeading = "Numerics"

        ucrChkRowRanks.SetText("Ties")
        ucrChkRowRanks.SetLinkedDisplayControl(ucrInputRowRanks)
        ucrChkRowRanks.AddParameterPresentCondition(True, "ties.method", True)
        ucrChkRowRanks.AddParameterPresentCondition(False, "ties.method", False)

        ucrInputRowRanks.SetParameter(New RParameter("ties.method", 2))
        dctTiesValues.Add("average", "average")
        dctTiesValues.Add("first", "first")
        dctTiesValues.Add("last", "last")
        dctTiesValues.Add("max", "max")
        dctTiesValues.Add("min", "min")
        ucrInputRowRanks.SetItems(dctTiesValues)
        ucrInputRowRanks.SetDefaultState("average")
        ucrInputRowRanks.AddQuotesIfUnrecognised = False
        ucrInputRowRanks.bAllowNonConditionValues = True

        'function ran here is probs = c(VALUES)
        ucrInputProbability.SetParameter(New RParameter("p", 1, bNewIncludeArgumentName:=False))
        ucrInputProbability.AddQuotesIfUnrecognised = False
        ucrInputProbability.SetValidationTypeAsNumericList()

        ucrInputRowRange.SetParameter(New RParameter("z", 2))
        dctRangeValues.Add("min", "min")
        dctRangeValues.Add("max", "max")
        ucrInputRowRange.SetItems(dctRangeValues)
        ucrInputRowRange.SetDefaultState("min")
        ucrInputRowRange.AddQuotesIfUnrecognised = False
        ucrInputRowRange.bAllowNonConditionValues = True

        ucrChkType.SetText("Type")
        ucrChkType.SetLinkedDisplayControl(ucrInputRowRanks)
        ucrChkType.AddParameterPresentCondition(True, "type", True)
        ucrChkType.AddParameterPresentCondition(False, "type", False)

        ucrInputType.SetParameter(New RParameter("type", 2))
        dctTypeValues.Add("1", "1")
        dctTypeValues.Add("2", "2")
        dctTypeValues.Add("3", "3")
        dctTypeValues.Add("4", "4")
        dctTypeValues.Add("5", "5")
        dctTypeValues.Add("6", "6")
        dctTypeValues.Add("7", "7")
        dctTypeValues.Add("8", "8")
        dctTypeValues.Add("9", "9")
        ucrInputType.SetItems(dctTypeValues)
        ucrInputType.SetDefaultState("7")
        ucrInputType.AddQuotesIfUnrecognised = False
        ucrInputRowRange.bAllowNonConditionValues = True

        'ucrChkIgnoreMissingValues.AddParameterPresentCondition(True, "na.rm")
        'ucrChkIgnoreMissingValues.AddParameterPresentCondition(False, "na.rm", False)
        ucrChkIgnoreMissingValues.SetParameter(New RParameter("na.rm", 2))
        ucrChkIgnoreMissingValues.SetRDefault("TRUE")
        ucrChkIgnoreMissingValues.bAddRemoveParameter = True
        ucrChkIgnoreMissingValues.bChangeParameterValue = False
        ucrChkIgnoreMissingValues.SetText("Ignore Missing Values")

        'linking controls
        ucrPnlRowSummaries.AddRadioButton(rdoSingle)
        ucrPnlRowSummaries.AddRadioButton(rdoMultiple)

        ucrPnlRowSummaries.AddFunctionNamesCondition(rdoSingle, {"rowwise"})
        ucrPnlRowSummaries.AddFunctionNamesCondition(rdoMultiple, {"matrixStats"})

        ucrPnlStatistics.AddRadioButton(rdoMean)
        ucrPnlStatistics.AddRadioButton(rdoMinimum)
        ucrPnlStatistics.AddRadioButton(rdoSum)
        ucrPnlStatistics.AddRadioButton(rdoMedian)
        ucrPnlStatistics.AddRadioButton(rdoNumberMissing)
        ucrPnlStatistics.AddRadioButton(rdoStandardDeviation)
        ucrPnlStatistics.AddRadioButton(rdoMaximum)
        ucrPnlStatistics.AddRadioButton(rdoCount)
        ucrPnlStatistics.AddRadioButton(rdoMore)

        ucrPnlMultipleRowSummary.AddRadioButton(rdoRowRanks)
        ucrPnlMultipleRowSummary.AddRadioButton(rdoRowRange)
        ucrPnlMultipleRowSummary.AddRadioButton(rdoRowQuantile)

        ucrPnlStatistics.AddParameterPresentCondition(rdoMean, "Mean")
        ucrPnlStatistics.AddParameterPresentCondition(rdoMinimum, "Minimum")
        ucrPnlStatistics.AddParameterPresentCondition(rdoSum, "Sum")
        ucrPnlStatistics.AddParameterPresentCondition(rdoMedian, "Median")
        ucrPnlStatistics.AddParameterPresentCondition(rdoNumberMissing, "Number_missing")
        ucrPnlStatistics.AddParameterPresentCondition(rdoStandardDeviation, "Standard_deviation")
        ucrPnlStatistics.AddParameterPresentCondition(rdoMaximum, "Maximum")
        ucrPnlStatistics.AddParameterPresentCondition(rdoCount, "Count")
        ucrPnlStatistics.AddParameterPresentCondition(rdoMore, {"anyDuplicated", "anyNA", "cv", "Gmean", "Hmean", "IQR", "kurtosis", "mad", "mc", "mean",
                                     "mfv", "mfv1", "quantile", "skewness"})
        ucrPnlMultipleRowSummary.AddParameterPresentCondition(rdoRowRanks, "rowRanks")
        ucrPnlMultipleRowSummary.AddParameterPresentCondition(rdoRowQuantile, "rowQuantiles")
        ucrPnlMultipleRowSummary.AddParameterPresentCondition(rdoRowRange, "rowRange")

        ucrPnlStatistics.AddToLinkedControls(ucrChkIgnoreMissingValues, {rdoMean, rdoMinimum, rdoSum, rdoMedian, rdoStandardDeviation, rdoMaximum}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStatistics.AddToLinkedControls(ucrInputUserDefined, {rdoMore}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMultipleRowSummary.AddToLinkedControls(ucrChkRowRanks, {rdoRowRanks}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMultipleRowSummary.AddToLinkedControls({ucrInputProbability, ucrChkType}, {rdoRowQuantile}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMultipleRowSummary.AddToLinkedControls(ucrInputRowRange, {rdoRowRange}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlRowSummaries.AddToLinkedControls(ucrPnlStatistics, {rdoSingle}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlRowSummaries.AddToLinkedControls(ucrPnlMultipleRowSummary, {rdoMultiple}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlRowSummaries.AddToLinkedControls(ucrReceiverForMultipleRowSummaries, {rdoMultiple}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrPnlStatistics.SetLinkedDisplayControl(grpStatistic)
        ucrPnlMultipleRowSummary.SetLinkedDisplayControl(grpMultipleRowSummary)
        ucrReceiverForMultipleRowSummaries.SetLinkedDisplayControl(lblSelectedVariablesMultiple)

        ucrChkRowRanks.AddToLinkedControls({ucrInputRowRanks}, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeParameterValue:=False)
        ucrChkType.AddToLinkedControls({ucrInputType}, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeParameterValue:=False)

        'ucrInputUserDefined
        ucrInputUserDefined.SetParameter(New RParameter("user_defined", 1))
        ucrInputUserDefined.SetItems({"anyDuplicated", "anyNA", "cv", "Gmean", "Hmean", "IQR", "kurtosis", "mad", "mc", "mean, trim=0.2",
                                     "mfv", "mfv1", "quantile, probs=0.5", "skewness"}, bAddConditions:=True)

        ucrNewDataFrameName.SetPrefix("row_summary")
        ucrNewDataFrameName.SetSaveTypeAsDataFrame()
        ucrNewDataFrameName.SetLabelText("New Dataframe Name:")
        ucrNewDataFrameName.SetIsTextBox()

        ucrSaveNewDataFrame.SetLabelText("New column name:")
        ucrSaveNewDataFrame.SetSaveTypeAsColumn()
        ucrSaveNewDataFrame.SetIsComboBox()
        ucrSaveNewDataFrame.SetPrefix("row_summary")
        ucrSaveNewDataFrame.SetDataFrameSelector(ucrSelectorForRowSummaries.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        clsPipeOperator = New ROperator
        clsRowWisePipeOperator = New ROperator
        clsDummyFunction = New RFunction
        clsGetColumnsFunction = New RFunction
        clsRowWiseFunction = New RFunction
        clsMutateFunction = New RFunction
        clsBaseFunction = New RFunction
        clsListFunction = New RFunction
        clsMeanFunction = New RFunction
        clsSumFunction = New RFunction
        clsStandardDeviationFunction = New RFunction
        clsMinimumFunction = New RFunction
        clsMaximumFunction = New RFunction
        clsMedianFunction = New RFunction
        clsCountFunction = New RFunction
        clsIsNaFunction = New RFunction
        clsIsNotNaFunction = New RFunction
        clsNumberMissingFunction = New RFunction
        clsAnyDuplicatedFunction = New RFunction
        clsAnyNaFuction = New RFunction
        clsCvFunction = New RFunction
        clsGmeanFunction = New RFunction
        clsHmeanFunction = New RFunction
        clsIQRFunction = New RFunction
        clsKurtosisFunction = New RFunction
        clsMadFunction = New RFunction
        clsMcFunction = New RFunction
        clsTrimmedMeanFunction = New RFunction
        clsMfv1Function = New RFunction
        clsMfvFunction = New RFunction
        clsQuantileFunction = New RFunction
        clsSkewnessFunction = New RFunction
        clsRowRanksFunction = New RFunction
        clsRowRangesFunction = New RFunction
        clsRowQuantilesFunction = New RFunction
        clsAsMatrixFunction = New RFunction

        'reset
        ucrSelectorForRowSummaries.Reset()
        ucrNewDataFrameName.Reset()
        ucrInputProbability.Reset()

        clsDummyFunction.AddParameter("checked", "mean", iPosition:=0)
        clsDummyFunction.AddParameter("user_defined", Chr(34) & "anyDuplicated" & Chr(34), iPosition:=1)
        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("left", clsRFunctionParameter:=ucrSelectorForRowSummaries.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsPipeOperator.AddParameter("right", clsROperatorParameter:=clsRowWisePipeOperator, iPosition:=1)

        clsRowWiseFunction.SetPackageName("dplyr")
        clsRowWiseFunction.SetRCommand("rowwise")

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")
        clsMutateFunction.AddParameter("Mean", clsRFunctionParameter:=clsMeanFunction, iPosition:=0)

        clsRowWisePipeOperator.SetOperation("%>%")
        clsRowWisePipeOperator.AddParameter("left", clsRFunctionParameter:=clsRowWiseFunction, iPosition:=0)
        clsRowWisePipeOperator.AddParameter("right", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)

        clsMeanFunction.SetRCommand("mean")
        clsSumFunction.SetRCommand("sum")
        clsStandardDeviationFunction.SetRCommand("sd")
        clsMinimumFunction.SetRCommand("min")
        clsMaximumFunction.SetRCommand("max")
        clsMedianFunction.SetRCommand("median")
        clsAnyDuplicatedFunction.SetRCommand("anyDuplicated")
        clsAnyNaFuction.SetRCommand("anyNA")
        clsCvFunction.SetPackageName("raster")
        clsCvFunction.SetRCommand("cv")
        clsGmeanFunction.SetPackageName("DescTools")
        clsGmeanFunction.SetRCommand("Gmean")
        clsHmeanFunction.SetPackageName("DescTools")
        clsHmeanFunction.SetRCommand("Hmean")
        clsIQRFunction.SetRCommand("IQR")
        clsKurtosisFunction.SetPackageName("e1071")
        clsKurtosisFunction.SetRCommand("kurtosis")
        clsMadFunction.SetRCommand("mad")
        clsMcFunction.SetPackageName("robustbase")
        clsMcFunction.SetRCommand("mc")
        clsTrimmedMeanFunction.SetRCommand("mean")
        clsTrimmedMeanFunction.AddParameter("trim", "0.2", iPosition:=1)
        clsMfvFunction.SetPackageName("statip")
        clsMfvFunction.SetRCommand("mfv")
        clsMfv1Function.SetPackageName("statip")
        clsMfv1Function.SetRCommand("mfv1")
        clsQuantileFunction.SetRCommand("quantile")
        clsQuantileFunction.AddParameter("probs", "0.5", iPosition:=1)
        clsSkewnessFunction.SetPackageName("e1071")
        clsSkewnessFunction.SetRCommand("skewness")

        clsIsNaFunction.SetRCommand("is.na")
        clsIsNotNaFunction.SetRCommand("!is.na")

        clsBaseFunction.SetRCommand("data_book$import_data")
        clsBaseFunction.AddParameter("data_tables", clsRFunctionParameter:=clsListFunction)

        clsListFunction.SetRCommand("list")

        clsRowRanksFunction.SetPackageName("matixStats")
        clsRowRanksFunction.SetRCommand("rowRanks")
        clsRowRanksFunction.AddParameter("dim.", "c(18,9)", iPosition:=1)

        clsRowRangesFunction.SetPackageName("matrixStats")
        clsRowRangesFunction.SetRCommand("rowRanges")
        clsRowRangesFunction.AddParameter("dim.", "c(18,9)", iPosition:=1)

        clsRowQuantilesFunction.SetPackageName("matrixStats")
        clsRowQuantilesFunction.SetRCommand("rowQuantiles")

        clsAsMatrixFunction.SetRCommand("as.matrix")

        ucrBase.clsRsyntax.SetBaseRFunction(clsBaseFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsSumFunction, ucrReceiverForRowSummaries.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsStandardDeviationFunction, ucrReceiverForRowSummaries.GetParameter(), iAdditionalPairNo:=2)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsMinimumFunction, ucrReceiverForRowSummaries.GetParameter(), iAdditionalPairNo:=3)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsMaximumFunction, ucrReceiverForRowSummaries.GetParameter(), iAdditionalPairNo:=4)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsMedianFunction, ucrReceiverForRowSummaries.GetParameter(), iAdditionalPairNo:=5)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsIsNotNaFunction, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=6)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsIsNaFunction, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=7)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsAnyDuplicatedFunction, New RParameter("anyDuplicated", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=8)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsAnyNaFuction, New RParameter("anyNA", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=9)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsCvFunction, New RParameter("cv", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=10)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsGmeanFunction, New RParameter("Gmean", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=11)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsHmeanFunction, New RParameter("Hmean", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=12)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsIQRFunction, New RParameter("IQR", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=13)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsKurtosisFunction, New RParameter("kurtosis", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=14)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsMadFunction, New RParameter("mad", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=15)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsMcFunction, New RParameter("mc", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=16)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsTrimmedMeanFunction, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=17)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsMfvFunction, New RParameter("mfv", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=18)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsMfv1Function, New RParameter("mfv1", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=19)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsQuantileFunction, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=20)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsSkewnessFunction, New RParameter("skewness", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=21)
        ucrChkIgnoreMissingValues.AddAdditionalCodeParameterPair(clsStandardDeviationFunction, ucrChkIgnoreMissingValues.GetParameter(), iAdditionalPairNo:=1)
        ucrChkIgnoreMissingValues.AddAdditionalCodeParameterPair(clsMinimumFunction, ucrChkIgnoreMissingValues.GetParameter(), iAdditionalPairNo:=2)
        ucrChkIgnoreMissingValues.AddAdditionalCodeParameterPair(clsMaximumFunction, ucrChkIgnoreMissingValues.GetParameter(), iAdditionalPairNo:=3)
        ucrChkIgnoreMissingValues.AddAdditionalCodeParameterPair(clsMedianFunction, ucrChkIgnoreMissingValues.GetParameter(), iAdditionalPairNo:=4)
        ucrReceiverForMultipleRowSummaries.SetRCode(clsAsMatrixFunction, bReset)
        ucrChkRowRanks.SetRCode(clsRowRanksFunction, bReset)
        ucrInputRowRanks.SetRCode(clsRowRanksFunction, bReset)
        ucrChkType.SetRCode(clsRowQuantilesFunction, bReset)
        ucrInputRowRange.SetRCode(clsRowRangesFunction)
        ucrChkIgnoreMissingValues.SetRCode(clsMeanFunction, bReset)
        ucrReceiverForRowSummaries.SetRCode(clsMeanFunction, bReset)
        ucrPnlStatistics.SetRCode(clsMutateFunction, bReset)
        ucrPnlRowSummaries.SetRCode(clsRowWiseFunction, bReset)
        ucrInputUserDefined.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoSingle.Checked Then
            If Not ucrReceiverForRowSummaries.IsEmpty AndAlso ucrNewDataFrameName.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If rdoMultiple.Checked Then
                If Not ucrReceiverForMultipleRowSummaries.IsEmpty AndAlso ucrSaveNewDataFrame.IsComplete Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    'Private Sub ucrChkIgnoreMissingValues_controlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIgnoreMissingValues.ControlValueChanged
    '    If ucrChkIgnoreMissingValues.Checked Then
    '        clsMeanFunction.AddParameter("na.rm", "TRUE", iPosition:=2)
    '        clsSumFunction.AddParameter("na.rm", "TRUE", iPosition:=2)
    '        clsMinimumFunction.AddParameter("na.rm", "TRUE", iPosition:=2)
    '        clsMaximumFunction.AddParameter("na.rm", "TRUE", iPosition:=2)
    '        clsMedianFunction.AddParameter("na.rm", "TRUE", iPosition:=2)
    '        clsStandardDeviationFunction.AddParameter("na.rm", "TRUE", iPosition:=2)
    '    Else
    '        clsMeanFunction.RemoveParameterByName("na.rm")
    '        clsSumFunction.RemoveParameterByName("na.rm")
    '        clsMinimumFunction.RemoveParameterByName("na.rm")
    '        clsMaximumFunction.RemoveParameterByName("na.rm")
    '        clsMedianFunction.RemoveParameterByName("na.rm")
    '        clsStandardDeviationFunction.RemoveParameterByName("na.rm")
    '    End If
    'End Sub

    Private Sub ucrPnlRowSummaries_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlRowSummaries.ControlValueChanged, ucrPnlStatistics.ControlValueChanged, ucrInputUserDefined.ControlValueChanged
        If rdoSingle.Checked Then
            clsMutateFunction.RemoveParameterByName("Mean")
            clsMutateFunction.RemoveParameterByName("Sum")
            clsMutateFunction.RemoveParameterByName("Standard_deviation")
            clsMutateFunction.RemoveParameterByName("Minimum")
            clsMutateFunction.RemoveParameterByName("Maximum")
            clsMutateFunction.RemoveParameterByName("Median")
            clsMutateFunction.RemoveParameterByName("Count")
            clsMutateFunction.RemoveParameterByName("Number_missing")
            clsMutateFunction.RemoveParameterByName("anyDuplicated")
            clsMutateFunction.RemoveParameterByName("anyNA")
            clsMutateFunction.RemoveParameterByName("cv")
            clsMutateFunction.RemoveParameterByName("Gmean")
            clsMutateFunction.RemoveParameterByName("Hmean")
            clsMutateFunction.RemoveParameterByName("IQR")
            clsMutateFunction.RemoveParameterByName("kurtosis")
            clsMutateFunction.RemoveParameterByName("mad")
            clsMutateFunction.RemoveParameterByName("mc")
            clsMutateFunction.RemoveParameterByName("mean")
            clsMutateFunction.RemoveParameterByName("mfv")
            clsMutateFunction.RemoveParameterByName("mfv1")
            clsMutateFunction.RemoveParameterByName("quantile")
            clsMutateFunction.RemoveParameterByName("skewness")
            clsSumFunction.RemoveParameterByName("x")
            clsListFunction.ClearParameters()
            If rdoMean.Checked Then
                clsMutateFunction.AddParameter("Mean", clsRFunctionParameter:=clsMeanFunction, iPosition:=0)
            ElseIf rdoSum.Checked Then
                clsSumFunction.AddParameter("x", ucrReceiverForRowSummaries.GetVariableNames("False"), bIncludeArgumentName:=False, iPosition:=0)
                clsMutateFunction.AddParameter("Sum", clsRFunctionParameter:=clsSumFunction, iPosition:=0)
            ElseIf rdoStandardDeviation.Checked Then
                clsMutateFunction.AddParameter("Standard_deviation", clsRFunctionParameter:=clsStandardDeviationFunction, iPosition:=0)
            ElseIf rdoMinimum.Checked Then
                clsMutateFunction.AddParameter("Minimum", clsRFunctionParameter:=clsMinimumFunction, iPosition:=0)
            ElseIf rdoMaximum.Checked Then
                clsMutateFunction.AddParameter("Maximum", clsRFunctionParameter:=clsMaximumFunction, iPosition:=0)
            ElseIf rdoMedian.Checked Then
                clsMutateFunction.AddParameter("Median", clsRFunctionParameter:=clsMedianFunction, iPosition:=0)
            ElseIf rdoCount.Checked Then
                clsSumFunction.AddParameter("x", clsRFunctionParameter:=clsIsNotNaFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsMutateFunction.AddParameter("Count", clsRFunctionParameter:=clsSumFunction, iPosition:=0)
            ElseIf rdoNumberMissing.Checked Then
                clsSumFunction.AddParameter("x", clsRFunctionParameter:=clsIsNaFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsMutateFunction.AddParameter("Number_missing", clsRFunctionParameter:=clsSumFunction, iPosition:=0)
            ElseIf rdoMore.Checked Then
                Select Case ucrInputUserDefined.GetText()
                    Case "anyDuplicated"
                        clsMutateFunction.AddParameter("anyDuplicated", clsRFunctionParameter:=clsAnyDuplicatedFunction, iPosition:=0)
                    Case "anyNA"
                        clsMutateFunction.AddParameter("anyNA", clsRFunctionParameter:=clsAnyNaFuction, iPosition:=0)
                    Case "cv"
                        clsMutateFunction.AddParameter("cv", clsRFunctionParameter:=clsCvFunction, iPosition:=0)
                    Case "Gmean"
                        clsMutateFunction.AddParameter("Gmean", clsRFunctionParameter:=clsGmeanFunction, iPosition:=0)
                    Case "Hmean"
                        clsMutateFunction.AddParameter("Hmean", clsRFunctionParameter:=clsHmeanFunction, iPosition:=0)
                    Case "IQR"
                        clsMutateFunction.AddParameter("IQR", clsRFunctionParameter:=clsIQRFunction, iPosition:=0)
                    Case "kurtosis"
                        clsMutateFunction.AddParameter("kurtosis", clsRFunctionParameter:=clsKurtosisFunction, iPosition:=0)
                    Case "mad"
                        clsMutateFunction.AddParameter("mad", clsRFunctionParameter:=clsMadFunction, iPosition:=0)
                    Case "mc"
                        clsMutateFunction.AddParameter("mc", clsRFunctionParameter:=clsMcFunction, iPosition:=0)
                    Case "mean, trim=0.2"
                        clsMutateFunction.AddParameter("mean", clsRFunctionParameter:=clsTrimmedMeanFunction, bIncludeArgumentName:=False, iPosition:=0)
                    Case "mfv"
                        clsMutateFunction.AddParameter("mfv", clsRFunctionParameter:=clsMfvFunction, iPosition:=0)
                    Case "mfv1"
                        clsMutateFunction.AddParameter("mfv1", clsRFunctionParameter:=clsMfv1Function, iPosition:=0)
                    Case "quantile, probs=0.5"
                        clsMutateFunction.AddParameter("quantile", clsRFunctionParameter:=clsQuantileFunction, bIncludeArgumentName:=False, iPosition:=0)
                    Case "skewness"
                        clsMutateFunction.AddParameter("skewness", clsRFunctionParameter:=clsSkewnessFunction, iPosition:=0)
                End Select
            End If
            clsPipeOperator.SetAssignTo(ucrNewDataFrameName.GetText)
            clsListFunction.AddParameter(ucrNewDataFrameName.GetText, clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        End If
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If rdoSingle.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsBaseFunction)
        ElseIf rdoMultiple.Checked Then

        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForRowSummaries.ControlContentsChanged, ucrPnlStatistics.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class