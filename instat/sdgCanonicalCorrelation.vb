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
Public Class sdgCanonicalCorrelation
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Public clsRCanCorFunction, clsRXCoefFunction, clsRYCoefFunction, clsRGraphicsFunction As New RFunction
    Private clsRSyntax As RSyntax
    Private Sub sdgCanonicalCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrPnlVariables.AddRadioButton(rdoXVariables)
        ucrPnlVariables.AddRadioButton(rdoYVariables)

        ucrChkCanonicalCorrelations.SetParameter(New RParameter("value1", 2))
        ucrChkCanonicalCorrelations.SetText("Canonical Correlations")
        ucrChkCanonicalCorrelations.SetValueIfChecked(Chr(34) & "cor" & Chr(34))
        ucrChkCanonicalCorrelations.AddParameterPresentCondition(True, "value1")
        ucrChkCanonicalCorrelations.AddParameterPresentCondition(False, "value1", False)

        ucrChkCoefficients.SetParameter(New RParameter("value1", 2))
        ucrChkCoefficients.SetText("Coefficients")
        ucrChkCoefficients.SetValueIfChecked(Chr(34) & "xcoef" & Chr(34))
        ucrChkCoefficients.AddParameterPresentCondition(True, "value1")
        ucrChkCoefficients.AddParameterPresentCondition(False, "value1", False)

        ucrChkPairwisePlot.AddRSyntaxContainsFunctionNamesCondition(True, {"ggpairs"})
        ucrChkPairwisePlot.AddRSyntaxContainsFunctionNamesCondition(False, {"ggpairs"}, False)

        ucrChkPairwisePlot.SetText("Pairwise Plot")
        ucrChkPairwisePlot.AddToLinkedControls(ucrPnlVariables, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoXVariables)
    End Sub

    Public Sub SetRFunction(clsNewRSyntax As RSyntax, clsNewRCanCorFunction As RFunction, clsNewRXCoefFunction As RFunction, clsNewRYCoefFunction As RFunction, clsNewRGraphicsFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        '  Dim clsTempFunc As RFunction
        clsRSyntax = clsNewRSyntax
        clsRCanCorFunction = clsNewRCanCorFunction
        clsRXCoefFunction = clsNewRXCoefFunction
        clsRYCoefFunction = clsNewRYCoefFunction
        clsRGraphicsFunction = clsNewRGraphicsFunction

        ucrChkCoefficients.AddAdditionalCodeParameterPair(clsRYCoefFunction, ucrChkCoefficients.GetParameter, iAdditionalPairNo:=1)

        ucrChkCanonicalCorrelations.SetRCode(clsRCanCorFunction, bReset, bCloneIfNeeded:=True)
        ucrChkCoefficients.SetRCode(clsRXCoefFunction, bReset, bCloneIfNeeded:=True)
        ucrChkPairwisePlot.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)

        bControlsInitialised = True
    End Sub

    Private Sub ucrChkCanonicalCorrelations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCanonicalCorrelations.ControlValueChanged
        If ucrChkCanonicalCorrelations.Checked Then
            clsRSyntax.AddToAfterCodes(clsRCanCorFunction, iPosition:=0)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRCanCorFunction)
        End If
    End Sub

    Private Sub ucrChkCoefficients_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCoefficients.ControlValueChanged
        If ucrChkCoefficients.Checked Then
            clsRSyntax.AddToAfterCodes(clsRXCoefFunction, iPosition:=1)
            clsRSyntax.AddToAfterCodes(clsRYCoefFunction, iPosition:=2)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRYCoefFunction)
            clsRSyntax.RemoveFromAfterCodes(clsRXCoefFunction)
        End If
    End Sub

    Private Sub ucrChkPairwisePlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPairwisePlot.ControlValueChanged, ucrPnlVariables.ControlValueChanged
        dlgCanonicalCorrelationAnalysis.ColumnsParameter()
    End Sub
End Class