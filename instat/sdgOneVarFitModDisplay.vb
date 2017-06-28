﻿' Instat-R
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
Imports instat
Imports instat.Translations

Public Class sdgOneVarFitModDisplay
    Public clsRplotFunction, clsRplotPPComp, clsRplotCdfcomp, clsRplotQqComp, clsRplotDenscomp As RFunction
    '  Private clsRplotFunction As New RFunction
    Private clsModel As New RFunction
    Private clsRLogLikFunction As New RFunction
    Private WithEvents ucrDists As ucrDistributions
    Public clsRdataframe As ucrDataFrame
    Public bfirstload As Boolean = True
    Private clsRSyntax As RSyntax
    Public bControlsInitialised As Boolean = False

    Private Sub sdgOneVarFitModDisplay(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrPnlLikelihood.SetParameter(New RParameter("loglik"))
        ucrPnlLikelihood.AddRadioButton(rdoLoglik, "TRUE")
        ucrPnlLikelihood.AddRadioButton(rdoLik, "FALSE")
        ucrPnlLikelihood.SetRDefault("TRUE")

        ucrChkPLotLogLik.AddToLinkedControls(ucrPnlLikelihood, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkPLotLogLik.AddParameterPresentCondition(True, "loglik")
        ucrChkPLotLogLik.AddParameterPresentCondition(False, "loglik", False)
        ucrChkPLotLogLik.SetText("Plot Likelihood")

        ucrPnlPlots.AddRadioButton(rdoNoPlot)
        ucrPnlPlots.AddRadioButton(rdoPlotAll)
        ucrPnlPlots.AddRadioButton(rdoCDFPlot)
        ucrPnlPlots.AddRadioButton(rdoDensityPlot)
        ucrPnlPlots.AddRadioButton(rdoQQPlot)
        ucrPnlPlots.AddRadioButton(rdoPPPlot)

        ucrPnlPlots.AddFunctionNamesCondition(rdoNoPlot, {"plot", "cdfcomp", "denscomp", "qqcomp", "ppcomp"}, False)
        ucrPnlPlots.AddFunctionNamesCondition(rdoPlotAll, "plot")
        ucrPnlPlots.AddFunctionNamesCondition(rdoCDFPlot, "cdfcomp")
        ucrPnlPlots.AddFunctionNamesCondition(rdoDensityPlot, "denscomp")
        ucrPnlPlots.AddFunctionNamesCondition(rdoQQPlot, "qqcomp")
        ucrPnlPlots.AddFunctionNamesCondition(rdoPPPlot, "ppcomp")

        ' ucrSaveLikelihood.SetDataFrameSelector(dlgOneVarFitModel.ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        ' ucrSavePlots.SetDataFrameSelector(dlgOneVarFitModel.ucrSelectorOneVarFitMod.ucrAvailableDataFrames)

        bControlsInitialised = True
    End Sub

    Public Sub SetDistribution(ucrNewDists As ucrDistributions)
        ucrDists = ucrNewDists
        SetPlotOptions()
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, Optional clsRNewOneVarFitModel As RFunction = Nothing, Optional clsNewRLogLikFunction As RFunction = Nothing, Optional clsNewRplotFunction As RFunction = Nothing, Optional clsNewRplotPPComp As RFunction = Nothing, Optional clsNewRplotCdfcomp As RFunction = Nothing, Optional clsNewRplotQqComp As RFunction = Nothing, Optional clsNewRplotDenscomp As RFunction = Nothing, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRSyntax = clsNewRSyntax
        clsModel = clsRNewOneVarFitModel
        clsRplotFunction = clsNewRplotFunction
        clsRplotPPComp = clsNewRplotPPComp
        clsRplotCdfcomp = clsNewRplotCdfcomp
        clsRplotQqComp = clsNewRplotQqComp
        clsRplotDenscomp = clsNewRplotDenscomp
        clsRLogLikFunction = clsNewRLogLikFunction
        ucrPnlLikelihood.SetRCode(clsRLogLikFunction, bReset)
        ucrChkPLotLogLik.SetRCode(clsRLogLikFunction, bReset)
        ucrPnlPlots.SetRCode(clsRplotFunction, bReset)
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlPlots.ControlValueChanged
        If rdoPlotAll.Checked Then
            clsRplotFunction.AddParameter("x", clsRFunctionParameter:=clsModel)
            clsRSyntax.AddToAfterCodes(clsRplotFunction, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsRplotDenscomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotQqComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotCdfcomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotPPComp)
        ElseIf rdoPPPlot.Checked Then
            clsRplotPPComp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
            clsRplotPPComp.AddParameter("ft", clsRFunctionParameter:=clsModel)
            clsRSyntax.AddToAfterCodes(clsRplotPPComp, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsRplotDenscomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotQqComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotCdfcomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotFunction)
        ElseIf rdoCDFPlot.Checked Then
            clsRplotCdfcomp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
            clsRplotCdfcomp.AddParameter("ft", clsRFunctionParameter:=clsModel)
            clsRSyntax.AddToAfterCodes(clsRplotCdfcomp, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsRplotDenscomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotQqComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotPPComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotFunction)
        ElseIf rdoQQPlot.Checked Then
            clsRplotQqComp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
            clsRplotQqComp.AddParameter("ft", clsRFunctionParameter:=clsModel)
            clsRSyntax.AddToAfterCodes(clsRplotQqComp, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsRplotDenscomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotCdfcomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotPPComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotFunction)
        ElseIf rdoDensityPlot.Checked Then
            clsRplotDenscomp.AddParameter("plotstyle", Chr(34) & "ggplot" & Chr(34))
            clsRplotDenscomp.AddParameter("ft", clsRFunctionParameter:=clsModel)
            clsRSyntax.AddToAfterCodes(clsRplotDenscomp, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsRplotQqComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotCdfcomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotPPComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotFunction)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRplotDenscomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotQqComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotCdfcomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotPPComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotFunction)
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

    'Private Sub VisibleSaveGraph_CheckedChanged(sender As Object, e As EventArgs)
    '    If rdoNoPlot.Checked Then
    '        ucrSavePlots.Visible = False
    '    Else
    '        ucrSavePlots.Visible = True
    '    End If
    '    Else
    '    ucrSaveLikelihood.Visible = True
    '    End If
    'End Sub
    Private Sub ucrChkPLotLogLik_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPLotLogLik.ControlValueChanged, ucrPnlLikelihood.ControlValueChanged
        If ucrChkPLotLogLik.Checked Then
            If rdoLoglik.Checked OrElse rdoLik.Checked Then
                clsRSyntax.AddToAfterCodes(clsRLogLikFunction, iPosition:=2)
            End If
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRLogLikFunction)
        End If
    End Sub
End Class