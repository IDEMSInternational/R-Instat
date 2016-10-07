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

Public Class sdgOneVarFitModDisplay
    Private clsRplotFunction As New RFunction
    Private clsModel As New RFunction
    Private WithEvents ucrDists As ucrDistributions
    Public bfirstload As Boolean = True

    Private Sub sdgOneVarFitModDisplay(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseDialog()
    End Sub

    Public Sub SetDefaults()
        rdoPlotAll.Checked = True
        'ucrBase.ihelptopicID = 
    End Sub

    Public Sub SetModelFunction(clsNewModel As RFunction)
        clsModel = clsNewModel
    End Sub

    Public Sub SetDistribution(ucrNewDists As ucrDistributions)
        ucrDists = ucrNewDists
        SetPlotOptions()
    End Sub

    Public Sub CreateGraphs()
        If rdoPlotAll.Checked Then
            clsRplotFunction.SetRCommand("plot")
            clsRplotFunction.AddParameter("x", clsRFunctionParameter:=clsModel)
            frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 2)
        ElseIf rdoPPPlot.Checked Then
            clsRplotFunction.SetRCommand("ppcomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
            frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 2)
        ElseIf rdoCDFPlot.Checked Then
            clsRplotFunction.SetRCommand("cdfcomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
            frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 2)
        ElseIf rdoQQPlot.Checked Then
            clsRplotFunction.SetRCommand("qqcomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
            frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 2)
        ElseIf rdoDensityPlot.Checked Then
            clsRplotFunction.SetRCommand("denscomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
            frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 2)
        End If
    End Sub

    Private Sub ucrDists_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles ucrDists.cboDistributionsIndexChanged
        SetPlotOptions()
    End Sub

    Private Sub SetPlotOptions()
        If ucrDists.clsCurrDistribution IsNot Nothing AndAlso Not ucrDists.clsCurrDistribution.bIsContinuous Then
            rdoDensityPlot.Enabled = False
            rdoQQPlot.Enabled = False
            rdoPPPlot.Enabled = False
            If rdoDensityPlot.Checked = True Or rdoQQPlot.Checked = True Or rdoPPPlot.Checked = True Then
                rdoPlotAll.Checked = True
            End If
        Else
            rdoDensityPlot.Enabled = True
            rdoQQPlot.Enabled = True
            rdoPPPlot.Enabled = True
        End If
    End Sub

    'Private Sub tbcQuantiles_VisibleChanged(sender As Object, e As EventArgs) Handles tbcQuantiles.VisibleChanged
    'if we are using One Var Fit Model then I do not want this tab to be visible.
    'tbcQuantiles.Visible = False
    'End Sub
End Class