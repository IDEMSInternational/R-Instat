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
Public Class dlgBoxplot
    Private clsRggplotFunction As New RFunction
    'clsRggplotFunction is the global ggplot function, will be used as RFunction of the first RParameter of ucrBase.clsRSyntax (which has "+" as main command). It is emphasised as a public field as it is used/editted in the sdgLayerOptions. The link is operated via SetupLayer that sets sdgLayerOptions.clsGgplotFunction = dlgBoxPlot.clsRggplotFunction.
    Private clsRgeom_boxplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    'Similarly clsRgeom_boxplotFunction and clsRaesFunction (respectively the geom_boxplot function and the global aes function) are given through SetupLayer to sdgLayerOptions for edit. 
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrSelectorBoxPlot.SetRCode(clsRggplotFunction, bReset)

        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrChkVarwidth.SetRCode(clsRgeom_boxplotFunction, bReset)

        ucrVariablesAsFactorForBoxplot.SetRCode(clsRaesFunction, bReset)
        ucrByFactorsReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSecondFactorReceiver.SetRCode(clsRaesFunction, bReset)

    End Sub

    Public Sub SetCoordFlip()
        Dim clsTempRFunc As New RFunction
        If ucrChkHorizontalBoxplot.Checked Then
            clsTempRFunc.SetRCommand("coord_flip")
            ucrBase.clsRsyntax.AddOperatorParameter("coord_flip", clsRFunc:=clsTempRFunc)
        Else
            ucrBase.clsRsyntax.RemoveOperatorParameter("coord_flip")
        End If
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeom_boxplotFunction = New RFunction
        clsRaesFunction = New RFunction

        ucrSelectorBoxPlot.Reset()
        ucrSelectorBoxPlot.Focus()
        ucrSaveBoxplot.Reset()
        sdgPlots.Reset()

        'rdoBoxplot.Checked = True
        'These chk boxes add features to the BoxPlot when ticked. See SetCorrdFlip and chkVarwidth_CheckedChanged. By default they are unticked.


        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("boxplot", clsRFunctionParameter:=clsRgeom_boxplotFunction)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))


        clsRgeom_boxplotFunction.SetPackageName("ggplot2")
        clsRgeom_boxplotFunction.SetRCommand("geom_boxplot")

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 436
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorBoxPlot.SetParameter(New RParameter("data"), 0)
        ucrSelectorBoxPlot.SetParameterIsrfunction()

        ucrByFactorsReceiver.Selector = ucrSelectorBoxPlot
        ucrByFactorsReceiver.SetIncludedDataTypes({"factor"})
        ucrByFactorsReceiver.SetParameter(New RParameter("x"))
        ucrByFactorsReceiver.SetParameterIsString()
        ucrByFactorsReceiver.bWithQuotes = False

        ucrSecondFactorReceiver.Selector = ucrSelectorBoxPlot
        ucrSecondFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrSecondFactorReceiver.SetParameter(New RParameter("fill"))
        ucrSecondFactorReceiver.SetParameterIsString()
        ucrSecondFactorReceiver.bWithQuotes = False
        ucrSecondFactorReceiver.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrSecondFactorReceiver.bAddParameterIfEmpty = True

        ucrVariablesAsFactorForBoxplot.SetFactorReceiver(ucrByFactorsReceiver)
        ucrVariablesAsFactorForBoxplot.Selector = ucrSelectorBoxPlot
        ucrVariablesAsFactorForBoxplot.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorForBoxplot.SetParameter(New RParameter("y"))
        ucrVariablesAsFactorForBoxplot.SetParameterIsString()
        ucrVariablesAsFactorForBoxplot.bWithQuotes = False

        ucrChkVarwidth.SetText("Variable Width")
        ucrChkVarwidth.SetParameter(New RParameter("varwidth"))
        ucrChkVarwidth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkHorizontalBoxplot.SetText("Horizontal Boxplot")
        ucrPnlPlots.AddToLinkedControls(ucrChkVarwidth, {rdoBoxplot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveBoxplot.SetPrefix("Boxplot")
        ucrSaveBoxplot.SetIsComboBox()
        ucrSaveBoxplot.SetCheckBoxText("Save Graph")
        ucrSaveBoxplot.SetSaveTypeAsGraph()
        ucrSaveBoxplot.SetDataFrameSelector(ucrSelectorBoxPlot.ucrAvailableDataFrames)
        ucrSaveBoxplot.SetAssignToIfUncheckedValue("last_graph")

        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        sdgPlots.SetGgplotFunction(clsRggplotFunction)
    End Sub

    Private Sub ChangeSavePrefixAndChkText()
        If rdoBoxplot.Checked Then
            ucrSaveBoxplot.SetPrefix("Boxplot")
            ucrChkHorizontalBoxplot.Text = "Horizontal Boxplot"
        ElseIf rdoJitter.Checked Then
            ucrSaveBoxplot.SetPrefix("Jitter")
            ucrChkHorizontalBoxplot.Text = "Horizontal Jitter Plot"
        ElseIf rdoViolin.Checked Then
            ucrSaveBoxplot.SetPrefix("Violin")
            ucrChkHorizontalBoxplot.Text = "Horizontal Violin Plot"
        End If
    End Sub

    Private Sub TestOkEnabled()
        If ucrVariablesAsFactorForBoxplot.IsEmpty OrElse Not ucrSaveBoxplot.IsComplete Then
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

    Private Sub ucrSecondFactorReceiver_ControlContentsChanged() Handles ucrSecondFactorReceiver.ControlContentsChanged
        FillColourAes()
    End Sub
    Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
        'SetupLayer sends the components storing the plot info (clsRgeom_boxplotFunction, clsRggplotFunction, ...) of dlgBoxPlot through to sdgLayerOptions where these will be edited.
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_boxplotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        sdgLayerOptions.ShowDialog()
        'Coming from the sdgLayerOptions, clsRgeom_boxplot and others has been modified. One then needs to display these modifications on the dlgBoxPlot.
        If clsRgeom_boxplotFunction.GetParameter("varwidth") IsNot Nothing Then
            If clsRgeom_boxplotFunction.GetParameter("varwidth").strArgumentValue = "TRUE" Then
                ' chkVarwidth.Checked = True
                'Observe that changing the check of the chkVarwidth here doesn't trigger the checkchanged event.
            End If
        Else
            'chkVarwidth.Checked = False
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

    Private Sub chkHorizontalBoxplot_CheckedChanged(sender As Object, e As EventArgs)
        SetCoordFlip()
    End Sub

    Private Sub ucrVariablesAsFactorForBoxplot_ControlContentsChanged() Handles ucrVariablesAsFactorForBoxplot.ControlContentsChanged
        TempOptionsDisabledInMultipleVariablesCase()
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
    
    Private Sub rdoBoxplot_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBoxplot.CheckedChanged, rdoJitter.CheckedChanged, rdoViolin.CheckedChanged
        'Sets appropriate geom function depending with selection 
        If rdoBoxplot.Checked Then
            clsRgeom_boxplotFunction.SetRCommand("geom_boxplot")
        ElseIf rdoJitter.Checked
            clsRgeom_boxplotFunction.SetRCommand("geom_jitter")
        Else
            clsRgeom_boxplotFunction.SetRCommand("geom_violin")
        End If
        DisableVarWidth()
        FillColourAes()
    End Sub

    Private Sub DisableVarWidth()
        'use linked objects here
        'Both vilon plot and Jitter plot can not have a varible width. User should not be able to check varible width
        If rdoViolin.Checked OrElse rdoJitter.Checked Then
            ' chkVarwidth.Visible = False
        Else
            'chkVarwidth.Visible = True
        End If
    End Sub
    Private Sub FillColourAes()
        If (rdoBoxplot.Checked AndAlso Not ucrSecondFactorReceiver.IsEmpty) OrElse (rdoViolin.Checked AndAlso Not ucrSecondFactorReceiver.IsEmpty) Then
            ucrSecondFactorReceiver.ChangeParameterName("fill")
        ElseIf rdoJitter.Checked AndAlso Not ucrSecondFactorReceiver.IsEmpty Then
            ucrSecondFactorReceiver.ChangeParameterName("colour")
        End If
    End Sub

    Private Sub ucrPnlPlots_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlPlots.ControlContentsChanged
        ChangeSavePrefixAndChkText()
    End Sub
End Class