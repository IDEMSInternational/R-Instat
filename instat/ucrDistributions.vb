' Instat+R
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
    Public lstAllDistributions As List(Of Distribution)
    Public lstCurrentDistributions As List(Of Distribution)
    Public strDistributionType As String
    Public clsCurrDistribution As Distribution
    Public bDistributionsSet As Boolean
    Public clsCurrRFunction As RFunction
    Public strDataType As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lstAllDistributions = New List(Of Distribution)
        lstCurrentDistributions = New List(Of Distribution)
        strDistributionType = ""
        clsCurrDistribution = New Distribution
        bDistributionsSet = False
        clsCurrRFunction = New RFunction
        strDataType = ""
        CreateDistributions()
    End Sub

    Private Sub ucrDistributions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDistributions()
    End Sub

    Public Sub AddParameter(strArgumentName As String, strArgumentValue As String)
        Dim clsTempOp As ROperator
        Dim i As Integer

        clsTempOp = New ROperator
        clsTempOp.SetOperation("/")

        If clsCurrDistribution.strNameTag = "Exponential" AndAlso strArgumentName = "mean" Then
            clsTempOp.SetParameter(True, strValue:=1)
            clsTempOp.SetParameter(False, strValue:=strArgumentValue)
            clsCurrRFunction.AddParameter("rate", clsROperatorParameter:=clsTempOp)
        ElseIf clsCurrDistribution.strNameTag = "Gamma_With_Shape_and_Mean" AndAlso (strArgumentName = "shape" OrElse strArgumentName = "mean") Then
            If strArgumentName = "shape" Then
                clsCurrRFunction.AddParameter(strArgumentName, strArgumentValue)
                i = clsCurrRFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "mean")
                If i <> -1 Then
                    clsTempOp.SetParameter(True, strValue:=clsCurrRFunction.clsParameters(i).strArgumentValue)
                    clsTempOp.SetParameter(False, strValue:=strArgumentValue)
                    clsCurrRFunction.AddParameter("scale", clsROperatorParameter:=clsTempOp)
                    clsCurrRFunction.RemoveParameterByName("mean")
                End If
            ElseIf strArgumentName = "mean" Then
                i = clsCurrRFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "shape")
                If i = -1 Then
                    clsCurrRFunction.AddParameter(strArgumentName, strArgumentValue)
                Else
                    clsTempOp.SetParameter(True, strValue:=strArgumentValue)
                    clsTempOp.SetParameter(False, strValue:=clsCurrRFunction.clsParameters(i).strArgumentValue)
                    clsCurrRFunction.AddParameter("scale", clsROperatorParameter:=clsTempOp)
                End If
            End If
        Else
            clsCurrRFunction.AddParameter(strArgumentName, strArgumentValue)
        End If

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
                        Select Case strDataType
                            Case "numeric"
                                If Dist.bNumeric Then
                                    bUse = True
                                End If
                            Case "positive integer"
                                If Dist.bPositiveInt Then
                                    bUse = True
                                End If
                            Case "two level factor"
                                If Dist.bTwoLevelFactor Then
                                    bUse = True
                                End If
                        End Select
                    End If
                Case Else
                    bUse = True
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
        clsNormalDist.strRName = "norm"
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
        clsExponentialDist.strRName = "exp"
        clsExponentialDist.strRFunctionName = "rexp"
        clsExponentialDist.strPFunctionName = "pexp"
        clsExponentialDist.strQFunctionName = "qexp"
        clsExponentialDist.strDFunctionName = "dexp"
        clsExponentialDist.AddParameter("mean", "Mean", 1)
        lstAllDistributions.Add(clsExponentialDist)

        ' Geometric Distribution
        clsGeometricDist.strNameTag = "Geometric"
        clsGeometricDist.strRName = "geom"
        clsGeometricDist.strRFunctionName = "rgeom"
        clsGeometricDist.strPFunctionName = "pgeom"
        clsGeometricDist.strQFunctionName = "qgeom"
        clsGeometricDist.strDFunctionName = "dgeom"
        clsGeometricDist.AddParameter("prob", "Probability", 0.5)
        lstAllDistributions.Add(clsGeometricDist)

        ' Extreme Value Distribution
        clsExtremeValueDist.strNameTag = "Extreme_Value"
        clsExtremeValueDist.strRName = "evd"
        clsExtremeValueDist.strRFunctionName = "revd"
        clsExtremeValueDist.strPFunctionName = "pevd"
        clsExtremeValueDist.strQFunctionName = "qqevd"
        clsExtremeValueDist.strDFunctionName = "devd"
        clsExtremeValueDist.AddParameter("shape", "Shape", 0)
        clsExtremeValueDist.AddParameter("scale", "Scale", 1)
        clsExtremeValueDist.AddParameter("loc", "Location", 0)
        lstAllDistributions.Add(clsExtremeValueDist)

        ' Weibull Distribution
        clsWeibullDist.strNameTag = "Weibull"
        clsWeibullDist.strRName = "weibull"
        clsWeibullDist.strRFunctionName = "rweibull"
        clsWeibullDist.strPFunctionName = "pweibull"
        clsWeibullDist.strQFunctionName = "qweibull"
        clsWeibullDist.strDFunctionName = "dweibull"
        clsWeibullDist.AddParameter("shape", "Shape")
        clsWeibullDist.AddParameter("scale", "Scale", 1)
        lstAllDistributions.Add(clsWeibullDist)

        'Uniform Distribution
        clsUniformDist.strNameTag = "Uniform"
        clsUniformDist.strRName = "unif"
        clsUniformDist.strRFunctionName = "runif"
        clsUniformDist.strPFunctionName = "punif"
        clsUniformDist.strQFunctionName = "qunif"
        clsUniformDist.strDFunctionName = "dunif"
        clsUniformDist.AddParameter("min", "Minimum", 0)
        clsUniformDist.AddParameter("max", "Maximum", 1)
        lstAllDistributions.Add(clsUniformDist)

        'Bernouli Distribution
        clsBernouliDist.strNameTag = "Bernouli"
        clsBernouliDist.strRName = "binom"
        clsBernouliDist.strRFunctionName = "rbinom"
        clsBernouliDist.strPFunctionName = "pbinom"
        clsBernouliDist.strQFunctionName = "qbinom"
        clsBernouliDist.strDFunctionName = "dbinom"
        clsBernouliDist.AddParameter("prob", "Probability", 0.5)
        lstAllDistributions.Add(clsBernouliDist)

        'Binomial Distribution
        clsBinomialDist.strNameTag = "Binomial"
        clsBinomialDist.strRName = "binom"
        clsBinomialDist.strRFunctionName = "rbinom"
        clsBinomialDist.strPFunctionName = "pbinom"
        clsBinomialDist.strQFunctionName = "qbinom"
        clsBinomialDist.strDFunctionName = "dbinom"
        clsBinomialDist.strGLMFunctionName = "binomial"
        clsBinomialDist.bTwoLevelFactor = True
        clsBinomialDist.AddParameter("size", "Number", 1)
        clsBinomialDist.AddParameter("prob", "Probability", 0.5)
        lstAllDistributions.Add(clsBinomialDist)

        'poisson Distribution
        clsPoissonDist.strNameTag = "Poisson"
        clsPoissonDist.strRName = "pois"
        clsPoissonDist.strRFunctionName = "rpois"
        clsPoissonDist.strPFunctionName = "ppois"
        clsPoissonDist.strQFunctionName = "qpois"
        clsPoissonDist.strDFunctionName = "dpois"
        clsPoissonDist.strGLMFunctionName = "poisson"
        clsPoissonDist.bPositiveInt = True
        clsPoissonDist.AddParameter("lambda", "Mean", 1)
        lstAllDistributions.Add(clsPoissonDist)

        ' von mises distribution
        clsVonnMisesDist.strNameTag = "von_mises"
        clsVonnMisesDist.strRName = "vonmises"
        clsVonnMisesDist.strRFunctionName = "rvonmises"
        clsVonnMisesDist.strPFunctionName = "pvonmises"
        clsVonnMisesDist.strQFunctionName = "qvonmises"
        clsVonnMisesDist.strDFunctionName = "dvonmises"
        clsVonnMisesDist.AddParameter("mu", "Mean", "pi")
        clsVonnMisesDist.AddParameter("kappa", "Kappa", 0)
        lstAllDistributions.Add(clsVonnMisesDist)

        'TODO Categorical distribution
        clsCategoricalDist.strNameTag = "Categorical"
        clsCategoricalDist.strRName = ""
        clsCategoricalDist.strRFunctionName = ""
        clsCategoricalDist.strPFunctionName = ""
        clsCategoricalDist.strQFunctionName = ""
        clsCategoricalDist.strDFunctionName = ""
        clsCategoricalDist.AddParameter("", "", "")
        clsCategoricalDist.AddParameter("", "", )
        lstAllDistributions.Add(clsCategoricalDist)

        'Gamma With Shape and Scale distribution
        clsGammaWithShapeandScale.strNameTag = "Gamma_With_Shape_and_Scale"
        clsGammaWithShapeandScale.strRName = "gamma"
        clsGammaWithShapeandScale.strRFunctionName = "rgamma"
        clsGammaWithShapeandScale.strPFunctionName = "pgamma"
        clsGammaWithShapeandScale.strQFunctionName = "qgamma"
        clsGammaWithShapeandScale.strDFunctionName = "dgamma"
        clsGammaWithShapeandScale.AddParameter("shape", "Shape")
        clsGammaWithShapeandScale.AddParameter("scale", "Scale")
        lstAllDistributions.Add(clsGammaWithShapeandScale)

        'Gamma With Shape and Mean distribution
        clsGammaWithShapeandMean.strNameTag = "Gamma_With_Shape_and_Mean"
        clsGammaWithShapeandMean.strRName = "gamma"
        clsGammaWithShapeandMean.strRFunctionName = "rgamma"
        clsGammaWithShapeandMean.strPFunctionName = "pgamma"
        clsGammaWithShapeandMean.strQFunctionName = "qgamma"
        clsGammaWithShapeandMean.strDFunctionName = "dgamma"
        clsGammaWithShapeandMean.AddParameter("shape", "Shape")
        clsGammaWithShapeandMean.AddParameter("mean", "Mean")
        lstAllDistributions.Add(clsGammaWithShapeandMean)

        'Gamma With Shape and Rate distribution
        clsGammaWithShapeandRate.strNameTag = "Gamma_With_Shape_and_Rate"
        clsGammaWithShapeandRate.strRName = "gamma"
        clsGammaWithShapeandRate.strRFunctionName = "rgamma"
        clsGammaWithShapeandRate.strPFunctionName = "pgamma"
        clsGammaWithShapeandRate.strQFunctionName = "qgamma"
        clsGammaWithShapeandRate.strDFunctionName = "dgamma"
        clsGammaWithShapeandRate.AddParameter("shape", "Shape")
        clsGammaWithShapeandRate.AddParameter("rate", "Rate")
        lstAllDistributions.Add(clsGammaWithShapeandRate)

        'Gamma With Shape and Scale distribution
        clsGamma.strNameTag = "Gamma"
        clsGamma.strRName = "gamma"
        clsGamma.strGLMFunctionName = "Gamma"
        clsGamma.bNumeric = True
        lstAllDistributions.Add(clsGamma)

        'Gamma with Zeros distribution
        'TODO Paramaters 
        clsGammaWithZerosDist.strNameTag = "Gamma_With_Zeros"
        clsGammaWithZerosDist.strRName = "gamma"
        clsGammaWithZerosDist.strRFunctionName = "rgamma"
        clsGammaWithZerosDist.strPFunctionName = "pgamma"
        clsGammaWithZerosDist.strQFunctionName = "qgamma"
        clsGammaWithZerosDist.strDFunctionName = "dgamma"
        clsGammaWithZerosDist.AddParameter("", "", "")
        clsGammaWithZerosDist.AddParameter("", "", )
        lstAllDistributions.Add(clsGammaWithZerosDist)

        'Inverse Gaussian distribution
        clsInverseGaussianDist.strNameTag = "Inverse_Gaussian"
        clsInverseGaussianDist.strRName = "inverse.gaussian"
        clsInverseGaussianDist.strGLMFunctionName = "inverse.gaussian"
        clsInverseGaussianDist.bNumeric = True
        lstAllDistributions.Add(clsInverseGaussianDist)

        'Quasi distribution
        clsQuasiDist.strNameTag = "Quasi"
        clsQuasiDist.strRName = "quasi"
        clsQuasiDist.strGLMFunctionName = "quasi"
        clsQuasiDist.bNumeric = True
        lstAllDistributions.Add(clsQuasiDist)

        'Quasibinomial distribution
        clsQuasibinomialDist.strNameTag = "Quasibinomial"
        clsQuasibinomialDist.strRName = "quasibinomial"
        clsQuasibinomialDist.strGLMFunctionName = "quasibinomial"
        clsQuasibinomialDist.bTwoLevelFactor = True
        lstAllDistributions.Add(clsQuasibinomialDist)

        'Quasipoisson distribution
        clsQuasipoissonDist.strNameTag = "Quasipoisson"
        clsQuasipoissonDist.strRName = "quasipoisson"
        clsQuasipoissonDist.strGLMFunctionName = "quasipoisson"
        clsQuasipoissonDist.bPositiveInt = True
        lstAllDistributions.Add(clsQuasipoissonDist)

        bDistributionsSet = True
    End Sub
    Public Event cboDistributionsIndexChanged(sender As Object, e As EventArgs)
    Private Sub cboDistributions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDistributions.SelectedIndexChanged
        clsCurrDistribution = lstCurrentDistributions(cboDistributions.SelectedIndex)
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
        strDataType = frmMain.clsRLink.GetDataType(DataFrame, Column)
        SetDistributions()
    End Sub

    Public Sub RecieverDatatype(strNewType As String)
        strDataType = strNewType
        SetDistributions()
    End Sub
End Class