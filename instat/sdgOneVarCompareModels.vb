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
    Private clsRcdfcompFunction, clsRdenscompFunction, clsRqqcompFunction, clsRppcompFunction, clsListFunction, clsRAsDataFrame, clsModel, clsRsyntax, clsOperation As New RFunction
    Private clsGetObjectOperator As New ROperator
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
        ucrDisplayChiData.SetValidationTypeAsRVariable()
        ' set default name
        ' if not checked, then this doesn't show
    End Sub

    Public Sub SetDefaults()
        chkCDF.Checked = True
        chkDensity.Checked = False
        chkPP.Checked = False
        chkQQ.Checked = False
        chkSaveChi.Checked = True
        chkSaveObjects.Checked = True
        chkInputBreakpoints.Enabled = False ' disabled for now
        ucrSavePlots.chkSaveGraph.Checked = False
        ucrSavePlots.Enabled = False ' disabled for now
        ucrSavePlots.ucrInputGraphName.SetPrefix("plots")
        ucrObjectName.SetValidationTypeAsRVariable()
        ucrObjectName.SetName("gof")
        ucrDisplayChiData.Reset()
        ucrDisplayChiData.SetName(dlgOneVarCompareModels.ucrSelectorOneVarCompModels.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_ChiSquare")
        ReturnEnabled()
        DisplayChiSquare()
        'ucrBase.ihelptopicID = 
    End Sub

    Public Sub Reopen()
        DisplayChiSquare()
    End Sub

    Public Sub SetModelFunction(clsNewModel As RFunction)
        clsModel = clsNewModel
        clsRcdfcompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
        ' clSr....   :=clsModel
        clsRdenscompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
        clsRppcompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
        clsRqqcompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
    End Sub

    Public Sub DisplayChiSquare()
        If chkSaveChi.Checked Then
            ucrDisplayChiData.Visible = True
            clsGetObjectOperator.SetOperation("$")
            clsGetObjectOperator.SetParameter(True, clsRFunc:=clsModel)
            clsGetObjectOperator.SetParameter(False, strValue:="chisqtable")
            clsRAsDataFrame.SetRCommand("as.data.frame")
            clsRAsDataFrame.AddParameter("x", clsROperatorParameter:=clsGetObjectOperator)
        Else
            ucrDisplayChiData.Visible = False
        End If
        If Not ucrDisplayChiData.IsEmpty Then
            clsRAsDataFrame.SetAssignTo(ucrDisplayChiData.GetText(), strTempDataframe:=ucrDisplayChiData.GetText())
        Else
            clsRAsDataFrame.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrDisplayChiData_NameChanged() Handles ucrDisplayChiData.NameChanged
        DisplayChiSquare()
    End Sub



    ' if it is selected and not given a default name then what happens

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


    Public Sub CreateGraphs()
        Dim strTemp As String = ""

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
        If chkSaveChi.Checked Then
            frmMain.clsRLink.RunScript(clsGetObjectOperator.ToScript(), 0)
            clsRAsDataFrame.ToScript(strTemp)
            frmMain.clsRLink.RunScript(strTemp, 0)
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

    Private Sub chkInputBreakpoints_Checked_Changed(sender As Object, e As EventArgs) Handles chkInputBreakpoints.CheckedChanged
        If chkInputBreakpoints.Checked Then
            clsRsyntax.AddParameter("chisqbreaks") 'in the brackets have numbers inputted numbers inputted
        End If
    End Sub

    Private Sub ReturnEnabled()
        If Not (chkSaveObjects.Checked AndAlso ucrObjectName.IsEmpty) Then
            ucrSubBase.cmdReturn.Enabled = True
        Else
            ucrSubBase.cmdReturn.Enabled = False
        End If
    End Sub

    Private Sub chkSaveChi_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveChi.CheckedChanged
        DisplayChiSquare()
    End Sub

    ' Private Sub ucrSavePlots_NameChanged() Handles ucrSavePlots.Click
    'TODO Graph Names assigned go up in increments for any of the graphs selected (e.g. 3 plots are selected and it is named "plots", then automatically we get "plots1", ... , "plots3"
    'End Sub


    Public Function TestOkEnabled() As Boolean
        Dim bOkEnabled As Boolean
        If (chkSaveObjects.Checked AndAlso Not ucrObjectName.IsEmpty) AndAlso (chkSaveChi.Checked AndAlso Not ucrDisplayChiData.IsEmpty) Then
            bOkEnabled = True
        Else
            bOkEnabled = False
        End If
        Return bOkEnabled
    End Function

End Class