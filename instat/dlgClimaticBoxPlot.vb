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
Public Class dlgClimaticBoxPlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRCodeUpdated As Boolean = False
    Private clsRggplotFunction As New RFunction
    Private clsRgeomPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsLocalRaesFunction As New RFunction
    Private clsXTitleFunction As New RFunction
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsFacetFunction As New RFunction
    Private clsFacetOp As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsThemeFunction As New RFunction
    Private clsThemeFunc As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True

    Private clsFilteredDataOperator As New ROperator
    Private clsFilterElementOperator As New ROperator
    Private clsFilterElementFunction As New RFunction
    Private clsAsFactorFunction As New RFunction
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction

    Private strFacetWrap As String = "Facet Wrap"
    Private strFacetRow As String = "Facet Row"
    Private strFacetCol As String = "Facet Column"
    Private strXAxis As String = "X Axis"
    Private strColour As String = "Colour Axis"
    Private strNone As String = "None"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False
    Private dctComboReceiver As New Dictionary(Of ucrInputComboBox, ucrReceiverSingle)

    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private Sub dlgClimaticBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        If bReset Then
            AutoFill()
        End If
        bReset = False
        SetOptionsButtonsText()
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim clsTextElementFunc As New RFunction

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'ucrBase.iHelpTopicID = ""
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlPlots.AddRadioButton(rdoViolin)
        ucrPnlPlots.AddRadioButton(rdoBoxplot)
        ucrPnlPlots.AddRadioButton(rdoJitter)

        ucrPnlPlots.AddFunctionNamesCondition(rdoBoxplot, "geom_boxplot")
        ucrPnlPlots.AddFunctionNamesCondition(rdoJitter, "geom_jitter")
        ucrPnlPlots.AddFunctionNamesCondition(rdoViolin, "geom_violin")
        ucrPnlPlots.AddToLinkedControls(ucrChkVarWidth, {rdoBoxplot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorClimaticBoxPlot.SetParameter(New RParameter("left", 0))
        ucrSelectorClimaticBoxPlot.SetParameterIsrfunction()

        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.SetParameter(New RParameter(""))
        ucrReceiverStation.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.bWithQuotes = False
        ucrReceiverStation.SetIncludedDataTypes({"factor"})
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetParameter(New RParameter(""))
        ucrReceiverYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.bWithQuotes = False
        ucrReceiverYear.SetIncludedDataTypes({"numeric", "factor"})
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverWithinYear.SetParameter(New RParameter("x", 1))
        ucrReceiverWithinYear.SetParameterIsString()
        ucrReceiverWithinYear.bWithQuotes = False
        ucrReceiverWithinYear.strSelectorHeading = "Factors"
        ucrReceiverWithinYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverWithinYear.SetIncludedDataTypes({"factor"})
        ucrReceiverWithinYear.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverWithinYear.bAddParameterIfEmpty = True

        ' others
        ucrReceiverDate.SetParameter(New RParameter("date", 1))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ' summary
        ucrReceiverElement.SetParameter(New RParameter("y", 0))
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.bAutoFill = True
        ucrReceiverElement.strSelectorHeading = "Variables"
        ucrReceiverElement.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverElement.SetIncludedDataTypes({"numeric"})

        dctComboReceiver.Add(ucrInputStation, ucrReceiverStation)
        dctComboReceiver.Add(ucrInputYear, ucrReceiverYear)
        dctComboReceiver.Add(ucrInputWithinYear, ucrReceiverWithinYear)

        ucrChkOmitBelow.SetText("Omit Below")
        ucrChkOmitBelow.AddParameterPresentCondition(True, "right", True)
        ucrChkOmitBelow.AddParameterPresentCondition(False, "right", False)

        ucrNudOmitBelow.SetParameter(New RParameter("right"))
        ucrNudOmitBelow.DecimalPlaces = 2
        ucrNudOmitBelow.Increment = 0.1
        ucrChkOmitBelow.AddToLinkedControls(ucrNudOmitBelow, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.85)

        ucrChkVarWidth.SetParameter(New RParameter("varwidth", 0))
        ucrChkVarWidth.SetText("Variable Width")
        ucrChkVarWidth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkVarWidth.SetRDefault("FALSE")

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkHorizontalBoxplot.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkHorizontalBoxplot.SetText("Horizontal Plot")

        ucrNudOutlierCoefficient.SetParameter(New RParameter("coef", iNewPosition:=1))
        ucrNudOutlierCoefficient.DecimalPlaces = 1
        ucrNudOutlierCoefficient.Increment = 0.1
        ucrNudOutlierCoefficient.SetRDefault(1.5)

        ucrNudOutlierCoefficient.SetLinkedDisplayControl(lblOutlierCoefficient)

        ucrPnlPlots.AddToLinkedControls(ucrNudOutlierCoefficient, {rdoBoxplot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        clsThemeFunc.SetPackageName("ggplot2")
        clsThemeFunc.SetRCommand("theme")
        clsThemeFunc.AddParameter("axis.text.x", clsRFunctionParameter:=clsTextElementFunc)
        clsTextElementFunc.SetPackageName("ggplot2")
        clsTextElementFunc.SetRCommand("element_text")
        clsTextElementFunc.AddParameter("angle", "90", iPosition:=0)
        clsTextElementFunc.AddParameter("hjust", "1", iPosition:=1)
        clsTextElementFunc.AddParameter("vjust", "0.5", iPosition:=2)

        ucrInputStation.SetItems({strXAxis, strColour, strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrInputYear.SetItems({strXAxis, strColour, strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputYear.SetDropDownStyleAsNonEditable()

        ucrInputWithinYear.SetItems({strXAxis, strColour, strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputWithinYear.SetDropDownStyleAsNonEditable()

        ucrSavePlot.SetPrefix("box_plot")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomPlotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsFacetFunction = New RFunction
        clsFacetOp = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator

        clsFilteredDataOperator = New ROperator
        clsFilterElementOperator = New ROperator
        clsFilterElementFunction = New RFunction
        clsAsFactorFunction = New RFunction

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetOp.SetOperation("~")
        clsFacetOp.bForceIncludeOperation = True
        clsFacetOp.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOp, iPosition:=0)
        clsFacetFunction.AddParameter("drop", "FALSE", iPosition:=1)

        clsFilterElementOperator.SetOperation(">")
        clsFilterElementOperator.bBrackets = False

        clsFilterElementFunction.SetPackageName("dplyr")
        clsFilterElementFunction.SetRCommand("filter")
        clsFilterElementFunction.AddParameter("expression", clsROperatorParameter:=clsFilterElementOperator, bIncludeArgumentName:=False)

        clsFilteredDataOperator.SetOperation("%>%")
        clsFilteredDataOperator.bBrackets = False
        clsRggplotFunction.AddParameter("data", clsROperatorParameter:=clsFilteredDataOperator, iPosition:=0)

        ucrSelectorClimaticBoxPlot.Reset()
        ucrSavePlot.Reset()
        sdgPlots.Reset()
        bResetSubdialog = True
        bResetBoxLayerSubdialog = True
        ucrReceiverElement.SetMeAsReceiver()

        ucrInputStation.SetText(strNone)
        ucrInputStation.bUpdateRCodeFromControl = True
        ucrInputYear.SetText(strNone)
        ucrInputYear.bUpdateRCodeFromControl = True
        ucrInputWithinYear.SetText(strXAxis)
        ucrInputWithinYear.bUpdateRCodeFromControl = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsRgeomPlotFunction, iPosition:=2) 'TODO Check this line

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))

        clsAsFactorFunction.SetRCommand("make_factor")

        clsRgeomPlotFunction.SetPackageName("ggplot2")
        clsRgeomPlotFunction.SetRCommand("geom_boxplot")
        clsRgeomPlotFunction.AddParameter("varwidth", "FALSE", iPosition:=0)

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunc, bIncludeArgumentName:=False)

        clsXlabsFunction.AddParameter("label", "NULL", bIncludeArgumentName:=False)
        clsBaseOperator.AddParameter("xlab", clsRFunctionParameter:=clsXlabsFunction, bIncludeArgumentName:=False)

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TestOKEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeUpdated = False
        ucrSavePlot.SetRCode(clsBaseOperator, bReset)
        ucrSelectorClimaticBoxPlot.SetRCode(clsFilteredDataOperator, bReset)
        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)

        ucrChkVarWidth.SetRCode(clsRgeomPlotFunction, bReset)
        ucrPnlPlots.SetRCode(clsRgeomPlotFunction, bReset)
        ucrNudOutlierCoefficient.SetRCode(clsRgeomPlotFunction, bReset)

        ucrReceiverElement.AddAdditionalCodeParameterPair(clsFilterElementOperator, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverElement.SetRCode(clsRaesFunction, bReset)
        ucrChkOmitBelow.SetRCode(clsFilteredDataOperator, bReset)
        ucrNudOmitBelow.SetRCode(clsFilterElementOperator, bReset)
        bRCodeUpdated = True
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverElement.IsEmpty AndAlso ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        AutoFill()
        UpdateParameters()
        TestOKEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
                         clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction,
                         clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction,
                         clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                         clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYLabTitleFunction:=clsYlabFunction,
                         clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsFacetFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction,
                         clsNewAnnotateFunction:=clsAnnotateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=ucrSelectorClimaticBoxPlot, bReset:=bResetSubdialog)
        'this is a temporary fix because we have facets done on the main dialog
        sdgPlots.tbpFacet.Enabled = False
        sdgPlots.ShowDialog()
        sdgPlots.tbpFacet.Enabled = True
        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)
        bResetSubdialog = False
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged() Handles ucrPnlPlots.ControlValueChanged
        If rdoBoxplot.Checked Then
            clsRgeomPlotFunction.SetRCommand("geom_boxplot")
            If Not ucrSavePlot.bUserTyped Then
                ucrSavePlot.SetPrefix("box_plot")
            End If
        ElseIf rdoJitter.Checked Then
            clsRgeomPlotFunction.SetRCommand("geom_jitter")
            If Not ucrSavePlot.bUserTyped Then
                ucrSavePlot.SetPrefix("jitter")
            End If
        Else
            clsRgeomPlotFunction.SetRCommand("geom_violin")
            If Not ucrSavePlot.bUserTyped Then
                ucrSavePlot.SetPrefix("violin")
            End If
        End If
        UpdateParameters()
        AddRemoveFacets()
        SetOptionsButtonsText()
        autoTranslate(Me)
    End Sub

    Private Sub SetOptionsButtonsText()
        If rdoBoxplot.Checked Then
            cmdBoxPlotOptions.Text = "Boxplot Options"
        ElseIf rdoJitter.Checked Then
            cmdBoxPlotOptions.Text = "Jitter Options"
        Else
            cmdBoxPlotOptions.Text = "Violin Options"
        End If
    End Sub

    Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorClimaticBoxPlot, bApplyAesGlobally:=True, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        'Making sure the filter isn't discarded
        clsRggplotFunction.AddParameter("data", clsROperatorParameter:=clsFilteredDataOperator, iPosition:=0)
        OmitFilter()
        ucrChkVarWidth.SetRCode(clsRgeomPlotFunction, bReset)
        If Not IsNothing(clsRgeomPlotFunction.GetParameter("coef")) Then
            ucrNudOutlierCoefficient.SetRCode(clsRgeomPlotFunction, bReset)
        End If
        bResetBoxLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                'ucrReceiverXVariable.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "y" Then
                'ucrReceiverData.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                'ucrReceiverMoreData.Add(clsParam.strArgumentValue)
            End If
        Next
        'TODO need to check for the variable width from the geom function in a way that when we check the var width checkbox, it triggers controlvaluechanged
    End Sub

    Private Sub AutoFill()
        Dim strMonthCol As String
        Dim strDataFrame As String
        Dim strRainCol As String

        strDataFrame = ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        strMonthCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "month_label")
        strRainCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "rain_label")

        If strRainCol <> "" Then
            ucrReceiverElement.Add(strRainCol, strDataFrame)
        End If
        If strMonthCol <> "" Then
            ucrReceiverWithinYear.Add(strMonthCol, strDataFrame)
        End If
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged, ucrInputYear.ControlValueChanged, ucrInputWithinYear.ControlValueChanged
        Dim ucrTempReciever As ucrReceiver = Nothing
        Dim strChangedText As String = ""

        If bUpdateComboOptions Then
            strChangedText = ucrChangedControl.GetText()
            If strChangedText <> strNone Then
                For Each ucrInputTemp As ucrInputComboBox In dctComboReceiver.Keys
                    If Not strChangedText = strFacetCol AndAlso Not strChangedText = strFacetRow AndAlso Not ucrInputTemp.Equals(ucrChangedControl) AndAlso ucrInputTemp.GetText() = strChangedText Then
                        bUpdateComboOptions = False
                        ucrInputTemp.SetName(strNone)
                        bUpdateComboOptions = True
                    End If
                    If strChangedText = strFacetWrap AndAlso ucrInputTemp.GetText = strFacetRow OrElse strChangedText = strFacetRow AndAlso ucrInputTemp.GetText = strFacetWrap OrElse strChangedText = strFacetWrap AndAlso ucrInputTemp.GetText = strFacetCol OrElse strChangedText = strFacetCol AndAlso ucrInputTemp.GetText = strFacetWrap Then
                        ucrInputTemp.SetName(strNone)
                    End If
                Next
            End If
            UpdateParameters()
            AddRemoveFacets()
        End If
    End Sub

    Private Sub UpdateParameters()
        Dim strTemp As String = ""

        clsRaesFunction.RemoveParameterByName("x")
        clsRaesFunction.RemoveParameterByName("color")
        clsRaesFunction.RemoveParameterByName("fill")
        clsAsFactorFunction.RemoveParameterByName("x")

        For Each ucrInputTemp As ucrInputComboBox In dctComboReceiver.Keys
            clsFacetOp.RemoveParameterByName("wrap" & ucrInputTemp.Name)
            clsFacetColOp.RemoveParameterByName("col" & ucrInputTemp.Name)
            clsFacetRowOp.RemoveParameterByName("row" & ucrInputTemp.Name)
        Next
        clsBaseOperator.RemoveParameterByName("facets")

        bUpdatingParameters = True
        For Each ucrInputTemp As ucrInputComboBox In dctComboReceiver.Keys
            strTemp = ucrInputTemp.GetText()
            dctComboReceiver(ucrInputTemp).SetRCode(Nothing)
            If strTemp = strXAxis Then
                dctComboReceiver(ucrInputTemp).ChangeParameterName("x")
                dctComboReceiver(ucrInputTemp).SetParameterIncludeArgumentName(False)
                dctComboReceiver(ucrInputTemp).SetRCode(clsAsFactorFunction)
                clsRaesFunction.AddParameter("x", clsRFunctionParameter:=clsAsFactorFunction)
            ElseIf strTemp = strColour Then
                If rdoJitter.Checked Then
                    dctComboReceiver(ucrInputTemp).ChangeParameterName("color")
                    dctComboReceiver(ucrInputTemp).SetParameterIncludeArgumentName(True)
                ElseIf rdoBoxplot.Checked OrElse rdoViolin.Checked Then
                    dctComboReceiver(ucrInputTemp).ChangeParameterName("fill")
                    dctComboReceiver(ucrInputTemp).SetParameterIncludeArgumentName(True)
                End If
                dctComboReceiver(ucrInputTemp).SetRCode(clsRaesFunction)
            ElseIf strTemp = strFacetWrap Then
                dctComboReceiver(ucrInputTemp).ChangeParameterName("wrap" & ucrInputTemp.Name)
                dctComboReceiver(ucrInputTemp).SetRCode(clsFacetOp)
            ElseIf strTemp = strFacetCol Then
                dctComboReceiver(ucrInputTemp).ChangeParameterName("col" & ucrInputTemp.Name)
                dctComboReceiver(ucrInputTemp).SetRCode(clsFacetColOp)
            ElseIf strTemp = strFacetRow Then
                dctComboReceiver(ucrInputTemp).ChangeParameterName("row" & ucrInputTemp.Name)
                dctComboReceiver(ucrInputTemp).SetRCode(clsFacetRowOp)
            End If
        Next
        If Not clsRaesFunction.ContainsParameter("x") Then
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
        bUpdatingParameters = False
    End Sub

    Private Sub ucrSelectorClimaticBoxPlot_DataFrameChanged() Handles ucrSelectorClimaticBoxPlot.DataFrameChanged
        AutoFill()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlContentsChanged, ucrSavePlot.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub AddRemoveFacets()
        Dim strText As String
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False

        If Not bUpdatingParameters Then
            clsBaseOperator.RemoveParameterByName("facets")
            For Each kvpTemp As KeyValuePair(Of ucrInputComboBox, ucrReceiverSingle) In dctComboReceiver
                strText = kvpTemp.Key.GetText()
                If strText = strFacetWrap OrElse strText = strFacetCol OrElse strText = strFacetRow AndAlso Not kvpTemp.Value.IsEmpty Then
                    If strText = strFacetWrap Then
                        bWrap = True
                    End If
                    If strText = strFacetCol Then
                        bCol = True
                    End If
                    If strText = strFacetRow Then
                        bRow = True
                    End If
                End If
            Next
            If bWrap OrElse bRow OrElse bCol Then
                clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
            End If
            If bWrap Then
                clsFacetFunction.SetRCommand("facet_wrap")
                clsFacetOp.AddParameter("wrap", iPosition:=0)
            Else
                clsFacetOp.RemoveParameterByName("wrap")
            End If
            If bRow OrElse bCol Then
                clsFacetFunction.SetRCommand("facet_grid")
            End If
            If bRow Then
                clsFacetOp.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
            ElseIf bCol AndAlso bWrap = False Then
                clsFacetOp.AddParameter("left", ".", iPosition:=0)
            Else
                clsFacetOp.RemoveParameterByName("left")
            End If
            If bCol Then
                clsFacetOp.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
            ElseIf bRow AndAlso bWrap = False Then
                clsFacetOp.AddParameter("right", ".", iPosition:=1)
            Else
                clsFacetOp.RemoveParameterByName("right")
            End If
        End If
    End Sub

    Private Sub OmitFilter()
        If ucrChkOmitBelow.Checked Then
            clsFilteredDataOperator.AddParameter("right", clsRFunctionParameter:=clsFilterElementFunction, iPosition:=1)
        Else
            clsFilteredDataOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub ucrChkOmitBelow_CheckedChanged() Handles ucrChkOmitBelow.ControlValueChanged
        OmitFilter()
    End Sub
    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrReceiverWithinYear.ControlValueChanged, ucrReceiverYear.ControlValueChanged
        AddRemoveFacets()
    End Sub
End Class
