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
    Public clsCurrRFunction As New RFunction
    Private strDatatype As String = ""
    Public lstFunctionParameters As New List(Of RParameter)

    Private Sub ucrDistributions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not bDistributionsSet Then
            CreateDistributions()
        End If
    End Sub

    Public Sub AddParameter(strArgumentName As String, strArgumentValue As String)
        Dim i As Integer
        Dim clsParam As New RParameter
        i = lstFunctionParameters.FindIndex(Function(x) x.strArgumentName.Equals(strArgumentName))
        If i = -1 Then
            clsParam.SetArgumentName(strArgumentName)
            clsParam.SetArgumentValue(strArgumentValue)
            lstFunctionParameters.Add(clsParam)
        Else
            lstFunctionParameters(i).strArgumentValue = strArgumentValue
        End If
    End Sub

    Public Sub IncludeFunctionParameter()
        Dim clsTempOp As ROperator
        For Each clsParam In lstFunctionParameters
            If clsCurrDistribution.strNameTag = "Exponential" And clsParam.strArgumentName = "mean" Then
                clsTempOp = New ROperator
                clsTempOp.SetOperation("/")
                clsTempOp.SetParameter(True, 1)
                clsTempOp.SetParameter(False, clsParam:=clsParam)
                clsCurrRFunction.AddParameter("rate", clsROperatorParameter:=clsTempOp)
            Else
                clsCurrRFunction.AddParameter(clsParam)
            End If
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

    Public Sub SetQDistributions()

        strDistributionType = "QFunctions"
        SetDistributions()

    End Sub

    Public Sub SetDDistributions()

        strDistributionType = "DFunctions"
        SetDistributions()

    End Sub

    Public Sub SetGLMDistributions()

        strDistributionType = "GLMFunctions"
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
                    bUse = (Dist.strQFunctionName <> "")
                Case "DFunctions"
                    bUse = (Dist.strDFunctionName <> "")
                Case "GLMFunctions"
                    If (Dist.strGLMFunctionName <> "") Then
                        Select Case strDatatype
                            Case "numeric"
                                If Dist.bNumeric Then
                                    bUse = True
                                End If
                            Case "positive integer"
                                If Dist.bPositiveInt Then
                                    bUse = True
                                End If
                            Case "two levels factor"
                                If Dist.bTwoLevelFactor Then
                                    bUse = True
                                End If
                        End Select
                    End If
            End Select
            If Dist.bIncluded And bUse Then
                lstCurrentDistributions.Add(Dist)
                cboDistributions.Items.Add(translate(Dist.strNameTag))
            End If
        Next
        If cboDistributions.Items.Count > 0 Then
            cboDistributions.SelectedIndex = 0
        End If
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
        Dim clsVonnMisesDist As New Distribution
        Dim clsCategoricalDist As New Distribution
        Dim clsGamma As New Distribution
        Dim clsGammaWithZerosDist As New Distribution
        Dim clsGammaWithShapeandScale As New Distribution
        Dim clsGammaWithShapeandMean As New Distribution
        Dim clsGammaWithShapeandRate As New Distribution
        Dim clsInverseGaussianDist As New Distribution
        Dim clsQuasiDist As New Distribution
        Dim clsQuasibinomialDist As New Distribution
        Dim clsQuasipoissonDist As New Distribution

        ' Normal distribution
        clsNormalDist.strNameTag = "Normal"
        clsNormalDist.strRFunctionName = "rnorm"
        clsNormalDist.strPFunctionName = "pnorm"
        clsNormalDist.strQFunctionName = "qnorm"
        clsNormalDist.strDFunctionName = "dnorm"
        clsNormalDist.strGLMFunctionName = "gaussian"
        clsNormalDist.bNumeric = True
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
        clsBinomialDist.strGLMFunctionName = "binomial"
        clsBinomialDist.bTwoLevelFactor = True
        clsBinomialDist.AddParameter("number", "Number", 1)
        clsBinomialDist.AddParameter("prob", "Probability", 0.5)
        lstAllDistributions.Add(clsBinomialDist)

        'poisson Distribution
        clsPoissonDist.strNameTag = "Poisson"
        clsPoissonDist.strRFunctionName = "rpois"
        clsPoissonDist.strPFunctionName = "ppois"
        clsPoissonDist.strQFunctionName = "qpois"
        clsPoissonDist.strDFunctionName = "dpois"
        clsPoissonDist.strGLMFunctionName = "poisson"
        clsPoissonDist.bPositiveInt = True
        clsPoissonDist.AddParameter("mean", "Mean", 1)
        lstAllDistributions.Add(clsPoissonDist)

        ' von mises distribution
        clsVonnMisesDist.strNameTag = "von_mises"
        clsVonnMisesDist.strRFunctionName = "rvonmises"
        clsVonnMisesDist.strPFunctionName = "pvonmises"
        clsVonnMisesDist.strQFunctionName = "qvonmises"
        clsVonnMisesDist.strDFunctionName = "dvonmises"
        clsVonnMisesDist.AddParameter("mean", "Mean", "pi")
        clsVonnMisesDist.AddParameter("kappa", "Kappa", 0)
        lstAllDistributions.Add(clsVonnMisesDist)

        'TODO Categorical distribution
        clsCategoricalDist.strNameTag = "Categorical"
        clsCategoricalDist.strRFunctionName = ""
        clsCategoricalDist.strPFunctionName = ""
        clsCategoricalDist.strQFunctionName = ""
        clsCategoricalDist.strDFunctionName = ""
        clsCategoricalDist.AddParameter("", "", "")
        clsCategoricalDist.AddParameter("", "", )
        lstAllDistributions.Add(clsCategoricalDist)

        'Gamma With Shape and Scale distribution
        clsGammaWithShapeandScale.strNameTag = "Gamma_With_Shape_and_Scale"
        clsGammaWithShapeandScale.strRFunctionName = "rgamma"
        clsGammaWithShapeandScale.strPFunctionName = "pgamma"
        clsGammaWithShapeandScale.strQFunctionName = "qgamma"
        clsGammaWithShapeandScale.strDFunctionName = "dgamma"
        clsGammaWithShapeandScale.AddParameter("shape", "Shape")
        clsGammaWithShapeandScale.AddParameter("scale", "Scale")
        lstAllDistributions.Add(clsGammaWithShapeandScale)

        'Gamma With Shape and Mean distribution
        clsGammaWithShapeandMean.strNameTag = "Gamma_With_Shape_and_Mean"
        clsGammaWithShapeandMean.strRFunctionName = "rgamma"
        clsGammaWithShapeandMean.strPFunctionName = "pgamma"
        clsGammaWithShapeandMean.strQFunctionName = "qgamma"
        clsGammaWithShapeandMean.strDFunctionName = "dgamma"
        clsGammaWithShapeandMean.AddParameter("shape", "Shape")
        clsGammaWithShapeandMean.AddParameter("mean", "Mean")
        lstAllDistributions.Add(clsGammaWithShapeandMean)

        'Gamma With Shape and Rate distribution
        clsGammaWithShapeandRate.strNameTag = "Gamma_With_Shape_and_Rate"
        clsGammaWithShapeandRate.strRFunctionName = "rgamma"
        clsGammaWithShapeandRate.strPFunctionName = "pgamma"
        clsGammaWithShapeandRate.strQFunctionName = "qgamma"
        clsGammaWithShapeandRate.strDFunctionName = "dgamma"
        clsGammaWithShapeandRate.AddParameter("shape", "Shape")
        clsGammaWithShapeandRate.AddParameter("rate", "Rate")
        lstAllDistributions.Add(clsGammaWithShapeandRate)

        'Gamma With Shape and Scale distribution
        clsGamma.strNameTag = "Gamma"
        clsGamma.strGLMFunctionName = "Gamma"
        clsGamma.bNumeric = True
        lstAllDistributions.Add(clsGamma)

        'Gamma with Zeros distribution
        'TODO Paramaters 
        clsGammaWithZerosDist.strNameTag = "Gamma_With_Zeros"
        clsGammaWithZerosDist.strRFunctionName = "rgamma"
        clsGammaWithZerosDist.strPFunctionName = "pgamma"
        clsGammaWithZerosDist.strQFunctionName = "qgamma"
        clsGammaWithZerosDist.strDFunctionName = "dgamma"
        clsGammaWithZerosDist.AddParameter("", "", "")
        clsGammaWithZerosDist.AddParameter("", "", )
        lstAllDistributions.Add(clsGammaWithZerosDist)

        'Inverse Gaussian distribution
        clsInverseGaussianDist.strNameTag = "Inverse_Gaussian"
        clsInverseGaussianDist.strGLMFunctionName = "inverse.gaussian"
        clsInverseGaussianDist.bNumeric = True
        lstAllDistributions.Add(clsInverseGaussianDist)

        'Quasi distribution
        clsQuasiDist.strNameTag = "Quasi"
        clsQuasiDist.strGLMFunctionName = "quasi"
        clsQuasiDist.bNumeric = True
        lstAllDistributions.Add(clsQuasiDist)

        'Quasibinomial distribution
        clsQuasibinomialDist.strNameTag = "Quasibinomial"
        clsQuasibinomialDist.strGLMFunctionName = "quasibinomial"
        clsQuasibinomialDist.bTwoLevelFactor = True
        lstAllDistributions.Add(clsQuasibinomialDist)

        'Quasipoisson distribution
        clsQuasipoissonDist.strNameTag = "Quasipoisson"
        clsQuasipoissonDist.strGLMFunctionName = "quasipoisson"
        clsQuasipoissonDist.bPositiveInt = True
        lstAllDistributions.Add(clsQuasipoissonDist)

        bDistributionsSet = True
    End Sub
    Public Event cboDistributionsIndexChanged(sender As Object, e As EventArgs)
    Private Sub cboDistributions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDistributions.SelectedIndexChanged
        clsCurrDistribution = lstCurrentDistributions(cboDistributions.SelectedIndex)
        'TODO why is this in here it's not relavent to the selection.
        Select Case strDistributionType
            Case "RFunctions"
                clsCurrRFunction.SetRCommand(clsCurrDistribution.strRFunctionName)
            Case "PFunctions"
                clsCurrRFunction.SetRCommand(clsCurrDistribution.strPFunctionName)
            Case "DFunctions"
                clsCurrRFunction.SetRCommand(clsCurrDistribution.strDFunctionName)
            Case "QFunctions"
                clsCurrRFunction.SetRCommand(clsCurrDistribution.strQFunctionName)
            Case "GLMFunctions"
                clsCurrRFunction.SetRCommand(clsCurrDistribution.strGLMFunctionName)
        End Select
        RaiseEvent cboDistributionsIndexChanged(sender, e)
    End Sub

    Public Sub RecieverDatatype(DataFrame As String, Column As String)
        strDatatype = frmMain.clsRLink.GetDataType(DataFrame, Column)
        SetDistributions()
    End Sub

End Class