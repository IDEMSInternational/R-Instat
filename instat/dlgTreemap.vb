' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations

Public Class dlgTreemap
    Private clsBaseOperator As New ROperator

    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction
    Private clsSummariseFunction As New RFunction
    Private clsSummaryFunction As New RFunction

    Private clsGgplotFunction As New RFunction
    Private clsGeomTreemapFunction As New RFunction
    Private clsGeomTreemapAesFunction As New RFunction
    Private clsGeomTreemapTextFunction As New RFunction
    Private clsGeomTreemapTextAesFunction As New RFunction

    Private clsPaste0Function As New RFunction
    Private clsDollarFunction As New RFunction

    Private clsLocalAesFunction As New RFunction

    Private clsRCoordPolarParam As New RParameter
    Private clsLabsFunction As New RFunction
    Private clsXlabFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsThemeFuction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)

    Private strIdentifier As String = "Identifier"
    Private strIdentifierAndWeighty As String = "Identifier & Weight"
    Private strWeight As String = "Weight"
    Private strNone As String = "None"

    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private bRCodeSet As Boolean = False
    Private bResetSubdialog As Boolean = True

    Private Sub dlgTreemap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        'ucrBase.iHelpTopicID = 

        ucrPnlDataType.AddRadioButton(rdoPrimary)
        ucrPnlDataType.AddRadioButton(rdoSummary)
        ucrPnlDataType.AddParameterPresentCondition(rdoPrimary, "group_by", True)
        ucrPnlDataType.AddParameterPresentCondition(rdoSummary, "group_by", False)

        ucrSelectorTreemap.SetParameter(New RParameter("data", 0))
        ucrSelectorTreemap.SetParameterIsrfunction()

        ucrReceiverIdentifier.Selector = ucrSelectorTreemap
        ucrReceiverIdentifier.SetParameter(New RParameter("0", 0, bNewIncludeArgumentName:=False))
        ucrReceiverIdentifier.bWithQuotes = False
        ucrReceiverIdentifier.SetParameterIsString()

        ucrReceiverWeightBy.Selector = ucrSelectorTreemap
        ucrReceiverWeightBy.SetIncludedDataTypes({"numeric"})
        ucrReceiverWeightBy.strSelectorHeading = "Numerics"
        ucrReceiverWeightBy.SetParameter(New RParameter("area", 1))
        ucrReceiverWeightBy.bWithQuotes = False
        ucrReceiverWeightBy.SetParameterIsString()
        ucrReceiverWeightBy.SetValuesToIgnore({".n"})

        ucrInputSummary.SetItems({"sum", "mean", "min", "max"})
        ucrInputSummary.AddQuotesIfUnrecognised = False
        ucrInputSummary.SetLinkedDisplayControl(lblSummary)
        ucrInputSummary.SetValidationTypeAsRVariable()

        ucrChkIsCurrency.SetText("Is Currency")
        ucrChkIsCurrency.SetParameter(New RParameter("dollar", iNewPosition:=2, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkIsCurrency.AddToLinkedControls(ucrInputSymbol, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputSymbol.SetParameter(New RParameter("prefix", 3))
        ucrInputSymbol.SetLinkedDisplayControl(lblSymbol)

        ucrInputLabel.SetItems({strIdentifier, strIdentifierAndWeighty, strWeight, strNone})
        ucrInputLabel.AddParameterPresentCondition(strIdentifier, "identifier")
        ucrInputLabel.AddParameterPresentCondition(strIdentifier, "\n", False)
        ucrInputLabel.AddParameterPresentCondition(strIdentifierAndWeighty, "\n")
        ucrInputLabel.AddParameterPresentCondition(strWeight, "weight")
        ucrInputLabel.AddParameterPresentCondition(strWeight, "\n", False)
        ucrInputLabel.AddParameterPresentCondition(strNone, "identifier", False)
        ucrInputLabel.AddParameterPresentCondition(strNone, "weight", False)
        ucrInputLabel.SetDropDownStyleAsNonEditable()

        ucrReceiverFill.Selector = ucrSelectorTreemap
        ucrReceiverFill.SetParameter(New RParameter("fill", 3))
        ucrReceiverFill.bWithQuotes = False
        ucrReceiverFill.SetParameterIsString()

        ucrColourTile.SetParameter(New RParameter("fill", 3))
        ucrColourTile.SetColours()

        ucrColourText.SetParameter(New RParameter("colour", 3))
        ucrColourText.SetColours()

        ucrSaveTreemap.SetIsComboBox()
        ucrSaveTreemap.SetCheckBoxText("Save Treemap")
        ucrSaveTreemap.SetDataFrameSelector(ucrSelectorTreemap.ucrAvailableDataFrames)
        ucrSaveTreemap.SetSaveTypeAsGraph()
        ucrSaveTreemap.SetPrefix("tree_map")
        ucrSaveTreemap.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsPipeOperator = New ROperator
        clsGroupByFunction = New RFunction
        clsSummariseFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsGgplotFunction = New RFunction
        clsGeomTreemapFunction = New RFunction
        clsGeomTreemapAesFunction = New RFunction
        clsGeomTreemapTextFunction = New RFunction
        clsGeomTreemapTextAesFunction = New RFunction
        clsPaste0Function = New RFunction
        clsDollarFunction = New RFunction
        clsLocalAesFunction = New RFunction
        clsRCoordPolarParam = New RParameter
        clsLabsFunction = New RFunction
        clsXlabFunction = New RFunction
        clsYlabFunction = New RFunction
        clsXScalecontinuousFunction = New RFunction
        clsYScalecontinuousFunction = New RFunction
        clsRFacetFunction = New RFunction
        clsThemeFuction = New RFunction
        dctThemeFunctions = New Dictionary(Of String, RFunction)

        bResetSubdialog = True

        ucrSelectorTreemap.Reset()
        ucrSelectorTreemap.SetGgplotFunction(clsBaseOperator)
        ucrReceiverIdentifier.SetMeAsReceiver()
        ucrSaveTreemap.Reset()

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
        clsPipeOperator.AddParameter("summarise", clsRFunctionParameter:=clsGroupByFunction, iPosition:=2)

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsSummariseFunction.SetPackageName("dplyr")
        clsSummariseFunction.SetRCommand("summarise")
        clsSummariseFunction.AddParameter(".n", "n()", iPosition:=0)

        clsSummaryFunction.SetRCommand("sum")
        clsSummaryFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsGeomTreemapFunction, iPosition:=2)

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")
        clsGgplotFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomTreemapAesFunction, iPosition:=1)

        clsGeomTreemapAesFunction.SetPackageName("ggplot2")
        clsGeomTreemapAesFunction.SetRCommand("aes")

        clsGeomTreemapFunction.SetPackageName("treemapify")
        clsGeomTreemapFunction.SetRCommand("geom_treemap")
        clsGeomTreemapFunction.AddParameter("fill", Chr(34) & "brown" & Chr(34), iPosition:=2)

        clsGeomTreemapTextFunction.SetPackageName("treemapify")
        clsGeomTreemapTextFunction.SetRCommand("geom_treemap_text")
        clsGeomTreemapTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomTreemapTextAesFunction, iPosition:=0)
        clsGeomTreemapTextFunction.AddParameter("colour", Chr(34) & "white" & Chr(34), iPosition:=2)

        clsGeomTreemapTextAesFunction.SetPackageName("ggplot2")
        clsGeomTreemapTextAesFunction.SetRCommand("aes")
        clsGeomTreemapTextAesFunction.AddParameter("label", clsRFunctionParameter:=clsPaste0Function, iPosition:=2)

        clsPaste0Function.SetRCommand("paste0")
        clsPaste0Function.AddParameter("identifier", ucrReceiverIdentifier.GetVariableNames(), iPosition:=0)

        clsDollarFunction.SetPackageName("scales")
        clsDollarFunction.SetRCommand("dollar")
        clsDollarFunction.AddParameter("prefix", Chr(34) & "$" & Chr(34), iPosition:=3)

        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXlabFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsThemeFuction = GgplotDefaults.clsDefaultThemeFunction.Clone
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalAesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTreemap.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        ucrReceiverWeightBy.AddAdditionalCodeParameterPair(clsSummaryFunction, New RParameter("x", iNewPosition:=0, bNewIncludeArgumentName:=False))

        ucrPnlDataType.SetRCode(clsPipeOperator, bReset)
        ucrSelectorTreemap.SetRCode(clsPipeOperator, bReset)
        ucrReceiverIdentifier.SetRCode(clsGroupByFunction, bReset)
        ucrReceiverWeightBy.SetRCode(clsGeomTreemapAesFunction, bReset)
        ucrChkIsCurrency.SetRCode(clsPaste0Function, bReset)
        ucrInputSymbol.SetRCode(clsDollarFunction, bReset)
        ucrInputLabel.SetRCode(clsPaste0Function, bReset)
        ucrReceiverFill.SetRCode(clsGeomTreemapAesFunction, bReset)
        ucrColourTile.SetRCode(clsGeomTreemapFunction, bReset)
        ucrColourText.SetRCode(clsGeomTreemapTextFunction, bReset)
        If bReset Then
            ucrInputLabel.SetText(strIdentifier)
        End If
        bRCodeSet = True
        ucrInputSummary.SetName(clsSummaryFunction.strRCommand)
        SetLabel()
        WeightControls()
        SetPipeAssignTo()
        PanelSettings()
    End Sub

    Private Sub TestOkEnabled()
        If rdoPrimary.Checked Then
            If Not ucrReceiverIdentifier.IsEmpty() AndAlso ucrSaveTreemap.IsComplete() Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoSummary.Checked Then
            If Not ucrReceiverWeightBy.IsEmpty() AndAlso ucrSaveTreemap.IsComplete() Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub CoreControls_ContentsChanged() Handles ucrReceiverIdentifier.ControlContentsChanged, ucrSaveTreemap.ControlContentsChanged, ucrPnlDataType.ControlContentsChanged, ucrReceiverWeightBy.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlDataType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDataType.ControlValueChanged
        PanelSettings()
    End Sub

    Private Sub PanelSettings()
        If bRCodeSet Then
            If rdoPrimary.Checked Then
                ' Cannot have facets in Primary data case since columns are not carried.
                clsBaseOperator.RemoveParameterByName("facets")
                lblIdentifier.Text = "Identifier:"
                lblWeightBy.Text = "Weight By (Optional):"
                clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
                clsPipeOperator.AddParameter("summarise", clsRFunctionParameter:=clsSummariseFunction, iPosition:=2)
            ElseIf rdoSummary.Checked Then
                lblIdentifier.Text = "Identifier (Optional):"
                lblWeightBy.Text = "Weight By:"
                clsPipeOperator.RemoveParameterByName("group_by")
                clsPipeOperator.RemoveParameterByName("summarise")
            End If
            SetPipeAssignTo()
            WeightControls()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub ucrInputLabel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLabel.ControlValueChanged
        SetLabel()
    End Sub

    Private Sub SetLabel()
        If bRCodeSet Then
            clsPaste0Function.ClearParameters()
            Select Case ucrInputLabel.GetText()
                Case strIdentifier
                    clsBaseOperator.AddParameter("geomfunc2", clsRFunctionParameter:=clsGeomTreemapTextFunction, iPosition:=3)
                    clsGeomTreemapTextAesFunction.AddParameter("label", clsRFunctionParameter:=clsPaste0Function, iPosition:=2)
                    clsPaste0Function.AddParameter("identifier", ucrReceiverIdentifier.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                Case strIdentifierAndWeighty, strWeight
                    clsBaseOperator.AddParameter("geomfunc2", clsRFunctionParameter:=clsGeomTreemapTextFunction, iPosition:=3)
                    clsGeomTreemapTextAesFunction.AddParameter("label", clsRFunctionParameter:=clsPaste0Function, iPosition:=2)
                    If ucrInputLabel.GetText() = strIdentifierAndWeighty Then
                        clsPaste0Function.AddParameter("identifier", ucrReceiverIdentifier.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                        clsPaste0Function.AddParameter("\n", Chr(34) & "\n" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
                    End If
                    If ucrChkIsCurrency.Checked Then
                        clsPaste0Function.AddParameter("dollar", clsRFunctionParameter:=clsDollarFunction, iPosition:=2, bIncludeArgumentName:=False)
                        clsDollarFunction.AddParameter("x", ucrReceiverWeightBy.GetVariableNames(False), iPosition:=0)
                        clsPaste0Function.RemoveParameterByName("weight")
                    Else
                        clsPaste0Function.AddParameter("weight", ucrReceiverWeightBy.GetVariableNames(False), iPosition:=2, bIncludeArgumentName:=False)
                        clsPaste0Function.RemoveParameterByName("dollar")
                    End If
                Case strNone
                    clsBaseOperator.RemoveParameterByName("geomfunc2")
                    clsGeomTreemapTextAesFunction.RemoveParameterByName("label")
            End Select
        End If
    End Sub

    Private Sub ucrReceiverFill_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFill.ControlValueChanged
        If ucrReceiverFill.IsEmpty() Then
            clsGeomTreemapFunction.AddParameter("fill", ucrColourTile.GetText(), iPosition:=3)
            ucrColourTile.Enabled = True
        Else
            clsGeomTreemapFunction.RemoveParameterByName("fill")
            ucrColourTile.Enabled = False
        End If
        clsScaleColourViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsScaleFillViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
    End Sub

    Private Sub ucrReceivers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverIdentifier.ControlValueChanged, ucrReceiverWeightBy.ControlValueChanged, ucrPnlDataType.ControlValueChanged
        If rdoPrimary.Checked Then
            If ucrReceiverWeightBy.IsEmpty Then
                clsGeomTreemapAesFunction.AddParameter("area", ".n", iPosition:=0)
            Else
                clsGeomTreemapAesFunction.AddParameter("area", ucrReceiverWeightBy.GetVariableNames(False), iPosition:=0)
            End If
        ElseIf rdoSummary.Checked Then
            clsGeomTreemapAesFunction.AddParameter("area", ucrReceiverWeightBy.GetVariableNames(False), iPosition:=0)
        End If
        SetLabel()
    End Sub

    Private Sub ucrReceiverWeightBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWeightBy.ControlValueChanged
        WeightControls()
    End Sub

    Private Sub WeightControls()
        If bRCodeSet Then
            If rdoPrimary.Checked Then
                ucrInputSummary.Visible = True
                If ucrReceiverWeightBy.IsEmpty Then
                    ucrChkIsCurrency.Enabled = False
                    ucrInputSummary.Enabled = False
                    ucrInputSymbol.Enabled = False
                    If {strIdentifierAndWeighty, strWeight}.Contains(ucrInputLabel.GetText()) Then
                        ucrInputLabel.SetName(strIdentifier)
                    End If
                Else
                    ucrChkIsCurrency.Enabled = True
                    ucrInputSummary.Enabled = True
                    ucrInputSymbol.Enabled = True
                End If
            ElseIf rdoSummary.Checked Then
                ucrInputSummary.Visible = False
            End If
            SetSummary()
        End If
    End Sub

    Private Sub SetSummary()
        If bRCodeSet Then
            clsSummariseFunction.ClearParameters()
            clsSummariseFunction.AddParameter(".n", "n()", iPosition:=0)
            If Not ucrReceiverWeightBy.IsEmpty Then
                clsSummariseFunction.AddParameter(ucrReceiverWeightBy.GetVariableNames(False), clsRFunctionParameter:=clsSummaryFunction, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub ucrInputSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSummary.ControlValueChanged
        clsSummaryFunction.SetRCommand(ucrInputSummary.GetText())
    End Sub

    Private Sub ucrSelectorTreemap_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTreemap.ControlValueChanged
        SetPipeAssignTo()
    End Sub

    Private Sub SetPipeAssignTo()
        If bRCodeSet Then
            If rdoPrimary.Checked Then
                If ucrSelectorTreemap.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
                    clsPipeOperator.SetAssignTo(ucrSelectorTreemap.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_summary")
                End If
            ElseIf rdoSummary.Checked Then
                clsPipeOperator.RemoveAssignTo()
            End If
        End If
    End Sub

    Private Sub ucrChkIsCurrency_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIsCurrency.ControlValueChanged
        SetLabel()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
                          clsNewXLabsTitleFunction:=clsXlabFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction,
                          clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewThemeFunction:=clsThemeFuction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsGeomTreemapAesFunction,
                          clsNewAnnotateFunction:=clsAnnotateFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction,
                          ucrNewBaseSelector:=ucrSelectorTreemap, bReset:=bResetSubdialog)
        'this is a temporary fix
        If rdoPrimary.Checked Then
            sdgPlots.tbpFacet.Enabled = False
            sdgPlots.tbpLayers.Enabled = False
        End If
        sdgPlots.ShowDialog()
        sdgPlots.tbpFacet.Enabled = True
        sdgPlots.tbpLayers.Enabled = True
        bResetSubdialog = False
    End Sub

    Private Sub CoreControls_ContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveTreemap.ControlContentsChanged, ucrReceiverWeightBy.ControlContentsChanged, ucrReceiverIdentifier.ControlContentsChanged, ucrPnlDataType.ControlContentsChanged

    End Sub
End Class