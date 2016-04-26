
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
        clsgeom_abline.AddGgParameter("")
        clsgeom_abline.AddGgParameter("")
        clsgeom_abline.AddGgParameter("")
        clsgeom_abline.AddGgParameter("")
        clsgeom_abline.AddGgParameter("")
        clsgeom_abline.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_abline)

        clsgeom_area.strGeomName = "geom_area"
        clsgeom_area.AddGgParameter("")
        clsgeom_area.AddGgParameter("")
        clsgeom_area.AddGgParameter("")
        clsgeom_area.AddGgParameter("")
        clsgeom_area.AddGgParameter("")
        clsgeom_area.AddGgParameter("")
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
        clsgeom_bin2d.AddGgParameter("")
        clsgeom_bin2d.AddGgParameter("")
        clsgeom_bin2d.AddGgParameter("")
        clsgeom_bin2d.AddGgParameter("")
        clsgeom_bin2d.AddGgParameter("")
        clsgeom_bin2d.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_bin2d)

        clsgeom_boxplot.strGeomName = "geom_boxplot"
        clsgeom_boxplot.AddGgParameter("x")
        clsgeom_boxplot.AddGgParameter("y")
        clsgeom_boxplot.AddGgParameter("fill")
        clsgeom_boxplot.AddGgParameter("colour")
        clsgeom_boxplot.AddGgParameter("shape")
        clsgeom_boxplot.AddGgParameter("lower")
        clsgeom_boxplot.AddGgParameter("middle")
        lstAllGeoms.Add(clsgeom_boxplot)

        clsgeom_contour.strGeomName = "geom_contour"
        clsgeom_contour.AddGgParameter("")
        clsgeom_contour.AddGgParameter("")
        clsgeom_contour.AddGgParameter("")
        clsgeom_contour.AddGgParameter("")
        clsgeom_contour.AddGgParameter("")
        clsgeom_contour.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_contour)

        clsgeom_count.strGeomName = "geom_count"
        clsgeom_count.AddGgParameter("")
        clsgeom_count.AddGgParameter("")
        clsgeom_count.AddGgParameter("")
        clsgeom_count.AddGgParameter("")
        clsgeom_count.AddGgParameter("")
        clsgeom_count.AddGgParameter("")
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
        clsgeom_density.AddGgParameter("")
        clsgeom_density.AddGgParameter("")
        clsgeom_density.AddGgParameter("")
        clsgeom_density.AddGgParameter("")
        clsgeom_density.AddGgParameter("")
        clsgeom_density.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_density)

        clsgeom_density2d.strGeomName = "geom_density2d"
        clsgeom_density2d.AddGgParameter("")
        clsgeom_density2d.AddGgParameter("")
        clsgeom_density2d.AddGgParameter("")
        clsgeom_density2d.AddGgParameter("")
        clsgeom_density2d.AddGgParameter("")
        clsgeom_density2d.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_density2d)

        clsgeom_density_2d.strGeomName = "geom_density_2d"
        clsgeom_density_2d.AddGgParameter("")
        clsgeom_density_2d.AddGgParameter("")
        clsgeom_density_2d.AddGgParameter("")
        clsgeom_density_2d.AddGgParameter("")
        clsgeom_density_2d.AddGgParameter("")
        clsgeom_density_2d.AddGgParameter("")
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

        clsgeom_jitter.strGeomName = "geom_errorbarh"
        clsgeom_jitter.AddGgParameter("")
        clsgeom_jitter.AddGgParameter("")
        clsgeom_jitter.AddGgParameter("")
        clsgeom_jitter.AddGgParameter("")
        clsgeom_jitter.AddGgParameter("")
        clsgeom_jitter.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_jitter)

        clsgeom_freqpoly.strGeomName = "geom_freqpoly"
        clsgeom_freqpoly.AddGgParameter("")
        clsgeom_freqpoly.AddGgParameter("")
        clsgeom_freqpoly.AddGgParameter("")
        clsgeom_freqpoly.AddGgParameter("")
        clsgeom_freqpoly.AddGgParameter("")
        clsgeom_freqpoly.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_freqpoly)


        clsgeom_hex.strGeomName = "geom_hex"
        clsgeom_hex.AddGgParameter("")
        clsgeom_hex.AddGgParameter("")
        clsgeom_hex.AddGgParameter("")
        clsgeom_hex.AddGgParameter("")
        clsgeom_hex.AddGgParameter("")
        clsgeom_hex.AddGgParameter("")
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
        clsgeom_hline.AddGgParameter("")
        clsgeom_hline.AddGgParameter("")
        clsgeom_hline.AddGgParameter("")
        clsgeom_hline.AddGgParameter("")
        clsgeom_hline.AddGgParameter("")
        clsgeom_hline.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_hline)

        clsgeom_jitter.strGeomName = "geom_jitter"
        clsgeom_jitter.AddGgParameter("")
        clsgeom_jitter.AddGgParameter("")
        clsgeom_jitter.AddGgParameter("")
        clsgeom_jitter.AddGgParameter("")
        clsgeom_jitter.AddGgParameter("")
        clsgeom_jitter.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_jitter)

        clsgeom_label.strGeomName = "geom_label"
        clsgeom_label.AddGgParameter("")
        clsgeom_label.AddGgParameter("")
        clsgeom_label.AddGgParameter("")
        clsgeom_label.AddGgParameter("")
        clsgeom_label.AddGgParameter("")
        clsgeom_label.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_label)


        clsgeom_line.strGeomName = "geom_line"
        clsgeom_line.AddGgParameter("")
        clsgeom_line.AddGgParameter("")
        clsgeom_line.AddGgParameter("")
        clsgeom_line.AddGgParameter("")
        clsgeom_line.AddGgParameter("")
        clsgeom_line.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_line)


        clsgeom_linerange.strGeomName = "geom_linerange"
        clsgeom_linerange.AddGgParameter("")
        clsgeom_linerange.AddGgParameter("")
        clsgeom_linerange.AddGgParameter("")
        clsgeom_linerange.AddGgParameter("")
        clsgeom_linerange.AddGgParameter("")
        clsgeom_linerange.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_linerange)

        clsgeom_map.strGeomName = "geom_map"
        clsgeom_map.AddGgParameter("")
        clsgeom_map.AddGgParameter("")
        clsgeom_map.AddGgParameter("")
        clsgeom_map.AddGgParameter("")
        clsgeom_map.AddGgParameter("")
        clsgeom_map.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_map)

        clsgeom_path.strGeomName = "geom_path"
        clsgeom_path.AddGgParameter("")
        clsgeom_path.AddGgParameter("")
        clsgeom_path.AddGgParameter("")
        clsgeom_path.AddGgParameter("")
        clsgeom_path.AddGgParameter("")
        clsgeom_path.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_path)

        clsgeom_point.strGeomName = "geom_point"
        clsgeom_point.AddGgParameter("")
        clsgeom_point.AddGgParameter("")
        clsgeom_point.AddGgParameter("")
        clsgeom_point.AddGgParameter("")
        clsgeom_point.AddGgParameter("")
        clsgeom_point.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_point)

        clsgeom_pointrange.strGeomName = "geom_pointrange"
        clsgeom_pointrange.AddGgParameter("")
        clsgeom_pointrange.AddGgParameter("")
        clsgeom_pointrange.AddGgParameter("")
        clsgeom_pointrange.AddGgParameter("")
        clsgeom_pointrange.AddGgParameter("")
        clsgeom_pointrange.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_pointrange)

        clsgeom_polygon.strGeomName = "geom_polygon"
        clsgeom_polygon.AddGgParameter("")
        clsgeom_polygon.AddGgParameter("")
        clsgeom_polygon.AddGgParameter("")
        clsgeom_polygon.AddGgParameter("")
        clsgeom_polygon.AddGgParameter("")
        clsgeom_polygon.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_polygon)

        clsgeom_qq.strGeomName = "geom_qq"
        clsgeom_qq.AddGgParameter("")
        clsgeom_qq.AddGgParameter("")
        clsgeom_qq.AddGgParameter("")
        clsgeom_qq.AddGgParameter("")
        clsgeom_qq.AddGgParameter("")
        clsgeom_qq.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_qq)

        clsgeom_quantile.strGeomName = "geom_label"
        clsgeom_quantile.AddGgParameter("")
        clsgeom_quantile.AddGgParameter("")
        clsgeom_quantile.AddGgParameter("")
        clsgeom_quantile.AddGgParameter("")
        clsgeom_quantile.AddGgParameter("")
        clsgeom_quantile.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_quantile)

        clsgeom_raster.strGeomName = "geom_label"
        clsgeom_raster.AddGgParameter("")
        clsgeom_raster.AddGgParameter("")
        clsgeom_raster.AddGgParameter("")
        clsgeom_raster.AddGgParameter("")
        clsgeom_raster.AddGgParameter("")
        clsgeom_raster.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_raster)

        clsgeom_rect.strGeomName = "geom_rect"
        clsgeom_rect.AddGgParameter("")
        clsgeom_rect.AddGgParameter("")
        clsgeom_rect.AddGgParameter("")
        clsgeom_rect.AddGgParameter("")
        clsgeom_rect.AddGgParameter("")
        clsgeom_rect.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_rect)

        clsgeom_ribbon.strGeomName = "geom_ribbon"
        clsgeom_ribbon.AddGgParameter("")
        clsgeom_ribbon.AddGgParameter("")
        clsgeom_ribbon.AddGgParameter("")
        clsgeom_ribbon.AddGgParameter("")
        clsgeom_ribbon.AddGgParameter("")
        clsgeom_ribbon.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_ribbon)

        clsgeom_rug.strGeomName = "geom_rug"
        clsgeom_rug.AddGgParameter("")
        clsgeom_rug.AddGgParameter("")
        clsgeom_rug.AddGgParameter("")
        clsgeom_rug.AddGgParameter("")
        clsgeom_rug.AddGgParameter("")
        clsgeom_rug.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_rug)

        clsgeom_segment.strGeomName = "geom_segment"
        clsgeom_segment.AddGgParameter("")
        clsgeom_segment.AddGgParameter("")
        clsgeom_segment.AddGgParameter("")
        clsgeom_segment.AddGgParameter("")
        clsgeom_segment.AddGgParameter("")
        clsgeom_segment.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_segment)

        clsgeom_smooth.strGeomName = "geom_smooth"
        clsgeom_smooth.AddGgParameter("")
        clsgeom_smooth.AddGgParameter("")
        clsgeom_smooth.AddGgParameter("")
        clsgeom_smooth.AddGgParameter("")
        clsgeom_smooth.AddGgParameter("")
        clsgeom_smooth.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_smooth)

        clsgeom_spoke.strGeomName = "geom_spoke"
        clsgeom_spoke.AddGgParameter("")
        clsgeom_spoke.AddGgParameter("")
        clsgeom_spoke.AddGgParameter("")
        clsgeom_spoke.AddGgParameter("")
        clsgeom_spoke.AddGgParameter("")
        clsgeom_spoke.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_spoke)

        clsgeom_step.strGeomName = "geom_step"
        clsgeom_step.AddGgParameter("")
        clsgeom_step.AddGgParameter("")
        clsgeom_step.AddGgParameter("")
        clsgeom_step.AddGgParameter("")
        clsgeom_step.AddGgParameter("")
        clsgeom_step.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_step)

        clsgeom_text.strGeomName = "geom_text"
        clsgeom_text.AddGgParameter("")
        clsgeom_text.AddGgParameter("")
        clsgeom_text.AddGgParameter("")
        clsgeom_text.AddGgParameter("")
        clsgeom_text.AddGgParameter("")
        clsgeom_text.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_text)

        clsgeom_tile.strGeomName = "geom_tile"
        clsgeom_tile.AddGgParameter("")
        clsgeom_tile.AddGgParameter("")
        clsgeom_tile.AddGgParameter("")
        clsgeom_tile.AddGgParameter("")
        clsgeom_tile.AddGgParameter("")
        clsgeom_tile.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_tile)

        clsgeom_violin.strGeomName = "geom_violin"
        clsgeom_violin.AddGgParameter("")
        clsgeom_violin.AddGgParameter("")
        clsgeom_violin.AddGgParameter("")
        clsgeom_violin.AddGgParameter("")
        clsgeom_violin.AddGgParameter("")
        clsgeom_violin.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_violin)

        clsgeom_vline.strGeomName = "geom_vline"
        clsgeom_vline.AddGgParameter("")
        clsgeom_vline.AddGgParameter("")
        clsgeom_vline.AddGgParameter("")
        clsgeom_vline.AddGgParameter("")
        clsgeom_vline.AddGgParameter("")
        clsgeom_vline.AddGgParameter("")
        lstAllGeoms.Add(clsgeom_vline)
    End Sub
    Public Event GeomChanged(sender As Object, e As EventArgs)
    Private Sub cboDistributions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGeomList.SelectedIndexChanged
        clsCurrGeom = lstAllGeoms(cboGeomList.SelectedIndex)
        clsGeomFunction.SetRCommand(clsCurrGeom.strGeomName)
        RaiseEvent GeomChanged(sender, e)
    End Sub
End Class
