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
Public Class sdgSimpleRegOptions
    Public clsRModelFunction As RFunction
    Public clsRDataFrame As ucrDataFrame
    Public clsRYVariable, clsRXVariable As ucrReceiverSingle
    Public clsRGraphics As New RSyntax
    Public clsRaovFunction, clsRaovpvalFunction, clsRestpvalFunction, clsRResidualPlotsFunction, clsRgeom_point, clsRPredFunction, clsRDFFunction, clsRFittedValues, clsRWriteFitted, clsRResiduals, clsRWriteResiduals, clsRStdResiduals, clsRWriteStdResiduals, clsRLeverage, clsRWriteLeverage As New RFunction
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

    Public Sub ResidualPlots()
        clsRGraphics.SetOperation("+")
        clsRResidualPlotsFunction.SetPackageName("ggplot2")
        clsRResidualPlotsFunction.SetRCommand("autoplot")
        clsRResidualPlotsFunction.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        clsRgeom_point.SetRCommand("geom_point")
    End Sub

    Private Sub FittedModel()
        clsRggplotFunction.SetPackageName("visreg")
        clsRggplotFunction.SetRCommand("visreg")
        clsRggplotFunction.AddParameter("fit", clsRFunctionParameter:=clsRModelFunction)
        If rdoConditional.Checked Then
            clsRggplotFunction.AddParameter("type", Chr(34) & "conditional" & Chr(34))
        ElseIf rdoContrast.Checked Then
            clsRggplotFunction.AddParameter("type", Chr(34) & "contrast" & Chr(34))
        End If
        If rdoLinear.Checked Then
            clsRggplotFunction.AddParameter("scale", Chr(34) & "linear" & Chr(34))
        ElseIf rdoResponse.Checked Then
            clsRggplotFunction.AddParameter("scale", Chr(34) & "response" & Chr(34))
        End If
        If chkJitter.Checked Then
            clsRggplotFunction.AddParameter("jitter", "TRUE")
        Else
            clsRggplotFunction.RemoveParameterByName("jitter")
        End If
        clsRggplotFunction.AddParameter("alpha", nudGraphicsCLevel.Value)
        clsRggplotFunction.AddParameter("whitespace", nudWhiteSpace.Value)
        If chkPartial.Checked Then
            clsRggplotFunction.AddParameter("partial", "TRUE")
        Else
            clsRggplotFunction.AddParameter("partial", "FALSE")
        End If
        If chkConfIntervalband.Checked = False Then
            clsRggplotFunction.AddParameter("band", "FALSE")
        Else
            clsRggplotFunction.RemoveParameterByName("band")
        End If
        If chkRugs.Checked Then
            If rdo1.Checked Then
                clsRggplotFunction.AddParameter("rug", 1)
            ElseIf rdo2.Checked Then
                clsRggplotFunction.AddParameter("rug", 2)
            End If
        Else
            clsRggplotFunction.RemoveParameterByName("rug")
        End If
        clsRggplotFunction.AddParameter("gg", "TRUE")
    End Sub

    Private Sub ConfidenceInterval()
        clsRCIFunction.SetRCommand("confint")
        clsRCIFunction.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        DisplayConfidence()
        frmMain.clsRLink.RunScript(clsRCIFunction.ToScript(), 2)
    End Sub

    Private Sub chkPartial_CheckedChanged(sender As Object, e As EventArgs) Handles chkPartial.CheckedChanged
        FittedModel()
    End Sub

    Private Sub chkRugs_CheckedChanged(sender As Object, e As EventArgs) Handles chkRugs.CheckedChanged
        If chkRugs.Checked Then
            grpRugs.Enabled = True
            rdoPartial.Checked = True
        End If
        FittedModel()
    End Sub

    Private Sub rdoPartial_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPartial.CheckedChanged
        FittedModel()
    End Sub

    Private Sub rdo1_CheckedChanged(sender As Object, e As EventArgs) Handles rdo1.CheckedChanged
        FittedModel()
    End Sub

    Private Sub rdo2_CheckedChanged(sender As Object, e As EventArgs) Handles rdo2.CheckedChanged
        FittedModel()
    End Sub

    Private Sub rdoConditional_CheckedChanged(sender As Object, e As EventArgs) Handles rdoConditional.CheckedChanged
        FittedModel()
    End Sub

    Private Sub rdoContrast_CheckedChanged(sender As Object, e As EventArgs) Handles rdoContrast.CheckedChanged
        FittedModel()
    End Sub

    Private Sub chkMultiplePlots_CheckedChanged(sender As Object, e As EventArgs) Handles chkMultiplePlots.CheckedChanged
        GraphMultiplePlots()
    End Sub

    Private Sub GraphMultiplePlots()
        If chkMultiplePlots.Checked Then
            chkFittedModel.Checked = False
            chkIndividualPlots.Checked = False
            grpMultiplePlots.Enabled = True
            rdoFourPlots.Checked = True
        Else
            grpMultiplePlots.Enabled = False
        End If
    End Sub

    Private Sub GraphIndividualPlots()
        If chkIndividualPlots.Checked Then
            chkFittedModel.Checked = False
            chkMultiplePlots.Checked = False
            grpIndividualPlots.Enabled = True
            rdoResidualsFitted.Checked = True
        Else
            grpIndividualPlots.Enabled = False
        End If
    End Sub

    Private Sub chkIndividualPlots_CheckedChanged(sender As Object, e As EventArgs) Handles chkIndividualPlots.CheckedChanged
        GraphIndividualPlots()
    End Sub

    Private Sub rdoMultiplePlots(sender As Object, e As EventArgs) Handles rdoFourPlots.CheckedChanged, rdoSixPlots3Rows.CheckedChanged, rdoSixPlots2Rows.CheckedChanged
        ResidualPlots()
        If rdoFourPlots.Checked Then
            clsRResidualPlotsFunction.AddParameter("ncol", 2)
            clsRResidualPlotsFunction.RemoveParameterByName("which")
            clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
            clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
        End If
        If rdoSixPlots2Rows.Checked Then
            clsRResidualPlotsFunction.AddParameter("ncol", 3)
            clsRResidualPlotsFunction.AddParameter("which", "1:6")
            clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
            clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
        End If
        If rdoSixPlots3Rows.Checked Then
            clsRResidualPlotsFunction.AddParameter("ncol", 2)
            clsRResidualPlotsFunction.AddParameter("which", "1:6")
            clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
            clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
        End If
    End Sub

    Private Sub rdoQQ_CheckedChanged(sender As Object, e As EventArgs) Handles rdoQQ.CheckedChanged
        clsRResidualPlotsFunction.RemoveParameterByName("ncol")
        clsRResidualPlotsFunction.AddParameter("which", 2)
        clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
    End Sub
    Private Sub rdoResidualsFitted_CheckedChanged(sender As Object, e As EventArgs) Handles rdoResidualsFitted.CheckedChanged
        clsRResidualPlotsFunction.RemoveParameterByName("ncol")
        clsRResidualPlotsFunction.AddParameter("which", 1)
        clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
    End Sub

    Private Sub rdoResidualsLeverage_CheckedChanged(sender As Object, e As EventArgs) Handles rdoResidualsLeverage.CheckedChanged
        clsRResidualPlotsFunction.RemoveParameterByName("ncol")
        clsRResidualPlotsFunction.AddParameter("which", 5)
        clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
    End Sub

    Private Sub rdoCooksDistanceLeverage_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCooksDistanceLeverage.CheckedChanged
        clsRResidualPlotsFunction.RemoveParameterByName("ncol")
        clsRResidualPlotsFunction.AddParameter("which", 6)
        clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
    End Sub

    Private Sub rdoCooksDistance_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCooksDistance.CheckedChanged
        clsRResidualPlotsFunction.RemoveParameterByName("ncol")
        clsRResidualPlotsFunction.AddParameter("which", 4)
        clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
    End Sub

    Private Sub rdoScaleLocation_CheckedChanged(sender As Object, e As EventArgs) Handles rdoScaleLocation.CheckedChanged
        clsRResidualPlotsFunction.RemoveParameterByName("ncol")
        clsRResidualPlotsFunction.AddParameter("which", 3)
        clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
    End Sub

    Private Sub FittedModel_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfIntervalband.CheckedChanged, chkJitter.CheckedChanged, chkPartial.CheckedChanged, rdoLinear.CheckedChanged, rdoResponse.CheckedChanged, rdoContrast.CheckedChanged, rdoConditional.CheckedChanged, nudWhiteSpace.ValueChanged, nudGraphicsCLevel.ValueChanged, rdoPartial.CheckedChanged, rdo1.CheckedChanged, rdo2.CheckedChanged
        FittedModel()
    End Sub

    Private Sub CheckRugs_CheckedChanged(sender As Object, e As EventArgs) Handles chkRugs.CheckedChanged
        GraphFittedModel()
    End Sub

    Private Sub DisplayTabDefaults()
        chkANOVA.Checked = True
        chkModel.Checked = True
        chkEstimates.Checked = True
        chkPvalues.Enabled = True
        chkPvalues.Checked = True
        chkDisplayCLimits.Checked = False
        lblDisplayCLevel.Enabled = False
        nudDisplayCLevel.Enabled = False
    End Sub

    Private Sub SaveTab()
        ucrFittedColumnName.SetPrefix("Fitted")
        ucrFittedColumnName.SetItemsTypeAsColumns()
        ucrFittedColumnName.SetDefaultTypeAsColumn()
        ucrFittedColumnName.SetDataFrameSelector(clsRDataFrame)
        ucrFittedColumnName.SetValidationTypeAsRVariable()
        ucrResidualsColumnName.SetPrefix("Resids")
        ucrResidualsColumnName.SetItemsTypeAsColumns()
        ucrResidualsColumnName.SetDefaultTypeAsColumn()
        ucrResidualsColumnName.SetDataFrameSelector(clsRDataFrame)
        ucrResidualsColumnName.SetValidationTypeAsRVariable()
        ucrStdResidualsColumnName.SetPrefix("Sresids")
        ucrStdResidualsColumnName.SetItemsTypeAsColumns()
        ucrStdResidualsColumnName.SetDefaultTypeAsColumn()
        ucrStdResidualsColumnName.SetDataFrameSelector(clsRDataFrame)
        ucrStdResidualsColumnName.SetValidationTypeAsRVariable()
        ucrLeverageColumnName.SetPrefix("Lever")
        ucrLeverageColumnName.SetItemsTypeAsColumns()
        ucrLeverageColumnName.SetDefaultTypeAsColumn()
        ucrLeverageColumnName.SetDataFrameSelector(clsRDataFrame)
        ucrLeverageColumnName.SetValidationTypeAsRVariable()
        ucrFittedColumnName.Enabled = False
        ucrResidualsColumnName.Enabled = False
        ucrStdResidualsColumnName.Enabled = False
        ucrLeverageColumnName.Enabled = False
        chkFittedValues.Checked = False
        chkLeverage.Checked = False
        chkStdResiduals.Checked = False
        chkResiduals.Checked = False
    End Sub

    Private Sub GraphsTabDefaults()
        GraphFittedModel()
        GraphMultiplePlots()
        GraphIndividualPlots()
    End Sub

    Public Sub SetDefaults()
        DisplayTabDefaults()
        SaveTab()
        GraphsTabDefaults()
        chkFittedModel.Checked = False
        chkMultiplePlots.Checked = False
        chkIndividualPlots.Checked = False
    End Sub

    Private Sub pvalues()
        If (chkANOVA.Checked Or chkEstimates.Checked) Then
            chkPvalues.Enabled = True
        Else
            chkPvalues.Enabled = False
        End If
    End Sub

    Private Sub chkanovatable_checkedchanged(sender As Object, e As EventArgs) Handles chkANOVA.CheckedChanged
        pvalues()
    End Sub

    Private Sub chkestimates_checkedchanged(sender As Object, e As EventArgs) Handles chkEstimates.CheckedChanged
        pvalues()
    End Sub

    Private Sub GraphFittedModel()
        If (chkFittedModel.Checked) Then
            grpPlotType.Enabled = True
            grpScale.Enabled = True
            nudDisplayCLevel.Enabled = True
            nudWhiteSpace.Enabled = True
            chkPartial.Enabled = True
            chkRugs.Enabled = True
            chkJitter.Enabled = True
            chkConfIntervalband.Enabled = True
            chkIndividualPlots.Checked = False
            chkMultiplePlots.Checked = False
        Else
            grpPlotType.Enabled = False
            grpScale.Enabled = False
            nudDisplayCLevel.Enabled = False
            nudWhiteSpace.Enabled = False
            chkPartial.Enabled = False
            chkRugs.Enabled = False
            chkJitter.Enabled = False
            chkConfIntervalband.Enabled = False
        End If
        rdoConditional.Checked = True
        rdoLinear.Checked = True
        nudDisplayCLevel.Value = 0.05
        nudWhiteSpace.Value = 0.2
        rdoPartial.Checked = True
        If chkRugs.Checked = True Then
            grpRugs.Enabled = True
        Else
            grpRugs.Enabled = False
        End If
        If (chkDisplayCLimits.Checked) Then
            lblDisplayCLevel.Enabled = True
            nudDisplayCLevel.Enabled = True
        Else
            lblDisplayCLevel.Enabled = False
            nudDisplayCLevel.Enabled = False
        End If

    End Sub

    Private Sub chkFittedModel_CheckedChanged(sender As Object, e As EventArgs) Handles chkFittedModel.CheckedChanged
        GraphFittedModel()
    End Sub

    Private Sub chkDisplayCLimits_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayCLimits.CheckedChanged
        GraphFittedModel()
        DisplayConfidence()
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
        If (rdoFourPlots.Checked Or rdoSixPlots2Rows.Checked Or rdoSixPlots3Rows.Checked Or rdoResidualsFitted.Checked Or rdoQQ.Checked Or rdoResidualsLeverage.Checked Or rdoScaleLocation.Checked Or rdoCooksDistance.Checked Or rdoCooksDistanceLeverage.Checked) Then
            frmMain.clsRLink.RunScript(clsRGraphics.GetScript, 3)
        End If
        If (chkFittedModel.Checked) Then
            frmMain.clsRLink.RunScript(clsRggplotFunction.ToScript(), 3)
        End If
        If chkFittedValues.Checked Then
            FittedValues()
            frmMain.clsRLink.RunScript(clsRWriteFitted.ToScript(), 3)
        End If
        If chkResiduals.Checked Then
            Residuals()
            frmMain.clsRLink.RunScript(clsRWriteResiduals.ToScript(), 3)
        End If
        If chkStdResiduals.Checked Then
            StdResiduals()
            frmMain.clsRLink.RunScript(clsRWriteStdResiduals.ToScript(), 3)
        End If
        If chkLeverage.Checked Then
            Leverage()
            frmMain.clsRLink.RunScript(clsRWriteLeverage.ToScript(), 3)
        End If
    End Sub

    Private Sub ucrFittedColumnName_NameChanged() Handles ucrFittedColumnName.NameChanged
        FittedValues()
    End Sub

    Private Sub FittedValues()
        clsRFittedValues.SetRCommand("fitted")
        clsRFittedValues.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        clsRWriteFitted.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsRWriteFitted.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        clsRWriteFitted.AddParameter("col_name", Chr(34) & ucrFittedColumnName.GetText & Chr(34))
        clsRWriteFitted.AddParameter("col_data", clsRFunctionParameter:=clsRFittedValues)
    End Sub

    Private Sub ucrResidualsColumnName_NameChanged() Handles ucrResidualsColumnName.NameChanged
        Residuals()
    End Sub

    Private Sub Residuals()
        clsRResiduals.SetRCommand("resid")
        clsRResiduals.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        clsRWriteResiduals.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsRWriteResiduals.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        clsRWriteResiduals.AddParameter("col_name", Chr(34) & ucrResidualsColumnName.GetText & Chr(34))
        clsRWriteResiduals.AddParameter("col_data", clsRFunctionParameter:=clsRResiduals)
    End Sub

    Private Sub ucrStdResidualsColumnName_NameChanged() Handles ucrStdResidualsColumnName.NameChanged
        StdResiduals()
    End Sub

    Private Sub StdResiduals()
        clsRStdResiduals.SetRCommand("rstandard")
        clsRStdResiduals.AddParameter("model", clsRFunctionParameter:=clsRModelFunction)
        clsRWriteStdResiduals.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsRWriteStdResiduals.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        clsRWriteStdResiduals.AddParameter("col_name", Chr(34) & ucrStdResidualsColumnName.GetText & Chr(34))
        clsRWriteStdResiduals.AddParameter("col_data", clsRFunctionParameter:=clsRStdResiduals)
    End Sub

    Private Sub ucrLeverageColumnName_NameChanged() Handles ucrLeverageColumnName.NameChanged
        Leverage()
    End Sub

    Private Sub Leverage()
        clsRLeverage.SetRCommand("hatvalues")
        clsRLeverage.AddParameter("model", clsRFunctionParameter:=clsRModelFunction)
        clsRWriteLeverage.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsRWriteLeverage.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        clsRWriteLeverage.AddParameter("col_name", Chr(34) & ucrLeverageColumnName.GetText & Chr(34))
        clsRWriteLeverage.AddParameter("col_data", clsRFunctionParameter:=clsRLeverage)
    End Sub

    Private Sub chkLeverage_CheckedChanged(sender As Object, e As EventArgs) Handles chkLeverage.CheckedChanged
        If chkLeverage.Checked Then
            ucrLeverageColumnName.Enabled = True
        Else
            ucrLeverageColumnName.Enabled = False
        End If
    End Sub

    Private Sub chkResiduals_CheckedChanged(sender As Object, e As EventArgs) Handles chkResiduals.CheckedChanged
        If chkResiduals.Checked Then
            ucrResidualsColumnName.Enabled = True
        Else
            ucrResidualsColumnName.Enabled = False
        End If
    End Sub

    Private Sub chkStdResiduals_CheckedChanged(sender As Object, e As EventArgs) Handles chkStdResiduals.CheckedChanged
        If chkStdResiduals.Checked Then
            ucrStdResidualsColumnName.Enabled = True
        Else
            ucrStdResidualsColumnName.Enabled = False
        End If
    End Sub

    Private Sub chkFittedValues_CheckedChanged(sender As Object, e As EventArgs) Handles chkFittedValues.CheckedChanged
        If chkFittedValues.Checked Then
            ucrFittedColumnName.Enabled = True
        Else
            ucrFittedColumnName.Enabled = False
        End If
    End Sub
End Class