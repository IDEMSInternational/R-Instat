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
    Public clsRsyntax As New RSyntax
    Public clsRggplotFunction As New RFunction
    Public clsAesFunction As New RFunction
    Public clsRFacetFunction As New RFunction
    Public clsXLabFunction As New RFunction
    Public clsYLabFunction As New RFunction
    Public clsRThemeFunction As New RFunction
    Public clsRLegendFunction As New RFunction
    Public clsGraphTitleFunction As New RFunction
    Public clsLegendFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Public strDataFrame As String
    Private bAdditionalLayersSetGlobal As Boolean

    Private Sub sdgPlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseTabs()
        For i = 0 To tabctrlBoxSubdialog.TabCount - 1
            tabctrlBoxSubdialog.SelectedIndex = i
        Next
        tabctrlBoxSubdialog.SelectedIndex = 0
    End Sub

    Public Sub SetDefaults()
        TitleDefaults()
        IncludeFacets()
        chkIncludeFacets.Checked = False
        ucrFacetSelector.Reset()
        ucr1stFactorReceiver.SetMeAsReceiver()
        ucrInputGraphTitle.SetName("")
        ucrPlotsAdditionalLayers.Reset()
        ucrXAxis.Reset()
        ucrYAxis.Reset()
        ucrInputThemes.SetName("theme_grey")
        rdoLegendTitleAuto.Checked = True
        LegendDefaults()
        bLayersDefaultIsGlobal = False
    End Sub

    Public Sub Reset()
        SetDefaults()
    End Sub

    Private Sub InitialiseDialog()
        InitialiseTabs()
        CreateThemes()
        Facets()
        IncludeFacets()
        ucrPlotsAdditionalLayers.SetGGplotFunction(clsRggplotFunction)
        ucrPlotsAdditionalLayers.SetAesFunction(clsAesFunction)
        ucrPlotsAdditionalLayers.SetRSyntax(clsRsyntax)
        ucrXAxis.SetXorY(True)
        ucrXAxis.SetRsyntaxAxis(clsRsyntax)
        ucrYAxis.SetXorY(False)
        ucrYAxis.SetRsyntaxAxis(clsRsyntax)
    End Sub

    Public Sub SetGgplotFunction(clsGgplotFunc As RFunction)
        clsRggplotFunction = clsGgplotFunc
    End Sub

    Public Sub me_me() Handles tabctrlBoxSubdialog.TabIndexChanged
        If tabctrlBoxSubdialog.SelectedTab Is tbpXAxis Then
            ucrXAxis.bIsX = True
        ElseIf tabctrlBoxSubdialog.SelectedTab Is tbpYAxis Then
            ucrYAxis.bIsX = False
        End If
    End Sub

    Private Sub CreateThemes()
        Dim strThemes() As String
        strThemes = {"theme_bw", "theme_linedraw", "theme_light", "theme_minimal", "theme_classic", "theme_dark", "theme_void", "theme_base", "theme_calc", "theme_economist", "theme_few", "theme_fivethirtyeight", "theme_foundation", "theme_grey", "theme_gdocs", "theme_igray", "theme_map", "theme_par", "theme_solarized", "theme_hc", "theme_pander", "theme_solid", "theme_stata", "theme_tufte", "theme_wsj"}
        Array.Sort(strThemes)
        ucrInputThemes.SetItems({"theme_bw", "theme_linedraw", "theme_light", "theme_minimal", "theme_classic", "theme_dark", "theme_void", "theme_base", "theme_calc", "theme_economist", "theme_few", "theme_fivethirtyeight", "theme_foundation", "theme_grey", "theme_gdocs", "theme_igray", "theme_map", "theme_par", "theme_solarized", "theme_hc", "theme_pander", "theme_solid", "theme_stata", "theme_tufte", "theme_wsj"})
        cmdAllOptions.Enabled = False
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
    Private Sub TitleDefaults()
        chkDisplayLegendTitle.Checked = True
        chkOverwriteLegendTitle.Checked = False
        ucrInputLegend.Visible = False
    End Sub

    Private Sub chkChangeLegendTitle_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayLegendTitle.CheckedChanged

        'Redid this properly

        'If chkOverwriteLegendTitle.Checked Then
        '    ucrInputLegend.Visible = True
        'Else
        '    ucrInputLegend.Visible = False
        'End If
    End Sub

    Private Sub Facets()
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
        SetFacets()
        IncludeFacetsOperator()
    End Sub

    Public Sub SetDataFrame(strNewDataFrame As String)
        strDataFrame = strNewDataFrame
        ucrFacetSelector.SetDataframe(strDataFrame, False)
    End Sub

    Private Sub SetFacets()
        Dim clsTempOp As New ROperator
        clsTempOp.SetOperation("~")
        clsRFacetFunction.RemoveParameterByName("nrow")
        clsRFacetFunction.RemoveParameterByName("ncol")

        If Not ucr1stFactorReceiver.IsEmpty() AndAlso ucr2ndFactorReceiver.IsEmpty() Then
            If rdoHorizontal.Checked AndAlso (chkMargin.Checked OrElse Not chkNoOfRowsOrColumns.Checked) Then
                clsRFacetFunction.SetRCommand("facet_grid")
                clsTempOp.SetParameter(True, strValue:=".")
                clsTempOp.SetParameter(False, strValue:=ucr1stFactorReceiver.GetVariableNames(False))
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
        If Not chkIncludeFacets.Checked Then
            clsRsyntax.RemoveOperatorParameter("facet")
        End If
    End Sub

    Private Sub ucr1stFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucr1stFactorReceiver.SelectionChanged
        SetFacets()
        IncludeFacetsOperator()
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
            clsRFacetFunction.AddParameter("scales", "free")
        ElseIf chkFreeScalesX.Checked AndAlso Not chkFreeScalesY.Checked Then
            clsRFacetFunction.AddParameter("scales", "free_x")
        ElseIf Not chkFreeScalesX.Checked AndAlso chkFreeScalesY.Checked Then
            clsRFacetFunction.AddParameter("scales", "free_y")
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

    Public Sub SetRsyntaxAxis(clsRsyntaxAxis As RSyntax)
        clsRsyntax = clsRsyntaxAxis
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
        ElseIf rdoLegendTitleAuto.Checked
            clsRsyntax.RemoveOperatorParameter("labs")
        End If
    End Sub
End Class