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
Imports instat.Translations

Public Class sdgOneVarCompareModels
    Private clsRcdfcompFunction As New RFunction
    Private clsRdenscompFunction As New RFunction
    Private clsRqqcompFunction As New RFunction
    Private clsRppcompFunction As New RFunction
    Private clsListFunction As New RFunction
    Private clsModel As New RFunction
    Private clsRsyntax As New RFunction
    Private WithEvents ucrRecs As ucrReceiver
    Public bfirstload As Boolean = True

    Private Sub sdgOneVarCompareModels(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseDialog()
        clsRsyntax.AddParameter("chisqbreaks")
        clsRcdfcompFunction.SetRCommand("cdfcomp")
        clsRdenscompFunction.SetRCommand("denscomp")
        clsRqqcompFunction.SetRCommand("qqcomp")
        clsRppcompFunction.SetRCommand("ppcomp")
    End Sub

    Public Sub SetDefaults()
        chkCDF.Checked = True
        chkDensity.Checked = False
        chkPP.Checked = False
        chkQQ.Checked = False
        chkSaveChi.Checked = True
        chkSaveObjects.Checked = True
        chkInputBreakpoints.Checked = False
        ucrObjectName.SetValidationTypeAsRVariable()
        ucrObjectName.SetName("gof")
        ucrSaveChiSq.SetValidationTypeAsRVariable()
        ucrSaveChiSq.SetDefaultTypeAsDataFrame()
        ucrSaveChiSq.SetName("ChiSquare")
        CreateGraphs()
        ReturnEnabled()
        'ucrBase.ihelptopicID = 
    End Sub

    Public Sub SetModelFunction(clsNewModel As RFunction)
        clsModel = clsNewModel
        clsRcdfcompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())


        ' I don't believe I need to specify that it is a list, which makes the below code redundant.
        'clsRcdfcompFunction.SetRCommand("cdfcomp")
        'clsListFunction.SetRCommand("list")
        'clsListFunction.AddParameter("x", clsRFunctionParameter:=clsModel)
        'dlgOneVarCompareModels.ucrBase.clsRsyntax.AddParameter("ft", clsRFunctionParameter:=clsListFunction)

        'clsRcdfcompFunction.SetRCommand("list")
        'clsRcdfcompFunction.AddParameter("x", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
        'dlgOneVarCompareModels.ucrBase.clsRsyntax.AddParameter("ft", clsRFunctionParameter:=clsRcdfcompFunction)

        'clsRcdfcompFunction.SetRCommand("list")
        'clsRcdfcompFunction.AddParameter("x", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
        'clsRcdfcompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
        'clsRcdfcompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())


        clsRdenscompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
        clsRppcompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
        clsRqqcompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
    End Sub

    Public Sub SetReceiver(ucrNewReceiver As ucrReceiver)
        ucrRecs = ucrNewReceiver
    End Sub

    Private Sub chkSaveObjects_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveObjects.CheckedChanged
        If Not chkSaveObjects.Checked Then
            ucrObjectName.Visible = False
        Else
            ucrObjectName.Visible = True
        End If
        ReturnEnabled()
    End Sub

    Private Sub chkSaveChi_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveChi.CheckedChanged
        If Not chkSaveChi.Checked Then
            ucrSaveChiSq.Visible = False
        Else
            ucrSaveChiSq.Visible = True
        End If
        ReturnEnabled()
    End Sub

    Private Sub chkInputBreakpoints_CheckedChanged(sender As Object, e As EventArgs) Handles chkInputBreakpoints.CheckedChanged

    End Sub

    Public Sub CreateGraphs()
        If chkCDF.Checked Then
            frmMain.clsRLink.RunScript(clsRcdfcompFunction.ToScript(), 2)
        End If
        If chkPP.Checked Then
            frmMain.clsRLink.RunScript(clsRppcompFunction.ToScript(), 2)
        End If
        If chkQQ.Checked Then
            frmMain.clsRLink.RunScript(clsRqqcompFunction.ToScript(), 2)
        End If
        If chkDensity.Checked Then
            frmMain.clsRLink.RunScript(clsRdenscompFunction.ToScript(), 2)
        End If
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


    'Public Sub SetMyRSyntax(clsRNewSyntax As RSyntax)
    '   clsRsyntax = clsRNewSyntax
    'End Sub

    Private Sub chkInputBreakpoints_Checked_Changed(sender As Object, e As EventArgs) Handles chkInputBreakpoints.CheckedChanged
        If chkInputBreakpoints.Checked Then
            clsRsyntax.AddParameter("chisqbreaks") 'in the brackets have numbers inputted numbers inputted)
        End If
    End Sub

    Private Sub ReturnEnabled()
        If Not (chkSaveObjects.Checked AndAlso ucrObjectName.IsEmpty) AndAlso Not (chkSaveChi.Checked AndAlso ucrSaveChiSq.IsEmpty) Then
            ucrBase.cmdReturn.Enabled = True
        Else
            ucrBase.cmdReturn.Enabled = False
        End If
    End Sub

    Private Sub ucrName_NameChanged() Handles ucrObjectName.NameChanged, ucrSaveChiSq.NameChanged
        ReturnEnabled()
    End Sub

End Class
