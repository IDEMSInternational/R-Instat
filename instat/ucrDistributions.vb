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

Public Class ucrDistributions
    Public lstAllDistributions As New List(Of Distribution)
    Public lstRequiredDistributions As New List(Of Distribution)
    Public strRequiredDistributions As String = "All"
    Public clsCurrDistribution As New Distribution
    Public bDistributionsSet As Boolean = False

    Private Sub ucrDistributions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not bDistributionsSet Then
            CreateDistributions()
        End If
        SetRequiredDistributions()
    End Sub

    Public Sub SetRequiredDistributions()
        Dim lstDistributionNames As New List(Of String)
        For Each Dist In lstAllDistributions
            Select Case strRequiredDistributions
                Case "All"
                    lstDistributionNames.Add(translate(Dist.strNameTag))
                    lstRequiredDistributions.Add(Dist)
                Case "RFunctions"
                    If Not Dist.strRFunctionName = "" Then
                        lstDistributionNames.Add(translate(Dist.strNameTag))
                        lstRequiredDistributions.Add(Dist)
                    End If
                Case "PFunctions"
                    If Not Dist.strPFunctionName = "" Then
                        lstDistributionNames.Add(translate(Dist.strNameTag))
                        lstRequiredDistributions.Add(Dist)
                    End If
                Case "QFunctions"
                    If Not Dist.strQFunctionName = "" Then
                        lstDistributionNames.Add(translate(Dist.strNameTag))
                        lstRequiredDistributions.Add(Dist)
                    End If
                Case "DFunctions"
                    If Not Dist.strDFunctionName = "" Then
                        lstDistributionNames.Add(translate(Dist.strNameTag))
                        lstRequiredDistributions.Add(Dist)
                    End If
                Case "GLMFunctions"
                    If Not Dist.strGLMFunctionName = "" Then
                        lstDistributionNames.Add(translate(Dist.strNameTag))
                        lstRequiredDistributions.Add(Dist)
                    End If
            End Select
        Next

        If Not lstDistributionNames.Count = 0 Then
            cboDistributions.Items.Clear()
            cboDistributions.Items.AddRange(lstDistributionNames.ToArray)
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
        Dim clsAutogressiveDist As New Distribution

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
        clsGeometricDist.AddParameter("prob", "Probability")
        lstAllDistributions.Add(clsGeometricDist)

        ' Extreme Value Distribution
        clsExtremeValueDist.strNameTag = "Extreme_Value"
        clsGeometricDist.strRFunctionName = ""
        clsGeometricDist.strPFunctionName = ""
        clsGeometricDist.strQFunctionName = ""
        clsGeometricDist.strDFunctionName = ""
        clsExtremeValueDist.AddParameter("mode", "Mode")
        clsExtremeValueDist.AddParameter("scale", "Scale")
        lstAllDistributions.Add(clsExtremeValueDist)

        ' Weibull Distribution
        clsWeibullDist.strNameTag = "Weibull"
        clsWeibullDist.strRFunctionName = ""
        clsWeibullDist.strPFunctionName = ""
        clsWeibullDist.strQFunctionName = ""
        clsWeibullDist.strDFunctionName = ""
        clsWeibullDist.AddParameter("mean", "Mean")
        clsWeibullDist.AddParameter("shape", "Shape")
        lstAllDistributions.Add(clsWeibullDist)

        'Uniform Distribution
        clsUniformDist.strNameTag = ""
        clsUniformDist.strRFunctionName = ""
        clsUniformDist.strPFunctionName = ""
        clsUniformDist.strQFunctionName = ""
        clsUniformDist.strDFunctionName = ""
        clsUniformDist.AddParameter("a", "a")
        clsUniformDist.AddParameter("b", "b")
        lstAllDistributions.Add(clsUniformDist)


        'bernouli Distribution
        clsBernouliDist.strNameTag = ""
        clsBernouliDist.strRFunctionName = ""
        clsBernouliDist.strPFunctionName = ""
        clsBernouliDist.strQFunctionName = ""
        clsBernouliDist.strDFunctionName = ""
        clsBernouliDist.AddParameter("prob", "Probability")
        lstAllDistributions.Add(clsBernouliDist)

        'Binomial Distribution
        clsBinomialDist.strNameTag = ""
        clsBinomialDist.strRFunctionName = ""
        clsBinomialDist.strPFunctionName = ""
        clsBinomialDist.strQFunctionName = ""
        clsBinomialDist.strDFunctionName = ""
        clsBinomialDist.AddParameter("number", "Number")
        clsBinomialDist.AddParameter("prob", "Probability")
        lstAllDistributions.Add(clsBinomialDist)

        'poisson Distribution
        clsPoissonDist.strNameTag = ""
        clsPoissonDist.strRFunctionName = ""
        clsPoissonDist.strPFunctionName = ""
        clsPoissonDist.strQFunctionName = ""
        clsPoissonDist.strDFunctionName = ""
        clsPoissonDist.AddParameter("mean", "Mean")
        lstAllDistributions.Add(clsPoissonDist)

        'Autogressive Distribution
        clsAutogressiveDist.strNameTag = ""
        clsAutogressiveDist.strRFunctionName = ""
        clsAutogressiveDist.strPFunctionName = ""
        clsAutogressiveDist.strQFunctionName = ""
        clsAutogressiveDist.strDFunctionName = ""
        clsAutogressiveDist.AddParameter("mean", "Mean")
        clsAutogressiveDist.AddParameter("st.", "St. Dev")
        lstAllDistributions.Add(clsAutogressiveDist)
        bDistributionsSet = True
    End Sub
    Public Event cboDistributionsIndexChanged(sender As Object, e As EventArgs)
    Private Sub cboDistributions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDistributions.SelectedIndexChanged
        clsCurrDistribution = lstRequiredDistributions(cboDistributions.SelectedIndex)
        RaiseEvent cboDistributionsIndexChanged(sender, e)
    End Sub

    Private Sub lblDistributionType_Click(sender As Object, e As EventArgs) Handles lblDistributionType.Click

    End Sub
End Class
