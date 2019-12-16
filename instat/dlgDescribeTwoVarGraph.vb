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

Public Class dlgDescribeTwoVarGraph
    Public strFirstVariablesType, strSecondVariableType As String

    Private clsBaseOperator As New ROperator
    Private clsRGGplotFunction, clsRFacet As New RFunction

    ' Use this aes for numeric by numeric graphs e.g. scatter and line plots
    Private clsAesNumericByNumeric As RFunction
    ' Use this aes for categorical by categorical bar graphs
    Private clsAesCategoricalByCategoricalBarChart As RFunction
    Private clsGgmosaicProduct As RFunction
    ' Use this aes for categorical by categorical mosiac plots
    Private clsAesCategoricalByCategoricalMosaicPlot As RFunction
    ' Use this aes for numeric by categorical when the y axis is the numeric variable(s) e.g. boxplot, violin, point
    Private clsAesNumericByCategoricalYNumeric As RFunction
    ' Use this aes for numeric by categorical when the x axis is the numeric variable(s)  e.g. histogram, density
    Private clsAesNumericByCategoricalXNumeric As RFunction
    ' Use this aes for categorical by numeric when the y axis is the numeric variable(s) e.g. boxplot, violin, point
    Private clsAesCategoricalByNumericYNumeric As RFunction
    ' Aes for stat_summary hline
    Private clsAesStatSummaryHlineCategoricalByNumeric As RFunction
    Private clsAesStatSummaryHlineNumericByCategorical As RFunction
    ' Use this aes for categorical by numeric when the x axis is the numeric variable(s) e.g. boxplot, violin, point
    Private clsAesCategoricalByNumericXNumeric As RFunction

    'Geoms
    Private clsGeomJitter As New RFunction
    Private clsGeomViolin As New RFunction
    Private clsGeomBar As New RFunction
    Private clsGeomMosaic As New RFunction
    Private clsGeomBoxplot As New RFunction
    Private clsGeomPoint As New RFunction
    Private clsGeomLine As New RFunction
    Private clsStatSummaryHline As New RFunction
    Private clsStatSummaryCrossbar As New RFunction
    Private clsGeomFreqPoly As New RFunction
    Private clsGeomHistogram As New RFunction
    Private clsGeomDensity As New RFunction

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgDescribeTwoVarGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
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
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim strNumericCategoricalPlots() As String

        cmdOptions.Hide()

        ucrBase.iHelpTopicID = 416
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorTwoVarGraph.SetParameter(New RParameter("data", 0))
        ucrSelectorTwoVarGraph.SetParameterIsrfunction()

        ucrReceiverFirstVars.Selector = ucrSelectorTwoVarGraph
        ucrReceiverFirstVars.ucrMultipleVariables.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)
        ucrReceiverFirstVars.SetMultipleOnlyStatus(True)

        ucrReceiverSecondVar.SetParameter(New RParameter("fill", 0))
        ucrReceiverSecondVar.Selector = ucrSelectorTwoVarGraph
        ucrReceiverSecondVar.SetParameterIsString()
        ucrReceiverSecondVar.bWithQuotes = False

        ucrInputNumericByNumeric.SetItems({"Scatter plot", "Line plot", "Line plot + points"})
        ucrInputNumericByNumeric.SetName("Scatter plot")
        ucrInputNumericByNumeric.SetDropDownStyleAsNonEditable()

        strNumericCategoricalPlots = {"Boxplot", "Point plot", "Jitter plot", "Violin plot", "Boxplot + Jitter", "Violin plot + Jitter plot", "Violin plot + Boxplot", "Summary Bars", "Summary Bars + Points", "Histogram", "Density plot", "Frequency polygon"}

        ucrInputNumericByCategorical.SetItems(strNumericCategoricalPlots)
        ucrInputNumericByCategorical.SetName("Boxplot")
        ucrInputNumericByCategorical.SetDropDownStyleAsNonEditable()

        ucrInputCategoricalByNumeric.SetItems(strNumericCategoricalPlots)
        ucrInputCategoricalByNumeric.SetName("Summary Bars + Points")
        ucrInputCategoricalByNumeric.SetDropDownStyleAsNonEditable()

        ucrInputCategoricalByCategorical.SetItems({"Bar Chart", "Mosaic Plot"})
        ucrInputCategoricalByCategorical.SetName("Bar Chart")
        ucrInputCategoricalByCategorical.SetDropDownStyleAsNonEditable()

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrFlipCoordinates.SetText("Flip Coordinates")
        ucrFlipCoordinates.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrSaveGraph.SetPrefix("two_var")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorTwoVarGraph.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsRGGplotFunction = New RFunction
        clsRFacet = New RFunction

        clsGeomBoxplot = New RFunction
        clsGeomJitter = New RFunction
        clsGeomViolin = New RFunction
        clsGeomPoint = New RFunction
        clsGeomLine = New RFunction
        clsGeomBar = New RFunction
        clsGeomFreqPoly = New RFunction
        clsGeomHistogram = New RFunction
        clsGeomDensity = New RFunction
        clsGeomMosaic = New RFunction
        clsGgmosaicProduct = New RFunction
        clsStatSummaryHline = New RFunction

        clsAesNumericByNumeric = New RFunction
        clsAesCategoricalByCategoricalBarChart = New RFunction
        clsAesCategoricalByCategoricalMosaicPlot = New RFunction
        clsAesNumericByCategoricalYNumeric = New RFunction
        clsAesNumericByCategoricalXNumeric = New RFunction
        clsAesCategoricalByNumericYNumeric = New RFunction
        clsAesCategoricalByNumericXNumeric = New RFunction
        clsAesStatSummaryHlineCategoricalByNumeric = New RFunction
        clsAesStatSummaryHlineNumericByCategorical = New RFunction

        clsBaseOperator = New ROperator

        'Reset
        ucrSaveGraph.Reset()
        ucrSelectorTwoVarGraph.Reset()

        ucrReceiverFirstVars.SetMeAsReceiver()

        clsBaseOperator.SetOperation("+")

        clsRGGplotFunction.SetPackageName("ggplot2")
        clsRGGplotFunction.SetRCommand("ggplot")

        clsRFacet.SetPackageName("ggplot2")
        clsRFacet.SetRCommand("facet_wrap")
        clsRFacet.AddParameter("facets", "~variable")

        clsGeomViolin.SetPackageName("ggplot2")
        clsGeomViolin.SetRCommand("geom_violin")

        clsGeomJitter.SetPackageName("ggplot2")
        clsGeomJitter.SetRCommand("geom_jitter")
        clsGeomJitter.AddParameter("width", "0.2", iPosition:=4)
        clsGeomJitter.AddParameter("height", "0", iPosition:=5)
        clsGeomJitter.AddParameter("alpha", "0.2", iPosition:=5)

        clsGeomBoxplot.SetPackageName("ggplot2")
        clsGeomBoxplot.SetRCommand("geom_boxplot")

        clsGeomMosaic.SetPackageName("ggmosaic")
        clsGeomMosaic.SetRCommand("geom_mosaic")

        clsAesNumericByNumeric.SetPackageName("ggplot2")
        clsAesNumericByNumeric.SetRCommand("aes")
        clsAesNumericByNumeric.AddParameter("y", "value")

        clsAesNumericByCategoricalYNumeric.SetPackageName("ggplot2")
        clsAesNumericByCategoricalYNumeric.SetRCommand("aes")
        clsAesNumericByCategoricalYNumeric.AddParameter("y", "value", iPosition:=1)

        clsAesNumericByCategoricalXNumeric.SetPackageName("ggplot2")
        clsAesNumericByCategoricalXNumeric.SetRCommand("aes")
        clsAesNumericByCategoricalXNumeric.AddParameter("x", "value", iPosition:=1)

        clsAesCategoricalByNumericYNumeric.SetPackageName("ggplot2")
        clsAesCategoricalByNumericYNumeric.SetRCommand("aes")
        clsAesCategoricalByNumericYNumeric.AddParameter("x", "value", iPosition:=0)

        clsAesCategoricalByNumericXNumeric.SetPackageName("ggplot2")
        clsAesCategoricalByNumericXNumeric.SetRCommand("aes")
        clsAesCategoricalByNumericXNumeric.AddParameter("colour", "value", iPosition:=1)

        clsAesNumericByCategoricalXNumeric.SetPackageName("ggplot2")
        clsAesNumericByCategoricalXNumeric.SetRCommand("aes")
        clsAesNumericByCategoricalXNumeric.AddParameter("x", "value", iPosition:=1)

        clsAesCategoricalByCategoricalBarChart.SetPackageName("ggplot2")
        clsAesCategoricalByCategoricalBarChart.SetRCommand("aes")
        clsAesCategoricalByCategoricalBarChart.AddParameter("x", "value")

        clsAesCategoricalByCategoricalMosaicPlot.SetPackageName("ggplot2")
        clsAesCategoricalByCategoricalMosaicPlot.SetRCommand("aes")
        clsAesCategoricalByCategoricalMosaicPlot.AddParameter("x", clsRFunctionParameter:=clsGgmosaicProduct, iPosition:=0)
        clsAesCategoricalByCategoricalMosaicPlot.AddParameter("fill", "value", iPosition:=1)

        clsAesStatSummaryHlineCategoricalByNumeric.SetPackageName("ggplot2")
        clsAesStatSummaryHlineCategoricalByNumeric.SetRCommand("aes")
        clsAesStatSummaryHlineCategoricalByNumeric.AddParameter("x", "1", iPosition:=0)
        clsAesStatSummaryHlineCategoricalByNumeric.AddParameter("yintercept", "..y..", iPosition:=2)

        clsGgmosaicProduct.SetPackageName("ggmosaic")
        clsGgmosaicProduct.SetRCommand("product")
        clsGgmosaicProduct.AddParameter("0", "value", bIncludeArgumentName:=False, iPosition:=0)

        clsGeomPoint.SetPackageName("ggplot2")
        clsGeomPoint.SetRCommand("geom_point")

        clsGeomLine.SetPackageName("ggplot2")
        clsGeomLine.SetRCommand("geom_line")

        clsGeomBar.SetPackageName("ggplot2")
        clsGeomBar.SetRCommand("geom_bar")
        clsGeomBar.AddParameter("position", Chr(34) & "dodge" & Chr(34))

        clsGeomFreqPoly.SetPackageName("ggplot2")
        clsGeomFreqPoly.SetRCommand("geom_freqpoly")

        clsGeomDensity.SetPackageName("ggplot2")
        clsGeomDensity.SetRCommand("geom_density")

        clsGeomHistogram.SetPackageName("ggplot2")
        clsGeomHistogram.SetRCommand("geom_histogram")
        clsGeomHistogram.AddParameter("position", Chr(34) & "dodge" & Chr(34))

        clsStatSummaryHline.SetPackageName("ggplot2")
        clsStatSummaryHline.SetRCommand("stat_summary")
        clsStatSummaryHline.AddParameter("geom", Chr(34) & "hline" & Chr(34), iPosition:=2)
        clsStatSummaryHline.AddParameter("fun.y", Chr(34) & "mean" & Chr(34), iPosition:=3)
        clsStatSummaryHline.AddParameter("inherit.aes", "FALSE", iPosition:=4)

        clsStatSummaryCrossbar.SetPackageName("ggplot2")
        clsStatSummaryCrossbar.SetRCommand("stat_summary")
        clsStatSummaryCrossbar.AddParameter("geom", Chr(34) & "crossbar" & Chr(34), iPosition:=2)
        clsStatSummaryCrossbar.AddParameter("fun.y", Chr(34) & "mean" & Chr(34), iPosition:=3)
        clsStatSummaryCrossbar.AddParameter("fun.ymax", Chr(34) & "mean" & Chr(34), iPosition:=4)
        clsStatSummaryCrossbar.AddParameter("fun.ymin", Chr(34) & "mean" & Chr(34), iPosition:=5)
        clsStatSummaryCrossbar.AddParameter("size", "0.5", iPosition:=6)
        clsStatSummaryCrossbar.AddParameter("colour", Chr(34) & "red" & Chr(34), iPosition:=7)

        clsBaseOperator.AddParameter("facet_wrap", clsRFunctionParameter:=clsRFacet)
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRGGplotFunction, iPosition:=0)
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        ' bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorTwoVarGraph.SetRCode(clsRGGplotFunction, bReset)
        ucrReceiverSecondVar.SetRCode(clsAesCategoricalByCategoricalBarChart, bReset)
        ucrSaveGraph.SetRCode(clsBaseOperator, bReset)
        ucrFlipCoordinates.SetRCode(clsBaseOperator, bReset)

        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsAesNumericByCategoricalYNumeric, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsAesNumericByCategoricalXNumeric, New RParameter("colour", 2), iAdditionalPairNo:=2)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsAesCategoricalByNumericYNumeric, New RParameter("y", 1), iAdditionalPairNo:=3)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsAesCategoricalByNumericXNumeric, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsAesNumericByNumeric, New RParameter("x", 0), iAdditionalPairNo:=5)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsGgmosaicProduct, New RParameter("1", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=6)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsAesStatSummaryHlineCategoricalByNumeric, New RParameter("y", 1), iAdditionalPairNo:=7)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverFirstVars.IsEmpty AndAlso Not ucrReceiverSecondVar.IsEmpty AndAlso ucrSaveGraph.IsComplete Then
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

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        TestOkEnabled()
    End Sub

    Public Sub Results()
        Dim lstFirstItemTypes As List(Of String)

        If Not ucrReceiverFirstVars.IsEmpty() Then
            lstFirstItemTypes = ucrReceiverFirstVars.ucrMultipleVariables.GetCurrentItemTypes(True, bIsCategoricalNumeric:=True)
            If lstFirstItemTypes.Count = 1 AndAlso lstFirstItemTypes.Contains("logical") Then
                lstFirstItemTypes(0) = "categorical"
            Else
                lstFirstItemTypes.RemoveAll(Function(x) x.Contains("logical"))
            End If
            If (lstFirstItemTypes.Count > 0) Then
                strFirstVariablesType = lstFirstItemTypes(0)
            Else
                strFirstVariablesType = ""
                lblFirstType.Text = "________"
                lblFirstType.ForeColor = SystemColors.ControlText
            End If
            lblFirstType.Text = strFirstVariablesType
            lblFirstType.ForeColor = SystemColors.Highlight
        Else
            strFirstVariablesType = ""
            lblFirstType.Text = "________"
            lblFirstType.ForeColor = SystemColors.ControlText
        End If
        If Not ucrReceiverSecondVar.IsEmpty() Then
            strSecondVariableType = ucrReceiverSecondVar.strCurrDataType
            If strSecondVariableType.Contains("factor") OrElse strSecondVariableType.Contains("character") OrElse strSecondVariableType.Contains("logical") Then
                strSecondVariableType = "categorical"
            Else
                strSecondVariableType = "numeric"
            End If
            lblSecondType.Text = strSecondVariableType
            lblSecondType.ForeColor = SystemColors.Highlight
        Else
            strSecondVariableType = ""
            lblSecondType.Text = "________"
            lblSecondType.ForeColor = SystemColors.ControlText
        End If

        lblGraphName.Visible = False
        ucrInputNumericByNumeric.Visible = False
        ucrInputCategoricalByNumeric.Visible = False
        ucrInputNumericByCategorical.Visible = False
        ucrInputCategoricalByCategorical.Visible = False
        RemoveAllGeomsStats()
        If strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric" Then
            grpOptions.Visible = True
            ucrInputNumericByNumeric.Visible = True
            clsRFacet.RemoveParameterByName("scale")
            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByNumeric, iPosition:=0)
            Select Case ucrInputNumericByNumeric.GetText
                Case "Scatter plot"
                    clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                Case "Line plot"
                    clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLine, iPosition:=1)
                Case "Line plot + points"
                    clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLine, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=2)
            End Select
        ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" Then
            grpOptions.Visible = False
            ucrInputCategoricalByNumeric.Visible = True
            clsRFacet.AddParameter("scale", Chr(34) & "free_x" & Chr(34))
            Select Case ucrInputCategoricalByNumeric.GetText
                Case "Boxplot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                Case "Point plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                Case "Jitter plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=1)
                Case "Violin plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                Case "Boxplot + Jitter"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                Case "Violin plot + Jitter plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                Case "Violin plot + Boxplot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=2)
                Case "Summary Bars"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                    clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                    clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineCategoricalByNumeric, iPosition:=0)
                Case "Summary Bars + Points"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                    clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                    clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineCategoricalByNumeric, iPosition:=0)
                    clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=3)
                Case "Histogram"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_histogram", clsRFunctionParameter:=clsGeomHistogram, iPosition:=1)
                Case "Density plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_density", clsRFunctionParameter:=clsGeomDensity, iPosition:=1)
                Case "Frequency polygon"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_freqpoly", clsRFunctionParameter:=clsGeomFreqPoly, iPosition:=1)
            End Select
        ElseIf strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" Then
            grpOptions.Visible = True
            ucrInputNumericByCategorical.Visible = True
            clsRFacet.RemoveParameterByName("scale")
            Select Case ucrInputNumericByCategorical.GetText
                Case "Boxplot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                Case "Point plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                Case "Jitter plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=1)
                Case "Violin plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                Case "Boxplot + Jitter"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                Case "Violin plot + Jitter plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                Case "Violin plot + Boxplot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=0)
                    clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=2)
                Case "Histogram"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_histogram", clsRFunctionParameter:=clsGeomHistogram, iPosition:=1)
                Case "Density plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_density", clsRFunctionParameter:=clsGeomDensity, iPosition:=1)
                Case "Frequency polygon"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_freqpolygon", clsRFunctionParameter:=clsGeomFreqPoly, iPosition:=1)
            End Select
        ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" Then
            grpOptions.Visible = False
            ucrInputCategoricalByCategorical.Visible = True
            clsRFacet.AddParameter("scale", Chr(34) & "free_x" & Chr(34))
            If ucrInputCategoricalByCategorical IsNot Nothing Then
                Select Case ucrInputCategoricalByCategorical.GetText
                    Case "Bar Chart"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByCategoricalBarChart, iPosition:=0)
                        clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBar, iPosition:=1)
                    Case "Mosaic Plot"
                        clsRGGplotFunction.RemoveParameterByName("mapping")
                        clsGeomMosaic.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByCategoricalMosaicPlot, iPosition:=0)
                        clsBaseOperator.AddParameter("geom_mosaic", clsRFunctionParameter:=clsGeomMosaic, iPosition:=1)
                End Select
            End If
        Else
            grpOptions.Visible = False
            lblGraphName.Visible = True
            lblGraphName.Text = "__________"
            lblGraphName.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub Controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondVar.ControlValueChanged, ucrReceiverFirstVars.ControlValueChanged
        Results()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondVar.ControlContentsChanged, ucrReceiverFirstVars.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputCategoricalByCategorical_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputNumericByNumeric.ControlValueChanged, ucrInputNumericByCategorical.ControlValueChanged, ucrInputCategoricalByNumeric.ControlValueChanged, ucrInputCategoricalByCategorical.ControlValueChanged
        Results()
    End Sub

    Private Sub RemoveAllGeomsStats()
        If clsBaseOperator.clsParameters.Count > 0 Then
            For i As Integer = (clsBaseOperator.clsParameters.Count - 1) To 0 Step -1
                If clsBaseOperator.clsParameters(i).strArgumentName.StartsWith("geom") OrElse clsBaseOperator.clsParameters(i).strArgumentName.StartsWith("stat") Then
                    clsBaseOperator.RemoveParameter(clsBaseOperator.clsParameters(i))
                End If
            Next
        End If
    End Sub
End Class