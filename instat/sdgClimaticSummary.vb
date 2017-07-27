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
    Private clsSummariseFunction, clsSumFunction, clsMinimaFunction, clsMaximaFunction, clsMeanFunction, clsMedianFunction, clsSdFunction, clsCountFunction, clsLengthFunction, clsProportionFunction, clsPercentileFunction, clsConcFunction As New RFunction
    Private clsRSyntax As RSyntax
    Private strTempFuc As String

    Private Sub sdgClimaticSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctOptions As New Dictionary(Of String, String)
        Dim dctPercentiles As New Dictionary(Of String, String)
        Dim dctProportions As New Dictionary(Of String, String)

        ucrPnlSummary.AddRadioButton(rdoTotals)
        ucrPnlSummary.AddRadioButton(rdoCounts)
        ucrPnlSummary.AddRadioButton(rdoMissing)
        ucrPnlSummary.AddRadioButton(rdoMinima)
        ucrPnlSummary.AddRadioButton(rdoMeans)
        ucrPnlSummary.AddRadioButton(rdoMedians)
        ucrPnlSummary.AddRadioButton(rdoMaxima)
        ucrPnlSummary.AddRadioButton(rdoStd)
        ucrPnlSummary.AddRadioButton(rdoPercentiles)
        ucrPnlSummary.AddRadioButton(rdoProportions)

        ucrChkPercentages.SetText("Percentages")

        ucrInputNumbers.SetValidationTypeAsNumeric()

        ucrInputComboOptions.SetParameter(New RParameter("function_exp"))
        dctOptions.Add(">", ">")
        dctOptions.Add(">=", ">=")
        dctOptions.Add("==", "==")
        dctOptions.Add("<", "<")
        dctOptions.Add("<=", "<=")
        ucrInputComboOptions.SetItems(dctOptions)
        ucrInputComboOptions.SetDropDownStyleAsNonEditable()

        ucrInputPercentiles.SetParameter(New RParameter("probs"))
        dctPercentiles.Add("0.5", "0.5")
        dctPercentiles.Add("0.2,0.5", "0.2,0.5,0.8")
        dctPercentiles.Add("0.25,0.5,0.8", "0.25,0.5,0.8")
        dctPercentiles.Add("0.1,0.2,0.5,0.8,0.9", "0.1,0.2,0.5,0.8,0.9")
        dctPercentiles.Add("0.8,0.9,0.95", "0.8,0.9,0.95")
        ucrInputPercentiles.SetItems(dctPercentiles)

        'linking controls
        ucrPnlSummary.AddToLinkedControls({ucrInputComboOptions}, {rdoCounts, rdoProportions}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="<")
        ucrPnlSummary.AddToLinkedControls(ucrInputPercentiles, {rdoPercentiles}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.5")
        ucrPnlSummary.AddToLinkedControls({ucrInputNumbers, ucrChkPercentages}, {rdoProportions}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummary.AddToLinkedControls(ucrNudValue, {rdoCounts}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewSummariseFunction As RFunction, clsNewSumFunction As RFunction, clsNewMinimaFunction As RFunction, clsNewMaximaFunction As RFunction, clsNewMeanFunction As RFunction, clsNewMedianFunction As RFunction, clsNewSdFunction As RFunction, clsNewCountFunction As RFunction, strNewTempFuc As String, clsNewLengthFunction As RFunction, clsNewProportionFunction As RFunction, clsNewPercentileFunction As RFunction, clsNewConcFunction As RFunction, Optional bReset As Boolean = False)
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
        clsConcFunction = clsNewConcFunction
        clsLengthFunction.AddParameter("x", clsRFunctionParameter:=clsCountFunction, bIncludeArgumentName:=False)
        clsPercentileFunction.AddParameter("x", strTempFuc)
        clsPercentileFunction.AddParameter("probs", clsRFunctionParameter:=clsConcFunction)
        FuncExpression()
        'ucrInputPercentiles.SetRCode(clsConcFunction, bReset)
        ucrPnlSummary.SetRCode(clsSumFunction, bReset)
    End Sub

    Private Sub FuncExpression()
        clsCountFunction.AddParameter("x", strTempFuc & ucrInputComboOptions.cboInput.SelectedItem & ucrNudValue.Value, bIncludeArgumentName:=False)
        If rdoTotals.Checked Then
            clsSumFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "Sums" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsSumFunction, iPosition:=1)
        ElseIf rdoCounts.Checked Then
            clsLengthFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "Counts" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsLengthFunction, iPosition:=1)
        ElseIf rdoMaxima.Checked Then
            clsMaximaFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "Maxima" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsMaximaFunction, iPosition:=1)
        ElseIf rdoMinima.Checked Then
            clsMinimaFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "Minima" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsMinimaFunction, iPosition:=1)
        ElseIf rdoMeans.Checked Then
            clsMeanFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "Means" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsMeanFunction, iPosition:=1)
        ElseIf rdoMedians.Checked Then
            clsMedianFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "Medians" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsMedianFunction, iPosition:=1)
        ElseIf rdoStd.Checked Then
            clsSdFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "Std.dev's" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsSdFunction, iPosition:=1)
        ElseIf rdoPercentiles.Checked Then
            clsPercentileFunction.bToScriptAsRString = True
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "Percentiles" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsPercentileFunction, iPosition:=1)
        ElseIf rdoProportions.Checked Then
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "Proportions" & Chr(34))
        ElseIf rdoMissing.Checked Then
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "Missing" & Chr(34))
        End If
    End Sub

    Private Sub ucrPnlSummary_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlSummary.ControlContentsChanged, ucrInputComboOptions.ControlValueChanged, ucrNudValue.ControlValueChanged
        FuncExpression()
    End Sub
End Class