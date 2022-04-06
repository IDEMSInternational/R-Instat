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
    clsMedianFunction, clsCountFunction, clsNumberMissingFunction As New RFunction
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

        ucrPnlStatistics.AddToLinkedControls(ucrChkIgnoreMissingValues, {rdoMean, rdoMinimum, rdoSum, rdoMedian, rdoStandardDeviation, rdoMaximum}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStatistics.AddToLinkedControls(ucrInputUserDefined, {rdoMore}, bNewLinkedHideIfParameterMissing:=True)

        'ucrPnlStatistics.SetParameter(New RParameter("FUN", 2))
        ucrPnlStatistics.AddRadioButton(rdoMean)
        ucrPnlStatistics.AddRadioButton(rdoMinimum)
        ucrPnlStatistics.AddRadioButton(rdoSum)
        ucrPnlStatistics.AddRadioButton(rdoMedian)
        ucrPnlStatistics.AddRadioButton(rdoNumberMissing)
        ucrPnlStatistics.AddRadioButton(rdoStandardDeviation)
        ucrPnlStatistics.AddRadioButton(rdoMaximum)
        ucrPnlStatistics.AddRadioButton(rdoCount)
        ucrPnlStatistics.AddRadioButton(rdoMore)

        ucrPnlStatistics.AddParameterPresentCondition(rdoMean, "Mean", True)
        ucrPnlStatistics.AddParameterPresentCondition(rdoMinimum, "Minimum")
        ucrPnlStatistics.AddParameterPresentCondition(rdoSum, "Sum")
        ucrPnlStatistics.AddParameterPresentCondition(rdoMedian, "Median")
        ucrPnlStatistics.AddParameterPresentCondition(rdoNumberMissing, "Number Missing")
        ucrPnlStatistics.AddParameterPresentCondition(rdoStandardDeviation, "Standard Deviation")
        ucrPnlStatistics.AddParameterPresentCondition(rdoMaximum, "Maximum")
        ucrPnlStatistics.AddParameterPresentCondition(rdoCount, "Count")
        ucrPnlStatistics.AddParameterPresentCondition(rdoMore, "user_defined")

        'ucrInputUserDefined
        ucrInputUserDefined.SetParameter(New RParameter("user_defined", 1))
        ucrInputUserDefined.SetItems({"anyDuplicated", "anyNA", "cv", "Gmean", "Hmean", "IQR", "kurtosis", "mad", "mc", "mean, trim=0.2",
                                     "mfv", "mfv1", "quantile, probs=0.5", "skewness"}, bAddConditions:=True)
        ucrInputUserDefined.AddQuotesIfUnrecognised = False
        ucrInputUserDefined.bAllowNonConditionValues = True

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
        clsNumberMissingFunction = New RFunction

        'reset
        ucrSelectorForRowSummaries.Reset()
        ucrNewDataFrameName.Reset()

        clsDummyFunction.AddParameter("checked", "mean", iPosition:=0)
        clsDummyFunction.AddParameter("user_defined", "anyDuplicated", iPosition:=1)
        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("left", clsRFunctionParameter:=ucrSelectorForRowSummaries.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsPipeOperator.AddParameter("right", clsROperatorParameter:=clsRowWisePipeOperator, iPosition:=1)

        clsRowWisePipeOperator.SetOperation("%>%")
        clsRowWisePipeOperator.AddParameter("left", clsRFunctionParameter:=clsRowWiseFunction, iPosition:=0)
        clsRowWisePipeOperator.AddParameter("right", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)

        clsRowWiseFunction.SetPackageName("dplyr")
        clsRowWiseFunction.SetRCommand("rowwise")

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")
        clsMutateFunction.AddParameter("Mean", clsRFunctionParameter:=clsMeanFunction, iPosition:=0)

        clsMeanFunction.SetRCommand("mean")
        clsSumFunction.SetRCommand("sum")
        clsStandardDeviationFunction.SetRCommand("sd")
        clsMinimumFunction.SetRCommand("min")
        clsMaximumFunction.SetRCommand("max")
        clsMedianFunction.SetRCommand("median")
        clsCountFunction.SetRCommand("function(z) sum(!is.na(z))")
        clsNumberMissingFunction.SetRCommand("function(z) sum(is.na(z))")

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
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsSumFunction, New RParameter("sum", 0), iAdditionalPairNo:=1)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsStandardDeviationFunction, New RParameter("sd", 0), iAdditionalPairNo:=2)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsMinimumFunction, New RParameter("min", 0), iAdditionalPairNo:=3)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsMaximumFunction, New RParameter("max", 0), iAdditionalPairNo:=4)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsMedianFunction, New RParameter("median", 0), iAdditionalPairNo:=5)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsCountFunction, New RParameter("function(z) sum(!is.na(z))", 0), iAdditionalPairNo:=6)
        ucrReceiverForRowSummaries.AddAdditionalCodeParameterPair(clsNumberMissingFunction, New RParameter("function(z) sum(is.na(z))", 0), iAdditionalPairNo:=7)
        'ucrChkIgnoreMissingValues.SetRCode(clsApplyFunction, bReset)
        ucrPnlRowSummaries.SetRCode(clsPipeOperator, bReset)
        ucrReceiverForRowSummaries.SetRCode(clsMeanFunction, bReset)
        ucrPnlStatistics.SetRCode(clsMutateFunction, bReset)
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForRowSummaries.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlRowSummaries_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlRowSummaries.ControlValueChanged, ucrPnlRowSummaries.ControlValueChanged
        If rdoSingle.Checked Then
            If rdoMean.Checked Then
                clsMutateFunction.AddParameter("Mean", clsRFunctionParameter:=clsMeanFunction, iPosition:=0)
            ElseIf rdoSum.Checked Then
                clsMutateFunction.AddParameter("Sum", clsRFunctionParameter:=clsSumFunction, iPosition:=0)
            ElseIf rdoStandardDeviation.Checked Then
                clsMutateFunction.AddParameter("Standard Deviation", clsRFunctionParameter:=clsStandardDeviationFunction, iPosition:=0)
            ElseIf rdoMinimum.Checked Then
                clsMutateFunction.AddParameter("Minimum", clsRFunctionParameter:=clsMinimumFunction, iPosition:=0)
            ElseIf rdoMaximum.Checked Then
                clsMutateFunction.AddParameter("Maximum", clsRFunctionParameter:=clsMaximumFunction, iPosition:=0)
            ElseIf rdoMedian.Checked Then
                clsMutateFunction.AddParameter("Median", clsRFunctionParameter:=clsMedianFunction, iPosition:=0)
            ElseIf rdoCount.Checked Then
                clsMutateFunction.AddParameter("Count", clsRFunctionParameter:=clsCountFunction, iPosition:=0)
            ElseIf rdoNumberMissing.Checked Then
                clsMutateFunction.AddParameter("Number Missing", clsRFunctionParameter:=clsNumberMissingFunction, iPosition:=0)
            End If
            clsPipeOperator.SetAssignTo(ucrNewDataFrameName.GetText)
            clsListFunction.AddParameter(ucrNewDataFrameName.GetText, clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        End If
    End Sub

    'Private Sub ucrReceiverForRowSummaries_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForRowSummaries.ControlValueChanged
    '    ucrBase.clsRsyntax.lstBeforeCodes.Clear()
    '    clsGetColumnsFunction = ucrReceiverForRowSummaries.GetVariables(True).Clone
    '    clsGetColumnsFunction.SetAssignTo("columns")
    '    clsApplyFunction.AddParameter("X", clsRFunctionParameter:=clsGetColumnsFunction, iPosition:=0)
    '    ucrBase.clsRsyntax.AddToBeforeCodes(clsGetColumnsFunction)
    'End Sub

    'Private Sub ucrChkIgnoreMissingValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIgnoreMissingValues.ControlValueChanged, ucrPnlStatistics.ControlValueChanged, ucrInputUserDefined.ControlValueChanged
    '    If ucrChkIgnoreMissingValues.Checked Then
    '        If rdoMean.Checked OrElse rdoMedian.Checked OrElse rdoSum.Checked OrElse rdoStandardDeviation.Checked OrElse rdoMinimum.Checked OrElse rdoMaximum.Checked Then
    '            clsApplyFunction.AddParameter("na.rm", "TRUE", iPosition:=3)
    '        Else
    '            clsApplyFunction.RemoveParameterByName("na.rm")
    '        End If
    '    Else
    '        clsApplyFunction.RemoveParameterByName("na.rm")
    '    End If
    '    If rdoMore.Checked Then
    '        clsDummyFunction.AddParameter("checked", "user_defined", iPosition:=0)
    '        Select Case ucrInputUserDefined.GetText
    '            Case "anyNA"
    '                clsApplyFunction.AddParameter("FUN", "anyNA", iPosition:=2)
    '            Case "anyDuplicated"
    '                clsApplyFunction.AddParameter("FUN", "anyDuplicated", iPosition:=2)
    '            Case "cv"
    '                clsApplyFunction.AddParameter("FUN", "raster::cv", iPosition:=2)
    '            Case "Gmean"
    '                clsApplyFunction.AddParameter("FUN", "DescTools::Gmean", iPosition:=2)
    '            Case "Hmean"
    '                clsApplyFunction.AddParameter("FUN", "DescTools::Hmean", iPosition:=2)
    '            Case "IQR"
    '                clsApplyFunction.AddParameter("FUN", "IQR", iPosition:=2)
    '            Case "kurtosis"
    '                clsApplyFunction.AddParameter("FUN", "e1071::kurtosis", iPosition:=2)
    '            Case "mad"
    '                clsApplyFunction.AddParameter("FUN", "mad", iPosition:=2)
    '            Case "mc"
    '                clsApplyFunction.AddParameter("FUN", "robustbase::mc", iPosition:=2)
    '            Case "mean, trim=0.2"
    '                clsApplyFunction.AddParameter("FUN", "mean, trim=0.2", iPosition:=2)
    '            Case "mfv"
    '                clsApplyFunction.AddParameter("FUN", "statip::mfv", iPosition:=2)
    '            Case "mfv1"
    '                clsApplyFunction.AddParameter("FUN", "statip::mfv1", iPosition:=2)
    '            Case "quantile, probs=0.5"
    '                clsApplyFunction.AddParameter("FUN", "quantile, probs=0.5", iPosition:=2)
    '            Case "skewness"
    '                clsApplyFunction.AddParameter("FUN", "e1071::skewness", iPosition:=2)
    '            Case Else
    '                clsApplyFunction.AddParameter("FUN", ucrInputUserDefined.GetText, iPosition:=2)
    '        End Select
    '    Else
    '        If rdoMean.Checked Then
    '            clsDummyFunction.AddParameter("checked", "mean", iPosition:=0)
    '            clsApplyFunction.AddParameter("FUN", "mean", iPosition:=2)
    '        ElseIf rdoMaximum.Checked Then
    '            clsDummyFunction.AddParameter("checked", "max", iPosition:=0)
    '            clsApplyFunction.AddParameter("FUN", "max", iPosition:=2)
    '        ElseIf rdoMinimum.Checked Then
    '            clsDummyFunction.AddParameter("checked", "min", iPosition:=0)
    '            clsApplyFunction.AddParameter("FUN", "min", iPosition:=2)
    '        ElseIf rdoStandardDeviation.Checked Then
    '            clsDummyFunction.AddParameter("checked", "sd", iPosition:=0)
    '            clsApplyFunction.AddParameter("FUN", "sd", iPosition:=2)
    '        ElseIf rdoSum.Checked Then
    '            clsDummyFunction.AddParameter("checked", "sum", iPosition:=0)
    '            clsApplyFunction.AddParameter("FUN", "sum", iPosition:=2)
    '        ElseIf rdoMedian.Checked Then
    '            clsDummyFunction.AddParameter("checked", "median", iPosition:=0)
    '            clsApplyFunction.AddParameter("FUN", "median", iPosition:=2)
    '        ElseIf rdoCount.Checked Then
    '            clsDummyFunction.AddParameter("checked", "count", iPosition:=0)
    '            clsApplyFunction.AddParameter("FUN", "function(z) sum(!is.na(z))", iPosition:=2)
    '        ElseIf rdoNumberMissing.Checked Then
    '            clsDummyFunction.AddParameter("checked", "number missing", iPosition:=0)
    '            clsApplyFunction.AddParameter("FUN", "function(z) sum(is.na(z))", iPosition:=2)
    '        Else
    '            clsApplyFunction.RemoveParameterByName("FUN")
    '        End If
    '    End If
    'End Sub
End Class