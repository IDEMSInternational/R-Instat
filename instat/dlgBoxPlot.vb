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
Public Class dlgBoxplot
    Private clsRggplotFunction As New RFunction
    'clsRggplotFunction is the global ggplot function, will be used as RFunction of the first RParameter of ucrBase.clsRSyntax (which has "+" as main command). It is emphasised as a public field as it is used/editted in the sdgLayerOptions. The link is operated via SetupLayer that sets sdgLayerOptions.clsGgplotFunction = dlgBoxPlot.clsRggplotFunction.
    Private clsRgeom_boxplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    'Similarly clsRgeom_boxplotFunction and clsRaesFunction (respectively the geom_boxplot function and the global aes function) are given through SetupLayer to sdgLayerOptions for edit. 
    Private bFirstLoad As Boolean = True

    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
    End Sub
    Public Sub SetCoordFlip()
        Dim clsTempRFunc As New RFunction
        If chkHorizontalBoxplot.Checked Then
            clsTempRFunc.SetRCommand("coord_flip")
            ucrBase.clsRsyntax.AddOperatorParameter("coord_flip", clsRFunc:=clsTempRFunc)
        Else
            ucrBase.clsRsyntax.RemoveOperatorParameter("coord_flip")
        End If
    End Sub

    Private Sub SetDefaults()
        clsRaesFunction.ClearParameters()
        clsRgeom_boxplotFunction.ClearParameters()
        ucrSelectorBoxPlot.Reset()
        ucrSelectorBoxPlot.Focus()
        ucrVariablesAsFactorForBoxplot.ResetControl()
        ucrSaveBoxplot.strPrefix = "Boxplot"
        chkHorizontalBoxplot.Checked = False
        chkVarwidth.Checked = False
        rdoBoxplot.Checked = True
        'These chk boxes add features to the BoxPlot when ticked. See SetCorrdFlip and chkVarwidth_CheckedChanged. By default they are unticked.
        ucrSaveBoxplot.Reset()
        sdgPlots.Reset()
        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
        SetXParameter()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        'clsRgeom_boxplotFunction.SetRCommand("geom_boxplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_boxplotFunction)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrBase.iHelpTopicID = 436

        ucrByFactorsReceiver.Selector = ucrSelectorBoxPlot
        ucrByFactorsReceiver.SetIncludedDataTypes({"factor"})

        ucrSecondFactorReceiver.Selector = ucrSelectorBoxPlot
        ucrSecondFactorReceiver.SetIncludedDataTypes({"factor"})


        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        sdgPlots.SetGgplotFunction(clsRggplotFunction)

        ucrVariablesAsFactorForBoxplot.SetFactorReceiver(ucrByFactorsReceiver)
        ucrVariablesAsFactorForBoxplot.SetSelector(ucrSelectorBoxPlot)
        ucrVariablesAsFactorForBoxplot.SetIncludedDataType({"numeric"})


        ucrSaveBoxplot.SetDataFrameSelector(ucrSelectorBoxPlot.ucrAvailableDataFrames)
        ucrBase.clsRsyntax.iCallType = 3
    End Sub

    Private Sub TestOkEnabled()
        If ucrVariablesAsFactorForBoxplot.IsEmpty OrElse (ucrSaveBoxplot.chkSaveGraph.Checked AndAlso ucrSaveBoxplot.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
        'Task: work on the link.
    End Sub

    Private Sub ucrSelectorBoxPlot_DataFrameChanged() Handles ucrSelectorBoxPlot.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorBoxPlot.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrByFactorsReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrByFactorsReceiver.SelectionChanged
        SetXParameter()
    End Sub

    Private Sub SetXParameter()
        If Not ucrByFactorsReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrByFactorsReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
    End Sub

    Private Sub ucrSecondFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrSecondFactorReceiver.SelectionChanged
        FillColourAes()
        'If Not ucrSecondFactorReceiver.IsEmpty Then
        '    clsRaesFunction.AddParameter("fill", ucrSecondFactorReceiver.GetVariableNames(False))
        'Else
        '    clsRaesFunction.RemoveParameterByName("fill")
        'End If
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
        'SetupLayer sends the components storing the plot info (clsRgeom_boxplotFunction, clsRggplotFunction, ...) of dlgBoxPlot through to sdgLayerOptions where these will be edited.
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_boxplotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        sdgLayerOptions.ShowDialog()
        'Coming from the sdgLayerOptions, clsRgeom_boxplot and others has been modified. One then needs to display these modifications on the dlgBoxPlot.
        If clsRgeom_boxplotFunction.GetParameter("varwidth") IsNot Nothing Then
            If clsRgeom_boxplotFunction.GetParameter("varwidth").strArgumentValue = "TRUE" Then
                chkVarwidth.Checked = True
                'Observe that changing the check of the chkVarwidth here doesn't trigger the checkchanged event.
            End If
        Else
            chkVarwidth.Checked = False
        End If

        'The aesthetics parameters on the main dialog are repopulated as required. 
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrByFactorsReceiver.Clear()
                Else
                    ucrByFactorsReceiver.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the vlue stored in the clsReasFunction in the multiplevariables case is "value", however that one shouldn't be written in the multiple variables receiver (otherwise it would stack all variables and the stack ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables independently from the multiple variables method ? Here if the receiver is actually in single mode, the variable "value" will still be given back, which throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForBoxplot.bSingleVariable) Then
                ucrVariablesAsFactorForBoxplot.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrSecondFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        'Question to be discussed: After running through the sdgLayerOptions, the clsCurrDataFrame parameters seem to have been cleared, such that in the multiple variable case, clsCurrDataFrame needs to be repopulated with "stack", "measure.vars" and "id.vars" parameters. Actually, even when repopulated, they are still not appearing in the script. ??
        'This resets the factor receiver and causes it to be cleared of the correct variable. We don't want this.
        'ucrVariablesAsFactorForBoxplot.SetReceiverStatus()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub chkHorizontalBoxplot_CheckedChanged(sender As Object, e As EventArgs) Handles chkHorizontalBoxplot.CheckedChanged
        SetCoordFlip()
    End Sub

    Private Sub UcrVariablesAsFactor1_SelectionChanged() Handles ucrVariablesAsFactorForBoxplot.SelectionChanged
        If Not ucrVariablesAsFactorForBoxplot.IsEmpty Then
            clsRaesFunction.AddParameter("y", ucrVariablesAsFactorForBoxplot.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("y")
        End If
        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
    End Sub

    Private Sub TempOptionsDisabledInMultipleVariablesCase()
        If ucrVariablesAsFactorForBoxplot.bSingleVariable Then
            cmdBoxPlotOptions.Enabled = True
            cmdOptions.Enabled = True
        Else
            cmdBoxPlotOptions.Enabled = False
            cmdOptions.Enabled = False
        End If
    End Sub
    Private Sub ucrSaveBoxplot_GraphNameChanged() Handles ucrSaveBoxplot.GraphNameChanged, ucrSaveBoxplot.SaveGraphCheckedChanged
        If ucrSaveBoxplot.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveBoxplot.strGraphName, strTempDataframe:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveBoxplot.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveBoxplot_ContentsChanged() Handles ucrSaveBoxplot.ContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub chkVarwidth_CheckedChanged(sender As Object, e As EventArgs) Handles chkVarwidth.CheckedChanged
        'If the Varwidth check box is ticked or unticked, the parameter "varwidth" is set to true or removed.
        If chkVarwidth.Checked = True Then
            clsRgeom_boxplotFunction.AddParameter("varwidth", "TRUE")
        Else clsRgeom_boxplotFunction.RemoveParameterByName("varwidth")
        End If
    End Sub

    Private Sub rdoBoxplot_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBoxplot.CheckedChanged, rdoJitter.CheckedChanged, rdoViolin.CheckedChanged
        'Sets appropriate geom function depending with selection 
        If rdoBoxplot.Checked Then
            clsRgeom_boxplotFunction.SetRCommand("geom_boxplot")
            chkHorizontalBoxplot.Text = "Horizontal Boxplot"
        ElseIf rdoJitter.Checked
            clsRgeom_boxplotFunction.SetRCommand("geom_jitter")
            chkHorizontalBoxplot.Text = "Horizontal Jitter Plot"
        Else
            clsRgeom_boxplotFunction.SetRCommand("geom_violin")
            chkHorizontalBoxplot.Text = "Horizontal Violin Plot"
        End If
        DisableVarWidth()
        FillColourAes()
    End Sub

    Private Sub DisableVarWidth()
        'Both vilon plot and Jitter plot can not have a varible width. User should not be able to check varible width
        If rdoViolin.Checked OrElse rdoJitter.Checked Then
            chkVarwidth.Visible = False
        Else
            chkVarwidth.Visible = True
        End If
    End Sub
    Private Sub FillColourAes()
        If (rdoBoxplot.Checked AndAlso Not ucrSecondFactorReceiver.IsEmpty) OrElse (rdoViolin.Checked AndAlso Not ucrSecondFactorReceiver.IsEmpty) Then

            clsRaesFunction.AddParameter("fill", ucrSecondFactorReceiver.GetVariableNames(False))
        ElseIf rdoJitter.Checked AndAlso Not ucrSecondFactorReceiver.IsEmpty Then

            clsRaesFunction.AddParameter("colour", ucrSecondFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("fill")
            clsRaesFunction.RemoveParameterByName("colour")
        End If
    End Sub
End Class