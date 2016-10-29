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
    Public clsAesFunction As New RFunction
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

    Public Sub SetDefaults()
        TitleDefaults()

        chkIncludeFacets.Checked = False
        'Changing the chkIncludeFacets will trigger IncludeFacets() ...
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
    End Sub

    Public Sub Reset() 'Task/Question: Really can we not just use SetDefaults immediately ? 
        SetDefaults()
    End Sub

    Private Sub InitialiseDialog()
        InitialiseTabs()
        CreateThemes()
        Facets()
        'The following three setup the ucrAdditionalLayers on the sdgPlots. Shares the global ggplot function and aesthetics, as well as the whole PLots RSyntax.
        ucrPlotsAdditionalLayers.SetGGplotFunction(clsRggplotFunction)
        ucrPlotsAdditionalLayers.SetAesFunction(clsAesFunction)
        ucrPlotsAdditionalLayers.SetRSyntax(clsRsyntax)
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
        tabctrlBoxSubdialog.SelectedIndex = 0
    End Sub

    Public Sub me_me() Handles tabctrlBoxSubdialog.TabIndexChanged
        'Question: I thought this would be the explanation of the tabs initialisation, but after reflexion I don't see the point of this function. Are these setup's not done in the Initialisedialog() ? Lines 83 and 85. Does it need to be performed again each time we go back to these particular tabs ?
        If tabctrlBoxSubdialog.SelectedTab Is tbpXAxis Then
            ucrXAxis.bIsX = True
        ElseIf tabctrlBoxSubdialog.SelectedTab Is tbpYAxis Then
            ucrYAxis.bIsX = False
        End If
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
    Private Sub Facets()
        'Links the factor receivers, used for creating facets, with the selector. The variables need to be factors.
        ucr1stFactorReceiver.Selector = ucrFacetSelector
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr2ndFactorReceiver.Selector = ucrFacetSelector
        ucr2ndFactorReceiver.SetIncludedDataTypes({"factor"})
    End Sub

    Private Sub IncludeFacets()
        If chkIncludeFacets.Checked Then
            ucrFacetSelector.Visible = True
            ucr1stFactorReceiver.Visible = True
            ucr2ndFactorReceiver.Visible = True
            lblFactor1.Visible = True
            lblFactor2.Visible = True
            rdoHorizontal.Visible = True
            rdoHorizontal.Checked = True
            rdoVertical.Visible = True
            chkNoOfRowsOrColumns.Visible = True
            chkNoOfRowsOrColumns.Checked = True
            nudNoOfRowsOrColumns.Visible = True
            chkMargin.Visible = True
            chkFreeScalesX.Visible = True
            chkFreeScalesY.Visible = True
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
        End If
        'Question to be discussed: should SetFacets not only be run when chkIncludeFacets is checked ?
        SetFacets()
        IncludeFacetsOperator()
    End Sub

    Private Sub SetFacets()
        'Depending on the settings on the dialog, this function sets the Facets command , stored within clsRFacetFunction.
        'The choice between grid and wrap are done systematically depending on the chosen settings.
        'Task: detailed comments about the procedure below
        Dim clsTempOp As New ROperator
        clsTempOp.SetOperation("~")
        clsRFacetFunction.RemoveParameterByName("nrow")
        clsRFacetFunction.RemoveParameterByName("ncol")

        If Not ucr1stFactorReceiver.IsEmpty() AndAlso ucr2ndFactorReceiver.IsEmpty() Then
            If rdoHorizontal.Checked AndAlso (chkMargin.Checked OrElse Not chkNoOfRowsOrColumns.Checked) Then
                clsRFacetFunction.SetRCommand("facet_grid")
                clsTempOp.SetParameter(True, strValue:=".")
                clsTempOp.SetParameter(False, strValue:=ucr1stFactorReceiver.GetVariableNames(False))
                'As there are only a left and a right parameter for clsTempOp, no need to specify a parameter name, the default "right" will be used.
                clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)

            ElseIf rdoVertical.Checked AndAlso (chkMargin.Checked OrElse Not chkNoOfRowsOrColumns.Checked) Then
                clsRFacetFunction.SetRCommand("facet_grid")
                clsTempOp.SetParameter(False, strValue:=".")
                clsTempOp.SetParameter(True, strValue:=ucr1stFactorReceiver.GetVariableNames(False))
                clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)

            Else
                clsRFacetFunction.SetRCommand("facet_wrap")
                clsTempOp.SetParameter(True, strValue:="")
                clsTempOp.SetParameter(False, strValue:=ucr1stFactorReceiver.GetVariableNames(False))
                clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)
                If rdoHorizontal.Checked AndAlso chkNoOfRowsOrColumns.Checked AndAlso nudNoOfRowsOrColumns.Value > 0 Then
                    clsRFacetFunction.AddParameter("nrow", nudNoOfRowsOrColumns.Value)
                ElseIf rdoVertical.Checked AndAlso chkNoOfRowsOrColumns.Checked AndAlso nudNoOfRowsOrColumns.Value > 0 Then
                    clsRFacetFunction.AddParameter("ncol", nudNoOfRowsOrColumns.Value)
                End If
            End If

        ElseIf Not ucr1stFactorReceiver.IsEmpty() AndAlso Not ucr2ndFactorReceiver.IsEmpty() Then
            clsRFacetFunction.SetRCommand("facet_grid")
            If rdoHorizontal.Checked Then
                clsTempOp.SetParameter(False, strValue:=ucr1stFactorReceiver.GetVariableNames(False))
                clsTempOp.SetParameter(True, strValue:=ucr2ndFactorReceiver.GetVariableNames(False))
                clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)
            ElseIf rdoVertical.Checked Then
                clsTempOp.SetParameter(True, strValue:=ucr1stFactorReceiver.GetVariableNames(False))
                clsTempOp.SetParameter(False, strValue:=ucr2ndFactorReceiver.GetVariableNames(False))
                clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)
            End If
        Else
            clsRFacetFunction.RemoveParameterByName("facets")
        End If

    End Sub

    Private Sub IncludeFacetsOperator()
        If chkIncludeFacets.Checked AndAlso Not ucr1stFactorReceiver.IsEmpty() Then
            clsRsyntax.AddOperatorParameter("facet", clsRFunc:=clsRFacetFunction)
        Else
            clsRsyntax.RemoveOperatorParameter("facet")
        End If
    End Sub

    'Question to be discussed/Task: This is the kind of subs that could go into a SetupPlotOptions procedure... also only called in two specific plots and not in the others ... Why ? (to be explored)
    Public Sub SetGgplotFunction(clsGgplotFunc As RFunction)
        clsRggplotFunction = clsGgplotFunc
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



    Public Sub SetDataFrame(strNewDataFrame As String)
        strDataFrame = strNewDataFrame
        ucrFacetSelector.SetDataframe(strDataFrame, False)
    End Sub



    Private Sub VisibileNumberOfRowsOrColumns()
        If chkMargin.Checked OrElse Not ucr2ndFactorReceiver.IsEmpty Then
            chkNoOfRowsOrColumns.Visible = False
            nudNoOfRowsOrColumns.Visible = False
        Else
            chkNoOfRowsOrColumns.Visible = True
            nudNoOfRowsOrColumns.Visible = chkNoOfRowsOrColumns.Checked
        End If
    End Sub

    Private Sub chkIncludeFacets_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeFacets.CheckedChanged
        IncludeFacets()
    End Sub

    Private Sub ucr1stFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucr1stFactorReceiver.SelectionChanged
        SetFacets()
        IncludeFacetsOperator()
        'Question: Do we not only need IncludeFacetsOperator here and not in the following subs, as only the first receiver and the chkIncludeFacets decides whether the operator should be added ? Can I delete the others ?
    End Sub

    Private Sub ucr2ndFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucr2ndFactorReceiver.SelectionChanged
        VisibileNumberOfRowsOrColumns()
        SetFacets()
        IncludeFacetsOperator()
    End Sub

    Private Sub rdoHorVer_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHorizontal.CheckedChanged, rdoVertical.CheckedChanged
        If rdoHorizontal.Checked Then
            chkNoOfRowsOrColumns.Text = "Fixed Number of Rows"
        ElseIf rdoVertical.Checked Then
            chkNoOfRowsOrColumns.Text = "Fixed Number of Columns"
        End If
        SetFacets()
        IncludeFacetsOperator()
    End Sub

    Private Sub chkNoOfRowsOrColumns_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoOfRowsOrColumns.CheckedChanged
        nudNoOfRowsOrColumns.Visible = chkNoOfRowsOrColumns.Checked
        SetFacets()
        IncludeFacetsOperator()
    End Sub

    Private Sub nudNoOfRowsOrColumns_TextChanged(sender As Object, e As EventArgs) Handles nudNoOfRowsOrColumns.TextChanged
        SetFacets()
        IncludeFacetsOperator()
    End Sub

    Private Sub chkMargin_CheckedChanged(sender As Object, e As EventArgs) Handles chkMargin.CheckedChanged
        If chkMargin.Checked Then
            clsRFacetFunction.AddParameter("margins", "TRUE")
        Else
            clsRFacetFunction.RemoveParameterByName("margins")

        End If
        VisibileNumberOfRowsOrColumns()
        SetFacets()
        IncludeFacetsOperator()
    End Sub

    Private Sub SetScaleOption()
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
        IncludeFacetsOperator()
        SetFacets()
    End Sub

    Public Sub SetRSyntax(clsRSyntaxIn As RSyntax)
        clsRsyntax = clsRSyntaxIn
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
End Class