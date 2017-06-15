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
    Public bFirstLoad As Boolean
    Private bParameterIsDistFunction As Boolean = False
    Private bFunctionIsDistFunction As Boolean = False
    Private bParameterIsDistName As Boolean = False

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
        bFirstLoad = True
    End Sub

    Private Sub ucrDistributions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDistributions()
            ucrInputDistributions.SetDropDownStyleAsNonEditable()
            bFirstLoad = False
        End If
    End Sub

    Public Sub AddParameter(strArgumentName As String, strArgumentValue As String)
        Dim clsTempOp As ROperator
        Dim i As Integer

        clsTempOp = New ROperator
        clsTempOp.SetOperation("/")

        If clsCurrDistribution.strNameTag = "Exponential" AndAlso strArgumentName = "mean" Then
            clsTempOp.AddParameter(iPosition:=0, strParameterValue:=1)
            clsTempOp.AddParameter(strParameterValue:=strArgumentValue)
            clsCurrRFunction.AddParameter("rate", clsROperatorParameter:=clsTempOp)
        ElseIf clsCurrDistribution.strNameTag = "Gamma_With_Shape_and_Mean" AndAlso (strArgumentName = "shape" OrElse strArgumentName = "mean") Then
            If strArgumentName = "shape" Then
                clsCurrRFunction.AddParameter(strArgumentName, strArgumentValue)
                i = clsCurrRFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "mean")
                If i <> -1 Then
                    clsTempOp.AddParameter(iPosition:=0, strParameterValue:=clsCurrRFunction.clsParameters(i).strArgumentValue)
                    clsTempOp.AddParameter(strParameterValue:=strArgumentValue)
                    clsCurrRFunction.AddParameter("scale", clsROperatorParameter:=clsTempOp)
                    clsCurrRFunction.RemoveParameterByName("mean")
                End If
            ElseIf strArgumentName = "mean" Then
                i = clsCurrRFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "shape")
                If i = -1 Then
                    clsCurrRFunction.AddParameter(strArgumentName, strArgumentValue)
                Else
                    clsTempOp.AddParameter(iPosition:=0, strParameterValue:=strArgumentValue)
                    clsTempOp.AddParameter(strParameterValue:=clsCurrRFunction.clsParameters(i).strArgumentValue)
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

    Public Sub SetExactDistributions()  ' this addition is temporary
        strDistributionType = "ExactSolution"
        SetDistributions()
    End Sub

    Public Sub SetAllDistributions()
        strDistributionType = ""
        SetDistributions()
    End Sub

    Public Sub SetDistributions()
        Dim bUse As Boolean
        lstCurrentDistributions.Clear()
        ucrInputDistributions.SetItems()

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
                Case "ExactSolution"
                    bUse = (Dist.strExactName <> "")
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
                    If Dist.strRName <> "" Then
                        bUse = True
                    End If
            End Select
            If Dist.bIncluded And bUse Then
                lstCurrentDistributions.Add(Dist)
                ucrInputDistributions.AddItems({translate(Dist.strNameTag)})
            End If
        Next
        If ucrInputDistributions.cboInput.Items.Count > 0 Then
            ucrInputDistributions.cboInput.SelectedIndex = 0
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
        Dim clsBetaDist As New Distribution
        Dim clsNegBinomDist As New Distribution
        Dim clsStudentsTDist As New Distribution
        Dim clsCauchyDist As New Distribution
        Dim clsChiSqDist As New Distribution
        Dim clsFDist As New Distribution
        Dim clsHyperGeoDist As New Distribution
        Dim clsLogNormDist As New Distribution
        Dim clsNoDist As New Distribution

        ' Normal distribution
        clsNormalDist.strNameTag = "Normal"
        clsNormalDist.strRName = "norm"
        clsNormalDist.strRFunctionName = "rnorm"
        clsNormalDist.strPFunctionName = "pnorm"
        clsNormalDist.strQFunctionName = "qnorm"
        clsNormalDist.strDFunctionName = "dnorm"
        clsNormalDist.strGLMFunctionName = "gaussian"
        clsNormalDist.bNumeric = True
        clsNormalDist.bIsContinuous = True
        clsNormalDist.bIsExact = True
        clsNormalDist.strExactName = "norm"
        clsNormalDist.lstExact = {"mean", "Difference in Means:", 0, 1, 2, Integer.MinValue, Integer.MaxValue}
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
        clsExponentialDist.bIsContinuous = True
        clsExponentialDist.AddParameter("mean", "Mean", 1)
        lstAllDistributions.Add(clsExponentialDist)

        ' Geometric Distribution
        clsGeometricDist.strNameTag = "Geometric"
        clsGeometricDist.strRName = "geom"
        clsGeometricDist.strRFunctionName = "rgeom"
        clsGeometricDist.strPFunctionName = "pgeom"
        clsGeometricDist.strQFunctionName = "qgeom"
        clsGeometricDist.strDFunctionName = "dgeom"
        clsGeometricDist.bIsContinuous = False
        clsGeometricDist.AddParameter("prob", "Probability", 0.5)
        lstAllDistributions.Add(clsGeometricDist)

        ' Extreme Value Distribution
        clsExtremeValueDist.strNameTag = "Extreme_Value"
        clsExtremeValueDist.strRName = "evd"
        clsExtremeValueDist.strPackagName = "extRemes"
        clsExtremeValueDist.strRFunctionName = "revd"
        clsExtremeValueDist.strPFunctionName = "pevd"
        clsExtremeValueDist.strQFunctionName = "qqevd"
        clsExtremeValueDist.strDFunctionName = "devd"
        clsExtremeValueDist.bIsContinuous = True
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
        clsWeibullDist.bIsContinuous = True
        clsWeibullDist.AddParameter("shape", "Shape", 1)
        clsWeibullDist.AddParameter("scale", "Scale", 1)
        lstAllDistributions.Add(clsWeibullDist)

        'Uniform Distribution
        clsUniformDist.strNameTag = "Uniform"
        clsUniformDist.strRName = "unif"
        clsUniformDist.strRFunctionName = "runif"
        clsUniformDist.strPFunctionName = "punif"
        clsUniformDist.strQFunctionName = "qunif"
        clsUniformDist.strDFunctionName = "dunif"
        'clsUniformDist.bIsContinuous = True
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
        clsBernouliDist.bIsContinuous = False
        clsBernouliDist.bIsExact = True
        clsBernouliDist.bTwoLevelFactor = True
        clsBernouliDist.strExactName = "binom"
        clsBernouliDist.lstExact = {"prob", "Probability:", 0.5, 0.1, 2, 0, 1}
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
        clsBinomialDist.bIsContinuous = False
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
        clsPoissonDist.bIsContinuous = False
        clsPoissonDist.bIsExact = True
        clsPoissonDist.strExactName = "pois"
        clsPoissonDist.lstExact = {"r", "Rate Ratio:", 1, 1, 2, 0, Integer.MaxValue}
        clsPoissonDist.AddParameter("lambda", "Mean", 1)
        lstAllDistributions.Add(clsPoissonDist)

        'Beta Distribution
        clsBetaDist.strNameTag = "Beta"
        clsBetaDist.strRName = "beta"
        clsBetaDist.strRFunctionName = "rbeta"
        clsBetaDist.strPFunctionName = "pbeta"
        clsBetaDist.strQFunctionName = "qbeta"
        clsBetaDist.strDFunctionName = "dbeta"
        clsBetaDist.bIsContinuous = True
        clsBetaDist.AddParameter("shape1", "Shape1", 1)
        clsBetaDist.AddParameter("shape2", "Shape2", 1)
        lstAllDistributions.Add(clsBetaDist)

        'Negative Binomial Distribution
        clsNegBinomDist.strNameTag = "Negative_Binomial"
        clsNegBinomDist.strRName = "nbinom"
        clsNegBinomDist.strRFunctionName = "rnbinom"
        clsNegBinomDist.strPFunctionName = "pnbinom"
        clsNegBinomDist.strQFunctionName = "qnbinom"
        clsNegBinomDist.strDFunctionName = "dnbinom"
        clsNegBinomDist.bIsContinuous = False
        clsNegBinomDist.AddParameter("size", "Number", 1)
        clsNegBinomDist.AddParameter("prob", "Probability", 0.5)
        lstAllDistributions.Add(clsNegBinomDist)

        'T Distribution
        clsStudentsTDist.strNameTag = "Students_t"
        clsStudentsTDist.strRName = "t"
        clsStudentsTDist.strRFunctionName = "rt"
        clsStudentsTDist.strPFunctionName = "pt"
        clsStudentsTDist.strQFunctionName = "qt"
        clsStudentsTDist.strDFunctionName = "dt"
        clsStudentsTDist.AddParameter("df", "DF", 1)
        lstAllDistributions.Add(clsStudentsTDist)

        ' von mises distribution
        clsVonnMisesDist.strNameTag = "von_mises"
        clsVonnMisesDist.strRName = "vonmises"
        clsVonnMisesDist.strRFunctionName = "rvonmises"
        clsVonnMisesDist.strPFunctionName = "pvonmises"
        clsVonnMisesDist.strQFunctionName = "qvonmises"
        clsVonnMisesDist.strDFunctionName = "dvonmises"
        clsVonnMisesDist.bIsContinuous = True
        clsVonnMisesDist.AddParameter("mu", "Mean", "pi")
        clsVonnMisesDist.AddParameter("kappa", "Kappa", 0)
        lstAllDistributions.Add(clsVonnMisesDist)

        ' Cauchy Distribution
        clsCauchyDist.strNameTag = "Cauchy"
        clsCauchyDist.strRName = "cauchy"
        clsCauchyDist.strRFunctionName = "rcauchy"
        clsCauchyDist.strPFunctionName = "pcauchy"
        clsCauchyDist.strQFunctionName = "qcauchy"
        clsCauchyDist.strDFunctionName = "dcauchy"
        clsCauchyDist.bIsContinuous = True
        clsCauchyDist.AddParameter("location", "Location", 0)
        clsCauchyDist.AddParameter("scale", "Scale", 1)
        lstAllDistributions.Add(clsCauchyDist)

        ' Chi-Square Distribution
        clsChiSqDist.strNameTag = "Chi_Square"
        clsChiSqDist.strRName = "chisq"
        clsChiSqDist.strRFunctionName = "rchisq"
        clsChiSqDist.strPFunctionName = "pchisq"
        clsChiSqDist.strQFunctionName = "qchisq"
        clsChiSqDist.strDFunctionName = "dchisq"
        clsChiSqDist.bIsContinuous = True
        clsChiSqDist.AddParameter("df", "DF", 1)
        lstAllDistributions.Add(clsChiSqDist)

        ' F Distribution
        clsFDist.strNameTag = "F"
        clsFDist.strRName = "f"
        clsFDist.strRFunctionName = "rf"
        clsFDist.strPFunctionName = "pf"
        clsFDist.strQFunctionName = "qf"
        clsFDist.strDFunctionName = "df"
        clsFDist.AddParameter("df1", "DF1", 1)
        clsFDist.AddParameter("df2", "DF2", 1)
        lstAllDistributions.Add(clsFDist)

        'Hypergeometric Distribution
        ' For rhyper, the parameters are nn = size, whereas for the other parameters this is n.
        clsHyperGeoDist.strNameTag = "Hypergeometric"
        clsHyperGeoDist.strRName = "hyper"
        clsHyperGeoDist.strRFunctionName = "rhyper"
        clsHyperGeoDist.strPFunctionName = "phyper"
        clsHyperGeoDist.strQFunctionName = "qhyper"
        clsHyperGeoDist.strDFunctionName = "dhyper"
        clsHyperGeoDist.bIsContinuous = False
        clsHyperGeoDist.AddParameter("m", "Population_Successes", 10)
        clsHyperGeoDist.AddParameter("n", "Population_Failures", 10)
        clsHyperGeoDist.AddParameter("k", "Sample_Size", 10)
        lstAllDistributions.Add(clsHyperGeoDist)

        ' Lognormal Distribution
        clsLogNormDist.strNameTag = "Lognormal"
        clsLogNormDist.strRName = "lnorm"
        clsLogNormDist.strRFunctionName = "rlnorm"
        clsLogNormDist.strPFunctionName = "plnorm"
        clsLogNormDist.strQFunctionName = "qlnorm"
        clsLogNormDist.strDFunctionName = "dlnorm"
        clsLogNormDist.AddParameter("meanlog", "Meanlog", 0)
        clsLogNormDist.AddParameter("sdlog", "SDlog", 1)
        lstAllDistributions.Add(clsLogNormDist)

        'TODO Categorical distribution
        clsCategoricalDist.strNameTag = "Categorical"
        clsCategoricalDist.strRName = ""
        clsCategoricalDist.strRFunctionName = ""
        clsCategoricalDist.strPFunctionName = ""
        clsCategoricalDist.strQFunctionName = ""
        clsCategoricalDist.strDFunctionName = ""
        clsCategoricalDist.bIsContinuous = False
        clsCategoricalDist.AddParameter("", "", "")
        clsCategoricalDist.AddParameter("", "", )
        lstAllDistributions.Add(clsCategoricalDist)

        'Gamma With Shape and Scale distribution
        clsGammaWithShapeandScale.strNameTag = "Gamma_With_Shape_and_Scale"
        clsGammaWithShapeandScale.strRName = "gamma"
        clsGammaWithShapeandScale.strPackagName = "stats"
        clsGammaWithShapeandScale.strRFunctionName = "rgamma"
        clsGammaWithShapeandScale.strPFunctionName = "pgamma"
        clsGammaWithShapeandScale.strQFunctionName = "qgamma"
        clsGammaWithShapeandScale.strDFunctionName = "dgamma"
        clsGammaWithShapeandScale.bIsContinuous = True
        clsGammaWithShapeandScale.AddParameter("shape", "Shape", "1")
        clsGammaWithShapeandScale.AddParameter("scale", "Scale")
        lstAllDistributions.Add(clsGammaWithShapeandScale)

        'Gamma With Shape and Mean distribution
        clsGammaWithShapeandMean.strNameTag = "Gamma_With_Shape_and_Mean"
        clsGammaWithShapeandMean.strRName = "gamma"
        clsGammaWithShapeandMean.strPackagName = "stats"
        clsGammaWithShapeandMean.strRFunctionName = "rgamma"
        clsGammaWithShapeandMean.strPFunctionName = "pgamma"
        clsGammaWithShapeandMean.strQFunctionName = "qgamma"
        clsGammaWithShapeandMean.strDFunctionName = "dgamma"
        clsGammaWithShapeandMean.bIsContinuous = True
        clsGammaWithShapeandMean.AddParameter("shape", "Shape", 1)
        clsGammaWithShapeandMean.AddParameter("mean", "Mean")
        lstAllDistributions.Add(clsGammaWithShapeandMean)

        'Gamma With Shape and Rate distribution
        clsGammaWithShapeandRate.strNameTag = "Gamma_With_Shape_and_Rate"
        clsGammaWithShapeandRate.strRName = "gamma"
        clsGammaWithShapeandRate.strPackagName = "stats"
        clsGammaWithShapeandRate.strRFunctionName = "rgamma"
        clsGammaWithShapeandRate.strPFunctionName = "pgamma"
        clsGammaWithShapeandRate.strQFunctionName = "qgamma"
        clsGammaWithShapeandRate.strDFunctionName = "dgamma"
        clsGammaWithShapeandRate.bIsContinuous = True
        clsGammaWithShapeandRate.AddParameter("shape", "Shape", 1)
        clsGammaWithShapeandRate.AddParameter("rate", "Rate")
        lstAllDistributions.Add(clsGammaWithShapeandRate)

        'Gamma With Shape and Scale distribution
        clsGamma.strNameTag = "Gamma"
        clsGamma.strRName = "gamma"
        clsGamma.strPackagName = "stats"
        clsGamma.strGLMFunctionName = "Gamma"
        clsGamma.bNumeric = True
        clsGamma.bIsContinuous = True
        lstAllDistributions.Add(clsGamma)

        'Gamma with Zeros distribution
        'TODO Paramaters 
        clsGammaWithZerosDist.strNameTag = "Gamma_With_Zeros"
        clsGammaWithZerosDist.strRName = "gamma"
        clsGammaWithZerosDist.strPackagName = "stats"
        clsGammaWithZerosDist.strRFunctionName = "rgamma"
        clsGammaWithZerosDist.strPFunctionName = "pgamma"
        clsGammaWithZerosDist.strQFunctionName = "qgamma"
        clsGammaWithZerosDist.strDFunctionName = "dgamma"
        clsGammaWithZerosDist.bIsContinuous = True
        clsGammaWithZerosDist.AddParameter("shape", "Shape", 1)
        clsGammaWithZerosDist.AddParameter("rate", "Rate")
        lstAllDistributions.Add(clsGammaWithZerosDist)

        'Inverse Gaussian distribution
        clsInverseGaussianDist.strNameTag = "Inverse_Gaussian"
        clsInverseGaussianDist.strRName = ""
        clsInverseGaussianDist.strGLMFunctionName = "inverse.gaussian"
        clsInverseGaussianDist.bNumeric = True
        clsInverseGaussianDist.bIsContinuous = True
        lstAllDistributions.Add(clsInverseGaussianDist)

        'Quasi distribution
        clsQuasiDist.strNameTag = "Quasi"
        clsQuasiDist.strRName = ""
        clsQuasiDist.strGLMFunctionName = "quasi"
        clsQuasiDist.bNumeric = True
        'clsQuasiDist.bIsContinuous = 
        lstAllDistributions.Add(clsQuasiDist)

        'Quasibinomial distribution
        clsQuasibinomialDist.strNameTag = "Quasibinomial"
        clsQuasibinomialDist.strGLMFunctionName = "quasibinomial"
        clsQuasibinomialDist.bTwoLevelFactor = True
        'clsQuasibinomialDist.bIsContinuous = 
        lstAllDistributions.Add(clsQuasibinomialDist)

        'Quasipoisson distribution
        clsQuasipoissonDist.strNameTag = "Quasipoisson"
        clsQuasipoissonDist.strRName = ""
        clsQuasipoissonDist.strGLMFunctionName = "quasipoisson"
        'clsQuasipoissonDist.bIsContinuous = 
        clsQuasipoissonDist.bPositiveInt = True
        lstAllDistributions.Add(clsQuasipoissonDist)
        bDistributionsSet = True

        ' No Distribution
        clsNoDist.strNameTag = "No_Distribution" ' TODO: Add in this name
        clsNoDist.strRName = ""
        clsNoDist.bIsExact = True
        clsNoDist.strExactName = "none"
        clsNoDist.lstExact = {"", "Difference in Means:", 0, 1, 2, Integer.MinValue, Integer.MaxValue}
        lstAllDistributions.Add(clsNoDist)
    End Sub

    Public Event DistributionsIndexChanged()

    Private Sub ucrInputDistributions_SelectedIndexChanged() Handles ucrInputDistributions.SelectionIndexChanged
        If ucrInputDistributions.cboInput.SelectedIndex <> -1 Then
            clsCurrDistribution = lstCurrentDistributions(ucrInputDistributions.cboInput.SelectedIndex)
            clsCurrRFunction.SetPackageName(clsCurrDistribution.strPackagName)
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
                Case "ExactSolution"
                    clsCurrRFunction.SetRCommand(clsCurrDistribution.strExactName)
            End Select
        Else
            clsCurrRFunction = New RFunction
        End If
        RaiseEvent DistributionsIndexChanged()
    End Sub

    Public Sub RecieverDatatype(DataFrame As String, Column As String)
        strDataType = frmMain.clsRLink.GetDataType(DataFrame, Column)
        SetDistributions()
    End Sub

    Public Sub RecieverDatatype(strNewType As String)
        strDataType = strNewType
        SetDistributions()
    End Sub

    Public Sub SetParameterIsDistName()
        bParameterIsDistName = True
        bParameterIsDistFunction = False
        bFunctionIsDistFunction = False
        UpdateAllParameters()
    End Sub

    Public Sub SetParameterIsDistFunction()
        bParameterIsDistFunction = True
        bParameterIsDistName = False
        bFunctionIsDistFunction = False
        UpdateAllParameters()
    End Sub

    Public Sub SetFunctionIsDistFunction()
        bParameterIsDistFunction = False
        bParameterIsDistName = False
        bFunctionIsDistFunction = True
        UpdateAllParameters()
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If clsTempParam Is Nothing Then
            clsTempParam = New RParameter
        End If
        If bParameterIsDistName Then
            'TODO this currently only works with one value to ignore. Also may need option not to set parameter value to strValuesToIgnore
            '     although this currently can be done with bAddParameterIfEmpty = True
            clsTempParam.SetArgumentValue(Chr(34) & clsCurrDistribution.strRName & Chr(34))
        ElseIf bParameterIsDistFunction Then
            clsTempParam.SetArgument(clsCurrRFunction)
        ElseIf bFunctionIsDistFunction Then
            SetRCode(clsCurrRFunction)
        End If
    End Sub

    Protected Overrides Sub SetControlValue()
        Dim strFunctionName As String = ""
        Dim lstCurrentVariables As String() = Nothing
        Dim clsTempParameter As RParameter
        Dim clsNewCurrentDist As Distribution = Nothing

        clsTempParameter = GetParameter()
        If bParameterIsDistName AndAlso clsTempParameter IsNot Nothing AndAlso clsTempParameter.bIsString Then
            clsNewCurrentDist = lstCurrentDistributions.Find(Function(x) x.strRName = clsTempParameter.strArgumentValue.Trim(Chr(34)))
        Else
            If (bParameterIsDistFunction AndAlso clsTempParameter IsNot Nothing AndAlso clsTempParameter.bIsFunction) Then
                strFunctionName = DirectCast(clsTempParameter.clsArgumentCodeStructure, RFunction).strRCommand
            ElseIf bFunctionIsDistFunction AndAlso GetRCode() IsNot Nothing Then
                strFunctionName = DirectCast(GetRCode(), RFunction).strRCommand
            End If
            If strFunctionName <> "" Then
                For Each clsTempDist As Distribution In lstCurrentDistributions
                    If clsTempDist.IsDistributionFunction(strFunctionName) Then
                        clsNewCurrentDist = clsTempDist
                    End If
                Next
            End If
        End If
        If clsNewCurrentDist IsNot Nothing Then
            ucrInputDistributions.SetName(translate(clsNewCurrentDist.strNameTag))
        Else
            MsgBox("Developer error: Cannot set value of " & Name & " because cannot find a distribution matching the function and parameter given")
        End If
    End Sub
End Class