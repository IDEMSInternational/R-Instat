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
Imports RDotNet
Public Class sdgPlots
    'Question to be discussed (later: need to explore first)/Exploration Task: In order to uniformise the code, could create a PlotOptionsSetup where all the necessary links between specific plots and plot options are made ? For the moment all these are scattered around. Might be necessary to have this flexibility though... 
    'Question to be discussed (later)/Exploration Task: Why do we have RSyntax given through here and not in the LayerOptions dialog ? Would it be easier to just give through the RSyntax everywhere, and locally extract/edit the necessary info in the different sdg's, ucr's ?  Sort of like it is done here ? As far as I understand, there is no clear attitude concerning what is shared, what is carried through, where, using what method. Maybe if we uniformise, choose a coherent attitiude, it will be easier to edit things, avoid bugs, add on functionalities...
    'Question to be discussed: Maybe there is a need for a more radical change: create a clsGgplot that would be carried through all graphics components and contain all the well organised ggplot necessary info, about different Layers, different parameters, theme, ... Then in the main dlg's initiating plots, there would be a method that interprets the info in clsGgplot inside the RSyntax. Big project, don't know if it's worth it, but could make things cleaner, easier to work with ? Maybe need a more detailed sketch of how this would be implemented before making decision whether it's worth the time investment or not...
    'Reaction to question/Task/more questions: Alternatively the RSyntax is already sort of playing this role. So maybe facilitating the access to the information stored inthe Rsyntax instead ? (Would consist in just writing a few methods ?) Then cleaning the material that is carried through to different graphics components editors by essentially sending the RSyntax ? But extracting deep info is probably combersome to do several times... Which is why there are these clsGgplotFunction, clsAesFunction ... ? Need to create a diagram of what is shared by whom, how and for what purpose in order to clarify best strategy...
    'Task: write an issue/proposal about this when ideas are a bit clearer.
    Public clsRsyntax As New RSyntax
    'This clsRSyntax is linked with the ucrBase.clsRSyntax from the dlg calling sdgPLotOptions...
    Public clsRggplotFunction As New RFunction
    Public clsGlobalAesFunction As New RFunction
    Public clsLabsFunction As New RFunction
    Public clsFacetFunction As New RFunction
    Public clsXLabFunction As New RFunction
    Public clsXScalecontinuousFunction As New RFunction
    Public clsYScalecontinuousFunction As New RFunction
    Public clsXScaleDiscreteFunction As New RFunction
    Public clsYScaleDiscreteFunction As New RFunction
    Public clsXScaleDateFunction As New RFunction
    Public clsYScaleDateFunction As New RFunction
    Public clsYLabFunction As New RFunction
    Public clsAttachFunction As New RFunction
    Public clsScaleColourViridisFunction As New RFunction
    Public clsScaleFillViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsPlotElementTitleFunction As New RFunction
    Private clsPlotElementSubTitleFunction As New RFunction
    Private clsPlotElementCaptionFunction As New RFunction
    Private clsPlotElementTagFunction As New RFunction
    Private clsPlotLegendTitleFunction As New RFunction
    Public clsBaseOperator As New ROperator
    Private bControlsInitialised As Boolean = False
    Private clsFillPaletteFunction As New RFunction
    Private clsColourPaletteFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsScaleColorColorblindFunction, clsScaleFillColorblindFunction As New RFunction
    Private clsScaleColorDistillerFunction, clsScaleFillDistillerFunction As New RFunction
    Private clsScalecolorcalcFunction, clsScalefillcalcFunction As New RFunction
    Private clsScalecoloreconomistFunction, clsScalefilleconomistFunction As New RFunction
    Private clsScalecolorexcelFunction, clsScalefillexcelFunction As New RFunction
    Private clsScalecolorfivethirtyeightFunction, clsScalefillfivethirtyeightFunction As New RFunction
    Private clsScalecolorgdocsFunction, clsScalefillgdocsFunction As New RFunction
    Private clsScalecolorpanderFunction, clsScalefillpanderFunction As New RFunction
    Private clsScalecolorptolFunction, clsScalefillptolFunction As New RFunction
    Private clsScalecolorsolarizedFunction, clsScalefillsolarizedFunction As New RFunction
    Private clsScalecolorfewFunction, clsScalefillfewFunction As New RFunction
    Private clsScalecolorhcFunction, clsScalefillhcFunction As New RFunction
    Private clsScalecolorstataFunction, clsScalefillstataFunction As New RFunction
    Private clsScalecolorwsjFunction, clsScalefillwsjFunction As New RFunction
    Private clsScalecolorcanvaFunction, clsScalefillcanvaFunction As New RFunction
    Private clsScalecolorexcelnewFunction, clsScalefillexcelnewFunction As New RFunction
    Private clsScalecolorgradienttableauFunction, clsScalefillgradienttableauFunction As New RFunction
    'All the previous RFunctions will eventually be stored as parameters (or parameters of parameters) within the RSyntax building the big Ggplot command "ggplot(...) + geom_..(..) + ... + theme(...) + scales(...) ..."
    'They are treated separately from the RSyntax for the sake of clarity, then sinked in eventually.
    Public bFirstLoad As Boolean = True
    Public strDataFrame As String
    Private bAdditionalLayersSetGlobal As Boolean
    Private clsFacetVariablesOperator As New ROperator
    Private strFirstVariable As String
    Private strSecondvariable As String
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bRCodeSet As Boolean = False
    Private bResetThemes As Boolean = True
    Private ucrBaseSelector As ucrSelector

    'Themes 
    'X axis angle
    Private clsXElementText As New RFunction
    Private clsXElementTitle As New RFunction
    Private clsYElemetText As New RFunction
    Private clsYElemetTitle As New RFunction

    'Polar Coordinates
    Private clsCoordPolarFunc As New RFunction
    Private clsCoordPolarStartOperator As New ROperator

    'Annotation control positions
    Private iSizeYPosition As Integer
    Private iAlphaYPosition As Integer
    Private iFillYPositon As Integer
    Private iLabelYposition As Integer

    'See bLayersDefaultIsGolobal below.
    Private dctTheta As New Dictionary(Of String, String)
    Private dctSequatailPairs As New Dictionary(Of String, String)
    Private dctDivergingPairs As New Dictionary(Of String, String)
    Private dctQualititivePairs As New Dictionary(Of String, String)
    Private dctSequatailPairsContinuous As New Dictionary(Of String, String)
    Private dctDivergingPairsContinuous As New Dictionary(Of String, String)
    Private dctQualititivePairsContinuous As New Dictionary(Of String, String)
    Public strAxisType As String

    Private Sub sdgPlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctThemes As New Dictionary(Of String, String)
        Dim dctLegendPosition As New Dictionary(Of String, String)
        Dim dctFillOptions As New Dictionary(Of String, String)
        Dim dctColourOptions As New Dictionary(Of String, String)
        Dim dctAnnotationGeom As New Dictionary(Of String, String)
        Dim dctFillGgthemes As New Dictionary(Of String, String)

        Dim strThemes As String()

        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter

        Dim clsCoordEqualFunc As New RFunction
        Dim clsCoordEqualParam As New RParameter



        ucrBaseSubdialog.iHelpTopicID = 136

        'facets tab  
        'Links the factor receivers, used for creating facets, with the selector. The variables need to be factors.
        ucr1stFactorReceiver.Selector = ucrFacetSelector
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.SetParameter(New RParameter("var1", 0))
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFactor1)
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.bUpdateRCodeFromControl = False

        ucr2ndFactorReceiver.Selector = ucrFacetSelector
        ucr2ndFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr2ndFactorReceiver.strSelectorHeading = "Factors"
        ucr2ndFactorReceiver.SetParameter(New RParameter("var2", 1))
        ucr2ndFactorReceiver.SetParameterIsString()
        ucr2ndFactorReceiver.bWithQuotes = False
        ucr2ndFactorReceiver.SetLinkedDisplayControl(lblFactor2)
        ucr2ndFactorReceiver.SetValuesToIgnore({"."})
        ucr2ndFactorReceiver.bUpdateRCodeFromControl = False

        ucrChkIncludeFacets.SetText("Include Facets")
        ucrChkIncludeFacets.AddParameterPresentCondition(True, "facets", True)
        ucrChkIncludeFacets.AddParameterPresentCondition(False, "facets", False)

        ucrChkIncludeTitles.SetText("Include Titles")
        ucrChkIncludeTitles.AddParameterPresentCondition(True, "titles", True)
        ucrChkIncludeTitles.AddParameterPresentCondition(False, "titles", False)

        ucrChkMargin.SetText("Margins")
        ucrChkMargin.SetParameter(New RParameter("margins", 2), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=False)
        ucrChkMargin.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMargin.SetRDefault("FALSE")

        ucrChkNoOfRowsOrColumns.AddFunctionNamesCondition(True, "facet_wrap", True)
        ucrChkNoOfRowsOrColumns.AddParameterPresentCondition(True, {"ncol", "nrow"}, True)
        ucrChkNoOfRowsOrColumns.AddFunctionNamesCondition(False, "facet_wrap", False)
        'ucrChkNoOfRowsOrColumns.AddParameterPresentCondition(False, {"ncol", "nrow"}, False)
        ucrChkNoOfRowsOrColumns.SetText("Fixed Number of Rows")

        ucrNudNumberofRows.SetParameter(New RParameter("nrow", 6))
        ucrNudNumberofRows.bAddRemoveParameter = False

        ucrChkFreeScalesX.SetText("Free Scales X")
        ucrChkFreeScalesX.SetParameter(New RParameter("scales", 4))
        ucrChkFreeScalesX.AddParameterValuesCondition(True, "scales", {Chr(34) & "free" & Chr(34), Chr(34) & "free_x" & Chr(34)})
        ucrChkFreeScalesX.AddParameterValuesCondition(False, "scales", {Chr(34) & "free" & Chr(34), Chr(34) & "free_x" & Chr(34)}, False)
        ucrChkFreeScalesX.bChangeParameterValue = False
        ucrChkFreeScalesX.bAddRemoveParameter = False

        ucrChkFreeScalesY.SetText("Free Scales Y")
        ucrChkFreeScalesY.SetParameter(New RParameter("scales", 5))
        ucrChkFreeScalesY.AddParameterValuesCondition(True, "scales", {Chr(34) & "free" & Chr(34), Chr(34) & "free_y" & Chr(34)})
        ucrChkFreeScalesY.AddParameterValuesCondition(False, "scales", {Chr(34) & "free" & Chr(34), Chr(34) & "free_y" & Chr(34)}, False)
        ucrChkFreeScalesY.bChangeParameterValue = False
        ucrChkFreeScalesY.bAddRemoveParameter = False

        'TODO space can be either: "fixed", "free", "free_x", "free_y"
        '     currently only implemented "free" or "fixed"
        ucrChkFreeSpace.SetText("Free Space")
        ucrChkFreeSpace.SetParameter(New RParameter("space", 3), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=False, strNewValueIfChecked:=Chr(34) & "free" & Chr(34), strNewValueIfUnchecked:=Chr(34) & "fixed" & Chr(34))
        ucrChkFreeSpace.SetRDefault(Chr(34) & "fixed" & Chr(34))
        ucrChkFreeSpace.AddToLinkedControls(ucrChkNoOfRowsOrColumns, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkLabeler.SetText("Include Variable Name in Labels")
        ucrChkLabeler.SetParameter(New RParameter("labeller", 7))
        ucrChkLabeler.AddParameterValuesCondition(True, "labeller", "label_both")
        ucrChkLabeler.AddParameterValuesCondition(False, "labeller", "label_value", False)
        ucrChkLabeler.SetValuesCheckedAndUnchecked("label_both", "label_value")
        ucrChkLabeler.SetRDefault("label_value")

        'Not setting parameter to write because of complex conditions for adding/removing this parameter
        'Conditions in place for reading function
        ucrPnlHorizonatalVertical.SetParameter(New RParameter("dir", 1))
        ucrPnlHorizonatalVertical.bChangeParameterValue = False
        ucrPnlHorizonatalVertical.AddRadioButton(rdoVertical)
        ucrPnlHorizonatalVertical.AddRadioButton(rdoHorizontal)
        ucrPnlHorizonatalVertical.AddParameterValuesCondition(rdoVertical, "dir", Chr(34) & "v" & Chr(34))
        ucrPnlHorizonatalVertical.AddParameterValuesCondition(rdoHorizontal, "dir", Chr(34) & "h" & Chr(34))
        ucrPnlHorizonatalVertical.SetRDefault(Chr(34) & "h" & Chr(34))

        ucrChkIncludeFacets.AddToLinkedControls(ucrFacetSelector, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucr1stFactorReceiver, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucr2ndFactorReceiver, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucrPnlHorizonatalVertical, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucrChkMargin, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucrChkFreeScalesX, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucrChkFreeScalesY, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucrChkFreeSpace, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucrChkLabeler, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucrChkDrop, {True}, bNewLinkedHideIfParameterMissing:=True)
        'layers tab 

        'titles tab

        ucrInputGraphTitle.SetParameter(New RParameter("title"))
        ucrInputGraphSubTitle.SetParameter(New RParameter("subtitle"))
        ucrInputGraphCaption.SetParameter(New RParameter("caption"))

        ucrInputTag.SetParameter(New RParameter("tag"))
        ucrInputLegendTitle.SetParameter(New RParameter("colour"))

        ucrInputGraphTitle.SetLinkedDisplayControl(lblTitle)
        ucrInputGraphSubTitle.SetLinkedDisplayControl(lblSubTitle)
        ucrInputGraphCaption.SetLinkedDisplayControl(lblCaption)

        ucrNudTitleSize.SetParameter(New RParameter("size"))
        ucrNudTitleSize.SetMinMax(0, Integer.MaxValue)
        ucrNudTitleSize.SetRDefault(20)
        ucrNudTitleSize.SetLinkedDisplayControl(lblTitleSize)

        ucrNudSubTitleSize.SetParameter(New RParameter("size"))
        ucrNudSubTitleSize.SetMinMax(0, Integer.MaxValue)
        ucrNudSubTitleSize.SetRDefault(15)
        ucrNudSubTitleSize.SetLinkedDisplayControl(lblSubTitleSize)

        ucrNudCaptionSize.SetParameter(New RParameter("size"))
        ucrNudCaptionSize.SetMinMax(0, Integer.MaxValue)
        ucrNudCaptionSize.SetRDefault(8)
        ucrNudCaptionSize.SetLinkedDisplayControl(lblCaptionSize)

        ucrNudTagSize.SetParameter(New RParameter("size"))
        ucrNudTagSize.SetMinMax(0, Integer.MaxValue)
        ucrNudTagSize.SetRDefault(20)

        ucrNudLegendSize.SetParameter(New RParameter("size"))
        ucrNudLegendSize.SetMinMax(0, Integer.MaxValue)
        ucrNudLegendSize.SetRDefault(18)

        ucrChkTag.SetText("Tag")
        ucrChkTag.AddToLinkedControls(ucrNudTagSize, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTag.AddToLinkedControls(ucrInputTag, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="A")
        ucrChkTag.AddParameterPresentCondition(True, "tag", True)
        ucrChkTag.AddParameterPresentCondition(False, "tag", False)

        ucrChkNewLegend.SetText("New Legend ")
        ucrChkNewLegend.AddToLinkedControls(ucrInputLegendTitle, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="new_title")
        ucrChkNewLegend.AddToLinkedControls(ucrNudLegendSize, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkNewLegend.AddParameterPresentCondition(True, {"colour", "fill"}, True)
        ucrChkNewLegend.AddParameterPresentCondition(False, {"colour", "fill"}, False)

        ucrInputTag.SetLinkedDisplayControl(lblTag)
        ucrInputLegendTitle.SetLinkedDisplayControl(lblLegendTitle)
        ucrNudTagSize.SetLinkedDisplayControl(lblTagSize)
        ucrNudLegendSize.SetLinkedDisplayControl(lblLegendSize)

        ucrChkIncludeTitles.AddToLinkedControls(ucrChkTag, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeTitles.AddToLinkedControls(ucrChkNewLegend, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeTitles.AddToLinkedControls(ucrInputGraphTitle, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeTitles.AddToLinkedControls(ucrInputGraphSubTitle, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeTitles.AddToLinkedControls(ucrInputGraphCaption, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeTitles.AddToLinkedControls(ucrNudTitleSize, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeTitles.AddToLinkedControls(ucrNudSubTitleSize, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeTitles.AddToLinkedControls(ucrNudCaptionSize, {True}, bNewLinkedHideIfParameterMissing:=True)

        'TODO what about the subtitle argument of labs?
        'TODO what about the caption argument of labs?

        'legend titles are more complex than this, suggest we disable until later
        'ucrPnlLegendTitle.AddRadioButton(rdoLegendTitleAuto)
        'ucrPnlLegendTitle.AddRadioButton(rdoLegendTitleCustom)
        'ucrPnlLegendTitle.AddParameterPresentCondition(rdoLegendTitleAuto, "labs", False)
        'ucrPnlLegendTitle.AddParameterPresentCondition(rdoLegendTitleAuto, "labs", True)
        'ucrPnlLegendTitle.AddToLinkedControls(ucrChkDisplayLegendTitle, {rdoLegendTitleCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrChkDisplayLegendTitle.SetText("Display")
        'ucrChkDisplayLegendTitle.AddToLinkedControls(ucrChkOverwriteLegendTitle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrChkOverwriteLegendTitle.SetText("Overwrite Title")
        'ucrChkOverwriteLegendTitle.AddToLinkedControls(ucrInputLegend, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputLegend.SetParameter(New RParameter("fill"))

        'X Axis tab
        ucrXAxis.InitialiseControl()

        'Y Axis tab
        ucrYAxis.InitialiseControl()

        'themes tab
        urChkSelectTheme.SetText("Select Theme")
        ' This position MUST be smaller than the position of the theme() parameter
        ' Otherwise this will overwrite any specific theme options selected
        ' Currently theme() is set to position 100
        ucrInputThemes.SetParameter(New RParameter("theme_name", iNewPosition:=14))
        urChkSelectTheme.AddToLinkedControls(ucrInputThemes, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        urChkSelectTheme.AddParameterPresentCondition(True, "theme_name")
        urChkSelectTheme.AddParameterPresentCondition(False, "theme_name", False)
        strThemes = GgplotDefaults.strThemes
        'Would prefer to do this through functions but auto updating function name not currently supported through combo box control
        For Each strTemp As String In strThemes
            If strTemp.StartsWith("theme_") Then
                dctThemes.Add(strTemp.Remove(0, 6), strTemp & "()")
            Else
                dctThemes.Add(strTemp, strTemp & "()")
            End If
        Next
        ucrInputThemes.SetItems(dctThemes)
        ' ucrInputThemes.SetRDefault("theme_grey()")
        ucrInputThemes.SetDropDownStyleAsNonEditable()

        'coordiantes tab
        ucrChkHorizontalPlot.SetText("Horizontal Plot (coord-flip)")
        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkHorizontalPlot.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkHorizontalPlot.AddParameterPresentCondition(True, "coord_flip", True)

        ucrChkSameScale.SetText("Same Scale (coord-equal)")
        clsCoordEqualFunc.SetPackageName("ggplot2")
        clsCoordEqualFunc.SetRCommand("coord_equal")
        clsCoordEqualParam.SetArgumentName("coord_equal")
        clsCoordEqualParam.SetArgument(clsCoordEqualFunc)
        ucrChkSameScale.SetParameter(clsCoordEqualParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkSameScale.AddParameterPresentCondition(True, "coord_equal", True)
        InitialiseTabs()

        'temporary disabled until implemented
        ' tbpLayers.Enabled = False
        grpLegendTitle.Enabled = False
        tbpCoordinates.Enabled = True
        'cmdAllOptions.Enabled = False
        'grpCommonOptions.Visible = False
        bControlsInitialised = True

        'Theme Tab Checkboxes under grpCommonOptions
        ucrChkLegendPosition.SetText("Legend Position")
        ucrChkLegendPosition.AddToLinkedControls(ucrInputLegendPosition, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrChkLegendPosition.AddParameterPresentCondition(True, "legend.position")
        ucrChkLegendPosition.AddParameterPresentCondition(False, "legend.position", False)

        'Polar Coordinates
        ucrChkUsePolarCoordinates.SetText("Polar Coordinates")
        ucrChkUsePolarCoordinates.AddParameterPresentCondition(True, "coord_polar")
        ucrChkUsePolarCoordinates.AddParameterPresentCondition(False, "coord_polar", False)
        ucrChkUsePolarCoordinates.AddToLinkedControls({ucrChkDirectionAnticlockwise, ucrInputStartingAngle}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkUsePolarCoordinates.AddToLinkedControls({ucrInputPolarCoordinates}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkDirectionAnticlockwise.SetText("Anticlockwise Direction")
        ucrChkDirectionAnticlockwise.SetParameter(New RParameter("direction"), bNewChangeParameterValue:=True, strNewValueIfChecked:="-1", strNewValueIfUnchecked:="1")
        ucrChkDirectionAnticlockwise.SetRDefault("1")

        ucrInputStartingAngle.SetParameter(New RParameter("0", iNewPosition:=0))
        ucrInputStartingAngle.SetValidationTypeAsNumeric()
        ucrInputStartingAngle.AddQuotesIfUnrecognised = False
        ucrInputStartingAngle.SetLinkedDisplayControl(New List(Of Control)({lblPi, lblStartingAngle}))


        dctTheta.Add("x", Chr(34) & "x" & Chr(34))
        dctTheta.Add("y", Chr(34) & "y" & Chr(34))
        ucrInputPolarCoordinates.SetParameter(New RParameter("theta", iNewPosition:=1))
        ucrInputPolarCoordinates.SetLinkedDisplayControl(lblPolarCoordinate)
        ucrInputPolarCoordinates.SetItems(dctTheta)
        ucrInputPolarCoordinates.SetDropDownStyleAsNonEditable()
        ucrInputPolarCoordinates.SetRDefault(Chr(34) & "x" & Chr(34))


        ucrChkXaxisAngle.SetText("X axis Tick Labels Angle")
        ucrChkXaxisAngle.AddToLinkedControls(ucrNudXAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10, bNewLinkedChangeParameterValue:=True)
        ucrNudXAngle.SetParameter(New RParameter("angle"))
        ucrChkXaxisAngle.AddParameterPresentCondition(True, "angle")
        ucrChkXaxisAngle.AddParameterPresentCondition(False, "angle", False)

        ucrChkXaxisSize.SetText("X axis Label Size")
        ucrChkXaxisSize.AddToLinkedControls(ucrNudXSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10, bNewLinkedChangeParameterValue:=True)
        ucrNudXSize.SetParameter(New RParameter("size"))
        ucrNudXSize.DecimalPlaces = 1
        ucrNudXSize.Increment = 0.1
        ucrChkXaxisSize.AddParameterPresentCondition(True, "size")
        ucrChkXaxisSize.AddParameterPresentCondition(False, "size", False)

        ucrChkYaxisSize.SetText("Y axis Label Size")
        ucrChkYaxisSize.AddToLinkedControls(ucrNudYSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10, bNewLinkedChangeParameterValue:=True)
        ucrNudYSize.SetParameter(New RParameter("size"))
        ucrNudYSize.DecimalPlaces = 1
        ucrNudYSize.Increment = 0.1
        ucrChkYaxisSize.AddParameterPresentCondition(True, "size")
        ucrChkYaxisSize.AddParameterPresentCondition(False, "size", False)

        ucrChkXaxisTickMarkLabelSize.SetText("X axis Tick Mark Label Size")
        ucrChkXaxisTickMarkLabelSize.AddToLinkedControls(ucrNudXaxisMarkSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10, bNewLinkedChangeParameterValue:=True)
        ucrNudXaxisMarkSize.SetParameter(New RParameter("size"))
        ucrNudXaxisMarkSize.DecimalPlaces = 1
        ucrNudXaxisMarkSize.Increment = 0.1
        ucrChkXaxisTickMarkLabelSize.AddParameterPresentCondition(True, "size")
        ucrChkXaxisTickMarkLabelSize.AddParameterPresentCondition(False, "size", False)

        ucrChkYaxisTickMarkLabelSize.SetText("Y axis Tick Mark Label Size")
        ucrChkYaxisTickMarkLabelSize.AddToLinkedControls(ucrNudYaxisMarkSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10, bNewLinkedChangeParameterValue:=True)
        ucrNudYaxisMarkSize.SetParameter(New RParameter("size"))
        ucrNudYaxisMarkSize.DecimalPlaces = 1
        ucrNudYaxisMarkSize.Increment = 0.1
        ucrChkYaxisTickMarkLabelSize.AddParameterPresentCondition(True, "size")
        ucrChkYaxisTickMarkLabelSize.AddParameterPresentCondition(False, "size", False)

        ucrChkDrop.SetParameter(New RParameter("drop", 8))
        ucrChkDrop.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDrop.SetText("Drop empty factor levels")
        ucrChkDrop.SetRDefault("TRUE")

        'Annotation
        ucrChkAnnotation.SetText("Annotation")
        ucrChkAnnotation.AddParameterPresentCondition(True, "annotate", True)
        ucrChkAnnotation.AddParameterPresentCondition(False, "annotate", False)

        ucrInputX.SetParameter(New RParameter("x", 0))
        ucrInputX.SetRDefault("NULL")
        ucrInputX.AddQuotesIfUnrecognised = False

        ucrInputY.SetParameter(New RParameter("y", 1))
        ucrInputY.SetRDefault("NULL")
        ucrInputY.AddQuotesIfUnrecognised = False

        ucrInputYmin.SetParameter(New RParameter("ymin", 2))
        ucrInputYmin.SetRDefault("NULL")
        ucrInputYmin.AddQuotesIfUnrecognised = False

        ucrInputXmin.SetParameter(New RParameter("xmin", 3))
        ucrInputXmin.SetRDefault("NULL")
        ucrInputXmin.AddQuotesIfUnrecognised = False

        ucrInputXend.SetParameter(New RParameter("xend", 4))
        ucrInputXend.SetRDefault("NULL")
        ucrInputXend.AddQuotesIfUnrecognised = False

        ucrInputYend.SetParameter(New RParameter("yend", 5))
        ucrInputYend.SetRDefault("NULL")
        ucrInputYend.AddQuotesIfUnrecognised = False

        ucrInputXmax.SetParameter(New RParameter("xmax", 6))
        ucrInputXmax.SetRDefault("NULL")
        ucrInputXmax.AddQuotesIfUnrecognised = False

        ucrInputYmax.SetParameter(New RParameter("ymax", 7))
        ucrInputYmax.SetRDefault("NULL")
        ucrInputYmax.AddQuotesIfUnrecognised = False

        ucrNudLinetype.SetParameter(New RParameter("linetype", 8))
        ucrNudLinetype.SetMinMax(iNewMin:=1)
        ucrNudLinetype.SetRDefault(1)
        ucrNudLinetype.SetLinkedDisplayControl(lblLinetype)

        ucrNudCurvature.SetParameter(New RParameter("curvature", 9))
        ucrNudCurvature.DecimalPlaces = 1
        ucrNudCurvature.SetRDefault(0.5)
        ucrNudCurvature.SetLinkedDisplayControl(lblCurvature)

        ucrNudCrossbarFatten.SetParameter(New RParameter("fatten", 10))
        ucrNudCrossbarFatten.SetMinMax(iNewMin:=0)
        ucrNudCrossbarFatten.SetRDefault(2.5)
        ucrNudCrossbarFatten.SetLinkedDisplayControl(lblCrossbarFatten)

        ucrNudPointrangeFatten.SetParameter(New RParameter("fatten", 11))
        ucrNudPointrangeFatten.SetMinMax(iNewMin:=0)
        ucrNudPointrangeFatten.SetRDefault(4)
        ucrNudPointrangeFatten.SetLinkedDisplayControl(lblPointrangeFatten)

        ucrInputLineend.SetParameter(New RParameter("lineend", 12))
        ucrInputLineend.SetItems({"butt", "square", "round"}, bAddConditions:=True)
        ucrInputLineend.SetRDefault(Chr(34) & "butt" & Chr(34))
        ucrInputLineend.SetLinkedDisplayControl(lblLineend)

        ucrNudAngle.SetParameter(New RParameter("angle", 13))
        ucrNudAngle.SetMinMax(0, 180)
        ucrNudAngle.Increment = 1
        ucrNudAngle.SetRDefault(90)
        ucrNudAngle.SetLinkedDisplayControl(lblAngle)

        ucrNudShape.SetParameter(New RParameter("shape", 14))
        ucrNudShape.SetMinMax(1, 255)
        ucrNudShape.Increment = 1
        ucrNudShape.SetRDefault(1)
        ucrNudShape.SetLinkedDisplayControl(lblShape)

        'Annotation Control positions
        iSizeYPosition = ucrNudSize.Location.Y
        iAlphaYPosition = ucrNudAlpha.Location.Y
        iFillYPositon = ucrInputFill.Location.Y
        iLabelYposition = ucrInputLabel.Location.Y

        ucrInputAnnotationGeoms.SetParameter(New RParameter("geom", iNewPosition:=15))
        dctAnnotationGeom.Add("text", Chr(34) & "text" & Chr(34))
        dctAnnotationGeom.Add("rect", Chr(34) & "rect" & Chr(34))
        dctAnnotationGeom.Add("segment", Chr(34) & "segment" & Chr(34))
        dctAnnotationGeom.Add("pointrange", Chr(34) & "pointrange" & Chr(34))
        dctAnnotationGeom.Add("label", Chr(34) & "label" & Chr(34))
        dctAnnotationGeom.Add("curve", Chr(34) & "curve" & Chr(34))
        dctAnnotationGeom.Add("linerange", Chr(34) & "linerange" & Chr(34))
        dctAnnotationGeom.Add("errorbar", Chr(34) & "errorbar" & Chr(34))
        dctAnnotationGeom.Add("crossbar", Chr(34) & "crossbar" & Chr(34))
        ucrInputAnnotationGeoms.SetItems(dctAnnotationGeom)
        ucrInputAnnotationGeoms.SetLinkedDisplayControl(New List(Of Control)({lblAnnotationGeoms, grpAnnotation}))


        ucrInputFill.SetParameter(New RParameter("fill", 16))
        ucrInputFill.SetRDefault(Chr(34) & "black" & Chr(34))
        ucrInputFill.SetLinkedDisplayControl(lblFill)

        ucrInputColour.SetParameter(New RParameter("colour", 17))
        ucrInputColour.SetLinkedDisplayControl(lblColour)
        ucrInputColour.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrNudAlpha.SetParameter(New RParameter("alpha", iNewPosition:=18))
        ucrNudAlpha.SetMinMax(0, 1)
        ucrNudAlpha.Increment = 0.01
        ucrNudAlpha.DecimalPlaces = 2
        ucrNudAlpha.SetLinkedDisplayControl(lblAlpha)
        ucrNudAlpha.SetRDefault(1.0)

        ucrNudSize.SetParameter(New RParameter("size", 19))
        ucrNudSize.SetMinMax(iNewMin:=0)
        ucrNudSize.Increment = 0.1
        ucrNudSize.DecimalPlaces = 1
        ucrNudSize.SetLinkedDisplayControl(lblSize)
        ucrNudSize.SetRDefault(0.5)

        ucrInputLabel.SetLinkedDisplayControl(lblLabel)
        ucrInputLabel.SetValidationTypeAsList()

        ucrChkParse.SetText("Parse")
        ucrChkParse.SetParameter(New RParameter("parse", 20))
        ucrChkParse.SetRDefault("FALSE")
        ucrChkParse.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkAnnotation.AddToLinkedControls(ucrInputAnnotationGeoms, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputAnnotationGeoms.AddToLinkedControls({ucrInputXmin, ucrInputXmax, ucrInputYmin, ucrInputYmax}, {"rect", "linerange", "errorbar", "crossbar", "pointrange"}, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrInputAnnotationGeoms.AddToLinkedControls({ucrInputY, ucrInputX}, {"text", "label", "segment", "curve", "linerange", "errorbar", "crossbar", "pointrange"}, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrInputAnnotationGeoms.AddToLinkedControls({ucrInputXend, ucrInputYend}, {"segment", "curve"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrInputAnnotationGeoms.AddToLinkedControls(ucrInputFill, {"rect", "label"}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True)
        ucrInputAnnotationGeoms.AddToLinkedControls(ucrNudLinetype, {"segment", "curve", "linerange", "errorbar", "crossbar", "pointrange"}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True)
        ucrInputAnnotationGeoms.AddToLinkedControls({ucrNudCurvature, ucrNudAngle}, {"curve"}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True)
        ucrInputAnnotationGeoms.AddToLinkedControls(ucrInputLineend, {"segment"}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True)
        ucrInputAnnotationGeoms.AddToLinkedControls(ucrNudCrossbarFatten, {"crossbar"}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True)
        ucrInputAnnotationGeoms.AddToLinkedControls({ucrNudShape, ucrNudPointrangeFatten}, {"pointrange"}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True)
        ucrInputAnnotationGeoms.AddToLinkedControls(ucrInputLabel, {"text", "label"}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        'Colour
        ucrPnlColourPalette.AddRadioButton(rdoSequential)
        ucrPnlColourPalette.AddRadioButton(rdoDiverging)
        ucrPnlColourPalette.AddRadioButton(rdoQualitative)
        ucrPnlColourPalette.AddRadioButton(rdoViridis)
        ucrPnlColourPalette.AddRadioButton(rdoGgthemes)

        ucrPnlScale.AddRadioButton(rdoColour)
        ucrPnlScale.AddRadioButton(rdoFill)

        ucrInputPalettes.SetParameter(New RParameter("palette", 7))
        ucrInputPalettes.bAllowNonConditionValues = True
        ucrInputPalettes.SetLinkedDisplayControl(lblPalette)

        ucrInputPaletteContinuous.SetParameter(New RParameter("palette", 8))
        ucrInputPaletteContinuous.bAllowNonConditionValues = True
        ucrInputPaletteContinuous.SetLinkedDisplayControl(lblPaletteContinuous)

        dctSequatailPairs.Add("Blues", Chr(34) & "Blues" & Chr(34))
        dctSequatailPairs.Add("Greens", Chr(34) & "Greens" & Chr(34))
        dctSequatailPairs.Add("Greys", Chr(34) & "Greys" & Chr(34))
        dctSequatailPairs.Add("Oranges", Chr(34) & "Oranges" & Chr(34))
        dctSequatailPairs.Add("Purples", Chr(34) & "Purples" & Chr(34))
        dctSequatailPairs.Add("Reds", Chr(34) & "Reds" & Chr(34))
        dctSequatailPairs.Add("BuGn", Chr(34) & "BuGn" & Chr(34))
        dctSequatailPairs.Add("BuPu", Chr(34) & "BuPu" & Chr(34))
        dctSequatailPairs.Add("GnBu", Chr(34) & "GnBu" & Chr(34))
        dctSequatailPairs.Add("OrRd", Chr(34) & "OrRd" & Chr(34))
        dctSequatailPairs.Add("PuBu", Chr(34) & "PuBu" & Chr(34))
        dctSequatailPairs.Add("PuBuGn", Chr(34) & "PuBuGn" & Chr(34))
        dctSequatailPairs.Add("PuRd", Chr(34) & "PuRd" & Chr(34))
        dctSequatailPairs.Add("RdPu", Chr(34) & "RdPu" & Chr(34))
        dctSequatailPairs.Add("YlGn", Chr(34) & "YlGn" & Chr(34))
        dctSequatailPairs.Add("YlGnBu", Chr(34) & "YlGnBu" & Chr(34))
        dctSequatailPairs.Add("YlOrBr", Chr(34) & "YlOrBr" & Chr(34))
        dctSequatailPairs.Add("YlOrRd", Chr(34) & "YlOrRd" & Chr(34))
        ucrInputPalettes.SetItems(dctSequatailPairs)
        ucrInputPalettes.SetDropDownStyleAsNonEditable()

        dctSequatailPairsContinuous.Add("Blues", Chr(34) & "Blues" & Chr(34))
        dctSequatailPairsContinuous.Add("Greens", Chr(34) & "Greens" & Chr(34))
        dctSequatailPairsContinuous.Add("Greys", Chr(34) & "Greys" & Chr(34))
        dctSequatailPairsContinuous.Add("Oranges", Chr(34) & "Oranges" & Chr(34))
        dctSequatailPairsContinuous.Add("Purples", Chr(34) & "Purples" & Chr(34))
        dctSequatailPairsContinuous.Add("Reds", Chr(34) & "Reds" & Chr(34))
        dctSequatailPairsContinuous.Add("BuGn", Chr(34) & "BuGn" & Chr(34))
        dctSequatailPairsContinuous.Add("BuPu", Chr(34) & "BuPu" & Chr(34))
        dctSequatailPairsContinuous.Add("GnBu", Chr(34) & "GnBu" & Chr(34))
        dctSequatailPairsContinuous.Add("OrRd", Chr(34) & "OrRd" & Chr(34))
        dctSequatailPairsContinuous.Add("PuBu", Chr(34) & "PuBu" & Chr(34))
        dctSequatailPairsContinuous.Add("PuBuGn", Chr(34) & "PuBuGn" & Chr(34))
        dctSequatailPairsContinuous.Add("PuRd", Chr(34) & "PuRd" & Chr(34))
        dctSequatailPairsContinuous.Add("RdPu", Chr(34) & "RdPu" & Chr(34))
        dctSequatailPairsContinuous.Add("YlGn", Chr(34) & "YlGn" & Chr(34))
        dctSequatailPairsContinuous.Add("YlGnBu", Chr(34) & "YlGnBu" & Chr(34))
        dctSequatailPairsContinuous.Add("YlOrBr", Chr(34) & "YlOrBr" & Chr(34))
        dctSequatailPairsContinuous.Add("YlOrRd", Chr(34) & "YlOrRd" & Chr(34))
        ucrInputPaletteContinuous.SetItems(dctSequatailPairsContinuous)
        ucrInputPaletteContinuous.SetDropDownStyleAsNonEditable()

        dctDivergingPairs.Add("Spectral", Chr(34) & "Spectral" & Chr(34))
        dctDivergingPairs.Add("BrBG", Chr(34) & "BrBG" & Chr(34))
        dctDivergingPairs.Add("PiYG", Chr(34) & "PiYG" & Chr(34))
        dctDivergingPairs.Add("PRGn", Chr(34) & "PRGn" & Chr(34))
        dctDivergingPairs.Add("PuOr", Chr(34) & "PuOr" & Chr(34))
        dctDivergingPairs.Add("RdBu", Chr(34) & "RdBu" & Chr(34))
        dctDivergingPairs.Add("RdGy", Chr(34) & "RdGy" & Chr(34))
        dctDivergingPairs.Add("RdYlBu", Chr(34) & "RdYlBu" & Chr(34))
        dctDivergingPairs.Add("RdYlGn", Chr(34) & "RdYlGn" & Chr(34))

        dctQualititivePairs.Add("Accent", Chr(34) & "Accent" & Chr(34))
        dctQualititivePairs.Add("Dark2", Chr(34) & "Dark2" & Chr(34))
        dctQualititivePairs.Add("Pastel1", Chr(34) & "Pastel1" & Chr(34))
        dctQualititivePairs.Add("Pastel2", Chr(34) & "Pastel2" & Chr(34))
        dctQualititivePairs.Add("Set1", Chr(34) & "Set1" & Chr(34))
        dctQualititivePairs.Add("Set2", Chr(34) & "Set2" & Chr(34))
        dctQualititivePairs.Add("Set3", Chr(34) & "Set3" & Chr(34))

        dctDivergingPairsContinuous.Add("Spectral", Chr(34) & "Spectral" & Chr(34))
        dctDivergingPairsContinuous.Add("BrBG", Chr(34) & "BrBG" & Chr(34))
        dctDivergingPairsContinuous.Add("PiYG", Chr(34) & "PiYG" & Chr(34))
        dctDivergingPairsContinuous.Add("PRGn", Chr(34) & "PRGn" & Chr(34))
        dctDivergingPairsContinuous.Add("PuOr", Chr(34) & "PuOr" & Chr(34))
        dctDivergingPairsContinuous.Add("RdBu", Chr(34) & "RdBu" & Chr(34))
        dctDivergingPairsContinuous.Add("RdGy", Chr(34) & "RdGy" & Chr(34))
        dctDivergingPairsContinuous.Add("RdYlBu", Chr(34) & "RdYlBu" & Chr(34))
        dctDivergingPairsContinuous.Add("RdYlGn", Chr(34) & "RdYlGn" & Chr(34))

        dctQualititivePairsContinuous.Add("Accent", Chr(34) & "Accent" & Chr(34))
        dctQualititivePairsContinuous.Add("Dark2", Chr(34) & "Dark2" & Chr(34))
        dctQualititivePairsContinuous.Add("Pastel1", Chr(34) & "Pastel1" & Chr(34))
        dctQualititivePairsContinuous.Add("Pastel2", Chr(34) & "Pastel2" & Chr(34))
        dctQualititivePairsContinuous.Add("Set1", Chr(34) & "Set1" & Chr(34))
        dctQualititivePairsContinuous.Add("Set2", Chr(34) & "Set2" & Chr(34))
        dctQualititivePairsContinuous.Add("Set3", Chr(34) & "Set3" & Chr(34))

        ucrChkDropUnusedLevels.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevels.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevels.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevels.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevels.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevels.AddToLinkedControls(ucrInputDropUnusedLevels, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevels.SetItems({"TRUE", "FALSE"})

        ucrChkPosition.SetText("Position")
        ucrChkPosition.AddToLinkedControls(ucrInputPosition, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPosition.SetDropDownStyleAsNonEditable()
        ucrInputPosition.SetParameter(New RParameter("position"))
        ucrInputPosition.SetItems({"left", "right", "bottom", "top"})
        ucrChkPosition.AddParameterPresentCondition(True, "position")
        ucrChkPosition.AddParameterPresentCondition(False, "position", False)

        ucrChkExpand.SetText("Expand")
        ucrChkExpand.AddParameterPresentCondition(True, "expand")
        ucrChkExpand.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpand.AddToLinkedControls(ucrInputTextExpand, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpand.SetValidationTypeAsNumericList()

        ucrChkBreaks.SetText("Breaks")
        ucrChkBreaks.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaks.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaks.AddToLinkedControls(ucrInputTextBreaks, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaks.SetValidationTypeAsList()

        ucrChkLimit.SetText("Limits")
        ucrChkLimit.AddParameterPresentCondition(True, "limit")
        ucrChkLimit.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimit.AddToLinkedControls(ucrInputTextLimit, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimit.SetValidationTypeAsList()

        ucrInputTextNaValue.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValue.SetValidationTypeAsNumeric()
        ucrInputTextNaValue.bAddRemoveParameter = False
        ucrInputTextNaValue.AddQuotesIfUnrecognised = False

        ucrChkNaValue.SetText("Replace Missing Values")
        ucrChkNaValue.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValue.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValue.AddToLinkedControls(ucrInputTextNaValue, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColor.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColor.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColor.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColor.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColor.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColor.AddToLinkedControls(ucrInputDropUnusedLevelsColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColor.SetItems({"TRUE", "FALSE"})

        ucrInputAxisType.SetItems({"continuous", "discrete"})
        ucrInputAxisType.SetDropDownStyleAsNonEditable()
        'ucrInputAxisType.SetRDefault("discrete")

        ucrChkPositionColor.SetText("Position")
        ucrChkPositionColor.AddToLinkedControls(ucrInputPositionColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColor.SetDropDownStyleAsNonEditable()
        ucrInputPositionColor.SetParameter(New RParameter("position"))
        ucrInputPositionColor.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColor.AddParameterPresentCondition(True, "position")
        ucrChkPositionColor.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColor.SetText("Expand")
        ucrChkExpandColor.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColor.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColor.AddToLinkedControls(ucrInputTextExpandColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColor.SetValidationTypeAsNumericList()

        ucrChkBreaksColor.SetText("Breaks")
        ucrChkBreaksColor.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColor.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColor.AddToLinkedControls(ucrInputTextBreaksColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColor.SetValidationTypeAsList()

        ucrChkLimitColor.SetText("Limits")
        ucrChkLimitColor.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColor.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColor.AddToLinkedControls(ucrInputTextLimitColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColor.SetValidationTypeAsList()

        ucrInputTextNaValueColor.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColor.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColor.bAddRemoveParameter = False
        ucrInputTextNaValueColor.AddQuotesIfUnrecognised = False

        ucrChkNaValueColor.SetText("Replace Missing Values")
        ucrChkNaValueColor.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColor.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColor.AddToLinkedControls(ucrInputTextNaValueColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsCal.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsCal.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsCal.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsCal.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsCal.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsCal.AddToLinkedControls(ucrInputDropUnusedLevelsCal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsCal.SetItems({"TRUE", "FALSE"})

        ucrChkPositionCal.SetText("Position")
        ucrChkPositionCal.AddToLinkedControls(ucrInputPositionCal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionCal.SetDropDownStyleAsNonEditable()
        ucrInputPositionCal.SetParameter(New RParameter("position"))
        ucrInputPositionCal.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionCal.AddParameterPresentCondition(True, "position")
        ucrChkPositionCal.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandCal.SetText("Expand")
        ucrChkExpandCal.AddParameterPresentCondition(True, "expand")
        ucrChkExpandCal.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandCal.AddToLinkedControls(ucrInputTextExpandCal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandCal.SetValidationTypeAsNumericList()

        ucrChkBreaksCal.SetText("Breaks")
        ucrChkBreaksCal.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksCal.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksCal.AddToLinkedControls(ucrInputTextBreaksCal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksCal.SetValidationTypeAsList()

        ucrChkLimitCal.SetText("Limits")
        ucrChkLimitCal.AddParameterPresentCondition(True, "limit")
        ucrChkLimitCal.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitCal.AddToLinkedControls(ucrInputTextLimitCal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitCal.SetValidationTypeAsList()

        ucrInputTextNaValueCal.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueCal.SetValidationTypeAsNumeric()
        ucrInputTextNaValueCal.bAddRemoveParameter = False
        ucrInputTextNaValueCal.AddQuotesIfUnrecognised = False

        ucrChkNaValueCal.SetText("Replace Missing Values")
        ucrChkNaValueCal.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueCal.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueCal.AddToLinkedControls(ucrInputTextNaValueCal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorCal.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorCal.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorCal.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorCal.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorCal.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorCal.AddToLinkedControls(ucrInputDropUnusedLevelsColorCal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorCal.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorCal.SetText("Position")
        ucrChkPositionColorCal.AddToLinkedControls(ucrInputPositionColorCal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorCal.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorCal.SetParameter(New RParameter("position"))
        ucrInputPositionColorCal.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorCal.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorCal.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorCal.SetText("Expand")
        ucrChkExpandColorCal.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorCal.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorCal.AddToLinkedControls(ucrInputTextExpandColorCal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorCal.SetValidationTypeAsNumericList()

        ucrChkBreaksColorCal.SetText("Breaks")
        ucrChkBreaksColorCal.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorCal.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorCal.AddToLinkedControls(ucrInputTextBreaksColorCal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorCal.SetValidationTypeAsList()

        ucrChkLimitColorCal.SetText("Limits")
        ucrChkLimitColorCal.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorCal.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorCal.AddToLinkedControls(ucrInputTextLimitColorCal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorCal.SetValidationTypeAsList()

        ucrInputTextNaValueColorCal.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorCal.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorCal.bAddRemoveParameter = False
        ucrInputTextNaValueColorCal.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorCal.SetText("Replace Missing Values")
        ucrChkNaValueColorCal.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorCal.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorCal.AddToLinkedControls(ucrInputTextNaValueColorCal, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsEcon.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsEcon.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsEcon.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsEcon.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsEcon.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsEcon.AddToLinkedControls(ucrInputDropUnusedLevelsEcon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsEcon.SetItems({"TRUE", "FALSE"})

        ucrChkPositionEcon.SetText("Position")
        ucrChkPositionEcon.AddToLinkedControls(ucrInputPositionEcon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionEcon.SetDropDownStyleAsNonEditable()
        ucrInputPositionEcon.SetParameter(New RParameter("position"))
        ucrInputPositionEcon.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionEcon.AddParameterPresentCondition(True, "position")
        ucrChkPositionEcon.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandEcon.SetText("Expand")
        ucrChkExpandEcon.AddParameterPresentCondition(True, "expand")
        ucrChkExpandEcon.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandEcon.AddToLinkedControls(ucrInputTextExpandEcon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandEcon.SetValidationTypeAsNumericList()

        ucrChkBreaksEcon.SetText("Breaks")
        ucrChkBreaksEcon.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksEcon.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksEcon.AddToLinkedControls(ucrInputTextBreaksEcon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksEcon.SetValidationTypeAsList()

        ucrChkLimitEcon.SetText("Limits")
        ucrChkLimitEcon.AddParameterPresentCondition(True, "limit")
        ucrChkLimitEcon.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitEcon.AddToLinkedControls(ucrInputTextLimitEcon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitEcon.SetValidationTypeAsList()

        ucrInputTextNaValueEcon.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueEcon.SetValidationTypeAsNumeric()
        ucrInputTextNaValueEcon.bAddRemoveParameter = False
        ucrInputTextNaValueEcon.AddQuotesIfUnrecognised = False

        ucrChkNaValueEcon.SetText("Replace Missing Values")
        ucrChkNaValueEcon.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueEcon.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueEcon.AddToLinkedControls(ucrInputTextNaValueEcon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorEcon.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorEcon.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorEcon.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorEcon.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorEcon.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorEcon.AddToLinkedControls(ucrInputDropUnusedLevelsColorEcon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorEcon.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorEcon.SetText("Position")
        ucrChkPositionColorEcon.AddToLinkedControls(ucrInputPositionColorEcon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorEcon.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorEcon.SetParameter(New RParameter("position"))
        ucrInputPositionColorEcon.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorEcon.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorEcon.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorEcon.SetText("Expand")
        ucrChkExpandColorEcon.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorEcon.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorEcon.AddToLinkedControls(ucrInputTextExpandColorEcon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorEcon.SetValidationTypeAsNumericList()

        ucrChkBreaksColorEcon.SetText("Breaks")
        ucrChkBreaksColorEcon.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorEcon.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorEcon.AddToLinkedControls(ucrInputTextBreaksColorEcon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorEcon.SetValidationTypeAsList()

        ucrChkLimitColorEcon.SetText("Limits")
        ucrChkLimitColorEcon.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorEcon.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorEcon.AddToLinkedControls(ucrInputTextLimitColorEcon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorEcon.SetValidationTypeAsList()

        ucrInputTextNaValueColorEcon.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorEcon.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorEcon.bAddRemoveParameter = False
        ucrInputTextNaValueColorEcon.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorEcon.SetText("Replace Missing Values")
        ucrChkNaValueColorEcon.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorEcon.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorEcon.AddToLinkedControls(ucrInputTextNaValueColorEcon, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsEx.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsEx.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsEx.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsEx.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsEx.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsEx.AddToLinkedControls(ucrInputDropUnusedLevelsEx, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsEx.SetItems({"TRUE", "FALSE"})

        ucrChkPositionEx.SetText("Position")
        ucrChkPositionEx.AddToLinkedControls(ucrInputPositionEx, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionEx.SetDropDownStyleAsNonEditable()
        ucrInputPositionEx.SetParameter(New RParameter("position"))
        ucrInputPositionEx.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionEx.AddParameterPresentCondition(True, "position")
        ucrChkPositionEx.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandEx.SetText("Expand")
        ucrChkExpandEx.AddParameterPresentCondition(True, "expand")
        ucrChkExpandEx.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandEx.AddToLinkedControls(ucrInputTextExpandEx, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandEx.SetValidationTypeAsNumericList()

        ucrChkBreaksEx.SetText("Breaks")
        ucrChkBreaksEx.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksEx.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksEx.AddToLinkedControls(ucrInputTextBreaksEx, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksEx.SetValidationTypeAsList()

        ucrChkLimitEx.SetText("Limits")
        ucrChkLimitEx.AddParameterPresentCondition(True, "limit")
        ucrChkLimitEx.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitEx.AddToLinkedControls(ucrInputTextLimitEx, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitEx.SetValidationTypeAsList()

        ucrInputTextNaValueEx.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueEx.SetValidationTypeAsNumeric()
        ucrInputTextNaValueEx.bAddRemoveParameter = False
        ucrInputTextNaValueEx.AddQuotesIfUnrecognised = False

        ucrChkNaValueEx.SetText("Replace Missing Values")
        ucrChkNaValueEx.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueEx.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueEx.AddToLinkedControls(ucrInputTextNaValueEx, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorEx.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorEx.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorEx.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorEx.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorEx.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorEx.AddToLinkedControls(ucrInputDropUnusedLevelsColorEx, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorEx.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorEx.SetText("Position")
        ucrChkPositionColorEx.AddToLinkedControls(ucrInputPositionColorEx, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorEx.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorEx.SetParameter(New RParameter("position"))
        ucrInputPositionColorEx.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorEx.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorEx.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorEx.SetText("Expand")
        ucrChkExpandColorEx.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorEx.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorEx.AddToLinkedControls(ucrInputTextExpandColorEx, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorEx.SetValidationTypeAsNumericList()

        ucrChkBreaksColorEx.SetText("Breaks")
        ucrChkBreaksColorEx.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorEx.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorEx.AddToLinkedControls(ucrInputTextBreaksColorEx, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorEx.SetValidationTypeAsList()

        ucrChkLimitColorEx.SetText("Limits")
        ucrChkLimitColorEx.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorEx.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorEx.AddToLinkedControls(ucrInputTextLimitColorEx, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorEx.SetValidationTypeAsList()

        ucrInputTextNaValueColorEx.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorEx.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorEx.bAddRemoveParameter = False
        ucrInputTextNaValueColorEx.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorEx.SetText("Replace Missing Values")
        ucrChkNaValueColorEx.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorEx.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorEx.AddToLinkedControls(ucrInputTextNaValueColorEx, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsExn.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsExn.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsExn.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsExn.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsExn.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsExn.AddToLinkedControls(ucrInputDropUnusedLevelsExn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsExn.SetItems({"TRUE", "FALSE"})

        ucrChkPositionExn.SetText("Position")
        ucrChkPositionExn.AddToLinkedControls(ucrInputPositionExn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionExn.SetDropDownStyleAsNonEditable()
        ucrInputPositionExn.SetParameter(New RParameter("position"))
        ucrInputPositionExn.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionExn.AddParameterPresentCondition(True, "position")
        ucrChkPositionExn.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandExn.SetText("Expand")
        ucrChkExpandExn.AddParameterPresentCondition(True, "expand")
        ucrChkExpandExn.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandExn.AddToLinkedControls(ucrInputTextExpandExn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandExn.SetValidationTypeAsNumericList()

        ucrChkBreaksExn.SetText("Breaks")
        ucrChkBreaksExn.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksExn.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksExn.AddToLinkedControls(ucrInputTextBreaksExn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksExn.SetValidationTypeAsList()

        ucrChkLimitExn.SetText("Limits")
        ucrChkLimitExn.AddParameterPresentCondition(True, "limit")
        ucrChkLimitExn.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitExn.AddToLinkedControls(ucrInputTextLimitExn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitExn.SetValidationTypeAsList()

        ucrInputTextNaValueExn.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueExn.SetValidationTypeAsNumeric()
        ucrInputTextNaValueExn.bAddRemoveParameter = False
        ucrInputTextNaValueExn.AddQuotesIfUnrecognised = False

        ucrChkNaValueExn.SetText("Replace Missing Values")
        ucrChkNaValueExn.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueExn.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueExn.AddToLinkedControls(ucrInputTextNaValueExn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorExn.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorExn.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorExn.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorExn.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorExn.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorExn.AddToLinkedControls(ucrInputDropUnusedLevelsColorExn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorExn.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorExn.SetText("Position")
        ucrChkPositionColorExn.AddToLinkedControls(ucrInputPositionColorExn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorExn.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorExn.SetParameter(New RParameter("position"))
        ucrInputPositionColorExn.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorExn.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorExn.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorExn.SetText("Expand")
        ucrChkExpandColorExn.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorExn.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorExn.AddToLinkedControls(ucrInputTextExpandColorExn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorExn.SetValidationTypeAsNumericList()

        ucrChkBreaksColorExn.SetText("Breaks")
        ucrChkBreaksColorExn.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorExn.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorExn.AddToLinkedControls(ucrInputTextBreaksColorExn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorExn.SetValidationTypeAsList()

        ucrChkLimitColorExn.SetText("Limits")
        ucrChkLimitColorExn.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorExn.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorExn.AddToLinkedControls(ucrInputTextLimitColorExn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorExn.SetValidationTypeAsList()

        ucrInputTextNaValueColorExn.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorExn.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorExn.bAddRemoveParameter = False
        ucrInputTextNaValueColorExn.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorExn.SetText("Replace Missing Values")
        ucrChkNaValueColorExn.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorExn.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorExn.AddToLinkedControls(ucrInputTextNaValueColorExn, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkThemecolor.SetText("Theme:")
        ucrChkThemecolor.AddToLinkedControls(ucrInputThemeColor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Atlas")
        ucrInputThemeColor.SetDropDownStyleAsNonEditable()
        ucrInputThemeColor.SetParameter(New RParameter("theme"))
        ucrInputThemeColor.SetItems({"Atlas", "Badge", "Berlin", "Celestial", "Crop", "Depth", "Droplet", "Facet", "Feathered", "Gallery", "Headlines", "Integral", "Ion Boardroom", "Ion", "Madison", "Main Event", "Mesh", "Office Theme", "Organic", "Parallax", "Parcel",
                                    "Retrospect", "Savon", "Slice", "Vapor Trail", "View", "Wisp", "Wood Type", "Aspect", "Blue Green", "Blue II", "Blue Warm", "Blue", "Grayscale", "Green Yellow", "Green", "Marquee", "Median", "Office 2007-2010", "Orange Red", "Orange", "Paper", "Red Orange", "Red Violet", "Red", "Slipstream", "Violet II", "Violet", "Yellow Orange", "Yellow"})
        ucrChkThemecolor.AddParameterPresentCondition(True, "theme")
        ucrChkThemecolor.AddParameterPresentCondition(False, "theme", False)

        ucrChkThemeFill.SetText("Theme:")
        ucrChkThemeFill.AddToLinkedControls(ucrInputThemeFill, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Atlas")
        ucrInputThemeFill.SetDropDownStyleAsNonEditable()
        ucrInputThemeFill.SetParameter(New RParameter("theme"))
        ucrInputThemeFill.SetItems({"Atlas", "Badge", "Berlin", "Celestial", "Crop", "Depth", "Droplet", "Facet", "Feathered", "Gallery", "Headlines", "Integral", "Ion Boardroom", "Ion", "Madison", "Main Event", "Mesh", "Office Theme", "Organic", "Parallax", "Parcel",
                                   "Retrospect", "Savon", "Slice", "Vapor Trail", "View", "Wisp", "Wood Type", "Aspect", "Blue Green", "Blue II", "Blue Warm", "Blue", "Grayscale", "Green Yellow", "Green", "Marquee", "Median", "Office 2007-2010", "Orange Red", "Orange", "Paper", "Red Orange", "Red Violet", "Red", "Slipstream", "Violet II", "Violet", "Yellow Orange", "Yellow"})
        ucrChkThemeFill.AddParameterPresentCondition(True, "theme")
        ucrChkThemeFill.AddParameterPresentCondition(False, "theme", False)

        ucrChkDropUnusedLevelsfew.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsfew.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsfew.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsfew.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsfew.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsfew.AddToLinkedControls(ucrInputDropUnusedLevelsfew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsfew.SetItems({"TRUE", "FALSE"})

        ucrChkPositionfew.SetText("Position")
        ucrChkPositionfew.AddToLinkedControls(ucrInputPositionfew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionfew.SetDropDownStyleAsNonEditable()
        ucrInputPositionfew.SetParameter(New RParameter("position"))
        ucrInputPositionfew.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionfew.AddParameterPresentCondition(True, "position")
        ucrChkPositionfew.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandfew.SetText("Expand")
        ucrChkExpandfew.AddParameterPresentCondition(True, "expand")
        ucrChkExpandfew.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandfew.AddToLinkedControls(ucrInputTextExpandfew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandfew.SetValidationTypeAsNumericList()

        ucrChkBreaksfew.SetText("Breaks")
        ucrChkBreaksfew.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksfew.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksfew.AddToLinkedControls(ucrInputTextBreaksfew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksfew.SetValidationTypeAsList()

        ucrChkLimitfew.SetText("Limits")
        ucrChkLimitfew.AddParameterPresentCondition(True, "limit")
        ucrChkLimitfew.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitfew.AddToLinkedControls(ucrInputTextLimitfew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitfew.SetValidationTypeAsList()

        ucrInputTextNaValuefew.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValuefew.SetValidationTypeAsNumeric()
        ucrInputTextNaValuefew.bAddRemoveParameter = False
        ucrInputTextNaValuefew.AddQuotesIfUnrecognised = False

        ucrChkNaValuefew.SetText("Replace Missing Values")
        ucrChkNaValuefew.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValuefew.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValuefew.AddToLinkedControls(ucrInputTextNaValuefew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorfew.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorfew.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorfew.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorfew.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorfew.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorfew.AddToLinkedControls(ucrInputDropUnusedLevelsColorfew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorfew.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorfew.SetText("Position")
        ucrChkPositionColorfew.AddToLinkedControls(ucrInputPositionColorfew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorfew.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorfew.SetParameter(New RParameter("position"))
        ucrInputPositionColorfew.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorfew.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorfew.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorfew.SetText("Expand")
        ucrChkExpandColorfew.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorfew.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorfew.AddToLinkedControls(ucrInputTextExpandColorfew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorfew.SetValidationTypeAsNumericList()

        ucrChkBreaksColorfew.SetText("Breaks")
        ucrChkBreaksColorfew.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorfew.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorfew.AddToLinkedControls(ucrInputTextBreaksColorfew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorfew.SetValidationTypeAsList()

        ucrChkLimitColorfew.SetText("Limits")
        ucrChkLimitColorfew.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorfew.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorfew.AddToLinkedControls(ucrInputTextLimitColorfew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorfew.SetValidationTypeAsList()

        ucrInputTextNaValueColorfew.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorfew.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorfew.bAddRemoveParameter = False
        ucrInputTextNaValueColorfew.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorfew.SetText("Replace Missing Values")
        ucrChkNaValueColorfew.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorfew.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorfew.AddToLinkedControls(ucrInputTextNaValueColorfew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsfiv.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsfiv.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsfiv.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsfiv.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsfiv.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsfiv.AddToLinkedControls(ucrInputDropUnusedLevelsfiv, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsfiv.SetItems({"TRUE", "FALSE"})

        ucrChkPositionfiv.SetText("Position")
        ucrChkPositionfiv.AddToLinkedControls(ucrInputPositionfiv, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionfiv.SetDropDownStyleAsNonEditable()
        ucrInputPositionfiv.SetParameter(New RParameter("position"))
        ucrInputPositionfiv.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionfiv.AddParameterPresentCondition(True, "position")
        ucrChkPositionfiv.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandfiv.SetText("Expand")
        ucrChkExpandfiv.AddParameterPresentCondition(True, "expand")
        ucrChkExpandfiv.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandfiv.AddToLinkedControls(ucrInputTextExpandfiv, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandfiv.SetValidationTypeAsNumericList()

        ucrChkBreaksfiv.SetText("Breaks")
        ucrChkBreaksfiv.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksfiv.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksfiv.AddToLinkedControls(ucrInputTextBreaksfiv, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksfiv.SetValidationTypeAsList()

        ucrChkLimitfiv.SetText("Limits")
        ucrChkLimitfiv.AddParameterPresentCondition(True, "limit")
        ucrChkLimitfiv.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitfiv.AddToLinkedControls(ucrInputTextLimitfiv, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitfiv.SetValidationTypeAsList()

        ucrInputTextNaValuefiv.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValuefiv.SetValidationTypeAsNumeric()
        ucrInputTextNaValuefiv.bAddRemoveParameter = False
        ucrInputTextNaValuefiv.AddQuotesIfUnrecognised = False

        ucrChkNaValuefiv.SetText("Replace Missing Values")
        ucrChkNaValuefiv.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValuefiv.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValuefiv.AddToLinkedControls(ucrInputTextNaValuefiv, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorfiv.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorfiv.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorfiv.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorfiv.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorfiv.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorfiv.AddToLinkedControls(ucrInputDropUnusedLevelsColorfiv, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorfiv.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorfiv.SetText("Position")
        ucrChkPositionColorfiv.AddToLinkedControls(ucrInputPositionColorfiv, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorfiv.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorfiv.SetParameter(New RParameter("position"))
        ucrInputPositionColorfiv.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorfiv.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorfiv.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorfiv.SetText("Expand")
        ucrChkExpandColorfiv.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorfiv.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorfiv.AddToLinkedControls(ucrInputTextExpandColorfiv, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorfiv.SetValidationTypeAsNumericList()

        ucrChkBreaksColorfiv.SetText("Breaks")
        ucrChkBreaksColorfiv.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorfiv.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorfiv.AddToLinkedControls(ucrInputTextBreaksColorfiv, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorfiv.SetValidationTypeAsList()

        ucrChkLimitColorfiv.SetText("Limits")
        ucrChkLimitColorfiv.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorfiv.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorfiv.AddToLinkedControls(ucrInputTextLimitColorfiv, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorfiv.SetValidationTypeAsList()

        ucrInputTextNaValueColorfiv.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorfiv.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorfiv.bAddRemoveParameter = False
        ucrInputTextNaValueColorfiv.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorfiv.SetText("Replace Missing Values")
        ucrChkNaValueColorfiv.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorfiv.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorfiv.AddToLinkedControls(ucrInputTextNaValueColorfiv, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsg.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsg.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsg.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsg.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsg.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsg.AddToLinkedControls(ucrInputDropUnusedLevelsg, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsg.SetItems({"TRUE", "FALSE"})

        ucrChkPositiong.SetText("Position")
        ucrChkPositiong.AddToLinkedControls(ucrInputPositiong, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositiong.SetDropDownStyleAsNonEditable()
        ucrInputPositiong.SetParameter(New RParameter("position"))
        ucrInputPositiong.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositiong.AddParameterPresentCondition(True, "position")
        ucrChkPositiong.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandg.SetText("Expand")
        ucrChkExpandg.AddParameterPresentCondition(True, "expand")
        ucrChkExpandg.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandg.AddToLinkedControls(ucrInputTextExpandg, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandg.SetValidationTypeAsNumericList()

        ucrChkBreaksg.SetText("Breaks")
        ucrChkBreaksg.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksg.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksg.AddToLinkedControls(ucrInputTextBreaksg, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksg.SetValidationTypeAsList()

        ucrChkLimitg.SetText("Limits")
        ucrChkLimitg.AddParameterPresentCondition(True, "limit")
        ucrChkLimitg.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitg.AddToLinkedControls(ucrInputTextLimitg, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitg.SetValidationTypeAsList()

        ucrInputTextNaValueg.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueg.SetValidationTypeAsNumeric()
        ucrInputTextNaValueg.bAddRemoveParameter = False
        ucrInputTextNaValueg.AddQuotesIfUnrecognised = False

        ucrChkNaValueg.SetText("Replace Missing Values")
        ucrChkNaValueg.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueg.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueg.AddToLinkedControls(ucrInputTextNaValueg, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorg.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorg.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorg.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorg.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorg.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorg.AddToLinkedControls(ucrInputDropUnusedLevelsColorg, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorg.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorg.SetText("Position")
        ucrChkPositionColorg.AddToLinkedControls(ucrInputPositionColorg, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorg.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorg.SetParameter(New RParameter("position"))
        ucrInputPositionColorg.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorg.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorg.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorg.SetText("Expand")
        ucrChkExpandColorg.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorg.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorg.AddToLinkedControls(ucrInputTextExpandColorg, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorg.SetValidationTypeAsNumericList()

        ucrChkBreaksColorg.SetText("Breaks")
        ucrChkBreaksColorg.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorg.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorg.AddToLinkedControls(ucrInputTextBreaksColorg, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorg.SetValidationTypeAsList()

        ucrChkLimitColorg.SetText("Limits")
        ucrChkLimitColorg.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorg.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorg.AddToLinkedControls(ucrInputTextLimitColorg, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorg.SetValidationTypeAsList()

        ucrInputTextNaValueColorg.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorg.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorg.bAddRemoveParameter = False
        ucrInputTextNaValueColorg.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorg.SetText("Replace Missing Values")
        ucrChkNaValueColorg.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorg.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorg.AddToLinkedControls(ucrInputTextNaValueColorg, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelshc.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelshc.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelshc.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelshc.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelshc.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelshc.AddToLinkedControls(ucrInputDropUnusedLevelshc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelshc.SetItems({"TRUE", "FALSE"})

        ucrChkPositionhc.SetText("Position")
        ucrChkPositionhc.AddToLinkedControls(ucrInputPositionhc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionhc.SetDropDownStyleAsNonEditable()
        ucrInputPositionhc.SetParameter(New RParameter("position"))
        ucrInputPositionhc.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionhc.AddParameterPresentCondition(True, "position")
        ucrChkPositionhc.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandhc.SetText("Expand")
        ucrChkExpandhc.AddParameterPresentCondition(True, "expand")
        ucrChkExpandhc.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandhc.AddToLinkedControls(ucrInputTextExpandhc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandhc.SetValidationTypeAsNumericList()

        ucrChkBreakshc.SetText("Breaks")
        ucrChkBreakshc.AddParameterPresentCondition(True, "breaks")
        ucrChkBreakshc.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreakshc.AddToLinkedControls(ucrInputTextBreakshc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreakshc.SetValidationTypeAsList()

        ucrChkLimithc.SetText("Limits")
        ucrChkLimithc.AddParameterPresentCondition(True, "limit")
        ucrChkLimithc.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimithc.AddToLinkedControls(ucrInputTextLimithc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimithc.SetValidationTypeAsList()

        ucrInputTextNaValuehc.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValuehc.SetValidationTypeAsNumeric()
        ucrInputTextNaValuehc.bAddRemoveParameter = False
        ucrInputTextNaValuehc.AddQuotesIfUnrecognised = False

        ucrChkNaValuehc.SetText("Replace Missing Values")
        ucrChkNaValuehc.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValuehc.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValuehc.AddToLinkedControls(ucrInputTextNaValuehc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorhc.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorhc.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorhc.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorhc.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorhc.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorhc.AddToLinkedControls(ucrInputDropUnusedLevelsColorhc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorhc.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorhc.SetText("Position")
        ucrChkPositionColorhc.AddToLinkedControls(ucrInputPositionColorhc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorhc.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorhc.SetParameter(New RParameter("position"))
        ucrInputPositionColorhc.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorhc.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorhc.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorhc.SetText("Expand")
        ucrChkExpandColorhc.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorhc.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorhc.AddToLinkedControls(ucrInputTextExpandColorhc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorhc.SetValidationTypeAsNumericList()

        ucrChkBreaksColorhc.SetText("Breaks")
        ucrChkBreaksColorhc.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorhc.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorhc.AddToLinkedControls(ucrInputTextBreaksColorhc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorhc.SetValidationTypeAsList()

        ucrChkLimitColorhc.SetText("Limits")
        ucrChkLimitColorhc.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorhc.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorhc.AddToLinkedControls(ucrInputTextLimitColorhc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorhc.SetValidationTypeAsList()

        ucrInputTextNaValueColorhc.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorhc.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorhc.bAddRemoveParameter = False
        ucrInputTextNaValueColorhc.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorhc.SetText("Replace Missing Values")
        ucrChkNaValueColorhc.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorhc.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorhc.AddToLinkedControls(ucrInputTextNaValueColorhc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkPalettehc.SetText("Palette")
        ucrChkPalettehc.AddToLinkedControls(ucrInputPalettehc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="default")
        ucrInputPalettehc.SetDropDownStyleAsNonEditable()
        ucrInputPalettehc.SetParameter(New RParameter("palette"))
        ucrInputPalettehc.SetItems({"default", "darkunica"})
        ucrChkPalettehc.AddParameterPresentCondition(True, "palette")
        ucrChkPalettehc.AddParameterPresentCondition(False, "palette", False)

        ucrChkPalettecolorhc.SetText("Palette")
        ucrChkPalettecolorhc.AddToLinkedControls(ucrInputPalettecolorhc, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="default")
        ucrInputPalettecolorhc.SetDropDownStyleAsNonEditable()
        ucrInputPalettecolorhc.SetParameter(New RParameter("palette"))
        ucrInputPalettecolorhc.SetItems({"default", "darkunica"})
        ucrChkPalettecolorhc.AddParameterPresentCondition(True, "palette")
        ucrChkPalettecolorhc.AddParameterPresentCondition(False, "palette", False)

        ucrChkPalettecolor.SetText("Palette")
        ucrChkPalettecolor.AddToLinkedControls(ucrInputPalettecolor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Light")
        ucrInputPalettecolor.SetDropDownStyleAsNonEditable()
        ucrInputPalettecolor.SetParameter(New RParameter("palette"))
        ucrInputPalettecolor.SetItems({"Light", "Medium", "Dark"})
        ucrChkPalettecolor.AddParameterPresentCondition(True, "palette")
        ucrChkPalettecolor.AddParameterPresentCondition(False, "palette", False)

        ucrChkPalettefill.SetText("Palette")
        ucrChkPalettefill.AddToLinkedControls(ucrInputPalettefill, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Light")
        ucrInputPalettefill.SetDropDownStyleAsNonEditable()
        ucrInputPalettefill.SetParameter(New RParameter("palette"))
        ucrInputPalettefill.SetItems({"Light", "Medium", "Dark"})
        ucrChkPalettefill.AddParameterPresentCondition(True, "palette")
        ucrChkPalettefill.AddParameterPresentCondition(False, "palette", False)

        ucrChkDropUnusedLevelspan.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelspan.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelspan.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelspan.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelspan.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelspan.AddToLinkedControls(ucrInputDropUnusedLevelspan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelspan.SetItems({"TRUE", "FALSE"})

        ucrChkPositionpan.SetText("Position")
        ucrChkPositionpan.AddToLinkedControls(ucrInputPositionpan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionpan.SetDropDownStyleAsNonEditable()
        ucrInputPositionpan.SetParameter(New RParameter("position"))
        ucrInputPositionpan.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionpan.AddParameterPresentCondition(True, "position")
        ucrChkPositionpan.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandpan.SetText("Expand")
        ucrChkExpandpan.AddParameterPresentCondition(True, "expand")
        ucrChkExpandpan.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandpan.AddToLinkedControls(ucrInputTextExpandpan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandpan.SetValidationTypeAsNumericList()

        ucrChkBreakspan.SetText("Breaks")
        ucrChkBreakspan.AddParameterPresentCondition(True, "breaks")
        ucrChkBreakspan.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreakspan.AddToLinkedControls(ucrInputTextBreakspan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreakspan.SetValidationTypeAsList()

        ucrChkLimitpan.SetText("Limits")
        ucrChkLimitpan.AddParameterPresentCondition(True, "limit")
        ucrChkLimitpan.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitpan.AddToLinkedControls(ucrInputTextLimitpan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitpan.SetValidationTypeAsList()

        ucrInputTextNaValuepan.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValuepan.SetValidationTypeAsNumeric()
        ucrInputTextNaValuepan.bAddRemoveParameter = False
        ucrInputTextNaValuepan.AddQuotesIfUnrecognised = False

        ucrChkNaValuepan.SetText("Replace Missing Values")
        ucrChkNaValuepan.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValuepan.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValuepan.AddToLinkedControls(ucrInputTextNaValuepan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorpan.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorpan.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorpan.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorpan.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorpan.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorpan.AddToLinkedControls(ucrInputDropUnusedLevelsColorpan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorpan.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorpan.SetText("Position")
        ucrChkPositionColorpan.AddToLinkedControls(ucrInputPositionColorpan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorpan.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorpan.SetParameter(New RParameter("position"))
        ucrInputPositionColorpan.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorpan.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorpan.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorpan.SetText("Expand")
        ucrChkExpandColorpan.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorpan.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorpan.AddToLinkedControls(ucrInputTextExpandColorpan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorpan.SetValidationTypeAsNumericList()

        ucrChkBreaksColorpan.SetText("Breaks")
        ucrChkBreaksColorpan.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorpan.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorpan.AddToLinkedControls(ucrInputTextBreaksColorpan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorpan.SetValidationTypeAsList()

        ucrChkLimitColorpan.SetText("Limits")
        ucrChkLimitColorpan.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorpan.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorpan.AddToLinkedControls(ucrInputTextLimitColorpan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorpan.SetValidationTypeAsList()

        ucrInputTextNaValueColorpan.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorpan.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorpan.bAddRemoveParameter = False
        ucrInputTextNaValueColorpan.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorpan.SetText("Replace Missing Values")
        ucrChkNaValueColorpan.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorpan.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorpan.AddToLinkedControls(ucrInputTextNaValueColorpan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelspt.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelspt.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelspt.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelspt.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelspt.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelspt.AddToLinkedControls(ucrInputDropUnusedLevelspt, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelspt.SetItems({"TRUE", "FALSE"})

        ucrChkPositionpt.SetText("Position")
        ucrChkPositionpt.AddToLinkedControls(ucrInputPositionpt, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionpt.SetDropDownStyleAsNonEditable()
        ucrInputPositionpt.SetParameter(New RParameter("position"))
        ucrInputPositionpt.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionpt.AddParameterPresentCondition(True, "position")
        ucrChkPositionpt.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandpt.SetText("Expand")
        ucrChkExpandpt.AddParameterPresentCondition(True, "expand")
        ucrChkExpandpt.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandpt.AddToLinkedControls(ucrInputTextExpandpt, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandpt.SetValidationTypeAsNumericList()

        ucrChkBreakspt.SetText("Breaks")
        ucrChkBreakspt.AddParameterPresentCondition(True, "breaks")
        ucrChkBreakspt.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreakspt.AddToLinkedControls(ucrInputTextBreakspt, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreakspt.SetValidationTypeAsList()

        ucrChkLimitpt.SetText("Limits")
        ucrChkLimitpt.AddParameterPresentCondition(True, "limit")
        ucrChkLimitpt.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitpt.AddToLinkedControls(ucrInputTextLimitpt, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitpt.SetValidationTypeAsList()

        ucrInputTextNaValuept.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValuept.SetValidationTypeAsNumeric()
        ucrInputTextNaValuept.bAddRemoveParameter = False
        ucrInputTextNaValuept.AddQuotesIfUnrecognised = False

        ucrChkNaValuept.SetText("Replace Missing Values")
        ucrChkNaValuept.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValuept.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValuept.AddToLinkedControls(ucrInputTextNaValuept, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorpt.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorpt.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorpt.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorpt.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorpt.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorpt.AddToLinkedControls(ucrInputDropUnusedLevelsColorpt, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorpt.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorpt.SetText("Position")
        ucrChkPositionColorpt.AddToLinkedControls(ucrInputPositionColorpt, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorpt.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorpt.SetParameter(New RParameter("position"))
        ucrInputPositionColorpt.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorpt.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorpt.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorpt.SetText("Expand")
        ucrChkExpandColorpt.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorpt.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorpt.AddToLinkedControls(ucrInputTextExpandColorpt, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorpt.SetValidationTypeAsNumericList()

        ucrChkBreaksColorpt.SetText("Breaks")
        ucrChkBreaksColorpt.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorpt.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorpt.AddToLinkedControls(ucrInputTextBreaksColorpt, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorpt.SetValidationTypeAsList()

        ucrChkLimitColorpt.SetText("Limits")
        ucrChkLimitColorpt.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorpt.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorpt.AddToLinkedControls(ucrInputTextLimitColorpt, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorpt.SetValidationTypeAsList()

        ucrInputTextNaValueColorpt.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorpt.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorpt.bAddRemoveParameter = False
        ucrInputTextNaValueColorpt.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorpt.SetText("Replace Missing Values")
        ucrChkNaValueColorpt.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorpt.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorpt.AddToLinkedControls(ucrInputTextNaValueColorpt, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelssol.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelssol.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelssol.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelssol.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelssol.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelssol.AddToLinkedControls(ucrInputDropUnusedLevelssol, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelssol.SetItems({"TRUE", "FALSE"})

        ucrChkPositionsol.SetText("Position")
        ucrChkPositionsol.AddToLinkedControls(ucrInputPositionsol, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionsol.SetDropDownStyleAsNonEditable()
        ucrInputPositionsol.SetParameter(New RParameter("position"))
        ucrInputPositionsol.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionsol.AddParameterPresentCondition(True, "position")
        ucrChkPositionsol.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandsol.SetText("Expand")
        ucrChkExpandsol.AddParameterPresentCondition(True, "expand")
        ucrChkExpandsol.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandsol.AddToLinkedControls(ucrInputTextExpandsol, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandsol.SetValidationTypeAsNumericList()

        ucrChkBreakssol.SetText("Breaks")
        ucrChkBreakssol.AddParameterPresentCondition(True, "breaks")
        ucrChkBreakssol.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreakssol.AddToLinkedControls(ucrInputTextBreakssol, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreakssol.SetValidationTypeAsList()

        ucrChkLimitsol.SetText("Limits")
        ucrChkLimitsol.AddParameterPresentCondition(True, "limit")
        ucrChkLimitsol.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitsol.AddToLinkedControls(ucrInputTextLimitsol, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitsol.SetValidationTypeAsList()

        ucrInputTextNaValuesol.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValuesol.SetValidationTypeAsNumeric()
        ucrInputTextNaValuesol.bAddRemoveParameter = False
        ucrInputTextNaValuesol.AddQuotesIfUnrecognised = False

        ucrChkNaValuesol.SetText("Replace Missing Values")
        ucrChkNaValuesol.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValuesol.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValuesol.AddToLinkedControls(ucrInputTextNaValuesol, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorsol.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorsol.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorsol.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorsol.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorsol.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorsol.AddToLinkedControls(ucrInputDropUnusedLevelsColorsol, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorsol.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorsol.SetText("Position")
        ucrChkPositionColorsol.AddToLinkedControls(ucrInputPositionColorsol, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorsol.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorsol.SetParameter(New RParameter("position"))
        ucrInputPositionColorsol.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorsol.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorsol.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorsol.SetText("Expand")
        ucrChkExpandColorsol.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorsol.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorsol.AddToLinkedControls(ucrInputTextExpandColorsol, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorsol.SetValidationTypeAsNumericList()

        ucrChkBreaksColorsol.SetText("Breaks")
        ucrChkBreaksColorsol.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorsol.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorsol.AddToLinkedControls(ucrInputTextBreaksColorsol, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorsol.SetValidationTypeAsList()

        ucrChkLimitColorsol.SetText("Limits")
        ucrChkLimitColorsol.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorsol.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorsol.AddToLinkedControls(ucrInputTextLimitColorsol, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorsol.SetValidationTypeAsList()

        ucrInputTextNaValueColorsol.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorsol.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorsol.bAddRemoveParameter = False
        ucrInputTextNaValueColorsol.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorsol.SetText("Replace Missing Values")
        ucrChkNaValueColorsol.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorsol.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorsol.AddToLinkedControls(ucrInputTextNaValueColorsol, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsst.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsst.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsst.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsst.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsst.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsst.AddToLinkedControls(ucrInputDropUnusedLevelsst, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsst.SetItems({"TRUE", "FALSE"})

        ucrChkPositionst.SetText("Position")
        ucrChkPositionst.AddToLinkedControls(ucrInputPositionst, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionst.SetDropDownStyleAsNonEditable()
        ucrInputPositionst.SetParameter(New RParameter("position"))
        ucrInputPositionst.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionst.AddParameterPresentCondition(True, "position")
        ucrChkPositionst.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandst.SetText("Expand")
        ucrChkExpandst.AddParameterPresentCondition(True, "expand")
        ucrChkExpandst.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandst.AddToLinkedControls(ucrInputTextExpandst, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandst.SetValidationTypeAsNumericList()

        ucrChkBreaksst.SetText("Breaks")
        ucrChkBreaksst.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksst.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksst.AddToLinkedControls(ucrInputTextBreaksst, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksst.SetValidationTypeAsList()

        ucrChkLimitst.SetText("Limits")
        ucrChkLimitst.AddParameterPresentCondition(True, "limit")
        ucrChkLimitst.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitst.AddToLinkedControls(ucrInputTextLimitst, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitst.SetValidationTypeAsList()

        ucrInputTextNaValuest.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValuest.SetValidationTypeAsNumeric()
        ucrInputTextNaValuest.bAddRemoveParameter = False
        ucrInputTextNaValuest.AddQuotesIfUnrecognised = False

        ucrChkNaValuest.SetText("Replace Missing Values")
        ucrChkNaValuest.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValuest.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValuest.AddToLinkedControls(ucrInputTextNaValuest, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorst.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorst.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorst.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorst.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorst.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorst.AddToLinkedControls(ucrInputDropUnusedLevelsColorst, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorst.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorst.SetText("Position")
        ucrChkPositionColorst.AddToLinkedControls(ucrInputPositionColorst, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorst.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorst.SetParameter(New RParameter("position"))
        ucrInputPositionColorst.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorst.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorst.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorst.SetText("Expand")
        ucrChkExpandColorst.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorst.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorst.AddToLinkedControls(ucrInputTextExpandColorst, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorst.SetValidationTypeAsNumericList()

        ucrChkBreaksColorst.SetText("Breaks")
        ucrChkBreaksColorst.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorst.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorst.AddToLinkedControls(ucrInputTextBreaksColorst, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorst.SetValidationTypeAsList()

        ucrChkLimitColorst.SetText("Limits")
        ucrChkLimitColorst.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorst.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorst.AddToLinkedControls(ucrInputTextLimitColorst, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorst.SetValidationTypeAsList()

        ucrInputTextNaValueColorst.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorst.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorst.bAddRemoveParameter = False
        ucrInputTextNaValueColorst.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorst.SetText("Replace Missing Values")
        ucrChkNaValueColorst.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorst.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorst.AddToLinkedControls(ucrInputTextNaValueColorst, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkSchemecolor.SetText("Scheme:")
        ucrChkSchemecolor.AddToLinkedControls(ucrInputSchemecolor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="s2color")
        ucrInputSchemecolor.SetDropDownStyleAsNonEditable()
        ucrInputSchemecolor.SetParameter(New RParameter("scheme"))
        ucrInputSchemecolor.SetItems({"s2color", "s1rcolor", "s1color", "mono"})
        ucrChkSchemecolor.AddParameterPresentCondition(True, "scheme")
        ucrChkSchemecolor.AddParameterPresentCondition(False, "scheme", False)

        ucrChkSchemefill.SetText("Scheme:")
        ucrChkSchemefill.AddToLinkedControls(ucrInputSchemefill, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="s2color")
        ucrInputSchemefill.SetDropDownStyleAsNonEditable()
        ucrInputSchemefill.SetParameter(New RParameter("scheme"))
        ucrInputSchemefill.SetItems({"s2color", "s1rcolor", "s1color", "mono"})
        ucrChkSchemefill.AddParameterPresentCondition(True, "scheme")
        ucrChkSchemefill.AddParameterPresentCondition(False, "scheme", False)

        ucrChkDropUnusedLevelsw.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsw.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsw.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsw.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsw.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsw.AddToLinkedControls(ucrInputDropUnusedLevelsw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsw.SetItems({"TRUE", "FALSE"})

        ucrChkPositionw.SetText("Position")
        ucrChkPositionw.AddToLinkedControls(ucrInputPositionw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionw.SetDropDownStyleAsNonEditable()
        ucrInputPositionw.SetParameter(New RParameter("position"))
        ucrInputPositionw.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionw.AddParameterPresentCondition(True, "position")
        ucrChkPositionw.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandw.SetText("Expand")
        ucrChkExpandw.AddParameterPresentCondition(True, "expand")
        ucrChkExpandw.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandw.AddToLinkedControls(ucrInputTextExpandw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandw.SetValidationTypeAsNumericList()

        ucrChkBreaksw.SetText("Breaks")
        ucrChkBreaksw.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksw.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksw.AddToLinkedControls(ucrInputTextBreaksw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksw.SetValidationTypeAsList()

        ucrChkLimitw.SetText("Limits")
        ucrChkLimitw.AddParameterPresentCondition(True, "limit")
        ucrChkLimitw.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitw.AddToLinkedControls(ucrInputTextLimitw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitw.SetValidationTypeAsList()

        ucrInputTextNaValuew.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValuew.SetValidationTypeAsNumeric()
        ucrInputTextNaValuew.bAddRemoveParameter = False
        ucrInputTextNaValuew.AddQuotesIfUnrecognised = False

        ucrChkNaValuew.SetText("Replace Missing Values")
        ucrChkNaValuew.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValuew.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValuew.AddToLinkedControls(ucrInputTextNaValuew, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkDropUnusedLevelsColorw.SetText("Drop Unused Levels")
        ucrInputDropUnusedLevelsColorw.SetParameter(New RParameter("drop"))
        ucrInputDropUnusedLevelsColorw.SetDropDownStyleAsNonEditable()
        ucrChkDropUnusedLevelsColorw.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevelsColorw.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevelsColorw.AddToLinkedControls(ucrInputDropUnusedLevelsColorw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevelsColorw.SetItems({"TRUE", "FALSE"})

        ucrChkPositionColorw.SetText("Position")
        ucrChkPositionColorw.AddToLinkedControls(ucrInputPositionColorw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Left")
        ucrInputPositionColorw.SetDropDownStyleAsNonEditable()
        ucrInputPositionColorw.SetParameter(New RParameter("position"))
        ucrInputPositionColorw.SetItems({"left", "right", "bottom", "top"})
        ucrChkPositionColorw.AddParameterPresentCondition(True, "position")
        ucrChkPositionColorw.AddParameterPresentCondition(False, "position", False)

        ucrChkExpandColorw.SetText("Expand")
        ucrChkExpandColorw.AddParameterPresentCondition(True, "expand")
        ucrChkExpandColorw.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandColorw.AddToLinkedControls(ucrInputTextExpandColorw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputTextExpandColorw.SetValidationTypeAsNumericList()

        ucrChkBreaksColorw.SetText("Breaks")
        ucrChkBreaksColorw.AddParameterPresentCondition(True, "breaks")
        ucrChkBreaksColorw.AddParameterPresentCondition(False, "breaks", False)
        ucrChkBreaksColorw.AddToLinkedControls(ucrInputTextBreaksColorw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextBreaksColorw.SetValidationTypeAsList()

        ucrChkLimitColorw.SetText("Limits")
        ucrChkLimitColorw.AddParameterPresentCondition(True, "limit")
        ucrChkLimitColorw.AddParameterPresentCondition(False, "limit", False)
        ucrChkLimitColorw.AddToLinkedControls(ucrInputTextLimitColorw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputTextLimitColorw.SetValidationTypeAsList()

        ucrInputTextNaValueColorw.SetParameter(New RParameter("na.value"))
        ucrInputTextNaValueColorw.SetValidationTypeAsNumeric()
        ucrInputTextNaValueColorw.bAddRemoveParameter = False
        ucrInputTextNaValueColorw.AddQuotesIfUnrecognised = False

        ucrChkNaValueColorw.SetText("Replace Missing Values")
        ucrChkNaValueColorw.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueColorw.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueColorw.AddToLinkedControls(ucrInputTextNaValueColorw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkPalettecolorw.SetText("Palette")
        ucrChkPalettecolorw.AddToLinkedControls(ucrInputPalettecolorw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="rgby")
        ucrInputPalettecolorw.SetDropDownStyleAsNonEditable()
        ucrInputPalettecolorw.SetParameter(New RParameter("palette"))
        ucrInputPalettecolorw.SetItems({"rgby", "red_green", "black_green", "dem_rep", "colors6"})
        ucrChkPalettecolorw.AddParameterPresentCondition(True, "palette")
        ucrChkPalettecolorw.AddParameterPresentCondition(False, "palette", False)

        ucrChkpalettefillw.SetText("Palette")
        ucrChkpalettefillw.AddToLinkedControls(ucrInputPalettefillw, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="rgby")
        ucrInputPalettefillw.SetDropDownStyleAsNonEditable()
        ucrInputPalettefillw.SetParameter(New RParameter("palette"))
        ucrInputPalettefillw.SetItems({"rgby", "red_green", "black_green", "dem_rep", "colors6"})
        ucrChkpalettefillw.AddParameterPresentCondition(True, "palette")
        ucrChkpalettefillw.AddParameterPresentCondition(False, "palette", False)

        ucrInputContinousfill.SetDropDownStyleAsNonEditable()
        ucrInputContinousfill.SetParameter(New RParameter("palette"))
        ucrInputContinousfill.SetItems({"Blue-Green Sequential", "Blue Light", "Orange Light", "Blue", "Orange", "Green", "Red", "Purple", "Brown", "Gray", "Gray Warm", "Blue-Teal", "Orange-Gold", "Green-Gold", "Red-Gold", "Classic Green", "Classic Gray", "Classic Blue", "Classic Red", "Classic Orange", "Classic Area Red",
                                       "Classic Area Green", "Classic Area-Brown", "ordered-diverging", "Orange-Blue Diverging", "Red-Green Diverging", "Green-Blue Diverging", "Red-Blue Diverging", "Red-Black Diverging", "Gold-Purple Diverging", "Red-Green-Gold Diverging", "Sunset-Sunrise Diverging", "Orange-Blue-White Diverging",
                                       "Red-Green-White Diverging", "Green-Blue-White Diverging", "Red-Blue-White Diverging", "Red-Black-White Diverging", "Orange-Blue Light Diverging", "Temperature Diverging", "Classic Red-Green", "Classic Red-Blue", "Classic Red-Black", "Classic Area Red-Green", "Classic Orange-Blue", "Classic Green-Blue",
                                       "Classic Red-White-Green", "Classic Red-White-Black", "Classic Orange-White-Blue", "Classic Red-White-Black Light", "Classic Orange-White-Blue Light", "Classic Red-White-Green Light", "Classic Red-Green Light"})
        ucrInputContinousfill.SetLinkedDisplayControl(lblPaletteContinuousfill)

        ucrInputcontinuouscolor.SetDropDownStyleAsNonEditable()
        ucrInputcontinuouscolor.SetParameter(New RParameter("palette"))
        ucrInputcontinuouscolor.SetItems({"Blue-Green Sequential", "Blue Light", "Orange Light", "Blue", "Orange", "Green", "Red", "Purple", "Brown", "Gray", "Gray Warm", "Blue-Teal", "Orange-Gold", "Green-Gold", "Red-Gold", "Classic Green", "Classic Gray", "Classic Blue", "Classic Red", "Classic Orange", "Classic Area Red",
                                         "Classic Area Green", "Classic Area-Brown", "ordered-diverging", "Orange-Blue Diverging", "Red-Green Diverging", "Green-Blue Diverging", "Red-Blue Diverging", "Red-Black Diverging", "Gold-Purple Diverging", "Red-Green-Gold Diverging", "Sunset-Sunrise Diverging", "Orange-Blue-White Diverging",
                                         "Red-Green-White Diverging", "Green-Blue-White Diverging", "Red-Blue-White Diverging", "Red-Black-White Diverging", "Orange-Blue Light Diverging", "Temperature Diverging", "Classic Red-Green", "Classic Red-Blue", "Classic Red-Black", "Classic Area Red-Green", "Classic Orange-Blue", "Classic Green-Blue",
                                         "Classic Red-White-Green", "Classic Red-White-Black", "Classic Orange-White-Blue", "Classic Red-White-Black Light", "Classic Orange-White-Blue Light", "Classic Red-White-Green Light", "Classic Red-Green Light"})
        ucrInputcontinuouscolor.SetLinkedDisplayControl(lblPalcontinuouscolor)

        ucrPnlColourPalette.AddParameterValuesCondition(rdoSequential, "palette", "sequential")
        ucrPnlColourPalette.AddParameterValuesCondition(rdoDiverging, "palette", "diverging")
        ucrPnlColourPalette.AddParameterValuesCondition(rdoQualitative, "palette", "qualitative")
        ucrPnlColourPalette.AddParameterValuesCondition(rdoViridis, "option", "viridis")
        ucrPnlColourPalette.AddParameterValuesCondition(rdoGgthemes, "palette", "ggthemes")
        ucrPnlScale.AddParameterValuesCondition(rdoColour, "Check", "color")
        ucrPnlScale.AddParameterValuesCondition(rdoFill, "Check", "fill")
        ucrPnlColourPalette.AddToLinkedControls(ucrInputColorFunctions, {rdoGgthemes}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrPnlColourPalette.AddToLinkedControls(ucrInputFillFunction, {rdoGgthemes}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrPnlColourPalette.AddToLinkedControls({ucrInputcontinuouscolor, ucrInputContinousfill}, {rdoGgthemes}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Blue-Green Sequential")

        ucrInputColorFunctions.SetDropDownStyleAsNonEditable()
        ucrInputColorFunctions.SetItems({"scale_color_calc", "scale_color_canva", "scale_color_colorblind", "scale_color_economist", "scale_color_excel", "scale_color_excel_new", "scale_color_few", "scale_color_fivethirtyeight", "scale_color_gdocs", "scale_color_hc", "scale_color_pander", "scale_color_ptol", "scale_color_solarized", "scale_color_stata", "scale_color_wsj"})
        ucrInputColorFunctions.SetLinkedDisplayControl(lblGgthemesFunctions)
        ucrInputColorFunctions.AddToLinkedControls(ucrInputCanvasColorPalette, {"scale_color_canva"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Antique and clean")

        ucrInputFillFunction.SetDropDownStyleAsNonEditable()
        ucrInputFillFunction.SetItems({"scale_fill_calc", "scale_fill_canva", "scale_fill_colorblind", "scale_fill_economist", "scale_fill_excel", "scale_fill_excel_new", "scale_fill_few", "scale_fill_fivethirtyeight", "scale_fill_gdocs", "scale_fill_hc", "scale_fill_pander", "scale_fill_ptol", "scale_fill_solarized", "scale_fill_stata", "scale_fill_wsj"})
        ucrInputFillFunction.SetLinkedDisplayControl(lblFillFunction)
        ucrInputFillFunction.AddToLinkedControls(ucrInputCanvasFillPalette, {"scale_fill_canva"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Antique and clean")

        ucrInputCanvasColorPalette.SetParameter(New RParameter("palette"))
        ucrInputCanvasColorPalette.SetDropDownStyleAsNonEditable()
        ucrInputCanvasColorPalette.SetItems({"Antique and clean", "Antique tones", "Berry blues", "Beyond black and white", "Bold berries", "Candy coated brights", "Cheerful brights", "City sights", "Coastal", "Day and night", "Fresh greens", "Golden afternoon", "Hazy grays", "Jewel tones", "Misty greens", "Modern and muted", "Muted tones", "Neon night", "Orange accent", "Pastels", "Pop art", "Violet sunset"})
        ucrInputCanvasColorPalette.SetLinkedDisplayControl(lblCanvasColorPalette)

        ucrInputCanvasFillPalette.SetParameter(New RParameter("palette"))
        ucrInputCanvasFillPalette.SetDropDownStyleAsNonEditable()
        ucrInputCanvasFillPalette.SetItems({"Antique and clean", "Antique tones", "Berry blues", "Beyond black and white", "Bold berries", "Candy coated brights", "Cheerful brights", "City sights", "Coastal", "Day and night", "Fresh greens", "Golden afternoon", "Hazy grays", "Jewel tones", "Misty greens", "Modern and muted", "Muted tones", "Neon night", "Orange accent", "Pastels", "Pop art", "Violet sunset"})
        ucrInputCanvasFillPalette.SetLinkedDisplayControl(lblCanvasFillPalette)

        ucrInputFillScaleColour.SetParameter(New RParameter("option", iNewPosition:=0))
        dctFillOptions.Add("viridis", Chr(34) & "viridis" & Chr(34))
        dctFillOptions.Add("magma", Chr(34) & "magma" & Chr(34))
        dctFillOptions.Add("inferno", Chr(34) & "inferno" & Chr(34))
        dctFillOptions.Add("plasma", Chr(34) & "plasma" & Chr(34))
        dctFillOptions.Add("cividis", Chr(34) & "cividis" & Chr(34))
        dctFillOptions.Add("mako", Chr(34) & "mako" & Chr(34))
        dctFillOptions.Add("rocket", Chr(34) & "rocket" & Chr(34))
        dctFillOptions.Add("turbo", Chr(34) & "turbo" & Chr(34))
        ucrInputFillScaleColour.SetItems(dctFillOptions)
        ucrInputFillScaleColour.SetRDefault(Chr(34) & "viridis" & Chr(34))
        ucrInputFillScaleColour.SetLinkedDisplayControl(lblFillScaleColourPalettte)

        ucrNudFillScaleTransparency.SetParameter(New RParameter("alpha", iNewPosition:=1))
        ucrNudFillScaleTransparency.SetMinMax(0, 1)
        ucrNudFillScaleTransparency.DecimalPlaces = 2
        ucrNudFillScaleTransparency.Increment = 0.01
        ucrNudFillScaleTransparency.SetRDefault(1)
        ucrNudFillScaleTransparency.SetLinkedDisplayControl(lblFillScaleTransparency)

        ucrNudFillScaleMapBegins.SetParameter(New RParameter("begin", iNewPosition:=2))
        ucrNudFillScaleMapBegins.SetMinMax(0, 1)
        ucrNudFillScaleMapBegins.DecimalPlaces = 2
        ucrNudFillScaleMapBegins.Increment = 0.01
        ucrNudFillScaleMapBegins.SetRDefault(0)
        ucrNudFillScaleMapBegins.SetLinkedDisplayControl(lblFillScaleBeginColour)

        ucrNudFillScaleMapEnds.SetParameter(New RParameter("end", iNewPosition:=3))
        ucrNudFillScaleMapEnds.SetMinMax(0, 1)
        ucrNudFillScaleMapEnds.DecimalPlaces = 2
        ucrNudFillScaleMapEnds.Increment = 0.01
        ucrNudFillScaleMapEnds.SetRDefault(1)
        ucrNudFillScaleMapEnds.SetLinkedDisplayControl(lblFillScaleMapEnds)

        ucrChkFillScaleReverseColourOrder.SetParameter(New RParameter("direction", iNewPosition:=4))
        ucrChkFillScaleReverseColourOrder.SetText("Reverse Order Of Colours")
        ucrChkFillScaleReverseColourOrder.SetRDefault(1)
        ucrChkFillScaleReverseColourOrder.SetValuesCheckedAndUnchecked("-1", "1")

        ucrInputColourScalePalette.SetParameter(New RParameter("option", iNewPosition:=0))
        dctColourOptions.Add("viridis", Chr(34) & "viridis" & Chr(34))
        dctColourOptions.Add("magma", Chr(34) & "magma" & Chr(34))
        dctColourOptions.Add("inferno", Chr(34) & "inferno" & Chr(34))
        dctColourOptions.Add("plasma", Chr(34) & "plasma" & Chr(34))
        dctColourOptions.Add("cividis", Chr(34) & "cividis" & Chr(34))
        dctColourOptions.Add("mako", Chr(34) & "mako" & Chr(34))
        dctColourOptions.Add("rocket", Chr(34) & "rocket" & Chr(34))
        dctColourOptions.Add("turbo", Chr(34) & "turbo" & Chr(34))
        ucrInputColourScalePalette.SetRDefault(Chr(34) & "viridis" & Chr(34))
        ucrInputColourScalePalette.SetItems(dctColourOptions)
        ucrInputColourScalePalette.SetLinkedDisplayControl(lblColourScalePalette)

        ucrNudColourScaleTransparency.SetParameter(New RParameter("alpha", iNewPosition:=1))
        ucrNudColourScaleTransparency.SetMinMax(0, 1)
        ucrNudColourScaleTransparency.DecimalPlaces = 2
        ucrNudColourScaleTransparency.Increment = 0.01
        ucrNudColourScaleTransparency.SetRDefault(1)
        ucrNudColourScaleTransparency.SetLinkedDisplayControl(lblColourScaleTransparency)

        ucrNudColourScaleMapBegins.SetParameter(New RParameter("begin", iNewPosition:=2))
        ucrNudColourScaleMapBegins.SetMinMax(0, 1)
        ucrNudColourScaleMapBegins.DecimalPlaces = 2
        ucrNudColourScaleMapBegins.Increment = 0.01
        ucrNudColourScaleMapBegins.SetRDefault(0)
        ucrNudColourScaleMapBegins.SetLinkedDisplayControl(lblColourScaleMapBegins)

        ucrNudColourScaleMapEnds.SetParameter(New RParameter("end", iNewPosition:=3))
        ucrNudColourScaleMapEnds.SetMinMax(0, 1)
        ucrNudColourScaleMapEnds.DecimalPlaces = 2
        ucrNudColourScaleMapEnds.Increment = 0.01
        ucrNudColourScaleMapEnds.SetRDefault(1)
        ucrNudColourScaleMapEnds.SetLinkedDisplayControl(lblColourScaleMapEnds)

        ucrChkColourScaleReverseOrder.SetParameter(New RParameter("direction", iNewPosition:=4))
        ucrChkColourScaleReverseOrder.SetText("Reverse Order Of Colours")
        ucrChkColourScaleReverseOrder.SetRDefault(1)
        ucrChkColourScaleReverseOrder.SetValuesCheckedAndUnchecked("-1", "1")

        ucrChkFillDiscrete.SetText("Discrete")
        ucrChkFillDiscrete.SetParameter(New RParameter("discrete", iNewPosition:=5))
        ucrChkFillDiscrete.SetRDefault("FALSE")
        ucrChkFillDiscrete.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkColourDiscrete.SetText("Discrete")
        ucrChkColourDiscrete.SetParameter(New RParameter("discrete", iNewPosition:=5))
        ucrChkColourDiscrete.SetRDefault("FALSE")
        ucrChkColourDiscrete.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
    End Sub

    Public Sub SetRCode(clsNewOperator As ROperator, clsNewCoordPolarFunction As RFunction, clsNewCoordPolarStartOperator As ROperator, clsNewYScalecontinuousFunction As RFunction, clsNewXScalecontinuousFunction As RFunction, clsNewLabsFunction As RFunction,
                        clsNewXLabsTitleFunction As RFunction, clsNewYLabTitleFunction As RFunction, clsNewFacetFunction As RFunction, clsNewThemeFunction As RFunction, dctNewThemeFunctions As Dictionary(Of String, RFunction), ucrNewBaseSelector As ucrSelector,
                        bReset As Boolean, Optional clsNewGlobalAesFunction As RFunction = Nothing, Optional clsNewXScaleDateFunction As RFunction = Nothing, Optional clsNewYScaleDateFunction As RFunction = Nothing,
                        Optional clsNewScaleFillViridisFunction As RFunction = Nothing, Optional clsNewScaleColourViridisFunction As RFunction = Nothing, Optional strMainDialogGeomParameterNames() As String = Nothing, Optional clsNewAnnotateFunction As RFunction = Nothing,
                        Optional bNewEnableFill As Boolean = True, Optional bNewChangeScales As Boolean = False, Optional bNewEnableColour As Boolean = True, Optional bNewEnableDiscrete As Boolean = True, Optional strNewAxisType As String = "discrete")
        Dim clsTempParam As RParameter
        bRCodeSet = False

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        ucrBaseSelector = ucrNewBaseSelector
        If ucrBaseSelector IsNot Nothing AndAlso ucrBaseSelector.strCurrentDataFrame <> "" Then
            strDataFrame = ucrBaseSelector.strCurrentDataFrame
            ucrFacetSelector.SetDataframe(strDataFrame, False)
        End If
        clsAttachFunction = New RFunction
        clsAttachFunction.SetRCommand("attach")
        clsAttachFunction.AddParameter("what", strDataFrame)
        clsRsyntax.AddToAfterCodes(clsAttachFunction)

        ucrFacetSelector.SetLinkedSelector(ucrBaseSelector)
        clsYScaleDateFunction = clsNewYScaleDateFunction
        clsXScaleDateFunction = clsNewXScaleDateFunction
        clsBaseOperator = clsNewOperator
        clsGlobalAesFunction = clsNewGlobalAesFunction
        clsXLabFunction = clsNewXLabsTitleFunction
        clsYLabFunction = clsNewYLabTitleFunction
        clsXScalecontinuousFunction = clsNewXScalecontinuousFunction
        clsYScalecontinuousFunction = clsNewYScalecontinuousFunction
        clsFacetFunction = clsNewFacetFunction
        clsThemeFunction = clsNewThemeFunction
        clsCoordPolarFunc = clsNewCoordPolarFunction
        clsCoordPolarStartOperator = clsNewCoordPolarStartOperator
        clsScaleFillViridisFunction = clsNewScaleFillViridisFunction
        clsScaleColourViridisFunction = clsNewScaleColourViridisFunction
        clsAnnotateFunction = clsNewAnnotateFunction

        clsDummyFunction = New RFunction

        clsDummyFunction.AddParameter("palette", "sequential", iPosition:=0)
        clsDummyFunction.AddParameter("Check", "fill", iPosition:=1)


        strAxisType = strNewAxisType
        ucrInputAxisType.SetName(strAxisType)

        If Not IsNothing(clsCoordPolarStartOperator) Then
            clsCoordPolarFunc.AddParameter("start", clsROperatorParameter:=clsCoordPolarStartOperator, iPosition:=1)
        End If

        dctThemeFunctions = dctNewThemeFunctions
        dctThemeFunctions.TryGetValue("axis.text.x", clsXElementText)
        dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle)
        dctThemeFunctions.TryGetValue("axis.text.y", clsYElemetText)
        dctThemeFunctions.TryGetValue("tag", clsPlotElementTagFunction)
        dctThemeFunctions.TryGetValue("colour", clsPlotLegendTitleFunction)

        dctNewThemeFunctions.TryGetValue("axis.title.y", clsYElemetTitle)

        If clsFacetFunction.ContainsParameter("facets") Then
            clsTempParam = clsFacetFunction.GetParameter("facets")
            If clsTempParam.bIsOperator AndAlso clsTempParam.clsArgumentCodeStructure IsNot Nothing Then
                clsFacetVariablesOperator = clsTempParam.clsArgumentCodeStructure
            Else
                clsFacetVariablesOperator = New ROperator("~")
            End If
        Else
            clsFacetVariablesOperator = New ROperator("~")
        End If
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)
        If clsNewLabsFunction IsNot Nothing Then
            clsLabsFunction = clsNewLabsFunction
        Else
            clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        End If

        clsScaleFillColorblindFunction = New RFunction
        clsScaleFillColorblindFunction.SetPackageName("ggthemes")
        clsScaleFillColorblindFunction.SetRCommand("scale_fill_colorblind")

        clsScaleColorColorblindFunction = New RFunction
        clsScaleColorColorblindFunction.SetPackageName("ggthemes")
        clsScaleColorColorblindFunction.SetRCommand("scale_color_colorblind")

        clsColourPaletteFunction = New RFunction
        clsColourPaletteFunction.SetPackageName("ggplot2")
        clsColourPaletteFunction.SetRCommand("scale_colour_brewer")

        clsFillPaletteFunction = New RFunction
        clsFillPaletteFunction.SetPackageName("ggplot2")
        clsFillPaletteFunction.SetRCommand("scale_fill_brewer")

        clsScaleColorDistillerFunction = New RFunction
        clsScaleColorDistillerFunction.SetPackageName("ggplot2")
        clsScaleColorDistillerFunction.SetRCommand("scale_color_distiller")

        clsScaleFillDistillerFunction = New RFunction
        clsScaleFillDistillerFunction.SetPackageName("ggplot2")
        clsScaleFillDistillerFunction.SetRCommand("scale_fill_distiller")

        clsScalecolorcalcFunction = New RFunction
        clsScalecolorcalcFunction.SetPackageName("ggthemes")
        clsScalecolorcalcFunction.SetRCommand("scale_color_calc")

        clsScalefillcalcFunction = New RFunction
        clsScalefillcalcFunction.SetPackageName("ggthemes")
        clsScalefillcalcFunction.SetRCommand("scale_fill_calc")

        clsScalecoloreconomistFunction = New RFunction
        clsScalecoloreconomistFunction.SetPackageName("ggthemes")
        clsScalecoloreconomistFunction.SetRCommand("scale_color_economist")

        clsScalefilleconomistFunction = New RFunction
        clsScalefilleconomistFunction.SetPackageName("ggthemes")
        clsScalefilleconomistFunction.SetRCommand("scale_fill_economist")

        clsScalecolorexcelFunction = New RFunction
        clsScalecolorexcelFunction.SetPackageName("ggthemes")
        clsScalecolorexcelFunction.SetRCommand("scale_color_excel")

        clsScalefillexcelFunction = New RFunction
        clsScalefillexcelFunction.SetPackageName("ggthemes")
        clsScalefillexcelFunction.SetRCommand("scale_fill_excel")

        clsScalecolorfivethirtyeightFunction = New RFunction
        clsScalecolorfivethirtyeightFunction.SetPackageName("ggthemes")
        clsScalecolorfivethirtyeightFunction.SetRCommand("scale_color_fivethirtyeight")

        clsScalefillfivethirtyeightFunction = New RFunction
        clsScalefillfivethirtyeightFunction.SetPackageName("ggthemes")
        clsScalefillfivethirtyeightFunction.SetRCommand("scale_fill_fivethirtyeight")

        clsScalecolorgdocsFunction = New RFunction
        clsScalecolorgdocsFunction.SetPackageName("ggthemes")
        clsScalecolorgdocsFunction.SetRCommand("scale_color_gdocs")

        clsScalefillgdocsFunction = New RFunction
        clsScalefillgdocsFunction.SetPackageName("ggthemes")
        clsScalefillgdocsFunction.SetRCommand("scale_fill_gdocs")

        clsScalecolorpanderFunction = New RFunction
        clsScalecolorpanderFunction.SetPackageName("ggthemes")
        clsScalecolorpanderFunction.SetRCommand("scale_color_pander")

        clsScalefillpanderFunction = New RFunction
        clsScalefillpanderFunction.SetPackageName("ggthemes")
        clsScalefillpanderFunction.SetRCommand("scale_fill_pander")

        clsScalecolorptolFunction = New RFunction
        clsScalecolorptolFunction.SetPackageName("ggthemes")
        clsScalecolorptolFunction.SetRCommand("scale_color_ptol")

        clsScalefillptolFunction = New RFunction
        clsScalefillptolFunction.SetPackageName("ggthemes")
        clsScalefillptolFunction.SetRCommand("scale_fill_ptol")

        clsScalecolorsolarizedFunction = New RFunction
        clsScalecolorsolarizedFunction.SetPackageName("ggthemes")
        clsScalecolorsolarizedFunction.SetRCommand("scale_color_solarized")

        clsScalefillsolarizedFunction = New RFunction
        clsScalefillsolarizedFunction.SetPackageName("ggthemes")
        clsScalefillsolarizedFunction.SetRCommand("scale_fill_solarized")

        clsScalecolorfewFunction = New RFunction
        clsScalecolorfewFunction.SetPackageName("ggthemes")
        clsScalecolorfewFunction.SetRCommand("scale_color_few")

        clsScalefillfewFunction = New RFunction
        clsScalefillfewFunction.SetPackageName("ggthemes")
        clsScalefillfewFunction.SetRCommand("scale_fill_few")

        clsScalecolorhcFunction = New RFunction
        clsScalecolorhcFunction.SetPackageName("ggthemes")
        clsScalecolorhcFunction.SetRCommand("scale_color_hc")

        clsScalefillhcFunction = New RFunction
        clsScalefillhcFunction.SetPackageName("ggthemes")
        clsScalefillhcFunction.SetRCommand("scale_fill_hc")

        clsScalecolorstataFunction = New RFunction
        clsScalecolorstataFunction.SetPackageName("ggthemes")
        clsScalecolorstataFunction.SetRCommand("scale_color_stata")

        clsScalefillstataFunction = New RFunction
        clsScalefillstataFunction.SetPackageName("ggthemes")
        clsScalefillstataFunction.SetRCommand("scale_fill_stata")

        clsScalecolorwsjFunction = New RFunction
        clsScalecolorwsjFunction.SetPackageName("ggthemes")
        clsScalecolorwsjFunction.SetRCommand("scale_color_wsj")

        clsScalefillwsjFunction = New RFunction
        clsScalefillwsjFunction.SetPackageName("ggthemes")
        clsScalefillwsjFunction.SetRCommand("scale_fill_wsj")

        clsScalecolorgradienttableauFunction = New RFunction
        clsScalecolorgradienttableauFunction.SetPackageName("ggthemes")
        clsScalecolorgradienttableauFunction.SetRCommand("scale_color_gradient_tableau")

        clsScalefillgradienttableauFunction = New RFunction
        clsScalefillgradienttableauFunction.SetPackageName("ggthemes")
        clsScalefillgradienttableauFunction.SetRCommand("scale_fill_gradient_tableau")

        clsScalecolorcanvaFunction = New RFunction
        clsScalecolorcanvaFunction.SetPackageName("ggthemes")
        clsScalecolorcanvaFunction.SetRCommand("scale_color_canva")

        clsScalefillcanvaFunction = New RFunction
        clsScalefillcanvaFunction.SetPackageName("ggthemes")
        clsScalefillcanvaFunction.SetRCommand("scale_fill_canva")

        clsScalecolorexcelnewFunction = New RFunction
        clsScalecolorexcelnewFunction.SetPackageName("ggthemes")
        clsScalecolorexcelnewFunction.SetRCommand("scale_color_excel_new")

        clsScalefillexcelnewFunction = New RFunction
        clsScalefillexcelnewFunction.SetPackageName("ggthemes")
        clsScalefillexcelnewFunction.SetRCommand("scale_fill_excel_new")

        If Not clsBaseOperator.ContainsParameter("theme_name") Then
            clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        End If

        ucrInputGraphTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputGraphSubTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputGraphCaption.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTag.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrChkTag.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        If bReset Then
            ucrChkNewLegend.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkIncludeTitles.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        End If

        ucrInputThemes.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        urChkSelectTheme.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)

        ucrPnlHorizonatalVertical.SetRCode(clsFacetFunction, bReset, bCloneIfNeeded:=True)
        ucr1stFactorReceiver.SetRCode(clsFacetVariablesOperator, bReset, bCloneIfNeeded:=True)
        ucr2ndFactorReceiver.SetRCode(clsFacetVariablesOperator, bReset, bCloneIfNeeded:=True)

        ucrChkMargin.SetRCode(clsFacetFunction, bReset, bCloneIfNeeded:=True)
        ucrChkFreeSpace.SetRCode(clsFacetFunction, bReset, bCloneIfNeeded:=True)
        ucrChkFreeScalesX.SetRCode(clsFacetFunction, bReset, bCloneIfNeeded:=True)
        If bReset Then
            ucrChkFreeScalesY.SetRCode(clsFacetFunction, bReset, bCloneIfNeeded:=True)
        End If
        ucrNudNumberofRows.SetRCode(clsFacetFunction, bReset, bCloneIfNeeded:=True)
        ucrChkLabeler.SetRCode(clsFacetFunction, bReset, bCloneIfNeeded:=True)
        ucrChkDrop.SetRCode(clsFacetFunction, bReset, bCloneIfNeeded:=True)
        ucrChkIncludeFacets.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)

        'Annnotation
        ucrChkAnnotation.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        ucrChkParse.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)
        ucrNudAlpha.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)
        ucrNudSize.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)
        ucrInputColour.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)
        ucrInputX.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)
        ucrInputY.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)
        ucrInputYmin.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)
        ucrInputXmin.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)
        ucrInputXend.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)
        ucrInputYend.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)
        ucrInputXmax.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)
        ucrInputYmax.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)
        ucrInputAnnotationGeoms.SetRCode(clsAnnotateFunction, bReset, bCloneIfNeeded:=True)


        'axis controls
        ucrXAxis.SetRCodeForControl(bIsXAxis:=True, strNewAxisType:=GetAxisType(True, bStrictDiscrete:=IsFactor(True, GetAesParameterArgValue("x"))), clsNewXYlabTitleFunction:=clsXLabFunction, clsNewXYScaleContinuousFunction:=clsXScalecontinuousFunction, clsNewXYScaleDateFunction:=clsXScaleDateFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset, bCloneIfNeeded:=True, strDataFrame:=strDataFrame, strNewVariable:=GetAesParameterArgValue("x"))
        ucrYAxis.SetRCodeForControl(bIsXAxis:=False, strNewAxisType:=GetAxisType(False, bStrictDiscrete:=IsFactor(False, GetAesParameterArgValue("y"))), clsNewXYlabTitleFunction:=clsYLabFunction, clsNewXYScaleContinuousFunction:=clsYScalecontinuousFunction, clsNewBaseOperator:=clsBaseOperator, clsNewXYScaleDateFunction:=clsYScaleDateFunction, bReset:=bReset, bCloneIfNeeded:=True, strDataFrame:=strDataFrame, strNewVariable:=GetAesParameterArgValue("y"))

        ucrInputAxisType.SetName(GetAxisType(False, bStrictDiscrete:=IsFactor(False, GetAesParameterArgValue("y"))))
        'Themes tab
        SetRcodeForCommonThemesControls(bReset)
        'coordinates tab
        ucrChkHorizontalPlot.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        ucrChkSameScale.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        ucrChkUsePolarCoordinates.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        ucrChkDirectionAnticlockwise.SetRCode(clsCoordPolarFunc, bReset:=True, bCloneIfNeeded:=True)
        ucrInputStartingAngle.SetRCode(clsCoordPolarStartOperator, bReset, bCloneIfNeeded:=True)
        ucrInputPolarCoordinates.SetRCode(clsCoordPolarFunc, bReset:=True, bCloneIfNeeded:=True)

        'colour
        ucrInputPalettes.AddAdditionalCodeParameterPair(clsColourPaletteFunction, New RParameter("palette", 7), iAdditionalPairNo:=1)
        ucrInputPaletteContinuous.AddAdditionalCodeParameterPair(clsScaleColorDistillerFunction, New RParameter("palette", 8), iAdditionalPairNo:=1)
        ucrInputFillScaleColour.SetRCode(clsScaleFillViridisFunction, bReset, bCloneIfNeeded:=True)
        ucrNudFillScaleTransparency.SetRCode(clsScaleFillViridisFunction, bReset, bCloneIfNeeded:=True)
        ucrNudFillScaleMapBegins.SetRCode(clsScaleFillViridisFunction, bReset, bCloneIfNeeded:=True)
        ucrNudFillScaleMapEnds.SetRCode(clsScaleFillViridisFunction, bReset, bCloneIfNeeded:=True)
        ucrChkFillScaleReverseColourOrder.SetRCode(clsScaleFillViridisFunction, bReset, bCloneIfNeeded:=True)
        ucrInputColourScalePalette.SetRCode(clsScaleColourViridisFunction, bReset, bCloneIfNeeded:=True)
        ucrNudColourScaleTransparency.SetRCode(clsScaleColourViridisFunction, bReset, bCloneIfNeeded:=True)
        ucrNudColourScaleMapBegins.SetRCode(clsScaleColourViridisFunction, bReset, bCloneIfNeeded:=True)
        ucrNudColourScaleMapEnds.SetRCode(clsScaleColourViridisFunction, bReset, bCloneIfNeeded:=True)
        ucrChkColourScaleReverseOrder.SetRCode(clsScaleColourViridisFunction, bReset, bCloneIfNeeded:=True)
        ucrChkFillDiscrete.SetRCode(clsScaleFillViridisFunction, bReset, bCloneIfNeeded:=True)
        ucrChkColourDiscrete.SetRCode(clsScaleColourViridisFunction, bReset, bCloneIfNeeded:=True)
        If bReset Then
            ucrPnlScale.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
            ucrPnlColourPalette.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPalettes.SetRCode(clsFillPaletteFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPaletteContinuous.SetRCode(clsScaleFillDistillerFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevels.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPosition.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPosition.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevels.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpand.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpand.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaks.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaks.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimit.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimit.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValue.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValue.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColor.SetRCode(clsScaleColorColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColor.SetRCode(clsScaleColorColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColor.SetRCode(clsScaleColorColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColor.SetRCode(clsScaleColorColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColor.SetRCode(clsScaleColorColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColor.SetRCode(clsScaleColorColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColor.SetRCode(clsScaleColorColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColor.SetRCode(clsScaleColorColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColor.SetRCode(clsScaleColorColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColor.SetRCode(clsScaleFillColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColor.SetRCode(clsScaleColorColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColor.SetRCode(clsScaleColorColorblindFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitCal.SetRCode(clsScalefillcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitCal.SetRCode(clsScalefillcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandCal.SetRCode(clsScalefillcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandCal.SetRCode(clsScalefillcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksCal.SetRCode(clsScalefillcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksCal.SetRCode(clsScalefillcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsCal.SetRCode(clsScalefillcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsCal.SetRCode(clsScalefillcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionCal.SetRCode(clsScalefillcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionCal.SetRCode(clsScalefillcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueCal.SetRCode(clsScalefillcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueCal.SetRCode(clsScalefillcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorCal.SetRCode(clsScalecolorcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorCal.SetRCode(clsScalecolorcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorCal.SetRCode(clsScalecolorcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorCal.SetRCode(clsScalecolorcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorCal.SetRCode(clsScalecolorcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorCal.SetRCode(clsScalecolorcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorCal.SetRCode(clsScalecolorcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorCal.SetRCode(clsScalecolorcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorCal.SetRCode(clsScalecolorcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorCal.SetRCode(clsScalecolorcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorCal.SetRCode(clsScalecolorcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorCal.SetRCode(clsScalecolorcalcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputCanvasFillPalette.SetRCode(clsScalefillcanvaFunction, bReset, bCloneIfNeeded:=True)
            ucrInputCanvasColorPalette.SetRCode(clsScalecolorcanvaFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitEcon.SetRCode(clsScalefilleconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitEcon.SetRCode(clsScalefilleconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandEcon.SetRCode(clsScalefilleconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandEcon.SetRCode(clsScalefilleconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksEcon.SetRCode(clsScalefilleconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksEcon.SetRCode(clsScalefilleconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsEcon.SetRCode(clsScalefilleconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsEcon.SetRCode(clsScalefilleconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionEcon.SetRCode(clsScalefilleconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionEcon.SetRCode(clsScalefilleconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueEcon.SetRCode(clsScalefilleconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueEcon.SetRCode(clsScalefilleconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorEcon.SetRCode(clsScalecoloreconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorEcon.SetRCode(clsScalecoloreconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorEcon.SetRCode(clsScalecoloreconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorEcon.SetRCode(clsScalecoloreconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorEcon.SetRCode(clsScalecoloreconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorEcon.SetRCode(clsScalecoloreconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorEcon.SetRCode(clsScalecoloreconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorEcon.SetRCode(clsScalecoloreconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorEcon.SetRCode(clsScalecoloreconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorEcon.SetRCode(clsScalecoloreconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorEcon.SetRCode(clsScalecoloreconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorEcon.SetRCode(clsScalecoloreconomistFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitEx.SetRCode(clsScalefillexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitEx.SetRCode(clsScalefillexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandEx.SetRCode(clsScalefillexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandEx.SetRCode(clsScalefillexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksEx.SetRCode(clsScalefillexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksEx.SetRCode(clsScalefillexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsEx.SetRCode(clsScalefillexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsEx.SetRCode(clsScalefillexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionEx.SetRCode(clsScalefillexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionEx.SetRCode(clsScalefillexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueEx.SetRCode(clsScalefillexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueEx.SetRCode(clsScalefillexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorEx.SetRCode(clsScalecolorexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorEx.SetRCode(clsScalecolorexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorEx.SetRCode(clsScalecolorexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorEx.SetRCode(clsScalecolorexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorEx.SetRCode(clsScalecolorexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorEx.SetRCode(clsScalecolorexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorEx.SetRCode(clsScalecolorexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorEx.SetRCode(clsScalecolorexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorEx.SetRCode(clsScalecolorexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorEx.SetRCode(clsScalecolorexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorEx.SetRCode(clsScalecolorexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorEx.SetRCode(clsScalecolorexcelFunction, bReset, bCloneIfNeeded:=True)
            ucrInputThemeFill.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkThemeFill.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkThemecolor.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputThemeColor.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitExn.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitExn.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandExn.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandExn.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksExn.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksExn.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsExn.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsExn.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionExn.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionExn.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueExn.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueExn.SetRCode(clsScalefillexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorExn.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorExn.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorExn.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorExn.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorExn.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorExn.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorExn.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorExn.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorExn.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorExn.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorExn.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorExn.SetRCode(clsScalecolorexcelnewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPalettefill.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPalettefill.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPalettecolor.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPalettecolor.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitfew.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitfew.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandfew.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandfew.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksfew.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksfew.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsfew.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsfew.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionfew.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionfew.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValuefew.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValuefew.SetRCode(clsScalefillfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorfew.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorfew.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorfew.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorfew.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorfew.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorfew.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorfew.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorfew.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorfew.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorfew.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorfew.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorfew.SetRCode(clsScalecolorfewFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitfiv.SetRCode(clsScalefillfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitfiv.SetRCode(clsScalefillfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandfiv.SetRCode(clsScalefillfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandfiv.SetRCode(clsScalefillfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksfiv.SetRCode(clsScalefillfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksfiv.SetRCode(clsScalefillfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsfiv.SetRCode(clsScalefillfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsfiv.SetRCode(clsScalefillfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionfiv.SetRCode(clsScalefillfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionfiv.SetRCode(clsScalefillfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValuefiv.SetRCode(clsScalefillfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValuefiv.SetRCode(clsScalefillfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorfiv.SetRCode(clsScalecolorfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorfiv.SetRCode(clsScalecolorfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorfiv.SetRCode(clsScalecolorfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorfiv.SetRCode(clsScalecolorfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorfiv.SetRCode(clsScalecolorfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorfiv.SetRCode(clsScalecolorfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorfiv.SetRCode(clsScalecolorfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorfiv.SetRCode(clsScalecolorfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorfiv.SetRCode(clsScalecolorfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorfiv.SetRCode(clsScalecolorfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorfiv.SetRCode(clsScalecolorfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorfiv.SetRCode(clsScalecolorfivethirtyeightFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitg.SetRCode(clsScalefillgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitg.SetRCode(clsScalefillgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandg.SetRCode(clsScalefillgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandg.SetRCode(clsScalefillgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksg.SetRCode(clsScalefillgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksg.SetRCode(clsScalefillgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsg.SetRCode(clsScalefillgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsg.SetRCode(clsScalefillgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositiong.SetRCode(clsScalefillgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositiong.SetRCode(clsScalefillgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueg.SetRCode(clsScalefillgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueg.SetRCode(clsScalefillgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorg.SetRCode(clsScalecolorgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorg.SetRCode(clsScalecolorgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorg.SetRCode(clsScalecolorgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorg.SetRCode(clsScalecolorgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorg.SetRCode(clsScalecolorgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorg.SetRCode(clsScalecolorgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorg.SetRCode(clsScalecolorgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorg.SetRCode(clsScalecolorgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorg.SetRCode(clsScalecolorgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorg.SetRCode(clsScalecolorgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorg.SetRCode(clsScalecolorgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorg.SetRCode(clsScalecolorgdocsFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPalettehc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPalettehc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPalettecolorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPalettecolorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimithc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimithc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandhc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandhc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreakshc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreakshc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelshc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelshc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionhc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionhc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValuehc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValuehc.SetRCode(clsScalefillhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorhc.SetRCode(clsScalecolorhcFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitpan.SetRCode(clsScalefillpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitpan.SetRCode(clsScalefillpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandpan.SetRCode(clsScalefillpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandpan.SetRCode(clsScalefillpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreakspan.SetRCode(clsScalefillpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreakspan.SetRCode(clsScalefillpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelspan.SetRCode(clsScalefillpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelspan.SetRCode(clsScalefillpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionpan.SetRCode(clsScalefillpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionpan.SetRCode(clsScalefillpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValuepan.SetRCode(clsScalefillpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValuepan.SetRCode(clsScalefillpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorpan.SetRCode(clsScalecolorpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorpan.SetRCode(clsScalecolorpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorpan.SetRCode(clsScalecolorpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorpan.SetRCode(clsScalecolorpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorpan.SetRCode(clsScalecolorpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorpan.SetRCode(clsScalecolorpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorpan.SetRCode(clsScalecolorpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorpan.SetRCode(clsScalecolorpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorpan.SetRCode(clsScalecolorpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorpan.SetRCode(clsScalecolorpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorpan.SetRCode(clsScalecolorpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorpan.SetRCode(clsScalecolorpanderFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitpt.SetRCode(clsScalefillptolFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitpt.SetRCode(clsScalefillptolFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandpt.SetRCode(clsScalefillptolFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandpt.SetRCode(clsScalefillptolFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreakspt.SetRCode(clsScalefillptolFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreakspt.SetRCode(clsScalefillptolFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelspt.SetRCode(clsScalefillptolFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelspt.SetRCode(clsScalefillptolFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionpt.SetRCode(clsScalefillptolFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionpt.SetRCode(clsScalefillptolFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValuept.SetRCode(clsScalefillptolFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValuept.SetRCode(clsScalefillptolFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorpt.SetRCode(clsScalecolorptolFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorpt.SetRCode(clsScalecolorptolFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorpt.SetRCode(clsScalecolorptolFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorpt.SetRCode(clsScalecolorptolFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorpt.SetRCode(clsScalecolorptolFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorpt.SetRCode(clsScalecolorptolFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorpt.SetRCode(clsScalecolorptolFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorpt.SetRCode(clsScalecolorptolFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorpt.SetRCode(clsScalecolorptolFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorpt.SetRCode(clsScalecolorptolFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorpt.SetRCode(clsScalecolorptolFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorpt.SetRCode(clsScalecolorptolFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitsol.SetRCode(clsScalefillsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitsol.SetRCode(clsScalefillsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandsol.SetRCode(clsScalefillsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandsol.SetRCode(clsScalefillsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreakssol.SetRCode(clsScalefillsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreakssol.SetRCode(clsScalefillsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelssol.SetRCode(clsScalefillsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelssol.SetRCode(clsScalefillsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionsol.SetRCode(clsScalefillsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionsol.SetRCode(clsScalefillsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValuesol.SetRCode(clsScalefillsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValuesol.SetRCode(clsScalefillsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorsol.SetRCode(clsScalecolorsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorsol.SetRCode(clsScalecolorsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorsol.SetRCode(clsScalecolorsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorsol.SetRCode(clsScalecolorsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorsol.SetRCode(clsScalecolorsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorsol.SetRCode(clsScalecolorsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorsol.SetRCode(clsScalecolorsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorsol.SetRCode(clsScalecolorsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorsol.SetRCode(clsScalecolorsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorsol.SetRCode(clsScalecolorsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorsol.SetRCode(clsScalecolorsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorsol.SetRCode(clsScalecolorsolarizedFunction, bReset, bCloneIfNeeded:=True)
            ucrInputSchemefill.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkSchemefill.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkSchemecolor.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputSchemecolor.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitst.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitst.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandst.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandst.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksst.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksst.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsst.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsst.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionst.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionst.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValuest.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValuest.SetRCode(clsScalefillstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorst.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorst.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorst.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorst.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorst.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorst.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorst.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorst.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorst.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorst.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorst.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorst.SetRCode(clsScalecolorstataFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPalettefillw.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkpalettefillw.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPalettecolorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPalettecolorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitw.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitw.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandw.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandw.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksw.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksw.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsw.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsw.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionw.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionw.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValuew.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValuew.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValuew.SetRCode(clsScalefillwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextLimitColorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLimitColorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkExpandColorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextExpandColorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkBreaksColorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextBreaksColorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDropUnusedLevelsColorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputDropUnusedLevelsColorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkPositionColorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputPositionColorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrChkNaValueColorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputTextNaValueColorw.SetRCode(clsScalecolorwsjFunction, bReset, bCloneIfNeeded:=True)
            ucrInputcontinuouscolor.SetRCode(clsScalecolorgradienttableauFunction, bReset, bCloneIfNeeded:=True)
            ucrInputContinousfill.SetRCode(clsScalefillgradienttableauFunction, bReset, bCloneIfNeeded:=True)
        End If

        'labels
        If bReset Then
            ucrNudTitleSize.SetRCode(clsPlotElementTitleFunction, bReset, bCloneIfNeeded:=True)
            ucrNudSubTitleSize.SetRCode(clsPlotElementSubTitleFunction, bReset, bCloneIfNeeded:=True)
            ucrNudCaptionSize.SetRCode(clsPlotElementCaptionFunction, bReset, bCloneIfNeeded:=True)
            ucrNudLegendSize.SetRCode(clsPlotLegendTitleFunction, bReset, bCloneIfNeeded:=True)
            ucrNudTagSize.SetRCode(clsPlotElementTagFunction, bReset, bCloneIfNeeded:=True)
        End If

        ucrPlotsAdditionalLayers.SetRCodeForControl(clsNewBaseOperator:=clsBaseOperator, clsRNewggplotFunc:=clsRggplotFunction, clsNewAesFunc:=clsGlobalAesFunction, strNewGlobalDataFrame:=strDataFrame, strMainDialogGeomParameterNames:=strMainDialogGeomParameterNames, bReset:=bReset)
        bRCodeSet = True
        AddRemoveLabs()
        AddRemoveFacets()
        SetScaleParameter()
        SecondFactorReceiverEnabled()
        If bReset Then
            ucr1stFactorReceiver.SetMeAsReceiver()
            tbpPlotsOptions.SelectedIndex = 0
            bResetThemes = True
        End If
        SetFacetParameters()
        ucrChkColourDiscrete.Enabled = bNewEnableDiscrete
        ucrChkFillDiscrete.Enabled = bNewEnableDiscrete
    End Sub

    Private Function GetAesParameterArgValue(strAes As String) As String
        Dim strVariable As String = ""
        If clsGlobalAesFunction.ContainsParameter(strAes) Then
            strVariable = clsGlobalAesFunction.GetParameter(strAes).strArgumentValue
        End If

        Return strVariable
    End Function

    Private Function IsFactor(bIsX As Boolean, strVariable As String) As Boolean
        Dim strAes As String
        strAes = If(bIsX, "x", "y")

        Dim bIsFactor As Boolean = False
        If clsGlobalAesFunction.ContainsParameter(strAes) Then

            Dim strCurrDataType As String = ""
            Dim clsGetDataType As New RFunction
            Dim expColumnType As SymbolicExpression

            clsGetDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
            clsGetDataType.AddParameter("property", "data_type_label")
            clsGetDataType.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
            clsGetDataType.AddParameter("column", Chr(34) & strVariable & Chr(34))

            expColumnType = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataType.ToScript(), bSilent:=True)
            If expColumnType?.Type <> Internals.SymbolicExpressionType.Null Then
                strCurrDataType = If(expColumnType.AsCharacter.Count > 1, Join(expColumnType.AsCharacter.ToArray, ","), expColumnType.AsCharacter(0))
            End If

            bIsFactor = If({"factor", "ordered,factor"}.Contains(strCurrDataType), True, False)

        End If

        Return bIsFactor
    End Function

    Private Sub SetFacetParameters()
        'Depending on the settings on the dialog, this function sets the Facets command, stored within clsRFacetFunction.
        'Then IncludeFacetsParameter() will add the facets command to the ggplot script as a parameter within RSyntax (unless no factor has been for fasceting, as R requires at least one facets argument).
        'The choice between grid and wrap is done systematically depending on the chosen settings.
        'The following two parameters (of the facet function) will be reset in this sub according to the settings selected on the dialog. They need to be cleared in case they are not relevant anymore for example if margins has been checked (they are specific to facet_wrap).
        If bRCodeSet Then
            FacetsNumberOfRowsOrColumns()
            If (Not ucr1stFactorReceiver.IsEmpty() AndAlso ucr2ndFactorReceiver.IsEmpty()) Then
                'There are two types of fasceting provided by ggplot2: grid and wrap. Grid works like a contigency table, wrap just rearranges a long list of plots into a grid. 
                'If two receivers are filled, only grid can be used. In case only one receiver is filled, grid will still be in use if one of the grid parameters is set such as "margins" or "free space". In other cases, wrap will be used.
                'In the grid case, the place of the argument, left or right, in the facets parameter of the facets function is determined by/determines the choice "vertical" or "horizontal" faceting. In the wrap case, the argument "dir" is set to vertical or horizontal accordingly.
                ucr1stFactorReceiver.SetParameterPosition(1)
                ucr2ndFactorReceiver.SetParameterPosition(0)
                clsFacetVariablesOperator.RemoveParameter(ucr2ndFactorReceiver.GetParameter())
                If rdoHorizontal.Checked AndAlso ((Not ucrChkMargin.Checked AndAlso Not ucrChkFreeSpace.Checked) OrElse (ucrChkNoOfRowsOrColumns.Visible AndAlso ucrChkNoOfRowsOrColumns.Checked)) Then
                    clsFacetFunction.SetRCommand("facet_wrap")
                    clsFacetFunction.AddParameter("dir", Chr(34) & "h" & Chr(34))
                ElseIf (rdoVertical.Checked AndAlso ((Not ucrChkMargin.Checked AndAlso Not ucrChkFreeSpace.Checked)) OrElse (ucrChkNoOfRowsOrColumns.Visible AndAlso ucrChkNoOfRowsOrColumns.Checked)) Then
                    clsFacetFunction.SetRCommand("facet_wrap")
                    clsFacetFunction.AddParameter("dir", Chr(34) & "v" & Chr(34))
                Else
                    clsFacetFunction.SetRCommand("facet_grid")
                    If rdoVertical.Checked Then
                        ucr1stFactorReceiver.SetParameterPosition(0)
                        ucr2ndFactorReceiver.SetParameterPosition(1)
                        ucr2ndFactorReceiver.SetParameterValue(".")
                        clsFacetVariablesOperator.AddParameter(ucr2ndFactorReceiver.GetParameter())
                    End If
                    clsFacetFunction.RemoveParameterByName("dir")
                End If
            ElseIf Not ucr1stFactorReceiver.IsEmpty() AndAlso Not ucr2ndFactorReceiver.IsEmpty() Then
                ucr1stFactorReceiver.SetParameterPosition(0)
                ucr2ndFactorReceiver.SetParameterPosition(1)
                clsFacetFunction.SetRCommand("facet_grid")
                clsFacetFunction.RemoveParameterByName("dir")
            End If
            If clsFacetFunction.strRCommand = "facet_grid" Then
                clsFacetFunction.AddParameter(ucrChkFreeSpace.GetParameter())
                If ucrChkMargin.Checked Then
                    clsFacetFunction.AddParameter(ucrChkMargin.GetParameter())
                Else
                    clsFacetFunction.RemoveParameter(ucrChkMargin.GetParameter())
                End If
                clsFacetFunction.RemoveParameter(ucrNudNumberofRows.GetParameter())
            Else
                clsFacetFunction.RemoveParameterByName("space")
                clsFacetFunction.RemoveParameterByName("margins")
                If rdoHorizontal.Checked Then
                    ucrChkNoOfRowsOrColumns.SetText("Fixed Number of Rows")
                    ucrNudNumberofRows.ChangeParameterName("nrow")
                ElseIf rdoVertical.Checked Then
                    ucrChkNoOfRowsOrColumns.SetText("Fixed Number of Columns")
                    ucrNudNumberofRows.ChangeParameterName("ncol")
                End If
                If ucrChkNoOfRowsOrColumns.Checked Then
                    clsFacetFunction.AddParameter(ucrNudNumberofRows.GetParameter())
                Else
                    clsFacetFunction.RemoveParameter(ucrNudNumberofRows.GetParameter())
                End If
            End If
        End If
    End Sub

    Public Sub DisableLayersTab()
        tbpLayers.Enabled = False
    End Sub

    Public Sub EnableLayersTab()
        tbpLayers.Enabled = True
    End Sub


    'To be removed but affects multiple dialogs
    Public Sub SetRSyntax(Optional clsRSyntax As RSyntax = Nothing)

    End Sub

    'To be removed but affects multiple dialogs
    Public Sub Reset()

    End Sub

    Private Sub InitialiseTabs()
        For i = 0 To tbpPlotsOptions.TabCount - 1
            tbpPlotsOptions.SelectedIndex = i
        Next
        tbpPlotsOptions.TabPages(6).Enabled = False
        tbpPlotsOptions.SelectedIndex = 0
    End Sub

    Private Sub AddRemoveFacets()
        If bRCodeSet Then
            'TODO What are the conditions for including facets
            If ucrChkIncludeFacets.Checked AndAlso Not ucr1stFactorReceiver.IsEmpty Then
                clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
            Else
                clsBaseOperator.RemoveParameterByName("facets")
            End If
        End If
    End Sub

    Private Sub ucrChkIncludeFacets_CheckedChanged() Handles ucrChkIncludeFacets.ControlValueChanged, ucr1stFactorReceiver.ControlValueChanged, ucr2ndFactorReceiver.ControlValueChanged
        FacetsNumberOfRowsOrColumns()
        AddRemoveFacets()
    End Sub

    Private Sub SetScaleParameter()
        'This sub is setting the right scale parameter in the clsRFacetFunctions, according to the scale chk boxes. 
        'It only needs to be called when these are modified, as this parameter is common to both facets_grid and facets_wrap. Although graphics on the same row or column in facets_grid share the y or x axis respectively. Still different rows might benefit from having different y-axis scales for instance.
        'Warning: ggplot allows the extra parameter "space" in the facet_grid case. That one takes as values "free" or "fixed" (with quotes). It determines whether the size of rows and columns should adapt to the range of the scale.
        If bRCodeSet Then
            If ucrChkFreeScalesX.Checked AndAlso ucrChkFreeScalesY.Checked Then
                clsFacetFunction.AddParameter("scales", Chr(34) & "free" & Chr(34))
            ElseIf ucrChkFreeScalesX.Checked Then
                clsFacetFunction.AddParameter("scales", Chr(34) & "free_x" & Chr(34))
            ElseIf ucrChkFreeScalesY.Checked Then
                clsFacetFunction.AddParameter("scales", Chr(34) & "free_y" & Chr(34))
            Else
                clsFacetFunction.RemoveParameterByName("scales")
            End If
        End If
    End Sub

    Private Sub chkScales_CheckedChanged() Handles ucrChkFreeScalesX.ControlValueChanged, ucrChkFreeScalesY.ControlValueChanged
        SetScaleParameter()
    End Sub

    Private Sub FacetsNumberOfRowsOrColumns()
        'This Sub() decides whether the option to fix the number of rows Or columns should be available Or Not.
        'When ucrChkMargin Is checked, Or when both receivers are used (i.e. the second optional Is filled), facet_grid Is used, And thus the number of rows Or columns can't be fixed.
        If ucrChkIncludeFacets.Checked Then
            If ucrChkMargin.Checked OrElse ucrChkFreeSpace.Checked OrElse Not ucr2ndFactorReceiver.IsEmpty Then
                ucrChkNoOfRowsOrColumns.Visible = False
                ucrNudNumberofRows.Visible = False
            Else
                ucrChkNoOfRowsOrColumns.Visible = True
                ucrNudNumberofRows.Visible = ucrChkNoOfRowsOrColumns.Checked
            End If
        Else
            ucrChkNoOfRowsOrColumns.Visible = False
            ucrNudNumberofRows.Visible = False
        End If
    End Sub

    Private Sub FactorReceivers_ControlValueChanged() Handles ucr1stFactorReceiver.ControlValueChanged, ucr2ndFactorReceiver.ControlValueChanged
        SecondFactorReceiverEnabled()
        SetFacetParameters()
        FacetsCheck()
    End Sub

    Private Sub SecondFactorReceiverEnabled()
        If bRCodeSet Then
            If ucr1stFactorReceiver.IsEmpty() Then
                ucr2ndFactorReceiver.Clear()
                ucr2ndFactorReceiver.Enabled = False
                If ucrFacetSelector.CurrentReceiver IsNot Nothing AndAlso ucrFacetSelector.CurrentReceiver.Equals(ucr2ndFactorReceiver) Then
                    ucr1stFactorReceiver.SetMeAsReceiver()
                End If
            Else
                ucr2ndFactorReceiver.Enabled = True
            End If
        End If
    End Sub

    Private Sub ucrPnlHorizonatalVertical_ControlValueChanged() Handles ucrPnlHorizonatalVertical.ControlValueChanged, ucrChkMargin.ControlValueChanged
        SetFacetParameters()
    End Sub


    Private Sub ucrChkFreeSpace_CheckedChanged() Handles ucrChkFreeSpace.ControlValueChanged
        SetFacetParameters()
    End Sub

    Public Sub SetDataFrame(strNewDataFrame As String)
        strDataFrame = strNewDataFrame
        ucrFacetSelector.SetDataframe(strDataFrame, False)
    End Sub

    Public Property bLayersDefaultIsGlobal As Boolean
        'Warning: This is used to decide whether the default setting of the first created layer should be to apply aes on all layers. Indeed, coming from plotoptions, it might be that the first layer is the "first additional layer" (don't want to ApplyOnAllLayers), whereas coming from generalforgraphics, the first layer is the first layer. This should be eliminated when the plotoptions sdg will be edited to have as first layer the non-editable layer coming from the main dlg. See issue #1948
        'It is only used in the set defaults here, which sets it to false
        Get
            Return bAdditionalLayersSetGlobal
        End Get
        Set(bValue As Boolean)
            bAdditionalLayersSetGlobal = bValue
            ucrPlotsAdditionalLayers.bSetGlobalIsDefault = bValue
        End Set
    End Property

    Private Sub AddRemoveLabs()
        If bRCodeSet Then
            If ucrChkIncludeTitles.Checked Then
                clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
                If Not ucrInputGraphTitle.IsEmpty() OrElse Not ucrInputGraphSubTitle.IsEmpty() OrElse Not ucrInputGraphCaption.IsEmpty() OrElse Not ucrInputTag.IsEmpty OrElse Not ucrInputLegendTitle.IsEmpty Then
                    clsBaseOperator.AddParameter("labs", clsRFunctionParameter:=clsLabsFunction)
                Else
                    clsBaseOperator.RemoveParameterByName("labs")
                End If
            Else
                clsBaseOperator.RemoveParameterByName("labs")
                clsBaseOperator.RemoveParameterByName("theme")
            End If
        End If
    End Sub

    Private Sub LabsControls_ControlValueChanged() Handles ucrInputGraphTitle.ControlValueChanged, ucrInputGraphSubTitle.ControlValueChanged, ucrInputGraphCaption.ControlValueChanged
        AddRemoveLabs()
    End Sub

    Private Sub ucrChkNoOfRowsOrColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNoOfRowsOrColumns.ControlValueChanged
        SetFacetParameters()
    End Sub

    Private Function GetAxisType(bIsX As Boolean, Optional bStrictDiscrete As Boolean = False) As String
        Dim strAes As String

        If bIsX Then
            strAes = "x"
        Else
            strAes = "y"
        End If
        If clsGlobalAesFunction IsNot Nothing Then
            If clsGlobalAesFunction.ContainsParameter(strAes) AndAlso clsGlobalAesFunction.GetParameter(strAes).strArgumentValue <> Chr(34) AndAlso Not bStrictDiscrete Then
                'Run R code to determine type
                'Temp default to continuous
                Return "continuous"
            Else
                'When aes not present discrete scale function works
                Return "discrete"
            End If
        Else
            Return "discrete"
        End If
    End Function

    Private Sub cmdAllOptions_Click(sender As Object, e As EventArgs) Handles cmdAllOptions.Click
        sdgThemes.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, bReset:=bResetThemes)
        Me.SendToBack()
        sdgThemes.ShowDialog()
        bResetThemes = False
        SetRcodeForCommonThemesControls(False)
    End Sub
    'Warning/Task to be discussed: need to disable ok on dlg's when layers are not complete on subdialogues + warning message... 
    'Warning: actually this will be very hard to implement until the global aes, set from the main layer are properly communicated to plots. Global aes might fill in missing mandatory aes...
    Private Sub FacetsCheck()
        If Not ucr1stFactorReceiver.IsEmpty AndAlso Not ucr2ndFactorReceiver.IsEmpty Then
            If ucr1stFactorReceiver.txtReceiverSingle.Text = ucr2ndFactorReceiver.txtReceiverSingle.Text Then
                MsgBox("You can not do facets with two same variables", vbOKOnly)
                ucr2ndFactorReceiver.Clear()
                ucr2ndFactorReceiver.SetMeAsReceiver()
            End If
        End If
    End Sub

    Private Sub AddRemoveYElementAxisTitle()
        If clsYElemetTitle.iParameterCount > 0 Then
            clsThemeFunction.AddParameter("axis.title.y", clsRFunctionParameter:=clsYElemetTitle)
        Else
            clsThemeFunction.RemoveParameterByName("axis.text.y")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveXElementAxisText()
        If clsXElementText.iParameterCount > 0 Then
            clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsXElementText)
        Else
            clsThemeFunction.RemoveParameterByName("axis.text.x")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveXElementTitle()
        If clsXElementTitle.iParameterCount > 0 Then
            clsThemeFunction.AddParameter("axis.title.x", clsRFunctionParameter:=clsXElementTitle)
        Else
            clsThemeFunction.RemoveParameterByName("axis.title.x")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveYElementAxisText()
        If clsYElemetText.iParameterCount > 0 Then
            clsThemeFunction.AddParameter("axis.text.y", clsRFunctionParameter:=clsYElemetText)
        Else
            clsThemeFunction.RemoveParameterByName("axis.text.y")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ElementXAxisTextControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkXaxisAngle.ControlValueChanged, ucrNudXAngle.ControlValueChanged, ucrChkXaxisTickMarkLabelSize.ControlValueChanged, ucrNudXaxisMarkSize.ControlValueChanged
        AddRemoveXElementAxisText()
    End Sub

    Private Sub ucrChkXaxisSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkXaxisSize.ControlValueChanged, ucrNudXSize.ControlValueChanged
        AddRemoveXElementTitle()
    End Sub

    Private Sub ucrChkYaxisTickMarkLabelSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkYaxisTickMarkLabelSize.ControlValueChanged, ucrNudYaxisMarkSize.ControlValueChanged
        AddRemoveYElementAxisText()
    End Sub

    Private Sub ucrChkYaxisSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkYaxisSize.ControlValueChanged, ucrNudYSize.ControlValueChanged
        AddRemoveYElementAxisTitle()
    End Sub

    Private Sub ucrChkLegendPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegendPosition.ControlValueChanged
        AddRemoveTheme()
    End Sub

    Private Sub SetRcodeForCommonThemesControls(bReset As Boolean)
        ucrChkLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        ucrChkXaxisAngle.SetRCode(clsXElementText, bReset, bCloneIfNeeded:=True)
        ucrNudXAngle.SetRCode(clsXElementText, bReset, bCloneIfNeeded:=True)

        ucrChkXaxisSize.SetRCode(clsXElementTitle, bReset, bCloneIfNeeded:=True)
        ucrNudXSize.SetRCode(clsXElementTitle, bReset, bCloneIfNeeded:=True)

        ucrChkYaxisTickMarkLabelSize.SetRCode(clsYElemetText, bReset, bCloneIfNeeded:=True)
        ucrNudYaxisMarkSize.SetRCode(clsYElemetText, bReset, bCloneIfNeeded:=True)

        ucrChkYaxisSize.SetRCode(clsYElemetTitle, bReset, bCloneIfNeeded:=True)
        ucrNudYSize.SetRCode(clsYElemetTitle, bReset, bCloneIfNeeded:=True)

        ucrChkXaxisTickMarkLabelSize.SetRCode(clsXElementText, bReset, bCloneIfNeeded:=True)
        ucrNudXaxisMarkSize.SetRCode(clsXElementText, bReset, bCloneIfNeeded:=True)
    End Sub

    Private Sub cmdSimpleOptions_Click(sender As Object, e As EventArgs) Handles cmdSimpleOptions.Click
        sdgThemesSub.SetRCode(clsBaseOperator, clsNewThemesFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, bReset:=bResetThemes)
        Me.SendToBack()
        sdgThemesSub.ShowDialog()
        SetRcodeForCommonThemesControls(False)
    End Sub

    Private Sub ucrChkUsePolarCoordinates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkUsePolarCoordinates.ControlValueChanged
        If ucrChkUsePolarCoordinates.Checked Then
            clsBaseOperator.AddParameter("coord_polar", clsRFunctionParameter:=clsCoordPolarFunc, iPosition:=20)
        Else
            clsBaseOperator.RemoveParameterByName("coord_polar")
        End If
    End Sub

    Private Sub ucrChkAnnotation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAnnotation.ControlValueChanged
        If ucrChkAnnotation.Checked Then
            clsBaseOperator.AddParameter("annotate", clsRFunctionParameter:=clsAnnotateFunction, iPosition:=10)
        Else
            clsBaseOperator.RemoveParameterByName("annotate")
        End If
    End Sub

    Private Sub ucrInputAnnotationGeoms_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputAnnotationGeoms.ControlValueChanged
        Select Case ucrInputAnnotationGeoms.GetText
            Case "rect", "label"
                ucrInputFill.Location = New Point(ucrInputFill.Location.X, iSizeYPosition)
                ucrNudSize.Location = New Point(ucrNudSize.Location.X, iAlphaYPosition)
                ucrNudAlpha.Location = New Point(ucrNudAlpha.Location.X, iLabelYposition)
                lblFill.Location = New Point((65 - lblFill.Size.Width), 111)
                lblSize.Location = New Point((65 - lblSize.Size.Width), 135)
                lblAlpha.Location = New Point((65 - lblAlpha.Size.Width), 159)
                If ucrInputAnnotationGeoms.GetText = "label" Then
                    ucrInputLabel.Location = New Point(ucrInputLabel.Location.X, iFillYPositon)
                    lblLabel.Location = New Point((65 - lblLabel.Size.Width), 183)
                End If
            Case "crossbar", "segment", "pointrange", "curve", "text", "linerange", "errorbar"
                ucrInputFill.Location = New Point(ucrInputFill.Location.X, iFillYPositon)
                ucrNudSize.Location = New Point(ucrNudSize.Location.X, iSizeYPosition)
                ucrNudAlpha.Location = New Point(ucrNudAlpha.Location.X, iAlphaYPosition)
                ucrInputLabel.Location = New Point(ucrInputLabel.Location.X, iLabelYposition)
                lblFill.Location = New Point((65 - lblFill.Size.Width), 183)
                lblSize.Location = New Point((65 - lblSize.Size.Width), 111)
                lblAlpha.Location = New Point((65 - lblAlpha.Size.Width), 135)
                lblLabel.Location = New Point((65 - lblLabel.Size.Width), 159)
        End Select

        Select Case ucrInputAnnotationGeoms.GetText
            Case "text", "rect", "linerange", "errorbar"
                ucrChkParse.Location = New Point(ucrChkParse.Location.X, 179)
            Case "label", "crossbar", "segment"
                ucrChkParse.Location = New Point(ucrChkParse.Location.X, 204)
            Case "pointrange", "curve"
                ucrChkParse.Location = New Point(ucrChkParse.Location.X, 228)
        End Select
        AddLabelParameter()
    End Sub

    Private Sub ucrInputLabel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLabel.ControlValueChanged
        AddLabelParameter()
    End Sub

    Private Sub AddLabelParameter()
        Select Case ucrInputAnnotationGeoms.GetText
            Case "text", "label"
                If ucrInputLabel.GetText <> "" AndAlso ucrInputLabel.clsRList.clsParameters.Count > 1 Then
                    clsAnnotateFunction.AddParameter("label", clsRFunctionParameter:=ucrInputLabel.clsRList, iPosition:=21)
                Else
                    clsAnnotateFunction.RemoveParameterByName("label")
                    clsAnnotateFunction.AddParameter("label", Chr(34) & ucrInputLabel.GetText & Chr(34), iPosition:=21)
                End If
            Case Else
                clsAnnotateFunction.RemoveParameterByName("label")
        End Select
    End Sub

    Private Sub ucrChkTag_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTag.ControlValueChanged, ucrInputTag.ControlValueChanged
        If ucrChkTag.Checked AndAlso Not ucrInputTag.IsEmpty Then
            clsLabsFunction.AddParameter("tag", Chr(34) & ucrInputTag.GetText & Chr(34))
            clsThemeFunction.AddParameter("plot.tag", clsRFunctionParameter:=clsPlotElementTagFunction)
        Else
            clsLabsFunction.RemoveParameterByName("tag")
            clsThemeFunction.RemoveParameterByName("plot.tag")
        End If
    End Sub

    Private Sub ucrChkNewLegend_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNewLegend.ControlValueChanged, ucrInputLegendTitle.ControlValueChanged
        If ucrChkNewLegend.Checked AndAlso Not ucrInputLegendTitle.IsEmpty Then
            clsLabsFunction.AddParameter("colour", Chr(34) & ucrInputLegendTitle.GetText & Chr(34))
            clsLabsFunction.AddParameter("fill", Chr(34) & ucrInputLegendTitle.GetText & Chr(34))
            clsThemeFunction.AddParameter("legend.title", clsRFunctionParameter:=clsPlotLegendTitleFunction)
        Else
            clsLabsFunction.RemoveParameterByName("colour")
            clsLabsFunction.RemoveParameterByName("fill")
            clsThemeFunction.RemoveParameterByName("legend.title")
        End If
    End Sub

    Private Sub ucrNudCaptionSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudCaptionSize.ControlValueChanged
        If clsPlotElementCaptionFunction.clsParameters.Count > 0 Then
            clsThemeFunction.AddParameter("plot.caption", clsRFunctionParameter:=clsPlotElementCaptionFunction)
        Else
            clsThemeFunction.RemoveParameterByName("plot.caption")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub ucrNudTitleSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudTitleSize.ControlValueChanged
        If clsPlotElementTitleFunction.clsParameters.Count > 0 Then
            clsThemeFunction.AddParameter("plot.title", clsRFunctionParameter:=clsPlotElementTitleFunction)
        Else
            clsThemeFunction.RemoveParameterByName("plot.title")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub ucrNudSubTitleSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudSubTitleSize.ControlValueChanged
        If clsPlotElementSubTitleFunction.clsParameters.Count > 0 Then
            clsThemeFunction.AddParameter("plot.title", clsRFunctionParameter:=clsPlotElementSubTitleFunction)
        Else
            clsThemeFunction.RemoveParameterByName("plot.title")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub ucrNudTagSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudTagSize.ControlValueChanged
        clsPlotElementTagFunction.AddParameter("size", ucrNudTagSize.GetText)
    End Sub

    Private Sub ucrNudLegendSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudLegendSize.ControlValueChanged
        clsPlotLegendTitleFunction.AddParameter("size", ucrNudLegendSize.GetText)
    End Sub

    Private Sub ucrChkIncludeTitles_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeTitles.ControlValueChanged
        AddRemoveLabs()
    End Sub
    
    Private Sub ucrBaseSubdialog_ClickReturn(sender As Object, e As EventArgs) Handles ucrBaseSubdialog.ClickReturn
        dlgGeneralForGraphics.ucrAdditionalLayers.SetRCodeForControl(clsNewBaseOperator:=clsBaseOperator, clsRNewggplotFunc:=clsRggplotFunction, clsNewAesFunc:=clsGlobalAesFunction, strNewGlobalDataFrame:=strDataFrame, bReset:=True)
    End Sub
End Class