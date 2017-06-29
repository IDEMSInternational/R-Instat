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
Public Class sdgVariableTransformations
    Public clsRCIFunction As RFunction
    Public clsRToFunction, clsLMorGLM As New RFunction
    Public clsRYVariable, clsRXVariable As String
    Public clsRModel, clsRModel1, clsFormulaOperator As ROperator
    Public clsModel0 As New ROperator
    Public bControlsInitialised As Boolean = True
    Private Sub sdgVariableTransformations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrPnlGenerateFunctions.AddFunctionNamesCondition(rdoLogBase10, "log10")
        ucrPnlGenerateFunctions.AddFunctionNamesCondition(rdoSquareroot, "sqrt")
        ucrPnlGenerateFunctions.AddFunctionNamesCondition(rdoNaturallog, "log")
        ucrPnlGenerateFunctions.AddFunctionNamesCondition(rdoIdentity, {"log10", "power", "log", "sqrt"}, False)
        ucrPnlGenerateFunctions.AddFunctionNamesCondition(rdoPower, "power")
        bControlsInitialised = True
    End Sub

    Public Sub SetRCodeForControls(clsNewLMorGLM As RFunction, clsNewFormulaOperator As ROperator, clsRModelNew As ROperator, clsRYVariableNew As String, clsRXVariableNew As String, Optional bReset As Boolean = False)
        If bControlsInitialised Then
            InitialiseControls()
        End If
        clsLMorGLM = clsNewLMorGLM
        clsRXVariable = clsRXVariableNew
        clsRYVariable = clsRYVariableNew
        clsRModel = clsRModelNew
        clsFormulaOperator = clsNewFormulaOperator
        ucrPnlGenerateFunctions.SetRCode(clsLMorGLM, bReset)

    End Sub

    Private Sub ExplanatoryFunction(strFunctionName As String, strPower As String, Optional choice As Boolean = False)
        Dim i As Integer 'This is temporary, will need to change this method...
        If choice Then
            i = 0
        Else
            i = -1
        End If
        If strFunctionName = "power" Then
            If strPower <> "1" Then
                'clsRModel.AddParameter(False, strParameterValue:=clsRYVariable.GetVariableNames(bWithQuotes:=False))
                clsModel0.SetOperation("^")
                clsModel0.bBrackets = False
                clsModel0.AddParameter(strParameterValue:=strPower)
                clsModel0.AddParameter("x", clsRXVariable, bIncludeArgumentName:=False)
                clsFormulaOperator.AddParameter("x", clsROperatorParameter:=clsModel0, iPosition:=1)
            End If

        Else
            clsRToFunction.SetRCommand(strFunctionName)
            clsRToFunction.AddParameter("x", clsRXVariable, bIncludeArgumentName:=False)
            clsFormulaOperator.AddParameter("x", clsRFunctionParameter:=clsRToFunction, iPosition:=1)
        End If

    End Sub

    Public Sub ModelFunction(Optional choice As Boolean = False)
        If rdoLogBase10.Checked Then
            ExplanatoryFunction("log10", 1, choice)
        End If
        If rdoNaturallog.Checked Then
            ExplanatoryFunction("log", 1, choice)
        End If
        If rdoSquareroot.Checked Then
            ExplanatoryFunction("sqrt", 1, choice)
        End If
        If rdoPower.Checked Then
            ExplanatoryFunction("power", ucrNudPower.Value, choice)
        End If
    End Sub

End Class