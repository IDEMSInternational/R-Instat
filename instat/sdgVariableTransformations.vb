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
Imports RDotNet

Public Class sdgVariableTransformations
    Private clsTransformationCode As New RCodeStructure
    Private clsTransformationFunction As New RFunction
    Private clsContainingCode As New RCodeStructure
    Private clsTransformParameter As New RParameter

    Private clsBrokenStickFirOperator As New ROperator
    Private clsBrokenStickSecOperator As New ROperator
    Private clsBrokenStickGeneralOperator As New ROperator

    Private clsSplineFunc As New RFunction

    Private clsPowerOperator As New ROperator
    Private strDataName As String
    Private bControlsInitialised As Boolean = False
    Private strCurrentVariableName As String


    Private Sub sdgVariableTransformations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrPnlChooseFunction.AddRadioButton(rdoIdentity)
        ucrPnlChooseFunction.AddRadioButton(rdoLogBase10)
        ucrPnlChooseFunction.AddRadioButton(rdoNaturalLog)
        ucrPnlChooseFunction.AddRadioButton(rdoPower)
        ucrPnlChooseFunction.AddRadioButton(rdoSquareRoot)
        ucrPnlChooseFunction.AddRadioButton(rdoBrokenStick)
        ucrPnlChooseFunction.AddRadioButton(rdoSplineDf)
        ucrPnlChooseFunction.AddRadioButton(rdoOwn)

        ucrPnlChooseFunction.AddToLinkedControls(ucrInputTxtPower, {rdoPower}, bNewLinkedDisabledIfParameterMissing:=True)
        ucrPnlChooseFunction.AddToLinkedControls(ucrInputTxtBrokenStick, {rdoBrokenStick}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlChooseFunction.AddToLinkedControls(ucrNudSplineDF, {rdoSplineDf}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)

        'temp disabled as need to use I(x ^ 2) instead of x ^ 2 as this has different meaning in a formula
        rdoPower.Enabled = False

        ucrInputTxtPower.SetParameter(New RParameter("power", 1))
        ucrInputTxtPower.SetValidationTypeAsNumeric()
        ucrInputTxtPower.AddQuotesIfUnrecognised = False

        ucrInputTxtBrokenStick.SetParameter(New RParameter("b", 1, bNewIncludeArgumentName:=False))
        ucrInputTxtBrokenStick.SetValidationTypeAsNumeric()
        ucrInputTxtBrokenStick.AddQuotesIfUnrecognised = False

        ucrNudSplineDF.SetParameter(New RParameter("df", 1))
        ucrNudSplineDF.SetMinMax(0, Integer.MaxValue)

        bControlsInitialised = True
    End Sub

    Public Sub SetRCodeForControls(clsNewFormulaOperator As ROperator, clsNewTransformParameter As RParameter, clsNewTransformFunction As RFunction, clsNewPowerOperator As ROperator, strVariableName As String, Optional clsNewBrokenStickFirOperator As ROperator = Nothing, Optional clsNewBrokenStickSecOperator As ROperator = Nothing, Optional clsNewBrokenStickGeneralOperator As ROperator = Nothing, Optional clsNewSplineFunc As RFunction = Nothing, Optional strNewDataName As String = "", Optional bReset As Boolean = False)
        Dim strParamName As String
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        strCurrentVariableName = strVariableName
        clsTransformationFunction = clsNewTransformFunction
        clsPowerOperator = clsNewPowerOperator
        clsTransformParameter = clsNewTransformParameter
        clsContainingCode = clsNewFormulaOperator
        clsBrokenStickFirOperator = clsNewBrokenStickFirOperator
        clsBrokenStickSecOperator = clsNewBrokenStickSecOperator
        clsBrokenStickGeneralOperator = clsNewBrokenStickGeneralOperator
        clsSplineFunc = clsNewSplineFunc
        strDataName = strNewDataName

        strParamName = clsTransformParameter.strArgumentName

        ucrPnlChooseFunction.ClearConditions()
        ucrPnlChooseFunction.AddParameterIsStringCondition(rdoIdentity, strParamName)
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoLogBase10, strParamName, "log10")
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoSquareRoot, strParamName, "sqrt")
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoNaturalLog, strParamName, "log")
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoSplineDf, strParamName, "bs")
        'ucrPnlChooseFunction.AddParameterIsROperatorCondition(rdoPower, strParamName)
        ucrPnlChooseFunction.AddParameterIsROperatorCondition(rdoBrokenStick, strParamName)

        ucrInputTxtBrokenStick.AddAdditionalCodeParameterPair(clsBrokenStickSecOperator, New RParameter("b", iNewPosition:=1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)

        ucrPnlChooseFunction.SetRCode(clsContainingCode, bReset, bCloneIfNeeded:=True)
        ucrInputTxtPower.SetRCode(clsPowerOperator, bReset, bCloneIfNeeded:=True)
        ucrInputTxtBrokenStick.SetRCode(clsBrokenStickFirOperator, bReset, bCloneIfNeeded:=True)
        ucrNudSplineDF.SetRCode(clsSplineFunc, bReset, bCloneIfNeeded:=True)

        UpdatePreview()
        GetColumnsMidianName()
    End Sub

    Private Sub ucrPnlGenerateFunctions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlChooseFunction.ControlValueChanged
        If rdoIdentity.Checked Then
            clsTransformParameter.SetArgumentValue(strCurrentVariableName)
        ElseIf rdoBrokenStick.Checked Then
            clsTransformParameter.SetArgument(clsBrokenStickGeneralOperator)
        ElseIf rdoSplineDf.Checked Then
            clsTransformParameter.SetArgument(clsSplineFunc)
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

    Private Sub ucrInputTxtBrokenStick_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTxtBrokenStick.ControlValueChanged, ucrNudSplineDF.ControlValueChanged
        UpdatePreview()
    End Sub

    Private Sub GetColumnsMidianName()
        Dim expColumn As SymbolicExpression
        Dim medianValue As String
        Dim clsGetColumnMedianFunc As New RFunction
        Dim clsGetVariablesFunc As New RFunction

        clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetVariablesFunc.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetVariablesFunc.AddParameter("col_names", Chr(34) & strCurrentVariableName & Chr(34))

        clsGetColumnMedianFunc.SetRCommand("summary_median")
        clsGetColumnMedianFunc.AddParameter("x", clsRFunctionParameter:=clsGetVariablesFunc)


        expColumn = frmMain.clsRLink.RunInternalScriptGetValue(clsGetColumnMedianFunc.ToScript, bSilent:=False)
        If expColumn IsNot Nothing AndAlso Not expColumn.Type = Internals.SymbolicExpressionType.Null Then
            medianValue = expColumn.AsCharacter(0)
            ucrInputTxtBrokenStick.SetName(medianValue)
        End If
    End Sub
End Class