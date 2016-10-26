
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

Public Class ucrGeom
    'Ucr Geom is used to select the geom that will be used for a specific graph/layer. It is used in ucrGeomListWithAes and ucrLayerParameters both ucr's of sdgLayerOptions. 
    'It stores the definition of the different Geoms, using instances of clsGeom, including their R names, the relevant/available parameters and their description (type of values, values, default, ...).
    Public lstAllGeoms As New List(Of Geoms)
    Public lstGgParameters As New List(Of RParameter)
    'Warning: This is used nowhere ...
    'Question: lstGgParameters lists of the ggplot parameters ? Let's delete ?
    Public clsCurrGeom As New Geoms
    Public clsGeomFunction As New RFunction
    Public lstFunctionParameters As New List(Of RParameter)
    'Question: clsGeomFunction is the RFunction associated to the clsCurrGeom ? Could it be included in clsCurrGeom, if yes do we wish that ? Used together with clsGgplotAesFunction... ?
    'Similarly for lstFunctionParameters. Both, together with clsGgplotAesFunction are supposedly passed through to ucrAdditionalLayers and assigned to smth in ucrAdditionalLayers by calling  sdgLayerOption.SetupLayer which calls setup ? Still need to figure out when/how they are used though...
    Public clsGgplotAesFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Public strGlobalDataFrame As String = ""

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CreateGeomList()
    End Sub

    Private Sub UcrGeoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseControl()
        clsGeomFunction.AddParameter("mapping", clsRFunctionParameter:=clsGgplotAesFunction)
    End Sub

    Public Overridable Sub Setup(clsTempGgPlot As RFunction, clsTempGeomFunc As RFunction, clsTempAesFunc As RFunction, Optional bFixAes As Boolean = False, Optional bFixGeom As Boolean = False, Optional strDataframe As String = "", Optional bApplyAesGlobally As Boolean = True, Optional bIgnoreGlobalAes As Boolean = False, Optional iNumVariablesForGeoms As Integer = -1, Optional clsTempLocalAes As RFunction = Nothing)
        'Setup is used to setup the parameters of ucrGeom as well as ucrGeomListWithAes and ucrLayerParameters as they override Setup from ucrGeom. The Setup function is also used within sdgLayerOptions.SetupLayer which plays the same role for the whole sdlLayerOption.
        'These functions are called all together in the ucrAddLayers when a Layer is added or editted, as well as in specific plots dialogs such as dlgBoxPlot when the plot options sdgPlots (dealing with layers) is opened.
        Dim GeomCount As New Geoms

        'First we clear the content of the displayed list (in cboGeomList) of available geoms as this may change between different setup's according to the parameter iNumVariablesForGeoms (see below). 
        cboGeomList.Items.Clear()
        'Then we add geom names from our lstAllGeoms to cboGeomList when the number of available variables to associate to geom Aes (iNumVariablesForGeom) is greater or equal to the number of mandatory Aes of that geom. Correct ?
        For Each GeomCount In lstAllGeoms
            If iNumVariablesForGeoms <= GeomCount.iNumMandatoryAes Then
                'Warning: Should this not be greater or equal instead of lower or equal ? But then what would the default value be for iNumVariablesForGeom ? Not -1 !!
                cboGeomList.Items.Add(GeomCount.strGeomName)
            End If
        Next
        'Task: needs further commenting when understood. clsGeomFunction is set at different occasions, not only in setup. SetGeomFunction overwritten...
        SetGeomFunction(clsTempGeomFunc)
        If clsGeomFunction.strRCommand = Nothing OrElse cboGeomList.Items.IndexOf(clsGeomFunction.strRCommand) = -1 Then
            cboGeomList.SelectedIndex = cboGeomList.Items.IndexOf("geom_boxplot")
        Else
            cboGeomList.SelectedIndex = cboGeomList.Items.IndexOf(clsGeomFunction.strRCommand)
        End If
        cboGeomList.Enabled = Not bFixGeom
        clsGgplotAesFunction = clsTempAesFunc
        clsGgplotAesFunction.SetRCommand("aes")
    End Sub

    Public Overridable Sub SetGeomFunction(clsTempGeomFunc As RFunction)
        clsGeomFunction = clsTempGeomFunc
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
        Dim clsgeom_crossbar As New Geoms
        Dim clsgeom_curve As New Geoms
        Dim clsgeom_density As New Geoms
        Dim clsgeom_density2d As New Geoms
        Dim clsgeom_density_2d As New Geoms
        Dim clsgeom_dotplot As New Geoms
        Dim clsgeom_errorbar As New Geoms
        Dim clsgeom_errorbarh As New Geoms
        Dim clsgeom_freqpoly As New Geoms
        Dim clsgeom_hex As New Geoms
        Dim clsgeom_histogram As New Geoms
        Dim clsgeom_hline As New Geoms
        Dim clsgeom_jitter As New Geoms
        Dim clsgeom_label As New Geoms
        Dim clsgeom_line As New Geoms
        Dim clsgeom_linerange As New Geoms
        Dim clsgeom_map As New Geoms
        Dim clsgeom_path As New Geoms
        Dim clsgeom_point As New Geoms
        Dim clsgeom_pointrange As New Geoms
        Dim clsgeom_polygon As New Geoms
        Dim clsgeom_qq As New Geoms
        Dim clsgeom_quantile As New Geoms
        Dim clsgeom_raster As New Geoms
        Dim clsgeom_rect As New Geoms
        Dim clsgeom_ribbon As New Geoms
        Dim clsgeom_rug As New Geoms
        Dim clsgeom_segment As New Geoms
        Dim clsgeom_smooth As New Geoms
        Dim clsgeom_spoke As New Geoms
        Dim clsgeom_step As New Geoms
        Dim clsgeom_text As New Geoms
        Dim clsgeom_tile As New Geoms
        Dim clsgeom_violin As New Geoms
        Dim clsgeom_vline As New Geoms


        'clsgeom_abline.SetGeomName("geom_abline")
        'clsgeom_abline.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_abline.AddAesParameter("y", bIsMandatory:=True)
        'clsgeom_abline.AddAesParameter("alpha")
        'clsgeom_abline.AddAesParameter("colour")
        'clsgeom_abline.AddAesParameter("linetype")
        'clsgeom_abline.AddAesParameter("size")
        ''aesthetics that control position of line include
        ''geom_vline:xintercept
        ''geom_hline:yintercept
        ''geom_abline: slope and intercept
        ''TO DO Discuss how to use these
        ''add layer parameters 
        'clsgeom_abline.AddLayerParameter("intercept", "numeric", "0")
        'clsgeom_abline.AddLayerParameter("xxxxxxxx", "numeric", "0")
        'lstAllGeoms.Add(clsgeom_abline)

        'clsgeom_area.SetGeomName("geom_area")
        ''mandatory aesthetics 
        'clsgeom_area.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_area.AddAesParameter("ymax", bIsMandatory:=True)
        'clsgeom_area.AddAesParameter("ymin", bIsMandatory:=True)
        ''Optional 
        'clsgeom_area.AddAesParameter("alpha")
        'clsgeom_area.AddAesParameter("colour")
        'clsgeom_area.AddAesParameter("fill")
        'clsgeom_area.AddAesParameter("linetype")
        'clsgeom_area.AddAesParameter("size")

        ''add layer parameters 
        'clsgeom_area.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_area.AddLayerParameter("position", "list", Chr(34) & "stack" & Chr(34))
        'clsgeom_area.AddLayerParameter("na.rm", "boolean", "FALSE")
        'lstAllGeoms.Add(clsgeom_area)

        clsgeom_bar.SetGeomName("geom_bar")
        clsgeom_bar.AddAesParameter("x", strIncludedDataTypes:=({"factor"}), bIsMandatory:=True)
        'Optional
        'we can map a continuous variable to y but we must include stat = “identity” inside the geom.
        clsgeom_bar.AddAesParameter("y", strIncludedDataTypes:=({"numeric"}))
        clsgeom_bar.AddAesParameter("alpha", strIncludedDataTypes:=({"factor"}))
        clsgeom_bar.AddAesParameter("fill", strIncludedDataTypes:=({"factor"}))
        clsgeom_bar.AddAesParameter("colour", strIncludedDataTypes:=({"factor"}))
        clsgeom_bar.AddAesParameter("linetype", strIncludedDataTypes:=({"factor"})) 'won't visibly change anything unless you change the theme
        clsgeom_bar.AddAesParameter("size", strIncludedDataTypes:=({"factor", "numeric"})) ' won't visibly change anything unless you change the theme

        'add layer parameters 
        clsgeom_bar.AddLayerParameter("stat", "list", Chr(34) & "count" & Chr(34), lstParameterStrings:={Chr(34) & "count" & Chr(34), Chr(34) & "identity" & Chr(34)})
        clsgeom_bar.AddLayerParameter("position", "list", Chr(34) & "stack" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "fill" & Chr(34), Chr(34) & "dodge" & Chr(34)})
        clsgeom_bar.AddLayerParameter("width", "numeric", "0.90", lstParameterStrings:={2, 0, 1})
        lstAllGeoms.Add(clsgeom_bar)


        'clsgeom_bin2d.SetGeomName("geom_bin2d")
        ''mandatory
        'clsgeom_bin2d.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_bin2d.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_bin2d.AddAesParameter("fill")
        ''adding layer parameters
        'clsgeom_bin2d.AddLayerParameter("stat", "list", Chr(34) & "bin2d" & Chr(34))
        'clsgeom_bin2d.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_bin2d.AddLayerParameter("na.rm", "boolean", "FALSE")
        'clsgeom_bin2d.AddLayerParameter("bins", "numeric", "30")
        'clsgeom_bin2d.AddLayerParameter("binwidth", "numeric", "0.1")

        'lstAllGeoms.Add(clsgeom_bin2d)


        clsgeom_boxplot.SetGeomName("geom_boxplot")
        clsgeom_boxplot.AddAesParameter("x")
        'Warning: When x is continuous, there needs to be a grouping variable... for example cut_width(x,0.25). Are there other grouping possibilities ?
        clsgeom_boxplot.AddAesParameter("group", strIncludedDataTypes:={"factor"})
        clsgeom_boxplot.AddAesParameter("y", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)

        'Warning: The following aesthetics should be assigned to calculations for the different parameters of a boxplot. Only relevant for sort of summaries. 
        'clsgeom_boxplot.AddAesParameter("lower", strIncludedDataTypes:={"numeric"})
        'clsgeom_boxplot.AddAesParameter("upper", strIncludedDataTypes:={"numeric"})
        'clsgeom_boxplot.AddAesParameter("middle", strIncludedDataTypes:={"numeric"})
        'clsgeom_boxplot.AddAesParameter("ymax", strIncludedDataTypes:={"numeric"})
        'clsgeom_boxplot.AddAesParameter("ymin", strIncludedDataTypes:={"numeric"})

        clsgeom_boxplot.AddAesParameter("fill", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_boxplot.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_boxplot.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_boxplot.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_boxplot.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_boxplot.AddAesParameter("weight", strIncludedDataTypes:={"numeric"})
        clsgeom_boxplot.AddAesParameter("shape", strIncludedDataTypes:={"factor"})
        clsgeom_boxplot.AddAesParameter("weight", strIncludedDataTypes:={"numeric"})

        'adding layerParameters
        'Main geom_boxplot parameters
        clsgeom_boxplot.AddLayerParameter("notch", "boolean", "TRUE")
        clsgeom_boxplot.AddLayerParameter("notchwidth", "numeric", "0.5", lstParameterStrings:={0.1, 0, 1})
        clsgeom_boxplot.AddLayerParameter("varwidth", "boolean", "TRUE")
        clsgeom_boxplot.AddLayerParameter("coef", "numeric", "1.5", lstParameterStrings:={0.2, 1, 4}) 'Question to be discussed: This parameter is setting the length of the whiskers as a multiple of th IQR. Are these values ok ?
        clsgeom_boxplot.AddLayerParameter("outlier.shape", "numeric", "19", lstParameterStrings:={1, 0, 25}) 'there are other symbols that we can add here 
        clsgeom_boxplot.AddLayerParameter("outlier.colour", "colour", "NULL")
        clsgeom_boxplot.AddLayerParameter("outlier.stroke ", "numeric", "0.5", lstParameterStrings:={1, 0})
        'Global Layer parameters
        clsgeom_boxplot.AddLayerParameter("show.legend", "boolean", "TRUE") 'Warning/Question to discuss: the default value in R is NA. Should that be the default value here ? When the parameter is not ticked on the sdgPlotOptions, it is not mentioned in the layer R command isn't it ?
        clsgeom_boxplot.AddLayerParameter("position", "list", Chr(34) & "dodge" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "fill" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "identity" & Chr(34)}) 'Could add the possiility to adjust the height and width parameters of these position functions... Sometimes useful to only jitter in one direction for example...
        'Aesthetics as layer parameters...
        clsgeom_boxplot.AddLayerParameter("fill", "colour", "NULL")
        clsgeom_boxplot.AddLayerParameter("colour", "colour", "NULL")
        clsgeom_boxplot.AddLayerParameter("linetype", "numeric", "1", lstParameterStrings:={1, 0, 6})
        clsgeom_boxplot.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={0.01, 0, 1})

        lstAllGeoms.Add(clsgeom_boxplot)

        'clsgeom_contour.SetGeomName("geom_contour")
        ''Mandatory
        'clsgeom_contour.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_contour.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_contour.AddAesParameter("alpha")
        'clsgeom_contour.AddAesParameter("colour")
        'clsgeom_contour.AddAesParameter("linetype")
        'clsgeom_contour.AddAesParameter("size")
        'clsgeom_contour.AddAesParameter("weight")

        ''add layer parameters 
        'clsgeom_contour.AddLayerParameter("stat", "list", Chr(34) & "contour" & Chr(34))
        'clsgeom_contour.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_contour.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        'clsgeom_contour.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        ''linemitre should 1 or a number >1
        'clsgeom_contour.AddLayerParameter("linemitre", "numeric", "1")
        ''bin and binwidth could be added here as well. I am not sure if they are needed.... 
        'lstAllGeoms.Add(clsgeom_contour)

        'clsgeom_count.SetGeomName("geom_count")
        ''mandatory
        'clsgeom_count.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_count.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_count.AddAesParameter("alpha")
        'clsgeom_count.AddAesParameter("colour")
        'clsgeom_count.AddAesParameter("fill")
        'clsgeom_count.AddAesParameter("shape")
        'clsgeom_count.AddAesParameter("size")
        'clsgeom_count.AddAesParameter("stroke")

        ''adding layer parameters
        'clsgeom_count.AddLayerParameter("stat", "list", Chr(34) & "sum" & Chr(34))
        'clsgeom_count.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_count)

        'clsgeom_crossbar.strGeomName = "geom_crossbar"
        ''Mandatory
        'clsgeom_crossbar.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_crossbar.AddAesParameter("ymax", bIsMandatory:=True)
        'clsgeom_crossbar.AddAesParameter("ymin", bIsMandatory:=True)
        ''Optional
        'clsgeom_crossbar.AddAesParameter("alpha")
        'clsgeom_crossbar.AddAesParameter("colour")
        'clsgeom_crossbar.AddAesParameter("linetype")
        'clsgeom_crossbar.AddAesParameter("size")

        ''adding layer parameters
        'clsgeom_crossbar.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_crossbar.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_crossbar)

        'clsgeom_curve.strGeomName = "geom_curve"
        ''Mandatory
        'clsgeom_curve.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_curve.AddAesParameter("xend", bIsMandatory:=True)
        'clsgeom_curve.AddAesParameter("y", bIsMandatory:=True)
        'clsgeom_curve.AddAesParameter("yend", bIsMandatory:=True)
        ''Optional
        'clsgeom_curve.AddAesParameter("alpha")
        'clsgeom_curve.AddAesParameter("colour")
        'clsgeom_curve.AddAesParameter("linetype")
        'clsgeom_curve.AddAesParameter("size")

        ''adding layer parameters
        'clsgeom_curve.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_curve.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_curve.AddLayerParameter("curvature", "numeric", "0.5") 'numeric values. negative values give a left hand curve while positive values give right hand curves
        'clsgeom_curve.AddLayerParameter("angle", "numeric", "90") 'needs to be 0-180
        'clsgeom_curve.AddLayerParameter("ncp", "numeric", "5")  'more control point creates a smoother curve
        'clsgeom_curve.AddLayerParameter("lineend", "list", "butt", lstParameterStrings:={Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        'lstAllGeoms.Add(clsgeom_curve)

        clsgeom_density.strGeomName = "geom_density"
        'mandatory
        clsgeom_density.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        'we can map a continuous variable to y but we must include stat = “identity” inside the geom
        clsgeom_density.AddAesParameter("y", strIncludedDataTypes:={"numeric"})
        'optional
        clsgeom_density.AddAesParameter("alpha", strIncludedDataTypes:={"factor"})
        clsgeom_density.AddAesParameter("colour", strIncludedDataTypes:={"factor"})
        clsgeom_density.AddAesParameter("fill", strIncludedDataTypes:={"factor"})
        clsgeom_density.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_density.AddAesParameter("size", strIncludedDataTypes:={"factor"})
        clsgeom_density.AddAesParameter("weight", strIncludedDataTypes:={"numeric"})

        'adding layer parameters
        clsgeom_density.AddLayerParameter("stat", "list", Chr(34) & "density" & Chr(34), lstParameterStrings:={Chr(34) & "density" & Chr(34), Chr(34) & "identity" & Chr(34)})
        clsgeom_density.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "stack" & Chr(34), Chr(34) & "fill" & Chr(34), Chr(34) & "dodge" & Chr(34)})
        clsgeom_density.AddLayerParameter("bw", "list", "nrd0", lstParameterStrings:={"nrd0", "nrd", "ucv", "bcv", "SJ"})
        clsgeom_density.AddLayerParameter("adjust", "numeric", "1", lstParameterStrings:={1, 1})
        clsgeom_density.AddLayerParameter("kernel", "list", Chr(34) & "gaussian" & Chr(34), lstParameterStrings:={Chr(34) & "gaussian" & Chr(34), Chr(34) & "rectangular" & Chr(34), Chr(34) & "triangular" & Chr(34), Chr(34) & "epanechnikov" & Chr(34), Chr(34) & "biweight" & Chr(34), Chr(34) & "cosine" & Chr(34), Chr(34) & "optcosin" & Chr(34)})
        lstAllGeoms.Add(clsgeom_density)

        'clsgeom_density2d.strGeomName = "geom_density2d"
        ''Mandatory
        'clsgeom_density2d.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_density2d.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_density2d.AddAesParameter("alpha")
        'clsgeom_density2d.AddAesParameter("colour")
        'clsgeom_density2d.AddAesParameter("linetype")
        'clsgeom_density2d.AddAesParameter("size")

        ''Adding layer parameters
        'clsgeom_density2d.AddLayerParameter("stat", "list", Chr(34) & "density2d" & Chr(34))
        'clsgeom_density2d.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_density2d.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        'clsgeom_density2d.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        ''linemitre should 1 or a number >1
        'clsgeom_density2d.AddLayerParameter("linemitre", "numeric", "1")
        'lstAllGeoms.Add(clsgeom_density2d)

        'clsgeom_density_2d.strGeomName = "geom_density_2d"
        ''Mandatory
        'clsgeom_density_2d.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_density_2d.AddAesParameter("y", bIsMandatory:=True)
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

        clsgeom_dotplot.strGeomName = "geom_dotplot"
        clsgeom_dotplot.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        clsgeom_dotplot.AddAesParameter("y", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        'Optional
        clsgeom_dotplot.AddAesParameter("alpha", strIncludedDataTypes:={"factor"})
        clsgeom_dotplot.AddAesParameter("colour", strIncludedDataTypes:={"factor"})
        clsgeom_dotplot.AddAesParameter("fill", strIncludedDataTypes:={"factor"})
        'adding layer parameters
        clsgeom_dotplot.AddLayerParameter("method", "list", Chr(34) & "dotdensity" & Chr(34), lstParameterStrings:={Chr(34) & "dotdensity" & Chr(34), Chr(34) & "histodot" & Chr(34)})
        clsgeom_dotplot.AddLayerParameter("binwidth", "numeric", "1", lstParameterStrings:={1, 1})
        clsgeom_dotplot.AddLayerParameter("binaxis", "list", Chr(34) & "x" & Chr(34), lstParameterStrings:={Chr(34) & "x" & Chr(34), Chr(34) & "y" & Chr(34)})
        clsgeom_dotplot.AddLayerParameter("binpositions", "list", Chr(34) & "bygroup" & Chr(34), lstParameterStrings:={Chr(34) & "bygroup" & Chr(34), Chr(34) & "all" & Chr(34)})
        clsgeom_dotplot.AddLayerParameter("stackdir", "list", Chr(34) & "up" & Chr(34), lstParameterStrings:={Chr(34) & "up" & Chr(34), Chr(34) & "down" & Chr(34), Chr(34) & "center" & Chr(34), Chr(34) & "centerwhole" & Chr(34)})
        clsgeom_dotplot.AddLayerParameter("stackratio", "numeric", "1", lstParameterStrings:={1})
        clsgeom_dotplot.AddLayerParameter("dotsize", "numeric", "1", lstParameterStrings:={1})
        clsgeom_dotplot.AddLayerParameter("stackgroups", "Boolean", "FALSE")
        clsgeom_dotplot.AddLayerParameter("origin", "numeric", "0", lstParameterStrings:={1})
        clsgeom_dotplot.AddLayerParameter("right", "Boolean", "TRUE")
        clsgeom_dotplot.AddLayerParameter("width", "numeric", "0.9", lstParameterStrings:={1})
        clsgeom_dotplot.AddLayerParameter("drop", "Boolean", "FALSE")
        lstAllGeoms.Add(clsgeom_dotplot)


        'clsgeom_errorbar.strGeomName = "geom_errorbar"
        '''Mandatory
        'clsgeom_errorbar.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_errorbar.AddAesParameter("ymax", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        'clsgeom_errorbar.AddAesParameter("ymin", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        '''Optional
        'clsgeom_errorbar.AddAesParameter("alpha", strIncludedDataTypes:={"factor"})
        'clsgeom_errorbar.AddAesParameter("colour", strIncludedDataTypes:={"factor"})
        'clsgeom_errorbar.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        'clsgeom_errorbar.AddAesParameter("size", strIncludedDataTypes:={"factor"})
        'clsgeom_errorbar.AddAesParameter("width", strIncludedDataTypes:={"numeric"})
        ''adding layer parameters
        'clsgeom_errorbar.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_errorbar.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_errorbar)

        'clsgeom_errorbarh.strGeomName = "geom_errorbarh"
        ''mandatory
        'clsgeom_errorbarh.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_errorbarh.AddAesParameter("xmax", bIsMandatory:=True)
        'clsgeom_errorbarh.AddAesParameter("xmin", bIsMandatory:=True)
        'clsgeom_errorbarh.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_errorbarh.AddAesParameter("alpha")
        'clsgeom_errorbarh.AddAesParameter("colour")
        'clsgeom_errorbarh.AddAesParameter("height")
        'clsgeom_errorbarh.AddAesParameter("linetype")
        'clsgeom_errorbarh.AddAesParameter("size")

        'add layer parameters
        clsgeom_errorbarh.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        clsgeom_errorbarh.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        lstAllGeoms.Add(clsgeom_errorbarh)

        clsgeom_freqpoly.strGeomName = "geom_freqpoly"
        clsgeom_freqpoly.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        'we can map a continuous variable to y but stat= "identity" must be included within the geom
        clsgeom_freqpoly.AddAesParameter("y", strIncludedDataTypes:={"numeric"})
        clsgeom_freqpoly.AddAesParameter("alpha", strIncludedDataTypes:={"factor"})
        clsgeom_freqpoly.AddAesParameter("colour", strIncludedDataTypes:={"factor"})
        clsgeom_freqpoly.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_freqpoly.AddAesParameter("size", strIncludedDataTypes:={"factor"})

        'Add layer parameters
        clsgeom_freqpoly.AddLayerParameter("stat", "list", Chr(34) & "bin" & Chr(34), lstParameterStrings:={Chr(34) & "bin" & Chr(34), Chr(34) & "identity" & Chr(34)})
        clsgeom_freqpoly.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34)})
        lstAllGeoms.Add(clsgeom_freqpoly)

        'clsgeom_hex.strGeomName = "geom_hex"
        ''mandatory
        'clsgeom_hex.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_hex.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_hex.AddAesParameter("alpha")
        'clsgeom_hex.AddAesParameter("colour")
        'clsgeom_hex.AddAesParameter("fill")
        'clsgeom_hex.AddAesParameter("size")

        ''add layer parameter 
        'clsgeom_hex.AddLayerParameter("stat", "list", Chr(34) & "binhex" & Chr(34))
        'clsgeom_hex.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_hex)

        clsgeom_histogram.strGeomName = "geom_histogram"
        clsgeom_histogram.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_histogram.AddAesParameter("alpha", strIncludedDataTypes:={"factor"})
        clsgeom_histogram.AddAesParameter("colour", strIncludedDataTypes:={"factor"})
        clsgeom_histogram.AddAesParameter("fill", strIncludedDataTypes:={"factor"})
        clsgeom_histogram.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_histogram.AddAesParameter("size", strIncludedDataTypes:={"factor"}) 'nothing will visibly change unless the theme is changed 
        clsgeom_histogram.AddAesParameter("weight", strIncludedDataTypes:={"numeric"})

        'adding layer parameters
        clsgeom_histogram.AddLayerParameter("bins", "numeric", "30", lstParameterStrings:={0, 1})
        clsgeom_histogram.AddLayerParameter("binwidth", "numeric", "1", lstParameterStrings:={1, 1})
        clsgeom_histogram.AddLayerParameter("closed", "list", Chr(34) & "left" & Chr(34), lstParameterStrings:={Chr(34) & "left" & Chr(34), Chr(34) & "right" & Chr(34)})
        clsgeom_histogram.AddLayerParameter("position", "list", Chr(34) & "stack" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34)})
        lstAllGeoms.Add(clsgeom_histogram)


        'clsgeom_hline.strGeomName = "geom_hline"
        'clsgeom_hline.AddAesParameter("alpha")
        'clsgeom_hline.AddAesParameter("colour")
        'clsgeom_hline.AddAesParameter("linetype")
        'clsgeom_hline.AddAesParameter("size")
        ''aesthetics that control position of line include
        ''geom_vline:xintercept
        ''geom_hline:yintercept
        ''geom_abline: slope and intercept
        ''TO DO Discuss how to use these
        ''add layer parameter
        'clsgeom_hline.AddLayerParameter("yintercept", "numeric", "0")
        'lstAllGeoms.Add(clsgeom_hline)

        'clsgeom_jitter.strGeomName = "geom_jitter"
        ''mandatory
        'clsgeom_jitter.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_jitter.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_jitter.AddAesParameter("alpha")
        'clsgeom_jitter.AddAesParameter("colour")
        'clsgeom_jitter.AddAesParameter("fill")
        'clsgeom_jitter.AddAesParameter("shape")
        'clsgeom_jitter.AddAesParameter("size")
        'clsgeom_jitter.AddAesParameter("stroke")

        ''add layer parameter 
        'clsgeom_jitter.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_jitter.AddLayerParameter("position", "list", Chr(34) & "jitter" & Chr(34))
        'lstAllGeoms.Add(clsgeom_jitter)

        'clsgeom_label.strGeomName = "geom_label"
        ''mandatory
        'clsgeom_label.AddAesParameter("label", bIsMandatory:=True)
        'clsgeom_label.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_label.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_label.AddAesParameter("alpha")
        'clsgeom_label.AddAesParameter("colour")
        'clsgeom_label.AddAesParameter("family")
        'clsgeom_label.AddAesParameter("fontface")
        'clsgeom_label.AddAesParameter("hjust")
        'clsgeom_label.AddAesParameter("lineheight")
        ''TO DO add size and vjust this might need additon of labels and receivers  
        'lstAllGeoms.Add(clsgeom_label)


        clsgeom_line.strGeomName = "geom_line"
        'mandatory
        clsgeom_line.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        clsgeom_line.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        'optional
        clsgeom_line.AddAesParameter("alpha", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_line.AddAesParameter("colour", strIncludedDataTypes:={"numeric", "factor"})
        clsgeom_line.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_line.AddAesParameter("size", strIncludedDataTypes:={"numeric, factor"})

        'adding layer parameters
        clsgeom_line.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "stack" & Chr(34)}) 'others options are “jitter”, “dodge” And “stack”
        lstAllGeoms.Add(clsgeom_line)


        'clsgeom_linerange.strGeomName = "geom_linerange"
        ''mandatory
        'clsgeom_linerange.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_linerange.AddAesParameter("ymax", bIsMandatory:=True)
        'clsgeom_linerange.AddAesParameter("ymin", bIsMandatory:=True)
        ''optional
        'clsgeom_linerange.AddAesParameter("alpha")
        'clsgeom_linerange.AddAesParameter("colour")
        'clsgeom_linerange.AddAesParameter("linetype")
        'clsgeom_linerange.AddAesParameter("size")

        ''adding layer parameters
        'clsgeom_linerange.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_linerange.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_linerange)

        'clsgeom_map.strGeomName = "geom_map"
        ''mandatory
        'clsgeom_map.AddAesParameter("map_id", bIsMandatory:=True)
        ''optional
        'clsgeom_map.AddAesParameter("alpha")
        'clsgeom_map.AddAesParameter("colour")
        'clsgeom_map.AddAesParameter("fill")
        'clsgeom_map.AddAesParameter("linetype")
        'clsgeom_map.AddAesParameter("size")

        ''adding layer parameters
        'clsgeom_map.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_map)

        'clsgeom_path.strGeomName = "geom_path"
        ''mandatory
        'clsgeom_path.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_path.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_path.AddAesParameter("alpha")
        'clsgeom_path.AddAesParameter("colour")
        'clsgeom_path.AddAesParameter("linetype")
        'clsgeom_path.AddAesParameter("size")
        ''add layer parameters 
        'clsgeom_path.AddLayerParameter("stat", "list", Chr(34) & "contour" & Chr(34))
        'clsgeom_path.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_path.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        'clsgeom_path.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        ''linemitre should 1 or a number >1
        'clsgeom_path.AddLayerParameter("linemitre", "numeric", "1")
        'lstAllGeoms.Add(clsgeom_path)

        clsgeom_point.strGeomName = "geom_point"
        'mandatory
        clsgeom_point.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        clsgeom_point.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        'optional
        clsgeom_point.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_point.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_point.AddAesParameter("fill", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_point.AddAesParameter("shape", strIncludedDataTypes:={"factor"})
        clsgeom_point.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_point.AddAesParameter("stroke")
        'adding layer parameters
        clsgeom_point.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34)})
        lstAllGeoms.Add(clsgeom_point)

        'clsgeom_pointrange.strGeomName = "geom_pointrange"
        'clsgeom_pointrange.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_pointrange.AddAesParameter("ymax", bIsMandatory:=True)
        'clsgeom_pointrange.AddAesParameter("ymin", bIsMandatory:=True)
        ''optional
        'clsgeom_pointrange.AddAesParameter("alpha")
        'clsgeom_pointrange.AddAesParameter("colour")
        'clsgeom_pointrange.AddAesParameter("linetype")
        'clsgeom_pointrange.AddAesParameter("size")
        ''adding layer parameters
        'clsgeom_pointrange.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_pointrange.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))

        'lstAllGeoms.Add(clsgeom_pointrange)

        'clsgeom_polygon.strGeomName = "geom_polygon"
        'clsgeom_polygon.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_polygon.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_polygon.AddAesParameter("alpha")
        'clsgeom_polygon.AddAesParameter("colour")
        'clsgeom_polygon.AddAesParameter("fill")
        'clsgeom_polygon.AddAesParameter("linetype")
        'clsgeom_polygon.AddAesParameter("size")
        ''add layer parameters 
        'clsgeom_polygon.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_polygon.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_polygon)

        ''clsgeom_qq.strGeomName = "geom_qq"
        ''clsgeom_qq.AddAesParameter("sample", bIsMandatory:=True)
        '''optional
        ''clsgeom_qq.AddAesParameter("x")
        ''clsgeom_qq.AddAesParameter("y")
        ''lstAllGeoms.Add(clsgeom_qq)

        'clsgeom_quantile.strGeomName = "geom_quantile"
        'clsgeom_quantile.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_quantile.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_quantile.AddAesParameter("alpha")
        'clsgeom_quantile.AddAesParameter("colour")
        'clsgeom_quantile.AddAesParameter("linetype")
        'clsgeom_quantile.AddAesParameter("size")
        'clsgeom_quantile.AddAesParameter("weight")

        ''adding layer parameter
        'clsgeom_quantile.AddLayerParameter("stat", "list", Chr(34) & "contour" & Chr(34))
        'clsgeom_quantile.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_quantile.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        'clsgeom_quantile.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        ''linemitre should 1 or a number >1
        'clsgeom_quantile.AddLayerParameter("linemitre", "numeric", "1")
        'lstAllGeoms.Add(clsgeom_quantile)

        'clsgeom_raster.strGeomName = "geom_raster"
        ''mandatory
        'clsgeom_raster.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_raster.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_raster.AddAesParameter("alpha")
        'clsgeom_raster.AddAesParameter("colour")
        'clsgeom_raster.AddAesParameter("fill")
        'clsgeom_raster.AddAesParameter("linetype")
        'clsgeom_raster.AddAesParameter("size")

        ''add layer parameter
        'clsgeom_raster.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_raster.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_raster.AddLayerParameter("hjust", "numeric", "0.5")
        'clsgeom_raster.AddLayerParameter("vjust", "numeric", "0.5")

        'lstAllGeoms.Add(clsgeom_raster)

        'clsgeom_rect.strGeomName = "geom_rect"
        ''mandatory
        'clsgeom_rect.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_rect.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_rect.AddAesParameter("alpha")
        'clsgeom_rect.AddAesParameter("colour")
        'clsgeom_rect.AddAesParameter("fill")
        'clsgeom_rect.AddAesParameter("linetype")
        'clsgeom_rect.AddAesParameter("size")

        ''clsgeom_raster.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_rect.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_rect.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_rect)

        'clsgeom_ribbon.strGeomName = "geom_ribbon"
        'clsgeom_ribbon.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_ribbon.AddAesParameter("ymax", bIsMandatory:=True)
        'clsgeom_ribbon.AddAesParameter("ymin", bIsMandatory:=True)
        ''optional
        'clsgeom_ribbon.AddAesParameter("alpha")
        'clsgeom_ribbon.AddAesParameter("colour")
        'clsgeom_ribbon.AddAesParameter("linetype")
        'clsgeom_ribbon.AddAesParameter("size")

        ''add layer parameter 
        'clsgeom_ribbon.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_ribbon.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_ribbon)

        clsgeom_rug.strGeomName = "geom_rug"
        clsgeom_rug.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_rug.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"})
        'These two are not made mendatory as we want to be able to choose only one, and could be either.
        clsgeom_rug.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_rug.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_rug.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_rug.AddAesParameter("size", strIncludedDataTypes:={"factor", "numeric"})

        'add layer parameters
        clsgeom_rug.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "stack" & Chr(34)})
        clsgeom_rug.AddLayerParameter("sides", "list", Chr(34) & "bl" & Chr(34), lstParameterStrings:={Chr(34) & "trbl" & Chr(34), Chr(34) & "trb" & Chr(34), Chr(34) & "trl" & Chr(34), Chr(34) & "tbl" & Chr(34), Chr(34) & "rbl" & Chr(34), Chr(34) & "tr" & Chr(34), Chr(34) & "tb" & Chr(34), Chr(34) & "tl" & Chr(34), Chr(34) & "rb" & Chr(34), Chr(34) & "rl" & Chr(34), Chr(34) & "bl" & Chr(34), Chr(34) & "t" & Chr(34), Chr(34) & "r" & Chr(34), Chr(34) & "b" & Chr(34), Chr(34) & "l" & Chr(34)})
        lstAllGeoms.Add(clsgeom_rug)

        'clsgeom_segment.strGeomName = "geom_segment"
        ''mandatory
        'clsgeom_segment.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_segment.AddAesParameter("xend", bIsMandatory:=True)
        'clsgeom_segment.AddAesParameter("y", bIsMandatory:=True)
        'clsgeom_segment.AddAesParameter("yend", bIsMandatory:=True)
        ''optional
        'clsgeom_segment.AddAesParameter("alpha")
        'clsgeom_segment.AddAesParameter("colour")
        'clsgeom_segment.AddAesParameter("linetype")
        'clsgeom_segment.AddAesParameter("size")
        ''add  layer parameter
        'clsgeom_segment.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_segment.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_segment.AddLayerParameter("hjust", "numeric", "0.5")
        'clsgeom_segment.AddLayerParameter("vjust", "numeric", "0.5")
        'lstAllGeoms.Add(clsgeom_segment)

        ''clsgeom_smooth.strGeomName = "geom_smooth"
        '''mandatory
        ''clsgeom_smooth.AddAesParameter("x", bIsMandatory:=True)
        ''clsgeom_smooth.AddAesParameter("y", bIsMandatory:=True)
        '''optional 
        ''clsgeom_smooth.AddAesParameter("alpha")
        ''clsgeom_smooth.AddAesParameter("colour")
        ''clsgeom_smooth.AddAesParameter("fill")
        ''clsgeom_smooth.AddAesParameter("linetype")
        ''clsgeom_smooth.AddAesParameter("size")
        ''clsgeom_smooth.AddAesParameter("weight")
        ''lstAllGeoms.Add(clsgeom_smooth)

        'clsgeom_spoke.strGeomName = "geom_spoke"
        ''mandatory
        'clsgeom_spoke.AddAesParameter("angle", bIsMandatory:=True)
        'clsgeom_spoke.AddAesParameter("radius", bIsMandatory:=True)
        'clsgeom_spoke.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_spoke.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_spoke.AddAesParameter("alpha")
        'clsgeom_spoke.AddAesParameter("colour")
        'clsgeom_spoke.AddAesParameter("linetype")
        'clsgeom_spoke.AddAesParameter("size")

        ''add layer parameter
        'clsgeom_spoke.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_spoke.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_spoke)

        'clsgeom_step.strGeomName = "geom_step"
        'clsgeom_step.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_step.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_step.AddAesParameter("alpha")
        'clsgeom_step.AddAesParameter("colour")
        'clsgeom_step.AddAesParameter("linetype")
        'clsgeom_step.AddAesParameter("size")

        ''adding layer parameter
        'clsgeom_step.AddLayerParameter("stat", "list", Chr(34) & "contour" & Chr(34))
        'clsgeom_step.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_step.AddLayerParameter("lineend", "list", Chr(34) & "butt" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "butt" & Chr(34), Chr(34) & "square" & Chr(34)})
        'clsgeom_step.AddLayerParameter("linejoin", "list", Chr(34) & "round" & Chr(34), lstParameterStrings:={Chr(34) & "round" & Chr(34), Chr(34) & "mitre" & Chr(34), Chr(34) & "bevel" & Chr(34)})
        ''linemitre should 1 or a number >1
        'clsgeom_step.AddLayerParameter("linemitre", "numeric", "1")
        'lstAllGeoms.Add(clsgeom_step)

        'clsgeom_text.strGeomName = "geom_text"
        ''mandatory
        'clsgeom_text.AddAesParameter("label", bIsMandatory:=True)
        'clsgeom_text.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_text.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_text.AddAesParameter("alpha")
        'clsgeom_text.AddAesParameter("colour")
        'clsgeom_text.AddAesParameter("family")
        'clsgeom_text.AddAesParameter("fontface")
        'clsgeom_text.AddAesParameter("hjust")
        'clsgeom_text.AddAesParameter("lineheight")
        ''TO DO add size and vjust this might need additon of labels and receivers  


        ''adding layer parameters
        'clsgeom_text.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_text.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_text.AddLayerParameter("parse", "bolean", "FALSE")
        'clsgeom_text.AddLayerParameter("nudge_x", "numeric", "0")
        'clsgeom_text.AddLayerParameter("nudge_y", "numeric", "0")
        'clsgeom_text.AddLayerParameter("check_overlap", "bolean", "FALSE")
        'lstAllGeoms.Add(clsgeom_text)

        'clsgeom_tile.strGeomName = "geom_tile"
        ''mandatory
        'clsgeom_tile.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_tile.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_tile.AddAesParameter("alpha")
        'clsgeom_tile.AddAesParameter("colour")
        'clsgeom_tile.AddAesParameter("fill")
        'clsgeom_tile.AddAesParameter("linetype")
        'clsgeom_tile.AddAesParameter("size")

        ''add layer parameters
        'clsgeom_tile.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_tile.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_tile)

        'clsgeom_violin.strGeomName = "geom_violin"
        ''mandatory
        'clsgeom_violin.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_violin.AddAesParameter("y", bIsMandatory:=True)
        ''optional
        'clsgeom_violin.AddAesParameter("alpha")
        'clsgeom_violin.AddAesParameter("colour")
        'clsgeom_violin.AddAesParameter("fill")
        'clsgeom_violin.AddAesParameter("linetype")
        'clsgeom_violin.AddAesParameter("size")
        'clsgeom_violin.AddAesParameter("weight")
        ''add layer parameter
        'clsgeom_violin.AddLayerParameter("stat", "list", Chr(34) & "ydensity" & Chr(34))
        'clsgeom_violin.AddLayerParameter("position", "list", Chr(34) & "dodge" & Chr(34))
        'lstAllGeoms.Add(clsgeom_violin)

        'clsgeom_vline.strGeomName = "geom_vline"
        'clsgeom_vline.AddAesParameter("alpha")
        'clsgeom_vline.AddAesParameter("colour")
        'clsgeom_vline.AddAesParameter("linetype")
        'clsgeom_vline.AddAesParameter("size")
        ''TO DO  include those that control position
        ''add layer parameter
        'clsgeom_vline.AddLayerParameter("xintercept", "numeric", "0")
        'lstAllGeoms.Add(clsgeom_vline)
    End Sub
    Public Event GeomChanged(sender As Object, e As EventArgs)
    Private Sub cboGeomList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGeomList.SelectedIndexChanged
        clsCurrGeom = lstAllGeoms(cboGeomList.SelectedIndex)
        clsGeomFunction.SetRCommand(clsCurrGeom.strGeomName)
        RaiseEvent GeomChanged(sender, e)
    End Sub
End Class
