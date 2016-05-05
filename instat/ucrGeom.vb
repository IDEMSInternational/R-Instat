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
    Public strGgParameterName As String
    Public strGgParameterValue As String
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

    Public Sub AddParameter(strGgParameterName As String, strGgParameterValue As String)
        'this adds parameters TODO pass appropriate parameters.
        Dim i As Integer
        Dim clsParam As New RParameter
        i = lstFunctionParameters.FindIndex(Function(x) x.strArgumentName.Equals(Me.strGgParameterName))
        If i = -1 Then
            clsParam.SetArgumentName(Me.strGgParameterName)
            clsParam.SetArgumentValue(Me.strGgParameterValue)
            lstFunctionParameters.Add(clsParam)
        Else
            lstFunctionParameters(i).strArgumentValue = Me.strGgParameterValue
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
        clsgeom_abline.AddGgParameter("alpha")
        clsgeom_abline.AddGgParameter("colour")
        clsgeom_abline.AddGgParameter("linetype")
        clsgeom_abline.AddGgParameter("size")
        'aesthetics that control position of line include
        'geom_vline:xintercept
        'geom_hline:yintercept
        'geom_abline: slope and intercept
        'TO DO Discuss how to use these
        lstAllGeoms.Add(clsgeom_abline)

        clsgeom_area.strGeomName = "geom_area"
        'mandatory aesthetics 
        clsgeom_area.AddGgParameter("x")
        clsgeom_area.AddGgParameter("ymax")
        clsgeom_area.AddGgParameter("ymin")
        'Optional 
        clsgeom_area.AddGgParameter("alpha")
        clsgeom_area.AddGgParameter("colour")
        clsgeom_area.AddGgParameter("fill")
        clsgeom_area.AddGgParameter("linetype")
        clsgeom_area.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_area)

        clsgeom_bar.strGeomName = "geom_bar"
        clsgeom_bar.AddGgParameter("x")
        clsgeom_bar.AddGgParameter("alpha")
        clsgeom_bar.AddGgParameter("fill")
        clsgeom_bar.AddGgParameter("colour")
        clsgeom_bar.AddGgParameter("linetype")
        clsgeom_bar.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_bar)

        clsgeom_bin2d.strGeomName = "geom_bin2d"
        'mandatory
        clsgeom_bin2d.AddGgParameter("x")
        clsgeom_bin2d.AddGgParameter("y")
        'optional
        clsgeom_bin2d.AddGgParameter("fill")
        lstAllGeoms.Add(clsgeom_bin2d)

        clsgeom_boxplot.strGeomName = "geom_boxplot"
        clsgeom_boxplot.AddGgParameter("x", strIncludedDataTypes:={"factor"})
        clsgeom_boxplot.AddGgParameter("y", strIncludedDataTypes:={"factor"})
        clsgeom_boxplot.AddGgParameter("fill")
        clsgeom_boxplot.AddGgParameter("colour")
        clsgeom_boxplot.AddGgParameter("shape")
        clsgeom_boxplot.AddGgParameter("lower")
        clsgeom_boxplot.AddGgParameter("middle")
        lstAllGeoms.Add(clsgeom_boxplot)

        clsgeom_contour.strGeomName = "geom_contour"
        'Mandatory
        clsgeom_contour.AddGgParameter("x")
        clsgeom_contour.AddGgParameter("y")
        'optional
        clsgeom_contour.AddGgParameter("alpha")
        clsgeom_contour.AddGgParameter("colour")
        clsgeom_contour.AddGgParameter("linetype")
        clsgeom_contour.AddGgParameter("size")
        clsgeom_contour.AddGgParameter("weight")
        lstAllGeoms.Add(clsgeom_contour)

        clsgeom_count.strGeomName = "geom_count"
        'mandatory
        clsgeom_count.AddGgParameter("x")
        clsgeom_count.AddGgParameter("y")
        'optional
        clsgeom_count.AddGgParameter("alpha")
        clsgeom_count.AddGgParameter("colour")
        clsgeom_count.AddGgParameter("fill")
        clsgeom_count.AddGgParameter("shape")
        clsgeom_count.AddGgParameter("size")
        clsgeom_count.AddGgParameter("stroke")
        lstAllGeoms.Add(clsgeom_count)

        clsgeom_crossbar.strGeomName = "geom_crossbar"
        clsgeom_crossbar.AddGgParameter("")
        clsgeom_crossbar.AddGgParameter("")
        clsgeom_crossbar.AddGgParameter("")
        clsgeom_crossbar.AddGgParameter("")
        clsgeom_crossbar.AddGgParameter("")
        clsgeom_crossbar.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_crossbar)

        clsgeom_curve.strGeomName = "geom_curve"
        clsgeom_curve.AddGgParameter("")
        clsgeom_curve.AddGgParameter("")
        clsgeom_curve.AddGgParameter("")
        clsgeom_curve.AddGgParameter("")
        clsgeom_curve.AddGgParameter("")
        clsgeom_curve.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_curve)

        clsgeom_density.strGeomName = "geom_density"
        'mandatory
        clsgeom_density.AddGgParameter("x")
        clsgeom_density.AddGgParameter("y")
        'optional
        clsgeom_density.AddGgParameter("alpha")
        clsgeom_density.AddGgParameter("colour")
        clsgeom_density.AddGgParameter("fill")
        clsgeom_density.AddGgParameter("linetype")
        clsgeom_density.AddGgParameter("size")
        clsgeom_density.AddGgParameter("weight")
        lstAllGeoms.Add(clsgeom_density)

        clsgeom_density2d.strGeomName = "geom_density2d"
        'Mandatory
        clsgeom_density2d.AddGgParameter("x")
        clsgeom_density2d.AddGgParameter("y")
        'optional
        clsgeom_density2d.AddGgParameter("alpha")
        clsgeom_density2d.AddGgParameter("colour")
        clsgeom_density2d.AddGgParameter("linetype")
        clsgeom_density2d.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_density2d)

        clsgeom_density_2d.strGeomName = "geom_density_2d"
        'Mandatory
        clsgeom_density_2d.AddGgParameter("x")
        clsgeom_density_2d.AddGgParameter("y")
        'optional
        clsgeom_density_2d.AddGgParameter("alpha")
        clsgeom_density_2d.AddGgParameter("colour")
        clsgeom_density_2d.AddGgParameter("linetype")
        clsgeom_density_2d.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_density_2d)

        clsgeom_dotplot.strGeomName = "geom_dotplot"
        clsgeom_dotplot.AddGgParameter("x")
        clsgeom_dotplot.AddGgParameter("y")
        clsgeom_dotplot.AddGgParameter("alpha")
        clsgeom_dotplot.AddGgParameter("colour")
        clsgeom_dotplot.AddGgParameter("fill")
        lstAllGeoms.Add(clsgeom_dotplot)


        clsgeom_errorbar.strGeomName = "geom_errorbar"
        clsgeom_errorbar.AddGgParameter("")
        clsgeom_errorbar.AddGgParameter("")
        clsgeom_errorbar.AddGgParameter("")
        clsgeom_errorbar.AddGgParameter("")
        clsgeom_errorbar.AddGgParameter("")
        clsgeom_errorbar.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_errorbar)

        clsgeom_errorbarh.strGeomName = "geom_errorbarh"
        'mandatory
        clsgeom_errorbarh.AddGgParameter("x")
        clsgeom_errorbarh.AddGgParameter("xmax")
        clsgeom_errorbarh.AddGgParameter("xmin")
        clsgeom_errorbarh.AddGgParameter("y")
        'optional
        clsgeom_errorbarh.AddGgParameter("alpha")
        clsgeom_errorbarh.AddGgParameter("colour")
        clsgeom_errorbarh.AddGgParameter("height")
        clsgeom_errorbarh.AddGgParameter("linetype")
        clsgeom_errorbarh.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_errorbarh)

        clsgeom_freqpoly.strGeomName = "geom_freqpoly"
        clsgeom_freqpoly.AddGgParameter("")
        clsgeom_freqpoly.AddGgParameter("")
        clsgeom_freqpoly.AddGgParameter("")
        clsgeom_freqpoly.AddGgParameter("")
        clsgeom_freqpoly.AddGgParameter("")
        clsgeom_freqpoly.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_freqpoly)


        clsgeom_hex.strGeomName = "geom_hex"
        'mandatory
        clsgeom_hex.AddGgParameter("x")
        clsgeom_hex.AddGgParameter("y")
        'optional
        clsgeom_hex.AddGgParameter("alpha")
        clsgeom_hex.AddGgParameter("colour")
        clsgeom_hex.AddGgParameter("fill")
        clsgeom_hex.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_hex)

        clsgeom_histogram.strGeomName = "geom_histogram"
        clsgeom_histogram.AddGgParameter("x")
        clsgeom_histogram.AddGgParameter("alpha")
        clsgeom_histogram.AddGgParameter("colour")
        clsgeom_histogram.AddGgParameter("fill")
        clsgeom_histogram.AddGgParameter("linetype")
        clsgeom_histogram.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_histogram)


        clsgeom_hline.strGeomName = "geom_hline"
        clsgeom_hline.AddGgParameter("alpha")
        clsgeom_hline.AddGgParameter("colour")
        clsgeom_hline.AddGgParameter("linetype")
        clsgeom_hline.AddGgParameter("size")
        'aesthetics that control position of line include
        'geom_vline:xintercept
        'geom_hline:yintercept
        'geom_abline: slope and intercept
        'TO DO Discuss how to use these

        lstAllGeoms.Add(clsgeom_hline)

        clsgeom_jitter.strGeomName = "geom_jitter"
        'mandatory
        clsgeom_jitter.AddGgParameter("x")
        clsgeom_jitter.AddGgParameter("y")
        'optional
        clsgeom_jitter.AddGgParameter("alpha")
        clsgeom_jitter.AddGgParameter("colour")
        clsgeom_jitter.AddGgParameter("fill")
        clsgeom_jitter.AddGgParameter("shape")
        clsgeom_jitter.AddGgParameter("size")
        clsgeom_jitter.AddGgParameter("stroke")
        lstAllGeoms.Add(clsgeom_jitter)

        clsgeom_label.strGeomName = "geom_label"
        'mandatory
        clsgeom_label.AddGgParameter("label")
        clsgeom_label.AddGgParameter("x")
        clsgeom_label.AddGgParameter("y")
        'optional
        clsgeom_label.AddGgParameter("alpha")
        clsgeom_label.AddGgParameter("color")
        clsgeom_label.AddGgParameter("family")
        clsgeom_label.AddGgParameter("fontface")
        clsgeom_label.AddGgParameter("hjust")
        clsgeom_label.AddGgParameter("lineheight")
        'TO DO add size and vjust this might need additon of labels and receivers  
        lstAllGeoms.Add(clsgeom_label)


        clsgeom_line.strGeomName = "geom_line"
        'mandatory
        clsgeom_line.AddGgParameter("x")
        clsgeom_line.AddGgParameter("y")
        'optional
        clsgeom_line.AddGgParameter("alpha")
        clsgeom_line.AddGgParameter("color")
        clsgeom_line.AddGgParameter("linetype")
        clsgeom_line.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_line)


        clsgeom_linerange.strGeomName = "geom_linerange"
        'mandatory
        clsgeom_linerange.AddGgParameter("x")
        clsgeom_linerange.AddGgParameter("ymax")
        clsgeom_linerange.AddGgParameter("ymin")
        'optional
        clsgeom_linerange.AddGgParameter("alpha")
        clsgeom_linerange.AddGgParameter("colour")
        clsgeom_linerange.AddGgParameter("linetype")
        clsgeom_linerange.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_linerange)

        clsgeom_map.strGeomName = "geom_map"
        'mandatory
        clsgeom_map.AddGgParameter("map_id")
        'optional
        clsgeom_map.AddGgParameter("alpha")
        clsgeom_map.AddGgParameter("colour")
        clsgeom_map.AddGgParameter("fill")
        clsgeom_map.AddGgParameter("linetype")
        clsgeom_map.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_map)

        clsgeom_path.strGeomName = "geom_path"
        'mandatory
        clsgeom_path.AddGgParameter("x")
        clsgeom_path.AddGgParameter("y")
        'optional
        clsgeom_path.AddGgParameter("alpha")
        clsgeom_path.AddGgParameter("colour")
        clsgeom_path.AddGgParameter("linetype")
        clsgeom_path.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_path)

        clsgeom_point.strGeomName = "geom_point"
        'mandatory
        clsgeom_point.AddGgParameter("x")
        clsgeom_point.AddGgParameter("y")
        'optional
        clsgeom_point.AddGgParameter("alpha")
        clsgeom_point.AddGgParameter("colour")
        clsgeom_point.AddGgParameter("fill")
        clsgeom_point.AddGgParameter("shape")
        clsgeom_point.AddGgParameter("size")
        clsgeom_point.AddGgParameter("stroke")
        lstAllGeoms.Add(clsgeom_point)

        clsgeom_pointrange.strGeomName = "geom_pointrange"
        clsgeom_pointrange.AddGgParameter("x")
        clsgeom_pointrange.AddGgParameter("ymax")
        clsgeom_pointrange.AddGgParameter("ymin")
        'optional
        clsgeom_pointrange.AddGgParameter("alpha")
        clsgeom_pointrange.AddGgParameter("colour")
        clsgeom_pointrange.AddGgParameter("linetype")
        clsgeom_pointrange.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_pointrange)

        clsgeom_polygon.strGeomName = "geom_polygon"
        clsgeom_polygon.AddGgParameter("x")
        clsgeom_polygon.AddGgParameter("y")
        'optional
        clsgeom_polygon.AddGgParameter("alpha")
        clsgeom_polygon.AddGgParameter("colour")
        clsgeom_polygon.AddGgParameter("fill")
        clsgeom_polygon.AddGgParameter("linetype")
        clsgeom_polygon.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_polygon)

        clsgeom_qq.strGeomName = "geom_qq"
        clsgeom_qq.AddGgParameter("sample")
        'optional
        clsgeom_qq.AddGgParameter("x")
        clsgeom_qq.AddGgParameter("y")
        lstAllGeoms.Add(clsgeom_qq)

        clsgeom_quantile.strGeomName = "geom_quantile"
        clsgeom_quantile.AddGgParameter("x")
        clsgeom_quantile.AddGgParameter("y")
        'optional
        clsgeom_quantile.AddGgParameter("alpha")
        clsgeom_quantile.AddGgParameter("colour")
        clsgeom_quantile.AddGgParameter("linetype")
        clsgeom_quantile.AddGgParameter("size")
        clsgeom_quantile.AddGgParameter("weight")
        lstAllGeoms.Add(clsgeom_quantile)

        clsgeom_raster.strGeomName = "geom_raster"
        'mandatory
        clsgeom_raster.AddGgParameter("x")
        clsgeom_raster.AddGgParameter("y")
        'optional
        clsgeom_raster.AddGgParameter("alpha")
        clsgeom_raster.AddGgParameter("colour")
        clsgeom_raster.AddGgParameter("fill")
        clsgeom_raster.AddGgParameter("linetype")
        clsgeom_raster.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_raster)

        clsgeom_rect.strGeomName = "geom_rect"
        'mandatory
        clsgeom_rect.AddGgParameter("x")
        clsgeom_rect.AddGgParameter("y")
        'optional
        clsgeom_rect.AddGgParameter("alpha")
        clsgeom_rect.AddGgParameter("colour")
        clsgeom_rect.AddGgParameter("fill")
        clsgeom_rect.AddGgParameter("linetype")
        clsgeom_rect.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_rect)

        clsgeom_ribbon.strGeomName = "geom_ribbon"
        clsgeom_ribbon.AddGgParameter("x")
        clsgeom_ribbon.AddGgParameter("ymax")
        clsgeom_ribbon.AddGgParameter("ymin")
        'optional
        clsgeom_ribbon.AddGgParameter("alpha")
        clsgeom_ribbon.AddGgParameter("colour")
        clsgeom_ribbon.AddGgParameter("linetype")
        clsgeom_ribbon.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_ribbon)

        clsgeom_rug.strGeomName = "geom_rug"
        clsgeom_rug.AddGgParameter("alpha")
        clsgeom_rug.AddGgParameter("colour")
        clsgeom_rug.AddGgParameter("linetype")
        clsgeom_rug.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_rug)

        clsgeom_segment.strGeomName = "geom_segment"
        'mandatory
        clsgeom_segment.AddGgParameter("x")
        clsgeom_segment.AddGgParameter("xend")
        clsgeom_segment.AddGgParameter("y")
        clsgeom_segment.AddGgParameter("yend")
        'optional
        clsgeom_segment.AddGgParameter("alpha")
        clsgeom_segment.AddGgParameter("colour")
        clsgeom_segment.AddGgParameter("linetype")
        clsgeom_segment.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_segment)

        clsgeom_smooth.strGeomName = "geom_smooth"
        'mandatory
        clsgeom_smooth.AddGgParameter("x")
        clsgeom_smooth.AddGgParameter("y")
        'optional 
        clsgeom_smooth.AddGgParameter("alpha")
        clsgeom_smooth.AddGgParameter("colour")
        clsgeom_smooth.AddGgParameter("fill")
        clsgeom_smooth.AddGgParameter("linetype")
        clsgeom_smooth.AddGgParameter("size")
        clsgeom_smooth.AddGgParameter("weight")
        lstAllGeoms.Add(clsgeom_smooth)

        clsgeom_spoke.strGeomName = "geom_spoke"
        'mandatory
        clsgeom_spoke.AddGgParameter("angle")
        clsgeom_spoke.AddGgParameter("radius")
        clsgeom_spoke.AddGgParameter("x")
        clsgeom_spoke.AddGgParameter("y")
        'optional
        clsgeom_spoke.AddGgParameter("alpha")
        clsgeom_spoke.AddGgParameter("colour")
        clsgeom_spoke.AddGgParameter("linetype")
        clsgeom_spoke.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_spoke)

        clsgeom_step.strGeomName = "geom_step"
        clsgeom_step.AddGgParameter("x")
        clsgeom_step.AddGgParameter("y")
        'optional
        clsgeom_step.AddGgParameter("alpha")
        clsgeom_step.AddGgParameter("colour")
        clsgeom_step.AddGgParameter("linetype")
        clsgeom_step.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_step)

        clsgeom_text.strGeomName = "geom_text"
        'mandatory
        clsgeom_text.AddGgParameter("label")
        clsgeom_text.AddGgParameter("x")
        clsgeom_text.AddGgParameter("y")
        'optional
        clsgeom_text.AddGgParameter("alpha")
        clsgeom_text.AddGgParameter("color")
        clsgeom_text.AddGgParameter("family")
        clsgeom_text.AddGgParameter("fontface")
        clsgeom_text.AddGgParameter("hjust")
        clsgeom_text.AddGgParameter("lineheight")
        'TO DO add size and vjust this might need additon of labels and receivers  
        lstAllGeoms.Add(clsgeom_text)

        clsgeom_tile.strGeomName = "geom_tile"
        'mandatory
        clsgeom_tile.AddGgParameter("x")
        clsgeom_tile.AddGgParameter("y")
        'optional
        clsgeom_tile.AddGgParameter("alpha")
        clsgeom_tile.AddGgParameter("colour")
        clsgeom_tile.AddGgParameter("fill")
        clsgeom_tile.AddGgParameter("linetype")
        clsgeom_tile.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_tile)

        clsgeom_violin.strGeomName = "geom_violin"
        'mandatory
        clsgeom_violin.AddGgParameter("x")
        clsgeom_violin.AddGgParameter("y")
        'optional
        clsgeom_violin.AddGgParameter("alpha")
        clsgeom_violin.AddGgParameter("colour")
        clsgeom_violin.AddGgParameter("fill")
        clsgeom_violin.AddGgParameter("linetype")
        clsgeom_violin.AddGgParameter("size")
        clsgeom_violin.AddGgParameter("weight")
        lstAllGeoms.Add(clsgeom_violin)

        clsgeom_vline.strGeomName = "geom_vline"
        clsgeom_vline.AddGgParameter("alpha")
        clsgeom_vline.AddGgParameter("colour")
        clsgeom_vline.AddGgParameter("linetype")
        clsgeom_vline.AddGgParameter("size")
        'TO DO  include those that control position
        lstAllGeoms.Add(clsgeom_vline)
    End Sub
    Public Event GeomChanged(sender As Object, e As EventArgs)
    Private Sub cboDistributions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGeomList.SelectedIndexChanged
        clsCurrGeom = lstAllGeoms(cboGeomList.SelectedIndex)
        clsGeomFunction.SetRCommand(clsCurrGeom.strGeomName)
        RaiseEvent GeomChanged(sender, e)
    End Sub
End Class
