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
Public Class sdgPlots
    'Question to be discussed (later: need to explore first)/Exploration Task: In order to uniformise the code, could create a PlotOptionsSetup where all the necessary links between specific plots and plot options are made ? For the moment all these are scattered around. Might be necessary to have this flexibility though... 
    'Question to be discussed (later)/Exploration Task: Why do we have RSyntax given through here and not in the LayerOptions dialog ? Would it be easier to just give through the RSyntax everywhere, and locally extract/edit the necessary info in the different sdg's, ucr's ?  Sort of like it is done here ? As far as I understand, there is no clear attitude concerning what is shared, what is carried through, where, using what method. Maybe if we uniformise, choose a coherent attitiude, it will be easier to edit things, avoid bugs, add on functionalities...
    'Question to be discussed: Maybe there is a need for a more radical change: create a clsGgplot that would be carried through all graphics components and contain all the well organised ggplot necessary info, about different Layers, different parameters, theme, ... Then in the main dlg's initiating plots, there would be a method that interprets the info in clsGgplot inside the RSyntax. Big project, don't know if it's worth it, but could make things cleaner, easier to work with ? Maybe need a more detailed sketch of how this would be implemented before making decision whether it's worth the time investment or not...
    'Reaction to question/Task/more questions: Alternatively the RSyntax is already sort of playing this role. So maybe facilitating the access to the information stored inthe Rsyntax instead ? (Would consist in just writing a few methods ?) Then cleaning the material that is carried through to different graphics components editors by essentially sending the RSyntax ? But extracting deep info is probably combersome to do several times... Which is why there are these clsGgplotFunction, clsAesFunction ... ? Need to create a diagram of what is shared by whom, how and for what purpose in order to clarify best strategy...
    'Task: write an issue/proposal about this when ideas are a bit clearer.
    Public clsRsyntax As New RSyntax
    'This clsRSyntax is linked with the ucrBase.clsRSyntax from the dlg calling sdgPLotOptions...
    Public clsRggplotFunction As New RFunction
    Public clsAesFunction As New RFunction    'Warning: I m not sure this field is useful... Will all be revised when changing links though...

    Public clsLabsFunction As New RFunction
    Public clsXLabTitleFunction As New RFunction

    Public clsRFacetFunction As New RFunction
    Public clsXLabFunction As New RFunction
    Public clsYLabFunction As New RFunction
    Public clsBaseOperator As New ROperator

    Private bControlsInitialised As Boolean = False
    'All the previous RFunctions will eventually be stored as parameters (or parameters of parameters) within the RSyntax building the big Ggplot command "ggplot(...) + geom_..(..) + ... + theme(...) + scales(...) ..."
    'They are treated separately from the RSyntax for the sake of clarity, then sinked in eventually.
    Public bFirstLoad As Boolean = True
    Public strDataFrame As String
    Private bAdditionalLayersSetGlobal As Boolean
    Private clsTempOp As New ROperator
    Private strSingleFactor As String
    Private strSecondvariable As String

    'See bLayersDefaultIsGolobal below.
    Private Sub sdgPlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If bFirstLoad Then
        '    InitialiseDialog()
        '    SetDefaults()
        '    bFirstLoad = False
        'End If
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctThemes As New Dictionary(Of String, String)
        Dim strThemes As String()

        'facets tab 
        'Links the factor receivers, used for creating facets, with the selector. The variables need to be factors.
        ucr1stFactorReceiver.Selector = ucrFacetSelector
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.SetMeAsReceiver()
        ucr1stFactorReceiver.SetParameter(New RParameter("var1", 0))
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFactor1)

        ucr2ndFactorReceiver.Selector = ucrFacetSelector
        ucr2ndFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr2ndFactorReceiver.SetParameter(New RParameter("var2", 1))
        ucr2ndFactorReceiver.SetParameterIsString()
        ucr2ndFactorReceiver.bWithQuotes = False
        ucr2ndFactorReceiver.SetLinkedDisplayControl(lblFactor2)

        ucrChkIncludeFacets.SetText("Include Facets")
        ucrChkIncludeFacets.AddParameterPresentCondition(True, "facets", True)
        ucrChkIncludeFacets.AddParameterPresentCondition(False, "facets", False)

        ucrChkMargin.SetText("Margins")
        ucrChkMargin.SetParameter(New RParameter("margins"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True)
        ucrChkMargin.SetRDefault("FALSE")
        ucrChkMargin.AddToLinkedControls(ucrChkNoOfRowsOrColumns, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=False)

        ucrChkNoOfRowsOrColumns.AddFunctionNamesCondition(True, "facet_wrap", True)
        ucrChkNoOfRowsOrColumns.AddFunctionNamesCondition(False, "facet_wrap", False)
        ucrChkNoOfRowsOrColumns.SetText("Fixed Number of Rows")
        ucrChkNoOfRowsOrColumns.AddToLinkedControls(ucrNudNumberofRows, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkFreeScalesX.SetText("Free Scales X")
        ucrChkFreeScalesX.SetParameter(New RParameter("free_x"))

        ucrChkFreeScalesY.SetText("Free Scales Y")
        ucrChkFreeScalesY.SetParameter(New RParameter("free_y"))

        ucrNudNumberofRows.SetParameter(New RParameter("nrow"))

        'this passes in parameter only if margin is checked. 
        'should be visible when margin is checked
        ucrChkFreeSpace.SetText("Free Space")
        ucrChkFreeSpace.SetParameter(New RParameter("space"))
        ucrChkFreeSpace.AddFunctionNamesCondition(True, "facet_grid")
        ucrChkFreeSpace.SetValueIfChecked(Chr(34) & "free" & Chr(34))
        ucrChkFreeSpace.AddToLinkedControls(ucrChkNoOfRowsOrColumns, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=False)

        ucrPnlHorizonatalVertical.SetParameter(New RParameter("dir"))
        ucrPnlHorizonatalVertical.AddRadioButton(rdoVertical, Chr(34) & "v" & Chr(34))
        ucrPnlHorizonatalVertical.AddRadioButton(rdoHorizontal, Chr(34) & "h" & Chr(34))
        ucrPnlHorizonatalVertical.SetRDefault(Chr(34) & "h" & Chr(34))

        ucrChkIncludeFacets.AddToLinkedControls(ucrFacetSelector, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucr1stFactorReceiver, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucr2ndFactorReceiver, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucrPnlHorizonatalVertical, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoVertical)
        ucrChkIncludeFacets.AddToLinkedControls(ucrChkMargin, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucrChkFreeScalesX, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucrChkFreeScalesY, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucrChkFreeSpace, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludeFacets.AddToLinkedControls(ucrChkNoOfRowsOrColumns, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

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


        'Y Axis tab

        'themes tab
        ucrInputThemes.SetParameter(New RParameter("theme"))
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

        'Corodiantes tab
        InitialiseTabs()
        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewOperator As ROperator, Optional clsNewLabsFunction As RFunction = Nothing, Optional clsNewXLabsTitleFunction As RFunction = Nothing, Optional clsNewRFacetFunction As RFunction = Nothing, Optional clsNewThemeParam As RParameter = Nothing, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        ucrXAxis.SetRCodeForXorY(True)
        clsBaseOperator = clsNewOperator
        If clsNewLabsFunction IsNot Nothing Then
            clsLabsFunction = clsNewLabsFunction
        Else
            clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        End If

        If clsNewXLabsTitleFunction IsNot Nothing Then
            clsXLabTitleFunction = clsNewXLabsTitleFunction
        Else
            clsLabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        End If

        If clsNewThemeParam IsNot Nothing Then
            clsBaseOperator.AddParameter(clsNewThemeParam)
        Else
            clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultTheme.Clone())
        End If
        'clsRFacetFunction = clsNewRFacetFunction
        ucrInputGraphTitle.SetRCode(clsLabsFunction, bReset)
        ucrInputGraphSubTitle.SetRCode(clsLabsFunction, bReset)
        ucrInputGraphCaption.SetRCode(clsLabsFunction, bReset)
        ucrInputThemes.SetRCode(clsBaseOperator)

        'ucrInputLegend.SetRCode(clsNewLabsFunction, bReset)
        ucrPnlHorizonatalVertical.SetRCode(clsRFacetFunction, bReset)
        ucr1stFactorReceiver.SetRCode(clsTempOp, bReset)
        ucr2ndFactorReceiver.SetRCode(clsTempOp, bReset)
        ucrChkMargin.SetRCode(clsRFacetFunction, bReset)
        ucrChkFreeSpace.SetRCode(clsRFacetFunction, bReset)
        ucrChkFreeScalesX.SetRCode(clsRFacetFunction, bReset)
        ucrChkFreeScalesY.SetRCode(clsRFacetFunction, bReset)
        ucrNudNumberofRows.SetRCode(clsRFacetFunction, bReset)
        ucrChkIncludeFacets.SetRCode(clsBaseOperator, bReset)
        AddRemoveLabs()


        tbpXAxis.Enabled = False
        tbpYAxis.Enabled = False
        tbpFacet.Enabled = False
        tbpLayers.Enabled = False
        tbpCoordinates.Enabled = False

    End Sub

    Private Sub SetFacetParameterFunctions()
        clsTempOp.SetOperation("~")
        'Depending on the settings on the dialog, this function sets the Facets command, stored within clsRFacetFunction.
        'Then IncludeFacetsParameter() will add the facets command to the ggplot script as a parameter within RSyntax (unless no factor has been for fasceting, as R requires at least one facets argument).
        'The choice between grid and wrap is done systematically depending on the chosen settings.

        'The following two parameters (of the facet function) will be reset in this sub according to the settings selected on the dialog. They need to be cleared in case they are not relevant anymore for example if margins has been checked (they are specific to facet_wrap).
        'clsRFacetFunction.RemoveParameterByName("nrow")
        'clsRFacetFunction.RemoveParameterByName("ncol")
        If (Not ucr1stFactorReceiver.IsEmpty() AndAlso ucr2ndFactorReceiver.IsEmpty()) Then
            'There are two types of fasceting provided by ggplot2: grid and wrap. Grid works like a contigency table, wrap just rearranges a long list of plots into a grid. 
            'If two receivers are filled, only grid can be used. In case only one receiver is filled, grid will still be in use if one of the grid parameters is set such as "margins" or "free space". In other cases, wrap will be used.
            'In the grid case, the place of the argument, left or right, in the facets parameter of the facets function is determined by/determines the choice "vertical" or "horizontal" faceting. In the wrap case, the argument "dir" is set to vertical or horizontal accordingly.
            strSingleFactor = ucr1stFactorReceiver.GetVariableNames(False)
            If rdoHorizontal.Checked AndAlso ((Not ucrChkMargin.Checked AndAlso Not ucrChkFreeSpace.Checked) OrElse ucrChkNoOfRowsOrColumns.Checked) Then
                clsRFacetFunction.SetRCommand("facet_wrap")
                clsTempOp.RemoveParameterByName("sn")
                'clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)
                clsTempOp.AddParameter(iPosition:=0, strParameterValue:=strSingleFactor)
                ' clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp, iPosition:=0)

                'As there are only a left and a right parameter for clsTempOp, no need to specify a parameter name, the default "right" will be used.
                'The boolean argument "false" is there to indicate we don't want quotes.
            ElseIf (rdoVertical.Checked AndAlso ((Not ucrChkMargin.Checked AndAlso Not ucrChkFreeSpace.Checked)) OrElse ucrChkNoOfRowsOrColumns.Checked) Then
                clsRFacetFunction.SetRCommand("facet_wrap")
                clsTempOp.AddParameter("sn", iPosition:=0, strParameterValue:="", bIncludeArgumentName:=False)
                ' clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp, iPosition:=0)
                'clsTempOp.AddParameter("sn", strParameterValue:=strSingleFactor)
            Else
                'Warning: could be refined a little...
                clsRFacetFunction.SetRCommand("facet_grid")
                clsTempOp.AddParameter("sn", iPosition:=1, strParameterValue:=".", bIncludeArgumentName:=False)
                ' clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp, iPosition:=1)
            End If
            clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)

        ElseIf Not ucr1stFactorReceiver.IsEmpty() AndAlso Not ucr2ndFactorReceiver.IsEmpty() Then
            clsRFacetFunction.SetRCommand("facet_grid")
            clsTempOp.RemoveParameterByName("sn")
            clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp, iPosition:=1)
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

    Public Sub Reset()
        SetDefaults()
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
    Private Sub InitialiseTabs()
        'Question: Tabs are set in turn as selected, using their index. Then the first tab is set as selected again. For some reason this initialises the tabs ?
        For i = 0 To tbpPlotsOptions.TabCount - 1
            tbpPlotsOptions.SelectedIndex = i
        Next
        tbpPlotsOptions.TabPages(6).Enabled = False
        tbpPlotsOptions.SelectedIndex = 0
    End Sub

    Private Sub IncludeFacets()
        'If the user wants facets, the facets options need to be shown, otherwise hide them.
        If ucrChkIncludeFacets.Checked Then
            'In case IncludeFacets is checked, the facets need to be set. Still might not be included as RSyntax parameter if no no variable has been set for faceting, but this is then decided in the IncludeFacetsParameter below.
            'SetFacets()
            ' SecondFactorReceiverEnabled()

        Else

        End If
        'Then the RSyntax is populated with the appropriate facet parameter (as part of the whole ggplot script) or not.
        ' IncludeFacetsParameter()
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

    Private Sub IncludeFacetsParameter()
        'If ucrChkIncludeFacets.Checked AndAlso Not ucr1stFactorReceiver.IsEmpty() Then
        '    clsRsyntax.AddOperatorParameter("facet", clsRFunc:=clsRFacetFunction)
        'Else
        '    clsRsyntax.RemoveOperatorParameter("facet")
        'End If
    End Sub

    Private Sub ucrChkIncludeFacets_CheckedChanged() Handles ucrChkIncludeFacets.ControlValueChanged
        '  IncludeFacets()
        ' FacetsNumberOfRowsOrColumns()
    End Sub

    Private Sub SetScaleOption()
        'This sub is setting the right scale parameter in the clsRFacetFunctions, according to the scale chk boxes. 
        'It only needs to be called when these are modified, as this parameter is common to both facets_grid and facets_wrap. Although graphics on the same row or column in facets_grid share the y or x axis respectively. Still different rows might benefit from having different y-axis scales for instance.
        'Warning: ggplot allows the extra parameter "space" in the facet_grid case. That one takes as values "free" or "fixed" (with quotes). It determines whether the size of rows and columns should adapt to the range of the scale.
        If ucrChkFreeScalesX.Checked AndAlso ucrChkFreeScalesY.Checked Then
            clsRFacetFunction.AddParameter("scales", Chr(34) & "free" & Chr(34))
        ElseIf ucrChkFreeScalesX.Checked AndAlso Not ucrChkFreeScalesY.Checked Then
            clsRFacetFunction.AddParameter("scales", Chr(34) & "free_x" & Chr(34))
        ElseIf Not ucrChkFreeScalesX.Checked AndAlso ucrChkFreeScalesY.Checked Then
            clsRFacetFunction.AddParameter("scales", Chr(34) & "free_y" & Chr(34))
        Else
            clsRFacetFunction.AddParameter("scales", Chr(34) & "free_y" & Chr(34))
        End If
    End Sub

    Private Sub chkScales_CheckedChanged() Handles ucrChkFreeScalesX.ControlValueChanged, ucrChkFreeScalesY.ControlValueChanged
        SetScaleOption()
        '    SetFacets()
    End Sub
    Private Sub FacetsNumberOfRowsOrColumns()
        'This sub decides whether the option to fix the number of rows or columns should be available or not.
        'When ucrChkMargin is checked, or when both receivers are used (i.e. the second optional is filled), facet_grid is used, and thus the number of rows or columns can't be fixed.
        ' If ucrChkIncludeFacets.Checked Then
        '    If (ucrChkMargin.Checked OrElse ucrChkFreeSpace.Checked OrElse (Not ucr2ndFactorReceiver.IsEmpty)) Then
        '        ucrChkNoOfRowsOrColumns.Checked = False
        '        ucrChkNoOfRowsOrColumns.Visible = False
        '        ucrNudNumberofRows.Visible = False
        '    Else
        '        ucrChkNoOfRowsOrColumns.Visible = True
        '        ucrNudNumberofRows.Visible = ucrChkNoOfRowsOrColumns.Checked
        '    End If
        'End If
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged() Handles ucr1stFactorReceiver.ControlValueChanged, ucr2ndFactorReceiver.ControlValueChanged
        'SetFacets()
        'IncludeFacetsParameter()
        SecondFactorReceiverEnabled()
        SetFacetParameterFunctions()
    End Sub

    Private Sub SecondFactorReceiverEnabled()
        If ucr1stFactorReceiver.IsEmpty() Then
            ucr2ndFactorReceiver.Enabled = False
        Else ucr2ndFactorReceiver.Enabled = True
        End If
    End Sub

    Private Sub ucr2ndFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucr2ndFactorReceiver.SelectionChanged
        'FacetsNumberOfRowsOrColumns()
        'SetFacets()
    End Sub

    Private Sub ucrPnlHorizonatalVertical_ControlValueChanged() Handles ucrPnlHorizonatalVertical.ControlValueChanged, ucrChkMargin.ControlValueChanged, ucrChkFreeSpace.ControlValueChanged, ucrChkNoOfRowsOrColumns.ControlValueChanged
        If rdoHorizontal.Checked Then
            ucrChkNoOfRowsOrColumns.SetText("Fixed Number of Rows")
        ElseIf rdoVertical.Checked Then
            ucrChkNoOfRowsOrColumns.SetText("Fixed Number of Columns")
        End If
        SetFacetParameterFunctions()
    End Sub

    Private Sub ucrChkNoOfRowsOrColumns_CheckedChanged() Handles ucrChkNoOfRowsOrColumns.ControlValueChanged
        'SetFacets()
    End Sub

    Private Sub nudNumberofRows_TextChanged(sender As Object, e As EventArgs)
        'SetFacets()
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
        'If ucrChkMargin.Checked Then
        '    clsRFacetFunction.AddParameter("space", Chr(34) & "free" & Chr(34))
        'Else
        '    clsRFacetFunction.RemoveParameterByName("space")
        'End If
        'FacetsNumberOfRowsOrColumns()
        'SetFacets()
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

    Public Sub SetRSyntax(clsRSyntaxIn As RSyntax)
        'When the link for RSyntax has been changed, the ucrAdditionalLayers RSyntax needs to be updated.
        'clsRsyntax = clsRSyntaxIn
        'ucrPlotsAdditionalLayers.SetRSyntax(clsRsyntax)
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

    Private Sub ucrInputLegend_NameChanged() Handles ucrInputLegend.NameChanged
        '    If rdoLegendTitleCustom.Checked AndAlso (Not ucrInputLegend.IsEmpty()) Then


        '        clsRsyntax.AddOperatorParameter("labs", clsRFunc:=clsLegendFunction)
        '    ElseIf rdoLegendTitleAuto.Checked Then
        '        clsRsyntax.RemoveOperatorParameter("labs")
        '    End If
    End Sub

    Private Sub AddRemoveLabs()
        If Not ucrInputGraphTitle.IsEmpty() OrElse (Not ucrInputGraphSubTitle.IsEmpty() OrElse Not ucrInputGraphCaption.IsEmpty()) Then
            clsBaseOperator.AddParameter("labs", clsRFunctionParameter:=clsLabsFunction)
        Else
            clsBaseOperator.RemoveParameterByName("labs")
        End If
    End Sub

    Private Sub ucrInputGraphTitle_ControlValueChanged() Handles ucrInputGraphTitle.ControlValueChanged, ucrInputGraphSubTitle.ControlValueChanged, ucrInputGraphCaption.ControlValueChanged
        AddRemoveLabs()
    End Sub


    'Warning/Task to be discussed: need to disable ok on dlg's when layers are not complete on subdialogues + warning message... 
    'Warning: actually this will be very hard to implement until the global aes, set from the main layer are properly communicated to plots. Global aes might fill in missing mandatory aes...
End Class