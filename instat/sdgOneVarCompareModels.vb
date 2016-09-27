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

Public Class sdgOneVarCompareModels
    Private clsRcdfcompFunction As New RFunction
    Private clsRdenscompFunction As New RFunction
    Private clsRqqcompFunction As New RFunction
    Private clsRppcompFunction As New RFunction
    Public bfirstload As Boolean = True

    Private Sub sdgOneVarCompareModels(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseDialog()
        clsRcdfcompFunction.SetRCommand("cdfcomp")
        clsRdenscompFunction.SetRCommand("denscomp")
        clsRqqcompFunction.SetRCommand("qqcomp")
        clsRppcompFunction.SetRCommand("ppcomp")
    End Sub

    Public Sub SetDefaults()
        chkCDF.Checked = True
        chkDensity.Checked = False
        chkInputBreakpoints.Checked = False
        chkPP.Checked = False
        chkQQ.Checked = False
        chkSaveChi.Checked = True
        chkSaveObjects.Checked = True
        ucrObjectName.Visible = False
        ucrObjectName.SetValidationTypeAsRVariable()
        ucrObjectName.SetPrefix("gof")
        SaveObject()
        CreateGraphs()
        'ucrBase.ihelptopicID = 
    End Sub

    'Public Sub SetModelFunction(clsNewModel As RFunction)
    '   clsModel = clsNewModel
    '  clsRcdfcompFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
    ' clsRppcompFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
    'clsRdenscompFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
    'clsRqqcompFunction.AddParameter("ft", clsRFunctionParameter:=clsModel)
    'End Sub


    Public Sub CreateGraphs()
        If chkPP.Checked Then
            frmMain.clsRLink.RunScript(clsRppcompFunction.ToScript(), 2)
        ElseIf chkCDF.Checked Then
            frmMain.clsRLink.RunScript(clsRcdfcompFunction.ToScript(), 2)
        ElseIf chkQQ.Checked Then
            frmMain.clsRLink.RunScript(clsRqqcompFunction.ToScript(), 2)
        ElseIf chkDensity.Checked Then
            frmMain.clsRLink.RunScript(clsRdenscompFunction.ToScript(), 2)
        End If
    End Sub

    Private Sub SaveObject()
        If chkSaveObjects.Checked Then
            ucrObjectName.Visible = True
        Else
            ucrObjectName.Visible = False
        End If
    End Sub

    'not sure if the following sub should be here or in the main
    Private Sub Here()

    End Sub



    ' To say if our models are discrete, we cannot use Density, QQ or PP
    'Private Sub SetPlotOptions()
    'If Not chosenmodels.bIsContinuous Then
    '       chkDensity.Enabled = False
    '       chkQQ.Enabled = False
    '       rdoPPPlot.Enabled = False
    'If chkDensity.Checked = True Or chkQQ.Checked = True Or chkPP.Checked = True Then
    '            chkCDF.Checked = True
    'End If
    'Else
    '        chkDensity.Enabled = True
    '        chkQQ.Enabled = True
    '        chkPP.Enabled = True
    'End If
    'End Sub


End Class
