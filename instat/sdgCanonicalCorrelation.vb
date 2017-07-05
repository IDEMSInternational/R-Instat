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
    Public strTempFunction, strXvarFunction, strYvarFunction, strTempFunc As String
    Private clsRSyntax As RSyntax
    Private Sub sdgCanonicalCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrPnlVariables.AddRadioButton(rdoXVariables)
        ucrPnlVariables.AddRadioButton(rdoYVariables)

        ucrChkCanonicalCorrelations.AddRSyntaxContainsFunctionNamesCondition(True, {frmMain.clsRLink.strInstatDataObject & "$get_from_model"})
        ucrChkCanonicalCorrelations.AddRSyntaxContainsFunctionNamesCondition(False, {frmMain.clsRLink.strInstatDataObject & "$get_from_model"}, False)
        ucrChkCanonicalCorrelations.SetText("Canonical Correlations")

        ucrChkCoefficients.AddRSyntaxContainsFunctionNamesCondition(True, {frmMain.clsRLink.strInstatDataObject & "$get_from_model"})
        ucrChkCoefficients.AddRSyntaxContainsFunctionNamesCondition(False, {frmMain.clsRLink.strInstatDataObject & "$get_from_model"}, False)
        ucrChkCoefficients.SetText("Coefficients")

        ucrChkPairwisePlot.AddRSyntaxContainsFunctionNamesCondition(True, {"ggpairs"})
        ucrChkPairwisePlot.AddRSyntaxContainsFunctionNamesCondition(False, {"ggpairs"}, False)

        ucrChkPairwisePlot.SetText("Pairwise Plot")
        ucrChkPairwisePlot.AddToLinkedControls(ucrPnlVariables, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoXVariables)
    End Sub

    Public Sub SetRFunction(clsNewRSyntax As RSyntax, clsNewRCanCorFunction As RFunction, clsNewRXCoefFunction As RFunction, clsNewRYCoefFunction As RFunction, clsNewRGraphicsFunction As RFunction, clsNewTempFunction As String, clsNewXvarFunction As String, clsNewYvarFunction As String, clsNewTempFun As String, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        '  Dim clsTempFunc As RFunction
        clsRSyntax = clsNewRSyntax
        clsRCanCorFunction = clsNewRCanCorFunction
        clsRXCoefFunction = clsNewRXCoefFunction
        clsRYCoefFunction = clsNewRYCoefFunction
        clsRGraphicsFunction = clsNewRGraphicsFunction
        strTempFunction = clsNewTempFunction
        strXvarFunction = clsNewXvarFunction
        strYvarFunction = clsNewYvarFunction
        strTempFunc = clsNewTempFun

        ucrChkCanonicalCorrelations.SetRSyntax(clsRSyntax, bReset)
        ucrChkCoefficients.SetRSyntax(clsRSyntax, bReset)
        ucrChkPairwisePlot.SetRSyntax(clsRSyntax, bReset)

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
        If ucrChkPairwisePlot.Checked Then
            If rdoXVariables.Checked Then
                'clsRGraphicsFunction.AddParameter("columns", clsXvarFunction)
                clsRSyntax.AddToAfterCodes(clsRGraphicsFunction, iPosition:=2)
            ElseIf rdoYVariables.Checked Then
                'clsRGraphicsFunction.AddParameter("columns", clsYvarFunction)
                clsRSyntax.AddToAfterCodes(clsRGraphicsFunction, iPosition:=2)
            Else
                clsRSyntax.RemoveFromAfterCodes(clsRGraphicsFunction)
            End If
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRGraphicsFunction)
        End If
    End Sub
End Class