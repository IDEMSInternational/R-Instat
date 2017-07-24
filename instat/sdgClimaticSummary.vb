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
    Private clsSummariseFunction, clsSumFunction, clsMinimaFunction, clsMaximaFunction, clsMeanFunction, clsMedianFunction, clsSdFunction, clsCountFunction As New RFunction
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
        dctOptions.Add("=", "=")
        dctOptions.Add("<", "<")
        dctOptions.Add("<=", "<=")
        ucrInputComboOptions.SetItems(dctOptions)
        ucrInputComboOptions.SetDropDownStyleAsNonEditable()
        'ucrInputComboCount.SetName("<")

        ucrInputPercentiles.SetParameter(New RParameter("function_exp"))
        dctPercentiles.Add("50", "50")
        dctPercentiles.Add("20,50", "20,50,80")
        dctPercentiles.Add("25,50,80", "25,50,80")
        dctPercentiles.Add("10,20,50,80,90", "10,20,50,80,90")
        dctPercentiles.Add("80,90,95", "80,90,95")
        ucrInputPercentiles.SetItems(dctPercentiles)

        'ucrInputComboProportions.SetParameter(New RParameter("function_exp"))
        'dctProportions.Add(">", ">")
        'dctProportions.Add(">=", ">=")
        'dctProportions.Add("=", "=")
        'dctProportions.Add("<", "<")
        'dctProportions.Add("<=", "<=")
        'ucrInputComboProportions.SetItems(dctProportions)
        'ucrInputComboProportions.SetDropDownStyleAsNonEditable()

        'linking controls
        ucrPnlSummary.AddToLinkedControls({ucrInputComboOptions, ucrNudValue}, {rdoCounts}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="<")
        ucrPnlSummary.AddToLinkedControls(ucrInputPercentiles, {rdoPercentiles}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummary.AddToLinkedControls({ucrInputComboOptions, ucrInputNumbers, ucrChkPercentages}, {rdoProportions}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlSummary.AddToLinkedControls(ucrInputOptions, {rdoCounts}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlSummary.AddToLinkedControls(ucrInputOptions, {rdoCounts}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewSummariseFunction As RFunction, clsNewSumFunction As RFunction, clsNewMinimaFunction As RFunction, clsNewMaximaFunction As RFunction, clsNewMeanFunction As RFunction, clsNewMedianFunction As RFunction, clsNewSdFunction As RFunction, clsNewCountFunction As RFunction, strNewTempFuc As String, Optional bReset As Boolean = False)
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
        CountFuncExp()
    End Sub

    Private Sub CountFuncExp()
        clsCountFunction.AddParameter("", Chr(34) & strTempFuc & ucrInputComboOptions.cboInput.SelectedItem & ucrNudValue.GetText & Chr(34))
    End Sub

    Private Sub ucrPnlSummary_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlSummary.ControlContentsChanged
        If rdoTotals.Checked Then
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "sum" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", Chr(34) & clsSumFunction.ToScript() & Chr(34))
        ElseIf rdoCounts.Checked Then
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "count" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsCountFunction)
        ElseIf rdoMaxima.Checked Then
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "max" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", Chr(34) & clsMaximaFunction.ToScript() & Chr(34))
        ElseIf rdoMinima.Checked Then
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "min" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", Chr(34) & clsMinimaFunction.ToScript() & Chr(34))
        ElseIf rdoMeans.Checked Then
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "mean" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", Chr(34) & clsMeanFunction.ToScript() & Chr(34))
        ElseIf rdoMedians.Checked Then
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "median" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", Chr(34) & clsMedianFunction.ToScript() & Chr(34))
        ElseIf rdoStd.Checked Then
            clsSummariseFunction.AddParameter("result_name", Chr(34) & "sd" & Chr(34))
            clsSummariseFunction.AddParameter("function_exp", Chr(34) & clsSdFunction.ToScript() & Chr(34))
        End If
    End Sub

    Private Sub ucrInputComboOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboOptions.ControlValueChanged
        CountFuncExp()
    End Sub
End Class