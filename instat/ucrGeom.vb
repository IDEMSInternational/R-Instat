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
        Dim clsgeom_boxplot As New Geoms
        Dim clsgeom_dotplot As New Geoms
        Dim clsgeom_histogram As New Geoms

        clsgeom_boxplot.strGeomName = "geom_boxplot"
        clsgeom_boxplot.AddGgParameter("x")
        clsgeom_boxplot.AddGgParameter("y")
        clsgeom_boxplot.AddGgParameter("fill")
        clsgeom_boxplot.AddGgParameter("colour")
        clsgeom_boxplot.AddGgParameter("shape")
        clsgeom_boxplot.AddGgParameter("lower")
        clsgeom_boxplot.AddGgParameter("middle")
        lstAllGeoms.Add(clsgeom_boxplot)


        clsgeom_dotplot.strGeomName = "geom_dotplot"
        clsgeom_dotplot.AddGgParameter("x")
        clsgeom_dotplot.AddGgParameter("y")
        clsgeom_dotplot.AddGgParameter("alpha")
        clsgeom_dotplot.AddGgParameter("colour")
        clsgeom_dotplot.AddGgParameter("fill")
        lstAllGeoms.Add(clsgeom_dotplot)


        clsgeom_histogram.strGeomName = "geom_histogram"
        clsgeom_histogram.AddGgParameter("x")
        clsgeom_histogram.AddGgParameter("alpha")
        clsgeom_histogram.AddGgParameter("colour")
        clsgeom_histogram.AddGgParameter("fill")
        clsgeom_histogram.AddGgParameter("linetype")
        clsgeom_histogram.AddGgParameter("size")
        lstAllGeoms.Add(clsgeom_histogram)

    End Sub
    Public Event GeomChanged(sender As Object, e As EventArgs)
    Private Sub cboDistributions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGeomList.SelectedIndexChanged
        clsCurrGeom = lstAllGeoms(cboGeomList.SelectedIndex)
        clsGeomFunction.SetRCommand(clsCurrGeom.strGeomName)
        RaiseEvent GeomChanged(sender, e)
    End Sub
End Class
