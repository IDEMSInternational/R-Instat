'R-Instat
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

Imports instat.Translations

Public Class dlgCircularScatterPlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsMutateFunction As RFunction
    Private clsArrangeFunction As RFunction
    Private clsDensityFunction As RFunction
    Private clsOrderFunction As RFunction
    Private clsGgplotFunction As RFunction
    Private clsGgplotAesFunction As RFunction
    Private clsGeomPointFunction As RFunction
    Private clsGeomPointAesFunction As RFunction
    Private clsGeomLineFunction As RFunction
    Private clsYlimFunction As RFunction
    Private clsXlimFunction As RFunction
    Private clsCordPolarFunction As RFunction
    Private clsMinimumFunction As RFunction
    Private clsMaximumFunction As RFunction
    Private clsFacetWrapFunction As RFunction
    Private clsVarsFunction As RFunction

    Private clsPipeOperator As ROperator
    Private clsPlusOperator As ROperator
    Private clsDolarOperator As ROperator

    Private Sub dlgCircularScatterPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class