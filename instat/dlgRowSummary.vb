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
    clsTrimmedMeanFunction, clsMfvFunction, clsMfv1Function, clsQuantileFunction, clsSkewnessFunction As New RFunction
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

        ucrReceiverForRowSummaries.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrReceiverForRowSummaries.Selector = ucrSelectorForRowSummaries
        ucrReceiverForRowSummaries.SetMeAsReceiver()
        ucrReceiverForRowSummaries.strSelectorHeading = "Numerics"
        ucrReceiverForRowSummaries.SetIncludedDataTypes({"numeric"})
        ucrReceiverForRowSummaries.bUseFilteredData = False
        ucrReceiverForRowSummaries.bForceAsDataFrame = False
        ucrReceiverForRowSummaries.SetParameterIsString()
        ucrReceiverForRowSummaries.bWithQuotes = False

        ucrChkIgnoreMissingValues.AddParameterPresentCondition(True, "na.rm")
        ucrChkIgnoreMissingValues.AddParameterPresentCondition(False, "na.rm", False)
        ucrChkIgnoreMissingValues.SetText("Ignore Missing Values")

        'linking controls
        ucrPnlRowSummaries.AddRadioButton(rdoSingle)
        ucrPnlRowSummaries.AddRadioButton(rdoMultiple)

        ucrPnlRowSummaries.AddFunctionNamesCondition(rdoSingle, {"rowwise"})

        ucrPnlStatistics.AddRadioButton(rdoMean)
        ucrPnlStatistics.AddRadioButton(rdoMinimum)
        ucrPnlStatistics.AddRadioButton(rdoSum)
        ucrPnlStatistics.AddRadioButton(rdoMedian)
        ucrPnlStatistics.AddRadioButton(rdoNumberMissing)
        ucrPnlStatistics.AddRadioButton(rdoStandardDeviation)
        ucrPnlStatistics.AddRadioButton(rdoMaximum)
        ucrPnlStatistics.AddRadioButton(rdoCount)
        ucrPnlStatistics.AddRadioButton(rdoMore)

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

        ucrPnlStatistics.AddToLinkedControls(ucrChkIgnoreMissingValues, {rdoMean, rdoMinimum, rdoSum, rdoMedian, rdoStandardDeviation, rdoMaximum}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStatistics.AddToLinkedControls(ucrInputUserDefined, {rdoMore}, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputUserDefined
        ucrInputUserDefined.SetParameter(New RParameter("user_defined", 1))
        ucrInputUserDefined.SetItems({"anyDuplicated", "anyNA", "cv", "Gmean", "Hmean", "IQR", "kurtosis", "mad", "mc", "mean, trim=0.2",
                                     "mfv", "mfv1", "quantile, probs=0.5", "skewness"}, bAddConditions:=True)
        'ucrInputUserDefined.AddQuotesIfUnrecognised = False
        'ucrInputUserDefined.bAllowNonConditionValues = True

        ucrNewDataFrameName.SetPrefix("row_summary")
        ucrNewDataFrameName.SetSaveTypeAsDataFrame()
        'ucrNewDataFrameName.SetDataFrameSelector(ucrSelectorForRowSummaries.ucrAvailableDataFrames)
        ucrNewDataFrameName.SetLabelText("New Dataframe Name:")
        ucrNewDataFrameName.SetIsTextBox()
        'ucrNewDataFrameName.setLinkedReceiver(ucrReceiverForRowSummaries)
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

        'reset
        ucrSelectorForRowSummaries.Reset()
        ucrNewDataFrameName.Reset()

        clsDummyFunction.AddParameter("checked", "mean", iPosition:=0)
        clsDummyFunction.AddParameter("user_defined", "anyDuplicated", iPosition:=1)
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

        'clsCountFunction.SetRCommand("sum(!is.na(z))")
        'clsNumberMissingFunction.SetRCommand("sum(is.na(z))")

        clsIsNaFunction.SetRCommand("is.na")
        clsIsNotNaFunction.SetRCommand("!is.na")

        clsBaseFunction.SetRCommand("data_book$import_data")
        clsBaseFunction.AddParameter("data_tables", clsRFunctionParameter:=clsListFunction)

        clsListFunction.SetRCommand("list")

        'Defining the default RFunction
        'clsApplyFunction.SetPackageName("base")
        'clsApplyFunction.SetRCommand("apply")
        'clsApplyFunction.AddParameter("FUN", "mean", iPosition:=2)
        'clsApplyFunction.AddParameter("MARGIN", 1)
        'clsPipeOperator.SetAssignTo(ucrNewDataFrameName.GetText, strTempDataframe:=ucrSelectorForRowSummaries.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        'clsPipeOperator.SetAssignTo("row_summary")
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
        'ucrChkIgnoreMissingValues.SetRCode(clsApplyFunction, bReset)
        ucrReceiverForRowSummaries.SetRCode(clsMeanFunction, bReset)
        ucrPnlStatistics.SetRCode(clsMutateFunction, bReset)
        ucrPnlRowSummaries.SetRCode(clsRowWiseFunction, bReset)
        'ucrNewDataFrameName.SetRCode(clsPipeOperator, bReset)
        ucrInputUserDefined.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForRowSummaries.IsEmpty AndAlso ucrNewDataFrameName.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForRowSummaries.ControlContentsChanged, ucrPnlStatistics.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class