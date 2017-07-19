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

Public Class sdgClimaticSummary
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Private Sub sdgClimaticSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'autoTranslate(Me)
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

        ucrInputOptions.SetParameter(New RParameter("function_exp"))
        dctOptions.Add(">", ">")
        dctOptions.Add(">=", ">=")
        dctOptions.Add("=", "=")
        dctOptions.Add("<", "<")
        dctOptions.Add("<=", "<=")
        ucrInputOptions.SetItems(dctOptions)
        ucrInputOptions.SetDropDownStyleAsNonEditable()

        ucrInputPercentiles.SetParameter(New RParameter("function_exp"))
        dctPercentiles.Add("50", "50")
        dctPercentiles.Add("20,50", "20,50,80")
        dctPercentiles.Add("25,50,80", "25,50,80")
        dctPercentiles.Add("10,20,50,80,90", "10,20,50,80,90")
        dctPercentiles.Add("80,90,95", "80,90,95")
        ucrInputPercentiles.SetItems(dctPercentiles)

        ucrInputProportions.SetParameter(New RParameter("function_exp"))
        dctProportions.Add(">", ">")
        dctProportions.Add(">=", ">=")
        dctProportions.Add("=", "=")
        dctProportions.Add("<", "<")
        dctProportions.Add("<=", "<=")
        ucrInputProportions.SetItems(dctProportions)
        ucrInputProportions.SetDropDownStyleAsNonEditable()

        'linking controls
        ucrPnlSummary.AddToLinkedControls({ucrInputOptions, ucrNudValue}, {rdoCounts}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummary.AddToLinkedControls(ucrInputPercentiles, {rdoPercentiles}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummary.AddToLinkedControls({ucrInputProportions, ucrInputNumbers, ucrChkPercentages}, {rdoProportions}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlSummary.AddToLinkedControls(ucrInputOptions, {rdoCounts}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlSummary.AddToLinkedControls(ucrInputOptions, {rdoCounts}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

    End Sub
End Class