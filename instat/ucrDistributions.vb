﻿' Instat+R
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
Imports instat.RSyntax

Public Class ucrDistributions
    Public lstAllDistributions As New List(Of Distribution)
    Public lstCurrentDistributions As New List(Of Distribution)
    Public strDistributionType As String = ""
    Public clsCurrDistribution As New Distribution
    Public bDistributionsSet As Boolean = False
    Public clsRSyntax As New RSyntax
    Public clsCurrRFunction As New RFunction
    Public lstFunctionParameters As New List(Of RParameter)

    Private Sub ucrDistributions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not bDistributionsSet Then
            CreateDistributions()
        End If
    End Sub

    Public Sub AddParameter(strArgumentName As String, strArgumentValue As String)
        Dim i As Integer
        clsRSyntax.AddParameter(strArgumentName, strArgumentValue, clsRFunction:=clsCurrRFunction)
        i = lstFunctionParameters.FindIndex(Function(x) x.strArgumentName.Equals(strArgumentName))
        If i = -1 Then
            lstFunctionParameters.Add(clsCurrRFunction.clsParameters.Last)
        Else
            lstFunctionParameters(i).strArgumentValue = strArgumentValue
        End If
    End Sub

    Public Sub IncludeFunctionParameter()
        For Each clsParam In lstFunctionParameters
            clsCurrRFunction.AddParameter(clsParam)
        Next
    End Sub

    Public Sub SetRDistributions()

        strDistributionType = "RFunctions"
        SetDistributions()

    End Sub

    Public Sub SetPDistributions()

        strDistributionType = "PFunctions"
        SetDistributions()

    End Sub

    Private Sub SetDistributions()

        Dim bUse As Boolean

        lstCurrentDistributions.Clear()
        cboDistributions.Items.Clear()
        For Each Dist In lstAllDistributions
            bUse = False
            Select Case strDistributionType
                Case "RFunctions"
                    bUse = (Dist.strRFunctionName <> "")
                Case "PFunctions"
                    bUse = (Dist.strPFunctionName <> "")
                Case "QFunctions"
                Case "DFunctions"
                Case "GLMFunctions"
            End Select
            If Dist.bIncluded And bUse Then
                lstCurrentDistributions.Add(Dist)
                cboDistributions.Items.Add(translate(Dist.strNameTag))
            End If
        Next
        cboDistributions.SelectedIndex = 0

    End Sub

    Public Sub CreateDistributions()
        Dim clsNormalDist As New Distribution
        Dim clsExponentialDist As New Distribution
        Dim clsGeometricDist As New Distribution
        Dim clsExtremeValueDist As New Distribution
        Dim clsWeibullDist As New Distribution
        Dim clsUniformDist As New Distribution
        Dim clsBernouliDist As New Distribution
        Dim clsBinomialDist As New Distribution
        Dim clsPoissonDist As New Distribution

        ' Normal distribution
        clsNormalDist.strNameTag = "Normal"
        clsNormalDist.strRFunctionName = "rnorm"
        clsNormalDist.strPFunctionName = "pnorm"
        clsNormalDist.strQFunctionName = "qnorm"
        clsNormalDist.strDFunctionName = "dnorm"
        clsNormalDist.strGLMFunctionName = "gausian"
        clsNormalDist.AddParameter("mean", "Mean", 0)
        clsNormalDist.AddParameter("sd", "Standard_deviation", 1)
        lstAllDistributions.Add(clsNormalDist)

        ' Exponential Distribution
        clsExponentialDist.strNameTag = "Exponential"
        clsExponentialDist.strRFunctionName = "rexp"
        clsExponentialDist.strPFunctionName = "pexp"
        clsExponentialDist.strQFunctionName = "qexp"
        clsExponentialDist.strDFunctionName = "dexp"
        clsExponentialDist.AddParameter("mean", "Mean", 1)
        lstAllDistributions.Add(clsExponentialDist)

        ' Geometric Distribution
        clsGeometricDist.strNameTag = "Geometric"
        clsGeometricDist.strRFunctionName = "rgeom"
        clsGeometricDist.strPFunctionName = "pgeom"
        clsGeometricDist.strQFunctionName = "qgeom"
        clsGeometricDist.strDFunctionName = "dgeom"
        clsGeometricDist.AddParameter("prob", "Probability", 0.5)
        lstAllDistributions.Add(clsGeometricDist)

        ' Extreme Value Distribution
        clsExtremeValueDist.strNameTag = "Extreme_Value"
        clsExtremeValueDist.strRFunctionName = "rgev"
        clsExtremeValueDist.strPFunctionName = "pgev"
        clsExtremeValueDist.strQFunctionName = "qgev"
        clsExtremeValueDist.strDFunctionName = "dgev"
        clsExtremeValueDist.AddParameter("mode", "Mode")
        clsExtremeValueDist.AddParameter("scale", "Scale")
        lstAllDistributions.Add(clsExtremeValueDist)

        ' Weibull Distribution
        clsWeibullDist.strNameTag = "Weibull"
        clsWeibullDist.strRFunctionName = "rweibull"
        clsWeibullDist.strPFunctionName = "pweibull"
        clsWeibullDist.strQFunctionName = "qweibull"
        clsWeibullDist.strDFunctionName = "dweibull"
        clsWeibullDist.AddParameter("shape", "Shape")
        clsWeibullDist.AddParameter("scale", "Scale", 1)
        lstAllDistributions.Add(clsWeibullDist)

        'Uniform Distribution
        clsUniformDist.strNameTag = "Uniform"
        clsUniformDist.strRFunctionName = "runif"
        clsUniformDist.strPFunctionName = "punif"
        clsUniformDist.strQFunctionName = "qunif"
        clsUniformDist.strDFunctionName = "dunif"
        clsUniformDist.AddParameter("a", "a", 0)
        clsUniformDist.AddParameter("b", "b", 1)
        lstAllDistributions.Add(clsUniformDist)


        'Bernouli Distribution
        clsBernouliDist.strNameTag = "Bernouli"
        clsBernouliDist.strRFunctionName = "rbern"
        clsBernouliDist.strPFunctionName = "pbern"
        clsBernouliDist.strQFunctionName = "qbern"
        clsBernouliDist.strDFunctionName = "dbern"
        clsBernouliDist.AddParameter("prob", "Probability", 0.5)
        lstAllDistributions.Add(clsBernouliDist)

        'Binomial Distribution
        clsBinomialDist.strNameTag = "Binomial"
        clsBinomialDist.strRFunctionName = "rbinom"
        clsBinomialDist.strPFunctionName = "pbinom"
        clsBinomialDist.strQFunctionName = "qbinom"
        clsBinomialDist.strDFunctionName = "dbinom"
        clsBinomialDist.AddParameter("number", "Number", 1)
        clsBinomialDist.AddParameter("prob", "Probability", 0.5)
        lstAllDistributions.Add(clsBinomialDist)

        'poisson Distribution
        clsPoissonDist.strNameTag = "Poisson"
        clsPoissonDist.strRFunctionName = "rpois"
        clsPoissonDist.strPFunctionName = "ppois"
        clsPoissonDist.strQFunctionName = "qpois"
        clsPoissonDist.strDFunctionName = "dpois"
        clsPoissonDist.AddParameter("mean", "Mean", 1)
        lstAllDistributions.Add(clsPoissonDist)

        bDistributionsSet = True
    End Sub
    Public Event cboDistributionsIndexChanged(sender As Object, e As EventArgs)
    Private Sub cboDistributions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDistributions.SelectedIndexChanged
        clsCurrDistribution = lstCurrentDistributions(cboDistributions.SelectedIndex)
        Select Case strDistributionType
            Case "RFunctions"
                clsRSyntax.SetFunction(clsCurrDistribution.strRFunctionName, clsCurrRFunction)
            Case "PFunctions"
                clsRSyntax.SetFunction(clsCurrDistribution.strPFunctionName, clsCurrRFunction)
            Case "DFunctions"
                clsRSyntax.SetFunction(clsCurrDistribution.strDFunctionName, clsCurrRFunction)
            Case "QFunctions"
                clsRSyntax.SetFunction(clsCurrDistribution.strQFunctionName, clsCurrRFunction)
            Case "GLMFunctions"
                clsRSyntax.SetFunction(clsCurrDistribution.strGLMFunctionName, clsCurrRFunction)
        End Select
        RaiseEvent cboDistributionsIndexChanged(sender, e)
    End Sub
End Class