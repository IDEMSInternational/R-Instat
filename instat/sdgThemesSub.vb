
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

Imports instat
    Imports instat.Translations

    Public Class sdgThemesSub
        Public bControlsInitialised As Boolean = False
        Private clsElementLine, clsElementRect, clsElementXAxisLine, clsElementYAxisLine, clsElementText, clsThemeFunction As New RFunction
        Private clsBaseOperator As New ROperator
        Private dctThemeFunctions As New Dictionary(Of String, RFunction)

        Private Sub sdgThemesSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            autoTranslate(Me)
        End Sub

        Public Sub InitialiseControls()
        ucrPlotTitle.SetLabel("Plot Title")
        ucrThemeTitleXAxis.SetLabel("X-Axis Title")
        ucrThemeTitleYAxis.SetLabel("Y-Axis Title")
        ucrChkAllLabels.SetText("All Labels")
        ucrThemeAxesTickLabels.SetLabel("X and Y-Axis Labels")
        ucrThemeBottomXAxis.SetLabel("X-Axis Labels")
        ucrThemeLeftYAxis.SetLabel("Y-Axis Labels")
        ucrChkAllTickMarkers.SetText("All Tick Markers")
        ucrTickMarksAxes.SetLabel("X and Y-Axis Tick Markers")
        ucrTickMarksXAxis.SetLabel("X-Axis Tick Markers")
        ucrTickMarksYAxis.SetLabel("Y-Axis Tick Markers")
        ucrChkAllLines.SetText("X and Y-Axis Lines")
        ucrThemeAxesLines.SetLabel("Axis Lines")
        ucrXAxisLines.SetLabel("X-Axis Line")
        ucrYAxisLines.SetLabel("Y-Axis Line")
        ucrChkAllGridLines.SetText("All Grid Lines")
        ucrPanelGridMajor.SetLabel("Major Grid Lines")
        ucrPanelGridMinor.SetLabel("Major Grid Lines")
        ucrPanelBorder.SetLabel("Panel Border")
        ucrPanelBackground.SetLabel("Panel Background")
        ucrChkRemoveLegend.SetText("Remove Legend")
        ucRdoCoordinated.SetText("Coordinates")
        ucrrdoSpecific.SetText("Specific")

        'Need to link all check boxes to ucrTextThemes
        ucrChkAllLabels.AddToLinkedControls(ucrThemeAxesTickLabels, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
    End Sub

    Public Sub SetRCode(clsBaseOperator As ROperator, clsNewThemeFunction As RFunction, dctNewThemeFunctions As Dictionary(Of String, RFunction), Optional bReset As Boolean = False)
        'Titles
        Dim clsElementPlotTitle As New RFunction
        Dim clsAxesTitles As New RFunction
        Dim clsXElementTitle As New RFunction
        Dim clsYElementTitle As New RFunction
        'Labels 
        Dim clsAllLabels As New RFunction
        Dim clsXAxisLables As New RFunction
        Dim clsYAxisLabels As New RFunction
        'Tick Markers 
        Dim clsAllTickMarks As New RFunction
        Dim clsXAxisTickMarks As New RFunction
        Dim clsYAxisTickMarks As New RFunction
        'Lines 
        Dim clsAllAxisLines As New RFunction
        Dim clsXAxisLine As New RFunction
        Dim clsYAxisLine As New RFunction

        Dim clsElementLineAxes As New RFunction
        Dim clsXElementLine As New RFunction
        Dim clsYElementLine As New RFunction
        Dim clsElementLineXAxis As New RFunction
        Dim clsElementLineYAxis As New RFunction
        Dim clsUnitAxisTickLength As New RFunction

        Dim clsElementLegendText As New RFunction
        Dim clsElementLegendTitle As New RFunction
        Dim clsElementLegendBackground As New RFunction
        Dim clsElementLegendBoxBackground As New RFunction
        Dim clsElementLegendtKey As New RFunction

        Dim clsElementBorder As New RFunction
        Dim clsElementPanelBackGround As New RFunction
        Dim clsElementPlotBackground As New RFunction

        Dim clsElementPanelGrid As New RFunction
        Dim clsElementPanelGridMajor As New RFunction
        Dim clsElementPanelGridMinor As New RFunction

        Dim clsUnitLegendSize As New RFunction
        Dim clsUnitLegendHeight As New RFunction
        Dim clsUnitLegendWidth As New RFunction

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsThemeFunction = clsNewThemeFunction
        ' The position MUST be larger than the position of the theme_* argument
        ' Otherwise the choice of theme will overwrite the options selected here.
        ' Currently set to large value as no reason this cannot be at the end currently
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)
        dctThemeFunctions = dctNewThemeFunctions

        dctThemeFunctions.TryGetValue("plot.title", clsElementPlotTitle)
        dctThemeFunctions.TryGetValue("axis.title", clsAxesTitles)
        dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.y", clsYElementTitle)

        dctThemeFunctions.TryGetValue("axis.text", clsAllLabels)
        dctThemeFunctions.TryGetValue("axis.text.x", clsXAxisLables)
        dctThemeFunctions.TryGetValue("axis.text.y", clsYAxisLabels)

        dctThemeFunctions.TryGetValue("legend.text", clsElementLegendText)
        dctThemeFunctions.TryGetValue("legend.title", clsElementLegendTitle)

        dctThemeFunctions.TryGetValue("axis.ticks", clsAllTickMarks)
        dctThemeFunctions.TryGetValue("axis.ticks.x", clsXAxisTickMarks)
        dctThemeFunctions.TryGetValue("axis.ticks.y", clsYAxisTickMarks)
        dctThemeFunctions.TryGetValue("axis.ticks.length", clsUnitAxisTickLength)

        dctThemeFunctions.TryGetValue("axis.line", clsElementLineAxes)
        dctThemeFunctions.TryGetValue("axis.line.x", clsElementLineXAxis)
        dctThemeFunctions.TryGetValue("axis.line.y", clsElementLineYAxis)

        dctThemeFunctions.TryGetValue("panel.grid", clsElementPanelGrid)
        dctThemeFunctions.TryGetValue("panel.grid.major", clsElementPanelGridMajor)
        dctThemeFunctions.TryGetValue("panel.grid.minor", clsElementPanelGridMinor)

        ucrPanelBackground.SetRCodeForControl("panel.background", clsElementPanelBackGround, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPlotBackground.SetRCodeForControl("plot.background", clsElementPlotBackground, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

    End Sub



End Class

