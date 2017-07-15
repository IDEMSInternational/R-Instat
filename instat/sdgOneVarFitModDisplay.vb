' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class sdgOneVarFitModDisplay
    Public clsRplotFunction, clsRplotPPComp, clsRplotCdfcomp, clsRplotQqComp, clsRplotDenscomp As RFunction
    Private clsModel As New RFunction
    Private clsRLogLikFunction As New RFunction
    Private WithEvents ucrDistribution As ucrDistributions
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
        ucrChkPLotLogLik.AddRSyntaxContainsFunctionNamesCondition(True, {"llplot"})
        ucrChkPLotLogLik.AddRSyntaxContainsFunctionNamesCondition(False, {"llplot"}, False)
        ucrChkPLotLogLik.SetText("Plot Likelihood")

        ucrPnlPlots.AddRadioButton(rdoNoPlot)
        ucrPnlPlots.AddRadioButton(rdoPlotAll)
        ucrPnlPlots.AddRadioButton(rdoCDFPlot)
        ucrPnlPlots.AddRadioButton(rdoDensityPlot)
        ucrPnlPlots.AddRadioButton(rdoQQPlot)
        ucrPnlPlots.AddRadioButton(rdoPPPlot)

        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoNoPlot, {"plot", "cdfcomp", "denscomp", "qqcomp", "ppcomp"}, False)
        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoPlotAll, {"plot"})
        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoCDFPlot, {"cdfcomp"})
        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoDensityPlot, {"denscomp"})
        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoQQPlot, {"qqcomp"})
        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoPPPlot, {"ppcomp"})

        ucrSavePlots.SetPrefix("plot")
        ucrSavePlots.SetSaveTypeAsGraph()
        ucrSavePlots.SetDataFrameSelector(dlgOneVarFitModel.ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        ucrSavePlots.SetCheckBoxText("Save Graph")
        ucrSavePlots.SetIsComboBox()
        ucrSavePlots.SetAssignToIfUncheckedValue("last_graph")

        ucrSaveLikelihood.SetPrefix("likelihood")
        ucrSaveLikelihood.SetSaveTypeAsGraph()
        ucrSaveLikelihood.SetDataFrameSelector(dlgOneVarFitModel.ucrSelectorOneVarFitMod.ucrAvailableDataFrames)
        ucrSaveLikelihood.SetCheckBoxText("Save Graph")
        ucrSaveLikelihood.SetIsComboBox()
        ucrSaveLikelihood.SetAssignToIfUncheckedValue("last_likelihood")

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, Optional clsRNewOneVarFitModel As RFunction = Nothing, Optional clsNewRLogLikFunction As RFunction = Nothing, Optional clsNewRplotFunction As RFunction = Nothing, Optional clsNewRplotPPComp As RFunction = Nothing, Optional clsNewRplotCdfcomp As RFunction = Nothing, Optional clsNewRplotQqComp As RFunction = Nothing, Optional clsNewRplotDenscomp As RFunction = Nothing, Optional ucrNewDistribution As ucrDistributions = Nothing, Optional bReset As Boolean = False)
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
        ucrDistribution = ucrNewDistribution
        ucrPnlPlots.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
        ucrSavePlots.AddAdditionalRCode(clsRplotDenscomp, 1)
        ucrSavePlots.AddAdditionalRCode(clsRplotQqComp, 2)
        ucrSavePlots.AddAdditionalRCode(clsRplotCdfcomp, 3)
        ucrSavePlots.AddAdditionalRCode(clsRplotPPComp, 4)
        ucrSavePlots.SetRCode(clsRplotFunction, bReset, bCloneIfNeeded:=True)
        ucrPnlLikelihood.SetRCode(clsRLogLikFunction, bReset, bCloneIfNeeded:=True)
        ucrChkPLotLogLik.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
        ucrSaveLikelihood.SetRCode(clsRLogLikFunction, bReset, bCloneIfNeeded:=True)
        SetPlotOptions()
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlPlots.ControlValueChanged
        If rdoPlotAll.Checked Then
            clsRSyntax.AddToAfterCodes(clsRplotFunction, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsRplotDenscomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotQqComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotCdfcomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotPPComp)
        ElseIf rdoPPPlot.Checked Then
            clsRSyntax.AddToAfterCodes(clsRplotPPComp, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsRplotDenscomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotQqComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotCdfcomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotFunction)
        ElseIf rdoCDFPlot.Checked Then
            clsRSyntax.AddToAfterCodes(clsRplotCdfcomp, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsRplotDenscomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotQqComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotPPComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotFunction)
        ElseIf rdoQQPlot.Checked Then
            clsRSyntax.AddToAfterCodes(clsRplotQqComp, iPosition:=1)
            clsRSyntax.RemoveFromAfterCodes(clsRplotDenscomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotCdfcomp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotPPComp)
            clsRSyntax.RemoveFromAfterCodes(clsRplotFunction)
        ElseIf rdoDensityPlot.Checked Then
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

    Private Sub ucrDistribution_cboDistributionsIndexChanged() Handles ucrDistribution.DistributionsIndexChanged
        SetPlotOptions()
    End Sub

    Private Sub SetPlotOptions()
        If ucrDistribution.clsCurrDistribution IsNot Nothing AndAlso Not ucrDistribution.clsCurrDistribution.bIsContinuous Then
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

    Private Sub ucrChkPLotLogLik_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPLotLogLik.ControlValueChanged, ucrPnlLikelihood.ControlValueChanged
        If ucrChkPLotLogLik.Checked Then
            clsRSyntax.AddToAfterCodes(clsRLogLikFunction, iPosition:=2)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRLogLikFunction)
        End If
    End Sub
End Class