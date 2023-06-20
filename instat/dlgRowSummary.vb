'
'R- Instat
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
    Private clsDummyRowFunction As New RFunction
    Private clsGetColumnsFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private clsRowWisePipeOperator As New ROperator
    Private clsAddColumnsFunction As New RFunction
    Private clsAssignOperator As New ROperator
    Private clsRowWiseFunction, clsMutateFunction As New RFunction
    Private clsMeanFunction, clsSumFunction, clsStandardDeviationFunction, clsMinimumFunction, clsMaximumFunction,
    clsMedianFunction, clsIsNaFunction, clsIsNotNaFunction, clsAnyDuplicatedFunction, clsTrimmedMeanFunction,
    clsAnyNaFuction, clsCvFunction, clsGmeanFunction, clsHmeanFunction, clsIQRFunction, clsKurtosisFunction, clsMadFunction, clsMcFunction,
    clsMfv1Function, clsQuantileFunction, clsSkewnessFunction, clsRowRanksFunction, clsRowRangesFunction, clsSelectFunction,
    clsRowQuantilesFunction, clsAsMatrixFunction, clsDimensionFunction, clsConcatenateFunction, clsColumnNamesFunction As New RFunction
    Private clsListFunction As New RFunction

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
        ucrReceiverForRowSummaries.bUseFilteredData = True
        ucrReceiverForRowSummaries.bForceAsDataFrame = False
        ucrReceiverForRowSummaries.SetParameterIsString()
        ucrReceiverForRowSummaries.bWithQuotes = False

        ucrChkTiesMethod.AddParameterPresentCondition(True, "ties.method", True)
        ucrChkTiesMethod.AddParameterPresentCondition(False, "ties.method", False)
        ucrChkTiesMethod.SetText("Ties method")

        ucrInputTiesMethod.SetParameter(New RParameter("ties.method", 2))
        dctTiesValues.Add("average", Chr(34) & "average" & Chr(34))
        dctTiesValues.Add("first", Chr(34) & "first" & Chr(34))
        dctTiesValues.Add("last", Chr(34) & "last" & Chr(34))
        dctTiesValues.Add("max", Chr(34) & "max" & Chr(34))
        dctTiesValues.Add("min", Chr(34) & "min" & Chr(34))
        ucrInputTiesMethod.SetItems(dctTiesValues)
        ucrInputTiesMethod.bAllowNonConditionValues = True
        ucrInputTiesMethod.SetDropDownStyleAsNonEditable()

        'function ran here is probs = c(VALUES)
        ucrInputProbability.SetParameter(New RParameter("p", 1, bNewIncludeArgumentName:=False))
        ucrInputProbability.AddQuotesIfUnrecognised = False
        ucrInputProbability.SetValidationTypeAsNumericList()

        ucrChkType.SetText("Type")
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
        ucrInputType.AddQuotesIfUnrecognised = False
        ucrInputType.SetDropDownStyleAsNonEditable()

        ucrChkIgnoreMissingValues.SetParameter(New RParameter("na.rm", 2))
        ucrChkIgnoreMissingValues.SetRDefault("TRUE")
        ucrChkIgnoreMissingValues.bAddRemoveParameter = True
        ucrChkIgnoreMissingValues.bChangeParameterValue = False
        ucrChkIgnoreMissingValues.SetText("Ignore Missing Values")

        'linking controls
        ucrPnlRowSummaries.AddRadioButton(rdoSingle)
        ucrPnlRowSummaries.AddRadioButton(rdoMultiple)

        ucrPnlRowSummaries.AddFunctionNamesCondition(rdoSingle, {"rowwise"}, False)
        ucrPnlRowSummaries.AddFunctionNamesCondition(rdoMultiple, {"rowRanks", "rowRanges", "rowQuantiles"})

        ucrPnlStatistics.AddRadioButton(rdoMean)
        ucrPnlStatistics.AddRadioButton(rdoMinimum)
        ucrPnlStatistics.AddRadioButton(rdoSum)
        ucrPnlStatistics.AddRadioButton(rdoMedian)
        ucrPnlStatistics.AddRadioButton(rdoNumberMissing)
        ucrPnlStatistics.AddRadioButton(rdoStandardDeviation)
        ucrPnlStatistics.AddRadioButton(rdoMaximum)
        ucrPnlStatistics.AddRadioButton(rdoCount)
        ucrPnlStatistics.AddRadioButton(rdoMore)

        ucrPnlStatistics.AddFunctionNamesCondition(rdoMean, "Mean", False)
        ucrPnlStatistics.AddFunctionNamesCondition(rdoMinimum, "Minimum")
        ucrPnlStatistics.AddFunctionNamesCondition(rdoSum, "Sum")
        ucrPnlStatistics.AddFunctionNamesCondition(rdoMedian, "Median")
        ucrPnlStatistics.AddFunctionNamesCondition(rdoNumberMissing, "Number_missing")
        ucrPnlStatistics.AddFunctionNamesCondition(rdoStandardDeviation, "Standard_deviation")
        ucrPnlStatistics.AddFunctionNamesCondition(rdoMaximum, "Maximum")
        ucrPnlStatistics.AddFunctionNamesCondition(rdoCount, "Count")
        ucrPnlStatistics.AddFunctionNamesCondition(rdoMore, {"anyDuplicated", "anyNA", "cv", "Gmean", "Hmean", "IQR", "kurtosis",
                                                   "mad", "mc", "mean, trim=0.2", "mfv1", "quantile, probs=0.5", "skewness"})

        ucrPnlMultipleRowSummary.AddRadioButton(rdoRowRanks)
        ucrPnlMultipleRowSummary.AddRadioButton(rdoRowRange)
        ucrPnlMultipleRowSummary.AddRadioButton(rdoRowQuantile)
        ucrPnlMultipleRowSummary.AddParameterValuesCondition(rdoRowRanks, "check", "rowRanks")
        ucrPnlMultipleRowSummary.AddParameterValuesCondition(rdoRowRange, "check", "rowRange")
        ucrPnlMultipleRowSummary.AddParameterValuesCondition(rdoRowQuantile, "check", "rowQuantiles")

        ucrPnlStatistics.AddToLinkedControls(ucrChkIgnoreMissingValues, {rdoMean, rdoMinimum, rdoSum, rdoMedian, rdoStandardDeviation, rdoMaximum}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStatistics.AddToLinkedControls(ucrInputUserDefined, {rdoMore}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlMultipleRowSummary.AddToLinkedControls(ucrChkTiesMethod, {rdoRowRanks}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMultipleRowSummary.AddToLinkedControls({ucrInputProbability, ucrChkType}, {rdoRowQuantile}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlRowSummaries.AddToLinkedControls({ucrPnlStatistics, ucrSaveNewDataFrame}, {rdoSingle}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlRowSummaries.AddToLinkedControls(ucrPnlMultipleRowSummary, {rdoMultiple}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrPnlStatistics.SetLinkedDisplayControl(grpStatistic)
        ucrPnlMultipleRowSummary.SetLinkedDisplayControl(grpMultipleRowSummary)

        ucrChkTiesMethod.AddToLinkedControls({ucrInputTiesMethod}, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True,
                           bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="average")
        ucrChkType.AddToLinkedControls({ucrInputType}, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True,
                                        bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="7")
        'ucrInputUserDefined
        ucrInputUserDefined.SetItems({"anyDuplicated", "anyNA", "cv", "Gmean", "Hmean", "IQR", "kurtosis", "mad", "mc", "mean",
                                     "mfv1", "quantile", "skewness"})
        ucrInputUserDefined.AddToLinkedControls(ucrNudProp, {"quantile"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputUserDefined.AddToLinkedControls(ucrNudTrim, {"mean"}, bNewLinkedHideIfParameterMissing:=True)


        ucrNudProp.SetParameter(New RParameter("probs", 1))
        ucrNudProp.SetMinMax(0.00, 1.0)
        ucrNudProp.Increment = 0.01
        ucrNudProp.DecimalPlaces = 2
        ucrNudProp.SetLinkedDisplayControl(lblProp)

        ucrNudTrim.SetParameter(New RParameter("trim", 1))
        ucrNudTrim.Minimum = 0.0
        ucrNudTrim.Maximum = 0.5
        ucrNudTrim.DecimalPlaces = 2
        ucrNudTrim.Increment = 0.01
        ucrNudTrim.SetLinkedDisplayControl(lblTrim)

        ucrSaveNewDataFrame.SetLabelText("New Column Name:")
        ucrSaveNewDataFrame.SetSaveTypeAsColumn()
        ucrSaveNewDataFrame.SetIsComboBox()
        ucrSaveNewDataFrame.SetPrefix("row_summary")
        ucrSaveNewDataFrame.SetDataFrameSelector(ucrSelectorForRowSummaries.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        clsPipeOperator = New ROperator
        clsRowWisePipeOperator = New ROperator
        clsAssignOperator = New ROperator
        clsDummyRowFunction = New RFunction
        clsGetColumnsFunction = New RFunction
        clsRowWiseFunction = New RFunction
        clsMutateFunction = New RFunction
        clsListFunction = New RFunction
        clsMeanFunction = New RFunction
        clsSumFunction = New RFunction
        clsStandardDeviationFunction = New RFunction
        clsMinimumFunction = New RFunction
        clsMaximumFunction = New RFunction
        clsMedianFunction = New RFunction
        clsIsNaFunction = New RFunction
        clsIsNotNaFunction = New RFunction
        clsAnyDuplicatedFunction = New RFunction
        clsAnyNaFuction = New RFunction
        clsCvFunction = New RFunction
        clsGmeanFunction = New RFunction
        clsHmeanFunction = New RFunction
        clsIQRFunction = New RFunction
        clsKurtosisFunction = New RFunction
        clsMadFunction = New RFunction
        clsMcFunction = New RFunction
        clsMfv1Function = New RFunction
        clsQuantileFunction = New RFunction
        clsSkewnessFunction = New RFunction
        clsRowRanksFunction = New RFunction
        clsRowRangesFunction = New RFunction
        clsRowQuantilesFunction = New RFunction
        clsAsMatrixFunction = New RFunction
        clsDimensionFunction = New RFunction
        clsTrimmedMeanFunction = New RFunction
        clsSelectFunction = New RFunction
        clsConcatenateFunction = New RFunction
        clsColumnNamesFunction = New RFunction
        clsAddColumnsFunction = New RFunction

        'reset
        ucrSelectorForRowSummaries.Reset()
        ucrReceiverForRowSummaries.SetMeAsReceiver()
        ucrSaveNewDataFrame.Reset()
        ucrInputProbability.Reset()
        ucrInputUserDefined.SetName("anyDuplicated")

        clsDummyRowFunction.AddParameter("check", "rowRanks", iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("left", clsRFunctionParameter:=ucrSelectorForRowSummaries.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsPipeOperator.AddParameter("right", clsROperatorParameter:=clsRowWisePipeOperator, iPosition:=1)

        clsRowWiseFunction.SetPackageName("dplyr")
        clsRowWiseFunction.SetRCommand("rowwise")

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")
        clsMutateFunction.AddParameter("Mean", clsRFunctionParameter:=clsMeanFunction, iPosition:=0)

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")

        clsRowWisePipeOperator.SetOperation("%>%")
        clsRowWisePipeOperator.AddParameter("left", clsRFunctionParameter:=clsRowWiseFunction, iPosition:=0)
        clsRowWisePipeOperator.AddParameter("right", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)
        clsRowWisePipeOperator.AddParameter("select_function", clsRFunctionParameter:=clsSelectFunction, iPosition:=2)

        clsMeanFunction.SetRCommand("mean")

        clsTrimmedMeanFunction.SetRCommand("mean")
        clsTrimmedMeanFunction.AddParameter("trim", "0.2", iPosition:=1)

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
        clsGmeanFunction.SetRCommand("Gmean"
                                     )
        clsHmeanFunction.SetPackageName("DescTools")
        clsHmeanFunction.SetRCommand("Hmean")

        clsIQRFunction.SetRCommand("IQR")

        clsKurtosisFunction.SetPackageName("e1071")
        clsKurtosisFunction.SetRCommand("kurtosis")

        clsMadFunction.SetRCommand("mad")

        clsMcFunction.SetPackageName("robustbase")
        clsMcFunction.SetRCommand("mc")

        clsMfv1Function.SetPackageName("statip")
        clsMfv1Function.SetRCommand("mfv1")

        clsQuantileFunction.SetRCommand("quantile")
        clsQuantileFunction.AddParameter("probs", "0.5", iPosition:=1)

        clsSkewnessFunction.SetPackageName("e1071")
        clsSkewnessFunction.SetRCommand("skewness")

        clsIsNaFunction.SetRCommand("is.na")
        clsIsNotNaFunction.SetRCommand("!is.na")

        clsListFunction.SetRCommand("list")

        clsRowRanksFunction.SetPackageName("matrixStats")
        clsRowRanksFunction.SetRCommand("rowRanks")
        clsRowRanksFunction.AddParameter("x", clsRFunctionParameter:=clsAsMatrixFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsRowRanksFunction.AddParameter("dim.", clsRFunctionParameter:=clsDimensionFunction, iPosition:=1)
        clsRowRanksFunction.SetAssignTo("col")

        clsColumnNamesFunction.SetRCommand("colnames")

        clsConcatenateFunction.SetRCommand("c")

        clsAssignOperator.SetOperation("<-")
        clsAssignOperator.AddParameter("left", clsRFunctionParameter:=clsColumnNamesFunction, iPosition:=0)
        clsAssignOperator.AddParameter("right", clsRFunctionParameter:=clsConcatenateFunction, iPosition:=1)


        clsRowRangesFunction.SetPackageName("matrixStats")
        clsRowRangesFunction.SetRCommand("rowRanges")
        clsRowRangesFunction.AddParameter("dim.", clsRFunctionParameter:=clsDimensionFunction, iPosition:=1)
        clsRowRangesFunction.AddParameter("x", clsRFunctionParameter:=clsAsMatrixFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsRowRangesFunction.SetAssignTo("col")


        clsDimensionFunction.SetRCommand("dim")

        clsRowQuantilesFunction.SetPackageName("matrixStats")
        clsRowQuantilesFunction.SetRCommand("rowQuantiles")
        clsRowQuantilesFunction.AddParameter("x", clsRFunctionParameter:=clsAsMatrixFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsRowQuantilesFunction.SetAssignTo("col")

        clsAddColumnsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsAddColumnsFunction.AddParameter("data_name", Chr(34) & ucrSelectorForRowSummaries.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsAddColumnsFunction.AddParameter("col_data", "col", iPosition:=1)
        clsAddColumnsFunction.AddParameter("before", "FALSE", iPosition:=2)

        clsAsMatrixFunction.SetRCommand("as.matrix")

        ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
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
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsMfv1Function, New RParameter("mfv1", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=17)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsQuantileFunction, New RParameter("quantile", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=18)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsSkewnessFunction, New RParameter("skewness", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=19)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsTrimmedMeanFunction, New RParameter("mean", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=20)

        ucrChkIgnoreMissingValues.AddAdditionalCodeParameterPair(clsSumFunction, ucrChkIgnoreMissingValues.GetParameter(), iAdditionalPairNo:=1)
        ucrChkIgnoreMissingValues.AddAdditionalCodeParameterPair(clsStandardDeviationFunction, ucrChkIgnoreMissingValues.GetParameter(), iAdditionalPairNo:=2)
        ucrChkIgnoreMissingValues.AddAdditionalCodeParameterPair(clsMinimumFunction, ucrChkIgnoreMissingValues.GetParameter(), iAdditionalPairNo:=3)
        ucrChkIgnoreMissingValues.AddAdditionalCodeParameterPair(clsMaximumFunction, ucrChkIgnoreMissingValues.GetParameter(), iAdditionalPairNo:=4)
        ucrChkIgnoreMissingValues.AddAdditionalCodeParameterPair(clsMedianFunction, ucrChkIgnoreMissingValues.GetParameter(), iAdditionalPairNo:=5)
        ucrChkTiesMethod.SetRCode(clsRowRanksFunction, bReset)
        ucrChkType.SetRCode(clsRowQuantilesFunction, bReset)
        ucrChkIgnoreMissingValues.SetRCode(clsMeanFunction, bReset)
        ucrReceiverForRowSummaries.SetRCode(clsMeanFunction, bReset)
        ucrPnlMultipleRowSummary.SetRCode(clsDummyRowFunction, bReset)
        ucrNudProp.SetRCode(clsQuantileFunction, bReset)
        ucrNudTrim.SetRCode(clsTrimmedMeanFunction, bReset)
        ucrSaveNewDataFrame.SetRCode(clsPipeOperator, bReset)
        If bReset Then
            ucrPnlStatistics.SetRCode(clsMeanFunction, bReset)
        End If
    End Sub

    Private Sub TestOKEnabled()
        If rdoSingle.Checked Then
            If Not ucrReceiverForRowSummaries.IsEmpty AndAlso ucrSaveNewDataFrame.IsComplete AndAlso ucrInputUserDefined.GetText <> "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If Not ucrReceiverForRowSummaries.IsEmpty Then
                If rdoRowQuantile.Checked Then
                    If ucrInputProbability.GetText <> "" Then
                        ucrBase.OKEnabled(True)
                    Else
                        ucrBase.OKEnabled(False)
                    End If
                Else
                    ucrBase.OKEnabled(True)
                End If
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlRowSummaries_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlRowSummaries.ControlValueChanged, ucrPnlStatistics.ControlValueChanged, ucrInputUserDefined.ControlValueChanged, ucrPnlMultipleRowSummary.ControlValueChanged
        If rdoSingle.Checked Then
            ucrReceiverForRowSummaries.SetMeAsReceiver()
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
            clsMutateFunction.RemoveParameterByName("mfv1")
            clsMutateFunction.RemoveParameterByName("quantile")
            clsMutateFunction.RemoveParameterByName("skewness")
            clsSumFunction.RemoveParameterByName("x")
            clsListFunction.ClearParameters()
            If rdoMean.Checked Then
                clsMutateFunction.AddParameter("Mean", clsRFunctionParameter:=clsMeanFunction, iPosition:=0)
                clsSelectFunction.AddParameter("x", "Mean", iPosition:=0, bIncludeArgumentName:=False)
                ucrSaveNewDataFrame.SetPrefix("Mean")
            ElseIf rdoSum.Checked Then
                clsSumFunction.AddParameter("x", ucrReceiverForRowSummaries.GetVariableNames("False"), bIncludeArgumentName:=False, iPosition:=0)
                clsMutateFunction.AddParameter("Sum", clsRFunctionParameter:=clsSumFunction, iPosition:=0)
                clsSelectFunction.AddParameter("x", "Sum", iPosition:=0, bIncludeArgumentName:=False)
                ucrSaveNewDataFrame.SetPrefix("Sum")
            ElseIf rdoStandardDeviation.Checked Then
                clsMutateFunction.AddParameter("Standard_deviation", clsRFunctionParameter:=clsStandardDeviationFunction, iPosition:=0)
                clsSelectFunction.AddParameter("x", "Standard_deviation", iPosition:=0, bIncludeArgumentName:=False)
                ucrSaveNewDataFrame.SetPrefix("Standard_deviation")
            ElseIf rdoMinimum.Checked Then
                clsMutateFunction.AddParameter("Minimum", clsRFunctionParameter:=clsMinimumFunction, iPosition:=0)
                clsSelectFunction.AddParameter("x", "Minimum", iPosition:=0, bIncludeArgumentName:=False)
                ucrSaveNewDataFrame.SetPrefix("Minimum")
            ElseIf rdoMaximum.Checked Then
                clsMutateFunction.AddParameter("Maximum", clsRFunctionParameter:=clsMaximumFunction, iPosition:=0)
                clsSelectFunction.AddParameter("x", "Maximum", iPosition:=0, bIncludeArgumentName:=False)
                ucrSaveNewDataFrame.SetPrefix("Maximum")
            ElseIf rdoMedian.Checked Then
                clsMutateFunction.AddParameter("Median", clsRFunctionParameter:=clsMedianFunction, iPosition:=0)
                clsSelectFunction.AddParameter("x", "Median", iPosition:=0, bIncludeArgumentName:=False)
                ucrSaveNewDataFrame.SetPrefix("Median")
            ElseIf rdoCount.Checked Then
                clsSumFunction.AddParameter("x", clsRFunctionParameter:=clsIsNotNaFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsMutateFunction.AddParameter("Count", clsRFunctionParameter:=clsSumFunction, iPosition:=0)
                clsSelectFunction.AddParameter("x", "Count", iPosition:=0, bIncludeArgumentName:=False)
                ucrSaveNewDataFrame.SetPrefix("Count")
            ElseIf rdoNumberMissing.Checked Then
                clsSumFunction.AddParameter("x", clsRFunctionParameter:=clsIsNaFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsMutateFunction.AddParameter("Number_missing", clsRFunctionParameter:=clsSumFunction, iPosition:=0)
                clsSelectFunction.AddParameter("x", "Number_missing", iPosition:=0, bIncludeArgumentName:=False)
                ucrSaveNewDataFrame.SetPrefix("Number_missing")

            ElseIf rdoMore.Checked Then
                Select Case ucrInputUserDefined.GetText()
                    Case "anyDuplicated"
                        clsMutateFunction.AddParameter("anyDuplicated", clsRFunctionParameter:=clsAnyDuplicatedFunction, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "anyDuplicated", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("anyDuplicated")
                    Case "anyNA"
                        clsMutateFunction.AddParameter("anyNA", clsRFunctionParameter:=clsAnyNaFuction, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "anyNA", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("anyNA")
                    Case "cv"
                        clsMutateFunction.AddParameter("cv", clsRFunctionParameter:=clsCvFunction, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "cv", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("cv")
                    Case "Gmean"
                        clsMutateFunction.AddParameter("Gmean", clsRFunctionParameter:=clsGmeanFunction, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "Gmean", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("Gmean")
                    Case "Hmean"
                        clsMutateFunction.AddParameter("Hmean", clsRFunctionParameter:=clsHmeanFunction, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "Hmean", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("Hmean")
                    Case "IQR"
                        clsMutateFunction.AddParameter("IQR", clsRFunctionParameter:=clsIQRFunction, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "IQR", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("IQR")
                    Case "kurtosis"
                        clsMutateFunction.AddParameter("kurtosis", clsRFunctionParameter:=clsKurtosisFunction, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "kurtosis", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("kurtosis")
                    Case "mad"
                        clsMutateFunction.AddParameter("mad", clsRFunctionParameter:=clsMadFunction, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "mad", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("mad")
                    Case "mc"
                        clsMutateFunction.AddParameter("mc", clsRFunctionParameter:=clsMcFunction, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "mc", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("mc")
                    Case "mean"
                        clsMutateFunction.AddParameter("mean", clsRFunctionParameter:=clsTrimmedMeanFunction, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "mean", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("trimmed_mean")
                    Case "mfv1"
                        clsMutateFunction.AddParameter("mfv1", clsRFunctionParameter:=clsMfv1Function, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "mfv1", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("mfv1")
                    Case "quantile"
                        clsMutateFunction.AddParameter("quantile", clsRFunctionParameter:=clsQuantileFunction, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "quantile", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("quantile")
                    Case "skewness"
                        clsMutateFunction.AddParameter("skewness", clsRFunctionParameter:=clsSkewnessFunction, iPosition:=0)
                        clsSelectFunction.AddParameter("x", "skewness", iPosition:=0, bIncludeArgumentName:=False)
                        ucrSaveNewDataFrame.SetPrefix("skewness")
                End Select
            End If
            ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
        Else
            If rdoMultiple.Checked Then
                If rdoRowRange.Checked Then
                    clsDummyRowFunction.AddParameter("check", "rowRange", iPosition:=0)
                    clsColumnNamesFunction.AddParameter("x", clsRFunctionParameter:=clsRowRangesFunction, iPosition:=0, bIncludeArgumentName:=False)
                    ucrBase.clsRsyntax.SetBaseROperator(clsAssignOperator)
                ElseIf rdoRowQuantile.Checked Then
                    clsDummyRowFunction.AddParameter("check", "rowQuantiles", iPosition:=0)
                    clsColumnNamesFunction.AddParameter("x", clsRFunctionParameter:=clsRowQuantilesFunction, iPosition:=0, bIncludeArgumentName:=False)
                    ucrBase.clsRsyntax.SetBaseROperator(clsAssignOperator)
                Else
                    clsDummyRowFunction.AddParameter("check", "rowRanks", iPosition:=0)
                    clsColumnNamesFunction.AddParameter("x", clsRFunctionParameter:=clsRowRanksFunction, iPosition:=0, bIncludeArgumentName:=False)
                    ucrBase.clsRsyntax.SetBaseROperator(clsAssignOperator)
                End If
            End If
        End If

        If rdoMultiple.Checked AndAlso rdoRowQuantile.Checked Then
            clsDummyRowFunction.AddParameter("0", clsRFunctionParameter:=clsRowQuantilesFunction, iPosition:=0)
            ucrInputProbability.SetName("0.25,0.5,0.75")
            ucrInputProbability.SetItems({"0.25,0.5,0.75", "0, 0.2, 0.4, 0.6, 0.8, 1", "0.5, 0.8, 1"})
        End If

        If ucrChangedControl Is ucrPnlRowSummaries Then
            If rdoMultiple.Checked Then
                ucrBase.clsRsyntax.AddToAfterCodes(clsAddColumnsFunction)
            Else
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAddColumnsFunction)
            End If
        End If

        If ucrChangedControl Is ucrPnlMultipleRowSummary Then
            AddConcatenateParameters()
        End If
    End Sub

    Private Sub AddConcatenateParameters()
        clsConcatenateFunction.ClearParameters()
        If rdoRowRanks.Checked Then
            Dim iPosition As Integer = 0
            For Each strVariable In ucrReceiverForRowSummaries.GetVariableNamesAsList
                clsConcatenateFunction.AddParameter(strVariable, Chr(34) & strVariable & "_r" & Chr(34), bIncludeArgumentName:=False, iPosition:=iPosition)
                iPosition += 1
            Next
        ElseIf rdoRowRange.Checked Then
            clsConcatenateFunction.AddParameter("r_min", Chr(34) & "r_min" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
            clsConcatenateFunction.AddParameter("r_max", Chr(34) & "r_max" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
        ElseIf rdoRowQuantile.Checked Then
            Select Case ucrInputProbability.GetText
                Case "0.25,0.5,0.75"
                    clsConcatenateFunction.AddParameter("q0.25", Chr(34) & "q0.25" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
                    clsConcatenateFunction.AddParameter("q0.5", Chr(34) & "q0.5" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
                    clsConcatenateFunction.AddParameter("q0.75", Chr(34) & "q0.75" & Chr(34), bIncludeArgumentName:=False, iPosition:=2)
                Case "0, 0.2, 0.4, 0.6, 0.8, 1"
                    clsConcatenateFunction.AddParameter("q0", Chr(34) & "q0" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
                    clsConcatenateFunction.AddParameter("q0.2", Chr(34) & "q0.2" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
                    clsConcatenateFunction.AddParameter("q0.4", Chr(34) & "q0.4" & Chr(34), bIncludeArgumentName:=False, iPosition:=2)
                    clsConcatenateFunction.AddParameter("q0.6", Chr(34) & "q0.6" & Chr(34), bIncludeArgumentName:=False, iPosition:=3)
                    clsConcatenateFunction.AddParameter("q0.8", Chr(34) & "q0.8" & Chr(34), bIncludeArgumentName:=False, iPosition:=4)
                    clsConcatenateFunction.AddParameter("q1", Chr(34) & "q1" & Chr(34), bIncludeArgumentName:=False, iPosition:=5)
                Case "0.5, 0.8, 1"
                    clsConcatenateFunction.AddParameter("q0.5", Chr(34) & "q0.5" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
                    clsConcatenateFunction.AddParameter("q0.8", Chr(34) & "q0.8" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
                    clsConcatenateFunction.AddParameter("q1", Chr(34) & "q1" & Chr(34), bIncludeArgumentName:=False, iPosition:=2)
                Case Else
                    Dim iposition As Integer = 0
                    For Each clsParameter In ucrInputProbability.clsRList.clsParameters
                        clsConcatenateFunction.AddParameter("q" & clsParameter.strArgumentValue,
                                                            Chr(34) & "q" & clsParameter.strArgumentValue & Chr(34), bIncludeArgumentName:=False, iPosition:=iposition)
                        iposition = iposition + 1
                    Next
            End Select
        End If
    End Sub

    Private Sub ucrReceiverForRowSummaries_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForRowSummaries.ControlValueChanged
        Dim clsGetColumnsFunction As New RFunction
        clsGetColumnsFunction = ucrReceiverForRowSummaries.GetVariables()
        clsGetColumnsFunction.SetAssignTo("columns")
        clsAsMatrixFunction.AddParameter("columns", clsRFunctionParameter:=clsGetColumnsFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsDimensionFunction.AddParameter("columns", clsRFunctionParameter:=clsGetColumnsFunction, iPosition:=0, bIncludeArgumentName:=False)
        AddConcatenateParameters()
    End Sub

    Private Sub ucrInputProbability_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputProbability.ControlValueChanged
        clsRowQuantilesFunction.AddParameter("probs", "c(" & ucrInputProbability.GetText & ")", iPosition:=1)
        AddConcatenateParameters()
    End Sub

    Private Sub ucrSelectorForRowSummaries_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForRowSummaries.ControlValueChanged
        clsAddColumnsFunction.AddParameter("data_name", Chr(34) & ucrSelectorForRowSummaries.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForRowSummaries.ControlContentsChanged, ucrPnlStatistics.ControlContentsChanged,
        ucrSaveNewDataFrame.ControlContentsChanged, ucrInputProbability.ControlContentsChanged, ucrInputUserDefined.ControlContentsChanged, ucrPnlMultipleRowSummary.ControlContentsChanged, ucrPnlRowSummaries.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class