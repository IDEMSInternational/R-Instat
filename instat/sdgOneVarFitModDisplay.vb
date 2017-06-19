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
    Public clsRplotFunction, clsRplotPPComp, clsRplotCdfcomp, clsRplotQqComp, clsRplotDenscomp As RFunction
    '  Private clsRplotFunction As New RFunction
    Private clsModel As New RFunction
    Private clsRLogLikFunction As New RFunction
    Private WithEvents ucrDists As ucrDistributions
    Public clsRdataframe As ucrDataFrame
    Public bfirstload As Boolean = True
    Public bControlsInitialised As Boolean = False

    Private Sub sdgOneVarFitModDisplay(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrPnlLikelihood.AddRadioButton(rdoLoglik)
        ucrPnlLikelihood.AddRadioButton(rdoLik)
        ucrPnlLikelihood.AddRadioButton(rdoNoLik)

        ucrPnlPlots.AddRadioButton(rdoNoPlot)
        ucrPnlPlots.AddRadioButton(rdoPlotAll)
        ucrPnlPlots.AddRadioButton(rdoCDFPlot)
        ucrPnlPlots.AddRadioButton(rdoDensityPlot)
        ucrPnlPlots.AddRadioButton(rdoQQPlot)
        ucrPnlPlots.AddRadioButton(rdoPPPlot)
        ucrSaveLikelihood.SetDataFrameSelector(dlgOneVarFitModel.ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        ucrSavePlots.SetDataFrameSelector(dlgOneVarFitModel.ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        clsRLogLikFunction.SetPackageName("fitdistrplus")
        clsRLogLikFunction.SetRCommand("llplot")
        bControlsInitialised = True
    End Sub

    ' Public Sub SetDefaults()
    ' rdoPlotAll.Checked = True
    ' rdoLoglik.Checked = True
    'ucrSaveLikelihood.Enabled = False
    'ucrBase.ihelptopicID = 
    ' ucrSavePlots.strPrefix = "Plot"
    ' ucrSaveLikelihood.strPrefix = "Likelihood"
    'ucrSaveLikelihood.Reset()
    ' ucrSavePlots.Reset()
    ' End Sub

    'Public Sub SetModelFunction(clsNewModel As RFunction)
    '    clsModel = clsNewModel
    '    clsRLogLikFunction.AddParameter("mlefit", clsRFunctionParameter:=clsModel)
    'End Sub

    Public Sub SetDistribution(ucrNewDists As ucrDistributions)
        ucrDists = ucrNewDists
        SetPlotOptions()
    End Sub

    Public Sub SetRCode(clsRNewOneVarFitModel As RFunction, clsNewRplotFunction As RFunction, clsNewRplotPPComp As RFunction, clsNewRplotCdfcomp As RFunction, clsNewRplotQqComp As RFunction, clsNewRplotDenscomp As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsModel = clsRNewOneVarFitModel
        clsRplotFunction = clsNewRplotFunction
        clsRplotPPComp = clsNewRplotPPComp
        clsRplotCdfcomp = clsNewRplotCdfcomp
        clsRplotQqComp = clsNewRplotQqComp
        clsRplotDenscomp = clsNewRplotDenscomp
        clsRLogLikFunction.AddParameter("mlefit", clsRFunctionParameter:=clsModel)
        'ucrPnlOptimisation.SetRCode(clsModel, bReset)
        'ucrPnlFitMethod.SetRCode(clsModel, bReset)
        CreateGraphs()
    End Sub

    Public Sub CreateGraphs()
        If rdoPlotAll.Checked Then
            'clsRplotFunction.ClearParameters()
            'clsRplotFunction.SetPackageName("")
            'clsRplotFunction.SetRCommand("plot")
            clsRplotFunction.AddParameter("x", clsRFunctionParameter:=clsModel)
            ' frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 3)
        ElseIf rdoPPPlot.Checked Then
            'clsRplotFunction.ClearParameters()
            'clsRplotFunction.SetPackageName("fitdistrplus")
            'clsRplotFunction.SetRCommand("ppcomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
            ' frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 3)
        ElseIf rdoCDFPlot.Checked Then
            'clsRplotFunction.ClearParameters()
            'clsRplotFunction.SetPackageName("fitdistrplus")
            'clsRplotFunction.SetRCommand("cdfcomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
            ' frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 3)
        ElseIf rdoQQPlot.Checked Then
            'clsRplotFunction.ClearParameters()
            'clsRplotFunction.SetPackageName("fitdistrplus")
            'clsRplotFunction.SetRCommand("qqcomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
            ' frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 3)
        ElseIf rdoDensityPlot.Checked Then
            'clsRplotFunction.ClearParameters()
            'clsRplotFunction.SetPackageName("fitdistrplus")
            'clsRplotFunction.SetRCommand("denscomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
            '' frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 3)
        End If
    End Sub

    Private Sub ucrDists_cboDistributionsIndexChanged() Handles ucrDists.DistributionsIndexChanged
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

    Public Sub rdoLikelihoods_CheckedChanged(sender As Object, e As EventArgs)
        If rdoLoglik.Checked Then
            clsRLogLikFunction.AddParameter("loglik", strParameterValue:="TRUE")
        ElseIf rdoLik.Checked Then
            clsRLogLikFunction.AddParameter("loglik", strParameterValue:="FALSE")
        End If
    End Sub

    Public Sub RunLikelihoods()
        frmMain.clsRLink.RunScript(clsRLogLikFunction.ToScript(), 3)
    End Sub


    '  Private Sub UcrSaveLikelihood_GraphNameChanged() Handles ucrSaveLikelihood.GraphNameChanged
    'If ucrSaveLikelihood.bSaveGraph Then
    '    dlgOneVarFitModel.UcrBase.clsRsyntax.SetAssignTo(ucrSaveLikelihood.strGraphName, strTempDataframe:=dlgOneVarFitModel.ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveLikelihood.strGraphName)
    'Else
    '    dlgOneVarFitModel.UcrBase.clsRsyntax.RemoveAssignTo()
    'End If
    'End Sub

    'Private Sub ucrSavePlots_GraphNameChanged()
    '    If ucrSavePlots.bSaveGraph Then
    '        dlgOneVarFitModel.UcrBase.clsRsyntax.SetAssignTo(ucrSavePlots.strGraphName, strTempDataframe:=dlgOneVarFitModel.ucrSelectorOneVarFitMod.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSavePlots.strGraphName)
    '    Else
    '        dlgOneVarFitModel.UcrBase.clsRsyntax.RemoveAssignTo()
    '    End If
    'End Sub

    Private Sub VisibleSaveGraph_CheckedChanged(sender As Object, e As EventArgs)
        If rdoNoPlot.Checked Then
            ucrSavePlots.Visible = False
        Else
            ucrSavePlots.Visible = True
        End If
        If rdoNoLik.Checked Then
            ucrSaveLikelihood.Visible = False
        Else
            ucrSaveLikelihood.Visible = True
        End If
    End Sub

    'Public Function TestOkEnabled() As Boolean
    '    Dim bOkEnabled As Boolean
    '    If (ucrSavePlots.chkSaveGraph.Checked AndAlso Not ucrSavePlots.ucrInputGraphName.IsEmpty OrElse Not ucrSavePlots.chkSaveGraph.Checked) AndAlso (UcrSaveLikelihood.chkSaveGraph.Checked AndAlso Not UcrSaveLikelihood.ucrInputGraphName.IsEmpty OrElse Not UcrSaveLikelihood.chkSaveGraph.Checked) Then
    '        bOkEnabled = True
    '    Else
    '        bOkEnabled = False
    '    End If
    '    Return bOkEnabled
    'End Function

End Class