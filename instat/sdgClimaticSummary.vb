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
Public Class sdgClimaticSummary
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Private clsSummariseFunction, clsSumFunction, clsMinimaFunction, clsMaximaFunction, clsMeanFunction, clsMedianFunction, clsSdFunction, clsCountFunction, clsLengthFunction, clsProportionFunction, clsPercentileFunction As New RFunction
    Private clsAboveFuction, clsTotalFunction, clsWhichAboveFunction, clsRunCalcFunction As New RFunction
    Private clsMultipyOperator, clsDivideOperator, clsWhichAboveFunctionOperator As New ROperator
    Private clsRSyntax As RSyntax
    Private strTempFuc As String

    Private Sub sdgClimaticSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctOptions As New Dictionary(Of String, String)
        Dim dctPercentiles As New Dictionary(Of String, String)
        Dim dctProportions As New Dictionary(Of String, String)

        ucrPnlSummary.SetParameter(New RParameter("result_name"))
        ucrPnlSummary.AddRadioButton(rdoTotals, Chr(34) & "sum" & Chr(34))
        ucrPnlSummary.AddRadioButton(rdoCounts, Chr(34) & "count" & Chr(34))
        ucrPnlSummary.AddRadioButton(rdoMissing, Chr(34) & "missing" & Chr(34))
        ucrPnlSummary.AddRadioButton(rdoMinima, Chr(34) & "minima" & Chr(34))
        ucrPnlSummary.AddRadioButton(rdoMeans, Chr(34) & "mean" & Chr(34))
        ucrPnlSummary.AddRadioButton(rdoMedians, Chr(34) & "median" & Chr(34))
        ucrPnlSummary.AddRadioButton(rdoMaxima, Chr(34) & "maxima" & Chr(34))
        ucrPnlSummary.AddRadioButton(rdoStd, Chr(34) & "std_dev" & Chr(34))
        ucrPnlSummary.AddRadioButton(rdoPercentiles, Chr(34) & "percentile" & Chr(34))
        ucrPnlSummary.AddRadioButton(rdoProportions, Chr(34) & "proportion" & Chr(34))

        '  ucrPnlSummary.

        'ucrPnlSummary.AddParameterValuesCondition(rdoTotals, "result_name", "sum")
        'ucrPnlSummary.AddParameterValuesCondition(rdoCounts, "result_name", "count")
        'ucrPnlSummary.AddParameterValuesCondition(rdoMinima, "result_name", "minima")
        'ucrPnlSummary.AddParameterValuesCondition(rdoMeans, "result_name", "mean")
        'ucrPnlSummary.AddParameterValuesCondition(rdoMedians, "result_name", "median")
        'ucrPnlSummary.AddParameterValuesCondition(rdoMaxima, "result_name", "maxima")
        'ucrPnlSummary.AddParameterValuesCondition(rdoStd, "result_name", "std_dev")
        'ucrPnlSummary.AddParameterValuesCondition(rdoPercentiles, "result_name", "percentile")
        'ucrPnlSummary.AddParameterValuesCondition(rdoProportions, "result_name", "proportion")

        'ucrChkPercentages.SetParameter(New RParameter("sub_1"))
        'ucrChkPercentages.SetValueIfChecked("*100")
        ucrChkPercentages.SetText("Percentages")

        ucrNudPercentile.SetParameter(New RParameter("probs", 1))
        ucrNudPercentile.DecimalPlaces = 2
        ucrNudPercentile.Increment = 0.05

        ucrInputNumbers.SetParameter(New RParameter("amount", 1))
        ucrInputNumbers.SetValidationTypeAsNumeric()
        ucrInputNumbers.AddQuotesIfUnrecognised = False

        ucrInputComboOptions.SetParameter(New RParameter("operator", 1))
        dctOptions.Add(">", ">")
        dctOptions.Add(">=", ">=")
        dctOptions.Add("==", "==")
        dctOptions.Add("<", "<")
        dctOptions.Add("<=", "<=")
        ucrInputComboOptions.SetItems(dctOptions)
        ucrInputComboOptions.SetDropDownStyleAsNonEditable()

        'linking controls
        ucrPnlSummary.AddToLinkedControls({ucrInputComboOptions}, {rdoCounts, rdoProportions}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="<")
        ucrPnlSummary.AddToLinkedControls({ucrInputNumbers}, {rdoCounts, rdoProportions}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True) ', bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.85")
        ucrPnlSummary.AddToLinkedControls({ucrNudPercentile}, {rdoPercentiles}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.5")
        ucrPnlSummary.AddToLinkedControls({ucrChkPercentages}, {rdoProportions}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        FuncExpression()
        bControlsInitialised = True
        'TODO:Disabled
        rdoMissing.Enabled = False
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewSummariseFunction As RFunction, clsNewSumFunction As RFunction, clsNewMinimaFunction As RFunction, clsNewMaximaFunction As RFunction, clsNewMeanFunction As RFunction, clsNewMedianFunction As RFunction, clsNewSdFunction As RFunction, clsNewCountFunction As RFunction, strNewTempFuc As String, clsNewLengthFunction As RFunction, clsNewProportionFunction As RFunction, clsNewPercentileFunction As RFunction, clsNewAboveFuction As RFunction, clsNewWhichAboveFunctionOperator As ROperator, clsNewTotalFunction As RFunction, clsNewWhichAboveFunction As RFunction, clsNewRunCalcFunction As RFunction, clsNewMultipyOperator As ROperator, clsNewDivideOperator As ROperator, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRSyntax = clsNewRSyntax
        strTempFuc = strNewTempFuc
        clsSummariseFunction = clsNewSummariseFunction
        clsSumFunction = clsNewSumFunction
        clsMinimaFunction = clsNewMinimaFunction
        clsMaximaFunction = clsNewMaximaFunction
        clsMeanFunction = clsNewMeanFunction
        clsMedianFunction = clsNewMedianFunction
        clsSdFunction = clsNewSdFunction
        clsCountFunction = clsNewCountFunction
        clsLengthFunction = clsNewLengthFunction
        clsProportionFunction = clsNewProportionFunction
        clsPercentileFunction = clsNewPercentileFunction
        clsAboveFuction = clsNewAboveFuction
        clsWhichAboveFunctionOperator = clsNewWhichAboveFunctionOperator
        clsTotalFunction = clsNewTotalFunction
        clsWhichAboveFunction = clsNewWhichAboveFunction
        clsRunCalcFunction = clsNewRunCalcFunction
        clsMultipyOperator = clsNewMultipyOperator
        clsDivideOperator = clsNewDivideOperator

        clsLengthFunction.AddParameter("x", clsRFunctionParameter:=clsCountFunction, bIncludeArgumentName:=False)
        clsPercentileFunction.AddParameter("x", strTempFuc, iPosition:=0)
        FuncExpression()
        CalcParam()

        ucrPnlSummary.SetRCode(clsSummariseFunction, bReset, bCloneIfNeeded:=False)

        ucrNudPercentile.SetRCode(clsPercentileFunction, bReset)
        ucrInputNumbers.SetRCode(clsWhichAboveFunctionOperator, bReset, bCloneIfNeeded:=False)
        'ucrChkPercentages.SetRCode(clsDivideOperator, bReset)
        'ucrPnlSummary.SetRCode(clsSummariseFunction, bReset)
    End Sub

    Private Sub FuncExpression()
        If rdoTotals.Checked Then
            clsSumFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsSumFunction, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsDivideOperator)
            clsRSyntax.AddToAfterCodes(clsSummariseFunction, iPosition:=3)
        ElseIf rdoCounts.Checked Then
            clsLengthFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsLengthFunction, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsDivideOperator)
            clsRSyntax.AddToAfterCodes(clsSummariseFunction, iPosition:=3)
        ElseIf rdoMaxima.Checked Then
            clsMaximaFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsMaximaFunction, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsDivideOperator)
            clsRSyntax.AddToAfterCodes(clsSummariseFunction, iPosition:=3)
        ElseIf rdoMinima.Checked Then
            clsMinimaFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsMinimaFunction, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsDivideOperator)
            clsRSyntax.AddToAfterCodes(clsSummariseFunction, iPosition:=3)
        ElseIf rdoMeans.Checked Then
            clsMeanFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsMeanFunction, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsDivideOperator)
            clsRSyntax.AddToAfterCodes(clsSummariseFunction, iPosition:=3)
        ElseIf rdoMedians.Checked Then
            clsMedianFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsMedianFunction, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsDivideOperator)
            clsRSyntax.AddToAfterCodes(clsSummariseFunction, iPosition:=3)
        ElseIf rdoStd.Checked Then
            clsSdFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsSdFunction, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsDivideOperator)
            clsRSyntax.AddToAfterCodes(clsSummariseFunction, iPosition:=3)
        ElseIf rdoPercentiles.Checked Then
            clsPercentileFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsPercentileFunction, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsDivideOperator)
            clsRSyntax.AddToAfterCodes(clsSummariseFunction, iPosition:=3)
        ElseIf rdoProportions.Checked Then
            clsRSyntax.AddToAfterCodes(clsDivideOperator)
            clsRSyntax.RemoveFromAfterCodes(clsSummariseFunction)
        ElseIf rdoMissing.Checked Then
            clsRSyntax.RemoveFromAfterCodes(clsDivideOperator)
            clsRSyntax.RemoveFromAfterCodes(clsSummariseFunction)
        End If
    End Sub

    Private Sub ucrPnlSummary_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlSummary.ControlContentsChanged
        FuncExpression()
        CalcParam()
    End Sub

    Private Sub CalcParam()
        If rdoProportions.Checked Then
            clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsProportionFunction, iPosition:=0)
        Else
            clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsSummariseFunction, iPosition:=0)
        End If
    End Sub

    Private Sub ucrInputComboOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboOptions.ControlValueChanged, ucrInputNumbers.ControlValueChanged
        Select Case ucrInputComboOptions.GetText
            Case ">"
                clsWhichAboveFunctionOperator.SetOperation(">")
            Case ">="
                clsWhichAboveFunctionOperator.SetOperation(">=")
            Case ">"
                clsWhichAboveFunctionOperator.SetOperation("==")
            Case ">"
                clsWhichAboveFunctionOperator.SetOperation("<")
            Case ">"
                clsWhichAboveFunctionOperator.SetOperation("<=")
        End Select
        'clsWhichAboveFunction.AddParameter("x", strTempFuc & ucrInputComboOptions.cboInput.SelectedItem & ucrInputNumbers.GetText, bIncludeArgumentName:=False)
        clsCountFunction.AddParameter("x", strTempFuc & ucrInputComboOptions.cboInput.SelectedItem & ucrInputNumbers.GetText, bIncludeArgumentName:=False)
    End Sub

    Private Sub ucrChkPercentages_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkPercentages.ControlContentsChanged
        If ucrChkPercentages.Checked Then
            'clsRSyntax.AddToAfterCodes(clsMultipyOperator)
        Else
            'clsRSyntax.RemoveFromAfterCodes(clsMultipyOperator)
        End If
    End Sub
End Class