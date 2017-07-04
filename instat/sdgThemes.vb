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

Public Class sdgThemes
    Public bControlsInitialised As Boolean = False
    Private clsElementLine, clsElementRect, clsElementXAxisTextTop, clsElementXAxisLine, clsElementYAxisLine, clsElementText, clsElementYAxisTextRight, clsElementXAxisLineTop, clsThemeFunction As New RFunction

    Private clsBaseOperator As New ROperator

    Private dctThemeFunctions As New Dictionary(Of String, RFunction)

    Private Sub sdgThemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctLegendPosition As New Dictionary(Of String, String)
        Dim dctLegendDirection As New Dictionary(Of String, String)
        Dim dctLegendBox As New Dictionary(Of String, String)
        Dim dctLegendBoxJust As New Dictionary(Of String, String)
        Dim dctLegendJustification As New Dictionary(Of String, String)

        ucrThemeBottomXAxis.SetLabel("X axis tick labels")
        ucrThemeTopXAxis.SetLabel("X axis tick labels on top axis")
        ucrThemeLeftYAxis.SetLabel("Y axis tick labels")
        ucrThemeYRightAxis.SetLabel("Y axis tick labels on right axis")
        ucrThemeTitleXAxis.SetLabel("X axis label ")
        ucrThemeTitleXTopAxis.SetLabel("X axis label on top axis")
        ucrThemeTitleYAxis.SetLabel("Y axis labels")
        ucrThemeTitleYRightAxis.SetLabel("Y axis labels on right axis")
        ucrTickMarksYAxis.SetLabel("Y axis tick marks")
        ucrYAxisLines.SetLabel("Line along y axis")
        ucrTickMarksXAxis.SetLabel("X axis tick marks")
        ucrXAxisLines.SetLabel("Line along x axis")
        ucrTickMarksAxes.SetLabel("Tick marks along axes")
        ucrThemeAxesTitle.SetLabel("Label of axes")
        ucrThemeAxesTickLabels.SetLabel("Tick marks label along axes")
        ucrThemeAxesLines.SetLabel("Lines along axes")

        ucrLegendTitle.SetLabel("Title of legend")
        ucrLegendText.SetLabel("Legend item labels")
        ucrLegendBackground.SetLabel("Background of legend")
        ucrLegendKey.SetLabel("Background underneath legend keys")
        ucrLegendBoxBackground.SetLabel("Background of legend area")

        ucrLegendSpacing.setlabel("Spacing between legends")
        ucrLegendSpacingXAxis.setlabel("Horizontal spacing between legends")
        ucrLegendSpacingYAxis.setlabel("Horizontal spacing between legends")
        ucrLegendBoxSpacing.setlabel("Space between plot area legend box")

        ucrPanelGridMajorXAxis.SetLabel("Vertical major grid lines ")
        ucrPanelGridMajorYAxis.SetLabel("Horizontal major grid lines ")
        ucrPanelGridMinorXAxis.SetLabel("Vertical minor grid lines")
        ucrPanelGridMinorYAxis.SetLabel("Horizontal minor grid lines")

        ucrPanelGrid.SetLabel("Grid lines")
        ucrPanelGridMajor.SetLabel("Major grid lines ")
        ucrPanelGridMinor.SetLabel("Major grid lines ")
        ucrPanelBorder.SetLabel("Panel border")
        ucrPanelBackGround.SetLabel("Panel background")

        ucrPlotBackground.SetLabel("Background of the entire plot")
        ucrPlotCaption.SetLabel("Caption below the plot (text appearance)")
        ucrPlotSubTitle.SetLabel("Plot subtitle (text appearance)")
        ucrPlotTitle.SetLabel("Plot title (text appearance)")

        ucrStripBackGround.SetLabel("Background of facet labels")
        ucrStripText.SetLabel("Facet labels")
        ucrStripTextXAxis.SetLabel("Facet labels along horizontal direction")
        ucrStripTextYAxis.SetLabel("Facet labels along vertical direction")

        ucrTickLength.setlabel("Length of tick marks")
        ucrPlotMargin.setlabel("Margin around entire plot")

        ucrLegendKeySize.setlabel("Size of legend keys")
        ucrLegendKeyHeight.setlabel("Key background height")
        ucrLegendKeyWidth.setlabel("Key background width")

        ucrPanelSpacing.setlabel("Spacing between facet panels ")
        ucrPanelSpacingXAxis.setlabel("Horizontal spacing between facet panels")
        ucrPanelSpacingYAxis.setlabel("Vertical spacing between facet panels")

        ucrStripsSpaceGrid.setlabel("When strips are switched (Grid)")
        ucrStripsSpaceWrap.setlabel("when strips are switched (wrap)")

        ' TODO: Find what this means: "two-element numeric vector"
        urChkLegendPosition.SetText("Legend Position")
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        urChkLegendPosition.AddParameterPresentCondition(True, "legend.position")
        urChkLegendPosition.AddParameterPresentCondition(False, "legend.position", False)

        ucrChkLegendBox.SetText("Legend Layout")
        ucrInputLegendBox.SetParameter(New RParameter("legend.box"))
        dctLegendBox.Add("Vertical", Chr(34) & "vertical" & Chr(34))
        dctLegendBox.Add("Horizontal", Chr(34) & "horizontal" & Chr(34))
        ucrInputLegendBox.SetItems(dctLegendBox)
        ucrChkLegendBox.AddParameterPresentCondition(True, "legend.box")
        ucrChkLegendBox.AddParameterPresentCondition(False, "legend.box", False)

        urChkLegendBoxJust.SetText("Justify Legend Box")
        ucrInputLegendBoxJust.SetParameter(New RParameter("legend.box.just"))
        dctLegendBoxJust.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendBoxJust.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctLegendBoxJust.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendBoxJust.Add("Left", Chr(34) & "left" & Chr(34))
        ucrInputLegendBoxJust.SetItems(dctLegendBoxJust)
        urChkLegendBoxJust.AddParameterPresentCondition(True, "legend.box.just")
        urChkLegendBoxJust.AddParameterPresentCondition(False, "legend.box.just", False)

        ucrChkLegendDirection.SetText("Legend Direction")
        ucrInputLegendDirection.SetParameter(New RParameter("legend.direction"))
        dctLegendDirection.Add("Vertical", Chr(34) & "vertical" & Chr(34))
        dctLegendDirection.Add("Horizontal", Chr(34) & "horizontal" & Chr(34))
        ucrInputLegendDirection.SetItems(dctLegendDirection)
        ucrChkLegendDirection.AddParameterPresentCondition(True, "legend.direction")
        ucrChkLegendDirection.AddParameterPresentCondition(False, "legend.direction", False)


        ucrChkLegendJustification.SetText("Legend Justification")
        ucrInputLegendJustification.SetParameter(New RParameter("legend.justification"))
        dctLegendJustification.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendJustification.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctLegendJustification.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendJustification.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendJustification.Add("Center", Chr(34) & "centre" & Chr(34))
        ucrInputLegendJustification.SetItems(dctLegendJustification)
        ucrChkLegendJustification.AddParameterPresentCondition(True, "legend.justification")
        ucrChkLegendJustification.AddParameterPresentCondition(False, "legend.justification", False)


        urChkLegendPosition.AddToLinkedControls(ucrInputLegendPosition, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrChkLegendBox.AddToLinkedControls(ucrInputLegendBox, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Vertical")
        urChkLegendBoxJust.AddToLinkedControls(ucrInputLegendBoxJust, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Top")
        ucrChkLegendDirection.AddToLinkedControls(ucrInputLegendDirection, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Vertical")
        ucrChkLegendJustification.AddToLinkedControls(ucrInputLegendJustification, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Top")

    End Sub

    Public Sub SetRCode(clsBaseOperator As ROperator, clsNewThemeFunction As RFunction, dctNewThemeFunctions As Dictionary(Of String, RFunction), Optional bReset As Boolean = False)
        Dim clsXElementText As New RFunction
        Dim clsElementTickText As New RFunction
        Dim clsXElementTitleText As New RFunction
        Dim clsYElementText As New RFunction
        Dim clsXTopElementText As New RFunction
        Dim clsYRightElementText As New RFunction
        Dim clsXElementTitle As New RFunction
        Dim clsYElementTitle As New RFunction
        Dim clsXTopElementTitle As New RFunction
        Dim clsYRightElementTitle As New RFunction
        Dim clsElementLegendText As New RFunction
        Dim clsElementLegendTitle As New RFunction

        Dim clsElementPlotTitle As New RFunction
        Dim clsElementPlotSubtitle As New RFunction
        Dim clsElementPlotCaption As New RFunction

        Dim clsElementStripText As New RFunction
        Dim clsElementStripTextXAxis As New RFunction
        Dim clsElementStripTextYAxis As New RFunction

        Dim clsXElementLine As New RFunction
        Dim clsElementLineAxes As New RFunction
        Dim clsYElementLine As New RFunction
        Dim clsElementTickAxes As New RFunction
        Dim clsElementTickXAxis As New RFunction
        Dim clsElementTickYAxis As New RFunction
        Dim clsElementLineXAxis As New RFunction
        Dim clsElementLineYAxis As New RFunction

        Dim clsElementLegendBackground As New RFunction
        Dim clsElementLegendBoxBackground As New RFunction
        Dim clsElementLegendtKey As New RFunction

        Dim clsElementBorder As New RFunction
        Dim clsElementPanelBackGround As New RFunction

        Dim clsElementPlotBackground As New RFunction
        Dim clsElementStripBackground As New RFunction

        Dim clsElementPanelGrid As New RFunction
        Dim clsElementPanelGridMajor As New RFunction
        Dim clsElementPanelGridMinor As New RFunction
        Dim clsElementPanelGridMajorXAxis As New RFunction
        Dim clsElementPanelGridMajorYAxis As New RFunction
        Dim clsElementPanelGridMinorXAxis As New RFunction
        Dim clsElementPanelGridMinorYAxis As New RFunction

        Dim clsUnitAxisTickLength As New RFunction
        Dim clsUnitLegendSize As New RFunction
        Dim clsUnitLegendHeight As New RFunction
        Dim clsUnitLegendWidth As New RFunction
        Dim clsUnitPanelSpacing As New RFunction
        Dim clsUnitPanelSpacingXAxis As New RFunction
        Dim clsUnitPanelSpacingYAxis As New RFunction
        Dim clsUnitPlotMargin As New RFunction
        Dim clsUnitStripsGrid As New RFunction
        Dim clsUnitStripsWrap As New RFunction
        Dim clsUnitLegendSpacing As New RFunction
        Dim clsUnitLegendSpacingXAxis As New RFunction
        Dim clsUnitLegendSpacingYAxis As New RFunction
        Dim clsUnitLegendBoxSpacing As New RFunction

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsThemeFunction = clsNewThemeFunction
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)

        dctThemeFunctions = dctNewThemeFunctions
        dctThemeFunctions.TryGetValue("axis.text", clsElementTickText)
        dctThemeFunctions.TryGetValue("axis.text.x", clsXElementText)
        dctThemeFunctions.TryGetValue("axis.text.y", clsYElementText)
        dctThemeFunctions.TryGetValue("axis.text.x.top", clsXTopElementText)
        dctThemeFunctions.TryGetValue("axis.text.y.right", clsYRightElementText)

        dctThemeFunctions.TryGetValue("legend.text", clsElementLegendText)
        dctThemeFunctions.TryGetValue("legend.title", clsElementLegendTitle)

        dctThemeFunctions.TryGetValue("axis.title", clsXElementTitleText)
        dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.y", clsYElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.x.top", clsXTopElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.y.right", clsYRightElementTitle)

        dctThemeFunctions.TryGetValue("plot.title", clsElementPlotTitle)
        dctThemeFunctions.TryGetValue("plot.subtitle", clsElementPlotSubtitle)
        dctThemeFunctions.TryGetValue("plot.caption", clsElementPlotCaption)

        dctThemeFunctions.TryGetValue("strip.text", clsElementStripText)
        dctThemeFunctions.TryGetValue("strip.text.x", clsElementStripTextXAxis)
        dctThemeFunctions.TryGetValue("strip.text.y", clsElementStripTextYAxis)

        dctThemeFunctions.TryGetValue("axis.ticks.x", clsXElementLine)
        dctThemeFunctions.TryGetValue("axis.ticks.y", clsYElementLine)
        dctThemeFunctions.TryGetValue("axis.line.x", clsElementLineXAxis)
        dctThemeFunctions.TryGetValue("axis.line.y", clsElementLineYAxis)
        dctThemeFunctions.TryGetValue("axis.ticks", clsElementTickAxes)
        dctThemeFunctions.TryGetValue("axis.line", clsElementLineAxes)

        dctThemeFunctions.TryGetValue("panel.grid", clsElementPanelGrid)
        dctThemeFunctions.TryGetValue("panel.grid.major", clsElementPanelGridMajor)
        dctThemeFunctions.TryGetValue("panel.grid.minor", clsElementPanelGridMinor)
        dctThemeFunctions.TryGetValue("panel.grid.major.x", clsElementPanelGridMajorXAxis)
        dctThemeFunctions.TryGetValue("panel.grid.major.y", clsElementPanelGridMajorYAxis)
        dctThemeFunctions.TryGetValue("panel.grid.minor.x", clsElementPanelGridMinorXAxis)
        dctThemeFunctions.TryGetValue("panel.grid.minor.y", clsElementPanelGridMinorYAxis)

        dctThemeFunctions.TryGetValue("axis.ticks.length", clsUnitAxisTickLength)
        dctThemeFunctions.TryGetValue("legend.key.size", clsUnitLegendSize)
        dctThemeFunctions.TryGetValue("legend.key.height", clsUnitLegendHeight)
        dctThemeFunctions.TryGetValue("legend.key.width", clsUnitLegendWidth)
        dctThemeFunctions.TryGetValue("panel.spacing", clsUnitPanelSpacing)
        dctThemeFunctions.TryGetValue("panel.spacing.x", clsUnitPanelSpacingXAxis)
        dctThemeFunctions.TryGetValue("panel.spacing.y", clsUnitPanelSpacingYAxis)
        dctThemeFunctions.TryGetValue("plot.margin", clsUnitPlotMargin)
        dctThemeFunctions.TryGetValue("strip.switch.pad.grid", clsUnitStripsGrid)
        dctThemeFunctions.TryGetValue("strip.switch.pad.wrap", clsUnitStripsWrap)

        dctThemeFunctions.TryGetValue("legend.background", clsElementLegendBackground)
        dctThemeFunctions.TryGetValue("legend.box.background", clsElementLegendBoxBackground)
        dctThemeFunctions.TryGetValue("legend.key", clsElementLegendtKey)
        dctThemeFunctions.TryGetValue("panel.background", clsElementPanelBackGround)
        dctThemeFunctions.TryGetValue("panel.border", clsElementBorder)

        dctThemeFunctions.TryGetValue("legend.spacing", clsUnitLegendSpacing)
        dctThemeFunctions.TryGetValue("legend.spacing.x", clsUnitLegendSpacingXAxis)
        dctThemeFunctions.TryGetValue("legend.spacing.y", clsUnitLegendSpacingYAxis)
        dctThemeFunctions.TryGetValue("legend.box.spacing", clsUnitLegendBoxSpacing)

        dctThemeFunctions.TryGetValue("plot.background", clsElementPlotBackground)

        dctThemeFunctions.TryGetValue("strip.background", clsElementStripBackground)

        ucrTickMarksXAxis.SetRCodeForControl("axis.ticks.x", clsXElementLine, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrTickMarksYAxis.SetRCodeForControl("axis.ticks.y", clsYElementLine, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrXAxisLines.SetRCodeForControl("axis.line.x", clsElementLineXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrYAxisLines.SetRCodeForControl("axis.line.y", clsElementLineYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrTickMarksAxes.SetRCodeForControl("axis.ticks", clsElementTickAxes, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeAxesTickLabels.SetRCodeForControl("axis.text", clsElementTickText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeAxesTitle.SetRCodeForControl("axis.title", clsXElementTitleText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeAxesLines.SetRCodeForControl("axis.line", clsElementLineAxes, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrThemeBottomXAxis.SetRCodeForControl("axis.text.x", clsXElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTopXAxis.SetRCodeForControl("axis.text.x.top", clsXTopElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeLeftYAxis.SetRCodeForControl("axis.text.y", clsYElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeYRightAxis.SetRCodeForControl("axis.text.y.right", clsYRightElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrThemeTitleXAxis.SetRCodeForControl("axis.title.x", clsXElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTitleXTopAxis.SetRCodeForControl("axis.title.x.top", clsXTopElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTitleYAxis.SetRCodeForControl("axis.title.y", clsYElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTitleYRightAxis.SetRCodeForControl("axis.title.y.right", clsYRightElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrLegendTitle.SetRCodeForControl("legend.title", clsElementLegendTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendText.SetRCodeForControl("legend.text", clsElementLegendText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendBackground.SetRCodeForControl("legend.background", clsElementLegendBackground, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendBoxBackground.SetRCodeForControl("legend.box.background", clsElementLegendBoxBackground, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendKey.SetRCodeForControl("legend.key", clsElementLegendtKey, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrLegendSpacing.SetRCodeForControl("legend.spacing", clsUnitLegendSpacing, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendSpacingXAxis.SetRCodeForControl("legend.spacing.x", clsUnitLegendSpacingXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendSpacingYAxis.SetRCodeForControl("legend.spacing.y", clsUnitLegendSpacingYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendBoxSpacing.SetRCodeForControl("legend.box.spacing", clsUnitLegendBoxSpacing, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPanelGridMajorXAxis.SetRCodeForControl("panel.grid.major.x", clsElementPanelGridMajorXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelGridMajorYAxis.SetRCodeForControl("panel.grid.major.y", clsElementPanelGridMajorYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelGridMinorXAxis.SetRCodeForControl("panel.grid.minor.x", clsElementPanelGridMinorXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelGridMinorYAxis.SetRCodeForControl("panel.grid.minor.y", clsElementPanelGridMinorYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPanelGrid.SetRCodeForControl("panel.grid", clsElementPanelGrid, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelGridMajor.SetRCodeForControl("panel.grid.major", clsElementPanelGridMajor, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelGridMinor.SetRCodeForControl("panel.grid.minor", clsElementPanelGridMinor, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelBackGround.SetRCodeForControl("panel.background", clsElementPanelBackGround, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelBorder.SetRCodeForControl("panel.border", clsElementBorder, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPlotBackground.SetRCodeForControl("plot.background", clsElementPlotBackground, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPlotCaption.SetRCodeForControl("plot.caption", clsElementPlotCaption, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPlotSubTitle.SetRCodeForControl("plot.subtitle", clsElementPlotSubtitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPlotTitle.SetRCodeForControl("plot.title", clsElementPlotTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrStripBackGround.SetRCodeForControl("strip.background", clsElementStripBackground, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrStripText.SetRCodeForControl("strip.text", clsElementStripText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrStripTextXAxis.SetRCodeForControl("strip.text.x", clsElementStripTextXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrStripTextYAxis.SetRCodeForControl("strip.text.y", clsElementStripTextYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrTickLength.SetRCodeForControl("axis.ticks.length", clsUnitAxisTickLength, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrLegendKeySize.SetRCodeForControl("legend.key.size", clsUnitLegendSize, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendKeyHeight.SetRCodeForControl("legend.key.height", clsUnitLegendHeight, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendKeyWidth.SetRCodeForControl("legend.key.width", clsUnitLegendWidth, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPanelSpacing.SetRCodeForControl("panel.spacing", clsUnitPanelSpacing, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelSpacingXAxis.SetRCodeForControl("panel.spacing.x", clsUnitPanelSpacingXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelSpacingYAxis.SetRCodeForControl("panel.spacing.y", clsUnitPanelSpacingYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrStripsSpaceGrid.SetRCodeForControl("strip.switch.pad.grid", clsUnitStripsGrid, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrStripsSpaceWrap.SetRCodeForControl("strip.switch.pad.wrap", clsUnitStripsWrap, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPlotMargin.SetRCodeForControl("plot.margin", clsUnitPlotMargin, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        urChkLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        ucrChkLegendBox.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendBox.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        urChkLegendBoxJust.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendBoxJust.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        ucrChkLegendDirection.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendDirection.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        ucrChkLegendJustification.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendJustification.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        AddRemoveElementParameters()
    End Sub

    Private Sub AddRemoveElementParameters()
        If ucrChkLegendBox.Checked Then
            clsThemeFunction.AddParameter("legend.box")
        Else
            clsThemeFunction.RemoveParameterByName("legend.box")
        End If

        If ucrChkLegendDirection.Checked Then
            clsThemeFunction.AddParameter("legend.direction")
        Else
            clsThemeFunction.RemoveParameterByName("legend.direction")
        End If

        If ucrChkLegendJustification.Checked Then
            clsThemeFunction.AddParameter("legend.justification")
        Else
            clsThemeFunction.RemoveParameterByName("legend.justification")
        End If

        If urChkLegendBoxJust.Checked Then
            clsThemeFunction.AddParameter("legend.box.just")
        Else
            clsThemeFunction.RemoveParameterByName("legend.box.just")
        End If

        If urChkLegendPosition.Checked Then
            clsThemeFunction.AddParameter("legend.position")
        Else
            clsThemeFunction.RemoveParameterByName("legend.position")
        End If

        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ElementLegendControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles urChkLegendPosition.ControlValueChanged, urChkLegendBoxJust.ControlValueChanged, ucrChkLegendJustification.ControlValueChanged, ucrChkLegendDirection.ControlValueChanged, ucrChkLegendBox.ControlValueChanged
        AddRemoveElementParameters()
    End Sub
End Class