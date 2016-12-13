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
    Public clsAesFunction As New RFunction 'Warning: I m not sure this field is useful... Will all be revised when changing links though...
    Public clsRFacetFunction As New RFunction
    Public clsXLabFunction As New RFunction
    Public clsYLabFunction As New RFunction
    Public clsRThemeFunction As New RFunction
    Public clsRLegendFunction As New RFunction
    Public clsGraphTitleFunction As New RFunction
    Public clsLegendFunction As New RFunction
    'All the previous RFunctions will eventually be stored as parameters (or parameters of parameters) within the RSyntax building the big Ggplot command "ggplot(...) + geom_..(..) + ... + theme(...) + scales(...) ..."
    'They are treated separately from the RSyntax for the sake of clarity, then sinked in eventually.
    Public bFirstLoad As Boolean = True
    Public strDataFrame As String
    Private bAdditionalLayersSetGlobal As Boolean
    'See bLayersDefaultIsGolobal below.
    Private Sub sdgPlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Public Sub DisableLayersTab()
        tabLayers.Enabled = False
    End Sub

    Public Sub EnableLayersTab()
        tabLayers.Enabled = True
    End Sub
    Public Sub SetDefaults()
        TitleDefaults()
        chkIncludeFacets.Checked = False
        IncludeFacets()
        nudNoOfRowsOrColumns.Value = 1
        ucrFacetSelector.Reset()

        ucr1stFactorReceiver.SetMeAsReceiver()
        ucrInputGraphTitle.SetName("")
        ucrPlotsAdditionalLayers.Reset()
        'Note that the following two don't reset the bisX and RSyntaxAxis ... So no need to set these again.
        ucrXAxis.Reset()
        ucrYAxis.Reset()
        ucrInputThemes.SetName("theme_grey")
        rdoLegendTitleAuto.Checked = True
        LegendDefaults()
        bLayersDefaultIsGlobal = False

    End Sub

    Private Sub TitleDefaults()
        chkDisplayLegendTitle.Checked = True
        chkOverwriteLegendTitle.Checked = False
        ucrInputLegend.Visible = False
        ucrInputGraphTitle.Reset()
    End Sub

    Public Sub Reset()
        SetDefaults()
    End Sub

    Private Sub InitialiseDialog()
        InitialiseTabs()
        CreateThemes()
        FacetsReceiversSetup()
        'The following sets up the clsGgplotAesFunction in ucrAdditionalLayers. Not sure this should happen in the initialise dialog... Not sure of the objective either... It is never linked to the main dlg anyway...
        ucrPlotsAdditionalLayers.SetAesFunction(clsAesFunction)
        'The following two setup the ucrAdditionalLayers on the sdgPlots. Shares the global ggplot function, as well as the whole PLots RSyntax.
        ucrPlotsAdditionalLayers.SetGGplotFunction(clsRggplotFunction)
        ucrPlotsAdditionalLayers.SetRSyntax(clsRsyntax)
        'This is necessary to make sure the minimum number of fixed rows or columns is 1.
        nudNoOfRowsOrColumns.Minimum = 1

        'Set's the X Axis tab to X mode and the YAxis tab to Y mode (each tab contains a generic ucrAxis with internal X or Y boolean setting).
        'Also carry the RSyntax through to these ucr's .
        ucrXAxis.SetXorY(True)
        ucrXAxis.SetRsyntaxAxis(clsRsyntax)
        ucrYAxis.SetXorY(False)
        ucrYAxis.SetRsyntaxAxis(clsRsyntax)
    End Sub
    Private Sub InitialiseTabs()
        'Question: Tabs are set in turn as selected, using their index. Then the first tab is set as selected again. For some reason this initialises the tabs ?
        For i = 0 To tabctrlBoxSubdialog.TabCount - 1
            tabctrlBoxSubdialog.SelectedIndex = i
        Next
        tabctrlBoxSubdialog.TabPages(6).Enabled = False
        tabctrlBoxSubdialog.SelectedIndex = 0
    End Sub

    Private Sub CreateThemes()
        'Adds the available themes in the relevant "Themes combo box".
        Dim strThemes() As String
        strThemes = {"theme_bw", "theme_linedraw", "theme_light", "theme_minimal", "theme_classic", "theme_dark", "theme_void", "theme_base", "theme_calc", "theme_economist", "theme_few", "theme_fivethirtyeight", "theme_foundation", "theme_grey", "theme_gdocs", "theme_igray", "theme_map", "theme_par", "theme_solarized", "theme_hc", "theme_pander", "theme_solid", "theme_stata", "theme_tufte", "theme_wsj"}
        Array.Sort(strThemes)
        ucrInputThemes.SetItems(strThemes)
        'Task: Need to implement theme options. The "All Options" button is temporarily disabled.
        cmdAllOptions.Enabled = False
    End Sub
    Private Sub FacetsReceiversSetup()
        'Links the factor receivers, used for creating facets, with the selector. The variables need to be factors.
        ucr1stFactorReceiver.Selector = ucrFacetSelector
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr2ndFactorReceiver.Selector = ucrFacetSelector
        ucr2ndFactorReceiver.SetIncludedDataTypes({"factor"})
    End Sub

    Private Sub IncludeFacets()
        'If the user wants facets, the facets options need to be shown, otherwise hide them.
        If chkIncludeFacets.Checked Then
            ucrFacetSelector.Visible = True
            ucr1stFactorReceiver.Visible = True
            ucr2ndFactorReceiver.Visible = True
            lblFactor1.Visible = True
            lblFactor2.Visible = True
            rdoHorizontal.Visible = True
            rdoHorizontal.Checked = True
            rdoVertical.Visible = True
            chkNoOfRowsOrColumns.Checked = False
            nudNoOfRowsOrColumns.Visible = True
            chkMargin.Checked = False
            chkFreeScalesX.Checked = False
            chkFreeScalesY.Checked = False
            chkFreeSpace.Checked = False
            chkMargin.Visible = True
            chkFreeScalesX.Visible = True
            chkFreeScalesY.Visible = True
            chkFreeSpace.Visible = True
            'In case IncludeFacets is checked, the facets need to be set. Still might not be included as RSyntax parameter if no no variable has been set for faceting, but this is then decided in the IncludeFacetsParameter below.
            SetFacets()
            SecondFactorReceiverEnabled()
        Else
            ucrFacetSelector.Visible = False
            ucr1stFactorReceiver.Visible = False
            ucr2ndFactorReceiver.Visible = False
            lblFactor1.Visible = False
            lblFactor2.Visible = False
            rdoHorizontal.Visible = False
            rdoVertical.Visible = False
            chkMargin.Visible = False
            chkFreeScalesX.Visible = False
            chkFreeScalesY.Visible = False
            chkNoOfRowsOrColumns.Visible = False
            nudNoOfRowsOrColumns.Visible = False
            chkFreeSpace.Visible = False
        End If
        'Then the RSyntax is populated with the appropriate facet parameter (as part of the whole ggplot script) or not.
        IncludeFacetsParameter()
    End Sub

    Private Sub SetFacets()
        'Depending on the settings on the dialog, this function sets the Facets command, stored within clsRFacetFunction.
        'Then IncludeFacetsParameter() will add the facets command to the ggplot script as a parameter within RSyntax (unless no factor has been for fasceting, as R requires at least one facets argument).
        'The choice between grid and wrap is done systematically depending on the chosen settings.
        Dim clsTempOp As New ROperator
        Dim strSingleFactor As String
        clsTempOp.SetOperation("~")
        'The following two parameters (of the facet function) will be reset in this sub according to the settings selected on the dialog. They need to be cleared in case they are not relevant anymore for example if margins has been checked (they are specific to facet_wrap).
        clsRFacetFunction.RemoveParameterByName("nrow")
        clsRFacetFunction.RemoveParameterByName("ncol")

        If (Not ucr1stFactorReceiver.IsEmpty() AndAlso ucr2ndFactorReceiver.IsEmpty()) Then

            strSingleFactor = ucr1stFactorReceiver.GetVariableNames(False)

            'There are two types of fasceting provided by ggplot2: grid and wrap. Grid works like a contigency table, wrap just rearranges a long list of plots into a grid. 
            'If two receivers are filled, only grid can be used. In case only one receiver is filled, grid will still be in use if one of the grid parameters is set such as "margins" or "free space". In other cases, wrap will be used.
            'In the grid case, the place of the argument, left or right, in the facets parameter of the facets function is determined by/determines the choice "vertical" or "horizontal" faceting. In the wrap case, the argument "dir" is set to vertical or horizontal accordingly.
            If rdoHorizontal.Checked AndAlso ((Not chkMargin.Checked AndAlso Not chkFreeSpace.Checked) OrElse chkNoOfRowsOrColumns.Checked) Then
                clsRFacetFunction.SetRCommand("facet_wrap")
                clsTempOp.AddParameter(iPosition:=0, strParameterValue:="")
                clsTempOp.AddParameter(strParameterValue:=strSingleFactor)
                clsRFacetFunction.AddParameter("dir", Chr(34) & "h" & Chr(34))
                SetFixRowColumnParameter()
                'As there are only a left and a right parameter for clsTempOp, no need to specify a parameter name, the default "right" will be used.
                'The boolean argument "false" is there to indicate we don't want quotes.
            ElseIf rdoVertical.Checked AndAlso ((Not chkMargin.Checked AndAlso Not chkFreeSpace.Checked) OrElse chkNoOfRowsOrColumns.Checked) Then
                clsRFacetFunction.SetRCommand("facet_wrap")
                clsTempOp.AddParameter(iPosition:=0, strParameterValue:="")
                clsTempOp.AddParameter(strParameterValue:=strSingleFactor)
                clsRFacetFunction.AddParameter("dir", Chr(34) & "v" & Chr(34))
                SetFixRowColumnParameter()
            Else
                'Warning: could be refined a little...
                RemoveWrapParameters()
                clsRFacetFunction.SetRCommand("facet_grid")
                clsTempOp.AddParameter(strParameterValue:=".")
                clsTempOp.AddParameter(iPosition:=0, strParameterValue:=strSingleFactor)
                If rdoHorizontal.Checked Then
                    clsTempOp.AddParameter(strParameterValue:=ucr1stFactorReceiver.GetVariableNames(False))
                    clsTempOp.AddParameter(iPosition:=0, strParameterValue:=".")
                ElseIf rdoVertical.Checked Then
                    clsTempOp.AddParameter(iPosition:=0, strParameterValue:=ucr1stFactorReceiver.GetVariableNames(False))
                    clsTempOp.AddParameter(strParameterValue:=".")
                End If
            End If
            clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)

        ElseIf Not ucr1stFactorReceiver.IsEmpty() AndAlso Not ucr2ndFactorReceiver.IsEmpty() Then
            clsRFacetFunction.SetRCommand("facet_grid")
            RemoveWrapParameters()
            If rdoHorizontal.Checked Then
                clsTempOp.AddParameter(strParameterValue:=ucr1stFactorReceiver.GetVariableNames(False))
                clsTempOp.AddParameter(iPosition:=0, strParameterValue:=ucr2ndFactorReceiver.GetVariableNames(False))
            ElseIf rdoVertical.Checked Then
                clsTempOp.AddParameter(iPosition:=0, strParameterValue:=ucr1stFactorReceiver.GetVariableNames(False))
                clsTempOp.AddParameter(strParameterValue:=ucr2ndFactorReceiver.GetVariableNames(False))
            End If
            clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)
        Else
            clsRFacetFunction.RemoveParameterByName("facets")
        End If
    End Sub

    Private Sub RemoveWrapParameters()
        'This sub is called when the clsRFacet function's RCommand is changed from wrap to grid to remove the parameters that are only relevant in the wrap case.
        clsRFacetFunction.RemoveParameterByName("dir")
        clsRFacetFunction.RemoveParameterByName("ncol")
        clsRFacetFunction.RemoveParameterByName("nrow")
    End Sub

    Private Sub SetFixRowColumnParameter()
        'This sub is called in the wrap case to set up the parameter fixing the number of rows or columns when working in the horizontal or vertical case.
        If chkNoOfRowsOrColumns.Checked Then
            If rdoHorizontal.Checked Then
                clsRFacetFunction.AddParameter("nrow", nudNoOfRowsOrColumns.Value)
                clsRFacetFunction.RemoveParameterByName("ncol")
            Else
                clsRFacetFunction.RemoveParameterByName("nrow")
                clsRFacetFunction.AddParameter("ncol", nudNoOfRowsOrColumns.Value)
            End If
        Else
            clsRFacetFunction.RemoveParameterByName("ncol")
            clsRFacetFunction.RemoveParameterByName("nrow")
        End If
    End Sub

    Private Sub IncludeFacetsParameter()
        If chkIncludeFacets.Checked AndAlso Not ucr1stFactorReceiver.IsEmpty() Then
            clsRsyntax.AddOperatorParameter("facet", clsRFunc:=clsRFacetFunction)
        Else
            clsRsyntax.RemoveOperatorParameter("facet")
        End If
    End Sub
    Private Sub chkIncludeFacets_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeFacets.CheckedChanged
        IncludeFacets()
        FacetsNumberOfRowsOrColumns()
    End Sub

    Private Sub SetScaleOption()
        'This sub is setting the right scale parameter in the clsRFacetFunctions, according to the scale chk boxes. 
        'It only needs to be called when these are modified, as this parameter is common to both facets_grid and facets_wrap. Although graphics on the same row or column in facets_grid share the y or x axis respectively. Still different rows might benefit from having different y-axis scales for instance.
        'Warning: ggplot allows the extra parameter "space" in the facet_grid case. That one takes as values "free" or "fixed" (with quotes). It determines whether the size of rows and columns should adapt to the range of the scale.
        If chkFreeScalesX.Checked AndAlso chkFreeScalesY.Checked Then
            clsRFacetFunction.AddParameter("scales", Chr(34) & "free" & Chr(34))
        ElseIf chkFreeScalesX.Checked AndAlso Not chkFreeScalesY.Checked Then
            clsRFacetFunction.AddParameter("scales", Chr(34) & "free_x" & Chr(34))
        ElseIf Not chkFreeScalesX.Checked AndAlso chkFreeScalesY.Checked Then
            clsRFacetFunction.AddParameter("scales", Chr(34) & "free_y" & Chr(34))
        Else
            clsRFacetFunction.RemoveParameterByName("scales")
        End If
    End Sub

    Private Sub chkScales_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreeScalesX.CheckedChanged, chkFreeScalesY.CheckedChanged
        SetScaleOption()
        SetFacets()
    End Sub
    Private Sub FacetsNumberOfRowsOrColumns()
        'This sub decides whether the option to fix the number of rows or columns should be available or not.
        'When chkMargin is checked, or when both receivers are used (i.e. the second optional is filled), facet_grid is used, and thus the number of rows or columns can't be fixed.
        If (chkMargin.Checked OrElse chkFreeSpace.Checked OrElse (Not ucr2ndFactorReceiver.IsEmpty)) Then
            chkNoOfRowsOrColumns.Checked = False
            chkNoOfRowsOrColumns.Visible = False
            nudNoOfRowsOrColumns.Visible = False
        Else
            chkNoOfRowsOrColumns.Visible = True
            nudNoOfRowsOrColumns.Visible = chkNoOfRowsOrColumns.Checked
        End If
    End Sub

    Private Sub ucr1stFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucr1stFactorReceiver.SelectionChanged
        SetFacets()
        IncludeFacetsParameter()
        SecondFactorReceiverEnabled()
    End Sub

    Private Sub SecondFactorReceiverEnabled()
        If ucr1stFactorReceiver.IsEmpty() Then
            ucr2ndFactorReceiver.Enabled = False
        Else ucr2ndFactorReceiver.Enabled = True
        End If
    End Sub

    Private Sub ucr2ndFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucr2ndFactorReceiver.SelectionChanged
        FacetsNumberOfRowsOrColumns()
        SetFacets()
    End Sub

    Private Sub rdoHorVer_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHorizontal.CheckedChanged, rdoVertical.CheckedChanged
        If rdoHorizontal.Checked Then
            chkNoOfRowsOrColumns.Text = "Fixed Number of Rows"
        ElseIf rdoVertical.Checked Then
            chkNoOfRowsOrColumns.Text = "Fixed Number of Columns"
        End If
        SetFacets()
    End Sub

    Private Sub chkNoOfRowsOrColumns_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoOfRowsOrColumns.CheckedChanged
        nudNoOfRowsOrColumns.Visible = chkNoOfRowsOrColumns.Checked
        SetFacets()
    End Sub

    Private Sub nudNoOfRowsOrColumns_TextChanged(sender As Object, e As EventArgs) Handles nudNoOfRowsOrColumns.TextChanged
        SetFacets()
    End Sub

    Private Sub chkMargin_CheckedChanged(sender As Object, e As EventArgs) Handles chkMargin.CheckedChanged
        If chkMargin.Checked Then
            clsRFacetFunction.AddParameter("margins", "TRUE")
        Else
            clsRFacetFunction.RemoveParameterByName("margins")
        End If
        FacetsNumberOfRowsOrColumns()
        SetFacets()
    End Sub

    Private Sub chkFreeSpace_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreeSpace.CheckedChanged
        If chkMargin.Checked Then
            clsRFacetFunction.AddParameter("space", Chr(34) & "free" & Chr(34))
        Else
            clsRFacetFunction.RemoveParameterByName("space")
        End If
        FacetsNumberOfRowsOrColumns()
        SetFacets()
    End Sub

    Private Sub ucrInputThemes_NameChanged() Handles ucrInputThemes.NameChanged
        If Not ucrInputThemes.IsEmpty Then
            clsRThemeFunction.SetRCommand(ucrInputThemes.GetText())
            If ucrInputThemes.GetText() = "theme_grey" Then
                If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    clsRsyntax.AddOperatorParameter("theme", clsRFunc:=clsRThemeFunction)
                Else
                    clsRsyntax.RemoveOperatorParameter("theme")
                End If
            Else
                clsRsyntax.AddOperatorParameter("theme", clsRFunc:=clsRThemeFunction)
            End If
        Else
            clsRsyntax.RemoveOperatorParameter("theme")
        End If
    End Sub

    Private Sub chkChangeLegendTitle_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayLegendTitle.CheckedChanged
        'The Overwrite Legend Title check box should only be available when the Display Legend Title is ticked.
        If chkDisplayLegendTitle.Checked Then
            chkOverwriteLegendTitle.Visible = True
        Else
            chkOverwriteLegendTitle.Visible = False
        End If
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
        clsRsyntax = clsRSyntaxIn
        ucrPlotsAdditionalLayers.SetRSyntax(clsRsyntax)
    End Sub


    Private Sub ucrInputGraphTitle_NameChanged() Handles ucrInputGraphTitle.NameChanged
        If Not ucrInputGraphTitle.IsEmpty Then
            clsGraphTitleFunction.SetRCommand("ggtitle")
            clsGraphTitleFunction.AddParameter("label", Chr(34) & ucrInputGraphTitle.GetText() & Chr(34))
            clsRsyntax.AddOperatorParameter("ggtitle", clsRFunc:=clsGraphTitleFunction)
        Else
            clsRsyntax.RemoveOperatorParameter("ggtitle")
        End If
    End Sub

    Private Sub chkOverwriteLegendTitle_CheckedChanged(sender As Object, e As EventArgs) Handles chkOverwriteLegendTitle.CheckedChanged
        If chkOverwriteLegendTitle.Checked Then
            ucrInputLegend.Visible = True
        Else
            ucrInputLegend.Visible = False
            ucrInputLegend.ResetText()
        End If
    End Sub

    Public Sub LegendDefaults()
        If rdoLegendTitleAuto.Checked Then
            chkDisplayLegendTitle.Visible = False
            chkOverwriteLegendTitle.Visible = False
            chkOverwriteLegendTitle.Checked = False
            ucrInputLegend.Visible = False
            ucrInputLegend.ResetText()
        ElseIf rdoLegendTitleCustom.Checked Then
            chkDisplayLegendTitle.Visible = True
            chkOverwriteLegendTitle.Visible = True
        End If
    End Sub

    Private Sub rdoLegendTitleAuto_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLegendTitleAuto.CheckedChanged
        LegendDefaults()
    End Sub

    Private Sub rdoLegendTitleCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLegendTitleCustom.CheckedChanged
        LegendDefaults()
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
        If rdoLegendTitleCustom.Checked AndAlso (Not ucrInputLegend.IsEmpty()) Then
            clsLegendFunction.SetRCommand("labs")
            clsLegendFunction.AddParameter("fill", Chr(34) & ucrInputLegend.GetText() & Chr(34))
            clsRsyntax.AddOperatorParameter("labs", clsRFunc:=clsLegendFunction)
        ElseIf rdoLegendTitleAuto.Checked Then
            clsRsyntax.RemoveOperatorParameter("labs")
        End If
    End Sub

    'Warning/Task to be discussed: need to disable ok on dlg's when layers are not complete on subdialogues + warning message... 
    'Warning: actually this will be very hard to implement until the global aes, set from the main layer are properly communicated to plots. Global aes might fill in missing mandatory aes...
End Class