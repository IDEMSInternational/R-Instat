Public Class clsThemeSubFunctions
    Public dctThemeFunctions As New Dictionary(Of String, RFunction)
    Public clsXElementText As New RFunction
    Public clsElementTickText As New RFunction
    Public clsXElementTitleText As New RFunction
    Public clsYElementText As New RFunction
    Public clsXTopElementText As New RFunction
    Public clsYRightElementText As New RFunction
    Public clsXElementTitle As New RFunction
    Public clsYElementTitle As New RFunction
    Public clsXTopElementTitle As New RFunction
    Public clsYRightElementTitle As New RFunction
    Public clsElementLegendText As New RFunction
    Public clsElementLegendTitle As New RFunction

    Public clsElementPlotTitle As New RFunction
    Public clsElementPlotSubtitle As New RFunction
    Public clsElementPlotCaption As New RFunction

    Public clsElementStripText As New RFunction
    Public clsElementStripTextXAxis As New RFunction
    Public clsElementStripTextYAxis As New RFunction

    Public clsXElementLine As New RFunction
    Public clsElementLineAxes As New RFunction
    Public clsYElementLine As New RFunction
    Public clsElementTickAxes As New RFunction
    Public clsElementTickXAxis As New RFunction
    Public clsElementTickYAxis As New RFunction
    Public clsElementLineXAxis As New RFunction
    Public clsElementLineYAxis As New RFunction

    Public clsElementLegendBackground As New RFunction
    Public clsElementLegendBoxBackground As New RFunction
    Public clsElementLegendtKey As New RFunction

    Public clsElementBorder As New RFunction
    Public clsElementPanelBackGround As New RFunction

    Public clsElementPlotBackground As New RFunction
    Public clsElementStripBackground As New RFunction

    Public clsElementPanelGrid As New RFunction
    Public clsElementPanelGridMajor As New RFunction
    Public clsElementPanelGridMinor As New RFunction
    Public clsElementPanelGridMajorXAxis As New RFunction
    Public clsElementPanelGridMajorYAxis As New RFunction
    Public clsElementPanelGridMinorXAxis As New RFunction
    Public clsElementPanelGridMinorYAxis As New RFunction

    Public clsUnitAxisTickLength As New RFunction
    Public clsUnitLegendSize As New RFunction
    Public clsUnitLegendHeight As New RFunction
    Public clsUnitLegendWidth As New RFunction
    Public clsUnitPanelSpacing As New RFunction
    Public clsUnitPanelSpacingXAxis As New RFunction
    Public clsUnitPanelSpacingYAxis As New RFunction
    Public clsUnitPlotMargin As New RFunction
    Public clsUnitStripsGrid As New RFunction
    Public clsUnitStripsWrap As New RFunction
    Public clsUnitLegendSpacing As New RFunction
    Public clsUnitLegendSpacingXAxis As New RFunction
    Public clsUnitLegendSpacingYAxis As New RFunction
    Public clsUnitLegendBoxSpacing As New RFunction

    Public Sub SetRCode(clsBaseOperator As ROperator, dctNewThemeFunctions As Dictionary(Of String, RFunction), Optional bReset As Boolean = False)

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
    End Sub

End Class
