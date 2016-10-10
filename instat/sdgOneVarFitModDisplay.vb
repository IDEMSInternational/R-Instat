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
    Private clsSaveLikelihood As New RFunction
    Private clsModel As New RFunction
    Private clsRLogLikFunction As New RFunction
    Private WithEvents ucrDists As ucrDistributions
    Public clsRdataframe As ucrDataFrame
    Public bfirstload As Boolean = True

    Private Sub sdgOneVarFitModDisplay(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseDialog()
        ucrSavePlots.ucrInputGraphName.SetItemsTypeAsGraphs()
        ucrSavePlots.ucrInputGraphName.SetDefaultTypeAsGraph()
        ucrSavePlots.ucrInputGraphName.SetValidationTypeAsRVariable()
        ucrSavePlots.ucrInputGraphName.SetPrefix(dlgOneVarFitModel.ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_Plot")
        ucrSaveLikelihood.ucrInputGraphName.SetItemsTypeAsGraphs()
        ucrSaveLikelihood.ucrInputGraphName.SetDefaultTypeAsGraph()
        ucrSaveLikelihood.ucrInputGraphName.SetValidationTypeAsRVariable()
        ucrSaveLikelihood.ucrInputGraphName.SetPrefix(dlgOneVarFitModel.ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_Likelihood")
    End Sub

    Public Sub SetDefaults()
        rdoPlotAll.Checked = True
        rdoLoglik.Checked = True
        'ucrSaveLikelihood.Enabled = False
        'ucrBase.ihelptopicID = 
        ucrSaveLikelihood.Reset()
        ucrSavePlots.Reset()
        ucrSavePlots.chkSaveGraph.Checked = False
        ucrSaveLikelihood.chkSaveGraph.Checked = False
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
            clsRplotFunction.ClearParameters()
            clsRplotFunction.SetRCommand("plot")
            clsRplotFunction.AddParameter("x", clsRFunctionParameter:=clsModel)
            frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 2)
        ElseIf rdoPPPlot.Checked Then
            clsRplotFunction.ClearParameters()
            clsRplotFunction.SetRCommand("ppcomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
            frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 2)
        ElseIf rdoCDFPlot.Checked Then
            clsRplotFunction.ClearParameters()
            clsRplotFunction.SetRCommand("cdfcomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
            frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 2)
        ElseIf rdoQQPlot.Checked Then
            clsRplotFunction.ClearParameters()
            clsRplotFunction.SetRCommand("qqcomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
            frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 2)
        ElseIf rdoDensityPlot.Checked Then
            clsRplotFunction.ClearParameters()
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

    ' looking into tab2

    Public Sub EnableLikelihood()
        If Not sdgOneVarFitModel.rdoMle.Checked Then
            tbclikelihood.Enabled = False
            If Not rdoNoLik.Checked Then
                rdoNoLik.Checked = True
            End If
        Else
            rdoLoglik.Checked = True
        End If
    End Sub

    Public Sub LikelihoodGraphs()
        clsRLogLikFunction.SetRCommand("llplot")
        clsRLogLikFunction.AddParameter("mlefit", clsRFunctionParameter:=clsModel)
        If rdoLoglik.Checked Then
            frmMain.clsRLink.RunScript(clsRLogLikFunction.ToScript(), 2)
        ElseIf rdoLik.Checked Then
            clsRLogLikFunction.AddParameter("loglik", strParameterValue:="FALSE")
            frmMain.clsRLink.RunScript(clsRLogLikFunction.ToScript(), 2)
        End If
    End Sub

    Private Sub ucrSaveLikelihood_GraphNameChanged() 
        AssignSaveLikelihood()
    End Sub

    Public Sub AssignSaveLikelihood()
        '     If ucrSaveLikelihood.chkSaveGraph.Checked AndAlso Not ucrSaveLikelihood.ucrInputGraphName.IsEmpty Then
    '    dlgOneVarFitModel.UcrBase.clsRsyntax.SetAssignTo(ucrSaveLikelihood.ucrInputGraphName.GetText, strTempGraph:=ucrSaveLikelihood.ucrInputGraphName.GetText, strTempDataframe:=dlgOneVarFitModel.ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    '   Else
    '  dlgOneVarFitModel.UcrBase.clsRsyntax.SetAssignTo("last_graph", strTempGraph:="last_graph", strTempDataframe:=dlgOneVarFitModel.ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    ' End If
    'End Sub
    'need to sort this
End Class