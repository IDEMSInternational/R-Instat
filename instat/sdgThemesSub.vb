
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

Imports instat.Translations

Public Class sdgThemesSub
    Public bControlsInitialised As Boolean = False
    Private clsThemesFunction, clsElementPlotTitle, clsAxesTitles, clsElementPanelGridMinor, clsElementPanelGridMajor, clsXElementTitle, clsYElementTitle, clsAllLabels, clsXAxisLables, clsYAxisLabels, clsAllTickMarks, clsXAxisTickMarks, clsYAxisTickMarks, clsUnitAxisTickLength, clsAllAxisLines, clsXAxisLine, clsYAxisLine As New RFunction
    Private clsAllPanelGrid, clsPanelGridMajor, clsPanelGridMinor, clsPanelBackground, clsPanelBorder As New RFunction
    Private clsBaseOperator As New ROperator
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsThemesSubFunctions As New clsThemeSubFunctions

    Private Sub sdgThemesSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrPlotTitle.SetLabel("Plot Title")
        ucrThemeTitleXAxis.SetLabel("X-Axis Title")
        ucrThemeTitleYAxis.SetLabel("Y-Axis Title")

        ucrThemeAxesTickLabels.SetLabel("X and Y-Axis Labels")
        ucrThemeBottomXAxis.SetLabel("X-Axis Labels")
        ucrThemeLeftYAxis.SetLabel("Y-Axis Labels")

        ucrTickMarksAxes.SetLabel("X and Y-Axis Tick Markers")
        ucrTickMarksXAxis.SetLabel("X-Axis Tick Markers")
        ucrTickMarksYAxis.SetLabel("Y-Axis Tick Markers")

        ucrThemeAxesLines.SetLabel("Axis Lines")
        ucrXAxisLines.SetLabel("X-Axis Line")
        ucrYAxisLines.SetLabel("Y-Axis Line")

        ucrPanelGridMajor.SetLabel("Major Grid Lines")
        ucrPanelGridMinor.SetLabel("Major Grid Lines")
        ucrPanelBorder.SetLabel("Panel Border")
        ucrPanelBackground.SetLabel("Panel Background")
        ucrChkRemoveLegend.SetText("Remove Legend")
        ucRdoCoordinated.SetText("Coordinates")
        ucrrdoSpecific.SetText("Specific")

        bControlsInitialised = True
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
        ucrPlotTitle.SetRCodeForControl("plot.title", clsThemesSubFunctions.clsElementPlotTitle, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle)
        ucrThemeTitleXAxis.SetRCodeForControl("axis.title.x", clsThemesSubFunctions.clsXElementTitle, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("axis.title.y", clsYElementTitle)
        ucrThemeTitleYAxis.SetRCodeForControl("axis.title.y", clsThemesSubFunctions.clsYElementTitle, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("axis.text.x", clsXAxisLables)
        ucrThemeBottomXAxis.SetRCodeForControl("axis.text.x", clsThemesSubFunctions.clsXElementText, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("axis.text.y", clsYAxisLabels)
        ucrThemeLeftYAxis.SetRCodeForControl("axis.text.y", clsThemesSubFunctions.clsYElementText, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)


        dctThemeFunctions.TryGetValue("axis.ticks.x", clsXAxisTickMarks)
        ucrTickMarksXAxis.SetRCodeForControl("axis.ticks.x", clsThemesSubFunctions.clsXElementLine, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("axis.ticks.y", clsYAxisTickMarks)
        ucrTickMarksYAxis.SetRCodeForControl("axis.ticks.y", clsThemesSubFunctions.clsYElementLine, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("panel.grid.major", clsElementPanelGridMajor)
        ucrPanelGridMajor.SetRCodeForControl("panel.grid.major", clsThemesSubFunctions.clsElementPanelGridMajor, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("panel.grid.minor", clsElementPanelGridMinor)
        ucrPanelGridMinor.SetRCodeForControl("panel.grid.minor", clsThemesSubFunctions.clsElementPanelGridMinor, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("legend.text", clsElementLegendText)
        dctThemeFunctions.TryGetValue("legend.title", clsElementLegendTitle)


        ucrXAxisLines.SetRCodeForControl("axis.line.x", clsThemesSubFunctions.clsElementLineXAxis, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrYAxisLines.SetRCodeForControl("axis.line.y", clsThemesSubFunctions.clsElementLineYAxis, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPanelBorder.SetRCodeForControl("panel.border", clsThemesSubFunctions.clsElementBorder, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelBackground.SetRCodeForControl("panel.background", clsThemesSubFunctions.clsElementPanelBackGround, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
    End Sub
End Class

