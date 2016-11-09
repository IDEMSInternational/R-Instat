
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

        'Global comments:
        'Warning: cannot use default values like NULL in the specification of our aesthetics as parameters (fill, colour, ...) as running a command like "ggplot(survey, aes(x="",y=Yield)) + geom_boxplot(colour = NULL)" will give an error (Error: Aesthetics must be either length 1 or the same as the data (4): colour). 
        '           however, NULL is still valid as parameter value for outlier.colour for example ( ggplot(survey, aes(x="",y=Yield)) + geom_boxplot(outlier.colour = NULL) runs ok).
        'Warning: Concerning the global parameter position: 
        '           We haven't implemented position_jitterdodge yet. It is seems to be mainly usefull in presence of a dodged layer, on top of which we want to display the points of the events (see explanation http://docs.ggplot2.org/current/position_jitterdodge.html). However it doesn't seem to work as the others when specified as position = "jitterdodge" (get errors). Works fine when specified by position = position_jitterdodge(), for geoms such as point, but also bar (and produces outputs that are not completely silly), ...
        '           Could add the possiility to adjust the height and width parameters in the position function position_jitter, also width for dodge... Sometimes useful to only jitter in one direction for example... Then need to specify position as -position=position_jitter([parameters])- instead of -position = "jitter". This is also required for position_jitterdodge (see below). Seems necessary to specify x and y parameters in position_nudge as well in order to obtain any result (see below).
        '           Another option that is not yet available is position_nudge, which makes it possible to move a whole layer by a given (x,y) value. It doesn't seem to do anything by default i.e. when not specifying any argument (position = "nudge" or position = position_nudge()), just uses (x=0,y=0). When x or y is assigned to a factor, each factor corresponds to one unit along the axis (e.g. if x is a factor, position_nudge(x=2) would shift the layer by two factors along the x axis). While testing what happens when x = "" in boxplot case, a weird error was identified: "y aesthetics required", even when both x and y aesthetics are in use.
        '           Dodge requires a factor to dodge by, if none, just doesn't dodge. However, gives a warning in the geom_point case for instance.
        ''Warning: About the show.legend layer parameter, the default value in R is NA, which only shows legend for that layer if aesthetics are mapped.


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
        'Mandatory Aesthetics
        clsgeom_bar.AddAesParameter("x", bIsMandatory:=True)
        'All datatypes work as x aesthetics although the most common one is factor.
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
        'Warning: Also varies the outline of the bars, hence difficult to see if fill and colour take the same values. 
        'Warning: Finally it Is Not advised To use size For discrete variables (R message), however, continuous variables mapped to size when the stat is "count" are ignored (no changes in the graph).

        'Geom_Bar layer parameters
        clsgeom_bar.AddLayerParameter("width", "numeric", "0.90", lstParameterStrings:={2, 0, 1}) 'The width of the bars is given as a proportion of the data resolution.
        'Global Layer parameters
        clsgeom_bar.AddLayerParameter("stat", "list", Chr(34) & "count" & Chr(34), lstParameterStrings:={Chr(34) & "count" & Chr(34), Chr(34) & "identity" & Chr(34)})
        clsgeom_bar.AddLayerParameter("show.legend", "boolean", "TRUE")
        clsgeom_bar.AddLayerParameter("position", "list", Chr(34) & "stack" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})
        'See global comments about position.
        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_bar.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34))
        clsgeom_bar.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_bar.AddLayerParameter("linetype", "numeric", "1", lstParameterStrings:={0, 0, 6})
        clsgeom_bar.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1}) 'Note: alpha only acts on the fill for bars. The outline is not getting transparent.

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
        'Mandatory Aesthetics
        clsgeom_boxplot.AddAesParameter("y", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        'Optional Aesthetics
        clsgeom_boxplot.AddAesParameter("x")
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
        clsgeom_boxplot.AddLayerParameter("notch", "boolean", "TRUE") 'Note: notch = False + notchwidth = 0.7 works fine (i.e. can specify nothwidth with no notch)
        clsgeom_boxplot.AddLayerParameter("notchwidth", "numeric", "0.5", lstParameterStrings:={1}) 'Question to be discussed: this sets the width of the notch as a proportion of the boxplot width. Values can be anything in ggplot but negative ones just give a silly looking thing (I ve left it in for now, but would suggest we exclude ?), and I don't know if values above 1 make sense ? The notch would then be larger than the boxplot.
        clsgeom_boxplot.AddLayerParameter("varwidth", "boolean", "TRUE")
        clsgeom_boxplot.AddLayerParameter("coef", "numeric", "1.5", lstParameterStrings:={1}) 'Question to be discussed: This parameter is setting the length of the whiskers as a multiple of the IQR. When giving a negative value, the whiskers are simply of length 0. Also the window showing the graph doesn't adapt to the whiskers' length, which means they are simply cut when too long.
        clsgeom_boxplot.AddLayerParameter("outlier.shape", "numeric", "19", lstParameterStrings:={0, 0, 25}) 'Warning: there are other symbols that we can add here 
        clsgeom_boxplot.AddLayerParameter("outlier.colour", "colour", "NULL")
        clsgeom_boxplot.AddLayerParameter("outlier.stroke", "numeric", "0.5", lstParameterStrings:={1, 0}) 'Outlier.stroke parameter gives the size of the outliers. It cannot be negative, this would trigger an error in R.

        'Global Layer parameters
        clsgeom_boxplot.AddLayerParameter("show.legend", "boolean", "TRUE")
        'Warning: when x is continuous, position_dodge requires non-overlapping x intervals (would still work if not respected but sends a warning message).
        clsgeom_boxplot.AddLayerParameter("position", "list", Chr(34) & "dodge" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "fill" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "identity" & Chr(34)})
        'clsgeom_boxplot.AddLayerParameter("stat", "list", Chr(34) & "boxplot" & Chr(34), lstParameterStrings:={Chr(34) & "boxplot" & Chr(34), Chr(34) & "identity" & Chr(34)})
        'The stat is usually not changed in boxplot as it comes together with stat_boxplot. However identity can be taken as value for instance, but then all the aesthetics ymin, ymax, ... need to be filled.

        'Aesthetics as layer parameters... Used fo fix colour, transparence, ... of the geom on that Layer.
        clsgeom_boxplot.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34))
        clsgeom_boxplot.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_boxplot.AddLayerParameter("linetype", "numeric", "1", lstParameterStrings:={0, 0, 6})
        clsgeom_boxplot.AddLayerParameter("alpha", "numeric", "1", lstParameterStrings:={2, 0, 1})

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
        clsgeom_density.AddLayerParameter("show.legend", "boolean", "TRUE")
        clsgeom_density.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34), lstParameterStrings:={Chr(34) & "identity" & Chr(34), Chr(34) & "fill" & Chr(34), Chr(34) & "stack" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "dodge" & Chr(34)})
        'Warning: "Stacked density plots: if you want to create a stacked density plot, you probably want To 'count' (density * n) variable instead of the default density."
        'Question to be discussed: when changing parameter position to stack, should automatically add x="..count.." in the aesthetics parameters ? Carefull to not copy count into variable receivers, add methods like for "" in the boxplt case.
        'See global comments about position.

        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_density.AddLayerParameter("fill", "colour", Chr(34) & "white" & Chr(34))
        clsgeom_density.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_density.AddLayerParameter("linetype", "numeric", "1", lstParameterStrings:={0, 0, 6})
        clsgeom_density.AddLayerParameter("alpha", "numeric", "0", lstParameterStrings:={2, 0, 1}) 'Varies transparence of fill.

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

        'Aesthetics parameters
        clsgeom_dotplot.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"}) 'x is partially mandatory, need to be given value "" when not filled.
        clsgeom_dotplot.AddAesParameter("y", strIncludedDataTypes:={"numeric", "factor"})
        'When the binaxis is y, then if x is a factor or character, several dotplots lines are displayed according to each group along the x axis. 
        'When the binaxis is x, and y is a factor or character, dot stacks are split according to the y mapping, but not aligned with the labels along the y axis. So all stacks stay at the bottom. Also this is visible only if stackratio < 1, and stackgroups = FALSE.
        'However, when y/x is continuous, the axis label is changed but that's all the mapping does. Still the number of dots represent the number of stacked dots represent the number of events in each bin.
        'Task: Try character, ...

        clsgeom_dotplot.AddAesParameter("alpha", strIncludedDataTypes:={"factor", "numeric"}) 'Warning: varies transparence of both the fill and the outline.
        clsgeom_dotplot.AddAesParameter("colour", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_dotplot.AddAesParameter("fill", strIncludedDataTypes:={"factor", "numeric"})

        'Adding layer parameters
        'Geom_dotplot layer parameters
        'Warning: when a parameter is irrelevant (e.g. mentioning 'width' when 'binaxis' is "x" or 'right' when 'method' is "dotdensity"), this parameter is simply ignored...

        clsgeom_dotplot.AddLayerParameter("method", "list", Chr(34) & "dotdensity" & Chr(34), lstParameterStrings:={Chr(34) & "dotdensity" & Chr(34), Chr(34) & "histodot" & Chr(34)}) 'For when the binaxis is continuous, "dotdensity" (default) for dot-density binning, or "histodot" for fixed bin widths (like stat_bin)
        clsgeom_dotplot.AddLayerParameter("binwidth", "numeric", "1", lstParameterStrings:={2}) 'When method is "dotdensity", this specifies maximum bin width. When method is "histodot", this specifies bin width. Defaults to 1/30 of the range of the data
        'Warning: here default has been set to 1 as calculating 1/30 of the range of the data is not possible. 
        clsgeom_dotplot.AddLayerParameter("binaxis", "list", Chr(34) & "x" & Chr(34), lstParameterStrings:={Chr(34) & "x" & Chr(34), Chr(34) & "y" & Chr(34)}) 'The axis to bin along
        clsgeom_dotplot.AddLayerParameter("binpositions", "list", Chr(34) & "bygroup" & Chr(34), lstParameterStrings:={Chr(34) & "bygroup" & Chr(34), Chr(34) & "all" & Chr(34)}) 'When method is "dotdensity", "bygroup" (default) determines positions of the bins for each group separately. "all" determines positions of the bins with all the data taken together; this is used for aligning dot stacks across multiple groups.
        clsgeom_dotplot.AddLayerParameter("stackdir", "list", Chr(34) & "up" & Chr(34), lstParameterStrings:={Chr(34) & "up" & Chr(34), Chr(34) & "down" & Chr(34), Chr(34) & "center" & Chr(34), Chr(34) & "centerwhole" & Chr(34)}) 'which direction to stack the dots. "centerwhole" (centered, but with dots aligned)
        clsgeom_dotplot.AddLayerParameter("stackratio", "numeric", "1", lstParameterStrings:={1}) 'how close to stack the dots. Default is 1, where dots just just touch. Use smaller values for closer, overlapping dots. Negative values sort of revert the direction of stacking.
        clsgeom_dotplot.AddLayerParameter("dotsize", "numeric", "1", lstParameterStrings:={1}) 'The diameter of the dots relative to binwidth, default 1
        'Warning: negative values seem to result in having the dots stacking downwards. However the window on the graph does not adapt... No errors
        clsgeom_dotplot.AddLayerParameter("stackgroups", "Boolean", "FALSE") 'should dots be stacked across groups? This has the effect that position = "stack" should have, but can't (because this geom has some odd properties)
        clsgeom_dotplot.AddLayerParameter("origin", "numeric", "0", lstParameterStrings:={1}) 'When method is "histodot", origin of first bin, and moves all subsequent bins accordingly (shift)
        clsgeom_dotplot.AddLayerParameter("right", "Boolean", "TRUE") 'When method is "histodot", should intervals be closed on the right (a, b], or not [a, b)
        clsgeom_dotplot.AddLayerParameter("width", "numeric", "0.9", lstParameterStrings:={1, 0}) 'When binaxis is "y", the spacing of the dot stacks for dodging. 
        'Warning: didn't manage to get any visible changes on the graph.
        clsgeom_dotplot.AddLayerParameter("drop", "Boolean", "FALSE") 'If TRUE, remove all bins with zero counts
        'Warning/question: as bins with zero counts have zero dots, what is meant by remove ? Can't see any difference on the graphs when changing drop.
        'Global Layer parameters
        'Warning: stat is not a parameter of geom_dotplot. Anyway the stat that is used is "bindot".
        clsgeom_bar.AddLayerParameter("show.legend", "boolean", "TRUE")
        clsgeom_bar.AddLayerParameter("position", "list", Chr(34) & "stack" & Chr(34), lstParameterStrings:={Chr(34) & "stack" & Chr(34), Chr(34) & "dodge" & Chr(34), Chr(34) & "identity" & Chr(34), Chr(34) & "jitter" & Chr(34), Chr(34) & "fill" & Chr(34)})

        'Aesthetics as layer parameters... Used to fix colour, transparence, ... of the geom on that Layer.
        clsgeom_density.AddLayerParameter("fill", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_dotplot.AddLayerParameter("colour", "colour", Chr(34) & "black" & Chr(34))
        clsgeom_dotplot.AddLayerParameter("alpha", "numeric", "0", lstParameterStrings:={2, 0, 1}) 'Warning: varies transparence of fill AND outline.

        lstAllGeoms.Add(clsgeom_dotplot)


        'clsgeom_errorbar.strGeomName = "geom_errorbar"
        'Mandatory
        'clsgeom_errorbar.AddAesParameter("x", bIsMandatory:=True)
        'clsgeom_errorbar.AddAesParameter("ymax", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        'clsgeom_errorbar.AddAesParameter("ymin", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        'Optional
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
        'clsgeom_errorbarh.AddLayerParameter("stat", "list", Chr(34) & "identity" & Chr(34))
        'clsgeom_errorbarh.AddLayerParameter("position", "list", Chr(34) & "identity" & Chr(34))
        'lstAllGeoms.Add(clsgeom_errorbarh)

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
        'x and y are mandatory, but these are autofilled by "" when no variable is mapped. "Partially mandatory"
        clsgeom_line.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_line.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"})
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
        'Mandatory aesthetics : here x and y are mandatory, however, when not filled, default values "" are given. Alternatively, if we want to have at least on filled, could add bIsDependentlyMandatory:=True in both. Planning on refining the mandatory aes methods to include the "" cases systematically.
        clsgeom_point.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"})
        clsgeom_point.AddAesParameter("y", strIncludedDataTypes:={"factor", "numeric"})
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
        'optional
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
        'mandatory
        ''clsgeom_smooth.AddAesParameter("x", bIsMandatory:=True)
        ''clsgeom_smooth.AddAesParameter("y", bIsMandatory:=True)
        'optional 
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
