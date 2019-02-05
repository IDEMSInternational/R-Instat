
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
    Private clsThemesFunction, clsElementPlotTitle, clsAxesTitles, clsXElementTitle, clsYElementTitle, clsAllLabels, clsXAxisLables, clsYAxisLabels, clsAllTickMarks, clsXAxisTickMarks, clsYAxisTickMarks, clsUnitAxisTickLength, clsAllAxisLines, clsXAxisLine, clsYAxisLine As New RFunction
    Private clsAllPanelGrid, clsPanelGridMajor, clsPanelGridMinor, clsPanelBackground, clsPanelBorder As New RFunction
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
        'ucrChkAllLabels.AddToLinkedControls(ucrThemeAxesTickLabels, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
    End Sub

    Public Sub SetRCode()
        'Theme command 
        clsThemesFunction = New RFunction
        'Titles
        clsElementPlotTitle = New RFunction
        clsAxesTitles = New RFunction
        clsXElementTitle = New RFunction
        clsYElementTitle = New RFunction
        'Labels 
        clsAllLabels = New RFunction
        clsXAxisLables = New RFunction
        clsYAxisLabels = New RFunction
        'Tick Markers 
        clsAllTickMarks = New RFunction
        clsXAxisTickMarks = New RFunction
        clsYAxisTickMarks = New RFunction
        clsUnitAxisTickLength = New RFunction
        'Lines 
        clsAllAxisLines = New RFunction
        clsXAxisLine = New RFunction
        clsYAxisLine = New RFunction
        'Panel
        clsAllPanelGrid = New RFunction
        clsPanelGridMajor = New RFunction
        clsPanelGridMinor = New RFunction
        'Background 
        clsPanelBackground = New RFunction
        clsPanelBorder = New RFunction

        Dim clsElementLegendText As New RFunction
        Dim clsElementLegendTitle As New RFunction
        Dim clsElementLegendBackground As New RFunction
        Dim clsElementLegendBoxBackground As New RFunction
        Dim clsElementLegendtKey As New RFunction

        Dim clsElementBorder As New RFunction
        Dim clsElementPanelBackGround As New RFunction
        Dim clsElementPlotBackground As New RFunction
    End Sub

    Public Sub SetRCode(clsBaseOperator As ROperator, clsNewThemesFunction As RFunction, dctNewThemeFunctions As Dictionary(Of String, RFunction), Optional bReset As Boolean = False)

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsThemesFunction = clsNewThemesFunction
        ' The position MUST be larger than the position of the theme_* argument
        ' Otherwise the choice of theme will overwrite the options selected here.
        ' Currently set to large value as no reason this cannot be at the end currently
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemesFunction, iPosition:=100)
        dctThemeFunctions = dctNewThemeFunctions

        Dim clsElementLegendText As New RFunction
        Dim clsElementLegendTitle As New RFunction

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

        'dctThemeFunctions.TryGetValue("axis.line", clsElementLineAxes)
        'dctThemeFunctions.TryGetValue("axis.line.x", clsElementLineXAxis)
        'dctThemeFunctions.TryGetValue("axis.line.y", clsElementLineYAxis)

        'dctThemeFunctions.TryGetValue("panel.grid", clsElementPanelGrid)
        'dctThemeFunctions.TryGetValue("panel.grid.major", clsElementPanelGridMajor)
        'dctThemeFunctions.TryGetValue("panel.grid.minor", clsElementPanelGridMinor)

        'ucrPanelBackground.SetRCodeForControl("panel.background", clsElementPanelBackGround, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        'ucrPlotBackground.SetRCodeForControl("plot.background", clsElementPlotBackground, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

    End Sub



End Class

