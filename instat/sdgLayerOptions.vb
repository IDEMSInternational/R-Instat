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
Public Class sdgLayerOptions
    Private bFirstLoad As Boolean = True
    Private Sub sdgLayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub
    Private Sub InitialiseDialog()

    End Sub

    Private Sub SetDefaults()
        lblNotchWidth.Visible = False
        nudNotchWidth.Visible = False
        nudWhiskerLength.Visible = False
        lblShape.Visible = False
        nudShape.Visible = False
        lblSize.Visible = False
        nudSize.Visible = -False
        lblStroke.Visible = False
        nudStroke.Visible = False
    End Sub
    Private Sub ReopenDialog()

    End Sub

    Private Sub chkVariableWidth_CheckedChanged(sender As Object, e As EventArgs) Handles chkVariableWidth.CheckedChanged
        If chkVariableWidth.Checked Then
            ucrGeomWithAes.clsGeomFunction.AddParameter("varwidth", "TRUE")
        Else
            ucrGeomWithAes.clsGeomFunction.RemoveParameterByName("varwidth")
        End If
    End Sub

    Private Sub chkNotchedBoxplot_CheckedChanged(sender As Object, e As EventArgs) Handles chkNotchedBoxplot.CheckedChanged
        If chkNotchedBoxplot.Checked Then
            ucrGeomWithAes.clsGeomFunction.AddParameter("notch", "TRUE")
        Else
            ucrGeomWithAes.clsGeomFunction.RemoveParameterByName("notch")
        End If
        lblNotchWidth.Visible = True
        nudNotchWidth.Visible = True
    End Sub

    Private Sub nudWhiskerLength_ValueChanged(sender As Object, e As EventArgs) Handles nudWhiskerLength.ValueChanged
        ucrGeomWithAes.clsGeomFunction.AddParameter("coef", nudWhiskerLength.Value)
    End Sub

    Private Sub nudShape_ValueChanged(sender As Object, e As EventArgs) Handles nudShape.ValueChanged
        ucrGeomWithAes.clsGeomFunction.AddParameter("outlier.shape", nudShape.Value)
    End Sub

    Private Sub nudStroke_ValueChanged(sender As Object, e As EventArgs) Handles nudStroke.ValueChanged
        ucrGeomWithAes.clsGeomFunction.AddParameter("outlier.stroke", nudStroke.Value)
    End Sub

    Private Sub nudSize_ValueChanged(sender As Object, e As EventArgs) Handles nudSize.ValueChanged
        ucrGeomWithAes.clsGeomFunction.AddParameter("outlier.size", nudSize.Value)
    End Sub

    Private Sub chkWhiskerLength_CheckedChanged(sender As Object, e As EventArgs) Handles chkWhiskerLength.CheckedChanged
        nudWhiskerLength.Visible = True
    End Sub

    Private Sub chkChangeOutliers_CheckedChanged(sender As Object, e As EventArgs) Handles chkChangeOutliers.CheckedChanged
        lblShape.Visible = True
        nudShape.Visible = True
        lblSize.Visible = True
        nudSize.Visible = -True
        lblStroke.Visible = True
        nudStroke.Visible = True
    End Sub
End Class
