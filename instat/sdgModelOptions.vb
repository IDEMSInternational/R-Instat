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
Public Class sdgModelOptions
    Public clsRToFunction As New RFunction
    Public clsModel1 As New ROperator
    Public bFirstLoad As Boolean = True

    Private Sub sdgModelOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'ResetLinks()
    End Sub

    Private Sub ResetLinks()
        rdoIdentity.Checked = False
        rdoCauchit.Checked = False
        rdocloglog.Checked = False
        rdoInverse.Checked = False
        rdoLog.Checked = False
        rdoLogit.Checked = False
        rdoMuSquaredInverse.Checked = False
        rdoProbit.Checked = False
        rdoSqrt.Checked = False

        rdoIdentity.Enabled = False
        rdoCauchit.Enabled = False
        rdocloglog.Enabled = False
        rdoInverse.Enabled = False
        rdoLog.Enabled = False
        rdoLogit.Enabled = False
        rdoMuSquaredInverse.Enabled = False
        rdoProbit.Enabled = False
        rdoSqrt.Enabled = False
    End Sub

    Public Sub RestrictLink()
        Dim strFamilyName As String
        strFamilyName = dlgRegressionSimple.ucrFamily.clsCurrDistribution.strNameTag
        ResetLinks()
        If strFamilyName = "Normal" Then
            rdoIdentity.Enabled = True
            rdoIdentity.Checked = True
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
        End If
        If strFamilyName = "Binomial" Then
            rdoLogit.Enabled = True
            rdoLogit.Checked = True
            rdoCauchit.Enabled = True
            rdocloglog.Enabled = True
            rdoLog.Enabled = True
            rdoProbit.Enabled = True
        End If
        If strFamilyName = "Gamma" Then
            rdoInverse.Enabled = True
            rdoInverse.Checked = True
            rdoIdentity.Enabled = True
            rdoLog.Enabled = True
        End If
        If strFamilyName = "Poisson" Then
            rdoLog.Enabled = True
            rdoLog.Checked = True
            rdoIdentity.Enabled = True
            rdoSqrt.Enabled = True
        End If
        If strFamilyName = "Inverse.gaussian" Then
            rdoMuSquaredInverse.Enabled = True
            rdoMuSquaredInverse.Checked = True
            rdoIdentity.Enabled = True
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
        End If
        If strFamilyName = "Quasi" Then
            rdoIdentity.Enabled = True
            rdocloglog.Enabled = True
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
            rdoLogit.Enabled = True
            rdoMuSquaredInverse.Enabled = True
            rdoProbit.Enabled = True
            rdoSqrt.Enabled = True
        End If
    End Sub

    Private Function ExplanatoryFunction(strFunctionName As String, strPower As String)
        If strFunctionName = "power" Then
            If strPower = "1" Then
                dlgRegressionSimple.clsModel.SetParameter(False, strValue:=dlgRegressionSimple.ucrExplanatory.GetVariableNames(bWithQuotes:=False))
            Else
                clsModel1.SetOperation("^")
                clsModel1.bBrackets = False
                clsModel1.SetParameter(True, strValue:=dlgRegressionSimple.ucrExplanatory.GetVariableNames(bWithQuotes:=False))
                clsModel1.SetParameter(False, strValue:=strPower)
                dlgRegressionSimple.clsModel.SetParameter(False, clsOp:=clsModel1)
            End If
        Else
            clsRToFunction.SetRCommand(strFunctionName)
            clsRToFunction.AddParameter("x", dlgRegressionSimple.ucrExplanatory.GetVariableNames(bWithQuotes:=False))
            dlgRegressionSimple.clsModel.SetParameter(False, clsRFunc:=clsRToFunction)
        End If
    End Function

    Public Sub ModelFunction()
        If rdoLogBase10.Checked Then
            ExplanatoryFunction("log10", 1)
        End If
        If rdoNaturallog.Checked Then
            ExplanatoryFunction("log", 1)
        End If
        If rdoSquareroot.Checked Then
            ExplanatoryFunction("sqrt", 1)
        End If
        If rdoPower.Checked Then
            ExplanatoryFunction("power", nudPower.Value)
        End If
    End Sub

    Public Function LinkFunction() As String
        RestrictLink()
        'Dim chrModelNames As CharacterVector
        Dim strLinkFunction As String = ""
        If rdoInverse.Checked Then
            strLinkFunction = "inverse"
        End If
        If rdoIdentity.Checked Then
            strLinkFunction = "identity"
        End If
        If rdoLog.Checked Then
            strLinkFunction = "log"
        End If
        If rdoLogit.Checked Then
            strLinkFunction = "logit"
        End If
        If rdoProbit.Checked Then
            strLinkFunction = "probit"
        End If
        If rdoCauchit.Checked Then
            strLinkFunction = "cauchit"
        End If
        If rdocloglog.Checked Then
            strLinkFunction = "cloglog"
        End If
        If rdoSqrt.Checked Then
            strLinkFunction = "sqrt"
        End If
        If rdoMuSquaredInverse.Checked Then
            strLinkFunction = "1/mu^2"
        End If
        Return strLinkFunction
    End Function
End Class