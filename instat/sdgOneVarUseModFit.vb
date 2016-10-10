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
    Private clsRplotFunction As New RFunction
    Private clsRppFunction As New RFunction
    Private clsRqqFunction As New RFunction
    Private clsRdensFunction As New RFunction
    Private clsRcdfFunction As New RFunction
    Private clsRCIcdfFunction As New RFunction
    Public clsRbootFunction As New RFunction
    Private clsRseqFunction As New RFunction
    Private clsModel As New RFunction
    Public clsRsyntax As New RSyntax
    Public bfirstload As Boolean = True

    Private Sub sdgOneVarFitModDisplay(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseDialog()
        clsRplotFunction.SetRCommand("plot")
        clsRcdfFunction.SetRCommand("cdfcomp")
        clsRppFunction.SetRCommand("ppcomp")
        clsRdensFunction.SetRCommand("denscomp")
        clsRqqFunction.SetRCommand("qqcomp")
        clsRCIcdfFunction.SetRCommand("CIcdfplot")
        nudFrom.Minimum = 0
        nudFrom.Maximum = 1
        nudFrom.Increment = 0.05
        nudTo.Minimum = 0
        nudTo.Maximum = 1
        nudTo.Increment = 0.05
        nudBy.Minimum = 0.001
        nudBy.Maximum = 1
        nudBy.Increment = 0.05
    End Sub

    Public Sub SetDefaults()
        rdoPlotAll.Checked = True
        rdoSeqValues.Checked = True
        rdoInsertValues.Enabled = False
        'any of InsertValues needs to be disabled here.
        'ucrBase.ihelptopicID = 
        SetPlotOptions()
        nudFrom.Value = 0
        nudTo.Value = 1
        nudBy.Value = 0.1
    End Sub

    Public Sub SetModelFunction(clsNewModel As RFunction)
        clsModel = clsNewModel
    End Sub

    Public Sub CreateGraphs()
        If rdoPlotAll.Checked Then
            clsRplotFunction.AddParameter("x", clsRFunctionParameter:=dlgOneVarUseModel.ucrReceiver.GetVariables())
            frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 2)
        ElseIf rdoPPPlot.Checked Then
            clsRppFunction.SetRCommand("ppcomp")
            clsRppFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarUseModel.ucrReceiver.GetVariables())
            frmMain.clsRLink.RunScript(clsRppFunction.ToScript(), 2)
        ElseIf rdoCDFPlot.Checked Then
            clsRcdfFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarUseModel.ucrReceiver.GetVariables())
            frmMain.clsRLink.RunScript(clsRcdfFunction.ToScript(), 2)
        ElseIf rdoQQPlot.Checked Then
            clsRqqFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarUseModel.ucrReceiver.GetVariables())
            frmMain.clsRLink.RunScript(clsRqqFunction.ToScript(), 2)
        ElseIf rdoDensityPlot.Checked Then
            clsRdensFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarUseModel.ucrReceiver.GetVariables())
            frmMain.clsRLink.RunScript(clsRdensFunction.ToScript(), 2)
        ElseIf rdoCIcdf.Checked Then
            clsRCIcdfFunction.AddParameter("b", clsRFunctionParameter:=clsRbootFunction)
            clsRCIcdfFunction.AddParameter("CI.output", Chr(34) & "quantile" & Chr(34))
            frmMain.clsRLink.RunScript(clsRCIcdfFunction.ToScript(), 2)
        End If
    End Sub

    Public Sub SetMyBootFunction(clsRNewBoot As RFunction)
        clsRbootFunction = clsRNewBoot
    End Sub

    Public Sub SetMyRSyntax(clsRNewSyntax As RSyntax)
        clsRsyntax = clsRNewSyntax
    End Sub

    Private Sub nudSeq_ValueChanged(sender As Object, e As EventArgs) Handles nudFrom.ValueChanged, nudTo.ValueChanged, nudBy.ValueChanged
        clsRseqFunction.SetRCommand("seq")
        clsRseqFunction.AddParameter("from", nudFrom.Value.ToString())
        clsRseqFunction.AddParameter("to", nudTo.Value.ToString())
        clsRseqFunction.AddParameter("by", nudBy.Value.ToString())
        clsRsyntax.AddParameter("probs", clsRFunctionParameter:=clsRseqFunction)
    End Sub

    Public Sub SetPlotOptions()
        If Not dlgOneVarUseModel.chkProduceBootstrap.Checked Then
            rdoCIcdf.Enabled = False
            If rdoCIcdf.Checked Then
                rdoPlotAll.Checked = True
            End If
        Else
            rdoCIcdf.Enabled = True
        End If

        ' if discrete discribution then cannot do PP, QQ, dens
    End Sub

End Class