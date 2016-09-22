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
    Private clsRcdfcompFunction As New RFunction
    Private clsRdenscompFunction As New RFunction
    Private clsRqqcompFunction As New RFunction
    Private clsRppcompFunction As New RFunction
    Private clsRplotFunction As New RFunction
    Private clsModel As New RFunction
    Public bfirstload As Boolean = True


    Private Sub sdgOneVarFitModDisplay(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseDialog()
        clsRcdfcompFunction.SetRCommand("cdfcomp")
        clsRdenscompFunction.SetRCommand("denscomp")
        clsRqqcompFunction.SetRCommand("qqcomp")
        clsRppcompFunction.SetRCommand("ppcomp")
        clsRplotFunction.SetRCommand("plot")

        ' If Not dlgOneVarFitModel.UcrDistributions.cboDistributions.iscontinous Then
        '  rdoDensityPlot.Enabled = False AndAlso rdoQQPlot.Enabled = False AndAlso rdoPPPlot.Enabled = False
        ' Else
        'rdoDensityPlot.Enabled = True AndAlso rdoQQPlot.Enabled = True AndAlso rdoPPPlot.Enabled = True
        'End If



    End Sub

    Public Sub SetDefaults()
        rdoPlotAll.Enabled = True
        rdoNoPlot.Enabled = True
        rdoCDFPlot.Enabled = True
        rdoPlotAll.Checked = True
        'ucrBase.ihelptopicID = 
    End Sub

    Public Sub SetModelFunction(clsNewModel As RFunction)
        clsModel = clsNewModel
        clsRplotFunction.AddParameter("x", clsRFunctionParameter:=clsModel)
        clsRcdfcompFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
        clsRppcompFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
        clsRdenscompFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
        clsRqqcompFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
    End Sub

    Public Sub CreateGraphs()
        If rdoPlotAll.Checked Then
            frmMain.clsRLink.RunScript(clsRplotFunction.ToScript(), 2)
        ElseIf rdoPPPlot.Checked Then
            frmMain.clsRLink.RunScript(clsRppcompFunction.ToScript(), 2)
        ElseIf rdoCDFPlot.Checked Then
            frmMain.clsRLink.RunScript(clsRcdfcompFunction.ToScript(), 2)
        ElseIf rdoQQPlot.Checked Then
            frmMain.clsRLink.RunScript(clsRqqcompFunction.ToScript(), 2)
        ElseIf rdoDensityPlot.Checked Then
            frmMain.clsRLink.RunScript(clsRdenscompFunction.ToScript(), 2)
        End If
    End Sub

End Class