' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations
Public Class sdgCanonicalCorrelation
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Public clsRCanCorFunction, clsRXCoefFunction, clsRYCoefFunction, clsRGraphicsFunction As New RFunction
    Public clsTempFunction, clsXvarFunction, clsYvarFunction, clsTempFun As String
    Private clsRSyntax As RSyntax
    Private Sub sdgCanonicalCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrPnlVariables.AddRadioButton(rdoXVariables)
        ucrPnlVariables.AddRadioButton(rdoYVariables)
        ucrPnlVariables.AddRSyntaxContainCodeCondition(rdoXVariables)
        ucrPnlVariables.AddRSyntaxContainCodeCondition(rdoYVariables)

        ucrChkCanonicalCorrelations.SetText("canonical Correlations")
        ucrChkCoefficients.SetText("Coefficients")
        ucrChkPairwisePlot.SetText("Pairwise Plot")
        ucrChkPairwisePlot.AddToLinkedControls(ucrPnlVariables, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=rdoXVariables)
    End Sub

    Public Sub SetRFunction(clsNewRSyntax As RSyntax, clsNewRCanCorFunction As RFunction, clsNewRXCoefFunction As RFunction, clsNewRYCoefFunction As RFunction, clsNewRGraphicsFunction As RFunction, clsNewTempFunction As String, clsNewXvarFunction As String, clsNewYvarFunction As String, clsNewTempFun As String, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        Dim clsTempFunc As RFunction
        clsRSyntax = clsNewRSyntax
        clsRCanCorFunction = clsNewRCanCorFunction
        clsRXCoefFunction = clsNewRXCoefFunction
        clsRYCoefFunction = clsNewRYCoefFunction
        clsRGraphicsFunction = clsNewRGraphicsFunction
        clsTempFunction = clsNewTempFunction
        clsXvarFunction = clsNewXvarFunction
        clsYvarFunction = clsNewYvarFunction
        clsTempFun = clsNewTempFun

        clsRCanCorFunction.AddParameter("data_name", Chr(34) & clsTempFun & Chr(34))
        clsRCanCorFunction.AddParameter("model_name", Chr(34) & clsTempFunction & Chr(34))
        clsRCanCorFunction.AddParameter("value1", Chr(34) & "cor" & Chr(34))
        clsRXCoefFunction.AddParameter("data_name", Chr(34) & clsTempFun & Chr(34))
        clsRXCoefFunction.AddParameter("model_name", Chr(34) & clsTempFunction & Chr(34))
        clsRXCoefFunction.AddParameter("value1", Chr(34) & "xcoef" & Chr(34))
        clsRYCoefFunction.AddParameter("data_name", Chr(34) & clsTempFun & Chr(34))
        clsRYCoefFunction.AddParameter("model_name", Chr(34) & clsTempFunction & Chr(34))
        clsRYCoefFunction.AddParameter("value1", Chr(34) & "ycoef" & Chr(34))
        clsTempFunc = dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.clsCurrDataFrame.Clone()
        clsTempFunc.AddParameter("remove_attr", "TRUE")
        clsRGraphicsFunction.AddParameter("data", clsRFunctionParameter:=clsTempFunc)
        bControlsInitialised = True
        If bReset Then
            tbRegOptions.SelectedIndex = 0
        End If
    End Sub

    Private Sub ucrChkCanonicalCorrelations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCanonicalCorrelations.ControlValueChanged
        If ucrChkCanonicalCorrelations.Checked Then
            clsRCanCorFunction.iCallType = 2
            clsRSyntax.AddToAfterCodes(clsRCanCorFunction, iPosition:=0)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRCanCorFunction)
        End If
    End Sub

    Private Sub ucrChkCoefficients_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCoefficients.ControlValueChanged
        If ucrChkCoefficients.Checked Then
            clsRXCoefFunction.iCallType = 2
            clsRYCoefFunction.iCallType = 2
            clsRSyntax.AddToAfterCodes(clsRXCoefFunction, iPosition:=1)
            clsRSyntax.AddToAfterCodes(clsRYCoefFunction, iPosition:=2)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRYCoefFunction)
            clsRSyntax.RemoveFromAfterCodes(clsRXCoefFunction)
        End If
    End Sub

    Private Sub ucrChkPairwisePlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPairwisePlot.ControlValueChanged
        If ucrChkPairwisePlot.Checked Then
            If rdoXVariables.Checked Then
                clsRGraphicsFunction.AddParameter("columns", clsXvarFunction)
                clsRGraphicsFunction.iCallType = 3
                clsRSyntax.AddToAfterCodes(clsRGraphicsFunction, iPosition:=2)
            ElseIf rdoYVariables.Checked Then
                clsRGraphicsFunction.AddParameter("columns", clsYvarFunction)
                clsRGraphicsFunction.iCallType = 3
                clsRSyntax.AddToAfterCodes(clsRGraphicsFunction, iPosition:=2)
            Else
                clsRSyntax.RemoveFromAfterCodes(clsRGraphicsFunction)
            End If
        End If
    End Sub
End Class