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
Imports instat
Imports instat.Translations
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
    Public clsYLabFunction As New RFunction
    Public clsBaseOperator As New ROperator
    Private bControlsInitialised As Boolean = False
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

    'See bLayersDefaultIsGolobal below.

    Private Sub sdgPlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctThemes As New Dictionary(Of String, String)
        Dim strThemes As String()

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

        ucrChkMargin.SetText("Margins")
        ucrChkMargin.SetParameter(New RParameter("margins"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=False)
        ucrChkMargin.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMargin.SetRDefault("FALSE")

        ucrChkNoOfRowsOrColumns.AddFunctionNamesCondition(True, "facet_wrap", True)
        ucrChkNoOfRowsOrColumns.AddParameterPresentCondition(True, {"ncol", "nrow"}, True)
        ucrChkNoOfRowsOrColumns.AddFunctionNamesCondition(False, "facet_wrap", False)
        'ucrChkNoOfRowsOrColumns.AddParameterPresentCondition(False, {"ncol", "nrow"}, False)
        ucrChkNoOfRowsOrColumns.SetText("Fixed Number of Rows")

        ucrNudNumberofRows.SetParameter(New RParameter("nrow"))
        ucrNudNumberofRows.bAddRemoveParameter = False

        ucrChkFreeScalesX.SetText("Free Scales X")
        ucrChkFreeScalesX.SetParameter(New RParameter("scales"))
        ucrChkFreeScalesX.AddParameterValuesCondition(True, "scales", {Chr(34) & "free" & Chr(34), Chr(34) & "free_x" & Chr(34)})
        ucrChkFreeScalesX.AddParameterValuesCondition(False, "scales", {Chr(34) & "free" & Chr(34), Chr(34) & "free_x" & Chr(34)}, False)
        ucrChkFreeScalesX.bChangeParameterValue = False
        ucrChkFreeScalesX.bAddRemoveParameter = False

        ucrChkFreeScalesY.SetText("Free Scales Y")
        ucrChkFreeScalesY.SetParameter(New RParameter("scales"))
        ucrChkFreeScalesY.AddParameterValuesCondition(True, "scales", {Chr(34) & "free" & Chr(34), Chr(34) & "free_y" & Chr(34)})
        ucrChkFreeScalesY.AddParameterValuesCondition(False, "scales", {Chr(34) & "free" & Chr(34), Chr(34) & "free_y" & Chr(34)}, False)
        ucrChkFreeScalesY.bChangeParameterValue = False
        ucrChkFreeScalesY.bAddRemoveParameter = False

        'TODO space can be either: "fixed", "free", "free_x", "free_y"
        '     currently only implemented "free" or "fixed"
        ucrChkFreeSpace.SetText("Free Space")
        ucrChkFreeSpace.SetParameter(New RParameter("space"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=False, strNewValueIfChecked:=Chr(34) & "free" & Chr(34), strNewValueIfUnchecked:=Chr(34) & "fixed" & Chr(34))
        ucrChkFreeSpace.SetRDefault(Chr(34) & "fixed" & Chr(34))
        ucrChkFreeSpace.AddToLinkedControls(ucrChkNoOfRowsOrColumns, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'Not setting parameter to write because of complex conditions for adding/removing this parameter
        'Conditions in place for reading function
        ucrPnlHorizonatalVertical.SetParameter(New RParameter("dir"))
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

        'layers tab 

        'titles tab

        ucrInputGraphTitle.SetParameter(New RParameter("title"))
        ucrInputGraphSubTitle.SetParameter(New RParameter("subtitle"))
        ucrInputGraphCaption.SetParameter(New RParameter("caption"))

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
        urChkSelectTheme.SetText("Select Theme:")
        ucrInputThemes.SetParameter(New RParameter("theme_name"))
        urChkSelectTheme.AddToLinkedControls(ucrInputThemes, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="theme_grey")
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
        ucrInputThemes.SetRDefault("theme_grey()")
        ucrInputThemes.SetDropDownStyleAsNonEditable()

        InitialiseTabs()

        'temporary disabled until implemented
        ' tbpLayers.Enabled = False
        tbpCoordinates.Enabled = False
        grpLegendTitle.Enabled = False
        'cmdAllOptions.Enabled = False
        GroupBox1.Visible = False
        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewOperator As ROperator, Optional clsNewGlobalAesFunction As RFunction = Nothing, Optional clsNewYScalecontinuousFunction As RFunction = Nothing, Optional clsNewXScalecontinuousFunction As RFunction = Nothing, Optional clsNewLabsFunction As RFunction = Nothing, Optional clsNewXLabsTitleFunction As RFunction = Nothing, Optional clsNewYLabTitleFunction As RFunction = Nothing, Optional clsNewFacetFunction As RFunction = Nothing, Optional clsNewThemeParam As RParameter = Nothing, Optional clsNewThemeFunction As RFunction = Nothing, Optional dctNewThemeFunctions As Dictionary(Of String, RFunction) = Nothing, Optional ucrNewBaseSelector As ucrSelector = Nothing, Optional bReset As Boolean = False)
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
        ucrFacetSelector.SetLinkedSelector(ucrBaseSelector)
        clsBaseOperator = clsNewOperator
        clsGlobalAesFunction = clsNewGlobalAesFunction
        clsXLabFunction = clsNewXLabsTitleFunction
        clsYLabFunction = clsNewYLabTitleFunction
        clsXScalecontinuousFunction = clsNewXScalecontinuousFunction
        clsYScalecontinuousFunction = clsNewYScalecontinuousFunction
        clsFacetFunction = clsNewFacetFunction
        clsThemeFunction = clsNewThemeFunction
        dctThemeFunctions = dctNewThemeFunctions

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
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator)
        If clsNewLabsFunction IsNot Nothing Then
            clsLabsFunction = clsNewLabsFunction
        Else
            clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        End If

        If clsNewThemeParam IsNot Nothing Then
            clsBaseOperator.AddParameter(clsNewThemeParam)
        Else
            clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        End If

        ucrInputGraphTitle.SetRCode(clsLabsFunction, bReset)
        ucrInputGraphSubTitle.SetRCode(clsLabsFunction, bReset)
        ucrInputGraphCaption.SetRCode(clsLabsFunction, bReset)
        urChkSelectTheme.SetRCode(clsBaseOperator, bReset)
        ucrInputThemes.SetRCode(clsBaseOperator, bReset)

        'ucrInputLegend.SetRCode(clsNewLabsFunction, bReset)
        ucrPnlHorizonatalVertical.SetRCode(clsFacetFunction, bReset)
        ucr1stFactorReceiver.SetRCode(clsFacetVariablesOperator, bReset)
        ucr2ndFactorReceiver.SetRCode(clsFacetVariablesOperator, bReset)

        ucrChkMargin.SetRCode(clsFacetFunction, bReset)
        ucrChkFreeSpace.SetRCode(clsFacetFunction, bReset)
        ucrChkFreeScalesX.SetRCode(clsFacetFunction, bReset)
        ucrChkFreeScalesY.SetRCode(clsFacetFunction, bReset)
        ucrNudNumberofRows.SetRCode(clsFacetFunction, bReset)
        ucrChkIncludeFacets.SetRCode(clsBaseOperator, bReset)

        'axis controls
        ucrXAxis.SetRCodeForControl(bIsXAxis:=True, strNewAxisType:=GetAxisType(True), clsNewXYlabTitleFunction:=clsXLabFunction, clsNewXYScaleContinuousFunction:=clsXScalecontinuousFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrYAxis.SetRCodeForControl(bIsXAxis:=False, strNewAxisType:=GetAxisType(False), clsNewXYlabTitleFunction:=clsYLabFunction, clsNewXYScaleContinuousFunction:=clsYScalecontinuousFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        'ucrPlotsAdditionalLayers.SetAesFunction(clsGlobalAesFunction)
        '''The following two setup the ucrAdditionalLayers on the sdgPlots. Shares the global ggplot function, as well as the whole PLots RSyntax.
        'ucrPlotsAdditionalLayers.SetGGplotFunction(clsRggplotFunction)
        'ucrPlotsAdditionalLayers.SetBaseOperator(clsBaseOperator)
        ucrPlotsAdditionalLayers.SetRCodeForControl(clsNewBaseOperator:=clsBaseOperator, clsRNewggplotFunc:=clsRggplotFunction, clsNewAesFunc:=clsGlobalAesFunction, bReset:=bReset)
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
    End Sub

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

    Public Sub SetDefaults()
        ' ucrChkIncludeFacets.Checked = False
        'IncludeFacets()
        'ucrNudNumberofRows.Value = 1
        'ucrFacetSelector.Reset()

        'ucrPlotsAdditionalLayers.Reset()
        ''Note that the following two don't reset the bisX and RSyntaxAxis ... So no need to set these again.
        'ucrXAxis.Reset()
        'ucrYAxis.Reset()
        'rdoLegendTitleAuto.Checked = True
        'bLayersDefaultIsGlobal = False
    End Sub

    Private Sub InitialiseDialog()
        'InitialiseTabs()
        'CreateThemes()
        ''The following sets up the clsGgplotAesFunction in ucrAdditionalLayers. Not sure this should happen in the initialise dialog... Not sure of the objective either... It is never linked to the main dlg anyway...
        'ucrPlotsAdditionalLayers.SetAesFunction(clsAesFunction)
        ''The following two setup the ucrAdditionalLayers on the sdgPlots. Shares the global ggplot function, as well as the whole PLots RSyntax.
        'ucrPlotsAdditionalLayers.SetGGplotFunction(clsRggplotFunction)
        'ucrPlotsAdditionalLayers.SetRSyntax(clsRsyntax)
        ''This is necessary to make sure the minimum number of fixed rows or columns is 1.
        'ucrNudNumberofRows.Minimum = 1

        ''Set's the X Axis tab to X mode and the YAxis tab to Y mode (each tab contains a generic ucrAxis with internal X or Y boolean setting).
        ''Also carry the RSyntax through to these ucr's .

        ' Dim clsNewSeqFunction As RFunction, clsNewTitleFunction As RFunction, clsNewScalecontinuousFunction As RFunction)
        'ucrXAxis.SetXorY(True)
        'ucrXAxis.SetRsyntaxAxis(clsRsyntax)

        'ucrYAxis.SetXorY(False)
        'ucrYAxis.SetRsyntaxAxis(clsRsyntax)
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

    Private Sub SetFacets()
        ''Depending on the settings on the dialog, this function sets the Facets command, stored within clsRFacetFunction.
        ''Then IncludeFacetsParameter() will add the facets command to the ggplot script as a parameter within RSyntax (unless no factor has been for fasceting, as R requires at least one facets argument).
        ''The choice between grid and wrap is done systematically depending on the chosen settings.

        ''The following two parameters (of the facet function) will be reset in this sub according to the settings selected on the dialog. They need to be cleared in case they are not relevant anymore for example if margins has been checked (they are specific to facet_wrap).
        ''clsRFacetFunction.RemoveParameterByName("nrow")
        ''clsRFacetFunction.RemoveParameterByName("ncol")
        'If (Not ucr1stFactorReceiver.IsEmpty() AndAlso ucr2ndFactorReceiver.IsEmpty()) Then

        '    strSingleFactor = ucr1stFactorReceiver.GetVariableNames(False)

        '    'There are two types of fasceting provided by ggplot2: grid and wrap. Grid works like a contigency table, wrap just rearranges a long list of plots into a grid. 
        '    'If two receivers are filled, only grid can be used. In case only one receiver is filled, grid will still be in use if one of the grid parameters is set such as "margins" or "free space". In other cases, wrap will be used.
        '    'In the grid case, the place of the argument, left or right, in the facets parameter of the facets function is determined by/determines the choice "vertical" or "horizontal" faceting. In the wrap case, the argument "dir" is set to vertical or horizontal accordingly.
        '    If rdoHorizontal.Checked AndAlso ((Not ucrChkMargin.Checked AndAlso Not ucrChkFreeSpace.Checked) OrElse ucrChkNoOfRowsOrColumns.Checked) Then
        '        clsRFacetFunction.SetRCommand("facet_wrap")
        '        clsTempOp.AddParameter(iPosition:=0, strParameterValue:="")
        '        clsTempOp.AddParameter(strParameterValue:=strSingleFactor)
        '        clsRFacetFunction.AddParameter("dir", Chr(34) & "h" & Chr(34))
        '        SetFixRowColumnParameter()
        '        'As there are only a left and a right parameter for clsTempOp, no need to specify a parameter name, the default "right" will be used.
        '        'The boolean argument "false" is there to indicate we don't want quotes.
        '    ElseIf rdoVertical.Checked AndAlso ((Not ucrChkMargin.Checked AndAlso Not ucrChkFreeSpace.Checked) OrElse ucrChkNoOfRowsOrColumns.Checked) Then
        '        clsRFacetFunction.SetRCommand("facet_wrap")
        '        clsTempOp.AddParameter(iPosition:=0, strParameterValue:="")
        '        clsTempOp.AddParameter(strParameterValue:=strSingleFactor)
        '        clsRFacetFunction.AddParameter("dir", Chr(34) & "v" & Chr(34))
        '        SetFixRowColumnParameter()
        '    Else
        '        'Warning: could be refined a little...
        '        RemoveWrapParameters()
        '        clsRFacetFunction.SetRCommand("facet_grid")
        '        clsTempOp.AddParameter(strParameterValue:=".")
        '        clsTempOp.AddParameter(iPosition:=0, strParameterValue:=strSingleFactor)
        '        If rdoHorizontal.Checked Then
        '            clsTempOp.AddParameter(strParameterValue:=ucr1stFactorReceiver.GetVariableNames(False))
        '            clsTempOp.AddParameter(iPosition:=0, strParameterValue:=".")
        '        ElseIf rdoVertical.Checked Then
        '            clsTempOp.AddParameter(iPosition:=0, strParameterValue:=ucr1stFactorReceiver.GetVariableNames(False))
        '            clsTempOp.AddParameter(strParameterValue:=".")
        '        End If
        '    End If
        '    clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)

        'ElseIf Not ucr1stFactorReceiver.IsEmpty() AndAlso Not ucr2ndFactorReceiver.IsEmpty() Then
        '    clsRFacetFunction.SetRCommand("facet_grid")
        '    RemoveWrapParameters()
        '    If rdoHorizontal.Checked Then
        '        clsTempOp.AddParameter(strParameterValue:=ucr1stFactorReceiver.GetVariableNames(False))
        '        clsTempOp.AddParameter(iPosition:=0, strParameterValue:=ucr2ndFactorReceiver.GetVariableNames(False))
        '    ElseIf rdoVertical.Checked Then
        '        clsTempOp.AddParameter(iPosition:=0, strParameterValue:=ucr1stFactorReceiver.GetVariableNames(False))
        '        clsTempOp.AddParameter(strParameterValue:=ucr2ndFactorReceiver.GetVariableNames(False))
        '    End If
        '    clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)
        'Else
        '    clsRFacetFunction.RemoveParameterByName("facets")
        'End If
    End Sub

    Private Sub RemoveWrapParameters()
        'This sub is called when the clsRFacet function's RCommand is changed from wrap to grid to remove the parameters that are only relevant in the wrap case.
        'clsRFacetFunction.RemoveParameterByName("dir")
        'clsRFacetFunction.RemoveParameterByName("ncol")
        'clsRFacetFunction.RemoveParameterByName("nrow")
    End Sub

    Private Sub SetFixRowColumnParameter()
        'This sub is called in the wrap case to set up the parameter fixing the number of rows or columns when working in the horizontal or vertical case.
        'If ucrChkNoOfRowsOrColumns.Checked Then
        '    If rdoHorizontal.Checked Then
        '        clsRFacetFunction.AddParameter("nrow", ucrNudNumberofRows.Value)
        '        clsRFacetFunction.RemoveParameterByName("ncol")
        '    Else
        '        clsRFacetFunction.RemoveParameterByName("nrow")
        '        clsRFacetFunction.AddParameter("ncol", ucrNudNumberofRows.Value)
        '    End If
        'Else
        '    clsRFacetFunction.RemoveParameterByName("ncol")
        '    clsRFacetFunction.RemoveParameterByName("nrow")
        'End If
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

    Private Sub ucrChkMargin_CheckedChanged() Handles ucrChkMargin.ControlValueChanged
        'If ucrChkMargin.Checked Then
        '    clsRFacetFunction.AddParameter("margins", "TRUE")
        'Else
        '    clsRFacetFunction.RemoveParameterByName("margins")
        'End If
        ' FacetsNumberOfRowsOrColumns()
        'SetFacets()
    End Sub

    Private Sub ucrChkFreeSpace_CheckedChanged() Handles ucrChkFreeSpace.ControlValueChanged
        SetFacetParameters()
    End Sub

    'Question to be discussed/Task: This is the kind of subs that could go into a SetupPlotOptions procedure... also only called in two specific plots and not in the others ... Why ? (to be explored)
    Public Sub SetGgplotFunction(clsGgplotFunc As RFunction)
        'When the link for clsRggplotFunction has been changed, the ucrAdditionalLayers GgplotFunction needs to be updated.
        clsRggplotFunction = clsGgplotFunc
        ucrPlotsAdditionalLayers.SetGGplotFunction(clsRggplotFunction)
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
            If Not ucrInputGraphTitle.IsEmpty() OrElse Not ucrInputGraphSubTitle.IsEmpty() OrElse Not ucrInputGraphCaption.IsEmpty() Then
                clsBaseOperator.AddParameter("labs", clsRFunctionParameter:=clsLabsFunction)
            Else
                clsBaseOperator.RemoveParameterByName("labs")
            End If
        End If
    End Sub

    Private Sub LabsControls_ControlValueChanged() Handles ucrInputGraphTitle.ControlValueChanged, ucrInputGraphSubTitle.ControlValueChanged, ucrInputGraphCaption.ControlValueChanged
        AddRemoveLabs()
    End Sub

    Private Sub ucrChkNoOfRowsOrColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNoOfRowsOrColumns.ControlValueChanged
        SetFacetParameters()
    End Sub

    Private Function GetAxisType(bIsX As Boolean) As String
        Dim strAes As String

        If bIsX Then
            strAes = "x"
        Else
            strAes = "y"
        End If
        If clsGlobalAesFunction IsNot Nothing Then
            If clsGlobalAesFunction.ContainsParameter(strAes) AndAlso clsGlobalAesFunction.GetParameter(strAes).strArgumentValue <> Chr(34) & Chr(34) Then
                'Run R code to determine type
                'Temp default to continuous
                Return "Continuous"
            Else
                'When aes not present discrete scale function works
                Return "Discrete"
            End If
        Else
            Return "Discrete"
        End If
    End Function

    Private Sub cmdAllOptions_Click(sender As Object, e As EventArgs) Handles cmdAllOptions.Click
        sdgThemes.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, bReset:=bResetThemes)
        Me.SendToBack()
        sdgThemes.ShowDialog()
        bResetThemes = False
    End Sub
    'Warning/Task to be discussed: need to disable ok on dlg's when layers are not complete on subdialogues + warning message... 
    'Warning: actually this will be very hard to implement until the global aes, set from the main layer are properly communicated to plots. Global aes might fill in missing mandatory aes...
End Class