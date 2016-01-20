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

        bDistributionsSet = True
    End Sub
    Public Event cboDistributionsIndexChanged(sender As Object, e As EventArgs)
    Private Sub cboDistributions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDistributions.SelectedIndexChanged
        clsCurrDistribution = lstRequiredDistributions(cboDistributions.SelectedIndex)
        RaiseEvent cboDistributionsIndexChanged(sender, e)
    End Sub
End Class
