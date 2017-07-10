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

Imports instat
Imports instat.Translations

Public Class sdgVariableTransformations
    Public clsTransformationCode As RCodeStructure
    Public clsTransformationFunction As RFunction
    Public clsContainingCode As RCodeStructure
    Public clsTransformParameter As RParameter
    Public clsPowerOperator As ROperator
    Public bControlsInitialised As Boolean = False
    Public strCurrentVariableName As String

    Private Sub sdgVariableTransformations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrPnlChooseFunction.AddRadioButton(rdoIdentity)
        ucrPnlChooseFunction.AddRadioButton(rdoLogBase10)
        ucrPnlChooseFunction.AddRadioButton(rdoNaturalLog)
        ucrPnlChooseFunction.AddRadioButton(rdoPower)
        ucrPnlChooseFunction.AddRadioButton(rdoSquareRoot)
        ucrPnlChooseFunction.AddToLinkedControls(ucrNudPower, {rdoPower}, bNewLinkedDisabledIfParameterMissing:=True)

        'temp disabled as need to use I(x ^ 2) instead of x ^ 2 as this has different meaning in a formula
        rdoPower.Enabled = False

        ucrNudPower.SetParameter(New RParameter("power", 1))
        ucrNudPower.SetMinMax(Integer.MinValue, Integer.MaxValue)
        bControlsInitialised = True
    End Sub

    Public Sub SetRCodeForControls(clsNewFormulaOperator As ROperator, clsNewTransformParameter As RParameter, clsNewTransformFunction As RFunction, clsNewPowerOperator As ROperator, strVariableName As String, Optional bReset As Boolean = False)
        Dim strParamName As String
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        strCurrentVariableName = strVariableName
        clsTransformationFunction = clsNewTransformFunction
        clsPowerOperator = clsNewPowerOperator
        clsTransformParameter = clsNewTransformParameter
        clsContainingCode = clsNewFormulaOperator
        strParamName = clsTransformParameter.strArgumentName

        ucrPnlChooseFunction.ClearConditions()
        ucrPnlChooseFunction.AddParameterIsStringCondition(rdoIdentity, strParamName)
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoLogBase10, strParamName, "log10")
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoSquareRoot, strParamName, "sqrt")
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoNaturalLog, strParamName, "log")
        ucrPnlChooseFunction.AddParameterIsROperatorCondition(rdoPower, strParamName)

        ucrPnlChooseFunction.SetRCode(clsContainingCode, bReset, bCloneIfNeeded:=True)
        ucrNudPower.SetRCode(clsPowerOperator, bReset, bCloneIfNeeded:=True)
        UpdatePreview()
    End Sub

    Private Sub ucrPnlGenerateFunctions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlChooseFunction.ControlValueChanged
        If rdoIdentity.Checked Then
            clsTransformParameter.SetArgumentValue(strCurrentVariableName)
        Else
            If rdoPower.Checked Then
                clsTransformationCode = clsPowerOperator
            Else
                If rdoLogBase10.Checked Then
                    clsTransformationFunction.SetRCommand("log10")
                ElseIf rdoNaturalLog.Checked Then
                    clsTransformationFunction.SetRCommand("log")
                ElseIf rdoSquareRoot.Checked Then
                    clsTransformationFunction.SetRCommand("sqrt")
                End If
                clsTransformationCode = clsTransformationFunction
            End If
            clsTransformParameter.SetArgument(clsTransformationCode)
        End If
        UpdatePreview()
    End Sub

    Private Sub UpdatePreview()
        ucrInputPreview.SetName(clsTransformParameter.ToScript(""))
    End Sub

    Private Sub ucrNudPower_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudPower.ControlValueChanged
        UpdatePreview()
    End Sub
End Class