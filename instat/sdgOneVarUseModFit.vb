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

Public Class sdgOneVarUseModFit
    Private bControlsInitialised As Boolean = False
    Private clsRplotFunction As New RFunction
    Public clsRbootFunction As New RFunction
    Private clsRseqFunction, clsRQuantileFunction As New RFunction
    Private clsModel As New RFunction
    Public clsRsyntax As New RSyntax
    Public bfirstload As Boolean = True

    Private Sub sdgOneVarFitModDisplay(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrNudFrom.SetParameter(New RParameter("from", 0))
        ucrNudFrom.SetMinMax(0, 1)
        ucrNudFrom.Increment = 0.05
        ucrNudTo.SetParameter(New RParameter("to", 1))
        ucrNudTo.SetMinMax(0, 1)
        ucrNudTo.Increment = 0.05
        ucrNudBy.SetParameter(New RParameter("by", 2))
        ucrNudBy.SetMinMax(0.001, 1)
        ucrNudBy.Increment = 0.05
        bControlsInitialised = True
    End Sub
    Public Sub SetRFunction(clsNewRSeqFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRseqFunction = clsNewRSeqFunction

        'Setting Rcode for the sub dialog
        ucrNudFrom.SetRCode(clsRseqFunction, bReset)
        ucrNudTo.SetRCode(clsRseqFunction, bReset)
        ucrNudBy.SetRCode(clsRseqFunction, bReset)

    End Sub

    Public Sub SetDefaults()
        rdoPlotAll.Checked = True
        rdoSeqValues.Checked = True
        rdoInsertValues.Enabled = False
        UcrInputValues.Enabled = False
        SetPlotOptions()
    End Sub

    Public Sub SetModelFunction(clsNewModel As RFunction)
        clsModel = clsNewModel
    End Sub

    Public Sub CreateGraphs()
        If rdoPlotAll.Checked Then
            clsRplotFunction.ClearParameters()
            clsRplotFunction.SetRCommand("plot")
            clsRplotFunction.AddParameter("x", clsRFunctionParameter:=dlgOneVarUseModel.ucrReceiverObject.GetVariables())
        ElseIf rdoPPPlot.Checked Then
            clsRplotFunction.ClearParameters()
            clsRplotFunction.SetRCommand("ppcomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarUseModel.ucrReceiverObject.GetVariables())
        ElseIf rdoCDFPlot.Checked Then
            clsRplotFunction.ClearParameters()
            clsRplotFunction.SetRCommand("cdfcomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarUseModel.ucrReceiverObject.GetVariables())
        ElseIf rdoQQPlot.Checked Then
            clsRplotFunction.ClearParameters()
            clsRplotFunction.SetRCommand("qqcomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarUseModel.ucrReceiverObject.GetVariables())
        ElseIf rdoDensityPlot.Checked Then
            clsRplotFunction.ClearParameters()
            clsRplotFunction.SetRCommand("denscomp")
            clsRplotFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarUseModel.ucrReceiverObject.GetVariables())
        ElseIf rdoCIcdf.Checked Then
            clsRplotFunction.ClearParameters()
            clsRplotFunction.SetRCommand("CIcdfplot")
            clsRplotFunction.AddParameter("b", clsRFunctionParameter:=clsRbootFunction)
            clsRplotFunction.AddParameter("CI.output", Chr(34) & "quantile" & Chr(34))
        End If
        frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 2)
    End Sub

    Public Sub SetMyBootFunction(clsRNewBoot As RFunction)
        clsRbootFunction = clsRNewBoot
    End Sub

    Public Sub SetMyRSyntax(clsRNewSyntax As RSyntax)
        clsRsyntax = clsRNewSyntax
    End Sub

    Public Sub SetPlotOptions()
        If Not dlgOneVarUseModel.ucrChkProduceBootstrap.Checked Then
            rdoCIcdf.Enabled = False
            If rdoCIcdf.Checked Then
                rdoPlotAll.Checked = True
            End If
        Else
            rdoCIcdf.Enabled = True
        End If
    End Sub

    Private Sub rdoInsertValues_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInsertValues.CheckedChanged
        If rdoInsertValues.Checked Then
            UcrInputValues.Enabled = True
        Else
            UcrInputValues.Enabled = False
        End If
    End Sub

End Class