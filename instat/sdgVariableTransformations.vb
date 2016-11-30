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
Imports instat.Translations
Public Class sdgVariableTransformations
    Public clsRCIFunction As RFunction
    Public clsRToFunction As New RFunction
    Public clsRYVariable, clsRXVariable As ucrReceiverSingle
    Public clsRModel, clsRModel1 As ROperator
    Public clsModel0 As New ROperator
    Public bFirstLoad As Boolean = True
    Private Sub sdgVariableTransformations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Public Sub SetDefaults()
        rdoNaturallog.Checked = False
        rdoLogBase10.Checked = False
        rdoSquareroot.Checked = False
        rdoPower.Checked = False
    End Sub

    Public Sub SetRCIFunction(clsNewFunction As RFunction)
        clsRCIFunction = clsNewFunction
    End Sub

    Public Sub SetRModelOperator(clsRModelNew As ROperator)
        clsRModel = clsRModelNew
    End Sub

    Public Sub SetRYVariable(clsRYVariableNew As ucrReceiverSingle)
        clsRYVariable = clsRYVariableNew
    End Sub

    Public Sub SetRXVariable(clsRXVariableNew As ucrReceiverSingle)
        clsRXVariable = clsRXVariableNew
    End Sub

    Private Sub ExplanatoryFunction(strFunctionName As String, strPower As String, Optional choice As Boolean = False)
        If strFunctionName = "power" Then
            If strPower <> "1" Then
                'clsRModel.SetParameter(False, strValue:=clsRYVariable.GetVariableNames(bWithQuotes:=False))
                clsModel0.SetOperation("^")
                clsModel0.bBrackets = False
                clsModel0.SetParameter(True, strValue:=clsRXVariable.GetVariableNames(bWithQuotes:=False))
                clsModel0.SetParameter(False, strValue:=strPower)
                clsRModel.SetParameter(choice, clsOp:=clsModel0.Clone())
            End If
        Else
            clsRToFunction.SetRCommand(strFunctionName)
            clsRToFunction.AddParameter("x", clsRXVariable.GetVariableNames(bWithQuotes:=False))
            clsRModel.SetParameter(choice, clsRFunc:=clsRToFunction.Clone())
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
            ExplanatoryFunction("power", nudPower.Value, choice)
        End If
    End Sub
End Class