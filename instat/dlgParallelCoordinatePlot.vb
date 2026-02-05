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

Imports instat.Translations
Public Class dlgParallelCoordinatePlot
    Private clsGGParCoordFunc As New RFunction
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsBaseOperator As New ROperator
    Private clsLabsFunction As New RFunction
    Private clsXLabsFunction As New RFunction
    Private clsYLabsFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsMatchFunction As New RFunction
    Private clsNamesFunction As New RFunction

    Private clsFacetFunction As New RFunction
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsVarsFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction

    Private ReadOnly strNone As String = "None"
    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strFacetRowAll As String = "Facet Row + O"
    Private ReadOnly strFacetColAll As String = "Facet Col + O"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

    Private Sub dlgParallelCoordinatePlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctScale As New Dictionary(Of String, String)
        Dim dctLegendPosition As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 593
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorParallelCoordinatePlot.SetParameter(New RParameter("data", 0))
        ucrSelectorParallelCoordinatePlot.SetParameterIsrfunction()

        ucrReceiverXVariables.SetParameter(New RParameter("columns", 1))
        ucrReceiverXVariables.strSelectorHeading = "Numerics"
        ucrReceiverXVariables.Selector = ucrSelectorParallelCoordinatePlot
        ucrReceiverXVariables.SetIncludedDataTypes({"numeric"})
        ucrReceiverXVariables.SetParameterIsString()

        ucrReceiverFactor.SetParameter(New RParameter("groupColumn", 2))
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.Selector = ucrSelectorParallelCoordinatePlot
        ucrReceiverFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverFactor.SetParameterIsString()

        ucrChkBoxplots.SetParameter(New RParameter("boxplot", 11))
        ' On R, 'boxplot' is the 12th item in the parameter list (but our count starts from 0) so this is position = 11
        ucrChkBoxplots.SetText("Boxplot")
        ucrChkBoxplots.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkBoxplots.SetRDefault("FALSE")

        ucrChkPoints.SetParameter(New RParameter("showPoints", 8))
        ucrChkPoints.SetText("Points")
        ucrChkPoints.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPoints.SetRDefault("FALSE")

        ucrNudTransparency.SetParameter(New RParameter("alphaLines", 10))
        ucrNudTransparency.SetMinMax(0, 1)
        ucrNudTransparency.DecimalPlaces = 2
        ucrNudTransparency.Increment = 0.01
        ucrNudTransparency.SetRDefault(1)

        ucrInputScale.SetParameter(New RParameter("scale", 3))
        dctScale.Add("Std", "std")
        dctScale.Add("Robust", Chr(34) & "robust" & Chr(34))
        dctScale.Add("Uniminmax", Chr(34) & "uniminmax" & Chr(34))
        dctScale.Add("Globalminmax", Chr(34) & "globalminmax" & Chr(34))
        dctScale.Add("Center", Chr(34) & "center" & Chr(34))
        dctScale.Add("CenterObs", Chr(34) & "centerObs" & Chr(34))
        ucrInputScale.SetItems(dctScale)
        ucrInputScale.SetRDefault("std")
        ucrInputScale.SetDropDownStyleAsNonEditable()

        ucrChkLegend.SetText("Legend:")
        ucrChkLegend.AddToLinkedControls({ucrInputLegendPosition}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrChkLegend.AddParameterPresentCondition(True, "legend.position")
        ucrChkLegend.AddParameterPresentCondition(False, "legend.position", False)

        ucr1stFactorReceiver.SetParameter(New RParameter("var1"))
        ucr1stFactorReceiver.Selector = ucrSelectorParallelCoordinatePlot
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(1)
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strFacetRowAll, strFacetColAll, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrSaveGraph.SetPrefix("par_coord_plot")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorParallelCoordinatePlot.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Store Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsGGParCoordFunc = New RFunction
        clsFacetFunction = New RFunction
        clsFacetVariablesOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator
        clsVarsFunction = New RFunction
        clsPipeOperator = New ROperator
        clsGroupByFunction = New RFunction
        clsNamesFunction = New RFunction
        clsMatchFunction = New RFunction

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        ucrReceiverXVariables.SetMeAsReceiver()
        ucrSelectorParallelCoordinatePlot.Reset()
        ucrSelectorParallelCoordinatePlot.SetGgplotFunction(clsBaseOperator)
        ucrSaveGraph.Reset()
        bResetSubdialog = True

        clsMatchFunction.SetRCommand("match")
        clsMatchFunction.SetAssignTo("column_numbers")

        clsGGParCoordFunc.SetPackageName("GGally")
        clsGGParCoordFunc.SetRCommand("ggparcoord")
        clsGGParCoordFunc.AddParameter("columns", clsRFunctionParameter:=clsMatchFunction, iPosition:=1)
        clsGGParCoordFunc.AddParameter("missing", Chr(34) & "exclude" & Chr(34), iPosition:=6)
        'clsGGParCoordFunc.AddParameter("order", Chr(34) & "anyClass" & Chr(34), iPosition:=7)
        clsGGParCoordFunc.AddParameter("centerObsID", "1", iPosition:=8)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggparcord", clsRFunctionParameter:=clsGGParCoordFunc, iPosition:=0)

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)

        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetVariablesOperator.SetOperation("~")
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetVariablesOperator.bBrackets = False

        clsVarsFunction.SetPackageName("ggplot2")
        clsVarsFunction.SetRCommand("vars")

        clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")



        clsNamesFunction.SetRCommand("names")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXLabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYLabsFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorParallelCoordinatePlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverXVariables.AddAdditionalCodeParameterPair(clsMatchFunction, New RParameter("var", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)

        ucrSelectorParallelCoordinatePlot.SetRCode(clsGGParCoordFunc, bReset)
        ucrReceiverFactor.SetRCode(clsGGParCoordFunc, bReset)
        ucrChkBoxplots.SetRCode(clsGGParCoordFunc, bReset)
        ucrChkPoints.SetRCode(clsGGParCoordFunc, bReset)
        ucrNudTransparency.SetRCode(clsGGParCoordFunc, bReset)
        ucrInputScale.SetRCode(clsGGParCoordFunc, bReset)
        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrSaveGraph.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (ucrReceiverXVariables.lstSelectedVariables.Items.Count > 1) AndAlso ucrSaveGraph.IsComplete AndAlso ucrNudTransparency.GetText <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub toolStripMenuItemParcoordOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemParcoordOptions.Click
        sdgParallelPlots.SetRCode(clsNewRFunction:=clsGGParCoordFunc, bReset:=bReset)
        bResetSubdialog = False
        sdgParallelPlots.ShowDialog()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click, toolStripMenuItemPlotOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction,
                  clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewXLabsTitleFunction:=clsXLabsFunction, clsNewYLabTitleFunction:=clsYLabsFunction, clsNewFacetVariablesOperator:=clsFacetVariablesOperator,
                  clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrSelectorParallelCoordinatePlot, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
                  clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, clsNewAnnotateFunction:=clsAnnotateFunction, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        ucr1stFactorReceiver.Add(sdgPlots.ucr1stFactorReceiver.GetText)
        bResetSubdialog = False
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ucrChkLegend_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegend.ControlValueChanged, ucrInputLegendPosition.ControlValueChanged
        AddRemoveTheme()
    End Sub

    Private Sub AutoFacetStation()
        Dim currentReceiver As ucrReceiver = ucrSelectorParallelCoordinatePlot.CurrentReceiver

        If currentReceiver IsNot Nothing Then
            ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrSelectorParallelCoordinatePlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
            currentReceiver.SetMeAsReceiver()
            AddRemoveGroupBy()
        End If
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged
        If Not bUpdateComboOptions Then
            Exit Sub
        End If
        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone Then
            If Not (strChangedText = strFacetCol OrElse strChangedText = strFacetColAll _
            OrElse strChangedText = strFacetRow OrElse strChangedText = strFacetRowAll) _
            AndAlso Not ucrInputStation.Equals(ucrChangedControl) _
            AndAlso ucrInputStation.GetText() = strChangedText Then

                bUpdateComboOptions = False
                ucrInputStation.SetName(strNone)
                bUpdateComboOptions = True
            End If
            If (strChangedText = strFacetWrap AndAlso
            (ucrInputStation.GetText = strFacetRow OrElse ucrInputStation.GetText = strFacetRowAll _
            OrElse ucrInputStation.GetText = strFacetCol OrElse ucrInputStation.GetText = strFacetColAll)) _
        OrElse ((strChangedText = strFacetRow OrElse strChangedText = strFacetRowAll) _
            AndAlso ucrInputStation.GetText = strFacetWrap) _
        OrElse ((strChangedText = strFacetCol OrElse strChangedText = strFacetColAll) _
            AndAlso ucrInputStation.GetText = strFacetWrap) Then

                ucrInputStation.SetName(strNone)
            End If
        End If
        UpdateParameters()
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub UpdateParameters()
        clsFacetVariablesOperator.RemoveParameterByName("var1")
        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucr1stFactorReceiver.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucr1stFactorReceiver.ChangeParameterName("var1")
                ucr1stFactorReceiver.SetRCode(clsFacetVariablesOperator)
            Case strFacetCol, strFacetColAll
                ucr1stFactorReceiver.ChangeParameterName("cols" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsVarsFunction)
            Case strFacetRow, strFacetRowAll
                ucr1stFactorReceiver.ChangeParameterName("rows" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsVarsFunction)
        End Select
        bUpdatingParameters = False
    End Sub

    Private Sub AddRemoveFacets()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False
        Dim bColAll As Boolean = False
        Dim bRowAll As Boolean = False

        If bUpdatingParameters Then
            Exit Sub
        End If
        clsBaseOperator.RemoveParameterByName("facets")
        If Not ucr1stFactorReceiver.IsEmpty Then
            Select Case ucrInputStation.GetText()
                Case strFacetWrap
                    bWrap = True
                Case strFacetCol
                    bCol = True
                Case strFacetRow
                    bRow = True
                Case strFacetColAll
                    bColAll = True
                Case strFacetRowAll
                    bRowAll = True
            End Select
        End If
        If bWrap OrElse bRow OrElse bCol OrElse bColAll OrElse bRowAll Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        End If

        If bWrap Then
            clsFacetFunction.SetRCommand("facet_wrap")
            clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)
        End If

        If bRow OrElse bCol OrElse bRowAll OrElse bColAll Then
            clsFacetFunction.SetRCommand("facet_grid")
            clsFacetFunction.RemoveParameterByName("facets")
        End If

        If bRowAll OrElse bColAll Then
            clsFacetFunction.AddParameter("margin", "TRUE", iPosition:=2)
        Else
            clsFacetFunction.RemoveParameterByName("margin")
        End If

        If bRow OrElse bRowAll Then
            clsFacetFunction.AddParameter("rows", clsRFunctionParameter:=clsVarsFunction, iPosition:=0)
        Else
            clsFacetFunction.RemoveParameterByName("rows")
        End If

        If bCol OrElse bColAll Then
            clsFacetFunction.AddParameter("cols", clsRFunctionParameter:=clsVarsFunction, iPosition:=1)
        Else
            clsFacetFunction.RemoveParameterByName("cols")
        End If
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub GetParameterValue(clsOperator As ROperator)
        Dim i As Integer = 0
        For Each clsTempParam As RParameter In clsOperator.clsParameters
            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                clsGroupByFunction.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                i = i + 1
            End If
        Next
    End Sub

    Private Sub AddRemoveGroupBy()
        If clsPipeOperator.ContainsParameter("mutate") Then
            clsGroupByFunction.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                Select Case ucrInputStation.GetText()
                    Case strFacetWrap
                        GetParameterValue(clsFacetVariablesOperator)
                End Select
            End If
            If clsGroupByFunction.iParameterCount > 0 Then
                clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
            Else
                clsPipeOperator.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator.RemoveParameterByName("group_by")
        End If

        SetPipeAssignTo()
    End Sub

    Private Sub SetPipeAssignTo()
        If ucrSelectorParallelCoordinatePlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrSelectorParallelCoordinatePlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrSelectorParallelCoordinatePlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorParallelCoordinatePlot.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
        clsNamesFunction.AddParameter("names", ucrSelectorParallelCoordinatePlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0, bIncludeArgumentName:=False)
        clsMatchFunction.AddParameter("data", clsRFunctionParameter:=clsNamesFunction, iPosition:=1, bIncludeArgumentName:=False)
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverXVariables.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrNudTransparency.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlValueChanged
        If Not ucrReceiverFactor.IsEmpty Then
            clsGGParCoordFunc.AddParameter("order", Chr(34) & "anyClass" & Chr(34), iPosition:=7)
        Else
            clsGGParCoordFunc.RemoveParameterByName("order")
        End If
    End Sub

End Class
