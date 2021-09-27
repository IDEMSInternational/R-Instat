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

Public Class ucrGeom
    'Ucr Geom is used to select the geom that will be used for a specific graph/layer. It is used in ucrGeomListWithAes and ucrLayerParameters both ucr's of sdgLayerOptions. 
    'It stores the definition of the different Geoms, using instances of clsGeom, including their R names, the relevant/available parameters and their description (type of values, values, default, ...).
    Public lstAllGeoms As New List(Of Geoms)
    'Public lstGgParameters As New List(Of RParameter)
    'Question: lstGgParameters lists of the ggplot parameters ? Let's delete ?
    Public clsCurrGeom As New Geoms
    Public clsGeomFunction As New RFunction
    'Question: clsGeomFunction is the RFunction associated to the clsCurrGeom ? Could it be included in clsCurrGeom, if yes do we wish that ? Used together with clsGgplotAesFunction... ?
    'Similarly for lstFunctionParameters. Both, together with clsGgplotAesFunction are supposedly passed through to ucrAdditionalLayers and assigned to smth in ucrAdditionalLayers by calling  sdgLayerOption.SetupLayer which calls setup ? Still need to figure out when/how they are used though...
    Public clsGlobalAesFunction As New RFunction
    Public clsLocalAesFunction As RFunction
    Public clsGgplotFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Public strGlobalDataFrame As String = ""
    Protected ucrBaseSelector As ucrSelectorByDataFrame
    Private iCurrentGeomIndex As Integer = -1
    Public bPauseChanges As Boolean = False
    Dim strLineType As String() = {Chr(34) & "blank" & Chr(34), Chr(34) & "solid" & Chr(34), Chr(34) & "dashed" & Chr(34), Chr(34) & "dotted" & Chr(34), Chr(34) & "dotdash" & Chr(34), Chr(34) & "longdash" & Chr(34), Chr(34) & "twodash" & Chr(34)}
    Dim strShapePoint As String() = {Chr(34) & "circle" & Chr(34), Chr(34) & "circle open" & Chr(34), Chr(34) & "circle filled" & Chr(34), Chr(34) & "circle cross" & Chr(34), Chr(34) & "circle plus" & Chr(34), Chr(34) & "circle small" & Chr(34), Chr(34) & "bullet" & Chr(34), Chr(34) & "square" & Chr(34), Chr(34) & "square open" & Chr(34), Chr(34) & "square filled" & Chr(34), Chr(34) & "square cross" & Chr(34), Chr(34) & "square plus" & Chr(34), Chr(34) & "square triangle" & Chr(34), Chr(34) & "diamond" & Chr(34), Chr(34) & "diamond open" & Chr(34), Chr(34) & "diamond filled" & Chr(34), Chr(34) & "diamond plus" & Chr(34), Chr(34) & "triangle" & Chr(34), Chr(34) & "triangle open" & Chr(34), Chr(34) & "triangle filled" & Chr(34), Chr(34) & "triangle square" & Chr(34), Chr(34) & "triangle down open" & Chr(34), Chr(34) & "triangle down filled" & Chr(34), Chr(34) & "plus" & Chr(34), Chr(34) & "cross" & Chr(34), Chr(34) & "asterisk" & Chr(34)}
    Dim strBoxShapePoint As String() = {Chr(34) & "NA" & Chr(34), Chr(34) & "circle" & Chr(34), Chr(34) & "circle open" & Chr(34), Chr(34) & "circle filled" & Chr(34), Chr(34) & "circle cross" & Chr(34), Chr(34) & "circle plus" & Chr(34), Chr(34) & "circle small" & Chr(34), Chr(34) & "bullet" & Chr(34), Chr(34) & "square" & Chr(34), Chr(34) & "square open" & Chr(34), Chr(34) & "square filled" & Chr(34), Chr(34) & "square cross" & Chr(34), Chr(34) & "square plus" & Chr(34), Chr(34) & "square triangle" & Chr(34), Chr(34) & "diamond" & Chr(34), Chr(34) & "diamond open" & Chr(34), Chr(34) & "diamond filled" & Chr(34), Chr(34) & "diamond plus" & Chr(34), Chr(34) & "triangle" & Chr(34), Chr(34) & "triangle open" & Chr(34), Chr(34) & "triangle filled" & Chr(34), Chr(34) & "triangle square" & Chr(34), Chr(34) & "triangle down open" & Chr(34), Chr(34) & "triangle down filled" & Chr(34), Chr(34) & "plus" & Chr(34), Chr(34) & "cross" & Chr(34), Chr(34) & "asterisk" & Chr(34)}
    Private bResetGlobal As Boolean = False
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CreateGeomList()
    End Sub

    Public Overrides Sub SetRCode(clsNewCodeStructure As RCodeStructure, Optional bReset As Boolean = False, Optional bUpdate As Boolean = True, Optional bCloneIfNeeded As Boolean = False)
        Dim clsTempFunc As RFunction
        Dim iGeomIndex As Integer

        MyBase.SetRCode(clsNewCodeStructure, bReset, bUpdate, bCloneIfNeeded)
        If clsNewCodeStructure IsNot Nothing AndAlso TypeOf (clsNewCodeStructure) Is RFunction Then
            clsTempFunc = TryCast(clsNewCodeStructure, RFunction)
            If clsTempFunc IsNot Nothing AndAlso clsTempFunc.strRCommand IsNot Nothing Then
                iGeomIndex = lstAllGeoms.FindIndex(Function(x) x.strGeomName = clsTempFunc.strRCommand)
                If iGeomIndex <> -1 Then
                    clsCurrGeom = lstAllGeoms(iGeomIndex)
                    bResetGlobal = bReset
                    ucrInputGeoms.SetName(clsCurrGeom.strGeomName)
                    bResetGlobal = False
                Else
                    MsgBox("Developer error: Function set for " & Name & " is not a recognised geom.")
                End If
            Else
                MsgBox("Developer error: Code set for " & Name & " is not an RFunction.")
            End If
        Else
            MsgBox("Developer error: Code set for " & Name & " is not an RFunction.")
        End If
    End Sub

    Private Sub UcrGeoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            bFirstLoad = False
            ucrInputGeoms.SetDropDownStyleAsNonEditable()
        End If
    End Sub

    Private Sub InitialiseControl()
        clsGeomFunction.AddParameter("mapping", clsRFunctionParameter:=clsGlobalAesFunction)
    End Sub

    Public Overridable Sub Setup(clsNewGgplotFunction As RFunction, clsNewGeomFunc As RFunction, clsNewGlobalAesFunc As RFunction, clsNewLocalAes As RFunction, Optional bFixGeom As Boolean = False, Optional ucrNewBaseSelector As ucrSelectorByDataFrame = Nothing, Optional bApplyAesGlobally As Boolean = True, Optional iNumVariablesForGeoms As Integer = -1, Optional bReset As Boolean = False, Optional strDataFrame As String = "")
        'Setup is used to setup the parameters of ucrGeom as well as ucrGeomListWithAes and ucrLayerParameters as they override Setup from ucrGeom. The Setup function is also used within sdgLayerOptions.SetupLayer which plays the same role for the whole sdlLayerOption.
        'These functions are called all together in the ucrAddLayers when a Layer is added or edited, as well as in specific plots dialogs such as dlgBoxPlot when the plot options sdgPlots (dealing with layers) is opened.
        Dim GeomCount As New Geoms

        'Question to be discussed: Never went back to this... don't understand what's happening...
        'First we clear the content of the displayed list (in ucrInputGeoms) of available geoms as this may change between different setup's according to the parameter iNumVariablesForGeoms (see below). 
        ucrInputGeoms.SetItems()
        'Then we add geom names from our lstAllGeoms to ucrInputGeoms when the number of available variables to associate to geom Aes (iNumVariablesForGeom) is greater or equal to the number of mandatory Aes of that geom. Correct ?
        For Each GeomCount In lstAllGeoms
            If iNumVariablesForGeoms = -1 OrElse iNumVariablesForGeoms >= GeomCount.iNumMandatoryAes Then
                ucrInputGeoms.AddItems({GeomCount.strGeomName})
            End If
        Next
        'Next, the clsGeomFunction is set. Either this one is empty, or it has already been setup on the dialogue that is calling Setup...
        SetGeomFunction(clsNewGeomFunc, bReset)
        ucrInputGeoms.Enabled = Not bFixGeom
        clsGlobalAesFunction = clsNewGlobalAesFunc
        clsLocalAesFunction = clsNewLocalAes
        clsGgplotFunction = clsNewGgplotFunction
        ucrBaseSelector = ucrNewBaseSelector
        If ucrBaseSelector IsNot Nothing Then
            strGlobalDataFrame = ucrBaseSelector.strCurrentDataFrame
        Else
            strGlobalDataFrame = strDataFrame
        End If
    End Sub

    Public Overridable Sub SetGeomFunction(clsTempGeomFunc As RFunction, Optional bReset As Boolean = False)
        clsGeomFunction = clsTempGeomFunc
        SetRCode(clsGeomFunction, bReset)
    End Sub

    Public Sub CreateGeomList()

        Dim clsgeom_abline As New Geoms
        Dim clsgeom_area As New Geoms
        Dim clsgeom_bar As New Geoms
        Dim clsgeom_bin2d As New Geoms
        Dim clsgeom_blank As New Geoms
        Dim clsgeom_boxplot As New Geoms
        Dim clsgeom_contour As New Geoms
        Dim clsgeom_count As New Geoms
        Dim clsgeom_col As New Geoms
        Dim clsgeom_crossbar As New Geoms
        Dim clsgeom_curve As New Geoms
        Dim clsgeom_density As New Geoms
        Dim clsgeom_density2d As New Geoms
        Dim clsgeom_density_2d As New Geoms
        Dim clsgeom_dumbbell As New Geoms
        Dim clsgeom_dotplot As New Geoms
        Dim clsgeom_encircle As New Geoms
        Dim clsgeom_errorbar As New Geoms
        Dim clsgeom_errorbarh As New Geoms
        Dim clsgeom_freqpoly As New Geoms
        Dim clsgeom_function As New Geoms
        Dim clsgeom_hex As New Geoms
        Dim clsgeom_histogram As New Geoms
        Dim clsgeom_hline As New Geoms
        Dim clsgeom_jitter As New Geoms
        Dim clsgeom_label As New Geoms
        Dim clsgeom_label_repel As New Geoms
        Dim clsgeom_line As New Geoms
        Dim clsgeom_linerange As New Geoms
        Dim clsgeom_lollipop As New Geoms
        Dim clsgeom_map As New Geoms
        Dim clsgeom_mosaic As New Geoms
        Dim clsgeom_path As New Geoms
        Dim clsgeom_point As New Geoms
        Dim clsgeom_pointrange As New Geoms
        Dim clsgeom_polygon As New Geoms
        Dim clsgeom_qq As New Geoms
        Dim clsgeom_qq_line As New Geoms
        Dim clsgeom_quantile As New Geoms
        Dim clsgeom_raster As New Geoms
        Dim clsgeom_rect As New Geoms
        Dim clsgeom_ribbon As New Geoms
        Dim clsgeom_rug As New Geoms
        Dim clsgeom_scale_fill_viridis_c As New Geoms
        Dim clsgeom_segment As New Geoms
        Dim clsgeom_sf As New Geoms
        Dim clsgeom_smooth As New Geoms
        Dim clsgeom_spoke As New Geoms
        Dim clsgeom_stat_density_ridges As New Geoms
        Dim clsgeom_statECDF As New Geoms
        Dim clsgeom_step As New Geoms
        Dim clsgeom_text As New Geoms
        Dim clsgeom_text_wordcloud As New Geoms
        Dim clsgeom_text_wordcloud_area As New Geoms
        Dim clsgeom_text_repel As New Geoms
        Dim clsgeom_tile As New Geoms
        Dim clsgeom_treemap As New Geoms
        Dim clsgeom_treemap_text As New Geoms
        Dim clsgeom_tufteboxplot As New Geoms
        Dim clsgeom_violin As New Geoms
        Dim clsgeom_vline As New Geoms

        clsgeom_scale_fill_viridis_c.SetGeomPackage("ggplot2")
        clsgeom_scale_fill_viridis_c.strGeomName = "scale_fill_viridis_c"
        'Other Aesthetics
        clsgeom_scale_fill_viridis_c.AddAesParameter("fill", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_scale_fill_viridis_c.AddAesParameter("colour", strIncludedDataTypes:=({"factor", "numeric"}))
        'adding layer parameters
        clsgeom_scale_fill_viridis_c.AddLayerParameter("alpha", "numeric", "0.7", lstParameterStrings:={1, 0})
        clsgeom_scale_fill_viridis_c.AddLayerParameter("begin", "numeric", "0", lstParameterStrings:={1, 0})
        clsgeom_scale_fill_viridis_c.AddLayerParameter("end", "numeric", "1", lstParameterStrings:={1, 0})
        clsgeom_scale_fill_viridis_c.AddLayerParameter("panel_scaling", "list", "1", lstParameterStrings:={"1", "-1"})
        clsgeom_scale_fill_viridis_c.AddLayerParameter("option", "list", Chr(34) & "cividis" & Chr(34), lstParameterStrings:={Chr(34) & "cividis" & Chr(34), Chr(34) & "magma" & Chr(34), Chr(34) & "inferno" & Chr(34), Chr(34) & "plasma" & Chr(34), Chr(34) & "viridis" & Chr(34)})
        clsgeom_scale_fill_viridis_c.AddLayerParameter("values", "numeric", "0", lstParameterStrings:={1, 0})
        clsgeom_scale_fill_viridis_c.AddLayerParameter("Space", "list", Chr(34) & "Lab" & Chr(34), lstParameterStrings:={Chr(34) & "Lab" & Chr(34)})
        clsgeom_scale_fill_viridis_c.AddLayerParameter("na.value", "list", Chr(34) & "grey50" & Chr(34), lstParameterStrings:={Chr(34) & "grey50" & Chr(34)})
        clsgeom_scale_fill_viridis_c.AddLayerParameter("guide", "list", Chr(34) & "colourbar" & Chr(34), lstParameterStrings:={Chr(34) & "colourbar" & Chr(34)})

        lstAllGeoms.Add(clsgeom_scale_fill_viridis_c)


        clsgeom_stat_density_ridges.SetGeomPackage("ggridges")
        clsgeom_stat_density_ridges.strGeomName = "stat_density_ridges"
        'Mandatory Aesthetics
        clsgeom_stat_density_ridges.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_stat_density_ridges.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        clsgeom_stat_density_ridges.AddAesParameter("fill", strIncludedDataTypes:=({"factor", "numeric"}))

        'adding layer parameters
        clsgeom_stat_density_ridges.AddLayerParameter("geom", "list", Chr(34) & "density_ridges" & Chr(34), lstParameterStrings:={Chr(34) & "density_ridges" & Chr(34), Chr(34) & "density_ridges_gradient" & Chr(34)})
        clsgeom_stat_density_ridges.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_stat_density_ridges.AddLayerParameter("bandwidth", "numeric", "0.1", lstParameterStrings:={1, 0})
        clsgeom_stat_density_ridges.AddLayerParameter("jittered_points", "boolean", "FALSE")
        clsgeom_stat_density_ridges.AddLayerParameter("quantile_lines", "boolean", "FALSE")
        clsgeom_stat_density_ridges.AddLayerParameter("calc_ecdf", "boolean", "FALSE")
        clsgeom_stat_density_ridges.AddLayerParameter("quantiles", "numeric", "1.0", lstParameterStrings:={1, 0})
        clsgeom_stat_density_ridges.AddLayerParameter("quantile_fun", "list", "quantile", lstParameterStrings:={"quantile"})
        clsgeom_stat_density_ridges.AddLayerParameter("alpha", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_stat_density_ridges.AddLayerParameter("n", "numeric", "512", lstParameterStrings:={0, 0}) ' This should be a power of 2 - Not sure how to restrict this. 40.
        clsgeom_stat_density_ridges.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_stat_density_ridges.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_stat_density_ridges)


        clsgeom_statECDF.SetGeomName("stat_ecdf")
        'mandatory
        clsgeom_statECDF.AddAesParameter("x", bIsMandatory:=True)
        'optional
        clsgeom_statECDF.AddAesParameter("colour")

        'add layer parameter
        clsgeom_statECDF.AddLayerParameter("geom", "list", Chr(34) & "step" & Chr(34), lstParameterStrings:={Chr(34) & "step" & Chr(34), Chr(34) & "line" & Chr(34), Chr(34) & "point" & Chr(34), Chr(34) & "bar" & Chr(34), Chr(34) & "density" & Chr(34)})
        clsgeom_statECDF.AddLayerParameter("pad", "boolean", "TRUE")
        clsgeom_statECDF.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_statECDF.AddLayerParameter("show.legend", "list", "NA", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_statECDF.AddLayerParameter("na.rm", "boolean", "FALSE")
        lstAllGeoms.Add(clsgeom_statECDF)


        Dim clsgeom_statsummary As New Geoms

        clsgeom_statsummary.SetGeomName("stat_summary")
        'mandatory aesthetics
        clsgeom_statsummary.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        clsgeom_statsummary.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        clsgeom_statsummary.AddAesParameter("group", strIncludedDataTypes:={"factor", "numeric"})

        'layer params

        'These are the list of parameters on the documentation, some may have more options than what we have here which am yet to find out
        clsgeom_statsummary.AddLayerParameter("fun.data", "editablelist", Chr(34) & "mean_cl_boot" & Chr(34), lstParameterStrings:={Chr(34) & "mean_sdl" & Chr(34), Chr(34) & "mean_cl_boot" & Chr(34)})
        clsgeom_statsummary.AddLayerParameter("fun.y", "editablelist", Chr(34) & "mean" & Chr(34), lstParameterStrings:={Chr(34) & "median" & Chr(34), Chr(34) & "mean" & Chr(34)})
        clsgeom_statsummary.AddLayerParameter("fun.ymin", "editablelist", Chr(34) & "min" & Chr(34), lstParameterStrings:={Chr(34) & "min" & Chr(34)})
        clsgeom_statsummary.AddLayerParameter("fun.ymax", "editablelist", Chr(34) & "max" & Chr(34), lstParameterStrings:={Chr(34) & "max" & Chr(34)})
        clsgeom_statsummary.AddLayerParameter("geom", "list", Chr(34) & "area" & Chr(34), lstParameterStrings:={Chr(34) & "area" & Chr(34), Chr(34) & "bar" & Chr(34), Chr(34) & "blank" & Chr(34), Chr(34) & "col" & Chr(34), Chr(34) & "contour" & Chr(34), Chr(34) & "crossbar" & Chr(34), Chr(34) & "density" & Chr(34), Chr(34) & "density_2d" & Chr(34), Chr(34) & "density2d" & Chr(34), Chr(34) & "errorbar" & Chr(34), Chr(34) & "hex" & Chr(34), Chr(34) & "line" & Chr(34), Chr(34) & "linerange" & Chr(34), Chr(34) & "path" & Chr(34), Chr(34) & "point" & Chr(34), Chr(34) & "pointrange" & Chr(34), Chr(34) & "polygon" & Chr(34), Chr(34) & "quantile" & Chr(34), Chr(34) & "raster" & Chr(34), Chr(34) & "ribbon" & Chr(34), Chr(34) & "rug" & Chr(34), Chr(34) & "smooth" & Chr(34), Chr(34) & "step" & Chr(34), Chr(34) & "tile" & Chr(34)})
        'TO DO what other positions can go here?
        clsgeom_statsummary.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})
        clsgeom_statsummary.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_statsummary.AddLayerParameter("size", "numeric", "1.5", lstParameterStrings:={1, 0})
        clsgeom_statsummary.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_statsummary.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        'TODO these needs to be looked at how they work. They are part of parameters thaat can go to stat_summary
        'clsgeom_statsummary.AddLayerParameter("bins", "numeric", "30", lstParameterStrings:={})
        'clsgeom_statsummary.AddLayerParameter("binwidth", "numeric", "1", lstParameterStrings:={})
        'clsgeom_statsummary.AddLayerParameter("breaks", "", "", lstParameterStrings:={})
        'clsgeom_statsummary.AddLayerParameter("fun.args", "", "", lstParameterStrings:={})

        lstAllGeoms.Add(clsgeom_statsummary)

        Dim clsgeom_statpeaks As New Geoms

        clsgeom_statpeaks.SetGeomPackage("ggpmisc")
        clsgeom_statpeaks.SetGeomName("stat_peaks")

        'add aes parameter
        clsgeom_statpeaks.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_statpeaks.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"})

        'add layer parameter
        clsgeom_statpeaks.AddLayerParameter("geom", "list", Chr(34) & "point" & Chr(34), lstParameterStrings:={Chr(34) & "point" & Chr(34), Chr(34) & "text" & Chr(34), Chr(34) & "label" & Chr(34), Chr(34) & "line" & Chr(34), Chr(34) & "rug" & Chr(34), Chr(34) & "hline" & Chr(34), Chr(34) & "vline" & Chr(34)})
        clsgeom_statpeaks.AddLayerParameter("span", "list", Chr(34) & "5" & Chr(34), lstParameterStrings:={Chr(34) & "5" & Chr(34), Chr(34) & "NULL" & Chr(34)})
        clsgeom_statpeaks.AddLayerParameter("ignore_threshold", "numeric", "0", lstParameterStrings:={1, 0, 1})
        clsgeom_statpeaks.AddLayerParameter("strict", "boolean", "FALSE")
        clsgeom_statpeaks.AddLayerParameter("label.fmt", "editablelist", Chr(34) & "%.4g" & Chr(34), lstParameterStrings:={Chr(34) & "%.4g" & Chr(34)})
        clsgeom_statpeaks.AddLayerParameter("x.label.fmt", "editablelist", Chr(34) & "NULL" & Chr(34), lstParameterStrings:={Chr(34) & "NULL" & Chr(34)})
        clsgeom_statpeaks.AddLayerParameter("y.label.fmt", "editablelist", Chr(34) & "label.fmt" & Chr(34), lstParameterStrings:={Chr(34) & "label.fmt" & Chr(34)})
        clsgeom_statpeaks.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_statpeaks.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_statpeaks.AddLayerParameter("show.legend", "list", "FALSE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_statpeaks.AddLayerParameter("inherit.aes", "boolean", "TRUE")

        lstAllGeoms.Add(clsgeom_statpeaks)

        Dim clsgeom_statvalleys As New Geoms

        clsgeom_statvalleys.SetGeomPackage("ggpmisc")
        clsgeom_statvalleys.SetGeomName("stat_valleys")

        'add aes parameter
        clsgeom_statvalleys.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_statvalleys.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"})

        'add layer parameter
        clsgeom_statvalleys.AddLayerParameter("geom", "list", Chr(34) & "point" & Chr(34), lstParameterStrings:={Chr(34) & "point" & Chr(34), Chr(34) & "text" & Chr(34), Chr(34) & "label" & Chr(34), Chr(34) & "line" & Chr(34), Chr(34) & "rug" & Chr(34), Chr(34) & "hline" & Chr(34), Chr(34) & "vline" & Chr(34)})
        clsgeom_statvalleys.AddLayerParameter("span", "list", Chr(34) & "5" & Chr(34), lstParameterStrings:={Chr(34) & "5" & Chr(34), Chr(34) & "NULL" & Chr(34)})
        clsgeom_statvalleys.AddLayerParameter("ignore_threshold", "numeric", "0", lstParameterStrings:={1, 0, 1})
        clsgeom_statvalleys.AddLayerParameter("strict", "boolean", "FALSE")
        clsgeom_statvalleys.AddLayerParameter("label.fmt", "editablelist", Chr(34) & "%.4g" & Chr(34), lstParameterStrings:={Chr(34) & "%.4g" & Chr(34)})
        clsgeom_statvalleys.AddLayerParameter("x.label.fmt", "editablelist", Chr(34) & "NULL" & Chr(34), lstParameterStrings:={Chr(34) & "NULL" & Chr(34)})
        clsgeom_statvalleys.AddLayerParameter("y.label.fmt", "editablelist", Chr(34) & "label.fmt" & Chr(34), lstParameterStrings:={Chr(34) & "label.fmt" & Chr(34)})
        clsgeom_statvalleys.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_statvalleys.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_statvalleys.AddLayerParameter("show.legend", "list", "FALSE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_statvalleys.AddLayerParameter("inherit.aes", "boolean", "TRUE")

        lstAllGeoms.Add(clsgeom_statvalleys)

        'Global comments:
        'WARNING: Most of the comments describing the parameters have been copied from the ggplot2 documentation: http://docs.ggplot2.org/current/
        'Warning: cannot use default values like NULL in the specification of our aesthetics as parameters (fill, colour, ...) as running a command like "ggplot(survey, aes(x="",y=Yield)) + geom_boxplot(colour = NULL)" will give an error (Error: Aesthetics must be either length 1 or the same as the data (4): colour). 
        '           however, NULL is still valid as parameter value for outlier.colour for example ( ggplot(survey, aes(x="",y=Yield)) + geom_boxplot(outlier.colour = NULL) runs ok).
        'Warning: Concerning the global parameter position: 
        '           We haven't implemented position_jitterdodge yet. It is seems to be mainly useful in presence of a dodged layer, on top of which we want to display the points of the events (see explanation http://docs.ggplot2.org/current/position_jitterdodge.html). However it doesn't seem to work as the others when specified as position = "jitterdodge" (get errors). Works fine when specified by position = position_jitterdodge(), for geoms such as point, but also bar (and produces outputs that are not completely silly), ...
        '           Could add the possibility to adjust the height and width parameters in the position function position_jitter, also width for dodge... Sometimes useful to only jitter in one direction for example... Then need to specify position as -position=position_jitter([parameters])- instead of -position = "jitter". This is also required for position_jitterdodge (see below). Seems necessary to specify x and y parameters in position_nudge as well in order to obtain any result (see below).
        '           Another option that is not yet available is position_nudge, which makes it possible to move a whole layer by a given (x,y) value. It doesn't seem to do anything by default i.e. when not specifying any argument (position = "nudge" or position = position_nudge()), just uses (x=0,y=0). When x or y is assigned to a factor, each factor corresponds to one unit along the axis (e.g. if x is a factor, position_nudge(x=2) would shift the layer by two factors along the x axis). While testing what happens when x = "" in boxplot case, a weird error was identified: "y aesthetics required", even when both x and y aesthetics are in use.
        '           Dodge requires a factor to dodge by, if none, just doesn't dodge. However, gives a warning in the geom_point case for instance.
        'Warning: About the show.legend layer parameter, the default value in R is NA, which only shows legend for that layer if aesthetics are mapped.
        'Question/Task: we are focusing a lot on numeric and factor variables when it comes to aesthetics mappings. Should we allow more characters ?
        'Warning/question: for line, point and rug (and in general), more stats are available, such as stat_function. However, they require parameters. For instance stat_summary needs some, but a default parameter mean_se() is given. Should we make it possible for users to have access to these ? Would need to be able to pass functions as parameters. Same difficulty as for the position functions such as position_jitterdodge... see above.
        'Warning: the colour type of parameter is not working quite right. Problems with pick colour and some of the available colours such as ff0000a0 and ff400040 are not recognised in R.
        'Warning/Task: need a new type of parameter: units, or perhaps function, in order to be able to specify units(value, unit) or for the position: position_dodge(width = value)... !!!
        'Warning: some parameters are incompatible such as position and nudge_x/nudge_y in geom_text, geom_label... need to introduce method for these...
        'Question/Task: Using or let the user use aes mapping such as ..count.., ..prop.. or ..density.. in bar and histogram for instance when the appropriate stat is in use. To be investigated...
        'Warning/Task: draw_quantiles takes as argument an array of numeric values, eg c(0.25, 0.5, 0.75). For the moment set as a list, but needs to give more flexibility to the type of values for these arguments.

        clsgeom_abline.SetGeomName("geom_abline") 'Warning: this geom never inherits global aesthetics ! It also doesn't affect the x and y scales. Can specify yintercept either with aes, or with parameter (second one overwrites). If want to vary with facets, need to mention as aes.
        'Warning: it does not have position or stat, neither inherit.aes parameters. However, when mentioned, these are simply ignored... 
        'Task: untick and disable IgnoreGlobalAes and ApplyOnAllLayers for this geom.
        'Task: add warning message to user...
        'Adding aesthetics parameters
        'Mandatory Aesthetics
        clsgeom_abline.AddAesParameter("slope", strIncludedDataTypes:={"numeric"})
        clsgeom_abline.AddAesParameter("intercept", strIncludedDataTypes:={"numeric"}) '(required) intercept with the y axis of the line (the "b" in "y=ax+b") 
        'Warning/to be discussed: when these are set as parameters, they are not really mandatory... should we introduce a partially mandatory method nbr 2 ? For now I think it can be left like this...
        'Optional aesthetics
        clsgeom_abline.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_abline.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_abline.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_abline.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        'Adding layer parameters
        'Geom_abline parameters
        clsgeom_abline.AddLayerParameter("slope", "numeric", "0", lstParameterStrings:={2}) 'Parameters that control the position of the line. If these are set, data, mapping and show.legend are overridden
        clsgeom_abline.AddLayerParameter("intercept", "numeric", "0", lstParameterStrings:={2})
        'Task: add warning message to user...
        'Global Layer parameters
        clsgeom_abline.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_abline.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_abline.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_abline.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})
        clsgeom_abline.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) 'Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...

        lstAllGeoms.Add(clsgeom_abline)

        clsgeom_area.SetGeomName("geom_area")
        'Mandatory Aesthetics 
        clsgeom_area.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        clsgeom_area.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"}) ' y is not mandatory when stat = "bin". We also have the option to assign y = ..density.. when stat = "bin"

        ' Optional Aesthetics 
        'geom_area Is a special case of geom_ribbon where ymin Is fixed to 0
        clsgeom_area.AddAesParameter("ymax", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_area.AddAesParameter("alpha", strIncludedDataTypes:={"factor"})
        clsgeom_area.AddAesParameter("colour", strIncludedDataTypes:={"factor"})
        clsgeom_area.AddAesParameter("fill", strIncludedDataTypes:={"factor"})
        clsgeom_area.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_area.AddAesParameter("size", strIncludedDataTypes:={"factor"}) 'factor not advised and cannot be continuous, this error message appears in R "Error in f(...) : Aesthetics can not vary with a ribbon"
        clsgeom_area.AddAesParameter("group", strIncludedDataTypes:={"factor"})

        'Global Layer Parameters 
        clsgeom_area.AddLayerParameter("position", "list", Chr(34) & "stack" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34), "position_dodge()"})
        'we can use position adjustment functions here As well. For "dodge" Option, R gives a warning: Width Not defined.Set with `position_dodge(width = ?). So we need to be able to set the width within position_dodge option here
        clsgeom_area.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_area.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "bin" & Chr(34), Chr(34) & "sum" & Chr(34), Chr(34) & "summary" & Chr(34), Chr(34) & "unique" & Chr(34)}) 'Warning, stat count cannot be used with y aesthetic !!!
        '' revise the options here since identity And unique seem to return the plot to the original scatter plot. Summary option defaults to `mean_se() since no summary function supplied
        clsgeom_area.AddLayerParameter("inherit.aes", "list", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_area.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})

        ''Aesthetics as layer parameters  
        clsgeom_area.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34))
        clsgeom_area.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_area.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_area.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1}) 'Note: alpha only acts on the fill for bars. The outline is not getting transparent.
        clsgeom_area.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0})
        lstAllGeoms.Add(clsgeom_area)


        clsgeom_bar.SetGeomName("geom_bar")
        'Mandatory Aesthetics
        clsgeom_bar.AddAesParameter("x", strIncludedDataTypes:=({"numeric", "factor"}), bIsMandatory:=True)
        'All data types work as x aesthetics although the most common one is factor.
        'Warning: the group aesthetic could be added, doesn't send errors, but using group doesn't work very well. Histograms have been designed to deal with continuous x and grouping (using stat_bin). Group is not mentioned as an available aesthetic in the documentation.

        'Optional aesthetics
        clsgeom_bar.AddAesParameter("y", strIncludedDataTypes:=({"numeric"}))
        'Warning: we can map a numeric variable to y but we must include stat = “identity” inside the geom. This is handled by sdgLayerOptions.ucrSdgLayerBase_ClickReturn. 
        'Alternatively, one can map a continuous variable to the aesthetics weight (other variable types produce an error as stat_count is using sum for that variable). Each bar will then add the values taken by this value for the different events falling under the count of each bar (proceeds to a weighted count).
        'Warning: In this case, the label of the y axis is still count, whereas it should take the name of the variable mapped to weight probably. Also, if a variable has been mapped to y (stat is "identity") then the weight aesthetic is ignored (no warning in R).
        clsgeom_bar.AddAesParameter("weight", strIncludedDataTypes:=({"numeric"}))
        clsgeom_bar.AddAesParameter("alpha", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_bar.AddAesParameter("fill", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_bar.AddAesParameter("colour", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_bar.AddAesParameter("linetype", strIncludedDataTypes:=({"factor"})) 'Warning: This distinguishes bars by varying the outline, however, the distinguished bars only visibly look different if the colour and the fill aesthetics take different values.
        clsgeom_bar.AddAesParameter("size", strIncludedDataTypes:=({"factor", "numeric"}))
        'Warning: Size varies the outline of the bars, hence changes are difficult to see if fill and colour take the same values. 
        'Warning: Finally it Is Not advised To use size For discrete variables (R message), however, continuous variables mapped to size when the stat is "count" are ignored (no changes in the graph).

        'Geom_Bar layer parameters
        clsgeom_bar.AddLayerParameter("width", "numeric", "0.90", lstParameterStrings:={2, 0, 1}) 'The width of the bars is given as a proportion of the data resolution.
        'Global Layer parameters
        clsgeom_bar.AddLayerParameter("stat", "list", Chr(34) & "count" & Chr(34), lstParameterStrings:={Chr(34) & "count" & Chr(34), Chr(34) & "identity" & Chr(34)})
        clsgeom_bar.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_bar.AddLayerParameter("position", "list", Chr(34) & "stack" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), "position_stack(reverse = TRUE)", Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), "position_jitterdodge()", Chr(34) & "nudge" & Chr(34), Chr(34) & "fill" & Chr(34)})
        'See global comments about position.
        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_bar.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34))
        clsgeom_bar.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_bar.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_bar.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1}) 'Note: alpha only acts on the fill for bars. The outline is not getting transparent.
        clsgeom_bar.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) ''Varies the size of outline. Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...

        lstAllGeoms.Add(clsgeom_bar)


        clsgeom_bin2d.SetGeomName("geom_bin2d")
        'mandatory
        clsgeom_bin2d.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_bin2d.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_bin2d.AddAesParameter("fill")
        clsgeom_bin2d.AddAesParameter("group")
        'adding layer parameters
        clsgeom_bin2d.AddLayerParameter("stat", "list", Chr(34) & "bin2d" & Chr(34), lstParameterStrings:={Chr(34) & "bin2d" & Chr(34), Chr(34) & "identity" & Chr(34)})
        clsgeom_bin2d.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_bin2d.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_bin2d.AddLayerParameter("bins", "numeric", "30")
        clsgeom_bin2d.AddLayerParameter("binwidth", "numeric", "0.1")
        clsgeom_bin2d.AddLayerParameter("drop", "boolean", "FALSE")
        lstAllGeoms.Add(clsgeom_bin2d)


        clsgeom_blank.SetGeomName("geom_blank")
        'mandatory
        clsgeom_blank.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_blank.AddAesParameter("y", bIsMandatory:=True)
        'adding layer parameters
        clsgeom_blank.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_blank.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_blank.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_blank)



        clsgeom_boxplot.SetGeomName("geom_boxplot")
        'Mandatory Aesthetics
        clsgeom_boxplot.AddAesParameter("y", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        'Optional Aesthetics
        clsgeom_boxplot.AddAesParameter("x", strIncludedDataTypes:={"numeric", "factor"})
        'Warning: When x is continuous, there needs to be a grouping variable... for example cut_width(x,0.25). In our setting, a factor column can be used. If group is empty, R will send a warning message and ignore the x variable (still labels x though).
        'Task: Add a warning message in the front end to explain the necessity to specify group. Give suggestions on how to proceed (use an existing factor, create a new factor column using cut_width...). To do when front-end messages will have been sorted properly.
        clsgeom_boxplot.AddAesParameter("group", strIncludedDataTypes:={"factor"})

        'Warning: The following aesthetics should be assigned to calculations for the different parameters of a boxplot. Only relevant for sort of summaries. These are required if the stat of the geom_boxplot is changed to "identity" for instance.
        'clsgeom_boxplot.AddAesParameter("lower", strIncludedDataTypes:={"numeric"})
        'clsgeom_boxplot.AddAesParameter("upper", strIncludedDataTypes:={"numeric"})
        'clsgeom_boxplot.AddAesParameter("middle", strIncludedDataTypes:={"numeric"})
        'clsgeom_boxplot.AddAesParameter("ymax", strIncludedDataTypes:={"numeric"})
        'clsgeom_boxplot.AddAesParameter("ymin", strIncludedDataTypes:={"numeric"})

        clsgeom_boxplot.AddAesParameter("fill", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_boxplot.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_boxplot.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_boxplot.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_boxplot.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"}) 'Warning: map a factor with the size aes is not recommended (R message).
        clsgeom_boxplot.AddAesParameter("weight", strIncludedDataTypes:={"numeric"})
        clsgeom_boxplot.AddAesParameter("shape", strIncludedDataTypes:={"factor"})

        'adding layerParameters
        'Main geom_boxplot parameters
        clsgeom_boxplot.AddLayerParameter("notch", "boolean", "TRUE") 'Note: notch = FALSE + notchwidth = 0.7 works fine (i.e. can specify nothwidth with no notch)
        clsgeom_boxplot.AddLayerParameter("notchwidth", "numeric", "0.5", lstParameterStrings:={1}) 'Question to be discussed: this sets the width of the notch as a proportion of the boxplot width. Values can be anything in ggplot but negative ones just give a silly looking thing (I ve left it in for now, but would suggest we exclude ?), and I don't know if values above 1 make sense ? The notch would then be larger than the boxplot.
        clsgeom_boxplot.AddLayerParameter("varwidth", "boolean", "TRUE")
        clsgeom_boxplot.AddLayerParameter("coef", "numeric", "1.5", lstParameterStrings:={1}) 'Question to be discussed: This parameter is setting the length of the whiskers as a multiple of the IQR. When giving a negative value, the whiskers are simply of length 0. Also the window showing the graph doesn't adapt to the whiskers' length, which means they are simply cut when too long.
        clsgeom_boxplot.AddLayerParameter("outlier.shape", "list", Chr(34) & "circle" & Chr(34), lstParameterStrings:=strBoxShapePoint) 'Warning: there are other symbols that we can add here 
        clsgeom_boxplot.AddLayerParameter("outlier.colour", "colour", "NULL")
        clsgeom_boxplot.AddLayerParameter("outlier.size", "numeric", "1.5", lstParameterStrings:={1, 0})
        clsgeom_boxplot.AddLayerParameter("outlier.stroke", "numeric", "0.5", lstParameterStrings:={1, 0}) 'Outlier.stroke parameter gives the size of the outliers. It cannot be negative, this would trigger an error in R.
        clsgeom_boxplot.AddLayerParameter("fatten", "numeric", "2", lstParameterStrings:={0, 1, 5})
        'Global Layer parameters
        clsgeom_boxplot.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        'Warning: when x is continuous, position_dodge requires non-overlapping x intervals (would still work if not respected but sends a warning message).
        clsgeom_boxplot.AddLayerParameter("position", "list", Chr(34) & "dodge" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "fill" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "identity" & Chr(34)})
        'clsgeom_boxplot.AddLayerParameter("stat", "list", Chr(34) & "boxplot" & Chr(34), lstParameterStrings:={Chr(34) & "boxplot" & Chr(34), Chr(34) & "identity" & Chr(34)})
        'The stat is usually not changed in boxplot as it comes together with stat_boxplot. However identity can be taken as value for instance, but then all the aesthetics ymin, ymax, ... need to be filled.

        'Aesthetics as layer parameters... Used fo fix colour, transparence, ... of the geom on that Layer.
        clsgeom_boxplot.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34))
        clsgeom_boxplot.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_boxplot.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_boxplot.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})
        clsgeom_boxplot.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) ''Varies the size of outline. Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...

        lstAllGeoms.Add(clsgeom_boxplot)

        clsgeom_col.SetGeomName("geom_col")
        'Mandatory Aesthetics
        clsgeom_col.AddAesParameter("x", strIncludedDataTypes:=({"factor", "numeric"}), bIsMandatory:=True)
        clsgeom_col.AddAesParameter("y", strIncludedDataTypes:=({"factor", "numeric"}), bIsMandatory:=True)
        'Optional aesthetics
        clsgeom_col.AddAesParameter("alpha", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_col.AddAesParameter("fill", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_col.AddAesParameter("colour", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_col.AddAesParameter("linetype", strIncludedDataTypes:=({"factor"})) 'Warning: This distinguishes bars by varying the outline, however, the distinguished bars only visibly look different if the colour and the fill aesthetics take different values.
        clsgeom_col.AddAesParameter("size", strIncludedDataTypes:=({"factor", "numeric"}))
        'Geom_col layer parameters
        clsgeom_col.AddLayerParameter("width", "numeric", "0.90", lstParameterStrings:={2, 0, 1}) 'The width of the bars is given as a proportion of the data resolution.
        'Global Layer parameters
        clsgeom_col.AddLayerParameter("stat", "list", Chr(34) & "count" & Chr(34), lstParameterStrings:={Chr(34) & "count" & Chr(34), Chr(34) & "identity" & Chr(34)})
        clsgeom_col.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_col.AddLayerParameter("position", "list", Chr(34) & "stack" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})
        'See global comments about position.
        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_col.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34))
        clsgeom_col.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_col.AddLayerParameter("linetype", "numeric", "1", lstParameterStrings:={0, 0, 6})
        clsgeom_col.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1}) 'Note: alpha only acts on the fill for bars. The outline is not getting transparent.
        clsgeom_col.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) ''Varies the size of outline. Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...

        lstAllGeoms.Add(clsgeom_col)

        clsgeom_contour.SetGeomName("geom_contour")
        ''Mandatory
        clsgeom_contour.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_contour.AddAesParameter("y", bIsMandatory:=True)
        clsgeom_contour.AddAesParameter("z", bIsMandatory:=True)

        ''optional
        clsgeom_contour.AddAesParameter("alpha")
        clsgeom_contour.AddAesParameter("colour")
        clsgeom_contour.AddAesParameter("group")
        clsgeom_contour.AddAesParameter("linetype")
        clsgeom_contour.AddAesParameter("size")
        clsgeom_contour.AddAesParameter("weight")

        ''add layer parameters 
        clsgeom_contour.AddLayerParameter("stat", "editablelist", Chr(34) & "contour" & Chr(34), lstParameterStrings:={Chr(34) & "contour" & Chr(34)})
        clsgeom_contour.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_contour.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        clsgeom_contour.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        ''linemitre should 1 or a number >1
        clsgeom_contour.AddLayerParameter("linemitre", "numeric", "10", lstParameterStrings:={1, 1})
        clsgeom_contour.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_contour.AddLayerParameter("show.legend", "list", "NA", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_contour.AddLayerParameter("inherit.aes", "boolean", "TRUE")
        clsgeom_contour.AddLayerParameter("bins", "numeric", "1", lstParameterStrings:={0, 1})
        clsgeom_contour.AddLayerParameter("binwidth", "numeric", "0.01", lstParameterStrings:={3, 0.001})
        clsgeom_contour.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        ''bin and binwidth could be added here as well. I am not sure if they are needed.... 
        lstAllGeoms.Add(clsgeom_contour)

        clsgeom_count.SetGeomName("geom_count")
        'Mandatory Aesthetics
        clsgeom_count.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        clsgeom_count.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)

        'Optional Aesthetics 
        clsgeom_count.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_count.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_count.AddAesParameter("fill", strIncludedDataTypes:={"factor", "numeric"})
        'clsgeom_count.AddAesParameter("group", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_count.AddAesParameter("shape", strIncludedDataTypes:={"factor"})
        clsgeom_count.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        'we want to be able to assign the following options to size: ..n.. and ..prop..
        clsgeom_count.AddAesParameter("stroke", strIncludedDataTypes:={"factor", "numeric"})

        'Global layer parameters
        clsgeom_count.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34), "position_dodge()"})
        'we can use position adjustment functions here as well. For "dodge" option, R gives a warning: Width Not defined. Set with `position_dodge(width = ?). So we need to be able to set the width within position_dodge option here
        clsgeom_count.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_count.AddLayerParameter("stat", "list", Chr(34) & "sum" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "ecdf" & Chr(34), Chr(34) & "sum" & Chr(34), Chr(34) & "summary" & Chr(34), Chr(34) & "unique" & Chr(34)}) 'Warning, stat count cannot be used with y aesthetic !!!
        'revise the options here since identity and unique seem to return the plot to the orginal scatter plot. Summary option defaults to `mean_se() since no summary function supplied
        clsgeom_count.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_count.AddLayerParameter("shape", "list", Chr(34) & "circle" & Chr(34), lstParameterStrings:=strShapePoint)
        clsgeom_count.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_count.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1}) 'Warning: varies transparence of fill AND outline.
        'clsgeom_count.AddLayerParameter("size", "list", Chr(34) & "..n.." & Chr(34), lstParameterStrings:={Chr(34) & "..n.." & Chr(34), Chr(34) & "..prop.." & Chr(34)}) 'Note: negative size gives size 0 in general, but 'Warning, sometimesgive errors...
        ' we need for this be within the aes function not a layer parameter 
        clsgeom_count.AddLayerParameter("stroke", "numeric", "0.5", lstParameterStrings:={1, 0}) 'Use the stroke aes to change the width of the outline of the shapes. When no outline stroke overrides size. 'Warning: sometimes negative values give errors...
        clsgeom_count.AddLayerParameter("fill", "colour", Chr(34) & "black" & Chr(34))

        lstAllGeoms.Add(clsgeom_count)

        clsgeom_crossbar.strGeomName = "geom_crossbar"
        'Mandatory
        clsgeom_crossbar.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_crossbar.AddAesParameter("y", bIsMandatory:=True)
        clsgeom_crossbar.AddAesParameter("ymax", bIsMandatory:=True)
        clsgeom_crossbar.AddAesParameter("ymin", bIsMandatory:=True)
        'Optional
        clsgeom_crossbar.AddAesParameter("alpha")
        clsgeom_crossbar.AddAesParameter("colour")
        clsgeom_crossbar.AddAesParameter("linetype")
        clsgeom_crossbar.AddAesParameter("size")
        clsgeom_crossbar.AddAesParameter("fill")
        clsgeom_crossbar.AddAesParameter("group")
        clsgeom_crossbar.AddAesParameter("type")



        'adding layer parameters
        clsgeom_crossbar.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_crossbar.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "dodge" & Chr(34)})
        clsgeom_crossbar.AddLayerParameter("fatten", "numeric", "2.5", lstParameterStrings:={1, 1})
        clsgeom_crossbar.AddLayerParameter("width", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_crossbar.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_crossbar.AddLayerParameter("na.rm", "boolean", "FALSE")
        lstAllGeoms.Add(clsgeom_crossbar)

        clsgeom_curve.strGeomName = "geom_curve"
        'Mandatory Aesthetics  
        clsgeom_curve.AddAesParameter("x", strIncludedDataTypes:={"numeric"})
        clsgeom_curve.AddAesParameter("xend", strIncludedDataTypes:={"numeric"})
        clsgeom_curve.AddAesParameter("y", strIncludedDataTypes:={"numeric"})
        clsgeom_curve.AddAesParameter("yend", strIncludedDataTypes:={"numeric"})

        'Optional Aesthetics 
        clsgeom_curve.AddAesParameter("alpha", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_curve.AddAesParameter("colour", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_curve.AddAesParameter("linetype", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_curve.AddAesParameter("group", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_curve.AddAesParameter("size", strIncludedDataTypes:=({"factor", "numeric"})) 'using size for a discrete variable is not advised 

        'Layer parameter
        ' we can also set x, y, xend and yend outside of aes function 
        clsgeom_curve.AddLayerParameter("x", "numeric", "0", lstParameterStrings:={2})
        clsgeom_curve.AddLayerParameter("xend", "numeric", "0", lstParameterStrings:={2})
        clsgeom_curve.AddLayerParameter("y", "numeric", "0", lstParameterStrings:={2})
        clsgeom_curve.AddLayerParameter("yend", "numeric", "0", lstParameterStrings:={2})
        'clsgeom_curve.AddLayerParameter("arrow", "list", "NULL") 'need to use arrow() command here e.g. arrow = arrow(angle = 30, length = unit(0.25, "inches"), ends = "last", type = "open") 
        clsgeom_curve.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        clsgeom_curve.AddLayerParameter("curvature", "numeric", "0.5", lstParameterStrings:={1}) 'numeric values. negative values give a left hand curve while positive values give right hand curves
        clsgeom_curve.AddLayerParameter("angle", "numeric", "90", lstParameterStrings:={0, 0, 180}) 'needs to be 0-180
        clsgeom_curve.AddLayerParameter("ncp", "numeric", "5", lstParameterStrings:={0, 0})  'more control point creates a smoother curve

        'Global Layer Parameters 
        clsgeom_curve.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "ecdf" & Chr(34), Chr(34) & "sum" & Chr(34), Chr(34) & "summary" & Chr(34), Chr(34) & "unique" & Chr(34)})
        'sum and summary only work when x and y parameters are set within aes(). Summary option defaults to `mean_se() since no summary function supplied
        'think it's okay to have this greyed out for now because we only tend to use stat = "identity"
        clsgeom_curve.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})
        'other options for position are ignored when using geom curve on a scatter plot (geom_point) - R gives the following warnign: "Ignoring unknown parameters: identity"
        clsgeom_curve.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_curve.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        'Aesthetics as layer parameters 
        clsgeom_curve.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) 'Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...
        clsgeom_curve.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_curve.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_curve.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})

        lstAllGeoms.Add(clsgeom_curve)

        clsgeom_density.strGeomName = "geom_density"
        'Mandatory Aesthetics
        clsgeom_density.AddAesParameter("x", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True) 'Question/Task: Can take factors, doesn't give error. However don't know if that makes sense ? 
        'Optional Aesthetics
        'clsgeom_density.AddAesParameter("y", strIncludedDataTypes:={"numeric"})
        'Warning: we can map a numeric variable to y but we must include stat = “identity” inside the geom. However don't know how much sense this makes. Also all the geom_density parameters are actually stat_density parameters. Hence if stat is changed, get in trouble. Still can happen when y is inherited from global aes. Might be confusing for the user to leave out y as geom_density will actually take y from global aes ! 
        'Question to be discussed: So the only valid y value seems to be ..count.. which could be a tick on the dialog, that is then ticked automatically when position "stack" is used ?
        clsgeom_density.AddAesParameter("weight", strIncludedDataTypes:=({"numeric"})) 'Warning/question: Don't really understand how this is used. When I give a numeric variable, sends a warning message saying that our density plot won't be a real density plot, still plots. When given a factor, there is a plot but nothing on it + warning message.
        clsgeom_density.AddAesParameter("alpha", strIncludedDataTypes:=({"factor", "numeric"})) 'Varies transparence of the fill.
        clsgeom_density.AddAesParameter("fill", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_density.AddAesParameter("colour", strIncludedDataTypes:=({"factor", "numeric"})) 'Colour of the outline.
        clsgeom_density.AddAesParameter("linetype", strIncludedDataTypes:=({"factor"})) 'Outline linetype.
        clsgeom_density.AddAesParameter("size", strIncludedDataTypes:=({"factor", "numeric"})) 'Varies the size of the outline.

        'adding layer parameters
        'Geom_density layer parameters
        clsgeom_density.AddLayerParameter("bw", "list", Chr(34) & "nrd0" & Chr(34), lstParameterStrings:={Chr(34) & "nrd0" & Chr(34), Chr(34) & "SJ" & Chr(34), Chr(34) & "nrd" & Chr(34), Chr(34) & "ucv" & Chr(34), Chr(34) & "bcv" & Chr(34)}) 'Bandwidth.
        clsgeom_density.AddLayerParameter("adjust", "numeric", "1", lstParameterStrings:={1, 0}) 'The bandwidth used is actually adjust*bw. This makes it easy to specify values like ‘half the default’ bandwidth.
        clsgeom_density.AddLayerParameter("kernel", "list", Chr(34) & "gaussian" & Chr(34), lstParameterStrings:={Chr(34) & "gaussian" & Chr(34), Chr(34) & "rectangular" & Chr(34), Chr(34) & "triangular" & Chr(34), Chr(34) & "epanechnikov" & Chr(34), Chr(34) & "biweight" & Chr(34), Chr(34) & "cosine" & Chr(34), Chr(34) & "optcosin" & Chr(34)}) 'A character string giving the smoothing kernel to be used.
        'This is only a parameter in developer version of ggplot. May soon be in release version.
        'clsgeom_density.AddLayerParameter("n", "numeric", "512", lstParameterStrings:={0, 0}) 'The number of equally spaced points at which the density is to be estimated. When n > 512, it is rounded up to a power of 2 during the calculations. If negative, sends an error.
        clsgeom_density.AddLayerParameter("trim", "boolean", "FALSE")
        'This parameter only matters if you are displaying multiple densities in one plot. If FALSE, the default, each density is computed on the full range of the data. If TRUE, each density is computed over the range of that group: this typically means the estimated x values will not line-up, and hence you won't be able to stack density values.

        'Global Layer parameters
        'clsgeom_density.AddLayerParameter("stat", "list", Chr(34) & "density" & Chr(34), lstParameterStrings:={Chr(34) & "density" & Chr(34), Chr(34) & "identity" & Chr(34)}) 'Warning: commented out as when set to "identity", all the parameters bw, n, etc are unknown as they belong to stat_density. Think it's easier for now to not allow "identity" instead of introducing dependent exclusion of parameters.
        clsgeom_density.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_density.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "fill" & Chr(34), Chr(34) & "stack" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34)})
        'Warning: "Stacked density plots: if you want to create a stacked density plot, you probably want To 'count' (density * n) variable instead of the default density."
        'Question to be discussed: when changing parameter position to stack, should automatically add x="..count.." in the aesthetics parameters ? Carefull to not copy count into variable receivers, add methods like for "" in the boxplt case.
        'See global comments about position.

        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_density.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34))
        clsgeom_density.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_density.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_density.AddLayerParameter("alpha", "numeric", "0", lstParameterStrings:={2, 0, 1}) 'Varies transparence of fill.
        clsgeom_density.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) ''Varies the size of outline. Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...

        lstAllGeoms.Add(clsgeom_density)


        clsgeom_density2d.strGeomName = "geom_density2d"
        'Mandatory
        clsgeom_density2d.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_density2d.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        clsgeom_density2d.AddAesParameter("alpha")
        clsgeom_density2d.AddAesParameter("colour")
        clsgeom_density2d.AddAesParameter("group")
        clsgeom_density2d.AddAesParameter("linetype")
        clsgeom_density2d.AddAesParameter("size")

        ''Adding layer parameters
        'not sure of other stats and positions here
        clsgeom_density2d.AddLayerParameter("stat", "editablelist", Chr(34) & "density2d" & Chr(34), lstParameterStrings:={Chr(34) & "density2d" & Chr(34)})
        clsgeom_density2d.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_density2d.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        clsgeom_density2d.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        clsgeom_density2d.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_density2d.AddLayerParameter("show.legend", "list", "NA", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_density2d.AddLayerParameter("contour", "boolean", "FALSE")
        ''linemitre should 1 or a number >1
        clsgeom_density2d.AddLayerParameter("linemitre", "numeric", "1")
        clsgeom_density2d.AddLayerParameter("n", "numeric", "20")
        clsgeom_density2d.AddLayerParameter("h", "numeric", "20")
        lstAllGeoms.Add(clsgeom_density2d)

        'clsgeom_density_2d.strGeomName = "geom_density_2d"
        ''Mandatory
        'clsgeom_density_2d.AddAesParameter("x", bIsMandatory:=TRUE)
        'clsgeom_density_2d.AddAesParameter("y", bIsMandatory:=TRUE)
        ''optional
        'clsgeom_density_2d.AddAesParameter("alpha")
        'clsgeom_density_2d.AddAesParameter("colour")
        'clsgeom_density_2d.AddAesParameter("linetype")
        'clsgeom_density_2d.AddAesParameter("size")

        ''Adding layer parameters
        'clsgeom_density_2d.AddLayerParameter("stat", "list", Chr(34) & "density2d" & Chr(34))
        'clsgeom_density_2d.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_density_2d.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        'clsgeom_density_2d.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        ''linemitre should 1 or a number >1
        'clsgeom_density2d.AddLayerParameter("linemitre", "numeric", "1")
        'lstAllGeoms.Add(clsgeom_density_2d)

        Dim clsgeom_density_ridges As New Geoms

        clsgeom_density_ridges.SetGeomPackage("ggridges")
        clsgeom_density_ridges.strGeomName = "geom_density_ridges"
        'Mandatory Aesthetics
        clsgeom_density_ridges.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_density_ridges.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        'Other Aesthetics
        clsgeom_density_ridges.AddAesParameter("height")
        clsgeom_density_ridges.AddAesParameter("group")
        clsgeom_density_ridges.AddAesParameter("scale")
        clsgeom_density_ridges.AddAesParameter("min_height")
        'Aesthetics for colour, fill, group, alpha, linetype, Size, as in geom_ridgeline.
        clsgeom_density_ridges.AddAesParameter("colour")
        clsgeom_density_ridges.AddAesParameter("fill")
        'clsgeom_density_ridges.AddAesParameter("group")
        clsgeom_density_ridges.AddAesParameter("alpha")
        clsgeom_density_ridges.AddAesParameter("linetype")
        'clsgeom_density_ridges.AddAesParameter("Size")
        'Aesthetics for point_shape, point_colour, point_size, point_fill, point_alpha, point_stroke
        'clsgeom_density_ridges.AddAesParameter("point_shape")
        clsgeom_density_ridges.AddAesParameter("point_colour")
        'clsgeom_density_ridges.AddAesParameter("point_size")
        'clsgeom_density_ridges.AddAesParameter("point_fill")
        'clsgeom_density_ridges.AddAesParameter("point_alpha")
        'clsgeom_density_ridges.AddAesParameter("point_stroke")

        'adding layer parameters
        clsgeom_density_ridges.AddLayerParameter("stat", "list", Chr(34) & "density_ridges" & Chr(34), lstParameterStrings:={Chr(34) & "density_ridges" & Chr(34), Chr(34) & "binline" & Chr(34)})
        clsgeom_density_ridges.AddLayerParameter("position", "list", Chr(34) & "points_sina" & Chr(34), lstParameterStrings:={Chr(34) & "points_sina" & Chr(34), Chr(34) & "points_jitter" & Chr(34), Chr(34) & "raincloud" & Chr(34)})
        clsgeom_density_ridges.AddLayerParameter("panel_scaling", "list", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_density_ridges.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_density_ridges.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_density_ridges.AddLayerParameter("inherit.aes", "list", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_density_ridges.AddLayerParameter("jittered_points", "list", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_density_ridges.AddLayerParameter("alpha", "numeric", "0.7", lstParameterStrings:={1, 0})
        clsgeom_density_ridges.AddLayerParameter("scale", "numeric", "1")
        clsgeom_density_ridges.AddLayerParameter("point_shape", "editablelist", "|", lstParameterStrings:={"|", "/", "$", "#", "*", "?", "!"})
        clsgeom_density_ridges.AddLayerParameter("point_size", "numeric", "3")
        clsgeom_density_ridges.AddLayerParameter("point_alpha", "numeric", "1", lstParameterStrings:={1, 0})
        lstAllGeoms.Add(clsgeom_density_ridges)

        Dim clsgeom_density_ridges2 As New Geoms

        clsgeom_density_ridges2.SetGeomPackage("ggridges")
        clsgeom_density_ridges2.strGeomName = "geom_density_ridges2"
        'Mandatory Aesthetics
        clsgeom_density_ridges2.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_density_ridges2.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        clsgeom_density_ridges2.AddAesParameter("fill", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_density_ridges2.AddAesParameter("height")
        clsgeom_density_ridges2.AddAesParameter("group")
        clsgeom_density_ridges2.AddAesParameter("scale")
        clsgeom_density_ridges2.AddAesParameter("min_height")
        'Aesthetics for colour, fill, group, alpha, linetype, Size, as in geom_ridgeline.
        clsgeom_density_ridges2.AddAesParameter("colour")
        'clsgeom_density_ridges2.AddAesParameter("group")
        clsgeom_density_ridges2.AddAesParameter("alpha")
        clsgeom_density_ridges2.AddAesParameter("linetype")
        'clsgeom_density_ridges2.AddAesParameter("Size")
        'Aesthetics for point_shape, point_colour, point_size, point_fill, point_alpha, point_stroke
        'clsgeom_density_ridges2.AddAesParameter("point_shape")
        clsgeom_density_ridges2.AddAesParameter("point_colour")
        'clsgeom_density_ridges2.AddAesParameter("point_size")
        'clsgeom_density_ridges2.AddAesParameter("point_fill")
        'clsgeom_density_ridges2.AddAesParameter("point_alpha")
        'clsgeom_density_ridges2.AddAesParameter("point_stroke")

        'adding layer parameters
        clsgeom_density_ridges2.AddLayerParameter("stat", "list", Chr(34) & "density_ridges" & Chr(34), lstParameterStrings:={Chr(34) & "density_ridges" & Chr(34), Chr(34) & "binline" & Chr(34)})
        clsgeom_density_ridges2.AddLayerParameter("position", "list", Chr(34) & "points_sina" & Chr(34), lstParameterStrings:={Chr(34) & "points_sina" & Chr(34)})
        clsgeom_density_ridges2.AddLayerParameter("panel_scaling", "list", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_density_ridges2.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_density_ridges2.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_density_ridges2.AddLayerParameter("inherit.aes", "list", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_density_ridges2)

        Dim clsgeom_density_ridges_gradient As New Geoms

        clsgeom_density_ridges_gradient.SetGeomPackage("ggridges")
        clsgeom_density_ridges_gradient.strGeomName = "geom_density_ridges_gradient"
        'Mandatory Aesthetics
        clsgeom_density_ridges_gradient.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_density_ridges_gradient.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        'Other Aesthetics
        clsgeom_density_ridges_gradient.AddAesParameter("fill", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_density_ridges_gradient.AddAesParameter("height")
        clsgeom_density_ridges_gradient.AddAesParameter("group")
        clsgeom_density_ridges_gradient.AddAesParameter("scale")
        clsgeom_density_ridges_gradient.AddAesParameter("min_height")
        'Aesthetics for colour, fill, group, alpha, linetype, Size, as in geom_ridgeline.
        clsgeom_density_ridges_gradient.AddAesParameter("colour")
        'clsgeom_density_ridges_gradient.AddAesParameter("group")
        clsgeom_density_ridges_gradient.AddAesParameter("alpha")
        clsgeom_density_ridges_gradient.AddAesParameter("linetype")
        'clsgeom_density_ridges_gradient.AddAesParameter("Size")
        'Aesthetics for point_shape, point_colour, point_size, point_fill, point_alpha, point_stroke
        'clsgeom_density_ridges_gradient.AddAesParameter("point_shape")
        clsgeom_density_ridges_gradient.AddAesParameter("point_colour")
        'clsgeom_density_ridges_gradient.AddAesParameter("point_size")
        'clsgeom_density_ridges_gradient.AddAesParameter("point_fill")
        'clsgeom_density_ridges_gradient.AddAesParameter("point_alpha")
        'clsgeom_density_ridges_gradient.AddAesParameter("point_stroke")

        'adding layer parameters
        clsgeom_density_ridges_gradient.AddLayerParameter("stat", "list", Chr(34) & "density_ridges" & Chr(34), lstParameterStrings:={Chr(34) & "density_ridges" & Chr(34), Chr(34) & "binline" & Chr(34)})
        clsgeom_density_ridges_gradient.AddLayerParameter("position", "list", Chr(34) & "points_sina" & Chr(34), lstParameterStrings:={Chr(34) & "points_sina" & Chr(34)})
        clsgeom_density_ridges_gradient.AddLayerParameter("panel_scaling", "list", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_density_ridges_gradient.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_density_ridges_gradient.AddLayerParameter("gradient_lwd", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_density_ridges_gradient.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_density_ridges_gradient.AddLayerParameter("inherit.aes", "list", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})

        lstAllGeoms.Add(clsgeom_density_ridges_gradient)


        clsgeom_dotplot.strGeomName = "geom_dotplot"

        'Aesthetics parameters
        clsgeom_dotplot.AddAesParameter("x", strIncludedDataTypes:={"numeric", "factor"}) 'x is partially mandatory, need to be given value "" (or anything) when not filled.
        clsgeom_dotplot.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"})
        'When the binaxis is y, then if x is a factor or character, several dotplots lines are displayed according to each group along the x axis. 
        'When the binaxis is x, and y is a factor or character, dot stacks are split according to the y mapping, but not aligned with the labels along the y axis. So all stacks stay at the bottom. Also this is visible only if stackratio < 1, and stackgroups = FALSE.
        'However, when binaxis is x/y and y/x is continuous, the axis label is changed but that's all the mapping does. Still the number of dots represent the number of stacked dots represent the number of events in each bin.
        'Date variables give silly outcomes but no crash/error/warning.

        clsgeom_dotplot.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"}) 'Warning: varies transparence of both the fill and the outline.
        clsgeom_dotplot.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_dotplot.AddAesParameter("fill", strIncludedDataTypes:={"factor", "numeric"})

        'Adding layer parameters
        'Geom_dotplot layer parameters
        'Warning: when a parameter is irrelevant (e.g. mentioning 'width' when 'binaxis' is "x" or 'right' when 'method' is "dotdensity"), this parameter is simply ignored...

        clsgeom_dotplot.AddLayerParameter("method", "list", Chr(34) & "dotdensity" & Chr(34), lstParameterStrings:={Chr(34) & "dotdensity" & Chr(34), Chr(34) & "histodot" & Chr(34)}) 'For when the binaxis is continuous, "dotdensity" (default) for dot-density binning, or "histodot" for fixed bin widths (like stat_bin)
        clsgeom_dotplot.AddLayerParameter("binwidth", "numeric", "1", lstParameterStrings:={2, 0.01}) 'When method is "dotdensity", this specifies maximum bin width. When method is "histodot", this specifies bin width. Defaults to 1/30 of the range of the data, need to be strictly positive.
        'Warning: here default has been set to 1 as calculating 1/30 of the range of the data is not possible. 
        clsgeom_dotplot.AddLayerParameter("binaxis", "list", Chr(34) & "x" & Chr(34), lstParameterStrings:={Chr(34) & "x" & Chr(34), Chr(34) & "y" & Chr(34)}) 'The axis to bin along
        clsgeom_dotplot.AddLayerParameter("binpositions", "list", Chr(34) & "bygroup" & Chr(34), lstParameterStrings:={Chr(34) & "bygroup" & Chr(34), Chr(34) & "all" & Chr(34)}) 'When method is "dotdensity", "bygroup" (default) determines positions of the bins for each group separately. "all" determines positions of the bins with all the data taken together; this is used for aligning dot stacks across multiple groups.
        clsgeom_dotplot.AddLayerParameter("stackdir", "list", Chr(34) & "up" & Chr(34), lstParameterStrings:={Chr(34) & "up" & Chr(34), Chr(34) & "down" & Chr(34), Chr(34) & "center" & Chr(34), Chr(34) & "centerwhole" & Chr(34)}) 'which direction to stack the dots. "centerwhole" (centered, but with dots aligned)
        clsgeom_dotplot.AddLayerParameter("stackratio", "numeric", "1", lstParameterStrings:={1}) 'how close to stack the dots. Default is 1, where dots just just touch. Use smaller values for closer, overlapping dots. Negative values sort of revert the direction of stacking.
        clsgeom_dotplot.AddLayerParameter("dotsize", "numeric", "1", lstParameterStrings:={1}) 'The diameter of the dots relative to binwidth, default 1
        'Warning: negative values seem to result in having the dots stacking downwards. However the window on the graph does not adapt... No errors
        clsgeom_dotplot.AddLayerParameter("stackgroups", "boolean", "FALSE") 'should dots be stacked across groups? This has the effect that position = "stack" should have, but can't (because this geom has some odd properties)
        clsgeom_dotplot.AddLayerParameter("origin", "numeric", "0", lstParameterStrings:={1}) 'When method is "histodot", origin of first bin, and moves all subsequent bins accordingly (shift)
        clsgeom_dotplot.AddLayerParameter("right", "boolean", "TRUE") 'When method is "histodot", should intervals be closed on the right (a, b], or not [a, b)
        clsgeom_dotplot.AddLayerParameter("width", "numeric", "0.9", lstParameterStrings:={1, 0}) 'When binaxis is "y", the spacing of the dot stacks for dodging. 
        'Warning: didn't manage to get any visible changes on the graph.
        clsgeom_dotplot.AddLayerParameter("drop", "boolean", "FALSE") 'If TRUE, remove all bins with zero counts
        'Warning/question: as bins with zero counts have zero dots, what is meant by remove ? Can't see any difference on the graphs when changing drop.
        'Global Layer parameters
        'Warning: stat is not a parameter of geom_dotplot. Anyway the stat that is used is "bindot".
        clsgeom_dotplot.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_dotplot.AddLayerParameter("position", "list", Chr(34) & "stack" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})

        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_dotplot.AddLayerParameter("fill", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_dotplot.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_dotplot.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1}) 'Warning: varies transparence of fill AND outline.

        lstAllGeoms.Add(clsgeom_dotplot)


        clsgeom_dumbbell.SetGeomName("geom_dumbbell")
        clsgeom_dumbbell.SetGeomPackage("ggalt")

        'Mandatory Aesthetics
        clsgeom_dumbbell.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        clsgeom_dumbbell.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        clsgeom_dumbbell.AddAesParameter("xend", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)

        'Optional Aesthetics
        'In the geom_dimbbell, yend is given as a mandatory aesthetic but in running the function it is not mandatory so am including it under optional aesthetics
        clsgeom_dumbbell.AddAesParameter("yend", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_dumbbell.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_dumbbell.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_dumbbell.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_dumbbell.AddAesParameter("linetype", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_dumbbell.AddAesParameter("group", strIncludedDataTypes:={"factor", "numeric"})

        'Layer parameters
        clsgeom_dumbbell.AddLayerParameter("colour_x", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_dumbbell.AddLayerParameter("colour_xend", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_dumbbell.AddLayerParameter("size_x", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_dumbbell.AddLayerParameter("size_xend", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_dumbbell.AddLayerParameter("dot_guide", "boolean", "TRUE", lstParameterStrings:={"TRUE", "FALSE"}) 'If True Then, a leading dotted line will be placed before the left-most dumbbell point.
        clsgeom_dumbbell.AddLayerParameter("dot_guide_colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_dumbbell.AddLayerParameter("dot_guide_size", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_dumbbell.AddLayerParameter("na.rm", "boolean", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_dumbbell.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_dumbbell.AddLayerParameter("inherit.aes", "boolean", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})

        lstAllGeoms.Add(clsgeom_dumbbell)


        clsgeom_encircle.SetGeomPackage("ggalt")
        clsgeom_encircle.SetGeomName("geom_encircle")

        'Mandatory Aesthetics 
        clsgeom_encircle.AddAesParameter("x", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        ' will want to be able to take a subset of the data here, so the encircle circles points with those requirements
        clsgeom_encircle.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)

        'Optional Aesthetics 
        clsgeom_encircle.AddAesParameter("alpha", strIncludedDataTypes:=({"factor", "numeric"})) 'Varies transparence of the fill.
        clsgeom_encircle.AddAesParameter("fill", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_encircle.AddAesParameter("colour", strIncludedDataTypes:=({"factor", "numeric"})) 'Colour of the outline.
        clsgeom_encircle.AddAesParameter("linetype", strIncludedDataTypes:=({"factor"})) 'Outline linetype.
        clsgeom_encircle.AddAesParameter("size", strIncludedDataTypes:=({"factor", "numeric"})) 'using size for a factor is not advised 

        'Layer Parameters (geom_encircle)
        clsgeom_encircle.AddLayerParameter("s_shape", "numeric", "0.5", lstParameterStrings:={1, 0, 2})
        clsgeom_encircle.AddLayerParameter("s_open", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_encircle.AddLayerParameter("expand", "numeric", "0.05", lstParameterStrings:={2})
        clsgeom_encircle.AddLayerParameter("spread", "numeric", "0.1", lstParameterStrings:={1})
        'spread only appears to have an effect if a subset of the data is taken which is assigned to the data parameter 

        'Global Layer Parameters 
        clsgeom_encircle.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "ecdf" & Chr(34), Chr(34) & "sum" & Chr(34), Chr(34) & "summary" & Chr(34), Chr(34) & "unique" & Chr(34)})
        clsgeom_encircle.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34), "position_dodge()"})
        'we can use position adjustment functions here as well. For "dodge" option, R gives a warning: Width Not defined. Set with `position_dodge(width = ?). So we need to be able to set the width within position_dodge option here
        clsgeom_encircle.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_encircle.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})

        'Aesthetics as layer parameters 
        clsgeom_encircle.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_encircle.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1}) 'alpha changes the transparency of line. When fill parameter is used alpha changes the transparaty of the fill
        clsgeom_encircle.AddLayerParameter("size", "numeric", "1", lstParameterStrings:={1, 0})
        clsgeom_encircle.AddLayerParameter("linetype", "list", Chr(34) & "solid" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_encircle.AddLayerParameter("fill", "colour", Chr(34) & "black" & Chr(34)) 'Note: only a small minority of shapes can be filled.

        lstAllGeoms.Add(clsgeom_encircle)

        clsgeom_errorbar.strGeomName = "geom_errorbar"
        '' Mandatory
        clsgeom_errorbar.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_errorbar.AddAesParameter("ymax", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_errorbar.AddAesParameter("ymin", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        ''Optional
        clsgeom_errorbar.AddAesParameter("alpha", strIncludedDataTypes:={"factor"})
        clsgeom_errorbar.AddAesParameter("colour", strIncludedDataTypes:={"factor"})
        clsgeom_errorbar.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_errorbar.AddAesParameter("size", strIncludedDataTypes:={"factor"})
        clsgeom_errorbar.AddAesParameter("width", strIncludedDataTypes:={"numeric"})
        'adding layer parameters
        clsgeom_errorbar.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_errorbar.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_errorbar.AddLayerParameter("orienatation", "list", "NA", lstParameterStrings:={"NA", "x", "y"})
        clsgeom_errorbar.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_errorbar.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})

        lstAllGeoms.Add(clsgeom_errorbar)

        clsgeom_errorbarh.strGeomName = "geom_errorbarh"
        'mandatory
        clsgeom_errorbarh.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_errorbarh.AddAesParameter("xmax", bIsMandatory:=True)
        clsgeom_errorbarh.AddAesParameter("xmin", bIsMandatory:=True)
        clsgeom_errorbarh.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_errorbarh.AddAesParameter("alpha")
        clsgeom_errorbarh.AddAesParameter("colour")
        clsgeom_errorbarh.AddAesParameter("height")
        clsgeom_errorbarh.AddAesParameter("linetype")
        clsgeom_errorbarh.AddAesParameter("size")

        ''add layer parameters
        clsgeom_errorbarh.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_errorbarh.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_errorbarh.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_errorbarh.AddLayerParameter("size", "numeric", "1", lstParameterStrings:={0, 0})
        clsgeom_errorbarh.AddLayerParameter("height", "numeric", "0.2", lstParameterStrings:={1, 0})
        clsgeom_errorbarh.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_errorbarh.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_errorbarh)

        clsgeom_freqpoly.strGeomName = "geom_freqpoly"
        'Adding aesthetics parameters.
        clsgeom_freqpoly.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True) 'Note: Mapping a factor to x is possible but requires stat "identity" ("count" doesn't give any results, but no error, just warning). However the output is the same as if we would have used line... Left it as it is to avoid complications even though things that are allowed are usually included.
        'Warning: a continuous variable can be mapped to y but stat= "identity" must be included within the geom. Very silly results, but differetn from geom_line so...
        clsgeom_freqpoly.AddAesParameter("y", strIncludedDataTypes:={"numeric"})
        clsgeom_freqpoly.AddAesParameter("weight", strIncludedDataTypes:={"numeric"}) 'An alternative to mapping something to y...
        clsgeom_freqpoly.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_freqpoly.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_freqpoly.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_freqpoly.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})

        'Add layer parameters
        'Geom_freqpoly parameters
        clsgeom_freqpoly.AddLayerParameter("binwidth", "numeric", "1", lstParameterStrings:={2, 0.01}) 'Defaults to 1/30 of the range of the data, need to be strictly positive.
        'Warning: here default has been set to 1 as calculating 1/30 of the range of the data is not possible. 
        clsgeom_freqpoly.AddLayerParameter("bins", "numeric", "30", lstParameterStrings:={0, 1}) 'Number of bins. Overridden by binwidth. Defaults to 30, need at least one.
        clsgeom_freqpoly.AddLayerParameter("center", "numeric", "0", lstParameterStrings:={1}) 'Finds the bin that is closest to that "centre" and centres that bin on it. All other bins are then shifted accordingly. Note that If center Is above Or below the range Of the data, things will oficcially be shifted by an appropriate number Of widths (testing shows that nothing actually happens in this version of R, wait for next version). To center On integers, for example, use width=1 And center=0, even if 0 Is outside the range of the data. At most one of center And boundary may be specified.
        clsgeom_freqpoly.AddLayerParameter("boundary", "numeric", "0", lstParameterStrings:={1}) 'Finds the bin with the closest boundary to this "boudary" and shifts that bin for the boundary to be on that value. All other bins are then shifted accordingly. As with center, things are shifted when boundary is outside the range of the data (testing shows that nothing actually happens in this version of R, wait for next version). For example, to center on integers, use width = 1 and boundary = 0.5, even if 1 is outside the range of the data. At most one of center and boundary may be specified.
        'Warning to be discussed: as mentioned above, only one of the two preceding parameters can be called at a time. If both are mentioned, an error is sent and the software crashes. Should introduce this case in the declaration of parameters ?
        clsgeom_freqpoly.AddLayerParameter("closed", "list", Chr(34) & "left" & Chr(34), lstParameterStrings:={Chr(34) & "left" & Chr(34), Chr(34) & "right" & Chr(34)})      'One of "right" Or "left" indicating whether right Or left edges of bins are included in the bin.
        clsgeom_freqpoly.AddLayerParameter("pad", "boolean", "FALSE") 'If TRUE Then, adds empty bins at either End Of x. This ensures frequency polygons touch 0. Defaults To FALSE.
        'Global Layer parameters
        clsgeom_freqpoly.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_freqpoly.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})
        clsgeom_freqpoly.AddLayerParameter("stat", "list", Chr(34) & "bin" & Chr(34), lstParameterStrings:={Chr(34) & "bin" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "count" & Chr(34)}) 'Note, count and identity simply give the same results as with geom_line.
        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_density.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_freqpoly.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_freqpoly.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1}) 'Warning: varies transparence of fill AND outline.
        clsgeom_freqpoly.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) ''Varies the size of outline. Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...

        lstAllGeoms.Add(clsgeom_freqpoly)


        clsgeom_function.strGeomName = "geom_function"
        'mandatory
        clsgeom_function.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_function.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_function.AddAesParameter("alpha")
        clsgeom_function.AddAesParameter("colour")
        clsgeom_function.AddAesParameter("group")
        clsgeom_function.AddAesParameter("height")
        clsgeom_function.AddAesParameter("linetype")
        clsgeom_function.AddAesParameter("size")

        ''add layer parameters
        clsgeom_function.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_function.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_function.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_function.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_function.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_function.AddLayerParameter("fun", "list", "dnorm", lstParameterStrings:={"dnorm"})
        clsgeom_function.AddLayerParameter("n", "numeric", "10", lstParameterStrings:={0, 0})
        lstAllGeoms.Add(clsgeom_function)

        clsgeom_hex.strGeomName = "geom_hex"
        'mandatory
        clsgeom_hex.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_hex.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_hex.AddAesParameter("alpha")
        clsgeom_hex.AddAesParameter("colour")
        clsgeom_hex.AddAesParameter("fill")
        clsgeom_hex.AddAesParameter("size")

        'add layer parameter 
        clsgeom_hex.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_hex.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_hex.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_hex.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_hex)

        clsgeom_hline.SetGeomName("geom_hline") 'Warning: this geom never inherits global aesthetics ! It also doesn't affect the x and y scales. Can specify yintercept either with aes, or with parameter (second one overwrites). If want to vary with facets, need to mention as aes.
        'Warning: it does not have position or stat, neither inherit.aes parameters. However, when mentioned, these are simply ignored... 
        'Task: untick and disable IgnoreGlobalAes and ApplyOnAllLayers for this geom.
        'Task: add warning message to user...
        'Adding aesthetics parameters
        'Mandatory Aesthetics
        clsgeom_hline.AddAesParameter("yintercept", strIncludedDataTypes:={"numeric"})
        'Warning/to be discussed: when this is set as parameter, it is not really mandatory... should we introduce a partially mandatory method nbr 2 ? For now I think it can be left like this...
        'Optional aesthetics
        clsgeom_hline.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_hline.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_hline.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_hline.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        'Adding layer parameters
        'Geom_hline parameters
        clsgeom_hline.AddLayerParameter("yintercept", "numeric", "0", lstParameterStrings:={2}) 'Parameter that controls the position of the line. If this is set, data, mapping and show.legend are overridden
        'Task: add warning message to user...
        'Global Layer parameters
        clsgeom_hline.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_hline.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_hline.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_hline.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})
        clsgeom_hline.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) ''Varies the size of outline. Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...

        lstAllGeoms.Add(clsgeom_hline)

        clsgeom_histogram.SetGeomName("geom_histogram")
        'Adding aesthetics parameters
        'Mandatory Aesthetics
        clsgeom_histogram.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        'Optional aesthetics
        clsgeom_histogram.AddAesParameter("weight", strIncludedDataTypes:={"numeric"})
        clsgeom_histogram.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_histogram.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_histogram.AddAesParameter("fill", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_histogram.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_histogram.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})

        'Adding layer parameters
        'Geom_histogram parameters
        clsgeom_histogram.AddLayerParameter("binwidth", "numeric", "1", lstParameterStrings:={2, 0.01}) 'Defaults to 1/30 of the range of the data, need to be strictly positive.
        'Warning: here default has been set to 1 as calculating 1/30 of the range of the data is not possible. 
        clsgeom_histogram.AddLayerParameter("bins", "numeric", "30", lstParameterStrings:={0, 1}) 'Number of bins. Overridden by binwidth. Defaults to 30, need at least one.
        clsgeom_histogram.AddLayerParameter("center", "numeric", "0", lstParameterStrings:={1}) 'Finds the bin that is closest to that "centre" and centres that bin on it. All other bins are then shifted accordingly. Note that If center Is above Or below the range Of the data, things will oficcially be shifted by an appropriate number Of widths (testing shows that nothing actually happens in this version of R, wait for next version). To center On integers, for example, use width=1 And center=0, even if 0 Is outside the range of the data. At most one of center And boundary may be specified.
        clsgeom_histogram.AddLayerParameter("boundary", "numeric", "0", lstParameterStrings:={1}) 'Finds the bin with the closest boundary to this "boudary" and shifts that bin for the boundary to be on that value. All other bins are then shifted accordingly. As with center, things are shifted when boundary is outside the range of the data (testing shows that nothing actually happens in this version of R, wait for next version). For example, to center on integers, use width = 1 and boundary = 0.5, even if 1 is outside the range of the data. At most one of center and boundary may be specified.
        'Warning to be discussed: as mentioned above, only one of the two preceding parameters can be called at a time. If both are mentioned, an error is sent and the software crashes. Should introduce this case in the declaration of parameters ?
        clsgeom_histogram.AddLayerParameter("closed", "list", Chr(34) & "left" & Chr(34), lstParameterStrings:={Chr(34) & "left" & Chr(34), Chr(34) & "right" & Chr(34)})      'One of "right" Or "left" indicating whether right Or left edges of bins are included in the bin.
        clsgeom_histogram.AddLayerParameter("pad", "boolean", "FALSE") 'If TRUE Then, adds empty bins at either End Of x. This ensures frequency polygons touch 0. Defaults To FALSE.

        'Global Layer parameters
        clsgeom_histogram.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_histogram.AddLayerParameter("position", "list", Chr(34) & "stack" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "stack" & Chr(34), "position = position_stack(reverse = TRUE)", Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})

        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_histogram.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34))
        clsgeom_histogram.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_histogram.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_histogram.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1}) 'Note: alpha only acts on the fill for bars. The outline is not getting transparent.
        clsgeom_histogram.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) ''Varies the size of outline. Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...

        lstAllGeoms.Add(clsgeom_histogram)


        clsgeom_jitter.SetGeomName("geom_jitter")
        'Mandatory aesthetics : here x and y are mandatory, however, when not filled, default values "" are given. Alternatively, if we want to have at least on filled, could add bIsDependentlyMandatory:=TRUE in both. Planning on refining the mandatory aes methods to include the "" cases systematically.
        'I am currently making these two mandatory
        clsgeom_jitter.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_jitter.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"})
        'optional
        clsgeom_jitter.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_jitter.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_jitter.AddAesParameter("shape", strIncludedDataTypes:={"factor"})
        clsgeom_jitter.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_jitter.AddAesParameter("stroke", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_jitter.AddAesParameter("fill", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_jitter.AddAesParameter("label", strIncludedDataTypes:={"factor", "numeric", "character", "Date"})
        'Adding layer parameters
        'Geom_jitter Parameters
        'Amount of vertical and horizontal jitter. The jitter is added in both positive and negative directions, so the total spread is twice the value specified here. If omitted, defaults to 40% of the resolution of the data: this means the jitter values will occupy 80% of the implied bins. Categorical data is aligned on the integers, so a width or height of 0.5 will spread the data so it's not possible to see the distinction between the categories.
        clsgeom_jitter.AddLayerParameter("height", "numeric", "0", lstParameterStrings:={2, 0, 1})
        clsgeom_jitter.AddLayerParameter("width", "numeric", "0", lstParameterStrings:={1})
        'Global Layer parameters
        'clsgeom_jitter.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34),Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34), "position_jitterdodge()"})
        clsgeom_jitter.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "bin" & Chr(34), Chr(34) & "count" & Chr(34), Chr(34) & "desnity" & Chr(34), Chr(34) & "ecdf" & Chr(34), Chr(34) & "sum" & Chr(34), Chr(34) & "summary" & Chr(34), Chr(34) & "unique" & Chr(34)}) 'Warning, stat count cannot be used with y aesthetic !!!
        clsgeom_jitter.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_jitter.AddLayerParameter("shape", "list", Chr(34) & "circle" & Chr(34), lstParameterStrings:=strShapePoint)
        clsgeom_jitter.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_jitter.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1}) 'Warning: varies transparence of fill AND outline.
        clsgeom_jitter.AddLayerParameter("size", "numeric", "1.5", lstParameterStrings:={1, 0}) 'Note: negative size gives size 0 in general, but 'Warning, sometimesgive errors...
        clsgeom_jitter.AddLayerParameter("stroke", "numeric", "0.5", lstParameterStrings:={1, 0}) 'Use the stroke aes to change the width of the outline of the shapes. When no outline stroke overrides size. 'Warning: sometimes negative values give errors...
        clsgeom_jitter.AddLayerParameter("fill", "colour", Chr(34) & "black" & Chr(34)) 'Note: only a small minority of shapes can be filled.

        lstAllGeoms.Add(clsgeom_jitter)

        clsgeom_label.SetGeomName("geom_label") 'Note: can also add text on the graph via annotate (to be added on sdgplots).
        'Adding aesthetics parameters
        'Mandatory Aesthetics
        clsgeom_label.AddAesParameter("x", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        clsgeom_label.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        clsgeom_label.AddAesParameter("label", strIncludedDataTypes:={"numeric", "factor", "character", "Date"}, bIsMandatory:=True)
        'Optional aesthetics
        clsgeom_label.AddAesParameter("fill", strIncludedDataTypes:={"factor", "numeric"}) 'Note: for the background of the label 
        clsgeom_label.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"}) 'Note: for the text
        clsgeom_label.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"}) 'size of the font
        clsgeom_label.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        'The following aesthetics are arguably more relevant as parameters. Setting them as parameters overwrites the aes mapping.
        clsgeom_label.AddAesParameter("family", strIncludedDataTypes:={"factor"})
        clsgeom_label.AddAesParameter("fontface", strIncludedDataTypes:={"factor"})
        clsgeom_label.AddAesParameter("lineheight", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_label.AddAesParameter("hjust", strIncludedDataTypes:={"numeric"}) 'position of the anchor (0=left edge, 1=right edge), can go below 0 or above 1 
        clsgeom_label.AddAesParameter("vjust", strIncludedDataTypes:={"numeric"}) 'position of the anchor (0=bottom edge, 1=top edge), can go below 0 or above 1 
        clsgeom_label.AddAesParameter("angle", strIncludedDataTypes:={"factor", "numeric"})
        'Adding layer parameters
        'Geom_label Parameters
        clsgeom_label.AddLayerParameter("label.size", "numeric", "0.5", lstParameterStrings:={1, 0}) 'Size of label border, in mm, 0 gives minimum size (nonzero), negative gives error.
        'Warning: The two following parameters need to specified with the help of unit objects... unit(value, unit), so need a type of parameter "unit".
        'clsgeom_label.AddLayerParameter("label.padding", "numeric", "0.25", lstParameterStrings:={2, 0}) 'Amount of padding around label. Defaults to 0.25 lines. 
        'clsgeom_label.AddLayerParameter("label.r", "numeric", "0.15", lstParameterStrings:={2, 0}) 'Radius of rounded corners. Defaults to 0.15 lines.
        clsgeom_label.AddLayerParameter("nudge_x", "numeric", "0.15", lstParameterStrings:={2}) 'Warning: cnnot use both position and nudge_x;nudge_y !!! Doesn't crash the software...
        clsgeom_label.AddLayerParameter("nudge_y", "numeric", "0.15", lstParameterStrings:={2}) 'Horizontal and vertical adjustment to nudge labels by (if nonzero, avoid superposition, then can accentuate in both directions, negative or positive). Useful for offsetting text from points, particularly on discrete scales. 
        clsgeom_label.AddLayerParameter("check_overlap", "boolean", "FALSE") 'If TRUE, text that overlaps previous text in the same layer will not be plotted. A quick and dirty way
        clsgeom_label.AddLayerParameter("parse", "boolean", "FALSE") 'If TRUE, the labels will be parsed into expressions and displayed as described in ?plotmath
        'Global Layer parameters
        clsgeom_label.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_label.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "stack" & Chr(34), "position_dodge(width = 0.9)", Chr(34) & "dodge2" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)}) 'Warning/Task: really need to specify values for width in position_dodge, as "dodge" doesn't have default values for this geom (sends a warning). This is necessary if you want to get the labels on top of dodged bars for instance... For the moment added position_jitterdodge() that works fine.
        'Warning: cannot use both position and nudge_x;nudge_y !!! Doesn't crash the software...
        clsgeom_label.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "bin" & Chr(34), Chr(34) & "count" & Chr(34), Chr(34) & "density" & Chr(34), Chr(34) & "sum" & Chr(34), Chr(34) & "unique" & Chr(34)}) 'Warning: stat count cannot be used with y aesthetic !!! 'Warning: summary and ecdf is source of errors.
        'Aesthetics as layer parameters.
        clsgeom_label.AddLayerParameter("family", "list", Chr(34) & Chr(34), lstParameterStrings:={Chr(34) & Chr(34), Chr(34) & "serif" & Chr(34), Chr(34) & "sans" & Chr(34), Chr(34) & "mono" & Chr(34), Chr(34) & "symbol" & Chr(34)}) 'Warning: could add more fonts, maybe use extrafonts package ?
        clsgeom_label.AddLayerParameter("fontface", "list", Chr(34) & "plain" & Chr(34), lstParameterStrings:={Chr(34) & "plain" & Chr(34), Chr(34) & "bold" & Chr(34), Chr(34) & "italic" & Chr(34), Chr(34) & "bold.italic" & Chr(34)})
        clsgeom_label.AddLayerParameter("lineheight", "numeric", "1.2", lstParameterStrings:={1}) 'can be negative or positive, moving text out of the label box when negative or big values...
        clsgeom_label.AddLayerParameter("hjust", "numeric", "0.5", lstParameterStrings:={1}) 'position of the anchor (0=left edge, 1=right edge), can go below 0 or above 1 
        clsgeom_label.AddLayerParameter("vjust", "numeric", "0.5", lstParameterStrings:={1}) 'position of the anchor (0=bottom edge, 1=top edge), can go below 0 or above 1 
        'clsgeom_label.AddLayerParameter("angle", "numeric", "0", lstParameterStrings:={0, 0, 360}) 'the angle at which to draw the text label 'this is not working for label !! only for text.
        clsgeom_label.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34)) 'Note: for the background of the label 
        clsgeom_label.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34)) 'Note: for the text
        clsgeom_label.AddLayerParameter("size", "numeric", "5", lstParameterStrings:={0, 0}) 'size of the font, if smaller than 0 and below gives minimal size (excluded negatives to avoid confusion...)
        clsgeom_label.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})
        lstAllGeoms.Add(clsgeom_label)

        clsgeom_label_repel.SetGeomPackage("ggrepel")
        clsgeom_label_repel.SetGeomName("geom_label_repel")
        'Adding aesthetics parameters
        'Mandatory Aesthetics
        clsgeom_label_repel.AddAesParameter("x", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        clsgeom_label_repel.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        clsgeom_label_repel.AddAesParameter("label", strIncludedDataTypes:={"numeric", "factor", "character", "Date"}, bIsMandatory:=True)
        'Optional aesthetics
        clsgeom_label_repel.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_label_repel.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_label_repel.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        'Further aestheticscould be
        clsgeom_label_repel.AddAesParameter("family", strIncludedDataTypes:={"factor"})
        clsgeom_label_repel.AddAesParameter("fontface", strIncludedDataTypes:={"factor"})
        clsgeom_label_repel.AddAesParameter("lineheight", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_label_repel.AddAesParameter("hjust", strIncludedDataTypes:={"numeric"})
        clsgeom_label_repel.AddAesParameter("vjust", strIncludedDataTypes:={"numeric"})
        clsgeom_label_repel.AddAesParameter("angle", strIncludedDataTypes:={"factor", "numeric"})
        'Adding layer parameters
        'Geom_text_repel Parameters
        clsgeom_label_repel.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "stack" & Chr(34), "position_dodge(width = 0.9)", Chr(34) & "dodge2" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})
        clsgeom_label_repel.AddLayerParameter("parse", "boolean", "FALSE")
        clsgeom_label_repel.AddLayerParameter("box.padding", "numeric", "0.25", lstParameterStrings:={2, 0})
        clsgeom_label_repel.AddLayerParameter("point.padding", "numeric", "0", lstParameterStrings:={2, 0})
        clsgeom_label_repel.AddLayerParameter("label.size", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_label_repel.AddLayerParameter("label.r", "numeric", "0.15", lstParameterStrings:={2, 0})
        clsgeom_label_repel.AddLayerParameter("min.segment.length", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_label_repel.AddLayerParameter("arrow", "editablelist", "arrow()", lstParameterStrings:={"arrow()"})
        clsgeom_label_repel.AddLayerParameter("max.time", "numeric", "0.5")
        clsgeom_label_repel.AddLayerParameter("max.iter", "numeric", "1000", lstParameterStrings:={0, 1})
        clsgeom_label_repel.AddLayerParameter("max.overlaps", "numeric", "10", lstParameterStrings:={0, 1})
        clsgeom_label_repel.AddLayerParameter("nudge_x", "numeric", "0", lstParameterStrings:={2})
        clsgeom_label_repel.AddLayerParameter("nudge_y", "numeric", "0", lstParameterStrings:={2})
        clsgeom_label_repel.AddLayerParameter("xlim", "numeric", "1", lstParameterStrings:={2})
        clsgeom_label_repel.AddLayerParameter("ylim", "numeric", "1", lstParameterStrings:={2})
        clsgeom_label_repel.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_label_repel.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_label_repel)

        clsgeom_line.SetGeomName("geom_line")
        'x and y are mandatory, but these are autofilled by "" when no variable is mapped. "Partially mandatory"
        clsgeom_line.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_line.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"})
        'Optional
        clsgeom_line.AddAesParameter("alpha", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_line.AddAesParameter("colour", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_line.AddAesParameter("group", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_line.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_line.AddAesParameter("size", strIncludedDataTypes:={"numeric", "factor"})

        'Adding layer parameters
        'Geom_line Parameters

        'Global Layer parameters
        clsgeom_line.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})
        clsgeom_line.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "bin" & Chr(34), Chr(34) & "count" & Chr(34), Chr(34) & "density" & Chr(34), Chr(34) & "ecdf" & Chr(34), Chr(34) & "sum" & Chr(34), Chr(34) & "unique" & Chr(34)})
        clsgeom_line.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_line.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) 'Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...
        clsgeom_line.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_line.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_line.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})

        lstAllGeoms.Add(clsgeom_line)


        clsgeom_linerange.strGeomName = "geom_linerange"
        'mandatory
        clsgeom_linerange.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_linerange.AddAesParameter("ymax", bIsMandatory:=True)
        clsgeom_linerange.AddAesParameter("ymin", bIsMandatory:=True)
        'optional
        clsgeom_linerange.AddAesParameter("alpha")
        clsgeom_linerange.AddAesParameter("colour")
        clsgeom_linerange.AddAesParameter("linetype")
        clsgeom_linerange.AddAesParameter("size")

        'adding layer parameters
        clsgeom_linerange.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_linerange.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_errorbar.AddLayerParameter("orientation", "list", "NA", lstParameterStrings:={"NA", "x", "y"})
        clsgeom_linerange.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_linerange.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_linerange)

        'clsgeom_map.strGeomName = "geom_map"
        ''mandatory
        'clsgeom_map.AddAesParameter("map_id", bIsMandatory:=TRUE)
        ''optional
        'clsgeom_map.AddAesParameter("alpha")
        'clsgeom_map.AddAesParameter("colour")
        'clsgeom_map.AddAesParameter("fill")
        'clsgeom_map.AddAesParameter("linetype")
        'clsgeom_map.AddAesParameter("size")

        ''adding layer parameters
        'clsgeom_map.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_map)


        clsgeom_lollipop.SetGeomName("geom_lollipop")
        clsgeom_lollipop.SetGeomPackage("ggalt")

        'Mandatory Aesthetics
        clsgeom_lollipop.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        clsgeom_lollipop.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)

        'Optional Aesthetics
        clsgeom_lollipop.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_lollipop.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_lollipop.AddAesParameter("fill", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_lollipop.AddAesParameter("group", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_lollipop.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_lollipop.AddAesParameter("stroke", strIncludedDataTypes:={"factor", "numeric"})

        'Layer parameters
        clsgeom_lollipop.AddLayerParameter("horizontal", "boolean", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_lollipop.AddLayerParameter("point.colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_lollipop.AddLayerParameter("point.size", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_lollipop.AddLayerParameter("na.rm", "boolean", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_lollipop.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_lollipop.AddLayerParameter("inherit.aes", "boolean", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})

        lstAllGeoms.Add(clsgeom_lollipop)

        clsgeom_path.strGeomName = "geom_path"
        'mandatory
        clsgeom_path.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_path.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_path.AddAesParameter("alpha")
        clsgeom_path.AddAesParameter("colour")
        clsgeom_path.AddAesParameter("linetype")
        clsgeom_path.AddAesParameter("size")
        'add layer parameters 

        clsgeom_path.AddLayerParameter("stat", "list", Chr(34) & "contour" & Chr(34), lstParameterStrings:={Chr(34) & "contour" & Chr(34), Chr(34) & "identity" & Chr(34)})
        clsgeom_path.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_path.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        clsgeom_path.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        'linemitre should 1 or a number >1
        clsgeom_path.AddLayerParameter("linemitre", "numeric", "1", lstParameterStrings:={0, 1})
        clsgeom_path.AddLayerParameter("arrow", "editablelist", "arrow()", lstParameterStrings:={"arrow()"})
        lstAllGeoms.Add(clsgeom_path)

        clsgeom_mosaic.SetGeomPackage("ggmosaic")
        clsgeom_mosaic.strGeomName = "geom_mosaic"
        'mandatory
        'clsgeom_mosaic.AddAesParameter("x", bIsMandatory:=True, strIncludedDataTypes:={"factor"})
        'clsgeom_mosaic.AddAesParameter("fill", bIsMandatory:=True, strIncludedDataTypes:={"factor"})
        'clsgeom_mosaic.AddAesParameter("conds", strIncludedDataTypes:={"factor"})
        'clsgeom_mosaic.AddAesParameter("weight", strIncludedDataTypes:={"numeric"})

        'adding layerParameters
        clsgeom_mosaic.AddLayerParameter("divider", "editablelist", "ggmosaic::mosaic(" & Chr(34) & "h" & Chr(34) & ")", lstParameterStrings:={Chr(34) & "vspine" & Chr(34), Chr(34) & "hspine" & Chr(34), Chr(34) & "vbar" & Chr(34), Chr(34) & "hbar" & Chr(34), "ggmosaic::mosaic(" & Chr(34) & "h" & Chr(34) & ")", "ggmosaic::mosaic(" & Chr(34) & "v" & Chr(34) & ")", "ggmosaic::ddecker()"})
        clsgeom_mosaic.AddLayerParameter("offset", "numeric", "0.01", lstParameterStrings:={2, 0, 1}) 'not sure if it goes beyond 1
        clsgeom_mosaic.AddLayerParameter("stat", "editablelist", Chr(34) & "mosaic" & Chr(34), lstParameterStrings:={Chr(34) & "mosaic" & Chr(34)}) ' Made this editable because am not sure what other stats go here
        clsgeom_mosaic.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)}) ' Made this editable because am not sure what other positions go here
        clsgeom_mosaic.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_mosaic.AddLayerParameter("size", "numeric", "1", lstParameterStrings:={1, 1})
        clsgeom_mosaic.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_mosaic.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_mosaic)


        clsgeom_point.SetGeomName("geom_point")
        'Mandatory aesthetics : here x and y are mandatory, however, when not filled, default values "" are given. Alternatively, if we want to have at least on filled, could add bIsDependentlyMandatory:=TRUE in both. Planning on refining the mandatory aes methods to include the "" cases systematically.
        clsgeom_point.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_point.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"})
        'optional
        clsgeom_point.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_point.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_point.AddAesParameter("shape", strIncludedDataTypes:={"factor"})
        clsgeom_point.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_point.AddAesParameter("stroke", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_point.AddAesParameter("fill", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_point.AddAesParameter("label", strIncludedDataTypes:={"factor", "numeric", "character", "Date"})
        'Adding layer parameters
        'Geom_poitn Parameters

        'Global Layer parameters
        clsgeom_point.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34), "position_jitterdodge()"})
        clsgeom_point.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "bin" & Chr(34), Chr(34) & "count" & Chr(34), Chr(34) & "desnity" & Chr(34), Chr(34) & "ecdf" & Chr(34), Chr(34) & "sum" & Chr(34), Chr(34) & "summary" & Chr(34), Chr(34) & "unique" & Chr(34)}) 'Warning, stat count cannot be used with y aesthetic !!!
        clsgeom_point.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_point.AddLayerParameter("shape", "list", Chr(34) & "circle" & Chr(34), lstParameterStrings:=strShapePoint)
        clsgeom_point.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_point.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1}) 'Warning: varies transparence of fill AND outline.
        clsgeom_point.AddLayerParameter("size", "numeric", "1.5", lstParameterStrings:={1, 0}) 'Note: negative size gives size 0 in general, but 'Warning, sometimesgive errors...
        clsgeom_point.AddLayerParameter("stroke", "numeric", "0.5", lstParameterStrings:={1, 0}) 'Use the stroke aes to change the width of the outline of the shapes. When no outline stroke overrides size. 'Warning: sometimes negative values give errors...
        clsgeom_point.AddLayerParameter("fill", "colour", Chr(34) & "black" & Chr(34)) 'Note: only a small minaority of shapes can be filled.

        lstAllGeoms.Add(clsgeom_point)

        'clsgeom_pointrange.strGeomName = "geom_pointrange"
        'clsgeom_pointrange.AddAesParameter("x", bIsMandatory:=TRUE)
        'clsgeom_pointrange.AddAesParameter("ymax", bIsMandatory:=TRUE)
        'clsgeom_pointrange.AddAesParameter("ymin", bIsMandatory:=TRUE)
        ''optional
        'clsgeom_pointrange.AddAesParameter("alpha")
        'clsgeom_pointrange.AddAesParameter("colour")
        'clsgeom_pointrange.AddAesParameter("linetype")
        'clsgeom_pointrange.AddAesParameter("size")
        ''adding layer parameters
        'clsgeom_pointrange.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_pointrange.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))

        'lstAllGeoms.Add(clsgeom_pointrange)

        clsgeom_polygon.strGeomName = "geom_polygon"
        clsgeom_polygon.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_polygon.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_polygon.AddAesParameter("alpha")
        clsgeom_polygon.AddAesParameter("colour")
        clsgeom_polygon.AddAesParameter("fill")
        clsgeom_polygon.AddAesParameter("group")
        clsgeom_polygon.AddAesParameter("linetype")
        clsgeom_polygon.AddAesParameter("size")

        'add layer parameters 
        clsgeom_polygon.AddLayerParameter("stat", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_polygon.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_polygon.AddLayerParameter("lineed", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "squire" & Chr(34)})
        clsgeom_polygon.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        clsgeom_polygon.AddLayerParameter("linemitre", "numeric", "0", lstParameterStrings:={1})

        'Arrow parameter is a function and should be passed like this
        'arrow(angle = 30, length = unit(0.25, "inches"), ends = "last", Type = "open")
        'currently not sure how to do this 
        'clsgeom_polygon.AddLayerParameter("arrow")

        clsgeom_polygon.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_polygon.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_polygon.AddLayerParameter("direction", "list", Chr(34) & "vh" & Chr(34), lstParameterStrings:={Chr(34) & "vh" & Chr(34), Chr(34) & "hv" & Chr(34)})
        lstAllGeoms.Add(clsgeom_polygon)

        clsgeom_qq.strGeomName = "geom_qq"
        clsgeom_qq.AddAesParameter("sample", bIsMandatory:=True)
        '' optional
        clsgeom_qq.AddAesParameter("x")
        clsgeom_qq.AddAesParameter("y")

        ''layer params 
        clsgeom_qq.AddLayerParameter("distribution", "list", "stats::qnorm", lstParameterStrings:={"stats::qnorm"})
        clsgeom_qq.AddLayerParameter("dparams", "editablelist", "list()", lstParameterStrings:={"list()"})
        clsgeom_qq.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_qq.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_qq)


        clsgeom_qq_line.strGeomName = "geom_qq_line"
        clsgeom_qq_line.AddAesParameter("sample", bIsMandatory:=True)
        '' optional
        clsgeom_qq_line.AddAesParameter("x")
        clsgeom_qq_line.AddAesParameter("y")

        ''layer params 
        clsgeom_qq_line.AddLayerParameter("distribution", "list", "stats::qnorm", lstParameterStrings:={"stats::qnorm"})
        clsgeom_qq_line.AddLayerParameter("dparams", "editablelist", "list()", lstParameterStrings:={"list()"})
        clsgeom_qq_line.AddLayerParameter("fullrange", "boolean", "FALSE")
        clsgeom_qq_line.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_qq_line.AddLayerParameter("line.p", "editablelist", "c(0.25, 0.75)", lstParameterStrings:={"c(0.25, 0.75)"})
        clsgeom_qq_line.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})

        lstAllGeoms.Add(clsgeom_qq_line)


        clsgeom_quantile.strGeomName = "geom_quantile"
        clsgeom_quantile.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_quantile.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_quantile.AddAesParameter("alpha")
        clsgeom_quantile.AddAesParameter("colour")
        clsgeom_quantile.AddAesParameter("linetype")
        clsgeom_quantile.AddAesParameter("size")
        clsgeom_quantile.AddAesParameter("weight")

        'adding layer parameter
        clsgeom_quantile.AddLayerParameter("stat", "list", Chr(34) & "contour" & Chr(34), lstParameterStrings:={Chr(34) & "contour" & Chr(34)})
        clsgeom_quantile.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_quantile.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        clsgeom_quantile.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        'linemitre should 1 or a number >1
        clsgeom_quantile.AddLayerParameter("linemitre", "numeric", "1")
        lstAllGeoms.Add(clsgeom_quantile)

        clsgeom_raster.strGeomName = "geom_raster"
        'mandatory
        clsgeom_raster.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_raster.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_raster.AddAesParameter("alpha")
        clsgeom_raster.AddAesParameter("colour")
        clsgeom_raster.AddAesParameter("fill")
        clsgeom_raster.AddAesParameter("linetype")
        clsgeom_raster.AddAesParameter("size")

        'add layer parameter
        clsgeom_quantile.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_quantile.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_raster.AddLayerParameter("hjust", "numeric", "0.5")
        clsgeom_raster.AddLayerParameter("vjust", "numeric", "0.5")
        clsgeom_raster.AddLayerParameter("interpolate ", "boolean", "FALSE")
        clsgeom_raster.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_raster.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})

        lstAllGeoms.Add(clsgeom_raster)

        clsgeom_rect.strGeomName = "geom_rect"
        'mandatory
        clsgeom_rect.AddAesParameter("xmin", bIsMandatory:=True)
        clsgeom_rect.AddAesParameter("xmax", bIsMandatory:=True)
        clsgeom_rect.AddAesParameter("ymin", bIsMandatory:=True)
        clsgeom_rect.AddAesParameter("ymax ", bIsMandatory:=True)
        'optional
        clsgeom_rect.AddAesParameter("alpha")
        clsgeom_rect.AddAesParameter("colour")
        clsgeom_rect.AddAesParameter("fill")
        clsgeom_rect.AddAesParameter("linetype")
        clsgeom_rect.AddAesParameter("size")

        clsgeom_rect.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_rect.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_raster.AddLayerParameter("size", "numeric", "0.5")
        clsgeom_rect.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        clsgeom_rect.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_rect.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_rect)

        clsgeom_ribbon.strGeomName = "geom_ribbon"
        'mandatory aes are s or y or ymax or y min 
        clsgeom_ribbon.AddAesParameter("x")
        clsgeom_ribbon.AddAesParameter("y")
        clsgeom_ribbon.AddAesParameter("ymax")
        clsgeom_ribbon.AddAesParameter("ymin")
        'optional
        clsgeom_ribbon.AddAesParameter("alpha")
        clsgeom_ribbon.AddAesParameter("colour")
        clsgeom_ribbon.AddAesParameter("group")
        clsgeom_ribbon.AddAesParameter("linetype")
        clsgeom_ribbon.AddAesParameter("size")

        ''add layer parameter 
        'not sure of all the options for this so i leave it as an editable list- once we know we can add all of them
        clsgeom_ribbon.AddLayerParameter("stat", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_ribbon.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_ribbon.AddLayerParameter("size", "numeric", "1")
        clsgeom_ribbon.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_ribbon.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_ribbon.AddLayerParameter("orientation", "list", "NA", lstParameterStrings:={"NA", "x", "y"})
        clsgeom_ribbon.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_ribbon)

        Dim clsgeom_ridgeline As New Geoms

        clsgeom_ridgeline.SetGeomPackage("ggridges")
        clsgeom_ridgeline.strGeomName = "geom_ridgeline"
        'Mandatory Aesthetics
        clsgeom_ridgeline.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_ridgeline.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        'Other Aesthetics
        clsgeom_ridgeline.AddAesParameter("fill", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_ridgeline.AddAesParameter("height")
        clsgeom_ridgeline.AddAesParameter("group")
        clsgeom_ridgeline.AddAesParameter("scale")
        clsgeom_ridgeline.AddAesParameter("min_height")
        'Aesthetics for colour, fill, group, alpha, linetype, Size, as in geom_ridgeline.
        clsgeom_ridgeline.AddAesParameter("colour")
        'clsgeom_ridgeline.AddAesParameter("group")
        clsgeom_ridgeline.AddAesParameter("alpha")
        clsgeom_ridgeline.AddAesParameter("linetype")
        'clsgeom_ridgeline.AddAesParameter("Size")
        'Aesthetics for point_shape, point_colour, point_size, point_fill, point_alpha, point_stroke
        'clsgeom_ridgeline.AddAesParameter("point_shape")
        clsgeom_ridgeline.AddAesParameter("point_colour")
        'clsgeom_ridgeline.AddAesParameter("point_size")
        'clsgeom_ridgeline.AddAesParameter("point_fill")
        'clsgeom_ridgeline.AddAesParameter("point_alpha")
        'clsgeom_ridgeline.AddAesParameter("point_stroke")

        'adding layer parameters
        clsgeom_ridgeline.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "density_ridges" & Chr(34), Chr(34) & "binline" & Chr(34)})
        clsgeom_ridgeline.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "points_sina" & Chr(34), Chr(34) & "points_jitter" & Chr(34), Chr(34) & "raincloud" & Chr(34)})
        clsgeom_ridgeline.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_ridgeline.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_ridgeline.AddLayerParameter("inherit.aes", "list", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_ridgeline)

        Dim clsgeom_ridgeline_gradient As New Geoms

        clsgeom_ridgeline_gradient.SetGeomPackage("ggridges")
        clsgeom_ridgeline_gradient.strGeomName = "geom_ridgeline_gradient"
        'Mandatory Aesthetics
        clsgeom_ridgeline_gradient.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_ridgeline_gradient.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        'Other Aesthetics
        clsgeom_ridgeline_gradient.AddAesParameter("fill", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_ridgeline_gradient.AddAesParameter("height")
        clsgeom_ridgeline_gradient.AddAesParameter("group")
        clsgeom_ridgeline_gradient.AddAesParameter("scale")
        clsgeom_ridgeline_gradient.AddAesParameter("min_height")
        'Aesthetics for colour, fill, group, alpha, linetype, Size, as in geom_ridgeline.
        clsgeom_ridgeline_gradient.AddAesParameter("colour")
        'clsgeom_ridgeline_gradient.AddAesParameter("group")
        clsgeom_ridgeline_gradient.AddAesParameter("alpha")
        clsgeom_ridgeline_gradient.AddAesParameter("linetype")
        'clsgeom_ridgeline_gradient.AddAesParameter("Size")
        'Aesthetics for point_shape, point_colour, point_size, point_fill, point_alpha, point_stroke
        'clsgeom_ridgeline_gradient.AddAesParameter("point_shape")
        clsgeom_ridgeline_gradient.AddAesParameter("point_colour")
        'clsgeom_ridgeline_gradient.AddAesParameter("point_size")
        'clsgeom_ridgeline_gradient.AddAesParameter("point_fill")
        'clsgeom_ridgeline_gradient.AddAesParameter("point_alpha")
        'clsgeom_ridgeline_gradient.AddAesParameter("point_stroke")

        'adding layer parameters
        clsgeom_ridgeline_gradient.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "density_ridges" & Chr(34), Chr(34) & "binline" & Chr(34)})
        clsgeom_ridgeline_gradient.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_ridgeline_gradient.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_ridgeline_gradient.AddLayerParameter("gradient_lwd", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_ridgeline_gradient.AddLayerParameter("show.legend", "list", "NA", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_ridgeline_gradient.AddLayerParameter("inherit.aes", "list", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_ridgeline_gradient)

        clsgeom_rug.SetGeomName("geom_rug")
        clsgeom_rug.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_rug.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"})
        'These two are not made mandatory as we want to be able to choose only one, and could be either.
        clsgeom_rug.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_rug.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_rug.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_rug.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})

        'Adding layer parameters
        'Geom_line Parameters
        clsgeom_rug.AddLayerParameter("sides", "list", Chr(34) & "bl" & Chr(34), lstParameterStrings:={Chr(34) & "trbl" & Chr(34), Chr(34) & "trb" & Chr(34), Chr(34) & "trl" & Chr(34), Chr(34) & "tbl" & Chr(34), Chr(34) & "rbl" & Chr(34), Chr(34) & "tr" & Chr(34), Chr(34) & "tb" & Chr(34), Chr(34) & "tl" & Chr(34), Chr(34) & "rb" & Chr(34), Chr(34) & "rl" & Chr(34), Chr(34) & "bl" & Chr(34), Chr(34) & "t" & Chr(34), Chr(34) & "r" & Chr(34), Chr(34) & "b" & Chr(34), Chr(34) & "l" & Chr(34)})
        'Global Layer parameters
        clsgeom_rug.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})
        clsgeom_rug.AddLayerParameter("outside", "boolean", "FALSE")
        clsgeom_rug.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "ecdf" & Chr(34), Chr(34) & "sum" & Chr(34), Chr(34) & "summary" & Chr(34), Chr(34) & "unique" & Chr(34)}) 'Warning, stat count cannot be used with y aesthetic !!!
        clsgeom_rug.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_rug.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) 'Note: negative size gives size 0 in general, but 'Warning, sometimesgive errors...
        clsgeom_rug.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_rug.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_rug.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})
        lstAllGeoms.Add(clsgeom_rug)

        clsgeom_segment.strGeomName = "geom_segment"
        'Mandatory Aesthetics  
        clsgeom_segment.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, strExcludedDataTypes:={})
        clsgeom_segment.AddAesParameter("xend", strIncludedDataTypes:={"numeric"})
        clsgeom_segment.AddAesParameter("y", strIncludedDataTypes:={"numeric"})
        clsgeom_segment.AddAesParameter("yend", strIncludedDataTypes:={"numeric"})

        'Optional Aesthetics 
        clsgeom_segment.AddAesParameter("alpha", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_segment.AddAesParameter("colour", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_segment.AddAesParameter("linetype", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_segment.AddAesParameter("group", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_segment.AddAesParameter("size", strIncludedDataTypes:=({"factor", "numeric"})) 'using size for a discrete variable is not advised 

        'Layer parameter
        ' we can also set x, y, xend and yend outside of the aes function
        clsgeom_segment.AddLayerParameter("x", "numeric", "0", lstParameterStrings:={2})
        clsgeom_segment.AddLayerParameter("xend", "numeric", "0", lstParameterStrings:={2}) 'mandatory
        clsgeom_segment.AddLayerParameter("y", "numeric", "0", lstParameterStrings:={2})
        clsgeom_segment.AddLayerParameter("yend", "numeric", "0", lstParameterStrings:={2}) 'mandatory
        'clsgeom_segment.AddLayerParameter("arrow", "list", "NULL") 'need to use arrow() command here e.g. arrow = arrow(angle = 30, length = unit(0.25, "inches"), ends = "last", type = "open") 
        clsgeom_segment.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)}) 'round butt or square 

        'Global Layer Parameters 
        clsgeom_segment.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "ecdf" & Chr(34), Chr(34) & "sum" & Chr(34), Chr(34) & "summary" & Chr(34), Chr(34) & "unique" & Chr(34)})
        'sum and summary only work when x and y parameters are set within aes(). Summary option defaults to `mean_se() since no summary function supplied
        'think it's okay to have this greyed out for now because we only tend to use stat = "identity"
        clsgeom_segment.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})
        'other options for position are ignored when using geom segment on a scatter plot (geom_point) - R gives the following warning: "Ignoring unknown parameters: identity"
        clsgeom_segment.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_segment.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})

        'Aesthetics as layer parameters 
        clsgeom_segment.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) 'Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...
        clsgeom_segment.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_segment.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_segment.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})

        lstAllGeoms.Add(clsgeom_segment)

        clsgeom_sf.SetGeomName("geom_sf")
        clsgeom_sf.AddAesParameter("geometry", strIncludedDataTypes:={"numeric"})
        clsgeom_sf.AddAesParameter("shape", strIncludedDataTypes:={"factor"})
        clsgeom_sf.AddAesParameter("colour", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_sf.AddAesParameter("size", strIncludedDataTypes:={"numeric"})
        clsgeom_sf.AddAesParameter("fill", strIncludedDataTypes:={"factor"})
        'Adding layer parameters
        clsgeom_sf.AddLayerParameter("geom", "list", Chr(34) & "area" & Chr(34), lstParameterStrings:={Chr(34) & "area" & Chr(34), Chr(34) & "bar" & Chr(34), Chr(34) & "blank" & Chr(34), Chr(34) & "col" & Chr(34), Chr(34) & "contour" & Chr(34), Chr(34) & "crossbar" & Chr(34), Chr(34) & "density" & Chr(34), Chr(34) & "density_2d" & Chr(34), Chr(34) & "density2d" & Chr(34), Chr(34) & "errorbar" & Chr(34), Chr(34) & "hex" & Chr(34), Chr(34) & "line" & Chr(34), Chr(34) & "linerange" & Chr(34), Chr(34) & "path" & Chr(34), Chr(34) & "point" & Chr(34), Chr(34) & "pointrange" & Chr(34), Chr(34) & "polygon" & Chr(34), Chr(34) & "quantile" & Chr(34), Chr(34) & "raster" & Chr(34), Chr(34) & "ribbon" & Chr(34), Chr(34) & "rug" & Chr(34), Chr(34) & "smooth" & Chr(34), Chr(34) & "step" & Chr(34), Chr(34) & "tile" & Chr(34)})
        clsgeom_sf.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "fill" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "identity" & Chr(34)})
        clsgeom_sf.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_sf.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})
        clsgeom_sf.AddLayerParameter("size", "numeric", "3", lstParameterStrings:={1, 1})
        clsgeom_sf.AddLayerParameter("expand", "list", "TRUE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_sf.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_sf.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_sf.AddLayerParameter("crs", "numeric", "1")
        'TODO we are not sure what this can take. Needs to be looked at more closely
        'clsgeom_sf.AddLayerParameter("datum", "numeric", "1")
        clsgeom_sf.AddLayerParameter("ndiscr", "list", "NULL", lstParameterStrings:={"NA", "NULL"})
        lstAllGeoms.Add(clsgeom_sf)


        clsgeom_smooth.strGeomName = "geom_smooth"
        'Mandatory Aesthetics 
        clsgeom_smooth.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_smooth.AddAesParameter("y", bIsMandatory:=True)
        'Optional Aesthetics 
        clsgeom_smooth.AddAesParameter("alpha")
        clsgeom_smooth.AddAesParameter("colour")
        clsgeom_smooth.AddAesParameter("fill")
        clsgeom_smooth.AddAesParameter("group")
        clsgeom_smooth.AddAesParameter("linetype")
        clsgeom_smooth.AddAesParameter("size")
        clsgeom_smooth.AddAesParameter("weight")

        'Add  layer parameters
        ''****Not sure how many positions exist for geom_smooth
        clsgeom_smooth.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34)})
        'Can we have  stack, DoDragDrop, fill positions here)
        clsgeom_smooth.AddLayerParameter("method", "list", Chr(34) & "lm" & Chr(34), lstParameterStrings:={Chr(34) & "lm" & Chr(34), Chr(34) & "glm" & Chr(34), Chr(34) & "gam" & Chr(34), Chr(34) & "loess" & Chr(34), "MASS::rlm"})
        'formula has to be an input and we dont have that currently. its passed in like this formula= y ~ x or  formula= y ~ poly(x, 2) or formula= y ~ log(x) so the user has to type in stuff
        clsgeom_smooth.AddLayerParameter("formula", "editablelist", "y ~ x", lstParameterStrings:={"y ~ x", "y ~ poly(x, 2)", "y ~ log(x)", "y ~ splines::bs(x,3)"})
        clsgeom_smooth.AddLayerParameter("se ", "list", "TRUE", lstParameterStrings:={"TRUE", "FALSE"}) 'We add space after parameter name se ("se ") for correct labeling, if the space is omitted, vb labels "se" as "ifelse" but when the space is included "se " is correctly labelled as "se". 
        clsgeom_smooth.AddLayerParameter("method.args", "editablelist", "list()", lstParameterStrings:={"list()"})
        clsgeom_smooth.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_smooth.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_smooth.AddLayerParameter("orientation", "list", "NA", lstParameterStrings:={"NA", Chr(34) & "x" & Chr(34), Chr(34) & "y" & Chr(34)})
        clsgeom_smooth.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        'geom and stat are missing here as we dont know how to override the default connection between geom_smooth and stat_smooth
        'you can have stat_smooth or geom_smooth. I am not sure how we can do that from here, changing the smothing function

        clsgeom_smooth.AddLayerParameter("n", "numeric", "0")
        clsgeom_smooth.AddLayerParameter("span", "numeric", "0.3", lstParameterStrings:={2, 0, 1})
        clsgeom_smooth.AddLayerParameter("fullrange", "boolean", "FALSE")
        clsgeom_smooth.AddLayerParameter("level", "numeric", "0.95", lstParameterStrings:={2, 0, 1})
        clsgeom_smooth.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) 'Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...
        clsgeom_smooth.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)

        'method.args is a list of methods passed into the moddeling function
        'its passed in like this** method.args = list(family = "binomial") we currently dont have this too. 
        'clsgeom_smooth.AddLayerParameter("method.args")

        lstAllGeoms.Add(clsgeom_smooth)

        clsgeom_spoke.strGeomName = "geom_spoke"
        'mandatory
        clsgeom_spoke.AddAesParameter("angle", bIsMandatory:=True)
        clsgeom_spoke.AddAesParameter("radius", bIsMandatory:=True)
        clsgeom_spoke.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_spoke.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_spoke.AddAesParameter("alpha")
        clsgeom_spoke.AddAesParameter("colour")
        clsgeom_spoke.AddAesParameter("linetype")
        clsgeom_spoke.AddAesParameter("size")

        'add layer parameter
        clsgeom_spoke.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_spoke.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_spoke.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_spoke.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        lstAllGeoms.Add(clsgeom_spoke)

        clsgeom_step.strGeomName = "geom_step"
        clsgeom_step.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_step.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_step.AddAesParameter("alpha")
        clsgeom_step.AddAesParameter("colour")
        clsgeom_step.AddAesParameter("linetype")
        clsgeom_step.AddAesParameter("size")

        'adding layer parameter
        clsgeom_step.AddLayerParameter("stat", "list", Chr(34) & "contour" & Chr(34), lstParameterStrings:={Chr(34) & "contour" & Chr(34)})
        clsgeom_step.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_step.AddLayerParameter("direction", "list", Chr(34) & "hv" & Chr(34), lstParameterStrings:={Chr(34) & "hv" & Chr(34), Chr(34) & "vh" & Chr(34)})
        clsgeom_step.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        clsgeom_step.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        'linemitre should 1 or a number >1
        clsgeom_step.AddLayerParameter("linemitre", "numeric", "1")
        lstAllGeoms.Add(clsgeom_step)

        clsgeom_text.SetGeomName("geom_text") 'Note: can also add text on the graph via annotate (to be added on sdgplots).
        'Adding aesthetics parameters
        'Mandatory Aesthetics
        clsgeom_text.AddAesParameter("x", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        clsgeom_text.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        clsgeom_text.AddAesParameter("label", strIncludedDataTypes:={"numeric", "factor", "character", "Date"}, bIsMandatory:=True)
        'Optional aesthetics
        clsgeom_text.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"}) 'Note: for the text
        clsgeom_text.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"}) 'size of the font
        clsgeom_text.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        'The following aesthetics are arguably more relevant relevant as parameters. Setting them as parameters overwrites the aes mapping.
        clsgeom_text.AddAesParameter("family", strIncludedDataTypes:={"factor"})
        clsgeom_text.AddAesParameter("fontface", strIncludedDataTypes:={"factor"})
        clsgeom_text.AddAesParameter("lineheight", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_text.AddAesParameter("hjust", strIncludedDataTypes:={"numeric"}) 'position of the anchor (0=left edge, 1=right edge), can go below 0 or above 1 
        clsgeom_text.AddAesParameter("vjust", strIncludedDataTypes:={"numeric"}) 'position of the anchor (0=bottom edge, 1=top edge), can go below 0 or above 1 
        clsgeom_text.AddAesParameter("angle", strIncludedDataTypes:={"factor", "numeric"})
        'Adding layer parameters
        'Geom_text Parameters
        clsgeom_text.AddLayerParameter("nudge_x", "numeric", "0.15", lstParameterStrings:={2}) 'Warning: cnnot use both position and nudge_x;nudge_y !!! Doesn't crash the software...
        clsgeom_text.AddLayerParameter("nudge_y", "numeric", "0.15", lstParameterStrings:={2}) 'Horizontal and vertical adjustment to nudge labels by (if nonzero, avoid superposition, then can accentuate in both directions, negative or positive). Useful for offsetting text from points, particularly on discrete scales. 
        clsgeom_text.AddLayerParameter("check_overlap", "boolean", "FALSE") 'If TRUE, text that overlaps previous text in the same layer will not be plotted. A quick and dirty way
        clsgeom_text.AddLayerParameter("parse", "boolean", "FALSE") 'If TRUE, the labels will be parsed into expressions and displayed as described in ?plotmath
        'Global Layer parameters
        clsgeom_text.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_text.AddLayerParameter("position", "editablelist", "position_identity()", lstParameterStrings:={"position_identity()", "position_stack(vjust = 0.9)", "position_stack(vjust = 0.5, reverse = TRUE)", "position_dodge(width = 0.9)", "position_jitter(width = 0.9)", "position_fill(vjust = 0.9)"}) 'Warning/Task: really need to specify values for width in position_dodge, as "dodge" doesn't have default values for this geom (sends a warning). This is necessary if you want to get the labels on top of dodged bars for instance... For the moment added position_jitterdodge() that works fine.
        'Warning: cannot use both position and nudge_x;nudge_y !!! Doesn't crash the software...
        clsgeom_text.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "bin" & Chr(34), Chr(34) & "count" & Chr(34), Chr(34) & "density" & Chr(34), Chr(34) & "sum" & Chr(34), Chr(34) & "unique" & Chr(34)}) 'Warning: stat count cannot be used with y aesthetic !!! 'Warning: summary and ecdf is source of errors.
        'Aesthetics as layer parameters.
        clsgeom_text.AddLayerParameter("family", "list", Chr(34) & Chr(34), lstParameterStrings:={Chr(34) & Chr(34), Chr(34) & "serif" & Chr(34), Chr(34) & "sans" & Chr(34), Chr(34) & "mono" & Chr(34), Chr(34) & "symbol" & Chr(34)}) 'Warning: could add more fonts, maybe use extrafonts package ?
        clsgeom_text.AddLayerParameter("fontface", "list", Chr(34) & "plain" & Chr(34), lstParameterStrings:={Chr(34) & "plain" & Chr(34), Chr(34) & "bold" & Chr(34), Chr(34) & "italic" & Chr(34), Chr(34) & "bold.italic" & Chr(34)})
        clsgeom_text.AddLayerParameter("lineheight", "numeric", "1.2", lstParameterStrings:={1}) 'can be negative or positive, moving text out of the label box when negative or big values...
        clsgeom_text.AddLayerParameter("hjust", "numeric", "0.5", lstParameterStrings:={1}) 'position of the anchor (0=left edge, 1=right edge), can go below 0 or above 1 
        clsgeom_text.AddLayerParameter("vjust", "numeric", "0.5", lstParameterStrings:={1}) 'position of the anchor (0=bottom edge, 1=top edge), can go below 0 or above 1 
        clsgeom_text.AddLayerParameter("angle", "numeric", "0", lstParameterStrings:={0, 0, 360}) 'the angle at which to draw the text label 'this is not working for label !! only for text.
        clsgeom_text.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34)) 'Note: for the text
        clsgeom_text.AddLayerParameter("size", "numeric", "5", lstParameterStrings:={0, 0}) 'size of the font, if smaller than 0 and below gives minimal size (excluded negatives to avoid confusion...)
        clsgeom_text.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})
        lstAllGeoms.Add(clsgeom_text)

        clsgeom_text_wordcloud.SetGeomPackage("ggwordcloud")
        clsgeom_text_wordcloud.SetGeomName("geom_text_wordcloud")
        'Adding aesthetics parameters
        'Mandatory Aesthetics
        clsgeom_text_wordcloud.AddAesParameter("label", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)

        'Optional aesthetics
        clsgeom_text_wordcloud.AddAesParameter("size", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_text_wordcloud.AddAesParameter("color", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_text_wordcloud.AddAesParameter("angle", "0", strIncludedDataTypes:={"numeric"})

        'Adding layer parameters
        'geom_text_wordcloud Parameters
        clsgeom_text_wordcloud.AddLayerParameter("stat", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_text_wordcloud.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_text_wordcloud.AddLayerParameter("parse", "boolean", "FALSE")
        clsgeom_text_wordcloud.AddLayerParameter("nudge_x", "numeric", "0", lstParameterStrings:={2})
        clsgeom_text_wordcloud.AddLayerParameter("nudge_y", "numeric", "0", lstParameterStrings:={2})
        clsgeom_text_wordcloud.AddLayerParameter("eccentricity", "numeric", "0.65", lstParameterStrings:={2, 0, 1})
        clsgeom_text_wordcloud.AddLayerParameter("grid_size", "numeric", "4", lstParameterStrings:={0, 0, 128})
        clsgeom_text_wordcloud.AddLayerParameter("max_grid_size", "numeric", "128", lstParameterStrings:={0, 0, 256})
        clsgeom_text_wordcloud.AddLayerParameter("grid_margin", "numeric", "1", lstParameterStrings:={0, 0, 10})
        clsgeom_text_wordcloud.AddLayerParameter("xlim", "numeric", "1", lstParameterStrings:={2})
        clsgeom_text_wordcloud.AddLayerParameter("ylim", "numeric", "1", lstParameterStrings:={2})
        clsgeom_text_wordcloud.AddLayerParameter("rm_outside", "boolean", "FALSE")
        clsgeom_text_wordcloud.AddLayerParameter("shape", "list", Chr(34) & "circle" & Chr(34), lstParameterStrings:={Chr(34) & "circle" & Chr(34), Chr(34) & "cardioid" & Chr(34), Chr(34) & "diamond" & Chr(34), Chr(34) & "square" & Chr(34), Chr(34) & "triangle - forward" & Chr(34), Chr(34) & "triangle - upright" & Chr(34), Chr(34) & "pentagon" & Chr(34), Chr(34) & "star" & Chr(34)})
        clsgeom_text_wordcloud.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_text_wordcloud.AddLayerParameter("Show.legend", "boolean", "FALSE")
        clsgeom_text_wordcloud.AddLayerParameter("inherit.aes", "boolean", "TRUE")
        clsgeom_text_wordcloud.AddLayerParameter("show_boxes", "boolean", "FALSE")
        clsgeom_text_wordcloud.AddLayerParameter("area_corr", "boolean", "FALSE")
        'clsgeom_text_wordcloud.AddLayerParameter("rstep", "numeric", "0.01", lstParameterStrings:={2, 0, 1})
        'clsgeom_text_wordcloud.AddLayerParameter("tstep", "numeric", "0.02", lstParameterStrings:={2, 0, 1})
        'clsgeom_text_wordcloud.AddLayerParameter("perc_step", "numeric", "0.01", lstParameterStrings:={2, 0, 1})
        'clsgeom_text_wordcloud.AddLayerParameter("max_steps", "numeric", "10", lstParameterStrings:={0, 0, 100})
        'clsgeom_text_wordcloud.AddLayerParameter("area_corr", "boolean", "FALSE")
        lstAllGeoms.Add(clsgeom_text_wordcloud)

        clsgeom_text_wordcloud_area.SetGeomPackage("ggwordcloud")
        clsgeom_text_wordcloud_area.SetGeomName("geom_text_wordcloud_area")
        'Adding aesthetics parameters
        'Mandatory Aesthetics
        clsgeom_text_wordcloud_area.AddAesParameter("label", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)

        'Optional aesthetics
        clsgeom_text_wordcloud_area.AddAesParameter("size", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_text_wordcloud_area.AddAesParameter("color", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_text_wordcloud_area.AddAesParameter("angle", "0", strIncludedDataTypes:={"numeric"})

        'Adding layer parameters
        'geom_text_wordcloud_area Parameters
        clsgeom_text_wordcloud_area.AddLayerParameter("stat", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_text_wordcloud_area.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_text_wordcloud_area.AddLayerParameter("parse", "boolean", "FALSE")
        clsgeom_text_wordcloud_area.AddLayerParameter("nudge_x", "numeric", "0", lstParameterStrings:={2})
        clsgeom_text_wordcloud_area.AddLayerParameter("nudge_y", "numeric", "0", lstParameterStrings:={2})
        clsgeom_text_wordcloud_area.AddLayerParameter("eccentricity", "numeric", "0.65", lstParameterStrings:={2, 0, 1})
        clsgeom_text_wordcloud_area.AddLayerParameter("grid_size", "numeric", "4", lstParameterStrings:={0, 0, 128})
        clsgeom_text_wordcloud_area.AddLayerParameter("max_grid_size", "numeric", "128", lstParameterStrings:={0, 0, 256})
        clsgeom_text_wordcloud_area.AddLayerParameter("grid_margin", "numeric", "1", lstParameterStrings:={0, 0, 10})
        clsgeom_text_wordcloud_area.AddLayerParameter("xlim", "numeric", "1", lstParameterStrings:={2})
        clsgeom_text_wordcloud_area.AddLayerParameter("ylim", "numeric", "1", lstParameterStrings:={2})
        clsgeom_text_wordcloud_area.AddLayerParameter("rm_outside", "boolean", "FALSE")
        clsgeom_text_wordcloud_area.AddLayerParameter("shape", "list", Chr(34) & "circle" & Chr(34), lstParameterStrings:={Chr(34) & "circle" & Chr(34), Chr(34) & "cardioid" & Chr(34), Chr(34) & "diamond" & Chr(34), Chr(34) & "square" & Chr(34), Chr(34) & "triangle - forward" & Chr(34), Chr(34) & "triangle - upright" & Chr(34), Chr(34) & "pentagon" & Chr(34), Chr(34) & "star" & Chr(34)})
        clsgeom_text_wordcloud_area.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_text_wordcloud_area.AddLayerParameter("Show.legend", "boolean", "FALSE")
        clsgeom_text_wordcloud_area.AddLayerParameter("inherit.aes", "boolean", "TRUE")
        clsgeom_text_wordcloud_area.AddLayerParameter("show_boxes", "boolean", "FALSE")
        'clsgeom_text_wordcloud_area.AddLayerParameter("rstep", "numeric", "0.01", lstParameterStrings:={2, 0, 1})
        'clsgeom_text_wordcloud_area.AddLayerParameter("tstep", "numeric", "0.02", lstParameterStrings:={2, 0, 1})
        'clsgeom_text_wordcloud_area.AddLayerParameter("perc_step", "numeric", "0.01", lstParameterStrings:={2, 0, 1})
        'clsgeom_text_wordcloud_area.AddLayerParameter("max_steps", "numeric", "10", lstParameterStrings:={0, 0, 100})
        'clsgeom_text_wordcloud_area.AddLayerParameter("area_corr", "boolean", "FALSE")
        lstAllGeoms.Add(clsgeom_text_wordcloud_area)

        clsgeom_text_repel.SetGeomPackage("ggrepel")
        clsgeom_text_repel.SetGeomName("geom_text_repel")
        'Adding aesthetics parameters
        'Mandatory Aesthetics
        clsgeom_text_repel.AddAesParameter("x", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        clsgeom_text_repel.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        clsgeom_text_repel.AddAesParameter("label", strIncludedDataTypes:={"numeric", "factor", "character", "Date"}, bIsMandatory:=True)
        'Optional aesthetics
        clsgeom_text_repel.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_text_repel.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_text_repel.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        'Further aesthetics include
        clsgeom_text_repel.AddAesParameter("family", strIncludedDataTypes:={"factor"})
        clsgeom_text_repel.AddAesParameter("fontface", strIncludedDataTypes:={"factor"})
        clsgeom_text_repel.AddAesParameter("lineheight", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_text_repel.AddAesParameter("hjust", strIncludedDataTypes:={"numeric"})
        clsgeom_text_repel.AddAesParameter("vjust", strIncludedDataTypes:={"numeric"})
        clsgeom_text_repel.AddAesParameter("angle", strIncludedDataTypes:={"factor", "numeric"})
        'Adding layer parameters
        'Geom_text_repel Parameters
        clsgeom_text_repel.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "stack" & Chr(34), "position_dodge(width = 0.9)", Chr(34) & "dodge2" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})
        clsgeom_text_repel.AddLayerParameter("parse", "boolean", "FALSE")
        clsgeom_text_repel.AddLayerParameter("box.padding", "numeric", "0.25", lstParameterStrings:={2, 0})
        clsgeom_text_repel.AddLayerParameter("point.padding", "numeric", "0", lstParameterStrings:={2, 0})
        clsgeom_text_repel.AddLayerParameter("min.segment.length", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_text_repel.AddLayerParameter("arrow", "editablelist", "arrow()", lstParameterStrings:={"arrow()"})
        clsgeom_text_repel.AddLayerParameter("max.time", "numeric", "0.5")
        clsgeom_text_repel.AddLayerParameter("max.iter", "numeric", "1000", lstParameterStrings:={0, 1})
        clsgeom_text_repel.AddLayerParameter("max.overlaps", "numeric", "10", lstParameterStrings:={0, 1})
        clsgeom_text_repel.AddLayerParameter("nudge_x", "numeric", "0", lstParameterStrings:={2})
        clsgeom_text_repel.AddLayerParameter("nudge_y", "numeric", "0", lstParameterStrings:={2})
        clsgeom_text_repel.AddLayerParameter("xlim", "numeric", "1", lstParameterStrings:={2})
        clsgeom_text_repel.AddLayerParameter("ylim", "numeric", "1", lstParameterStrings:={2})
        clsgeom_text_repel.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_text_repel.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})
        clsgeom_text_repel.AddLayerParameter("force", "numeric", "1", lstParameterStrings:={2})
        clsgeom_text_repel.AddLayerParameter("force_pull", "numeric", "1", lstParameterStrings:={2})
        lstAllGeoms.Add(clsgeom_text_repel)

        clsgeom_tile.strGeomName = "geom_tile"

        'Mandatory Aesthetics 
        clsgeom_tile.AddAesParameter("x", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        clsgeom_tile.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)

        'Optional Aesthetics 
        clsgeom_tile.AddAesParameter("alpha", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_tile.AddAesParameter("colour", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_tile.AddAesParameter("fill", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_tile.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_tile.AddAesParameter("size", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_tile.AddAesParameter("group")
        clsgeom_tile.AddAesParameter("width", strIncludedDataTypes:={"numeric"})
        clsgeom_tile.AddAesParameter("height", strIncludedDataTypes:={"numeric"})

        'Global layer parameters
        clsgeom_tile.AddLayerParameter("stat", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_tile.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_tile.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_tile.AddLayerParameter("na.rm", "list", "FALSE", lstParameterStrings:={"TRUE", "FALSE"})

        'Geom Layer Parameters 
        clsgeom_tile.AddLayerParameter("width", "numeric", "0", lstParameterStrings:={2})
        clsgeom_tile.AddLayerParameter("height", "numeric", "0", lstParameterStrings:={2})

        'Optional Aesthetics as Layer Parameters
        clsgeom_tile.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})
        clsgeom_tile.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_tile.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34))
        clsgeom_tile.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_tile.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0})
        'clsgeom_tile.AddLayerParameter("group")

        lstAllGeoms.Add(clsgeom_tile)

        clsgeom_treemap.SetGeomName("geom_treemap")
        clsgeom_treemap.SetGeomPackage("treemapify")

        clsgeom_treemap.AddAesParameter("area", strIncludedDataTypes:=({"numeric"}), bIsMandatory:=True)
        clsgeom_treemap.AddAesParameter("alpha", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_treemap.AddAesParameter("colour", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_treemap.AddAesParameter("fill", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_treemap.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_treemap.AddAesParameter("subgroup", strIncludedDataTypes:={"factor"})
        clsgeom_treemap.AddAesParameter("subgroup2", strIncludedDataTypes:={"factor"})
        clsgeom_treemap.AddAesParameter("subgroup3", strIncludedDataTypes:={"factor"})

        clsgeom_treemap.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "count" & Chr(34)})
        clsgeom_treemap.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_treemap.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_treemap.AddLayerParameter("show.legend", "list", "NA", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_treemap.AddLayerParameter("inherit.aes", "boolean", "TRUE")
        clsgeom_treemap.AddLayerParameter("layout", "list", Chr(34) & "squarified" & Chr(34), lstParameterStrings:={Chr(34) & "squarified" & Chr(34), Chr(34) & "scol" & Chr(34), Chr(34) & "srow" & Chr(34), Chr(34) & "fixed" & Chr(34)})
        clsgeom_treemap.AddLayerParameter("start", "list", Chr(34) & "bottomleft" & Chr(34), lstParameterStrings:={Chr(34) & "bottomleft" & Chr(34), Chr(34) & "topleft" & Chr(34), Chr(34) & "topright" & Chr(34), Chr(34) & "bottomright" & Chr(34)})


        lstAllGeoms.Add(clsgeom_treemap)

        clsgeom_treemap_text.SetGeomName("geom_treemap_text")
        clsgeom_treemap_text.SetGeomPackage("treemapify")

        clsgeom_treemap_text.SetGeomName("geom_treemap_text")
        clsgeom_treemap_text.AddAesParameter("area", strIncludedDataTypes:=({"numeric"}), bIsMandatory:=True)
        clsgeom_treemap_text.AddAesParameter("label", bIsMandatory:=True)
        clsgeom_treemap_text.AddAesParameter("colour", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_treemap_text.AddAesParameter("size", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_treemap_text.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})
        clsgeom_treemap_text.AddAesParameter("family", strIncludedDataTypes:={"factor"})
        clsgeom_treemap_text.AddAesParameter("subgroup", strIncludedDataTypes:={"factor"})
        clsgeom_treemap_text.AddAesParameter("subgroup2", strIncludedDataTypes:={"factor"})
        clsgeom_treemap_text.AddAesParameter("subgroup3", strIncludedDataTypes:={"factor"})


        clsgeom_treemap_text.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "count" & Chr(34)})
        clsgeom_treemap_text.AddLayerParameter("na.rm", "boolean", "FALSE")
        clsgeom_treemap_text.AddLayerParameter("show.legend", "list", "NA", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_treemap_text.AddLayerParameter("inherit.aes", "boolean", "TRUE")
        clsgeom_treemap_text.AddLayerParameter("layout", "list", Chr(34) & "squarified" & Chr(34), lstParameterStrings:={Chr(34) & "squarified" & Chr(34), Chr(34) & "scol" & Chr(34), Chr(34) & "srow" & Chr(34), Chr(34) & "fixed" & Chr(34)})
        clsgeom_treemap_text.AddLayerParameter("start", "list", Chr(34) & "bottomleft" & Chr(34), lstParameterStrings:={Chr(34) & "bottomleft" & Chr(34), Chr(34) & "topleft" & Chr(34), Chr(34) & "topright" & Chr(34), Chr(34) & "bottomright" & Chr(34)})
        clsgeom_treemap_text.AddLayerParameter("position", "editablelist", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34)})
        clsgeom_treemap_text.AddLayerParameter("angle", "numeric", "0", lstParameterStrings:={0, 0, 360})
        clsgeom_treemap_text.AddLayerParameter("fontface", "list", Chr(34) & "plain" & Chr(34), lstParameterStrings:={Chr(34) & "plain" & Chr(34), Chr(34) & "bold" & Chr(34), Chr(34) & "italic" & Chr(34), Chr(34) & "bold.italic" & Chr(34)})

        lstAllGeoms.Add(clsgeom_treemap_text)


        clsgeom_tufteboxplot.SetGeomName("geom_tufteboxplot")
        clsgeom_tufteboxplot.SetGeomPackage("ggthemes")

        'Mandatory Aesthetics
        clsgeom_tufteboxplot.AddAesParameter("x", strIncludedDataTypes:={"factor"}, bIsMandatory:=True)
        clsgeom_tufteboxplot.AddAesParameter("y", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)

        'Optional Aesthetics
        clsgeom_tufteboxplot.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_tufteboxplot.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_tufteboxplot.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_tufteboxplot.AddAesParameter("shape", strIncludedDataTypes:={"factor"})
        clsgeom_tufteboxplot.AddAesParameter("fill", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_tufteboxplot.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})

        'Layer parameters
        clsgeom_tufteboxplot.AddLayerParameter("stat", "editablelist", Chr(34) & "boxplot" & Chr(34), lstParameterStrings:={Chr(34) & "boxplot" & Chr(34), Chr(34) & "fivenumber" & Chr(34)})
        clsgeom_tufteboxplot.AddLayerParameter("position", "editablelist", Chr(34) & "dodge" & Chr(34), lstParameterStrings:={Chr(34) & "dodge" & Chr(34)})
        clsgeom_tufteboxplot.AddLayerParameter("coef", "numeric", "1.5", lstParameterStrings:={1}) 'Question to be discussed: This parameter is setting the length of the whiskers as a multiple of the IQR. When giving a negative value, the whiskers are simply of length 0. Also the window showing the graph doesn't adapt to the whiskers' length, which means they are simply cut when too long.
        clsgeom_tufteboxplot.AddLayerParameter("outlier.shape", "list", Chr(34) & "circle" & Chr(34), lstParameterStrings:=strShapePoint)
        clsgeom_tufteboxplot.AddLayerParameter("outlier.colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_tufteboxplot.AddLayerParameter("outlier.size", "numeric", "1.5", lstParameterStrings:={1, 0})
        clsgeom_tufteboxplot.AddLayerParameter("outlier.stroke", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_tufteboxplot.AddLayerParameter("voffset", "numeric", "0.01", lstParameterStrings:={2, 0})
        clsgeom_tufteboxplot.AddLayerParameter("hoffset", "numeric", "0.005", lstParameterStrings:={3, 0})
        clsgeom_tufteboxplot.AddLayerParameter("median.type", "list", Chr(34) & "point" & Chr(34), lstParameterStrings:={Chr(34) & "point" & Chr(34), Chr(34) & "line" & Chr(34)})
        clsgeom_tufteboxplot.AddLayerParameter("whisker.type", "list", Chr(34) & "line" & Chr(34), lstParameterStrings:={Chr(34) & "line" & Chr(34), Chr(34) & "point" & Chr(34)})
        clsgeom_tufteboxplot.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_tufteboxplot.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0})
        clsgeom_tufteboxplot.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_tufteboxplot.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34))
        clsgeom_tufteboxplot.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})

        lstAllGeoms.Add(clsgeom_tufteboxplot)


        clsgeom_violin.strGeomName = "geom_violin"
        'Mandatory Aesthetics
        clsgeom_violin.AddAesParameter("x", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        clsgeom_violin.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"}, bIsMandatory:=True)
        'Optional Aesthetics
        clsgeom_violin.AddAesParameter("weight", strIncludedDataTypes:=({"numeric"}))
        clsgeom_violin.AddAesParameter("alpha", strIncludedDataTypes:=({"factor", "numeric"})) 'Varies transparence of the fill.
        clsgeom_violin.AddAesParameter("fill", strIncludedDataTypes:=({"factor", "numeric"}))
        clsgeom_violin.AddAesParameter("colour", strIncludedDataTypes:=({"factor", "numeric"})) 'Colour of the outline.
        clsgeom_violin.AddAesParameter("linetype", strIncludedDataTypes:=({"factor"})) 'Outline linetype.
        clsgeom_violin.AddAesParameter("size", strIncludedDataTypes:=({"factor", "numeric"})) 'Varies the size of the outline.

        'adding layer parameters
        'Geom_density layer parameters
        clsgeom_violin.AddLayerParameter("draw_quantiles", "list", "NULL", lstParameterStrings:={"NULL", "0.25", "0.5", "0.75", "c(0.25, 0.5)", "c(0.25, 0.75)", "c(0.5,0.75)", "c(0.25,0.5,0.75)"}) 'If not(NULL) (default), draw horizontal lines at the given quantiles of the density estimate - confusing instructions; it's say NULL is the default and when it not NULL and soemthing else then draw horizontal lines at the given quantiles of the density estimate
        clsgeom_violin.AddLayerParameter("trim", "boolean", "TRUE", lstParameterStrings:={"TRUE", "FALSE"}) 'If TRUE (default), trim the tails of the violins to the range of the data. If FALSE, don't trim the tails.
        clsgeom_violin.AddLayerParameter("scale", "list", Chr(34) & "area" & Chr(34), lstParameterStrings:={Chr(34) & "area" & Chr(34), Chr(34) & "count" & Chr(34), Chr(34) & "width" & Chr(34)}) 'if "area" (default), all violins have the same area (before trimming the tails). If "count", areas are scaled proportionally to the number of observations. If "width", all violins have the same maximum width.
        clsgeom_violin.AddLayerParameter("bw", "list", Chr(34) & "nrd0" & Chr(34), lstParameterStrings:={Chr(34) & "nrd0" & Chr(34), Chr(34) & "SJ" & Chr(34), Chr(34) & "nrd" & Chr(34), Chr(34) & "ucv" & Chr(34), Chr(34) & "bcv" & Chr(34)}) 'Bandwidth.
        clsgeom_violin.AddLayerParameter("adjust", "numeric", "1", lstParameterStrings:={1, 0}) 'The bandwidth used is actually adjust*bw. This makes it easy to specify values like ‘half the default’ bandwidth.
        clsgeom_violin.AddLayerParameter("kernel", "list", Chr(34) & "gaussian" & Chr(34), lstParameterStrings:={Chr(34) & "gaussian" & Chr(34), Chr(34) & "rectangular" & Chr(34), Chr(34) & "triangular" & Chr(34), Chr(34) & "epanechnikov" & Chr(34), Chr(34) & "biweight" & Chr(34), Chr(34) & "cosine" & Chr(34), Chr(34) & "optcosin" & Chr(34)}) 'A character string giving the smoothing kernel to be used.
        'This is only a parameter in developer version of ggplot. May soon be in release version.
        'clsgeom_density.AddLayerParameter("n", "numeric", "512", lstParameterStrings:={0, 0}) 'The number of equally spaced points at which the density is to be estimated. When n > 512, it is rounded up to a power of 2 during the calculations. If negative, sends an error.
        'This parameter only matters if you are displaying multiple densities in one plot. If FALSE, the default, each density is computed on the full range of the data. If TRUE, each density is computed over the range of that group: this typically means the estimated x values will not line-up, and hence you won't be able to stack density values.

        'Global Layer parameters
        'clsgeom_violin.AddLayerParameter("stat", "list", Chr(34) & "density" & Chr(34), lstParameterStrings:={Chr(34) & "density" & Chr(34), Chr(34) & "identity" & Chr(34)}) 'Warning: commented out as when set to "identity", all the parameters bw, n, etc are unknown as they belong to stat_density. Think it's easier for now to not allow "identity" instead of introducing dependent exclusion of parameters.
        clsgeom_violin.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        clsgeom_violin.AddLayerParameter("position", "list", Chr(34) & "dodge" & Chr(34), lstParameterStrings:={Chr(34) & "dodge" & Chr(34), Chr(34) & "dodge2" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "fill" & Chr(34), Chr(34) & "stack" & Chr(34), Chr(34) & "jitter" & Chr(34)})
        ''Warning: "Stacked density plots: If you want to create a stacked density plot, you probably want To 'count' (density * n) variable instead of the default density."
        ''Question to be discussed: when changing parameter position to stack, should automatically add x="..count.." in the aesthetics parameters ? Carefull to not copy count into variable receivers, add methods like for "" in the boxplt case.
        ''See global comments about position.

        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_violin.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34))
        clsgeom_violin.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_violin.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_violin.AddLayerParameter("alpha", "numeric", "0", lstParameterStrings:={2, 0, 1}) 'Varies transparence of fill.
        clsgeom_violin.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) ''Varies the size of outline. Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...

        lstAllGeoms.Add(clsgeom_violin)

        clsgeom_vline.SetGeomName("geom_vline") 'Warning: this geom never inherits global aesthetics ! It also doesn't affect the x and y scales. Can specify yintercept either with aes, or with parameter (second one overwrites). If want to vary with facets, need to mention as aes.
        'Warning: it does not have position or stat, neither inherit.aes parameters. However, when mentioned, these are simply ignored... 
        'Task: untick and disable IgnoreGlobalAes and ApplyOnAllLayers for this geom.
        'Task: add warning message to user...
        'Adding aesthetics parameters
        'Mandatory Aesthetics
        clsgeom_vline.AddAesParameter("xintercept", strIncludedDataTypes:={"numeric"})
        'Warning/to be discussed: when this is set as parameter, it is not really mandatory... should we introduce a partially mandatory method nbr 2 ? For now I think it can be left like this...
        'Optional aesthetics
        clsgeom_vline.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_vline.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_vline.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_vline.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        'Adding layer parameters
        'Geom_hline parameters
        clsgeom_vline.AddLayerParameter("xintercept", "numeric", "0", lstParameterStrings:={2}) 'Parameter that controls the position of the line. If this is set, data, mapping and show.legend are overridden
        'Task: add warning message to user...
        'Global Layer parameters
        clsgeom_vline.AddLayerParameter("show.legend", "list", "TRUE", lstParameterStrings:={"NA", "TRUE", "FALSE"})
        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_vline.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_vline.AddLayerParameter("linetype", "list", Chr(34) & "blank" & Chr(34), lstParameterStrings:=strLineType)
        clsgeom_vline.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})
        clsgeom_vline.AddLayerParameter("size", "numeric", "0.5", lstParameterStrings:={1, 0}) ''Varies the size of outline. Note: negative size gives size 0 in general, but 'Warning: sometimesgive errors...

        lstAllGeoms.Add(clsgeom_vline)

        For Each Geom In lstAllGeoms
            Geom.AddLayerParameter("key_glyph", "list", Chr(34) & "point" & Chr(34), lstParameterStrings:={Chr(34) & "point" & Chr(34), Chr(34) & "abline" & Chr(34), Chr(34) & "rect" & Chr(34), Chr(34) & "polygon" & Chr(34), Chr(34) & "blank" & Chr(34), Chr(34) & "boxplot" & Chr(34), Chr(34) & "crossbar" & Chr(34), Chr(34) & "path" & Chr(34), Chr(34) & "vpath" & Chr(34), Chr(34) & "dotplot" & Chr(34), Chr(34) & "pointrange" & Chr(34), Chr(34) & "smooth" & Chr(34), Chr(34) & "text" & Chr(34), Chr(34) & "label" & Chr(34), Chr(34) & "vline" & Chr(34), Chr(34) & "timeseries" & Chr(34)})
        Next

    End Sub

    Public Event GeomChanged()

    Private Sub ucrInputGeoms_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputGeoms.ControlValueChanged
        Dim clsParam As New LayerParameter
        Dim iNewGeomIndex As Integer

        If Not bPauseChanges Then
            iNewGeomIndex = lstAllGeoms.FindIndex(Function(x) x.strGeomName = ucrInputGeoms.GetText())
            If iCurrentGeomIndex = -1 Then
                iCurrentGeomIndex = lstAllGeoms.FindIndex(Function(x) x.strGeomName = clsGeomFunction.strRCommand)
            End If
            If iNewGeomIndex <> -1 Then
                clsCurrGeom = lstAllGeoms(iNewGeomIndex)
                If iNewGeomIndex <> iCurrentGeomIndex Then
                    'TODO Why do we have to remove the parameters here?
                    If Not bResetGlobal Then
                        For Each clsParam In lstAllGeoms(iCurrentGeomIndex).clsLayerParameters
                            clsGeomFunction.RemoveParameterByName(clsParam.strLayerParameterName)
                        Next
                    End If
                    clsGeomFunction.SetPackageName(clsCurrGeom.strGeomPackage)
                    clsGeomFunction.SetRCommand(clsCurrGeom.strGeomName)
                    iCurrentGeomIndex = iNewGeomIndex
                    RaiseEvent GeomChanged()
                Else
                    clsGeomFunction.SetPackageName(clsCurrGeom.strGeomPackage)
                    clsGeomFunction.SetRCommand(clsCurrGeom.strGeomName)
                End If
            End If
        End If
    End Sub

    Public Sub SetGeomName(strNewGeom As String)
        ucrInputGeoms.SetName(strNewGeom)
    End Sub

    Public Function GetGeomName() As String
        Return ucrInputGeoms.GetText()
    End Function
End Class
