﻿
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
    Public strAesParameterName As String
    Public strAesParameterValue As String
    Public lstAllGeoms As New List(Of Geoms)
    Public lstGgParameters As New List(Of RParameter)
    Public clsGeomFunction As New RFunction
    Public clsCurrGeom As New Geoms
    Public lstFunctionParameters As New List(Of RParameter)
    Private bFirstLoad As Boolean = True
    Public clsRaesFunction As New RFunction
    Private Sub UcrGeoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            CreateGeomList()
            SetGeoms()
            bFirstLoad = False
        End If
    End Sub
    Private Sub InitialiseControl()
        clsRaesFunction.SetRCommand("aes")
        clsGeomFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
    End Sub

    Public Sub SetGeoms()
        Dim GeomCount As New Geoms
        cboGeomList.Items.Clear()
        For Each GeomCount In lstAllGeoms
            cboGeomList.Items.Add(GeomCount.strGeomName)
        Next
        cboGeomList.SelectedIndex = 0
    End Sub

    Public Sub SetFuncSync(clsGeomFunc As RFunction)
        clsGeomFunction = clsGeomFunc
    End Sub

    Public Sub AddParameter(strAesParameterName As String, strAesParameterValue As String)
        'this adds parameters TODO pass appropriate parameters.
        Dim i As Integer
        Dim clsParam As New RParameter
        i = lstFunctionParameters.FindIndex(Function(x) x.strArgumentName.Equals(Me.strAesParameterName))
        If i = -1 Then
            clsParam.SetArgumentName(Me.strAesParameterName)
            clsParam.SetArgumentValue(Me.strAesParameterValue)
            lstFunctionParameters.Add(clsParam)
        Else
            lstFunctionParameters(i).strArgumentValue = Me.strAesParameterValue
        End If
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


        clsgeom_abline.strGeomName = "geom_abline"
        clsgeom_abline.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_abline.AddAesParameter("y", bIsMandatory:=True)
        clsgeom_abline.AddAesParameter("alpha")
        clsgeom_abline.AddAesParameter("colour")
        clsgeom_abline.AddAesParameter("linetype")
        clsgeom_abline.AddAesParameter("size")
        'aesthetics that control position of line include
        'geom_vline:xintercept
        'geom_hline:yintercept
        'geom_abline: slope and intercept
        'TO DO Discuss how to use these
        lstAllGeoms.Add(clsgeom_abline)

        clsgeom_area.strGeomName = "geom_area"
        'mandatory aesthetics 
        clsgeom_area.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_area.AddAesParameter("ymax", bIsMandatory:=True)
        clsgeom_area.AddAesParameter("ymin", bIsMandatory:=True)
        'Optional 
        clsgeom_area.AddAesParameter("alpha")
        clsgeom_area.AddAesParameter("colour")
        clsgeom_area.AddAesParameter("fill")
        clsgeom_area.AddAesParameter("linetype")
        clsgeom_area.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_area)

        clsgeom_bar.strGeomName = "geom_bar"
        clsgeom_bar.AddAesParameter("x", bIsMandatory:=True)
        'Optional
        clsgeom_bar.AddAesParameter("alpha")
        clsgeom_bar.AddAesParameter("fill")
        clsgeom_bar.AddAesParameter("colour")
        clsgeom_bar.AddAesParameter("linetype")
        clsgeom_bar.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_bar)

        clsgeom_bin2d.strGeomName = "geom_bin2d"
        'mandatory
        clsgeom_bin2d.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_bin2d.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_bin2d.AddAesParameter("fill")
        lstAllGeoms.Add(clsgeom_bin2d)

        clsgeom_boxplot.strGeomName = "geom_boxplot"
        clsgeom_boxplot.AddAesParameter("x", strIncludedDataTypes:={"factor", "numeric"}, bIsMandatory:=True)
        clsgeom_boxplot.AddAesParameter("y", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_boxplot.AddAesParameter("fill", bIsMandatory:=True, strIncludedDataTypes:={"factor"})
        clsgeom_boxplot.AddAesParameter("colour",, strIncludedDataTypes:={"factor"})
        clsgeom_boxplot.AddAesParameter("linetype", strIncludedDataTypes:={"factor"})
        clsgeom_boxplot.AddAesParameter("size", strIncludedDataTypes:={"factor"})
        clsgeom_boxplot.AddAesParameter("weight", strIncludedDataTypes:={"numeric"})
        clsgeom_boxplot.AddAesParameter("group", strIncludedDataTypes:={"factor"})

        'adding layerParameters
        clsgeom_boxplot.AddLayerParameter("notch", "boolean", "TRUE")
        lstAllGeoms.Add(clsgeom_boxplot)

        clsgeom_contour.strGeomName = "geom_contour"
        'Mandatory
        clsgeom_contour.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_contour.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_contour.AddAesParameter("alpha")
        clsgeom_contour.AddAesParameter("colour")
        clsgeom_contour.AddAesParameter("linetype")
        clsgeom_contour.AddAesParameter("size")
        clsgeom_contour.AddAesParameter("weight")
        lstAllGeoms.Add(clsgeom_contour)

        clsgeom_count.strGeomName = "geom_count"
        'mandatory
        clsgeom_count.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_count.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_count.AddAesParameter("alpha")
        clsgeom_count.AddAesParameter("colour")
        clsgeom_count.AddAesParameter("fill")
        clsgeom_count.AddAesParameter("shape")
        clsgeom_count.AddAesParameter("size")
        clsgeom_count.AddAesParameter("stroke")
        lstAllGeoms.Add(clsgeom_count)

        clsgeom_crossbar.strGeomName = "geom_crossbar"
        'Mandatory
        clsgeom_crossbar.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_crossbar.AddAesParameter("ymax", bIsMandatory:=True)
        clsgeom_crossbar.AddAesParameter("ymin", bIsMandatory:=True)
        'Optional
        clsgeom_crossbar.AddAesParameter("alpha")
        clsgeom_crossbar.AddAesParameter("colour")
        clsgeom_crossbar.AddAesParameter("linetype")
        clsgeom_crossbar.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_crossbar)

        clsgeom_curve.strGeomName = "geom_curve"
        'Mandatory
        clsgeom_curve.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_curve.AddAesParameter("xend", bIsMandatory:=True)
        clsgeom_curve.AddAesParameter("y", bIsMandatory:=True)
        clsgeom_curve.AddAesParameter("yend", bIsMandatory:=True)
        ''Optional
        clsgeom_curve.AddAesParameter("alpha")
        clsgeom_curve.AddAesParameter("colour")
        clsgeom_curve.AddAesParameter("linetype")
        clsgeom_curve.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_curve)

        clsgeom_density.strGeomName = "geom_density"
        'mandatory
        clsgeom_density.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_density.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_density.AddAesParameter("alpha")
        clsgeom_density.AddAesParameter("colour")
        clsgeom_density.AddAesParameter("fill", strIncludedDataTypes:={"factor"})
        clsgeom_density.AddAesParameter("linetype")
        clsgeom_density.AddAesParameter("size")
        clsgeom_density.AddAesParameter("weight")
        lstAllGeoms.Add(clsgeom_density)

        clsgeom_density2d.strGeomName = "geom_density2d"
        'Mandatory
        clsgeom_density2d.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_density2d.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_density2d.AddAesParameter("alpha")
        clsgeom_density2d.AddAesParameter("colour")
        clsgeom_density2d.AddAesParameter("linetype")
        clsgeom_density2d.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_density2d)

        clsgeom_density_2d.strGeomName = "geom_density_2d"
        'Mandatory
        clsgeom_density_2d.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_density_2d.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_density_2d.AddAesParameter("alpha")
        clsgeom_density_2d.AddAesParameter("colour")
        clsgeom_density_2d.AddAesParameter("linetype")
        clsgeom_density_2d.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_density_2d)

        clsgeom_dotplot.strGeomName = "geom_dotplot"
        clsgeom_dotplot.AddAesParameter("x", strIncludedDataTypes:={"factor"}, bIsMandatory:=True)
        clsgeom_dotplot.AddAesParameter("y", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        'Optional
        clsgeom_dotplot.AddAesParameter("alpha")
        clsgeom_dotplot.AddAesParameter("colour")
        clsgeom_dotplot.AddAesParameter("fill", strIncludedDataTypes:={"factor"})
        lstAllGeoms.Add(clsgeom_dotplot)


        clsgeom_errorbar.strGeomName = "geom_errorbar"
        'Mandatory
        clsgeom_errorbar.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_errorbar.AddAesParameter("ymax", bIsMandatory:=True)
        clsgeom_errorbar.AddAesParameter("ymin", bIsMandatory:=True)
        'Optional
        clsgeom_errorbar.AddAesParameter("alpha")
        clsgeom_errorbar.AddAesParameter("volour")
        clsgeom_errorbar.AddAesParameter("linetype")
        clsgeom_errorbar.AddAesParameter("size")
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
        lstAllGeoms.Add(clsgeom_errorbarh)

        clsgeom_freqpoly.strGeomName = "geom_freqpoly"
        clsgeom_freqpoly.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_freqpoly.AddAesParameter("alpha")
        clsgeom_freqpoly.AddAesParameter("colour")
        clsgeom_freqpoly.AddAesParameter("fill", strIncludedDataTypes:={"factor"}, bIsMandatory:=True)
        clsgeom_freqpoly.AddAesParameter("linetype")
        clsgeom_freqpoly.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_freqpoly)

        clsgeom_hex.strGeomName = "geom_hex"
        'mandatory
        clsgeom_hex.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_hex.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_hex.AddAesParameter("alpha")
        clsgeom_hex.AddAesParameter("colour")
        clsgeom_hex.AddAesParameter("fill")
        clsgeom_hex.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_hex)

        clsgeom_histogram.strGeomName = "geom_histogram"
        clsgeom_histogram.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_histogram.AddAesParameter("alpha")
        clsgeom_histogram.AddAesParameter("colour")
        clsgeom_histogram.AddAesParameter("fill", strIncludedDataTypes:={"factor"}, bIsMandatory:=True)
        clsgeom_histogram.AddAesParameter("linetype")
        clsgeom_histogram.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_histogram)


        clsgeom_hline.strGeomName = "geom_hline"
        clsgeom_hline.AddAesParameter("alpha")
        clsgeom_hline.AddAesParameter("colour")
        clsgeom_hline.AddAesParameter("linetype")
        clsgeom_hline.AddAesParameter("size")
        'aesthetics that control position of line include
        'geom_vline:xintercept
        'geom_hline:yintercept
        'geom_abline: slope and intercept
        'TO DO Discuss how to use these
        lstAllGeoms.Add(clsgeom_hline)

        clsgeom_jitter.strGeomName = "geom_jitter"
        'mandatory
        clsgeom_jitter.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_jitter.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_jitter.AddAesParameter("alpha")
        clsgeom_jitter.AddAesParameter("colour")
        clsgeom_jitter.AddAesParameter("fill")
        clsgeom_jitter.AddAesParameter("shape")
        clsgeom_jitter.AddAesParameter("size")
        clsgeom_jitter.AddAesParameter("stroke")
        lstAllGeoms.Add(clsgeom_jitter)

        clsgeom_label.strGeomName = "geom_label"
        'mandatory
        clsgeom_label.AddAesParameter("label", bIsMandatory:=True)
        clsgeom_label.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_label.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_label.AddAesParameter("alpha")
        clsgeom_label.AddAesParameter("colour")
        clsgeom_label.AddAesParameter("family")
        clsgeom_label.AddAesParameter("fontface")
        clsgeom_label.AddAesParameter("hjust")
        clsgeom_label.AddAesParameter("lineheight")
        'TO DO add size and vjust this might need additon of labels and receivers  
        lstAllGeoms.Add(clsgeom_label)


        clsgeom_line.strGeomName = "geom_line"
        'mandatory
        clsgeom_line.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_line.AddAesParameter("y", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        'optional
        clsgeom_line.AddAesParameter("alpha")
        clsgeom_line.AddAesParameter("colour")
        clsgeom_line.AddAesParameter("linetype")
        clsgeom_line.AddAesParameter("size")
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
        lstAllGeoms.Add(clsgeom_linerange)

        clsgeom_map.strGeomName = "geom_map"
        'mandatory
        clsgeom_map.AddAesParameter("map_id", bIsMandatory:=True)
        'optional
        clsgeom_map.AddAesParameter("alpha")
        clsgeom_map.AddAesParameter("colour")
        clsgeom_map.AddAesParameter("fill")
        clsgeom_map.AddAesParameter("linetype")
        clsgeom_map.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_map)

        clsgeom_path.strGeomName = "geom_path"
        'mandatory
        clsgeom_path.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_path.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_path.AddAesParameter("alpha")
        clsgeom_path.AddAesParameter("colour")
        clsgeom_path.AddAesParameter("linetype")
        clsgeom_path.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_path)

        clsgeom_point.strGeomName = "geom_point"
        'mandatory
        clsgeom_point.AddAesParameter("x", strIncludedDataTypes:={"numeric"}, bIsMandatory:=True)
        clsgeom_point.AddAesParameter("y", strIncludedDataTypes:={"factor"}, bIsMandatory:=True)
        'optional
        clsgeom_point.AddAesParameter("alpha")
        clsgeom_point.AddAesParameter("colour")
        clsgeom_point.AddAesParameter("fill")
        clsgeom_point.AddAesParameter("shape")
        clsgeom_point.AddAesParameter("size")
        clsgeom_point.AddAesParameter("stroke")
        lstAllGeoms.Add(clsgeom_point)

        clsgeom_pointrange.strGeomName = "geom_pointrange"
        clsgeom_pointrange.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_pointrange.AddAesParameter("ymax", bIsMandatory:=True)
        clsgeom_pointrange.AddAesParameter("ymin", bIsMandatory:=True)
        'optional
        clsgeom_pointrange.AddAesParameter("alpha")
        clsgeom_pointrange.AddAesParameter("colour")
        clsgeom_pointrange.AddAesParameter("linetype")
        clsgeom_pointrange.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_pointrange)

        clsgeom_polygon.strGeomName = "geom_polygon"
        clsgeom_polygon.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_polygon.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_polygon.AddAesParameter("alpha")
        clsgeom_polygon.AddAesParameter("colour")
        clsgeom_polygon.AddAesParameter("fill")
        clsgeom_polygon.AddAesParameter("linetype")
        clsgeom_polygon.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_polygon)

        clsgeom_qq.strGeomName = "geom_qq"
        clsgeom_qq.AddAesParameter("sample", bIsMandatory:=True)
        'optional
        clsgeom_qq.AddAesParameter("x")
        clsgeom_qq.AddAesParameter("y")
        lstAllGeoms.Add(clsgeom_qq)

        clsgeom_quantile.strGeomName = "geom_quantile"
        clsgeom_quantile.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_quantile.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_quantile.AddAesParameter("alpha")
        clsgeom_quantile.AddAesParameter("colour")
        clsgeom_quantile.AddAesParameter("linetype")
        clsgeom_quantile.AddAesParameter("size")
        clsgeom_quantile.AddAesParameter("weight")
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
        lstAllGeoms.Add(clsgeom_raster)

        clsgeom_rect.strGeomName = "geom_rect"
        'mandatory
        clsgeom_rect.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_rect.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_rect.AddAesParameter("alpha")
        clsgeom_rect.AddAesParameter("colour")
        clsgeom_rect.AddAesParameter("fill")
        clsgeom_rect.AddAesParameter("linetype")
        clsgeom_rect.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_rect)

        clsgeom_ribbon.strGeomName = "geom_ribbon"
        clsgeom_ribbon.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_ribbon.AddAesParameter("ymax", bIsMandatory:=True)
        clsgeom_ribbon.AddAesParameter("ymin", bIsMandatory:=True)
        'optional
        clsgeom_ribbon.AddAesParameter("alpha")
        clsgeom_ribbon.AddAesParameter("colour")
        clsgeom_ribbon.AddAesParameter("linetype")
        clsgeom_ribbon.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_ribbon)

        clsgeom_rug.strGeomName = "geom_rug"
        clsgeom_rug.AddAesParameter("alpha")
        clsgeom_rug.AddAesParameter("colour")
        clsgeom_rug.AddAesParameter("linetype")
        clsgeom_rug.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_rug)

        clsgeom_segment.strGeomName = "geom_segment"
        'mandatory
        clsgeom_segment.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_segment.AddAesParameter("xend", bIsMandatory:=True)
        clsgeom_segment.AddAesParameter("y", bIsMandatory:=True)
        clsgeom_segment.AddAesParameter("yend", bIsMandatory:=True)
        'optional
        clsgeom_segment.AddAesParameter("alpha")
        clsgeom_segment.AddAesParameter("colour")
        clsgeom_segment.AddAesParameter("linetype")
        clsgeom_segment.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_segment)

        clsgeom_smooth.strGeomName = "geom_smooth"
        'mandatory
        clsgeom_smooth.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_smooth.AddAesParameter("y", bIsMandatory:=True)
        'optional 
        clsgeom_smooth.AddAesParameter("alpha")
        clsgeom_smooth.AddAesParameter("colour")
        clsgeom_smooth.AddAesParameter("fill")
        clsgeom_smooth.AddAesParameter("linetype")
        clsgeom_smooth.AddAesParameter("size")
        clsgeom_smooth.AddAesParameter("weight")
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
        lstAllGeoms.Add(clsgeom_spoke)

        clsgeom_step.strGeomName = "geom_step"
        clsgeom_step.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_step.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_step.AddAesParameter("alpha")
        clsgeom_step.AddAesParameter("colour")
        clsgeom_step.AddAesParameter("linetype")
        clsgeom_step.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_step)

        clsgeom_text.strGeomName = "geom_text"
        'mandatory
        clsgeom_text.AddAesParameter("label", bIsMandatory:=True)
        clsgeom_text.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_text.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_text.AddAesParameter("alpha")
        clsgeom_text.AddAesParameter("colour")
        clsgeom_text.AddAesParameter("family")
        clsgeom_text.AddAesParameter("fontface")
        clsgeom_text.AddAesParameter("hjust")
        clsgeom_text.AddAesParameter("lineheight")
        'TO DO add size and vjust this might need additon of labels and receivers  
        lstAllGeoms.Add(clsgeom_text)

        clsgeom_tile.strGeomName = "geom_tile"
        'mandatory
        clsgeom_tile.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_tile.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_tile.AddAesParameter("alpha")
        clsgeom_tile.AddAesParameter("colour")
        clsgeom_tile.AddAesParameter("fill")
        clsgeom_tile.AddAesParameter("linetype")
        clsgeom_tile.AddAesParameter("size")
        lstAllGeoms.Add(clsgeom_tile)

        clsgeom_violin.strGeomName = "geom_violin"
        'mandatory
        clsgeom_violin.AddAesParameter("x", bIsMandatory:=True)
        clsgeom_violin.AddAesParameter("y", bIsMandatory:=True)
        'optional
        clsgeom_violin.AddAesParameter("alpha")
        clsgeom_violin.AddAesParameter("colour")
        clsgeom_violin.AddAesParameter("fill")
        clsgeom_violin.AddAesParameter("linetype")
        clsgeom_violin.AddAesParameter("size")
        clsgeom_violin.AddAesParameter("weight")
        lstAllGeoms.Add(clsgeom_violin)

        clsgeom_vline.strGeomName = "geom_vline"
        clsgeom_vline.AddAesParameter("alpha")
        clsgeom_vline.AddAesParameter("colour")
        clsgeom_vline.AddAesParameter("linetype")
        clsgeom_vline.AddAesParameter("size")
        'TO DO  include those that control position
        lstAllGeoms.Add(clsgeom_vline)
    End Sub
    Public Event GeomChanged(sender As Object, e As EventArgs)
    Private Sub cboGeomList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGeomList.SelectedIndexChanged
        clsCurrGeom = lstAllGeoms(cboGeomList.SelectedIndex)
        clsGeomFunction.SetRCommand(clsCurrGeom.strGeomName)
        RaiseEvent GeomChanged(sender, e)
    End Sub
End Class
