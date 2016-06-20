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
Public Class sdgSimpleRegOptions
    Public clsRModelFunction As RFunction
    Public clsRDataFrame As ucrDataFrame
    Public clsRYVariable, clsRXVariable As ucrReceiverSingle
    Public clsRGraphics, clsRFittedModelGraphics, clsRFittedModelGraphics2 As New RSyntax
    Public clsRaovFunction, clsRaovpvalFunction, clsRestpvalFunction, clsRFourPlotsFunction, clsRgeom_point, clsRPredFunction, clsRDFFunction As New RFunction
    Public clsRggplotFunction, clsRaesFunction, clsRStat_smooth, clsRModelsFunction, clsRCIFunction, clsR_ribbon, clsRaes_ribbon As New RFunction
    Public bFirstLoad As Boolean = True

    Private Sub sdgSimpleRegOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Public Sub SetRModelFunction(clsRModelFunc As RFunction)
        clsRModelFunction = clsRModelFunc
    End Sub

    Public Sub SetRDataFrame(clsRDataFr As ucrDataFrame)
        clsRDataFrame = clsRDataFr
    End Sub

    Public Sub SetRYVariable(clsRYVar As ucrReceiverSingle)
        clsRYVariable = clsRYVar
    End Sub
    Public Sub SetRXVariable(clsRXVar As ucrReceiverSingle)
        clsRXVariable = clsRXVar
    End Sub

    Public Sub AnovaTable()
        'p-values should be false here
        clsRaovFunction.SetRCommand("anova")
        clsRaovFunction.AddParameter("", clsRFunctionParameter:=clsRModelFunction)
        frmMain.clsRLink.RunScript(clsRaovFunction.ToScript(), 2)
    End Sub

    Private Sub AnovaTablePvalues()
        clsRaovpvalFunction.SetRCommand("anova")
        clsRaovpvalFunction.AddParameter("", clsRFunctionParameter:=clsRModelFunction)
        clsRaovpvalFunction.AddParameter("", clsRFunctionParameter:=clsRModelFunction)

        frmMain.clsRLink.RunScript(clsRaovpvalFunction.ToScript(), 2)
    End Sub

    Private Sub Estimates()
        'p-values should be false here
        frmMain.clsRLink.RunScript(clsRModelFunction.ToScript(), 2)
    End Sub

    Private Sub EstimatesPvalues()
        clsRestpvalFunction.SetRCommand("summary")
        clsRestpvalFunction.AddParameter("", clsRFunctionParameter:=clsRModelFunction)
        frmMain.clsRLink.RunScript(clsRestpvalFunction.ToScript(), 2)
    End Sub

    Private Sub Model()
        clsRModelsFunction.SetRCommand("formula")
        clsRModelsFunction.AddParameter("", clsRFunctionParameter:=clsRModelFunction)
        frmMain.clsRLink.RunScript(clsRModelsFunction.ToScript(), 2)
    End Sub

    Private Sub FourPlots()
        clsRGraphics.SetOperation("+")
        clsRFourPlotsFunction.SetRCommand("autoplot")
        clsRFourPlotsFunction.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        clsRFourPlotsFunction.AddParameter("ncol", 2) 'these should be an option by the user as either 2 by 2, 4 by 1 or 1 by 4
        clsRgeom_point.SetRCommand("geom_point")
        clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRFourPlotsFunction)
        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)

        frmMain.clsRLink.RunScript(clsRGraphics.GetScript, 0)
    End Sub

    Private Sub FittedModel()
        clsRFittedModelGraphics.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        If (chkGraphicsCLimits.Checked = True) Then
            clsRggplotFunction.AddParameter("", clsRFunctionParameter:=clsRModelFunction)
        End If
        If (chkPredictionInterval.Checked = True) Then
            clsRggplotFunction.AddParameter("", clsRFunctionParameter:=clsRDataFrame.clsCurrDataFrame)
        End If
        clsRaesFunction.SetRCommand("aes")
        'this is not the right way of adding the aesthetics x and y since we are using the lm object
        'The next two lines shoulb be made more robust....
        clsRaesFunction.AddParameter("y", clsRYVariable.GetVariableNames(bWithQuotes:=False))
        clsRaesFunction.AddParameter("x", clsRXVariable.GetVariableNames(bWithQuotes:=False))
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        clsRgeom_point.SetRCommand("geom_point")
        clsRFittedModelGraphics.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        clsRFittedModelGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
        clsRStat_smooth.SetRCommand("stat_smooth")
        clsRStat_smooth.AddParameter("method", Chr(34) & "lm" & Chr(34))
        GraphicsConfidenceSE()
        clsRFittedModelGraphics.AddOperatorParameter("", clsRFunc:=clsRStat_smooth)
    End Sub

    Private Sub FitConfidence()
        FittedModel()
        frmMain.clsRLink.RunScript(clsRFittedModelGraphics.GetScript, 0)
    End Sub

    Private Sub rdoCauchit_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddCols()
        clsRPredFunction.SetRCommand("predict")
        clsRPredFunction.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        clsRPredFunction.AddParameter("interval", Chr(34) & "prediction" & Chr(34))
        clsRDFFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsRDFFunction.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        clsRDFFunction.AddParameter("col_name", "c(" & Chr(34) & "fit" & Chr(34) & "," & Chr(34) & "lwr" & Chr(34) & "," & Chr(34) & "upr" & Chr(34) & ")")
        clsRDFFunction.AddParameter("col_data", clsRFunctionParameter:=clsRPredFunction)
        clsRDFFunction.AddParameter("use_col_name_as_prefix", "FALSE")
        frmMain.clsRLink.RunScript(clsRDFFunction.ToScript(), 2)
    End Sub

    Private Sub FitPrediction()
        AddCols()
        FittedModel()
        clsRaes_ribbon.SetRCommand("aes")
        clsRaes_ribbon.AddParameter("ymin", "lwr")
        clsRaes_ribbon.AddParameter("ymax", "upr")
        clsR_ribbon.SetRCommand("geom_ribbon")
        clsR_ribbon.AddParameter("mapping", clsRFunctionParameter:=clsRaes_ribbon)
        clsR_ribbon.AddParameter("alpha", 0.3) 'to fix alpha
        clsR_ribbon.AddParameter("show.legend", "FALSE") 'to fix show  legend
        clsRFittedModelGraphics.AddOperatorParameter("", clsRFunc:=clsR_ribbon)

        frmMain.clsRLink.RunScript(clsRFittedModelGraphics.GetScript, 0)
    End Sub

    Private Sub ConfidenceInterval()
        clsRCIFunction.SetRCommand("confint")
        clsRCIFunction.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        DisplayConfidence()
        frmMain.clsRLink.RunScript(clsRCIFunction.ToScript(), 2)
    End Sub

    Public Sub SetDefaults()
        chkANOVA.Checked = True
        chkModel.Checked = True
        chkEstimates.Checked = True
        chkPvalues.Enabled = True
        chkPvalues.Checked = True
        chkPredictionInterval.Enabled = False
        chkGraphicsCLimits.Checked = False
        chkGraphicsCLimits.Enabled = False
        lblGraphicsCLevel.Enabled = False
        nudGraphicsCLevel.Enabled = False
        chkPredictionInterval.Enabled = False
        chkPredictionInterval.Checked = False
        chkFittedModel.Checked = False
        chkFourinOne.Checked = False
        chkDisplayCLimits.Checked = True
        lblDisplayCLevel.Enabled = True
        nudDisplayCLevel.Enabled = True

    End Sub

    Private Sub pvalues()
        If (chkANOVA.Checked Or chkEstimates.Checked) Then
            chkPvalues.Enabled = True
        Else
            'chkPvalues.Checked = False
            chkPvalues.Enabled = False
        End If
    End Sub

    Private Sub chkanovatable_checkedchanged(sender As Object, e As EventArgs) Handles chkANOVA.CheckedChanged
        pvalues()
    End Sub

    Private Sub chkestimates_checkedchanged(sender As Object, e As EventArgs) Handles chkEstimates.CheckedChanged
        pvalues()
    End Sub

    Private Sub chkFittedModel_CheckedChanged(sender As Object, e As EventArgs) Handles chkFittedModel.CheckedChanged
        If (chkFittedModel.Checked) Then
            chkPredictionInterval.Enabled = True
            chkGraphicsCLimits.Enabled = True
            chkGraphicsCLimits.Checked = True
        Else
            chkPredictionInterval.Enabled = False
            chkGraphicsCLimits.Checked = False
            chkGraphicsCLimits.Enabled = False
        End If
    End Sub

    Private Sub chkGraphicsCLimits_CheckedChanged(sender As Object, e As EventArgs) Handles chkGraphicsCLimits.CheckedChanged
        If (chkGraphicsCLimits.Checked) Then
            lblGraphicsCLevel.Enabled = True
            nudGraphicsCLevel.Enabled = True
            chkPredictionInterval.Checked = False
        Else
            lblGraphicsCLevel.Enabled = False
            nudGraphicsCLevel.Enabled = False
        End If
    End Sub

    Private Sub GraphicsConfidenceSE()
        If (chkGraphicsCLimits.Checked = True) Then
            clsRStat_smooth.AddParameter("se", "TRUE")
            clsRStat_smooth.AddParameter("level", nudGraphicsCLevel.Value)
        ElseIf (chkGraphicsCLimits.Checked = False) Then
            clsRStat_smooth.AddParameter("se", "FALSE")
            clsRStat_smooth.RemoveParameterByName("level")
        Else
            clsRStat_smooth.RemoveParameterByName("se")
            clsRStat_smooth.RemoveParameterByName("level")
        End If
    End Sub

    Private Sub chkDisplayCLimits_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayCLimits.CheckedChanged
        If (chkDisplayCLimits.Checked) Then
            lblDisplayCLevel.Enabled = True
            nudDisplayCLevel.Enabled = True
        Else
            lblDisplayCLevel.Enabled = False
            nudDisplayCLevel.Enabled = False
        End If
    End Sub

    Private Sub DisplayConfidence()
        If (chkDisplayCLimits.Checked = True) Then
            clsRCIFunction.AddParameter("level", nudDisplayCLevel.Value)
        ElseIf (chkDisplayCLimits.Checked = False) Then
            clsRCIFunction.AddParameter("level", "")
        Else
            clsRCIFunction.RemoveParameterByName("level")
        End If
    End Sub

    Private Sub chkPredictionInterval_CheckedChanged(sender As Object, e As EventArgs) Handles chkPredictionInterval.CheckedChanged
        If (chkPredictionInterval.Checked) Then
            chkGraphicsCLimits.Checked = False
        End If
    End Sub

    Public Sub RegOptions()
        If (chkANOVA.Checked) Then
            If (chkPvalues.Checked) Then
                AnovaTablePvalues()
            Else
                AnovaTable()
            End If
        End If
        If (chkEstimates.Checked) Then
            If (chkPvalues.Checked) Then
                EstimatesPvalues()
            Else
                Estimates()
            End If
        End If
        If (chkModel.Checked) Then
            Model()
        End If
        If (chkDisplayCLimits.Checked) Then
            ConfidenceInterval()
        End If
        If (chkFourinOne.Checked) Then
            FourPlots()
        End If
        If (chkFittedModel.Checked) Then
            If (chkGraphicsCLimits.Checked) Then
                FitConfidence()
            End If
            If (chkPredictionInterval.Checked) Then
                FitPrediction()
            End If
        End If
    End Sub
End Class