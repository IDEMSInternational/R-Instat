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

    Private clsAsFactorFunc As New RFunction
    Private clsMonthFunc As New RFunction
    Private clsYearFunc As New RFunction

    Private clsPolynomialFunc As New RFunction
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
        ucrPnlChooseFunction.AddRadioButton(rdoPolynomial)
        ucrPnlChooseFunction.AddRadioButton(rdoSquareRoot)
        ucrPnlChooseFunction.AddRadioButton(rdoBrokenStick)
        ucrPnlChooseFunction.AddRadioButton(rdoSplineDf)
        ucrPnlChooseFunction.AddRadioButton(rdoCustom)
        ucrPnlChooseFunction.AddRadioButton(rdoMonth)
        ucrPnlChooseFunction.AddRadioButton(rdoYear)

        ucrPnlChooseFunction.AddToLinkedControls(ucrNudPolynomial, {rdoPolynomial}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        ucrPnlChooseFunction.AddToLinkedControls(ucrInputTxtBrokenStick, {rdoBrokenStick}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlChooseFunction.AddToLinkedControls(ucrNudSplineDF, {rdoSplineDf}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=3)
        ucrPnlChooseFunction.AddToLinkedControls(ucrChkMonthAsFactor, {rdoMonth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlChooseFunction.AddToLinkedControls(ucrChkYearAsFactor, {rdoYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlChooseFunction.AddToLinkedControls(ucrInputTxtOwn, {rdoCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudPolynomial.SetParameter(New RParameter("degree", 1))

        ucrInputTxtBrokenStick.SetParameter(New RParameter("b", 1, bNewIncludeArgumentName:=False))
        ucrInputTxtBrokenStick.SetValidationTypeAsNumeric()
        ucrInputTxtBrokenStick.AddQuotesIfUnrecognised = False

        ucrNudSplineDF.SetParameter(New RParameter("df", 1))
        ucrNudSplineDF.SetMinMax(Integer.MinValue = 0, Integer.MaxValue)

        ucrChkMonthAsFactor.SetText("Month As Factor")
        ucrChkYearAsFactor.SetText("Year As Factor")
        rdoCustom.Enabled = False

        bControlsInitialised = True
    End Sub

    Public Sub SetRCodeForControls(clsNewFormulaOperator As ROperator, clsNewTransformParameter As RParameter, clsNewTransformFunction As RFunction, strVariableName As String, Optional clsNewBrokenStickFirOperator As ROperator = Nothing, Optional clsNewBrokenStickSecOperator As ROperator = Nothing, Optional clsNewBrokenStickGeneralOperator As ROperator = Nothing, Optional clsNewSplineFunc As RFunction = Nothing, Optional clsNewPowerOperator As ROperator = Nothing, Optional clsNewPolynomialFunc As RFunction = Nothing, Optional clsNewMonthFunc As RFunction = Nothing, Optional clsNewYearFunc As RFunction = Nothing, Optional clsNewAsFactorFunc As RFunction = Nothing, Optional strNewCurDataType As String = "", Optional strNewDataName As String = "", Optional bReset As Boolean = False)
        Dim strParamName As String
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        strCurrentVariableName = strVariableName
        clsTransformationFunction = clsNewTransformFunction
        clsPolynomialFunc = clsNewPolynomialFunc
        clsTransformParameter = clsNewTransformParameter
        clsContainingCode = clsNewFormulaOperator
        clsBrokenStickFirOperator = clsNewBrokenStickFirOperator
        clsBrokenStickSecOperator = clsNewBrokenStickSecOperator
        clsBrokenStickGeneralOperator = clsNewBrokenStickGeneralOperator
        clsSplineFunc = clsNewSplineFunc
        clsAsFactorFunc = clsNewAsFactorFunc
        clsMonthFunc = clsNewMonthFunc
        clsYearFunc = clsNewYearFunc
        strDataName = strNewDataName

        strParamName = clsTransformParameter.strArgumentName

        ucrPnlChooseFunction.ClearConditions()
        ucrPnlChooseFunction.AddParameterIsStringCondition(rdoIdentity, strParamName)
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoLogBase10, strParamName, "log10")
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoSquareRoot, strParamName, "sqrt")
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoNaturalLog, strParamName, "log")
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoSplineDf, strParamName, "bs")
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoPolynomial, strParamName, "poly")
        ucrPnlChooseFunction.AddParameterIsROperatorCondition(rdoBrokenStick, strParamName)

        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoMonth, strParamName, "month")
        ucrPnlChooseFunction.AddParameterValueFunctionNamesCondition(rdoYear, strParamName, "year")
        ucrPnlChooseFunction.bAllowNonConditionValues = True 'temp fix

        ucrInputTxtBrokenStick.AddAdditionalCodeParameterPair(clsBrokenStickSecOperator, New RParameter("b", iNewPosition:=1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)

        ucrPnlChooseFunction.SetRCode(clsContainingCode, bReset, bCloneIfNeeded:=True)
        ucrNudPolynomial.SetRCode(clsPolynomialFunc, bReset, bCloneIfNeeded:=True)
        ucrInputTxtBrokenStick.SetRCode(clsBrokenStickFirOperator, bReset, bCloneIfNeeded:=True)
        ucrNudSplineDF.SetRCode(clsSplineFunc, bReset, bCloneIfNeeded:=True)

        showYearAndMonthFunc(strNewCurDataType)
        UpdatePreview()
        GetColumnMidian()
    End Sub

    Private Sub ucrPnlGenerateFunctions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlChooseFunction.ControlValueChanged
        If rdoIdentity.Checked Then
            clsTransformParameter.SetArgumentValue(strCurrentVariableName)
        ElseIf rdoBrokenStick.Checked Then
            clsTransformParameter.SetArgument(clsBrokenStickGeneralOperator)
        ElseIf rdoSplineDf.Checked Then
            clsTransformParameter.SetArgument(clsSplineFunc)
        ElseIf (rdoMonth.Checked OrElse rdoYear.Checked) Then
            ConvertToFactorOrNot()
        Else
            If rdoPolynomial.Checked Then
                clsTransformationCode = clsPolynomialFunc
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

    '''--------------------------------------------------------------------------------------------
    ''' <summary> Updates the ucrInputText when valeus of the ucrInputTxtBrokenStick,ucrNudSpplineDf and ucrNudPolynomial change     </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub ucrInputTxtBrokenStick_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTxtBrokenStick.ControlContentsChanged, ucrNudSplineDF.ControlValueChanged, ucrNudPolynomial.ControlValueChanged
        UpdatePreview()
    End Sub


    '''--------------------------------------------------------------------------------------------
    ''' <summary>  Finds the median of the X variable from the main dialogue and sets the value to the broken stick textbox
    '''             </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub GetColumnMidian()
        Dim expColumn As SymbolicExpression
        Dim medianValue As String
        Dim clsGetColumnMedianFunc As New RFunction
        Dim clsGetVariablesFunc As New RFunction

        clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetVariablesFunc.AddParameter("data_name", Chr(34) & strDataName & Chr(34), iPosition:=0)
        clsGetVariablesFunc.AddParameter("col_names", Chr(34) & strCurrentVariableName & Chr(34), iPosition:=1)


        clsGetColumnMedianFunc.SetRCommand("summary_median")
        clsGetColumnMedianFunc.AddParameter("x", clsRFunctionParameter:=clsGetVariablesFunc,iPosition:=0)
        clsGetColumnMedianFunc.AddParameter("na.rm", "TRUE", iPosition:=1)


        expColumn = frmMain.clsRLink.RunInternalScriptGetValue(clsGetColumnMedianFunc.ToScript, bSilent:=False)
        If expColumn IsNot Nothing AndAlso Not expColumn.Type = Internals.SymbolicExpressionType.Null Then
            medianValue = expColumn.AsCharacter(0)
            ucrInputTxtBrokenStick.SetName(medianValue)
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary> Updates the ucrInputText  and converts the year and month functions to factors when values for the ucrChkMonth  and ucrChkYearAsFActor change </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub AsFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkYearAsFactor.ControlValueChanged, ucrChkMonthAsFactor.ControlValueChanged
        ConvertToFactorOrNot()
        UpdatePreview()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary> Converts the month and year functions to factors    </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub ConvertToFactorOrNot()
        If rdoMonth.Checked Then
            If ucrChkMonthAsFactor.Checked Then
                clsAsFactorFunc.AddParameter(clsRFunctionParameter:=clsMonthFunc, iPosition:=1)
                clsTransformParameter.SetArgument(clsAsFactorFunc)
            Else
                clsTransformParameter.SetArgument(clsMonthFunc)
            End If
            Exit Sub
        End If

        If rdoYear.Checked Then
            If ucrChkYearAsFactor.Checked Then
                clsAsFactorFunc.AddParameter(clsRFunctionParameter:=clsYearFunc, iPosition:=1)
                clsTransformParameter.SetArgument(clsAsFactorFunc)
            Else
                clsTransformParameter.SetArgument(clsYearFunc)
            End If
        End If
    End Sub

    Private Sub showYearAndMonthFunc(strCurrDataType As String)
        If strCurrDataType = "Date" Then
            rdoMonth.Enabled = True
            rdoYear.Enabled = True
        Else
            rdoMonth.Enabled = False
            rdoYear.Enabled = False
        End If
    End Sub
End Class